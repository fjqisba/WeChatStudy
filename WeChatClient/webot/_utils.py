import platform
import winreg
from enum import IntEnum,unique
import win32process
import win32api
import win32event
import ctypes
import numpy
import pefile


@unique
class wechat_ver(IntEnum):
    ver_unknown = 0
    ver_3_7_6_44 = 0x6307062c
    ver_3_8_0_33 = 0x63080021


def formatVersion(ver:wechat_ver):
    '''格式化版本号'''
    if wechat_ver == ver.ver_unknown:
        return ""
    majorVer = ((ver >> 0x18) - 0x60) % 0x63
    minorVer = ((ver >> 0x10) & 0xF) % 0x63
    revisionVer = (ver >> 0x8) & 0xF
    buildVer = (ver & 0xFF) % 9999
    formatStr = str.format("{0}.{1}.{2}.{3}",majorVer,minorVer,revisionVer,buildVer)
    return formatStr


def getWeChatInstallPath():
    '''获取微信安装路径'''
    retPath = ""
    try:
        hKey = winreg.OpenKey(winreg.HKEY_CURRENT_USER,"Software\\Tencent\\WeChat")
        retPath = winreg.QueryValueEx(hKey,"InstallPath")[0]
        winreg.CloseKey(hKey)
    except:
        pass
    return retPath

def switchCaseVersion(ver:int):
    if ver == 0x6307062c:
        return wechat_ver.ver_3_7_6_44
    if ver == 0x63080021:
        return wechat_ver.ver_3_8_0_33
    return wechat_ver.ver_unknown

def getWeChatVersion():
    '''获取微信版本'''
    retVer = wechat_ver.ver_unknown
    try:
        hKey = winreg.OpenKey(winreg.HKEY_CURRENT_USER,"Software\\Tencent\\WeChat")
        retVer = winreg.QueryValueEx(hKey,"Version")[0]
        winreg.CloseKey(hKey)
        retVer = switchCaseVersion(retVer)
    except:
        pass
    return retVer

def getLoadLibraryOffset(exePath:str):
    funcName = "LoadLibraryW".encode("ascii")
    pe = pefile.PE(exePath)
    dllList = pe.DIRECTORY_ENTRY_IMPORT[0]
    for eFunc in dllList.imports:
        if eFunc.name == funcName:
            return eFunc.address - 0x400000
    return -1


def injectDll_py64(exePath:str,dllPath:str,port:int):
    si = win32process.STARTUPINFO()
    hProcData = win32process.CreateProcess(exePath, str(port), None, None, False,
                                           win32process.CREATE_SUSPENDED, None, None, si)
    k32 = ctypes.windll.kernel32
    shellcodeAddr = k32.VirtualAllocEx(hProcData[0].__int__(), 0, 0x1000, 0x101000, 0x40)

    #组装shellcode
    shellcode = bytearray(b"\x64\xA1\x30\x00\x00\x00\x8B\x40\x08\xFF\xA0")
    fLoadLibrary = numpy.uint32(getLoadLibraryOffset(exePath))
    shellcode.append(fLoadLibrary & 0xFF)
    shellcode.append((fLoadLibrary >> 0x8) & 0xFF)
    shellcode.append((fLoadLibrary >> 0x10) & 0xFF)
    shellcode.append((fLoadLibrary >> 0x18) & 0xFF)
    shellcode = bytes(shellcode) + dllPath.encode("utf-16-le")
    bytesWritten = ctypes.c_int(0)
    k32.WriteProcessMemory(hProcData[0].__int__(), shellcodeAddr, shellcode, len(shellcode),
                           ctypes.byref(bytesWritten))
    shellcodeAddr = numpy.uint32(shellcodeAddr)
    remoteData = win32process.CreateRemoteThread(hProcData[0], None, 0, shellcodeAddr, shellcodeAddr + 15, 0)
    win32event.WaitForSingleObject(remoteData[0], -1)

    #恢复线程
    win32process.ResumeThread(hProcData[1])
    win32api.CloseHandle(hProcData[0])
    win32api.CloseHandle(hProcData[1])
    return


def injectDll(exePath:str,dllPath:str,port:int):

    arch = platform.architecture()[0]
    if arch == '64bit':
        return injectDll_py64(exePath,dllPath,port)

    #32位
    si = win32process.STARTUPINFO()
    hProcData = win32process.CreateProcess(exePath, str(port), None, None, False,
                                           win32process.CREATE_SUSPENDED, None, None, si)

    #写入dll路径
    k32 = ctypes.windll.kernel32
    loadDllPath = k32.VirtualAllocEx(hProcData[0].__int__(), 0, 0x1000, 0x101000, 0x40)
    bytesWritten = ctypes.c_int(0)
    k32.WriteProcessMemory(hProcData[0].__int__(), loadDllPath, dllPath.encode("utf-8"), len(dllPath),
                           ctypes.byref(bytesWritten))

    fLoadLibrary = win32api.GetProcAddress(win32api.GetModuleHandle('kernel32.dll'), 'LoadLibraryA')
    remoteData = win32process.CreateRemoteThread(hProcData[0], None, 0, fLoadLibrary, loadDllPath, 0)

    win32event.WaitForSingleObject(remoteData[0], -1)

    # 恢复线程
    win32process.ResumeThread(hProcData[1])
    win32api.CloseHandle(hProcData[0])
    win32api.CloseHandle(hProcData[1])
    return

import json

import requests

from . import _utils
import win32api
import win32process
import os

class webot:
    def __init__(self,port):
        self.wechat_path = ""
        self.wechat_ver = 0
        self.wechat_verStr = ""
        self.port = port
        self.host = "127.0.0.1"
        self.__init_bot()
        self.__create_wechat()
        return

    def __init_bot(self):
        self.wechat_path = _utils.getWeChatInstallPath()
        self.wechat_ver = _utils.getWeChatVersion()
        if self.wechat_ver == _utils.wechat_ver.ver_unknown:
            raise Exception("不支持的微信版本", self.wechat_ver)
        self.wechat_verStr = _utils.formatVersion(self.wechat_ver)
        return

    def __create_wechat(self):
        exePath = self.wechat_path + "\\[" + self.wechat_verStr + "]\\WeChat.exe"
        dllPath = self.wechat_path + "\\[" + self.wechat_verStr + "]\\WeChatDLL.dll"
        if not os.path.isfile(exePath):
            raise Exception("未找到WeChat.exe", exePath)
        if not os.path.isfile(dllPath):
            raise Exception("未找到核心DLL文件", dllPath)
        _utils.injectDll(exePath,dllPath,self.port)
        return

    def sync_msg(self):
        '''同步微信消息'''
        url = str.format("http://{0}:{1}/syncMsg", self.host, self.port)
        resp = requests.get(url)
        retJson = json.loads(resp.text)
        if retJson["code"] == 200:
            return retJson["data"]
        return retJson["msg"]

    def get_login_qrcode(self):
        url = str.format("http://{0}:{1}/getLoginQRCode",self.host,self.port)
        resp = requests.get(url,timeout=None)
        retJson = json.loads(resp.text)
        if retJson["code"] == 200:
            return retJson["qrcode"]
        return ""
    def wait_util_login(self):
        '''等待用户登录'''
        url = str.format("http://{0}:{1}/waitForLogin",self.host,self.port)
        resp = requests.get(url,timeout=None)
        retJson = json.loads(resp.text)
        if retJson["code"] == 200:
            return retJson["wxid"]
        return ""
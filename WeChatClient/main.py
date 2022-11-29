import base64
import time
import webbrowser

import qrcode
import webot
import requests

#给大家做个示例吧
def testDemo():

    #启动微信,需要填入一个端口
    wechat = webot.new_bot(1234)

    #等待加载微信二维码
    time.sleep(3)

    #获取登录二维码
    qrcodeStr = wechat.get_login_qrcode()
    if qrcodeStr != "":
        print("成功获取微信登录二维码:",qrcodeStr)

    #等待扫码登录
    userWxid = wechat.wait_util_login()
    print("登录成功",userWxid)
    while True:
        msgList = wechat.sync_msg()
        print(msgList)
        time.sleep(3)
        pass
    return

if __name__ == '__main__':
    testDemo()


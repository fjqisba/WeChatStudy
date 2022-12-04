import time
import webot

def handleMsg(wechat,eMsg):
    msgType = eMsg["msg_type"]
    if msgType == 20000:
        print("获取登录二维码:",eMsg["qrcode"])
        return
    if msgType == 20001:
        print("登录成功:",eMsg)
        return
    if msgType == 20010:
        print("群聊成员增加:",eMsg)
        return
    if msgType == 20011:
        print("群聊成员减少:",eMsg)
        return

#给大家做个简单的示例吧
def testDemo():

    #启动微信,需要填入一个端口
    wechat = webot.new_bot(5000)
    while True:
        time.sleep(3)
        msgList = wechat.sync_msg()
        if msgList == None:
            continue
        for eMsg in msgList:
            handleMsg(wechat,eMsg)
        continue
    return

if __name__ == '__main__':
    testDemo()


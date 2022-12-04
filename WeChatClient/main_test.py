import requests


def test_SendText():
    data = {"to_wxid":"filehelper","msg":"test哈哈"}
    resp = requests.post("http://127.0.0.1:5000/sendTextMsg",json=data)
    print(resp.text)

def test_syncSns():
    resp = requests.get("http://127.0.0.1:5000/syncSns")
    print(resp.text)

def test_getContanct():
    contactList = []
    contactList.append("filehelper")
    resp = requests.post("http://127.0.0.1:5000/getContactInfo", json=contactList)
    print(resp.text)

def test_syncMsg():
    resp = requests.get("http://127.0.0.1:5000/syncMsg")
    print(resp.text)

def test_getContactList():
    resp = requests.get("http://127.0.0.1:5000/getContactList")
    print(resp.text)
def test_sendTextMsgEx():
    data = {"to_wxid": "12346755172@chatroom"}
    msgList = []
    msgList.append({"atUser":"wxid_6axcd25watzn92"})
    msgList.append({"msg":"你是笨蛋"})
    data["msg_list"] = msgList
    resp = requests.post("http://127.0.0.1:5000/sendTextMsgEx", json=data)
    print(resp.text)

test_syncMsg()
exit(0)
test_sendTextMsgEx()
test_SendText()
test_getContanct()
test_syncSns()

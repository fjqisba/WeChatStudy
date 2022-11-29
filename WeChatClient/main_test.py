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

test_syncMsg()
exit(0)
test_SendText()
test_getContanct()
test_syncSns()

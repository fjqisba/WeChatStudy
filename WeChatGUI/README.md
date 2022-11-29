## 微信自动更新

微信首先会从WeChatWin.dll中读出版本号，存在到一个全局变量中。

UpdateMgr里面存着一个要更新的微信地址，和全局变量进行对比来判断是否要更新。

## 微信多开(已完成)

关键字，_WeChat_App_Instance_Identity_Mutex_Name

## 登录流程

获取当前登录的wxid，AccountService::login。

LoginWnd::eventProc -> LoginWnd::qrCodeScaned

授权成功之后的回调

NetSceneManualAuth::doManualAuthSuccess

## 判断微信主窗口是否加载

关键字符串MainWnd has been launched

## 微信二维码监听

LoginWnd::eventProc，消息id为0x300，获取到二维码。







## 消息监控

消息类型

```
1 = 文本消息
3 = 图片消息
37 = 好友请求
42 = 名片消息
47 = 表情消息
49 = 应用消息
51 = op消息
10000 = 系统消息
10002 = 系统消息
```

先是SyncMgr::doAddMsg，解析micromsg::AddMsg，转换成ChatMsg。

然后是SyncMgr::addMsgListToDB，将ChatMsg添加到数据库中。

### 图片消息监控

NetSceneGetMsgImgCDN::onDownloadSuccessed



### 群邀请消息监控

新成员被邀请入群后，先是SyncMgr，来一条 xxx 被 xxx 邀请入群的文本消息，但是这里面只有昵称。

然后又是SyncMgr，来一条群所有成员wxid的信息。

之后是ChatRoomMgr::syncAddChatroomMember，对比多出来的新wxid，准备开始同步新增群成员，发送protoReq，GetChatroomMemberDetail，能拿到新增群成员的wxid，以及到底是被谁邀请的。

NetSceneGetChatroomMemberDetail::onGYNetEnd



我将A邀请入群：消息类型10002，特殊消息sysmsg(能拿到被邀请的人的wxid)

我将A移出群：消息类型10000，你将"xxx"移出了群聊(拿不到被踢的人wxid)

我被A邀请入群：消息类型10000，"xxx"邀请你加入了群聊，群聊参与人还有：a、b、c

我被A移出群：消息类型10000，你被"xxx"移出群聊

A被B邀请入群：消息类型10000，"xxx"邀请"yyy"加入了群聊

A被B移出群，SyncMgr无感知。



## 消息发送

### 文本消息发送(已经完成)

首先在ExtendChatView某个类函数中读取要发送的消息列表，之后调用ChatViewModel::batchSendMsg批量发送消息，最终走的是SendMessageMgr。

```
ExtendChatView::sub_some ->  ChatViewModel::batchSendMsg -> SendMessageMgr::sendMsg
{
	SendMessageMgr::sendTextMsg
	SendMessageMgr::sendImageMsg
}
```

### 自定义表情发送

```
ExtendChatView::sub_some -> CustomSmileyMgr::sendCustomEmotion
```

EmotionStorage::getEmtionByMd5

### 图片发送

### 发送文件

ExtendChatView::sub_xxx -> ChatViewModel::batchSendMsg -> AppMsgMgr::sendFile



## 微信通讯录

FavoriteMgr::init，在这个地方会将ContactMgr赋值给一个全局变量，这个就是gContactMgr。

ContactMgr::InitStorage，账号登录后初始化存储。

ContactMgr::getList，获取内存中的通讯录列表。

ContactMgr::getContact，获取内存中的通讯录信息。

ContactStorage，存储通讯录相关，数据库封装。



## 朋友圈

## 视频号

CefBrowserCore::OnGetA8KeySuccess -> CefBrowserCore::NavigateToUrl



## 结构体逆向

1、原生结构体非必要不定义析构函数

因为无法确定结构体是函数体内析构还是体外析构，因此不能进行定义析构函数。把结构体当成有名字的buffer就好了。








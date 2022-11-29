namespace micromsg
{
    using Google.ProtocolBuffers;
   
    using System;
    using System.IO;
    

    
    public sealed class NewAuthResponse : GeneratedMessageLite<NewAuthResponse, NewAuthResponse.Builder>
    {
        private static readonly string[] _NewAuthResponseFieldNames = new string[] { 
            "A2Key", "Alias", "ApplyBetaUrl", "AuthKey", "AuthTicket", "AutoAuthTicket", "BaseResponse", "BindEmail", "BindMobile", "BindUin", "BuiltinIPList", "DeviceInfoXml", "DnsInfo", "FSURL", "HintMsg", "ImgBuf", 
            "ImgEncryptKey", "ImgSid", "IsAutoReg", "KSid", "KickResponse", "MainAcctType", "NeedSetEmailPwd", "NetworkControl", "NewHostList", "NewVersion", "NickName", "OfficialNickName", "OfficialUserName", "Password", "PluginFlag", "PluginKeyList", 
            "ProfileFlag", "PushMailSettingTicket", "PushMailStatus", "QQMicroBlogStatus", "QQMicroBlogUserName", "RegType", "SafeDevice", "SendCardBitFlag", "SessionKey", "Sid", "SoftConfigXml", "Status", "Ticket", "TimeStamp", "Uin", "UserName"
         };
        private static readonly uint[] _NewAuthResponseFieldTags = new uint[] { 
            250, 0xca, 0x132, 0xda, 0x152, 0x17a, 10, 50, 0x3a, 40, 170, 0x13a, 0x182, 0xb2, 370, 90, 
            0xf2, 0x52, 0x120, 0x102, 0x12a, 0x160, 360, 0xba, 330, 0x80, 0x22, 0x6a, 0x62, 0x112, 0xc0, 0xea, 
            0x108, 0xa2, 0x90, 120, 0x72, 0xd0, 0x158, 0x98, 0x4a, 0xe2, 0x142, 0x40, 0x8a, 280, 0x10, 0x1a
         };
        private SKBuiltinBuffer_t a2Key_;
        public const int A2KeyFieldNumber = 0x1f;
        private string alias_ = "";
        public const int AliasFieldNumber = 0x19;
        private string applyBetaUrl_ = "";
        public const int ApplyBetaUrlFieldNumber = 0x26;
        private string authKey_ = "";
        public const int AuthKeyFieldNumber = 0x1b;
        private string authTicket_ = "";
        public const int AuthTicketFieldNumber = 0x2a;
        private string autoAuthTicket_ = "";
        public const int AutoAuthTicketFieldNumber = 0x2f;
        private micromsg.BaseResponse baseResponse_;
        public const int BaseResponseFieldNumber = 1;
        private SKBuiltinString_t bindEmail_;
        public const int BindEmailFieldNumber = 6;
        private SKBuiltinString_t bindMobile_;
        public const int BindMobileFieldNumber = 7;
        private uint bindUin_;
        public const int BindUinFieldNumber = 5;
        private micromsg.BuiltinIPList builtinIPList_;
        public const int BuiltinIPListFieldNumber = 0x15;
        private static readonly NewAuthResponse defaultInstance = new NewAuthResponse().MakeReadOnly();
        private string deviceInfoXml_ = "";
        public const int DeviceInfoXmlFieldNumber = 0x27;
        private CDNDnsInfo dnsInfo_;
        public const int DnsInfoFieldNumber = 0x30;
        private string fSURL_ = "";
        public const int FSURLFieldNumber = 0x16;
        private bool hasA2Key;
        private bool hasAlias;
        private bool hasApplyBetaUrl;
        private bool hasAuthKey;
        private bool hasAuthTicket;
        private bool hasAutoAuthTicket;
        private bool hasBaseResponse;
        private bool hasBindEmail;
        private bool hasBindMobile;
        private bool hasBindUin;
        private bool hasBuiltinIPList;
        private bool hasDeviceInfoXml;
        private bool hasDnsInfo;
        private bool hasFSURL;
        private bool hasHintMsg;
        private bool hasImgBuf;
        private bool hasImgEncryptKey;
        private bool hasImgSid;
        private bool hasIsAutoReg;
        private bool hasKickResponse;
        private bool hasKSid;
        private bool hasMainAcctType;
        private bool hasNeedSetEmailPwd;
        private bool hasNetworkControl;
        private bool hasNewHostList;
        private bool hasNewVersion;
        private bool hasNickName;
        private bool hasOfficialNickName;
        private bool hasOfficialUserName;
        private bool hasPassword;
        private bool hasPluginFlag;
        private bool hasPluginKeyList;
        private bool hasProfileFlag;
        private bool hasPushMailSettingTicket;
        private bool hasPushMailStatus;
        private bool hasQQMicroBlogStatus;
        private bool hasQQMicroBlogUserName;
        private bool hasRegType;
        private bool hasSafeDevice;
        private bool hasSendCardBitFlag;
        private bool hasSessionKey;
        private bool hasSid;
        private bool hasSoftConfigXml;
        private bool hasStatus;
        private bool hasTicket;
        private bool hasTimeStamp;
        private bool hasUin;
        private bool hasUserName;
        private string hintMsg_ = "";
        public const int HintMsgFieldNumber = 0x2e;
        private SKBuiltinBuffer_t imgBuf_;
        public const int ImgBufFieldNumber = 11;
        private SKBuiltinString_t imgEncryptKey_;
        public const int ImgEncryptKeyFieldNumber = 30;
        private SKBuiltinString_t imgSid_;
        public const int ImgSidFieldNumber = 10;
        private uint isAutoReg_;
        public const int IsAutoRegFieldNumber = 0x24;
        private string kickResponse_ = "";
        public const int KickResponseFieldNumber = 0x25;
        private SKBuiltinBuffer_t kSid_;
        public const int KSidFieldNumber = 0x20;
        private uint mainAcctType_;
        public const int MainAcctTypeFieldNumber = 0x2c;
        private int memoizedSerializedSize = -1;
        private uint needSetEmailPwd_;
        public const int NeedSetEmailPwdFieldNumber = 0x2d;
        private micromsg.NetworkControl networkControl_;
        public const int NetworkControlFieldNumber = 0x17;
        private HostList newHostList_;
        public const int NewHostListFieldNumber = 0x29;
        private uint newVersion_;
        public const int NewVersionFieldNumber = 0x10;
        private SKBuiltinString_t nickName_;
        public const int NickNameFieldNumber = 4;
        private SKBuiltinString_t officialNickName_;
        public const int OfficialNickNameFieldNumber = 13;
        private SKBuiltinString_t officialUserName_;
        public const int OfficialUserNameFieldNumber = 12;
        private string password_ = "";
        public const int PasswordFieldNumber = 0x22;
        private uint pluginFlag_;
        public const int PluginFlagFieldNumber = 0x18;
        private micromsg.PluginKeyList pluginKeyList_;
        public const int PluginKeyListFieldNumber = 0x1d;
        private uint profileFlag_;
        public const int ProfileFlagFieldNumber = 0x21;
        private string pushMailSettingTicket_ = "";
        public const int PushMailSettingTicketFieldNumber = 20;
        private uint pushMailStatus_;
        public const int PushMailStatusFieldNumber = 0x12;
        private uint qQMicroBlogStatus_;
        public const int QQMicroBlogStatusFieldNumber = 15;
        private SKBuiltinString_t qQMicroBlogUserName_;
        public const int QQMicroBlogUserNameFieldNumber = 14;
        private uint regType_;
        public const int RegTypeFieldNumber = 0x1a;
        private uint safeDevice_;
        public const int SafeDeviceFieldNumber = 0x2b;
        private uint sendCardBitFlag_;
        public const int SendCardBitFlagFieldNumber = 0x13;
        private ByteString sessionKey_ = ByteString.Empty;
        public const int SessionKeyFieldNumber = 9;
        private string sid_ = "";
        public const int SidFieldNumber = 0x1c;
        private string softConfigXml_ = "";
        public const int SoftConfigXmlFieldNumber = 40;
        private uint status_;
        public const int StatusFieldNumber = 8;
        private string ticket_ = "";
        public const int TicketFieldNumber = 0x11;
        private uint timeStamp_;
        public const int TimeStampFieldNumber = 0x23;
        private uint uin_;
        public const int UinFieldNumber = 2;
        private SKBuiltinString_t userName_;
        public const int UserNameFieldNumber = 3;

        static NewAuthResponse()
        {
           // object.ReferenceEquals(NewAuthResponse.Descriptor, null);
        }

        private NewAuthResponse()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(NewAuthResponse prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            NewAuthResponse response = obj as NewAuthResponse;
            if (response == null)
            {
                return false;
            }
            if ((this.hasBaseResponse != response.hasBaseResponse) || (this.hasBaseResponse && !this.baseResponse_.Equals(response.baseResponse_)))
            {
                return false;
            }
            if ((this.hasUin != response.hasUin) || (this.hasUin && !this.uin_.Equals(response.uin_)))
            {
                return false;
            }
            if ((this.hasUserName != response.hasUserName) || (this.hasUserName && !this.userName_.Equals(response.userName_)))
            {
                return false;
            }
            if ((this.hasNickName != response.hasNickName) || (this.hasNickName && !this.nickName_.Equals(response.nickName_)))
            {
                return false;
            }
            if ((this.hasBindUin != response.hasBindUin) || (this.hasBindUin && !this.bindUin_.Equals(response.bindUin_)))
            {
                return false;
            }
            if ((this.hasBindEmail != response.hasBindEmail) || (this.hasBindEmail && !this.bindEmail_.Equals(response.bindEmail_)))
            {
                return false;
            }
            if ((this.hasBindMobile != response.hasBindMobile) || (this.hasBindMobile && !this.bindMobile_.Equals(response.bindMobile_)))
            {
                return false;
            }
            if ((this.hasStatus != response.hasStatus) || (this.hasStatus && !this.status_.Equals(response.status_)))
            {
                return false;
            }
            if ((this.hasSessionKey != response.hasSessionKey) || (this.hasSessionKey && !this.sessionKey_.Equals(response.sessionKey_)))
            {
                return false;
            }
            if ((this.hasImgSid != response.hasImgSid) || (this.hasImgSid && !this.imgSid_.Equals(response.imgSid_)))
            {
                return false;
            }
            if ((this.hasImgBuf != response.hasImgBuf) || (this.hasImgBuf && !this.imgBuf_.Equals(response.imgBuf_)))
            {
                return false;
            }
            if ((this.hasOfficialUserName != response.hasOfficialUserName) || (this.hasOfficialUserName && !this.officialUserName_.Equals(response.officialUserName_)))
            {
                return false;
            }
            if ((this.hasOfficialNickName != response.hasOfficialNickName) || (this.hasOfficialNickName && !this.officialNickName_.Equals(response.officialNickName_)))
            {
                return false;
            }
            if ((this.hasQQMicroBlogUserName != response.hasQQMicroBlogUserName) || (this.hasQQMicroBlogUserName && !this.qQMicroBlogUserName_.Equals(response.qQMicroBlogUserName_)))
            {
                return false;
            }
            if ((this.hasQQMicroBlogStatus != response.hasQQMicroBlogStatus) || (this.hasQQMicroBlogStatus && !this.qQMicroBlogStatus_.Equals(response.qQMicroBlogStatus_)))
            {
                return false;
            }
            if ((this.hasNewVersion != response.hasNewVersion) || (this.hasNewVersion && !this.newVersion_.Equals(response.newVersion_)))
            {
                return false;
            }
            if ((this.hasTicket != response.hasTicket) || (this.hasTicket && !this.ticket_.Equals(response.ticket_)))
            {
                return false;
            }
            if ((this.hasPushMailStatus != response.hasPushMailStatus) || (this.hasPushMailStatus && !this.pushMailStatus_.Equals(response.pushMailStatus_)))
            {
                return false;
            }
            if ((this.hasSendCardBitFlag != response.hasSendCardBitFlag) || (this.hasSendCardBitFlag && !this.sendCardBitFlag_.Equals(response.sendCardBitFlag_)))
            {
                return false;
            }
            if ((this.hasPushMailSettingTicket != response.hasPushMailSettingTicket) || (this.hasPushMailSettingTicket && !this.pushMailSettingTicket_.Equals(response.pushMailSettingTicket_)))
            {
                return false;
            }
            if ((this.hasBuiltinIPList != response.hasBuiltinIPList) || (this.hasBuiltinIPList && !this.builtinIPList_.Equals(response.builtinIPList_)))
            {
                return false;
            }
            if ((this.hasFSURL != response.hasFSURL) || (this.hasFSURL && !this.fSURL_.Equals(response.fSURL_)))
            {
                return false;
            }
            if ((this.hasNetworkControl != response.hasNetworkControl) || (this.hasNetworkControl && !this.networkControl_.Equals(response.networkControl_)))
            {
                return false;
            }
            if ((this.hasPluginFlag != response.hasPluginFlag) || (this.hasPluginFlag && !this.pluginFlag_.Equals(response.pluginFlag_)))
            {
                return false;
            }
            if ((this.hasAlias != response.hasAlias) || (this.hasAlias && !this.alias_.Equals(response.alias_)))
            {
                return false;
            }
            if ((this.hasRegType != response.hasRegType) || (this.hasRegType && !this.regType_.Equals(response.regType_)))
            {
                return false;
            }
            if ((this.hasAuthKey != response.hasAuthKey) || (this.hasAuthKey && !this.authKey_.Equals(response.authKey_)))
            {
                return false;
            }
            if ((this.hasSid != response.hasSid) || (this.hasSid && !this.sid_.Equals(response.sid_)))
            {
                return false;
            }
            if ((this.hasPluginKeyList != response.hasPluginKeyList) || (this.hasPluginKeyList && !this.pluginKeyList_.Equals(response.pluginKeyList_)))
            {
                return false;
            }
            if ((this.hasImgEncryptKey != response.hasImgEncryptKey) || (this.hasImgEncryptKey && !this.imgEncryptKey_.Equals(response.imgEncryptKey_)))
            {
                return false;
            }
            if ((this.hasA2Key != response.hasA2Key) || (this.hasA2Key && !this.a2Key_.Equals(response.a2Key_)))
            {
                return false;
            }
            if ((this.hasKSid != response.hasKSid) || (this.hasKSid && !this.kSid_.Equals(response.kSid_)))
            {
                return false;
            }
            if ((this.hasProfileFlag != response.hasProfileFlag) || (this.hasProfileFlag && !this.profileFlag_.Equals(response.profileFlag_)))
            {
                return false;
            }
            if ((this.hasPassword != response.hasPassword) || (this.hasPassword && !this.password_.Equals(response.password_)))
            {
                return false;
            }
            if ((this.hasTimeStamp != response.hasTimeStamp) || (this.hasTimeStamp && !this.timeStamp_.Equals(response.timeStamp_)))
            {
                return false;
            }
            if ((this.hasIsAutoReg != response.hasIsAutoReg) || (this.hasIsAutoReg && !this.isAutoReg_.Equals(response.isAutoReg_)))
            {
                return false;
            }
            if ((this.hasKickResponse != response.hasKickResponse) || (this.hasKickResponse && !this.kickResponse_.Equals(response.kickResponse_)))
            {
                return false;
            }
            if ((this.hasApplyBetaUrl != response.hasApplyBetaUrl) || (this.hasApplyBetaUrl && !this.applyBetaUrl_.Equals(response.applyBetaUrl_)))
            {
                return false;
            }
            if ((this.hasDeviceInfoXml != response.hasDeviceInfoXml) || (this.hasDeviceInfoXml && !this.deviceInfoXml_.Equals(response.deviceInfoXml_)))
            {
                return false;
            }
            if ((this.hasSoftConfigXml != response.hasSoftConfigXml) || (this.hasSoftConfigXml && !this.softConfigXml_.Equals(response.softConfigXml_)))
            {
                return false;
            }
            if ((this.hasNewHostList != response.hasNewHostList) || (this.hasNewHostList && !this.newHostList_.Equals(response.newHostList_)))
            {
                return false;
            }
            if ((this.hasAuthTicket != response.hasAuthTicket) || (this.hasAuthTicket && !this.authTicket_.Equals(response.authTicket_)))
            {
                return false;
            }
            if ((this.hasSafeDevice != response.hasSafeDevice) || (this.hasSafeDevice && !this.safeDevice_.Equals(response.safeDevice_)))
            {
                return false;
            }
            if ((this.hasMainAcctType != response.hasMainAcctType) || (this.hasMainAcctType && !this.mainAcctType_.Equals(response.mainAcctType_)))
            {
                return false;
            }
            if ((this.hasNeedSetEmailPwd != response.hasNeedSetEmailPwd) || (this.hasNeedSetEmailPwd && !this.needSetEmailPwd_.Equals(response.needSetEmailPwd_)))
            {
                return false;
            }
            if ((this.hasHintMsg != response.hasHintMsg) || (this.hasHintMsg && !this.hintMsg_.Equals(response.hintMsg_)))
            {
                return false;
            }
            if ((this.hasAutoAuthTicket != response.hasAutoAuthTicket) || (this.hasAutoAuthTicket && !this.autoAuthTicket_.Equals(response.autoAuthTicket_)))
            {
                return false;
            }
            return ((this.hasDnsInfo == response.hasDnsInfo) && (!this.hasDnsInfo || this.dnsInfo_.Equals(response.dnsInfo_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasBaseResponse)
            {
                hashCode ^= this.baseResponse_.GetHashCode();
            }
            if (this.hasUin)
            {
                hashCode ^= this.uin_.GetHashCode();
            }
            if (this.hasUserName)
            {
                hashCode ^= this.userName_.GetHashCode();
            }
            if (this.hasNickName)
            {
                hashCode ^= this.nickName_.GetHashCode();
            }
            if (this.hasBindUin)
            {
                hashCode ^= this.bindUin_.GetHashCode();
            }
            if (this.hasBindEmail)
            {
                hashCode ^= this.bindEmail_.GetHashCode();
            }
            if (this.hasBindMobile)
            {
                hashCode ^= this.bindMobile_.GetHashCode();
            }
            if (this.hasStatus)
            {
                hashCode ^= this.status_.GetHashCode();
            }
            if (this.hasSessionKey)
            {
                hashCode ^= this.sessionKey_.GetHashCode();
            }
            if (this.hasImgSid)
            {
                hashCode ^= this.imgSid_.GetHashCode();
            }
            if (this.hasImgBuf)
            {
                hashCode ^= this.imgBuf_.GetHashCode();
            }
            if (this.hasOfficialUserName)
            {
                hashCode ^= this.officialUserName_.GetHashCode();
            }
            if (this.hasOfficialNickName)
            {
                hashCode ^= this.officialNickName_.GetHashCode();
            }
            if (this.hasQQMicroBlogUserName)
            {
                hashCode ^= this.qQMicroBlogUserName_.GetHashCode();
            }
            if (this.hasQQMicroBlogStatus)
            {
                hashCode ^= this.qQMicroBlogStatus_.GetHashCode();
            }
            if (this.hasNewVersion)
            {
                hashCode ^= this.newVersion_.GetHashCode();
            }
            if (this.hasTicket)
            {
                hashCode ^= this.ticket_.GetHashCode();
            }
            if (this.hasPushMailStatus)
            {
                hashCode ^= this.pushMailStatus_.GetHashCode();
            }
            if (this.hasSendCardBitFlag)
            {
                hashCode ^= this.sendCardBitFlag_.GetHashCode();
            }
            if (this.hasPushMailSettingTicket)
            {
                hashCode ^= this.pushMailSettingTicket_.GetHashCode();
            }
            if (this.hasBuiltinIPList)
            {
                hashCode ^= this.builtinIPList_.GetHashCode();
            }
            if (this.hasFSURL)
            {
                hashCode ^= this.fSURL_.GetHashCode();
            }
            if (this.hasNetworkControl)
            {
                hashCode ^= this.networkControl_.GetHashCode();
            }
            if (this.hasPluginFlag)
            {
                hashCode ^= this.pluginFlag_.GetHashCode();
            }
            if (this.hasAlias)
            {
                hashCode ^= this.alias_.GetHashCode();
            }
            if (this.hasRegType)
            {
                hashCode ^= this.regType_.GetHashCode();
            }
            if (this.hasAuthKey)
            {
                hashCode ^= this.authKey_.GetHashCode();
            }
            if (this.hasSid)
            {
                hashCode ^= this.sid_.GetHashCode();
            }
            if (this.hasPluginKeyList)
            {
                hashCode ^= this.pluginKeyList_.GetHashCode();
            }
            if (this.hasImgEncryptKey)
            {
                hashCode ^= this.imgEncryptKey_.GetHashCode();
            }
            if (this.hasA2Key)
            {
                hashCode ^= this.a2Key_.GetHashCode();
            }
            if (this.hasKSid)
            {
                hashCode ^= this.kSid_.GetHashCode();
            }
            if (this.hasProfileFlag)
            {
                hashCode ^= this.profileFlag_.GetHashCode();
            }
            if (this.hasPassword)
            {
                hashCode ^= this.password_.GetHashCode();
            }
            if (this.hasTimeStamp)
            {
                hashCode ^= this.timeStamp_.GetHashCode();
            }
            if (this.hasIsAutoReg)
            {
                hashCode ^= this.isAutoReg_.GetHashCode();
            }
            if (this.hasKickResponse)
            {
                hashCode ^= this.kickResponse_.GetHashCode();
            }
            if (this.hasApplyBetaUrl)
            {
                hashCode ^= this.applyBetaUrl_.GetHashCode();
            }
            if (this.hasDeviceInfoXml)
            {
                hashCode ^= this.deviceInfoXml_.GetHashCode();
            }
            if (this.hasSoftConfigXml)
            {
                hashCode ^= this.softConfigXml_.GetHashCode();
            }
            if (this.hasNewHostList)
            {
                hashCode ^= this.newHostList_.GetHashCode();
            }
            if (this.hasAuthTicket)
            {
                hashCode ^= this.authTicket_.GetHashCode();
            }
            if (this.hasSafeDevice)
            {
                hashCode ^= this.safeDevice_.GetHashCode();
            }
            if (this.hasMainAcctType)
            {
                hashCode ^= this.mainAcctType_.GetHashCode();
            }
            if (this.hasNeedSetEmailPwd)
            {
                hashCode ^= this.needSetEmailPwd_.GetHashCode();
            }
            if (this.hasHintMsg)
            {
                hashCode ^= this.hintMsg_.GetHashCode();
            }
            if (this.hasAutoAuthTicket)
            {
                hashCode ^= this.autoAuthTicket_.GetHashCode();
            }
            if (this.hasDnsInfo)
            {
                hashCode ^= this.dnsInfo_.GetHashCode();
            }
            return hashCode;
        }

        private NewAuthResponse MakeReadOnly()
        {
            return this;
        }

        public static NewAuthResponse ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<NewAuthResponse, Builder>.PrintField("BaseResponse", this.hasBaseResponse, this.baseResponse_, writer);
            GeneratedMessageLite<NewAuthResponse, Builder>.PrintField("Uin", this.hasUin, this.uin_, writer);
            GeneratedMessageLite<NewAuthResponse, Builder>.PrintField("UserName", this.hasUserName, this.userName_, writer);
            GeneratedMessageLite<NewAuthResponse, Builder>.PrintField("NickName", this.hasNickName, this.nickName_, writer);
            GeneratedMessageLite<NewAuthResponse, Builder>.PrintField("BindUin", this.hasBindUin, this.bindUin_, writer);
            GeneratedMessageLite<NewAuthResponse, Builder>.PrintField("BindEmail", this.hasBindEmail, this.bindEmail_, writer);
            GeneratedMessageLite<NewAuthResponse, Builder>.PrintField("BindMobile", this.hasBindMobile, this.bindMobile_, writer);
            GeneratedMessageLite<NewAuthResponse, Builder>.PrintField("Status", this.hasStatus, this.status_, writer);
            GeneratedMessageLite<NewAuthResponse, Builder>.PrintField("SessionKey", this.hasSessionKey, this.sessionKey_, writer);
            GeneratedMessageLite<NewAuthResponse, Builder>.PrintField("ImgSid", this.hasImgSid, this.imgSid_, writer);
            GeneratedMessageLite<NewAuthResponse, Builder>.PrintField("ImgBuf", this.hasImgBuf, this.imgBuf_, writer);
            GeneratedMessageLite<NewAuthResponse, Builder>.PrintField("OfficialUserName", this.hasOfficialUserName, this.officialUserName_, writer);
            GeneratedMessageLite<NewAuthResponse, Builder>.PrintField("OfficialNickName", this.hasOfficialNickName, this.officialNickName_, writer);
            GeneratedMessageLite<NewAuthResponse, Builder>.PrintField("QQMicroBlogUserName", this.hasQQMicroBlogUserName, this.qQMicroBlogUserName_, writer);
            GeneratedMessageLite<NewAuthResponse, Builder>.PrintField("QQMicroBlogStatus", this.hasQQMicroBlogStatus, this.qQMicroBlogStatus_, writer);
            GeneratedMessageLite<NewAuthResponse, Builder>.PrintField("NewVersion", this.hasNewVersion, this.newVersion_, writer);
            GeneratedMessageLite<NewAuthResponse, Builder>.PrintField("Ticket", this.hasTicket, this.ticket_, writer);
            GeneratedMessageLite<NewAuthResponse, Builder>.PrintField("PushMailStatus", this.hasPushMailStatus, this.pushMailStatus_, writer);
            GeneratedMessageLite<NewAuthResponse, Builder>.PrintField("SendCardBitFlag", this.hasSendCardBitFlag, this.sendCardBitFlag_, writer);
            GeneratedMessageLite<NewAuthResponse, Builder>.PrintField("PushMailSettingTicket", this.hasPushMailSettingTicket, this.pushMailSettingTicket_, writer);
            GeneratedMessageLite<NewAuthResponse, Builder>.PrintField("BuiltinIPList", this.hasBuiltinIPList, this.builtinIPList_, writer);
            GeneratedMessageLite<NewAuthResponse, Builder>.PrintField("FSURL", this.hasFSURL, this.fSURL_, writer);
            GeneratedMessageLite<NewAuthResponse, Builder>.PrintField("NetworkControl", this.hasNetworkControl, this.networkControl_, writer);
            GeneratedMessageLite<NewAuthResponse, Builder>.PrintField("PluginFlag", this.hasPluginFlag, this.pluginFlag_, writer);
            GeneratedMessageLite<NewAuthResponse, Builder>.PrintField("Alias", this.hasAlias, this.alias_, writer);
            GeneratedMessageLite<NewAuthResponse, Builder>.PrintField("RegType", this.hasRegType, this.regType_, writer);
            GeneratedMessageLite<NewAuthResponse, Builder>.PrintField("AuthKey", this.hasAuthKey, this.authKey_, writer);
            GeneratedMessageLite<NewAuthResponse, Builder>.PrintField("Sid", this.hasSid, this.sid_, writer);
            GeneratedMessageLite<NewAuthResponse, Builder>.PrintField("PluginKeyList", this.hasPluginKeyList, this.pluginKeyList_, writer);
            GeneratedMessageLite<NewAuthResponse, Builder>.PrintField("ImgEncryptKey", this.hasImgEncryptKey, this.imgEncryptKey_, writer);
            GeneratedMessageLite<NewAuthResponse, Builder>.PrintField("A2Key", this.hasA2Key, this.a2Key_, writer);
            GeneratedMessageLite<NewAuthResponse, Builder>.PrintField("KSid", this.hasKSid, this.kSid_, writer);
            GeneratedMessageLite<NewAuthResponse, Builder>.PrintField("ProfileFlag", this.hasProfileFlag, this.profileFlag_, writer);
            GeneratedMessageLite<NewAuthResponse, Builder>.PrintField("Password", this.hasPassword, this.password_, writer);
            GeneratedMessageLite<NewAuthResponse, Builder>.PrintField("TimeStamp", this.hasTimeStamp, this.timeStamp_, writer);
            GeneratedMessageLite<NewAuthResponse, Builder>.PrintField("IsAutoReg", this.hasIsAutoReg, this.isAutoReg_, writer);
            GeneratedMessageLite<NewAuthResponse, Builder>.PrintField("KickResponse", this.hasKickResponse, this.kickResponse_, writer);
            GeneratedMessageLite<NewAuthResponse, Builder>.PrintField("ApplyBetaUrl", this.hasApplyBetaUrl, this.applyBetaUrl_, writer);
            GeneratedMessageLite<NewAuthResponse, Builder>.PrintField("DeviceInfoXml", this.hasDeviceInfoXml, this.deviceInfoXml_, writer);
            GeneratedMessageLite<NewAuthResponse, Builder>.PrintField("SoftConfigXml", this.hasSoftConfigXml, this.softConfigXml_, writer);
            GeneratedMessageLite<NewAuthResponse, Builder>.PrintField("NewHostList", this.hasNewHostList, this.newHostList_, writer);
            GeneratedMessageLite<NewAuthResponse, Builder>.PrintField("AuthTicket", this.hasAuthTicket, this.authTicket_, writer);
            GeneratedMessageLite<NewAuthResponse, Builder>.PrintField("SafeDevice", this.hasSafeDevice, this.safeDevice_, writer);
            GeneratedMessageLite<NewAuthResponse, Builder>.PrintField("MainAcctType", this.hasMainAcctType, this.mainAcctType_, writer);
            GeneratedMessageLite<NewAuthResponse, Builder>.PrintField("NeedSetEmailPwd", this.hasNeedSetEmailPwd, this.needSetEmailPwd_, writer);
            GeneratedMessageLite<NewAuthResponse, Builder>.PrintField("HintMsg", this.hasHintMsg, this.hintMsg_, writer);
            GeneratedMessageLite<NewAuthResponse, Builder>.PrintField("AutoAuthTicket", this.hasAutoAuthTicket, this.autoAuthTicket_, writer);
            GeneratedMessageLite<NewAuthResponse, Builder>.PrintField("DnsInfo", this.hasDnsInfo, this.dnsInfo_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _NewAuthResponseFieldNames;
            if (this.hasBaseResponse)
            {
                output.WriteMessage(1, strArray[6], this.BaseResponse);
            }
            if (this.hasUin)
            {
                output.WriteUInt32(2, strArray[0x2e], this.Uin);
            }
            if (this.hasUserName)
            {
                output.WriteMessage(3, strArray[0x2f], this.UserName);
            }
            if (this.hasNickName)
            {
                output.WriteMessage(4, strArray[0x1a], this.NickName);
            }
            if (this.hasBindUin)
            {
                output.WriteUInt32(5, strArray[9], this.BindUin);
            }
            if (this.hasBindEmail)
            {
                output.WriteMessage(6, strArray[7], this.BindEmail);
            }
            if (this.hasBindMobile)
            {
                output.WriteMessage(7, strArray[8], this.BindMobile);
            }
            if (this.hasStatus)
            {
                output.WriteUInt32(8, strArray[0x2b], this.Status);
            }
            if (this.hasSessionKey)
            {
                output.WriteBytes(9, strArray[40], this.SessionKey);
            }
            if (this.hasImgSid)
            {
                output.WriteMessage(10, strArray[0x11], this.ImgSid);
            }
            if (this.hasImgBuf)
            {
                output.WriteMessage(11, strArray[15], this.ImgBuf);
            }
            if (this.hasOfficialUserName)
            {
                output.WriteMessage(12, strArray[0x1c], this.OfficialUserName);
            }
            if (this.hasOfficialNickName)
            {
                output.WriteMessage(13, strArray[0x1b], this.OfficialNickName);
            }
            if (this.hasQQMicroBlogUserName)
            {
                output.WriteMessage(14, strArray[0x24], this.QQMicroBlogUserName);
            }
            if (this.hasQQMicroBlogStatus)
            {
                output.WriteUInt32(15, strArray[0x23], this.QQMicroBlogStatus);
            }
            if (this.hasNewVersion)
            {
                output.WriteUInt32(0x10, strArray[0x19], this.NewVersion);
            }
            if (this.hasTicket)
            {
                output.WriteString(0x11, strArray[0x2c], this.Ticket);
            }
            if (this.hasPushMailStatus)
            {
                output.WriteUInt32(0x12, strArray[0x22], this.PushMailStatus);
            }
            if (this.hasSendCardBitFlag)
            {
                output.WriteUInt32(0x13, strArray[0x27], this.SendCardBitFlag);
            }
            if (this.hasPushMailSettingTicket)
            {
                output.WriteString(20, strArray[0x21], this.PushMailSettingTicket);
            }
            if (this.hasBuiltinIPList)
            {
                output.WriteMessage(0x15, strArray[10], this.BuiltinIPList);
            }
            if (this.hasFSURL)
            {
                output.WriteString(0x16, strArray[13], this.FSURL);
            }
            if (this.hasNetworkControl)
            {
                output.WriteMessage(0x17, strArray[0x17], this.NetworkControl);
            }
            if (this.hasPluginFlag)
            {
                output.WriteUInt32(0x18, strArray[30], this.PluginFlag);
            }
            if (this.hasAlias)
            {
                output.WriteString(0x19, strArray[1], this.Alias);
            }
            if (this.hasRegType)
            {
                output.WriteUInt32(0x1a, strArray[0x25], this.RegType);
            }
            if (this.hasAuthKey)
            {
                output.WriteString(0x1b, strArray[3], this.AuthKey);
            }
            if (this.hasSid)
            {
                output.WriteString(0x1c, strArray[0x29], this.Sid);
            }
            if (this.hasPluginKeyList)
            {
                output.WriteMessage(0x1d, strArray[0x1f], this.PluginKeyList);
            }
            if (this.hasImgEncryptKey)
            {
                output.WriteMessage(30, strArray[0x10], this.ImgEncryptKey);
            }
            if (this.hasA2Key)
            {
                output.WriteMessage(0x1f, strArray[0], this.A2Key);
            }
            if (this.hasKSid)
            {
                output.WriteMessage(0x20, strArray[0x13], this.KSid);
            }
            if (this.hasProfileFlag)
            {
                output.WriteUInt32(0x21, strArray[0x20], this.ProfileFlag);
            }
            if (this.hasPassword)
            {
                output.WriteString(0x22, strArray[0x1d], this.Password);
            }
            if (this.hasTimeStamp)
            {
                output.WriteUInt32(0x23, strArray[0x2d], this.TimeStamp);
            }
            if (this.hasIsAutoReg)
            {
                output.WriteUInt32(0x24, strArray[0x12], this.IsAutoReg);
            }
            if (this.hasKickResponse)
            {
                output.WriteString(0x25, strArray[20], this.KickResponse);
            }
            if (this.hasApplyBetaUrl)
            {
                output.WriteString(0x26, strArray[2], this.ApplyBetaUrl);
            }
            if (this.hasDeviceInfoXml)
            {
                output.WriteString(0x27, strArray[11], this.DeviceInfoXml);
            }
            if (this.hasSoftConfigXml)
            {
                output.WriteString(40, strArray[0x2a], this.SoftConfigXml);
            }
            if (this.hasNewHostList)
            {
                output.WriteMessage(0x29, strArray[0x18], this.NewHostList);
            }
            if (this.hasAuthTicket)
            {
                output.WriteString(0x2a, strArray[4], this.AuthTicket);
            }
            if (this.hasSafeDevice)
            {
                output.WriteUInt32(0x2b, strArray[0x26], this.SafeDevice);
            }
            if (this.hasMainAcctType)
            {
                output.WriteUInt32(0x2c, strArray[0x15], this.MainAcctType);
            }
            if (this.hasNeedSetEmailPwd)
            {
                output.WriteUInt32(0x2d, strArray[0x16], this.NeedSetEmailPwd);
            }
            if (this.hasHintMsg)
            {
                output.WriteString(0x2e, strArray[14], this.HintMsg);
            }
            if (this.hasAutoAuthTicket)
            {
                output.WriteString(0x2f, strArray[5], this.AutoAuthTicket);
            }
            if (this.hasDnsInfo)
            {
                output.WriteMessage(0x30, strArray[12], this.DnsInfo);
            }
        }

        public SKBuiltinBuffer_t A2Key
        {
            get
            {
                return (this.a2Key_ ?? SKBuiltinBuffer_t.DefaultInstance);
            }
        }

        public string Alias
        {
            get
            {
                return this.alias_;
            }
        }

        public string ApplyBetaUrl
        {
            get
            {
                return this.applyBetaUrl_;
            }
        }

        public string AuthKey
        {
            get
            {
                return this.authKey_;
            }
        }

        public string AuthTicket
        {
            get
            {
                return this.authTicket_;
            }
        }

        public string AutoAuthTicket
        {
            get
            {
                return this.autoAuthTicket_;
            }
        }

        public micromsg.BaseResponse BaseResponse
        {
            get
            {
                return (this.baseResponse_ ?? micromsg.BaseResponse.DefaultInstance);
            }
        }

        public SKBuiltinString_t BindEmail
        {
            get
            {
                return (this.bindEmail_ ?? SKBuiltinString_t.DefaultInstance);
            }
        }

        public SKBuiltinString_t BindMobile
        {
            get
            {
                return (this.bindMobile_ ?? SKBuiltinString_t.DefaultInstance);
            }
        }

        public uint BindUin
        {
            get
            {
                return this.bindUin_;
            }
        }

        public micromsg.BuiltinIPList BuiltinIPList
        {
            get
            {
                return (this.builtinIPList_ ?? micromsg.BuiltinIPList.DefaultInstance);
            }
        }

        public static NewAuthResponse DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override NewAuthResponse DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public string DeviceInfoXml
        {
            get
            {
                return this.deviceInfoXml_;
            }
        }

        public CDNDnsInfo DnsInfo
        {
            get
            {
                return (this.dnsInfo_ ?? CDNDnsInfo.DefaultInstance);
            }
        }

        public string FSURL
        {
            get
            {
                return this.fSURL_;
            }
        }

        public string HintMsg
        {
            get
            {
                return this.hintMsg_;
            }
        }

        public SKBuiltinBuffer_t ImgBuf
        {
            get
            {
                return (this.imgBuf_ ?? SKBuiltinBuffer_t.DefaultInstance);
            }
        }

        public SKBuiltinString_t ImgEncryptKey
        {
            get
            {
                return (this.imgEncryptKey_ ?? SKBuiltinString_t.DefaultInstance);
            }
        }

        public SKBuiltinString_t ImgSid
        {
            get
            {
                return (this.imgSid_ ?? SKBuiltinString_t.DefaultInstance);
            }
        }

        public uint IsAutoReg
        {
            get
            {
                return this.isAutoReg_;
            }
        }

        public override bool IsInitialized
        {
            get
            {
                if (!this.hasBaseResponse)
                {
                    return false;
                }
                if (!this.hasUin)
                {
                    return false;
                }
                if (!this.hasUserName)
                {
                    return false;
                }
                if (!this.hasNickName)
                {
                    return false;
                }
                if (!this.hasBindUin)
                {
                    return false;
                }
                if (!this.hasBindEmail)
                {
                    return false;
                }
                if (!this.hasBindMobile)
                {
                    return false;
                }
                if (!this.hasStatus)
                {
                    return false;
                }
                if (!this.hasSessionKey)
                {
                    return false;
                }
                if (!this.hasImgSid)
                {
                    return false;
                }
                if (!this.hasImgBuf)
                {
                    return false;
                }
                if (!this.hasOfficialUserName)
                {
                    return false;
                }
                if (!this.hasOfficialNickName)
                {
                    return false;
                }
                if (!this.BaseResponse.IsInitialized)
                {
                    return false;
                }
                if (!this.ImgBuf.IsInitialized)
                {
                    return false;
                }
                return true;
            }
        }

        public string KickResponse
        {
            get
            {
                return this.kickResponse_;
            }
        }

        public SKBuiltinBuffer_t KSid
        {
            get
            {
                return (this.kSid_ ?? SKBuiltinBuffer_t.DefaultInstance);
            }
        }

        public uint MainAcctType
        {
            get
            {
                return this.mainAcctType_;
            }
        }

        public uint NeedSetEmailPwd
        {
            get
            {
                return this.needSetEmailPwd_;
            }
        }

        public micromsg.NetworkControl NetworkControl
        {
            get
            {
                return (this.networkControl_ ?? micromsg.NetworkControl.DefaultInstance);
            }
        }

        public HostList NewHostList
        {
            get
            {
                return (this.newHostList_ ?? HostList.DefaultInstance);
            }
        }

        public uint NewVersion
        {
            get
            {
                return this.newVersion_;
            }
        }

        public SKBuiltinString_t NickName
        {
            get
            {
                return (this.nickName_ ?? SKBuiltinString_t.DefaultInstance);
            }
        }

        public SKBuiltinString_t OfficialNickName
        {
            get
            {
                return (this.officialNickName_ ?? SKBuiltinString_t.DefaultInstance);
            }
        }

        public SKBuiltinString_t OfficialUserName
        {
            get
            {
                return (this.officialUserName_ ?? SKBuiltinString_t.DefaultInstance);
            }
        }

        public string Password
        {
            get
            {
                return this.password_;
            }
        }

        public uint PluginFlag
        {
            get
            {
                return this.pluginFlag_;
            }
        }

        public micromsg.PluginKeyList PluginKeyList
        {
            get
            {
                return (this.pluginKeyList_ ?? micromsg.PluginKeyList.DefaultInstance);
            }
        }

        public uint ProfileFlag
        {
            get
            {
                return this.profileFlag_;
            }
        }

        public string PushMailSettingTicket
        {
            get
            {
                return this.pushMailSettingTicket_;
            }
        }

        public uint PushMailStatus
        {
            get
            {
                return this.pushMailStatus_;
            }
        }

        public uint QQMicroBlogStatus
        {
            get
            {
                return this.qQMicroBlogStatus_;
            }
        }

        public SKBuiltinString_t QQMicroBlogUserName
        {
            get
            {
                return (this.qQMicroBlogUserName_ ?? SKBuiltinString_t.DefaultInstance);
            }
        }

        public uint RegType
        {
            get
            {
                return this.regType_;
            }
        }

        public uint SafeDevice
        {
            get
            {
                return this.safeDevice_;
            }
        }

        public uint SendCardBitFlag
        {
            get
            {
                return this.sendCardBitFlag_;
            }
        }

        public override int SerializedSize
        {
            get
            {
                int memoizedSerializedSize = this.memoizedSerializedSize;
                if (memoizedSerializedSize == -1)
                {
                    memoizedSerializedSize = 0;
                    if (this.hasBaseResponse)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(1, this.BaseResponse);
                    }
                    if (this.hasUin)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(2, this.Uin);
                    }
                    if (this.hasUserName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(3, this.UserName);
                    }
                    if (this.hasNickName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(4, this.NickName);
                    }
                    if (this.hasBindUin)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(5, this.BindUin);
                    }
                    if (this.hasBindEmail)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(6, this.BindEmail);
                    }
                    if (this.hasBindMobile)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(7, this.BindMobile);
                    }
                    if (this.hasStatus)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(8, this.Status);
                    }
                    if (this.hasSessionKey)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeBytesSize(9, this.SessionKey);
                    }
                    if (this.hasImgSid)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(10, this.ImgSid);
                    }
                    if (this.hasImgBuf)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(11, this.ImgBuf);
                    }
                    if (this.hasOfficialUserName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(12, this.OfficialUserName);
                    }
                    if (this.hasOfficialNickName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(13, this.OfficialNickName);
                    }
                    if (this.hasQQMicroBlogUserName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(14, this.QQMicroBlogUserName);
                    }
                    if (this.hasQQMicroBlogStatus)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(15, this.QQMicroBlogStatus);
                    }
                    if (this.hasNewVersion)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(0x10, this.NewVersion);
                    }
                    if (this.hasTicket)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x11, this.Ticket);
                    }
                    if (this.hasPushMailStatus)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(0x12, this.PushMailStatus);
                    }
                    if (this.hasSendCardBitFlag)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(0x13, this.SendCardBitFlag);
                    }
                    if (this.hasPushMailSettingTicket)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(20, this.PushMailSettingTicket);
                    }
                    if (this.hasBuiltinIPList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(0x15, this.BuiltinIPList);
                    }
                    if (this.hasFSURL)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x16, this.FSURL);
                    }
                    if (this.hasNetworkControl)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(0x17, this.NetworkControl);
                    }
                    if (this.hasPluginFlag)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(0x18, this.PluginFlag);
                    }
                    if (this.hasAlias)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x19, this.Alias);
                    }
                    if (this.hasRegType)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(0x1a, this.RegType);
                    }
                    if (this.hasAuthKey)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x1b, this.AuthKey);
                    }
                    if (this.hasSid)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x1c, this.Sid);
                    }
                    if (this.hasPluginKeyList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(0x1d, this.PluginKeyList);
                    }
                    if (this.hasImgEncryptKey)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(30, this.ImgEncryptKey);
                    }
                    if (this.hasA2Key)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(0x1f, this.A2Key);
                    }
                    if (this.hasKSid)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(0x20, this.KSid);
                    }
                    if (this.hasProfileFlag)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(0x21, this.ProfileFlag);
                    }
                    if (this.hasPassword)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x22, this.Password);
                    }
                    if (this.hasTimeStamp)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(0x23, this.TimeStamp);
                    }
                    if (this.hasIsAutoReg)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(0x24, this.IsAutoReg);
                    }
                    if (this.hasKickResponse)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x25, this.KickResponse);
                    }
                    if (this.hasApplyBetaUrl)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x26, this.ApplyBetaUrl);
                    }
                    if (this.hasDeviceInfoXml)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x27, this.DeviceInfoXml);
                    }
                    if (this.hasSoftConfigXml)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(40, this.SoftConfigXml);
                    }
                    if (this.hasNewHostList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(0x29, this.NewHostList);
                    }
                    if (this.hasAuthTicket)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x2a, this.AuthTicket);
                    }
                    if (this.hasSafeDevice)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(0x2b, this.SafeDevice);
                    }
                    if (this.hasMainAcctType)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(0x2c, this.MainAcctType);
                    }
                    if (this.hasNeedSetEmailPwd)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(0x2d, this.NeedSetEmailPwd);
                    }
                    if (this.hasHintMsg)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x2e, this.HintMsg);
                    }
                    if (this.hasAutoAuthTicket)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x2f, this.AutoAuthTicket);
                    }
                    if (this.hasDnsInfo)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(0x30, this.DnsInfo);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        public ByteString SessionKey
        {
            get
            {
                return this.sessionKey_;
            }
        }

        public string Sid
        {
            get
            {
                return this.sid_;
            }
        }

        public string SoftConfigXml
        {
            get
            {
                return this.softConfigXml_;
            }
        }

        public uint Status
        {
            get
            {
                return this.status_;
            }
        }

        protected override NewAuthResponse ThisMessage
        {
            get
            {
                return this;
            }
        }

        public string Ticket
        {
            get
            {
                return this.ticket_;
            }
        }

        public uint TimeStamp
        {
            get
            {
                return this.timeStamp_;
            }
        }

        public uint Uin
        {
            get
            {
                return this.uin_;
            }
        }

        public SKBuiltinString_t UserName
        {
            get
            {
                return (this.userName_ ?? SKBuiltinString_t.DefaultInstance);
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<NewAuthResponse, NewAuthResponse.Builder>
        {
            private NewAuthResponse result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = NewAuthResponse.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(NewAuthResponse cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override NewAuthResponse BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override NewAuthResponse.Builder Clear()
            {
                this.result = NewAuthResponse.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public NewAuthResponse.Builder ClearA2Key()
            {
                this.PrepareBuilder();
                this.result.hasA2Key = false;
                this.result.a2Key_ = null;
                return this;
            }

            public NewAuthResponse.Builder ClearAlias()
            {
                this.PrepareBuilder();
                this.result.hasAlias = false;
                this.result.alias_ = "";
                return this;
            }

            public NewAuthResponse.Builder ClearApplyBetaUrl()
            {
                this.PrepareBuilder();
                this.result.hasApplyBetaUrl = false;
                this.result.applyBetaUrl_ = "";
                return this;
            }

            public NewAuthResponse.Builder ClearAuthKey()
            {
                this.PrepareBuilder();
                this.result.hasAuthKey = false;
                this.result.authKey_ = "";
                return this;
            }

            public NewAuthResponse.Builder ClearAuthTicket()
            {
                this.PrepareBuilder();
                this.result.hasAuthTicket = false;
                this.result.authTicket_ = "";
                return this;
            }

            public NewAuthResponse.Builder ClearAutoAuthTicket()
            {
                this.PrepareBuilder();
                this.result.hasAutoAuthTicket = false;
                this.result.autoAuthTicket_ = "";
                return this;
            }

            public NewAuthResponse.Builder ClearBaseResponse()
            {
                this.PrepareBuilder();
                this.result.hasBaseResponse = false;
                this.result.baseResponse_ = null;
                return this;
            }

            public NewAuthResponse.Builder ClearBindEmail()
            {
                this.PrepareBuilder();
                this.result.hasBindEmail = false;
                this.result.bindEmail_ = null;
                return this;
            }

            public NewAuthResponse.Builder ClearBindMobile()
            {
                this.PrepareBuilder();
                this.result.hasBindMobile = false;
                this.result.bindMobile_ = null;
                return this;
            }

            public NewAuthResponse.Builder ClearBindUin()
            {
                this.PrepareBuilder();
                this.result.hasBindUin = false;
                this.result.bindUin_ = 0;
                return this;
            }

            public NewAuthResponse.Builder ClearBuiltinIPList()
            {
                this.PrepareBuilder();
                this.result.hasBuiltinIPList = false;
                this.result.builtinIPList_ = null;
                return this;
            }

            public NewAuthResponse.Builder ClearDeviceInfoXml()
            {
                this.PrepareBuilder();
                this.result.hasDeviceInfoXml = false;
                this.result.deviceInfoXml_ = "";
                return this;
            }

            public NewAuthResponse.Builder ClearDnsInfo()
            {
                this.PrepareBuilder();
                this.result.hasDnsInfo = false;
                this.result.dnsInfo_ = null;
                return this;
            }

            public NewAuthResponse.Builder ClearFSURL()
            {
                this.PrepareBuilder();
                this.result.hasFSURL = false;
                this.result.fSURL_ = "";
                return this;
            }

            public NewAuthResponse.Builder ClearHintMsg()
            {
                this.PrepareBuilder();
                this.result.hasHintMsg = false;
                this.result.hintMsg_ = "";
                return this;
            }

            public NewAuthResponse.Builder ClearImgBuf()
            {
                this.PrepareBuilder();
                this.result.hasImgBuf = false;
                this.result.imgBuf_ = null;
                return this;
            }

            public NewAuthResponse.Builder ClearImgEncryptKey()
            {
                this.PrepareBuilder();
                this.result.hasImgEncryptKey = false;
                this.result.imgEncryptKey_ = null;
                return this;
            }

            public NewAuthResponse.Builder ClearImgSid()
            {
                this.PrepareBuilder();
                this.result.hasImgSid = false;
                this.result.imgSid_ = null;
                return this;
            }

            public NewAuthResponse.Builder ClearIsAutoReg()
            {
                this.PrepareBuilder();
                this.result.hasIsAutoReg = false;
                this.result.isAutoReg_ = 0;
                return this;
            }

            public NewAuthResponse.Builder ClearKickResponse()
            {
                this.PrepareBuilder();
                this.result.hasKickResponse = false;
                this.result.kickResponse_ = "";
                return this;
            }

            public NewAuthResponse.Builder ClearKSid()
            {
                this.PrepareBuilder();
                this.result.hasKSid = false;
                this.result.kSid_ = null;
                return this;
            }

            public NewAuthResponse.Builder ClearMainAcctType()
            {
                this.PrepareBuilder();
                this.result.hasMainAcctType = false;
                this.result.mainAcctType_ = 0;
                return this;
            }

            public NewAuthResponse.Builder ClearNeedSetEmailPwd()
            {
                this.PrepareBuilder();
                this.result.hasNeedSetEmailPwd = false;
                this.result.needSetEmailPwd_ = 0;
                return this;
            }

            public NewAuthResponse.Builder ClearNetworkControl()
            {
                this.PrepareBuilder();
                this.result.hasNetworkControl = false;
                this.result.networkControl_ = null;
                return this;
            }

            public NewAuthResponse.Builder ClearNewHostList()
            {
                this.PrepareBuilder();
                this.result.hasNewHostList = false;
                this.result.newHostList_ = null;
                return this;
            }

            public NewAuthResponse.Builder ClearNewVersion()
            {
                this.PrepareBuilder();
                this.result.hasNewVersion = false;
                this.result.newVersion_ = 0;
                return this;
            }

            public NewAuthResponse.Builder ClearNickName()
            {
                this.PrepareBuilder();
                this.result.hasNickName = false;
                this.result.nickName_ = null;
                return this;
            }

            public NewAuthResponse.Builder ClearOfficialNickName()
            {
                this.PrepareBuilder();
                this.result.hasOfficialNickName = false;
                this.result.officialNickName_ = null;
                return this;
            }

            public NewAuthResponse.Builder ClearOfficialUserName()
            {
                this.PrepareBuilder();
                this.result.hasOfficialUserName = false;
                this.result.officialUserName_ = null;
                return this;
            }

            public NewAuthResponse.Builder ClearPassword()
            {
                this.PrepareBuilder();
                this.result.hasPassword = false;
                this.result.password_ = "";
                return this;
            }

            public NewAuthResponse.Builder ClearPluginFlag()
            {
                this.PrepareBuilder();
                this.result.hasPluginFlag = false;
                this.result.pluginFlag_ = 0;
                return this;
            }

            public NewAuthResponse.Builder ClearPluginKeyList()
            {
                this.PrepareBuilder();
                this.result.hasPluginKeyList = false;
                this.result.pluginKeyList_ = null;
                return this;
            }

            public NewAuthResponse.Builder ClearProfileFlag()
            {
                this.PrepareBuilder();
                this.result.hasProfileFlag = false;
                this.result.profileFlag_ = 0;
                return this;
            }

            public NewAuthResponse.Builder ClearPushMailSettingTicket()
            {
                this.PrepareBuilder();
                this.result.hasPushMailSettingTicket = false;
                this.result.pushMailSettingTicket_ = "";
                return this;
            }

            public NewAuthResponse.Builder ClearPushMailStatus()
            {
                this.PrepareBuilder();
                this.result.hasPushMailStatus = false;
                this.result.pushMailStatus_ = 0;
                return this;
            }

            public NewAuthResponse.Builder ClearQQMicroBlogStatus()
            {
                this.PrepareBuilder();
                this.result.hasQQMicroBlogStatus = false;
                this.result.qQMicroBlogStatus_ = 0;
                return this;
            }

            public NewAuthResponse.Builder ClearQQMicroBlogUserName()
            {
                this.PrepareBuilder();
                this.result.hasQQMicroBlogUserName = false;
                this.result.qQMicroBlogUserName_ = null;
                return this;
            }

            public NewAuthResponse.Builder ClearRegType()
            {
                this.PrepareBuilder();
                this.result.hasRegType = false;
                this.result.regType_ = 0;
                return this;
            }

            public NewAuthResponse.Builder ClearSafeDevice()
            {
                this.PrepareBuilder();
                this.result.hasSafeDevice = false;
                this.result.safeDevice_ = 0;
                return this;
            }

            public NewAuthResponse.Builder ClearSendCardBitFlag()
            {
                this.PrepareBuilder();
                this.result.hasSendCardBitFlag = false;
                this.result.sendCardBitFlag_ = 0;
                return this;
            }

            public NewAuthResponse.Builder ClearSessionKey()
            {
                this.PrepareBuilder();
                this.result.hasSessionKey = false;
                this.result.sessionKey_ = ByteString.Empty;
                return this;
            }

            public NewAuthResponse.Builder ClearSid()
            {
                this.PrepareBuilder();
                this.result.hasSid = false;
                this.result.sid_ = "";
                return this;
            }

            public NewAuthResponse.Builder ClearSoftConfigXml()
            {
                this.PrepareBuilder();
                this.result.hasSoftConfigXml = false;
                this.result.softConfigXml_ = "";
                return this;
            }

            public NewAuthResponse.Builder ClearStatus()
            {
                this.PrepareBuilder();
                this.result.hasStatus = false;
                this.result.status_ = 0;
                return this;
            }

            public NewAuthResponse.Builder ClearTicket()
            {
                this.PrepareBuilder();
                this.result.hasTicket = false;
                this.result.ticket_ = "";
                return this;
            }

            public NewAuthResponse.Builder ClearTimeStamp()
            {
                this.PrepareBuilder();
                this.result.hasTimeStamp = false;
                this.result.timeStamp_ = 0;
                return this;
            }

            public NewAuthResponse.Builder ClearUin()
            {
                this.PrepareBuilder();
                this.result.hasUin = false;
                this.result.uin_ = 0;
                return this;
            }

            public NewAuthResponse.Builder ClearUserName()
            {
                this.PrepareBuilder();
                this.result.hasUserName = false;
                this.result.userName_ = null;
                return this;
            }

            public override NewAuthResponse.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new NewAuthResponse.Builder(this.result);
                }
                return new NewAuthResponse.Builder().MergeFrom(this.result);
            }

            public NewAuthResponse.Builder MergeA2Key(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasA2Key && (this.result.a2Key_ != SKBuiltinBuffer_t.DefaultInstance))
                {
                    this.result.a2Key_ = SKBuiltinBuffer_t.CreateBuilder(this.result.a2Key_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.a2Key_ = value;
                }
                this.result.hasA2Key = true;
                return this;
            }

            public NewAuthResponse.Builder MergeBaseResponse(BaseResponse value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasBaseResponse && (this.result.baseResponse_ != BaseResponse.DefaultInstance))
                {
                    this.result.baseResponse_ = BaseResponse.CreateBuilder(this.result.baseResponse_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.baseResponse_ = value;
                }
                this.result.hasBaseResponse = true;
                return this;
            }

            public NewAuthResponse.Builder MergeBindEmail(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasBindEmail && (this.result.bindEmail_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.bindEmail_ = SKBuiltinString_t.CreateBuilder(this.result.bindEmail_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.bindEmail_ = value;
                }
                this.result.hasBindEmail = true;
                return this;
            }

            public NewAuthResponse.Builder MergeBindMobile(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasBindMobile && (this.result.bindMobile_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.bindMobile_ = SKBuiltinString_t.CreateBuilder(this.result.bindMobile_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.bindMobile_ = value;
                }
                this.result.hasBindMobile = true;
                return this;
            }

            public NewAuthResponse.Builder MergeBuiltinIPList(micromsg.BuiltinIPList value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasBuiltinIPList && (this.result.builtinIPList_ != micromsg.BuiltinIPList.DefaultInstance))
                {
                    this.result.builtinIPList_ = micromsg.BuiltinIPList.CreateBuilder(this.result.builtinIPList_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.builtinIPList_ = value;
                }
                this.result.hasBuiltinIPList = true;
                return this;
            }

            public NewAuthResponse.Builder MergeDnsInfo(CDNDnsInfo value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasDnsInfo && (this.result.dnsInfo_ != CDNDnsInfo.DefaultInstance))
                {
                    this.result.dnsInfo_ = CDNDnsInfo.CreateBuilder(this.result.dnsInfo_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.dnsInfo_ = value;
                }
                this.result.hasDnsInfo = true;
                return this;
            }

            public override NewAuthResponse.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override NewAuthResponse.Builder MergeFrom(IMessageLite other)
            {
                if (other is NewAuthResponse)
                {
                    return this.MergeFrom((NewAuthResponse) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override NewAuthResponse.Builder MergeFrom(NewAuthResponse other)
            {
                return this;
            }

            public override NewAuthResponse.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(NewAuthResponse._NewAuthResponseFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = NewAuthResponse._NewAuthResponseFieldTags[index];
                        }
                        else
                        {
                            this.ParseUnknownField(input, extensionRegistry, num, str);
                            continue;
                        }
                    }
                    switch (num)
                    {
                        case 0x1a:
                        {
                            SKBuiltinString_t.Builder builder2 = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasUserName)
                            {
                                builder2.MergeFrom(this.UserName);
                            }
                            input.ReadMessage(builder2, extensionRegistry);
                            this.UserName = builder2.BuildPartial();
                            continue;
                        }
                        case 0x22:
                        {
                            SKBuiltinString_t.Builder builder3 = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasNickName)
                            {
                                builder3.MergeFrom(this.NickName);
                            }
                            input.ReadMessage(builder3, extensionRegistry);
                            this.NickName = builder3.BuildPartial();
                            continue;
                        }
                        case 40:
                        {
                            this.result.hasBindUin = input.ReadUInt32(ref this.result.bindUin_);
                            continue;
                        }
                        case 0:
                            throw InvalidProtocolBufferException.InvalidTag();

                        case 10:
                        {
                            BaseResponse.Builder builder = BaseResponse.CreateBuilder();
                            if (this.result.hasBaseResponse)
                            {
                                builder.MergeFrom(this.BaseResponse);
                            }
                            input.ReadMessage(builder, extensionRegistry);
                            this.BaseResponse = builder.BuildPartial();
                            continue;
                        }
                        case 0x10:
                        {
                            this.result.hasUin = input.ReadUInt32(ref this.result.uin_);
                            continue;
                        }
                        case 50:
                        {
                            SKBuiltinString_t.Builder builder4 = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasBindEmail)
                            {
                                builder4.MergeFrom(this.BindEmail);
                            }
                            input.ReadMessage(builder4, extensionRegistry);
                            this.BindEmail = builder4.BuildPartial();
                            continue;
                        }
                        case 0x3a:
                        {
                            SKBuiltinString_t.Builder builder5 = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasBindMobile)
                            {
                                builder5.MergeFrom(this.BindMobile);
                            }
                            input.ReadMessage(builder5, extensionRegistry);
                            this.BindMobile = builder5.BuildPartial();
                            continue;
                        }
                        case 0x40:
                        {
                            this.result.hasStatus = input.ReadUInt32(ref this.result.status_);
                            continue;
                        }
                        case 0x4a:
                        {
                            this.result.hasSessionKey = input.ReadBytes(ref this.result.sessionKey_);
                            continue;
                        }
                        case 0x52:
                        {
                            SKBuiltinString_t.Builder builder6 = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasImgSid)
                            {
                                builder6.MergeFrom(this.ImgSid);
                            }
                            input.ReadMessage(builder6, extensionRegistry);
                            this.ImgSid = builder6.BuildPartial();
                            continue;
                        }
                        case 90:
                        {
                            SKBuiltinBuffer_t.Builder builder7 = SKBuiltinBuffer_t.CreateBuilder();
                            if (this.result.hasImgBuf)
                            {
                                builder7.MergeFrom(this.ImgBuf);
                            }
                            input.ReadMessage(builder7, extensionRegistry);
                            this.ImgBuf = builder7.BuildPartial();
                            continue;
                        }
                        case 120:
                        {
                            this.result.hasQQMicroBlogStatus = input.ReadUInt32(ref this.result.qQMicroBlogStatus_);
                            continue;
                        }
                        case 0x80:
                        {
                            this.result.hasNewVersion = input.ReadUInt32(ref this.result.newVersion_);
                            continue;
                        }
                        case 0x8a:
                        {
                            this.result.hasTicket = input.ReadString(ref this.result.ticket_);
                            continue;
                        }
                        case 0x62:
                        {
                            SKBuiltinString_t.Builder builder8 = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasOfficialUserName)
                            {
                                builder8.MergeFrom(this.OfficialUserName);
                            }
                            input.ReadMessage(builder8, extensionRegistry);
                            this.OfficialUserName = builder8.BuildPartial();
                            continue;
                        }
                        case 0x6a:
                        {
                            SKBuiltinString_t.Builder builder9 = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasOfficialNickName)
                            {
                                builder9.MergeFrom(this.OfficialNickName);
                            }
                            input.ReadMessage(builder9, extensionRegistry);
                            this.OfficialNickName = builder9.BuildPartial();
                            continue;
                        }
                        case 0x72:
                        {
                            SKBuiltinString_t.Builder builder10 = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasQQMicroBlogUserName)
                            {
                                builder10.MergeFrom(this.QQMicroBlogUserName);
                            }
                            input.ReadMessage(builder10, extensionRegistry);
                            this.QQMicroBlogUserName = builder10.BuildPartial();
                            continue;
                        }
                        case 0x90:
                        {
                            this.result.hasPushMailStatus = input.ReadUInt32(ref this.result.pushMailStatus_);
                            continue;
                        }
                        case 0x98:
                        {
                            this.result.hasSendCardBitFlag = input.ReadUInt32(ref this.result.sendCardBitFlag_);
                            continue;
                        }
                        case 0xa2:
                        {
                            this.result.hasPushMailSettingTicket = input.ReadString(ref this.result.pushMailSettingTicket_);
                            continue;
                        }
                        case 170:
                        {
                            micromsg.BuiltinIPList.Builder builder11 = micromsg.BuiltinIPList.CreateBuilder();
                            if (this.result.hasBuiltinIPList)
                            {
                                builder11.MergeFrom(this.BuiltinIPList);
                            }
                            input.ReadMessage(builder11, extensionRegistry);
                            this.BuiltinIPList = builder11.BuildPartial();
                            continue;
                        }
                        case 0xb2:
                        {
                            this.result.hasFSURL = input.ReadString(ref this.result.fSURL_);
                            continue;
                        }
                        case 0xba:
                        {
                            micromsg.NetworkControl.Builder builder12 = micromsg.NetworkControl.CreateBuilder();
                            if (this.result.hasNetworkControl)
                            {
                                builder12.MergeFrom(this.NetworkControl);
                            }
                            input.ReadMessage(builder12, extensionRegistry);
                            this.NetworkControl = builder12.BuildPartial();
                            continue;
                        }
                        case 0xda:
                        {
                            this.result.hasAuthKey = input.ReadString(ref this.result.authKey_);
                            continue;
                        }
                        case 0xe2:
                        {
                            this.result.hasSid = input.ReadString(ref this.result.sid_);
                            continue;
                        }
                        case 0xea:
                        {
                            micromsg.PluginKeyList.Builder builder13 = micromsg.PluginKeyList.CreateBuilder();
                            if (this.result.hasPluginKeyList)
                            {
                                builder13.MergeFrom(this.PluginKeyList);
                            }
                            input.ReadMessage(builder13, extensionRegistry);
                            this.PluginKeyList = builder13.BuildPartial();
                            continue;
                        }
                        case 0xc0:
                        {
                            this.result.hasPluginFlag = input.ReadUInt32(ref this.result.pluginFlag_);
                            continue;
                        }
                        case 0xca:
                        {
                            this.result.hasAlias = input.ReadString(ref this.result.alias_);
                            continue;
                        }
                        case 0xd0:
                        {
                            this.result.hasRegType = input.ReadUInt32(ref this.result.regType_);
                            continue;
                        }
                        case 0xf2:
                        {
                            SKBuiltinString_t.Builder builder14 = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasImgEncryptKey)
                            {
                                builder14.MergeFrom(this.ImgEncryptKey);
                            }
                            input.ReadMessage(builder14, extensionRegistry);
                            this.ImgEncryptKey = builder14.BuildPartial();
                            continue;
                        }
                        case 250:
                        {
                            SKBuiltinBuffer_t.Builder builder15 = SKBuiltinBuffer_t.CreateBuilder();
                            if (this.result.hasA2Key)
                            {
                                builder15.MergeFrom(this.A2Key);
                            }
                            input.ReadMessage(builder15, extensionRegistry);
                            this.A2Key = builder15.BuildPartial();
                            continue;
                        }
                        case 0x102:
                        {
                            SKBuiltinBuffer_t.Builder builder16 = SKBuiltinBuffer_t.CreateBuilder();
                            if (this.result.hasKSid)
                            {
                                builder16.MergeFrom(this.KSid);
                            }
                            input.ReadMessage(builder16, extensionRegistry);
                            this.KSid = builder16.BuildPartial();
                            continue;
                        }
                        case 0x108:
                        {
                            this.result.hasProfileFlag = input.ReadUInt32(ref this.result.profileFlag_);
                            continue;
                        }
                        case 0x112:
                        {
                            this.result.hasPassword = input.ReadString(ref this.result.password_);
                            continue;
                        }
                        case 280:
                        {
                            this.result.hasTimeStamp = input.ReadUInt32(ref this.result.timeStamp_);
                            continue;
                        }
                        case 0x13a:
                        {
                            this.result.hasDeviceInfoXml = input.ReadString(ref this.result.deviceInfoXml_);
                            continue;
                        }
                        case 0x142:
                        {
                            this.result.hasSoftConfigXml = input.ReadString(ref this.result.softConfigXml_);
                            continue;
                        }
                        case 330:
                        {
                            HostList.Builder builder17 = HostList.CreateBuilder();
                            if (this.result.hasNewHostList)
                            {
                                builder17.MergeFrom(this.NewHostList);
                            }
                            input.ReadMessage(builder17, extensionRegistry);
                            this.NewHostList = builder17.BuildPartial();
                            continue;
                        }
                        case 0x120:
                        {
                            this.result.hasIsAutoReg = input.ReadUInt32(ref this.result.isAutoReg_);
                            continue;
                        }
                        case 0x12a:
                        {
                            this.result.hasKickResponse = input.ReadString(ref this.result.kickResponse_);
                            continue;
                        }
                        case 0x132:
                        {
                            this.result.hasApplyBetaUrl = input.ReadString(ref this.result.applyBetaUrl_);
                            continue;
                        }
                        case 0x152:
                        {
                            this.result.hasAuthTicket = input.ReadString(ref this.result.authTicket_);
                            continue;
                        }
                        case 0x158:
                        {
                            this.result.hasSafeDevice = input.ReadUInt32(ref this.result.safeDevice_);
                            continue;
                        }
                        case 0x160:
                        {
                            this.result.hasMainAcctType = input.ReadUInt32(ref this.result.mainAcctType_);
                            continue;
                        }
                        case 360:
                        {
                            this.result.hasNeedSetEmailPwd = input.ReadUInt32(ref this.result.needSetEmailPwd_);
                            continue;
                        }
                        case 370:
                        {
                            this.result.hasHintMsg = input.ReadString(ref this.result.hintMsg_);
                            continue;
                        }
                        case 0x17a:
                        {
                            this.result.hasAutoAuthTicket = input.ReadString(ref this.result.autoAuthTicket_);
                            continue;
                        }
                        case 0x182:
                        {
                            CDNDnsInfo.Builder builder18 = CDNDnsInfo.CreateBuilder();
                            if (this.result.hasDnsInfo)
                            {
                                builder18.MergeFrom(this.DnsInfo);
                            }
                            input.ReadMessage(builder18, extensionRegistry);
                            this.DnsInfo = builder18.BuildPartial();
                            continue;
                        }
                    }
                    if (WireFormat.IsEndGroupTag(num))
                    {
                        return this;
                    }
                    this.ParseUnknownField(input, extensionRegistry, num, str);
                }
                return this;
            }

            public NewAuthResponse.Builder MergeImgBuf(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasImgBuf && (this.result.imgBuf_ != SKBuiltinBuffer_t.DefaultInstance))
                {
                    this.result.imgBuf_ = SKBuiltinBuffer_t.CreateBuilder(this.result.imgBuf_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.imgBuf_ = value;
                }
                this.result.hasImgBuf = true;
                return this;
            }

            public NewAuthResponse.Builder MergeImgEncryptKey(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasImgEncryptKey && (this.result.imgEncryptKey_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.imgEncryptKey_ = SKBuiltinString_t.CreateBuilder(this.result.imgEncryptKey_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.imgEncryptKey_ = value;
                }
                this.result.hasImgEncryptKey = true;
                return this;
            }

            public NewAuthResponse.Builder MergeImgSid(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasImgSid && (this.result.imgSid_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.imgSid_ = SKBuiltinString_t.CreateBuilder(this.result.imgSid_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.imgSid_ = value;
                }
                this.result.hasImgSid = true;
                return this;
            }

            public NewAuthResponse.Builder MergeKSid(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasKSid && (this.result.kSid_ != SKBuiltinBuffer_t.DefaultInstance))
                {
                    this.result.kSid_ = SKBuiltinBuffer_t.CreateBuilder(this.result.kSid_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.kSid_ = value;
                }
                this.result.hasKSid = true;
                return this;
            }

            public NewAuthResponse.Builder MergeNetworkControl(micromsg.NetworkControl value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasNetworkControl && (this.result.networkControl_ != micromsg.NetworkControl.DefaultInstance))
                {
                    this.result.networkControl_ = micromsg.NetworkControl.CreateBuilder(this.result.networkControl_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.networkControl_ = value;
                }
                this.result.hasNetworkControl = true;
                return this;
            }

            public NewAuthResponse.Builder MergeNewHostList(HostList value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasNewHostList && (this.result.newHostList_ != HostList.DefaultInstance))
                {
                    this.result.newHostList_ = HostList.CreateBuilder(this.result.newHostList_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.newHostList_ = value;
                }
                this.result.hasNewHostList = true;
                return this;
            }

            public NewAuthResponse.Builder MergeNickName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasNickName && (this.result.nickName_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.nickName_ = SKBuiltinString_t.CreateBuilder(this.result.nickName_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.nickName_ = value;
                }
                this.result.hasNickName = true;
                return this;
            }

            public NewAuthResponse.Builder MergeOfficialNickName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasOfficialNickName && (this.result.officialNickName_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.officialNickName_ = SKBuiltinString_t.CreateBuilder(this.result.officialNickName_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.officialNickName_ = value;
                }
                this.result.hasOfficialNickName = true;
                return this;
            }

            public NewAuthResponse.Builder MergeOfficialUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasOfficialUserName && (this.result.officialUserName_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.officialUserName_ = SKBuiltinString_t.CreateBuilder(this.result.officialUserName_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.officialUserName_ = value;
                }
                this.result.hasOfficialUserName = true;
                return this;
            }

            public NewAuthResponse.Builder MergePluginKeyList(micromsg.PluginKeyList value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasPluginKeyList && (this.result.pluginKeyList_ != micromsg.PluginKeyList.DefaultInstance))
                {
                    this.result.pluginKeyList_ = micromsg.PluginKeyList.CreateBuilder(this.result.pluginKeyList_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.pluginKeyList_ = value;
                }
                this.result.hasPluginKeyList = true;
                return this;
            }

            public NewAuthResponse.Builder MergeQQMicroBlogUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasQQMicroBlogUserName && (this.result.qQMicroBlogUserName_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.qQMicroBlogUserName_ = SKBuiltinString_t.CreateBuilder(this.result.qQMicroBlogUserName_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.qQMicroBlogUserName_ = value;
                }
                this.result.hasQQMicroBlogUserName = true;
                return this;
            }

            public NewAuthResponse.Builder MergeUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasUserName && (this.result.userName_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.userName_ = SKBuiltinString_t.CreateBuilder(this.result.userName_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.userName_ = value;
                }
                this.result.hasUserName = true;
                return this;
            }

            private NewAuthResponse PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    NewAuthResponse result = this.result;
                    this.result = new NewAuthResponse();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public NewAuthResponse.Builder SetA2Key(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasA2Key = true;
                this.result.a2Key_ = value;
                return this;
            }

            public NewAuthResponse.Builder SetA2Key(SKBuiltinBuffer_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasA2Key = true;
                this.result.a2Key_ = builderForValue.Build();
                return this;
            }

            public NewAuthResponse.Builder SetAlias(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasAlias = true;
                this.result.alias_ = value;
                return this;
            }

            public NewAuthResponse.Builder SetApplyBetaUrl(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasApplyBetaUrl = true;
                this.result.applyBetaUrl_ = value;
                return this;
            }

            public NewAuthResponse.Builder SetAuthKey(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasAuthKey = true;
                this.result.authKey_ = value;
                return this;
            }

            public NewAuthResponse.Builder SetAuthTicket(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasAuthTicket = true;
                this.result.authTicket_ = value;
                return this;
            }

            public NewAuthResponse.Builder SetAutoAuthTicket(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasAutoAuthTicket = true;
                this.result.autoAuthTicket_ = value;
                return this;
            }

            public NewAuthResponse.Builder SetBaseResponse(micromsg.BaseResponse value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = value;
                return this;
            }

            public NewAuthResponse.Builder SetBaseResponse(micromsg.BaseResponse.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = builderForValue.Build();
                return this;
            }

            public NewAuthResponse.Builder SetBindEmail(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBindEmail = true;
                this.result.bindEmail_ = value;
                return this;
            }

            public NewAuthResponse.Builder SetBindEmail(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBindEmail = true;
                this.result.bindEmail_ = builderForValue.Build();
                return this;
            }

            public NewAuthResponse.Builder SetBindMobile(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBindMobile = true;
                this.result.bindMobile_ = value;
                return this;
            }

            public NewAuthResponse.Builder SetBindMobile(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBindMobile = true;
                this.result.bindMobile_ = builderForValue.Build();
                return this;
            }

            public NewAuthResponse.Builder SetBindUin(uint value)
            {
                this.PrepareBuilder();
                this.result.hasBindUin = true;
                this.result.bindUin_ = value;
                return this;
            }

            public NewAuthResponse.Builder SetBuiltinIPList(micromsg.BuiltinIPList value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBuiltinIPList = true;
                this.result.builtinIPList_ = value;
                return this;
            }

            public NewAuthResponse.Builder SetBuiltinIPList(micromsg.BuiltinIPList.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBuiltinIPList = true;
                this.result.builtinIPList_ = builderForValue.Build();
                return this;
            }

            public NewAuthResponse.Builder SetDeviceInfoXml(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasDeviceInfoXml = true;
                this.result.deviceInfoXml_ = value;
                return this;
            }

            public NewAuthResponse.Builder SetDnsInfo(CDNDnsInfo value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasDnsInfo = true;
                this.result.dnsInfo_ = value;
                return this;
            }

            public NewAuthResponse.Builder SetDnsInfo(CDNDnsInfo.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasDnsInfo = true;
                this.result.dnsInfo_ = builderForValue.Build();
                return this;
            }

            public NewAuthResponse.Builder SetFSURL(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasFSURL = true;
                this.result.fSURL_ = value;
                return this;
            }

            public NewAuthResponse.Builder SetHintMsg(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasHintMsg = true;
                this.result.hintMsg_ = value;
                return this;
            }

            public NewAuthResponse.Builder SetImgBuf(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasImgBuf = true;
                this.result.imgBuf_ = value;
                return this;
            }

            public NewAuthResponse.Builder SetImgBuf(SKBuiltinBuffer_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasImgBuf = true;
                this.result.imgBuf_ = builderForValue.Build();
                return this;
            }

            public NewAuthResponse.Builder SetImgEncryptKey(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasImgEncryptKey = true;
                this.result.imgEncryptKey_ = value;
                return this;
            }

            public NewAuthResponse.Builder SetImgEncryptKey(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasImgEncryptKey = true;
                this.result.imgEncryptKey_ = builderForValue.Build();
                return this;
            }

            public NewAuthResponse.Builder SetImgSid(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasImgSid = true;
                this.result.imgSid_ = value;
                return this;
            }

            public NewAuthResponse.Builder SetImgSid(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasImgSid = true;
                this.result.imgSid_ = builderForValue.Build();
                return this;
            }

            public NewAuthResponse.Builder SetIsAutoReg(uint value)
            {
                this.PrepareBuilder();
                this.result.hasIsAutoReg = true;
                this.result.isAutoReg_ = value;
                return this;
            }

            public NewAuthResponse.Builder SetKickResponse(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasKickResponse = true;
                this.result.kickResponse_ = value;
                return this;
            }

            public NewAuthResponse.Builder SetKSid(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasKSid = true;
                this.result.kSid_ = value;
                return this;
            }

            public NewAuthResponse.Builder SetKSid(SKBuiltinBuffer_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasKSid = true;
                this.result.kSid_ = builderForValue.Build();
                return this;
            }

            public NewAuthResponse.Builder SetMainAcctType(uint value)
            {
                this.PrepareBuilder();
                this.result.hasMainAcctType = true;
                this.result.mainAcctType_ = value;
                return this;
            }

            public NewAuthResponse.Builder SetNeedSetEmailPwd(uint value)
            {
                this.PrepareBuilder();
                this.result.hasNeedSetEmailPwd = true;
                this.result.needSetEmailPwd_ = value;
                return this;
            }

            public NewAuthResponse.Builder SetNetworkControl(micromsg.NetworkControl value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasNetworkControl = true;
                this.result.networkControl_ = value;
                return this;
            }

            public NewAuthResponse.Builder SetNetworkControl(micromsg.NetworkControl.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasNetworkControl = true;
                this.result.networkControl_ = builderForValue.Build();
                return this;
            }

            public NewAuthResponse.Builder SetNewHostList(HostList value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasNewHostList = true;
                this.result.newHostList_ = value;
                return this;
            }

            public NewAuthResponse.Builder SetNewHostList(HostList.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasNewHostList = true;
                this.result.newHostList_ = builderForValue.Build();
                return this;
            }

            public NewAuthResponse.Builder SetNewVersion(uint value)
            {
                this.PrepareBuilder();
                this.result.hasNewVersion = true;
                this.result.newVersion_ = value;
                return this;
            }

            public NewAuthResponse.Builder SetNickName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasNickName = true;
                this.result.nickName_ = value;
                return this;
            }

            public NewAuthResponse.Builder SetNickName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasNickName = true;
                this.result.nickName_ = builderForValue.Build();
                return this;
            }

            public NewAuthResponse.Builder SetOfficialNickName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasOfficialNickName = true;
                this.result.officialNickName_ = value;
                return this;
            }

            public NewAuthResponse.Builder SetOfficialNickName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasOfficialNickName = true;
                this.result.officialNickName_ = builderForValue.Build();
                return this;
            }

            public NewAuthResponse.Builder SetOfficialUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasOfficialUserName = true;
                this.result.officialUserName_ = value;
                return this;
            }

            public NewAuthResponse.Builder SetOfficialUserName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasOfficialUserName = true;
                this.result.officialUserName_ = builderForValue.Build();
                return this;
            }

            public NewAuthResponse.Builder SetPassword(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasPassword = true;
                this.result.password_ = value;
                return this;
            }

            public NewAuthResponse.Builder SetPluginFlag(uint value)
            {
                this.PrepareBuilder();
                this.result.hasPluginFlag = true;
                this.result.pluginFlag_ = value;
                return this;
            }

            public NewAuthResponse.Builder SetPluginKeyList(micromsg.PluginKeyList value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasPluginKeyList = true;
                this.result.pluginKeyList_ = value;
                return this;
            }

            public NewAuthResponse.Builder SetPluginKeyList(micromsg.PluginKeyList.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasPluginKeyList = true;
                this.result.pluginKeyList_ = builderForValue.Build();
                return this;
            }

            public NewAuthResponse.Builder SetProfileFlag(uint value)
            {
                this.PrepareBuilder();
                this.result.hasProfileFlag = true;
                this.result.profileFlag_ = value;
                return this;
            }

            public NewAuthResponse.Builder SetPushMailSettingTicket(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasPushMailSettingTicket = true;
                this.result.pushMailSettingTicket_ = value;
                return this;
            }

            public NewAuthResponse.Builder SetPushMailStatus(uint value)
            {
                this.PrepareBuilder();
                this.result.hasPushMailStatus = true;
                this.result.pushMailStatus_ = value;
                return this;
            }

            public NewAuthResponse.Builder SetQQMicroBlogStatus(uint value)
            {
                this.PrepareBuilder();
                this.result.hasQQMicroBlogStatus = true;
                this.result.qQMicroBlogStatus_ = value;
                return this;
            }

            public NewAuthResponse.Builder SetQQMicroBlogUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasQQMicroBlogUserName = true;
                this.result.qQMicroBlogUserName_ = value;
                return this;
            }

            public NewAuthResponse.Builder SetQQMicroBlogUserName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasQQMicroBlogUserName = true;
                this.result.qQMicroBlogUserName_ = builderForValue.Build();
                return this;
            }

            public NewAuthResponse.Builder SetRegType(uint value)
            {
                this.PrepareBuilder();
                this.result.hasRegType = true;
                this.result.regType_ = value;
                return this;
            }

            public NewAuthResponse.Builder SetSafeDevice(uint value)
            {
                this.PrepareBuilder();
                this.result.hasSafeDevice = true;
                this.result.safeDevice_ = value;
                return this;
            }

            public NewAuthResponse.Builder SetSendCardBitFlag(uint value)
            {
                this.PrepareBuilder();
                this.result.hasSendCardBitFlag = true;
                this.result.sendCardBitFlag_ = value;
                return this;
            }

            public NewAuthResponse.Builder SetSessionKey(ByteString value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSessionKey = true;
                this.result.sessionKey_ = value;
                return this;
            }

            public NewAuthResponse.Builder SetSid(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSid = true;
                this.result.sid_ = value;
                return this;
            }

            public NewAuthResponse.Builder SetSoftConfigXml(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSoftConfigXml = true;
                this.result.softConfigXml_ = value;
                return this;
            }

            public NewAuthResponse.Builder SetStatus(uint value)
            {
                this.PrepareBuilder();
                this.result.hasStatus = true;
                this.result.status_ = value;
                return this;
            }

            public NewAuthResponse.Builder SetTicket(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasTicket = true;
                this.result.ticket_ = value;
                return this;
            }

            public NewAuthResponse.Builder SetTimeStamp(uint value)
            {
                this.PrepareBuilder();
                this.result.hasTimeStamp = true;
                this.result.timeStamp_ = value;
                return this;
            }

            public NewAuthResponse.Builder SetUin(uint value)
            {
                this.PrepareBuilder();
                this.result.hasUin = true;
                this.result.uin_ = value;
                return this;
            }

            public NewAuthResponse.Builder SetUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasUserName = true;
                this.result.userName_ = value;
                return this;
            }

            public NewAuthResponse.Builder SetUserName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasUserName = true;
                this.result.userName_ = builderForValue.Build();
                return this;
            }

            public SKBuiltinBuffer_t A2Key
            {
                get
                {
                    return this.result.A2Key;
                }
                set
                {
                    this.SetA2Key(value);
                }
            }

            public string Alias
            {
                get
                {
                    return this.result.Alias;
                }
                set
                {
                    this.SetAlias(value);
                }
            }

            public string ApplyBetaUrl
            {
                get
                {
                    return this.result.ApplyBetaUrl;
                }
                set
                {
                    this.SetApplyBetaUrl(value);
                }
            }

            public string AuthKey
            {
                get
                {
                    return this.result.AuthKey;
                }
                set
                {
                    this.SetAuthKey(value);
                }
            }

            public string AuthTicket
            {
                get
                {
                    return this.result.AuthTicket;
                }
                set
                {
                    this.SetAuthTicket(value);
                }
            }

            public string AutoAuthTicket
            {
                get
                {
                    return this.result.AutoAuthTicket;
                }
                set
                {
                    this.SetAutoAuthTicket(value);
                }
            }

            public micromsg.BaseResponse BaseResponse
            {
                get
                {
                    return this.result.BaseResponse;
                }
                set
                {
                    this.SetBaseResponse(value);
                }
            }

            public SKBuiltinString_t BindEmail
            {
                get
                {
                    return this.result.BindEmail;
                }
                set
                {
                    this.SetBindEmail(value);
                }
            }

            public SKBuiltinString_t BindMobile
            {
                get
                {
                    return this.result.BindMobile;
                }
                set
                {
                    this.SetBindMobile(value);
                }
            }

            public uint BindUin
            {
                get
                {
                    return this.result.BindUin;
                }
                set
                {
                    this.SetBindUin(value);
                }
            }

            public micromsg.BuiltinIPList BuiltinIPList
            {
                get
                {
                    return this.result.BuiltinIPList;
                }
                set
                {
                    this.SetBuiltinIPList(value);
                }
            }

            public override NewAuthResponse DefaultInstanceForType
            {
                get
                {
                    return NewAuthResponse.DefaultInstance;
                }
            }

            public string DeviceInfoXml
            {
                get
                {
                    return this.result.DeviceInfoXml;
                }
                set
                {
                    this.SetDeviceInfoXml(value);
                }
            }

            public CDNDnsInfo DnsInfo
            {
                get
                {
                    return this.result.DnsInfo;
                }
                set
                {
                    this.SetDnsInfo(value);
                }
            }

            public string FSURL
            {
                get
                {
                    return this.result.FSURL;
                }
                set
                {
                    this.SetFSURL(value);
                }
            }

            public string HintMsg
            {
                get
                {
                    return this.result.HintMsg;
                }
                set
                {
                    this.SetHintMsg(value);
                }
            }

            public SKBuiltinBuffer_t ImgBuf
            {
                get
                {
                    return this.result.ImgBuf;
                }
                set
                {
                    this.SetImgBuf(value);
                }
            }

            public SKBuiltinString_t ImgEncryptKey
            {
                get
                {
                    return this.result.ImgEncryptKey;
                }
                set
                {
                    this.SetImgEncryptKey(value);
                }
            }

            public SKBuiltinString_t ImgSid
            {
                get
                {
                    return this.result.ImgSid;
                }
                set
                {
                    this.SetImgSid(value);
                }
            }

            public uint IsAutoReg
            {
                get
                {
                    return this.result.IsAutoReg;
                }
                set
                {
                    this.SetIsAutoReg(value);
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            public string KickResponse
            {
                get
                {
                    return this.result.KickResponse;
                }
                set
                {
                    this.SetKickResponse(value);
                }
            }

            public SKBuiltinBuffer_t KSid
            {
                get
                {
                    return this.result.KSid;
                }
                set
                {
                    this.SetKSid(value);
                }
            }

            public uint MainAcctType
            {
                get
                {
                    return this.result.MainAcctType;
                }
                set
                {
                    this.SetMainAcctType(value);
                }
            }

            protected override NewAuthResponse MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public uint NeedSetEmailPwd
            {
                get
                {
                    return this.result.NeedSetEmailPwd;
                }
                set
                {
                    this.SetNeedSetEmailPwd(value);
                }
            }

            public micromsg.NetworkControl NetworkControl
            {
                get
                {
                    return this.result.NetworkControl;
                }
                set
                {
                    this.SetNetworkControl(value);
                }
            }

            public HostList NewHostList
            {
                get
                {
                    return this.result.NewHostList;
                }
                set
                {
                    this.SetNewHostList(value);
                }
            }

            public uint NewVersion
            {
                get
                {
                    return this.result.NewVersion;
                }
                set
                {
                    this.SetNewVersion(value);
                }
            }

            public SKBuiltinString_t NickName
            {
                get
                {
                    return this.result.NickName;
                }
                set
                {
                    this.SetNickName(value);
                }
            }

            public SKBuiltinString_t OfficialNickName
            {
                get
                {
                    return this.result.OfficialNickName;
                }
                set
                {
                    this.SetOfficialNickName(value);
                }
            }

            public SKBuiltinString_t OfficialUserName
            {
                get
                {
                    return this.result.OfficialUserName;
                }
                set
                {
                    this.SetOfficialUserName(value);
                }
            }

            public string Password
            {
                get
                {
                    return this.result.Password;
                }
                set
                {
                    this.SetPassword(value);
                }
            }

            public uint PluginFlag
            {
                get
                {
                    return this.result.PluginFlag;
                }
                set
                {
                    this.SetPluginFlag(value);
                }
            }

            public micromsg.PluginKeyList PluginKeyList
            {
                get
                {
                    return this.result.PluginKeyList;
                }
                set
                {
                    this.SetPluginKeyList(value);
                }
            }

            public uint ProfileFlag
            {
                get
                {
                    return this.result.ProfileFlag;
                }
                set
                {
                    this.SetProfileFlag(value);
                }
            }

            public string PushMailSettingTicket
            {
                get
                {
                    return this.result.PushMailSettingTicket;
                }
                set
                {
                    this.SetPushMailSettingTicket(value);
                }
            }

            public uint PushMailStatus
            {
                get
                {
                    return this.result.PushMailStatus;
                }
                set
                {
                    this.SetPushMailStatus(value);
                }
            }

            public uint QQMicroBlogStatus
            {
                get
                {
                    return this.result.QQMicroBlogStatus;
                }
                set
                {
                    this.SetQQMicroBlogStatus(value);
                }
            }

            public SKBuiltinString_t QQMicroBlogUserName
            {
                get
                {
                    return this.result.QQMicroBlogUserName;
                }
                set
                {
                    this.SetQQMicroBlogUserName(value);
                }
            }

            public uint RegType
            {
                get
                {
                    return this.result.RegType;
                }
                set
                {
                    this.SetRegType(value);
                }
            }

            public uint SafeDevice
            {
                get
                {
                    return this.result.SafeDevice;
                }
                set
                {
                    this.SetSafeDevice(value);
                }
            }

            public uint SendCardBitFlag
            {
                get
                {
                    return this.result.SendCardBitFlag;
                }
                set
                {
                    this.SetSendCardBitFlag(value);
                }
            }

            public ByteString SessionKey
            {
                get
                {
                    return this.result.SessionKey;
                }
                set
                {
                    this.SetSessionKey(value);
                }
            }

            public string Sid
            {
                get
                {
                    return this.result.Sid;
                }
                set
                {
                    this.SetSid(value);
                }
            }

            public string SoftConfigXml
            {
                get
                {
                    return this.result.SoftConfigXml;
                }
                set
                {
                    this.SetSoftConfigXml(value);
                }
            }

            public uint Status
            {
                get
                {
                    return this.result.Status;
                }
                set
                {
                    this.SetStatus(value);
                }
            }

            protected override NewAuthResponse.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }

            public string Ticket
            {
                get
                {
                    return this.result.Ticket;
                }
                set
                {
                    this.SetTicket(value);
                }
            }

            public uint TimeStamp
            {
                get
                {
                    return this.result.TimeStamp;
                }
                set
                {
                    this.SetTimeStamp(value);
                }
            }

            public uint Uin
            {
                get
                {
                    return this.result.Uin;
                }
                set
                {
                    this.SetUin(value);
                }
            }

            public SKBuiltinString_t UserName
            {
                get
                {
                    return this.result.UserName;
                }
                set
                {
                    this.SetUserName(value);
                }
            }
        }
    }
}


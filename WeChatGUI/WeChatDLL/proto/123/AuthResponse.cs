namespace micromsg
{
    using Google.ProtocolBuffers;
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Runtime.CompilerServices;

    public sealed class AuthResponse : GeneratedMessageLite<AuthResponse, AuthResponse.Builder>
    {
        private static readonly string[] _AuthResponseFieldNames = new string[] { 
            "A2Key", "Alias", "AppDnsInfo", "ApplyBetaUrl", "AuthKey", "AuthTicket", "AutoAuthTicket", "BaseResponse", "BindEmail", "BindMobile", "BindUin", "BuiltinIPList", "CliDBEncryptInfo", "CliDBEncryptKey", "DeviceInfoXml", "DnsInfo", 
            "FSURL", "Flag", "HintMsg", "ImgBuf", "ImgEncryptKey", "ImgSid", "IsAutoReg", "KSid", "KickResponse", "NeedSetEmailPwd", "NetworkControl", "NewHostList", "NewVersion", "NextAuthType", "NickName", "ObsoleteItem1", 
            "OfficialNickName", "OfficialUserName", "Password", "PluginFlag", "PluginKeyList", "ProfileFlag", "PushMailSettingTicket", "PushMailStatus", "QQMicroBlogStatus", "QQMicroBlogUserName", "RegType", "SafeDevice", "SendCardBitFlag", "SessionKey", "ShowStyle", "Sid", 
            "SnsDnsInfo", "SoftConfigXml", "Status", "Ticket", "TimeStamp", "Uin", "UserName", "VerifyBuff", "VerifySignature", "WTLoginRspBuff"
         };
        private static readonly uint[] _AuthResponseFieldTags = new uint[] { 
            250, 0xca, 450, 0x132, 0xda, 0x152, 0x17a, 10, 50, 0x3a, 40, 170, 0x1aa, 0x1a2, 0x13a, 0x182, 
            0xb2, 0x1b0, 370, 90, 0xf2, 0x52, 0x120, 0x102, 0x12a, 360, 0xba, 330, 0x80, 0x188, 0x22, 0x160, 
            0x6a, 0x62, 0x112, 0xc0, 0xea, 0x108, 0xa2, 0x90, 120, 0x72, 0xd0, 0x158, 0x98, 0x4a, 410, 0xe2, 
            0x1ba, 0x142, 0x40, 0x8a, 280, 0x10, 0x1a, 0x1d2, 0x1ca, 0x192
         };
        private SKBuiltinBuffer_t a2Key_;
        public const int A2KeyFieldNumber = 0x1f;
        private string alias_ = "";
        public const int AliasFieldNumber = 0x19;
        private CDNDnsInfo appDnsInfo_;
        public const int AppDnsInfoFieldNumber = 0x38;
        private string applyBetaUrl_ = "";
        public const int ApplyBetaUrlFieldNumber = 0x26;
        private string authKey_ = "";
        public const int AuthKeyFieldNumber = 0x1b;
        private string authTicket_ = "";
        public const int AuthTicketFieldNumber = 0x2a;
        private string autoAuthTicket_ = "";
        public const int AutoAuthTicketFieldNumber = 0x2f;
        private BaseResponse baseResponse_;
        public const int BaseResponseFieldNumber = 1;
        private SKBuiltinString_t bindEmail_;
        public const int BindEmailFieldNumber = 6;
        private SKBuiltinString_t bindMobile_;
        public const int BindMobileFieldNumber = 7;
        private uint bindUin_;
        public const int BindUinFieldNumber = 5;
        private BuiltinIPList builtinIPList_;
        public const int BuiltinIPListFieldNumber = 0x15;
        private SKBuiltinBuffer_t cliDBEncryptInfo_;
        public const int CliDBEncryptInfoFieldNumber = 0x35;
        private SKBuiltinBuffer_t cliDBEncryptKey_;
        public const int CliDBEncryptKeyFieldNumber = 0x34;
        private static readonly AuthResponse defaultInstance = new AuthResponse().MakeReadOnly();
        private string deviceInfoXml_ = "";
        public const int DeviceInfoXmlFieldNumber = 0x27;
        private CDNDnsInfo dnsInfo_;
        public const int DnsInfoFieldNumber = 0x30;
        private uint flag_;
        public const int FlagFieldNumber = 0x36;
        private string fSURL_ = "";
        public const int FSURLFieldNumber = 0x16;
        private bool hasA2Key;
        private bool hasAlias;
        private bool hasAppDnsInfo;
        private bool hasApplyBetaUrl;
        private bool hasAuthKey;
        private bool hasAuthTicket;
        private bool hasAutoAuthTicket;
        private bool hasBaseResponse;
        private bool hasBindEmail;
        private bool hasBindMobile;
        private bool hasBindUin;
        private bool hasBuiltinIPList;
        private bool hasCliDBEncryptInfo;
        private bool hasCliDBEncryptKey;
        private bool hasDeviceInfoXml;
        private bool hasDnsInfo;
        private bool hasFlag;
        private bool hasFSURL;
        private bool hasHintMsg;
        private bool hasImgBuf;
        private bool hasImgEncryptKey;
        private bool hasImgSid;
        private bool hasIsAutoReg;
        private bool hasKickResponse;
        private bool hasKSid;
        private bool hasNeedSetEmailPwd;
        private bool hasNetworkControl;
        private bool hasNewHostList;
        private bool hasNewVersion;
        private bool hasNextAuthType;
        private bool hasNickName;
        private bool hasObsoleteItem1;
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
        private bool hasShowStyle;
        private bool hasSid;
        private bool hasSnsDnsInfo;
        private bool hasSoftConfigXml;
        private bool hasStatus;
        private bool hasTicket;
        private bool hasTimeStamp;
        private bool hasUin;
        private bool hasUserName;
        private bool hasVerifyBuff;
        private bool hasVerifySignature;
        private bool hasWTLoginRspBuff;
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
        private int memoizedSerializedSize = -1;
        private uint needSetEmailPwd_;
        public const int NeedSetEmailPwdFieldNumber = 0x2d;
        private NetworkControl networkControl_;
        public const int NetworkControlFieldNumber = 0x17;
        private HostList newHostList_;
        public const int NewHostListFieldNumber = 0x29;
        private uint newVersion_;
        public const int NewVersionFieldNumber = 0x10;
        private uint nextAuthType_;
        public const int NextAuthTypeFieldNumber = 0x31;
        private SKBuiltinString_t nickName_;
        public const int NickNameFieldNumber = 4;
        private uint obsoleteItem1_;
        public const int ObsoleteItem1FieldNumber = 0x2c;
        private SKBuiltinString_t officialNickName_;
        public const int OfficialNickNameFieldNumber = 13;
        private SKBuiltinString_t officialUserName_;
        public const int OfficialUserNameFieldNumber = 12;
        private string password_ = "";
        public const int PasswordFieldNumber = 0x22;
        private uint pluginFlag_;
        public const int PluginFlagFieldNumber = 0x18;
        private PluginKeyList pluginKeyList_;
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
        private ShowStyleKey showStyle_;
        public const int ShowStyleFieldNumber = 0x33;
        private string sid_ = "";
        public const int SidFieldNumber = 0x1c;
        private CDNDnsInfo snsDnsInfo_;
        public const int SnsDnsInfoFieldNumber = 0x37;
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
        private SKBuiltinBuffer_t verifyBuff_;
        public const int VerifyBuffFieldNumber = 0x3a;
        private string verifySignature_ = "";
        public const int VerifySignatureFieldNumber = 0x39;
        private SKBuiltinBuffer_t wTLoginRspBuff_;
        public const int WTLoginRspBuffFieldNumber = 50;

        static AuthResponse()
        {

        }

        private AuthResponse()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(AuthResponse prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            AuthResponse response = obj as AuthResponse;
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
            if ((this.hasObsoleteItem1 != response.hasObsoleteItem1) || (this.hasObsoleteItem1 && !this.obsoleteItem1_.Equals(response.obsoleteItem1_)))
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
            if ((this.hasDnsInfo != response.hasDnsInfo) || (this.hasDnsInfo && !this.dnsInfo_.Equals(response.dnsInfo_)))
            {
                return false;
            }
            if ((this.hasNextAuthType != response.hasNextAuthType) || (this.hasNextAuthType && !this.nextAuthType_.Equals(response.nextAuthType_)))
            {
                return false;
            }
            if ((this.hasWTLoginRspBuff != response.hasWTLoginRspBuff) || (this.hasWTLoginRspBuff && !this.wTLoginRspBuff_.Equals(response.wTLoginRspBuff_)))
            {
                return false;
            }
            if ((this.hasShowStyle != response.hasShowStyle) || (this.hasShowStyle && !this.showStyle_.Equals(response.showStyle_)))
            {
                return false;
            }
            if ((this.hasCliDBEncryptKey != response.hasCliDBEncryptKey) || (this.hasCliDBEncryptKey && !this.cliDBEncryptKey_.Equals(response.cliDBEncryptKey_)))
            {
                return false;
            }
            if ((this.hasCliDBEncryptInfo != response.hasCliDBEncryptInfo) || (this.hasCliDBEncryptInfo && !this.cliDBEncryptInfo_.Equals(response.cliDBEncryptInfo_)))
            {
                return false;
            }
            if ((this.hasFlag != response.hasFlag) || (this.hasFlag && !this.flag_.Equals(response.flag_)))
            {
                return false;
            }
            if ((this.hasSnsDnsInfo != response.hasSnsDnsInfo) || (this.hasSnsDnsInfo && !this.snsDnsInfo_.Equals(response.snsDnsInfo_)))
            {
                return false;
            }
            if ((this.hasAppDnsInfo != response.hasAppDnsInfo) || (this.hasAppDnsInfo && !this.appDnsInfo_.Equals(response.appDnsInfo_)))
            {
                return false;
            }
            if ((this.hasVerifySignature != response.hasVerifySignature) || (this.hasVerifySignature && !this.verifySignature_.Equals(response.verifySignature_)))
            {
                return false;
            }
            return ((this.hasVerifyBuff == response.hasVerifyBuff) && (!this.hasVerifyBuff || this.verifyBuff_.Equals(response.verifyBuff_)));
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
            if (this.hasObsoleteItem1)
            {
                hashCode ^= this.obsoleteItem1_.GetHashCode();
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
            if (this.hasNextAuthType)
            {
                hashCode ^= this.nextAuthType_.GetHashCode();
            }
            if (this.hasWTLoginRspBuff)
            {
                hashCode ^= this.wTLoginRspBuff_.GetHashCode();
            }
            if (this.hasShowStyle)
            {
                hashCode ^= this.showStyle_.GetHashCode();
            }
            if (this.hasCliDBEncryptKey)
            {
                hashCode ^= this.cliDBEncryptKey_.GetHashCode();
            }
            if (this.hasCliDBEncryptInfo)
            {
                hashCode ^= this.cliDBEncryptInfo_.GetHashCode();
            }
            if (this.hasFlag)
            {
                hashCode ^= this.flag_.GetHashCode();
            }
            if (this.hasSnsDnsInfo)
            {
                hashCode ^= this.snsDnsInfo_.GetHashCode();
            }
            if (this.hasAppDnsInfo)
            {
                hashCode ^= this.appDnsInfo_.GetHashCode();
            }
            if (this.hasVerifySignature)
            {
                hashCode ^= this.verifySignature_.GetHashCode();
            }
            if (this.hasVerifyBuff)
            {
                hashCode ^= this.verifyBuff_.GetHashCode();
            }
            return hashCode;
        }

        private AuthResponse MakeReadOnly()
        {
            return this;
        }

        public static AuthResponse ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<AuthResponse, Builder>.PrintField("BaseResponse", this.hasBaseResponse, this.baseResponse_, writer);
            GeneratedMessageLite<AuthResponse, Builder>.PrintField("Uin", this.hasUin, this.uin_, writer);
            GeneratedMessageLite<AuthResponse, Builder>.PrintField("UserName", this.hasUserName, this.userName_, writer);
            GeneratedMessageLite<AuthResponse, Builder>.PrintField("NickName", this.hasNickName, this.nickName_, writer);
            GeneratedMessageLite<AuthResponse, Builder>.PrintField("BindUin", this.hasBindUin, this.bindUin_, writer);
            GeneratedMessageLite<AuthResponse, Builder>.PrintField("BindEmail", this.hasBindEmail, this.bindEmail_, writer);
            GeneratedMessageLite<AuthResponse, Builder>.PrintField("BindMobile", this.hasBindMobile, this.bindMobile_, writer);
            GeneratedMessageLite<AuthResponse, Builder>.PrintField("Status", this.hasStatus, this.status_, writer);
            GeneratedMessageLite<AuthResponse, Builder>.PrintField("SessionKey", this.hasSessionKey, this.sessionKey_, writer);
            GeneratedMessageLite<AuthResponse, Builder>.PrintField("ImgSid", this.hasImgSid, this.imgSid_, writer);
            GeneratedMessageLite<AuthResponse, Builder>.PrintField("ImgBuf", this.hasImgBuf, this.imgBuf_, writer);
            GeneratedMessageLite<AuthResponse, Builder>.PrintField("OfficialUserName", this.hasOfficialUserName, this.officialUserName_, writer);
            GeneratedMessageLite<AuthResponse, Builder>.PrintField("OfficialNickName", this.hasOfficialNickName, this.officialNickName_, writer);
            GeneratedMessageLite<AuthResponse, Builder>.PrintField("QQMicroBlogUserName", this.hasQQMicroBlogUserName, this.qQMicroBlogUserName_, writer);
            GeneratedMessageLite<AuthResponse, Builder>.PrintField("QQMicroBlogStatus", this.hasQQMicroBlogStatus, this.qQMicroBlogStatus_, writer);
            GeneratedMessageLite<AuthResponse, Builder>.PrintField("NewVersion", this.hasNewVersion, this.newVersion_, writer);
            GeneratedMessageLite<AuthResponse, Builder>.PrintField("Ticket", this.hasTicket, this.ticket_, writer);
            GeneratedMessageLite<AuthResponse, Builder>.PrintField("PushMailStatus", this.hasPushMailStatus, this.pushMailStatus_, writer);
            GeneratedMessageLite<AuthResponse, Builder>.PrintField("SendCardBitFlag", this.hasSendCardBitFlag, this.sendCardBitFlag_, writer);
            GeneratedMessageLite<AuthResponse, Builder>.PrintField("PushMailSettingTicket", this.hasPushMailSettingTicket, this.pushMailSettingTicket_, writer);
            GeneratedMessageLite<AuthResponse, Builder>.PrintField("BuiltinIPList", this.hasBuiltinIPList, this.builtinIPList_, writer);
            GeneratedMessageLite<AuthResponse, Builder>.PrintField("FSURL", this.hasFSURL, this.fSURL_, writer);
            GeneratedMessageLite<AuthResponse, Builder>.PrintField("NetworkControl", this.hasNetworkControl, this.networkControl_, writer);
            GeneratedMessageLite<AuthResponse, Builder>.PrintField("PluginFlag", this.hasPluginFlag, this.pluginFlag_, writer);
            GeneratedMessageLite<AuthResponse, Builder>.PrintField("Alias", this.hasAlias, this.alias_, writer);
            GeneratedMessageLite<AuthResponse, Builder>.PrintField("RegType", this.hasRegType, this.regType_, writer);
            GeneratedMessageLite<AuthResponse, Builder>.PrintField("AuthKey", this.hasAuthKey, this.authKey_, writer);
            GeneratedMessageLite<AuthResponse, Builder>.PrintField("Sid", this.hasSid, this.sid_, writer);
            GeneratedMessageLite<AuthResponse, Builder>.PrintField("PluginKeyList", this.hasPluginKeyList, this.pluginKeyList_, writer);
            GeneratedMessageLite<AuthResponse, Builder>.PrintField("ImgEncryptKey", this.hasImgEncryptKey, this.imgEncryptKey_, writer);
            GeneratedMessageLite<AuthResponse, Builder>.PrintField("A2Key", this.hasA2Key, this.a2Key_, writer);
            GeneratedMessageLite<AuthResponse, Builder>.PrintField("KSid", this.hasKSid, this.kSid_, writer);
            GeneratedMessageLite<AuthResponse, Builder>.PrintField("ProfileFlag", this.hasProfileFlag, this.profileFlag_, writer);
            GeneratedMessageLite<AuthResponse, Builder>.PrintField("Password", this.hasPassword, this.password_, writer);
            GeneratedMessageLite<AuthResponse, Builder>.PrintField("TimeStamp", this.hasTimeStamp, this.timeStamp_, writer);
            GeneratedMessageLite<AuthResponse, Builder>.PrintField("IsAutoReg", this.hasIsAutoReg, this.isAutoReg_, writer);
            GeneratedMessageLite<AuthResponse, Builder>.PrintField("KickResponse", this.hasKickResponse, this.kickResponse_, writer);
            GeneratedMessageLite<AuthResponse, Builder>.PrintField("ApplyBetaUrl", this.hasApplyBetaUrl, this.applyBetaUrl_, writer);
            GeneratedMessageLite<AuthResponse, Builder>.PrintField("DeviceInfoXml", this.hasDeviceInfoXml, this.deviceInfoXml_, writer);
            GeneratedMessageLite<AuthResponse, Builder>.PrintField("SoftConfigXml", this.hasSoftConfigXml, this.softConfigXml_, writer);
            GeneratedMessageLite<AuthResponse, Builder>.PrintField("NewHostList", this.hasNewHostList, this.newHostList_, writer);
            GeneratedMessageLite<AuthResponse, Builder>.PrintField("AuthTicket", this.hasAuthTicket, this.authTicket_, writer);
            GeneratedMessageLite<AuthResponse, Builder>.PrintField("SafeDevice", this.hasSafeDevice, this.safeDevice_, writer);
            GeneratedMessageLite<AuthResponse, Builder>.PrintField("ObsoleteItem1", this.hasObsoleteItem1, this.obsoleteItem1_, writer);
            GeneratedMessageLite<AuthResponse, Builder>.PrintField("NeedSetEmailPwd", this.hasNeedSetEmailPwd, this.needSetEmailPwd_, writer);
            GeneratedMessageLite<AuthResponse, Builder>.PrintField("HintMsg", this.hasHintMsg, this.hintMsg_, writer);
            GeneratedMessageLite<AuthResponse, Builder>.PrintField("AutoAuthTicket", this.hasAutoAuthTicket, this.autoAuthTicket_, writer);
            GeneratedMessageLite<AuthResponse, Builder>.PrintField("DnsInfo", this.hasDnsInfo, this.dnsInfo_, writer);
            GeneratedMessageLite<AuthResponse, Builder>.PrintField("NextAuthType", this.hasNextAuthType, this.nextAuthType_, writer);
            GeneratedMessageLite<AuthResponse, Builder>.PrintField("WTLoginRspBuff", this.hasWTLoginRspBuff, this.wTLoginRspBuff_, writer);
            GeneratedMessageLite<AuthResponse, Builder>.PrintField("ShowStyle", this.hasShowStyle, this.showStyle_, writer);
            GeneratedMessageLite<AuthResponse, Builder>.PrintField("CliDBEncryptKey", this.hasCliDBEncryptKey, this.cliDBEncryptKey_, writer);
            GeneratedMessageLite<AuthResponse, Builder>.PrintField("CliDBEncryptInfo", this.hasCliDBEncryptInfo, this.cliDBEncryptInfo_, writer);
            GeneratedMessageLite<AuthResponse, Builder>.PrintField("Flag", this.hasFlag, this.flag_, writer);
            GeneratedMessageLite<AuthResponse, Builder>.PrintField("SnsDnsInfo", this.hasSnsDnsInfo, this.snsDnsInfo_, writer);
            GeneratedMessageLite<AuthResponse, Builder>.PrintField("AppDnsInfo", this.hasAppDnsInfo, this.appDnsInfo_, writer);
            GeneratedMessageLite<AuthResponse, Builder>.PrintField("VerifySignature", this.hasVerifySignature, this.verifySignature_, writer);
            GeneratedMessageLite<AuthResponse, Builder>.PrintField("VerifyBuff", this.hasVerifyBuff, this.verifyBuff_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _AuthResponseFieldNames;
            if (this.hasBaseResponse)
            {
                output.WriteMessage(1, strArray[7], this.BaseResponse);
            }
            if (this.hasUin)
            {
                output.WriteUInt32(2, strArray[0x35], this.Uin);
            }
            if (this.hasUserName)
            {
                output.WriteMessage(3, strArray[0x36], this.UserName);
            }
            if (this.hasNickName)
            {
                output.WriteMessage(4, strArray[30], this.NickName);
            }
            if (this.hasBindUin)
            {
                output.WriteUInt32(5, strArray[10], this.BindUin);
            }
            if (this.hasBindEmail)
            {
                output.WriteMessage(6, strArray[8], this.BindEmail);
            }
            if (this.hasBindMobile)
            {
                output.WriteMessage(7, strArray[9], this.BindMobile);
            }
            if (this.hasStatus)
            {
                output.WriteUInt32(8, strArray[50], this.Status);
            }
            if (this.hasSessionKey)
            {
                output.WriteBytes(9, strArray[0x2d], this.SessionKey);
            }
            if (this.hasImgSid)
            {
                output.WriteMessage(10, strArray[0x15], this.ImgSid);
            }
            if (this.hasImgBuf)
            {
                output.WriteMessage(11, strArray[0x13], this.ImgBuf);
            }
            if (this.hasOfficialUserName)
            {
                output.WriteMessage(12, strArray[0x21], this.OfficialUserName);
            }
            if (this.hasOfficialNickName)
            {
                output.WriteMessage(13, strArray[0x20], this.OfficialNickName);
            }
            if (this.hasQQMicroBlogUserName)
            {
                output.WriteMessage(14, strArray[0x29], this.QQMicroBlogUserName);
            }
            if (this.hasQQMicroBlogStatus)
            {
                output.WriteUInt32(15, strArray[40], this.QQMicroBlogStatus);
            }
            if (this.hasNewVersion)
            {
                output.WriteUInt32(0x10, strArray[0x1c], this.NewVersion);
            }
            if (this.hasTicket)
            {
                output.WriteString(0x11, strArray[0x33], this.Ticket);
            }
            if (this.hasPushMailStatus)
            {
                output.WriteUInt32(0x12, strArray[0x27], this.PushMailStatus);
            }
            if (this.hasSendCardBitFlag)
            {
                output.WriteUInt32(0x13, strArray[0x2c], this.SendCardBitFlag);
            }
            if (this.hasPushMailSettingTicket)
            {
                output.WriteString(20, strArray[0x26], this.PushMailSettingTicket);
            }
            if (this.hasBuiltinIPList)
            {
                output.WriteMessage(0x15, strArray[11], this.BuiltinIPList);
            }
            if (this.hasFSURL)
            {
                output.WriteString(0x16, strArray[0x10], this.FSURL);
            }
            if (this.hasNetworkControl)
            {
                output.WriteMessage(0x17, strArray[0x1a], this.NetworkControl);
            }
            if (this.hasPluginFlag)
            {
                output.WriteUInt32(0x18, strArray[0x23], this.PluginFlag);
            }
            if (this.hasAlias)
            {
                output.WriteString(0x19, strArray[1], this.Alias);
            }
            if (this.hasRegType)
            {
                output.WriteUInt32(0x1a, strArray[0x2a], this.RegType);
            }
            if (this.hasAuthKey)
            {
                output.WriteString(0x1b, strArray[4], this.AuthKey);
            }
            if (this.hasSid)
            {
                output.WriteString(0x1c, strArray[0x2f], this.Sid);
            }
            if (this.hasPluginKeyList)
            {
                output.WriteMessage(0x1d, strArray[0x24], this.PluginKeyList);
            }
            if (this.hasImgEncryptKey)
            {
                output.WriteMessage(30, strArray[20], this.ImgEncryptKey);
            }
            if (this.hasA2Key)
            {
                output.WriteMessage(0x1f, strArray[0], this.A2Key);
            }
            if (this.hasKSid)
            {
                output.WriteMessage(0x20, strArray[0x17], this.KSid);
            }
            if (this.hasProfileFlag)
            {
                output.WriteUInt32(0x21, strArray[0x25], this.ProfileFlag);
            }
            if (this.hasPassword)
            {
                output.WriteString(0x22, strArray[0x22], this.Password);
            }
            if (this.hasTimeStamp)
            {
                output.WriteUInt32(0x23, strArray[0x34], this.TimeStamp);
            }
            if (this.hasIsAutoReg)
            {
                output.WriteUInt32(0x24, strArray[0x16], this.IsAutoReg);
            }
            if (this.hasKickResponse)
            {
                output.WriteString(0x25, strArray[0x18], this.KickResponse);
            }
            if (this.hasApplyBetaUrl)
            {
                output.WriteString(0x26, strArray[3], this.ApplyBetaUrl);
            }
            if (this.hasDeviceInfoXml)
            {
                output.WriteString(0x27, strArray[14], this.DeviceInfoXml);
            }
            if (this.hasSoftConfigXml)
            {
                output.WriteString(40, strArray[0x31], this.SoftConfigXml);
            }
            if (this.hasNewHostList)
            {
                output.WriteMessage(0x29, strArray[0x1b], this.NewHostList);
            }
            if (this.hasAuthTicket)
            {
                output.WriteString(0x2a, strArray[5], this.AuthTicket);
            }
            if (this.hasSafeDevice)
            {
                output.WriteUInt32(0x2b, strArray[0x2b], this.SafeDevice);
            }
            if (this.hasObsoleteItem1)
            {
                output.WriteUInt32(0x2c, strArray[0x1f], this.ObsoleteItem1);
            }
            if (this.hasNeedSetEmailPwd)
            {
                output.WriteUInt32(0x2d, strArray[0x19], this.NeedSetEmailPwd);
            }
            if (this.hasHintMsg)
            {
                output.WriteString(0x2e, strArray[0x12], this.HintMsg);
            }
            if (this.hasAutoAuthTicket)
            {
                output.WriteString(0x2f, strArray[6], this.AutoAuthTicket);
            }
            if (this.hasDnsInfo)
            {
                output.WriteMessage(0x30, strArray[15], this.DnsInfo);
            }
            if (this.hasNextAuthType)
            {
                output.WriteUInt32(0x31, strArray[0x1d], this.NextAuthType);
            }
            if (this.hasWTLoginRspBuff)
            {
                output.WriteMessage(50, strArray[0x39], this.WTLoginRspBuff);
            }
            if (this.hasShowStyle)
            {
                output.WriteMessage(0x33, strArray[0x2e], this.ShowStyle);
            }
            if (this.hasCliDBEncryptKey)
            {
                output.WriteMessage(0x34, strArray[13], this.CliDBEncryptKey);
            }
            if (this.hasCliDBEncryptInfo)
            {
                output.WriteMessage(0x35, strArray[12], this.CliDBEncryptInfo);
            }
            if (this.hasFlag)
            {
                output.WriteUInt32(0x36, strArray[0x11], this.Flag);
            }
            if (this.hasSnsDnsInfo)
            {
                output.WriteMessage(0x37, strArray[0x30], this.SnsDnsInfo);
            }
            if (this.hasAppDnsInfo)
            {
                output.WriteMessage(0x38, strArray[2], this.AppDnsInfo);
            }
            if (this.hasVerifySignature)
            {
                output.WriteString(0x39, strArray[0x38], this.VerifySignature);
            }
            if (this.hasVerifyBuff)
            {
                output.WriteMessage(0x3a, strArray[0x37], this.VerifyBuff);
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

        public CDNDnsInfo AppDnsInfo
        {
            get
            {
                return (this.appDnsInfo_ ?? CDNDnsInfo.DefaultInstance);
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

        public BaseResponse BaseResponse
        {
            get
            {
                return (this.baseResponse_ ?? BaseResponse.DefaultInstance);
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

        public BuiltinIPList BuiltinIPList
        {
            get
            {
                return (this.builtinIPList_ ?? BuiltinIPList.DefaultInstance);
            }
        }

        public SKBuiltinBuffer_t CliDBEncryptInfo
        {
            get
            {
                return (this.cliDBEncryptInfo_ ?? SKBuiltinBuffer_t.DefaultInstance);
            }
        }

        public SKBuiltinBuffer_t CliDBEncryptKey
        {
            get
            {
                return (this.cliDBEncryptKey_ ?? SKBuiltinBuffer_t.DefaultInstance);
            }
        }

        public static AuthResponse DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override AuthResponse DefaultInstanceForType
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

        public uint Flag
        {
            get
            {
                return this.flag_;
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

        public uint NeedSetEmailPwd
        {
            get
            {
                return this.needSetEmailPwd_;
            }
        }

        public NetworkControl NetworkControl
        {
            get
            {
                return (this.networkControl_ ?? NetworkControl.DefaultInstance);
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

        public uint NextAuthType
        {
            get
            {
                return this.nextAuthType_;
            }
        }

        public SKBuiltinString_t NickName
        {
            get
            {
                return (this.nickName_ ?? SKBuiltinString_t.DefaultInstance);
            }
        }

        public uint ObsoleteItem1
        {
            get
            {
                return this.obsoleteItem1_;
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

        public PluginKeyList PluginKeyList
        {
            get
            {
                return (this.pluginKeyList_ ?? PluginKeyList.DefaultInstance);
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
                    if (this.hasObsoleteItem1)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(0x2c, this.ObsoleteItem1);
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
                    if (this.hasNextAuthType)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(0x31, this.NextAuthType);
                    }
                    if (this.hasWTLoginRspBuff)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(50, this.WTLoginRspBuff);
                    }
                    if (this.hasShowStyle)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(0x33, this.ShowStyle);
                    }
                    if (this.hasCliDBEncryptKey)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(0x34, this.CliDBEncryptKey);
                    }
                    if (this.hasCliDBEncryptInfo)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(0x35, this.CliDBEncryptInfo);
                    }
                    if (this.hasFlag)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(0x36, this.Flag);
                    }
                    if (this.hasSnsDnsInfo)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(0x37, this.SnsDnsInfo);
                    }
                    if (this.hasAppDnsInfo)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(0x38, this.AppDnsInfo);
                    }
                    if (this.hasVerifySignature)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x39, this.VerifySignature);
                    }
                    if (this.hasVerifyBuff)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(0x3a, this.VerifyBuff);
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

        public ShowStyleKey ShowStyle
        {
            get
            {
                return (this.showStyle_ ?? ShowStyleKey.DefaultInstance);
            }
        }

        public string Sid
        {
            get
            {
                return this.sid_;
            }
        }

        public CDNDnsInfo SnsDnsInfo
        {
            get
            {
                return (this.snsDnsInfo_ ?? CDNDnsInfo.DefaultInstance);
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

        protected override AuthResponse ThisMessage
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

        public SKBuiltinBuffer_t VerifyBuff
        {
            get
            {
                return (this.verifyBuff_ ?? SKBuiltinBuffer_t.DefaultInstance);
            }
        }

        public string VerifySignature
        {
            get
            {
                return this.verifySignature_;
            }
        }

        public SKBuiltinBuffer_t WTLoginRspBuff
        {
            get
            {
                return (this.wTLoginRspBuff_ ?? SKBuiltinBuffer_t.DefaultInstance);
            }
        }


        public sealed class Builder : GeneratedBuilderLite<AuthResponse, AuthResponse.Builder>
        {
            private AuthResponse result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = AuthResponse.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(AuthResponse cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override AuthResponse BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override AuthResponse.Builder Clear()
            {
                this.result = AuthResponse.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public AuthResponse.Builder ClearA2Key()
            {
                this.PrepareBuilder();
                this.result.hasA2Key = false;
                this.result.a2Key_ = null;
                return this;
            }

            public AuthResponse.Builder ClearAlias()
            {
                this.PrepareBuilder();
                this.result.hasAlias = false;
                this.result.alias_ = "";
                return this;
            }

            public AuthResponse.Builder ClearAppDnsInfo()
            {
                this.PrepareBuilder();
                this.result.hasAppDnsInfo = false;
                this.result.appDnsInfo_ = null;
                return this;
            }

            public AuthResponse.Builder ClearApplyBetaUrl()
            {
                this.PrepareBuilder();
                this.result.hasApplyBetaUrl = false;
                this.result.applyBetaUrl_ = "";
                return this;
            }

            public AuthResponse.Builder ClearAuthKey()
            {
                this.PrepareBuilder();
                this.result.hasAuthKey = false;
                this.result.authKey_ = "";
                return this;
            }

            public AuthResponse.Builder ClearAuthTicket()
            {
                this.PrepareBuilder();
                this.result.hasAuthTicket = false;
                this.result.authTicket_ = "";
                return this;
            }

            public AuthResponse.Builder ClearAutoAuthTicket()
            {
                this.PrepareBuilder();
                this.result.hasAutoAuthTicket = false;
                this.result.autoAuthTicket_ = "";
                return this;
            }

            public AuthResponse.Builder ClearBaseResponse()
            {
                this.PrepareBuilder();
                this.result.hasBaseResponse = false;
                this.result.baseResponse_ = null;
                return this;
            }

            public AuthResponse.Builder ClearBindEmail()
            {
                this.PrepareBuilder();
                this.result.hasBindEmail = false;
                this.result.bindEmail_ = null;
                return this;
            }

            public AuthResponse.Builder ClearBindMobile()
            {
                this.PrepareBuilder();
                this.result.hasBindMobile = false;
                this.result.bindMobile_ = null;
                return this;
            }

            public AuthResponse.Builder ClearBindUin()
            {
                this.PrepareBuilder();
                this.result.hasBindUin = false;
                this.result.bindUin_ = 0;
                return this;
            }

            public AuthResponse.Builder ClearBuiltinIPList()
            {
                this.PrepareBuilder();
                this.result.hasBuiltinIPList = false;
                this.result.builtinIPList_ = null;
                return this;
            }

            public AuthResponse.Builder ClearCliDBEncryptInfo()
            {
                this.PrepareBuilder();
                this.result.hasCliDBEncryptInfo = false;
                this.result.cliDBEncryptInfo_ = null;
                return this;
            }

            public AuthResponse.Builder ClearCliDBEncryptKey()
            {
                this.PrepareBuilder();
                this.result.hasCliDBEncryptKey = false;
                this.result.cliDBEncryptKey_ = null;
                return this;
            }

            public AuthResponse.Builder ClearDeviceInfoXml()
            {
                this.PrepareBuilder();
                this.result.hasDeviceInfoXml = false;
                this.result.deviceInfoXml_ = "";
                return this;
            }

            public AuthResponse.Builder ClearDnsInfo()
            {
                this.PrepareBuilder();
                this.result.hasDnsInfo = false;
                this.result.dnsInfo_ = null;
                return this;
            }

            public AuthResponse.Builder ClearFlag()
            {
                this.PrepareBuilder();
                this.result.hasFlag = false;
                this.result.flag_ = 0;
                return this;
            }

            public AuthResponse.Builder ClearFSURL()
            {
                this.PrepareBuilder();
                this.result.hasFSURL = false;
                this.result.fSURL_ = "";
                return this;
            }

            public AuthResponse.Builder ClearHintMsg()
            {
                this.PrepareBuilder();
                this.result.hasHintMsg = false;
                this.result.hintMsg_ = "";
                return this;
            }

            public AuthResponse.Builder ClearImgBuf()
            {
                this.PrepareBuilder();
                this.result.hasImgBuf = false;
                this.result.imgBuf_ = null;
                return this;
            }

            public AuthResponse.Builder ClearImgEncryptKey()
            {
                this.PrepareBuilder();
                this.result.hasImgEncryptKey = false;
                this.result.imgEncryptKey_ = null;
                return this;
            }

            public AuthResponse.Builder ClearImgSid()
            {
                this.PrepareBuilder();
                this.result.hasImgSid = false;
                this.result.imgSid_ = null;
                return this;
            }

            public AuthResponse.Builder ClearIsAutoReg()
            {
                this.PrepareBuilder();
                this.result.hasIsAutoReg = false;
                this.result.isAutoReg_ = 0;
                return this;
            }

            public AuthResponse.Builder ClearKickResponse()
            {
                this.PrepareBuilder();
                this.result.hasKickResponse = false;
                this.result.kickResponse_ = "";
                return this;
            }

            public AuthResponse.Builder ClearKSid()
            {
                this.PrepareBuilder();
                this.result.hasKSid = false;
                this.result.kSid_ = null;
                return this;
            }

            public AuthResponse.Builder ClearNeedSetEmailPwd()
            {
                this.PrepareBuilder();
                this.result.hasNeedSetEmailPwd = false;
                this.result.needSetEmailPwd_ = 0;
                return this;
            }

            public AuthResponse.Builder ClearNetworkControl()
            {
                this.PrepareBuilder();
                this.result.hasNetworkControl = false;
                this.result.networkControl_ = null;
                return this;
            }

            public AuthResponse.Builder ClearNewHostList()
            {
                this.PrepareBuilder();
                this.result.hasNewHostList = false;
                this.result.newHostList_ = null;
                return this;
            }

            public AuthResponse.Builder ClearNewVersion()
            {
                this.PrepareBuilder();
                this.result.hasNewVersion = false;
                this.result.newVersion_ = 0;
                return this;
            }

            public AuthResponse.Builder ClearNextAuthType()
            {
                this.PrepareBuilder();
                this.result.hasNextAuthType = false;
                this.result.nextAuthType_ = 0;
                return this;
            }

            public AuthResponse.Builder ClearNickName()
            {
                this.PrepareBuilder();
                this.result.hasNickName = false;
                this.result.nickName_ = null;
                return this;
            }

            public AuthResponse.Builder ClearObsoleteItem1()
            {
                this.PrepareBuilder();
                this.result.hasObsoleteItem1 = false;
                this.result.obsoleteItem1_ = 0;
                return this;
            }

            public AuthResponse.Builder ClearOfficialNickName()
            {
                this.PrepareBuilder();
                this.result.hasOfficialNickName = false;
                this.result.officialNickName_ = null;
                return this;
            }

            public AuthResponse.Builder ClearOfficialUserName()
            {
                this.PrepareBuilder();
                this.result.hasOfficialUserName = false;
                this.result.officialUserName_ = null;
                return this;
            }

            public AuthResponse.Builder ClearPassword()
            {
                this.PrepareBuilder();
                this.result.hasPassword = false;
                this.result.password_ = "";
                return this;
            }

            public AuthResponse.Builder ClearPluginFlag()
            {
                this.PrepareBuilder();
                this.result.hasPluginFlag = false;
                this.result.pluginFlag_ = 0;
                return this;
            }

            public AuthResponse.Builder ClearPluginKeyList()
            {
                this.PrepareBuilder();
                this.result.hasPluginKeyList = false;
                this.result.pluginKeyList_ = null;
                return this;
            }

            public AuthResponse.Builder ClearProfileFlag()
            {
                this.PrepareBuilder();
                this.result.hasProfileFlag = false;
                this.result.profileFlag_ = 0;
                return this;
            }

            public AuthResponse.Builder ClearPushMailSettingTicket()
            {
                this.PrepareBuilder();
                this.result.hasPushMailSettingTicket = false;
                this.result.pushMailSettingTicket_ = "";
                return this;
            }

            public AuthResponse.Builder ClearPushMailStatus()
            {
                this.PrepareBuilder();
                this.result.hasPushMailStatus = false;
                this.result.pushMailStatus_ = 0;
                return this;
            }

            public AuthResponse.Builder ClearQQMicroBlogStatus()
            {
                this.PrepareBuilder();
                this.result.hasQQMicroBlogStatus = false;
                this.result.qQMicroBlogStatus_ = 0;
                return this;
            }

            public AuthResponse.Builder ClearQQMicroBlogUserName()
            {
                this.PrepareBuilder();
                this.result.hasQQMicroBlogUserName = false;
                this.result.qQMicroBlogUserName_ = null;
                return this;
            }

            public AuthResponse.Builder ClearRegType()
            {
                this.PrepareBuilder();
                this.result.hasRegType = false;
                this.result.regType_ = 0;
                return this;
            }

            public AuthResponse.Builder ClearSafeDevice()
            {
                this.PrepareBuilder();
                this.result.hasSafeDevice = false;
                this.result.safeDevice_ = 0;
                return this;
            }

            public AuthResponse.Builder ClearSendCardBitFlag()
            {
                this.PrepareBuilder();
                this.result.hasSendCardBitFlag = false;
                this.result.sendCardBitFlag_ = 0;
                return this;
            }

            public AuthResponse.Builder ClearSessionKey()
            {
                this.PrepareBuilder();
                this.result.hasSessionKey = false;
                this.result.sessionKey_ = ByteString.Empty;
                return this;
            }

            public AuthResponse.Builder ClearShowStyle()
            {
                this.PrepareBuilder();
                this.result.hasShowStyle = false;
                this.result.showStyle_ = null;
                return this;
            }

            public AuthResponse.Builder ClearSid()
            {
                this.PrepareBuilder();
                this.result.hasSid = false;
                this.result.sid_ = "";
                return this;
            }

            public AuthResponse.Builder ClearSnsDnsInfo()
            {
                this.PrepareBuilder();
                this.result.hasSnsDnsInfo = false;
                this.result.snsDnsInfo_ = null;
                return this;
            }

            public AuthResponse.Builder ClearSoftConfigXml()
            {
                this.PrepareBuilder();
                this.result.hasSoftConfigXml = false;
                this.result.softConfigXml_ = "";
                return this;
            }

            public AuthResponse.Builder ClearStatus()
            {
                this.PrepareBuilder();
                this.result.hasStatus = false;
                this.result.status_ = 0;
                return this;
            }

            public AuthResponse.Builder ClearTicket()
            {
                this.PrepareBuilder();
                this.result.hasTicket = false;
                this.result.ticket_ = "";
                return this;
            }

            public AuthResponse.Builder ClearTimeStamp()
            {
                this.PrepareBuilder();
                this.result.hasTimeStamp = false;
                this.result.timeStamp_ = 0;
                return this;
            }

            public AuthResponse.Builder ClearUin()
            {
                this.PrepareBuilder();
                this.result.hasUin = false;
                this.result.uin_ = 0;
                return this;
            }

            public AuthResponse.Builder ClearUserName()
            {
                this.PrepareBuilder();
                this.result.hasUserName = false;
                this.result.userName_ = null;
                return this;
            }

            public AuthResponse.Builder ClearVerifyBuff()
            {
                this.PrepareBuilder();
                this.result.hasVerifyBuff = false;
                this.result.verifyBuff_ = null;
                return this;
            }

            public AuthResponse.Builder ClearVerifySignature()
            {
                this.PrepareBuilder();
                this.result.hasVerifySignature = false;
                this.result.verifySignature_ = "";
                return this;
            }

            public AuthResponse.Builder ClearWTLoginRspBuff()
            {
                this.PrepareBuilder();
                this.result.hasWTLoginRspBuff = false;
                this.result.wTLoginRspBuff_ = null;
                return this;
            }

            public override AuthResponse.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new AuthResponse.Builder(this.result);
                }
                return new AuthResponse.Builder().MergeFrom(this.result);
            }

            public AuthResponse.Builder MergeA2Key(SKBuiltinBuffer_t value)
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

            public AuthResponse.Builder MergeAppDnsInfo(CDNDnsInfo value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasAppDnsInfo && (this.result.appDnsInfo_ != CDNDnsInfo.DefaultInstance))
                {
                    this.result.appDnsInfo_ = CDNDnsInfo.CreateBuilder(this.result.appDnsInfo_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.appDnsInfo_ = value;
                }
                this.result.hasAppDnsInfo = true;
                return this;
            }

            public AuthResponse.Builder MergeBaseResponse(BaseResponse value)
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

            public AuthResponse.Builder MergeBindEmail(SKBuiltinString_t value)
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

            public AuthResponse.Builder MergeBindMobile(SKBuiltinString_t value)
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

            public AuthResponse.Builder MergeBuiltinIPList(BuiltinIPList value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasBuiltinIPList && (this.result.builtinIPList_ != BuiltinIPList.DefaultInstance))
                {
                    this.result.builtinIPList_ = BuiltinIPList.CreateBuilder(this.result.builtinIPList_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.builtinIPList_ = value;
                }
                this.result.hasBuiltinIPList = true;
                return this;
            }

            public AuthResponse.Builder MergeCliDBEncryptInfo(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasCliDBEncryptInfo && (this.result.cliDBEncryptInfo_ != SKBuiltinBuffer_t.DefaultInstance))
                {
                    this.result.cliDBEncryptInfo_ = SKBuiltinBuffer_t.CreateBuilder(this.result.cliDBEncryptInfo_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.cliDBEncryptInfo_ = value;
                }
                this.result.hasCliDBEncryptInfo = true;
                return this;
            }

            public AuthResponse.Builder MergeCliDBEncryptKey(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasCliDBEncryptKey && (this.result.cliDBEncryptKey_ != SKBuiltinBuffer_t.DefaultInstance))
                {
                    this.result.cliDBEncryptKey_ = SKBuiltinBuffer_t.CreateBuilder(this.result.cliDBEncryptKey_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.cliDBEncryptKey_ = value;
                }
                this.result.hasCliDBEncryptKey = true;
                return this;
            }

            public AuthResponse.Builder MergeDnsInfo(CDNDnsInfo value)
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

            public override AuthResponse.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override AuthResponse.Builder MergeFrom(IMessageLite other)
            {
                if (other is AuthResponse)
                {
                    return this.MergeFrom((AuthResponse)other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override AuthResponse.Builder MergeFrom(AuthResponse other)
            {
                return this;
            }

            public override AuthResponse.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(AuthResponse._AuthResponseFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = AuthResponse._AuthResponseFieldTags[index];
                        }
                        else
                        {
                            this.ParseUnknownField(input, extensionRegistry, num, str);
                            continue;
                        }
                    }
                    switch (num)
                    {
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
                        case 40:
                            {
                                this.result.hasBindUin = input.ReadUInt32(ref this.result.bindUin_);
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
                        case 0x8a:
                            {
                                this.result.hasTicket = input.ReadString(ref this.result.ticket_);
                                continue;
                            }
                        case 0x90:
                            {
                                this.result.hasPushMailStatus = input.ReadUInt32(ref this.result.pushMailStatus_);
                                continue;
                            }
                        case 0xba:
                            {
                                NetworkControl.Builder builder12 = NetworkControl.CreateBuilder();
                                if (this.result.hasNetworkControl)
                                {
                                    builder12.MergeFrom(this.NetworkControl);
                                }
                                input.ReadMessage(builder12, extensionRegistry);
                                this.NetworkControl = builder12.BuildPartial();
                                continue;
                            }
                        case 0xc0:
                            {
                                this.result.hasPluginFlag = input.ReadUInt32(ref this.result.pluginFlag_);
                                continue;
                            }
                        case 170:
                            {
                                BuiltinIPList.Builder builder11 = BuiltinIPList.CreateBuilder();
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
                                PluginKeyList.Builder builder13 = PluginKeyList.CreateBuilder();
                                if (this.result.hasPluginKeyList)
                                {
                                    builder13.MergeFrom(this.PluginKeyList);
                                }
                                input.ReadMessage(builder13, extensionRegistry);
                                this.PluginKeyList = builder13.BuildPartial();
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
                        case 0x132:
                            {
                                this.result.hasApplyBetaUrl = input.ReadString(ref this.result.applyBetaUrl_);
                                continue;
                            }
                        case 0x13a:
                            {
                                this.result.hasDeviceInfoXml = input.ReadString(ref this.result.deviceInfoXml_);
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
                                this.result.hasObsoleteItem1 = input.ReadUInt32(ref this.result.obsoleteItem1_);
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
                        case 0x188:
                            {
                                this.result.hasNextAuthType = input.ReadUInt32(ref this.result.nextAuthType_);
                                continue;
                            }
                        case 0x192:
                            {
                                SKBuiltinBuffer_t.Builder builder19 = SKBuiltinBuffer_t.CreateBuilder();
                                if (this.result.hasWTLoginRspBuff)
                                {
                                    builder19.MergeFrom(this.WTLoginRspBuff);
                                }
                                input.ReadMessage(builder19, extensionRegistry);
                                this.WTLoginRspBuff = builder19.BuildPartial();
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
                        case 0x1aa:
                            {
                                SKBuiltinBuffer_t.Builder builder22 = SKBuiltinBuffer_t.CreateBuilder();
                                if (this.result.hasCliDBEncryptInfo)
                                {
                                    builder22.MergeFrom(this.CliDBEncryptInfo);
                                }
                                input.ReadMessage(builder22, extensionRegistry);
                                this.CliDBEncryptInfo = builder22.BuildPartial();
                                continue;
                            }
                        case 0x1b0:
                            {
                                this.result.hasFlag = input.ReadUInt32(ref this.result.flag_);
                                continue;
                            }
                        case 410:
                            {
                                ShowStyleKey.Builder builder20 = ShowStyleKey.CreateBuilder();
                                if (this.result.hasShowStyle)
                                {
                                    builder20.MergeFrom(this.ShowStyle);
                                }
                                input.ReadMessage(builder20, extensionRegistry);
                                this.ShowStyle = builder20.BuildPartial();
                                continue;
                            }
                        case 0x1a2:
                            {
                                SKBuiltinBuffer_t.Builder builder21 = SKBuiltinBuffer_t.CreateBuilder();
                                if (this.result.hasCliDBEncryptKey)
                                {
                                    builder21.MergeFrom(this.CliDBEncryptKey);
                                }
                                input.ReadMessage(builder21, extensionRegistry);
                                this.CliDBEncryptKey = builder21.BuildPartial();
                                continue;
                            }
                        case 0x1ba:
                            {
                                CDNDnsInfo.Builder builder23 = CDNDnsInfo.CreateBuilder();
                                if (this.result.hasSnsDnsInfo)
                                {
                                    builder23.MergeFrom(this.SnsDnsInfo);
                                }
                                input.ReadMessage(builder23, extensionRegistry);
                                this.SnsDnsInfo = builder23.BuildPartial();
                                continue;
                            }
                        case 450:
                            {
                                CDNDnsInfo.Builder builder24 = CDNDnsInfo.CreateBuilder();
                                if (this.result.hasAppDnsInfo)
                                {
                                    builder24.MergeFrom(this.AppDnsInfo);
                                }
                                input.ReadMessage(builder24, extensionRegistry);
                                this.AppDnsInfo = builder24.BuildPartial();
                                continue;
                            }
                        case 0x1ca:
                            {
                                this.result.hasVerifySignature = input.ReadString(ref this.result.verifySignature_);
                                continue;
                            }
                        case 0x1d2:
                            {
                                SKBuiltinBuffer_t.Builder builder25 = SKBuiltinBuffer_t.CreateBuilder();
                                if (this.result.hasVerifyBuff)
                                {
                                    builder25.MergeFrom(this.VerifyBuff);
                                }
                                input.ReadMessage(builder25, extensionRegistry);
                                this.VerifyBuff = builder25.BuildPartial();
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

            public AuthResponse.Builder MergeImgBuf(SKBuiltinBuffer_t value)
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

            public AuthResponse.Builder MergeImgEncryptKey(SKBuiltinString_t value)
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

            public AuthResponse.Builder MergeImgSid(SKBuiltinString_t value)
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

            public AuthResponse.Builder MergeKSid(SKBuiltinBuffer_t value)
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

            public AuthResponse.Builder MergeNetworkControl(NetworkControl value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasNetworkControl && (this.result.networkControl_ != NetworkControl.DefaultInstance))
                {
                    this.result.networkControl_ = NetworkControl.CreateBuilder(this.result.networkControl_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.networkControl_ = value;
                }
                this.result.hasNetworkControl = true;
                return this;
            }

            public AuthResponse.Builder MergeNewHostList(HostList value)
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

            public AuthResponse.Builder MergeNickName(SKBuiltinString_t value)
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

            public AuthResponse.Builder MergeOfficialNickName(SKBuiltinString_t value)
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

            public AuthResponse.Builder MergeOfficialUserName(SKBuiltinString_t value)
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

            public AuthResponse.Builder MergePluginKeyList(PluginKeyList value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasPluginKeyList && (this.result.pluginKeyList_ != PluginKeyList.DefaultInstance))
                {
                    this.result.pluginKeyList_ = PluginKeyList.CreateBuilder(this.result.pluginKeyList_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.pluginKeyList_ = value;
                }
                this.result.hasPluginKeyList = true;
                return this;
            }

            public AuthResponse.Builder MergeQQMicroBlogUserName(SKBuiltinString_t value)
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

            public AuthResponse.Builder MergeShowStyle(ShowStyleKey value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasShowStyle && (this.result.showStyle_ != ShowStyleKey.DefaultInstance))
                {
                    this.result.showStyle_ = ShowStyleKey.CreateBuilder(this.result.showStyle_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.showStyle_ = value;
                }
                this.result.hasShowStyle = true;
                return this;
            }

            public AuthResponse.Builder MergeSnsDnsInfo(CDNDnsInfo value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasSnsDnsInfo && (this.result.snsDnsInfo_ != CDNDnsInfo.DefaultInstance))
                {
                    this.result.snsDnsInfo_ = CDNDnsInfo.CreateBuilder(this.result.snsDnsInfo_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.snsDnsInfo_ = value;
                }
                this.result.hasSnsDnsInfo = true;
                return this;
            }

            public AuthResponse.Builder MergeUserName(SKBuiltinString_t value)
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

            public AuthResponse.Builder MergeVerifyBuff(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasVerifyBuff && (this.result.verifyBuff_ != SKBuiltinBuffer_t.DefaultInstance))
                {
                    this.result.verifyBuff_ = SKBuiltinBuffer_t.CreateBuilder(this.result.verifyBuff_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.verifyBuff_ = value;
                }
                this.result.hasVerifyBuff = true;
                return this;
            }

            public AuthResponse.Builder MergeWTLoginRspBuff(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasWTLoginRspBuff && (this.result.wTLoginRspBuff_ != SKBuiltinBuffer_t.DefaultInstance))
                {
                    this.result.wTLoginRspBuff_ = SKBuiltinBuffer_t.CreateBuilder(this.result.wTLoginRspBuff_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.wTLoginRspBuff_ = value;
                }
                this.result.hasWTLoginRspBuff = true;
                return this;
            }

            private AuthResponse PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    AuthResponse result = this.result;
                    this.result = new AuthResponse();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public AuthResponse.Builder SetA2Key(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasA2Key = true;
                this.result.a2Key_ = value;
                return this;
            }

            public AuthResponse.Builder SetA2Key(SKBuiltinBuffer_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasA2Key = true;
                this.result.a2Key_ = builderForValue.Build();
                return this;
            }

            public AuthResponse.Builder SetAlias(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasAlias = true;
                this.result.alias_ = value;
                return this;
            }

            public AuthResponse.Builder SetAppDnsInfo(CDNDnsInfo value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasAppDnsInfo = true;
                this.result.appDnsInfo_ = value;
                return this;
            }

            public AuthResponse.Builder SetAppDnsInfo(CDNDnsInfo.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasAppDnsInfo = true;
                this.result.appDnsInfo_ = builderForValue.Build();
                return this;
            }

            public AuthResponse.Builder SetApplyBetaUrl(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasApplyBetaUrl = true;
                this.result.applyBetaUrl_ = value;
                return this;
            }

            public AuthResponse.Builder SetAuthKey(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasAuthKey = true;
                this.result.authKey_ = value;
                return this;
            }

            public AuthResponse.Builder SetAuthTicket(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasAuthTicket = true;
                this.result.authTicket_ = value;
                return this;
            }

            public AuthResponse.Builder SetAutoAuthTicket(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasAutoAuthTicket = true;
                this.result.autoAuthTicket_ = value;
                return this;
            }

            public AuthResponse.Builder SetBaseResponse(BaseResponse value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = value;
                return this;
            }

            public AuthResponse.Builder SetBaseResponse(BaseResponse.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = builderForValue.Build();
                return this;
            }

            public AuthResponse.Builder SetBindEmail(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBindEmail = true;
                this.result.bindEmail_ = value;
                return this;
            }

            public AuthResponse.Builder SetBindEmail(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBindEmail = true;
                this.result.bindEmail_ = builderForValue.Build();
                return this;
            }

            public AuthResponse.Builder SetBindMobile(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBindMobile = true;
                this.result.bindMobile_ = value;
                return this;
            }

            public AuthResponse.Builder SetBindMobile(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBindMobile = true;
                this.result.bindMobile_ = builderForValue.Build();
                return this;
            }

            public AuthResponse.Builder SetBindUin(uint value)
            {
                this.PrepareBuilder();
                this.result.hasBindUin = true;
                this.result.bindUin_ = value;
                return this;
            }

            public AuthResponse.Builder SetBuiltinIPList(BuiltinIPList value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBuiltinIPList = true;
                this.result.builtinIPList_ = value;
                return this;
            }

            public AuthResponse.Builder SetBuiltinIPList(BuiltinIPList.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBuiltinIPList = true;
                this.result.builtinIPList_ = builderForValue.Build();
                return this;
            }

            public AuthResponse.Builder SetCliDBEncryptInfo(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasCliDBEncryptInfo = true;
                this.result.cliDBEncryptInfo_ = value;
                return this;
            }

            public AuthResponse.Builder SetCliDBEncryptInfo(SKBuiltinBuffer_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasCliDBEncryptInfo = true;
                this.result.cliDBEncryptInfo_ = builderForValue.Build();
                return this;
            }

            public AuthResponse.Builder SetCliDBEncryptKey(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasCliDBEncryptKey = true;
                this.result.cliDBEncryptKey_ = value;
                return this;
            }

            public AuthResponse.Builder SetCliDBEncryptKey(SKBuiltinBuffer_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasCliDBEncryptKey = true;
                this.result.cliDBEncryptKey_ = builderForValue.Build();
                return this;
            }

            public AuthResponse.Builder SetDeviceInfoXml(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasDeviceInfoXml = true;
                this.result.deviceInfoXml_ = value;
                return this;
            }

            public AuthResponse.Builder SetDnsInfo(CDNDnsInfo value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasDnsInfo = true;
                this.result.dnsInfo_ = value;
                return this;
            }

            public AuthResponse.Builder SetDnsInfo(CDNDnsInfo.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasDnsInfo = true;
                this.result.dnsInfo_ = builderForValue.Build();
                return this;
            }

            public AuthResponse.Builder SetFlag(uint value)
            {
                this.PrepareBuilder();
                this.result.hasFlag = true;
                this.result.flag_ = value;
                return this;
            }

            public AuthResponse.Builder SetFSURL(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasFSURL = true;
                this.result.fSURL_ = value;
                return this;
            }

            public AuthResponse.Builder SetHintMsg(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasHintMsg = true;
                this.result.hintMsg_ = value;
                return this;
            }

            public AuthResponse.Builder SetImgBuf(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasImgBuf = true;
                this.result.imgBuf_ = value;
                return this;
            }

            public AuthResponse.Builder SetImgBuf(SKBuiltinBuffer_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasImgBuf = true;
                this.result.imgBuf_ = builderForValue.Build();
                return this;
            }

            public AuthResponse.Builder SetImgEncryptKey(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasImgEncryptKey = true;
                this.result.imgEncryptKey_ = value;
                return this;
            }

            public AuthResponse.Builder SetImgEncryptKey(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasImgEncryptKey = true;
                this.result.imgEncryptKey_ = builderForValue.Build();
                return this;
            }

            public AuthResponse.Builder SetImgSid(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasImgSid = true;
                this.result.imgSid_ = value;
                return this;
            }

            public AuthResponse.Builder SetImgSid(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasImgSid = true;
                this.result.imgSid_ = builderForValue.Build();
                return this;
            }

            public AuthResponse.Builder SetIsAutoReg(uint value)
            {
                this.PrepareBuilder();
                this.result.hasIsAutoReg = true;
                this.result.isAutoReg_ = value;
                return this;
            }

            public AuthResponse.Builder SetKickResponse(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasKickResponse = true;
                this.result.kickResponse_ = value;
                return this;
            }

            public AuthResponse.Builder SetKSid(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasKSid = true;
                this.result.kSid_ = value;
                return this;
            }

            public AuthResponse.Builder SetKSid(SKBuiltinBuffer_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasKSid = true;
                this.result.kSid_ = builderForValue.Build();
                return this;
            }

            public AuthResponse.Builder SetNeedSetEmailPwd(uint value)
            {
                this.PrepareBuilder();
                this.result.hasNeedSetEmailPwd = true;
                this.result.needSetEmailPwd_ = value;
                return this;
            }

            public AuthResponse.Builder SetNetworkControl(NetworkControl value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasNetworkControl = true;
                this.result.networkControl_ = value;
                return this;
            }

            public AuthResponse.Builder SetNetworkControl(NetworkControl.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasNetworkControl = true;
                this.result.networkControl_ = builderForValue.Build();
                return this;
            }

            public AuthResponse.Builder SetNewHostList(HostList value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasNewHostList = true;
                this.result.newHostList_ = value;
                return this;
            }

            public AuthResponse.Builder SetNewHostList(HostList.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasNewHostList = true;
                this.result.newHostList_ = builderForValue.Build();
                return this;
            }

            public AuthResponse.Builder SetNewVersion(uint value)
            {
                this.PrepareBuilder();
                this.result.hasNewVersion = true;
                this.result.newVersion_ = value;
                return this;
            }

            public AuthResponse.Builder SetNextAuthType(uint value)
            {
                this.PrepareBuilder();
                this.result.hasNextAuthType = true;
                this.result.nextAuthType_ = value;
                return this;
            }

            public AuthResponse.Builder SetNickName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasNickName = true;
                this.result.nickName_ = value;
                return this;
            }

            public AuthResponse.Builder SetNickName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasNickName = true;
                this.result.nickName_ = builderForValue.Build();
                return this;
            }

            public AuthResponse.Builder SetObsoleteItem1(uint value)
            {
                this.PrepareBuilder();
                this.result.hasObsoleteItem1 = true;
                this.result.obsoleteItem1_ = value;
                return this;
            }

            public AuthResponse.Builder SetOfficialNickName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasOfficialNickName = true;
                this.result.officialNickName_ = value;
                return this;
            }

            public AuthResponse.Builder SetOfficialNickName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasOfficialNickName = true;
                this.result.officialNickName_ = builderForValue.Build();
                return this;
            }

            public AuthResponse.Builder SetOfficialUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasOfficialUserName = true;
                this.result.officialUserName_ = value;
                return this;
            }

            public AuthResponse.Builder SetOfficialUserName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasOfficialUserName = true;
                this.result.officialUserName_ = builderForValue.Build();
                return this;
            }

            public AuthResponse.Builder SetPassword(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasPassword = true;
                this.result.password_ = value;
                return this;
            }

            public AuthResponse.Builder SetPluginFlag(uint value)
            {
                this.PrepareBuilder();
                this.result.hasPluginFlag = true;
                this.result.pluginFlag_ = value;
                return this;
            }

            public AuthResponse.Builder SetPluginKeyList(PluginKeyList value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasPluginKeyList = true;
                this.result.pluginKeyList_ = value;
                return this;
            }

            public AuthResponse.Builder SetPluginKeyList(PluginKeyList.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasPluginKeyList = true;
                this.result.pluginKeyList_ = builderForValue.Build();
                return this;
            }

            public AuthResponse.Builder SetProfileFlag(uint value)
            {
                this.PrepareBuilder();
                this.result.hasProfileFlag = true;
                this.result.profileFlag_ = value;
                return this;
            }

            public AuthResponse.Builder SetPushMailSettingTicket(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasPushMailSettingTicket = true;
                this.result.pushMailSettingTicket_ = value;
                return this;
            }

            public AuthResponse.Builder SetPushMailStatus(uint value)
            {
                this.PrepareBuilder();
                this.result.hasPushMailStatus = true;
                this.result.pushMailStatus_ = value;
                return this;
            }

            public AuthResponse.Builder SetQQMicroBlogStatus(uint value)
            {
                this.PrepareBuilder();
                this.result.hasQQMicroBlogStatus = true;
                this.result.qQMicroBlogStatus_ = value;
                return this;
            }

            public AuthResponse.Builder SetQQMicroBlogUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasQQMicroBlogUserName = true;
                this.result.qQMicroBlogUserName_ = value;
                return this;
            }

            public AuthResponse.Builder SetQQMicroBlogUserName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasQQMicroBlogUserName = true;
                this.result.qQMicroBlogUserName_ = builderForValue.Build();
                return this;
            }

            public AuthResponse.Builder SetRegType(uint value)
            {
                this.PrepareBuilder();
                this.result.hasRegType = true;
                this.result.regType_ = value;
                return this;
            }

            public AuthResponse.Builder SetSafeDevice(uint value)
            {
                this.PrepareBuilder();
                this.result.hasSafeDevice = true;
                this.result.safeDevice_ = value;
                return this;
            }

            public AuthResponse.Builder SetSendCardBitFlag(uint value)
            {
                this.PrepareBuilder();
                this.result.hasSendCardBitFlag = true;
                this.result.sendCardBitFlag_ = value;
                return this;
            }

            public AuthResponse.Builder SetSessionKey(ByteString value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSessionKey = true;
                this.result.sessionKey_ = value;
                return this;
            }

            public AuthResponse.Builder SetShowStyle(ShowStyleKey value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasShowStyle = true;
                this.result.showStyle_ = value;
                return this;
            }

            public AuthResponse.Builder SetShowStyle(ShowStyleKey.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasShowStyle = true;
                this.result.showStyle_ = builderForValue.Build();
                return this;
            }

            public AuthResponse.Builder SetSid(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSid = true;
                this.result.sid_ = value;
                return this;
            }

            public AuthResponse.Builder SetSnsDnsInfo(CDNDnsInfo value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSnsDnsInfo = true;
                this.result.snsDnsInfo_ = value;
                return this;
            }

            public AuthResponse.Builder SetSnsDnsInfo(CDNDnsInfo.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasSnsDnsInfo = true;
                this.result.snsDnsInfo_ = builderForValue.Build();
                return this;
            }

            public AuthResponse.Builder SetSoftConfigXml(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSoftConfigXml = true;
                this.result.softConfigXml_ = value;
                return this;
            }

            public AuthResponse.Builder SetStatus(uint value)
            {
                this.PrepareBuilder();
                this.result.hasStatus = true;
                this.result.status_ = value;
                return this;
            }

            public AuthResponse.Builder SetTicket(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasTicket = true;
                this.result.ticket_ = value;
                return this;
            }

            public AuthResponse.Builder SetTimeStamp(uint value)
            {
                this.PrepareBuilder();
                this.result.hasTimeStamp = true;
                this.result.timeStamp_ = value;
                return this;
            }

            public AuthResponse.Builder SetUin(uint value)
            {
                this.PrepareBuilder();
                this.result.hasUin = true;
                this.result.uin_ = value;
                return this;
            }

            public AuthResponse.Builder SetUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasUserName = true;
                this.result.userName_ = value;
                return this;
            }

            public AuthResponse.Builder SetUserName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasUserName = true;
                this.result.userName_ = builderForValue.Build();
                return this;
            }

            public AuthResponse.Builder SetVerifyBuff(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasVerifyBuff = true;
                this.result.verifyBuff_ = value;
                return this;
            }

            public AuthResponse.Builder SetVerifyBuff(SKBuiltinBuffer_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasVerifyBuff = true;
                this.result.verifyBuff_ = builderForValue.Build();
                return this;
            }

            public AuthResponse.Builder SetVerifySignature(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasVerifySignature = true;
                this.result.verifySignature_ = value;
                return this;
            }

            public AuthResponse.Builder SetWTLoginRspBuff(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasWTLoginRspBuff = true;
                this.result.wTLoginRspBuff_ = value;
                return this;
            }

            public AuthResponse.Builder SetWTLoginRspBuff(SKBuiltinBuffer_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasWTLoginRspBuff = true;
                this.result.wTLoginRspBuff_ = builderForValue.Build();
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

            public CDNDnsInfo AppDnsInfo
            {
                get
                {
                    return this.result.AppDnsInfo;
                }
                set
                {
                    this.SetAppDnsInfo(value);
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

            public BaseResponse BaseResponse
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

            public BuiltinIPList BuiltinIPList
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

            public SKBuiltinBuffer_t CliDBEncryptInfo
            {
                get
                {
                    return this.result.CliDBEncryptInfo;
                }
                set
                {
                    this.SetCliDBEncryptInfo(value);
                }
            }

            public SKBuiltinBuffer_t CliDBEncryptKey
            {
                get
                {
                    return this.result.CliDBEncryptKey;
                }
                set
                {
                    this.SetCliDBEncryptKey(value);
                }
            }

            public override AuthResponse DefaultInstanceForType
            {
                get
                {
                    return AuthResponse.DefaultInstance;
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

            public uint Flag
            {
                get
                {
                    return this.result.Flag;
                }
                set
                {
                    this.SetFlag(value);
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

            protected override AuthResponse MessageBeingBuilt
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

            public NetworkControl NetworkControl
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

            public uint NextAuthType
            {
                get
                {
                    return this.result.NextAuthType;
                }
                set
                {
                    this.SetNextAuthType(value);
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

            public uint ObsoleteItem1
            {
                get
                {
                    return this.result.ObsoleteItem1;
                }
                set
                {
                    this.SetObsoleteItem1(value);
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

            public PluginKeyList PluginKeyList
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

            public ShowStyleKey ShowStyle
            {
                get
                {
                    return this.result.ShowStyle;
                }
                set
                {
                    this.SetShowStyle(value);
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

            public CDNDnsInfo SnsDnsInfo
            {
                get
                {
                    return this.result.SnsDnsInfo;
                }
                set
                {
                    this.SetSnsDnsInfo(value);
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

            protected override AuthResponse.Builder ThisBuilder
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

            public SKBuiltinBuffer_t VerifyBuff
            {
                get
                {
                    return this.result.VerifyBuff;
                }
                set
                {
                    this.SetVerifyBuff(value);
                }
            }

            public string VerifySignature
            {
                get
                {
                    return this.result.VerifySignature;
                }
                set
                {
                    this.SetVerifySignature(value);
                }
            }

            public SKBuiltinBuffer_t WTLoginRspBuff
            {
                get
                {
                    return this.result.WTLoginRspBuff;
                }
                set
                {
                    this.SetWTLoginRspBuff(value);
                }
            }
        }
    }
}

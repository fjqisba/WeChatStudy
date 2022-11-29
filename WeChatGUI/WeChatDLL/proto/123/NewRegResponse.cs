namespace micromsg
{
    using Google.ProtocolBuffers;

    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    


    public sealed class NewRegResponse : GeneratedMessageLite<NewRegResponse, NewRegResponse.Builder>
    {
        private static readonly string[] _newRegResponseFieldNames = new string[] { 
            "AuthKey", "AutoAuthTicket", "BaseResponse", "BindEmail", "BuiltinIPList", "DnsInfo", "FSURL", "NetworkControl", "NewHostList", "OfficialNickName", "OfficialUserName", "Password", "PluginKeyList", "ProfileFlag", "PushMailSettingTicket", "PushMailStatus", 
            "QQMicroBlogUserName", "RegType", "ReturnFlag", "SendCardBitFlag", "SessionKey", "Status", "Uin", "UserName"
         };
        private static readonly uint[] _newRegResponseFieldTags = new uint[] { 
            170, 210, 10, 0x3a, 0x72, 0xda, 0x7a, 0x92, 0xca, 0x2a, 0x22, 0xba, 0xb2, 0xc0, 0x52, 0x40, 
            50, 160, 0x98, 0x48, 0x1a, 0x88, 0x10, 130
         };
        private string authKey_ = "";
        public const int AuthKeyFieldNumber = 0x15;
        private string autoAuthTicket_ = "";
        public const int AutoAuthTicketFieldNumber = 0x1a;
        private micromsg.BaseResponse baseResponse_;
        public const int BaseResponseFieldNumber = 1;
        private string bindEmail_ = "";
        public const int BindEmailFieldNumber = 7;
        private micromsg.BuiltinIPList builtinIPList_;
        public const int BuiltinIPListFieldNumber = 14;
        private static readonly NewRegResponse defaultInstance = new NewRegResponse().MakeReadOnly();
        private CDNDnsInfo dnsInfo_;
        public const int DnsInfoFieldNumber = 0x1b;
        private string fSURL_ = "";
        public const int FSURLFieldNumber = 15;
        private bool hasAuthKey;
        private bool hasAutoAuthTicket;
        private bool hasBaseResponse;
        private bool hasBindEmail;
        private bool hasBuiltinIPList;
        private bool hasDnsInfo;
        private bool hasFSURL;
        private bool hasNetworkControl;
        private bool hasNewHostList;
        private bool hasOfficialNickName;
        private bool hasOfficialUserName;
        private bool hasPassword;
        private bool hasPluginKeyList;
        private bool hasProfileFlag;
        private bool hasPushMailSettingTicket;
        private bool hasPushMailStatus;
        private bool hasQQMicroBlogUserName;
        private bool hasRegType;
        private bool hasReturnFlag;
        private bool hasSendCardBitFlag;
        private bool hasSessionKey;
        private bool hasStatus;
        private bool hasUin;
        private bool hasUserName;
        private int memoizedSerializedSize = -1;
        private micromsg.NetworkControl networkControl_;
        public const int NetworkControlFieldNumber = 0x12;
        private HostList newHostList_;
        public const int NewHostListFieldNumber = 0x19;
        private string officialNickName_ = "";
        public const int OfficialNickNameFieldNumber = 5;
        private string officialUserName_ = "";
        public const int OfficialUserNameFieldNumber = 4;
        private string password_ = "";
        public const int PasswordFieldNumber = 0x17;
        private micromsg.PluginKeyList pluginKeyList_;
        public const int PluginKeyListFieldNumber = 0x16;
        private uint profileFlag_;
        public const int ProfileFlagFieldNumber = 0x18;
        private string pushMailSettingTicket_ = "";
        public const int PushMailSettingTicketFieldNumber = 10;
        private uint pushMailStatus_;
        public const int PushMailStatusFieldNumber = 8;
        private string qQMicroBlogUserName_ = "";
        public const int QQMicroBlogUserNameFieldNumber = 6;
        private uint regType_;
        public const int RegTypeFieldNumber = 20;
        private uint returnFlag_;
        public const int ReturnFlagFieldNumber = 0x13;
        private uint sendCardBitFlag_;
        public const int SendCardBitFlagFieldNumber = 9;
        private string sessionKey_ = "";
        public const int SessionKeyFieldNumber = 3;
        private uint status_;
        public const int StatusFieldNumber = 0x11;
        private uint uin_;
        public const int UinFieldNumber = 2;
        private string userName_ = "";
        public const int UserNameFieldNumber = 0x10;

        static NewRegResponse()
        {
            
        }

        private NewRegResponse()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(NewRegResponse prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            NewRegResponse response = obj as NewRegResponse;
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
            if ((this.hasSessionKey != response.hasSessionKey) || (this.hasSessionKey && !this.sessionKey_.Equals(response.sessionKey_)))
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
            if ((this.hasBindEmail != response.hasBindEmail) || (this.hasBindEmail && !this.bindEmail_.Equals(response.bindEmail_)))
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
            if ((this.hasUserName != response.hasUserName) || (this.hasUserName && !this.userName_.Equals(response.userName_)))
            {
                return false;
            }
            if ((this.hasStatus != response.hasStatus) || (this.hasStatus && !this.status_.Equals(response.status_)))
            {
                return false;
            }
            if ((this.hasNetworkControl != response.hasNetworkControl) || (this.hasNetworkControl && !this.networkControl_.Equals(response.networkControl_)))
            {
                return false;
            }
            if ((this.hasReturnFlag != response.hasReturnFlag) || (this.hasReturnFlag && !this.returnFlag_.Equals(response.returnFlag_)))
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
            if ((this.hasPluginKeyList != response.hasPluginKeyList) || (this.hasPluginKeyList && !this.pluginKeyList_.Equals(response.pluginKeyList_)))
            {
                return false;
            }
            if ((this.hasPassword != response.hasPassword) || (this.hasPassword && !this.password_.Equals(response.password_)))
            {
                return false;
            }
            if ((this.hasProfileFlag != response.hasProfileFlag) || (this.hasProfileFlag && !this.profileFlag_.Equals(response.profileFlag_)))
            {
                return false;
            }
            if ((this.hasNewHostList != response.hasNewHostList) || (this.hasNewHostList && !this.newHostList_.Equals(response.newHostList_)))
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
            if (this.hasSessionKey)
            {
                hashCode ^= this.sessionKey_.GetHashCode();
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
            if (this.hasBindEmail)
            {
                hashCode ^= this.bindEmail_.GetHashCode();
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
            if (this.hasUserName)
            {
                hashCode ^= this.userName_.GetHashCode();
            }
            if (this.hasStatus)
            {
                hashCode ^= this.status_.GetHashCode();
            }
            if (this.hasNetworkControl)
            {
                hashCode ^= this.networkControl_.GetHashCode();
            }
            if (this.hasReturnFlag)
            {
                hashCode ^= this.returnFlag_.GetHashCode();
            }
            if (this.hasRegType)
            {
                hashCode ^= this.regType_.GetHashCode();
            }
            if (this.hasAuthKey)
            {
                hashCode ^= this.authKey_.GetHashCode();
            }
            if (this.hasPluginKeyList)
            {
                hashCode ^= this.pluginKeyList_.GetHashCode();
            }
            if (this.hasPassword)
            {
                hashCode ^= this.password_.GetHashCode();
            }
            if (this.hasProfileFlag)
            {
                hashCode ^= this.profileFlag_.GetHashCode();
            }
            if (this.hasNewHostList)
            {
                hashCode ^= this.newHostList_.GetHashCode();
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

        private NewRegResponse MakeReadOnly()
        {
            return this;
        }

        public static NewRegResponse ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<NewRegResponse, Builder>.PrintField("BaseResponse", this.hasBaseResponse, this.baseResponse_, writer);
            GeneratedMessageLite<NewRegResponse, Builder>.PrintField("Uin", this.hasUin, this.uin_, writer);
            GeneratedMessageLite<NewRegResponse, Builder>.PrintField("SessionKey", this.hasSessionKey, this.sessionKey_, writer);
            GeneratedMessageLite<NewRegResponse, Builder>.PrintField("OfficialUserName", this.hasOfficialUserName, this.officialUserName_, writer);
            GeneratedMessageLite<NewRegResponse, Builder>.PrintField("OfficialNickName", this.hasOfficialNickName, this.officialNickName_, writer);
            GeneratedMessageLite<NewRegResponse, Builder>.PrintField("QQMicroBlogUserName", this.hasQQMicroBlogUserName, this.qQMicroBlogUserName_, writer);
            GeneratedMessageLite<NewRegResponse, Builder>.PrintField("BindEmail", this.hasBindEmail, this.bindEmail_, writer);
            GeneratedMessageLite<NewRegResponse, Builder>.PrintField("PushMailStatus", this.hasPushMailStatus, this.pushMailStatus_, writer);
            GeneratedMessageLite<NewRegResponse, Builder>.PrintField("SendCardBitFlag", this.hasSendCardBitFlag, this.sendCardBitFlag_, writer);
            GeneratedMessageLite<NewRegResponse, Builder>.PrintField("PushMailSettingTicket", this.hasPushMailSettingTicket, this.pushMailSettingTicket_, writer);
            GeneratedMessageLite<NewRegResponse, Builder>.PrintField("BuiltinIPList", this.hasBuiltinIPList, this.builtinIPList_, writer);
            GeneratedMessageLite<NewRegResponse, Builder>.PrintField("FSURL", this.hasFSURL, this.fSURL_, writer);
            GeneratedMessageLite<NewRegResponse, Builder>.PrintField("UserName", this.hasUserName, this.userName_, writer);
            GeneratedMessageLite<NewRegResponse, Builder>.PrintField("Status", this.hasStatus, this.status_, writer);
            GeneratedMessageLite<NewRegResponse, Builder>.PrintField("NetworkControl", this.hasNetworkControl, this.networkControl_, writer);
            GeneratedMessageLite<NewRegResponse, Builder>.PrintField("ReturnFlag", this.hasReturnFlag, this.returnFlag_, writer);
            GeneratedMessageLite<NewRegResponse, Builder>.PrintField("RegType", this.hasRegType, this.regType_, writer);
            GeneratedMessageLite<NewRegResponse, Builder>.PrintField("AuthKey", this.hasAuthKey, this.authKey_, writer);
            GeneratedMessageLite<NewRegResponse, Builder>.PrintField("PluginKeyList", this.hasPluginKeyList, this.pluginKeyList_, writer);
            GeneratedMessageLite<NewRegResponse, Builder>.PrintField("Password", this.hasPassword, this.password_, writer);
            GeneratedMessageLite<NewRegResponse, Builder>.PrintField("ProfileFlag", this.hasProfileFlag, this.profileFlag_, writer);
            GeneratedMessageLite<NewRegResponse, Builder>.PrintField("NewHostList", this.hasNewHostList, this.newHostList_, writer);
            GeneratedMessageLite<NewRegResponse, Builder>.PrintField("AutoAuthTicket", this.hasAutoAuthTicket, this.autoAuthTicket_, writer);
            GeneratedMessageLite<NewRegResponse, Builder>.PrintField("DnsInfo", this.hasDnsInfo, this.dnsInfo_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _newRegResponseFieldNames;
            if (this.hasBaseResponse)
            {
                output.WriteMessage(1, strArray[2], this.BaseResponse);
            }
            if (this.hasUin)
            {
                output.WriteUInt32(2, strArray[0x16], this.Uin);
            }
            if (this.hasSessionKey)
            {
                output.WriteString(3, strArray[20], this.SessionKey);
            }
            if (this.hasOfficialUserName)
            {
                output.WriteString(4, strArray[10], this.OfficialUserName);
            }
            if (this.hasOfficialNickName)
            {
                output.WriteString(5, strArray[9], this.OfficialNickName);
            }
            if (this.hasQQMicroBlogUserName)
            {
                output.WriteString(6, strArray[0x10], this.QQMicroBlogUserName);
            }
            if (this.hasBindEmail)
            {
                output.WriteString(7, strArray[3], this.BindEmail);
            }
            if (this.hasPushMailStatus)
            {
                output.WriteUInt32(8, strArray[15], this.PushMailStatus);
            }
            if (this.hasSendCardBitFlag)
            {
                output.WriteUInt32(9, strArray[0x13], this.SendCardBitFlag);
            }
            if (this.hasPushMailSettingTicket)
            {
                output.WriteString(10, strArray[14], this.PushMailSettingTicket);
            }
            if (this.hasBuiltinIPList)
            {
                output.WriteMessage(14, strArray[4], this.BuiltinIPList);
            }
            if (this.hasFSURL)
            {
                output.WriteString(15, strArray[6], this.FSURL);
            }
            if (this.hasUserName)
            {
                output.WriteString(0x10, strArray[0x17], this.UserName);
            }
            if (this.hasStatus)
            {
                output.WriteUInt32(0x11, strArray[0x15], this.Status);
            }
            if (this.hasNetworkControl)
            {
                output.WriteMessage(0x12, strArray[7], this.NetworkControl);
            }
            if (this.hasReturnFlag)
            {
                output.WriteUInt32(0x13, strArray[0x12], this.ReturnFlag);
            }
            if (this.hasRegType)
            {
                output.WriteUInt32(20, strArray[0x11], this.RegType);
            }
            if (this.hasAuthKey)
            {
                output.WriteString(0x15, strArray[0], this.AuthKey);
            }
            if (this.hasPluginKeyList)
            {
                output.WriteMessage(0x16, strArray[12], this.PluginKeyList);
            }
            if (this.hasPassword)
            {
                output.WriteString(0x17, strArray[11], this.Password);
            }
            if (this.hasProfileFlag)
            {
                output.WriteUInt32(0x18, strArray[13], this.ProfileFlag);
            }
            if (this.hasNewHostList)
            {
                output.WriteMessage(0x19, strArray[8], this.NewHostList);
            }
            if (this.hasAutoAuthTicket)
            {
                output.WriteString(0x1a, strArray[1], this.AutoAuthTicket);
            }
            if (this.hasDnsInfo)
            {
                output.WriteMessage(0x1b, strArray[5], this.DnsInfo);
            }
        }

        public string AuthKey
        {
            get
            {
                return this.authKey_;
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

        public string BindEmail
        {
            get
            {
                return this.bindEmail_;
            }
        }

        public micromsg.BuiltinIPList BuiltinIPList
        {
            get
            {
                return (this.builtinIPList_ ?? micromsg.BuiltinIPList.DefaultInstance);
            }
        }

        public static NewRegResponse DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override NewRegResponse DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
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
                if (!this.hasPushMailStatus)
                {
                    return false;
                }
                if (!this.BaseResponse.IsInitialized)
                {
                    return false;
                }
                return true;
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

        public string OfficialNickName
        {
            get
            {
                return this.officialNickName_;
            }
        }

        public string OfficialUserName
        {
            get
            {
                return this.officialUserName_;
            }
        }

        public string Password
        {
            get
            {
                return this.password_;
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

        public string QQMicroBlogUserName
        {
            get
            {
                return this.qQMicroBlogUserName_;
            }
        }

        public uint RegType
        {
            get
            {
                return this.regType_;
            }
        }

        public uint ReturnFlag
        {
            get
            {
                return this.returnFlag_;
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
                    if (this.hasSessionKey)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(3, this.SessionKey);
                    }
                    if (this.hasOfficialUserName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(4, this.OfficialUserName);
                    }
                    if (this.hasOfficialNickName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(5, this.OfficialNickName);
                    }
                    if (this.hasQQMicroBlogUserName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(6, this.QQMicroBlogUserName);
                    }
                    if (this.hasBindEmail)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(7, this.BindEmail);
                    }
                    if (this.hasPushMailStatus)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(8, this.PushMailStatus);
                    }
                    if (this.hasSendCardBitFlag)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(9, this.SendCardBitFlag);
                    }
                    if (this.hasPushMailSettingTicket)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(10, this.PushMailSettingTicket);
                    }
                    if (this.hasBuiltinIPList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(14, this.BuiltinIPList);
                    }
                    if (this.hasFSURL)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(15, this.FSURL);
                    }
                    if (this.hasUserName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x10, this.UserName);
                    }
                    if (this.hasStatus)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(0x11, this.Status);
                    }
                    if (this.hasNetworkControl)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(0x12, this.NetworkControl);
                    }
                    if (this.hasReturnFlag)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(0x13, this.ReturnFlag);
                    }
                    if (this.hasRegType)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(20, this.RegType);
                    }
                    if (this.hasAuthKey)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x15, this.AuthKey);
                    }
                    if (this.hasPluginKeyList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(0x16, this.PluginKeyList);
                    }
                    if (this.hasPassword)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x17, this.Password);
                    }
                    if (this.hasProfileFlag)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(0x18, this.ProfileFlag);
                    }
                    if (this.hasNewHostList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(0x19, this.NewHostList);
                    }
                    if (this.hasAutoAuthTicket)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x1a, this.AutoAuthTicket);
                    }
                    if (this.hasDnsInfo)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(0x1b, this.DnsInfo);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        public string SessionKey
        {
            get
            {
                return this.sessionKey_;
            }
        }

        public uint Status
        {
            get
            {
                return this.status_;
            }
        }

        protected override NewRegResponse ThisMessage
        {
            get
            {
                return this;
            }
        }

        public uint Uin
        {
            get
            {
                return this.uin_;
            }
        }

        public string UserName
        {
            get
            {
                return this.userName_;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<NewRegResponse, NewRegResponse.Builder>
        {
            private NewRegResponse result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = NewRegResponse.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(NewRegResponse cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override NewRegResponse BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override NewRegResponse.Builder Clear()
            {
                this.result = NewRegResponse.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public NewRegResponse.Builder ClearAuthKey()
            {
                this.PrepareBuilder();
                this.result.hasAuthKey = false;
                this.result.authKey_ = "";
                return this;
            }

            public NewRegResponse.Builder ClearAutoAuthTicket()
            {
                this.PrepareBuilder();
                this.result.hasAutoAuthTicket = false;
                this.result.autoAuthTicket_ = "";
                return this;
            }

            public NewRegResponse.Builder ClearBaseResponse()
            {
                this.PrepareBuilder();
                this.result.hasBaseResponse = false;
                this.result.baseResponse_ = null;
                return this;
            }

            public NewRegResponse.Builder ClearBindEmail()
            {
                this.PrepareBuilder();
                this.result.hasBindEmail = false;
                this.result.bindEmail_ = "";
                return this;
            }

            public NewRegResponse.Builder ClearBuiltinIPList()
            {
                this.PrepareBuilder();
                this.result.hasBuiltinIPList = false;
                this.result.builtinIPList_ = null;
                return this;
            }

            public NewRegResponse.Builder ClearDnsInfo()
            {
                this.PrepareBuilder();
                this.result.hasDnsInfo = false;
                this.result.dnsInfo_ = null;
                return this;
            }

            public NewRegResponse.Builder ClearFSURL()
            {
                this.PrepareBuilder();
                this.result.hasFSURL = false;
                this.result.fSURL_ = "";
                return this;
            }

            public NewRegResponse.Builder ClearNetworkControl()
            {
                this.PrepareBuilder();
                this.result.hasNetworkControl = false;
                this.result.networkControl_ = null;
                return this;
            }

            public NewRegResponse.Builder ClearNewHostList()
            {
                this.PrepareBuilder();
                this.result.hasNewHostList = false;
                this.result.newHostList_ = null;
                return this;
            }

            public NewRegResponse.Builder ClearOfficialNickName()
            {
                this.PrepareBuilder();
                this.result.hasOfficialNickName = false;
                this.result.officialNickName_ = "";
                return this;
            }

            public NewRegResponse.Builder ClearOfficialUserName()
            {
                this.PrepareBuilder();
                this.result.hasOfficialUserName = false;
                this.result.officialUserName_ = "";
                return this;
            }

            public NewRegResponse.Builder ClearPassword()
            {
                this.PrepareBuilder();
                this.result.hasPassword = false;
                this.result.password_ = "";
                return this;
            }

            public NewRegResponse.Builder ClearPluginKeyList()
            {
                this.PrepareBuilder();
                this.result.hasPluginKeyList = false;
                this.result.pluginKeyList_ = null;
                return this;
            }

            public NewRegResponse.Builder ClearProfileFlag()
            {
                this.PrepareBuilder();
                this.result.hasProfileFlag = false;
                this.result.profileFlag_ = 0;
                return this;
            }

            public NewRegResponse.Builder ClearPushMailSettingTicket()
            {
                this.PrepareBuilder();
                this.result.hasPushMailSettingTicket = false;
                this.result.pushMailSettingTicket_ = "";
                return this;
            }

            public NewRegResponse.Builder ClearPushMailStatus()
            {
                this.PrepareBuilder();
                this.result.hasPushMailStatus = false;
                this.result.pushMailStatus_ = 0;
                return this;
            }

            public NewRegResponse.Builder ClearQQMicroBlogUserName()
            {
                this.PrepareBuilder();
                this.result.hasQQMicroBlogUserName = false;
                this.result.qQMicroBlogUserName_ = "";
                return this;
            }

            public NewRegResponse.Builder ClearRegType()
            {
                this.PrepareBuilder();
                this.result.hasRegType = false;
                this.result.regType_ = 0;
                return this;
            }

            public NewRegResponse.Builder ClearReturnFlag()
            {
                this.PrepareBuilder();
                this.result.hasReturnFlag = false;
                this.result.returnFlag_ = 0;
                return this;
            }

            public NewRegResponse.Builder ClearSendCardBitFlag()
            {
                this.PrepareBuilder();
                this.result.hasSendCardBitFlag = false;
                this.result.sendCardBitFlag_ = 0;
                return this;
            }

            public NewRegResponse.Builder ClearSessionKey()
            {
                this.PrepareBuilder();
                this.result.hasSessionKey = false;
                this.result.sessionKey_ = "";
                return this;
            }

            public NewRegResponse.Builder ClearStatus()
            {
                this.PrepareBuilder();
                this.result.hasStatus = false;
                this.result.status_ = 0;
                return this;
            }

            public NewRegResponse.Builder ClearUin()
            {
                this.PrepareBuilder();
                this.result.hasUin = false;
                this.result.uin_ = 0;
                return this;
            }

            public NewRegResponse.Builder ClearUserName()
            {
                this.PrepareBuilder();
                this.result.hasUserName = false;
                this.result.userName_ = "";
                return this;
            }

            public override NewRegResponse.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new NewRegResponse.Builder(this.result);
                }
                return new NewRegResponse.Builder().MergeFrom(this.result);
            }

            public NewRegResponse.Builder MergeBaseResponse(micromsg.BaseResponse value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasBaseResponse && (this.result.baseResponse_ != micromsg.BaseResponse.DefaultInstance))
                {
                    this.result.baseResponse_ = micromsg.BaseResponse.CreateBuilder(this.result.baseResponse_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.baseResponse_ = value;
                }
                this.result.hasBaseResponse = true;
                return this;
            }

            public NewRegResponse.Builder MergeBuiltinIPList(micromsg.BuiltinIPList value)
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

            public NewRegResponse.Builder MergeDnsInfo(CDNDnsInfo value)
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

            public override NewRegResponse.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override NewRegResponse.Builder MergeFrom(IMessageLite other)
            {
                if (other is NewRegResponse)
                {
                    return this.MergeFrom((NewRegResponse) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override NewRegResponse.Builder MergeFrom(NewRegResponse other)
            {
                return this;
            }

            public override NewRegResponse.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(NewRegResponse._newRegResponseFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = NewRegResponse._newRegResponseFieldTags[index];
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
                            this.result.hasSessionKey = input.ReadString(ref this.result.sessionKey_);
                            continue;
                        }
                        case 0x22:
                        {
                            this.result.hasOfficialUserName = input.ReadString(ref this.result.officialUserName_);
                            continue;
                        }
                        case 0x2a:
                        {
                            this.result.hasOfficialNickName = input.ReadString(ref this.result.officialNickName_);
                            continue;
                        }
                        case 0:
                            throw InvalidProtocolBufferException.InvalidTag();

                        case 10:
                        {
                            micromsg.BaseResponse.Builder builder = micromsg.BaseResponse.CreateBuilder();
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
                            this.result.hasQQMicroBlogUserName = input.ReadString(ref this.result.qQMicroBlogUserName_);
                            continue;
                        }
                        case 0x3a:
                        {
                            this.result.hasBindEmail = input.ReadString(ref this.result.bindEmail_);
                            continue;
                        }
                        case 0x40:
                        {
                            this.result.hasPushMailStatus = input.ReadUInt32(ref this.result.pushMailStatus_);
                            continue;
                        }
                        case 0x48:
                        {
                            this.result.hasSendCardBitFlag = input.ReadUInt32(ref this.result.sendCardBitFlag_);
                            continue;
                        }
                        case 0x52:
                        {
                            this.result.hasPushMailSettingTicket = input.ReadString(ref this.result.pushMailSettingTicket_);
                            continue;
                        }
                        case 0x72:
                        {
                            micromsg.BuiltinIPList.Builder builder2 = micromsg.BuiltinIPList.CreateBuilder();
                            if (this.result.hasBuiltinIPList)
                            {
                                builder2.MergeFrom(this.BuiltinIPList);
                            }
                            input.ReadMessage(builder2, extensionRegistry);
                            this.BuiltinIPList = builder2.BuildPartial();
                            continue;
                        }
                        case 0x92:
                        {
                            micromsg.NetworkControl.Builder builder3 = micromsg.NetworkControl.CreateBuilder();
                            if (this.result.hasNetworkControl)
                            {
                                builder3.MergeFrom(this.NetworkControl);
                            }
                            input.ReadMessage(builder3, extensionRegistry);
                            this.NetworkControl = builder3.BuildPartial();
                            continue;
                        }
                        case 0x98:
                        {
                            this.result.hasReturnFlag = input.ReadUInt32(ref this.result.returnFlag_);
                            continue;
                        }
                        case 160:
                        {
                            this.result.hasRegType = input.ReadUInt32(ref this.result.regType_);
                            continue;
                        }
                        case 0x7a:
                        {
                            this.result.hasFSURL = input.ReadString(ref this.result.fSURL_);
                            continue;
                        }
                        case 130:
                        {
                            this.result.hasUserName = input.ReadString(ref this.result.userName_);
                            continue;
                        }
                        case 0x88:
                        {
                            this.result.hasStatus = input.ReadUInt32(ref this.result.status_);
                            continue;
                        }
                        case 170:
                        {
                            this.result.hasAuthKey = input.ReadString(ref this.result.authKey_);
                            continue;
                        }
                        case 0xb2:
                        {
                            micromsg.PluginKeyList.Builder builder4 = micromsg.PluginKeyList.CreateBuilder();
                            if (this.result.hasPluginKeyList)
                            {
                                builder4.MergeFrom(this.PluginKeyList);
                            }
                            input.ReadMessage(builder4, extensionRegistry);
                            this.PluginKeyList = builder4.BuildPartial();
                            continue;
                        }
                        case 0xba:
                        {
                            this.result.hasPassword = input.ReadString(ref this.result.password_);
                            continue;
                        }
                        case 0xc0:
                        {
                            this.result.hasProfileFlag = input.ReadUInt32(ref this.result.profileFlag_);
                            continue;
                        }
                        case 0xca:
                        {
                            HostList.Builder builder5 = HostList.CreateBuilder();
                            if (this.result.hasNewHostList)
                            {
                                builder5.MergeFrom(this.NewHostList);
                            }
                            input.ReadMessage(builder5, extensionRegistry);
                            this.NewHostList = builder5.BuildPartial();
                            continue;
                        }
                        case 210:
                        {
                            this.result.hasAutoAuthTicket = input.ReadString(ref this.result.autoAuthTicket_);
                            continue;
                        }
                        case 0xda:
                        {
                            CDNDnsInfo.Builder builder6 = CDNDnsInfo.CreateBuilder();
                            if (this.result.hasDnsInfo)
                            {
                                builder6.MergeFrom(this.DnsInfo);
                            }
                            input.ReadMessage(builder6, extensionRegistry);
                            this.DnsInfo = builder6.BuildPartial();
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

            public NewRegResponse.Builder MergeNetworkControl(micromsg.NetworkControl value)
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

            public NewRegResponse.Builder MergeNewHostList(HostList value)
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

            public NewRegResponse.Builder MergePluginKeyList(micromsg.PluginKeyList value)
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

            private NewRegResponse PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    NewRegResponse result = this.result;
                    this.result = new NewRegResponse();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public NewRegResponse.Builder SetAuthKey(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasAuthKey = true;
                this.result.authKey_ = value;
                return this;
            }

            public NewRegResponse.Builder SetAutoAuthTicket(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasAutoAuthTicket = true;
                this.result.autoAuthTicket_ = value;
                return this;
            }

            public NewRegResponse.Builder SetBaseResponse(micromsg.BaseResponse value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = value;
                return this;
            }

            public NewRegResponse.Builder SetBaseResponse(micromsg.BaseResponse.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = builderForValue.Build();
                return this;
            }

            public NewRegResponse.Builder SetBindEmail(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBindEmail = true;
                this.result.bindEmail_ = value;
                return this;
            }

            public NewRegResponse.Builder SetBuiltinIPList(micromsg.BuiltinIPList value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBuiltinIPList = true;
                this.result.builtinIPList_ = value;
                return this;
            }

            public NewRegResponse.Builder SetBuiltinIPList(micromsg.BuiltinIPList.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBuiltinIPList = true;
                this.result.builtinIPList_ = builderForValue.Build();
                return this;
            }

            public NewRegResponse.Builder SetDnsInfo(CDNDnsInfo value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasDnsInfo = true;
                this.result.dnsInfo_ = value;
                return this;
            }

            public NewRegResponse.Builder SetDnsInfo(CDNDnsInfo.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasDnsInfo = true;
                this.result.dnsInfo_ = builderForValue.Build();
                return this;
            }

            public NewRegResponse.Builder SetFSURL(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasFSURL = true;
                this.result.fSURL_ = value;
                return this;
            }

            public NewRegResponse.Builder SetNetworkControl(micromsg.NetworkControl value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasNetworkControl = true;
                this.result.networkControl_ = value;
                return this;
            }

            public NewRegResponse.Builder SetNetworkControl(micromsg.NetworkControl.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasNetworkControl = true;
                this.result.networkControl_ = builderForValue.Build();
                return this;
            }

            public NewRegResponse.Builder SetNewHostList(HostList value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasNewHostList = true;
                this.result.newHostList_ = value;
                return this;
            }

            public NewRegResponse.Builder SetNewHostList(HostList.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasNewHostList = true;
                this.result.newHostList_ = builderForValue.Build();
                return this;
            }

            public NewRegResponse.Builder SetOfficialNickName(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasOfficialNickName = true;
                this.result.officialNickName_ = value;
                return this;
            }

            public NewRegResponse.Builder SetOfficialUserName(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasOfficialUserName = true;
                this.result.officialUserName_ = value;
                return this;
            }

            public NewRegResponse.Builder SetPassword(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasPassword = true;
                this.result.password_ = value;
                return this;
            }

            public NewRegResponse.Builder SetPluginKeyList(micromsg.PluginKeyList value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasPluginKeyList = true;
                this.result.pluginKeyList_ = value;
                return this;
            }

            public NewRegResponse.Builder SetPluginKeyList(micromsg.PluginKeyList.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasPluginKeyList = true;
                this.result.pluginKeyList_ = builderForValue.Build();
                return this;
            }

            public NewRegResponse.Builder SetProfileFlag(uint value)
            {
                this.PrepareBuilder();
                this.result.hasProfileFlag = true;
                this.result.profileFlag_ = value;
                return this;
            }

            public NewRegResponse.Builder SetPushMailSettingTicket(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasPushMailSettingTicket = true;
                this.result.pushMailSettingTicket_ = value;
                return this;
            }

            public NewRegResponse.Builder SetPushMailStatus(uint value)
            {
                this.PrepareBuilder();
                this.result.hasPushMailStatus = true;
                this.result.pushMailStatus_ = value;
                return this;
            }

            public NewRegResponse.Builder SetQQMicroBlogUserName(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasQQMicroBlogUserName = true;
                this.result.qQMicroBlogUserName_ = value;
                return this;
            }

            public NewRegResponse.Builder SetRegType(uint value)
            {
                this.PrepareBuilder();
                this.result.hasRegType = true;
                this.result.regType_ = value;
                return this;
            }

            public NewRegResponse.Builder SetReturnFlag(uint value)
            {
                this.PrepareBuilder();
                this.result.hasReturnFlag = true;
                this.result.returnFlag_ = value;
                return this;
            }

            public NewRegResponse.Builder SetSendCardBitFlag(uint value)
            {
                this.PrepareBuilder();
                this.result.hasSendCardBitFlag = true;
                this.result.sendCardBitFlag_ = value;
                return this;
            }

            public NewRegResponse.Builder SetSessionKey(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSessionKey = true;
                this.result.sessionKey_ = value;
                return this;
            }

            public NewRegResponse.Builder SetStatus(uint value)
            {
                this.PrepareBuilder();
                this.result.hasStatus = true;
                this.result.status_ = value;
                return this;
            }

            public NewRegResponse.Builder SetUin(uint value)
            {
                this.PrepareBuilder();
                this.result.hasUin = true;
                this.result.uin_ = value;
                return this;
            }

            public NewRegResponse.Builder SetUserName(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasUserName = true;
                this.result.userName_ = value;
                return this;
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

            public string BindEmail
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

            public override NewRegResponse DefaultInstanceForType
            {
                get
                {
                    return NewRegResponse.DefaultInstance;
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

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override NewRegResponse MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
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

            public string OfficialNickName
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

            public string OfficialUserName
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

            public string QQMicroBlogUserName
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

            public uint ReturnFlag
            {
                get
                {
                    return this.result.ReturnFlag;
                }
                set
                {
                    this.SetReturnFlag(value);
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

            public string SessionKey
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

            protected override NewRegResponse.Builder ThisBuilder
            {
                get
                {
                    return this;
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

            public string UserName
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


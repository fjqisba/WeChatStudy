namespace micromsg
{
    using Google.ProtocolBuffers;

    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    


    public sealed class RegResponse : GeneratedMessageLite<RegResponse, RegResponse.Builder>
    {
        private static readonly string[] _regResponseFieldNames = new string[] { "BaseResponse", "BuiltinIPList", "FSURL", "ImgBuf", "ImgSid", "NetworkControl", "OfficialNickName", "OfficialUserName", "PushMailSettingTicket", "PushMailStatus", "QQMicroBlogUserName", "SendCardBitFlag", "SessionKey", "SpareUserName", "Ticket", "Uin" };
        private static readonly uint[] _regResponseFieldTags = new uint[] { 10, 0x72, 0x7a, 0x2a, 0x22, 130, 0x4a, 0x42, 0x6a, 0x58, 0x52, 0x60, 0x1a, 0x3a, 50, 0x10 };
        private micromsg.BaseResponse baseResponse_;
        public const int BaseResponseFieldNumber = 1;
        private micromsg.BuiltinIPList builtinIPList_;
        public const int BuiltinIPListFieldNumber = 14;
        private static readonly RegResponse defaultInstance = new RegResponse().MakeReadOnly();
        private string fSURL_ = "";
        public const int FSURLFieldNumber = 15;
        private bool hasBaseResponse;
        private bool hasBuiltinIPList;
        private bool hasFSURL;
        private bool hasImgBuf;
        private bool hasImgSid;
        private bool hasNetworkControl;
        private bool hasOfficialNickName;
        private bool hasOfficialUserName;
        private bool hasPushMailSettingTicket;
        private bool hasPushMailStatus;
        private bool hasQQMicroBlogUserName;
        private bool hasSendCardBitFlag;
        private bool hasSessionKey;
        private bool hasSpareUserName;
        private bool hasTicket;
        private bool hasUin;
        private SKBuiltinBuffer_t imgBuf_;
        public const int ImgBufFieldNumber = 5;
        private SKBuiltinString_t imgSid_;
        public const int ImgSidFieldNumber = 4;
        private int memoizedSerializedSize = -1;
        private micromsg.NetworkControl networkControl_;
        public const int NetworkControlFieldNumber = 0x10;
        private SKBuiltinString_t officialNickName_;
        public const int OfficialNickNameFieldNumber = 9;
        private SKBuiltinString_t officialUserName_;
        public const int OfficialUserNameFieldNumber = 8;
        private string pushMailSettingTicket_ = "";
        public const int PushMailSettingTicketFieldNumber = 13;
        private uint pushMailStatus_;
        public const int PushMailStatusFieldNumber = 11;
        private SKBuiltinString_t qQMicroBlogUserName_;
        public const int QQMicroBlogUserNameFieldNumber = 10;
        private uint sendCardBitFlag_;
        public const int SendCardBitFlagFieldNumber = 12;
        private ByteString sessionKey_ = ByteString.Empty;
        public const int SessionKeyFieldNumber = 3;
        private SKBuiltinString_t spareUserName_;
        public const int SpareUserNameFieldNumber = 7;
        private SKBuiltinString_t ticket_;
        public const int TicketFieldNumber = 6;
        private uint uin_;
        public const int UinFieldNumber = 2;

        static RegResponse()
        {
            
        }

        private RegResponse()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(RegResponse prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            RegResponse response = obj as RegResponse;
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
            if ((this.hasImgSid != response.hasImgSid) || (this.hasImgSid && !this.imgSid_.Equals(response.imgSid_)))
            {
                return false;
            }
            if ((this.hasImgBuf != response.hasImgBuf) || (this.hasImgBuf && !this.imgBuf_.Equals(response.imgBuf_)))
            {
                return false;
            }
            if ((this.hasTicket != response.hasTicket) || (this.hasTicket && !this.ticket_.Equals(response.ticket_)))
            {
                return false;
            }
            if ((this.hasSpareUserName != response.hasSpareUserName) || (this.hasSpareUserName && !this.spareUserName_.Equals(response.spareUserName_)))
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
            return ((this.hasNetworkControl == response.hasNetworkControl) && (!this.hasNetworkControl || this.networkControl_.Equals(response.networkControl_)));
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
            if (this.hasImgSid)
            {
                hashCode ^= this.imgSid_.GetHashCode();
            }
            if (this.hasImgBuf)
            {
                hashCode ^= this.imgBuf_.GetHashCode();
            }
            if (this.hasTicket)
            {
                hashCode ^= this.ticket_.GetHashCode();
            }
            if (this.hasSpareUserName)
            {
                hashCode ^= this.spareUserName_.GetHashCode();
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
            return hashCode;
        }

        private RegResponse MakeReadOnly()
        {
            return this;
        }

        public static RegResponse ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<RegResponse, Builder>.PrintField("BaseResponse", this.hasBaseResponse, this.baseResponse_, writer);
            GeneratedMessageLite<RegResponse, Builder>.PrintField("Uin", this.hasUin, this.uin_, writer);
            GeneratedMessageLite<RegResponse, Builder>.PrintField("SessionKey", this.hasSessionKey, this.sessionKey_, writer);
            GeneratedMessageLite<RegResponse, Builder>.PrintField("ImgSid", this.hasImgSid, this.imgSid_, writer);
            GeneratedMessageLite<RegResponse, Builder>.PrintField("ImgBuf", this.hasImgBuf, this.imgBuf_, writer);
            GeneratedMessageLite<RegResponse, Builder>.PrintField("Ticket", this.hasTicket, this.ticket_, writer);
            GeneratedMessageLite<RegResponse, Builder>.PrintField("SpareUserName", this.hasSpareUserName, this.spareUserName_, writer);
            GeneratedMessageLite<RegResponse, Builder>.PrintField("OfficialUserName", this.hasOfficialUserName, this.officialUserName_, writer);
            GeneratedMessageLite<RegResponse, Builder>.PrintField("OfficialNickName", this.hasOfficialNickName, this.officialNickName_, writer);
            GeneratedMessageLite<RegResponse, Builder>.PrintField("QQMicroBlogUserName", this.hasQQMicroBlogUserName, this.qQMicroBlogUserName_, writer);
            GeneratedMessageLite<RegResponse, Builder>.PrintField("PushMailStatus", this.hasPushMailStatus, this.pushMailStatus_, writer);
            GeneratedMessageLite<RegResponse, Builder>.PrintField("SendCardBitFlag", this.hasSendCardBitFlag, this.sendCardBitFlag_, writer);
            GeneratedMessageLite<RegResponse, Builder>.PrintField("PushMailSettingTicket", this.hasPushMailSettingTicket, this.pushMailSettingTicket_, writer);
            GeneratedMessageLite<RegResponse, Builder>.PrintField("BuiltinIPList", this.hasBuiltinIPList, this.builtinIPList_, writer);
            GeneratedMessageLite<RegResponse, Builder>.PrintField("FSURL", this.hasFSURL, this.fSURL_, writer);
            GeneratedMessageLite<RegResponse, Builder>.PrintField("NetworkControl", this.hasNetworkControl, this.networkControl_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _regResponseFieldNames;
            if (this.hasBaseResponse)
            {
                output.WriteMessage(1, strArray[0], this.BaseResponse);
            }
            if (this.hasUin)
            {
                output.WriteUInt32(2, strArray[15], this.Uin);
            }
            if (this.hasSessionKey)
            {
                output.WriteBytes(3, strArray[12], this.SessionKey);
            }
            if (this.hasImgSid)
            {
                output.WriteMessage(4, strArray[4], this.ImgSid);
            }
            if (this.hasImgBuf)
            {
                output.WriteMessage(5, strArray[3], this.ImgBuf);
            }
            if (this.hasTicket)
            {
                output.WriteMessage(6, strArray[14], this.Ticket);
            }
            if (this.hasSpareUserName)
            {
                output.WriteMessage(7, strArray[13], this.SpareUserName);
            }
            if (this.hasOfficialUserName)
            {
                output.WriteMessage(8, strArray[7], this.OfficialUserName);
            }
            if (this.hasOfficialNickName)
            {
                output.WriteMessage(9, strArray[6], this.OfficialNickName);
            }
            if (this.hasQQMicroBlogUserName)
            {
                output.WriteMessage(10, strArray[10], this.QQMicroBlogUserName);
            }
            if (this.hasPushMailStatus)
            {
                output.WriteUInt32(11, strArray[9], this.PushMailStatus);
            }
            if (this.hasSendCardBitFlag)
            {
                output.WriteUInt32(12, strArray[11], this.SendCardBitFlag);
            }
            if (this.hasPushMailSettingTicket)
            {
                output.WriteString(13, strArray[8], this.PushMailSettingTicket);
            }
            if (this.hasBuiltinIPList)
            {
                output.WriteMessage(14, strArray[1], this.BuiltinIPList);
            }
            if (this.hasFSURL)
            {
                output.WriteString(15, strArray[2], this.FSURL);
            }
            if (this.hasNetworkControl)
            {
                output.WriteMessage(0x10, strArray[5], this.NetworkControl);
            }
        }

        public micromsg.BaseResponse BaseResponse
        {
            get
            {
                return (this.baseResponse_ ?? micromsg.BaseResponse.DefaultInstance);
            }
        }

        public micromsg.BuiltinIPList BuiltinIPList
        {
            get
            {
                return (this.builtinIPList_ ?? micromsg.BuiltinIPList.DefaultInstance);
            }
        }

        public static RegResponse DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override RegResponse DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public string FSURL
        {
            get
            {
                return this.fSURL_;
            }
        }

        public SKBuiltinBuffer_t ImgBuf
        {
            get
            {
                return (this.imgBuf_ ?? SKBuiltinBuffer_t.DefaultInstance);
            }
        }

        public SKBuiltinString_t ImgSid
        {
            get
            {
                return (this.imgSid_ ?? SKBuiltinString_t.DefaultInstance);
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
                if (!this.hasTicket)
                {
                    return false;
                }
                if (!this.hasSpareUserName)
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

        public micromsg.NetworkControl NetworkControl
        {
            get
            {
                return (this.networkControl_ ?? micromsg.NetworkControl.DefaultInstance);
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

        public SKBuiltinString_t QQMicroBlogUserName
        {
            get
            {
                return (this.qQMicroBlogUserName_ ?? SKBuiltinString_t.DefaultInstance);
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
                        memoizedSerializedSize += CodedOutputStream.ComputeBytesSize(3, this.SessionKey);
                    }
                    if (this.hasImgSid)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(4, this.ImgSid);
                    }
                    if (this.hasImgBuf)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(5, this.ImgBuf);
                    }
                    if (this.hasTicket)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(6, this.Ticket);
                    }
                    if (this.hasSpareUserName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(7, this.SpareUserName);
                    }
                    if (this.hasOfficialUserName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(8, this.OfficialUserName);
                    }
                    if (this.hasOfficialNickName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(9, this.OfficialNickName);
                    }
                    if (this.hasQQMicroBlogUserName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(10, this.QQMicroBlogUserName);
                    }
                    if (this.hasPushMailStatus)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(11, this.PushMailStatus);
                    }
                    if (this.hasSendCardBitFlag)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(12, this.SendCardBitFlag);
                    }
                    if (this.hasPushMailSettingTicket)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(13, this.PushMailSettingTicket);
                    }
                    if (this.hasBuiltinIPList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(14, this.BuiltinIPList);
                    }
                    if (this.hasFSURL)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(15, this.FSURL);
                    }
                    if (this.hasNetworkControl)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(0x10, this.NetworkControl);
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

        public SKBuiltinString_t SpareUserName
        {
            get
            {
                return (this.spareUserName_ ?? SKBuiltinString_t.DefaultInstance);
            }
        }

        protected override RegResponse ThisMessage
        {
            get
            {
                return this;
            }
        }

        public SKBuiltinString_t Ticket
        {
            get
            {
                return (this.ticket_ ?? SKBuiltinString_t.DefaultInstance);
            }
        }

        public uint Uin
        {
            get
            {
                return this.uin_;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<RegResponse, RegResponse.Builder>
        {
            private RegResponse result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = RegResponse.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(RegResponse cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override RegResponse BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override RegResponse.Builder Clear()
            {
                this.result = RegResponse.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public RegResponse.Builder ClearBaseResponse()
            {
                this.PrepareBuilder();
                this.result.hasBaseResponse = false;
                this.result.baseResponse_ = null;
                return this;
            }

            public RegResponse.Builder ClearBuiltinIPList()
            {
                this.PrepareBuilder();
                this.result.hasBuiltinIPList = false;
                this.result.builtinIPList_ = null;
                return this;
            }

            public RegResponse.Builder ClearFSURL()
            {
                this.PrepareBuilder();
                this.result.hasFSURL = false;
                this.result.fSURL_ = "";
                return this;
            }

            public RegResponse.Builder ClearImgBuf()
            {
                this.PrepareBuilder();
                this.result.hasImgBuf = false;
                this.result.imgBuf_ = null;
                return this;
            }

            public RegResponse.Builder ClearImgSid()
            {
                this.PrepareBuilder();
                this.result.hasImgSid = false;
                this.result.imgSid_ = null;
                return this;
            }

            public RegResponse.Builder ClearNetworkControl()
            {
                this.PrepareBuilder();
                this.result.hasNetworkControl = false;
                this.result.networkControl_ = null;
                return this;
            }

            public RegResponse.Builder ClearOfficialNickName()
            {
                this.PrepareBuilder();
                this.result.hasOfficialNickName = false;
                this.result.officialNickName_ = null;
                return this;
            }

            public RegResponse.Builder ClearOfficialUserName()
            {
                this.PrepareBuilder();
                this.result.hasOfficialUserName = false;
                this.result.officialUserName_ = null;
                return this;
            }

            public RegResponse.Builder ClearPushMailSettingTicket()
            {
                this.PrepareBuilder();
                this.result.hasPushMailSettingTicket = false;
                this.result.pushMailSettingTicket_ = "";
                return this;
            }

            public RegResponse.Builder ClearPushMailStatus()
            {
                this.PrepareBuilder();
                this.result.hasPushMailStatus = false;
                this.result.pushMailStatus_ = 0;
                return this;
            }

            public RegResponse.Builder ClearQQMicroBlogUserName()
            {
                this.PrepareBuilder();
                this.result.hasQQMicroBlogUserName = false;
                this.result.qQMicroBlogUserName_ = null;
                return this;
            }

            public RegResponse.Builder ClearSendCardBitFlag()
            {
                this.PrepareBuilder();
                this.result.hasSendCardBitFlag = false;
                this.result.sendCardBitFlag_ = 0;
                return this;
            }

            public RegResponse.Builder ClearSessionKey()
            {
                this.PrepareBuilder();
                this.result.hasSessionKey = false;
                this.result.sessionKey_ = ByteString.Empty;
                return this;
            }

            public RegResponse.Builder ClearSpareUserName()
            {
                this.PrepareBuilder();
                this.result.hasSpareUserName = false;
                this.result.spareUserName_ = null;
                return this;
            }

            public RegResponse.Builder ClearTicket()
            {
                this.PrepareBuilder();
                this.result.hasTicket = false;
                this.result.ticket_ = null;
                return this;
            }

            public RegResponse.Builder ClearUin()
            {
                this.PrepareBuilder();
                this.result.hasUin = false;
                this.result.uin_ = 0;
                return this;
            }

            public override RegResponse.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new RegResponse.Builder(this.result);
                }
                return new RegResponse.Builder().MergeFrom(this.result);
            }

            public RegResponse.Builder MergeBaseResponse(micromsg.BaseResponse value)
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

            public RegResponse.Builder MergeBuiltinIPList(micromsg.BuiltinIPList value)
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

            public override RegResponse.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override RegResponse.Builder MergeFrom(IMessageLite other)
            {
                if (other is RegResponse)
                {
                    return this.MergeFrom((RegResponse) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override RegResponse.Builder MergeFrom(RegResponse other)
            {
                return this;
            }

            public override RegResponse.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(RegResponse._regResponseFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = RegResponse._regResponseFieldTags[index];
                        }
                        else
                        {
                            this.ParseUnknownField(input, extensionRegistry, num, str);
                            continue;
                        }
                    }
                    switch (num)
                    {
                        case 0x10:
                        {
                            this.result.hasUin = input.ReadUInt32(ref this.result.uin_);
                            continue;
                        }
                        case 0x1a:
                        {
                            this.result.hasSessionKey = input.ReadBytes(ref this.result.sessionKey_);
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
                        case 0x22:
                        {
                            SKBuiltinString_t.Builder builder2 = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasImgSid)
                            {
                                builder2.MergeFrom(this.ImgSid);
                            }
                            input.ReadMessage(builder2, extensionRegistry);
                            this.ImgSid = builder2.BuildPartial();
                            continue;
                        }
                        case 0x2a:
                        {
                            SKBuiltinBuffer_t.Builder builder3 = SKBuiltinBuffer_t.CreateBuilder();
                            if (this.result.hasImgBuf)
                            {
                                builder3.MergeFrom(this.ImgBuf);
                            }
                            input.ReadMessage(builder3, extensionRegistry);
                            this.ImgBuf = builder3.BuildPartial();
                            continue;
                        }
                        case 50:
                        {
                            SKBuiltinString_t.Builder builder4 = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasTicket)
                            {
                                builder4.MergeFrom(this.Ticket);
                            }
                            input.ReadMessage(builder4, extensionRegistry);
                            this.Ticket = builder4.BuildPartial();
                            continue;
                        }
                        case 0x3a:
                        {
                            SKBuiltinString_t.Builder builder5 = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasSpareUserName)
                            {
                                builder5.MergeFrom(this.SpareUserName);
                            }
                            input.ReadMessage(builder5, extensionRegistry);
                            this.SpareUserName = builder5.BuildPartial();
                            continue;
                        }
                        case 0x52:
                        {
                            SKBuiltinString_t.Builder builder8 = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasQQMicroBlogUserName)
                            {
                                builder8.MergeFrom(this.QQMicroBlogUserName);
                            }
                            input.ReadMessage(builder8, extensionRegistry);
                            this.QQMicroBlogUserName = builder8.BuildPartial();
                            continue;
                        }
                        case 0x58:
                        {
                            this.result.hasPushMailStatus = input.ReadUInt32(ref this.result.pushMailStatus_);
                            continue;
                        }
                        case 0x42:
                        {
                            SKBuiltinString_t.Builder builder6 = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasOfficialUserName)
                            {
                                builder6.MergeFrom(this.OfficialUserName);
                            }
                            input.ReadMessage(builder6, extensionRegistry);
                            this.OfficialUserName = builder6.BuildPartial();
                            continue;
                        }
                        case 0x4a:
                        {
                            SKBuiltinString_t.Builder builder7 = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasOfficialNickName)
                            {
                                builder7.MergeFrom(this.OfficialNickName);
                            }
                            input.ReadMessage(builder7, extensionRegistry);
                            this.OfficialNickName = builder7.BuildPartial();
                            continue;
                        }
                        case 0x60:
                        {
                            this.result.hasSendCardBitFlag = input.ReadUInt32(ref this.result.sendCardBitFlag_);
                            continue;
                        }
                        case 0x6a:
                        {
                            this.result.hasPushMailSettingTicket = input.ReadString(ref this.result.pushMailSettingTicket_);
                            continue;
                        }
                        case 0x72:
                        {
                            micromsg.BuiltinIPList.Builder builder9 = micromsg.BuiltinIPList.CreateBuilder();
                            if (this.result.hasBuiltinIPList)
                            {
                                builder9.MergeFrom(this.BuiltinIPList);
                            }
                            input.ReadMessage(builder9, extensionRegistry);
                            this.BuiltinIPList = builder9.BuildPartial();
                            continue;
                        }
                        case 0x7a:
                        {
                            this.result.hasFSURL = input.ReadString(ref this.result.fSURL_);
                            continue;
                        }
                        case 130:
                        {
                            micromsg.NetworkControl.Builder builder10 = micromsg.NetworkControl.CreateBuilder();
                            if (this.result.hasNetworkControl)
                            {
                                builder10.MergeFrom(this.NetworkControl);
                            }
                            input.ReadMessage(builder10, extensionRegistry);
                            this.NetworkControl = builder10.BuildPartial();
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

            public RegResponse.Builder MergeImgBuf(SKBuiltinBuffer_t value)
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

            public RegResponse.Builder MergeImgSid(SKBuiltinString_t value)
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

            public RegResponse.Builder MergeNetworkControl(micromsg.NetworkControl value)
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

            public RegResponse.Builder MergeOfficialNickName(SKBuiltinString_t value)
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

            public RegResponse.Builder MergeOfficialUserName(SKBuiltinString_t value)
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

            public RegResponse.Builder MergeQQMicroBlogUserName(SKBuiltinString_t value)
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

            public RegResponse.Builder MergeSpareUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasSpareUserName && (this.result.spareUserName_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.spareUserName_ = SKBuiltinString_t.CreateBuilder(this.result.spareUserName_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.spareUserName_ = value;
                }
                this.result.hasSpareUserName = true;
                return this;
            }

            public RegResponse.Builder MergeTicket(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasTicket && (this.result.ticket_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.ticket_ = SKBuiltinString_t.CreateBuilder(this.result.ticket_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.ticket_ = value;
                }
                this.result.hasTicket = true;
                return this;
            }

            private RegResponse PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    RegResponse result = this.result;
                    this.result = new RegResponse();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public RegResponse.Builder SetBaseResponse(micromsg.BaseResponse value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = value;
                return this;
            }

            public RegResponse.Builder SetBaseResponse(micromsg.BaseResponse.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = builderForValue.Build();
                return this;
            }

            public RegResponse.Builder SetBuiltinIPList(micromsg.BuiltinIPList value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBuiltinIPList = true;
                this.result.builtinIPList_ = value;
                return this;
            }

            public RegResponse.Builder SetBuiltinIPList(micromsg.BuiltinIPList.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBuiltinIPList = true;
                this.result.builtinIPList_ = builderForValue.Build();
                return this;
            }

            public RegResponse.Builder SetFSURL(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasFSURL = true;
                this.result.fSURL_ = value;
                return this;
            }

            public RegResponse.Builder SetImgBuf(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasImgBuf = true;
                this.result.imgBuf_ = value;
                return this;
            }

            public RegResponse.Builder SetImgBuf(SKBuiltinBuffer_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasImgBuf = true;
                this.result.imgBuf_ = builderForValue.Build();
                return this;
            }

            public RegResponse.Builder SetImgSid(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasImgSid = true;
                this.result.imgSid_ = value;
                return this;
            }

            public RegResponse.Builder SetImgSid(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasImgSid = true;
                this.result.imgSid_ = builderForValue.Build();
                return this;
            }

            public RegResponse.Builder SetNetworkControl(micromsg.NetworkControl value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasNetworkControl = true;
                this.result.networkControl_ = value;
                return this;
            }

            public RegResponse.Builder SetNetworkControl(micromsg.NetworkControl.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasNetworkControl = true;
                this.result.networkControl_ = builderForValue.Build();
                return this;
            }

            public RegResponse.Builder SetOfficialNickName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasOfficialNickName = true;
                this.result.officialNickName_ = value;
                return this;
            }

            public RegResponse.Builder SetOfficialNickName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasOfficialNickName = true;
                this.result.officialNickName_ = builderForValue.Build();
                return this;
            }

            public RegResponse.Builder SetOfficialUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasOfficialUserName = true;
                this.result.officialUserName_ = value;
                return this;
            }

            public RegResponse.Builder SetOfficialUserName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasOfficialUserName = true;
                this.result.officialUserName_ = builderForValue.Build();
                return this;
            }

            public RegResponse.Builder SetPushMailSettingTicket(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasPushMailSettingTicket = true;
                this.result.pushMailSettingTicket_ = value;
                return this;
            }

            public RegResponse.Builder SetPushMailStatus(uint value)
            {
                this.PrepareBuilder();
                this.result.hasPushMailStatus = true;
                this.result.pushMailStatus_ = value;
                return this;
            }

            public RegResponse.Builder SetQQMicroBlogUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasQQMicroBlogUserName = true;
                this.result.qQMicroBlogUserName_ = value;
                return this;
            }

            public RegResponse.Builder SetQQMicroBlogUserName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasQQMicroBlogUserName = true;
                this.result.qQMicroBlogUserName_ = builderForValue.Build();
                return this;
            }

            public RegResponse.Builder SetSendCardBitFlag(uint value)
            {
                this.PrepareBuilder();
                this.result.hasSendCardBitFlag = true;
                this.result.sendCardBitFlag_ = value;
                return this;
            }

            public RegResponse.Builder SetSessionKey(ByteString value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSessionKey = true;
                this.result.sessionKey_ = value;
                return this;
            }

            public RegResponse.Builder SetSpareUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSpareUserName = true;
                this.result.spareUserName_ = value;
                return this;
            }

            public RegResponse.Builder SetSpareUserName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasSpareUserName = true;
                this.result.spareUserName_ = builderForValue.Build();
                return this;
            }

            public RegResponse.Builder SetTicket(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasTicket = true;
                this.result.ticket_ = value;
                return this;
            }

            public RegResponse.Builder SetTicket(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasTicket = true;
                this.result.ticket_ = builderForValue.Build();
                return this;
            }

            public RegResponse.Builder SetUin(uint value)
            {
                this.PrepareBuilder();
                this.result.hasUin = true;
                this.result.uin_ = value;
                return this;
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

            public override RegResponse DefaultInstanceForType
            {
                get
                {
                    return RegResponse.DefaultInstance;
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

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override RegResponse MessageBeingBuilt
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

            public SKBuiltinString_t SpareUserName
            {
                get
                {
                    return this.result.SpareUserName;
                }
                set
                {
                    this.SetSpareUserName(value);
                }
            }

            protected override RegResponse.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }

            public SKBuiltinString_t Ticket
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
        }
    }
}


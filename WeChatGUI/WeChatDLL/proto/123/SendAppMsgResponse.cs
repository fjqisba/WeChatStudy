namespace micromsg
{
    using Google.ProtocolBuffers;
    
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

   
    public sealed class SendAppMsgResponse : GeneratedMessageLite<SendAppMsgResponse, SendAppMsgResponse.Builder>
    {
        private static readonly string[] _sendAppMsgResponseFieldNames = new string[] { "AppId", "BaseResponse", "ClientMsgId", "CreateTime", "FromUserName", "MsgId", "ToUserName", "Type" };
        private static readonly uint[] _sendAppMsgResponseFieldTags = new uint[] { 0x12, 10, 50, 0x38, 0x1a, 40, 0x22, 0x40 };
        private string appId_ = "";
        public const int AppIdFieldNumber = 2;
        private micromsg.BaseResponse baseResponse_;
        public const int BaseResponseFieldNumber = 1;
        private string clientMsgId_ = "";
        public const int ClientMsgIdFieldNumber = 6;
        private uint createTime_;
        public const int CreateTimeFieldNumber = 7;
        private static readonly SendAppMsgResponse defaultInstance = new SendAppMsgResponse().MakeReadOnly();
        private string fromUserName_ = "";
        public const int FromUserNameFieldNumber = 3;
        private bool hasAppId;
        private bool hasBaseResponse;
        private bool hasClientMsgId;
        private bool hasCreateTime;
        private bool hasFromUserName;
        private bool hasMsgId;
        private bool hasToUserName;
        private bool hasType;
        private int memoizedSerializedSize = -1;
        private uint msgId_;
        public const int MsgIdFieldNumber = 5;
        private string toUserName_ = "";
        public const int ToUserNameFieldNumber = 4;
        private uint type_;
        public const int TypeFieldNumber = 8;

        static SendAppMsgResponse()
        {
           // object.ReferenceEquals(SendAppMsgResponse.Descriptor, null);
        }

        private SendAppMsgResponse()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(SendAppMsgResponse prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            SendAppMsgResponse response = obj as SendAppMsgResponse;
            if (response == null)
            {
                return false;
            }
            if ((this.hasBaseResponse != response.hasBaseResponse) || (this.hasBaseResponse && !this.baseResponse_.Equals(response.baseResponse_)))
            {
                return false;
            }
            if ((this.hasAppId != response.hasAppId) || (this.hasAppId && !this.appId_.Equals(response.appId_)))
            {
                return false;
            }
            if ((this.hasFromUserName != response.hasFromUserName) || (this.hasFromUserName && !this.fromUserName_.Equals(response.fromUserName_)))
            {
                return false;
            }
            if ((this.hasToUserName != response.hasToUserName) || (this.hasToUserName && !this.toUserName_.Equals(response.toUserName_)))
            {
                return false;
            }
            if ((this.hasMsgId != response.hasMsgId) || (this.hasMsgId && !this.msgId_.Equals(response.msgId_)))
            {
                return false;
            }
            if ((this.hasClientMsgId != response.hasClientMsgId) || (this.hasClientMsgId && !this.clientMsgId_.Equals(response.clientMsgId_)))
            {
                return false;
            }
            if ((this.hasCreateTime != response.hasCreateTime) || (this.hasCreateTime && !this.createTime_.Equals(response.createTime_)))
            {
                return false;
            }
            return ((this.hasType == response.hasType) && (!this.hasType || this.type_.Equals(response.type_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasBaseResponse)
            {
                hashCode ^= this.baseResponse_.GetHashCode();
            }
            if (this.hasAppId)
            {
                hashCode ^= this.appId_.GetHashCode();
            }
            if (this.hasFromUserName)
            {
                hashCode ^= this.fromUserName_.GetHashCode();
            }
            if (this.hasToUserName)
            {
                hashCode ^= this.toUserName_.GetHashCode();
            }
            if (this.hasMsgId)
            {
                hashCode ^= this.msgId_.GetHashCode();
            }
            if (this.hasClientMsgId)
            {
                hashCode ^= this.clientMsgId_.GetHashCode();
            }
            if (this.hasCreateTime)
            {
                hashCode ^= this.createTime_.GetHashCode();
            }
            if (this.hasType)
            {
                hashCode ^= this.type_.GetHashCode();
            }
            return hashCode;
        }

        private SendAppMsgResponse MakeReadOnly()
        {
            return this;
        }

        public static SendAppMsgResponse ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<SendAppMsgResponse, Builder>.PrintField("BaseResponse", this.hasBaseResponse, this.baseResponse_, writer);
            GeneratedMessageLite<SendAppMsgResponse, Builder>.PrintField("AppId", this.hasAppId, this.appId_, writer);
            GeneratedMessageLite<SendAppMsgResponse, Builder>.PrintField("FromUserName", this.hasFromUserName, this.fromUserName_, writer);
            GeneratedMessageLite<SendAppMsgResponse, Builder>.PrintField("ToUserName", this.hasToUserName, this.toUserName_, writer);
            GeneratedMessageLite<SendAppMsgResponse, Builder>.PrintField("MsgId", this.hasMsgId, this.msgId_, writer);
            GeneratedMessageLite<SendAppMsgResponse, Builder>.PrintField("ClientMsgId", this.hasClientMsgId, this.clientMsgId_, writer);
            GeneratedMessageLite<SendAppMsgResponse, Builder>.PrintField("CreateTime", this.hasCreateTime, this.createTime_, writer);
            GeneratedMessageLite<SendAppMsgResponse, Builder>.PrintField("Type", this.hasType, this.type_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _sendAppMsgResponseFieldNames;
            if (this.hasBaseResponse)
            {
                output.WriteMessage(1, strArray[1], this.BaseResponse);
            }
            if (this.hasAppId)
            {
                output.WriteString(2, strArray[0], this.AppId);
            }
            if (this.hasFromUserName)
            {
                output.WriteString(3, strArray[4], this.FromUserName);
            }
            if (this.hasToUserName)
            {
                output.WriteString(4, strArray[6], this.ToUserName);
            }
            if (this.hasMsgId)
            {
                output.WriteUInt32(5, strArray[5], this.MsgId);
            }
            if (this.hasClientMsgId)
            {
                output.WriteString(6, strArray[2], this.ClientMsgId);
            }
            if (this.hasCreateTime)
            {
                output.WriteUInt32(7, strArray[3], this.CreateTime);
            }
            if (this.hasType)
            {
                output.WriteUInt32(8, strArray[7], this.Type);
            }
        }

        public string AppId
        {
            get
            {
                return this.appId_;
            }
        }

        public micromsg.BaseResponse BaseResponse
        {
            get
            {
                return (this.baseResponse_ ?? micromsg.BaseResponse.DefaultInstance);
            }
        }

        public string ClientMsgId
        {
            get
            {
                return this.clientMsgId_;
            }
        }

        public uint CreateTime
        {
            get
            {
                return this.createTime_;
            }
        }

        public static SendAppMsgResponse DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override SendAppMsgResponse DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public string FromUserName
        {
            get
            {
                return this.fromUserName_;
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
                if (!this.hasMsgId)
                {
                    return false;
                }
                if (!this.hasCreateTime)
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

        public uint MsgId
        {
            get
            {
                return this.msgId_;
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
                    if (this.hasAppId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(2, this.AppId);
                    }
                    if (this.hasFromUserName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(3, this.FromUserName);
                    }
                    if (this.hasToUserName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(4, this.ToUserName);
                    }
                    if (this.hasMsgId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(5, this.MsgId);
                    }
                    if (this.hasClientMsgId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(6, this.ClientMsgId);
                    }
                    if (this.hasCreateTime)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(7, this.CreateTime);
                    }
                    if (this.hasType)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(8, this.Type);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override SendAppMsgResponse ThisMessage
        {
            get
            {
                return this;
            }
        }

        public string ToUserName
        {
            get
            {
                return this.toUserName_;
            }
        }

        public uint Type
        {
            get
            {
                return this.type_;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<SendAppMsgResponse, SendAppMsgResponse.Builder>
        {
            private SendAppMsgResponse result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = SendAppMsgResponse.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(SendAppMsgResponse cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override SendAppMsgResponse BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override SendAppMsgResponse.Builder Clear()
            {
                this.result = SendAppMsgResponse.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public SendAppMsgResponse.Builder ClearAppId()
            {
                this.PrepareBuilder();
                this.result.hasAppId = false;
                this.result.appId_ = "";
                return this;
            }

            public SendAppMsgResponse.Builder ClearBaseResponse()
            {
                this.PrepareBuilder();
                this.result.hasBaseResponse = false;
                this.result.baseResponse_ = null;
                return this;
            }

            public SendAppMsgResponse.Builder ClearClientMsgId()
            {
                this.PrepareBuilder();
                this.result.hasClientMsgId = false;
                this.result.clientMsgId_ = "";
                return this;
            }

            public SendAppMsgResponse.Builder ClearCreateTime()
            {
                this.PrepareBuilder();
                this.result.hasCreateTime = false;
                this.result.createTime_ = 0;
                return this;
            }

            public SendAppMsgResponse.Builder ClearFromUserName()
            {
                this.PrepareBuilder();
                this.result.hasFromUserName = false;
                this.result.fromUserName_ = "";
                return this;
            }

            public SendAppMsgResponse.Builder ClearMsgId()
            {
                this.PrepareBuilder();
                this.result.hasMsgId = false;
                this.result.msgId_ = 0;
                return this;
            }

            public SendAppMsgResponse.Builder ClearToUserName()
            {
                this.PrepareBuilder();
                this.result.hasToUserName = false;
                this.result.toUserName_ = "";
                return this;
            }

            public SendAppMsgResponse.Builder ClearType()
            {
                this.PrepareBuilder();
                this.result.hasType = false;
                this.result.type_ = 0;
                return this;
            }

            public override SendAppMsgResponse.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new SendAppMsgResponse.Builder(this.result);
                }
                return new SendAppMsgResponse.Builder().MergeFrom(this.result);
            }

            public SendAppMsgResponse.Builder MergeBaseResponse(micromsg.BaseResponse value)
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

            public override SendAppMsgResponse.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override SendAppMsgResponse.Builder MergeFrom(IMessageLite other)
            {
                if (other is SendAppMsgResponse)
                {
                    return this.MergeFrom((SendAppMsgResponse) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override SendAppMsgResponse.Builder MergeFrom(SendAppMsgResponse other)
            {
                return this;
            }

            public override SendAppMsgResponse.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(SendAppMsgResponse._sendAppMsgResponseFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = SendAppMsgResponse._sendAppMsgResponseFieldTags[index];
                        }
                        else
                        {
                            this.ParseUnknownField(input, extensionRegistry, num, str);
                            continue;
                        }
                    }
                    switch (num)
                    {
                        case 0x12:
                        {
                            this.result.hasAppId = input.ReadString(ref this.result.appId_);
                            continue;
                        }
                        case 0x1a:
                        {
                            this.result.hasFromUserName = input.ReadString(ref this.result.fromUserName_);
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
                            this.result.hasToUserName = input.ReadString(ref this.result.toUserName_);
                            continue;
                        }
                        case 40:
                        {
                            this.result.hasMsgId = input.ReadUInt32(ref this.result.msgId_);
                            continue;
                        }
                        case 50:
                        {
                            this.result.hasClientMsgId = input.ReadString(ref this.result.clientMsgId_);
                            continue;
                        }
                        case 0x38:
                        {
                            this.result.hasCreateTime = input.ReadUInt32(ref this.result.createTime_);
                            continue;
                        }
                        case 0x40:
                            break;

                        default:
                        {
                            if (WireFormat.IsEndGroupTag(num))
                            {
                                return this;
                            }
                            this.ParseUnknownField(input, extensionRegistry, num, str);
                            continue;
                        }
                    }
                    this.result.hasType = input.ReadUInt32(ref this.result.type_);
                }
                return this;
            }

            private SendAppMsgResponse PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    SendAppMsgResponse result = this.result;
                    this.result = new SendAppMsgResponse();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public SendAppMsgResponse.Builder SetAppId(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasAppId = true;
                this.result.appId_ = value;
                return this;
            }

            public SendAppMsgResponse.Builder SetBaseResponse(micromsg.BaseResponse value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = value;
                return this;
            }

            public SendAppMsgResponse.Builder SetBaseResponse(micromsg.BaseResponse.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = builderForValue.Build();
                return this;
            }

            public SendAppMsgResponse.Builder SetClientMsgId(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasClientMsgId = true;
                this.result.clientMsgId_ = value;
                return this;
            }

            public SendAppMsgResponse.Builder SetCreateTime(uint value)
            {
                this.PrepareBuilder();
                this.result.hasCreateTime = true;
                this.result.createTime_ = value;
                return this;
            }

            public SendAppMsgResponse.Builder SetFromUserName(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasFromUserName = true;
                this.result.fromUserName_ = value;
                return this;
            }

            public SendAppMsgResponse.Builder SetMsgId(uint value)
            {
                this.PrepareBuilder();
                this.result.hasMsgId = true;
                this.result.msgId_ = value;
                return this;
            }

            public SendAppMsgResponse.Builder SetToUserName(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasToUserName = true;
                this.result.toUserName_ = value;
                return this;
            }

            public SendAppMsgResponse.Builder SetType(uint value)
            {
                this.PrepareBuilder();
                this.result.hasType = true;
                this.result.type_ = value;
                return this;
            }

            public string AppId
            {
                get
                {
                    return this.result.AppId;
                }
                set
                {
                    this.SetAppId(value);
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

            public string ClientMsgId
            {
                get
                {
                    return this.result.ClientMsgId;
                }
                set
                {
                    this.SetClientMsgId(value);
                }
            }

            public uint CreateTime
            {
                get
                {
                    return this.result.CreateTime;
                }
                set
                {
                    this.SetCreateTime(value);
                }
            }

            public override SendAppMsgResponse DefaultInstanceForType
            {
                get
                {
                    return SendAppMsgResponse.DefaultInstance;
                }
            }

            public string FromUserName
            {
                get
                {
                    return this.result.FromUserName;
                }
                set
                {
                    this.SetFromUserName(value);
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override SendAppMsgResponse MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public uint MsgId
            {
                get
                {
                    return this.result.MsgId;
                }
                set
                {
                    this.SetMsgId(value);
                }
            }

            protected override SendAppMsgResponse.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }

            public string ToUserName
            {
                get
                {
                    return this.result.ToUserName;
                }
                set
                {
                    this.SetToUserName(value);
                }
            }

            public uint Type
            {
                get
                {
                    return this.result.Type;
                }
                set
                {
                    this.SetType(value);
                }
            }
        }
    }
}


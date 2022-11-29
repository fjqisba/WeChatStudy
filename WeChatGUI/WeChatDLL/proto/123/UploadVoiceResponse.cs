namespace micromsg
{
    using Google.ProtocolBuffers;
   
    using System;
    using System.IO;
    

    
    public sealed class UploadVoiceResponse : GeneratedMessageLite<UploadVoiceResponse, UploadVoiceResponse.Builder>
    {
        private static readonly string[] _uploadVoiceResponseFieldNames = new string[] { "BaseResponse", "CancelFlag", "ClientMsgId", "CreateTime", "EndFlag", "FromUserName", "Length", "MsgId", "Offset", "ToUserName", "VoiceLength" };
        private static readonly uint[] _uploadVoiceResponseFieldTags = new uint[] { 0x52, 0x58, 50, 40, 0x48, 10, 0x20, 0x38, 0x18, 0x12, 0x40 };
        private micromsg.BaseResponse baseResponse_;
        public const int BaseResponseFieldNumber = 10;
        private uint cancelFlag_;
        public const int CancelFlagFieldNumber = 11;
        private string clientMsgId_ = "";
        public const int ClientMsgIdFieldNumber = 6;
        private uint createTime_;
        public const int CreateTimeFieldNumber = 5;
        private static readonly UploadVoiceResponse defaultInstance = new UploadVoiceResponse().MakeReadOnly();
        private uint endFlag_;
        public const int EndFlagFieldNumber = 9;
        private string fromUserName_ = "";
        public const int FromUserNameFieldNumber = 1;
        private bool hasBaseResponse;
        private bool hasCancelFlag;
        private bool hasClientMsgId;
        private bool hasCreateTime;
        private bool hasEndFlag;
        private bool hasFromUserName;
        private bool hasLength;
        private bool hasMsgId;
        private bool hasOffset;
        private bool hasToUserName;
        private bool hasVoiceLength;
        private uint length_;
        public const int LengthFieldNumber = 4;
        private int memoizedSerializedSize = -1;
        private uint msgId_;
        public const int MsgIdFieldNumber = 7;
        private uint offset_;
        public const int OffsetFieldNumber = 3;
        private string toUserName_ = "";
        public const int ToUserNameFieldNumber = 2;
        private uint voiceLength_;
        public const int VoiceLengthFieldNumber = 8;

        static UploadVoiceResponse()
        {
           // object.ReferenceEquals(UploadVoiceResponse.Descriptor, null);
        }

        private UploadVoiceResponse()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(UploadVoiceResponse prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            UploadVoiceResponse response = obj as UploadVoiceResponse;
            if (response == null)
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
            if ((this.hasOffset != response.hasOffset) || (this.hasOffset && !this.offset_.Equals(response.offset_)))
            {
                return false;
            }
            if ((this.hasLength != response.hasLength) || (this.hasLength && !this.length_.Equals(response.length_)))
            {
                return false;
            }
            if ((this.hasCreateTime != response.hasCreateTime) || (this.hasCreateTime && !this.createTime_.Equals(response.createTime_)))
            {
                return false;
            }
            if ((this.hasClientMsgId != response.hasClientMsgId) || (this.hasClientMsgId && !this.clientMsgId_.Equals(response.clientMsgId_)))
            {
                return false;
            }
            if ((this.hasMsgId != response.hasMsgId) || (this.hasMsgId && !this.msgId_.Equals(response.msgId_)))
            {
                return false;
            }
            if ((this.hasVoiceLength != response.hasVoiceLength) || (this.hasVoiceLength && !this.voiceLength_.Equals(response.voiceLength_)))
            {
                return false;
            }
            if ((this.hasEndFlag != response.hasEndFlag) || (this.hasEndFlag && !this.endFlag_.Equals(response.endFlag_)))
            {
                return false;
            }
            if ((this.hasBaseResponse != response.hasBaseResponse) || (this.hasBaseResponse && !this.baseResponse_.Equals(response.baseResponse_)))
            {
                return false;
            }
            return ((this.hasCancelFlag == response.hasCancelFlag) && (!this.hasCancelFlag || this.cancelFlag_.Equals(response.cancelFlag_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasFromUserName)
            {
                hashCode ^= this.fromUserName_.GetHashCode();
            }
            if (this.hasToUserName)
            {
                hashCode ^= this.toUserName_.GetHashCode();
            }
            if (this.hasOffset)
            {
                hashCode ^= this.offset_.GetHashCode();
            }
            if (this.hasLength)
            {
                hashCode ^= this.length_.GetHashCode();
            }
            if (this.hasCreateTime)
            {
                hashCode ^= this.createTime_.GetHashCode();
            }
            if (this.hasClientMsgId)
            {
                hashCode ^= this.clientMsgId_.GetHashCode();
            }
            if (this.hasMsgId)
            {
                hashCode ^= this.msgId_.GetHashCode();
            }
            if (this.hasVoiceLength)
            {
                hashCode ^= this.voiceLength_.GetHashCode();
            }
            if (this.hasEndFlag)
            {
                hashCode ^= this.endFlag_.GetHashCode();
            }
            if (this.hasBaseResponse)
            {
                hashCode ^= this.baseResponse_.GetHashCode();
            }
            if (this.hasCancelFlag)
            {
                hashCode ^= this.cancelFlag_.GetHashCode();
            }
            return hashCode;
        }

        private UploadVoiceResponse MakeReadOnly()
        {
            return this;
        }

        public static UploadVoiceResponse ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<UploadVoiceResponse, Builder>.PrintField("FromUserName", this.hasFromUserName, this.fromUserName_, writer);
            GeneratedMessageLite<UploadVoiceResponse, Builder>.PrintField("ToUserName", this.hasToUserName, this.toUserName_, writer);
            GeneratedMessageLite<UploadVoiceResponse, Builder>.PrintField("Offset", this.hasOffset, this.offset_, writer);
            GeneratedMessageLite<UploadVoiceResponse, Builder>.PrintField("Length", this.hasLength, this.length_, writer);
            GeneratedMessageLite<UploadVoiceResponse, Builder>.PrintField("CreateTime", this.hasCreateTime, this.createTime_, writer);
            GeneratedMessageLite<UploadVoiceResponse, Builder>.PrintField("ClientMsgId", this.hasClientMsgId, this.clientMsgId_, writer);
            GeneratedMessageLite<UploadVoiceResponse, Builder>.PrintField("MsgId", this.hasMsgId, this.msgId_, writer);
            GeneratedMessageLite<UploadVoiceResponse, Builder>.PrintField("VoiceLength", this.hasVoiceLength, this.voiceLength_, writer);
            GeneratedMessageLite<UploadVoiceResponse, Builder>.PrintField("EndFlag", this.hasEndFlag, this.endFlag_, writer);
            GeneratedMessageLite<UploadVoiceResponse, Builder>.PrintField("BaseResponse", this.hasBaseResponse, this.baseResponse_, writer);
            GeneratedMessageLite<UploadVoiceResponse, Builder>.PrintField("CancelFlag", this.hasCancelFlag, this.cancelFlag_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _uploadVoiceResponseFieldNames;
            if (this.hasFromUserName)
            {
                output.WriteString(1, strArray[5], this.FromUserName);
            }
            if (this.hasToUserName)
            {
                output.WriteString(2, strArray[9], this.ToUserName);
            }
            if (this.hasOffset)
            {
                output.WriteUInt32(3, strArray[8], this.Offset);
            }
            if (this.hasLength)
            {
                output.WriteUInt32(4, strArray[6], this.Length);
            }
            if (this.hasCreateTime)
            {
                output.WriteUInt32(5, strArray[3], this.CreateTime);
            }
            if (this.hasClientMsgId)
            {
                output.WriteString(6, strArray[2], this.ClientMsgId);
            }
            if (this.hasMsgId)
            {
                output.WriteUInt32(7, strArray[7], this.MsgId);
            }
            if (this.hasVoiceLength)
            {
                output.WriteUInt32(8, strArray[10], this.VoiceLength);
            }
            if (this.hasEndFlag)
            {
                output.WriteUInt32(9, strArray[4], this.EndFlag);
            }
            if (this.hasBaseResponse)
            {
                output.WriteMessage(10, strArray[0], this.BaseResponse);
            }
            if (this.hasCancelFlag)
            {
                output.WriteUInt32(11, strArray[1], this.CancelFlag);
            }
        }

        public micromsg.BaseResponse BaseResponse
        {
            get
            {
                return (this.baseResponse_ ?? micromsg.BaseResponse.DefaultInstance);
            }
        }

        public uint CancelFlag
        {
            get
            {
                return this.cancelFlag_;
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

        public static UploadVoiceResponse DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override UploadVoiceResponse DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public uint EndFlag
        {
            get
            {
                return this.endFlag_;
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
                if (!this.hasOffset)
                {
                    return false;
                }
                if (!this.hasLength)
                {
                    return false;
                }
                if (!this.hasCreateTime)
                {
                    return false;
                }
                if (!this.hasMsgId)
                {
                    return false;
                }
                if (!this.hasVoiceLength)
                {
                    return false;
                }
                if (!this.hasEndFlag)
                {
                    return false;
                }
                if (!this.hasBaseResponse)
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

        public uint Length
        {
            get
            {
                return this.length_;
            }
        }

        public uint MsgId
        {
            get
            {
                return this.msgId_;
            }
        }

        public uint Offset
        {
            get
            {
                return this.offset_;
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
                    if (this.hasFromUserName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(1, this.FromUserName);
                    }
                    if (this.hasToUserName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(2, this.ToUserName);
                    }
                    if (this.hasOffset)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(3, this.Offset);
                    }
                    if (this.hasLength)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(4, this.Length);
                    }
                    if (this.hasCreateTime)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(5, this.CreateTime);
                    }
                    if (this.hasClientMsgId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(6, this.ClientMsgId);
                    }
                    if (this.hasMsgId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(7, this.MsgId);
                    }
                    if (this.hasVoiceLength)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(8, this.VoiceLength);
                    }
                    if (this.hasEndFlag)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(9, this.EndFlag);
                    }
                    if (this.hasBaseResponse)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(10, this.BaseResponse);
                    }
                    if (this.hasCancelFlag)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(11, this.CancelFlag);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override UploadVoiceResponse ThisMessage
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

        public uint VoiceLength
        {
            get
            {
                return this.voiceLength_;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<UploadVoiceResponse, UploadVoiceResponse.Builder>
        {
            private UploadVoiceResponse result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = UploadVoiceResponse.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(UploadVoiceResponse cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override UploadVoiceResponse BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override UploadVoiceResponse.Builder Clear()
            {
                this.result = UploadVoiceResponse.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public UploadVoiceResponse.Builder ClearBaseResponse()
            {
                this.PrepareBuilder();
                this.result.hasBaseResponse = false;
                this.result.baseResponse_ = null;
                return this;
            }

            public UploadVoiceResponse.Builder ClearCancelFlag()
            {
                this.PrepareBuilder();
                this.result.hasCancelFlag = false;
                this.result.cancelFlag_ = 0;
                return this;
            }

            public UploadVoiceResponse.Builder ClearClientMsgId()
            {
                this.PrepareBuilder();
                this.result.hasClientMsgId = false;
                this.result.clientMsgId_ = "";
                return this;
            }

            public UploadVoiceResponse.Builder ClearCreateTime()
            {
                this.PrepareBuilder();
                this.result.hasCreateTime = false;
                this.result.createTime_ = 0;
                return this;
            }

            public UploadVoiceResponse.Builder ClearEndFlag()
            {
                this.PrepareBuilder();
                this.result.hasEndFlag = false;
                this.result.endFlag_ = 0;
                return this;
            }

            public UploadVoiceResponse.Builder ClearFromUserName()
            {
                this.PrepareBuilder();
                this.result.hasFromUserName = false;
                this.result.fromUserName_ = "";
                return this;
            }

            public UploadVoiceResponse.Builder ClearLength()
            {
                this.PrepareBuilder();
                this.result.hasLength = false;
                this.result.length_ = 0;
                return this;
            }

            public UploadVoiceResponse.Builder ClearMsgId()
            {
                this.PrepareBuilder();
                this.result.hasMsgId = false;
                this.result.msgId_ = 0;
                return this;
            }

            public UploadVoiceResponse.Builder ClearOffset()
            {
                this.PrepareBuilder();
                this.result.hasOffset = false;
                this.result.offset_ = 0;
                return this;
            }

            public UploadVoiceResponse.Builder ClearToUserName()
            {
                this.PrepareBuilder();
                this.result.hasToUserName = false;
                this.result.toUserName_ = "";
                return this;
            }

            public UploadVoiceResponse.Builder ClearVoiceLength()
            {
                this.PrepareBuilder();
                this.result.hasVoiceLength = false;
                this.result.voiceLength_ = 0;
                return this;
            }

            public override UploadVoiceResponse.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new UploadVoiceResponse.Builder(this.result);
                }
                return new UploadVoiceResponse.Builder().MergeFrom(this.result);
            }

            public UploadVoiceResponse.Builder MergeBaseResponse(micromsg.BaseResponse value)
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

            public override UploadVoiceResponse.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override UploadVoiceResponse.Builder MergeFrom(IMessageLite other)
            {
                if (other is UploadVoiceResponse)
                {
                    return this.MergeFrom((UploadVoiceResponse) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override UploadVoiceResponse.Builder MergeFrom(UploadVoiceResponse other)
            {
                return this;
            }

            public override UploadVoiceResponse.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(UploadVoiceResponse._uploadVoiceResponseFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = UploadVoiceResponse._uploadVoiceResponseFieldTags[index];
                        }
                        else
                        {
                            this.ParseUnknownField(input, extensionRegistry, num, str);
                            continue;
                        }
                    }
                    switch (num)
                    {
                        case 0x18:
                        {
                            this.result.hasOffset = input.ReadUInt32(ref this.result.offset_);
                            continue;
                        }
                        case 0x20:
                        {
                            this.result.hasLength = input.ReadUInt32(ref this.result.length_);
                            continue;
                        }
                        case 40:
                        {
                            this.result.hasCreateTime = input.ReadUInt32(ref this.result.createTime_);
                            continue;
                        }
                        case 0:
                            throw InvalidProtocolBufferException.InvalidTag();

                        case 10:
                        {
                            this.result.hasFromUserName = input.ReadString(ref this.result.fromUserName_);
                            continue;
                        }
                        case 0x12:
                        {
                            this.result.hasToUserName = input.ReadString(ref this.result.toUserName_);
                            continue;
                        }
                        case 50:
                        {
                            this.result.hasClientMsgId = input.ReadString(ref this.result.clientMsgId_);
                            continue;
                        }
                        case 0x38:
                        {
                            this.result.hasMsgId = input.ReadUInt32(ref this.result.msgId_);
                            continue;
                        }
                        case 0x40:
                        {
                            this.result.hasVoiceLength = input.ReadUInt32(ref this.result.voiceLength_);
                            continue;
                        }
                        case 0x48:
                        {
                            this.result.hasEndFlag = input.ReadUInt32(ref this.result.endFlag_);
                            continue;
                        }
                        case 0x52:
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
                        case 0x58:
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
                    this.result.hasCancelFlag = input.ReadUInt32(ref this.result.cancelFlag_);
                }
                return this;
            }

            private UploadVoiceResponse PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    UploadVoiceResponse result = this.result;
                    this.result = new UploadVoiceResponse();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public UploadVoiceResponse.Builder SetBaseResponse(micromsg.BaseResponse value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = value;
                return this;
            }

            public UploadVoiceResponse.Builder SetBaseResponse(micromsg.BaseResponse.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = builderForValue.Build();
                return this;
            }

            public UploadVoiceResponse.Builder SetCancelFlag(uint value)
            {
                this.PrepareBuilder();
                this.result.hasCancelFlag = true;
                this.result.cancelFlag_ = value;
                return this;
            }

            public UploadVoiceResponse.Builder SetClientMsgId(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasClientMsgId = true;
                this.result.clientMsgId_ = value;
                return this;
            }

            public UploadVoiceResponse.Builder SetCreateTime(uint value)
            {
                this.PrepareBuilder();
                this.result.hasCreateTime = true;
                this.result.createTime_ = value;
                return this;
            }

            public UploadVoiceResponse.Builder SetEndFlag(uint value)
            {
                this.PrepareBuilder();
                this.result.hasEndFlag = true;
                this.result.endFlag_ = value;
                return this;
            }

            public UploadVoiceResponse.Builder SetFromUserName(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasFromUserName = true;
                this.result.fromUserName_ = value;
                return this;
            }

            public UploadVoiceResponse.Builder SetLength(uint value)
            {
                this.PrepareBuilder();
                this.result.hasLength = true;
                this.result.length_ = value;
                return this;
            }

            public UploadVoiceResponse.Builder SetMsgId(uint value)
            {
                this.PrepareBuilder();
                this.result.hasMsgId = true;
                this.result.msgId_ = value;
                return this;
            }

            public UploadVoiceResponse.Builder SetOffset(uint value)
            {
                this.PrepareBuilder();
                this.result.hasOffset = true;
                this.result.offset_ = value;
                return this;
            }

            public UploadVoiceResponse.Builder SetToUserName(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasToUserName = true;
                this.result.toUserName_ = value;
                return this;
            }

            public UploadVoiceResponse.Builder SetVoiceLength(uint value)
            {
                this.PrepareBuilder();
                this.result.hasVoiceLength = true;
                this.result.voiceLength_ = value;
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

            public uint CancelFlag
            {
                get
                {
                    return this.result.CancelFlag;
                }
                set
                {
                    this.SetCancelFlag(value);
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

            public override UploadVoiceResponse DefaultInstanceForType
            {
                get
                {
                    return UploadVoiceResponse.DefaultInstance;
                }
            }

            public uint EndFlag
            {
                get
                {
                    return this.result.EndFlag;
                }
                set
                {
                    this.SetEndFlag(value);
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

            public uint Length
            {
                get
                {
                    return this.result.Length;
                }
                set
                {
                    this.SetLength(value);
                }
            }

            protected override UploadVoiceResponse MessageBeingBuilt
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

            public uint Offset
            {
                get
                {
                    return this.result.Offset;
                }
                set
                {
                    this.SetOffset(value);
                }
            }

            protected override UploadVoiceResponse.Builder ThisBuilder
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

            public uint VoiceLength
            {
                get
                {
                    return this.result.VoiceLength;
                }
                set
                {
                    this.SetVoiceLength(value);
                }
            }
        }
    }
}


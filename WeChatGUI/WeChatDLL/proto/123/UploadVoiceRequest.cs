namespace micromsg
{
    using Google.ProtocolBuffers;

    using System;
    using System.IO;


 
    public sealed class UploadVoiceRequest : GeneratedMessageLite<UploadVoiceRequest, UploadVoiceRequest.Builder>
    {
        private static readonly string[] _uploadVoiceRequestFieldNames = new string[] {
            "BaseRequest", "CancelFlag", "ClientMsgId", "Data", "EndFlag", "ForwardFlag", "FromUserName", "Length", "MsgId", "MsgSource", "NewMsgId", "Offset", "ReqTime", "ToUserName", "UICreateTime", "VoiceFormat",
            "VoiceId", "VoiceLength"
         };
        private static readonly uint[] _uploadVoiceRequestFieldTags = new uint[] {
            0x52, 0x58, 0x2a, 0x42, 0x48, 120, 10, 0x20, 0x30, 0x62, 0x80, 0x18, 0x88, 0x12, 0x70, 0x68,
            0x92, 0x38
         };
        private BaseRequest baseRequest_;
        public const int BaseRequestFieldNumber = 10;
        private uint cancelFlag_;
        public const int CancelFlagFieldNumber = 11;
        private string clientMsgId_ = "";
        public const int ClientMsgIdFieldNumber = 5;
        private SKBuiltinBuffer_t data_;
        public const int DataFieldNumber = 8;
        private static readonly UploadVoiceRequest defaultInstance = new UploadVoiceRequest().MakeReadOnly();
        private uint endFlag_;
        public const int EndFlagFieldNumber = 9;
        private uint forwardFlag_;
        public const int ForwardFlagFieldNumber = 15;
        private string fromUserName_ = "";
        public const int FromUserNameFieldNumber = 1;
        private bool hasBaseRequest;
        private bool hasCancelFlag;
        private bool hasClientMsgId;
        private bool hasData;
        private bool hasEndFlag;
        private bool hasForwardFlag;
        private bool hasFromUserName;
        private bool hasLength;
        private bool hasMsgId;
        private bool hasMsgSource;
        private bool hasNewMsgId;
        private bool hasOffset;
        private bool hasReqTime;
        private bool hasToUserName;
        private bool hasUICreateTime;
        private bool hasVoiceFormat;
        private bool hasVoiceId;
        private bool hasVoiceLength;
        private uint length_;
        public const int LengthFieldNumber = 4;
        private int memoizedSerializedSize = -1;
        private uint msgId_;
        public const int MsgIdFieldNumber = 6;
        private string msgSource_ = "";
        public const int MsgSourceFieldNumber = 12;
        private ulong newMsgId_;
        public const int NewMsgIdFieldNumber = 0x10;
        private uint offset_;
        public const int OffsetFieldNumber = 3;
        private uint reqTime_;
        public const int ReqTimeFieldNumber = 0x11;
        private string toUserName_ = "";
        public const int ToUserNameFieldNumber = 2;
        private uint uICreateTime_;
        public const int UICreateTimeFieldNumber = 14;
        private uint voiceFormat_;
        public const int VoiceFormatFieldNumber = 13;
        private SKBuiltinBuffer_t voiceId_;
        public const int VoiceIdFieldNumber = 0x12;
        private uint voiceLength_;
        public const int VoiceLengthFieldNumber = 7;

    
        private UploadVoiceRequest()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(UploadVoiceRequest prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            UploadVoiceRequest request = obj as UploadVoiceRequest;
            if (request == null)
            {
                return false;
            }
            if ((this.hasFromUserName != request.hasFromUserName) || (this.hasFromUserName && !this.fromUserName_.Equals(request.fromUserName_)))
            {
                return false;
            }
            if ((this.hasToUserName != request.hasToUserName) || (this.hasToUserName && !this.toUserName_.Equals(request.toUserName_)))
            {
                return false;
            }
            if ((this.hasOffset != request.hasOffset) || (this.hasOffset && !this.offset_.Equals(request.offset_)))
            {
                return false;
            }
            if ((this.hasLength != request.hasLength) || (this.hasLength && !this.length_.Equals(request.length_)))
            {
                return false;
            }
            if ((this.hasClientMsgId != request.hasClientMsgId) || (this.hasClientMsgId && !this.clientMsgId_.Equals(request.clientMsgId_)))
            {
                return false;
            }
            if ((this.hasMsgId != request.hasMsgId) || (this.hasMsgId && !this.msgId_.Equals(request.msgId_)))
            {
                return false;
            }
            if ((this.hasVoiceLength != request.hasVoiceLength) || (this.hasVoiceLength && !this.voiceLength_.Equals(request.voiceLength_)))
            {
                return false;
            }
            if ((this.hasData != request.hasData) || (this.hasData && !this.data_.Equals(request.data_)))
            {
                return false;
            }
            if ((this.hasEndFlag != request.hasEndFlag) || (this.hasEndFlag && !this.endFlag_.Equals(request.endFlag_)))
            {
                return false;
            }
            if ((this.hasBaseRequest != request.hasBaseRequest) || (this.hasBaseRequest && !this.baseRequest_.Equals(request.baseRequest_)))
            {
                return false;
            }
            if ((this.hasCancelFlag != request.hasCancelFlag) || (this.hasCancelFlag && !this.cancelFlag_.Equals(request.cancelFlag_)))
            {
                return false;
            }
            if ((this.hasMsgSource != request.hasMsgSource) || (this.hasMsgSource && !this.msgSource_.Equals(request.msgSource_)))
            {
                return false;
            }
            if ((this.hasVoiceFormat != request.hasVoiceFormat) || (this.hasVoiceFormat && !this.voiceFormat_.Equals(request.voiceFormat_)))
            {
                return false;
            }
            if ((this.hasUICreateTime != request.hasUICreateTime) || (this.hasUICreateTime && !this.uICreateTime_.Equals(request.uICreateTime_)))
            {
                return false;
            }
            if ((this.hasForwardFlag != request.hasForwardFlag) || (this.hasForwardFlag && !this.forwardFlag_.Equals(request.forwardFlag_)))
            {
                return false;
            }
            if ((this.hasNewMsgId != request.hasNewMsgId) || (this.hasNewMsgId && !this.newMsgId_.Equals(request.newMsgId_)))
            {
                return false;
            }
            if ((this.hasReqTime != request.hasReqTime) || (this.hasReqTime && !this.reqTime_.Equals(request.reqTime_)))
            {
                return false;
            }
            return ((this.hasVoiceId == request.hasVoiceId) && (!this.hasVoiceId || this.voiceId_.Equals(request.voiceId_)));
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
            if (this.hasData)
            {
                hashCode ^= this.data_.GetHashCode();
            }
            if (this.hasEndFlag)
            {
                hashCode ^= this.endFlag_.GetHashCode();
            }
            if (this.hasBaseRequest)
            {
                hashCode ^= this.baseRequest_.GetHashCode();
            }
            if (this.hasCancelFlag)
            {
                hashCode ^= this.cancelFlag_.GetHashCode();
            }
            if (this.hasMsgSource)
            {
                hashCode ^= this.msgSource_.GetHashCode();
            }
            if (this.hasVoiceFormat)
            {
                hashCode ^= this.voiceFormat_.GetHashCode();
            }
            if (this.hasUICreateTime)
            {
                hashCode ^= this.uICreateTime_.GetHashCode();
            }
            if (this.hasForwardFlag)
            {
                hashCode ^= this.forwardFlag_.GetHashCode();
            }
            if (this.hasNewMsgId)
            {
                hashCode ^= this.newMsgId_.GetHashCode();
            }
            if (this.hasReqTime)
            {
                hashCode ^= this.reqTime_.GetHashCode();
            }
            if (this.hasVoiceId)
            {
                hashCode ^= this.voiceId_.GetHashCode();
            }
            return hashCode;
        }

        private UploadVoiceRequest MakeReadOnly()
        {
            return this;
        }

        public static UploadVoiceRequest ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<UploadVoiceRequest, Builder>.PrintField("FromUserName", this.hasFromUserName, this.fromUserName_, writer);
            GeneratedMessageLite<UploadVoiceRequest, Builder>.PrintField("ToUserName", this.hasToUserName, this.toUserName_, writer);
            GeneratedMessageLite<UploadVoiceRequest, Builder>.PrintField("Offset", this.hasOffset, this.offset_, writer);
            GeneratedMessageLite<UploadVoiceRequest, Builder>.PrintField("Length", this.hasLength, this.length_, writer);
            GeneratedMessageLite<UploadVoiceRequest, Builder>.PrintField("ClientMsgId", this.hasClientMsgId, this.clientMsgId_, writer);
            GeneratedMessageLite<UploadVoiceRequest, Builder>.PrintField("MsgId", this.hasMsgId, this.msgId_, writer);
            GeneratedMessageLite<UploadVoiceRequest, Builder>.PrintField("VoiceLength", this.hasVoiceLength, this.voiceLength_, writer);
            GeneratedMessageLite<UploadVoiceRequest, Builder>.PrintField("Data", this.hasData, this.data_, writer);
            GeneratedMessageLite<UploadVoiceRequest, Builder>.PrintField("EndFlag", this.hasEndFlag, this.endFlag_, writer);
            GeneratedMessageLite<UploadVoiceRequest, Builder>.PrintField("BaseRequest", this.hasBaseRequest, this.baseRequest_, writer);
            GeneratedMessageLite<UploadVoiceRequest, Builder>.PrintField("CancelFlag", this.hasCancelFlag, this.cancelFlag_, writer);
            GeneratedMessageLite<UploadVoiceRequest, Builder>.PrintField("MsgSource", this.hasMsgSource, this.msgSource_, writer);
            GeneratedMessageLite<UploadVoiceRequest, Builder>.PrintField("VoiceFormat", this.hasVoiceFormat, this.voiceFormat_, writer);
            GeneratedMessageLite<UploadVoiceRequest, Builder>.PrintField("UICreateTime", this.hasUICreateTime, this.uICreateTime_, writer);
            GeneratedMessageLite<UploadVoiceRequest, Builder>.PrintField("ForwardFlag", this.hasForwardFlag, this.forwardFlag_, writer);
            GeneratedMessageLite<UploadVoiceRequest, Builder>.PrintField("NewMsgId", this.hasNewMsgId, this.newMsgId_, writer);
            GeneratedMessageLite<UploadVoiceRequest, Builder>.PrintField("ReqTime", this.hasReqTime, this.reqTime_, writer);
            GeneratedMessageLite<UploadVoiceRequest, Builder>.PrintField("VoiceId", this.hasVoiceId, this.voiceId_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _uploadVoiceRequestFieldNames;
            if (this.hasFromUserName)
            {
                output.WriteString(1, strArray[6], this.FromUserName);
            }
            if (this.hasToUserName)
            {
                output.WriteString(2, strArray[13], this.ToUserName);
            }
            if (this.hasOffset)
            {
                output.WriteUInt32(3, strArray[11], this.Offset);
            }
            if (this.hasLength)
            {
                output.WriteUInt32(4, strArray[7], this.Length);
            }
            if (this.hasClientMsgId)
            {
                output.WriteString(5, strArray[2], this.ClientMsgId);
            }
            if (this.hasMsgId)
            {
                output.WriteUInt32(6, strArray[8], this.MsgId);
            }
            if (this.hasVoiceLength)
            {
                output.WriteUInt32(7, strArray[0x11], this.VoiceLength);
            }
            if (this.hasData)
            {
                output.WriteMessage(8, strArray[3], this.Data);
            }
            if (this.hasEndFlag)
            {
                output.WriteUInt32(9, strArray[4], this.EndFlag);
            }
            if (this.hasBaseRequest)
            {
                output.WriteMessage(10, strArray[0], this.BaseRequest);
            }
            if (this.hasCancelFlag)
            {
                output.WriteUInt32(11, strArray[1], this.CancelFlag);
            }
            if (this.hasMsgSource)
            {
                output.WriteString(12, strArray[9], this.MsgSource);
            }
            if (this.hasVoiceFormat)
            {
                output.WriteUInt32(13, strArray[15], this.VoiceFormat);
            }
            if (this.hasUICreateTime)
            {
                output.WriteUInt32(14, strArray[14], this.UICreateTime);
            }
            if (this.hasForwardFlag)
            {
                output.WriteUInt32(15, strArray[5], this.ForwardFlag);
            }
            if (this.hasNewMsgId)
            {
                output.WriteUInt64(0x10, strArray[10], this.NewMsgId);
            }
            if (this.hasReqTime)
            {
                output.WriteUInt32(0x11, strArray[12], this.ReqTime);
            }
            if (this.hasVoiceId)
            {
                output.WriteMessage(0x12, strArray[0x10], this.VoiceId);
            }
        }

        public BaseRequest BaseRequest
        {
            get
            {
                return (this.baseRequest_ ?? BaseRequest.DefaultInstance);
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

        public SKBuiltinBuffer_t Data
        {
            get
            {
                return (this.data_ ?? SKBuiltinBuffer_t.DefaultInstance);
            }
        }

        public static UploadVoiceRequest DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override UploadVoiceRequest DefaultInstanceForType
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

        public uint ForwardFlag
        {
            get
            {
                return this.forwardFlag_;
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
                if (!this.hasMsgId)
                {
                    return false;
                }
                if (!this.hasVoiceLength)
                {
                    return false;
                }
                if (!this.hasData)
                {
                    return false;
                }
                if (!this.hasEndFlag)
                {
                    return false;
                }
                if (!this.hasBaseRequest)
                {
                    return false;
                }
                if (!this.Data.IsInitialized)
                {
                    return false;
                }
                if (!this.BaseRequest.IsInitialized)
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

        public string MsgSource
        {
            get
            {
                return this.msgSource_;
            }
        }

        public ulong NewMsgId
        {
            get
            {
                return this.newMsgId_;
            }
        }

        public uint Offset
        {
            get
            {
                return this.offset_;
            }
        }

        public uint ReqTime
        {
            get
            {
                return this.reqTime_;
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
                    if (this.hasClientMsgId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(5, this.ClientMsgId);
                    }
                    if (this.hasMsgId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(6, this.MsgId);
                    }
                    if (this.hasVoiceLength)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(7, this.VoiceLength);
                    }
                    if (this.hasData)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(8, this.Data);
                    }
                    if (this.hasEndFlag)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(9, this.EndFlag);
                    }
                    if (this.hasBaseRequest)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(10, this.BaseRequest);
                    }
                    if (this.hasCancelFlag)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(11, this.CancelFlag);
                    }
                    if (this.hasMsgSource)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(12, this.MsgSource);
                    }
                    if (this.hasVoiceFormat)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(13, this.VoiceFormat);
                    }
                    if (this.hasUICreateTime)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(14, this.UICreateTime);
                    }
                    if (this.hasForwardFlag)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(15, this.ForwardFlag);
                    }
                    if (this.hasNewMsgId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt64Size(0x10, this.NewMsgId);
                    }
                    if (this.hasReqTime)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(0x11, this.ReqTime);
                    }
                    if (this.hasVoiceId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(0x12, this.VoiceId);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override UploadVoiceRequest ThisMessage
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

        public uint UICreateTime
        {
            get
            {
                return this.uICreateTime_;
            }
        }

        public uint VoiceFormat
        {
            get
            {
                return this.voiceFormat_;
            }
        }

        public SKBuiltinBuffer_t VoiceId
        {
            get
            {
                return (this.voiceId_ ?? SKBuiltinBuffer_t.DefaultInstance);
            }
        }

        public uint VoiceLength
        {
            get
            {
                return this.voiceLength_;
            }
        }

 
        public sealed class Builder : GeneratedBuilderLite<UploadVoiceRequest, UploadVoiceRequest.Builder>
        {
            private UploadVoiceRequest result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = UploadVoiceRequest.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(UploadVoiceRequest cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override UploadVoiceRequest BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override UploadVoiceRequest.Builder Clear()
            {
                this.result = UploadVoiceRequest.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public UploadVoiceRequest.Builder ClearBaseRequest()
            {
                this.PrepareBuilder();
                this.result.hasBaseRequest = false;
                this.result.baseRequest_ = null;
                return this;
            }

            public UploadVoiceRequest.Builder ClearCancelFlag()
            {
                this.PrepareBuilder();
                this.result.hasCancelFlag = false;
                this.result.cancelFlag_ = 0;
                return this;
            }

            public UploadVoiceRequest.Builder ClearClientMsgId()
            {
                this.PrepareBuilder();
                this.result.hasClientMsgId = false;
                this.result.clientMsgId_ = "";
                return this;
            }

            public UploadVoiceRequest.Builder ClearData()
            {
                this.PrepareBuilder();
                this.result.hasData = false;
                this.result.data_ = null;
                return this;
            }

            public UploadVoiceRequest.Builder ClearEndFlag()
            {
                this.PrepareBuilder();
                this.result.hasEndFlag = false;
                this.result.endFlag_ = 0;
                return this;
            }

            public UploadVoiceRequest.Builder ClearForwardFlag()
            {
                this.PrepareBuilder();
                this.result.hasForwardFlag = false;
                this.result.forwardFlag_ = 0;
                return this;
            }

            public UploadVoiceRequest.Builder ClearFromUserName()
            {
                this.PrepareBuilder();
                this.result.hasFromUserName = false;
                this.result.fromUserName_ = "";
                return this;
            }

            public UploadVoiceRequest.Builder ClearLength()
            {
                this.PrepareBuilder();
                this.result.hasLength = false;
                this.result.length_ = 0;
                return this;
            }

            public UploadVoiceRequest.Builder ClearMsgId()
            {
                this.PrepareBuilder();
                this.result.hasMsgId = false;
                this.result.msgId_ = 0;
                return this;
            }

            public UploadVoiceRequest.Builder ClearMsgSource()
            {
                this.PrepareBuilder();
                this.result.hasMsgSource = false;
                this.result.msgSource_ = "";
                return this;
            }

            public UploadVoiceRequest.Builder ClearNewMsgId()
            {
                this.PrepareBuilder();
                this.result.hasNewMsgId = false;
                this.result.newMsgId_ = 0L;
                return this;
            }

            public UploadVoiceRequest.Builder ClearOffset()
            {
                this.PrepareBuilder();
                this.result.hasOffset = false;
                this.result.offset_ = 0;
                return this;
            }

            public UploadVoiceRequest.Builder ClearReqTime()
            {
                this.PrepareBuilder();
                this.result.hasReqTime = false;
                this.result.reqTime_ = 0;
                return this;
            }

            public UploadVoiceRequest.Builder ClearToUserName()
            {
                this.PrepareBuilder();
                this.result.hasToUserName = false;
                this.result.toUserName_ = "";
                return this;
            }

            public UploadVoiceRequest.Builder ClearUICreateTime()
            {
                this.PrepareBuilder();
                this.result.hasUICreateTime = false;
                this.result.uICreateTime_ = 0;
                return this;
            }

            public UploadVoiceRequest.Builder ClearVoiceFormat()
            {
                this.PrepareBuilder();
                this.result.hasVoiceFormat = false;
                this.result.voiceFormat_ = 0;
                return this;
            }

            public UploadVoiceRequest.Builder ClearVoiceId()
            {
                this.PrepareBuilder();
                this.result.hasVoiceId = false;
                this.result.voiceId_ = null;
                return this;
            }

            public UploadVoiceRequest.Builder ClearVoiceLength()
            {
                this.PrepareBuilder();
                this.result.hasVoiceLength = false;
                this.result.voiceLength_ = 0;
                return this;
            }

            public override UploadVoiceRequest.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new UploadVoiceRequest.Builder(this.result);
                }
                return new UploadVoiceRequest.Builder().MergeFrom(this.result);
            }

            public UploadVoiceRequest.Builder MergeBaseRequest(BaseRequest value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasBaseRequest && (this.result.baseRequest_ != BaseRequest.DefaultInstance))
                {
                    this.result.baseRequest_ = BaseRequest.CreateBuilder(this.result.baseRequest_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.baseRequest_ = value;
                }
                this.result.hasBaseRequest = true;
                return this;
            }

            public UploadVoiceRequest.Builder MergeData(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasData && (this.result.data_ != SKBuiltinBuffer_t.DefaultInstance))
                {
                    this.result.data_ = SKBuiltinBuffer_t.CreateBuilder(this.result.data_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.data_ = value;
                }
                this.result.hasData = true;
                return this;
            }

            public override UploadVoiceRequest.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override UploadVoiceRequest.Builder MergeFrom(IMessageLite other)
            {
                if (other is UploadVoiceRequest)
                {
                    return this.MergeFrom((UploadVoiceRequest)other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override UploadVoiceRequest.Builder MergeFrom(UploadVoiceRequest other)
            {
                return this;
            }

            public override UploadVoiceRequest.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(UploadVoiceRequest._uploadVoiceRequestFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = UploadVoiceRequest._uploadVoiceRequestFieldTags[index];
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
                                this.result.hasToUserName = input.ReadString(ref this.result.toUserName_);
                                continue;
                            }
                        case 0x18:
                            {
                                this.result.hasOffset = input.ReadUInt32(ref this.result.offset_);
                                continue;
                            }
                        case 0:
                            throw InvalidProtocolBufferException.InvalidTag();

                        case 10:
                            {
                                this.result.hasFromUserName = input.ReadString(ref this.result.fromUserName_);
                                continue;
                            }
                        case 0x20:
                            {
                                this.result.hasLength = input.ReadUInt32(ref this.result.length_);
                                continue;
                            }
                        case 0x2a:
                            {
                                this.result.hasClientMsgId = input.ReadString(ref this.result.clientMsgId_);
                                continue;
                            }
                        case 0x30:
                            {
                                this.result.hasMsgId = input.ReadUInt32(ref this.result.msgId_);
                                continue;
                            }
                        case 0x38:
                            {
                                this.result.hasVoiceLength = input.ReadUInt32(ref this.result.voiceLength_);
                                continue;
                            }
                        case 0x42:
                            {
                                SKBuiltinBuffer_t.Builder builder = SKBuiltinBuffer_t.CreateBuilder();
                                if (this.result.hasData)
                                {
                                    builder.MergeFrom(this.Data);
                                }
                                input.ReadMessage(builder, extensionRegistry);
                                this.Data = builder.BuildPartial();
                                continue;
                            }
                        case 0x58:
                            {
                                this.result.hasCancelFlag = input.ReadUInt32(ref this.result.cancelFlag_);
                                continue;
                            }
                        case 0x62:
                            {
                                this.result.hasMsgSource = input.ReadString(ref this.result.msgSource_);
                                continue;
                            }
                        case 0x68:
                            {
                                this.result.hasVoiceFormat = input.ReadUInt32(ref this.result.voiceFormat_);
                                continue;
                            }
                        case 0x48:
                            {
                                this.result.hasEndFlag = input.ReadUInt32(ref this.result.endFlag_);
                                continue;
                            }
                        case 0x52:
                            {
                                BaseRequest.Builder builder2 = BaseRequest.CreateBuilder();
                                if (this.result.hasBaseRequest)
                                {
                                    builder2.MergeFrom(this.BaseRequest);
                                }
                                input.ReadMessage(builder2, extensionRegistry);
                                this.BaseRequest = builder2.BuildPartial();
                                continue;
                            }
                        case 0x70:
                            {
                                this.result.hasUICreateTime = input.ReadUInt32(ref this.result.uICreateTime_);
                                continue;
                            }
                        case 120:
                            {
                                this.result.hasForwardFlag = input.ReadUInt32(ref this.result.forwardFlag_);
                                continue;
                            }
                        case 0x80:
                            {
                                this.result.hasNewMsgId = input.ReadUInt64(ref this.result.newMsgId_);
                                continue;
                            }
                        case 0x88:
                            {
                                this.result.hasReqTime = input.ReadUInt32(ref this.result.reqTime_);
                                continue;
                            }
                        case 0x92:
                            {
                                SKBuiltinBuffer_t.Builder builder3 = SKBuiltinBuffer_t.CreateBuilder();
                                if (this.result.hasVoiceId)
                                {
                                    builder3.MergeFrom(this.VoiceId);
                                }
                                input.ReadMessage(builder3, extensionRegistry);
                                this.VoiceId = builder3.BuildPartial();
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

            public UploadVoiceRequest.Builder MergeVoiceId(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasVoiceId && (this.result.voiceId_ != SKBuiltinBuffer_t.DefaultInstance))
                {
                    this.result.voiceId_ = SKBuiltinBuffer_t.CreateBuilder(this.result.voiceId_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.voiceId_ = value;
                }
                this.result.hasVoiceId = true;
                return this;
            }

            private UploadVoiceRequest PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    UploadVoiceRequest result = this.result;
                    this.result = new UploadVoiceRequest();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public UploadVoiceRequest.Builder SetBaseRequest(BaseRequest value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = value;
                return this;
            }

            public UploadVoiceRequest.Builder SetBaseRequest(BaseRequest.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = builderForValue.Build();
                return this;
            }

            public UploadVoiceRequest.Builder SetCancelFlag(uint value)
            {
                this.PrepareBuilder();
                this.result.hasCancelFlag = true;
                this.result.cancelFlag_ = value;
                return this;
            }

            public UploadVoiceRequest.Builder SetClientMsgId(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasClientMsgId = true;
                this.result.clientMsgId_ = value;
                return this;
            }

            public UploadVoiceRequest.Builder SetData(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasData = true;
                this.result.data_ = value;
                return this;
            }

            public UploadVoiceRequest.Builder SetData(SKBuiltinBuffer_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasData = true;
                this.result.data_ = builderForValue.Build();
                return this;
            }

            public UploadVoiceRequest.Builder SetEndFlag(uint value)
            {
                this.PrepareBuilder();
                this.result.hasEndFlag = true;
                this.result.endFlag_ = value;
                return this;
            }

            public UploadVoiceRequest.Builder SetForwardFlag(uint value)
            {
                this.PrepareBuilder();
                this.result.hasForwardFlag = true;
                this.result.forwardFlag_ = value;
                return this;
            }

            public UploadVoiceRequest.Builder SetFromUserName(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasFromUserName = true;
                this.result.fromUserName_ = value;
                return this;
            }

            public UploadVoiceRequest.Builder SetLength(uint value)
            {
                this.PrepareBuilder();
                this.result.hasLength = true;
                this.result.length_ = value;
                return this;
            }

            public UploadVoiceRequest.Builder SetMsgId(uint value)
            {
                this.PrepareBuilder();
                this.result.hasMsgId = true;
                this.result.msgId_ = value;
                return this;
            }

            public UploadVoiceRequest.Builder SetMsgSource(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasMsgSource = true;
                this.result.msgSource_ = value;
                return this;
            }

            public UploadVoiceRequest.Builder SetNewMsgId(ulong value)
            {
                this.PrepareBuilder();
                this.result.hasNewMsgId = true;
                this.result.newMsgId_ = value;
                return this;
            }

            public UploadVoiceRequest.Builder SetOffset(uint value)
            {
                this.PrepareBuilder();
                this.result.hasOffset = true;
                this.result.offset_ = value;
                return this;
            }

            public UploadVoiceRequest.Builder SetReqTime(uint value)
            {
                this.PrepareBuilder();
                this.result.hasReqTime = true;
                this.result.reqTime_ = value;
                return this;
            }

            public UploadVoiceRequest.Builder SetToUserName(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasToUserName = true;
                this.result.toUserName_ = value;
                return this;
            }

            public UploadVoiceRequest.Builder SetUICreateTime(uint value)
            {
                this.PrepareBuilder();
                this.result.hasUICreateTime = true;
                this.result.uICreateTime_ = value;
                return this;
            }

            public UploadVoiceRequest.Builder SetVoiceFormat(uint value)
            {
                this.PrepareBuilder();
                this.result.hasVoiceFormat = true;
                this.result.voiceFormat_ = value;
                return this;
            }

            public UploadVoiceRequest.Builder SetVoiceId(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasVoiceId = true;
                this.result.voiceId_ = value;
                return this;
            }

            public UploadVoiceRequest.Builder SetVoiceId(SKBuiltinBuffer_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasVoiceId = true;
                this.result.voiceId_ = builderForValue.Build();
                return this;
            }

            public UploadVoiceRequest.Builder SetVoiceLength(uint value)
            {
                this.PrepareBuilder();
                this.result.hasVoiceLength = true;
                this.result.voiceLength_ = value;
                return this;
            }

            public BaseRequest BaseRequest
            {
                get
                {
                    return this.result.BaseRequest;
                }
                set
                {
                    this.SetBaseRequest(value);
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

            public SKBuiltinBuffer_t Data
            {
                get
                {
                    return this.result.Data;
                }
                set
                {
                    this.SetData(value);
                }
            }

            public override UploadVoiceRequest DefaultInstanceForType
            {
                get
                {
                    return UploadVoiceRequest.DefaultInstance;
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

            public uint ForwardFlag
            {
                get
                {
                    return this.result.ForwardFlag;
                }
                set
                {
                    this.SetForwardFlag(value);
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

            protected override UploadVoiceRequest MessageBeingBuilt
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

            public string MsgSource
            {
                get
                {
                    return this.result.MsgSource;
                }
                set
                {
                    this.SetMsgSource(value);
                }
            }

            public ulong NewMsgId
            {
                get
                {
                    return this.result.NewMsgId;
                }
                set
                {
                    this.SetNewMsgId(value);
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

            public uint ReqTime
            {
                get
                {
                    return this.result.ReqTime;
                }
                set
                {
                    this.SetReqTime(value);
                }
            }

            protected override UploadVoiceRequest.Builder ThisBuilder
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

            public uint UICreateTime
            {
                get
                {
                    return this.result.UICreateTime;
                }
                set
                {
                    this.SetUICreateTime(value);
                }
            }

            public uint VoiceFormat
            {
                get
                {
                    return this.result.VoiceFormat;
                }
                set
                {
                    this.SetVoiceFormat(value);
                }
            }

            public SKBuiltinBuffer_t VoiceId
            {
                get
                {
                    return this.result.VoiceId;
                }
                set
                {
                    this.SetVoiceId(value);
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

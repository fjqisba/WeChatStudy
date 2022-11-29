namespace micromsg
{
    using Google.ProtocolBuffers;

    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    using System.Runtime.CompilerServices;

    public sealed class UploadMsgImgResponse : GeneratedMessageLite<UploadMsgImgResponse, UploadMsgImgResponse.Builder>
    {
        private static readonly string[] _uploadMsgImgResponseFieldNames = new string[] { "BaseResponse", "ClientImgId", "CreateTime", "DataLen", "FromUserName", "MsgId", "StartPos", "ToUserName", "TotalLen" };
        private static readonly uint[] _uploadMsgImgResponseFieldTags = new uint[] { 10, 0x1a, 0x48, 0x40, 0x22, 0x10, 0x38, 0x2a, 0x30 };
        private BaseResponse baseResponse_;
        public const int BaseResponseFieldNumber = 1;
        private SKBuiltinString_t clientImgId_;
        public const int ClientImgIdFieldNumber = 3;
        private uint createTime_;
        public const int CreateTimeFieldNumber = 9;
        private uint dataLen_;
        public const int DataLenFieldNumber = 8;
        private static readonly UploadMsgImgResponse defaultInstance = new UploadMsgImgResponse().MakeReadOnly();
        private SKBuiltinString_t fromUserName_;
        public const int FromUserNameFieldNumber = 4;
        private bool hasBaseResponse;
        private bool hasClientImgId;
        private bool hasCreateTime;
        private bool hasDataLen;
        private bool hasFromUserName;
        private bool hasMsgId;
        private bool hasStartPos;
        private bool hasTotalLen;
        private bool hasToUserName;
        private int memoizedSerializedSize = -1;
        private uint msgId_;
        public const int MsgIdFieldNumber = 2;
        private uint startPos_;
        public const int StartPosFieldNumber = 7;
        private uint totalLen_;
        public const int TotalLenFieldNumber = 6;
        private SKBuiltinString_t toUserName_;
        public const int ToUserNameFieldNumber = 5;


        private UploadMsgImgResponse()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(UploadMsgImgResponse prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            UploadMsgImgResponse response = obj as UploadMsgImgResponse;
            if (response == null)
            {
                return false;
            }
            if ((this.hasBaseResponse != response.hasBaseResponse) || (this.hasBaseResponse && !this.baseResponse_.Equals(response.baseResponse_)))
            {
                return false;
            }
            if ((this.hasMsgId != response.hasMsgId) || (this.hasMsgId && !this.msgId_.Equals(response.msgId_)))
            {
                return false;
            }
            if ((this.hasClientImgId != response.hasClientImgId) || (this.hasClientImgId && !this.clientImgId_.Equals(response.clientImgId_)))
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
            if ((this.hasTotalLen != response.hasTotalLen) || (this.hasTotalLen && !this.totalLen_.Equals(response.totalLen_)))
            {
                return false;
            }
            if ((this.hasStartPos != response.hasStartPos) || (this.hasStartPos && !this.startPos_.Equals(response.startPos_)))
            {
                return false;
            }
            if ((this.hasDataLen != response.hasDataLen) || (this.hasDataLen && !this.dataLen_.Equals(response.dataLen_)))
            {
                return false;
            }
            return ((this.hasCreateTime == response.hasCreateTime) && (!this.hasCreateTime || this.createTime_.Equals(response.createTime_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasBaseResponse)
            {
                hashCode ^= this.baseResponse_.GetHashCode();
            }
            if (this.hasMsgId)
            {
                hashCode ^= this.msgId_.GetHashCode();
            }
            if (this.hasClientImgId)
            {
                hashCode ^= this.clientImgId_.GetHashCode();
            }
            if (this.hasFromUserName)
            {
                hashCode ^= this.fromUserName_.GetHashCode();
            }
            if (this.hasToUserName)
            {
                hashCode ^= this.toUserName_.GetHashCode();
            }
            if (this.hasTotalLen)
            {
                hashCode ^= this.totalLen_.GetHashCode();
            }
            if (this.hasStartPos)
            {
                hashCode ^= this.startPos_.GetHashCode();
            }
            if (this.hasDataLen)
            {
                hashCode ^= this.dataLen_.GetHashCode();
            }
            if (this.hasCreateTime)
            {
                hashCode ^= this.createTime_.GetHashCode();
            }
            return hashCode;
        }

        private UploadMsgImgResponse MakeReadOnly()
        {
            return this;
        }

        public static UploadMsgImgResponse ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<UploadMsgImgResponse, Builder>.PrintField("BaseResponse", this.hasBaseResponse, this.baseResponse_, writer);
            GeneratedMessageLite<UploadMsgImgResponse, Builder>.PrintField("MsgId", this.hasMsgId, this.msgId_, writer);
            GeneratedMessageLite<UploadMsgImgResponse, Builder>.PrintField("ClientImgId", this.hasClientImgId, this.clientImgId_, writer);
            GeneratedMessageLite<UploadMsgImgResponse, Builder>.PrintField("FromUserName", this.hasFromUserName, this.fromUserName_, writer);
            GeneratedMessageLite<UploadMsgImgResponse, Builder>.PrintField("ToUserName", this.hasToUserName, this.toUserName_, writer);
            GeneratedMessageLite<UploadMsgImgResponse, Builder>.PrintField("TotalLen", this.hasTotalLen, this.totalLen_, writer);
            GeneratedMessageLite<UploadMsgImgResponse, Builder>.PrintField("StartPos", this.hasStartPos, this.startPos_, writer);
            GeneratedMessageLite<UploadMsgImgResponse, Builder>.PrintField("DataLen", this.hasDataLen, this.dataLen_, writer);
            GeneratedMessageLite<UploadMsgImgResponse, Builder>.PrintField("CreateTime", this.hasCreateTime, this.createTime_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _uploadMsgImgResponseFieldNames;
            if (this.hasBaseResponse)
            {
                output.WriteMessage(1, strArray[0], this.BaseResponse);
            }
            if (this.hasMsgId)
            {
                output.WriteUInt32(2, strArray[5], this.MsgId);
            }
            if (this.hasClientImgId)
            {
                output.WriteMessage(3, strArray[1], this.ClientImgId);
            }
            if (this.hasFromUserName)
            {
                output.WriteMessage(4, strArray[4], this.FromUserName);
            }
            if (this.hasToUserName)
            {
                output.WriteMessage(5, strArray[7], this.ToUserName);
            }
            if (this.hasTotalLen)
            {
                output.WriteUInt32(6, strArray[8], this.TotalLen);
            }
            if (this.hasStartPos)
            {
                output.WriteUInt32(7, strArray[6], this.StartPos);
            }
            if (this.hasDataLen)
            {
                output.WriteUInt32(8, strArray[3], this.DataLen);
            }
            if (this.hasCreateTime)
            {
                output.WriteUInt32(9, strArray[2], this.CreateTime);
            }
        }

        public BaseResponse BaseResponse
        {
            get
            {
                return (this.baseResponse_ ?? BaseResponse.DefaultInstance);
            }
        }

        public SKBuiltinString_t ClientImgId
        {
            get
            {
                return (this.clientImgId_ ?? SKBuiltinString_t.DefaultInstance);
            }
        }

        public uint CreateTime
        {
            get
            {
                return this.createTime_;
            }
        }

        public uint DataLen
        {
            get
            {
                return this.dataLen_;
            }
        }

        public static UploadMsgImgResponse DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override UploadMsgImgResponse DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public SKBuiltinString_t FromUserName
        {
            get
            {
                return (this.fromUserName_ ?? SKBuiltinString_t.DefaultInstance);
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
                if (!this.hasClientImgId)
                {
                    return false;
                }
                if (!this.hasFromUserName)
                {
                    return false;
                }
                if (!this.hasToUserName)
                {
                    return false;
                }
                if (!this.hasTotalLen)
                {
                    return false;
                }
                if (!this.hasStartPos)
                {
                    return false;
                }
                if (!this.hasDataLen)
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
                    if (this.hasMsgId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(2, this.MsgId);
                    }
                    if (this.hasClientImgId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(3, this.ClientImgId);
                    }
                    if (this.hasFromUserName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(4, this.FromUserName);
                    }
                    if (this.hasToUserName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(5, this.ToUserName);
                    }
                    if (this.hasTotalLen)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(6, this.TotalLen);
                    }
                    if (this.hasStartPos)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(7, this.StartPos);
                    }
                    if (this.hasDataLen)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(8, this.DataLen);
                    }
                    if (this.hasCreateTime)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(9, this.CreateTime);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        public uint StartPos
        {
            get
            {
                return this.startPos_;
            }
        }

        protected override UploadMsgImgResponse ThisMessage
        {
            get
            {
                return this;
            }
        }

        public uint TotalLen
        {
            get
            {
                return this.totalLen_;
            }
        }

        public SKBuiltinString_t ToUserName
        {
            get
            {
                return (this.toUserName_ ?? SKBuiltinString_t.DefaultInstance);
            }
        }

        [DebuggerNonUserCode, GeneratedCode("ProtoGen", "2.3.0.277"), CompilerGenerated]
        public sealed class Builder : GeneratedBuilderLite<UploadMsgImgResponse, UploadMsgImgResponse.Builder>
        {
            private UploadMsgImgResponse result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = UploadMsgImgResponse.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(UploadMsgImgResponse cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override UploadMsgImgResponse BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override UploadMsgImgResponse.Builder Clear()
            {
                this.result = UploadMsgImgResponse.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public UploadMsgImgResponse.Builder ClearBaseResponse()
            {
                this.PrepareBuilder();
                this.result.hasBaseResponse = false;
                this.result.baseResponse_ = null;
                return this;
            }

            public UploadMsgImgResponse.Builder ClearClientImgId()
            {
                this.PrepareBuilder();
                this.result.hasClientImgId = false;
                this.result.clientImgId_ = null;
                return this;
            }

            public UploadMsgImgResponse.Builder ClearCreateTime()
            {
                this.PrepareBuilder();
                this.result.hasCreateTime = false;
                this.result.createTime_ = 0;
                return this;
            }

            public UploadMsgImgResponse.Builder ClearDataLen()
            {
                this.PrepareBuilder();
                this.result.hasDataLen = false;
                this.result.dataLen_ = 0;
                return this;
            }

            public UploadMsgImgResponse.Builder ClearFromUserName()
            {
                this.PrepareBuilder();
                this.result.hasFromUserName = false;
                this.result.fromUserName_ = null;
                return this;
            }

            public UploadMsgImgResponse.Builder ClearMsgId()
            {
                this.PrepareBuilder();
                this.result.hasMsgId = false;
                this.result.msgId_ = 0;
                return this;
            }

            public UploadMsgImgResponse.Builder ClearStartPos()
            {
                this.PrepareBuilder();
                this.result.hasStartPos = false;
                this.result.startPos_ = 0;
                return this;
            }

            public UploadMsgImgResponse.Builder ClearTotalLen()
            {
                this.PrepareBuilder();
                this.result.hasTotalLen = false;
                this.result.totalLen_ = 0;
                return this;
            }

            public UploadMsgImgResponse.Builder ClearToUserName()
            {
                this.PrepareBuilder();
                this.result.hasToUserName = false;
                this.result.toUserName_ = null;
                return this;
            }

            public override UploadMsgImgResponse.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new UploadMsgImgResponse.Builder(this.result);
                }
                return new UploadMsgImgResponse.Builder().MergeFrom(this.result);
            }

            public UploadMsgImgResponse.Builder MergeBaseResponse(BaseResponse value)
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

            public UploadMsgImgResponse.Builder MergeClientImgId(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasClientImgId && (this.result.clientImgId_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.clientImgId_ = SKBuiltinString_t.CreateBuilder(this.result.clientImgId_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.clientImgId_ = value;
                }
                this.result.hasClientImgId = true;
                return this;
            }

            public override UploadMsgImgResponse.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override UploadMsgImgResponse.Builder MergeFrom(IMessageLite other)
            {
                if (other is UploadMsgImgResponse)
                {
                    return this.MergeFrom((UploadMsgImgResponse)other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override UploadMsgImgResponse.Builder MergeFrom(UploadMsgImgResponse other)
            {
                return this;
            }

            public override UploadMsgImgResponse.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(UploadMsgImgResponse._uploadMsgImgResponseFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = UploadMsgImgResponse._uploadMsgImgResponseFieldTags[index];
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
                                this.result.hasMsgId = input.ReadUInt32(ref this.result.msgId_);
                                continue;
                            }
                        case 0x1a:
                            {
                                SKBuiltinString_t.Builder builder2 = SKBuiltinString_t.CreateBuilder();
                                if (this.result.hasClientImgId)
                                {
                                    builder2.MergeFrom(this.ClientImgId);
                                }
                                input.ReadMessage(builder2, extensionRegistry);
                                this.ClientImgId = builder2.BuildPartial();
                                continue;
                            }
                        case 0x22:
                            {
                                SKBuiltinString_t.Builder builder3 = SKBuiltinString_t.CreateBuilder();
                                if (this.result.hasFromUserName)
                                {
                                    builder3.MergeFrom(this.FromUserName);
                                }
                                input.ReadMessage(builder3, extensionRegistry);
                                this.FromUserName = builder3.BuildPartial();
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
                        case 0x2a:
                            {
                                SKBuiltinString_t.Builder builder4 = SKBuiltinString_t.CreateBuilder();
                                if (this.result.hasToUserName)
                                {
                                    builder4.MergeFrom(this.ToUserName);
                                }
                                input.ReadMessage(builder4, extensionRegistry);
                                this.ToUserName = builder4.BuildPartial();
                                continue;
                            }
                        case 0x30:
                            {
                                this.result.hasTotalLen = input.ReadUInt32(ref this.result.totalLen_);
                                continue;
                            }
                        case 0x38:
                            {
                                this.result.hasStartPos = input.ReadUInt32(ref this.result.startPos_);
                                continue;
                            }
                        case 0x40:
                            {
                                this.result.hasDataLen = input.ReadUInt32(ref this.result.dataLen_);
                                continue;
                            }
                        case 0x48:
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
                    this.result.hasCreateTime = input.ReadUInt32(ref this.result.createTime_);
                }
                return this;
            }

            public UploadMsgImgResponse.Builder MergeFromUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasFromUserName && (this.result.fromUserName_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.fromUserName_ = SKBuiltinString_t.CreateBuilder(this.result.fromUserName_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.fromUserName_ = value;
                }
                this.result.hasFromUserName = true;
                return this;
            }

            public UploadMsgImgResponse.Builder MergeToUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasToUserName && (this.result.toUserName_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.toUserName_ = SKBuiltinString_t.CreateBuilder(this.result.toUserName_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.toUserName_ = value;
                }
                this.result.hasToUserName = true;
                return this;
            }

            private UploadMsgImgResponse PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    UploadMsgImgResponse result = this.result;
                    this.result = new UploadMsgImgResponse();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public UploadMsgImgResponse.Builder SetBaseResponse(BaseResponse value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = value;
                return this;
            }

            public UploadMsgImgResponse.Builder SetBaseResponse(BaseResponse.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = builderForValue.Build();
                return this;
            }

            public UploadMsgImgResponse.Builder SetClientImgId(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasClientImgId = true;
                this.result.clientImgId_ = value;
                return this;
            }

            public UploadMsgImgResponse.Builder SetClientImgId(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasClientImgId = true;
                this.result.clientImgId_ = builderForValue.Build();
                return this;
            }

            public UploadMsgImgResponse.Builder SetCreateTime(uint value)
            {
                this.PrepareBuilder();
                this.result.hasCreateTime = true;
                this.result.createTime_ = value;
                return this;
            }

            public UploadMsgImgResponse.Builder SetDataLen(uint value)
            {
                this.PrepareBuilder();
                this.result.hasDataLen = true;
                this.result.dataLen_ = value;
                return this;
            }

            public UploadMsgImgResponse.Builder SetFromUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasFromUserName = true;
                this.result.fromUserName_ = value;
                return this;
            }

            public UploadMsgImgResponse.Builder SetFromUserName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasFromUserName = true;
                this.result.fromUserName_ = builderForValue.Build();
                return this;
            }

            public UploadMsgImgResponse.Builder SetMsgId(uint value)
            {
                this.PrepareBuilder();
                this.result.hasMsgId = true;
                this.result.msgId_ = value;
                return this;
            }

            public UploadMsgImgResponse.Builder SetStartPos(uint value)
            {
                this.PrepareBuilder();
                this.result.hasStartPos = true;
                this.result.startPos_ = value;
                return this;
            }

            public UploadMsgImgResponse.Builder SetTotalLen(uint value)
            {
                this.PrepareBuilder();
                this.result.hasTotalLen = true;
                this.result.totalLen_ = value;
                return this;
            }

            public UploadMsgImgResponse.Builder SetToUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasToUserName = true;
                this.result.toUserName_ = value;
                return this;
            }

            public UploadMsgImgResponse.Builder SetToUserName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasToUserName = true;
                this.result.toUserName_ = builderForValue.Build();
                return this;
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

            public SKBuiltinString_t ClientImgId
            {
                get
                {
                    return this.result.ClientImgId;
                }
                set
                {
                    this.SetClientImgId(value);
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

            public uint DataLen
            {
                get
                {
                    return this.result.DataLen;
                }
                set
                {
                    this.SetDataLen(value);
                }
            }

            public override UploadMsgImgResponse DefaultInstanceForType
            {
                get
                {
                    return UploadMsgImgResponse.DefaultInstance;
                }
            }

            public SKBuiltinString_t FromUserName
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

            protected override UploadMsgImgResponse MessageBeingBuilt
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

            public uint StartPos
            {
                get
                {
                    return this.result.StartPos;
                }
                set
                {
                    this.SetStartPos(value);
                }
            }

            protected override UploadMsgImgResponse.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }

            public uint TotalLen
            {
                get
                {
                    return this.result.TotalLen;
                }
                set
                {
                    this.SetTotalLen(value);
                }
            }

            public SKBuiltinString_t ToUserName
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
        }
    }
}

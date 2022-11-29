namespace micromsg
{
    using Google.ProtocolBuffers;

    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;


    public sealed class DownloadVideoRequest : GeneratedMessageLite<DownloadVideoRequest, DownloadVideoRequest.Builder>
    {
        private static readonly string[] _downloadVideoRequestFieldNames = new string[] { "BaseRequest", "MsgId", "NetworkEnv", "StartPos", "TotalLen" };
        private static readonly uint[] _downloadVideoRequestFieldTags = new uint[] { 10, 0x10, 40, 0x20, 0x18 };
        private BaseRequest baseRequest_;
        public const int BaseRequestFieldNumber = 1;
        private static readonly DownloadVideoRequest defaultInstance = new DownloadVideoRequest().MakeReadOnly();
        private bool hasBaseRequest;
        private bool hasMsgId;
        private bool hasNetworkEnv;
        private bool hasStartPos;
        private bool hasTotalLen;
        private int memoizedSerializedSize = -1;
        private uint msgId_;
        public const int MsgIdFieldNumber = 2;
        private uint networkEnv_;
        public const int NetworkEnvFieldNumber = 5;
        private uint startPos_;
        public const int StartPosFieldNumber = 4;
        private uint totalLen_;
        public const int TotalLenFieldNumber = 3;

        static DownloadVideoRequest()
        {

        }

        private DownloadVideoRequest()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(DownloadVideoRequest prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            DownloadVideoRequest request = obj as DownloadVideoRequest;
            if (request == null)
            {
                return false;
            }
            if ((this.hasBaseRequest != request.hasBaseRequest) || (this.hasBaseRequest && !this.baseRequest_.Equals(request.baseRequest_)))
            {
                return false;
            }
            if ((this.hasMsgId != request.hasMsgId) || (this.hasMsgId && !this.msgId_.Equals(request.msgId_)))
            {
                return false;
            }
            if ((this.hasTotalLen != request.hasTotalLen) || (this.hasTotalLen && !this.totalLen_.Equals(request.totalLen_)))
            {
                return false;
            }
            if ((this.hasStartPos != request.hasStartPos) || (this.hasStartPos && !this.startPos_.Equals(request.startPos_)))
            {
                return false;
            }
            return ((this.hasNetworkEnv == request.hasNetworkEnv) && (!this.hasNetworkEnv || this.networkEnv_.Equals(request.networkEnv_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasBaseRequest)
            {
                hashCode ^= this.baseRequest_.GetHashCode();
            }
            if (this.hasMsgId)
            {
                hashCode ^= this.msgId_.GetHashCode();
            }
            if (this.hasTotalLen)
            {
                hashCode ^= this.totalLen_.GetHashCode();
            }
            if (this.hasStartPos)
            {
                hashCode ^= this.startPos_.GetHashCode();
            }
            if (this.hasNetworkEnv)
            {
                hashCode ^= this.networkEnv_.GetHashCode();
            }
            return hashCode;
        }

        private DownloadVideoRequest MakeReadOnly()
        {
            return this;
        }

        public static DownloadVideoRequest ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<DownloadVideoRequest, Builder>.PrintField("BaseRequest", this.hasBaseRequest, this.baseRequest_, writer);
            GeneratedMessageLite<DownloadVideoRequest, Builder>.PrintField("MsgId", this.hasMsgId, this.msgId_, writer);
            GeneratedMessageLite<DownloadVideoRequest, Builder>.PrintField("TotalLen", this.hasTotalLen, this.totalLen_, writer);
            GeneratedMessageLite<DownloadVideoRequest, Builder>.PrintField("StartPos", this.hasStartPos, this.startPos_, writer);
            GeneratedMessageLite<DownloadVideoRequest, Builder>.PrintField("NetworkEnv", this.hasNetworkEnv, this.networkEnv_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _downloadVideoRequestFieldNames;
            if (this.hasBaseRequest)
            {
                output.WriteMessage(1, strArray[0], this.BaseRequest);
            }
            if (this.hasMsgId)
            {
                output.WriteUInt32(2, strArray[1], this.MsgId);
            }
            if (this.hasTotalLen)
            {
                output.WriteUInt32(3, strArray[4], this.TotalLen);
            }
            if (this.hasStartPos)
            {
                output.WriteUInt32(4, strArray[3], this.StartPos);
            }
            if (this.hasNetworkEnv)
            {
                output.WriteUInt32(5, strArray[2], this.NetworkEnv);
            }
        }

        public BaseRequest BaseRequest
        {
            get
            {
                return (this.baseRequest_ ?? BaseRequest.DefaultInstance);
            }
        }

        public static DownloadVideoRequest DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override DownloadVideoRequest DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public override bool IsInitialized
        {
            get
            {
                if (!this.hasBaseRequest)
                {
                    return false;
                }
                if (!this.hasMsgId)
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
                if (!this.BaseRequest.IsInitialized)
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

        public uint NetworkEnv
        {
            get
            {
                return this.networkEnv_;
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
                    if (this.hasBaseRequest)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(1, this.BaseRequest);
                    }
                    if (this.hasMsgId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(2, this.MsgId);
                    }
                    if (this.hasTotalLen)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(3, this.TotalLen);
                    }
                    if (this.hasStartPos)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(4, this.StartPos);
                    }
                    if (this.hasNetworkEnv)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(5, this.NetworkEnv);
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

        protected override DownloadVideoRequest ThisMessage
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


        public sealed class Builder : GeneratedBuilderLite<DownloadVideoRequest, DownloadVideoRequest.Builder>
        {
            private DownloadVideoRequest result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = DownloadVideoRequest.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(DownloadVideoRequest cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override DownloadVideoRequest BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override DownloadVideoRequest.Builder Clear()
            {
                this.result = DownloadVideoRequest.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public DownloadVideoRequest.Builder ClearBaseRequest()
            {
                this.PrepareBuilder();
                this.result.hasBaseRequest = false;
                this.result.baseRequest_ = null;
                return this;
            }

            public DownloadVideoRequest.Builder ClearMsgId()
            {
                this.PrepareBuilder();
                this.result.hasMsgId = false;
                this.result.msgId_ = 0;
                return this;
            }

            public DownloadVideoRequest.Builder ClearNetworkEnv()
            {
                this.PrepareBuilder();
                this.result.hasNetworkEnv = false;
                this.result.networkEnv_ = 0;
                return this;
            }

            public DownloadVideoRequest.Builder ClearStartPos()
            {
                this.PrepareBuilder();
                this.result.hasStartPos = false;
                this.result.startPos_ = 0;
                return this;
            }

            public DownloadVideoRequest.Builder ClearTotalLen()
            {
                this.PrepareBuilder();
                this.result.hasTotalLen = false;
                this.result.totalLen_ = 0;
                return this;
            }

            public override DownloadVideoRequest.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new DownloadVideoRequest.Builder(this.result);
                }
                return new DownloadVideoRequest.Builder().MergeFrom(this.result);
            }

            public DownloadVideoRequest.Builder MergeBaseRequest(BaseRequest value)
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

            public override DownloadVideoRequest.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override DownloadVideoRequest.Builder MergeFrom(IMessageLite other)
            {
                if (other is DownloadVideoRequest)
                {
                    return this.MergeFrom((DownloadVideoRequest) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override DownloadVideoRequest.Builder MergeFrom(DownloadVideoRequest other)
            {
                return this;
            }

            public override DownloadVideoRequest.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(DownloadVideoRequest._downloadVideoRequestFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = DownloadVideoRequest._downloadVideoRequestFieldTags[index];
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
                            BaseRequest.Builder builder = BaseRequest.CreateBuilder();
                            if (this.result.hasBaseRequest)
                            {
                                builder.MergeFrom(this.BaseRequest);
                            }
                            input.ReadMessage(builder, extensionRegistry);
                            this.BaseRequest = builder.BuildPartial();
                            continue;
                        }
                        case 0x10:
                        {
                            this.result.hasMsgId = input.ReadUInt32(ref this.result.msgId_);
                            continue;
                        }
                        case 0x18:
                        {
                            this.result.hasTotalLen = input.ReadUInt32(ref this.result.totalLen_);
                            continue;
                        }
                        case 0x20:
                        {
                            this.result.hasStartPos = input.ReadUInt32(ref this.result.startPos_);
                            continue;
                        }
                        case 40:
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
                    this.result.hasNetworkEnv = input.ReadUInt32(ref this.result.networkEnv_);
                }
                return this;
            }

            private DownloadVideoRequest PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    DownloadVideoRequest result = this.result;
                    this.result = new DownloadVideoRequest();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public DownloadVideoRequest.Builder SetBaseRequest(BaseRequest value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = value;
                return this;
            }

            public DownloadVideoRequest.Builder SetBaseRequest(BaseRequest.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = builderForValue.Build();
                return this;
            }

            public DownloadVideoRequest.Builder SetMsgId(uint value)
            {
                this.PrepareBuilder();
                this.result.hasMsgId = true;
                this.result.msgId_ = value;
                return this;
            }

            public DownloadVideoRequest.Builder SetNetworkEnv(uint value)
            {
                this.PrepareBuilder();
                this.result.hasNetworkEnv = true;
                this.result.networkEnv_ = value;
                return this;
            }

            public DownloadVideoRequest.Builder SetStartPos(uint value)
            {
                this.PrepareBuilder();
                this.result.hasStartPos = true;
                this.result.startPos_ = value;
                return this;
            }

            public DownloadVideoRequest.Builder SetTotalLen(uint value)
            {
                this.PrepareBuilder();
                this.result.hasTotalLen = true;
                this.result.totalLen_ = value;
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

            public override DownloadVideoRequest DefaultInstanceForType
            {
                get
                {
                    return DownloadVideoRequest.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override DownloadVideoRequest MessageBeingBuilt
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

            public uint NetworkEnv
            {
                get
                {
                    return this.result.NetworkEnv;
                }
                set
                {
                    this.SetNetworkEnv(value);
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

            protected override DownloadVideoRequest.Builder ThisBuilder
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
        }
    }
}

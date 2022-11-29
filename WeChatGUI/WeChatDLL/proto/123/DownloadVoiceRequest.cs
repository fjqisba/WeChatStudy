namespace micromsg
{
    using Google.ProtocolBuffers;
   
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

    
    public sealed class DownloadVoiceRequest : GeneratedMessageLite<DownloadVoiceRequest, DownloadVoiceRequest.Builder>
    {
        private static readonly string[] _downloadVoiceRequestFieldNames = new string[] { "BaseRequest", "ClientMsgId", "Length", "MsgId", "Offset" };
        private static readonly uint[] _downloadVoiceRequestFieldTags = new uint[] { 0x2a, 0x22, 0x18, 8, 0x10 };
        private micromsg.BaseRequest baseRequest_;
        public const int BaseRequestFieldNumber = 5;
        private string clientMsgId_ = "";
        public const int ClientMsgIdFieldNumber = 4;
        private static readonly DownloadVoiceRequest defaultInstance = new DownloadVoiceRequest().MakeReadOnly();
        private bool hasBaseRequest;
        private bool hasClientMsgId;
        private bool hasLength;
        private bool hasMsgId;
        private bool hasOffset;
        private uint length_;
        public const int LengthFieldNumber = 3;
        private int memoizedSerializedSize = -1;
        private uint msgId_;
        public const int MsgIdFieldNumber = 1;
        private uint offset_;
        public const int OffsetFieldNumber = 2;

        static DownloadVoiceRequest()
        {
           // object.ReferenceEquals(DownloadVoiceRequest.Descriptor, null);
        }

        private DownloadVoiceRequest()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(DownloadVoiceRequest prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            DownloadVoiceRequest request = obj as DownloadVoiceRequest;
            if (request == null)
            {
                return false;
            }
            if ((this.hasMsgId != request.hasMsgId) || (this.hasMsgId && !this.msgId_.Equals(request.msgId_)))
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
            return ((this.hasBaseRequest == request.hasBaseRequest) && (!this.hasBaseRequest || this.baseRequest_.Equals(request.baseRequest_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasMsgId)
            {
                hashCode ^= this.msgId_.GetHashCode();
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
            if (this.hasBaseRequest)
            {
                hashCode ^= this.baseRequest_.GetHashCode();
            }
            return hashCode;
        }

        private DownloadVoiceRequest MakeReadOnly()
        {
            return this;
        }

        public static DownloadVoiceRequest ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<DownloadVoiceRequest, Builder>.PrintField("MsgId", this.hasMsgId, this.msgId_, writer);
            GeneratedMessageLite<DownloadVoiceRequest, Builder>.PrintField("Offset", this.hasOffset, this.offset_, writer);
            GeneratedMessageLite<DownloadVoiceRequest, Builder>.PrintField("Length", this.hasLength, this.length_, writer);
            GeneratedMessageLite<DownloadVoiceRequest, Builder>.PrintField("ClientMsgId", this.hasClientMsgId, this.clientMsgId_, writer);
            GeneratedMessageLite<DownloadVoiceRequest, Builder>.PrintField("BaseRequest", this.hasBaseRequest, this.baseRequest_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _downloadVoiceRequestFieldNames;
            if (this.hasMsgId)
            {
                output.WriteUInt32(1, strArray[3], this.MsgId);
            }
            if (this.hasOffset)
            {
                output.WriteUInt32(2, strArray[4], this.Offset);
            }
            if (this.hasLength)
            {
                output.WriteUInt32(3, strArray[2], this.Length);
            }
            if (this.hasClientMsgId)
            {
                output.WriteString(4, strArray[1], this.ClientMsgId);
            }
            if (this.hasBaseRequest)
            {
                output.WriteMessage(5, strArray[0], this.BaseRequest);
            }
        }

        public micromsg.BaseRequest BaseRequest
        {
            get
            {
                return (this.baseRequest_ ?? micromsg.BaseRequest.DefaultInstance);
            }
        }

        public string ClientMsgId
        {
            get
            {
                return this.clientMsgId_;
            }
        }

        public static DownloadVoiceRequest DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override DownloadVoiceRequest DefaultInstanceForType
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
                if (!this.hasMsgId)
                {
                    return false;
                }
                if (!this.hasOffset)
                {
                    return false;
                }
                if (!this.hasLength)
                {
                    return false;
                }
                if (!this.hasBaseRequest)
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
                    if (this.hasMsgId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(1, this.MsgId);
                    }
                    if (this.hasOffset)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(2, this.Offset);
                    }
                    if (this.hasLength)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(3, this.Length);
                    }
                    if (this.hasClientMsgId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(4, this.ClientMsgId);
                    }
                    if (this.hasBaseRequest)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(5, this.BaseRequest);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override DownloadVoiceRequest ThisMessage
        {
            get
            {
                return this;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<DownloadVoiceRequest, DownloadVoiceRequest.Builder>
        {
            private DownloadVoiceRequest result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = DownloadVoiceRequest.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(DownloadVoiceRequest cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override DownloadVoiceRequest BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override DownloadVoiceRequest.Builder Clear()
            {
                this.result = DownloadVoiceRequest.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public DownloadVoiceRequest.Builder ClearBaseRequest()
            {
                this.PrepareBuilder();
                this.result.hasBaseRequest = false;
                this.result.baseRequest_ = null;
                return this;
            }

            public DownloadVoiceRequest.Builder ClearClientMsgId()
            {
                this.PrepareBuilder();
                this.result.hasClientMsgId = false;
                this.result.clientMsgId_ = "";
                return this;
            }

            public DownloadVoiceRequest.Builder ClearLength()
            {
                this.PrepareBuilder();
                this.result.hasLength = false;
                this.result.length_ = 0;
                return this;
            }

            public DownloadVoiceRequest.Builder ClearMsgId()
            {
                this.PrepareBuilder();
                this.result.hasMsgId = false;
                this.result.msgId_ = 0;
                return this;
            }

            public DownloadVoiceRequest.Builder ClearOffset()
            {
                this.PrepareBuilder();
                this.result.hasOffset = false;
                this.result.offset_ = 0;
                return this;
            }

            public override DownloadVoiceRequest.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new DownloadVoiceRequest.Builder(this.result);
                }
                return new DownloadVoiceRequest.Builder().MergeFrom(this.result);
            }

            public DownloadVoiceRequest.Builder MergeBaseRequest(micromsg.BaseRequest value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasBaseRequest && (this.result.baseRequest_ != micromsg.BaseRequest.DefaultInstance))
                {
                    this.result.baseRequest_ = micromsg.BaseRequest.CreateBuilder(this.result.baseRequest_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.baseRequest_ = value;
                }
                this.result.hasBaseRequest = true;
                return this;
            }

            public override DownloadVoiceRequest.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override DownloadVoiceRequest.Builder MergeFrom(IMessageLite other)
            {
                if (other is DownloadVoiceRequest)
                {
                    return this.MergeFrom((DownloadVoiceRequest) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override DownloadVoiceRequest.Builder MergeFrom(DownloadVoiceRequest other)
            {
                return this;
            }

            public override DownloadVoiceRequest.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(DownloadVoiceRequest._downloadVoiceRequestFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = DownloadVoiceRequest._downloadVoiceRequestFieldTags[index];
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

                        case 8:
                        {
                            this.result.hasMsgId = input.ReadUInt32(ref this.result.msgId_);
                            continue;
                        }
                        case 0x10:
                        {
                            this.result.hasOffset = input.ReadUInt32(ref this.result.offset_);
                            continue;
                        }
                        case 0x18:
                        {
                            this.result.hasLength = input.ReadUInt32(ref this.result.length_);
                            continue;
                        }
                        case 0x22:
                        {
                            this.result.hasClientMsgId = input.ReadString(ref this.result.clientMsgId_);
                            continue;
                        }
                        case 0x2a:
                        {
                            micromsg.BaseRequest.Builder builder = micromsg.BaseRequest.CreateBuilder();
                            if (this.result.hasBaseRequest)
                            {
                                builder.MergeFrom(this.BaseRequest);
                            }
                            input.ReadMessage(builder, extensionRegistry);
                            this.BaseRequest = builder.BuildPartial();
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

            private DownloadVoiceRequest PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    DownloadVoiceRequest result = this.result;
                    this.result = new DownloadVoiceRequest();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public DownloadVoiceRequest.Builder SetBaseRequest(micromsg.BaseRequest value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = value;
                return this;
            }

            public DownloadVoiceRequest.Builder SetBaseRequest(micromsg.BaseRequest.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = builderForValue.Build();
                return this;
            }

            public DownloadVoiceRequest.Builder SetClientMsgId(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasClientMsgId = true;
                this.result.clientMsgId_ = value;
                return this;
            }

            public DownloadVoiceRequest.Builder SetLength(uint value)
            {
                this.PrepareBuilder();
                this.result.hasLength = true;
                this.result.length_ = value;
                return this;
            }

            public DownloadVoiceRequest.Builder SetMsgId(uint value)
            {
                this.PrepareBuilder();
                this.result.hasMsgId = true;
                this.result.msgId_ = value;
                return this;
            }

            public DownloadVoiceRequest.Builder SetOffset(uint value)
            {
                this.PrepareBuilder();
                this.result.hasOffset = true;
                this.result.offset_ = value;
                return this;
            }

            public micromsg.BaseRequest BaseRequest
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

            public override DownloadVoiceRequest DefaultInstanceForType
            {
                get
                {
                    return DownloadVoiceRequest.DefaultInstance;
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

            protected override DownloadVoiceRequest MessageBeingBuilt
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

            protected override DownloadVoiceRequest.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


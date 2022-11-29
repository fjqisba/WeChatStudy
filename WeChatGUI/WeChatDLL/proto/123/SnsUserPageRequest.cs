namespace micromsg
{
    using Google.ProtocolBuffers;
    
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

    
    public sealed class SnsUserPageRequest : GeneratedMessageLite<SnsUserPageRequest, SnsUserPageRequest.Builder>
    {
        private static readonly string[] _snsUserPageRequestFieldNames = new string[] { "BaseRequest", "FirstPageMd5", "LastRequestTime", "MaxId", "MinFilterId", "Source", "Username" };
        private static readonly uint[] _snsUserPageRequestFieldTags = new uint[] { 10, 0x12, 0x38, 0x20, 0x30, 40, 0x1a };
        private micromsg.BaseRequest baseRequest_;
        public const int BaseRequestFieldNumber = 1;
        private static readonly SnsUserPageRequest defaultInstance = new SnsUserPageRequest().MakeReadOnly();
        private string firstPageMd5_ = "";
        public const int FirstPageMd5FieldNumber = 2;
        private bool hasBaseRequest;
        private bool hasFirstPageMd5;
        private bool hasLastRequestTime;
        private bool hasMaxId;
        private bool hasMinFilterId;
        private bool hasSource;
        private bool hasUsername;
        private uint lastRequestTime_;
        public const int LastRequestTimeFieldNumber = 7;
        private ulong maxId_;
        public const int MaxIdFieldNumber = 4;
        private int memoizedSerializedSize = -1;
        private ulong minFilterId_;
        public const int MinFilterIdFieldNumber = 6;
        private uint source_;
        public const int SourceFieldNumber = 5;
        private string username_ = "";
        public const int UsernameFieldNumber = 3;

        static SnsUserPageRequest()
        {
            //object.ReferenceEquals(SnsUserPageRequest.Descriptor, null);
        }

        private SnsUserPageRequest()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(SnsUserPageRequest prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            SnsUserPageRequest request = obj as SnsUserPageRequest;
            if (request == null)
            {
                return false;
            }
            if ((this.hasBaseRequest != request.hasBaseRequest) || (this.hasBaseRequest && !this.baseRequest_.Equals(request.baseRequest_)))
            {
                return false;
            }
            if ((this.hasFirstPageMd5 != request.hasFirstPageMd5) || (this.hasFirstPageMd5 && !this.firstPageMd5_.Equals(request.firstPageMd5_)))
            {
                return false;
            }
            if ((this.hasUsername != request.hasUsername) || (this.hasUsername && !this.username_.Equals(request.username_)))
            {
                return false;
            }
            if ((this.hasMaxId != request.hasMaxId) || (this.hasMaxId && !this.maxId_.Equals(request.maxId_)))
            {
                return false;
            }
            if ((this.hasSource != request.hasSource) || (this.hasSource && !this.source_.Equals(request.source_)))
            {
                return false;
            }
            if ((this.hasMinFilterId != request.hasMinFilterId) || (this.hasMinFilterId && !this.minFilterId_.Equals(request.minFilterId_)))
            {
                return false;
            }
            return ((this.hasLastRequestTime == request.hasLastRequestTime) && (!this.hasLastRequestTime || this.lastRequestTime_.Equals(request.lastRequestTime_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasBaseRequest)
            {
                hashCode ^= this.baseRequest_.GetHashCode();
            }
            if (this.hasFirstPageMd5)
            {
                hashCode ^= this.firstPageMd5_.GetHashCode();
            }
            if (this.hasUsername)
            {
                hashCode ^= this.username_.GetHashCode();
            }
            if (this.hasMaxId)
            {
                hashCode ^= this.maxId_.GetHashCode();
            }
            if (this.hasSource)
            {
                hashCode ^= this.source_.GetHashCode();
            }
            if (this.hasMinFilterId)
            {
                hashCode ^= this.minFilterId_.GetHashCode();
            }
            if (this.hasLastRequestTime)
            {
                hashCode ^= this.lastRequestTime_.GetHashCode();
            }
            return hashCode;
        }

        private SnsUserPageRequest MakeReadOnly()
        {
            return this;
        }

        public static SnsUserPageRequest ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<SnsUserPageRequest, Builder>.PrintField("BaseRequest", this.hasBaseRequest, this.baseRequest_, writer);
            GeneratedMessageLite<SnsUserPageRequest, Builder>.PrintField("FirstPageMd5", this.hasFirstPageMd5, this.firstPageMd5_, writer);
            GeneratedMessageLite<SnsUserPageRequest, Builder>.PrintField("Username", this.hasUsername, this.username_, writer);
            GeneratedMessageLite<SnsUserPageRequest, Builder>.PrintField("MaxId", this.hasMaxId, this.maxId_, writer);
            GeneratedMessageLite<SnsUserPageRequest, Builder>.PrintField("Source", this.hasSource, this.source_, writer);
            GeneratedMessageLite<SnsUserPageRequest, Builder>.PrintField("MinFilterId", this.hasMinFilterId, this.minFilterId_, writer);
            GeneratedMessageLite<SnsUserPageRequest, Builder>.PrintField("LastRequestTime", this.hasLastRequestTime, this.lastRequestTime_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _snsUserPageRequestFieldNames;
            if (this.hasBaseRequest)
            {
                output.WriteMessage(1, strArray[0], this.BaseRequest);
            }
            if (this.hasFirstPageMd5)
            {
                output.WriteString(2, strArray[1], this.FirstPageMd5);
            }
            if (this.hasUsername)
            {
                output.WriteString(3, strArray[6], this.Username);
            }
            if (this.hasMaxId)
            {
                output.WriteUInt64(4, strArray[3], this.MaxId);
            }
            if (this.hasSource)
            {
                output.WriteUInt32(5, strArray[5], this.Source);
            }
            if (this.hasMinFilterId)
            {
                output.WriteUInt64(6, strArray[4], this.MinFilterId);
            }
            if (this.hasLastRequestTime)
            {
                output.WriteUInt32(7, strArray[2], this.LastRequestTime);
            }
        }

        public micromsg.BaseRequest BaseRequest
        {
            get
            {
                return (this.baseRequest_ ?? micromsg.BaseRequest.DefaultInstance);
            }
        }

        public static SnsUserPageRequest DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override SnsUserPageRequest DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public string FirstPageMd5
        {
            get
            {
                return this.firstPageMd5_;
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
                if (!this.hasMaxId)
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

        public uint LastRequestTime
        {
            get
            {
                return this.lastRequestTime_;
            }
        }

        public ulong MaxId
        {
            get
            {
                return this.maxId_;
            }
        }

        public ulong MinFilterId
        {
            get
            {
                return this.minFilterId_;
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
                    if (this.hasFirstPageMd5)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(2, this.FirstPageMd5);
                    }
                    if (this.hasUsername)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(3, this.Username);
                    }
                    if (this.hasMaxId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt64Size(4, this.MaxId);
                    }
                    if (this.hasSource)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(5, this.Source);
                    }
                    if (this.hasMinFilterId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt64Size(6, this.MinFilterId);
                    }
                    if (this.hasLastRequestTime)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(7, this.LastRequestTime);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        public uint Source
        {
            get
            {
                return this.source_;
            }
        }

        protected override SnsUserPageRequest ThisMessage
        {
            get
            {
                return this;
            }
        }

        public string Username
        {
            get
            {
                return this.username_;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<SnsUserPageRequest, SnsUserPageRequest.Builder>
        {
            private SnsUserPageRequest result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = SnsUserPageRequest.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(SnsUserPageRequest cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override SnsUserPageRequest BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override SnsUserPageRequest.Builder Clear()
            {
                this.result = SnsUserPageRequest.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public SnsUserPageRequest.Builder ClearBaseRequest()
            {
                this.PrepareBuilder();
                this.result.hasBaseRequest = false;
                this.result.baseRequest_ = null;
                return this;
            }

            public SnsUserPageRequest.Builder ClearFirstPageMd5()
            {
                this.PrepareBuilder();
                this.result.hasFirstPageMd5 = false;
                this.result.firstPageMd5_ = "";
                return this;
            }

            public SnsUserPageRequest.Builder ClearLastRequestTime()
            {
                this.PrepareBuilder();
                this.result.hasLastRequestTime = false;
                this.result.lastRequestTime_ = 0;
                return this;
            }

            public SnsUserPageRequest.Builder ClearMaxId()
            {
                this.PrepareBuilder();
                this.result.hasMaxId = false;
                this.result.maxId_ = 0L;
                return this;
            }

            public SnsUserPageRequest.Builder ClearMinFilterId()
            {
                this.PrepareBuilder();
                this.result.hasMinFilterId = false;
                this.result.minFilterId_ = 0L;
                return this;
            }

            public SnsUserPageRequest.Builder ClearSource()
            {
                this.PrepareBuilder();
                this.result.hasSource = false;
                this.result.source_ = 0;
                return this;
            }

            public SnsUserPageRequest.Builder ClearUsername()
            {
                this.PrepareBuilder();
                this.result.hasUsername = false;
                this.result.username_ = "";
                return this;
            }

            public override SnsUserPageRequest.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new SnsUserPageRequest.Builder(this.result);
                }
                return new SnsUserPageRequest.Builder().MergeFrom(this.result);
            }

            public SnsUserPageRequest.Builder MergeBaseRequest(micromsg.BaseRequest value)
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

            public override SnsUserPageRequest.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override SnsUserPageRequest.Builder MergeFrom(IMessageLite other)
            {
                if (other is SnsUserPageRequest)
                {
                    return this.MergeFrom((SnsUserPageRequest) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override SnsUserPageRequest.Builder MergeFrom(SnsUserPageRequest other)
            {
                return this;
            }

            public override SnsUserPageRequest.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(SnsUserPageRequest._snsUserPageRequestFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = SnsUserPageRequest._snsUserPageRequestFieldTags[index];
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
                            this.result.hasFirstPageMd5 = input.ReadString(ref this.result.firstPageMd5_);
                            continue;
                        }
                        case 0x1a:
                        {
                            this.result.hasUsername = input.ReadString(ref this.result.username_);
                            continue;
                        }
                        case 0:
                            throw InvalidProtocolBufferException.InvalidTag();

                        case 10:
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
                        case 0x20:
                        {
                            this.result.hasMaxId = input.ReadUInt64(ref this.result.maxId_);
                            continue;
                        }
                        case 40:
                        {
                            this.result.hasSource = input.ReadUInt32(ref this.result.source_);
                            continue;
                        }
                        case 0x30:
                        {
                            this.result.hasMinFilterId = input.ReadUInt64(ref this.result.minFilterId_);
                            continue;
                        }
                        case 0x38:
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
                    this.result.hasLastRequestTime = input.ReadUInt32(ref this.result.lastRequestTime_);
                }
                return this;
            }

            private SnsUserPageRequest PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    SnsUserPageRequest result = this.result;
                    this.result = new SnsUserPageRequest();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public SnsUserPageRequest.Builder SetBaseRequest(micromsg.BaseRequest value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = value;
                return this;
            }

            public SnsUserPageRequest.Builder SetBaseRequest(micromsg.BaseRequest.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = builderForValue.Build();
                return this;
            }

            public SnsUserPageRequest.Builder SetFirstPageMd5(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasFirstPageMd5 = true;
                this.result.firstPageMd5_ = value;
                return this;
            }

            public SnsUserPageRequest.Builder SetLastRequestTime(uint value)
            {
                this.PrepareBuilder();
                this.result.hasLastRequestTime = true;
                this.result.lastRequestTime_ = value;
                return this;
            }

            public SnsUserPageRequest.Builder SetMaxId(ulong value)
            {
                this.PrepareBuilder();
                this.result.hasMaxId = true;
                this.result.maxId_ = value;
                return this;
            }

            public SnsUserPageRequest.Builder SetMinFilterId(ulong value)
            {
                this.PrepareBuilder();
                this.result.hasMinFilterId = true;
                this.result.minFilterId_ = value;
                return this;
            }

            public SnsUserPageRequest.Builder SetSource(uint value)
            {
                this.PrepareBuilder();
                this.result.hasSource = true;
                this.result.source_ = value;
                return this;
            }

            public SnsUserPageRequest.Builder SetUsername(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasUsername = true;
                this.result.username_ = value;
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

            public override SnsUserPageRequest DefaultInstanceForType
            {
                get
                {
                    return SnsUserPageRequest.DefaultInstance;
                }
            }

            public string FirstPageMd5
            {
                get
                {
                    return this.result.FirstPageMd5;
                }
                set
                {
                    this.SetFirstPageMd5(value);
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            public uint LastRequestTime
            {
                get
                {
                    return this.result.LastRequestTime;
                }
                set
                {
                    this.SetLastRequestTime(value);
                }
            }

            public ulong MaxId
            {
                get
                {
                    return this.result.MaxId;
                }
                set
                {
                    this.SetMaxId(value);
                }
            }

            protected override SnsUserPageRequest MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public ulong MinFilterId
            {
                get
                {
                    return this.result.MinFilterId;
                }
                set
                {
                    this.SetMinFilterId(value);
                }
            }

            public uint Source
            {
                get
                {
                    return this.result.Source;
                }
                set
                {
                    this.SetSource(value);
                }
            }

            protected override SnsUserPageRequest.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }

            public string Username
            {
                get
                {
                    return this.result.Username;
                }
                set
                {
                    this.SetUsername(value);
                }
            }
        }
    }
}


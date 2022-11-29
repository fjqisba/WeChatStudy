namespace micromsg
{
    using Google.ProtocolBuffers;

    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    using System.Runtime.CompilerServices;


    public sealed class SnsTimeLineRequest : GeneratedMessageLite<SnsTimeLineRequest, SnsTimeLineRequest.Builder>
    {
        private static readonly string[] _snsTimeLineRequestFieldNames = new string[] { "BaseRequest", "FirstPageMd5", "LastRequestTime", "MaxId", "MinFilterId" };
        private static readonly uint[] _snsTimeLineRequestFieldTags = new uint[] { 10, 0x12, 40, 0x18, 0x20 };
        private micromsg.BaseRequest baseRequest_;
        public const int BaseRequestFieldNumber = 1;
        private static readonly SnsTimeLineRequest defaultInstance = new SnsTimeLineRequest().MakeReadOnly();
        private string firstPageMd5_ = "";
        public const int FirstPageMd5FieldNumber = 2;
        private bool hasBaseRequest;
        private bool hasFirstPageMd5;
        private bool hasLastRequestTime;
        private bool hasMaxId;
        private bool hasMinFilterId;
        private uint lastRequestTime_;
        public const int LastRequestTimeFieldNumber = 5;
        private ulong maxId_;
        public const int MaxIdFieldNumber = 3;
        private int memoizedSerializedSize = -1;
        private ulong minFilterId_;
        public const int MinFilterIdFieldNumber = 4;

        static SnsTimeLineRequest()
        {

        }

        private SnsTimeLineRequest()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(SnsTimeLineRequest prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            SnsTimeLineRequest request = obj as SnsTimeLineRequest;
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
            if ((this.hasMaxId != request.hasMaxId) || (this.hasMaxId && !this.maxId_.Equals(request.maxId_)))
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
            if (this.hasMaxId)
            {
                hashCode ^= this.maxId_.GetHashCode();
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

        private SnsTimeLineRequest MakeReadOnly()
        {
            return this;
        }

        public static SnsTimeLineRequest ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<SnsTimeLineRequest, Builder>.PrintField("BaseRequest", this.hasBaseRequest, this.baseRequest_, writer);
            GeneratedMessageLite<SnsTimeLineRequest, Builder>.PrintField("FirstPageMd5", this.hasFirstPageMd5, this.firstPageMd5_, writer);
            GeneratedMessageLite<SnsTimeLineRequest, Builder>.PrintField("MaxId", this.hasMaxId, this.maxId_, writer);
            GeneratedMessageLite<SnsTimeLineRequest, Builder>.PrintField("MinFilterId", this.hasMinFilterId, this.minFilterId_, writer);
            GeneratedMessageLite<SnsTimeLineRequest, Builder>.PrintField("LastRequestTime", this.hasLastRequestTime, this.lastRequestTime_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _snsTimeLineRequestFieldNames;
            if (this.hasBaseRequest)
            {
                output.WriteMessage(1, strArray[0], this.BaseRequest);
            }
            if (this.hasFirstPageMd5)
            {
                output.WriteString(2, strArray[1], this.FirstPageMd5);
            }
            if (this.hasMaxId)
            {
                output.WriteUInt64(3, strArray[3], this.MaxId);
            }
            if (this.hasMinFilterId)
            {
                output.WriteUInt64(4, strArray[4], this.MinFilterId);
            }
            if (this.hasLastRequestTime)
            {
                output.WriteUInt32(5, strArray[2], this.LastRequestTime);
            }
        }

        public micromsg.BaseRequest BaseRequest
        {
            get
            {
                return (this.baseRequest_ ?? micromsg.BaseRequest.DefaultInstance);
            }
        }

        public static SnsTimeLineRequest DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override SnsTimeLineRequest DefaultInstanceForType
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
                    if (this.hasMaxId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt64Size(3, this.MaxId);
                    }
                    if (this.hasMinFilterId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt64Size(4, this.MinFilterId);
                    }
                    if (this.hasLastRequestTime)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(5, this.LastRequestTime);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override SnsTimeLineRequest ThisMessage
        {
            get
            {
                return this;
            }
        }

        [DebuggerNonUserCode, CompilerGenerated, GeneratedCode("ProtoGen", "2.3.0.277")]
        public sealed class Builder : GeneratedBuilderLite<SnsTimeLineRequest, SnsTimeLineRequest.Builder>
        {
            private SnsTimeLineRequest result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = SnsTimeLineRequest.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(SnsTimeLineRequest cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override SnsTimeLineRequest BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override SnsTimeLineRequest.Builder Clear()
            {
                this.result = SnsTimeLineRequest.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public SnsTimeLineRequest.Builder ClearBaseRequest()
            {
                this.PrepareBuilder();
                this.result.hasBaseRequest = false;
                this.result.baseRequest_ = null;
                return this;
            }

            public SnsTimeLineRequest.Builder ClearFirstPageMd5()
            {
                this.PrepareBuilder();
                this.result.hasFirstPageMd5 = false;
                this.result.firstPageMd5_ = "";
                return this;
            }

            public SnsTimeLineRequest.Builder ClearLastRequestTime()
            {
                this.PrepareBuilder();
                this.result.hasLastRequestTime = false;
                this.result.lastRequestTime_ = 0;
                return this;
            }

            public SnsTimeLineRequest.Builder ClearMaxId()
            {
                this.PrepareBuilder();
                this.result.hasMaxId = false;
                this.result.maxId_ = 0L;
                return this;
            }

            public SnsTimeLineRequest.Builder ClearMinFilterId()
            {
                this.PrepareBuilder();
                this.result.hasMinFilterId = false;
                this.result.minFilterId_ = 0L;
                return this;
            }

            public override SnsTimeLineRequest.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new SnsTimeLineRequest.Builder(this.result);
                }
                return new SnsTimeLineRequest.Builder().MergeFrom(this.result);
            }

            public SnsTimeLineRequest.Builder MergeBaseRequest(micromsg.BaseRequest value)
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

            public override SnsTimeLineRequest.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override SnsTimeLineRequest.Builder MergeFrom(IMessageLite other)
            {
                if (other is SnsTimeLineRequest)
                {
                    return this.MergeFrom((SnsTimeLineRequest) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override SnsTimeLineRequest.Builder MergeFrom(SnsTimeLineRequest other)
            {
                return this;
            }

            public override SnsTimeLineRequest.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(SnsTimeLineRequest._snsTimeLineRequestFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = SnsTimeLineRequest._snsTimeLineRequestFieldTags[index];
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
                            micromsg.BaseRequest.Builder builder = micromsg.BaseRequest.CreateBuilder();
                            if (this.result.hasBaseRequest)
                            {
                                builder.MergeFrom(this.BaseRequest);
                            }
                            input.ReadMessage(builder, extensionRegistry);
                            this.BaseRequest = builder.BuildPartial();
                            continue;
                        }
                        case 0x12:
                        {
                            this.result.hasFirstPageMd5 = input.ReadString(ref this.result.firstPageMd5_);
                            continue;
                        }
                        case 0x18:
                        {
                            this.result.hasMaxId = input.ReadUInt64(ref this.result.maxId_);
                            continue;
                        }
                        case 0x20:
                        {
                            this.result.hasMinFilterId = input.ReadUInt64(ref this.result.minFilterId_);
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
                    this.result.hasLastRequestTime = input.ReadUInt32(ref this.result.lastRequestTime_);
                }
                return this;
            }

            private SnsTimeLineRequest PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    SnsTimeLineRequest result = this.result;
                    this.result = new SnsTimeLineRequest();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public SnsTimeLineRequest.Builder SetBaseRequest(micromsg.BaseRequest value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = value;
                return this;
            }

            public SnsTimeLineRequest.Builder SetBaseRequest(micromsg.BaseRequest.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = builderForValue.Build();
                return this;
            }

            public SnsTimeLineRequest.Builder SetFirstPageMd5(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasFirstPageMd5 = true;
                this.result.firstPageMd5_ = value;
                return this;
            }

            public SnsTimeLineRequest.Builder SetLastRequestTime(uint value)
            {
                this.PrepareBuilder();
                this.result.hasLastRequestTime = true;
                this.result.lastRequestTime_ = value;
                return this;
            }

            public SnsTimeLineRequest.Builder SetMaxId(ulong value)
            {
                this.PrepareBuilder();
                this.result.hasMaxId = true;
                this.result.maxId_ = value;
                return this;
            }

            public SnsTimeLineRequest.Builder SetMinFilterId(ulong value)
            {
                this.PrepareBuilder();
                this.result.hasMinFilterId = true;
                this.result.minFilterId_ = value;
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

            public override SnsTimeLineRequest DefaultInstanceForType
            {
                get
                {
                    return SnsTimeLineRequest.DefaultInstance;
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

            protected override SnsTimeLineRequest MessageBeingBuilt
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

            protected override SnsTimeLineRequest.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


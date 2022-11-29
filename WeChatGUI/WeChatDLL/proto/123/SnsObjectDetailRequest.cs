namespace micromsg
{
    using Google.ProtocolBuffers;

    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    using System.Runtime.CompilerServices;

    public sealed class SnsObjectDetailRequest : GeneratedMessageLite<SnsObjectDetailRequest, SnsObjectDetailRequest.Builder>
    {
        private static readonly string[] _snsObjectDetailRequestFieldNames = new string[] { "BaseRequest", "Id" };
        private static readonly uint[] _snsObjectDetailRequestFieldTags = new uint[] { 10, 0x10 };
        private micromsg.BaseRequest baseRequest_;
        public const int BaseRequestFieldNumber = 1;
        private static readonly SnsObjectDetailRequest defaultInstance = new SnsObjectDetailRequest().MakeReadOnly();
        private bool hasBaseRequest;
        private bool hasId;
        private ulong id_;
        public const int IdFieldNumber = 2;
        private int memoizedSerializedSize = -1;

        static SnsObjectDetailRequest()
        {

        }

        private SnsObjectDetailRequest()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(SnsObjectDetailRequest prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            SnsObjectDetailRequest request = obj as SnsObjectDetailRequest;
            if (request == null)
            {
                return false;
            }
            if ((this.hasBaseRequest != request.hasBaseRequest) || (this.hasBaseRequest && !this.baseRequest_.Equals(request.baseRequest_)))
            {
                return false;
            }
            return ((this.hasId == request.hasId) && (!this.hasId || this.id_.Equals(request.id_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasBaseRequest)
            {
                hashCode ^= this.baseRequest_.GetHashCode();
            }
            if (this.hasId)
            {
                hashCode ^= this.id_.GetHashCode();
            }
            return hashCode;
        }

        private SnsObjectDetailRequest MakeReadOnly()
        {
            return this;
        }

        public static SnsObjectDetailRequest ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<SnsObjectDetailRequest, Builder>.PrintField("BaseRequest", this.hasBaseRequest, this.baseRequest_, writer);
            GeneratedMessageLite<SnsObjectDetailRequest, Builder>.PrintField("Id", this.hasId, this.id_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _snsObjectDetailRequestFieldNames;
            if (this.hasBaseRequest)
            {
                output.WriteMessage(1, strArray[0], this.BaseRequest);
            }
            if (this.hasId)
            {
                output.WriteUInt64(2, strArray[1], this.Id);
            }
        }

        public micromsg.BaseRequest BaseRequest
        {
            get
            {
                return (this.baseRequest_ ?? micromsg.BaseRequest.DefaultInstance);
            }
        }

        public static SnsObjectDetailRequest DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override SnsObjectDetailRequest DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public ulong Id
        {
            get
            {
                return this.id_;
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
                if (!this.hasId)
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
                    if (this.hasId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt64Size(2, this.Id);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override SnsObjectDetailRequest ThisMessage
        {
            get
            {
                return this;
            }
        }

        [CompilerGenerated, GeneratedCode("ProtoGen", "2.3.0.277"), DebuggerNonUserCode]
        public sealed class Builder : GeneratedBuilderLite<SnsObjectDetailRequest, SnsObjectDetailRequest.Builder>
        {
            private SnsObjectDetailRequest result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = SnsObjectDetailRequest.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(SnsObjectDetailRequest cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override SnsObjectDetailRequest BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override SnsObjectDetailRequest.Builder Clear()
            {
                this.result = SnsObjectDetailRequest.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public SnsObjectDetailRequest.Builder ClearBaseRequest()
            {
                this.PrepareBuilder();
                this.result.hasBaseRequest = false;
                this.result.baseRequest_ = null;
                return this;
            }

            public SnsObjectDetailRequest.Builder ClearId()
            {
                this.PrepareBuilder();
                this.result.hasId = false;
                this.result.id_ = 0L;
                return this;
            }

            public override SnsObjectDetailRequest.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new SnsObjectDetailRequest.Builder(this.result);
                }
                return new SnsObjectDetailRequest.Builder().MergeFrom(this.result);
            }

            public SnsObjectDetailRequest.Builder MergeBaseRequest(micromsg.BaseRequest value)
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

            public override SnsObjectDetailRequest.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override SnsObjectDetailRequest.Builder MergeFrom(IMessageLite other)
            {
                if (other is SnsObjectDetailRequest)
                {
                    return this.MergeFrom((SnsObjectDetailRequest) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override SnsObjectDetailRequest.Builder MergeFrom(SnsObjectDetailRequest other)
            {
                return this;
            }

            public override SnsObjectDetailRequest.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(SnsObjectDetailRequest._snsObjectDetailRequestFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = SnsObjectDetailRequest._snsObjectDetailRequestFieldTags[index];
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
                        case 0x10:
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
                    this.result.hasId = input.ReadUInt64(ref this.result.id_);
                }
                return this;
            }

            private SnsObjectDetailRequest PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    SnsObjectDetailRequest result = this.result;
                    this.result = new SnsObjectDetailRequest();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public SnsObjectDetailRequest.Builder SetBaseRequest(micromsg.BaseRequest value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = value;
                return this;
            }

            public SnsObjectDetailRequest.Builder SetBaseRequest(micromsg.BaseRequest.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = builderForValue.Build();
                return this;
            }

            public SnsObjectDetailRequest.Builder SetId(ulong value)
            {
                this.PrepareBuilder();
                this.result.hasId = true;
                this.result.id_ = value;
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

            public override SnsObjectDetailRequest DefaultInstanceForType
            {
                get
                {
                    return SnsObjectDetailRequest.DefaultInstance;
                }
            }

            public ulong Id
            {
                get
                {
                    return this.result.Id;
                }
                set
                {
                    this.SetId(value);
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override SnsObjectDetailRequest MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override SnsObjectDetailRequest.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


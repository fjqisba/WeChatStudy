namespace micromsg
{
    using Google.ProtocolBuffers;

    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    using System.Runtime.CompilerServices;


    public sealed class SnsSyncRequest : GeneratedMessageLite<SnsSyncRequest, SnsSyncRequest.Builder>
    {
        private static readonly string[] _snsSyncRequestFieldNames = new string[] { "BaseRequest", "KeyBuf", "Selector" };
        private static readonly uint[] _snsSyncRequestFieldTags = new uint[] { 10, 0x1a, 0x10 };
        private BaseRequest baseRequest_;
        public const int BaseRequestFieldNumber = 1;
        private static readonly SnsSyncRequest defaultInstance = new SnsSyncRequest().MakeReadOnly();
        private bool hasBaseRequest;
        private bool hasKeyBuf;
        private bool hasSelector;
        private SKBuiltinBuffer_t keyBuf_;
        public const int KeyBufFieldNumber = 3;
        private int memoizedSerializedSize = -1;
        private uint selector_;
        public const int SelectorFieldNumber = 2;

        static SnsSyncRequest()
        {

        }

        private SnsSyncRequest()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(SnsSyncRequest prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            SnsSyncRequest request = obj as SnsSyncRequest;
            if (request == null)
            {
                return false;
            }
            if ((this.hasBaseRequest != request.hasBaseRequest) || (this.hasBaseRequest && !this.baseRequest_.Equals(request.baseRequest_)))
            {
                return false;
            }
            if ((this.hasSelector != request.hasSelector) || (this.hasSelector && !this.selector_.Equals(request.selector_)))
            {
                return false;
            }
            return ((this.hasKeyBuf == request.hasKeyBuf) && (!this.hasKeyBuf || this.keyBuf_.Equals(request.keyBuf_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasBaseRequest)
            {
                hashCode ^= this.baseRequest_.GetHashCode();
            }
            if (this.hasSelector)
            {
                hashCode ^= this.selector_.GetHashCode();
            }
            if (this.hasKeyBuf)
            {
                hashCode ^= this.keyBuf_.GetHashCode();
            }
            return hashCode;
        }

        private SnsSyncRequest MakeReadOnly()
        {
            return this;
        }

        public static SnsSyncRequest ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<SnsSyncRequest, Builder>.PrintField("BaseRequest", this.hasBaseRequest, this.baseRequest_, writer);
            GeneratedMessageLite<SnsSyncRequest, Builder>.PrintField("Selector", this.hasSelector, this.selector_, writer);
            GeneratedMessageLite<SnsSyncRequest, Builder>.PrintField("KeyBuf", this.hasKeyBuf, this.keyBuf_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _snsSyncRequestFieldNames;
            if (this.hasBaseRequest)
            {
                output.WriteMessage(1, strArray[0], this.BaseRequest);
            }
            if (this.hasSelector)
            {
                output.WriteUInt32(2, strArray[2], this.Selector);
            }
            if (this.hasKeyBuf)
            {
                output.WriteMessage(3, strArray[1], this.KeyBuf);
            }
        }

        public BaseRequest BaseRequest
        {
            get
            {
                return (this.baseRequest_ ?? BaseRequest.DefaultInstance);
            }
        }

        public static SnsSyncRequest DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override SnsSyncRequest DefaultInstanceForType
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
                if (!this.hasSelector)
                {
                    return false;
                }
                if (!this.hasKeyBuf)
                {
                    return false;
                }
                if (!this.BaseRequest.IsInitialized)
                {
                    return false;
                }
                if (!this.KeyBuf.IsInitialized)
                {
                    return false;
                }
                return true;
            }
        }

        public SKBuiltinBuffer_t KeyBuf
        {
            get
            {
                return (this.keyBuf_ ?? SKBuiltinBuffer_t.DefaultInstance);
            }
        }

        public uint Selector
        {
            get
            {
                return this.selector_;
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
                    if (this.hasSelector)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(2, this.Selector);
                    }
                    if (this.hasKeyBuf)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(3, this.KeyBuf);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override SnsSyncRequest ThisMessage
        {
            get
            {
                return this;
            }
        }

        [DebuggerNonUserCode, CompilerGenerated, GeneratedCode("ProtoGen", "2.3.0.277")]
        public sealed class Builder : GeneratedBuilderLite<SnsSyncRequest, SnsSyncRequest.Builder>
        {
            private SnsSyncRequest result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = SnsSyncRequest.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(SnsSyncRequest cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override SnsSyncRequest BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override SnsSyncRequest.Builder Clear()
            {
                this.result = SnsSyncRequest.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public SnsSyncRequest.Builder ClearBaseRequest()
            {
                this.PrepareBuilder();
                this.result.hasBaseRequest = false;
                this.result.baseRequest_ = null;
                return this;
            }

            public SnsSyncRequest.Builder ClearKeyBuf()
            {
                this.PrepareBuilder();
                this.result.hasKeyBuf = false;
                this.result.keyBuf_ = null;
                return this;
            }

            public SnsSyncRequest.Builder ClearSelector()
            {
                this.PrepareBuilder();
                this.result.hasSelector = false;
                this.result.selector_ = 0;
                return this;
            }

            public override SnsSyncRequest.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new SnsSyncRequest.Builder(this.result);
                }
                return new SnsSyncRequest.Builder().MergeFrom(this.result);
            }

            public SnsSyncRequest.Builder MergeBaseRequest(BaseRequest value)
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

            public override SnsSyncRequest.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override SnsSyncRequest.Builder MergeFrom(IMessageLite other)
            {
                if (other is SnsSyncRequest)
                {
                    return this.MergeFrom((SnsSyncRequest)other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override SnsSyncRequest.Builder MergeFrom(SnsSyncRequest other)
            {
                return this;
            }

            public override SnsSyncRequest.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(SnsSyncRequest._snsSyncRequestFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = SnsSyncRequest._snsSyncRequestFieldTags[index];
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
                                this.result.hasSelector = input.ReadUInt32(ref this.result.selector_);
                                continue;
                            }
                        case 0x1a:
                            {
                                SKBuiltinBuffer_t.Builder builder2 = SKBuiltinBuffer_t.CreateBuilder();
                                if (this.result.hasKeyBuf)
                                {
                                    builder2.MergeFrom(this.KeyBuf);
                                }
                                input.ReadMessage(builder2, extensionRegistry);
                                this.KeyBuf = builder2.BuildPartial();
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

            public SnsSyncRequest.Builder MergeKeyBuf(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasKeyBuf && (this.result.keyBuf_ != SKBuiltinBuffer_t.DefaultInstance))
                {
                    this.result.keyBuf_ = SKBuiltinBuffer_t.CreateBuilder(this.result.keyBuf_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.keyBuf_ = value;
                }
                this.result.hasKeyBuf = true;
                return this;
            }

            private SnsSyncRequest PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    SnsSyncRequest result = this.result;
                    this.result = new SnsSyncRequest();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public SnsSyncRequest.Builder SetBaseRequest(BaseRequest value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = value;
                return this;
            }

            public SnsSyncRequest.Builder SetBaseRequest(BaseRequest.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = builderForValue.Build();
                return this;
            }

            public SnsSyncRequest.Builder SetKeyBuf(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasKeyBuf = true;
                this.result.keyBuf_ = value;
                return this;
            }

            public SnsSyncRequest.Builder SetKeyBuf(SKBuiltinBuffer_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasKeyBuf = true;
                this.result.keyBuf_ = builderForValue.Build();
                return this;
            }

            public SnsSyncRequest.Builder SetSelector(uint value)
            {
                this.PrepareBuilder();
                this.result.hasSelector = true;
                this.result.selector_ = value;
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

            public override SnsSyncRequest DefaultInstanceForType
            {
                get
                {
                    return SnsSyncRequest.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            public SKBuiltinBuffer_t KeyBuf
            {
                get
                {
                    return this.result.KeyBuf;
                }
                set
                {
                    this.SetKeyBuf(value);
                }
            }

            protected override SnsSyncRequest MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public uint Selector
            {
                get
                {
                    return this.result.Selector;
                }
                set
                {
                    this.SetSelector(value);
                }
            }

            protected override SnsSyncRequest.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}

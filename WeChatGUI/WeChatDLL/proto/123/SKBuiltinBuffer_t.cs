namespace micromsg
{
    using Google.ProtocolBuffers;
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

    public sealed class SKBuiltinBuffer_t : GeneratedMessageLite<SKBuiltinBuffer_t, SKBuiltinBuffer_t.Builder>
    {
        private static readonly string[] _sKBuiltinBufferTFieldNames = new string[] { "Buffer", "iLen" };
        private static readonly uint[] _sKBuiltinBufferTFieldTags = new uint[] { 0x12, 8 };
        private ByteString buffer_ = ByteString.Empty;
        public const int BufferFieldNumber = 2;
        private static readonly SKBuiltinBuffer_t defaultInstance = new SKBuiltinBuffer_t().MakeReadOnly();
        private bool hasBuffer;
        private bool hasILen;
        private uint iLen_;
        public const int ILenFieldNumber = 1;
        private int memoizedSerializedSize = -1;

        static SKBuiltinBuffer_t()
        {
            object.ReferenceEquals(SKBuiltinBufferT.Descriptor, null);
        }

        private SKBuiltinBuffer_t()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(SKBuiltinBuffer_t prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            SKBuiltinBuffer_t _t = obj as SKBuiltinBuffer_t;
            if (_t == null)
            {
                return false;
            }
            if ((this.hasILen != _t.hasILen) || (this.hasILen && !this.iLen_.Equals(_t.iLen_)))
            {
                return false;
            }
            return ((this.hasBuffer == _t.hasBuffer) && (!this.hasBuffer || this.buffer_.Equals(_t.buffer_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasILen)
            {
                hashCode ^= this.iLen_.GetHashCode();
            }
            if (this.hasBuffer)
            {
                hashCode ^= this.buffer_.GetHashCode();
            }
            return hashCode;
        }

        private SKBuiltinBuffer_t MakeReadOnly()
        {
            return this;
        }

        public static SKBuiltinBuffer_t ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<SKBuiltinBuffer_t, Builder>.PrintField("iLen", this.hasILen, this.iLen_, writer);
            GeneratedMessageLite<SKBuiltinBuffer_t, Builder>.PrintField("Buffer", this.hasBuffer, this.buffer_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _sKBuiltinBufferTFieldNames;
            if (this.hasILen)
            {
                output.WriteUInt32(1, strArray[1], this.ILen);
            }
            if (this.hasBuffer)
            {
                output.WriteBytes(2, strArray[0], this.Buffer);
            }
        }

        public ByteString Buffer
        {
            get
            {
                return this.buffer_;
            }
        }

        public static SKBuiltinBuffer_t DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override SKBuiltinBuffer_t DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public uint ILen
        {
            get
            {
                return this.iLen_;
            }
        }

        public override bool IsInitialized
        {
            get
            {
                if (!this.hasILen)
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
                    if (this.hasILen)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(1, this.ILen);
                    }
                    if (this.hasBuffer)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeBytesSize(2, this.Buffer);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override SKBuiltinBuffer_t ThisMessage
        {
            get
            {
                return this;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<SKBuiltinBuffer_t, SKBuiltinBuffer_t.Builder>
        {
            private SKBuiltinBuffer_t result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = SKBuiltinBuffer_t.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(SKBuiltinBuffer_t cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override SKBuiltinBuffer_t BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override SKBuiltinBuffer_t.Builder Clear()
            {
                this.result = SKBuiltinBuffer_t.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public SKBuiltinBuffer_t.Builder ClearBuffer()
            {
                this.PrepareBuilder();
                this.result.hasBuffer = false;
                this.result.buffer_ = ByteString.Empty;
                return this;
            }

            public SKBuiltinBuffer_t.Builder ClearILen()
            {
                this.PrepareBuilder();
                this.result.hasILen = false;
                this.result.iLen_ = 0;
                return this;
            }

            public override SKBuiltinBuffer_t.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new SKBuiltinBuffer_t.Builder(this.result);
                }
                return new SKBuiltinBuffer_t.Builder().MergeFrom(this.result);
            }

            public override SKBuiltinBuffer_t.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override SKBuiltinBuffer_t.Builder MergeFrom(IMessageLite other)
            {
                if (other is SKBuiltinBuffer_t)
                {
                    return this.MergeFrom((SKBuiltinBuffer_t) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override SKBuiltinBuffer_t.Builder MergeFrom(SKBuiltinBuffer_t other)
            {
                return this;
            }

            public override SKBuiltinBuffer_t.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(SKBuiltinBuffer_t._sKBuiltinBufferTFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = SKBuiltinBuffer_t._sKBuiltinBufferTFieldTags[index];
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
                            this.result.hasILen = input.ReadUInt32(ref this.result.iLen_);
                            continue;
                        }
                        case 0x12:
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
                    this.result.hasBuffer = input.ReadBytes(ref this.result.buffer_);
                }
                return this;
            }

            private SKBuiltinBuffer_t PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    SKBuiltinBuffer_t result = this.result;
                    this.result = new SKBuiltinBuffer_t();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public SKBuiltinBuffer_t.Builder SetBuffer(ByteString value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBuffer = true;
                this.result.buffer_ = value;
                return this;
            }

            public SKBuiltinBuffer_t.Builder SetILen(uint value)
            {
                this.PrepareBuilder();
                this.result.hasILen = true;
                this.result.iLen_ = value;
                return this;
            }

            public ByteString Buffer
            {
                get
                {
                    return this.result.Buffer;
                }
                set
                {
                    this.SetBuffer(value);
                }
            }

            public override SKBuiltinBuffer_t DefaultInstanceForType
            {
                get
                {
                    return SKBuiltinBuffer_t.DefaultInstance;
                }
            }

            public uint ILen
            {
                get
                {
                    return this.result.ILen;
                }
                set
                {
                    this.SetILen(value);
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override SKBuiltinBuffer_t MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override SKBuiltinBuffer_t.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


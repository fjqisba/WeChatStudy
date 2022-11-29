namespace micromsg
{
    using Google.ProtocolBuffers;
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

    public sealed class SKBuiltinString_t : GeneratedMessageLite<SKBuiltinString_t, SKBuiltinString_t.Builder>
    {
        private static readonly string[] _sKBuiltinStringTFieldNames = new string[] { "String" };
        private static readonly uint[] _sKBuiltinStringTFieldTags = new uint[] { 10 };
        private static readonly SKBuiltinString_t defaultInstance = new SKBuiltinString_t().MakeReadOnly();
        private bool hasString;
        private int memoizedSerializedSize = -1;
        private string string_ = "";
        public const int StringFieldNumber = 1;

        static SKBuiltinString_t()
        {
            object.ReferenceEquals(SKBuiltinStringT.Descriptor, null);
        }

        private SKBuiltinString_t()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(SKBuiltinString_t prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            SKBuiltinString_t _t = obj as SKBuiltinString_t;
            if (_t == null)
            {
                return false;
            }
            return ((this.hasString == _t.hasString) && (!this.hasString || this.string_.Equals(_t.string_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasString)
            {
                hashCode ^= this.string_.GetHashCode();
            }
            return hashCode;
        }

        private SKBuiltinString_t MakeReadOnly()
        {
            return this;
        }

        public static SKBuiltinString_t ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<SKBuiltinString_t, Builder>.PrintField("String", this.hasString, this.string_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _sKBuiltinStringTFieldNames;
            if (this.hasString)
            {
                output.WriteString(1, strArray[0], this.String);
            }
        }

        public static SKBuiltinString_t DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override SKBuiltinString_t DefaultInstanceForType
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
                    if (this.hasString)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(1, this.String);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        public string String
        {
            get
            {
                return this.string_;
            }
        }

        protected override SKBuiltinString_t ThisMessage
        {
            get
            {
                return this;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<SKBuiltinString_t, SKBuiltinString_t.Builder>
        {
            private SKBuiltinString_t result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = SKBuiltinString_t.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(SKBuiltinString_t cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override SKBuiltinString_t BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override SKBuiltinString_t.Builder Clear()
            {
                this.result = SKBuiltinString_t.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public SKBuiltinString_t.Builder ClearString()
            {
                this.PrepareBuilder();
                this.result.hasString = false;
                this.result.string_ = "";
                return this;
            }

            public override SKBuiltinString_t.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new SKBuiltinString_t.Builder(this.result);
                }
                return new SKBuiltinString_t.Builder().MergeFrom(this.result);
            }

            public override SKBuiltinString_t.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override SKBuiltinString_t.Builder MergeFrom(IMessageLite other)
            {
                if (other is SKBuiltinString_t)
                {
                    return this.MergeFrom((SKBuiltinString_t) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override SKBuiltinString_t.Builder MergeFrom(SKBuiltinString_t other)
            {
                return this;
            }

            public override SKBuiltinString_t.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(SKBuiltinString_t._sKBuiltinStringTFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = SKBuiltinString_t._sKBuiltinStringTFieldTags[index];
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
                    this.result.hasString = input.ReadString(ref this.result.string_);
                }
                return this;
            }

            private SKBuiltinString_t PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    SKBuiltinString_t result = this.result;
                    this.result = new SKBuiltinString_t();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public SKBuiltinString_t.Builder SetString(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasString = true;
                this.result.string_ = value;
                return this;
            }

            public override SKBuiltinString_t DefaultInstanceForType
            {
                get
                {
                    return SKBuiltinString_t.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override SKBuiltinString_t MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public string String
            {
                get
                {
                    return this.result.String;
                }
                set
                {
                    this.SetString(value);
                }
            }

            protected override SKBuiltinString_t.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


namespace micromsg
{
    using Google.ProtocolBuffers;

    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

    
    public sealed class GeneralControlBitSet : GeneratedMessageLite<GeneralControlBitSet, GeneralControlBitSet.Builder>
    {
        private static readonly string[] _generalControlBitSetFieldNames = new string[] { "BitValue" };
        private static readonly uint[] _generalControlBitSetFieldTags = new uint[] { 8 };
        private uint bitValue_;
        public const int BitValueFieldNumber = 1;
        private static readonly GeneralControlBitSet defaultInstance = new GeneralControlBitSet().MakeReadOnly();
        private bool hasBitValue;
        private int memoizedSerializedSize = -1;

        static GeneralControlBitSet()
        {
        }

        private GeneralControlBitSet()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(GeneralControlBitSet prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            GeneralControlBitSet set = obj as GeneralControlBitSet;
            if (set == null)
            {
                return false;
            }
            return ((this.hasBitValue == set.hasBitValue) && (!this.hasBitValue || this.bitValue_.Equals(set.bitValue_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasBitValue)
            {
                hashCode ^= this.bitValue_.GetHashCode();
            }
            return hashCode;
        }

        private GeneralControlBitSet MakeReadOnly()
        {
            return this;
        }

        public static GeneralControlBitSet ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<GeneralControlBitSet, Builder>.PrintField("BitValue", this.hasBitValue, this.bitValue_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _generalControlBitSetFieldNames;
            if (this.hasBitValue)
            {
                output.WriteUInt32(1, strArray[0], this.BitValue);
            }
        }

        public uint BitValue
        {
            get
            {
                return this.bitValue_;
            }
        }

        public static GeneralControlBitSet DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override GeneralControlBitSet DefaultInstanceForType
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
                if (!this.hasBitValue)
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
                    if (this.hasBitValue)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(1, this.BitValue);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override GeneralControlBitSet ThisMessage
        {
            get
            {
                return this;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<GeneralControlBitSet, GeneralControlBitSet.Builder>
        {
            private GeneralControlBitSet result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = GeneralControlBitSet.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(GeneralControlBitSet cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override GeneralControlBitSet BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override GeneralControlBitSet.Builder Clear()
            {
                this.result = GeneralControlBitSet.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public GeneralControlBitSet.Builder ClearBitValue()
            {
                this.PrepareBuilder();
                this.result.hasBitValue = false;
                this.result.bitValue_ = 0;
                return this;
            }

            public override GeneralControlBitSet.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new GeneralControlBitSet.Builder(this.result);
                }
                return new GeneralControlBitSet.Builder().MergeFrom(this.result);
            }

            public override GeneralControlBitSet.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override GeneralControlBitSet.Builder MergeFrom(IMessageLite other)
            {
                if (other is GeneralControlBitSet)
                {
                    return this.MergeFrom((GeneralControlBitSet) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override GeneralControlBitSet.Builder MergeFrom(GeneralControlBitSet other)
            {
                return this;
            }

            public override GeneralControlBitSet.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(GeneralControlBitSet._generalControlBitSetFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = GeneralControlBitSet._generalControlBitSetFieldTags[index];
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
                    this.result.hasBitValue = input.ReadUInt32(ref this.result.bitValue_);
                }
                return this;
            }

            private GeneralControlBitSet PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    GeneralControlBitSet result = this.result;
                    this.result = new GeneralControlBitSet();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public GeneralControlBitSet.Builder SetBitValue(uint value)
            {
                this.PrepareBuilder();
                this.result.hasBitValue = true;
                this.result.bitValue_ = value;
                return this;
            }

            public uint BitValue
            {
                get
                {
                    return this.result.BitValue;
                }
                set
                {
                    this.SetBitValue(value);
                }
            }

            public override GeneralControlBitSet DefaultInstanceForType
            {
                get
                {
                    return GeneralControlBitSet.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override GeneralControlBitSet MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override GeneralControlBitSet.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


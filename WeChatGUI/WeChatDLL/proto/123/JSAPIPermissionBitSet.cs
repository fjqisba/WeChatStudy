namespace micromsg
{
    using Google.ProtocolBuffers;

    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    


    public sealed class JSAPIPermissionBitSet : GeneratedMessageLite<JSAPIPermissionBitSet, JSAPIPermissionBitSet.Builder>
    {
        private static readonly string[] _jSAPIPermissionBitSetFieldNames = new string[] { "BitValue" };
        private static readonly uint[] _jSAPIPermissionBitSetFieldTags = new uint[] { 8 };
        private uint bitValue_;
        public const int BitValueFieldNumber = 1;
        private static readonly JSAPIPermissionBitSet defaultInstance = new JSAPIPermissionBitSet().MakeReadOnly();
        private bool hasBitValue;
        private int memoizedSerializedSize = -1;

        static JSAPIPermissionBitSet()
        {

        }

        private JSAPIPermissionBitSet()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(JSAPIPermissionBitSet prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            JSAPIPermissionBitSet set = obj as JSAPIPermissionBitSet;
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

        private JSAPIPermissionBitSet MakeReadOnly()
        {
            return this;
        }

        public static JSAPIPermissionBitSet ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<JSAPIPermissionBitSet, Builder>.PrintField("BitValue", this.hasBitValue, this.bitValue_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _jSAPIPermissionBitSetFieldNames;
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

        public static JSAPIPermissionBitSet DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override JSAPIPermissionBitSet DefaultInstanceForType
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

        protected override JSAPIPermissionBitSet ThisMessage
        {
            get
            {
                return this;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<JSAPIPermissionBitSet, JSAPIPermissionBitSet.Builder>
        {
            private JSAPIPermissionBitSet result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = JSAPIPermissionBitSet.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(JSAPIPermissionBitSet cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override JSAPIPermissionBitSet BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override JSAPIPermissionBitSet.Builder Clear()
            {
                this.result = JSAPIPermissionBitSet.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public JSAPIPermissionBitSet.Builder ClearBitValue()
            {
                this.PrepareBuilder();
                this.result.hasBitValue = false;
                this.result.bitValue_ = 0;
                return this;
            }

            public override JSAPIPermissionBitSet.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new JSAPIPermissionBitSet.Builder(this.result);
                }
                return new JSAPIPermissionBitSet.Builder().MergeFrom(this.result);
            }

            public override JSAPIPermissionBitSet.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override JSAPIPermissionBitSet.Builder MergeFrom(IMessageLite other)
            {
                if (other is JSAPIPermissionBitSet)
                {
                    return this.MergeFrom((JSAPIPermissionBitSet) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override JSAPIPermissionBitSet.Builder MergeFrom(JSAPIPermissionBitSet other)
            {
                return this;
            }

            public override JSAPIPermissionBitSet.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(JSAPIPermissionBitSet._jSAPIPermissionBitSetFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = JSAPIPermissionBitSet._jSAPIPermissionBitSetFieldTags[index];
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

            private JSAPIPermissionBitSet PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    JSAPIPermissionBitSet result = this.result;
                    this.result = new JSAPIPermissionBitSet();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public JSAPIPermissionBitSet.Builder SetBitValue(uint value)
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

            public override JSAPIPermissionBitSet DefaultInstanceForType
            {
                get
                {
                    return JSAPIPermissionBitSet.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override JSAPIPermissionBitSet MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override JSAPIPermissionBitSet.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


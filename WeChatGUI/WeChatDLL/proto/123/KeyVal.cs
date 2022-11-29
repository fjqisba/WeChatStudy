namespace micromsg
{
    using Google.ProtocolBuffers;
    
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

   
    public sealed class KeyVal : GeneratedMessageLite<KeyVal, KeyVal.Builder>
    {
        private static readonly string[] _keyValFieldNames = new string[] { "Key", "Val" };
        private static readonly uint[] _keyValFieldTags = new uint[] { 8, 0x10 };
        private static readonly KeyVal defaultInstance = new KeyVal().MakeReadOnly();
        private bool hasKey;
        private bool hasVal;
        private uint key_;
        public const int KeyFieldNumber = 1;
        private int memoizedSerializedSize = -1;
        private uint val_;
        public const int ValFieldNumber = 2;

        static KeyVal()
        {
            //object.ReferenceEquals(KeyVal.Descriptor, null);
        }

        private KeyVal()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(KeyVal prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            KeyVal val = obj as KeyVal;
            if (val == null)
            {
                return false;
            }
            if ((this.hasKey != val.hasKey) || (this.hasKey && !this.key_.Equals(val.key_)))
            {
                return false;
            }
            return ((this.hasVal == val.hasVal) && (!this.hasVal || this.val_.Equals(val.val_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasKey)
            {
                hashCode ^= this.key_.GetHashCode();
            }
            if (this.hasVal)
            {
                hashCode ^= this.val_.GetHashCode();
            }
            return hashCode;
        }

        private KeyVal MakeReadOnly()
        {
            return this;
        }

        public static KeyVal ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<KeyVal, Builder>.PrintField("Key", this.hasKey, this.key_, writer);
            GeneratedMessageLite<KeyVal, Builder>.PrintField("Val", this.hasVal, this.val_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _keyValFieldNames;
            if (this.hasKey)
            {
                output.WriteUInt32(1, strArray[0], this.Key);
            }
            if (this.hasVal)
            {
                output.WriteUInt32(2, strArray[1], this.Val);
            }
        }

        public static KeyVal DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override KeyVal DefaultInstanceForType
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
                if (!this.hasKey)
                {
                    return false;
                }
                if (!this.hasVal)
                {
                    return false;
                }
                return true;
            }
        }

        public uint Key
        {
            get
            {
                return this.key_;
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
                    if (this.hasKey)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(1, this.Key);
                    }
                    if (this.hasVal)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(2, this.Val);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override KeyVal ThisMessage
        {
            get
            {
                return this;
            }
        }

        public uint Val
        {
            get
            {
                return this.val_;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<KeyVal, KeyVal.Builder>
        {
            private KeyVal result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = KeyVal.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(KeyVal cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override KeyVal BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override KeyVal.Builder Clear()
            {
                this.result = KeyVal.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public KeyVal.Builder ClearKey()
            {
                this.PrepareBuilder();
                this.result.hasKey = false;
                this.result.key_ = 0;
                return this;
            }

            public KeyVal.Builder ClearVal()
            {
                this.PrepareBuilder();
                this.result.hasVal = false;
                this.result.val_ = 0;
                return this;
            }

            public override KeyVal.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new KeyVal.Builder(this.result);
                }
                return new KeyVal.Builder().MergeFrom(this.result);
            }

            public override KeyVal.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override KeyVal.Builder MergeFrom(IMessageLite other)
            {
                if (other is KeyVal)
                {
                    return this.MergeFrom((KeyVal) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override KeyVal.Builder MergeFrom(KeyVal other)
            {
                return this;
            }

            public override KeyVal.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(KeyVal._keyValFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = KeyVal._keyValFieldTags[index];
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
                            this.result.hasKey = input.ReadUInt32(ref this.result.key_);
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
                    this.result.hasVal = input.ReadUInt32(ref this.result.val_);
                }
                return this;
            }

            private KeyVal PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    KeyVal result = this.result;
                    this.result = new KeyVal();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public KeyVal.Builder SetKey(uint value)
            {
                this.PrepareBuilder();
                this.result.hasKey = true;
                this.result.key_ = value;
                return this;
            }

            public KeyVal.Builder SetVal(uint value)
            {
                this.PrepareBuilder();
                this.result.hasVal = true;
                this.result.val_ = value;
                return this;
            }

            public override KeyVal DefaultInstanceForType
            {
                get
                {
                    return KeyVal.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            public uint Key
            {
                get
                {
                    return this.result.Key;
                }
                set
                {
                    this.SetKey(value);
                }
            }

            protected override KeyVal MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override KeyVal.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }

            public uint Val
            {
                get
                {
                    return this.result.Val;
                }
                set
                {
                    this.SetVal(value);
                }
            }
        }
    }
}


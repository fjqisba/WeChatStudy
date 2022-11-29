namespace micromsg
{
    using Google.ProtocolBuffers;
    
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

    //
    public sealed class KVStatItem : GeneratedMessageLite<KVStatItem, KVStatItem.Builder>
    {
        private static readonly string[] _kVStatItemFieldNames = new string[] { "Key", "Value" };
        private static readonly uint[] _kVStatItemFieldTags = new uint[] { 8, 0x12 };
        private static readonly KVStatItem defaultInstance = new KVStatItem().MakeReadOnly();
        private bool hasKey;
        private bool hasValue;
        private uint key_;
        public const int KeyFieldNumber = 1;
        private int memoizedSerializedSize = -1;
        private string value_ = "";
        public const int ValueFieldNumber = 2;

        static KVStatItem()
        {
            //object.ReferenceEquals(KVStatItem.Descriptor, null);
        }

        private KVStatItem()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(KVStatItem prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            KVStatItem item = obj as KVStatItem;
            if (item == null)
            {
                return false;
            }
            if ((this.hasKey != item.hasKey) || (this.hasKey && !this.key_.Equals(item.key_)))
            {
                return false;
            }
            return ((this.hasValue == item.hasValue) && (!this.hasValue || this.value_.Equals(item.value_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasKey)
            {
                hashCode ^= this.key_.GetHashCode();
            }
            if (this.hasValue)
            {
                hashCode ^= this.value_.GetHashCode();
            }
            return hashCode;
        }

        private KVStatItem MakeReadOnly()
        {
            return this;
        }

        public static KVStatItem ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<KVStatItem, Builder>.PrintField("Key", this.hasKey, this.key_, writer);
            GeneratedMessageLite<KVStatItem, Builder>.PrintField("Value", this.hasValue, this.value_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _kVStatItemFieldNames;
            if (this.hasKey)
            {
                output.WriteUInt32(1, strArray[0], this.Key);
            }
            if (this.hasValue)
            {
                output.WriteString(2, strArray[1], this.Value);
            }
        }

        public static KVStatItem DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override KVStatItem DefaultInstanceForType
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
                    if (this.hasValue)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(2, this.Value);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override KVStatItem ThisMessage
        {
            get
            {
                return this;
            }
        }

        public string Value
        {
            get
            {
                return this.value_;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<KVStatItem, KVStatItem.Builder>
        {
            private KVStatItem result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = KVStatItem.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(KVStatItem cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override KVStatItem BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override KVStatItem.Builder Clear()
            {
                this.result = KVStatItem.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public KVStatItem.Builder ClearKey()
            {
                this.PrepareBuilder();
                this.result.hasKey = false;
                this.result.key_ = 0;
                return this;
            }

            public KVStatItem.Builder ClearValue()
            {
                this.PrepareBuilder();
                this.result.hasValue = false;
                this.result.value_ = "";
                return this;
            }

            public override KVStatItem.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new KVStatItem.Builder(this.result);
                }
                return new KVStatItem.Builder().MergeFrom(this.result);
            }

            public override KVStatItem.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override KVStatItem.Builder MergeFrom(IMessageLite other)
            {
                if (other is KVStatItem)
                {
                    return this.MergeFrom((KVStatItem) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override KVStatItem.Builder MergeFrom(KVStatItem other)
            {
                return this;
            }

            public override KVStatItem.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(KVStatItem._kVStatItemFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = KVStatItem._kVStatItemFieldTags[index];
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
                    this.result.hasValue = input.ReadString(ref this.result.value_);
                }
                return this;
            }

            private KVStatItem PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    KVStatItem result = this.result;
                    this.result = new KVStatItem();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public KVStatItem.Builder SetKey(uint value)
            {
                this.PrepareBuilder();
                this.result.hasKey = true;
                this.result.key_ = value;
                return this;
            }

            public KVStatItem.Builder SetValue(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasValue = true;
                this.result.value_ = value;
                return this;
            }

            public override KVStatItem DefaultInstanceForType
            {
                get
                {
                    return KVStatItem.DefaultInstance;
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

            protected override KVStatItem MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override KVStatItem.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }

            public string Value
            {
                get
                {
                    return this.result.Value;
                }
                set
                {
                    this.SetValue(value);
                }
            }
        }
    }
}


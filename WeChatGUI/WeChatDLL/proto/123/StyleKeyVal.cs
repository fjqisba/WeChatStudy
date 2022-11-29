namespace micromsg
{
    using Google.ProtocolBuffers;

    using System;

    using System.Diagnostics;
    using System.IO;
    using System.Runtime.CompilerServices;


    public sealed class StyleKeyVal : GeneratedMessageLite<StyleKeyVal, StyleKeyVal.Builder>
    {
        private static readonly string[] _styleKeyValFieldNames = new string[] { "Key", "Val" };
        private static readonly uint[] _styleKeyValFieldTags = new uint[] { 8, 0x12 };
        private static readonly StyleKeyVal defaultInstance = new StyleKeyVal().MakeReadOnly();
        private bool hasKey;
        private bool hasVal;
        private uint key_;
        public const int KeyFieldNumber = 1;
        private int memoizedSerializedSize = -1;
        private string val_ = "";
        public const int ValFieldNumber = 2;

        static StyleKeyVal()
        {

        }

        private StyleKeyVal()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(StyleKeyVal prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            StyleKeyVal val = obj as StyleKeyVal;
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

        private StyleKeyVal MakeReadOnly()
        {
            return this;
        }

        public static StyleKeyVal ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<StyleKeyVal, Builder>.PrintField("Key", this.hasKey, this.key_, writer);
            GeneratedMessageLite<StyleKeyVal, Builder>.PrintField("Val", this.hasVal, this.val_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _styleKeyValFieldNames;
            if (this.hasKey)
            {
                output.WriteUInt32(1, strArray[0], this.Key);
            }
            if (this.hasVal)
            {
                output.WriteString(2, strArray[1], this.Val);
            }
        }

        public static StyleKeyVal DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override StyleKeyVal DefaultInstanceForType
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
                    if (this.hasVal)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(2, this.Val);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override StyleKeyVal ThisMessage
        {
            get
            {
                return this;
            }
        }

        public string Val
        {
            get
            {
                return this.val_;
            }
        }


        public sealed class Builder : GeneratedBuilderLite<StyleKeyVal, StyleKeyVal.Builder>
        {
            private StyleKeyVal result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = StyleKeyVal.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(StyleKeyVal cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override StyleKeyVal BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override StyleKeyVal.Builder Clear()
            {
                this.result = StyleKeyVal.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public StyleKeyVal.Builder ClearKey()
            {
                this.PrepareBuilder();
                this.result.hasKey = false;
                this.result.key_ = 0;
                return this;
            }

            public StyleKeyVal.Builder ClearVal()
            {
                this.PrepareBuilder();
                this.result.hasVal = false;
                this.result.val_ = "";
                return this;
            }

            public override StyleKeyVal.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new StyleKeyVal.Builder(this.result);
                }
                return new StyleKeyVal.Builder().MergeFrom(this.result);
            }

            public override StyleKeyVal.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override StyleKeyVal.Builder MergeFrom(IMessageLite other)
            {
                if (other is StyleKeyVal)
                {
                    return this.MergeFrom((StyleKeyVal) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override StyleKeyVal.Builder MergeFrom(StyleKeyVal other)
            {
                return this;
            }

            public override StyleKeyVal.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(StyleKeyVal._styleKeyValFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = StyleKeyVal._styleKeyValFieldTags[index];
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
                    this.result.hasVal = input.ReadString(ref this.result.val_);
                }
                return this;
            }

            private StyleKeyVal PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    StyleKeyVal result = this.result;
                    this.result = new StyleKeyVal();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public StyleKeyVal.Builder SetKey(uint value)
            {
                this.PrepareBuilder();
                this.result.hasKey = true;
                this.result.key_ = value;
                return this;
            }

            public StyleKeyVal.Builder SetVal(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasVal = true;
                this.result.val_ = value;
                return this;
            }

            public override StyleKeyVal DefaultInstanceForType
            {
                get
                {
                    return StyleKeyVal.DefaultInstance;
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

            protected override StyleKeyVal MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override StyleKeyVal.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }

            public string Val
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

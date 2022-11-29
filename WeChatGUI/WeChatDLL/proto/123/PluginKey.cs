namespace micromsg
{
    using Google.ProtocolBuffers;
    
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

    
    public sealed class PluginKey : GeneratedMessageLite<PluginKey, PluginKey.Builder>
    {
        private static readonly string[] _pluginKeyFieldNames = new string[] { "Id", "Key" };
        private static readonly uint[] _pluginKeyFieldTags = new uint[] { 0x10, 10 };
        private static readonly PluginKey defaultInstance = new PluginKey().MakeReadOnly();
        private bool hasId;
        private bool hasKey;
        private uint id_;
        public const int IdFieldNumber = 2;
        private string key_ = "";
        public const int KeyFieldNumber = 1;
        private int memoizedSerializedSize = -1;

        static PluginKey()
        {
            //object.ReferenceEquals(PluginKey.Descriptor, null);
        }

        private PluginKey()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(PluginKey prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            PluginKey key = obj as PluginKey;
            if (key == null)
            {
                return false;
            }
            if ((this.hasKey != key.hasKey) || (this.hasKey && !this.key_.Equals(key.key_)))
            {
                return false;
            }
            return ((this.hasId == key.hasId) && (!this.hasId || this.id_.Equals(key.id_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasKey)
            {
                hashCode ^= this.key_.GetHashCode();
            }
            if (this.hasId)
            {
                hashCode ^= this.id_.GetHashCode();
            }
            return hashCode;
        }

        private PluginKey MakeReadOnly()
        {
            return this;
        }

        public static PluginKey ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<PluginKey, Builder>.PrintField("Key", this.hasKey, this.key_, writer);
            GeneratedMessageLite<PluginKey, Builder>.PrintField("Id", this.hasId, this.id_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _pluginKeyFieldNames;
            if (this.hasKey)
            {
                output.WriteString(1, strArray[1], this.Key);
            }
            if (this.hasId)
            {
                output.WriteUInt32(2, strArray[0], this.Id);
            }
        }

        public static PluginKey DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override PluginKey DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public uint Id
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
                return true;
            }
        }

        public string Key
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
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(1, this.Key);
                    }
                    if (this.hasId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(2, this.Id);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override PluginKey ThisMessage
        {
            get
            {
                return this;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<PluginKey, PluginKey.Builder>
        {
            private PluginKey result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = PluginKey.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(PluginKey cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override PluginKey BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override PluginKey.Builder Clear()
            {
                this.result = PluginKey.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public PluginKey.Builder ClearId()
            {
                this.PrepareBuilder();
                this.result.hasId = false;
                this.result.id_ = 0;
                return this;
            }

            public PluginKey.Builder ClearKey()
            {
                this.PrepareBuilder();
                this.result.hasKey = false;
                this.result.key_ = "";
                return this;
            }

            public override PluginKey.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new PluginKey.Builder(this.result);
                }
                return new PluginKey.Builder().MergeFrom(this.result);
            }

            public override PluginKey.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override PluginKey.Builder MergeFrom(IMessageLite other)
            {
                if (other is PluginKey)
                {
                    return this.MergeFrom((PluginKey) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override PluginKey.Builder MergeFrom(PluginKey other)
            {
                return this;
            }

            public override PluginKey.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(PluginKey._pluginKeyFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = PluginKey._pluginKeyFieldTags[index];
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
                            this.result.hasKey = input.ReadString(ref this.result.key_);
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
                    this.result.hasId = input.ReadUInt32(ref this.result.id_);
                }
                return this;
            }

            private PluginKey PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    PluginKey result = this.result;
                    this.result = new PluginKey();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public PluginKey.Builder SetId(uint value)
            {
                this.PrepareBuilder();
                this.result.hasId = true;
                this.result.id_ = value;
                return this;
            }

            public PluginKey.Builder SetKey(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasKey = true;
                this.result.key_ = value;
                return this;
            }

            public override PluginKey DefaultInstanceForType
            {
                get
                {
                    return PluginKey.DefaultInstance;
                }
            }

            public uint Id
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

            public string Key
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

            protected override PluginKey MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override PluginKey.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


namespace micromsg
{
    using Google.ProtocolBuffers;
    using Google.ProtocolBuffers.Collections;
    
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    

    
    public sealed class PluginKeyList : GeneratedMessageLite<PluginKeyList, PluginKeyList.Builder>
    {
        private static readonly string[] _pluginKeyListFieldNames = new string[] { "Count", "List" };
        private static readonly uint[] _pluginKeyListFieldTags = new uint[] { 8, 0x12 };
        private uint count_;
        public const int CountFieldNumber = 1;
        private static readonly PluginKeyList defaultInstance = new PluginKeyList().MakeReadOnly();
        private bool hasCount;
        private PopsicleList<PluginKey> list_ = new PopsicleList<PluginKey>();
        public const int ListFieldNumber = 2;
        private int memoizedSerializedSize = -1;

        static PluginKeyList()
        {
            //object.ReferenceEquals(PluginKeyList.Descriptor, null);
        }

        private PluginKeyList()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(PluginKeyList prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            PluginKeyList list = obj as PluginKeyList;
            if (list == null)
            {
                return false;
            }
            if ((this.hasCount != list.hasCount) || (this.hasCount && !this.count_.Equals(list.count_)))
            {
                return false;
            }
            if (this.list_.Count != list.list_.Count)
            {
                return false;
            }
            for (int i = 0; i < this.list_.Count; i++)
            {
                if (!this.list_[i].Equals(list.list_[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasCount)
            {
                hashCode ^= this.count_.GetHashCode();
            }
            foreach (PluginKey key in this.list_)
            {
                hashCode ^= key.GetHashCode();
            }
            return hashCode;
        }

        public PluginKey GetList(int index)
        {
            return this.list_[index];
        }

        private PluginKeyList MakeReadOnly()
        {
            this.list_.MakeReadOnly();
            return this;
        }

        public static PluginKeyList ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<PluginKeyList, Builder>.PrintField("Count", this.hasCount, this.count_, writer);
            GeneratedMessageLite<PluginKeyList, Builder>.PrintField<PluginKey>("List", this.list_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _pluginKeyListFieldNames;
            if (this.hasCount)
            {
                output.WriteUInt32(1, strArray[0], this.Count);
            }
            if (this.list_.Count > 0)
            {
                output.WriteMessageArray<PluginKey>(2, strArray[1], this.list_);
            }
        }

        public uint Count
        {
            get
            {
                return this.count_;
            }
        }

        public static PluginKeyList DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override PluginKeyList DefaultInstanceForType
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
                if (!this.hasCount)
                {
                    return false;
                }
                return true;
            }
        }

        public int ListCount
        {
            get
            {
                return this.list_.Count;
            }
        }

        public IList<PluginKey> ListList
        {
            get
            {
                return this.list_;
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
                    if (this.hasCount)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(1, this.Count);
                    }
                    foreach (PluginKey key in this.ListList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(2, key);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override PluginKeyList ThisMessage
        {
            get
            {
                return this;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<PluginKeyList, PluginKeyList.Builder>
        {
            private PluginKeyList result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = PluginKeyList.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(PluginKeyList cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public PluginKeyList.Builder AddList(PluginKey value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.list_.Add(value);
                return this;
            }

            public PluginKeyList.Builder AddList(PluginKey.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.list_.Add(builderForValue.Build());
                return this;
            }

            public PluginKeyList.Builder AddRangeList(IEnumerable<PluginKey> values)
            {
                this.PrepareBuilder();
                this.result.list_.Add(values);
                return this;
            }

            public override PluginKeyList BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override PluginKeyList.Builder Clear()
            {
                this.result = PluginKeyList.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public PluginKeyList.Builder ClearCount()
            {
                this.PrepareBuilder();
                this.result.hasCount = false;
                this.result.count_ = 0;
                return this;
            }

            public PluginKeyList.Builder ClearList()
            {
                this.PrepareBuilder();
                this.result.list_.Clear();
                return this;
            }

            public override PluginKeyList.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new PluginKeyList.Builder(this.result);
                }
                return new PluginKeyList.Builder().MergeFrom(this.result);
            }

            public PluginKey GetList(int index)
            {
                return this.result.GetList(index);
            }

            public override PluginKeyList.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override PluginKeyList.Builder MergeFrom(IMessageLite other)
            {
                if (other is PluginKeyList)
                {
                    return this.MergeFrom((PluginKeyList) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override PluginKeyList.Builder MergeFrom(PluginKeyList other)
            {
                return this;
            }

            public override PluginKeyList.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(PluginKeyList._pluginKeyListFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = PluginKeyList._pluginKeyListFieldTags[index];
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
                            this.result.hasCount = input.ReadUInt32(ref this.result.count_);
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
                    input.ReadMessageArray<PluginKey>(num, str, this.result.list_, PluginKey.DefaultInstance, extensionRegistry);
                }
                return this;
            }

            private PluginKeyList PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    PluginKeyList result = this.result;
                    this.result = new PluginKeyList();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public PluginKeyList.Builder SetCount(uint value)
            {
                this.PrepareBuilder();
                this.result.hasCount = true;
                this.result.count_ = value;
                return this;
            }

            public PluginKeyList.Builder SetList(int index, PluginKey value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.list_[index] = value;
                return this;
            }

            public PluginKeyList.Builder SetList(int index, PluginKey.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.list_[index] = builderForValue.Build();
                return this;
            }

            public uint Count
            {
                get
                {
                    return this.result.Count;
                }
                set
                {
                    this.SetCount(value);
                }
            }

            public override PluginKeyList DefaultInstanceForType
            {
                get
                {
                    return PluginKeyList.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            public int ListCount
            {
                get
                {
                    return this.result.ListCount;
                }
            }

            public IPopsicleList<PluginKey> ListList
            {
                get
                {
                    return this.PrepareBuilder().list_;
                }
            }

            protected override PluginKeyList MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override PluginKeyList.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


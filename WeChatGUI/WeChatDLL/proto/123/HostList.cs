namespace micromsg
{
    using Google.ProtocolBuffers;
    using Google.ProtocolBuffers.Collections;
    
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    

    
    public sealed class HostList : GeneratedMessageLite<HostList, HostList.Builder>
    {
        private static readonly string[] _hostListFieldNames = new string[] { "Count", "List" };
        private static readonly uint[] _hostListFieldTags = new uint[] { 8, 0x12 };
        private uint count_;
        public const int CountFieldNumber = 1;
        private static readonly HostList defaultInstance = new HostList().MakeReadOnly();
        private bool hasCount;
        private PopsicleList<Host> list_ = new PopsicleList<Host>();
        public const int ListFieldNumber = 2;
        private int memoizedSerializedSize = -1;

        static HostList()
        {
           // object.ReferenceEquals(HostList.Descriptor, null);
        }

        private HostList()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(HostList prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            HostList list = obj as HostList;
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
            foreach (Host host in this.list_)
            {
                hashCode ^= host.GetHashCode();
            }
            return hashCode;
        }

        public Host GetList(int index)
        {
            return this.list_[index];
        }

        private HostList MakeReadOnly()
        {
            this.list_.MakeReadOnly();
            return this;
        }

        public static HostList ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<HostList, Builder>.PrintField("Count", this.hasCount, this.count_, writer);
            GeneratedMessageLite<HostList, Builder>.PrintField<Host>("List", this.list_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _hostListFieldNames;
            if (this.hasCount)
            {
                output.WriteUInt32(1, strArray[0], this.Count);
            }
            if (this.list_.Count > 0)
            {
                output.WriteMessageArray<Host>(2, strArray[1], this.list_);
            }
        }

        public uint Count
        {
            get
            {
                return this.count_;
            }
        }

        public static HostList DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override HostList DefaultInstanceForType
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

        public IList<Host> ListList
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
                    foreach (Host host in this.ListList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(2, host);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override HostList ThisMessage
        {
            get
            {
                return this;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<HostList, HostList.Builder>
        {
            private HostList result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = HostList.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(HostList cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public HostList.Builder AddList(Host value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.list_.Add(value);
                return this;
            }

            public HostList.Builder AddList(Host.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.list_.Add(builderForValue.Build());
                return this;
            }

            public HostList.Builder AddRangeList(IEnumerable<Host> values)
            {
                this.PrepareBuilder();
                this.result.list_.Add(values);
                return this;
            }

            public override HostList BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override HostList.Builder Clear()
            {
                this.result = HostList.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public HostList.Builder ClearCount()
            {
                this.PrepareBuilder();
                this.result.hasCount = false;
                this.result.count_ = 0;
                return this;
            }

            public HostList.Builder ClearList()
            {
                this.PrepareBuilder();
                this.result.list_.Clear();
                return this;
            }

            public override HostList.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new HostList.Builder(this.result);
                }
                return new HostList.Builder().MergeFrom(this.result);
            }

            public Host GetList(int index)
            {
                return this.result.GetList(index);
            }

            public override HostList.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override HostList.Builder MergeFrom(IMessageLite other)
            {
                if (other is HostList)
                {
                    return this.MergeFrom((HostList) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override HostList.Builder MergeFrom(HostList other)
            {
                return this;
            }

            public override HostList.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(HostList._hostListFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = HostList._hostListFieldTags[index];
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
                    input.ReadMessageArray<Host>(num, str, this.result.list_, Host.DefaultInstance, extensionRegistry);
                }
                return this;
            }

            private HostList PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    HostList result = this.result;
                    this.result = new HostList();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public HostList.Builder SetCount(uint value)
            {
                this.PrepareBuilder();
                this.result.hasCount = true;
                this.result.count_ = value;
                return this;
            }

            public HostList.Builder SetList(int index, Host value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.list_[index] = value;
                return this;
            }

            public HostList.Builder SetList(int index, Host.Builder builderForValue)
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

            public override HostList DefaultInstanceForType
            {
                get
                {
                    return HostList.DefaultInstance;
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

            public IPopsicleList<Host> ListList
            {
                get
                {
                    return this.PrepareBuilder().list_;
                }
            }

            protected override HostList MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override HostList.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


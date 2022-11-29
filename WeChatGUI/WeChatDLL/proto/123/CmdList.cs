namespace micromsg
{
    using Google.ProtocolBuffers;
    using Google.ProtocolBuffers.Collections;
    
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    

    
    public sealed class CmdList : GeneratedMessageLite<CmdList, CmdList.Builder>
    {
        private static readonly string[] _cmdListFieldNames = new string[] { "Count", "List" };
        private static readonly uint[] _cmdListFieldTags = new uint[] { 8, 0x12 };
        private uint count_;
        public const int CountFieldNumber = 1;
        private static readonly CmdList defaultInstance = new CmdList().MakeReadOnly();
        private bool hasCount;
        private PopsicleList<CmdItem> list_ = new PopsicleList<CmdItem>();
        public const int ListFieldNumber = 2;
        private int memoizedSerializedSize = -1;

        static CmdList()
        {
            //object.ReferenceEquals(CmdList.Descriptor, null);
        }

        private CmdList()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(CmdList prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            CmdList list = obj as CmdList;
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
            foreach (CmdItem item in this.list_)
            {
                hashCode ^= item.GetHashCode();
            }
            return hashCode;
        }

        public CmdItem GetList(int index)
        {
            return this.list_[index];
        }

        private CmdList MakeReadOnly()
        {
            this.list_.MakeReadOnly();
            return this;
        }

        public static CmdList ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<CmdList, Builder>.PrintField("Count", this.hasCount, this.count_, writer);
            GeneratedMessageLite<CmdList, Builder>.PrintField<CmdItem>("List", this.list_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _cmdListFieldNames;
            if (this.hasCount)
            {
                output.WriteUInt32(1, strArray[0], this.Count);
            }
            if (this.list_.Count > 0)
            {
                output.WriteMessageArray<CmdItem>(2, strArray[1], this.list_);
            }
        }

        public uint Count
        {
            get
            {
                return this.count_;
            }
        }

        public static CmdList DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override CmdList DefaultInstanceForType
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
                foreach (CmdItem item in this.ListList)
                {
                    if (!item.IsInitialized)
                    {
                        return false;
                    }
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

        public IList<CmdItem> ListList
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
                    foreach (CmdItem item in this.ListList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(2, item);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override CmdList ThisMessage
        {
            get
            {
                return this;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<CmdList, CmdList.Builder>
        {
            private CmdList result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = CmdList.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(CmdList cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public CmdList.Builder AddList(CmdItem value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.list_.Add(value);
                return this;
            }

            public CmdList.Builder AddList(CmdItem.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.list_.Add(builderForValue.Build());
                return this;
            }

            public CmdList.Builder AddRangeList(IEnumerable<CmdItem> values)
            {
                this.PrepareBuilder();
                this.result.list_.Add(values);
                return this;
            }

            public override CmdList BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override CmdList.Builder Clear()
            {
                this.result = CmdList.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public CmdList.Builder ClearCount()
            {
                this.PrepareBuilder();
                this.result.hasCount = false;
                this.result.count_ = 0;
                return this;
            }

            public CmdList.Builder ClearList()
            {
                this.PrepareBuilder();
                this.result.list_.Clear();
                return this;
            }

            public override CmdList.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new CmdList.Builder(this.result);
                }
                return new CmdList.Builder().MergeFrom(this.result);
            }

            public CmdItem GetList(int index)
            {
                return this.result.GetList(index);
            }

            public override CmdList.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override CmdList.Builder MergeFrom(IMessageLite other)
            {
                if (other is CmdList)
                {
                    return this.MergeFrom((CmdList) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override CmdList.Builder MergeFrom(CmdList other)
            {
                return this;
            }

            public override CmdList.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(CmdList._cmdListFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = CmdList._cmdListFieldTags[index];
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
                    input.ReadMessageArray<CmdItem>(num, str, this.result.list_, CmdItem.DefaultInstance, extensionRegistry);
                }
                return this;
            }

            private CmdList PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    CmdList result = this.result;
                    this.result = new CmdList();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public CmdList.Builder SetCount(uint value)
            {
                this.PrepareBuilder();
                this.result.hasCount = true;
                this.result.count_ = value;
                return this;
            }

            public CmdList.Builder SetList(int index, CmdItem value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.list_[index] = value;
                return this;
            }

            public CmdList.Builder SetList(int index, CmdItem.Builder builderForValue)
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

            public override CmdList DefaultInstanceForType
            {
                get
                {
                    return CmdList.DefaultInstance;
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

            public IPopsicleList<CmdItem> ListList
            {
                get
                {
                    return this.PrepareBuilder().list_;
                }
            }

            protected override CmdList MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override CmdList.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


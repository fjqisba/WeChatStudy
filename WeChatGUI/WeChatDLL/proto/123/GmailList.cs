namespace micromsg
{
    using Google.ProtocolBuffers;
    using Google.ProtocolBuffers.Collections;
    
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    

    //
    public sealed class GmailList : GeneratedMessageLite<GmailList, GmailList.Builder>
    {
        private static readonly string[] _gmailListFieldNames = new string[] { "Count", "List" };
        private static readonly uint[] _gmailListFieldTags = new uint[] { 8, 0x12 };
        private uint count_;
        public const int CountFieldNumber = 1;
        private static readonly GmailList defaultInstance = new GmailList().MakeReadOnly();
        private bool hasCount;
        private PopsicleList<GmailInfo> list_ = new PopsicleList<GmailInfo>();
        public const int ListFieldNumber = 2;
        private int memoizedSerializedSize = -1;

        static GmailList()
        {
            //object.ReferenceEquals(GmailList.Descriptor, null);
        }

        private GmailList()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(GmailList prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            GmailList list = obj as GmailList;
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
            foreach (GmailInfo info in this.list_)
            {
                hashCode ^= info.GetHashCode();
            }
            return hashCode;
        }

        public GmailInfo GetList(int index)
        {
            return this.list_[index];
        }

        private GmailList MakeReadOnly()
        {
            this.list_.MakeReadOnly();
            return this;
        }

        public static GmailList ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<GmailList, Builder>.PrintField("Count", this.hasCount, this.count_, writer);
            GeneratedMessageLite<GmailList, Builder>.PrintField<GmailInfo>("List", this.list_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _gmailListFieldNames;
            if (this.hasCount)
            {
                output.WriteUInt32(1, strArray[0], this.Count);
            }
            if (this.list_.Count > 0)
            {
                output.WriteMessageArray<GmailInfo>(2, strArray[1], this.list_);
            }
        }

        public uint Count
        {
            get
            {
                return this.count_;
            }
        }

        public static GmailList DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override GmailList DefaultInstanceForType
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
                foreach (GmailInfo info in this.ListList)
                {
                    if (!info.IsInitialized)
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

        public IList<GmailInfo> ListList
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
                    foreach (GmailInfo info in this.ListList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(2, info);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override GmailList ThisMessage
        {
            get
            {
                return this;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<GmailList, GmailList.Builder>
        {
            private GmailList result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = GmailList.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(GmailList cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public GmailList.Builder AddList(GmailInfo value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.list_.Add(value);
                return this;
            }

            public GmailList.Builder AddList(GmailInfo.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.list_.Add(builderForValue.Build());
                return this;
            }

            public GmailList.Builder AddRangeList(IEnumerable<GmailInfo> values)
            {
                this.PrepareBuilder();
                this.result.list_.Add(values);
                return this;
            }

            public override GmailList BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override GmailList.Builder Clear()
            {
                this.result = GmailList.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public GmailList.Builder ClearCount()
            {
                this.PrepareBuilder();
                this.result.hasCount = false;
                this.result.count_ = 0;
                return this;
            }

            public GmailList.Builder ClearList()
            {
                this.PrepareBuilder();
                this.result.list_.Clear();
                return this;
            }

            public override GmailList.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new GmailList.Builder(this.result);
                }
                return new GmailList.Builder().MergeFrom(this.result);
            }

            public GmailInfo GetList(int index)
            {
                return this.result.GetList(index);
            }

            public override GmailList.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override GmailList.Builder MergeFrom(IMessageLite other)
            {
                if (other is GmailList)
                {
                    return this.MergeFrom((GmailList) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override GmailList.Builder MergeFrom(GmailList other)
            {
                return this;
            }

            public override GmailList.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(GmailList._gmailListFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = GmailList._gmailListFieldTags[index];
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
                    input.ReadMessageArray<GmailInfo>(num, str, this.result.list_, GmailInfo.DefaultInstance, extensionRegistry);
                }
                return this;
            }

            private GmailList PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    GmailList result = this.result;
                    this.result = new GmailList();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public GmailList.Builder SetCount(uint value)
            {
                this.PrepareBuilder();
                this.result.hasCount = true;
                this.result.count_ = value;
                return this;
            }

            public GmailList.Builder SetList(int index, GmailInfo value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.list_[index] = value;
                return this;
            }

            public GmailList.Builder SetList(int index, GmailInfo.Builder builderForValue)
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

            public override GmailList DefaultInstanceForType
            {
                get
                {
                    return GmailList.DefaultInstance;
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

            public IPopsicleList<GmailInfo> ListList
            {
                get
                {
                    return this.PrepareBuilder().list_;
                }
            }

            protected override GmailList MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override GmailList.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


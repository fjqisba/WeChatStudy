namespace micromsg
{
    using Google.ProtocolBuffers;
    using Google.ProtocolBuffers.Collections;
    
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    

    
    public sealed class BuiltinIPList : GeneratedMessageLite<BuiltinIPList, BuiltinIPList.Builder>
    {
        private static readonly string[] _builtinIPListFieldNames = new string[] { "LongConnectIPCount", "LongConnectIPList", "Seq", "ShortConnectIPCount", "ShortConnectIPList" };
        private static readonly uint[] _builtinIPListFieldTags = new uint[] { 8, 0x1a, 40, 0x10, 0x22 };
        private static readonly BuiltinIPList defaultInstance = new BuiltinIPList().MakeReadOnly();
        private bool hasLongConnectIPCount;
        private bool hasSeq;
        private bool hasShortConnectIPCount;
        private uint longConnectIPCount_;
        public const int LongConnectIPCountFieldNumber = 1;
        private PopsicleList<BuiltinIP> longConnectIPList_ = new PopsicleList<BuiltinIP>();
        public const int LongConnectIPListFieldNumber = 3;
        private int memoizedSerializedSize = -1;
        private uint seq_;
        public const int SeqFieldNumber = 5;
        private uint shortConnectIPCount_;
        public const int ShortConnectIPCountFieldNumber = 2;
        private PopsicleList<BuiltinIP> shortConnectIPList_ = new PopsicleList<BuiltinIP>();
        public const int ShortConnectIPListFieldNumber = 4;

        static BuiltinIPList()
        {
            //object.ReferenceEquals(BuiltinIPList.Descriptor, null);
        }

        private BuiltinIPList()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(BuiltinIPList prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            BuiltinIPList list = obj as BuiltinIPList;
            if (list == null)
            {
                return false;
            }
            if ((this.hasLongConnectIPCount != list.hasLongConnectIPCount) || (this.hasLongConnectIPCount && !this.longConnectIPCount_.Equals(list.longConnectIPCount_)))
            {
                return false;
            }
            if ((this.hasShortConnectIPCount != list.hasShortConnectIPCount) || (this.hasShortConnectIPCount && !this.shortConnectIPCount_.Equals(list.shortConnectIPCount_)))
            {
                return false;
            }
            if ((this.hasSeq != list.hasSeq) || (this.hasSeq && !this.seq_.Equals(list.seq_)))
            {
                return false;
            }
            if (this.longConnectIPList_.Count != list.longConnectIPList_.Count)
            {
                return false;
            }
            for (int i = 0; i < this.longConnectIPList_.Count; i++)
            {
                if (!this.longConnectIPList_[i].Equals(list.longConnectIPList_[i]))
                {
                    return false;
                }
            }
            if (this.shortConnectIPList_.Count != list.shortConnectIPList_.Count)
            {
                return false;
            }
            for (int j = 0; j < this.shortConnectIPList_.Count; j++)
            {
                if (!this.shortConnectIPList_[j].Equals(list.shortConnectIPList_[j]))
                {
                    return false;
                }
            }
            return true;
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasLongConnectIPCount)
            {
                hashCode ^= this.longConnectIPCount_.GetHashCode();
            }
            if (this.hasShortConnectIPCount)
            {
                hashCode ^= this.shortConnectIPCount_.GetHashCode();
            }
            if (this.hasSeq)
            {
                hashCode ^= this.seq_.GetHashCode();
            }
            foreach (BuiltinIP nip in this.longConnectIPList_)
            {
                hashCode ^= nip.GetHashCode();
            }
            foreach (BuiltinIP nip2 in this.shortConnectIPList_)
            {
                hashCode ^= nip2.GetHashCode();
            }
            return hashCode;
        }

        public BuiltinIP GetLongConnectIPList(int index)
        {
            return this.longConnectIPList_[index];
        }

        public BuiltinIP GetShortConnectIPList(int index)
        {
            return this.shortConnectIPList_[index];
        }

        private BuiltinIPList MakeReadOnly()
        {
            this.longConnectIPList_.MakeReadOnly();
            this.shortConnectIPList_.MakeReadOnly();
            return this;
        }

        public static BuiltinIPList ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<BuiltinIPList, Builder>.PrintField("LongConnectIPCount", this.hasLongConnectIPCount, this.longConnectIPCount_, writer);
            GeneratedMessageLite<BuiltinIPList, Builder>.PrintField("ShortConnectIPCount", this.hasShortConnectIPCount, this.shortConnectIPCount_, writer);
            GeneratedMessageLite<BuiltinIPList, Builder>.PrintField<BuiltinIP>("LongConnectIPList", this.longConnectIPList_, writer);
            GeneratedMessageLite<BuiltinIPList, Builder>.PrintField<BuiltinIP>("ShortConnectIPList", this.shortConnectIPList_, writer);
            GeneratedMessageLite<BuiltinIPList, Builder>.PrintField("Seq", this.hasSeq, this.seq_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _builtinIPListFieldNames;
            if (this.hasLongConnectIPCount)
            {
                output.WriteUInt32(1, strArray[0], this.LongConnectIPCount);
            }
            if (this.hasShortConnectIPCount)
            {
                output.WriteUInt32(2, strArray[3], this.ShortConnectIPCount);
            }
            if (this.longConnectIPList_.Count > 0)
            {
                output.WriteMessageArray<BuiltinIP>(3, strArray[1], this.longConnectIPList_);
            }
            if (this.shortConnectIPList_.Count > 0)
            {
                output.WriteMessageArray<BuiltinIP>(4, strArray[4], this.shortConnectIPList_);
            }
            if (this.hasSeq)
            {
                output.WriteUInt32(5, strArray[2], this.Seq);
            }
        }

        public static BuiltinIPList DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override BuiltinIPList DefaultInstanceForType
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
                if (!this.hasLongConnectIPCount)
                {
                    return false;
                }
                if (!this.hasShortConnectIPCount)
                {
                    return false;
                }
                if (!this.hasSeq)
                {
                    return false;
                }
                foreach (BuiltinIP nip in this.LongConnectIPListList)
                {
                    if (!nip.IsInitialized)
                    {
                        return false;
                    }
                }
                foreach (BuiltinIP nip2 in this.ShortConnectIPListList)
                {
                    if (!nip2.IsInitialized)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public uint LongConnectIPCount
        {
            get
            {
                return this.longConnectIPCount_;
            }
        }

        public int LongConnectIPListCount
        {
            get
            {
                return this.longConnectIPList_.Count;
            }
        }

        public IList<BuiltinIP> LongConnectIPListList
        {
            get
            {
                return this.longConnectIPList_;
            }
        }

        public uint Seq
        {
            get
            {
                return this.seq_;
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
                    if (this.hasLongConnectIPCount)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(1, this.LongConnectIPCount);
                    }
                    if (this.hasShortConnectIPCount)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(2, this.ShortConnectIPCount);
                    }
                    if (this.hasSeq)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(5, this.Seq);
                    }
                    foreach (BuiltinIP nip in this.LongConnectIPListList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(3, nip);
                    }
                    foreach (BuiltinIP nip2 in this.ShortConnectIPListList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(4, nip2);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        public uint ShortConnectIPCount
        {
            get
            {
                return this.shortConnectIPCount_;
            }
        }

        public int ShortConnectIPListCount
        {
            get
            {
                return this.shortConnectIPList_.Count;
            }
        }

        public IList<BuiltinIP> ShortConnectIPListList
        {
            get
            {
                return this.shortConnectIPList_;
            }
        }

        protected override BuiltinIPList ThisMessage
        {
            get
            {
                return this;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<BuiltinIPList, BuiltinIPList.Builder>
        {
            private BuiltinIPList result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = BuiltinIPList.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(BuiltinIPList cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public BuiltinIPList.Builder AddLongConnectIPList(BuiltinIP value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.longConnectIPList_.Add(value);
                return this;
            }

            public BuiltinIPList.Builder AddLongConnectIPList(BuiltinIP.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.longConnectIPList_.Add(builderForValue.Build());
                return this;
            }

            public BuiltinIPList.Builder AddRangeLongConnectIPList(IEnumerable<BuiltinIP> values)
            {
                this.PrepareBuilder();
                this.result.longConnectIPList_.Add(values);
                return this;
            }

            public BuiltinIPList.Builder AddRangeShortConnectIPList(IEnumerable<BuiltinIP> values)
            {
                this.PrepareBuilder();
                this.result.shortConnectIPList_.Add(values);
                return this;
            }

            public BuiltinIPList.Builder AddShortConnectIPList(BuiltinIP value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.shortConnectIPList_.Add(value);
                return this;
            }

            public BuiltinIPList.Builder AddShortConnectIPList(BuiltinIP.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.shortConnectIPList_.Add(builderForValue.Build());
                return this;
            }

            public override BuiltinIPList BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override BuiltinIPList.Builder Clear()
            {
                this.result = BuiltinIPList.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public BuiltinIPList.Builder ClearLongConnectIPCount()
            {
                this.PrepareBuilder();
                this.result.hasLongConnectIPCount = false;
                this.result.longConnectIPCount_ = 0;
                return this;
            }

            public BuiltinIPList.Builder ClearLongConnectIPList()
            {
                this.PrepareBuilder();
                this.result.longConnectIPList_.Clear();
                return this;
            }

            public BuiltinIPList.Builder ClearSeq()
            {
                this.PrepareBuilder();
                this.result.hasSeq = false;
                this.result.seq_ = 0;
                return this;
            }

            public BuiltinIPList.Builder ClearShortConnectIPCount()
            {
                this.PrepareBuilder();
                this.result.hasShortConnectIPCount = false;
                this.result.shortConnectIPCount_ = 0;
                return this;
            }

            public BuiltinIPList.Builder ClearShortConnectIPList()
            {
                this.PrepareBuilder();
                this.result.shortConnectIPList_.Clear();
                return this;
            }

            public override BuiltinIPList.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new BuiltinIPList.Builder(this.result);
                }
                return new BuiltinIPList.Builder().MergeFrom(this.result);
            }

            public BuiltinIP GetLongConnectIPList(int index)
            {
                return this.result.GetLongConnectIPList(index);
            }

            public BuiltinIP GetShortConnectIPList(int index)
            {
                return this.result.GetShortConnectIPList(index);
            }

            public override BuiltinIPList.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override BuiltinIPList.Builder MergeFrom(IMessageLite other)
            {
                if (other is BuiltinIPList)
                {
                    return this.MergeFrom((BuiltinIPList) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override BuiltinIPList.Builder MergeFrom(BuiltinIPList other)
            {
                return this;
            }

            public override BuiltinIPList.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(BuiltinIPList._builtinIPListFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = BuiltinIPList._builtinIPListFieldTags[index];
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
                            this.result.hasLongConnectIPCount = input.ReadUInt32(ref this.result.longConnectIPCount_);
                            continue;
                        }
                        case 0x10:
                        {
                            this.result.hasShortConnectIPCount = input.ReadUInt32(ref this.result.shortConnectIPCount_);
                            continue;
                        }
                        case 0x1a:
                        {
                            input.ReadMessageArray<BuiltinIP>(num, str, this.result.longConnectIPList_, BuiltinIP.DefaultInstance, extensionRegistry);
                            continue;
                        }
                        case 0x22:
                        {
                            input.ReadMessageArray<BuiltinIP>(num, str, this.result.shortConnectIPList_, BuiltinIP.DefaultInstance, extensionRegistry);
                            continue;
                        }
                        case 40:
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
                    this.result.hasSeq = input.ReadUInt32(ref this.result.seq_);
                }
                return this;
            }

            private BuiltinIPList PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    BuiltinIPList result = this.result;
                    this.result = new BuiltinIPList();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public BuiltinIPList.Builder SetLongConnectIPCount(uint value)
            {
                this.PrepareBuilder();
                this.result.hasLongConnectIPCount = true;
                this.result.longConnectIPCount_ = value;
                return this;
            }

            public BuiltinIPList.Builder SetLongConnectIPList(int index, BuiltinIP value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.longConnectIPList_[index] = value;
                return this;
            }

            public BuiltinIPList.Builder SetLongConnectIPList(int index, BuiltinIP.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.longConnectIPList_[index] = builderForValue.Build();
                return this;
            }

            public BuiltinIPList.Builder SetSeq(uint value)
            {
                this.PrepareBuilder();
                this.result.hasSeq = true;
                this.result.seq_ = value;
                return this;
            }

            public BuiltinIPList.Builder SetShortConnectIPCount(uint value)
            {
                this.PrepareBuilder();
                this.result.hasShortConnectIPCount = true;
                this.result.shortConnectIPCount_ = value;
                return this;
            }

            public BuiltinIPList.Builder SetShortConnectIPList(int index, BuiltinIP value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.shortConnectIPList_[index] = value;
                return this;
            }

            public BuiltinIPList.Builder SetShortConnectIPList(int index, BuiltinIP.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.shortConnectIPList_[index] = builderForValue.Build();
                return this;
            }

            public override BuiltinIPList DefaultInstanceForType
            {
                get
                {
                    return BuiltinIPList.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            public uint LongConnectIPCount
            {
                get
                {
                    return this.result.LongConnectIPCount;
                }
                set
                {
                    this.SetLongConnectIPCount(value);
                }
            }

            public int LongConnectIPListCount
            {
                get
                {
                    return this.result.LongConnectIPListCount;
                }
            }

            public IPopsicleList<BuiltinIP> LongConnectIPListList
            {
                get
                {
                    return this.PrepareBuilder().longConnectIPList_;
                }
            }

            protected override BuiltinIPList MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public uint Seq
            {
                get
                {
                    return this.result.Seq;
                }
                set
                {
                    this.SetSeq(value);
                }
            }

            public uint ShortConnectIPCount
            {
                get
                {
                    return this.result.ShortConnectIPCount;
                }
                set
                {
                    this.SetShortConnectIPCount(value);
                }
            }

            public int ShortConnectIPListCount
            {
                get
                {
                    return this.result.ShortConnectIPListCount;
                }
            }

            public IPopsicleList<BuiltinIP> ShortConnectIPListList
            {
                get
                {
                    return this.PrepareBuilder().shortConnectIPList_;
                }
            }

            protected override BuiltinIPList.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


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
    public sealed class KVStatOpLog : GeneratedMessageLite<KVStatOpLog, KVStatOpLog.Builder>
    {
        private static readonly string[] _kVStatOpLogFieldNames = new string[] { "Count", "List" };
        private static readonly uint[] _kVStatOpLogFieldTags = new uint[] { 8, 0x12 };
        private uint count_;
        public const int CountFieldNumber = 1;
        private static readonly KVStatOpLog defaultInstance = new KVStatOpLog().MakeReadOnly();
        private bool hasCount;
        private PopsicleList<KVStatItem> list_ = new PopsicleList<KVStatItem>();
        public const int ListFieldNumber = 2;
        private int memoizedSerializedSize = -1;

        static KVStatOpLog()
        {
            //object.ReferenceEquals(KVStatOpLog.Descriptor, null);
        }

        private KVStatOpLog()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(KVStatOpLog prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            KVStatOpLog log = obj as KVStatOpLog;
            if (log == null)
            {
                return false;
            }
            if ((this.hasCount != log.hasCount) || (this.hasCount && !this.count_.Equals(log.count_)))
            {
                return false;
            }
            if (this.list_.Count != log.list_.Count)
            {
                return false;
            }
            for (int i = 0; i < this.list_.Count; i++)
            {
                if (!this.list_[i].Equals(log.list_[i]))
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
            foreach (KVStatItem item in this.list_)
            {
                hashCode ^= item.GetHashCode();
            }
            return hashCode;
        }

        public KVStatItem GetList(int index)
        {
            return this.list_[index];
        }

        private KVStatOpLog MakeReadOnly()
        {
            this.list_.MakeReadOnly();
            return this;
        }

        public static KVStatOpLog ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<KVStatOpLog, Builder>.PrintField("Count", this.hasCount, this.count_, writer);
            GeneratedMessageLite<KVStatOpLog, Builder>.PrintField<KVStatItem>("List", this.list_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _kVStatOpLogFieldNames;
            if (this.hasCount)
            {
                output.WriteUInt32(1, strArray[0], this.Count);
            }
            if (this.list_.Count > 0)
            {
                output.WriteMessageArray<KVStatItem>(2, strArray[1], this.list_);
            }
        }

        public uint Count
        {
            get
            {
                return this.count_;
            }
        }

        public static KVStatOpLog DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override KVStatOpLog DefaultInstanceForType
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
                foreach (KVStatItem item in this.ListList)
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

        public IList<KVStatItem> ListList
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
                    foreach (KVStatItem item in this.ListList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(2, item);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override KVStatOpLog ThisMessage
        {
            get
            {
                return this;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<KVStatOpLog, KVStatOpLog.Builder>
        {
            private KVStatOpLog result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = KVStatOpLog.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(KVStatOpLog cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public KVStatOpLog.Builder AddList(KVStatItem value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.list_.Add(value);
                return this;
            }

            public KVStatOpLog.Builder AddList(KVStatItem.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.list_.Add(builderForValue.Build());
                return this;
            }

            public KVStatOpLog.Builder AddRangeList(IEnumerable<KVStatItem> values)
            {
                this.PrepareBuilder();
                this.result.list_.Add(values);
                return this;
            }

            public override KVStatOpLog BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override KVStatOpLog.Builder Clear()
            {
                this.result = KVStatOpLog.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public KVStatOpLog.Builder ClearCount()
            {
                this.PrepareBuilder();
                this.result.hasCount = false;
                this.result.count_ = 0;
                return this;
            }

            public KVStatOpLog.Builder ClearList()
            {
                this.PrepareBuilder();
                this.result.list_.Clear();
                return this;
            }

            public override KVStatOpLog.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new KVStatOpLog.Builder(this.result);
                }
                return new KVStatOpLog.Builder().MergeFrom(this.result);
            }

            public KVStatItem GetList(int index)
            {
                return this.result.GetList(index);
            }

            public override KVStatOpLog.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override KVStatOpLog.Builder MergeFrom(IMessageLite other)
            {
                if (other is KVStatOpLog)
                {
                    return this.MergeFrom((KVStatOpLog) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override KVStatOpLog.Builder MergeFrom(KVStatOpLog other)
            {
                return this;
            }

            public override KVStatOpLog.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(KVStatOpLog._kVStatOpLogFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = KVStatOpLog._kVStatOpLogFieldTags[index];
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
                    input.ReadMessageArray<KVStatItem>(num, str, this.result.list_, KVStatItem.DefaultInstance, extensionRegistry);
                }
                return this;
            }

            private KVStatOpLog PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    KVStatOpLog result = this.result;
                    this.result = new KVStatOpLog();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public KVStatOpLog.Builder SetCount(uint value)
            {
                this.PrepareBuilder();
                this.result.hasCount = true;
                this.result.count_ = value;
                return this;
            }

            public KVStatOpLog.Builder SetList(int index, KVStatItem value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.list_[index] = value;
                return this;
            }

            public KVStatOpLog.Builder SetList(int index, KVStatItem.Builder builderForValue)
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

            public override KVStatOpLog DefaultInstanceForType
            {
                get
                {
                    return KVStatOpLog.DefaultInstance;
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

            public IPopsicleList<KVStatItem> ListList
            {
                get
                {
                    return this.PrepareBuilder().list_;
                }
            }

            protected override KVStatOpLog MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override KVStatOpLog.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


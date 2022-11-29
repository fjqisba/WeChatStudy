namespace micromsg
{
    using Google.ProtocolBuffers;
    using Google.ProtocolBuffers.Collections;

    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Runtime.CompilerServices;


    public sealed class SendMsgRequestNew : GeneratedMessageLite<SendMsgRequestNew, SendMsgRequestNew.Builder>
    {
        private static readonly string[] _sendMsgRequestNewFieldNames = new string[] { "Count", "List" };
        private static readonly uint[] _sendMsgRequestNewFieldTags = new uint[] { 8, 0x12 };
        private uint count_;
        public const int CountFieldNumber = 1;
        private static readonly SendMsgRequestNew defaultInstance = new SendMsgRequestNew().MakeReadOnly();
        private bool hasCount;
        private PopsicleList<MicroMsgRequestNew> list_ = new PopsicleList<MicroMsgRequestNew>();
        public const int ListFieldNumber = 2;
        private int memoizedSerializedSize = -1;

        static SendMsgRequestNew()
        {
           
        }

        private SendMsgRequestNew()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(SendMsgRequestNew prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            SendMsgRequestNew new2 = obj as SendMsgRequestNew;
            if (new2 == null)
            {
                return false;
            }
            if ((this.hasCount != new2.hasCount) || (this.hasCount && !this.count_.Equals(new2.count_)))
            {
                return false;
            }
            if (this.list_.Count != new2.list_.Count)
            {
                return false;
            }
            for (int i = 0; i < this.list_.Count; i++)
            {
                if (!this.list_[i].Equals(new2.list_[i]))
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
            foreach (MicroMsgRequestNew new2 in this.list_)
            {
                hashCode ^= new2.GetHashCode();
            }
            return hashCode;
        }

        public MicroMsgRequestNew GetList(int index)
        {
            return this.list_[index];
        }

        private SendMsgRequestNew MakeReadOnly()
        {
            this.list_.MakeReadOnly();
            return this;
        }

        public static SendMsgRequestNew ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<SendMsgRequestNew, Builder>.PrintField("Count", this.hasCount, this.count_, writer);
            GeneratedMessageLite<SendMsgRequestNew, Builder>.PrintField<MicroMsgRequestNew>("List", this.list_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _sendMsgRequestNewFieldNames;
            if (this.hasCount)
            {
                output.WriteUInt32(1, strArray[0], this.Count);
            }
            if (this.list_.Count > 0)
            {
                output.WriteMessageArray<MicroMsgRequestNew>(2, strArray[1], this.list_);
            }
        }

        public uint Count
        {
            get
            {
                return this.count_;
            }
        }

        public static SendMsgRequestNew DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override SendMsgRequestNew DefaultInstanceForType
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
                foreach (MicroMsgRequestNew new2 in this.ListList)
                {
                    if (!new2.IsInitialized)
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

        public IList<MicroMsgRequestNew> ListList
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
                    foreach (MicroMsgRequestNew new2 in this.ListList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(2, new2);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override SendMsgRequestNew ThisMessage
        {
            get
            {
                return this;
            }
        }

        [GeneratedCode("ProtoGen", "2.3.0.277"), CompilerGenerated, DebuggerNonUserCode]
        public sealed class Builder : GeneratedBuilderLite<SendMsgRequestNew, SendMsgRequestNew.Builder>
        {
            private SendMsgRequestNew result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = SendMsgRequestNew.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(SendMsgRequestNew cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public SendMsgRequestNew.Builder AddList(MicroMsgRequestNew value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.list_.Add(value);
                return this;
            }

            public SendMsgRequestNew.Builder AddList(MicroMsgRequestNew.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.list_.Add(builderForValue.Build());
                return this;
            }

            public SendMsgRequestNew.Builder AddRangeList(IEnumerable<MicroMsgRequestNew> values)
            {
                this.PrepareBuilder();
                this.result.list_.Add(values);
                return this;
            }

            public override SendMsgRequestNew BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override SendMsgRequestNew.Builder Clear()
            {
                this.result = SendMsgRequestNew.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public SendMsgRequestNew.Builder ClearCount()
            {
                this.PrepareBuilder();
                this.result.hasCount = false;
                this.result.count_ = 0;
                return this;
            }

            public SendMsgRequestNew.Builder ClearList()
            {
                this.PrepareBuilder();
                this.result.list_.Clear();
                return this;
            }

            public override SendMsgRequestNew.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new SendMsgRequestNew.Builder(this.result);
                }
                return new SendMsgRequestNew.Builder().MergeFrom(this.result);
            }

            public MicroMsgRequestNew GetList(int index)
            {
                return this.result.GetList(index);
            }

            public override SendMsgRequestNew.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override SendMsgRequestNew.Builder MergeFrom(IMessageLite other)
            {
                if (other is SendMsgRequestNew)
                {
                    return this.MergeFrom((SendMsgRequestNew) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override SendMsgRequestNew.Builder MergeFrom(SendMsgRequestNew other)
            {
                return this;
            }

            public override SendMsgRequestNew.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(SendMsgRequestNew._sendMsgRequestNewFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = SendMsgRequestNew._sendMsgRequestNewFieldTags[index];
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
                    input.ReadMessageArray<MicroMsgRequestNew>(num, str, this.result.list_, MicroMsgRequestNew.DefaultInstance, extensionRegistry);
                }
                return this;
            }

            private SendMsgRequestNew PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    SendMsgRequestNew result = this.result;
                    this.result = new SendMsgRequestNew();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public SendMsgRequestNew.Builder SetCount(uint value)
            {
                this.PrepareBuilder();
                this.result.hasCount = true;
                this.result.count_ = value;
                return this;
            }

            public SendMsgRequestNew.Builder SetList(int index, MicroMsgRequestNew value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.list_[index] = value;
                return this;
            }

            public SendMsgRequestNew.Builder SetList(int index, MicroMsgRequestNew.Builder builderForValue)
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

            public override SendMsgRequestNew DefaultInstanceForType
            {
                get
                {
                    return SendMsgRequestNew.DefaultInstance;
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

            public IPopsicleList<MicroMsgRequestNew> ListList
            {
                get
                {
                    return this.PrepareBuilder().list_;
                }
            }

            protected override SendMsgRequestNew MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override SendMsgRequestNew.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}

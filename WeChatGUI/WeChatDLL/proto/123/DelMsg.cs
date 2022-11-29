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
    public sealed class DelMsg : GeneratedMessageLite<DelMsg, DelMsg.Builder>
    {
        private static readonly string[] _delMsgFieldNames = new string[] { "Count", "MsgIdList", "UserName" };
        private static readonly uint[] _delMsgFieldTags = new uint[] { 0x10, 0x1a, 10 };
        private uint count_;
        public const int CountFieldNumber = 2;
        private static readonly DelMsg defaultInstance = new DelMsg().MakeReadOnly();
        private bool hasCount;
        private bool hasUserName;
        private int memoizedSerializedSize = -1;
        private PopsicleList<int> msgIdList_ = new PopsicleList<int>();
        public const int MsgIdListFieldNumber = 3;
        private int msgIdListMemoizedSerializedSize;
        private SKBuiltinString_t userName_;
        public const int UserNameFieldNumber = 1;

        static DelMsg()
        {
            //object.ReferenceEquals(DelMsg.Descriptor, null);
        }

        private DelMsg()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(DelMsg prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            DelMsg msg = obj as DelMsg;
            if (msg == null)
            {
                return false;
            }
            if ((this.hasUserName != msg.hasUserName) || (this.hasUserName && !this.userName_.Equals(msg.userName_)))
            {
                return false;
            }
            if ((this.hasCount != msg.hasCount) || (this.hasCount && !this.count_.Equals(msg.count_)))
            {
                return false;
            }
            if (this.msgIdList_.Count != msg.msgIdList_.Count)
            {
                return false;
            }
            for (int i = 0; i < this.msgIdList_.Count; i++)
            {
                int num2 = this.msgIdList_[i];
                if (!num2.Equals(msg.msgIdList_[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasUserName)
            {
                hashCode ^= this.userName_.GetHashCode();
            }
            if (this.hasCount)
            {
                hashCode ^= this.count_.GetHashCode();
            }
            foreach (int num2 in this.msgIdList_)
            {
                hashCode ^= num2.GetHashCode();
            }
            return hashCode;
        }

        public int GetMsgIdList(int index)
        {
            return this.msgIdList_[index];
        }

        private DelMsg MakeReadOnly()
        {
            this.msgIdList_.MakeReadOnly();
            return this;
        }

        public static DelMsg ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<DelMsg, Builder>.PrintField("UserName", this.hasUserName, this.userName_, writer);
            GeneratedMessageLite<DelMsg, Builder>.PrintField("Count", this.hasCount, this.count_, writer);
            GeneratedMessageLite<DelMsg, Builder>.PrintField<int>("MsgIdList", this.msgIdList_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _delMsgFieldNames;
            if (this.hasUserName)
            {
                output.WriteMessage(1, strArray[2], this.UserName);
            }
            if (this.hasCount)
            {
                output.WriteUInt32(2, strArray[0], this.Count);
            }
            if (this.msgIdList_.Count > 0)
            {
                output.WritePackedInt32Array(3, strArray[1], this.msgIdListMemoizedSerializedSize, this.msgIdList_);
            }
        }

        public uint Count
        {
            get
            {
                return this.count_;
            }
        }

        public static DelMsg DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override DelMsg DefaultInstanceForType
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
                if (!this.hasUserName)
                {
                    return false;
                }
                if (!this.hasCount)
                {
                    return false;
                }
                return true;
            }
        }

        public int MsgIdListCount
        {
            get
            {
                return this.msgIdList_.Count;
            }
        }

        public IList<int> MsgIdListList
        {
            get
            {
                return Lists.AsReadOnly<int>(this.msgIdList_);
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
                    if (this.hasUserName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(1, this.UserName);
                    }
                    if (this.hasCount)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(2, this.Count);
                    }
                    int num2 = 0;
                    foreach (int num3 in this.MsgIdListList)
                    {
                        num2 += CodedOutputStream.ComputeInt32SizeNoTag(num3);
                    }
                    memoizedSerializedSize += num2;
                    if (this.msgIdList_.Count != 0)
                    {
                        memoizedSerializedSize += 1 + CodedOutputStream.ComputeInt32SizeNoTag(num2);
                    }
                    this.msgIdListMemoizedSerializedSize = num2;
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override DelMsg ThisMessage
        {
            get
            {
                return this;
            }
        }

        public SKBuiltinString_t UserName
        {
            get
            {
                return (this.userName_ ?? SKBuiltinString_t.DefaultInstance);
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<DelMsg, DelMsg.Builder>
        {
            private DelMsg result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = DelMsg.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(DelMsg cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public DelMsg.Builder AddMsgIdList(int value)
            {
                this.PrepareBuilder();
                this.result.msgIdList_.Add(value);
                return this;
            }

            public DelMsg.Builder AddRangeMsgIdList(IEnumerable<int> values)
            {
                this.PrepareBuilder();
                this.result.msgIdList_.Add(values);
                return this;
            }

            public override DelMsg BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override DelMsg.Builder Clear()
            {
                this.result = DelMsg.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public DelMsg.Builder ClearCount()
            {
                this.PrepareBuilder();
                this.result.hasCount = false;
                this.result.count_ = 0;
                return this;
            }

            public DelMsg.Builder ClearMsgIdList()
            {
                this.PrepareBuilder();
                this.result.msgIdList_.Clear();
                return this;
            }

            public DelMsg.Builder ClearUserName()
            {
                this.PrepareBuilder();
                this.result.hasUserName = false;
                this.result.userName_ = null;
                return this;
            }

            public override DelMsg.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new DelMsg.Builder(this.result);
                }
                return new DelMsg.Builder().MergeFrom(this.result);
            }

            public int GetMsgIdList(int index)
            {
                return this.result.GetMsgIdList(index);
            }

            public override DelMsg.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override DelMsg.Builder MergeFrom(IMessageLite other)
            {
                if (other is DelMsg)
                {
                    return this.MergeFrom((DelMsg) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override DelMsg.Builder MergeFrom(DelMsg other)
            {
                return this;
            }

            public override DelMsg.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(DelMsg._delMsgFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = DelMsg._delMsgFieldTags[index];
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
                            SKBuiltinString_t.Builder builder = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasUserName)
                            {
                                builder.MergeFrom(this.UserName);
                            }
                            input.ReadMessage(builder, extensionRegistry);
                            this.UserName = builder.BuildPartial();
                            continue;
                        }
                        case 0x18:
                        case 0x1a:
                            break;

                        case 0x10:
                        {
                            this.result.hasCount = input.ReadUInt32(ref this.result.count_);
                            continue;
                        }
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
                    input.ReadInt32Array(num, str, this.result.msgIdList_);
                }
                return this;
            }

            public DelMsg.Builder MergeUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasUserName && (this.result.userName_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.userName_ = SKBuiltinString_t.CreateBuilder(this.result.userName_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.userName_ = value;
                }
                this.result.hasUserName = true;
                return this;
            }

            private DelMsg PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    DelMsg result = this.result;
                    this.result = new DelMsg();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public DelMsg.Builder SetCount(uint value)
            {
                this.PrepareBuilder();
                this.result.hasCount = true;
                this.result.count_ = value;
                return this;
            }

            public DelMsg.Builder SetMsgIdList(int index, int value)
            {
                this.PrepareBuilder();
                this.result.msgIdList_[index] = value;
                return this;
            }

            public DelMsg.Builder SetUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasUserName = true;
                this.result.userName_ = value;
                return this;
            }

            public DelMsg.Builder SetUserName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasUserName = true;
                this.result.userName_ = builderForValue.Build();
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

            public override DelMsg DefaultInstanceForType
            {
                get
                {
                    return DelMsg.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override DelMsg MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public int MsgIdListCount
            {
                get
                {
                    return this.result.MsgIdListCount;
                }
            }

            public IPopsicleList<int> MsgIdListList
            {
                get
                {
                    return this.PrepareBuilder().msgIdList_;
                }
            }

            protected override DelMsg.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }

            public SKBuiltinString_t UserName
            {
                get
                {
                    return this.result.UserName;
                }
                set
                {
                    this.SetUserName(value);
                }
            }
        }
    }
}


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


    public sealed class SendMsgResponseNew : GeneratedMessageLite<SendMsgResponseNew, SendMsgResponseNew.Builder>
    {
        private static readonly string[] _sendMsgResponseNewFieldNames = new string[] { "BaseResponse", "Count", "List" };
        private static readonly uint[] _sendMsgResponseNewFieldTags = new uint[] { 10, 0x10, 0x1a };
        private BaseResponse baseResponse_;
        public const int BaseResponseFieldNumber = 1;
        private uint count_;
        public const int CountFieldNumber = 2;
        private static readonly SendMsgResponseNew defaultInstance = new SendMsgResponseNew().MakeReadOnly();
        private bool hasBaseResponse;
        private bool hasCount;
        private PopsicleList<MicroMsgResponseNew> list_ = new PopsicleList<MicroMsgResponseNew>();
        public const int ListFieldNumber = 3;
        private int memoizedSerializedSize = -1;

        static SendMsgResponseNew()
        {
   
        }

        private SendMsgResponseNew()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(SendMsgResponseNew prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            SendMsgResponseNew new2 = obj as SendMsgResponseNew;
            if (new2 == null)
            {
                return false;
            }
            if ((this.hasBaseResponse != new2.hasBaseResponse) || (this.hasBaseResponse && !this.baseResponse_.Equals(new2.baseResponse_)))
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
            if (this.hasBaseResponse)
            {
                hashCode ^= this.baseResponse_.GetHashCode();
            }
            if (this.hasCount)
            {
                hashCode ^= this.count_.GetHashCode();
            }
            foreach (MicroMsgResponseNew new2 in this.list_)
            {
                hashCode ^= new2.GetHashCode();
            }
            return hashCode;
        }

        public MicroMsgResponseNew GetList(int index)
        {
            return this.list_[index];
        }

        private SendMsgResponseNew MakeReadOnly()
        {
            this.list_.MakeReadOnly();
            return this;
        }

        public static SendMsgResponseNew ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<SendMsgResponseNew, Builder>.PrintField("BaseResponse", this.hasBaseResponse, this.baseResponse_, writer);
            GeneratedMessageLite<SendMsgResponseNew, Builder>.PrintField("Count", this.hasCount, this.count_, writer);
            GeneratedMessageLite<SendMsgResponseNew, Builder>.PrintField<MicroMsgResponseNew>("List", this.list_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _sendMsgResponseNewFieldNames;
            if (this.hasBaseResponse)
            {
                output.WriteMessage(1, strArray[0], this.BaseResponse);
            }
            if (this.hasCount)
            {
                output.WriteUInt32(2, strArray[1], this.Count);
            }
            if (this.list_.Count > 0)
            {
                output.WriteMessageArray<MicroMsgResponseNew>(3, strArray[2], this.list_);
            }
        }

        public BaseResponse BaseResponse
        {
            get
            {
                return (this.baseResponse_ ?? BaseResponse.DefaultInstance);
            }
        }

        public uint Count
        {
            get
            {
                return this.count_;
            }
        }

        public static SendMsgResponseNew DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override SendMsgResponseNew DefaultInstanceForType
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
                if (!this.hasBaseResponse)
                {
                    return false;
                }
                if (!this.hasCount)
                {
                    return false;
                }
                if (!this.BaseResponse.IsInitialized)
                {
                    return false;
                }
                foreach (MicroMsgResponseNew new2 in this.ListList)
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

        public IList<MicroMsgResponseNew> ListList
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
                    if (this.hasBaseResponse)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(1, this.BaseResponse);
                    }
                    if (this.hasCount)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(2, this.Count);
                    }
                    foreach (MicroMsgResponseNew new2 in this.ListList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(3, new2);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override SendMsgResponseNew ThisMessage
        {
            get
            {
                return this;
            }
        }

        [DebuggerNonUserCode, GeneratedCode("ProtoGen", "2.3.0.277"), CompilerGenerated]
        public sealed class Builder : GeneratedBuilderLite<SendMsgResponseNew, SendMsgResponseNew.Builder>
        {
            private SendMsgResponseNew result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = SendMsgResponseNew.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(SendMsgResponseNew cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public SendMsgResponseNew.Builder AddList(MicroMsgResponseNew value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.list_.Add(value);
                return this;
            }

            public SendMsgResponseNew.Builder AddList(MicroMsgResponseNew.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.list_.Add(builderForValue.Build());
                return this;
            }

            public SendMsgResponseNew.Builder AddRangeList(IEnumerable<MicroMsgResponseNew> values)
            {
                this.PrepareBuilder();
                this.result.list_.Add(values);
                return this;
            }

            public override SendMsgResponseNew BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override SendMsgResponseNew.Builder Clear()
            {
                this.result = SendMsgResponseNew.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public SendMsgResponseNew.Builder ClearBaseResponse()
            {
                this.PrepareBuilder();
                this.result.hasBaseResponse = false;
                this.result.baseResponse_ = null;
                return this;
            }

            public SendMsgResponseNew.Builder ClearCount()
            {
                this.PrepareBuilder();
                this.result.hasCount = false;
                this.result.count_ = 0;
                return this;
            }

            public SendMsgResponseNew.Builder ClearList()
            {
                this.PrepareBuilder();
                this.result.list_.Clear();
                return this;
            }

            public override SendMsgResponseNew.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new SendMsgResponseNew.Builder(this.result);
                }
                return new SendMsgResponseNew.Builder().MergeFrom(this.result);
            }

            public MicroMsgResponseNew GetList(int index)
            {
                return this.result.GetList(index);
            }

            public SendMsgResponseNew.Builder MergeBaseResponse(BaseResponse value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasBaseResponse && (this.result.baseResponse_ != BaseResponse.DefaultInstance))
                {
                    this.result.baseResponse_ = BaseResponse.CreateBuilder(this.result.baseResponse_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.baseResponse_ = value;
                }
                this.result.hasBaseResponse = true;
                return this;
            }

            public override SendMsgResponseNew.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override SendMsgResponseNew.Builder MergeFrom(IMessageLite other)
            {
                if (other is SendMsgResponseNew)
                {
                    return this.MergeFrom((SendMsgResponseNew) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override SendMsgResponseNew.Builder MergeFrom(SendMsgResponseNew other)
            {
                return this;
            }

            public override SendMsgResponseNew.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(SendMsgResponseNew._sendMsgResponseNewFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = SendMsgResponseNew._sendMsgResponseNewFieldTags[index];
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
                            BaseResponse.Builder builder = BaseResponse.CreateBuilder();
                            if (this.result.hasBaseResponse)
                            {
                                builder.MergeFrom(this.BaseResponse);
                            }
                            input.ReadMessage(builder, extensionRegistry);
                            this.BaseResponse = builder.BuildPartial();
                            continue;
                        }
                        case 0x10:
                        {
                            this.result.hasCount = input.ReadUInt32(ref this.result.count_);
                            continue;
                        }
                        case 0x1a:
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
                    input.ReadMessageArray<MicroMsgResponseNew>(num, str, this.result.list_, MicroMsgResponseNew.DefaultInstance, extensionRegistry);
                }
                return this;
            }

            private SendMsgResponseNew PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    SendMsgResponseNew result = this.result;
                    this.result = new SendMsgResponseNew();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public SendMsgResponseNew.Builder SetBaseResponse(BaseResponse value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = value;
                return this;
            }

            public SendMsgResponseNew.Builder SetBaseResponse(BaseResponse.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = builderForValue.Build();
                return this;
            }

            public SendMsgResponseNew.Builder SetCount(uint value)
            {
                this.PrepareBuilder();
                this.result.hasCount = true;
                this.result.count_ = value;
                return this;
            }

            public SendMsgResponseNew.Builder SetList(int index, MicroMsgResponseNew value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.list_[index] = value;
                return this;
            }

            public SendMsgResponseNew.Builder SetList(int index, MicroMsgResponseNew.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.list_[index] = builderForValue.Build();
                return this;
            }

            public BaseResponse BaseResponse
            {
                get
                {
                    return this.result.BaseResponse;
                }
                set
                {
                    this.SetBaseResponse(value);
                }
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

            public override SendMsgResponseNew DefaultInstanceForType
            {
                get
                {
                    return SendMsgResponseNew.DefaultInstance;
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

            public IPopsicleList<MicroMsgResponseNew> ListList
            {
                get
                {
                    return this.PrepareBuilder().list_;
                }
            }

            protected override SendMsgResponseNew MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override SendMsgResponseNew.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}

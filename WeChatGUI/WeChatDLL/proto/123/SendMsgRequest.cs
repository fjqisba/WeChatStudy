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
    public sealed class SendMsgRequest : GeneratedMessageLite<SendMsgRequest, SendMsgRequest.Builder>
    {
        private static readonly string[] _sendMsgRequestFieldNames = new string[] { "BaseRequest", "Count", "List" };
        private static readonly uint[] _sendMsgRequestFieldTags = new uint[] { 10, 0x10, 0x1a };
        private micromsg.BaseRequest baseRequest_;
        public const int BaseRequestFieldNumber = 1;
        private uint count_;
        public const int CountFieldNumber = 2;
        private static readonly SendMsgRequest defaultInstance = new SendMsgRequest().MakeReadOnly();
        private bool hasBaseRequest;
        private bool hasCount;
        private PopsicleList<MicroMsgRequest> list_ = new PopsicleList<MicroMsgRequest>();
        public const int ListFieldNumber = 3;
        private int memoizedSerializedSize = -1;

        static SendMsgRequest()
        {
            //object.ReferenceEquals(SendMsgRequest.Descriptor, null);
        }

        private SendMsgRequest()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(SendMsgRequest prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            SendMsgRequest request = obj as SendMsgRequest;
            if (request == null)
            {
                return false;
            }
            if ((this.hasBaseRequest != request.hasBaseRequest) || (this.hasBaseRequest && !this.baseRequest_.Equals(request.baseRequest_)))
            {
                return false;
            }
            if ((this.hasCount != request.hasCount) || (this.hasCount && !this.count_.Equals(request.count_)))
            {
                return false;
            }
            if (this.list_.Count != request.list_.Count)
            {
                return false;
            }
            for (int i = 0; i < this.list_.Count; i++)
            {
                if (!this.list_[i].Equals(request.list_[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasBaseRequest)
            {
                hashCode ^= this.baseRequest_.GetHashCode();
            }
            if (this.hasCount)
            {
                hashCode ^= this.count_.GetHashCode();
            }
            foreach (MicroMsgRequest request in this.list_)
            {
                hashCode ^= request.GetHashCode();
            }
            return hashCode;
        }

        public MicroMsgRequest GetList(int index)
        {
            return this.list_[index];
        }

        private SendMsgRequest MakeReadOnly()
        {
            this.list_.MakeReadOnly();
            return this;
        }

        public static SendMsgRequest ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<SendMsgRequest, Builder>.PrintField("BaseRequest", this.hasBaseRequest, this.baseRequest_, writer);
            GeneratedMessageLite<SendMsgRequest, Builder>.PrintField("Count", this.hasCount, this.count_, writer);
            GeneratedMessageLite<SendMsgRequest, Builder>.PrintField<MicroMsgRequest>("List", this.list_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _sendMsgRequestFieldNames;
            if (this.hasBaseRequest)
            {
                output.WriteMessage(1, strArray[0], this.BaseRequest);
            }
            if (this.hasCount)
            {
                output.WriteUInt32(2, strArray[1], this.Count);
            }
            if (this.list_.Count > 0)
            {
                output.WriteMessageArray<MicroMsgRequest>(3, strArray[2], this.list_);
            }
        }

        public micromsg.BaseRequest BaseRequest
        {
            get
            {
                return (this.baseRequest_ ?? micromsg.BaseRequest.DefaultInstance);
            }
        }

        public uint Count
        {
            get
            {
                return this.count_;
            }
        }

        public static SendMsgRequest DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override SendMsgRequest DefaultInstanceForType
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
                if (!this.hasBaseRequest)
                {
                    return false;
                }
                if (!this.hasCount)
                {
                    return false;
                }
                if (!this.BaseRequest.IsInitialized)
                {
                    return false;
                }
                foreach (MicroMsgRequest request in this.ListList)
                {
                    if (!request.IsInitialized)
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

        public IList<MicroMsgRequest> ListList
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
                    if (this.hasBaseRequest)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(1, this.BaseRequest);
                    }
                    if (this.hasCount)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(2, this.Count);
                    }
                    foreach (MicroMsgRequest request in this.ListList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(3, request);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override SendMsgRequest ThisMessage
        {
            get
            {
                return this;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<SendMsgRequest, SendMsgRequest.Builder>
        {
            private SendMsgRequest result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = SendMsgRequest.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(SendMsgRequest cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public SendMsgRequest.Builder AddList(MicroMsgRequest value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.list_.Add(value);
                return this;
            }

            public SendMsgRequest.Builder AddList(MicroMsgRequest.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.list_.Add(builderForValue.Build());
                return this;
            }

            public SendMsgRequest.Builder AddRangeList(IEnumerable<MicroMsgRequest> values)
            {
                this.PrepareBuilder();
                this.result.list_.Add(values);
                return this;
            }

            public override SendMsgRequest BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override SendMsgRequest.Builder Clear()
            {
                this.result = SendMsgRequest.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public SendMsgRequest.Builder ClearBaseRequest()
            {
                this.PrepareBuilder();
                this.result.hasBaseRequest = false;
                this.result.baseRequest_ = null;
                return this;
            }

            public SendMsgRequest.Builder ClearCount()
            {
                this.PrepareBuilder();
                this.result.hasCount = false;
                this.result.count_ = 0;
                return this;
            }

            public SendMsgRequest.Builder ClearList()
            {
                this.PrepareBuilder();
                this.result.list_.Clear();
                return this;
            }

            public override SendMsgRequest.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new SendMsgRequest.Builder(this.result);
                }
                return new SendMsgRequest.Builder().MergeFrom(this.result);
            }

            public MicroMsgRequest GetList(int index)
            {
                return this.result.GetList(index);
            }

            public SendMsgRequest.Builder MergeBaseRequest(micromsg.BaseRequest value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasBaseRequest && (this.result.baseRequest_ != micromsg.BaseRequest.DefaultInstance))
                {
                    this.result.baseRequest_ = micromsg.BaseRequest.CreateBuilder(this.result.baseRequest_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.baseRequest_ = value;
                }
                this.result.hasBaseRequest = true;
                return this;
            }

            public override SendMsgRequest.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override SendMsgRequest.Builder MergeFrom(IMessageLite other)
            {
                if (other is SendMsgRequest)
                {
                    return this.MergeFrom((SendMsgRequest) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override SendMsgRequest.Builder MergeFrom(SendMsgRequest other)
            {
                return this;
            }

            public override SendMsgRequest.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(SendMsgRequest._sendMsgRequestFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = SendMsgRequest._sendMsgRequestFieldTags[index];
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
                            micromsg.BaseRequest.Builder builder = micromsg.BaseRequest.CreateBuilder();
                            if (this.result.hasBaseRequest)
                            {
                                builder.MergeFrom(this.BaseRequest);
                            }
                            input.ReadMessage(builder, extensionRegistry);
                            this.BaseRequest = builder.BuildPartial();
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
                    input.ReadMessageArray<MicroMsgRequest>(num, str, this.result.list_, MicroMsgRequest.DefaultInstance, extensionRegistry);
                }
                return this;
            }

            private SendMsgRequest PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    SendMsgRequest result = this.result;
                    this.result = new SendMsgRequest();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public SendMsgRequest.Builder SetBaseRequest(micromsg.BaseRequest value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = value;
                return this;
            }

            public SendMsgRequest.Builder SetBaseRequest(micromsg.BaseRequest.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = builderForValue.Build();
                return this;
            }

            public SendMsgRequest.Builder SetCount(uint value)
            {
                this.PrepareBuilder();
                this.result.hasCount = true;
                this.result.count_ = value;
                return this;
            }

            public SendMsgRequest.Builder SetList(int index, MicroMsgRequest value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.list_[index] = value;
                return this;
            }

            public SendMsgRequest.Builder SetList(int index, MicroMsgRequest.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.list_[index] = builderForValue.Build();
                return this;
            }

            public micromsg.BaseRequest BaseRequest
            {
                get
                {
                    return this.result.BaseRequest;
                }
                set
                {
                    this.SetBaseRequest(value);
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

            public override SendMsgRequest DefaultInstanceForType
            {
                get
                {
                    return SendMsgRequest.DefaultInstance;
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

            public IPopsicleList<MicroMsgRequest> ListList
            {
                get
                {
                    return this.PrepareBuilder().list_;
                }
            }

            protected override SendMsgRequest MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override SendMsgRequest.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


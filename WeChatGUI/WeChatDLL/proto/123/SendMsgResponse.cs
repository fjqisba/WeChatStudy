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
    public sealed class SendMsgResponse : GeneratedMessageLite<SendMsgResponse, SendMsgResponse.Builder>
    {
        private static readonly string[] _sendMsgResponseFieldNames = new string[] { "BaseResponse", "Count", "List" };
        private static readonly uint[] _sendMsgResponseFieldTags = new uint[] { 10, 0x10, 0x1a };
        private micromsg.BaseResponse baseResponse_;
        public const int BaseResponseFieldNumber = 1;
        private uint count_;
        public const int CountFieldNumber = 2;
        private static readonly SendMsgResponse defaultInstance = new SendMsgResponse().MakeReadOnly();
        private bool hasBaseResponse;
        private bool hasCount;
        private PopsicleList<MicroMsgResponse> list_ = new PopsicleList<MicroMsgResponse>();
        public const int ListFieldNumber = 3;
        private int memoizedSerializedSize = -1;

        static SendMsgResponse()
        {
            //object.ReferenceEquals(SendMsgResponse.Descriptor, null);
        }

        private SendMsgResponse()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(SendMsgResponse prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            SendMsgResponse response = obj as SendMsgResponse;
            if (response == null)
            {
                return false;
            }
            if ((this.hasBaseResponse != response.hasBaseResponse) || (this.hasBaseResponse && !this.baseResponse_.Equals(response.baseResponse_)))
            {
                return false;
            }
            if ((this.hasCount != response.hasCount) || (this.hasCount && !this.count_.Equals(response.count_)))
            {
                return false;
            }
            if (this.list_.Count != response.list_.Count)
            {
                return false;
            }
            for (int i = 0; i < this.list_.Count; i++)
            {
                if (!this.list_[i].Equals(response.list_[i]))
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
            foreach (MicroMsgResponse response in this.list_)
            {
                hashCode ^= response.GetHashCode();
            }
            return hashCode;
        }

        public MicroMsgResponse GetList(int index)
        {
            return this.list_[index];
        }

        private SendMsgResponse MakeReadOnly()
        {
            this.list_.MakeReadOnly();
            return this;
        }

        public static SendMsgResponse ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<SendMsgResponse, Builder>.PrintField("BaseResponse", this.hasBaseResponse, this.baseResponse_, writer);
            GeneratedMessageLite<SendMsgResponse, Builder>.PrintField("Count", this.hasCount, this.count_, writer);
            GeneratedMessageLite<SendMsgResponse, Builder>.PrintField<MicroMsgResponse>("List", this.list_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _sendMsgResponseFieldNames;
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
                output.WriteMessageArray<MicroMsgResponse>(3, strArray[2], this.list_);
            }
        }

        public micromsg.BaseResponse BaseResponse
        {
            get
            {
                return (this.baseResponse_ ?? micromsg.BaseResponse.DefaultInstance);
            }
        }

        public uint Count
        {
            get
            {
                return this.count_;
            }
        }

        public static SendMsgResponse DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override SendMsgResponse DefaultInstanceForType
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
                foreach (MicroMsgResponse response in this.ListList)
                {
                    if (!response.IsInitialized)
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

        public IList<MicroMsgResponse> ListList
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
                    foreach (MicroMsgResponse response in this.ListList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(3, response);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override SendMsgResponse ThisMessage
        {
            get
            {
                return this;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<SendMsgResponse, SendMsgResponse.Builder>
        {
            private SendMsgResponse result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = SendMsgResponse.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(SendMsgResponse cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public SendMsgResponse.Builder AddList(MicroMsgResponse value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.list_.Add(value);
                return this;
            }

            public SendMsgResponse.Builder AddList(MicroMsgResponse.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.list_.Add(builderForValue.Build());
                return this;
            }

            public SendMsgResponse.Builder AddRangeList(IEnumerable<MicroMsgResponse> values)
            {
                this.PrepareBuilder();
                this.result.list_.Add(values);
                return this;
            }

            public override SendMsgResponse BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override SendMsgResponse.Builder Clear()
            {
                this.result = SendMsgResponse.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public SendMsgResponse.Builder ClearBaseResponse()
            {
                this.PrepareBuilder();
                this.result.hasBaseResponse = false;
                this.result.baseResponse_ = null;
                return this;
            }

            public SendMsgResponse.Builder ClearCount()
            {
                this.PrepareBuilder();
                this.result.hasCount = false;
                this.result.count_ = 0;
                return this;
            }

            public SendMsgResponse.Builder ClearList()
            {
                this.PrepareBuilder();
                this.result.list_.Clear();
                return this;
            }

            public override SendMsgResponse.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new SendMsgResponse.Builder(this.result);
                }
                return new SendMsgResponse.Builder().MergeFrom(this.result);
            }

            public MicroMsgResponse GetList(int index)
            {
                return this.result.GetList(index);
            }

            public SendMsgResponse.Builder MergeBaseResponse(micromsg.BaseResponse value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasBaseResponse && (this.result.baseResponse_ != micromsg.BaseResponse.DefaultInstance))
                {
                    this.result.baseResponse_ = micromsg.BaseResponse.CreateBuilder(this.result.baseResponse_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.baseResponse_ = value;
                }
                this.result.hasBaseResponse = true;
                return this;
            }

            public override SendMsgResponse.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override SendMsgResponse.Builder MergeFrom(IMessageLite other)
            {
                if (other is SendMsgResponse)
                {
                    return this.MergeFrom((SendMsgResponse) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override SendMsgResponse.Builder MergeFrom(SendMsgResponse other)
            {
                return this;
            }

            public override SendMsgResponse.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(SendMsgResponse._sendMsgResponseFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = SendMsgResponse._sendMsgResponseFieldTags[index];
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
                            micromsg.BaseResponse.Builder builder = micromsg.BaseResponse.CreateBuilder();
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
                    input.ReadMessageArray<MicroMsgResponse>(num, str, this.result.list_, MicroMsgResponse.DefaultInstance, extensionRegistry);
                }
                return this;
            }

            private SendMsgResponse PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    SendMsgResponse result = this.result;
                    this.result = new SendMsgResponse();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public SendMsgResponse.Builder SetBaseResponse(micromsg.BaseResponse value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = value;
                return this;
            }

            public SendMsgResponse.Builder SetBaseResponse(micromsg.BaseResponse.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = builderForValue.Build();
                return this;
            }

            public SendMsgResponse.Builder SetCount(uint value)
            {
                this.PrepareBuilder();
                this.result.hasCount = true;
                this.result.count_ = value;
                return this;
            }

            public SendMsgResponse.Builder SetList(int index, MicroMsgResponse value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.list_[index] = value;
                return this;
            }

            public SendMsgResponse.Builder SetList(int index, MicroMsgResponse.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.list_[index] = builderForValue.Build();
                return this;
            }

            public micromsg.BaseResponse BaseResponse
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

            public override SendMsgResponse DefaultInstanceForType
            {
                get
                {
                    return SendMsgResponse.DefaultInstance;
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

            public IPopsicleList<MicroMsgResponse> ListList
            {
                get
                {
                    return this.PrepareBuilder().list_;
                }
            }

            protected override SendMsgResponse MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override SendMsgResponse.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


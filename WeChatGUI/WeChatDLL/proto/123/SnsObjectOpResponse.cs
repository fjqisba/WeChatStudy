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
    public sealed class SnsObjectOpResponse : GeneratedMessageLite<SnsObjectOpResponse, SnsObjectOpResponse.Builder>
    {
        private static readonly string[] _snsObjectOpResponseFieldNames = new string[] { "BaseResponse", "OpCount", "OpRetList" };
        private static readonly uint[] _snsObjectOpResponseFieldTags = new uint[] { 10, 0x10, 0x1a };
        private micromsg.BaseResponse baseResponse_;
        public const int BaseResponseFieldNumber = 1;
        private static readonly SnsObjectOpResponse defaultInstance = new SnsObjectOpResponse().MakeReadOnly();
        private bool hasBaseResponse;
        private bool hasOpCount;
        private int memoizedSerializedSize = -1;
        private uint opCount_;
        public const int OpCountFieldNumber = 2;
        private PopsicleList<int> opRetList_ = new PopsicleList<int>();
        public const int OpRetListFieldNumber = 3;
        private int opRetListMemoizedSerializedSize;

        static SnsObjectOpResponse()
        {
           // object.ReferenceEquals(SnsObjectOpResponse.Descriptor, null);
        }

        private SnsObjectOpResponse()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(SnsObjectOpResponse prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            SnsObjectOpResponse response = obj as SnsObjectOpResponse;
            if (response == null)
            {
                return false;
            }
            if ((this.hasBaseResponse != response.hasBaseResponse) || (this.hasBaseResponse && !this.baseResponse_.Equals(response.baseResponse_)))
            {
                return false;
            }
            if ((this.hasOpCount != response.hasOpCount) || (this.hasOpCount && !this.opCount_.Equals(response.opCount_)))
            {
                return false;
            }
            if (this.opRetList_.Count != response.opRetList_.Count)
            {
                return false;
            }
            for (int i = 0; i < this.opRetList_.Count; i++)
            {
                int num2 = this.opRetList_[i];
                if (!num2.Equals(response.opRetList_[i]))
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
            if (this.hasOpCount)
            {
                hashCode ^= this.opCount_.GetHashCode();
            }
            foreach (int num2 in this.opRetList_)
            {
                hashCode ^= num2.GetHashCode();
            }
            return hashCode;
        }

        public int GetOpRetList(int index)
        {
            return this.opRetList_[index];
        }

        private SnsObjectOpResponse MakeReadOnly()
        {
            this.opRetList_.MakeReadOnly();
            return this;
        }

        public static SnsObjectOpResponse ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<SnsObjectOpResponse, Builder>.PrintField("BaseResponse", this.hasBaseResponse, this.baseResponse_, writer);
            GeneratedMessageLite<SnsObjectOpResponse, Builder>.PrintField("OpCount", this.hasOpCount, this.opCount_, writer);
            GeneratedMessageLite<SnsObjectOpResponse, Builder>.PrintField<int>("OpRetList", this.opRetList_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _snsObjectOpResponseFieldNames;
            if (this.hasBaseResponse)
            {
                output.WriteMessage(1, strArray[0], this.BaseResponse);
            }
            if (this.hasOpCount)
            {
                output.WriteUInt32(2, strArray[1], this.OpCount);
            }
            if (this.opRetList_.Count > 0)
            {
                output.WritePackedInt32Array(3, strArray[2], this.opRetListMemoizedSerializedSize, this.opRetList_);
            }
        }

        public micromsg.BaseResponse BaseResponse
        {
            get
            {
                return (this.baseResponse_ ?? micromsg.BaseResponse.DefaultInstance);
            }
        }

        public static SnsObjectOpResponse DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override SnsObjectOpResponse DefaultInstanceForType
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
                if (!this.hasOpCount)
                {
                    return false;
                }
                if (!this.BaseResponse.IsInitialized)
                {
                    return false;
                }
                return true;
            }
        }

        public uint OpCount
        {
            get
            {
                return this.opCount_;
            }
        }

        public int OpRetListCount
        {
            get
            {
                return this.opRetList_.Count;
            }
        }

        public IList<int> OpRetListList
        {
            get
            {
                return Lists.AsReadOnly<int>(this.opRetList_);
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
                    if (this.hasOpCount)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(2, this.OpCount);
                    }
                    int num2 = 0;
                    foreach (int num3 in this.OpRetListList)
                    {
                        num2 += CodedOutputStream.ComputeInt32SizeNoTag(num3);
                    }
                    memoizedSerializedSize += num2;
                    if (this.opRetList_.Count != 0)
                    {
                        memoizedSerializedSize += 1 + CodedOutputStream.ComputeInt32SizeNoTag(num2);
                    }
                    this.opRetListMemoizedSerializedSize = num2;
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override SnsObjectOpResponse ThisMessage
        {
            get
            {
                return this;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<SnsObjectOpResponse, SnsObjectOpResponse.Builder>
        {
            private SnsObjectOpResponse result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = SnsObjectOpResponse.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(SnsObjectOpResponse cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public SnsObjectOpResponse.Builder AddOpRetList(int value)
            {
                this.PrepareBuilder();
                this.result.opRetList_.Add(value);
                return this;
            }

            public SnsObjectOpResponse.Builder AddRangeOpRetList(IEnumerable<int> values)
            {
                this.PrepareBuilder();
                this.result.opRetList_.Add(values);
                return this;
            }

            public override SnsObjectOpResponse BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override SnsObjectOpResponse.Builder Clear()
            {
                this.result = SnsObjectOpResponse.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public SnsObjectOpResponse.Builder ClearBaseResponse()
            {
                this.PrepareBuilder();
                this.result.hasBaseResponse = false;
                this.result.baseResponse_ = null;
                return this;
            }

            public SnsObjectOpResponse.Builder ClearOpCount()
            {
                this.PrepareBuilder();
                this.result.hasOpCount = false;
                this.result.opCount_ = 0;
                return this;
            }

            public SnsObjectOpResponse.Builder ClearOpRetList()
            {
                this.PrepareBuilder();
                this.result.opRetList_.Clear();
                return this;
            }

            public override SnsObjectOpResponse.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new SnsObjectOpResponse.Builder(this.result);
                }
                return new SnsObjectOpResponse.Builder().MergeFrom(this.result);
            }

            public int GetOpRetList(int index)
            {
                return this.result.GetOpRetList(index);
            }

            public SnsObjectOpResponse.Builder MergeBaseResponse(micromsg.BaseResponse value)
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

            public override SnsObjectOpResponse.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override SnsObjectOpResponse.Builder MergeFrom(IMessageLite other)
            {
                if (other is SnsObjectOpResponse)
                {
                    return this.MergeFrom((SnsObjectOpResponse) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override SnsObjectOpResponse.Builder MergeFrom(SnsObjectOpResponse other)
            {
                return this;
            }

            public override SnsObjectOpResponse.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(SnsObjectOpResponse._snsObjectOpResponseFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = SnsObjectOpResponse._snsObjectOpResponseFieldTags[index];
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
                        case 0x18:
                        case 0x1a:
                            break;

                        case 0x10:
                        {
                            this.result.hasOpCount = input.ReadUInt32(ref this.result.opCount_);
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
                    input.ReadInt32Array(num, str, this.result.opRetList_);
                }
                return this;
            }

            private SnsObjectOpResponse PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    SnsObjectOpResponse result = this.result;
                    this.result = new SnsObjectOpResponse();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public SnsObjectOpResponse.Builder SetBaseResponse(micromsg.BaseResponse value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = value;
                return this;
            }

            public SnsObjectOpResponse.Builder SetBaseResponse(micromsg.BaseResponse.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = builderForValue.Build();
                return this;
            }

            public SnsObjectOpResponse.Builder SetOpCount(uint value)
            {
                this.PrepareBuilder();
                this.result.hasOpCount = true;
                this.result.opCount_ = value;
                return this;
            }

            public SnsObjectOpResponse.Builder SetOpRetList(int index, int value)
            {
                this.PrepareBuilder();
                this.result.opRetList_[index] = value;
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

            public override SnsObjectOpResponse DefaultInstanceForType
            {
                get
                {
                    return SnsObjectOpResponse.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override SnsObjectOpResponse MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public uint OpCount
            {
                get
                {
                    return this.result.OpCount;
                }
                set
                {
                    this.SetOpCount(value);
                }
            }

            public int OpRetListCount
            {
                get
                {
                    return this.result.OpRetListCount;
                }
            }

            public IPopsicleList<int> OpRetListList
            {
                get
                {
                    return this.PrepareBuilder().opRetList_;
                }
            }

            protected override SnsObjectOpResponse.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


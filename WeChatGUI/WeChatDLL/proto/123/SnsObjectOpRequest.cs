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
    public sealed class SnsObjectOpRequest : GeneratedMessageLite<SnsObjectOpRequest, SnsObjectOpRequest.Builder>
    {
        private static readonly string[] _snsObjectOpRequestFieldNames = new string[] { "BaseRequest", "OpCount", "OpList" };
        private static readonly uint[] _snsObjectOpRequestFieldTags = new uint[] { 10, 0x10, 0x1a };
        private micromsg.BaseRequest baseRequest_;
        public const int BaseRequestFieldNumber = 1;
        private static readonly SnsObjectOpRequest defaultInstance = new SnsObjectOpRequest().MakeReadOnly();
        private bool hasBaseRequest;
        private bool hasOpCount;
        private int memoizedSerializedSize = -1;
        private uint opCount_;
        public const int OpCountFieldNumber = 2;
        private PopsicleList<SnsObjectOp> opList_ = new PopsicleList<SnsObjectOp>();
        public const int OpListFieldNumber = 3;

        static SnsObjectOpRequest()
        {
            //object.ReferenceEquals(SnsObjectOpRequest.Descriptor, null);
        }

        private SnsObjectOpRequest()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(SnsObjectOpRequest prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            SnsObjectOpRequest request = obj as SnsObjectOpRequest;
            if (request == null)
            {
                return false;
            }
            if ((this.hasBaseRequest != request.hasBaseRequest) || (this.hasBaseRequest && !this.baseRequest_.Equals(request.baseRequest_)))
            {
                return false;
            }
            if ((this.hasOpCount != request.hasOpCount) || (this.hasOpCount && !this.opCount_.Equals(request.opCount_)))
            {
                return false;
            }
            if (this.opList_.Count != request.opList_.Count)
            {
                return false;
            }
            for (int i = 0; i < this.opList_.Count; i++)
            {
                if (!this.opList_[i].Equals(request.opList_[i]))
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
            if (this.hasOpCount)
            {
                hashCode ^= this.opCount_.GetHashCode();
            }
            foreach (SnsObjectOp op in this.opList_)
            {
                hashCode ^= op.GetHashCode();
            }
            return hashCode;
        }

        public SnsObjectOp GetOpList(int index)
        {
            return this.opList_[index];
        }

        private SnsObjectOpRequest MakeReadOnly()
        {
            this.opList_.MakeReadOnly();
            return this;
        }

        public static SnsObjectOpRequest ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<SnsObjectOpRequest, Builder>.PrintField("BaseRequest", this.hasBaseRequest, this.baseRequest_, writer);
            GeneratedMessageLite<SnsObjectOpRequest, Builder>.PrintField("OpCount", this.hasOpCount, this.opCount_, writer);
            GeneratedMessageLite<SnsObjectOpRequest, Builder>.PrintField<SnsObjectOp>("OpList", this.opList_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _snsObjectOpRequestFieldNames;
            if (this.hasBaseRequest)
            {
                output.WriteMessage(1, strArray[0], this.BaseRequest);
            }
            if (this.hasOpCount)
            {
                output.WriteUInt32(2, strArray[1], this.OpCount);
            }
            if (this.opList_.Count > 0)
            {
                output.WriteMessageArray<SnsObjectOp>(3, strArray[2], this.opList_);
            }
        }

        public micromsg.BaseRequest BaseRequest
        {
            get
            {
                return (this.baseRequest_ ?? micromsg.BaseRequest.DefaultInstance);
            }
        }

        public static SnsObjectOpRequest DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override SnsObjectOpRequest DefaultInstanceForType
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
                if (!this.hasOpCount)
                {
                    return false;
                }
                if (!this.BaseRequest.IsInitialized)
                {
                    return false;
                }
                foreach (SnsObjectOp op in this.OpListList)
                {
                    if (!op.IsInitialized)
                    {
                        return false;
                    }
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

        public int OpListCount
        {
            get
            {
                return this.opList_.Count;
            }
        }

        public IList<SnsObjectOp> OpListList
        {
            get
            {
                return this.opList_;
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
                    if (this.hasOpCount)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(2, this.OpCount);
                    }
                    foreach (SnsObjectOp op in this.OpListList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(3, op);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override SnsObjectOpRequest ThisMessage
        {
            get
            {
                return this;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<SnsObjectOpRequest, SnsObjectOpRequest.Builder>
        {
            private SnsObjectOpRequest result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = SnsObjectOpRequest.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(SnsObjectOpRequest cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public SnsObjectOpRequest.Builder AddOpList(SnsObjectOp value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.opList_.Add(value);
                return this;
            }

            public SnsObjectOpRequest.Builder AddOpList(SnsObjectOp.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.opList_.Add(builderForValue.Build());
                return this;
            }

            public SnsObjectOpRequest.Builder AddRangeOpList(IEnumerable<SnsObjectOp> values)
            {
                this.PrepareBuilder();
                this.result.opList_.Add(values);
                return this;
            }

            public override SnsObjectOpRequest BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override SnsObjectOpRequest.Builder Clear()
            {
                this.result = SnsObjectOpRequest.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public SnsObjectOpRequest.Builder ClearBaseRequest()
            {
                this.PrepareBuilder();
                this.result.hasBaseRequest = false;
                this.result.baseRequest_ = null;
                return this;
            }

            public SnsObjectOpRequest.Builder ClearOpCount()
            {
                this.PrepareBuilder();
                this.result.hasOpCount = false;
                this.result.opCount_ = 0;
                return this;
            }

            public SnsObjectOpRequest.Builder ClearOpList()
            {
                this.PrepareBuilder();
                this.result.opList_.Clear();
                return this;
            }

            public override SnsObjectOpRequest.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new SnsObjectOpRequest.Builder(this.result);
                }
                return new SnsObjectOpRequest.Builder().MergeFrom(this.result);
            }

            public SnsObjectOp GetOpList(int index)
            {
                return this.result.GetOpList(index);
            }

            public SnsObjectOpRequest.Builder MergeBaseRequest(micromsg.BaseRequest value)
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

            public override SnsObjectOpRequest.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override SnsObjectOpRequest.Builder MergeFrom(IMessageLite other)
            {
                if (other is SnsObjectOpRequest)
                {
                    return this.MergeFrom((SnsObjectOpRequest) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override SnsObjectOpRequest.Builder MergeFrom(SnsObjectOpRequest other)
            {
                return this;
            }

            public override SnsObjectOpRequest.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(SnsObjectOpRequest._snsObjectOpRequestFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = SnsObjectOpRequest._snsObjectOpRequestFieldTags[index];
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
                            this.result.hasOpCount = input.ReadUInt32(ref this.result.opCount_);
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
                    input.ReadMessageArray<SnsObjectOp>(num, str, this.result.opList_, SnsObjectOp.DefaultInstance, extensionRegistry);
                }
                return this;
            }

            private SnsObjectOpRequest PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    SnsObjectOpRequest result = this.result;
                    this.result = new SnsObjectOpRequest();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public SnsObjectOpRequest.Builder SetBaseRequest(micromsg.BaseRequest value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = value;
                return this;
            }

            public SnsObjectOpRequest.Builder SetBaseRequest(micromsg.BaseRequest.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = builderForValue.Build();
                return this;
            }

            public SnsObjectOpRequest.Builder SetOpCount(uint value)
            {
                this.PrepareBuilder();
                this.result.hasOpCount = true;
                this.result.opCount_ = value;
                return this;
            }

            public SnsObjectOpRequest.Builder SetOpList(int index, SnsObjectOp value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.opList_[index] = value;
                return this;
            }

            public SnsObjectOpRequest.Builder SetOpList(int index, SnsObjectOp.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.opList_[index] = builderForValue.Build();
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

            public override SnsObjectOpRequest DefaultInstanceForType
            {
                get
                {
                    return SnsObjectOpRequest.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override SnsObjectOpRequest MessageBeingBuilt
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

            public int OpListCount
            {
                get
                {
                    return this.result.OpListCount;
                }
            }

            public IPopsicleList<SnsObjectOp> OpListList
            {
                get
                {
                    return this.PrepareBuilder().opList_;
                }
            }

            protected override SnsObjectOpRequest.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


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

    public sealed class SnsTimeLineResponse : GeneratedMessageLite<SnsTimeLineResponse, SnsTimeLineResponse.Builder>
    {
        private static readonly string[] _snsTimeLineResponseFieldNames = new string[] { "BaseResponse", "FirstPageMd5", "NewRequestTime", "ObjectCount", "ObjectList" };
        private static readonly uint[] _snsTimeLineResponseFieldTags = new uint[] { 10, 0x12, 40, 0x18, 0x22 };
        private micromsg.BaseResponse baseResponse_;
        public const int BaseResponseFieldNumber = 1;
        private static readonly SnsTimeLineResponse defaultInstance = new SnsTimeLineResponse().MakeReadOnly();
        private string firstPageMd5_ = "";
        public const int FirstPageMd5FieldNumber = 2;
        private bool hasBaseResponse;
        private bool hasFirstPageMd5;
        private bool hasNewRequestTime;
        private bool hasObjectCount;
        private int memoizedSerializedSize = -1;
        private uint newRequestTime_;
        public const int NewRequestTimeFieldNumber = 5;
        private uint objectCount_;
        public const int ObjectCountFieldNumber = 3;
        private PopsicleList<SnsObject> objectList_ = new PopsicleList<SnsObject>();
        public const int ObjectListFieldNumber = 4;

        static SnsTimeLineResponse()
        {

        }

        private SnsTimeLineResponse()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(SnsTimeLineResponse prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            SnsTimeLineResponse response = obj as SnsTimeLineResponse;
            if (response == null)
            {
                return false;
            }
            if ((this.hasBaseResponse != response.hasBaseResponse) || (this.hasBaseResponse && !this.baseResponse_.Equals(response.baseResponse_)))
            {
                return false;
            }
            if ((this.hasFirstPageMd5 != response.hasFirstPageMd5) || (this.hasFirstPageMd5 && !this.firstPageMd5_.Equals(response.firstPageMd5_)))
            {
                return false;
            }
            if ((this.hasObjectCount != response.hasObjectCount) || (this.hasObjectCount && !this.objectCount_.Equals(response.objectCount_)))
            {
                return false;
            }
            if (this.objectList_.Count != response.objectList_.Count)
            {
                return false;
            }
            for (int i = 0; i < this.objectList_.Count; i++)
            {
                if (!this.objectList_[i].Equals(response.objectList_[i]))
                {
                    return false;
                }
            }
            return ((this.hasNewRequestTime == response.hasNewRequestTime) && (!this.hasNewRequestTime || this.newRequestTime_.Equals(response.newRequestTime_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasBaseResponse)
            {
                hashCode ^= this.baseResponse_.GetHashCode();
            }
            if (this.hasFirstPageMd5)
            {
                hashCode ^= this.firstPageMd5_.GetHashCode();
            }
            if (this.hasObjectCount)
            {
                hashCode ^= this.objectCount_.GetHashCode();
            }
            foreach (SnsObject obj2 in this.objectList_)
            {
                hashCode ^= obj2.GetHashCode();
            }
            if (this.hasNewRequestTime)
            {
                hashCode ^= this.newRequestTime_.GetHashCode();
            }
            return hashCode;
        }

        public SnsObject GetObjectList(int index)
        {
            return this.objectList_[index];
        }

        private SnsTimeLineResponse MakeReadOnly()
        {
            this.objectList_.MakeReadOnly();
            return this;
        }

        public static SnsTimeLineResponse ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<SnsTimeLineResponse, Builder>.PrintField("BaseResponse", this.hasBaseResponse, this.baseResponse_, writer);
            GeneratedMessageLite<SnsTimeLineResponse, Builder>.PrintField("FirstPageMd5", this.hasFirstPageMd5, this.firstPageMd5_, writer);
            GeneratedMessageLite<SnsTimeLineResponse, Builder>.PrintField("ObjectCount", this.hasObjectCount, this.objectCount_, writer);
            GeneratedMessageLite<SnsTimeLineResponse, Builder>.PrintField<SnsObject>("ObjectList", this.objectList_, writer);
            GeneratedMessageLite<SnsTimeLineResponse, Builder>.PrintField("NewRequestTime", this.hasNewRequestTime, this.newRequestTime_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _snsTimeLineResponseFieldNames;
            if (this.hasBaseResponse)
            {
                output.WriteMessage(1, strArray[0], this.BaseResponse);
            }
            if (this.hasFirstPageMd5)
            {
                output.WriteString(2, strArray[1], this.FirstPageMd5);
            }
            if (this.hasObjectCount)
            {
                output.WriteUInt32(3, strArray[3], this.ObjectCount);
            }
            if (this.objectList_.Count > 0)
            {
                output.WriteMessageArray<SnsObject>(4, strArray[4], this.objectList_);
            }
            if (this.hasNewRequestTime)
            {
                output.WriteUInt32(5, strArray[2], this.NewRequestTime);
            }
        }

        public micromsg.BaseResponse BaseResponse
        {
            get
            {
                return (this.baseResponse_ ?? micromsg.BaseResponse.DefaultInstance);
            }
        }

        public static SnsTimeLineResponse DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override SnsTimeLineResponse DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public string FirstPageMd5
        {
            get
            {
                return this.firstPageMd5_;
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
                if (!this.hasObjectCount)
                {
                    return false;
                }
                if (!this.BaseResponse.IsInitialized)
                {
                    return false;
                }
                foreach (SnsObject obj2 in this.ObjectListList)
                {
                    if (!obj2.IsInitialized)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public uint NewRequestTime
        {
            get
            {
                return this.newRequestTime_;
            }
        }

        public uint ObjectCount
        {
            get
            {
                return this.objectCount_;
            }
        }

        public int ObjectListCount
        {
            get
            {
                return this.objectList_.Count;
            }
        }

        public IList<SnsObject> ObjectListList
        {
            get
            {
                return this.objectList_;
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
                    if (this.hasFirstPageMd5)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(2, this.FirstPageMd5);
                    }
                    if (this.hasObjectCount)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(3, this.ObjectCount);
                    }
                    foreach (SnsObject obj2 in this.ObjectListList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(4, obj2);
                    }
                    if (this.hasNewRequestTime)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(5, this.NewRequestTime);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override SnsTimeLineResponse ThisMessage
        {
            get
            {
                return this;
            }
        }

        [DebuggerNonUserCode, CompilerGenerated, GeneratedCode("ProtoGen", "2.3.0.277")]
        public sealed class Builder : GeneratedBuilderLite<SnsTimeLineResponse, SnsTimeLineResponse.Builder>
        {
            private SnsTimeLineResponse result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = SnsTimeLineResponse.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(SnsTimeLineResponse cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public SnsTimeLineResponse.Builder AddObjectList(SnsObject value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.objectList_.Add(value);
                return this;
            }

            public SnsTimeLineResponse.Builder AddObjectList(SnsObject.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.objectList_.Add(builderForValue.Build());
                return this;
            }

            public SnsTimeLineResponse.Builder AddRangeObjectList(IEnumerable<SnsObject> values)
            {
                this.PrepareBuilder();
                this.result.objectList_.Add(values);
                return this;
            }

            public override SnsTimeLineResponse BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override SnsTimeLineResponse.Builder Clear()
            {
                this.result = SnsTimeLineResponse.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public SnsTimeLineResponse.Builder ClearBaseResponse()
            {
                this.PrepareBuilder();
                this.result.hasBaseResponse = false;
                this.result.baseResponse_ = null;
                return this;
            }

            public SnsTimeLineResponse.Builder ClearFirstPageMd5()
            {
                this.PrepareBuilder();
                this.result.hasFirstPageMd5 = false;
                this.result.firstPageMd5_ = "";
                return this;
            }

            public SnsTimeLineResponse.Builder ClearNewRequestTime()
            {
                this.PrepareBuilder();
                this.result.hasNewRequestTime = false;
                this.result.newRequestTime_ = 0;
                return this;
            }

            public SnsTimeLineResponse.Builder ClearObjectCount()
            {
                this.PrepareBuilder();
                this.result.hasObjectCount = false;
                this.result.objectCount_ = 0;
                return this;
            }

            public SnsTimeLineResponse.Builder ClearObjectList()
            {
                this.PrepareBuilder();
                this.result.objectList_.Clear();
                return this;
            }

            public override SnsTimeLineResponse.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new SnsTimeLineResponse.Builder(this.result);
                }
                return new SnsTimeLineResponse.Builder().MergeFrom(this.result);
            }

            public SnsObject GetObjectList(int index)
            {
                return this.result.GetObjectList(index);
            }

            public SnsTimeLineResponse.Builder MergeBaseResponse(micromsg.BaseResponse value)
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

            public override SnsTimeLineResponse.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override SnsTimeLineResponse.Builder MergeFrom(IMessageLite other)
            {
                if (other is SnsTimeLineResponse)
                {
                    return this.MergeFrom((SnsTimeLineResponse) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override SnsTimeLineResponse.Builder MergeFrom(SnsTimeLineResponse other)
            {
                return this;
            }

            public override SnsTimeLineResponse.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(SnsTimeLineResponse._snsTimeLineResponseFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = SnsTimeLineResponse._snsTimeLineResponseFieldTags[index];
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
                        case 0x12:
                        {
                            this.result.hasFirstPageMd5 = input.ReadString(ref this.result.firstPageMd5_);
                            continue;
                        }
                        case 0x18:
                        {
                            this.result.hasObjectCount = input.ReadUInt32(ref this.result.objectCount_);
                            continue;
                        }
                        case 0x22:
                        {
                            input.ReadMessageArray<SnsObject>(num, str, this.result.objectList_, SnsObject.DefaultInstance, extensionRegistry);
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
                    this.result.hasNewRequestTime = input.ReadUInt32(ref this.result.newRequestTime_);
                }
                return this;
            }

            private SnsTimeLineResponse PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    SnsTimeLineResponse result = this.result;
                    this.result = new SnsTimeLineResponse();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public SnsTimeLineResponse.Builder SetBaseResponse(micromsg.BaseResponse value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = value;
                return this;
            }

            public SnsTimeLineResponse.Builder SetBaseResponse(micromsg.BaseResponse.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = builderForValue.Build();
                return this;
            }

            public SnsTimeLineResponse.Builder SetFirstPageMd5(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasFirstPageMd5 = true;
                this.result.firstPageMd5_ = value;
                return this;
            }

            public SnsTimeLineResponse.Builder SetNewRequestTime(uint value)
            {
                this.PrepareBuilder();
                this.result.hasNewRequestTime = true;
                this.result.newRequestTime_ = value;
                return this;
            }

            public SnsTimeLineResponse.Builder SetObjectCount(uint value)
            {
                this.PrepareBuilder();
                this.result.hasObjectCount = true;
                this.result.objectCount_ = value;
                return this;
            }

            public SnsTimeLineResponse.Builder SetObjectList(int index, SnsObject value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.objectList_[index] = value;
                return this;
            }

            public SnsTimeLineResponse.Builder SetObjectList(int index, SnsObject.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.objectList_[index] = builderForValue.Build();
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

            public override SnsTimeLineResponse DefaultInstanceForType
            {
                get
                {
                    return SnsTimeLineResponse.DefaultInstance;
                }
            }

            public string FirstPageMd5
            {
                get
                {
                    return this.result.FirstPageMd5;
                }
                set
                {
                    this.SetFirstPageMd5(value);
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override SnsTimeLineResponse MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public uint NewRequestTime
            {
                get
                {
                    return this.result.NewRequestTime;
                }
                set
                {
                    this.SetNewRequestTime(value);
                }
            }

            public uint ObjectCount
            {
                get
                {
                    return this.result.ObjectCount;
                }
                set
                {
                    this.SetObjectCount(value);
                }
            }

            public int ObjectListCount
            {
                get
                {
                    return this.result.ObjectListCount;
                }
            }

            public IPopsicleList<SnsObject> ObjectListList
            {
                get
                {
                    return this.PrepareBuilder().objectList_;
                }
            }

            protected override SnsTimeLineResponse.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


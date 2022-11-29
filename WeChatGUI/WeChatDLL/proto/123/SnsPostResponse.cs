namespace micromsg
{
    using Google.ProtocolBuffers;
    
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

    
    public sealed class SnsPostResponse : GeneratedMessageLite<SnsPostResponse, SnsPostResponse.Builder>
    {
        private static readonly string[] _snsPostResponseFieldNames = new string[] { "BaseResponse", "SnsObject" };
        private static readonly uint[] _snsPostResponseFieldTags = new uint[] { 10, 0x12 };
        private micromsg.BaseResponse baseResponse_;
        public const int BaseResponseFieldNumber = 1;
        private static readonly SnsPostResponse defaultInstance = new SnsPostResponse().MakeReadOnly();
        private bool hasBaseResponse;
        private bool hasSnsObject;
        private int memoizedSerializedSize = -1;
        private micromsg.SnsObject snsObject_;
        public const int SnsObjectFieldNumber = 2;

        static SnsPostResponse()
        {
            //object.ReferenceEquals(SnsPostResponse.Descriptor, null);
        }

        private SnsPostResponse()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(SnsPostResponse prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            SnsPostResponse response = obj as SnsPostResponse;
            if (response == null)
            {
                return false;
            }
            if ((this.hasBaseResponse != response.hasBaseResponse) || (this.hasBaseResponse && !this.baseResponse_.Equals(response.baseResponse_)))
            {
                return false;
            }
            return ((this.hasSnsObject == response.hasSnsObject) && (!this.hasSnsObject || this.snsObject_.Equals(response.snsObject_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasBaseResponse)
            {
                hashCode ^= this.baseResponse_.GetHashCode();
            }
            if (this.hasSnsObject)
            {
                hashCode ^= this.snsObject_.GetHashCode();
            }
            return hashCode;
        }

        private SnsPostResponse MakeReadOnly()
        {
            return this;
        }

        public static SnsPostResponse ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<SnsPostResponse, Builder>.PrintField("BaseResponse", this.hasBaseResponse, this.baseResponse_, writer);
            GeneratedMessageLite<SnsPostResponse, Builder>.PrintField("SnsObject", this.hasSnsObject, this.snsObject_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _snsPostResponseFieldNames;
            if (this.hasBaseResponse)
            {
                output.WriteMessage(1, strArray[0], this.BaseResponse);
            }
            if (this.hasSnsObject)
            {
                output.WriteMessage(2, strArray[1], this.SnsObject);
            }
        }

        public micromsg.BaseResponse BaseResponse
        {
            get
            {
                return (this.baseResponse_ ?? micromsg.BaseResponse.DefaultInstance);
            }
        }

        public static SnsPostResponse DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override SnsPostResponse DefaultInstanceForType
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
                if (!this.hasSnsObject)
                {
                    return false;
                }
                if (!this.BaseResponse.IsInitialized)
                {
                    return false;
                }
                if (!this.SnsObject.IsInitialized)
                {
                    return false;
                }
                return true;
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
                    if (this.hasSnsObject)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(2, this.SnsObject);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        public micromsg.SnsObject SnsObject
        {
            get
            {
                return (this.snsObject_ ?? micromsg.SnsObject.DefaultInstance);
            }
        }

        protected override SnsPostResponse ThisMessage
        {
            get
            {
                return this;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<SnsPostResponse, SnsPostResponse.Builder>
        {
            private SnsPostResponse result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = SnsPostResponse.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(SnsPostResponse cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override SnsPostResponse BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override SnsPostResponse.Builder Clear()
            {
                this.result = SnsPostResponse.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public SnsPostResponse.Builder ClearBaseResponse()
            {
                this.PrepareBuilder();
                this.result.hasBaseResponse = false;
                this.result.baseResponse_ = null;
                return this;
            }

            public SnsPostResponse.Builder ClearSnsObject()
            {
                this.PrepareBuilder();
                this.result.hasSnsObject = false;
                this.result.snsObject_ = null;
                return this;
            }

            public override SnsPostResponse.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new SnsPostResponse.Builder(this.result);
                }
                return new SnsPostResponse.Builder().MergeFrom(this.result);
            }

            public SnsPostResponse.Builder MergeBaseResponse(micromsg.BaseResponse value)
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

            public override SnsPostResponse.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override SnsPostResponse.Builder MergeFrom(IMessageLite other)
            {
                if (other is SnsPostResponse)
                {
                    return this.MergeFrom((SnsPostResponse) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override SnsPostResponse.Builder MergeFrom(SnsPostResponse other)
            {
                return this;
            }

            public override SnsPostResponse.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(SnsPostResponse._snsPostResponseFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = SnsPostResponse._snsPostResponseFieldTags[index];
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
                            micromsg.SnsObject.Builder builder2 = micromsg.SnsObject.CreateBuilder();
                            if (this.result.hasSnsObject)
                            {
                                builder2.MergeFrom(this.SnsObject);
                            }
                            input.ReadMessage(builder2, extensionRegistry);
                            this.SnsObject = builder2.BuildPartial();
                            continue;
                        }
                    }
                    if (WireFormat.IsEndGroupTag(num))
                    {
                        return this;
                    }
                    this.ParseUnknownField(input, extensionRegistry, num, str);
                }
                return this;
            }

            public SnsPostResponse.Builder MergeSnsObject(micromsg.SnsObject value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasSnsObject && (this.result.snsObject_ != micromsg.SnsObject.DefaultInstance))
                {
                    this.result.snsObject_ = micromsg.SnsObject.CreateBuilder(this.result.snsObject_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.snsObject_ = value;
                }
                this.result.hasSnsObject = true;
                return this;
            }

            private SnsPostResponse PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    SnsPostResponse result = this.result;
                    this.result = new SnsPostResponse();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public SnsPostResponse.Builder SetBaseResponse(micromsg.BaseResponse value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = value;
                return this;
            }

            public SnsPostResponse.Builder SetBaseResponse(micromsg.BaseResponse.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = builderForValue.Build();
                return this;
            }

            public SnsPostResponse.Builder SetSnsObject(micromsg.SnsObject value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSnsObject = true;
                this.result.snsObject_ = value;
                return this;
            }

            public SnsPostResponse.Builder SetSnsObject(micromsg.SnsObject.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasSnsObject = true;
                this.result.snsObject_ = builderForValue.Build();
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

            public override SnsPostResponse DefaultInstanceForType
            {
                get
                {
                    return SnsPostResponse.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override SnsPostResponse MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public micromsg.SnsObject SnsObject
            {
                get
                {
                    return this.result.SnsObject;
                }
                set
                {
                    this.SetSnsObject(value);
                }
            }

            protected override SnsPostResponse.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


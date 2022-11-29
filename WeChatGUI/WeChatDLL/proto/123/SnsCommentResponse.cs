namespace micromsg
{
    using Google.ProtocolBuffers;

    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;

    public sealed class SnsCommentResponse : GeneratedMessageLite<SnsCommentResponse, SnsCommentResponse.Builder>
    {
        private static readonly string[] _snsCommentResponseFieldNames = new string[] { "BaseResponse", "SnsObject" };
        private static readonly uint[] _snsCommentResponseFieldTags = new uint[] { 10, 0x12 };
        private micromsg.BaseResponse baseResponse_;
        public const int BaseResponseFieldNumber = 1;
        private static readonly SnsCommentResponse defaultInstance = new SnsCommentResponse().MakeReadOnly();
        private bool hasBaseResponse;
        private bool hasSnsObject;
        private int memoizedSerializedSize = -1;
        private micromsg.SnsObject snsObject_;
        public const int SnsObjectFieldNumber = 2;

        static SnsCommentResponse()
        {
            
        }

        private SnsCommentResponse()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(SnsCommentResponse prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            SnsCommentResponse response = obj as SnsCommentResponse;
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

        private SnsCommentResponse MakeReadOnly()
        {
            return this;
        }

        public static SnsCommentResponse ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<SnsCommentResponse, Builder>.PrintField("BaseResponse", this.hasBaseResponse, this.baseResponse_, writer);
            GeneratedMessageLite<SnsCommentResponse, Builder>.PrintField("SnsObject", this.hasSnsObject, this.snsObject_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _snsCommentResponseFieldNames;
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

        public static SnsCommentResponse DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override SnsCommentResponse DefaultInstanceForType
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

        protected override SnsCommentResponse ThisMessage
        {
            get
            {
                return this;
            }
        }

        public sealed class Builder : GeneratedBuilderLite<SnsCommentResponse, SnsCommentResponse.Builder>
        {
            private SnsCommentResponse result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = SnsCommentResponse.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(SnsCommentResponse cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override SnsCommentResponse BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override SnsCommentResponse.Builder Clear()
            {
                this.result = SnsCommentResponse.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public SnsCommentResponse.Builder ClearBaseResponse()
            {
                this.PrepareBuilder();
                this.result.hasBaseResponse = false;
                this.result.baseResponse_ = null;
                return this;
            }

            public SnsCommentResponse.Builder ClearSnsObject()
            {
                this.PrepareBuilder();
                this.result.hasSnsObject = false;
                this.result.snsObject_ = null;
                return this;
            }

            public override SnsCommentResponse.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new SnsCommentResponse.Builder(this.result);
                }
                return new SnsCommentResponse.Builder().MergeFrom(this.result);
            }

            public SnsCommentResponse.Builder MergeBaseResponse(micromsg.BaseResponse value)
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

            public override SnsCommentResponse.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override SnsCommentResponse.Builder MergeFrom(IMessageLite other)
            {
                if (other is SnsCommentResponse)
                {
                    return this.MergeFrom((SnsCommentResponse) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override SnsCommentResponse.Builder MergeFrom(SnsCommentResponse other)
            {
                return this;
            }

            public override SnsCommentResponse.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(SnsCommentResponse._snsCommentResponseFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = SnsCommentResponse._snsCommentResponseFieldTags[index];
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

            public SnsCommentResponse.Builder MergeSnsObject(micromsg.SnsObject value)
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

            private SnsCommentResponse PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    SnsCommentResponse result = this.result;
                    this.result = new SnsCommentResponse();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public SnsCommentResponse.Builder SetBaseResponse(micromsg.BaseResponse value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = value;
                return this;
            }

            public SnsCommentResponse.Builder SetBaseResponse(micromsg.BaseResponse.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = builderForValue.Build();
                return this;
            }

            public SnsCommentResponse.Builder SetSnsObject(micromsg.SnsObject value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSnsObject = true;
                this.result.snsObject_ = value;
                return this;
            }

            public SnsCommentResponse.Builder SetSnsObject(micromsg.SnsObject.Builder builderForValue)
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

            public override SnsCommentResponse DefaultInstanceForType
            {
                get
                {
                    return SnsCommentResponse.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override SnsCommentResponse MessageBeingBuilt
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

            protected override SnsCommentResponse.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


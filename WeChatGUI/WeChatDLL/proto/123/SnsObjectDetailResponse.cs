namespace micromsg
{
    using Google.ProtocolBuffers;

    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    using System.Runtime.CompilerServices;


    public sealed class SnsObjectDetailResponse : GeneratedMessageLite<SnsObjectDetailResponse, SnsObjectDetailResponse.Builder>
    {
        private static readonly string[] _snsObjectDetailResponseFieldNames = new string[] { "BaseResponse", "Object" };
        private static readonly uint[] _snsObjectDetailResponseFieldTags = new uint[] { 10, 0x12 };
        private micromsg.BaseResponse baseResponse_;
        public const int BaseResponseFieldNumber = 1;
        private static readonly SnsObjectDetailResponse defaultInstance = new SnsObjectDetailResponse().MakeReadOnly();
        private bool hasBaseResponse;
        private bool hasObject;
        private int memoizedSerializedSize = -1;
        private SnsObject object_;
        public const int ObjectFieldNumber = 2;

        static SnsObjectDetailResponse()
        {

        }

        private SnsObjectDetailResponse()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(SnsObjectDetailResponse prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            SnsObjectDetailResponse response = obj as SnsObjectDetailResponse;
            if (response == null)
            {
                return false;
            }
            if ((this.hasBaseResponse != response.hasBaseResponse) || (this.hasBaseResponse && !this.baseResponse_.Equals(response.baseResponse_)))
            {
                return false;
            }
            return ((this.hasObject == response.hasObject) && (!this.hasObject || this.object_.Equals(response.object_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasBaseResponse)
            {
                hashCode ^= this.baseResponse_.GetHashCode();
            }
            if (this.hasObject)
            {
                hashCode ^= this.object_.GetHashCode();
            }
            return hashCode;
        }

        private SnsObjectDetailResponse MakeReadOnly()
        {
            return this;
        }

        public static SnsObjectDetailResponse ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<SnsObjectDetailResponse, Builder>.PrintField("BaseResponse", this.hasBaseResponse, this.baseResponse_, writer);
            GeneratedMessageLite<SnsObjectDetailResponse, Builder>.PrintField("Object", this.hasObject, this.object_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _snsObjectDetailResponseFieldNames;
            if (this.hasBaseResponse)
            {
                output.WriteMessage(1, strArray[0], this.BaseResponse);
            }
            if (this.hasObject)
            {
                output.WriteMessage(2, strArray[1], this.Object);
            }
        }

        public micromsg.BaseResponse BaseResponse
        {
            get
            {
                return (this.baseResponse_ ?? micromsg.BaseResponse.DefaultInstance);
            }
        }

        public static SnsObjectDetailResponse DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override SnsObjectDetailResponse DefaultInstanceForType
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
                if (!this.hasObject)
                {
                    return false;
                }
                if (!this.BaseResponse.IsInitialized)
                {
                    return false;
                }
                if (!this.Object.IsInitialized)
                {
                    return false;
                }
                return true;
            }
        }

        public SnsObject Object
        {
            get
            {
                return (this.object_ ?? SnsObject.DefaultInstance);
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
                    if (this.hasObject)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(2, this.Object);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override SnsObjectDetailResponse ThisMessage
        {
            get
            {
                return this;
            }
        }

        [GeneratedCode("ProtoGen", "2.3.0.277"), CompilerGenerated, DebuggerNonUserCode]
        public sealed class Builder : GeneratedBuilderLite<SnsObjectDetailResponse, SnsObjectDetailResponse.Builder>
        {
            private SnsObjectDetailResponse result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = SnsObjectDetailResponse.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(SnsObjectDetailResponse cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override SnsObjectDetailResponse BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override SnsObjectDetailResponse.Builder Clear()
            {
                this.result = SnsObjectDetailResponse.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public SnsObjectDetailResponse.Builder ClearBaseResponse()
            {
                this.PrepareBuilder();
                this.result.hasBaseResponse = false;
                this.result.baseResponse_ = null;
                return this;
            }

            public SnsObjectDetailResponse.Builder ClearObject()
            {
                this.PrepareBuilder();
                this.result.hasObject = false;
                this.result.object_ = null;
                return this;
            }

            public override SnsObjectDetailResponse.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new SnsObjectDetailResponse.Builder(this.result);
                }
                return new SnsObjectDetailResponse.Builder().MergeFrom(this.result);
            }

            public SnsObjectDetailResponse.Builder MergeBaseResponse(micromsg.BaseResponse value)
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

            public override SnsObjectDetailResponse.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override SnsObjectDetailResponse.Builder MergeFrom(IMessageLite other)
            {
                if (other is SnsObjectDetailResponse)
                {
                    return this.MergeFrom((SnsObjectDetailResponse) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override SnsObjectDetailResponse.Builder MergeFrom(SnsObjectDetailResponse other)
            {
                return this;
            }

            public override SnsObjectDetailResponse.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(SnsObjectDetailResponse._snsObjectDetailResponseFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = SnsObjectDetailResponse._snsObjectDetailResponseFieldTags[index];
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
                            SnsObject.Builder builder2 = SnsObject.CreateBuilder();
                            if (this.result.hasObject)
                            {
                                builder2.MergeFrom(this.Object);
                            }
                            input.ReadMessage(builder2, extensionRegistry);
                            this.Object = builder2.BuildPartial();
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

            public SnsObjectDetailResponse.Builder MergeObject(SnsObject value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasObject && (this.result.object_ != SnsObject.DefaultInstance))
                {
                    this.result.object_ = SnsObject.CreateBuilder(this.result.object_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.object_ = value;
                }
                this.result.hasObject = true;
                return this;
            }

            private SnsObjectDetailResponse PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    SnsObjectDetailResponse result = this.result;
                    this.result = new SnsObjectDetailResponse();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public SnsObjectDetailResponse.Builder SetBaseResponse(micromsg.BaseResponse value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = value;
                return this;
            }

            public SnsObjectDetailResponse.Builder SetBaseResponse(micromsg.BaseResponse.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = builderForValue.Build();
                return this;
            }

            public SnsObjectDetailResponse.Builder SetObject(SnsObject value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasObject = true;
                this.result.object_ = value;
                return this;
            }

            public SnsObjectDetailResponse.Builder SetObject(SnsObject.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasObject = true;
                this.result.object_ = builderForValue.Build();
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

            public override SnsObjectDetailResponse DefaultInstanceForType
            {
                get
                {
                    return SnsObjectDetailResponse.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override SnsObjectDetailResponse MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public SnsObject Object
            {
                get
                {
                    return this.result.Object;
                }
                set
                {
                    this.SetObject(value);
                }
            }

            protected override SnsObjectDetailResponse.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


namespace micromsg
{
    using Google.ProtocolBuffers;

    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    using System.Runtime.CompilerServices;

    public sealed class AddSafeDeviceResponse : GeneratedMessageLite<AddSafeDeviceResponse, AddSafeDeviceResponse.Builder>
    {
        private static readonly string[] _addSafeDeviceResponseFieldNames = new string[] { "BaseResponse", "SafeDeviceList" };
        private static readonly uint[] _addSafeDeviceResponseFieldTags = new uint[] { 10, 0x12 };
        private micromsg.BaseResponse baseResponse_;
        public const int BaseResponseFieldNumber = 1;
        private static readonly AddSafeDeviceResponse defaultInstance = new AddSafeDeviceResponse().MakeReadOnly();
        private bool hasBaseResponse;
        private bool hasSafeDeviceList;
        private int memoizedSerializedSize = -1;
        private micromsg.SafeDeviceList safeDeviceList_;
        public const int SafeDeviceListFieldNumber = 2;

        static AddSafeDeviceResponse()
        {
           
        }

        private AddSafeDeviceResponse()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(AddSafeDeviceResponse prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            AddSafeDeviceResponse response = obj as AddSafeDeviceResponse;
            if (response == null)
            {
                return false;
            }
            if ((this.hasBaseResponse != response.hasBaseResponse) || (this.hasBaseResponse && !this.baseResponse_.Equals(response.baseResponse_)))
            {
                return false;
            }
            return ((this.hasSafeDeviceList == response.hasSafeDeviceList) && (!this.hasSafeDeviceList || this.safeDeviceList_.Equals(response.safeDeviceList_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasBaseResponse)
            {
                hashCode ^= this.baseResponse_.GetHashCode();
            }
            if (this.hasSafeDeviceList)
            {
                hashCode ^= this.safeDeviceList_.GetHashCode();
            }
            return hashCode;
        }

        private AddSafeDeviceResponse MakeReadOnly()
        {
            return this;
        }

        public static AddSafeDeviceResponse ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<AddSafeDeviceResponse, Builder>.PrintField("BaseResponse", this.hasBaseResponse, this.baseResponse_, writer);
            GeneratedMessageLite<AddSafeDeviceResponse, Builder>.PrintField("SafeDeviceList", this.hasSafeDeviceList, this.safeDeviceList_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _addSafeDeviceResponseFieldNames;
            if (this.hasBaseResponse)
            {
                output.WriteMessage(1, strArray[0], this.BaseResponse);
            }
            if (this.hasSafeDeviceList)
            {
                output.WriteMessage(2, strArray[1], this.SafeDeviceList);
            }
        }

        public micromsg.BaseResponse BaseResponse
        {
            get
            {
                return (this.baseResponse_ ?? micromsg.BaseResponse.DefaultInstance);
            }
        }

        public static AddSafeDeviceResponse DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override AddSafeDeviceResponse DefaultInstanceForType
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
                if (!this.BaseResponse.IsInitialized)
                {
                    return false;
                }
                return true;
            }
        }

        public micromsg.SafeDeviceList SafeDeviceList
        {
            get
            {
                return (this.safeDeviceList_ ?? micromsg.SafeDeviceList.DefaultInstance);
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
                    if (this.hasSafeDeviceList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(2, this.SafeDeviceList);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override AddSafeDeviceResponse ThisMessage
        {
            get
            {
                return this;
            }
        }

        [GeneratedCode("ProtoGen", "2.3.0.277"), DebuggerNonUserCode, CompilerGenerated]
        public sealed class Builder : GeneratedBuilderLite<AddSafeDeviceResponse, AddSafeDeviceResponse.Builder>
        {
            private AddSafeDeviceResponse result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = AddSafeDeviceResponse.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(AddSafeDeviceResponse cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override AddSafeDeviceResponse BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override AddSafeDeviceResponse.Builder Clear()
            {
                this.result = AddSafeDeviceResponse.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public AddSafeDeviceResponse.Builder ClearBaseResponse()
            {
                this.PrepareBuilder();
                this.result.hasBaseResponse = false;
                this.result.baseResponse_ = null;
                return this;
            }

            public AddSafeDeviceResponse.Builder ClearSafeDeviceList()
            {
                this.PrepareBuilder();
                this.result.hasSafeDeviceList = false;
                this.result.safeDeviceList_ = null;
                return this;
            }

            public override AddSafeDeviceResponse.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new AddSafeDeviceResponse.Builder(this.result);
                }
                return new AddSafeDeviceResponse.Builder().MergeFrom(this.result);
            }

            public AddSafeDeviceResponse.Builder MergeBaseResponse(micromsg.BaseResponse value)
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

            public override AddSafeDeviceResponse.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override AddSafeDeviceResponse.Builder MergeFrom(IMessageLite other)
            {
                if (other is AddSafeDeviceResponse)
                {
                    return this.MergeFrom((AddSafeDeviceResponse) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override AddSafeDeviceResponse.Builder MergeFrom(AddSafeDeviceResponse other)
            {
                return this;
            }

            public override AddSafeDeviceResponse.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(AddSafeDeviceResponse._addSafeDeviceResponseFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = AddSafeDeviceResponse._addSafeDeviceResponseFieldTags[index];
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
                            micromsg.SafeDeviceList.Builder builder2 = micromsg.SafeDeviceList.CreateBuilder();
                            if (this.result.hasSafeDeviceList)
                            {
                                builder2.MergeFrom(this.SafeDeviceList);
                            }
                            input.ReadMessage(builder2, extensionRegistry);
                            this.SafeDeviceList = builder2.BuildPartial();
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

            public AddSafeDeviceResponse.Builder MergeSafeDeviceList(micromsg.SafeDeviceList value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasSafeDeviceList && (this.result.safeDeviceList_ != micromsg.SafeDeviceList.DefaultInstance))
                {
                    this.result.safeDeviceList_ = micromsg.SafeDeviceList.CreateBuilder(this.result.safeDeviceList_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.safeDeviceList_ = value;
                }
                this.result.hasSafeDeviceList = true;
                return this;
            }

            private AddSafeDeviceResponse PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    AddSafeDeviceResponse result = this.result;
                    this.result = new AddSafeDeviceResponse();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public AddSafeDeviceResponse.Builder SetBaseResponse(micromsg.BaseResponse value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = value;
                return this;
            }

            public AddSafeDeviceResponse.Builder SetBaseResponse(micromsg.BaseResponse.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = builderForValue.Build();
                return this;
            }

            public AddSafeDeviceResponse.Builder SetSafeDeviceList(micromsg.SafeDeviceList value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSafeDeviceList = true;
                this.result.safeDeviceList_ = value;
                return this;
            }

            public AddSafeDeviceResponse.Builder SetSafeDeviceList(micromsg.SafeDeviceList.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasSafeDeviceList = true;
                this.result.safeDeviceList_ = builderForValue.Build();
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

            public override AddSafeDeviceResponse DefaultInstanceForType
            {
                get
                {
                    return AddSafeDeviceResponse.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override AddSafeDeviceResponse MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public micromsg.SafeDeviceList SafeDeviceList
            {
                get
                {
                    return this.result.SafeDeviceList;
                }
                set
                {
                    this.SetSafeDeviceList(value);
                }
            }

            protected override AddSafeDeviceResponse.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


namespace micromsg
{
    using Google.ProtocolBuffers;
    
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

    //
    public sealed class SendCardResponse : GeneratedMessageLite<SendCardResponse, SendCardResponse.Builder>
    {
        private static readonly string[] _sendCardResponseFieldNames = new string[] { "BaseResponse" };
        private static readonly uint[] _sendCardResponseFieldTags = new uint[] { 10 };
        private micromsg.BaseResponse baseResponse_;
        public const int BaseResponseFieldNumber = 1;
        private static readonly SendCardResponse defaultInstance = new SendCardResponse().MakeReadOnly();
        private bool hasBaseResponse;
        private int memoizedSerializedSize = -1;

        static SendCardResponse()
        {
           // object.ReferenceEquals(SendCardResponse.Descriptor, null);
        }

        private SendCardResponse()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(SendCardResponse prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            SendCardResponse response = obj as SendCardResponse;
            if (response == null)
            {
                return false;
            }
            return ((this.hasBaseResponse == response.hasBaseResponse) && (!this.hasBaseResponse || this.baseResponse_.Equals(response.baseResponse_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasBaseResponse)
            {
                hashCode ^= this.baseResponse_.GetHashCode();
            }
            return hashCode;
        }

        private SendCardResponse MakeReadOnly()
        {
            return this;
        }

        public static SendCardResponse ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<SendCardResponse, Builder>.PrintField("BaseResponse", this.hasBaseResponse, this.baseResponse_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _sendCardResponseFieldNames;
            if (this.hasBaseResponse)
            {
                output.WriteMessage(1, strArray[0], this.BaseResponse);
            }
        }

        public micromsg.BaseResponse BaseResponse
        {
            get
            {
                return (this.baseResponse_ ?? micromsg.BaseResponse.DefaultInstance);
            }
        }

        public static SendCardResponse DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override SendCardResponse DefaultInstanceForType
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
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override SendCardResponse ThisMessage
        {
            get
            {
                return this;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<SendCardResponse, SendCardResponse.Builder>
        {
            private SendCardResponse result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = SendCardResponse.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(SendCardResponse cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override SendCardResponse BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override SendCardResponse.Builder Clear()
            {
                this.result = SendCardResponse.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public SendCardResponse.Builder ClearBaseResponse()
            {
                this.PrepareBuilder();
                this.result.hasBaseResponse = false;
                this.result.baseResponse_ = null;
                return this;
            }

            public override SendCardResponse.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new SendCardResponse.Builder(this.result);
                }
                return new SendCardResponse.Builder().MergeFrom(this.result);
            }

            public SendCardResponse.Builder MergeBaseResponse(micromsg.BaseResponse value)
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

            public override SendCardResponse.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override SendCardResponse.Builder MergeFrom(IMessageLite other)
            {
                if (other is SendCardResponse)
                {
                    return this.MergeFrom((SendCardResponse) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override SendCardResponse.Builder MergeFrom(SendCardResponse other)
            {
                return this;
            }

            public override SendCardResponse.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(SendCardResponse._sendCardResponseFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = SendCardResponse._sendCardResponseFieldTags[index];
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
                    }
                    if (WireFormat.IsEndGroupTag(num))
                    {
                        return this;
                    }
                    this.ParseUnknownField(input, extensionRegistry, num, str);
                }
                return this;
            }

            private SendCardResponse PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    SendCardResponse result = this.result;
                    this.result = new SendCardResponse();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public SendCardResponse.Builder SetBaseResponse(micromsg.BaseResponse value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = value;
                return this;
            }

            public SendCardResponse.Builder SetBaseResponse(micromsg.BaseResponse.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = builderForValue.Build();
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

            public override SendCardResponse DefaultInstanceForType
            {
                get
                {
                    return SendCardResponse.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override SendCardResponse MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override SendCardResponse.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


namespace micromsg
{
    using Google.ProtocolBuffers;

    using System;
    using System.IO;



    public sealed class TenPayRequest : GeneratedMessageLite<TenPayRequest, TenPayRequest.Builder>
    {
        private static readonly string[] _tenPayRequestFieldNames = new string[] { "BaseRequest", "CgiCmd", "OutPutType", "ReqText", "ReqTextWx" };
        private static readonly uint[] _tenPayRequestFieldTags = new uint[] { 10, 0x10, 0x18, 0x22, 0x2a };
        private BaseRequest baseRequest_;
        public const int BaseRequestFieldNumber = 1;
        private uint cgiCmd_;
        public const int CgiCmdFieldNumber = 2;
        private static readonly TenPayRequest defaultInstance = new TenPayRequest().MakeReadOnly();
        private bool hasBaseRequest;
        private bool hasCgiCmd;
        private bool hasOutPutType;
        private bool hasReqText;
        private bool hasReqTextWx;
        private int memoizedSerializedSize = -1;
        private uint outPutType_;
        public const int OutPutTypeFieldNumber = 3;
        private SKBuiltinBuffer_t reqText_;
        public const int ReqTextFieldNumber = 4;
        private SKBuiltinBuffer_t reqTextWx_;
        public const int ReqTextWxFieldNumber = 5;

        static TenPayRequest()
        {

        }

        private TenPayRequest()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(TenPayRequest prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            TenPayRequest request = obj as TenPayRequest;
            if (request == null)
            {
                return false;
            }
            if ((this.hasBaseRequest != request.hasBaseRequest) || (this.hasBaseRequest && !this.baseRequest_.Equals(request.baseRequest_)))
            {
                return false;
            }
            if ((this.hasCgiCmd != request.hasCgiCmd) || (this.hasCgiCmd && !this.cgiCmd_.Equals(request.cgiCmd_)))
            {
                return false;
            }
            if ((this.hasOutPutType != request.hasOutPutType) || (this.hasOutPutType && !this.outPutType_.Equals(request.outPutType_)))
            {
                return false;
            }
            if ((this.hasReqText != request.hasReqText) || (this.hasReqText && !this.reqText_.Equals(request.reqText_)))
            {
                return false;
            }
            return ((this.hasReqTextWx == request.hasReqTextWx) && (!this.hasReqTextWx || this.reqTextWx_.Equals(request.reqTextWx_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasBaseRequest)
            {
                hashCode ^= this.baseRequest_.GetHashCode();
            }
            if (this.hasCgiCmd)
            {
                hashCode ^= this.cgiCmd_.GetHashCode();
            }
            if (this.hasOutPutType)
            {
                hashCode ^= this.outPutType_.GetHashCode();
            }
            if (this.hasReqText)
            {
                hashCode ^= this.reqText_.GetHashCode();
            }
            if (this.hasReqTextWx)
            {
                hashCode ^= this.reqTextWx_.GetHashCode();
            }
            return hashCode;
        }

        private TenPayRequest MakeReadOnly()
        {
            return this;
        }

        public static TenPayRequest ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<TenPayRequest, Builder>.PrintField("BaseRequest", this.hasBaseRequest, this.baseRequest_, writer);
            GeneratedMessageLite<TenPayRequest, Builder>.PrintField("CgiCmd", this.hasCgiCmd, this.cgiCmd_, writer);
            GeneratedMessageLite<TenPayRequest, Builder>.PrintField("OutPutType", this.hasOutPutType, this.outPutType_, writer);
            GeneratedMessageLite<TenPayRequest, Builder>.PrintField("ReqText", this.hasReqText, this.reqText_, writer);
            GeneratedMessageLite<TenPayRequest, Builder>.PrintField("ReqTextWx", this.hasReqTextWx, this.reqTextWx_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _tenPayRequestFieldNames;
            if (this.hasBaseRequest)
            {
                output.WriteMessage(1, strArray[0], this.BaseRequest);
            }
            if (this.hasCgiCmd)
            {
                output.WriteUInt32(2, strArray[1], this.CgiCmd);
            }
            if (this.hasOutPutType)
            {
                output.WriteUInt32(3, strArray[2], this.OutPutType);
            }
            if (this.hasReqText)
            {
                output.WriteMessage(4, strArray[3], this.ReqText);
            }
            if (this.hasReqTextWx)
            {
                output.WriteMessage(5, strArray[4], this.ReqTextWx);
            }
        }

        public BaseRequest BaseRequest
        {
            get
            {
                return (this.baseRequest_ ?? BaseRequest.DefaultInstance);
            }
        }

        public uint CgiCmd
        {
            get
            {
                return this.cgiCmd_;
            }
        }

        public static TenPayRequest DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override TenPayRequest DefaultInstanceForType
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
                if (!this.hasCgiCmd)
                {
                    return false;
                }
                if (!this.hasOutPutType)
                {
                    return false;
                }
                if (!this.hasReqText)
                {
                    return false;
                }
                if (!this.BaseRequest.IsInitialized)
                {
                    return false;
                }
                if (!this.ReqText.IsInitialized)
                {
                    return false;
                }
                return true;
            }
        }

        public uint OutPutType
        {
            get
            {
                return this.outPutType_;
            }
        }

        public SKBuiltinBuffer_t ReqText
        {
            get
            {
                return (this.reqText_ ?? SKBuiltinBuffer_t.DefaultInstance);
            }
        }

        public SKBuiltinBuffer_t ReqTextWx
        {
            get
            {
                return (this.reqTextWx_ ?? SKBuiltinBuffer_t.DefaultInstance);
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
                    if (this.hasCgiCmd)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(2, this.CgiCmd);
                    }
                    if (this.hasOutPutType)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(3, this.OutPutType);
                    }
                    if (this.hasReqText)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(4, this.ReqText);
                    }
                    if (this.hasReqTextWx)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(5, this.ReqTextWx);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override TenPayRequest ThisMessage
        {
            get
            {
                return this;
            }
        }

      
        public sealed class Builder : GeneratedBuilderLite<TenPayRequest, TenPayRequest.Builder>
        {
            private TenPayRequest result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = TenPayRequest.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(TenPayRequest cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override TenPayRequest BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override TenPayRequest.Builder Clear()
            {
                this.result = TenPayRequest.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public TenPayRequest.Builder ClearBaseRequest()
            {
                this.PrepareBuilder();
                this.result.hasBaseRequest = false;
                this.result.baseRequest_ = null;
                return this;
            }

            public TenPayRequest.Builder ClearCgiCmd()
            {
                this.PrepareBuilder();
                this.result.hasCgiCmd = false;
                this.result.cgiCmd_ = 0;
                return this;
            }

            public TenPayRequest.Builder ClearOutPutType()
            {
                this.PrepareBuilder();
                this.result.hasOutPutType = false;
                this.result.outPutType_ = 0;
                return this;
            }

            public TenPayRequest.Builder ClearReqText()
            {
                this.PrepareBuilder();
                this.result.hasReqText = false;
                this.result.reqText_ = null;
                return this;
            }

            public TenPayRequest.Builder ClearReqTextWx()
            {
                this.PrepareBuilder();
                this.result.hasReqTextWx = false;
                this.result.reqTextWx_ = null;
                return this;
            }

            public override TenPayRequest.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new TenPayRequest.Builder(this.result);
                }
                return new TenPayRequest.Builder().MergeFrom(this.result);
            }

            public TenPayRequest.Builder MergeBaseRequest(BaseRequest value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasBaseRequest && (this.result.baseRequest_ != BaseRequest.DefaultInstance))
                {
                    this.result.baseRequest_ = BaseRequest.CreateBuilder(this.result.baseRequest_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.baseRequest_ = value;
                }
                this.result.hasBaseRequest = true;
                return this;
            }

            public override TenPayRequest.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override TenPayRequest.Builder MergeFrom(IMessageLite other)
            {
                if (other is TenPayRequest)
                {
                    return this.MergeFrom((TenPayRequest) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override TenPayRequest.Builder MergeFrom(TenPayRequest other)
            {
                return this;
            }

            public override TenPayRequest.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(TenPayRequest._tenPayRequestFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = TenPayRequest._tenPayRequestFieldTags[index];
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
                            BaseRequest.Builder builder = BaseRequest.CreateBuilder();
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
                            this.result.hasCgiCmd = input.ReadUInt32(ref this.result.cgiCmd_);
                            continue;
                        }
                        case 0x18:
                        {
                            this.result.hasOutPutType = input.ReadUInt32(ref this.result.outPutType_);
                            continue;
                        }
                        case 0x22:
                        {
                            SKBuiltinBuffer_t.Builder builder2 = SKBuiltinBuffer_t.CreateBuilder();
                            if (this.result.hasReqText)
                            {
                                builder2.MergeFrom(this.ReqText);
                            }
                            input.ReadMessage(builder2, extensionRegistry);
                            this.ReqText = builder2.BuildPartial();
                            continue;
                        }
                        case 0x2a:
                        {
                            SKBuiltinBuffer_t.Builder builder3 = SKBuiltinBuffer_t.CreateBuilder();
                            if (this.result.hasReqTextWx)
                            {
                                builder3.MergeFrom(this.ReqTextWx);
                            }
                            input.ReadMessage(builder3, extensionRegistry);
                            this.ReqTextWx = builder3.BuildPartial();
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

            public TenPayRequest.Builder MergeReqText(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasReqText && (this.result.reqText_ != SKBuiltinBuffer_t.DefaultInstance))
                {
                    this.result.reqText_ = SKBuiltinBuffer_t.CreateBuilder(this.result.reqText_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.reqText_ = value;
                }
                this.result.hasReqText = true;
                return this;
            }

            public TenPayRequest.Builder MergeReqTextWx(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasReqTextWx && (this.result.reqTextWx_ != SKBuiltinBuffer_t.DefaultInstance))
                {
                    this.result.reqTextWx_ = SKBuiltinBuffer_t.CreateBuilder(this.result.reqTextWx_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.reqTextWx_ = value;
                }
                this.result.hasReqTextWx = true;
                return this;
            }

            private TenPayRequest PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    TenPayRequest result = this.result;
                    this.result = new TenPayRequest();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public TenPayRequest.Builder SetBaseRequest(BaseRequest value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = value;
                return this;
            }

            public TenPayRequest.Builder SetBaseRequest(BaseRequest.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = builderForValue.Build();
                return this;
            }

            public TenPayRequest.Builder SetCgiCmd(uint value)
            {
                this.PrepareBuilder();
                this.result.hasCgiCmd = true;
                this.result.cgiCmd_ = value;
                return this;
            }

            public TenPayRequest.Builder SetOutPutType(uint value)
            {
                this.PrepareBuilder();
                this.result.hasOutPutType = true;
                this.result.outPutType_ = value;
                return this;
            }

            public TenPayRequest.Builder SetReqText(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasReqText = true;
                this.result.reqText_ = value;
                return this;
            }

            public TenPayRequest.Builder SetReqText(SKBuiltinBuffer_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasReqText = true;
                this.result.reqText_ = builderForValue.Build();
                return this;
            }

            public TenPayRequest.Builder SetReqTextWx(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasReqTextWx = true;
                this.result.reqTextWx_ = value;
                return this;
            }

            public TenPayRequest.Builder SetReqTextWx(SKBuiltinBuffer_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasReqTextWx = true;
                this.result.reqTextWx_ = builderForValue.Build();
                return this;
            }

            public BaseRequest BaseRequest
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

            public uint CgiCmd
            {
                get
                {
                    return this.result.CgiCmd;
                }
                set
                {
                    this.SetCgiCmd(value);
                }
            }

            public override TenPayRequest DefaultInstanceForType
            {
                get
                {
                    return TenPayRequest.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override TenPayRequest MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public uint OutPutType
            {
                get
                {
                    return this.result.OutPutType;
                }
                set
                {
                    this.SetOutPutType(value);
                }
            }

            public SKBuiltinBuffer_t ReqText
            {
                get
                {
                    return this.result.ReqText;
                }
                set
                {
                    this.SetReqText(value);
                }
            }

            public SKBuiltinBuffer_t ReqTextWx
            {
                get
                {
                    return this.result.ReqTextWx;
                }
                set
                {
                    this.SetReqTextWx(value);
                }
            }

            protected override TenPayRequest.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}

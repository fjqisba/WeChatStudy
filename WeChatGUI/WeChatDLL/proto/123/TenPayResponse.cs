namespace micromsg
{
    using Google.ProtocolBuffers;

    using System;
    using System.IO;


    public sealed class TenPayResponse : GeneratedMessageLite<TenPayResponse, TenPayResponse.Builder>
    {
        private static readonly string[] _tenPayResponseFieldNames = new string[] { "BaseResponse", "CgiCmdid", "PlatMsg", "PlatRet", "RetText", "TenpayErrMsg", "TenpayErrType" };
        private static readonly uint[] _tenPayResponseFieldTags = new uint[] { 10, 40, 0x22, 0x18, 0x12, 0x3a, 0x30 };
        private BaseResponse baseResponse_;
        public const int BaseResponseFieldNumber = 1;
        private int cgiCmdid_;
        public const int CgiCmdidFieldNumber = 5;
        private static readonly TenPayResponse defaultInstance = new TenPayResponse().MakeReadOnly();
        private bool hasBaseResponse;
        private bool hasCgiCmdid;
        private bool hasPlatMsg;
        private bool hasPlatRet;
        private bool hasRetText;
        private bool hasTenpayErrMsg;
        private bool hasTenpayErrType;
        private int memoizedSerializedSize = -1;
        private string platMsg_ = "";
        public const int PlatMsgFieldNumber = 4;
        private int platRet_;
        public const int PlatRetFieldNumber = 3;
        private SKBuiltinBuffer_t retText_;
        public const int RetTextFieldNumber = 2;
        private string tenpayErrMsg_ = "";
        public const int TenpayErrMsgFieldNumber = 7;
        private int tenpayErrType_;
        public const int TenpayErrTypeFieldNumber = 6;

        static TenPayResponse()
        {
           
        }

        private TenPayResponse()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(TenPayResponse prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            TenPayResponse response = obj as TenPayResponse;
            if (response == null)
            {
                return false;
            }
            if ((this.hasBaseResponse != response.hasBaseResponse) || (this.hasBaseResponse && !this.baseResponse_.Equals(response.baseResponse_)))
            {
                return false;
            }
            if ((this.hasRetText != response.hasRetText) || (this.hasRetText && !this.retText_.Equals(response.retText_)))
            {
                return false;
            }
            if ((this.hasPlatRet != response.hasPlatRet) || (this.hasPlatRet && !this.platRet_.Equals(response.platRet_)))
            {
                return false;
            }
            if ((this.hasPlatMsg != response.hasPlatMsg) || (this.hasPlatMsg && !this.platMsg_.Equals(response.platMsg_)))
            {
                return false;
            }
            if ((this.hasCgiCmdid != response.hasCgiCmdid) || (this.hasCgiCmdid && !this.cgiCmdid_.Equals(response.cgiCmdid_)))
            {
                return false;
            }
            if ((this.hasTenpayErrType != response.hasTenpayErrType) || (this.hasTenpayErrType && !this.tenpayErrType_.Equals(response.tenpayErrType_)))
            {
                return false;
            }
            return ((this.hasTenpayErrMsg == response.hasTenpayErrMsg) && (!this.hasTenpayErrMsg || this.tenpayErrMsg_.Equals(response.tenpayErrMsg_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasBaseResponse)
            {
                hashCode ^= this.baseResponse_.GetHashCode();
            }
            if (this.hasRetText)
            {
                hashCode ^= this.retText_.GetHashCode();
            }
            if (this.hasPlatRet)
            {
                hashCode ^= this.platRet_.GetHashCode();
            }
            if (this.hasPlatMsg)
            {
                hashCode ^= this.platMsg_.GetHashCode();
            }
            if (this.hasCgiCmdid)
            {
                hashCode ^= this.cgiCmdid_.GetHashCode();
            }
            if (this.hasTenpayErrType)
            {
                hashCode ^= this.tenpayErrType_.GetHashCode();
            }
            if (this.hasTenpayErrMsg)
            {
                hashCode ^= this.tenpayErrMsg_.GetHashCode();
            }
            return hashCode;
        }

        private TenPayResponse MakeReadOnly()
        {
            return this;
        }

        public static TenPayResponse ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<TenPayResponse, Builder>.PrintField("BaseResponse", this.hasBaseResponse, this.baseResponse_, writer);
            GeneratedMessageLite<TenPayResponse, Builder>.PrintField("RetText", this.hasRetText, this.retText_, writer);
            GeneratedMessageLite<TenPayResponse, Builder>.PrintField("PlatRet", this.hasPlatRet, this.platRet_, writer);
            GeneratedMessageLite<TenPayResponse, Builder>.PrintField("PlatMsg", this.hasPlatMsg, this.platMsg_, writer);
            GeneratedMessageLite<TenPayResponse, Builder>.PrintField("CgiCmdid", this.hasCgiCmdid, this.cgiCmdid_, writer);
            GeneratedMessageLite<TenPayResponse, Builder>.PrintField("TenpayErrType", this.hasTenpayErrType, this.tenpayErrType_, writer);
            GeneratedMessageLite<TenPayResponse, Builder>.PrintField("TenpayErrMsg", this.hasTenpayErrMsg, this.tenpayErrMsg_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _tenPayResponseFieldNames;
            if (this.hasBaseResponse)
            {
                output.WriteMessage(1, strArray[0], this.BaseResponse);
            }
            if (this.hasRetText)
            {
                output.WriteMessage(2, strArray[4], this.RetText);
            }
            if (this.hasPlatRet)
            {
                output.WriteInt32(3, strArray[3], this.PlatRet);
            }
            if (this.hasPlatMsg)
            {
                output.WriteString(4, strArray[2], this.PlatMsg);
            }
            if (this.hasCgiCmdid)
            {
                output.WriteInt32(5, strArray[1], this.CgiCmdid);
            }
            if (this.hasTenpayErrType)
            {
                output.WriteInt32(6, strArray[6], this.TenpayErrType);
            }
            if (this.hasTenpayErrMsg)
            {
                output.WriteString(7, strArray[5], this.TenpayErrMsg);
            }
        }

        public BaseResponse BaseResponse
        {
            get
            {
                return (this.baseResponse_ ?? BaseResponse.DefaultInstance);
            }
        }

        public int CgiCmdid
        {
            get
            {
                return this.cgiCmdid_;
            }
        }

        public static TenPayResponse DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override TenPayResponse DefaultInstanceForType
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
                if (!this.hasPlatRet)
                {
                    return false;
                }
                if (!this.hasCgiCmdid)
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

        public string PlatMsg
        {
            get
            {
                return this.platMsg_;
            }
        }

        public int PlatRet
        {
            get
            {
                return this.platRet_;
            }
        }

        public SKBuiltinBuffer_t RetText
        {
            get
            {
                return (this.retText_ ?? SKBuiltinBuffer_t.DefaultInstance);
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
                    if (this.hasRetText)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(2, this.RetText);
                    }
                    if (this.hasPlatRet)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(3, this.PlatRet);
                    }
                    if (this.hasPlatMsg)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(4, this.PlatMsg);
                    }
                    if (this.hasCgiCmdid)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(5, this.CgiCmdid);
                    }
                    if (this.hasTenpayErrType)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(6, this.TenpayErrType);
                    }
                    if (this.hasTenpayErrMsg)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(7, this.TenpayErrMsg);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        public string TenpayErrMsg
        {
            get
            {
                return this.tenpayErrMsg_;
            }
        }

        public int TenpayErrType
        {
            get
            {
                return this.tenpayErrType_;
            }
        }

        protected override TenPayResponse ThisMessage
        {
            get
            {
                return this;
            }
        }

        public sealed class Builder : GeneratedBuilderLite<TenPayResponse, TenPayResponse.Builder>
        {
            private TenPayResponse result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = TenPayResponse.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(TenPayResponse cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override TenPayResponse BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override TenPayResponse.Builder Clear()
            {
                this.result = TenPayResponse.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public TenPayResponse.Builder ClearBaseResponse()
            {
                this.PrepareBuilder();
                this.result.hasBaseResponse = false;
                this.result.baseResponse_ = null;
                return this;
            }

            public TenPayResponse.Builder ClearCgiCmdid()
            {
                this.PrepareBuilder();
                this.result.hasCgiCmdid = false;
                this.result.cgiCmdid_ = 0;
                return this;
            }

            public TenPayResponse.Builder ClearPlatMsg()
            {
                this.PrepareBuilder();
                this.result.hasPlatMsg = false;
                this.result.platMsg_ = "";
                return this;
            }

            public TenPayResponse.Builder ClearPlatRet()
            {
                this.PrepareBuilder();
                this.result.hasPlatRet = false;
                this.result.platRet_ = 0;
                return this;
            }

            public TenPayResponse.Builder ClearRetText()
            {
                this.PrepareBuilder();
                this.result.hasRetText = false;
                this.result.retText_ = null;
                return this;
            }

            public TenPayResponse.Builder ClearTenpayErrMsg()
            {
                this.PrepareBuilder();
                this.result.hasTenpayErrMsg = false;
                this.result.tenpayErrMsg_ = "";
                return this;
            }

            public TenPayResponse.Builder ClearTenpayErrType()
            {
                this.PrepareBuilder();
                this.result.hasTenpayErrType = false;
                this.result.tenpayErrType_ = 0;
                return this;
            }

            public override TenPayResponse.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new TenPayResponse.Builder(this.result);
                }
                return new TenPayResponse.Builder().MergeFrom(this.result);
            }

            public TenPayResponse.Builder MergeBaseResponse(BaseResponse value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasBaseResponse && (this.result.baseResponse_ != BaseResponse.DefaultInstance))
                {
                    this.result.baseResponse_ = BaseResponse.CreateBuilder(this.result.baseResponse_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.baseResponse_ = value;
                }
                this.result.hasBaseResponse = true;
                return this;
            }

            public override TenPayResponse.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override TenPayResponse.Builder MergeFrom(IMessageLite other)
            {
                if (other is TenPayResponse)
                {
                    return this.MergeFrom((TenPayResponse) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override TenPayResponse.Builder MergeFrom(TenPayResponse other)
            {
                return this;
            }

            public override TenPayResponse.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(TenPayResponse._tenPayResponseFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = TenPayResponse._tenPayResponseFieldTags[index];
                        }
                        else
                        {
                            this.ParseUnknownField(input, extensionRegistry, num, str);
                            continue;
                        }
                    }
                    switch (num)
                    {
                        case 0x12:
                        {
                            SKBuiltinBuffer_t.Builder builder2 = SKBuiltinBuffer_t.CreateBuilder();
                            if (this.result.hasRetText)
                            {
                                builder2.MergeFrom(this.RetText);
                            }
                            input.ReadMessage(builder2, extensionRegistry);
                            this.RetText = builder2.BuildPartial();
                            continue;
                        }
                        case 0x18:
                        {
                            this.result.hasPlatRet = input.ReadInt32(ref this.result.platRet_);
                            continue;
                        }
                        case 0:
                            throw InvalidProtocolBufferException.InvalidTag();

                        case 10:
                        {
                            BaseResponse.Builder builder = BaseResponse.CreateBuilder();
                            if (this.result.hasBaseResponse)
                            {
                                builder.MergeFrom(this.BaseResponse);
                            }
                            input.ReadMessage(builder, extensionRegistry);
                            this.BaseResponse = builder.BuildPartial();
                            continue;
                        }
                        case 0x22:
                        {
                            this.result.hasPlatMsg = input.ReadString(ref this.result.platMsg_);
                            continue;
                        }
                        case 40:
                        {
                            this.result.hasCgiCmdid = input.ReadInt32(ref this.result.cgiCmdid_);
                            continue;
                        }
                        case 0x30:
                        {
                            this.result.hasTenpayErrType = input.ReadInt32(ref this.result.tenpayErrType_);
                            continue;
                        }
                        case 0x3a:
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
                    this.result.hasTenpayErrMsg = input.ReadString(ref this.result.tenpayErrMsg_);
                }
                return this;
            }

            public TenPayResponse.Builder MergeRetText(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasRetText && (this.result.retText_ != SKBuiltinBuffer_t.DefaultInstance))
                {
                    this.result.retText_ = SKBuiltinBuffer_t.CreateBuilder(this.result.retText_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.retText_ = value;
                }
                this.result.hasRetText = true;
                return this;
            }

            private TenPayResponse PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    TenPayResponse result = this.result;
                    this.result = new TenPayResponse();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public TenPayResponse.Builder SetBaseResponse(BaseResponse value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = value;
                return this;
            }

            public TenPayResponse.Builder SetBaseResponse(BaseResponse.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = builderForValue.Build();
                return this;
            }

            public TenPayResponse.Builder SetCgiCmdid(int value)
            {
                this.PrepareBuilder();
                this.result.hasCgiCmdid = true;
                this.result.cgiCmdid_ = value;
                return this;
            }

            public TenPayResponse.Builder SetPlatMsg(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasPlatMsg = true;
                this.result.platMsg_ = value;
                return this;
            }

            public TenPayResponse.Builder SetPlatRet(int value)
            {
                this.PrepareBuilder();
                this.result.hasPlatRet = true;
                this.result.platRet_ = value;
                return this;
            }

            public TenPayResponse.Builder SetRetText(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasRetText = true;
                this.result.retText_ = value;
                return this;
            }

            public TenPayResponse.Builder SetRetText(SKBuiltinBuffer_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasRetText = true;
                this.result.retText_ = builderForValue.Build();
                return this;
            }

            public TenPayResponse.Builder SetTenpayErrMsg(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasTenpayErrMsg = true;
                this.result.tenpayErrMsg_ = value;
                return this;
            }

            public TenPayResponse.Builder SetTenpayErrType(int value)
            {
                this.PrepareBuilder();
                this.result.hasTenpayErrType = true;
                this.result.tenpayErrType_ = value;
                return this;
            }

            public BaseResponse BaseResponse
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

            public int CgiCmdid
            {
                get
                {
                    return this.result.CgiCmdid;
                }
                set
                {
                    this.SetCgiCmdid(value);
                }
            }

            public override TenPayResponse DefaultInstanceForType
            {
                get
                {
                    return TenPayResponse.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override TenPayResponse MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public string PlatMsg
            {
                get
                {
                    return this.result.PlatMsg;
                }
                set
                {
                    this.SetPlatMsg(value);
                }
            }

            public int PlatRet
            {
                get
                {
                    return this.result.PlatRet;
                }
                set
                {
                    this.SetPlatRet(value);
                }
            }

            public SKBuiltinBuffer_t RetText
            {
                get
                {
                    return this.result.RetText;
                }
                set
                {
                    this.SetRetText(value);
                }
            }

            public string TenpayErrMsg
            {
                get
                {
                    return this.result.TenpayErrMsg;
                }
                set
                {
                    this.SetTenpayErrMsg(value);
                }
            }

            public int TenpayErrType
            {
                get
                {
                    return this.result.TenpayErrType;
                }
                set
                {
                    this.SetTenpayErrType(value);
                }
            }

            protected override TenPayResponse.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}

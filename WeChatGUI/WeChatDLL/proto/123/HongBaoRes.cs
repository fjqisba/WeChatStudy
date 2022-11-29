namespace micromsg
{
    using Google.ProtocolBuffers;

    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    using System.Runtime.CompilerServices;


    public sealed class HongBaoRes : GeneratedMessageLite<HongBaoRes, HongBaoRes.Builder>
    {
        private static readonly string[] _hongBaoResFieldNames = new string[] { "BaseResponse", "CgiCmdid", "PlatMsg", "PlatRet", "RetText", "errorMsg", "errorType" };
        private static readonly uint[] _hongBaoResFieldTags = new uint[] { 10, 40, 0x22, 0x18, 0x12, 0x3a, 0x30 };
        private BaseResponse baseResponse_;
        public const int BaseResponseFieldNumber = 1;
        private int cgiCmdid_;
        public const int CgiCmdidFieldNumber = 5;
        private static readonly HongBaoRes defaultInstance = new HongBaoRes().MakeReadOnly();
        private string errorMsg_ = "";
        public const int ErrorMsgFieldNumber = 7;
        private int errorType_;
        public const int ErrorTypeFieldNumber = 6;
        private bool hasBaseResponse;
        private bool hasCgiCmdid;
        private bool hasErrorMsg;
        private bool hasErrorType;
        private bool hasPlatMsg;
        private bool hasPlatRet;
        private bool hasRetText;
        private int memoizedSerializedSize = -1;
        private string platMsg_ = "";
        public const int PlatMsgFieldNumber = 4;
        private int platRet_;
        public const int PlatRetFieldNumber = 3;
        private SKBuiltinBuffer_t retText_;
        public const int RetTextFieldNumber = 2;

        static HongBaoRes()
        {

        }

        private HongBaoRes()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(HongBaoRes prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            HongBaoRes res = obj as HongBaoRes;
            if (res == null)
            {
                return false;
            }
            if ((this.hasBaseResponse != res.hasBaseResponse) || (this.hasBaseResponse && !this.baseResponse_.Equals(res.baseResponse_)))
            {
                return false;
            }
            if ((this.hasRetText != res.hasRetText) || (this.hasRetText && !this.retText_.Equals(res.retText_)))
            {
                return false;
            }
            if ((this.hasPlatRet != res.hasPlatRet) || (this.hasPlatRet && !this.platRet_.Equals(res.platRet_)))
            {
                return false;
            }
            if ((this.hasPlatMsg != res.hasPlatMsg) || (this.hasPlatMsg && !this.platMsg_.Equals(res.platMsg_)))
            {
                return false;
            }
            if ((this.hasCgiCmdid != res.hasCgiCmdid) || (this.hasCgiCmdid && !this.cgiCmdid_.Equals(res.cgiCmdid_)))
            {
                return false;
            }
            if ((this.hasErrorType != res.hasErrorType) || (this.hasErrorType && !this.errorType_.Equals(res.errorType_)))
            {
                return false;
            }
            return ((this.hasErrorMsg == res.hasErrorMsg) && (!this.hasErrorMsg || this.errorMsg_.Equals(res.errorMsg_)));
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
            if (this.hasErrorType)
            {
                hashCode ^= this.errorType_.GetHashCode();
            }
            if (this.hasErrorMsg)
            {
                hashCode ^= this.errorMsg_.GetHashCode();
            }
            return hashCode;
        }

        private HongBaoRes MakeReadOnly()
        {
            return this;
        }

        public static HongBaoRes ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<HongBaoRes, Builder>.PrintField("BaseResponse", this.hasBaseResponse, this.baseResponse_, writer);
            GeneratedMessageLite<HongBaoRes, Builder>.PrintField("RetText", this.hasRetText, this.retText_, writer);
            GeneratedMessageLite<HongBaoRes, Builder>.PrintField("PlatRet", this.hasPlatRet, this.platRet_, writer);
            GeneratedMessageLite<HongBaoRes, Builder>.PrintField("PlatMsg", this.hasPlatMsg, this.platMsg_, writer);
            GeneratedMessageLite<HongBaoRes, Builder>.PrintField("CgiCmdid", this.hasCgiCmdid, this.cgiCmdid_, writer);
            GeneratedMessageLite<HongBaoRes, Builder>.PrintField("errorType", this.hasErrorType, this.errorType_, writer);
            GeneratedMessageLite<HongBaoRes, Builder>.PrintField("errorMsg", this.hasErrorMsg, this.errorMsg_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _hongBaoResFieldNames;
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
            if (this.hasErrorType)
            {
                output.WriteInt32(6, strArray[6], this.ErrorType);
            }
            if (this.hasErrorMsg)
            {
                output.WriteString(7, strArray[5], this.ErrorMsg);
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

        public static HongBaoRes DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override HongBaoRes DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public string ErrorMsg
        {
            get
            {
                return this.errorMsg_;
            }
        }

        public int ErrorType
        {
            get
            {
                return this.errorType_;
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
                    if (this.hasErrorType)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(6, this.ErrorType);
                    }
                    if (this.hasErrorMsg)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(7, this.ErrorMsg);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override HongBaoRes ThisMessage
        {
            get
            {
                return this;
            }
        }

        [GeneratedCode("ProtoGen", "2.3.0.277"), DebuggerNonUserCode, CompilerGenerated]
        public sealed class Builder : GeneratedBuilderLite<HongBaoRes, HongBaoRes.Builder>
        {
            private HongBaoRes result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = HongBaoRes.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(HongBaoRes cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override HongBaoRes BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override HongBaoRes.Builder Clear()
            {
                this.result = HongBaoRes.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public HongBaoRes.Builder ClearBaseResponse()
            {
                this.PrepareBuilder();
                this.result.hasBaseResponse = false;
                this.result.baseResponse_ = null;
                return this;
            }

            public HongBaoRes.Builder ClearCgiCmdid()
            {
                this.PrepareBuilder();
                this.result.hasCgiCmdid = false;
                this.result.cgiCmdid_ = 0;
                return this;
            }

            public HongBaoRes.Builder ClearErrorMsg()
            {
                this.PrepareBuilder();
                this.result.hasErrorMsg = false;
                this.result.errorMsg_ = "";
                return this;
            }

            public HongBaoRes.Builder ClearErrorType()
            {
                this.PrepareBuilder();
                this.result.hasErrorType = false;
                this.result.errorType_ = 0;
                return this;
            }

            public HongBaoRes.Builder ClearPlatMsg()
            {
                this.PrepareBuilder();
                this.result.hasPlatMsg = false;
                this.result.platMsg_ = "";
                return this;
            }

            public HongBaoRes.Builder ClearPlatRet()
            {
                this.PrepareBuilder();
                this.result.hasPlatRet = false;
                this.result.platRet_ = 0;
                return this;
            }

            public HongBaoRes.Builder ClearRetText()
            {
                this.PrepareBuilder();
                this.result.hasRetText = false;
                this.result.retText_ = null;
                return this;
            }

            public override HongBaoRes.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new HongBaoRes.Builder(this.result);
                }
                return new HongBaoRes.Builder().MergeFrom(this.result);
            }

            public HongBaoRes.Builder MergeBaseResponse(BaseResponse value)
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

            public override HongBaoRes.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override HongBaoRes.Builder MergeFrom(IMessageLite other)
            {
                if (other is HongBaoRes)
                {
                    return this.MergeFrom((HongBaoRes) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override HongBaoRes.Builder MergeFrom(HongBaoRes other)
            {
                return this;
            }

            public override HongBaoRes.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(HongBaoRes._hongBaoResFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = HongBaoRes._hongBaoResFieldTags[index];
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
                            this.result.hasErrorType = input.ReadInt32(ref this.result.errorType_);
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
                    this.result.hasErrorMsg = input.ReadString(ref this.result.errorMsg_);
                }
                return this;
            }

            public HongBaoRes.Builder MergeRetText(SKBuiltinBuffer_t value)
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

            private HongBaoRes PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    HongBaoRes result = this.result;
                    this.result = new HongBaoRes();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public HongBaoRes.Builder SetBaseResponse(BaseResponse value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = value;
                return this;
            }

            public HongBaoRes.Builder SetBaseResponse(BaseResponse.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = builderForValue.Build();
                return this;
            }

            public HongBaoRes.Builder SetCgiCmdid(int value)
            {
                this.PrepareBuilder();
                this.result.hasCgiCmdid = true;
                this.result.cgiCmdid_ = value;
                return this;
            }

            public HongBaoRes.Builder SetErrorMsg(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasErrorMsg = true;
                this.result.errorMsg_ = value;
                return this;
            }

            public HongBaoRes.Builder SetErrorType(int value)
            {
                this.PrepareBuilder();
                this.result.hasErrorType = true;
                this.result.errorType_ = value;
                return this;
            }

            public HongBaoRes.Builder SetPlatMsg(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasPlatMsg = true;
                this.result.platMsg_ = value;
                return this;
            }

            public HongBaoRes.Builder SetPlatRet(int value)
            {
                this.PrepareBuilder();
                this.result.hasPlatRet = true;
                this.result.platRet_ = value;
                return this;
            }

            public HongBaoRes.Builder SetRetText(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasRetText = true;
                this.result.retText_ = value;
                return this;
            }

            public HongBaoRes.Builder SetRetText(SKBuiltinBuffer_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasRetText = true;
                this.result.retText_ = builderForValue.Build();
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

            public override HongBaoRes DefaultInstanceForType
            {
                get
                {
                    return HongBaoRes.DefaultInstance;
                }
            }

            public string ErrorMsg
            {
                get
                {
                    return this.result.ErrorMsg;
                }
                set
                {
                    this.SetErrorMsg(value);
                }
            }

            public int ErrorType
            {
                get
                {
                    return this.result.ErrorType;
                }
                set
                {
                    this.SetErrorType(value);
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override HongBaoRes MessageBeingBuilt
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

            protected override HongBaoRes.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}

namespace micromsg
{
    using Google.ProtocolBuffers;
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    using System.Runtime.CompilerServices;


    public sealed class HongBaoReq : GeneratedMessageLite<HongBaoReq, HongBaoReq.Builder>
    {
        private static readonly string[] _hongBaoReqFieldNames = new string[] { "BaseRequest", "CgiCmd", "OutPutType", "ReqText" };
        private static readonly uint[] _hongBaoReqFieldTags = new uint[] { 10, 0x10, 0x18, 0x22 };
        private BaseRequest baseRequest_;
        public const int BaseRequestFieldNumber = 1;
        private uint cgiCmd_;
        public const int CgiCmdFieldNumber = 2;
        private static readonly HongBaoReq defaultInstance = new HongBaoReq().MakeReadOnly();
        private bool hasBaseRequest;
        private bool hasCgiCmd;
        private bool hasOutPutType;
        private bool hasReqText;
        private int memoizedSerializedSize = -1;
        private uint outPutType_;
        public const int OutPutTypeFieldNumber = 3;
        private SKBuiltinBuffer_t reqText_;
        public const int ReqTextFieldNumber = 4;

        static HongBaoReq()
        {

        }

        private HongBaoReq()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(HongBaoReq prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            HongBaoReq req = obj as HongBaoReq;
            if (req == null)
            {
                return false;
            }
            if ((this.hasBaseRequest != req.hasBaseRequest) || (this.hasBaseRequest && !this.baseRequest_.Equals(req.baseRequest_)))
            {
                return false;
            }
            if ((this.hasCgiCmd != req.hasCgiCmd) || (this.hasCgiCmd && !this.cgiCmd_.Equals(req.cgiCmd_)))
            {
                return false;
            }
            if ((this.hasOutPutType != req.hasOutPutType) || (this.hasOutPutType && !this.outPutType_.Equals(req.outPutType_)))
            {
                return false;
            }
            return ((this.hasReqText == req.hasReqText) && (!this.hasReqText || this.reqText_.Equals(req.reqText_)));
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
            return hashCode;
        }

        private HongBaoReq MakeReadOnly()
        {
            return this;
        }

        public static HongBaoReq ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<HongBaoReq, Builder>.PrintField("BaseRequest", this.hasBaseRequest, this.baseRequest_, writer);
            GeneratedMessageLite<HongBaoReq, Builder>.PrintField("CgiCmd", this.hasCgiCmd, this.cgiCmd_, writer);
            GeneratedMessageLite<HongBaoReq, Builder>.PrintField("OutPutType", this.hasOutPutType, this.outPutType_, writer);
            GeneratedMessageLite<HongBaoReq, Builder>.PrintField("ReqText", this.hasReqText, this.reqText_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _hongBaoReqFieldNames;
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

        public static HongBaoReq DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override HongBaoReq DefaultInstanceForType
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
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override HongBaoReq ThisMessage
        {
            get
            {
                return this;
            }
        }

        [DebuggerNonUserCode, GeneratedCode("ProtoGen", "2.3.0.277"), CompilerGenerated]
        public sealed class Builder : GeneratedBuilderLite<HongBaoReq, HongBaoReq.Builder>
        {
            private HongBaoReq result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = HongBaoReq.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(HongBaoReq cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override HongBaoReq BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override HongBaoReq.Builder Clear()
            {
                this.result = HongBaoReq.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public HongBaoReq.Builder ClearBaseRequest()
            {
                this.PrepareBuilder();
                this.result.hasBaseRequest = false;
                this.result.baseRequest_ = null;
                return this;
            }

            public HongBaoReq.Builder ClearCgiCmd()
            {
                this.PrepareBuilder();
                this.result.hasCgiCmd = false;
                this.result.cgiCmd_ = 0;
                return this;
            }

            public HongBaoReq.Builder ClearOutPutType()
            {
                this.PrepareBuilder();
                this.result.hasOutPutType = false;
                this.result.outPutType_ = 0;
                return this;
            }

            public HongBaoReq.Builder ClearReqText()
            {
                this.PrepareBuilder();
                this.result.hasReqText = false;
                this.result.reqText_ = null;
                return this;
            }

            public override HongBaoReq.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new HongBaoReq.Builder(this.result);
                }
                return new HongBaoReq.Builder().MergeFrom(this.result);
            }

            public HongBaoReq.Builder MergeBaseRequest(BaseRequest value)
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

            public override HongBaoReq.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override HongBaoReq.Builder MergeFrom(IMessageLite other)
            {
                if (other is HongBaoReq)
                {
                    return this.MergeFrom((HongBaoReq) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override HongBaoReq.Builder MergeFrom(HongBaoReq other)
            {
                return this;
            }

            public override HongBaoReq.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(HongBaoReq._hongBaoReqFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = HongBaoReq._hongBaoReqFieldTags[index];
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
                    }
                    if (WireFormat.IsEndGroupTag(num))
                    {
                        return this;
                    }
                    this.ParseUnknownField(input, extensionRegistry, num, str);
                }
                return this;
            }

            public HongBaoReq.Builder MergeReqText(SKBuiltinBuffer_t value)
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

            private HongBaoReq PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    HongBaoReq result = this.result;
                    this.result = new HongBaoReq();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public HongBaoReq.Builder SetBaseRequest(BaseRequest value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = value;
                return this;
            }

            public HongBaoReq.Builder SetBaseRequest(BaseRequest.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = builderForValue.Build();
                return this;
            }

            public HongBaoReq.Builder SetCgiCmd(uint value)
            {
                this.PrepareBuilder();
                this.result.hasCgiCmd = true;
                this.result.cgiCmd_ = value;
                return this;
            }

            public HongBaoReq.Builder SetOutPutType(uint value)
            {
                this.PrepareBuilder();
                this.result.hasOutPutType = true;
                this.result.outPutType_ = value;
                return this;
            }

            public HongBaoReq.Builder SetReqText(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasReqText = true;
                this.result.reqText_ = value;
                return this;
            }

            public HongBaoReq.Builder SetReqText(SKBuiltinBuffer_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasReqText = true;
                this.result.reqText_ = builderForValue.Build();
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

            public override HongBaoReq DefaultInstanceForType
            {
                get
                {
                    return HongBaoReq.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override HongBaoReq MessageBeingBuilt
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

            protected override HongBaoReq.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}

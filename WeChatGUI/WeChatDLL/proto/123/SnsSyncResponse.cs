namespace micromsg
{
    using Google.ProtocolBuffers;

    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    using System.Runtime.CompilerServices;


    public sealed class SnsSyncResponse : GeneratedMessageLite<SnsSyncResponse, SnsSyncResponse.Builder>
    {
        private static readonly string[] _snsSyncResponseFieldNames = new string[] { "BaseResponse", "CmdList", "ContinueFlag", "KeyBuf" };
        private static readonly uint[] _snsSyncResponseFieldTags = new uint[] { 10, 0x12, 0x18, 0x22 };
        private BaseResponse baseResponse_;
        public const int BaseResponseFieldNumber = 1;
        private CmdList cmdList_;
        public const int CmdListFieldNumber = 2;
        private uint continueFlag_;
        public const int ContinueFlagFieldNumber = 3;
        private static readonly SnsSyncResponse defaultInstance = new SnsSyncResponse().MakeReadOnly();
        private bool hasBaseResponse;
        private bool hasCmdList;
        private bool hasContinueFlag;
        private bool hasKeyBuf;
        private SKBuiltinBuffer_t keyBuf_;
        public const int KeyBufFieldNumber = 4;
        private int memoizedSerializedSize = -1;

        static SnsSyncResponse()
        {
           
        }

        private SnsSyncResponse()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(SnsSyncResponse prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            SnsSyncResponse response = obj as SnsSyncResponse;
            if (response == null)
            {
                return false;
            }
            if ((this.hasBaseResponse != response.hasBaseResponse) || (this.hasBaseResponse && !this.baseResponse_.Equals(response.baseResponse_)))
            {
                return false;
            }
            if ((this.hasCmdList != response.hasCmdList) || (this.hasCmdList && !this.cmdList_.Equals(response.cmdList_)))
            {
                return false;
            }
            if ((this.hasContinueFlag != response.hasContinueFlag) || (this.hasContinueFlag && !this.continueFlag_.Equals(response.continueFlag_)))
            {
                return false;
            }
            return ((this.hasKeyBuf == response.hasKeyBuf) && (!this.hasKeyBuf || this.keyBuf_.Equals(response.keyBuf_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasBaseResponse)
            {
                hashCode ^= this.baseResponse_.GetHashCode();
            }
            if (this.hasCmdList)
            {
                hashCode ^= this.cmdList_.GetHashCode();
            }
            if (this.hasContinueFlag)
            {
                hashCode ^= this.continueFlag_.GetHashCode();
            }
            if (this.hasKeyBuf)
            {
                hashCode ^= this.keyBuf_.GetHashCode();
            }
            return hashCode;
        }

        private SnsSyncResponse MakeReadOnly()
        {
            return this;
        }

        public static SnsSyncResponse ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<SnsSyncResponse, Builder>.PrintField("BaseResponse", this.hasBaseResponse, this.baseResponse_, writer);
            GeneratedMessageLite<SnsSyncResponse, Builder>.PrintField("CmdList", this.hasCmdList, this.cmdList_, writer);
            GeneratedMessageLite<SnsSyncResponse, Builder>.PrintField("ContinueFlag", this.hasContinueFlag, this.continueFlag_, writer);
            GeneratedMessageLite<SnsSyncResponse, Builder>.PrintField("KeyBuf", this.hasKeyBuf, this.keyBuf_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _snsSyncResponseFieldNames;
            if (this.hasBaseResponse)
            {
                output.WriteMessage(1, strArray[0], this.BaseResponse);
            }
            if (this.hasCmdList)
            {
                output.WriteMessage(2, strArray[1], this.CmdList);
            }
            if (this.hasContinueFlag)
            {
                output.WriteUInt32(3, strArray[2], this.ContinueFlag);
            }
            if (this.hasKeyBuf)
            {
                output.WriteMessage(4, strArray[3], this.KeyBuf);
            }
        }

        public BaseResponse BaseResponse
        {
            get
            {
                return (this.baseResponse_ ?? BaseResponse.DefaultInstance);
            }
        }

        public CmdList CmdList
        {
            get
            {
                return (this.cmdList_ ?? CmdList.DefaultInstance);
            }
        }

        public uint ContinueFlag
        {
            get
            {
                return this.continueFlag_;
            }
        }

        public static SnsSyncResponse DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override SnsSyncResponse DefaultInstanceForType
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
                if (!this.hasCmdList)
                {
                    return false;
                }
                if (!this.hasContinueFlag)
                {
                    return false;
                }
                if (!this.hasKeyBuf)
                {
                    return false;
                }
                if (!this.BaseResponse.IsInitialized)
                {
                    return false;
                }
                if (!this.CmdList.IsInitialized)
                {
                    return false;
                }
                if (!this.KeyBuf.IsInitialized)
                {
                    return false;
                }
                return true;
            }
        }

        public SKBuiltinBuffer_t KeyBuf
        {
            get
            {
                return (this.keyBuf_ ?? SKBuiltinBuffer_t.DefaultInstance);
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
                    if (this.hasCmdList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(2, this.CmdList);
                    }
                    if (this.hasContinueFlag)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(3, this.ContinueFlag);
                    }
                    if (this.hasKeyBuf)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(4, this.KeyBuf);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override SnsSyncResponse ThisMessage
        {
            get
            {
                return this;
            }
        }

        [DebuggerNonUserCode, CompilerGenerated, GeneratedCode("ProtoGen", "2.3.0.277")]
        public sealed class Builder : GeneratedBuilderLite<SnsSyncResponse, SnsSyncResponse.Builder>
        {
            private SnsSyncResponse result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = SnsSyncResponse.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(SnsSyncResponse cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override SnsSyncResponse BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override SnsSyncResponse.Builder Clear()
            {
                this.result = SnsSyncResponse.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public SnsSyncResponse.Builder ClearBaseResponse()
            {
                this.PrepareBuilder();
                this.result.hasBaseResponse = false;
                this.result.baseResponse_ = null;
                return this;
            }

            public SnsSyncResponse.Builder ClearCmdList()
            {
                this.PrepareBuilder();
                this.result.hasCmdList = false;
                this.result.cmdList_ = null;
                return this;
            }

            public SnsSyncResponse.Builder ClearContinueFlag()
            {
                this.PrepareBuilder();
                this.result.hasContinueFlag = false;
                this.result.continueFlag_ = 0;
                return this;
            }

            public SnsSyncResponse.Builder ClearKeyBuf()
            {
                this.PrepareBuilder();
                this.result.hasKeyBuf = false;
                this.result.keyBuf_ = null;
                return this;
            }

            public override SnsSyncResponse.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new SnsSyncResponse.Builder(this.result);
                }
                return new SnsSyncResponse.Builder().MergeFrom(this.result);
            }

            public SnsSyncResponse.Builder MergeBaseResponse(BaseResponse value)
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

            public SnsSyncResponse.Builder MergeCmdList(CmdList value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasCmdList && (this.result.cmdList_ != CmdList.DefaultInstance))
                {
                    this.result.cmdList_ = CmdList.CreateBuilder(this.result.cmdList_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.cmdList_ = value;
                }
                this.result.hasCmdList = true;
                return this;
            }

            public override SnsSyncResponse.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override SnsSyncResponse.Builder MergeFrom(IMessageLite other)
            {
                if (other is SnsSyncResponse)
                {
                    return this.MergeFrom((SnsSyncResponse)other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override SnsSyncResponse.Builder MergeFrom(SnsSyncResponse other)
            {
                return this;
            }

            public override SnsSyncResponse.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(SnsSyncResponse._snsSyncResponseFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = SnsSyncResponse._snsSyncResponseFieldTags[index];
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
                                BaseResponse.Builder builder = BaseResponse.CreateBuilder();
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
                                CmdList.Builder builder2 = CmdList.CreateBuilder();
                                if (this.result.hasCmdList)
                                {
                                    builder2.MergeFrom(this.CmdList);
                                }
                                input.ReadMessage(builder2, extensionRegistry);
                                this.CmdList = builder2.BuildPartial();
                                continue;
                            }
                        case 0x18:
                            {
                                this.result.hasContinueFlag = input.ReadUInt32(ref this.result.continueFlag_);
                                continue;
                            }
                        case 0x22:
                            {
                                SKBuiltinBuffer_t.Builder builder3 = SKBuiltinBuffer_t.CreateBuilder();
                                if (this.result.hasKeyBuf)
                                {
                                    builder3.MergeFrom(this.KeyBuf);
                                }
                                input.ReadMessage(builder3, extensionRegistry);
                                this.KeyBuf = builder3.BuildPartial();
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

            public SnsSyncResponse.Builder MergeKeyBuf(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasKeyBuf && (this.result.keyBuf_ != SKBuiltinBuffer_t.DefaultInstance))
                {
                    this.result.keyBuf_ = SKBuiltinBuffer_t.CreateBuilder(this.result.keyBuf_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.keyBuf_ = value;
                }
                this.result.hasKeyBuf = true;
                return this;
            }

            private SnsSyncResponse PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    SnsSyncResponse result = this.result;
                    this.result = new SnsSyncResponse();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public SnsSyncResponse.Builder SetBaseResponse(BaseResponse value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = value;
                return this;
            }

            public SnsSyncResponse.Builder SetBaseResponse(BaseResponse.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = builderForValue.Build();
                return this;
            }

            public SnsSyncResponse.Builder SetCmdList(CmdList value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasCmdList = true;
                this.result.cmdList_ = value;
                return this;
            }

            public SnsSyncResponse.Builder SetCmdList(CmdList.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasCmdList = true;
                this.result.cmdList_ = builderForValue.Build();
                return this;
            }

            public SnsSyncResponse.Builder SetContinueFlag(uint value)
            {
                this.PrepareBuilder();
                this.result.hasContinueFlag = true;
                this.result.continueFlag_ = value;
                return this;
            }

            public SnsSyncResponse.Builder SetKeyBuf(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasKeyBuf = true;
                this.result.keyBuf_ = value;
                return this;
            }

            public SnsSyncResponse.Builder SetKeyBuf(SKBuiltinBuffer_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasKeyBuf = true;
                this.result.keyBuf_ = builderForValue.Build();
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

            public CmdList CmdList
            {
                get
                {
                    return this.result.CmdList;
                }
                set
                {
                    this.SetCmdList(value);
                }
            }

            public uint ContinueFlag
            {
                get
                {
                    return this.result.ContinueFlag;
                }
                set
                {
                    this.SetContinueFlag(value);
                }
            }

            public override SnsSyncResponse DefaultInstanceForType
            {
                get
                {
                    return SnsSyncResponse.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            public SKBuiltinBuffer_t KeyBuf
            {
                get
                {
                    return this.result.KeyBuf;
                }
                set
                {
                    this.SetKeyBuf(value);
                }
            }

            protected override SnsSyncResponse MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override SnsSyncResponse.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}

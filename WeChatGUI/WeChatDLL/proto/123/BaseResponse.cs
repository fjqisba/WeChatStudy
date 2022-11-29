namespace micromsg
{
    using Google.ProtocolBuffers;
    
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

    
    public sealed class BaseResponse : GeneratedMessageLite<BaseResponse, BaseResponse.Builder>
    {
        private static readonly string[] _baseResponseFieldNames = new string[] { "ErrMsg", "Ret" };
        private static readonly uint[] _baseResponseFieldTags = new uint[] { 0x12, 8 };
        private static readonly BaseResponse defaultInstance = new BaseResponse().MakeReadOnly();
        private SKBuiltinString_t errMsg_;
        public const int ErrMsgFieldNumber = 2;
        private bool hasErrMsg;
        private bool hasRet;
        private int memoizedSerializedSize = -1;
        private int ret_;
        public const int RetFieldNumber = 1;

        static BaseResponse()
        {
            //object.ReferenceEquals(BaseResponse.Descriptor, null);
        }

        private BaseResponse()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(BaseResponse prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            BaseResponse response = obj as BaseResponse;
            if (response == null)
            {
                return false;
            }
            if ((this.hasRet != response.hasRet) || (this.hasRet && !this.ret_.Equals(response.ret_)))
            {
                return false;
            }
            return ((this.hasErrMsg == response.hasErrMsg) && (!this.hasErrMsg || this.errMsg_.Equals(response.errMsg_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasRet)
            {
                hashCode ^= this.ret_.GetHashCode();
            }
            if (this.hasErrMsg)
            {
                hashCode ^= this.errMsg_.GetHashCode();
            }
            return hashCode;
        }

        private BaseResponse MakeReadOnly()
        {
            return this;
        }

        public static BaseResponse ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<BaseResponse, Builder>.PrintField("Ret", this.hasRet, this.ret_, writer);
            GeneratedMessageLite<BaseResponse, Builder>.PrintField("ErrMsg", this.hasErrMsg, this.errMsg_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _baseResponseFieldNames;
            if (this.hasRet)
            {
                output.WriteInt32(1, strArray[1], this.Ret);
            }
            if (this.hasErrMsg)
            {
                output.WriteMessage(2, strArray[0], this.ErrMsg);
            }
        }

        public static BaseResponse DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override BaseResponse DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public SKBuiltinString_t ErrMsg
        {
            get
            {
                return (this.errMsg_ ?? SKBuiltinString_t.DefaultInstance);
            }
        }

        public override bool IsInitialized
        {
            get
            {
                if (!this.hasRet)
                {
                    return false;
                }
                if (!this.hasErrMsg)
                {
                    return false;
                }
                return true;
            }
        }

        public int Ret
        {
            get
            {
                return this.ret_;
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
                    if (this.hasRet)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(1, this.Ret);
                    }
                    if (this.hasErrMsg)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(2, this.ErrMsg);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override BaseResponse ThisMessage
        {
            get
            {
                return this;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<BaseResponse, BaseResponse.Builder>
        {
            private BaseResponse result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = BaseResponse.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(BaseResponse cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override BaseResponse BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override BaseResponse.Builder Clear()
            {
                this.result = BaseResponse.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public BaseResponse.Builder ClearErrMsg()
            {
                this.PrepareBuilder();
                this.result.hasErrMsg = false;
                this.result.errMsg_ = null;
                return this;
            }

            public BaseResponse.Builder ClearRet()
            {
                this.PrepareBuilder();
                this.result.hasRet = false;
                this.result.ret_ = 0;
                return this;
            }

            public override BaseResponse.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new BaseResponse.Builder(this.result);
                }
                return new BaseResponse.Builder().MergeFrom(this.result);
            }

            public BaseResponse.Builder MergeErrMsg(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasErrMsg && (this.result.errMsg_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.errMsg_ = SKBuiltinString_t.CreateBuilder(this.result.errMsg_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.errMsg_ = value;
                }
                this.result.hasErrMsg = true;
                return this;
            }

            public override BaseResponse.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override BaseResponse.Builder MergeFrom(IMessageLite other)
            {
                if (other is BaseResponse)
                {
                    return this.MergeFrom((BaseResponse) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override BaseResponse.Builder MergeFrom(BaseResponse other)
            {
                return this;
            }

            public override BaseResponse.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(BaseResponse._baseResponseFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = BaseResponse._baseResponseFieldTags[index];
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

                        case 8:
                        {
                            this.result.hasRet = input.ReadInt32(ref this.result.ret_);
                            continue;
                        }
                        case 0x12:
                        {
                            SKBuiltinString_t.Builder builder = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasErrMsg)
                            {
                                builder.MergeFrom(this.ErrMsg);
                            }
                            input.ReadMessage(builder, extensionRegistry);
                            this.ErrMsg = builder.BuildPartial();
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

            private BaseResponse PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    BaseResponse result = this.result;
                    this.result = new BaseResponse();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public BaseResponse.Builder SetErrMsg(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasErrMsg = true;
                this.result.errMsg_ = value;
                return this;
            }

            public BaseResponse.Builder SetErrMsg(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasErrMsg = true;
                this.result.errMsg_ = builderForValue.Build();
                return this;
            }

            public BaseResponse.Builder SetRet(int value)
            {
                this.PrepareBuilder();
                this.result.hasRet = true;
                this.result.ret_ = value;
                return this;
            }

            public override BaseResponse DefaultInstanceForType
            {
                get
                {
                    return BaseResponse.DefaultInstance;
                }
            }

            public SKBuiltinString_t ErrMsg
            {
                get
                {
                    return this.result.ErrMsg;
                }
                set
                {
                    this.SetErrMsg(value);
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override BaseResponse MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public int Ret
            {
                get
                {
                    return this.result.Ret;
                }
                set
                {
                    this.SetRet(value);
                }
            }

            protected override BaseResponse.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


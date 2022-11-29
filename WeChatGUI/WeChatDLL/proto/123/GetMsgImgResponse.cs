namespace micromsg
{
    using Google.ProtocolBuffers;
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    


    public sealed class GetMsgImgResponse : GeneratedMessageLite<GetMsgImgResponse, GetMsgImgResponse.Builder>
    {
        private static readonly string[] _getMsgImgResponseFieldNames = new string[] { "BaseResponse", "Data", "DataLen", "FromUserName", "MsgId", "StartPos", "ToUserName", "TotalLen" };
        private static readonly uint[] _getMsgImgResponseFieldTags = new uint[] { 10, 0x42, 0x38, 0x1a, 0x10, 0x30, 0x22, 40 };
        private micromsg.BaseResponse baseResponse_;
        public const int BaseResponseFieldNumber = 1;
        private SKBuiltinBuffer_t data_;
        public const int DataFieldNumber = 8;
        private uint dataLen_;
        public const int DataLenFieldNumber = 7;
        private static readonly GetMsgImgResponse defaultInstance = new GetMsgImgResponse().MakeReadOnly();
        private SKBuiltinString_t fromUserName_;
        public const int FromUserNameFieldNumber = 3;
        private bool hasBaseResponse;
        private bool hasData;
        private bool hasDataLen;
        private bool hasFromUserName;
        private bool hasMsgId;
        private bool hasStartPos;
        private bool hasTotalLen;
        private bool hasToUserName;
        private int memoizedSerializedSize = -1;
        private uint msgId_;
        public const int MsgIdFieldNumber = 2;
        private uint startPos_;
        public const int StartPosFieldNumber = 6;
        private uint totalLen_;
        public const int TotalLenFieldNumber = 5;
        private SKBuiltinString_t toUserName_;
        public const int ToUserNameFieldNumber = 4;

        static GetMsgImgResponse()
        {
           
        }

        private GetMsgImgResponse()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(GetMsgImgResponse prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            GetMsgImgResponse response = obj as GetMsgImgResponse;
            if (response == null)
            {
                return false;
            }
            if ((this.hasBaseResponse != response.hasBaseResponse) || (this.hasBaseResponse && !this.baseResponse_.Equals(response.baseResponse_)))
            {
                return false;
            }
            if ((this.hasMsgId != response.hasMsgId) || (this.hasMsgId && !this.msgId_.Equals(response.msgId_)))
            {
                return false;
            }
            if ((this.hasFromUserName != response.hasFromUserName) || (this.hasFromUserName && !this.fromUserName_.Equals(response.fromUserName_)))
            {
                return false;
            }
            if ((this.hasToUserName != response.hasToUserName) || (this.hasToUserName && !this.toUserName_.Equals(response.toUserName_)))
            {
                return false;
            }
            if ((this.hasTotalLen != response.hasTotalLen) || (this.hasTotalLen && !this.totalLen_.Equals(response.totalLen_)))
            {
                return false;
            }
            if ((this.hasStartPos != response.hasStartPos) || (this.hasStartPos && !this.startPos_.Equals(response.startPos_)))
            {
                return false;
            }
            if ((this.hasDataLen != response.hasDataLen) || (this.hasDataLen && !this.dataLen_.Equals(response.dataLen_)))
            {
                return false;
            }
            return ((this.hasData == response.hasData) && (!this.hasData || this.data_.Equals(response.data_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasBaseResponse)
            {
                hashCode ^= this.baseResponse_.GetHashCode();
            }
            if (this.hasMsgId)
            {
                hashCode ^= this.msgId_.GetHashCode();
            }
            if (this.hasFromUserName)
            {
                hashCode ^= this.fromUserName_.GetHashCode();
            }
            if (this.hasToUserName)
            {
                hashCode ^= this.toUserName_.GetHashCode();
            }
            if (this.hasTotalLen)
            {
                hashCode ^= this.totalLen_.GetHashCode();
            }
            if (this.hasStartPos)
            {
                hashCode ^= this.startPos_.GetHashCode();
            }
            if (this.hasDataLen)
            {
                hashCode ^= this.dataLen_.GetHashCode();
            }
            if (this.hasData)
            {
                hashCode ^= this.data_.GetHashCode();
            }
            return hashCode;
        }

        private GetMsgImgResponse MakeReadOnly()
        {
            return this;
        }

        public static GetMsgImgResponse ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<GetMsgImgResponse, Builder>.PrintField("BaseResponse", this.hasBaseResponse, this.baseResponse_, writer);
            GeneratedMessageLite<GetMsgImgResponse, Builder>.PrintField("MsgId", this.hasMsgId, this.msgId_, writer);
            GeneratedMessageLite<GetMsgImgResponse, Builder>.PrintField("FromUserName", this.hasFromUserName, this.fromUserName_, writer);
            GeneratedMessageLite<GetMsgImgResponse, Builder>.PrintField("ToUserName", this.hasToUserName, this.toUserName_, writer);
            GeneratedMessageLite<GetMsgImgResponse, Builder>.PrintField("TotalLen", this.hasTotalLen, this.totalLen_, writer);
            GeneratedMessageLite<GetMsgImgResponse, Builder>.PrintField("StartPos", this.hasStartPos, this.startPos_, writer);
            GeneratedMessageLite<GetMsgImgResponse, Builder>.PrintField("DataLen", this.hasDataLen, this.dataLen_, writer);
            GeneratedMessageLite<GetMsgImgResponse, Builder>.PrintField("Data", this.hasData, this.data_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _getMsgImgResponseFieldNames;
            if (this.hasBaseResponse)
            {
                output.WriteMessage(1, strArray[0], this.BaseResponse);
            }
            if (this.hasMsgId)
            {
                output.WriteUInt32(2, strArray[4], this.MsgId);
            }
            if (this.hasFromUserName)
            {
                output.WriteMessage(3, strArray[3], this.FromUserName);
            }
            if (this.hasToUserName)
            {
                output.WriteMessage(4, strArray[6], this.ToUserName);
            }
            if (this.hasTotalLen)
            {
                output.WriteUInt32(5, strArray[7], this.TotalLen);
            }
            if (this.hasStartPos)
            {
                output.WriteUInt32(6, strArray[5], this.StartPos);
            }
            if (this.hasDataLen)
            {
                output.WriteUInt32(7, strArray[2], this.DataLen);
            }
            if (this.hasData)
            {
                output.WriteMessage(8, strArray[1], this.Data);
            }
        }

        public micromsg.BaseResponse BaseResponse
        {
            get
            {
                return (this.baseResponse_ ?? micromsg.BaseResponse.DefaultInstance);
            }
        }

        public SKBuiltinBuffer_t Data
        {
            get
            {
                return (this.data_ ?? SKBuiltinBuffer_t.DefaultInstance);
            }
        }

        public uint DataLen
        {
            get
            {
                return this.dataLen_;
            }
        }

        public static GetMsgImgResponse DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override GetMsgImgResponse DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public SKBuiltinString_t FromUserName
        {
            get
            {
                return (this.fromUserName_ ?? SKBuiltinString_t.DefaultInstance);
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
                if (!this.hasMsgId)
                {
                    return false;
                }
                if (!this.hasFromUserName)
                {
                    return false;
                }
                if (!this.hasToUserName)
                {
                    return false;
                }
                if (!this.hasTotalLen)
                {
                    return false;
                }
                if (!this.hasStartPos)
                {
                    return false;
                }
                if (!this.hasDataLen)
                {
                    return false;
                }
                if (!this.hasData)
                {
                    return false;
                }
                if (!this.BaseResponse.IsInitialized)
                {
                    return false;
                }
                if (!this.Data.IsInitialized)
                {
                    return false;
                }
                return true;
            }
        }

        public uint MsgId
        {
            get
            {
                return this.msgId_;
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
                    if (this.hasMsgId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(2, this.MsgId);
                    }
                    if (this.hasFromUserName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(3, this.FromUserName);
                    }
                    if (this.hasToUserName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(4, this.ToUserName);
                    }
                    if (this.hasTotalLen)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(5, this.TotalLen);
                    }
                    if (this.hasStartPos)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(6, this.StartPos);
                    }
                    if (this.hasDataLen)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(7, this.DataLen);
                    }
                    if (this.hasData)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(8, this.Data);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        public uint StartPos
        {
            get
            {
                return this.startPos_;
            }
        }

        protected override GetMsgImgResponse ThisMessage
        {
            get
            {
                return this;
            }
        }

        public uint TotalLen
        {
            get
            {
                return this.totalLen_;
            }
        }

        public SKBuiltinString_t ToUserName
        {
            get
            {
                return (this.toUserName_ ?? SKBuiltinString_t.DefaultInstance);
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<GetMsgImgResponse, GetMsgImgResponse.Builder>
        {
            private GetMsgImgResponse result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = GetMsgImgResponse.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(GetMsgImgResponse cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override GetMsgImgResponse BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override GetMsgImgResponse.Builder Clear()
            {
                this.result = GetMsgImgResponse.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public GetMsgImgResponse.Builder ClearBaseResponse()
            {
                this.PrepareBuilder();
                this.result.hasBaseResponse = false;
                this.result.baseResponse_ = null;
                return this;
            }

            public GetMsgImgResponse.Builder ClearData()
            {
                this.PrepareBuilder();
                this.result.hasData = false;
                this.result.data_ = null;
                return this;
            }

            public GetMsgImgResponse.Builder ClearDataLen()
            {
                this.PrepareBuilder();
                this.result.hasDataLen = false;
                this.result.dataLen_ = 0;
                return this;
            }

            public GetMsgImgResponse.Builder ClearFromUserName()
            {
                this.PrepareBuilder();
                this.result.hasFromUserName = false;
                this.result.fromUserName_ = null;
                return this;
            }

            public GetMsgImgResponse.Builder ClearMsgId()
            {
                this.PrepareBuilder();
                this.result.hasMsgId = false;
                this.result.msgId_ = 0;
                return this;
            }

            public GetMsgImgResponse.Builder ClearStartPos()
            {
                this.PrepareBuilder();
                this.result.hasStartPos = false;
                this.result.startPos_ = 0;
                return this;
            }

            public GetMsgImgResponse.Builder ClearTotalLen()
            {
                this.PrepareBuilder();
                this.result.hasTotalLen = false;
                this.result.totalLen_ = 0;
                return this;
            }

            public GetMsgImgResponse.Builder ClearToUserName()
            {
                this.PrepareBuilder();
                this.result.hasToUserName = false;
                this.result.toUserName_ = null;
                return this;
            }

            public override GetMsgImgResponse.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new GetMsgImgResponse.Builder(this.result);
                }
                return new GetMsgImgResponse.Builder().MergeFrom(this.result);
            }

            public GetMsgImgResponse.Builder MergeBaseResponse(micromsg.BaseResponse value)
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

            public GetMsgImgResponse.Builder MergeData(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasData && (this.result.data_ != SKBuiltinBuffer_t.DefaultInstance))
                {
                    this.result.data_ = SKBuiltinBuffer_t.CreateBuilder(this.result.data_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.data_ = value;
                }
                this.result.hasData = true;
                return this;
            }

            public override GetMsgImgResponse.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override GetMsgImgResponse.Builder MergeFrom(IMessageLite other)
            {
                if (other is GetMsgImgResponse)
                {
                    return this.MergeFrom((GetMsgImgResponse) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override GetMsgImgResponse.Builder MergeFrom(GetMsgImgResponse other)
            {
                return this;
            }

            public override GetMsgImgResponse.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(GetMsgImgResponse._getMsgImgResponseFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = GetMsgImgResponse._getMsgImgResponseFieldTags[index];
                        }
                        else
                        {
                            this.ParseUnknownField(input, extensionRegistry, num, str);
                            continue;
                        }
                    }
                    switch (num)
                    {
                        case 0x10:
                        {
                            this.result.hasMsgId = input.ReadUInt32(ref this.result.msgId_);
                            continue;
                        }
                        case 0x1a:
                        {
                            SKBuiltinString_t.Builder builder2 = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasFromUserName)
                            {
                                builder2.MergeFrom(this.FromUserName);
                            }
                            input.ReadMessage(builder2, extensionRegistry);
                            this.FromUserName = builder2.BuildPartial();
                            continue;
                        }
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
                        case 0x22:
                        {
                            SKBuiltinString_t.Builder builder3 = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasToUserName)
                            {
                                builder3.MergeFrom(this.ToUserName);
                            }
                            input.ReadMessage(builder3, extensionRegistry);
                            this.ToUserName = builder3.BuildPartial();
                            continue;
                        }
                        case 40:
                        {
                            this.result.hasTotalLen = input.ReadUInt32(ref this.result.totalLen_);
                            continue;
                        }
                        case 0x30:
                        {
                            this.result.hasStartPos = input.ReadUInt32(ref this.result.startPos_);
                            continue;
                        }
                        case 0x38:
                        {
                            this.result.hasDataLen = input.ReadUInt32(ref this.result.dataLen_);
                            continue;
                        }
                        case 0x42:
                        {
                            SKBuiltinBuffer_t.Builder builder4 = SKBuiltinBuffer_t.CreateBuilder();
                            if (this.result.hasData)
                            {
                                builder4.MergeFrom(this.Data);
                            }
                            input.ReadMessage(builder4, extensionRegistry);
                            this.Data = builder4.BuildPartial();
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

            public GetMsgImgResponse.Builder MergeFromUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasFromUserName && (this.result.fromUserName_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.fromUserName_ = SKBuiltinString_t.CreateBuilder(this.result.fromUserName_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.fromUserName_ = value;
                }
                this.result.hasFromUserName = true;
                return this;
            }

            public GetMsgImgResponse.Builder MergeToUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasToUserName && (this.result.toUserName_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.toUserName_ = SKBuiltinString_t.CreateBuilder(this.result.toUserName_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.toUserName_ = value;
                }
                this.result.hasToUserName = true;
                return this;
            }

            private GetMsgImgResponse PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    GetMsgImgResponse result = this.result;
                    this.result = new GetMsgImgResponse();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public GetMsgImgResponse.Builder SetBaseResponse(micromsg.BaseResponse value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = value;
                return this;
            }

            public GetMsgImgResponse.Builder SetBaseResponse(micromsg.BaseResponse.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = builderForValue.Build();
                return this;
            }

            public GetMsgImgResponse.Builder SetData(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasData = true;
                this.result.data_ = value;
                return this;
            }

            public GetMsgImgResponse.Builder SetData(SKBuiltinBuffer_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasData = true;
                this.result.data_ = builderForValue.Build();
                return this;
            }

            public GetMsgImgResponse.Builder SetDataLen(uint value)
            {
                this.PrepareBuilder();
                this.result.hasDataLen = true;
                this.result.dataLen_ = value;
                return this;
            }

            public GetMsgImgResponse.Builder SetFromUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasFromUserName = true;
                this.result.fromUserName_ = value;
                return this;
            }

            public GetMsgImgResponse.Builder SetFromUserName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasFromUserName = true;
                this.result.fromUserName_ = builderForValue.Build();
                return this;
            }

            public GetMsgImgResponse.Builder SetMsgId(uint value)
            {
                this.PrepareBuilder();
                this.result.hasMsgId = true;
                this.result.msgId_ = value;
                return this;
            }

            public GetMsgImgResponse.Builder SetStartPos(uint value)
            {
                this.PrepareBuilder();
                this.result.hasStartPos = true;
                this.result.startPos_ = value;
                return this;
            }

            public GetMsgImgResponse.Builder SetTotalLen(uint value)
            {
                this.PrepareBuilder();
                this.result.hasTotalLen = true;
                this.result.totalLen_ = value;
                return this;
            }

            public GetMsgImgResponse.Builder SetToUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasToUserName = true;
                this.result.toUserName_ = value;
                return this;
            }

            public GetMsgImgResponse.Builder SetToUserName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasToUserName = true;
                this.result.toUserName_ = builderForValue.Build();
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

            public SKBuiltinBuffer_t Data
            {
                get
                {
                    return this.result.Data;
                }
                set
                {
                    this.SetData(value);
                }
            }

            public uint DataLen
            {
                get
                {
                    return this.result.DataLen;
                }
                set
                {
                    this.SetDataLen(value);
                }
            }

            public override GetMsgImgResponse DefaultInstanceForType
            {
                get
                {
                    return GetMsgImgResponse.DefaultInstance;
                }
            }

            public SKBuiltinString_t FromUserName
            {
                get
                {
                    return this.result.FromUserName;
                }
                set
                {
                    this.SetFromUserName(value);
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override GetMsgImgResponse MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public uint MsgId
            {
                get
                {
                    return this.result.MsgId;
                }
                set
                {
                    this.SetMsgId(value);
                }
            }

            public uint StartPos
            {
                get
                {
                    return this.result.StartPos;
                }
                set
                {
                    this.SetStartPos(value);
                }
            }

            protected override GetMsgImgResponse.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }

            public uint TotalLen
            {
                get
                {
                    return this.result.TotalLen;
                }
                set
                {
                    this.SetTotalLen(value);
                }
            }

            public SKBuiltinString_t ToUserName
            {
                get
                {
                    return this.result.ToUserName;
                }
                set
                {
                    this.SetToUserName(value);
                }
            }
        }
    }
}


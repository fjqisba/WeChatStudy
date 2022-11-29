namespace micromsg
{
    using Google.ProtocolBuffers;

    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    using System.Runtime.CompilerServices;

    public sealed class DownloadVideoResponse : GeneratedMessageLite<DownloadVideoResponse, DownloadVideoResponse.Builder>
    {
        private static readonly string[] _downloadVideoResponseFieldNames = new string[] { "BaseResponse", "Data", "MsgId", "StartPos", "TotalLen" };
        private static readonly uint[] _downloadVideoResponseFieldTags = new uint[] { 10, 0x2a, 0x10, 0x20, 0x18 };
        private BaseResponse baseResponse_;
        public const int BaseResponseFieldNumber = 1;
        private SKBuiltinBuffer_t data_;
        public const int DataFieldNumber = 5;
        private static readonly DownloadVideoResponse defaultInstance = new DownloadVideoResponse().MakeReadOnly();
        private bool hasBaseResponse;
        private bool hasData;
        private bool hasMsgId;
        private bool hasStartPos;
        private bool hasTotalLen;
        private int memoizedSerializedSize = -1;
        private uint msgId_;
        public const int MsgIdFieldNumber = 2;
        private uint startPos_;
        public const int StartPosFieldNumber = 4;
        private uint totalLen_;
        public const int TotalLenFieldNumber = 3;

        static DownloadVideoResponse()
        {

        }

        private DownloadVideoResponse()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(DownloadVideoResponse prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            DownloadVideoResponse response = obj as DownloadVideoResponse;
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
            if ((this.hasTotalLen != response.hasTotalLen) || (this.hasTotalLen && !this.totalLen_.Equals(response.totalLen_)))
            {
                return false;
            }
            if ((this.hasStartPos != response.hasStartPos) || (this.hasStartPos && !this.startPos_.Equals(response.startPos_)))
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
            if (this.hasTotalLen)
            {
                hashCode ^= this.totalLen_.GetHashCode();
            }
            if (this.hasStartPos)
            {
                hashCode ^= this.startPos_.GetHashCode();
            }
            if (this.hasData)
            {
                hashCode ^= this.data_.GetHashCode();
            }
            return hashCode;
        }

        private DownloadVideoResponse MakeReadOnly()
        {
            return this;
        }

        public static DownloadVideoResponse ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<DownloadVideoResponse, Builder>.PrintField("BaseResponse", this.hasBaseResponse, this.baseResponse_, writer);
            GeneratedMessageLite<DownloadVideoResponse, Builder>.PrintField("MsgId", this.hasMsgId, this.msgId_, writer);
            GeneratedMessageLite<DownloadVideoResponse, Builder>.PrintField("TotalLen", this.hasTotalLen, this.totalLen_, writer);
            GeneratedMessageLite<DownloadVideoResponse, Builder>.PrintField("StartPos", this.hasStartPos, this.startPos_, writer);
            GeneratedMessageLite<DownloadVideoResponse, Builder>.PrintField("Data", this.hasData, this.data_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _downloadVideoResponseFieldNames;
            if (this.hasBaseResponse)
            {
                output.WriteMessage(1, strArray[0], this.BaseResponse);
            }
            if (this.hasMsgId)
            {
                output.WriteUInt32(2, strArray[2], this.MsgId);
            }
            if (this.hasTotalLen)
            {
                output.WriteUInt32(3, strArray[4], this.TotalLen);
            }
            if (this.hasStartPos)
            {
                output.WriteUInt32(4, strArray[3], this.StartPos);
            }
            if (this.hasData)
            {
                output.WriteMessage(5, strArray[1], this.Data);
            }
        }

        public BaseResponse BaseResponse
        {
            get
            {
                return (this.baseResponse_ ?? BaseResponse.DefaultInstance);
            }
        }

        public SKBuiltinBuffer_t Data
        {
            get
            {
                return (this.data_ ?? SKBuiltinBuffer_t.DefaultInstance);
            }
        }

        public static DownloadVideoResponse DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override DownloadVideoResponse DefaultInstanceForType
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
                if (!this.hasMsgId)
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
                    if (this.hasTotalLen)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(3, this.TotalLen);
                    }
                    if (this.hasStartPos)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(4, this.StartPos);
                    }
                    if (this.hasData)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(5, this.Data);
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

        protected override DownloadVideoResponse ThisMessage
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

        [GeneratedCode("ProtoGen", "2.3.0.277"), CompilerGenerated, DebuggerNonUserCode]
        public sealed class Builder : GeneratedBuilderLite<DownloadVideoResponse, DownloadVideoResponse.Builder>
        {
            private DownloadVideoResponse result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = DownloadVideoResponse.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(DownloadVideoResponse cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override DownloadVideoResponse BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override DownloadVideoResponse.Builder Clear()
            {
                this.result = DownloadVideoResponse.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public DownloadVideoResponse.Builder ClearBaseResponse()
            {
                this.PrepareBuilder();
                this.result.hasBaseResponse = false;
                this.result.baseResponse_ = null;
                return this;
            }

            public DownloadVideoResponse.Builder ClearData()
            {
                this.PrepareBuilder();
                this.result.hasData = false;
                this.result.data_ = null;
                return this;
            }

            public DownloadVideoResponse.Builder ClearMsgId()
            {
                this.PrepareBuilder();
                this.result.hasMsgId = false;
                this.result.msgId_ = 0;
                return this;
            }

            public DownloadVideoResponse.Builder ClearStartPos()
            {
                this.PrepareBuilder();
                this.result.hasStartPos = false;
                this.result.startPos_ = 0;
                return this;
            }

            public DownloadVideoResponse.Builder ClearTotalLen()
            {
                this.PrepareBuilder();
                this.result.hasTotalLen = false;
                this.result.totalLen_ = 0;
                return this;
            }

            public override DownloadVideoResponse.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new DownloadVideoResponse.Builder(this.result);
                }
                return new DownloadVideoResponse.Builder().MergeFrom(this.result);
            }

            public DownloadVideoResponse.Builder MergeBaseResponse(BaseResponse value)
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

            public DownloadVideoResponse.Builder MergeData(SKBuiltinBuffer_t value)
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

            public override DownloadVideoResponse.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override DownloadVideoResponse.Builder MergeFrom(IMessageLite other)
            {
                if (other is DownloadVideoResponse)
                {
                    return this.MergeFrom((DownloadVideoResponse) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override DownloadVideoResponse.Builder MergeFrom(DownloadVideoResponse other)
            {
                return this;
            }

            public override DownloadVideoResponse.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(DownloadVideoResponse._downloadVideoResponseFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = DownloadVideoResponse._downloadVideoResponseFieldTags[index];
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
                        case 0x10:
                        {
                            this.result.hasMsgId = input.ReadUInt32(ref this.result.msgId_);
                            continue;
                        }
                        case 0x18:
                        {
                            this.result.hasTotalLen = input.ReadUInt32(ref this.result.totalLen_);
                            continue;
                        }
                        case 0x20:
                        {
                            this.result.hasStartPos = input.ReadUInt32(ref this.result.startPos_);
                            continue;
                        }
                        case 0x2a:
                        {
                            SKBuiltinBuffer_t.Builder builder2 = SKBuiltinBuffer_t.CreateBuilder();
                            if (this.result.hasData)
                            {
                                builder2.MergeFrom(this.Data);
                            }
                            input.ReadMessage(builder2, extensionRegistry);
                            this.Data = builder2.BuildPartial();
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

            private DownloadVideoResponse PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    DownloadVideoResponse result = this.result;
                    this.result = new DownloadVideoResponse();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public DownloadVideoResponse.Builder SetBaseResponse(BaseResponse value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = value;
                return this;
            }

            public DownloadVideoResponse.Builder SetBaseResponse(BaseResponse.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = builderForValue.Build();
                return this;
            }

            public DownloadVideoResponse.Builder SetData(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasData = true;
                this.result.data_ = value;
                return this;
            }

            public DownloadVideoResponse.Builder SetData(SKBuiltinBuffer_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasData = true;
                this.result.data_ = builderForValue.Build();
                return this;
            }

            public DownloadVideoResponse.Builder SetMsgId(uint value)
            {
                this.PrepareBuilder();
                this.result.hasMsgId = true;
                this.result.msgId_ = value;
                return this;
            }

            public DownloadVideoResponse.Builder SetStartPos(uint value)
            {
                this.PrepareBuilder();
                this.result.hasStartPos = true;
                this.result.startPos_ = value;
                return this;
            }

            public DownloadVideoResponse.Builder SetTotalLen(uint value)
            {
                this.PrepareBuilder();
                this.result.hasTotalLen = true;
                this.result.totalLen_ = value;
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

            public override DownloadVideoResponse DefaultInstanceForType
            {
                get
                {
                    return DownloadVideoResponse.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override DownloadVideoResponse MessageBeingBuilt
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

            protected override DownloadVideoResponse.Builder ThisBuilder
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
        }
    }
}

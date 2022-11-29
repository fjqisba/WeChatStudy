namespace micromsg
{
    using Google.ProtocolBuffers;
    
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

    
    public sealed class DownloadVoiceResponse : GeneratedMessageLite<DownloadVoiceResponse, DownloadVoiceResponse.Builder>
    {
        private static readonly string[] _downloadVoiceResponseFieldNames = new string[] { "BaseResponse", "CancelFlag", "ClientMsgId", "Data", "EndFlag", "Length", "MsgId", "Offset", "VoiceLength" };
        private static readonly uint[] _downloadVoiceResponseFieldTags = new uint[] { 0x4a, 80, 50, 0x3a, 0x40, 0x18, 8, 0x10, 40 };
        private micromsg.BaseResponse baseResponse_;
        public const int BaseResponseFieldNumber = 9;
        private uint cancelFlag_;
        public const int CancelFlagFieldNumber = 10;
        private string clientMsgId_ = "";
        public const int ClientMsgIdFieldNumber = 6;
        private SKBuiltinBuffer_t data_;
        public const int DataFieldNumber = 7;
        private static readonly DownloadVoiceResponse defaultInstance = new DownloadVoiceResponse().MakeReadOnly();
        private uint endFlag_;
        public const int EndFlagFieldNumber = 8;
        private bool hasBaseResponse;
        private bool hasCancelFlag;
        private bool hasClientMsgId;
        private bool hasData;
        private bool hasEndFlag;
        private bool hasLength;
        private bool hasMsgId;
        private bool hasOffset;
        private bool hasVoiceLength;
        private uint length_;
        public const int LengthFieldNumber = 3;
        private int memoizedSerializedSize = -1;
        private uint msgId_;
        public const int MsgIdFieldNumber = 1;
        private uint offset_;
        public const int OffsetFieldNumber = 2;
        private uint voiceLength_;
        public const int VoiceLengthFieldNumber = 5;

        static DownloadVoiceResponse()
        {
           // object.ReferenceEquals(DownloadVoiceResponse.Descriptor, null);
        }

        private DownloadVoiceResponse()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(DownloadVoiceResponse prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            DownloadVoiceResponse response = obj as DownloadVoiceResponse;
            if (response == null)
            {
                return false;
            }
            if ((this.hasMsgId != response.hasMsgId) || (this.hasMsgId && !this.msgId_.Equals(response.msgId_)))
            {
                return false;
            }
            if ((this.hasOffset != response.hasOffset) || (this.hasOffset && !this.offset_.Equals(response.offset_)))
            {
                return false;
            }
            if ((this.hasLength != response.hasLength) || (this.hasLength && !this.length_.Equals(response.length_)))
            {
                return false;
            }
            if ((this.hasVoiceLength != response.hasVoiceLength) || (this.hasVoiceLength && !this.voiceLength_.Equals(response.voiceLength_)))
            {
                return false;
            }
            if ((this.hasClientMsgId != response.hasClientMsgId) || (this.hasClientMsgId && !this.clientMsgId_.Equals(response.clientMsgId_)))
            {
                return false;
            }
            if ((this.hasData != response.hasData) || (this.hasData && !this.data_.Equals(response.data_)))
            {
                return false;
            }
            if ((this.hasEndFlag != response.hasEndFlag) || (this.hasEndFlag && !this.endFlag_.Equals(response.endFlag_)))
            {
                return false;
            }
            if ((this.hasBaseResponse != response.hasBaseResponse) || (this.hasBaseResponse && !this.baseResponse_.Equals(response.baseResponse_)))
            {
                return false;
            }
            return ((this.hasCancelFlag == response.hasCancelFlag) && (!this.hasCancelFlag || this.cancelFlag_.Equals(response.cancelFlag_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasMsgId)
            {
                hashCode ^= this.msgId_.GetHashCode();
            }
            if (this.hasOffset)
            {
                hashCode ^= this.offset_.GetHashCode();
            }
            if (this.hasLength)
            {
                hashCode ^= this.length_.GetHashCode();
            }
            if (this.hasVoiceLength)
            {
                hashCode ^= this.voiceLength_.GetHashCode();
            }
            if (this.hasClientMsgId)
            {
                hashCode ^= this.clientMsgId_.GetHashCode();
            }
            if (this.hasData)
            {
                hashCode ^= this.data_.GetHashCode();
            }
            if (this.hasEndFlag)
            {
                hashCode ^= this.endFlag_.GetHashCode();
            }
            if (this.hasBaseResponse)
            {
                hashCode ^= this.baseResponse_.GetHashCode();
            }
            if (this.hasCancelFlag)
            {
                hashCode ^= this.cancelFlag_.GetHashCode();
            }
            return hashCode;
        }

        private DownloadVoiceResponse MakeReadOnly()
        {
            return this;
        }

        public static DownloadVoiceResponse ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<DownloadVoiceResponse, Builder>.PrintField("MsgId", this.hasMsgId, this.msgId_, writer);
            GeneratedMessageLite<DownloadVoiceResponse, Builder>.PrintField("Offset", this.hasOffset, this.offset_, writer);
            GeneratedMessageLite<DownloadVoiceResponse, Builder>.PrintField("Length", this.hasLength, this.length_, writer);
            GeneratedMessageLite<DownloadVoiceResponse, Builder>.PrintField("VoiceLength", this.hasVoiceLength, this.voiceLength_, writer);
            GeneratedMessageLite<DownloadVoiceResponse, Builder>.PrintField("ClientMsgId", this.hasClientMsgId, this.clientMsgId_, writer);
            GeneratedMessageLite<DownloadVoiceResponse, Builder>.PrintField("Data", this.hasData, this.data_, writer);
            GeneratedMessageLite<DownloadVoiceResponse, Builder>.PrintField("EndFlag", this.hasEndFlag, this.endFlag_, writer);
            GeneratedMessageLite<DownloadVoiceResponse, Builder>.PrintField("BaseResponse", this.hasBaseResponse, this.baseResponse_, writer);
            GeneratedMessageLite<DownloadVoiceResponse, Builder>.PrintField("CancelFlag", this.hasCancelFlag, this.cancelFlag_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _downloadVoiceResponseFieldNames;
            if (this.hasMsgId)
            {
                output.WriteUInt32(1, strArray[6], this.MsgId);
            }
            if (this.hasOffset)
            {
                output.WriteUInt32(2, strArray[7], this.Offset);
            }
            if (this.hasLength)
            {
                output.WriteUInt32(3, strArray[5], this.Length);
            }
            if (this.hasVoiceLength)
            {
                output.WriteUInt32(5, strArray[8], this.VoiceLength);
            }
            if (this.hasClientMsgId)
            {
                output.WriteString(6, strArray[2], this.ClientMsgId);
            }
            if (this.hasData)
            {
                output.WriteMessage(7, strArray[3], this.Data);
            }
            if (this.hasEndFlag)
            {
                output.WriteUInt32(8, strArray[4], this.EndFlag);
            }
            if (this.hasBaseResponse)
            {
                output.WriteMessage(9, strArray[0], this.BaseResponse);
            }
            if (this.hasCancelFlag)
            {
                output.WriteUInt32(10, strArray[1], this.CancelFlag);
            }
        }

        public micromsg.BaseResponse BaseResponse
        {
            get
            {
                return (this.baseResponse_ ?? micromsg.BaseResponse.DefaultInstance);
            }
        }

        public uint CancelFlag
        {
            get
            {
                return this.cancelFlag_;
            }
        }

        public string ClientMsgId
        {
            get
            {
                return this.clientMsgId_;
            }
        }

        public SKBuiltinBuffer_t Data
        {
            get
            {
                return (this.data_ ?? SKBuiltinBuffer_t.DefaultInstance);
            }
        }

        public static DownloadVoiceResponse DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override DownloadVoiceResponse DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public uint EndFlag
        {
            get
            {
                return this.endFlag_;
            }
        }

        public override bool IsInitialized
        {
            get
            {
                if (!this.hasMsgId)
                {
                    return false;
                }
                if (!this.hasOffset)
                {
                    return false;
                }
                if (!this.hasLength)
                {
                    return false;
                }
                if (!this.hasVoiceLength)
                {
                    return false;
                }
                if (!this.hasData)
                {
                    return false;
                }
                if (!this.hasEndFlag)
                {
                    return false;
                }
                if (!this.hasBaseResponse)
                {
                    return false;
                }
                if (!this.Data.IsInitialized)
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

        public uint Length
        {
            get
            {
                return this.length_;
            }
        }

        public uint MsgId
        {
            get
            {
                return this.msgId_;
            }
        }

        public uint Offset
        {
            get
            {
                return this.offset_;
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
                    if (this.hasMsgId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(1, this.MsgId);
                    }
                    if (this.hasOffset)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(2, this.Offset);
                    }
                    if (this.hasLength)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(3, this.Length);
                    }
                    if (this.hasVoiceLength)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(5, this.VoiceLength);
                    }
                    if (this.hasClientMsgId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(6, this.ClientMsgId);
                    }
                    if (this.hasData)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(7, this.Data);
                    }
                    if (this.hasEndFlag)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(8, this.EndFlag);
                    }
                    if (this.hasBaseResponse)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(9, this.BaseResponse);
                    }
                    if (this.hasCancelFlag)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(10, this.CancelFlag);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override DownloadVoiceResponse ThisMessage
        {
            get
            {
                return this;
            }
        }

        public uint VoiceLength
        {
            get
            {
                return this.voiceLength_;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<DownloadVoiceResponse, DownloadVoiceResponse.Builder>
        {
            private DownloadVoiceResponse result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = DownloadVoiceResponse.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(DownloadVoiceResponse cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override DownloadVoiceResponse BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override DownloadVoiceResponse.Builder Clear()
            {
                this.result = DownloadVoiceResponse.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public DownloadVoiceResponse.Builder ClearBaseResponse()
            {
                this.PrepareBuilder();
                this.result.hasBaseResponse = false;
                this.result.baseResponse_ = null;
                return this;
            }

            public DownloadVoiceResponse.Builder ClearCancelFlag()
            {
                this.PrepareBuilder();
                this.result.hasCancelFlag = false;
                this.result.cancelFlag_ = 0;
                return this;
            }

            public DownloadVoiceResponse.Builder ClearClientMsgId()
            {
                this.PrepareBuilder();
                this.result.hasClientMsgId = false;
                this.result.clientMsgId_ = "";
                return this;
            }

            public DownloadVoiceResponse.Builder ClearData()
            {
                this.PrepareBuilder();
                this.result.hasData = false;
                this.result.data_ = null;
                return this;
            }

            public DownloadVoiceResponse.Builder ClearEndFlag()
            {
                this.PrepareBuilder();
                this.result.hasEndFlag = false;
                this.result.endFlag_ = 0;
                return this;
            }

            public DownloadVoiceResponse.Builder ClearLength()
            {
                this.PrepareBuilder();
                this.result.hasLength = false;
                this.result.length_ = 0;
                return this;
            }

            public DownloadVoiceResponse.Builder ClearMsgId()
            {
                this.PrepareBuilder();
                this.result.hasMsgId = false;
                this.result.msgId_ = 0;
                return this;
            }

            public DownloadVoiceResponse.Builder ClearOffset()
            {
                this.PrepareBuilder();
                this.result.hasOffset = false;
                this.result.offset_ = 0;
                return this;
            }

            public DownloadVoiceResponse.Builder ClearVoiceLength()
            {
                this.PrepareBuilder();
                this.result.hasVoiceLength = false;
                this.result.voiceLength_ = 0;
                return this;
            }

            public override DownloadVoiceResponse.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new DownloadVoiceResponse.Builder(this.result);
                }
                return new DownloadVoiceResponse.Builder().MergeFrom(this.result);
            }

            public DownloadVoiceResponse.Builder MergeBaseResponse(micromsg.BaseResponse value)
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

            public DownloadVoiceResponse.Builder MergeData(SKBuiltinBuffer_t value)
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

            public override DownloadVoiceResponse.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override DownloadVoiceResponse.Builder MergeFrom(IMessageLite other)
            {
                if (other is DownloadVoiceResponse)
                {
                    return this.MergeFrom((DownloadVoiceResponse) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override DownloadVoiceResponse.Builder MergeFrom(DownloadVoiceResponse other)
            {
                return this;
            }

            public override DownloadVoiceResponse.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(DownloadVoiceResponse._downloadVoiceResponseFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = DownloadVoiceResponse._downloadVoiceResponseFieldTags[index];
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
                            this.result.hasOffset = input.ReadUInt32(ref this.result.offset_);
                            continue;
                        }
                        case 0x18:
                        {
                            this.result.hasLength = input.ReadUInt32(ref this.result.length_);
                            continue;
                        }
                        case 40:
                        {
                            this.result.hasVoiceLength = input.ReadUInt32(ref this.result.voiceLength_);
                            continue;
                        }
                        case 0:
                            throw InvalidProtocolBufferException.InvalidTag();

                        case 8:
                        {
                            this.result.hasMsgId = input.ReadUInt32(ref this.result.msgId_);
                            continue;
                        }
                        case 50:
                        {
                            this.result.hasClientMsgId = input.ReadString(ref this.result.clientMsgId_);
                            continue;
                        }
                        case 0x3a:
                        {
                            SKBuiltinBuffer_t.Builder builder = SKBuiltinBuffer_t.CreateBuilder();
                            if (this.result.hasData)
                            {
                                builder.MergeFrom(this.Data);
                            }
                            input.ReadMessage(builder, extensionRegistry);
                            this.Data = builder.BuildPartial();
                            continue;
                        }
                        case 0x40:
                        {
                            this.result.hasEndFlag = input.ReadUInt32(ref this.result.endFlag_);
                            continue;
                        }
                        case 0x4a:
                        {
                            micromsg.BaseResponse.Builder builder2 = micromsg.BaseResponse.CreateBuilder();
                            if (this.result.hasBaseResponse)
                            {
                                builder2.MergeFrom(this.BaseResponse);
                            }
                            input.ReadMessage(builder2, extensionRegistry);
                            this.BaseResponse = builder2.BuildPartial();
                            continue;
                        }
                        case 80:
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
                    this.result.hasCancelFlag = input.ReadUInt32(ref this.result.cancelFlag_);
                }
                return this;
            }

            private DownloadVoiceResponse PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    DownloadVoiceResponse result = this.result;
                    this.result = new DownloadVoiceResponse();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public DownloadVoiceResponse.Builder SetBaseResponse(micromsg.BaseResponse value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = value;
                return this;
            }

            public DownloadVoiceResponse.Builder SetBaseResponse(micromsg.BaseResponse.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = builderForValue.Build();
                return this;
            }

            public DownloadVoiceResponse.Builder SetCancelFlag(uint value)
            {
                this.PrepareBuilder();
                this.result.hasCancelFlag = true;
                this.result.cancelFlag_ = value;
                return this;
            }

            public DownloadVoiceResponse.Builder SetClientMsgId(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasClientMsgId = true;
                this.result.clientMsgId_ = value;
                return this;
            }

            public DownloadVoiceResponse.Builder SetData(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasData = true;
                this.result.data_ = value;
                return this;
            }

            public DownloadVoiceResponse.Builder SetData(SKBuiltinBuffer_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasData = true;
                this.result.data_ = builderForValue.Build();
                return this;
            }

            public DownloadVoiceResponse.Builder SetEndFlag(uint value)
            {
                this.PrepareBuilder();
                this.result.hasEndFlag = true;
                this.result.endFlag_ = value;
                return this;
            }

            public DownloadVoiceResponse.Builder SetLength(uint value)
            {
                this.PrepareBuilder();
                this.result.hasLength = true;
                this.result.length_ = value;
                return this;
            }

            public DownloadVoiceResponse.Builder SetMsgId(uint value)
            {
                this.PrepareBuilder();
                this.result.hasMsgId = true;
                this.result.msgId_ = value;
                return this;
            }

            public DownloadVoiceResponse.Builder SetOffset(uint value)
            {
                this.PrepareBuilder();
                this.result.hasOffset = true;
                this.result.offset_ = value;
                return this;
            }

            public DownloadVoiceResponse.Builder SetVoiceLength(uint value)
            {
                this.PrepareBuilder();
                this.result.hasVoiceLength = true;
                this.result.voiceLength_ = value;
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

            public uint CancelFlag
            {
                get
                {
                    return this.result.CancelFlag;
                }
                set
                {
                    this.SetCancelFlag(value);
                }
            }

            public string ClientMsgId
            {
                get
                {
                    return this.result.ClientMsgId;
                }
                set
                {
                    this.SetClientMsgId(value);
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

            public override DownloadVoiceResponse DefaultInstanceForType
            {
                get
                {
                    return DownloadVoiceResponse.DefaultInstance;
                }
            }

            public uint EndFlag
            {
                get
                {
                    return this.result.EndFlag;
                }
                set
                {
                    this.SetEndFlag(value);
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            public uint Length
            {
                get
                {
                    return this.result.Length;
                }
                set
                {
                    this.SetLength(value);
                }
            }

            protected override DownloadVoiceResponse MessageBeingBuilt
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

            public uint Offset
            {
                get
                {
                    return this.result.Offset;
                }
                set
                {
                    this.SetOffset(value);
                }
            }

            protected override DownloadVoiceResponse.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }

            public uint VoiceLength
            {
                get
                {
                    return this.result.VoiceLength;
                }
                set
                {
                    this.SetVoiceLength(value);
                }
            }
        }
    }
}


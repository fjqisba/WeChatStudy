namespace micromsg
{
    using Google.ProtocolBuffers;

    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

    
    public sealed class UploadVideoResponse : GeneratedMessageLite<UploadVideoResponse, UploadVideoResponse.Builder>
    {
        private static readonly string[] _uploadVideoResponseFieldNames = new string[] { "BaseResponse", "ClientMsgId", "MsgId", "NewMsgId", "ThumbStartPos", "VideoStartPos" };
        private static readonly uint[] _uploadVideoResponseFieldTags = new uint[] { 10, 0x12, 0x18, 0x30, 0x20, 40 };
        private BaseResponse baseResponse_;
        public const int BaseResponseFieldNumber = 1;
        private string clientMsgId_ = "";
        public const int ClientMsgIdFieldNumber = 2;
        private static readonly UploadVideoResponse defaultInstance = new UploadVideoResponse().MakeReadOnly();
        private bool hasBaseResponse;
        private bool hasClientMsgId;
        private bool hasMsgId;
        private bool hasNewMsgId;
        private bool hasThumbStartPos;
        private bool hasVideoStartPos;
        private int memoizedSerializedSize = -1;
        private uint msgId_;
        public const int MsgIdFieldNumber = 3;
        private ulong newMsgId_;
        public const int NewMsgIdFieldNumber = 6;
        private uint thumbStartPos_;
        public const int ThumbStartPosFieldNumber = 4;
        private uint videoStartPos_;
        public const int VideoStartPosFieldNumber = 5;

        static UploadVideoResponse()
        {

        }

        private UploadVideoResponse()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(UploadVideoResponse prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            UploadVideoResponse response = obj as UploadVideoResponse;
            if (response == null)
            {
                return false;
            }
            if ((this.hasBaseResponse != response.hasBaseResponse) || (this.hasBaseResponse && !this.baseResponse_.Equals(response.baseResponse_)))
            {
                return false;
            }
            if ((this.hasClientMsgId != response.hasClientMsgId) || (this.hasClientMsgId && !this.clientMsgId_.Equals(response.clientMsgId_)))
            {
                return false;
            }
            if ((this.hasMsgId != response.hasMsgId) || (this.hasMsgId && !this.msgId_.Equals(response.msgId_)))
            {
                return false;
            }
            if ((this.hasThumbStartPos != response.hasThumbStartPos) || (this.hasThumbStartPos && !this.thumbStartPos_.Equals(response.thumbStartPos_)))
            {
                return false;
            }
            if ((this.hasVideoStartPos != response.hasVideoStartPos) || (this.hasVideoStartPos && !this.videoStartPos_.Equals(response.videoStartPos_)))
            {
                return false;
            }
            return ((this.hasNewMsgId == response.hasNewMsgId) && (!this.hasNewMsgId || this.newMsgId_.Equals(response.newMsgId_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasBaseResponse)
            {
                hashCode ^= this.baseResponse_.GetHashCode();
            }
            if (this.hasClientMsgId)
            {
                hashCode ^= this.clientMsgId_.GetHashCode();
            }
            if (this.hasMsgId)
            {
                hashCode ^= this.msgId_.GetHashCode();
            }
            if (this.hasThumbStartPos)
            {
                hashCode ^= this.thumbStartPos_.GetHashCode();
            }
            if (this.hasVideoStartPos)
            {
                hashCode ^= this.videoStartPos_.GetHashCode();
            }
            if (this.hasNewMsgId)
            {
                hashCode ^= this.newMsgId_.GetHashCode();
            }
            return hashCode;
        }

        private UploadVideoResponse MakeReadOnly()
        {
            return this;
        }

        public static UploadVideoResponse ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<UploadVideoResponse, Builder>.PrintField("BaseResponse", this.hasBaseResponse, this.baseResponse_, writer);
            GeneratedMessageLite<UploadVideoResponse, Builder>.PrintField("ClientMsgId", this.hasClientMsgId, this.clientMsgId_, writer);
            GeneratedMessageLite<UploadVideoResponse, Builder>.PrintField("MsgId", this.hasMsgId, this.msgId_, writer);
            GeneratedMessageLite<UploadVideoResponse, Builder>.PrintField("ThumbStartPos", this.hasThumbStartPos, this.thumbStartPos_, writer);
            GeneratedMessageLite<UploadVideoResponse, Builder>.PrintField("VideoStartPos", this.hasVideoStartPos, this.videoStartPos_, writer);
            GeneratedMessageLite<UploadVideoResponse, Builder>.PrintField("NewMsgId", this.hasNewMsgId, this.newMsgId_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _uploadVideoResponseFieldNames;
            if (this.hasBaseResponse)
            {
                output.WriteMessage(1, strArray[0], this.BaseResponse);
            }
            if (this.hasClientMsgId)
            {
                output.WriteString(2, strArray[1], this.ClientMsgId);
            }
            if (this.hasMsgId)
            {
                output.WriteUInt32(3, strArray[2], this.MsgId);
            }
            if (this.hasThumbStartPos)
            {
                output.WriteUInt32(4, strArray[4], this.ThumbStartPos);
            }
            if (this.hasVideoStartPos)
            {
                output.WriteUInt32(5, strArray[5], this.VideoStartPos);
            }
            if (this.hasNewMsgId)
            {
                output.WriteUInt64(6, strArray[3], this.NewMsgId);
            }
        }

        public BaseResponse BaseResponse
        {
            get
            {
                return (this.baseResponse_ ?? BaseResponse.DefaultInstance);
            }
        }

        public string ClientMsgId
        {
            get
            {
                return this.clientMsgId_;
            }
        }

        public static UploadVideoResponse DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override UploadVideoResponse DefaultInstanceForType
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
                if (!this.hasThumbStartPos)
                {
                    return false;
                }
                if (!this.hasVideoStartPos)
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

        public uint MsgId
        {
            get
            {
                return this.msgId_;
            }
        }

        public ulong NewMsgId
        {
            get
            {
                return this.newMsgId_;
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
                    if (this.hasClientMsgId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(2, this.ClientMsgId);
                    }
                    if (this.hasMsgId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(3, this.MsgId);
                    }
                    if (this.hasThumbStartPos)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(4, this.ThumbStartPos);
                    }
                    if (this.hasVideoStartPos)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(5, this.VideoStartPos);
                    }
                    if (this.hasNewMsgId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt64Size(6, this.NewMsgId);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override UploadVideoResponse ThisMessage
        {
            get
            {
                return this;
            }
        }

        public uint ThumbStartPos
        {
            get
            {
                return this.thumbStartPos_;
            }
        }

        public uint VideoStartPos
        {
            get
            {
                return this.videoStartPos_;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<UploadVideoResponse, UploadVideoResponse.Builder>
        {
            private UploadVideoResponse result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = UploadVideoResponse.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(UploadVideoResponse cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override UploadVideoResponse BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override UploadVideoResponse.Builder Clear()
            {
                this.result = UploadVideoResponse.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public UploadVideoResponse.Builder ClearBaseResponse()
            {
                this.PrepareBuilder();
                this.result.hasBaseResponse = false;
                this.result.baseResponse_ = null;
                return this;
            }

            public UploadVideoResponse.Builder ClearClientMsgId()
            {
                this.PrepareBuilder();
                this.result.hasClientMsgId = false;
                this.result.clientMsgId_ = "";
                return this;
            }

            public UploadVideoResponse.Builder ClearMsgId()
            {
                this.PrepareBuilder();
                this.result.hasMsgId = false;
                this.result.msgId_ = 0;
                return this;
            }

            public UploadVideoResponse.Builder ClearNewMsgId()
            {
                this.PrepareBuilder();
                this.result.hasNewMsgId = false;
                this.result.newMsgId_ = 0L;
                return this;
            }

            public UploadVideoResponse.Builder ClearThumbStartPos()
            {
                this.PrepareBuilder();
                this.result.hasThumbStartPos = false;
                this.result.thumbStartPos_ = 0;
                return this;
            }

            public UploadVideoResponse.Builder ClearVideoStartPos()
            {
                this.PrepareBuilder();
                this.result.hasVideoStartPos = false;
                this.result.videoStartPos_ = 0;
                return this;
            }

            public override UploadVideoResponse.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new UploadVideoResponse.Builder(this.result);
                }
                return new UploadVideoResponse.Builder().MergeFrom(this.result);
            }

            public UploadVideoResponse.Builder MergeBaseResponse(BaseResponse value)
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

            public override UploadVideoResponse.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override UploadVideoResponse.Builder MergeFrom(IMessageLite other)
            {
                if (other is UploadVideoResponse)
                {
                    return this.MergeFrom((UploadVideoResponse) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override UploadVideoResponse.Builder MergeFrom(UploadVideoResponse other)
            {
                return this;
            }

            public override UploadVideoResponse.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(UploadVideoResponse._uploadVideoResponseFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = UploadVideoResponse._uploadVideoResponseFieldTags[index];
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
                            this.result.hasClientMsgId = input.ReadString(ref this.result.clientMsgId_);
                            continue;
                        }
                        case 0x18:
                        {
                            this.result.hasMsgId = input.ReadUInt32(ref this.result.msgId_);
                            continue;
                        }
                        case 0x20:
                        {
                            this.result.hasThumbStartPos = input.ReadUInt32(ref this.result.thumbStartPos_);
                            continue;
                        }
                        case 40:
                        {
                            this.result.hasVideoStartPos = input.ReadUInt32(ref this.result.videoStartPos_);
                            continue;
                        }
                        case 0x30:
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
                    this.result.hasNewMsgId = input.ReadUInt64(ref this.result.newMsgId_);
                }
                return this;
            }

            private UploadVideoResponse PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    UploadVideoResponse result = this.result;
                    this.result = new UploadVideoResponse();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public UploadVideoResponse.Builder SetBaseResponse(BaseResponse value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = value;
                return this;
            }

            public UploadVideoResponse.Builder SetBaseResponse(BaseResponse.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = builderForValue.Build();
                return this;
            }

            public UploadVideoResponse.Builder SetClientMsgId(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasClientMsgId = true;
                this.result.clientMsgId_ = value;
                return this;
            }

            public UploadVideoResponse.Builder SetMsgId(uint value)
            {
                this.PrepareBuilder();
                this.result.hasMsgId = true;
                this.result.msgId_ = value;
                return this;
            }

            public UploadVideoResponse.Builder SetNewMsgId(ulong value)
            {
                this.PrepareBuilder();
                this.result.hasNewMsgId = true;
                this.result.newMsgId_ = value;
                return this;
            }

            public UploadVideoResponse.Builder SetThumbStartPos(uint value)
            {
                this.PrepareBuilder();
                this.result.hasThumbStartPos = true;
                this.result.thumbStartPos_ = value;
                return this;
            }

            public UploadVideoResponse.Builder SetVideoStartPos(uint value)
            {
                this.PrepareBuilder();
                this.result.hasVideoStartPos = true;
                this.result.videoStartPos_ = value;
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

            public override UploadVideoResponse DefaultInstanceForType
            {
                get
                {
                    return UploadVideoResponse.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override UploadVideoResponse MessageBeingBuilt
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

            public ulong NewMsgId
            {
                get
                {
                    return this.result.NewMsgId;
                }
                set
                {
                    this.SetNewMsgId(value);
                }
            }

            protected override UploadVideoResponse.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }

            public uint ThumbStartPos
            {
                get
                {
                    return this.result.ThumbStartPos;
                }
                set
                {
                    this.SetThumbStartPos(value);
                }
            }

            public uint VideoStartPos
            {
                get
                {
                    return this.result.VideoStartPos;
                }
                set
                {
                    this.SetVideoStartPos(value);
                }
            }
        }
    }
}

namespace micromsg
{
    using Google.ProtocolBuffers;
   
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

   // 
    public sealed class MicroMsgRequest : GeneratedMessageLite<MicroMsgRequest, MicroMsgRequest.Builder>
    {
        private static readonly string[] _microMsgRequestFieldNames = new string[] { "ClientMsgId", "Content", "CreateTime", "EmojiFlag", "FromUserName", "MsgSource", "ToUserName", "Type" };
        private static readonly uint[] _microMsgRequestFieldTags = new uint[] { 50, 0x22, 40, 0x40, 10, 0x3a, 0x12, 0x18 };
        private string clientMsgId_ = "";
        public const int ClientMsgIdFieldNumber = 6;
        private string content_ = "";
        public const int ContentFieldNumber = 4;
        private uint createTime_;
        public const int CreateTimeFieldNumber = 5;
        private static readonly MicroMsgRequest defaultInstance = new MicroMsgRequest().MakeReadOnly();
        private uint emojiFlag_;
        public const int EmojiFlagFieldNumber = 8;
        private SKBuiltinString_t fromUserName_;
        public const int FromUserNameFieldNumber = 1;
        private bool hasClientMsgId;
        private bool hasContent;
        private bool hasCreateTime;
        private bool hasEmojiFlag;
        private bool hasFromUserName;
        private bool hasMsgSource;
        private bool hasToUserName;
        private bool hasType;
        private int memoizedSerializedSize = -1;
        private string msgSource_ = "";
        public const int MsgSourceFieldNumber = 7;
        private SKBuiltinString_t toUserName_;
        public const int ToUserNameFieldNumber = 2;
        private uint type_;
        public const int TypeFieldNumber = 3;

        static MicroMsgRequest()
        {
            //object.ReferenceEquals(MicroMsgRequest.Descriptor, null);
        }

        private MicroMsgRequest()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(MicroMsgRequest prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            MicroMsgRequest request = obj as MicroMsgRequest;
            if (request == null)
            {
                return false;
            }
            if ((this.hasFromUserName != request.hasFromUserName) || (this.hasFromUserName && !this.fromUserName_.Equals(request.fromUserName_)))
            {
                return false;
            }
            if ((this.hasToUserName != request.hasToUserName) || (this.hasToUserName && !this.toUserName_.Equals(request.toUserName_)))
            {
                return false;
            }
            if ((this.hasType != request.hasType) || (this.hasType && !this.type_.Equals(request.type_)))
            {
                return false;
            }
            if ((this.hasContent != request.hasContent) || (this.hasContent && !this.content_.Equals(request.content_)))
            {
                return false;
            }
            if ((this.hasCreateTime != request.hasCreateTime) || (this.hasCreateTime && !this.createTime_.Equals(request.createTime_)))
            {
                return false;
            }
            if ((this.hasClientMsgId != request.hasClientMsgId) || (this.hasClientMsgId && !this.clientMsgId_.Equals(request.clientMsgId_)))
            {
                return false;
            }
            if ((this.hasMsgSource != request.hasMsgSource) || (this.hasMsgSource && !this.msgSource_.Equals(request.msgSource_)))
            {
                return false;
            }
            return ((this.hasEmojiFlag == request.hasEmojiFlag) && (!this.hasEmojiFlag || this.emojiFlag_.Equals(request.emojiFlag_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasFromUserName)
            {
                hashCode ^= this.fromUserName_.GetHashCode();
            }
            if (this.hasToUserName)
            {
                hashCode ^= this.toUserName_.GetHashCode();
            }
            if (this.hasType)
            {
                hashCode ^= this.type_.GetHashCode();
            }
            if (this.hasContent)
            {
                hashCode ^= this.content_.GetHashCode();
            }
            if (this.hasCreateTime)
            {
                hashCode ^= this.createTime_.GetHashCode();
            }
            if (this.hasClientMsgId)
            {
                hashCode ^= this.clientMsgId_.GetHashCode();
            }
            if (this.hasMsgSource)
            {
                hashCode ^= this.msgSource_.GetHashCode();
            }
            if (this.hasEmojiFlag)
            {
                hashCode ^= this.emojiFlag_.GetHashCode();
            }
            return hashCode;
        }

        private MicroMsgRequest MakeReadOnly()
        {
            return this;
        }

        public static MicroMsgRequest ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<MicroMsgRequest, Builder>.PrintField("FromUserName", this.hasFromUserName, this.fromUserName_, writer);
            GeneratedMessageLite<MicroMsgRequest, Builder>.PrintField("ToUserName", this.hasToUserName, this.toUserName_, writer);
            GeneratedMessageLite<MicroMsgRequest, Builder>.PrintField("Type", this.hasType, this.type_, writer);
            GeneratedMessageLite<MicroMsgRequest, Builder>.PrintField("Content", this.hasContent, this.content_, writer);
            GeneratedMessageLite<MicroMsgRequest, Builder>.PrintField("CreateTime", this.hasCreateTime, this.createTime_, writer);
            GeneratedMessageLite<MicroMsgRequest, Builder>.PrintField("ClientMsgId", this.hasClientMsgId, this.clientMsgId_, writer);
            GeneratedMessageLite<MicroMsgRequest, Builder>.PrintField("MsgSource", this.hasMsgSource, this.msgSource_, writer);
            GeneratedMessageLite<MicroMsgRequest, Builder>.PrintField("EmojiFlag", this.hasEmojiFlag, this.emojiFlag_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _microMsgRequestFieldNames;
            if (this.hasFromUserName)
            {
                output.WriteMessage(1, strArray[4], this.FromUserName);
            }
            if (this.hasToUserName)
            {
                output.WriteMessage(2, strArray[6], this.ToUserName);
            }
            if (this.hasType)
            {
                output.WriteUInt32(3, strArray[7], this.Type);
            }
            if (this.hasContent)
            {
                output.WriteString(4, strArray[1], this.Content);
            }
            if (this.hasCreateTime)
            {
                output.WriteUInt32(5, strArray[2], this.CreateTime);
            }
            if (this.hasClientMsgId)
            {
                output.WriteString(6, strArray[0], this.ClientMsgId);
            }
            if (this.hasMsgSource)
            {
                output.WriteString(7, strArray[5], this.MsgSource);
            }
            if (this.hasEmojiFlag)
            {
                output.WriteUInt32(8, strArray[3], this.EmojiFlag);
            }
        }

        public string ClientMsgId
        {
            get
            {
                return this.clientMsgId_;
            }
        }

        public string Content
        {
            get
            {
                return this.content_;
            }
        }

        public uint CreateTime
        {
            get
            {
                return this.createTime_;
            }
        }

        public static MicroMsgRequest DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override MicroMsgRequest DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public uint EmojiFlag
        {
            get
            {
                return this.emojiFlag_;
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
                if (!this.hasFromUserName)
                {
                    return false;
                }
                if (!this.hasToUserName)
                {
                    return false;
                }
                if (!this.hasType)
                {
                    return false;
                }
                if (!this.hasCreateTime)
                {
                    return false;
                }
                return true;
            }
        }

        public string MsgSource
        {
            get
            {
                return this.msgSource_;
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
                    if (this.hasFromUserName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(1, this.FromUserName);
                    }
                    if (this.hasToUserName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(2, this.ToUserName);
                    }
                    if (this.hasType)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(3, this.Type);
                    }
                    if (this.hasContent)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(4, this.Content);
                    }
                    if (this.hasCreateTime)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(5, this.CreateTime);
                    }
                    if (this.hasClientMsgId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(6, this.ClientMsgId);
                    }
                    if (this.hasMsgSource)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(7, this.MsgSource);
                    }
                    if (this.hasEmojiFlag)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(8, this.EmojiFlag);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override MicroMsgRequest ThisMessage
        {
            get
            {
                return this;
            }
        }

        public SKBuiltinString_t ToUserName
        {
            get
            {
                return (this.toUserName_ ?? SKBuiltinString_t.DefaultInstance);
            }
        }

        public uint Type
        {
            get
            {
                return this.type_;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<MicroMsgRequest, MicroMsgRequest.Builder>
        {
            private MicroMsgRequest result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = MicroMsgRequest.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(MicroMsgRequest cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override MicroMsgRequest BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override MicroMsgRequest.Builder Clear()
            {
                this.result = MicroMsgRequest.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public MicroMsgRequest.Builder ClearClientMsgId()
            {
                this.PrepareBuilder();
                this.result.hasClientMsgId = false;
                this.result.clientMsgId_ = "";
                return this;
            }

            public MicroMsgRequest.Builder ClearContent()
            {
                this.PrepareBuilder();
                this.result.hasContent = false;
                this.result.content_ = "";
                return this;
            }

            public MicroMsgRequest.Builder ClearCreateTime()
            {
                this.PrepareBuilder();
                this.result.hasCreateTime = false;
                this.result.createTime_ = 0;
                return this;
            }

            public MicroMsgRequest.Builder ClearEmojiFlag()
            {
                this.PrepareBuilder();
                this.result.hasEmojiFlag = false;
                this.result.emojiFlag_ = 0;
                return this;
            }

            public MicroMsgRequest.Builder ClearFromUserName()
            {
                this.PrepareBuilder();
                this.result.hasFromUserName = false;
                this.result.fromUserName_ = null;
                return this;
            }

            public MicroMsgRequest.Builder ClearMsgSource()
            {
                this.PrepareBuilder();
                this.result.hasMsgSource = false;
                this.result.msgSource_ = "";
                return this;
            }

            public MicroMsgRequest.Builder ClearToUserName()
            {
                this.PrepareBuilder();
                this.result.hasToUserName = false;
                this.result.toUserName_ = null;
                return this;
            }

            public MicroMsgRequest.Builder ClearType()
            {
                this.PrepareBuilder();
                this.result.hasType = false;
                this.result.type_ = 0;
                return this;
            }

            public override MicroMsgRequest.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new MicroMsgRequest.Builder(this.result);
                }
                return new MicroMsgRequest.Builder().MergeFrom(this.result);
            }

            public override MicroMsgRequest.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override MicroMsgRequest.Builder MergeFrom(IMessageLite other)
            {
                if (other is MicroMsgRequest)
                {
                    return this.MergeFrom((MicroMsgRequest) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override MicroMsgRequest.Builder MergeFrom(MicroMsgRequest other)
            {
                return this;
            }

            public override MicroMsgRequest.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(MicroMsgRequest._microMsgRequestFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = MicroMsgRequest._microMsgRequestFieldTags[index];
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
                            SKBuiltinString_t.Builder builder2 = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasToUserName)
                            {
                                builder2.MergeFrom(this.ToUserName);
                            }
                            input.ReadMessage(builder2, extensionRegistry);
                            this.ToUserName = builder2.BuildPartial();
                            continue;
                        }
                        case 0x18:
                        {
                            this.result.hasType = input.ReadUInt32(ref this.result.type_);
                            continue;
                        }
                        case 0:
                            throw InvalidProtocolBufferException.InvalidTag();

                        case 10:
                        {
                            SKBuiltinString_t.Builder builder = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasFromUserName)
                            {
                                builder.MergeFrom(this.FromUserName);
                            }
                            input.ReadMessage(builder, extensionRegistry);
                            this.FromUserName = builder.BuildPartial();
                            continue;
                        }
                        case 0x22:
                        {
                            this.result.hasContent = input.ReadString(ref this.result.content_);
                            continue;
                        }
                        case 40:
                        {
                            this.result.hasCreateTime = input.ReadUInt32(ref this.result.createTime_);
                            continue;
                        }
                        case 50:
                        {
                            this.result.hasClientMsgId = input.ReadString(ref this.result.clientMsgId_);
                            continue;
                        }
                        case 0x3a:
                        {
                            this.result.hasMsgSource = input.ReadString(ref this.result.msgSource_);
                            continue;
                        }
                        case 0x40:
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
                    this.result.hasEmojiFlag = input.ReadUInt32(ref this.result.emojiFlag_);
                }
                return this;
            }

            public MicroMsgRequest.Builder MergeFromUserName(SKBuiltinString_t value)
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

            public MicroMsgRequest.Builder MergeToUserName(SKBuiltinString_t value)
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

            private MicroMsgRequest PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    MicroMsgRequest result = this.result;
                    this.result = new MicroMsgRequest();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public MicroMsgRequest.Builder SetClientMsgId(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasClientMsgId = true;
                this.result.clientMsgId_ = value;
                return this;
            }

            public MicroMsgRequest.Builder SetContent(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasContent = true;
                this.result.content_ = value;
                return this;
            }

            public MicroMsgRequest.Builder SetCreateTime(uint value)
            {
                this.PrepareBuilder();
                this.result.hasCreateTime = true;
                this.result.createTime_ = value;
                return this;
            }

            public MicroMsgRequest.Builder SetEmojiFlag(uint value)
            {
                this.PrepareBuilder();
                this.result.hasEmojiFlag = true;
                this.result.emojiFlag_ = value;
                return this;
            }

            public MicroMsgRequest.Builder SetFromUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasFromUserName = true;
                this.result.fromUserName_ = value;
                return this;
            }

            public MicroMsgRequest.Builder SetFromUserName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasFromUserName = true;
                this.result.fromUserName_ = builderForValue.Build();
                return this;
            }

            public MicroMsgRequest.Builder SetMsgSource(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasMsgSource = true;
                this.result.msgSource_ = value;
                return this;
            }

            public MicroMsgRequest.Builder SetToUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasToUserName = true;
                this.result.toUserName_ = value;
                return this;
            }

            public MicroMsgRequest.Builder SetToUserName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasToUserName = true;
                this.result.toUserName_ = builderForValue.Build();
                return this;
            }

            public MicroMsgRequest.Builder SetType(uint value)
            {
                this.PrepareBuilder();
                this.result.hasType = true;
                this.result.type_ = value;
                return this;
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

            public string Content
            {
                get
                {
                    return this.result.Content;
                }
                set
                {
                    this.SetContent(value);
                }
            }

            public uint CreateTime
            {
                get
                {
                    return this.result.CreateTime;
                }
                set
                {
                    this.SetCreateTime(value);
                }
            }

            public override MicroMsgRequest DefaultInstanceForType
            {
                get
                {
                    return MicroMsgRequest.DefaultInstance;
                }
            }

            public uint EmojiFlag
            {
                get
                {
                    return this.result.EmojiFlag;
                }
                set
                {
                    this.SetEmojiFlag(value);
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

            protected override MicroMsgRequest MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public string MsgSource
            {
                get
                {
                    return this.result.MsgSource;
                }
                set
                {
                    this.SetMsgSource(value);
                }
            }

            protected override MicroMsgRequest.Builder ThisBuilder
            {
                get
                {
                    return this;
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

            public uint Type
            {
                get
                {
                    return this.result.Type;
                }
                set
                {
                    this.SetType(value);
                }
            }
        }
    }
}


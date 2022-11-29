namespace micromsg
{
    using Google.ProtocolBuffers;

    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    using System.Runtime.CompilerServices;


    public sealed class AddMsg : GeneratedMessageLite<AddMsg, AddMsg.Builder>
    {
        private static readonly string[] _addMsgFieldNames = new string[] { "Content", "CreateTime", "FromUserName", "ImgBuf", "ImgStatus", "MsgId", "MsgSource", "MsgType", "NewMsgId", "PushContent", "Status", "ToUserName" };
        private static readonly uint[] _addMsgFieldTags = new uint[] { 0x2a, 0x48, 0x12, 0x42, 0x38, 8, 0x52, 0x20, 0x60, 90, 0x30, 0x1a };
        private SKBuiltinString_t content_;
        public const int ContentFieldNumber = 5;
        private uint createTime_;
        public const int CreateTimeFieldNumber = 9;
        private static readonly AddMsg defaultInstance = new AddMsg().MakeReadOnly();
        private SKBuiltinString_t fromUserName_;
        public const int FromUserNameFieldNumber = 2;
        private bool hasContent;
        private bool hasCreateTime;
        private bool hasFromUserName;
        private bool hasImgBuf;
        private bool hasImgStatus;
        private bool hasMsgId;
        private bool hasMsgSource;
        private bool hasMsgType;
        private bool hasNewMsgId;
        private bool hasPushContent;
        private bool hasStatus;
        private bool hasToUserName;
        private SKBuiltinBuffer_t imgBuf_;
        public const int ImgBufFieldNumber = 8;
        private uint imgStatus_;
        public const int ImgStatusFieldNumber = 7;
        private int memoizedSerializedSize = -1;
        private int msgId_;
        public const int MsgIdFieldNumber = 1;
        private string msgSource_ = "";
        public const int MsgSourceFieldNumber = 10;
        private int msgType_;
        public const int MsgTypeFieldNumber = 4;
        private long newMsgId_;
        public const int NewMsgIdFieldNumber = 12;
        private string pushContent_ = "";
        public const int PushContentFieldNumber = 11;
        private uint status_;
        public const int StatusFieldNumber = 6;
        private SKBuiltinString_t toUserName_;
        public const int ToUserNameFieldNumber = 3;

        static AddMsg()
        {

        }

        private AddMsg()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(AddMsg prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            AddMsg msg = obj as AddMsg;
            if (msg == null)
            {
                return false;
            }
            if ((this.hasMsgId != msg.hasMsgId) || (this.hasMsgId && !this.msgId_.Equals(msg.msgId_)))
            {
                return false;
            }
            if ((this.hasFromUserName != msg.hasFromUserName) || (this.hasFromUserName && !this.fromUserName_.Equals(msg.fromUserName_)))
            {
                return false;
            }
            if ((this.hasToUserName != msg.hasToUserName) || (this.hasToUserName && !this.toUserName_.Equals(msg.toUserName_)))
            {
                return false;
            }
            if ((this.hasMsgType != msg.hasMsgType) || (this.hasMsgType && !this.msgType_.Equals(msg.msgType_)))
            {
                return false;
            }
            if ((this.hasContent != msg.hasContent) || (this.hasContent && !this.content_.Equals(msg.content_)))
            {
                return false;
            }
            if ((this.hasStatus != msg.hasStatus) || (this.hasStatus && !this.status_.Equals(msg.status_)))
            {
                return false;
            }
            if ((this.hasImgStatus != msg.hasImgStatus) || (this.hasImgStatus && !this.imgStatus_.Equals(msg.imgStatus_)))
            {
                return false;
            }
            if ((this.hasImgBuf != msg.hasImgBuf) || (this.hasImgBuf && !this.imgBuf_.Equals(msg.imgBuf_)))
            {
                return false;
            }
            if ((this.hasCreateTime != msg.hasCreateTime) || (this.hasCreateTime && !this.createTime_.Equals(msg.createTime_)))
            {
                return false;
            }
            if ((this.hasMsgSource != msg.hasMsgSource) || (this.hasMsgSource && !this.msgSource_.Equals(msg.msgSource_)))
            {
                return false;
            }
            if ((this.hasPushContent != msg.hasPushContent) || (this.hasPushContent && !this.pushContent_.Equals(msg.pushContent_)))
            {
                return false;
            }
            return ((this.hasNewMsgId == msg.hasNewMsgId) && (!this.hasNewMsgId || this.newMsgId_.Equals(msg.newMsgId_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
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
            if (this.hasMsgType)
            {
                hashCode ^= this.msgType_.GetHashCode();
            }
            if (this.hasContent)
            {
                hashCode ^= this.content_.GetHashCode();
            }
            if (this.hasStatus)
            {
                hashCode ^= this.status_.GetHashCode();
            }
            if (this.hasImgStatus)
            {
                hashCode ^= this.imgStatus_.GetHashCode();
            }
            if (this.hasImgBuf)
            {
                hashCode ^= this.imgBuf_.GetHashCode();
            }
            if (this.hasCreateTime)
            {
                hashCode ^= this.createTime_.GetHashCode();
            }
            if (this.hasMsgSource)
            {
                hashCode ^= this.msgSource_.GetHashCode();
            }
            if (this.hasPushContent)
            {
                hashCode ^= this.pushContent_.GetHashCode();
            }
            if (this.hasNewMsgId)
            {
                hashCode ^= this.newMsgId_.GetHashCode();
            }
            return hashCode;
        }

        private AddMsg MakeReadOnly()
        {
            return this;
        }

        public static AddMsg ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<AddMsg, Builder>.PrintField("MsgId", this.hasMsgId, this.msgId_, writer);
            GeneratedMessageLite<AddMsg, Builder>.PrintField("FromUserName", this.hasFromUserName, this.fromUserName_, writer);
            GeneratedMessageLite<AddMsg, Builder>.PrintField("ToUserName", this.hasToUserName, this.toUserName_, writer);
            GeneratedMessageLite<AddMsg, Builder>.PrintField("MsgType", this.hasMsgType, this.msgType_, writer);
            GeneratedMessageLite<AddMsg, Builder>.PrintField("Content", this.hasContent, this.content_, writer);
            GeneratedMessageLite<AddMsg, Builder>.PrintField("Status", this.hasStatus, this.status_, writer);
            GeneratedMessageLite<AddMsg, Builder>.PrintField("ImgStatus", this.hasImgStatus, this.imgStatus_, writer);
            GeneratedMessageLite<AddMsg, Builder>.PrintField("ImgBuf", this.hasImgBuf, this.imgBuf_, writer);
            GeneratedMessageLite<AddMsg, Builder>.PrintField("CreateTime", this.hasCreateTime, this.createTime_, writer);
            GeneratedMessageLite<AddMsg, Builder>.PrintField("MsgSource", this.hasMsgSource, this.msgSource_, writer);
            GeneratedMessageLite<AddMsg, Builder>.PrintField("PushContent", this.hasPushContent, this.pushContent_, writer);
            GeneratedMessageLite<AddMsg, Builder>.PrintField("NewMsgId", this.hasNewMsgId, this.newMsgId_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _addMsgFieldNames;
            if (this.hasMsgId)
            {
                output.WriteInt32(1, strArray[5], this.MsgId);
            }
            if (this.hasFromUserName)
            {
                output.WriteMessage(2, strArray[2], this.FromUserName);
            }
            if (this.hasToUserName)
            {
                output.WriteMessage(3, strArray[11], this.ToUserName);
            }
            if (this.hasMsgType)
            {
                output.WriteInt32(4, strArray[7], this.MsgType);
            }
            if (this.hasContent)
            {
                output.WriteMessage(5, strArray[0], this.Content);
            }
            if (this.hasStatus)
            {
                output.WriteUInt32(6, strArray[10], this.Status);
            }
            if (this.hasImgStatus)
            {
                output.WriteUInt32(7, strArray[4], this.ImgStatus);
            }
            if (this.hasImgBuf)
            {
                output.WriteMessage(8, strArray[3], this.ImgBuf);
            }
            if (this.hasCreateTime)
            {
                output.WriteUInt32(9, strArray[1], this.CreateTime);
            }
            if (this.hasMsgSource)
            {
                output.WriteString(10, strArray[6], this.MsgSource);
            }
            if (this.hasPushContent)
            {
                output.WriteString(11, strArray[9], this.PushContent);
            }
            if (this.hasNewMsgId)
            {
                output.WriteInt64(12, strArray[8], this.NewMsgId);
            }
        }

        public SKBuiltinString_t Content
        {
            get
            {
                return (this.content_ ?? SKBuiltinString_t.DefaultInstance);
            }
        }

        public uint CreateTime
        {
            get
            {
                return this.createTime_;
            }
        }

        public static AddMsg DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override AddMsg DefaultInstanceForType
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

        public SKBuiltinBuffer_t ImgBuf
        {
            get
            {
                return (this.imgBuf_ ?? SKBuiltinBuffer_t.DefaultInstance);
            }
        }

        public uint ImgStatus
        {
            get
            {
                return this.imgStatus_;
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
                if (!this.hasFromUserName)
                {
                    return false;
                }
                if (!this.hasToUserName)
                {
                    return false;
                }
                if (!this.hasMsgType)
                {
                    return false;
                }
                if (!this.hasContent)
                {
                    return false;
                }
                if (!this.hasStatus)
                {
                    return false;
                }
                if (!this.hasImgStatus)
                {
                    return false;
                }
                if (!this.hasImgBuf)
                {
                    return false;
                }
                if (!this.hasCreateTime)
                {
                    return false;
                }
                if (!this.ImgBuf.IsInitialized)
                {
                    return false;
                }
                return true;
            }
        }

        public int MsgId
        {
            get
            {
                return this.msgId_;
            }
        }

        public string MsgSource
        {
            get
            {
                return this.msgSource_;
            }
        }

        public int MsgType
        {
            get
            {
                return this.msgType_;
            }
        }

        public long NewMsgId
        {
            get
            {
                return this.newMsgId_;
            }
        }

        public string PushContent
        {
            get
            {
                return this.pushContent_;
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
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(1, this.MsgId);
                    }
                    if (this.hasFromUserName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(2, this.FromUserName);
                    }
                    if (this.hasToUserName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(3, this.ToUserName);
                    }
                    if (this.hasMsgType)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(4, this.MsgType);
                    }
                    if (this.hasContent)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(5, this.Content);
                    }
                    if (this.hasStatus)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(6, this.Status);
                    }
                    if (this.hasImgStatus)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(7, this.ImgStatus);
                    }
                    if (this.hasImgBuf)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(8, this.ImgBuf);
                    }
                    if (this.hasCreateTime)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(9, this.CreateTime);
                    }
                    if (this.hasMsgSource)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(10, this.MsgSource);
                    }
                    if (this.hasPushContent)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(11, this.PushContent);
                    }
                    if (this.hasNewMsgId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt64Size(12, this.NewMsgId);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        public uint Status
        {
            get
            {
                return this.status_;
            }
        }

        protected override AddMsg ThisMessage
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

        [DebuggerNonUserCode, GeneratedCode("ProtoGen", "2.3.0.277"), CompilerGenerated]
        public sealed class Builder : GeneratedBuilderLite<AddMsg, AddMsg.Builder>
        {
            private AddMsg result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = AddMsg.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(AddMsg cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override AddMsg BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override AddMsg.Builder Clear()
            {
                this.result = AddMsg.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public AddMsg.Builder ClearContent()
            {
                this.PrepareBuilder();
                this.result.hasContent = false;
                this.result.content_ = null;
                return this;
            }

            public AddMsg.Builder ClearCreateTime()
            {
                this.PrepareBuilder();
                this.result.hasCreateTime = false;
                this.result.createTime_ = 0;
                return this;
            }

            public AddMsg.Builder ClearFromUserName()
            {
                this.PrepareBuilder();
                this.result.hasFromUserName = false;
                this.result.fromUserName_ = null;
                return this;
            }

            public AddMsg.Builder ClearImgBuf()
            {
                this.PrepareBuilder();
                this.result.hasImgBuf = false;
                this.result.imgBuf_ = null;
                return this;
            }

            public AddMsg.Builder ClearImgStatus()
            {
                this.PrepareBuilder();
                this.result.hasImgStatus = false;
                this.result.imgStatus_ = 0;
                return this;
            }

            public AddMsg.Builder ClearMsgId()
            {
                this.PrepareBuilder();
                this.result.hasMsgId = false;
                this.result.msgId_ = 0;
                return this;
            }

            public AddMsg.Builder ClearMsgSource()
            {
                this.PrepareBuilder();
                this.result.hasMsgSource = false;
                this.result.msgSource_ = "";
                return this;
            }

            public AddMsg.Builder ClearMsgType()
            {
                this.PrepareBuilder();
                this.result.hasMsgType = false;
                this.result.msgType_ = 0;
                return this;
            }

            public AddMsg.Builder ClearNewMsgId()
            {
                this.PrepareBuilder();
                this.result.hasNewMsgId = false;
                this.result.newMsgId_ = 0L;
                return this;
            }

            public AddMsg.Builder ClearPushContent()
            {
                this.PrepareBuilder();
                this.result.hasPushContent = false;
                this.result.pushContent_ = "";
                return this;
            }

            public AddMsg.Builder ClearStatus()
            {
                this.PrepareBuilder();
                this.result.hasStatus = false;
                this.result.status_ = 0;
                return this;
            }

            public AddMsg.Builder ClearToUserName()
            {
                this.PrepareBuilder();
                this.result.hasToUserName = false;
                this.result.toUserName_ = null;
                return this;
            }

            public override AddMsg.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new AddMsg.Builder(this.result);
                }
                return new AddMsg.Builder().MergeFrom(this.result);
            }

            public AddMsg.Builder MergeContent(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasContent && (this.result.content_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.content_ = SKBuiltinString_t.CreateBuilder(this.result.content_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.content_ = value;
                }
                this.result.hasContent = true;
                return this;
            }

            public override AddMsg.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override AddMsg.Builder MergeFrom(IMessageLite other)
            {
                if (other is AddMsg)
                {
                    return this.MergeFrom((AddMsg)other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override AddMsg.Builder MergeFrom(AddMsg other)
            {
                return this;
            }

            public override AddMsg.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(AddMsg._addMsgFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = AddMsg._addMsgFieldTags[index];
                        }
                        else
                        {
                            this.ParseUnknownField(input, extensionRegistry, num, str);
                            continue;
                        }
                    }
                    switch (num)
                    {
                        case 0x1a:
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
                        case 0x20:
                            {
                                this.result.hasMsgType = input.ReadInt32(ref this.result.msgType_);
                                continue;
                            }
                        case 0x2a:
                            {
                                SKBuiltinString_t.Builder builder3 = SKBuiltinString_t.CreateBuilder();
                                if (this.result.hasContent)
                                {
                                    builder3.MergeFrom(this.Content);
                                }
                                input.ReadMessage(builder3, extensionRegistry);
                                this.Content = builder3.BuildPartial();
                                continue;
                            }
                        case 0:
                            throw InvalidProtocolBufferException.InvalidTag();

                        case 8:
                            {
                                this.result.hasMsgId = input.ReadInt32(ref this.result.msgId_);
                                continue;
                            }
                        case 0x12:
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
                        case 0x30:
                            {
                                this.result.hasStatus = input.ReadUInt32(ref this.result.status_);
                                continue;
                            }
                        case 0x38:
                            {
                                this.result.hasImgStatus = input.ReadUInt32(ref this.result.imgStatus_);
                                continue;
                            }
                        case 0x42:
                            {
                                SKBuiltinBuffer_t.Builder builder4 = SKBuiltinBuffer_t.CreateBuilder();
                                if (this.result.hasImgBuf)
                                {
                                    builder4.MergeFrom(this.ImgBuf);
                                }
                                input.ReadMessage(builder4, extensionRegistry);
                                this.ImgBuf = builder4.BuildPartial();
                                continue;
                            }
                        case 0x48:
                            {
                                this.result.hasCreateTime = input.ReadUInt32(ref this.result.createTime_);
                                continue;
                            }
                        case 0x52:
                            {
                                this.result.hasMsgSource = input.ReadString(ref this.result.msgSource_);
                                continue;
                            }
                        case 90:
                            {
                                this.result.hasPushContent = input.ReadString(ref this.result.pushContent_);
                                continue;
                            }
                        case 0x60:
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
                    this.result.hasNewMsgId = input.ReadInt64(ref this.result.newMsgId_);
                }
                return this;
            }

            public AddMsg.Builder MergeFromUserName(SKBuiltinString_t value)
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

            public AddMsg.Builder MergeImgBuf(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasImgBuf && (this.result.imgBuf_ != SKBuiltinBuffer_t.DefaultInstance))
                {
                    this.result.imgBuf_ = SKBuiltinBuffer_t.CreateBuilder(this.result.imgBuf_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.imgBuf_ = value;
                }
                this.result.hasImgBuf = true;
                return this;
            }

            public AddMsg.Builder MergeToUserName(SKBuiltinString_t value)
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

            private AddMsg PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    AddMsg result = this.result;
                    this.result = new AddMsg();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public AddMsg.Builder SetContent(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasContent = true;
                this.result.content_ = value;
                return this;
            }

            public AddMsg.Builder SetContent(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasContent = true;
                this.result.content_ = builderForValue.Build();
                return this;
            }

            public AddMsg.Builder SetCreateTime(uint value)
            {
                this.PrepareBuilder();
                this.result.hasCreateTime = true;
                this.result.createTime_ = value;
                return this;
            }

            public AddMsg.Builder SetFromUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasFromUserName = true;
                this.result.fromUserName_ = value;
                return this;
            }

            public AddMsg.Builder SetFromUserName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasFromUserName = true;
                this.result.fromUserName_ = builderForValue.Build();
                return this;
            }

            public AddMsg.Builder SetImgBuf(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasImgBuf = true;
                this.result.imgBuf_ = value;
                return this;
            }

            public AddMsg.Builder SetImgBuf(SKBuiltinBuffer_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasImgBuf = true;
                this.result.imgBuf_ = builderForValue.Build();
                return this;
            }

            public AddMsg.Builder SetImgStatus(uint value)
            {
                this.PrepareBuilder();
                this.result.hasImgStatus = true;
                this.result.imgStatus_ = value;
                return this;
            }

            public AddMsg.Builder SetMsgId(int value)
            {
                this.PrepareBuilder();
                this.result.hasMsgId = true;
                this.result.msgId_ = value;
                return this;
            }

            public AddMsg.Builder SetMsgSource(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasMsgSource = true;
                this.result.msgSource_ = value;
                return this;
            }

            public AddMsg.Builder SetMsgType(int value)
            {
                this.PrepareBuilder();
                this.result.hasMsgType = true;
                this.result.msgType_ = value;
                return this;
            }

            public AddMsg.Builder SetNewMsgId(long value)
            {
                this.PrepareBuilder();
                this.result.hasNewMsgId = true;
                this.result.newMsgId_ = value;
                return this;
            }

            public AddMsg.Builder SetPushContent(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasPushContent = true;
                this.result.pushContent_ = value;
                return this;
            }

            public AddMsg.Builder SetStatus(uint value)
            {
                this.PrepareBuilder();
                this.result.hasStatus = true;
                this.result.status_ = value;
                return this;
            }

            public AddMsg.Builder SetToUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasToUserName = true;
                this.result.toUserName_ = value;
                return this;
            }

            public AddMsg.Builder SetToUserName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasToUserName = true;
                this.result.toUserName_ = builderForValue.Build();
                return this;
            }

            public SKBuiltinString_t Content
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

            public override AddMsg DefaultInstanceForType
            {
                get
                {
                    return AddMsg.DefaultInstance;
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

            public SKBuiltinBuffer_t ImgBuf
            {
                get
                {
                    return this.result.ImgBuf;
                }
                set
                {
                    this.SetImgBuf(value);
                }
            }

            public uint ImgStatus
            {
                get
                {
                    return this.result.ImgStatus;
                }
                set
                {
                    this.SetImgStatus(value);
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override AddMsg MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public int MsgId
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

            public int MsgType
            {
                get
                {
                    return this.result.MsgType;
                }
                set
                {
                    this.SetMsgType(value);
                }
            }

            public long NewMsgId
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

            public string PushContent
            {
                get
                {
                    return this.result.PushContent;
                }
                set
                {
                    this.SetPushContent(value);
                }
            }

            public uint Status
            {
                get
                {
                    return this.result.Status;
                }
                set
                {
                    this.SetStatus(value);
                }
            }

            protected override AddMsg.Builder ThisBuilder
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
        }
    }
}

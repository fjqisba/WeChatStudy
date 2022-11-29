namespace micromsg
{
    using Google.ProtocolBuffers;
    
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

   // 
    public sealed class AppMsg : GeneratedMessageLite<AppMsg, AppMsg.Builder>
    {
        private static readonly string[] _appMsgFieldNames = new string[] { "AppId", "ClientMsgId", "Content", "CreateTime", "FromUserName", "RemindId", "SdkVersion", "Source", "Thumb", "ToUserName", "Type" };
        private static readonly uint[] _appMsgFieldTags = new uint[] { 0x12, 0x42, 50, 0x38, 10, 0x58, 0x18, 80, 0x4a, 0x22, 40 };
        private string appId_ = "";
        public const int AppIdFieldNumber = 2;
        private string clientMsgId_ = "";
        public const int ClientMsgIdFieldNumber = 8;
        private string content_ = "";
        public const int ContentFieldNumber = 6;
        private uint createTime_;
        public const int CreateTimeFieldNumber = 7;
        private static readonly AppMsg defaultInstance = new AppMsg().MakeReadOnly();
        private string fromUserName_ = "";
        public const int FromUserNameFieldNumber = 1;
        private bool hasAppId;
        private bool hasClientMsgId;
        private bool hasContent;
        private bool hasCreateTime;
        private bool hasFromUserName;
        private bool hasRemindId;
        private bool hasSdkVersion;
        private bool hasSource;
        private bool hasThumb;
        private bool hasToUserName;
        private bool hasType;
        private int memoizedSerializedSize = -1;
        private int remindId_;
        public const int RemindIdFieldNumber = 11;
        private uint sdkVersion_;
        public const int SdkVersionFieldNumber = 3;
        private int source_;
        public const int SourceFieldNumber = 10;
        private SKBuiltinBuffer_t thumb_;
        public const int ThumbFieldNumber = 9;
        private string toUserName_ = "";
        public const int ToUserNameFieldNumber = 4;
        private uint type_;
        public const int TypeFieldNumber = 5;

        static AppMsg()
        {
            //object.ReferenceEquals(AppMsg.Descriptor, null);
        }

        private AppMsg()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(AppMsg prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            AppMsg msg = obj as AppMsg;
            if (msg == null)
            {
                return false;
            }
            if ((this.hasFromUserName != msg.hasFromUserName) || (this.hasFromUserName && !this.fromUserName_.Equals(msg.fromUserName_)))
            {
                return false;
            }
            if ((this.hasAppId != msg.hasAppId) || (this.hasAppId && !this.appId_.Equals(msg.appId_)))
            {
                return false;
            }
            if ((this.hasSdkVersion != msg.hasSdkVersion) || (this.hasSdkVersion && !this.sdkVersion_.Equals(msg.sdkVersion_)))
            {
                return false;
            }
            if ((this.hasToUserName != msg.hasToUserName) || (this.hasToUserName && !this.toUserName_.Equals(msg.toUserName_)))
            {
                return false;
            }
            if ((this.hasType != msg.hasType) || (this.hasType && !this.type_.Equals(msg.type_)))
            {
                return false;
            }
            if ((this.hasContent != msg.hasContent) || (this.hasContent && !this.content_.Equals(msg.content_)))
            {
                return false;
            }
            if ((this.hasCreateTime != msg.hasCreateTime) || (this.hasCreateTime && !this.createTime_.Equals(msg.createTime_)))
            {
                return false;
            }
            if ((this.hasClientMsgId != msg.hasClientMsgId) || (this.hasClientMsgId && !this.clientMsgId_.Equals(msg.clientMsgId_)))
            {
                return false;
            }
            if ((this.hasThumb != msg.hasThumb) || (this.hasThumb && !this.thumb_.Equals(msg.thumb_)))
            {
                return false;
            }
            if ((this.hasSource != msg.hasSource) || (this.hasSource && !this.source_.Equals(msg.source_)))
            {
                return false;
            }
            return ((this.hasRemindId == msg.hasRemindId) && (!this.hasRemindId || this.remindId_.Equals(msg.remindId_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasFromUserName)
            {
                hashCode ^= this.fromUserName_.GetHashCode();
            }
            if (this.hasAppId)
            {
                hashCode ^= this.appId_.GetHashCode();
            }
            if (this.hasSdkVersion)
            {
                hashCode ^= this.sdkVersion_.GetHashCode();
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
            if (this.hasThumb)
            {
                hashCode ^= this.thumb_.GetHashCode();
            }
            if (this.hasSource)
            {
                hashCode ^= this.source_.GetHashCode();
            }
            if (this.hasRemindId)
            {
                hashCode ^= this.remindId_.GetHashCode();
            }
            return hashCode;
        }

        private AppMsg MakeReadOnly()
        {
            return this;
        }

        public static AppMsg ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<AppMsg, Builder>.PrintField("FromUserName", this.hasFromUserName, this.fromUserName_, writer);
            GeneratedMessageLite<AppMsg, Builder>.PrintField("AppId", this.hasAppId, this.appId_, writer);
            GeneratedMessageLite<AppMsg, Builder>.PrintField("SdkVersion", this.hasSdkVersion, this.sdkVersion_, writer);
            GeneratedMessageLite<AppMsg, Builder>.PrintField("ToUserName", this.hasToUserName, this.toUserName_, writer);
            GeneratedMessageLite<AppMsg, Builder>.PrintField("Type", this.hasType, this.type_, writer);
            GeneratedMessageLite<AppMsg, Builder>.PrintField("Content", this.hasContent, this.content_, writer);
            GeneratedMessageLite<AppMsg, Builder>.PrintField("CreateTime", this.hasCreateTime, this.createTime_, writer);
            GeneratedMessageLite<AppMsg, Builder>.PrintField("ClientMsgId", this.hasClientMsgId, this.clientMsgId_, writer);
            GeneratedMessageLite<AppMsg, Builder>.PrintField("Thumb", this.hasThumb, this.thumb_, writer);
            GeneratedMessageLite<AppMsg, Builder>.PrintField("Source", this.hasSource, this.source_, writer);
            GeneratedMessageLite<AppMsg, Builder>.PrintField("RemindId", this.hasRemindId, this.remindId_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _appMsgFieldNames;
            if (this.hasFromUserName)
            {
                output.WriteString(1, strArray[4], this.FromUserName);
            }
            if (this.hasAppId)
            {
                output.WriteString(2, strArray[0], this.AppId);
            }
            if (this.hasSdkVersion)
            {
                output.WriteUInt32(3, strArray[6], this.SdkVersion);
            }
            if (this.hasToUserName)
            {
                output.WriteString(4, strArray[9], this.ToUserName);
            }
            if (this.hasType)
            {
                output.WriteUInt32(5, strArray[10], this.Type);
            }
            if (this.hasContent)
            {
                output.WriteString(6, strArray[2], this.Content);
            }
            if (this.hasCreateTime)
            {
                output.WriteUInt32(7, strArray[3], this.CreateTime);
            }
            if (this.hasClientMsgId)
            {
                output.WriteString(8, strArray[1], this.ClientMsgId);
            }
            if (this.hasThumb)
            {
                output.WriteMessage(9, strArray[8], this.Thumb);
            }
            if (this.hasSource)
            {
                output.WriteInt32(10, strArray[7], this.Source);
            }
            if (this.hasRemindId)
            {
                output.WriteInt32(11, strArray[5], this.RemindId);
            }
        }

        public string AppId
        {
            get
            {
                return this.appId_;
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

        public static AppMsg DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override AppMsg DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public string FromUserName
        {
            get
            {
                return this.fromUserName_;
            }
        }

        public override bool IsInitialized
        {
            get
            {
                if (!this.hasSdkVersion)
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

        public int RemindId
        {
            get
            {
                return this.remindId_;
            }
        }

        public uint SdkVersion
        {
            get
            {
                return this.sdkVersion_;
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
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(1, this.FromUserName);
                    }
                    if (this.hasAppId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(2, this.AppId);
                    }
                    if (this.hasSdkVersion)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(3, this.SdkVersion);
                    }
                    if (this.hasToUserName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(4, this.ToUserName);
                    }
                    if (this.hasType)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(5, this.Type);
                    }
                    if (this.hasContent)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(6, this.Content);
                    }
                    if (this.hasCreateTime)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(7, this.CreateTime);
                    }
                    if (this.hasClientMsgId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(8, this.ClientMsgId);
                    }
                    if (this.hasThumb)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(9, this.Thumb);
                    }
                    if (this.hasSource)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(10, this.Source);
                    }
                    if (this.hasRemindId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(11, this.RemindId);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        public int Source
        {
            get
            {
                return this.source_;
            }
        }

        protected override AppMsg ThisMessage
        {
            get
            {
                return this;
            }
        }

        public SKBuiltinBuffer_t Thumb
        {
            get
            {
                return (this.thumb_ ?? SKBuiltinBuffer_t.DefaultInstance);
            }
        }

        public string ToUserName
        {
            get
            {
                return this.toUserName_;
            }
        }

        public uint Type
        {
            get
            {
                return this.type_;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<AppMsg, AppMsg.Builder>
        {
            private AppMsg result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = AppMsg.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(AppMsg cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override AppMsg BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override AppMsg.Builder Clear()
            {
                this.result = AppMsg.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public AppMsg.Builder ClearAppId()
            {
                this.PrepareBuilder();
                this.result.hasAppId = false;
                this.result.appId_ = "";
                return this;
            }

            public AppMsg.Builder ClearClientMsgId()
            {
                this.PrepareBuilder();
                this.result.hasClientMsgId = false;
                this.result.clientMsgId_ = "";
                return this;
            }

            public AppMsg.Builder ClearContent()
            {
                this.PrepareBuilder();
                this.result.hasContent = false;
                this.result.content_ = "";
                return this;
            }

            public AppMsg.Builder ClearCreateTime()
            {
                this.PrepareBuilder();
                this.result.hasCreateTime = false;
                this.result.createTime_ = 0;
                return this;
            }

            public AppMsg.Builder ClearFromUserName()
            {
                this.PrepareBuilder();
                this.result.hasFromUserName = false;
                this.result.fromUserName_ = "";
                return this;
            }

            public AppMsg.Builder ClearRemindId()
            {
                this.PrepareBuilder();
                this.result.hasRemindId = false;
                this.result.remindId_ = 0;
                return this;
            }

            public AppMsg.Builder ClearSdkVersion()
            {
                this.PrepareBuilder();
                this.result.hasSdkVersion = false;
                this.result.sdkVersion_ = 0;
                return this;
            }

            public AppMsg.Builder ClearSource()
            {
                this.PrepareBuilder();
                this.result.hasSource = false;
                this.result.source_ = 0;
                return this;
            }

            public AppMsg.Builder ClearThumb()
            {
                this.PrepareBuilder();
                this.result.hasThumb = false;
                this.result.thumb_ = null;
                return this;
            }

            public AppMsg.Builder ClearToUserName()
            {
                this.PrepareBuilder();
                this.result.hasToUserName = false;
                this.result.toUserName_ = "";
                return this;
            }

            public AppMsg.Builder ClearType()
            {
                this.PrepareBuilder();
                this.result.hasType = false;
                this.result.type_ = 0;
                return this;
            }

            public override AppMsg.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new AppMsg.Builder(this.result);
                }
                return new AppMsg.Builder().MergeFrom(this.result);
            }

            public override AppMsg.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override AppMsg.Builder MergeFrom(IMessageLite other)
            {
                if (other is AppMsg)
                {
                    return this.MergeFrom((AppMsg) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override AppMsg.Builder MergeFrom(AppMsg other)
            {
                return this;
            }

            public override AppMsg.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(AppMsg._appMsgFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = AppMsg._appMsgFieldTags[index];
                        }
                        else
                        {
                            this.ParseUnknownField(input, extensionRegistry, num, str);
                            continue;
                        }
                    }
                    switch (num)
                    {
                        case 0x18:
                        {
                            this.result.hasSdkVersion = input.ReadUInt32(ref this.result.sdkVersion_);
                            continue;
                        }
                        case 0x22:
                        {
                            this.result.hasToUserName = input.ReadString(ref this.result.toUserName_);
                            continue;
                        }
                        case 40:
                        {
                            this.result.hasType = input.ReadUInt32(ref this.result.type_);
                            continue;
                        }
                        case 0:
                            throw InvalidProtocolBufferException.InvalidTag();

                        case 10:
                        {
                            this.result.hasFromUserName = input.ReadString(ref this.result.fromUserName_);
                            continue;
                        }
                        case 0x12:
                        {
                            this.result.hasAppId = input.ReadString(ref this.result.appId_);
                            continue;
                        }
                        case 50:
                        {
                            this.result.hasContent = input.ReadString(ref this.result.content_);
                            continue;
                        }
                        case 0x38:
                        {
                            this.result.hasCreateTime = input.ReadUInt32(ref this.result.createTime_);
                            continue;
                        }
                        case 0x42:
                        {
                            this.result.hasClientMsgId = input.ReadString(ref this.result.clientMsgId_);
                            continue;
                        }
                        case 0x4a:
                        {
                            SKBuiltinBuffer_t.Builder builder = SKBuiltinBuffer_t.CreateBuilder();
                            if (this.result.hasThumb)
                            {
                                builder.MergeFrom(this.Thumb);
                            }
                            input.ReadMessage(builder, extensionRegistry);
                            this.Thumb = builder.BuildPartial();
                            continue;
                        }
                        case 80:
                        {
                            this.result.hasSource = input.ReadInt32(ref this.result.source_);
                            continue;
                        }
                        case 0x58:
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
                    this.result.hasRemindId = input.ReadInt32(ref this.result.remindId_);
                }
                return this;
            }

            public AppMsg.Builder MergeThumb(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasThumb && (this.result.thumb_ != SKBuiltinBuffer_t.DefaultInstance))
                {
                    this.result.thumb_ = SKBuiltinBuffer_t.CreateBuilder(this.result.thumb_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.thumb_ = value;
                }
                this.result.hasThumb = true;
                return this;
            }

            private AppMsg PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    AppMsg result = this.result;
                    this.result = new AppMsg();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public AppMsg.Builder SetAppId(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasAppId = true;
                this.result.appId_ = value;
                return this;
            }

            public AppMsg.Builder SetClientMsgId(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasClientMsgId = true;
                this.result.clientMsgId_ = value;
                return this;
            }

            public AppMsg.Builder SetContent(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasContent = true;
                this.result.content_ = value;
                return this;
            }

            public AppMsg.Builder SetCreateTime(uint value)
            {
                this.PrepareBuilder();
                this.result.hasCreateTime = true;
                this.result.createTime_ = value;
                return this;
            }

            public AppMsg.Builder SetFromUserName(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasFromUserName = true;
                this.result.fromUserName_ = value;
                return this;
            }

            public AppMsg.Builder SetRemindId(int value)
            {
                this.PrepareBuilder();
                this.result.hasRemindId = true;
                this.result.remindId_ = value;
                return this;
            }

            public AppMsg.Builder SetSdkVersion(uint value)
            {
                this.PrepareBuilder();
                this.result.hasSdkVersion = true;
                this.result.sdkVersion_ = value;
                return this;
            }

            public AppMsg.Builder SetSource(int value)
            {
                this.PrepareBuilder();
                this.result.hasSource = true;
                this.result.source_ = value;
                return this;
            }

            public AppMsg.Builder SetThumb(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasThumb = true;
                this.result.thumb_ = value;
                return this;
            }

            public AppMsg.Builder SetThumb(SKBuiltinBuffer_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasThumb = true;
                this.result.thumb_ = builderForValue.Build();
                return this;
            }

            public AppMsg.Builder SetToUserName(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasToUserName = true;
                this.result.toUserName_ = value;
                return this;
            }

            public AppMsg.Builder SetType(uint value)
            {
                this.PrepareBuilder();
                this.result.hasType = true;
                this.result.type_ = value;
                return this;
            }

            public string AppId
            {
                get
                {
                    return this.result.AppId;
                }
                set
                {
                    this.SetAppId(value);
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

            public override AppMsg DefaultInstanceForType
            {
                get
                {
                    return AppMsg.DefaultInstance;
                }
            }

            public string FromUserName
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

            protected override AppMsg MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public int RemindId
            {
                get
                {
                    return this.result.RemindId;
                }
                set
                {
                    this.SetRemindId(value);
                }
            }

            public uint SdkVersion
            {
                get
                {
                    return this.result.SdkVersion;
                }
                set
                {
                    this.SetSdkVersion(value);
                }
            }

            public int Source
            {
                get
                {
                    return this.result.Source;
                }
                set
                {
                    this.SetSource(value);
                }
            }

            protected override AppMsg.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }

            public SKBuiltinBuffer_t Thumb
            {
                get
                {
                    return this.result.Thumb;
                }
                set
                {
                    this.SetThumb(value);
                }
            }

            public string ToUserName
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


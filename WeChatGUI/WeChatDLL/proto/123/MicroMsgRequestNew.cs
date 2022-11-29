namespace micromsg
{
    using Google.ProtocolBuffers;

    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    using System.Runtime.CompilerServices;

    public sealed class MicroMsgRequestNew : GeneratedMessageLite<MicroMsgRequestNew, MicroMsgRequestNew.Builder>
    {
        private static readonly string[] _microMsgRequestNewFieldNames = new string[] { "ClientMsgId", "Content", "CreateTime", "MsgSource", "ToUserName", "Type" };
        private static readonly uint[] _microMsgRequestNewFieldTags = new uint[] { 40, 0x12, 0x20, 50, 10, 0x18 };
        private uint clientMsgId_;
        public const int ClientMsgIdFieldNumber = 5;
        private string content_ = "";
        public const int ContentFieldNumber = 2;
        private uint createTime_;
        public const int CreateTimeFieldNumber = 4;
        private static readonly MicroMsgRequestNew defaultInstance = new MicroMsgRequestNew().MakeReadOnly();
        private bool hasClientMsgId;
        private bool hasContent;
        private bool hasCreateTime;
        private bool hasMsgSource;
        private bool hasToUserName;
        private bool hasType;
        private int memoizedSerializedSize = -1;
        private string msgSource_ = "";
        public const int MsgSourceFieldNumber = 6;
        private SKBuiltinString_t toUserName_;
        public const int ToUserNameFieldNumber = 1;
        private uint type_;
        public const int TypeFieldNumber = 3;

        static MicroMsgRequestNew()
        {
            
        }

        private MicroMsgRequestNew()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(MicroMsgRequestNew prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            MicroMsgRequestNew new2 = obj as MicroMsgRequestNew;
            if (new2 == null)
            {
                return false;
            }
            if ((this.hasToUserName != new2.hasToUserName) || (this.hasToUserName && !this.toUserName_.Equals(new2.toUserName_)))
            {
                return false;
            }
            if ((this.hasContent != new2.hasContent) || (this.hasContent && !this.content_.Equals(new2.content_)))
            {
                return false;
            }
            if ((this.hasType != new2.hasType) || (this.hasType && !this.type_.Equals(new2.type_)))
            {
                return false;
            }
            if ((this.hasCreateTime != new2.hasCreateTime) || (this.hasCreateTime && !this.createTime_.Equals(new2.createTime_)))
            {
                return false;
            }
            if ((this.hasClientMsgId != new2.hasClientMsgId) || (this.hasClientMsgId && !this.clientMsgId_.Equals(new2.clientMsgId_)))
            {
                return false;
            }
            return ((this.hasMsgSource == new2.hasMsgSource) && (!this.hasMsgSource || this.msgSource_.Equals(new2.msgSource_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasToUserName)
            {
                hashCode ^= this.toUserName_.GetHashCode();
            }
            if (this.hasContent)
            {
                hashCode ^= this.content_.GetHashCode();
            }
            if (this.hasType)
            {
                hashCode ^= this.type_.GetHashCode();
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
            return hashCode;
        }

        private MicroMsgRequestNew MakeReadOnly()
        {
            return this;
        }

        public static MicroMsgRequestNew ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<MicroMsgRequestNew, Builder>.PrintField("ToUserName", this.hasToUserName, this.toUserName_, writer);
            GeneratedMessageLite<MicroMsgRequestNew, Builder>.PrintField("Content", this.hasContent, this.content_, writer);
            GeneratedMessageLite<MicroMsgRequestNew, Builder>.PrintField("Type", this.hasType, this.type_, writer);
            GeneratedMessageLite<MicroMsgRequestNew, Builder>.PrintField("CreateTime", this.hasCreateTime, this.createTime_, writer);
            GeneratedMessageLite<MicroMsgRequestNew, Builder>.PrintField("ClientMsgId", this.hasClientMsgId, this.clientMsgId_, writer);
            GeneratedMessageLite<MicroMsgRequestNew, Builder>.PrintField("MsgSource", this.hasMsgSource, this.msgSource_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _microMsgRequestNewFieldNames;
            if (this.hasToUserName)
            {
                output.WriteMessage(1, strArray[4], this.ToUserName);
            }
            if (this.hasContent)
            {
                output.WriteString(2, strArray[1], this.Content);
            }
            if (this.hasType)
            {
                output.WriteUInt32(3, strArray[5], this.Type);
            }
            if (this.hasCreateTime)
            {
                output.WriteUInt32(4, strArray[2], this.CreateTime);
            }
            if (this.hasClientMsgId)
            {
                output.WriteUInt32(5, strArray[0], this.ClientMsgId);
            }
            if (this.hasMsgSource)
            {
                output.WriteString(6, strArray[3], this.MsgSource);
            }
        }

        public uint ClientMsgId
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

        public static MicroMsgRequestNew DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override MicroMsgRequestNew DefaultInstanceForType
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
                if (!this.hasClientMsgId)
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
                    if (this.hasToUserName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(1, this.ToUserName);
                    }
                    if (this.hasContent)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(2, this.Content);
                    }
                    if (this.hasType)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(3, this.Type);
                    }
                    if (this.hasCreateTime)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(4, this.CreateTime);
                    }
                    if (this.hasClientMsgId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(5, this.ClientMsgId);
                    }
                    if (this.hasMsgSource)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(6, this.MsgSource);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override MicroMsgRequestNew ThisMessage
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

        [DebuggerNonUserCode, GeneratedCode("ProtoGen", "2.3.0.277"), CompilerGenerated]
        public sealed class Builder : GeneratedBuilderLite<MicroMsgRequestNew, MicroMsgRequestNew.Builder>
        {
            private MicroMsgRequestNew result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = MicroMsgRequestNew.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(MicroMsgRequestNew cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override MicroMsgRequestNew BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override MicroMsgRequestNew.Builder Clear()
            {
                this.result = MicroMsgRequestNew.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public MicroMsgRequestNew.Builder ClearClientMsgId()
            {
                this.PrepareBuilder();
                this.result.hasClientMsgId = false;
                this.result.clientMsgId_ = 0;
                return this;
            }

            public MicroMsgRequestNew.Builder ClearContent()
            {
                this.PrepareBuilder();
                this.result.hasContent = false;
                this.result.content_ = "";
                return this;
            }

            public MicroMsgRequestNew.Builder ClearCreateTime()
            {
                this.PrepareBuilder();
                this.result.hasCreateTime = false;
                this.result.createTime_ = 0;
                return this;
            }

            public MicroMsgRequestNew.Builder ClearMsgSource()
            {
                this.PrepareBuilder();
                this.result.hasMsgSource = false;
                this.result.msgSource_ = "";
                return this;
            }

            public MicroMsgRequestNew.Builder ClearToUserName()
            {
                this.PrepareBuilder();
                this.result.hasToUserName = false;
                this.result.toUserName_ = null;
                return this;
            }

            public MicroMsgRequestNew.Builder ClearType()
            {
                this.PrepareBuilder();
                this.result.hasType = false;
                this.result.type_ = 0;
                return this;
            }

            public override MicroMsgRequestNew.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new MicroMsgRequestNew.Builder(this.result);
                }
                return new MicroMsgRequestNew.Builder().MergeFrom(this.result);
            }

            public override MicroMsgRequestNew.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override MicroMsgRequestNew.Builder MergeFrom(IMessageLite other)
            {
                if (other is MicroMsgRequestNew)
                {
                    return this.MergeFrom((MicroMsgRequestNew) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override MicroMsgRequestNew.Builder MergeFrom(MicroMsgRequestNew other)
            {
                return this;
            }

            public override MicroMsgRequestNew.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(MicroMsgRequestNew._microMsgRequestNewFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = MicroMsgRequestNew._microMsgRequestNewFieldTags[index];
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
                            SKBuiltinString_t.Builder builder = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasToUserName)
                            {
                                builder.MergeFrom(this.ToUserName);
                            }
                            input.ReadMessage(builder, extensionRegistry);
                            this.ToUserName = builder.BuildPartial();
                            continue;
                        }
                        case 0x12:
                        {
                            this.result.hasContent = input.ReadString(ref this.result.content_);
                            continue;
                        }
                        case 0x18:
                        {
                            this.result.hasType = input.ReadUInt32(ref this.result.type_);
                            continue;
                        }
                        case 0x20:
                        {
                            this.result.hasCreateTime = input.ReadUInt32(ref this.result.createTime_);
                            continue;
                        }
                        case 40:
                        {
                            this.result.hasClientMsgId = input.ReadUInt32(ref this.result.clientMsgId_);
                            continue;
                        }
                        case 50:
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
                    this.result.hasMsgSource = input.ReadString(ref this.result.msgSource_);
                }
                return this;
            }

            public MicroMsgRequestNew.Builder MergeToUserName(SKBuiltinString_t value)
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

            private MicroMsgRequestNew PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    MicroMsgRequestNew result = this.result;
                    this.result = new MicroMsgRequestNew();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public MicroMsgRequestNew.Builder SetClientMsgId(uint value)
            {
                this.PrepareBuilder();
                this.result.hasClientMsgId = true;
                this.result.clientMsgId_ = value;
                return this;
            }

            public MicroMsgRequestNew.Builder SetContent(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasContent = true;
                this.result.content_ = value;
                return this;
            }

            public MicroMsgRequestNew.Builder SetCreateTime(uint value)
            {
                this.PrepareBuilder();
                this.result.hasCreateTime = true;
                this.result.createTime_ = value;
                return this;
            }

            public MicroMsgRequestNew.Builder SetMsgSource(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasMsgSource = true;
                this.result.msgSource_ = value;
                return this;
            }

            public MicroMsgRequestNew.Builder SetToUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasToUserName = true;
                this.result.toUserName_ = value;
                return this;
            }

            public MicroMsgRequestNew.Builder SetToUserName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasToUserName = true;
                this.result.toUserName_ = builderForValue.Build();
                return this;
            }

            public MicroMsgRequestNew.Builder SetType(uint value)
            {
                this.PrepareBuilder();
                this.result.hasType = true;
                this.result.type_ = value;
                return this;
            }

            public uint ClientMsgId
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

            public override MicroMsgRequestNew DefaultInstanceForType
            {
                get
                {
                    return MicroMsgRequestNew.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override MicroMsgRequestNew MessageBeingBuilt
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

            protected override MicroMsgRequestNew.Builder ThisBuilder
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

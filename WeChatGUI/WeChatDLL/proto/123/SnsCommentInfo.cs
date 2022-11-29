namespace micromsg
{
    using Google.ProtocolBuffers;
    
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

    
    public sealed class SnsCommentInfo : GeneratedMessageLite<SnsCommentInfo, SnsCommentInfo.Builder>
    {
        private static readonly string[] _snsCommentInfoFieldNames = new string[] { "CommentId", "Content", "CreateTime", "Nickname", "ReplyCommentId", "ReplyUsername", "Source", "Type", "Username" };
        private static readonly uint[] _snsCommentInfoFieldTags = new uint[] { 0x38, 0x2a, 0x30, 0x12, 0x40, 0x4a, 0x18, 0x20, 10 };
        private int commentId_;
        public const int CommentIdFieldNumber = 7;
        private string content_ = "";
        public const int ContentFieldNumber = 5;
        private uint createTime_;
        public const int CreateTimeFieldNumber = 6;
        private static readonly SnsCommentInfo defaultInstance = new SnsCommentInfo().MakeReadOnly();
        private bool hasCommentId;
        private bool hasContent;
        private bool hasCreateTime;
        private bool hasNickname;
        private bool hasReplyCommentId;
        private bool hasReplyUsername;
        private bool hasSource;
        private bool hasType;
        private bool hasUsername;
        private int memoizedSerializedSize = -1;
        private string nickname_ = "";
        public const int NicknameFieldNumber = 2;
        private int replyCommentId_;
        public const int ReplyCommentIdFieldNumber = 8;
        private string replyUsername_ = "";
        public const int ReplyUsernameFieldNumber = 9;
        private uint source_;
        public const int SourceFieldNumber = 3;
        private uint type_;
        public const int TypeFieldNumber = 4;
        private string username_ = "";
        public const int UsernameFieldNumber = 1;

        static SnsCommentInfo()
        {
           // object.ReferenceEquals(SnsCommentInfo.Descriptor, null);
        }

        private SnsCommentInfo()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(SnsCommentInfo prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            SnsCommentInfo info = obj as SnsCommentInfo;
            if (info == null)
            {
                return false;
            }
            if ((this.hasUsername != info.hasUsername) || (this.hasUsername && !this.username_.Equals(info.username_)))
            {
                return false;
            }
            if ((this.hasNickname != info.hasNickname) || (this.hasNickname && !this.nickname_.Equals(info.nickname_)))
            {
                return false;
            }
            if ((this.hasSource != info.hasSource) || (this.hasSource && !this.source_.Equals(info.source_)))
            {
                return false;
            }
            if ((this.hasType != info.hasType) || (this.hasType && !this.type_.Equals(info.type_)))
            {
                return false;
            }
            if ((this.hasContent != info.hasContent) || (this.hasContent && !this.content_.Equals(info.content_)))
            {
                return false;
            }
            if ((this.hasCreateTime != info.hasCreateTime) || (this.hasCreateTime && !this.createTime_.Equals(info.createTime_)))
            {
                return false;
            }
            if ((this.hasCommentId != info.hasCommentId) || (this.hasCommentId && !this.commentId_.Equals(info.commentId_)))
            {
                return false;
            }
            if ((this.hasReplyCommentId != info.hasReplyCommentId) || (this.hasReplyCommentId && !this.replyCommentId_.Equals(info.replyCommentId_)))
            {
                return false;
            }
            return ((this.hasReplyUsername == info.hasReplyUsername) && (!this.hasReplyUsername || this.replyUsername_.Equals(info.replyUsername_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasUsername)
            {
                hashCode ^= this.username_.GetHashCode();
            }
            if (this.hasNickname)
            {
                hashCode ^= this.nickname_.GetHashCode();
            }
            if (this.hasSource)
            {
                hashCode ^= this.source_.GetHashCode();
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
            if (this.hasCommentId)
            {
                hashCode ^= this.commentId_.GetHashCode();
            }
            if (this.hasReplyCommentId)
            {
                hashCode ^= this.replyCommentId_.GetHashCode();
            }
            if (this.hasReplyUsername)
            {
                hashCode ^= this.replyUsername_.GetHashCode();
            }
            return hashCode;
        }

        private SnsCommentInfo MakeReadOnly()
        {
            return this;
        }

        public static SnsCommentInfo ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<SnsCommentInfo, Builder>.PrintField("Username", this.hasUsername, this.username_, writer);
            GeneratedMessageLite<SnsCommentInfo, Builder>.PrintField("Nickname", this.hasNickname, this.nickname_, writer);
            GeneratedMessageLite<SnsCommentInfo, Builder>.PrintField("Source", this.hasSource, this.source_, writer);
            GeneratedMessageLite<SnsCommentInfo, Builder>.PrintField("Type", this.hasType, this.type_, writer);
            GeneratedMessageLite<SnsCommentInfo, Builder>.PrintField("Content", this.hasContent, this.content_, writer);
            GeneratedMessageLite<SnsCommentInfo, Builder>.PrintField("CreateTime", this.hasCreateTime, this.createTime_, writer);
            GeneratedMessageLite<SnsCommentInfo, Builder>.PrintField("CommentId", this.hasCommentId, this.commentId_, writer);
            GeneratedMessageLite<SnsCommentInfo, Builder>.PrintField("ReplyCommentId", this.hasReplyCommentId, this.replyCommentId_, writer);
            GeneratedMessageLite<SnsCommentInfo, Builder>.PrintField("ReplyUsername", this.hasReplyUsername, this.replyUsername_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _snsCommentInfoFieldNames;
            if (this.hasUsername)
            {
                output.WriteString(1, strArray[8], this.Username);
            }
            if (this.hasNickname)
            {
                output.WriteString(2, strArray[3], this.Nickname);
            }
            if (this.hasSource)
            {
                output.WriteUInt32(3, strArray[6], this.Source);
            }
            if (this.hasType)
            {
                output.WriteUInt32(4, strArray[7], this.Type);
            }
            if (this.hasContent)
            {
                output.WriteString(5, strArray[1], this.Content);
            }
            if (this.hasCreateTime)
            {
                output.WriteUInt32(6, strArray[2], this.CreateTime);
            }
            if (this.hasCommentId)
            {
                output.WriteInt32(7, strArray[0], this.CommentId);
            }
            if (this.hasReplyCommentId)
            {
                output.WriteInt32(8, strArray[4], this.ReplyCommentId);
            }
            if (this.hasReplyUsername)
            {
                output.WriteString(9, strArray[5], this.ReplyUsername);
            }
        }

        public int CommentId
        {
            get
            {
                return this.commentId_;
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

        public static SnsCommentInfo DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override SnsCommentInfo DefaultInstanceForType
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
                if (!this.hasSource)
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

        public string Nickname
        {
            get
            {
                return this.nickname_;
            }
        }

        public int ReplyCommentId
        {
            get
            {
                return this.replyCommentId_;
            }
        }

        public string ReplyUsername
        {
            get
            {
                return this.replyUsername_;
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
                    if (this.hasUsername)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(1, this.Username);
                    }
                    if (this.hasNickname)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(2, this.Nickname);
                    }
                    if (this.hasSource)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(3, this.Source);
                    }
                    if (this.hasType)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(4, this.Type);
                    }
                    if (this.hasContent)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(5, this.Content);
                    }
                    if (this.hasCreateTime)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(6, this.CreateTime);
                    }
                    if (this.hasCommentId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(7, this.CommentId);
                    }
                    if (this.hasReplyCommentId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(8, this.ReplyCommentId);
                    }
                    if (this.hasReplyUsername)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(9, this.ReplyUsername);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        public uint Source
        {
            get
            {
                return this.source_;
            }
        }

        protected override SnsCommentInfo ThisMessage
        {
            get
            {
                return this;
            }
        }

        public uint Type
        {
            get
            {
                return this.type_;
            }
        }

        public string Username
        {
            get
            {
                return this.username_;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<SnsCommentInfo, SnsCommentInfo.Builder>
        {
            private SnsCommentInfo result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = SnsCommentInfo.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(SnsCommentInfo cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override SnsCommentInfo BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override SnsCommentInfo.Builder Clear()
            {
                this.result = SnsCommentInfo.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public SnsCommentInfo.Builder ClearCommentId()
            {
                this.PrepareBuilder();
                this.result.hasCommentId = false;
                this.result.commentId_ = 0;
                return this;
            }

            public SnsCommentInfo.Builder ClearContent()
            {
                this.PrepareBuilder();
                this.result.hasContent = false;
                this.result.content_ = "";
                return this;
            }

            public SnsCommentInfo.Builder ClearCreateTime()
            {
                this.PrepareBuilder();
                this.result.hasCreateTime = false;
                this.result.createTime_ = 0;
                return this;
            }

            public SnsCommentInfo.Builder ClearNickname()
            {
                this.PrepareBuilder();
                this.result.hasNickname = false;
                this.result.nickname_ = "";
                return this;
            }

            public SnsCommentInfo.Builder ClearReplyCommentId()
            {
                this.PrepareBuilder();
                this.result.hasReplyCommentId = false;
                this.result.replyCommentId_ = 0;
                return this;
            }

            public SnsCommentInfo.Builder ClearReplyUsername()
            {
                this.PrepareBuilder();
                this.result.hasReplyUsername = false;
                this.result.replyUsername_ = "";
                return this;
            }

            public SnsCommentInfo.Builder ClearSource()
            {
                this.PrepareBuilder();
                this.result.hasSource = false;
                this.result.source_ = 0;
                return this;
            }

            public SnsCommentInfo.Builder ClearType()
            {
                this.PrepareBuilder();
                this.result.hasType = false;
                this.result.type_ = 0;
                return this;
            }

            public SnsCommentInfo.Builder ClearUsername()
            {
                this.PrepareBuilder();
                this.result.hasUsername = false;
                this.result.username_ = "";
                return this;
            }

            public override SnsCommentInfo.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new SnsCommentInfo.Builder(this.result);
                }
                return new SnsCommentInfo.Builder().MergeFrom(this.result);
            }

            public override SnsCommentInfo.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override SnsCommentInfo.Builder MergeFrom(IMessageLite other)
            {
                if (other is SnsCommentInfo)
                {
                    return this.MergeFrom((SnsCommentInfo) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override SnsCommentInfo.Builder MergeFrom(SnsCommentInfo other)
            {
                return this;
            }

            public override SnsCommentInfo.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(SnsCommentInfo._snsCommentInfoFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = SnsCommentInfo._snsCommentInfoFieldTags[index];
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
                            this.result.hasNickname = input.ReadString(ref this.result.nickname_);
                            continue;
                        }
                        case 0x18:
                        {
                            this.result.hasSource = input.ReadUInt32(ref this.result.source_);
                            continue;
                        }
                        case 0x20:
                        {
                            this.result.hasType = input.ReadUInt32(ref this.result.type_);
                            continue;
                        }
                        case 0:
                            throw InvalidProtocolBufferException.InvalidTag();

                        case 10:
                        {
                            this.result.hasUsername = input.ReadString(ref this.result.username_);
                            continue;
                        }
                        case 0x2a:
                        {
                            this.result.hasContent = input.ReadString(ref this.result.content_);
                            continue;
                        }
                        case 0x30:
                        {
                            this.result.hasCreateTime = input.ReadUInt32(ref this.result.createTime_);
                            continue;
                        }
                        case 0x38:
                        {
                            this.result.hasCommentId = input.ReadInt32(ref this.result.commentId_);
                            continue;
                        }
                        case 0x40:
                        {
                            this.result.hasReplyCommentId = input.ReadInt32(ref this.result.replyCommentId_);
                            continue;
                        }
                        case 0x4a:
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
                    this.result.hasReplyUsername = input.ReadString(ref this.result.replyUsername_);
                }
                return this;
            }

            private SnsCommentInfo PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    SnsCommentInfo result = this.result;
                    this.result = new SnsCommentInfo();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public SnsCommentInfo.Builder SetCommentId(int value)
            {
                this.PrepareBuilder();
                this.result.hasCommentId = true;
                this.result.commentId_ = value;
                return this;
            }

            public SnsCommentInfo.Builder SetContent(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasContent = true;
                this.result.content_ = value;
                return this;
            }

            public SnsCommentInfo.Builder SetCreateTime(uint value)
            {
                this.PrepareBuilder();
                this.result.hasCreateTime = true;
                this.result.createTime_ = value;
                return this;
            }

            public SnsCommentInfo.Builder SetNickname(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasNickname = true;
                this.result.nickname_ = value;
                return this;
            }

            public SnsCommentInfo.Builder SetReplyCommentId(int value)
            {
                this.PrepareBuilder();
                this.result.hasReplyCommentId = true;
                this.result.replyCommentId_ = value;
                return this;
            }

            public SnsCommentInfo.Builder SetReplyUsername(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasReplyUsername = true;
                this.result.replyUsername_ = value;
                return this;
            }

            public SnsCommentInfo.Builder SetSource(uint value)
            {
                this.PrepareBuilder();
                this.result.hasSource = true;
                this.result.source_ = value;
                return this;
            }

            public SnsCommentInfo.Builder SetType(uint value)
            {
                this.PrepareBuilder();
                this.result.hasType = true;
                this.result.type_ = value;
                return this;
            }

            public SnsCommentInfo.Builder SetUsername(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasUsername = true;
                this.result.username_ = value;
                return this;
            }

            public int CommentId
            {
                get
                {
                    return this.result.CommentId;
                }
                set
                {
                    this.SetCommentId(value);
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

            public override SnsCommentInfo DefaultInstanceForType
            {
                get
                {
                    return SnsCommentInfo.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override SnsCommentInfo MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public string Nickname
            {
                get
                {
                    return this.result.Nickname;
                }
                set
                {
                    this.SetNickname(value);
                }
            }

            public int ReplyCommentId
            {
                get
                {
                    return this.result.ReplyCommentId;
                }
                set
                {
                    this.SetReplyCommentId(value);
                }
            }

            public string ReplyUsername
            {
                get
                {
                    return this.result.ReplyUsername;
                }
                set
                {
                    this.SetReplyUsername(value);
                }
            }

            public uint Source
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

            protected override SnsCommentInfo.Builder ThisBuilder
            {
                get
                {
                    return this;
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

            public string Username
            {
                get
                {
                    return this.result.Username;
                }
                set
                {
                    this.SetUsername(value);
                }
            }
        }
    }
}


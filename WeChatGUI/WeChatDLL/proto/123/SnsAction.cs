namespace micromsg
{
    using Google.ProtocolBuffers;
    
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    


    public sealed class SnsAction : GeneratedMessageLite<SnsAction, SnsAction.Builder>
    {
        private static readonly string[] _snsActionFieldNames = new string[] { "CommentId", "Content", "CreateTime", "FromNickname", "FromUsername", "ReplyCommentId", "Source", "ToNickname", "ToUsername", "Type" };
        private static readonly uint[] _snsActionFieldTags = new uint[] { 80, 0x42, 0x38, 0x1a, 10, 0x48, 0x30, 0x22, 0x12, 40 };
        private int commentId_;
        public const int CommentIdFieldNumber = 10;
        private string content_ = "";
        public const int ContentFieldNumber = 8;
        private uint createTime_;
        public const int CreateTimeFieldNumber = 7;
        private static readonly SnsAction defaultInstance = new SnsAction().MakeReadOnly();
        private string fromNickname_ = "";
        public const int FromNicknameFieldNumber = 3;
        private string fromUsername_ = "";
        public const int FromUsernameFieldNumber = 1;
        private bool hasCommentId;
        private bool hasContent;
        private bool hasCreateTime;
        private bool hasFromNickname;
        private bool hasFromUsername;
        private bool hasReplyCommentId;
        private bool hasSource;
        private bool hasToNickname;
        private bool hasToUsername;
        private bool hasType;
        private int memoizedSerializedSize = -1;
        private int replyCommentId_;
        public const int ReplyCommentIdFieldNumber = 9;
        private uint source_;
        public const int SourceFieldNumber = 6;
        private string toNickname_ = "";
        public const int ToNicknameFieldNumber = 4;
        private string toUsername_ = "";
        public const int ToUsernameFieldNumber = 2;
        private uint type_;
        public const int TypeFieldNumber = 5;

        static SnsAction()
        {
            //object.ReferenceEquals(SnsAction.Descriptor, null);
        }

        private SnsAction()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(SnsAction prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            SnsAction action = obj as SnsAction;
            if (action == null)
            {
                return false;
            }
            if ((this.hasFromUsername != action.hasFromUsername) || (this.hasFromUsername && !this.fromUsername_.Equals(action.fromUsername_)))
            {
                return false;
            }
            if ((this.hasToUsername != action.hasToUsername) || (this.hasToUsername && !this.toUsername_.Equals(action.toUsername_)))
            {
                return false;
            }
            if ((this.hasFromNickname != action.hasFromNickname) || (this.hasFromNickname && !this.fromNickname_.Equals(action.fromNickname_)))
            {
                return false;
            }
            if ((this.hasToNickname != action.hasToNickname) || (this.hasToNickname && !this.toNickname_.Equals(action.toNickname_)))
            {
                return false;
            }
            if ((this.hasType != action.hasType) || (this.hasType && !this.type_.Equals(action.type_)))
            {
                return false;
            }
            if ((this.hasSource != action.hasSource) || (this.hasSource && !this.source_.Equals(action.source_)))
            {
                return false;
            }
            if ((this.hasCreateTime != action.hasCreateTime) || (this.hasCreateTime && !this.createTime_.Equals(action.createTime_)))
            {
                return false;
            }
            if ((this.hasContent != action.hasContent) || (this.hasContent && !this.content_.Equals(action.content_)))
            {
                return false;
            }
            if ((this.hasReplyCommentId != action.hasReplyCommentId) || (this.hasReplyCommentId && !this.replyCommentId_.Equals(action.replyCommentId_)))
            {
                return false;
            }
            return ((this.hasCommentId == action.hasCommentId) && (!this.hasCommentId || this.commentId_.Equals(action.commentId_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasFromUsername)
            {
                hashCode ^= this.fromUsername_.GetHashCode();
            }
            if (this.hasToUsername)
            {
                hashCode ^= this.toUsername_.GetHashCode();
            }
            if (this.hasFromNickname)
            {
                hashCode ^= this.fromNickname_.GetHashCode();
            }
            if (this.hasToNickname)
            {
                hashCode ^= this.toNickname_.GetHashCode();
            }
            if (this.hasType)
            {
                hashCode ^= this.type_.GetHashCode();
            }
            if (this.hasSource)
            {
                hashCode ^= this.source_.GetHashCode();
            }
            if (this.hasCreateTime)
            {
                hashCode ^= this.createTime_.GetHashCode();
            }
            if (this.hasContent)
            {
                hashCode ^= this.content_.GetHashCode();
            }
            if (this.hasReplyCommentId)
            {
                hashCode ^= this.replyCommentId_.GetHashCode();
            }
            if (this.hasCommentId)
            {
                hashCode ^= this.commentId_.GetHashCode();
            }
            return hashCode;
        }

        private SnsAction MakeReadOnly()
        {
            return this;
        }

        public static SnsAction ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<SnsAction, Builder>.PrintField("FromUsername", this.hasFromUsername, this.fromUsername_, writer);
            GeneratedMessageLite<SnsAction, Builder>.PrintField("ToUsername", this.hasToUsername, this.toUsername_, writer);
            GeneratedMessageLite<SnsAction, Builder>.PrintField("FromNickname", this.hasFromNickname, this.fromNickname_, writer);
            GeneratedMessageLite<SnsAction, Builder>.PrintField("ToNickname", this.hasToNickname, this.toNickname_, writer);
            GeneratedMessageLite<SnsAction, Builder>.PrintField("Type", this.hasType, this.type_, writer);
            GeneratedMessageLite<SnsAction, Builder>.PrintField("Source", this.hasSource, this.source_, writer);
            GeneratedMessageLite<SnsAction, Builder>.PrintField("CreateTime", this.hasCreateTime, this.createTime_, writer);
            GeneratedMessageLite<SnsAction, Builder>.PrintField("Content", this.hasContent, this.content_, writer);
            GeneratedMessageLite<SnsAction, Builder>.PrintField("ReplyCommentId", this.hasReplyCommentId, this.replyCommentId_, writer);
            GeneratedMessageLite<SnsAction, Builder>.PrintField("CommentId", this.hasCommentId, this.commentId_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _snsActionFieldNames;
            if (this.hasFromUsername)
            {
                output.WriteString(1, strArray[4], this.FromUsername);
            }
            if (this.hasToUsername)
            {
                output.WriteString(2, strArray[8], this.ToUsername);
            }
            if (this.hasFromNickname)
            {
                output.WriteString(3, strArray[3], this.FromNickname);
            }
            if (this.hasToNickname)
            {
                output.WriteString(4, strArray[7], this.ToNickname);
            }
            if (this.hasType)
            {
                output.WriteUInt32(5, strArray[9], this.Type);
            }
            if (this.hasSource)
            {
                output.WriteUInt32(6, strArray[6], this.Source);
            }
            if (this.hasCreateTime)
            {
                output.WriteUInt32(7, strArray[2], this.CreateTime);
            }
            if (this.hasContent)
            {
                output.WriteString(8, strArray[1], this.Content);
            }
            if (this.hasReplyCommentId)
            {
                output.WriteInt32(9, strArray[5], this.ReplyCommentId);
            }
            if (this.hasCommentId)
            {
                output.WriteInt32(10, strArray[0], this.CommentId);
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

        public static SnsAction DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override SnsAction DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public string FromNickname
        {
            get
            {
                return this.fromNickname_;
            }
        }

        public string FromUsername
        {
            get
            {
                return this.fromUsername_;
            }
        }

        public override bool IsInitialized
        {
            get
            {
                if (!this.hasType)
                {
                    return false;
                }
                if (!this.hasSource)
                {
                    return false;
                }
                return true;
            }
        }

        public int ReplyCommentId
        {
            get
            {
                return this.replyCommentId_;
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
                    if (this.hasFromUsername)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(1, this.FromUsername);
                    }
                    if (this.hasToUsername)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(2, this.ToUsername);
                    }
                    if (this.hasFromNickname)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(3, this.FromNickname);
                    }
                    if (this.hasToNickname)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(4, this.ToNickname);
                    }
                    if (this.hasType)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(5, this.Type);
                    }
                    if (this.hasSource)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(6, this.Source);
                    }
                    if (this.hasCreateTime)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(7, this.CreateTime);
                    }
                    if (this.hasContent)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(8, this.Content);
                    }
                    if (this.hasReplyCommentId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(9, this.ReplyCommentId);
                    }
                    if (this.hasCommentId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(10, this.CommentId);
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

        protected override SnsAction ThisMessage
        {
            get
            {
                return this;
            }
        }

        public string ToNickname
        {
            get
            {
                return this.toNickname_;
            }
        }

        public string ToUsername
        {
            get
            {
                return this.toUsername_;
            }
        }

        public uint Type
        {
            get
            {
                return this.type_;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<SnsAction, SnsAction.Builder>
        {
            private SnsAction result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = SnsAction.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(SnsAction cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override SnsAction BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override SnsAction.Builder Clear()
            {
                this.result = SnsAction.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public SnsAction.Builder ClearCommentId()
            {
                this.PrepareBuilder();
                this.result.hasCommentId = false;
                this.result.commentId_ = 0;
                return this;
            }

            public SnsAction.Builder ClearContent()
            {
                this.PrepareBuilder();
                this.result.hasContent = false;
                this.result.content_ = "";
                return this;
            }

            public SnsAction.Builder ClearCreateTime()
            {
                this.PrepareBuilder();
                this.result.hasCreateTime = false;
                this.result.createTime_ = 0;
                return this;
            }

            public SnsAction.Builder ClearFromNickname()
            {
                this.PrepareBuilder();
                this.result.hasFromNickname = false;
                this.result.fromNickname_ = "";
                return this;
            }

            public SnsAction.Builder ClearFromUsername()
            {
                this.PrepareBuilder();
                this.result.hasFromUsername = false;
                this.result.fromUsername_ = "";
                return this;
            }

            public SnsAction.Builder ClearReplyCommentId()
            {
                this.PrepareBuilder();
                this.result.hasReplyCommentId = false;
                this.result.replyCommentId_ = 0;
                return this;
            }

            public SnsAction.Builder ClearSource()
            {
                this.PrepareBuilder();
                this.result.hasSource = false;
                this.result.source_ = 0;
                return this;
            }

            public SnsAction.Builder ClearToNickname()
            {
                this.PrepareBuilder();
                this.result.hasToNickname = false;
                this.result.toNickname_ = "";
                return this;
            }

            public SnsAction.Builder ClearToUsername()
            {
                this.PrepareBuilder();
                this.result.hasToUsername = false;
                this.result.toUsername_ = "";
                return this;
            }

            public SnsAction.Builder ClearType()
            {
                this.PrepareBuilder();
                this.result.hasType = false;
                this.result.type_ = 0;
                return this;
            }

            public override SnsAction.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new SnsAction.Builder(this.result);
                }
                return new SnsAction.Builder().MergeFrom(this.result);
            }

            public override SnsAction.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override SnsAction.Builder MergeFrom(IMessageLite other)
            {
                if (other is SnsAction)
                {
                    return this.MergeFrom((SnsAction) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override SnsAction.Builder MergeFrom(SnsAction other)
            {
                return this;
            }

            public override SnsAction.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(SnsAction._snsActionFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = SnsAction._snsActionFieldTags[index];
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
                            this.result.hasToUsername = input.ReadString(ref this.result.toUsername_);
                            continue;
                        }
                        case 0x1a:
                        {
                            this.result.hasFromNickname = input.ReadString(ref this.result.fromNickname_);
                            continue;
                        }
                        case 0x22:
                        {
                            this.result.hasToNickname = input.ReadString(ref this.result.toNickname_);
                            continue;
                        }
                        case 0:
                            throw InvalidProtocolBufferException.InvalidTag();

                        case 10:
                        {
                            this.result.hasFromUsername = input.ReadString(ref this.result.fromUsername_);
                            continue;
                        }
                        case 40:
                        {
                            this.result.hasType = input.ReadUInt32(ref this.result.type_);
                            continue;
                        }
                        case 0x30:
                        {
                            this.result.hasSource = input.ReadUInt32(ref this.result.source_);
                            continue;
                        }
                        case 0x38:
                        {
                            this.result.hasCreateTime = input.ReadUInt32(ref this.result.createTime_);
                            continue;
                        }
                        case 0x42:
                        {
                            this.result.hasContent = input.ReadString(ref this.result.content_);
                            continue;
                        }
                        case 0x48:
                        {
                            this.result.hasReplyCommentId = input.ReadInt32(ref this.result.replyCommentId_);
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
                    this.result.hasCommentId = input.ReadInt32(ref this.result.commentId_);
                }
                return this;
            }

            private SnsAction PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    SnsAction result = this.result;
                    this.result = new SnsAction();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public SnsAction.Builder SetCommentId(int value)
            {
                this.PrepareBuilder();
                this.result.hasCommentId = true;
                this.result.commentId_ = value;
                return this;
            }

            public SnsAction.Builder SetContent(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasContent = true;
                this.result.content_ = value;
                return this;
            }

            public SnsAction.Builder SetCreateTime(uint value)
            {
                this.PrepareBuilder();
                this.result.hasCreateTime = true;
                this.result.createTime_ = value;
                return this;
            }

            public SnsAction.Builder SetFromNickname(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasFromNickname = true;
                this.result.fromNickname_ = value;
                return this;
            }

            public SnsAction.Builder SetFromUsername(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasFromUsername = true;
                this.result.fromUsername_ = value;
                return this;
            }

            public SnsAction.Builder SetReplyCommentId(int value)
            {
                this.PrepareBuilder();
                this.result.hasReplyCommentId = true;
                this.result.replyCommentId_ = value;
                return this;
            }

            public SnsAction.Builder SetSource(uint value)
            {
                this.PrepareBuilder();
                this.result.hasSource = true;
                this.result.source_ = value;
                return this;
            }

            public SnsAction.Builder SetToNickname(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasToNickname = true;
                this.result.toNickname_ = value;
                return this;
            }

            public SnsAction.Builder SetToUsername(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasToUsername = true;
                this.result.toUsername_ = value;
                return this;
            }

            public SnsAction.Builder SetType(uint value)
            {
                this.PrepareBuilder();
                this.result.hasType = true;
                this.result.type_ = value;
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

            public override SnsAction DefaultInstanceForType
            {
                get
                {
                    return SnsAction.DefaultInstance;
                }
            }

            public string FromNickname
            {
                get
                {
                    return this.result.FromNickname;
                }
                set
                {
                    this.SetFromNickname(value);
                }
            }

            public string FromUsername
            {
                get
                {
                    return this.result.FromUsername;
                }
                set
                {
                    this.SetFromUsername(value);
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override SnsAction MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
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

            protected override SnsAction.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }

            public string ToNickname
            {
                get
                {
                    return this.result.ToNickname;
                }
                set
                {
                    this.SetToNickname(value);
                }
            }

            public string ToUsername
            {
                get
                {
                    return this.result.ToUsername;
                }
                set
                {
                    this.SetToUsername(value);
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


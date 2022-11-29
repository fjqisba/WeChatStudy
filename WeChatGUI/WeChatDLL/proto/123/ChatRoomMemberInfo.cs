namespace micromsg
{
    using Google.ProtocolBuffers;
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    using System.Runtime.CompilerServices;


    public sealed class ChatRoomMemberInfo : GeneratedMessageLite<ChatRoomMemberInfo, ChatRoomMemberInfo.Builder>
    {
        private static readonly string[] _chatRoomMemberInfoFieldNames = new string[] { "BigHeadImgUrl", "ChatroomMemberFlag", "DisplayName", "NickName", "SmallHeadImgUrl", "UserName" , "InviterUserName" };
        private static readonly uint[] _chatRoomMemberInfoFieldTags = new uint[] { 0x22, 0x30, 0x1a, 0x12, 0x2a, 10 };
        private string bigHeadImgUrl_ = "";
        private string inviterUserName_ = "";
        public const int BigHeadImgUrlFieldNumber = 4;
        private uint chatroomMemberFlag_;
        public const int ChatroomMemberFlagFieldNumber = 6;
        private static readonly ChatRoomMemberInfo defaultInstance = new ChatRoomMemberInfo().MakeReadOnly();
        private string displayName_ = "";
        public const int DisplayNameFieldNumber = 3;
        private bool hasBigHeadImgUrl;
        private bool hasChatroomMemberFlag;
        private bool hasDisplayName;
        private bool hasNickName;
        private bool hasSmallHeadImgUrl;
        private bool hasUserName;
        private bool hasInviterUserName;
        private int memoizedSerializedSize = -1;
        private string nickName_ = "";
        public const int NickNameFieldNumber = 2;
        private string smallHeadImgUrl_ = "";
        public const int SmallHeadImgUrlFieldNumber = 5;
        private string userName_ = "";
        public const int UserNameFieldNumber = 1;

        static ChatRoomMemberInfo()
        {

        }

        private ChatRoomMemberInfo()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(ChatRoomMemberInfo prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            ChatRoomMemberInfo info = obj as ChatRoomMemberInfo;
            if (info == null)
            {
                return false;
            }
            if ((this.hasUserName != info.hasUserName) || (this.hasUserName && !this.userName_.Equals(info.userName_)))
            {
                return false;
            }
            if ((this.hasNickName != info.hasNickName) || (this.hasNickName && !this.nickName_.Equals(info.nickName_)))
            {
                return false;
            }
            if ((this.hasDisplayName != info.hasDisplayName) || (this.hasDisplayName && !this.displayName_.Equals(info.displayName_)))
            {
                return false;
            }
            if ((this.hasBigHeadImgUrl != info.hasBigHeadImgUrl) || (this.hasBigHeadImgUrl && !this.bigHeadImgUrl_.Equals(info.bigHeadImgUrl_)))
            {
                return false;
            }
            if ((this.hasSmallHeadImgUrl != info.hasSmallHeadImgUrl) || (this.hasSmallHeadImgUrl && !this.smallHeadImgUrl_.Equals(info.smallHeadImgUrl_)))
            {
                return false;
            }
            return ((this.hasChatroomMemberFlag == info.hasChatroomMemberFlag) && (!this.hasChatroomMemberFlag || this.chatroomMemberFlag_.Equals(info.chatroomMemberFlag_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasUserName)
            {
                hashCode ^= this.userName_.GetHashCode();
            }
            if (this.hasNickName)
            {
                hashCode ^= this.nickName_.GetHashCode();
            }
            if (this.hasDisplayName)
            {
                hashCode ^= this.displayName_.GetHashCode();
            }
            if (this.hasBigHeadImgUrl)
            {
                hashCode ^= this.bigHeadImgUrl_.GetHashCode();
            }
            if (this.hasSmallHeadImgUrl)
            {
                hashCode ^= this.smallHeadImgUrl_.GetHashCode();
            }
            if (this.hasChatroomMemberFlag)
            {
                hashCode ^= this.chatroomMemberFlag_.GetHashCode();
            }
            return hashCode;
        }

        private ChatRoomMemberInfo MakeReadOnly()
        {
            return this;
        }

        public static ChatRoomMemberInfo ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<ChatRoomMemberInfo, Builder>.PrintField("UserName", this.hasUserName, this.userName_, writer);
            GeneratedMessageLite<ChatRoomMemberInfo, Builder>.PrintField("NickName", this.hasNickName, this.nickName_, writer);
            GeneratedMessageLite<ChatRoomMemberInfo, Builder>.PrintField("DisplayName", this.hasDisplayName, this.displayName_, writer);
            GeneratedMessageLite<ChatRoomMemberInfo, Builder>.PrintField("BigHeadImgUrl", this.hasBigHeadImgUrl, this.bigHeadImgUrl_, writer);
            GeneratedMessageLite<ChatRoomMemberInfo, Builder>.PrintField("SmallHeadImgUrl", this.hasSmallHeadImgUrl, this.smallHeadImgUrl_, writer);
            GeneratedMessageLite<ChatRoomMemberInfo, Builder>.PrintField("ChatroomMemberFlag", this.hasChatroomMemberFlag, this.chatroomMemberFlag_, writer);
            GeneratedMessageLite<ChatRoomMemberInfo, Builder>.PrintField("InviterUserName", this.hasInviterUserName, this.inviterUserName_, writer);


            
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _chatRoomMemberInfoFieldNames;
            if (this.hasUserName)
            {
                output.WriteString(1, strArray[5], this.UserName);
            }
            if (this.hasNickName)
            {
                output.WriteString(2, strArray[3], this.NickName);
            }
            if (this.hasDisplayName)
            {
                output.WriteString(3, strArray[2], this.DisplayName);
            }
            if (this.hasBigHeadImgUrl)
            {
                output.WriteString(4, strArray[0], this.BigHeadImgUrl);
            }
            if (this.hasSmallHeadImgUrl)
            {
                output.WriteString(5, strArray[4], this.SmallHeadImgUrl);
            }
            if (this.hasChatroomMemberFlag)
            {
                output.WriteUInt32(6, strArray[1], this.ChatroomMemberFlag);
            }
            if (this.hasInviterUserName)
            {
                output.WriteUInt32(7, strArray[6], this.ChatroomMemberFlag);
            }
        }

        public string BigHeadImgUrl
        {
            get
            {
                return this.bigHeadImgUrl_;
            }
        }

        public string InviterUserName
        {
            get
            {
                return this.inviterUserName_;
            }
        }

        public uint ChatroomMemberFlag
        {
            get
            {
                return this.chatroomMemberFlag_;
            }
        }

        public static ChatRoomMemberInfo DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override ChatRoomMemberInfo DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public string DisplayName
        {
            get
            {
                return this.displayName_;
            }
        }

        public override bool IsInitialized
        {
            get
            {
                if (!this.hasChatroomMemberFlag)
                {
                    return false;
                }
                return true;
            }
        }

        public string NickName
        {
            get
            {
                return this.nickName_;
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
                    if (this.hasUserName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(1, this.UserName);
                    }
                    if (this.hasNickName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(2, this.NickName);
                    }
                    if (this.hasDisplayName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(3, this.DisplayName);
                    }
                    if (this.hasBigHeadImgUrl)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(4, this.BigHeadImgUrl);
                    }
                    if (this.hasSmallHeadImgUrl)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(5, this.SmallHeadImgUrl);
                    }
                    if (this.hasChatroomMemberFlag)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(6, this.ChatroomMemberFlag);
                    }         
                    if (this.hasInviterUserName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(7, this.InviterUserName);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        public string SmallHeadImgUrl
        {
            get
            {
                return this.smallHeadImgUrl_;
            }
        }

        protected override ChatRoomMemberInfo ThisMessage
        {
            get
            {
                return this;
            }
        }

        public string UserName
        {
            get
            {
                return this.userName_;
            }
        }

        [DebuggerNonUserCode, CompilerGenerated, GeneratedCode("ProtoGen", "2.3.0.277")]
        public sealed class Builder : GeneratedBuilderLite<ChatRoomMemberInfo, ChatRoomMemberInfo.Builder>
        {
            private ChatRoomMemberInfo result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = ChatRoomMemberInfo.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(ChatRoomMemberInfo cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override ChatRoomMemberInfo BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override ChatRoomMemberInfo.Builder Clear()
            {
                this.result = ChatRoomMemberInfo.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public ChatRoomMemberInfo.Builder ClearBigHeadImgUrl()
            {
                this.PrepareBuilder();
                this.result.hasBigHeadImgUrl = false;
                this.result.bigHeadImgUrl_ = "";
                return this;
            }

            public ChatRoomMemberInfo.Builder ClearChatroomMemberFlag()
            {
                this.PrepareBuilder();
                this.result.hasChatroomMemberFlag = false;
                this.result.chatroomMemberFlag_ = 0;
                return this;
            }

            public ChatRoomMemberInfo.Builder ClearDisplayName()
            {
                this.PrepareBuilder();
                this.result.hasDisplayName = false;
                this.result.displayName_ = "";
                return this;
            }

            public ChatRoomMemberInfo.Builder ClearNickName()
            {
                this.PrepareBuilder();
                this.result.hasNickName = false;
                this.result.nickName_ = "";
                return this;
            }

            public ChatRoomMemberInfo.Builder ClearSmallHeadImgUrl()
            {
                this.PrepareBuilder();
                this.result.hasSmallHeadImgUrl = false;
                this.result.smallHeadImgUrl_ = "";
                return this;
            }

            public ChatRoomMemberInfo.Builder ClearUserName()
            {
                this.PrepareBuilder();
                this.result.hasUserName = false;
                this.result.userName_ = "";
                return this;
            }

            public override ChatRoomMemberInfo.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new ChatRoomMemberInfo.Builder(this.result);
                }
                return new ChatRoomMemberInfo.Builder().MergeFrom(this.result);
            }

            public override ChatRoomMemberInfo.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override ChatRoomMemberInfo.Builder MergeFrom(IMessageLite other)
            {
                if (other is ChatRoomMemberInfo)
                {
                    return this.MergeFrom((ChatRoomMemberInfo) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override ChatRoomMemberInfo.Builder MergeFrom(ChatRoomMemberInfo other)
            {
                return this;
            }

            public override ChatRoomMemberInfo.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(ChatRoomMemberInfo._chatRoomMemberInfoFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = ChatRoomMemberInfo._chatRoomMemberInfoFieldTags[index];
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
                            this.result.hasUserName = input.ReadString(ref this.result.userName_);
                            continue;
                        }
                        case 0x12:
                        {
                            this.result.hasNickName = input.ReadString(ref this.result.nickName_);
                            continue;
                        }
                        case 0x1a:
                        {
                            this.result.hasDisplayName = input.ReadString(ref this.result.displayName_);
                            continue;
                        }
                        case 0x22:
                        {
                            this.result.hasBigHeadImgUrl = input.ReadString(ref this.result.bigHeadImgUrl_);
                            continue;
                        }
                        case 0x2a:
                        {
                            this.result.hasSmallHeadImgUrl = input.ReadString(ref this.result.smallHeadImgUrl_);
                            continue;
                        }
                        case 0x30:
                            {
                                this.result.hasChatroomMemberFlag = input.ReadUInt32(ref this.result.chatroomMemberFlag_);
                                continue;
                            }
                        case 0x3a:
                            {
                                this.result.hasInviterUserName = input.ReadString(ref this.result.inviterUserName_);
                                continue;
                            }
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
                    
                }
                return this;
            }

            private ChatRoomMemberInfo PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    ChatRoomMemberInfo result = this.result;
                    this.result = new ChatRoomMemberInfo();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public ChatRoomMemberInfo.Builder SetBigHeadImgUrl(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBigHeadImgUrl = true;
                this.result.bigHeadImgUrl_ = value;
                return this;
            }

            public ChatRoomMemberInfo.Builder SetChatroomMemberFlag(uint value)
            {
                this.PrepareBuilder();
                this.result.hasChatroomMemberFlag = true;
                this.result.chatroomMemberFlag_ = value;
                return this;
            }

            public ChatRoomMemberInfo.Builder SetDisplayName(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasDisplayName = true;
                this.result.displayName_ = value;
                return this;
            }

            public ChatRoomMemberInfo.Builder SetNickName(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasNickName = true;
                this.result.nickName_ = value;
                return this;
            }

            public ChatRoomMemberInfo.Builder SetSmallHeadImgUrl(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSmallHeadImgUrl = true;
                this.result.smallHeadImgUrl_ = value;
                return this;
            }

            public ChatRoomMemberInfo.Builder SetUserName(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasUserName = true;
                this.result.userName_ = value;
                return this;
            }

            public ChatRoomMemberInfo.Builder SetInviterUserName(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasInviterUserName = true;
                this.result.inviterUserName_ = value;
                return this;
            }

            public string BigHeadImgUrl
            {
                get
                {
                    return this.result.BigHeadImgUrl;
                }
                set
                {
                    this.SetBigHeadImgUrl(value);
                }
            }

            public uint ChatroomMemberFlag
            {
                get
                {
                    return this.result.ChatroomMemberFlag;
                }
                set
                {
                    this.SetChatroomMemberFlag(value);
                }
            }

            public override ChatRoomMemberInfo DefaultInstanceForType
            {
                get
                {
                    return ChatRoomMemberInfo.DefaultInstance;
                }
            }

            public string DisplayName
            {
                get
                {
                    return this.result.DisplayName;
                }
                set
                {
                    this.SetDisplayName(value);
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override ChatRoomMemberInfo MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public string NickName
            {
                get
                {
                    return this.result.NickName;
                }
                set
                {
                    this.SetNickName(value);
                }
            }

            public string SmallHeadImgUrl
            {
                get
                {
                    return this.result.SmallHeadImgUrl;
                }
                set
                {
                    this.SetSmallHeadImgUrl(value);
                }
            }

            protected override ChatRoomMemberInfo.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }

            public string UserName
            {
                get
                {
                    return this.result.UserName;
                }
                set
                {
                    this.SetUserName(value);
                }
            }

            public string InviterUserName
            {
                get
                {
                    return this.result.InviterUserName;
                }
                set
                {
                    this.SetInviterUserName(value);
                }
            }

        }
    }
}

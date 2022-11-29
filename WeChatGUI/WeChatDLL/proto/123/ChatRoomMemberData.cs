namespace micromsg
{
    using Google.ProtocolBuffers;
    using Google.ProtocolBuffers.Collections;

    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Runtime.CompilerServices;


    public sealed class ChatRoomMemberData : GeneratedMessageLite<ChatRoomMemberData, ChatRoomMemberData.Builder>
    {
        private static readonly string[] _chatRoomMemberDataFieldNames = new string[] { "ChatRoomMember", "InfoMask", "MemberCount" };
        private static readonly uint[] _chatRoomMemberDataFieldTags = new uint[] { 0x12, 0x18, 8 };
        private PopsicleList<ChatRoomMemberInfo> chatRoomMember_ = new PopsicleList<ChatRoomMemberInfo>();
        public const int ChatRoomMemberFieldNumber = 2;
        private static readonly ChatRoomMemberData defaultInstance = new ChatRoomMemberData().MakeReadOnly();
        private bool hasInfoMask;
        private bool hasMemberCount;
        private uint infoMask_;
        public const int InfoMaskFieldNumber = 3;
        private uint memberCount_;
        public const int MemberCountFieldNumber = 1;
        private int memoizedSerializedSize = -1;

        static ChatRoomMemberData()
        {
           
        }

        private ChatRoomMemberData()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(ChatRoomMemberData prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            ChatRoomMemberData data = obj as ChatRoomMemberData;
            if (data == null)
            {
                return false;
            }
            if ((this.hasMemberCount != data.hasMemberCount) || (this.hasMemberCount && !this.memberCount_.Equals(data.memberCount_)))
            {
                return false;
            }
            if (this.chatRoomMember_.Count != data.chatRoomMember_.Count)
            {
                return false;
            }
            for (int i = 0; i < this.chatRoomMember_.Count; i++)
            {
                if (!this.chatRoomMember_[i].Equals(data.chatRoomMember_[i]))
                {
                    return false;
                }
            }
            return ((this.hasInfoMask == data.hasInfoMask) && (!this.hasInfoMask || this.infoMask_.Equals(data.infoMask_)));
        }

        public ChatRoomMemberInfo GetChatRoomMember(int index)
        {
            return this.chatRoomMember_[index];
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasMemberCount)
            {
                hashCode ^= this.memberCount_.GetHashCode();
            }
            foreach (ChatRoomMemberInfo info in this.chatRoomMember_)
            {
                hashCode ^= info.GetHashCode();
            }
            if (this.hasInfoMask)
            {
                hashCode ^= this.infoMask_.GetHashCode();
            }
            return hashCode;
        }

        private ChatRoomMemberData MakeReadOnly()
        {
            this.chatRoomMember_.MakeReadOnly();
            return this;
        }

        public static ChatRoomMemberData ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<ChatRoomMemberData, Builder>.PrintField("MemberCount", this.hasMemberCount, this.memberCount_, writer);
            GeneratedMessageLite<ChatRoomMemberData, Builder>.PrintField<ChatRoomMemberInfo>("ChatRoomMember", this.chatRoomMember_, writer);
            GeneratedMessageLite<ChatRoomMemberData, Builder>.PrintField("InfoMask", this.hasInfoMask, this.infoMask_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _chatRoomMemberDataFieldNames;
            if (this.hasMemberCount)
            {
                output.WriteUInt32(1, strArray[2], this.MemberCount);
            }
            if (this.chatRoomMember_.Count > 0)
            {
                output.WriteMessageArray<ChatRoomMemberInfo>(2, strArray[0], this.chatRoomMember_);
            }
            if (this.hasInfoMask)
            {
                output.WriteUInt32(3, strArray[1], this.InfoMask);
            }
        }

        public int ChatRoomMemberCount
        {
            get
            {
                return this.chatRoomMember_.Count;
            }
        }

        public IList<ChatRoomMemberInfo> ChatRoomMemberList
        {
            get
            {
                return this.chatRoomMember_;
            }
        }

        public static ChatRoomMemberData DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override ChatRoomMemberData DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public uint InfoMask
        {
            get
            {
                return this.infoMask_;
            }
        }

        public override bool IsInitialized
        {
            get
            {
                if (!this.hasMemberCount)
                {
                    return false;
                }
                foreach (ChatRoomMemberInfo info in this.ChatRoomMemberList)
                {
                    if (!info.IsInitialized)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public uint MemberCount
        {
            get
            {
                return this.memberCount_;
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
                    if (this.hasMemberCount)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(1, this.MemberCount);
                    }
                    foreach (ChatRoomMemberInfo info in this.ChatRoomMemberList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(2, info);
                    }
                    if (this.hasInfoMask)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(3, this.InfoMask);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override ChatRoomMemberData ThisMessage
        {
            get
            {
                return this;
            }
        }

        [CompilerGenerated, GeneratedCode("ProtoGen", "2.3.0.277"), DebuggerNonUserCode]
        public sealed class Builder : GeneratedBuilderLite<ChatRoomMemberData, ChatRoomMemberData.Builder>
        {
            private ChatRoomMemberData result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = ChatRoomMemberData.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(ChatRoomMemberData cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public ChatRoomMemberData.Builder AddChatRoomMember(ChatRoomMemberInfo value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.chatRoomMember_.Add(value);
                return this;
            }

            public ChatRoomMemberData.Builder AddChatRoomMember(ChatRoomMemberInfo.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.chatRoomMember_.Add(builderForValue.Build());
                return this;
            }

            public ChatRoomMemberData.Builder AddRangeChatRoomMember(IEnumerable<ChatRoomMemberInfo> values)
            {
                this.PrepareBuilder();
                this.result.chatRoomMember_.Add(values);
                return this;
            }

            public override ChatRoomMemberData BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override ChatRoomMemberData.Builder Clear()
            {
                this.result = ChatRoomMemberData.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public ChatRoomMemberData.Builder ClearChatRoomMember()
            {
                this.PrepareBuilder();
                this.result.chatRoomMember_.Clear();
                return this;
            }

            public ChatRoomMemberData.Builder ClearInfoMask()
            {
                this.PrepareBuilder();
                this.result.hasInfoMask = false;
                this.result.infoMask_ = 0;
                return this;
            }

            public ChatRoomMemberData.Builder ClearMemberCount()
            {
                this.PrepareBuilder();
                this.result.hasMemberCount = false;
                this.result.memberCount_ = 0;
                return this;
            }

            public override ChatRoomMemberData.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new ChatRoomMemberData.Builder(this.result);
                }
                return new ChatRoomMemberData.Builder().MergeFrom(this.result);
            }

            public ChatRoomMemberInfo GetChatRoomMember(int index)
            {
                return this.result.GetChatRoomMember(index);
            }

            public override ChatRoomMemberData.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override ChatRoomMemberData.Builder MergeFrom(IMessageLite other)
            {
                if (other is ChatRoomMemberData)
                {
                    return this.MergeFrom((ChatRoomMemberData) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override ChatRoomMemberData.Builder MergeFrom(ChatRoomMemberData other)
            {
                return this;
            }

            public override ChatRoomMemberData.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(ChatRoomMemberData._chatRoomMemberDataFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = ChatRoomMemberData._chatRoomMemberDataFieldTags[index];
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

                        case 8:
                        {
                            this.result.hasMemberCount = input.ReadUInt32(ref this.result.memberCount_);
                            continue;
                        }
                        case 0x12:
                        {
                            input.ReadMessageArray<ChatRoomMemberInfo>(num, str, this.result.chatRoomMember_, ChatRoomMemberInfo.DefaultInstance, extensionRegistry);
                            continue;
                        }
                        case 0x18:
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
                    this.result.hasInfoMask = input.ReadUInt32(ref this.result.infoMask_);
                }
                return this;
            }

            private ChatRoomMemberData PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    ChatRoomMemberData result = this.result;
                    this.result = new ChatRoomMemberData();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public ChatRoomMemberData.Builder SetChatRoomMember(int index, ChatRoomMemberInfo value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.chatRoomMember_[index] = value;
                return this;
            }

            public ChatRoomMemberData.Builder SetChatRoomMember(int index, ChatRoomMemberInfo.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.chatRoomMember_[index] = builderForValue.Build();
                return this;
            }

            public ChatRoomMemberData.Builder SetInfoMask(uint value)
            {
                this.PrepareBuilder();
                this.result.hasInfoMask = true;
                this.result.infoMask_ = value;
                return this;
            }

            public ChatRoomMemberData.Builder SetMemberCount(uint value)
            {
                this.PrepareBuilder();
                this.result.hasMemberCount = true;
                this.result.memberCount_ = value;
                return this;
            }

            public int ChatRoomMemberCount
            {
                get
                {
                    return this.result.ChatRoomMemberCount;
                }
            }

            public IPopsicleList<ChatRoomMemberInfo> ChatRoomMemberList
            {
                get
                {
                    return this.PrepareBuilder().chatRoomMember_;
                }
            }

            public override ChatRoomMemberData DefaultInstanceForType
            {
                get
                {
                    return ChatRoomMemberData.DefaultInstance;
                }
            }

            public uint InfoMask
            {
                get
                {
                    return this.result.InfoMask;
                }
                set
                {
                    this.SetInfoMask(value);
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            public uint MemberCount
            {
                get
                {
                    return this.result.MemberCount;
                }
                set
                {
                    this.SetMemberCount(value);
                }
            }

            protected override ChatRoomMemberData MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override ChatRoomMemberData.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}

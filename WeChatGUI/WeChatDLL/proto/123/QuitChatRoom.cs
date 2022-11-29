namespace micromsg
{
    using Google.ProtocolBuffers;
   
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

    //
    public sealed class QuitChatRoom : GeneratedMessageLite<QuitChatRoom, QuitChatRoom.Builder>
    {
        private static readonly string[] _quitChatRoomFieldNames = new string[] { "ChatRoomName", "UserName" };
        private static readonly uint[] _quitChatRoomFieldTags = new uint[] { 10, 0x12 };
        private SKBuiltinString_t chatRoomName_;
        public const int ChatRoomNameFieldNumber = 1;
        private static readonly QuitChatRoom defaultInstance = new QuitChatRoom().MakeReadOnly();
        private bool hasChatRoomName;
        private bool hasUserName;
        private int memoizedSerializedSize = -1;
        private SKBuiltinString_t userName_;
        public const int UserNameFieldNumber = 2;

        static QuitChatRoom()
        {
            //object.ReferenceEquals(QuitChatRoom.Descriptor, null);
        }

        private QuitChatRoom()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(QuitChatRoom prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            QuitChatRoom room = obj as QuitChatRoom;
            if (room == null)
            {
                return false;
            }
            if ((this.hasChatRoomName != room.hasChatRoomName) || (this.hasChatRoomName && !this.chatRoomName_.Equals(room.chatRoomName_)))
            {
                return false;
            }
            return ((this.hasUserName == room.hasUserName) && (!this.hasUserName || this.userName_.Equals(room.userName_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasChatRoomName)
            {
                hashCode ^= this.chatRoomName_.GetHashCode();
            }
            if (this.hasUserName)
            {
                hashCode ^= this.userName_.GetHashCode();
            }
            return hashCode;
        }

        private QuitChatRoom MakeReadOnly()
        {
            return this;
        }

        public static QuitChatRoom ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<QuitChatRoom, Builder>.PrintField("ChatRoomName", this.hasChatRoomName, this.chatRoomName_, writer);
            GeneratedMessageLite<QuitChatRoom, Builder>.PrintField("UserName", this.hasUserName, this.userName_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _quitChatRoomFieldNames;
            if (this.hasChatRoomName)
            {
                output.WriteMessage(1, strArray[0], this.ChatRoomName);
            }
            if (this.hasUserName)
            {
                output.WriteMessage(2, strArray[1], this.UserName);
            }
        }

        public SKBuiltinString_t ChatRoomName
        {
            get
            {
                return (this.chatRoomName_ ?? SKBuiltinString_t.DefaultInstance);
            }
        }

        public static QuitChatRoom DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override QuitChatRoom DefaultInstanceForType
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
                if (!this.hasChatRoomName)
                {
                    return false;
                }
                if (!this.hasUserName)
                {
                    return false;
                }
                return true;
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
                    if (this.hasChatRoomName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(1, this.ChatRoomName);
                    }
                    if (this.hasUserName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(2, this.UserName);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override QuitChatRoom ThisMessage
        {
            get
            {
                return this;
            }
        }

        public SKBuiltinString_t UserName
        {
            get
            {
                return (this.userName_ ?? SKBuiltinString_t.DefaultInstance);
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<QuitChatRoom, QuitChatRoom.Builder>
        {
            private QuitChatRoom result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = QuitChatRoom.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(QuitChatRoom cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override QuitChatRoom BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override QuitChatRoom.Builder Clear()
            {
                this.result = QuitChatRoom.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public QuitChatRoom.Builder ClearChatRoomName()
            {
                this.PrepareBuilder();
                this.result.hasChatRoomName = false;
                this.result.chatRoomName_ = null;
                return this;
            }

            public QuitChatRoom.Builder ClearUserName()
            {
                this.PrepareBuilder();
                this.result.hasUserName = false;
                this.result.userName_ = null;
                return this;
            }

            public override QuitChatRoom.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new QuitChatRoom.Builder(this.result);
                }
                return new QuitChatRoom.Builder().MergeFrom(this.result);
            }

            public QuitChatRoom.Builder MergeChatRoomName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasChatRoomName && (this.result.chatRoomName_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.chatRoomName_ = SKBuiltinString_t.CreateBuilder(this.result.chatRoomName_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.chatRoomName_ = value;
                }
                this.result.hasChatRoomName = true;
                return this;
            }

            public override QuitChatRoom.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override QuitChatRoom.Builder MergeFrom(IMessageLite other)
            {
                if (other is QuitChatRoom)
                {
                    return this.MergeFrom((QuitChatRoom) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override QuitChatRoom.Builder MergeFrom(QuitChatRoom other)
            {
                return this;
            }

            public override QuitChatRoom.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(QuitChatRoom._quitChatRoomFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = QuitChatRoom._quitChatRoomFieldTags[index];
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
                            if (this.result.hasChatRoomName)
                            {
                                builder.MergeFrom(this.ChatRoomName);
                            }
                            input.ReadMessage(builder, extensionRegistry);
                            this.ChatRoomName = builder.BuildPartial();
                            continue;
                        }
                        case 0x12:
                        {
                            SKBuiltinString_t.Builder builder2 = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasUserName)
                            {
                                builder2.MergeFrom(this.UserName);
                            }
                            input.ReadMessage(builder2, extensionRegistry);
                            this.UserName = builder2.BuildPartial();
                            continue;
                        }
                    }
                    if (WireFormat.IsEndGroupTag(num))
                    {
                        return this;
                    }
                    this.ParseUnknownField(input, extensionRegistry, num, str);
                }
                return this;
            }

            public QuitChatRoom.Builder MergeUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasUserName && (this.result.userName_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.userName_ = SKBuiltinString_t.CreateBuilder(this.result.userName_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.userName_ = value;
                }
                this.result.hasUserName = true;
                return this;
            }

            private QuitChatRoom PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    QuitChatRoom result = this.result;
                    this.result = new QuitChatRoom();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public QuitChatRoom.Builder SetChatRoomName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasChatRoomName = true;
                this.result.chatRoomName_ = value;
                return this;
            }

            public QuitChatRoom.Builder SetChatRoomName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasChatRoomName = true;
                this.result.chatRoomName_ = builderForValue.Build();
                return this;
            }

            public QuitChatRoom.Builder SetUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasUserName = true;
                this.result.userName_ = value;
                return this;
            }

            public QuitChatRoom.Builder SetUserName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasUserName = true;
                this.result.userName_ = builderForValue.Build();
                return this;
            }

            public SKBuiltinString_t ChatRoomName
            {
                get
                {
                    return this.result.ChatRoomName;
                }
                set
                {
                    this.SetChatRoomName(value);
                }
            }

            public override QuitChatRoom DefaultInstanceForType
            {
                get
                {
                    return QuitChatRoom.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override QuitChatRoom MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override QuitChatRoom.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }

            public SKBuiltinString_t UserName
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
        }
    }
}


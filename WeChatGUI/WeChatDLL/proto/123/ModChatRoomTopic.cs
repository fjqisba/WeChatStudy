namespace micromsg
{
    using Google.ProtocolBuffers;
    
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

   // 
    public sealed class ModChatRoomTopic : GeneratedMessageLite<ModChatRoomTopic, ModChatRoomTopic.Builder>
    {
        private static readonly string[] _modChatRoomTopicFieldNames = new string[] { "ChatRoomName", "ChatRoomTopic" };
        private static readonly uint[] _modChatRoomTopicFieldTags = new uint[] { 10, 0x12 };
        private SKBuiltinString_t chatRoomName_;
        public const int ChatRoomNameFieldNumber = 1;
        private SKBuiltinString_t chatRoomTopic_;
        public const int ChatRoomTopicFieldNumber = 2;
        private static readonly ModChatRoomTopic defaultInstance = new ModChatRoomTopic().MakeReadOnly();
        private bool hasChatRoomName;
        private bool hasChatRoomTopic;
        private int memoizedSerializedSize = -1;

        static ModChatRoomTopic()
        {
           // object.ReferenceEquals(ModChatRoomTopic.Descriptor, null);
        }

        private ModChatRoomTopic()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(ModChatRoomTopic prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            ModChatRoomTopic topic = obj as ModChatRoomTopic;
            if (topic == null)
            {
                return false;
            }
            if ((this.hasChatRoomName != topic.hasChatRoomName) || (this.hasChatRoomName && !this.chatRoomName_.Equals(topic.chatRoomName_)))
            {
                return false;
            }
            return ((this.hasChatRoomTopic == topic.hasChatRoomTopic) && (!this.hasChatRoomTopic || this.chatRoomTopic_.Equals(topic.chatRoomTopic_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasChatRoomName)
            {
                hashCode ^= this.chatRoomName_.GetHashCode();
            }
            if (this.hasChatRoomTopic)
            {
                hashCode ^= this.chatRoomTopic_.GetHashCode();
            }
            return hashCode;
        }

        private ModChatRoomTopic MakeReadOnly()
        {
            return this;
        }

        public static ModChatRoomTopic ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<ModChatRoomTopic, Builder>.PrintField("ChatRoomName", this.hasChatRoomName, this.chatRoomName_, writer);
            GeneratedMessageLite<ModChatRoomTopic, Builder>.PrintField("ChatRoomTopic", this.hasChatRoomTopic, this.chatRoomTopic_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _modChatRoomTopicFieldNames;
            if (this.hasChatRoomName)
            {
                output.WriteMessage(1, strArray[0], this.ChatRoomName);
            }
            if (this.hasChatRoomTopic)
            {
                output.WriteMessage(2, strArray[1], this.ChatRoomTopic);
            }
        }

        public SKBuiltinString_t ChatRoomName
        {
            get
            {
                return (this.chatRoomName_ ?? SKBuiltinString_t.DefaultInstance);
            }
        }

        public SKBuiltinString_t ChatRoomTopic
        {
            get
            {
                return (this.chatRoomTopic_ ?? SKBuiltinString_t.DefaultInstance);
            }
        }

        public static ModChatRoomTopic DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override ModChatRoomTopic DefaultInstanceForType
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
                if (!this.hasChatRoomTopic)
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
                    if (this.hasChatRoomTopic)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(2, this.ChatRoomTopic);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override ModChatRoomTopic ThisMessage
        {
            get
            {
                return this;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<ModChatRoomTopic, ModChatRoomTopic.Builder>
        {
            private ModChatRoomTopic result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = ModChatRoomTopic.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(ModChatRoomTopic cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override ModChatRoomTopic BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override ModChatRoomTopic.Builder Clear()
            {
                this.result = ModChatRoomTopic.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public ModChatRoomTopic.Builder ClearChatRoomName()
            {
                this.PrepareBuilder();
                this.result.hasChatRoomName = false;
                this.result.chatRoomName_ = null;
                return this;
            }

            public ModChatRoomTopic.Builder ClearChatRoomTopic()
            {
                this.PrepareBuilder();
                this.result.hasChatRoomTopic = false;
                this.result.chatRoomTopic_ = null;
                return this;
            }

            public override ModChatRoomTopic.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new ModChatRoomTopic.Builder(this.result);
                }
                return new ModChatRoomTopic.Builder().MergeFrom(this.result);
            }

            public ModChatRoomTopic.Builder MergeChatRoomName(SKBuiltinString_t value)
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

            public ModChatRoomTopic.Builder MergeChatRoomTopic(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasChatRoomTopic && (this.result.chatRoomTopic_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.chatRoomTopic_ = SKBuiltinString_t.CreateBuilder(this.result.chatRoomTopic_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.chatRoomTopic_ = value;
                }
                this.result.hasChatRoomTopic = true;
                return this;
            }

            public override ModChatRoomTopic.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override ModChatRoomTopic.Builder MergeFrom(IMessageLite other)
            {
                if (other is ModChatRoomTopic)
                {
                    return this.MergeFrom((ModChatRoomTopic) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override ModChatRoomTopic.Builder MergeFrom(ModChatRoomTopic other)
            {
                return this;
            }

            public override ModChatRoomTopic.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(ModChatRoomTopic._modChatRoomTopicFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = ModChatRoomTopic._modChatRoomTopicFieldTags[index];
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
                            if (this.result.hasChatRoomTopic)
                            {
                                builder2.MergeFrom(this.ChatRoomTopic);
                            }
                            input.ReadMessage(builder2, extensionRegistry);
                            this.ChatRoomTopic = builder2.BuildPartial();
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

            private ModChatRoomTopic PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    ModChatRoomTopic result = this.result;
                    this.result = new ModChatRoomTopic();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public ModChatRoomTopic.Builder SetChatRoomName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasChatRoomName = true;
                this.result.chatRoomName_ = value;
                return this;
            }

            public ModChatRoomTopic.Builder SetChatRoomName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasChatRoomName = true;
                this.result.chatRoomName_ = builderForValue.Build();
                return this;
            }

            public ModChatRoomTopic.Builder SetChatRoomTopic(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasChatRoomTopic = true;
                this.result.chatRoomTopic_ = value;
                return this;
            }

            public ModChatRoomTopic.Builder SetChatRoomTopic(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasChatRoomTopic = true;
                this.result.chatRoomTopic_ = builderForValue.Build();
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

            public SKBuiltinString_t ChatRoomTopic
            {
                get
                {
                    return this.result.ChatRoomTopic;
                }
                set
                {
                    this.SetChatRoomTopic(value);
                }
            }

            public override ModChatRoomTopic DefaultInstanceForType
            {
                get
                {
                    return ModChatRoomTopic.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override ModChatRoomTopic MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override ModChatRoomTopic.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


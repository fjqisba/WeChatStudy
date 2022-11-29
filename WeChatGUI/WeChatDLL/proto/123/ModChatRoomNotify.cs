namespace micromsg
{
    using Google.ProtocolBuffers;
    
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

   // 
    public sealed class ModChatRoomNotify : GeneratedMessageLite<ModChatRoomNotify, ModChatRoomNotify.Builder>
    {
        private static readonly string[] _modChatRoomNotifyFieldNames = new string[] { "ChatRoomName", "Status" };
        private static readonly uint[] _modChatRoomNotifyFieldTags = new uint[] { 10, 0x10 };
        private SKBuiltinString_t chatRoomName_;
        public const int ChatRoomNameFieldNumber = 1;
        private static readonly ModChatRoomNotify defaultInstance = new ModChatRoomNotify().MakeReadOnly();
        private bool hasChatRoomName;
        private bool hasStatus;
        private int memoizedSerializedSize = -1;
        private uint status_;
        public const int StatusFieldNumber = 2;

        static ModChatRoomNotify()
        {
            //object.ReferenceEquals(ModChatRoomNotify.Descriptor, null);
        }

        private ModChatRoomNotify()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(ModChatRoomNotify prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            ModChatRoomNotify notify = obj as ModChatRoomNotify;
            if (notify == null)
            {
                return false;
            }
            if ((this.hasChatRoomName != notify.hasChatRoomName) || (this.hasChatRoomName && !this.chatRoomName_.Equals(notify.chatRoomName_)))
            {
                return false;
            }
            return ((this.hasStatus == notify.hasStatus) && (!this.hasStatus || this.status_.Equals(notify.status_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasChatRoomName)
            {
                hashCode ^= this.chatRoomName_.GetHashCode();
            }
            if (this.hasStatus)
            {
                hashCode ^= this.status_.GetHashCode();
            }
            return hashCode;
        }

        private ModChatRoomNotify MakeReadOnly()
        {
            return this;
        }

        public static ModChatRoomNotify ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<ModChatRoomNotify, Builder>.PrintField("ChatRoomName", this.hasChatRoomName, this.chatRoomName_, writer);
            GeneratedMessageLite<ModChatRoomNotify, Builder>.PrintField("Status", this.hasStatus, this.status_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _modChatRoomNotifyFieldNames;
            if (this.hasChatRoomName)
            {
                output.WriteMessage(1, strArray[0], this.ChatRoomName);
            }
            if (this.hasStatus)
            {
                output.WriteUInt32(2, strArray[1], this.Status);
            }
        }

        public SKBuiltinString_t ChatRoomName
        {
            get
            {
                return (this.chatRoomName_ ?? SKBuiltinString_t.DefaultInstance);
            }
        }

        public static ModChatRoomNotify DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override ModChatRoomNotify DefaultInstanceForType
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
                if (!this.hasStatus)
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
                    if (this.hasStatus)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(2, this.Status);
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

        protected override ModChatRoomNotify ThisMessage
        {
            get
            {
                return this;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<ModChatRoomNotify, ModChatRoomNotify.Builder>
        {
            private ModChatRoomNotify result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = ModChatRoomNotify.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(ModChatRoomNotify cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override ModChatRoomNotify BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override ModChatRoomNotify.Builder Clear()
            {
                this.result = ModChatRoomNotify.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public ModChatRoomNotify.Builder ClearChatRoomName()
            {
                this.PrepareBuilder();
                this.result.hasChatRoomName = false;
                this.result.chatRoomName_ = null;
                return this;
            }

            public ModChatRoomNotify.Builder ClearStatus()
            {
                this.PrepareBuilder();
                this.result.hasStatus = false;
                this.result.status_ = 0;
                return this;
            }

            public override ModChatRoomNotify.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new ModChatRoomNotify.Builder(this.result);
                }
                return new ModChatRoomNotify.Builder().MergeFrom(this.result);
            }

            public ModChatRoomNotify.Builder MergeChatRoomName(SKBuiltinString_t value)
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

            public override ModChatRoomNotify.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override ModChatRoomNotify.Builder MergeFrom(IMessageLite other)
            {
                if (other is ModChatRoomNotify)
                {
                    return this.MergeFrom((ModChatRoomNotify) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override ModChatRoomNotify.Builder MergeFrom(ModChatRoomNotify other)
            {
                return this;
            }

            public override ModChatRoomNotify.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(ModChatRoomNotify._modChatRoomNotifyFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = ModChatRoomNotify._modChatRoomNotifyFieldTags[index];
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
                        case 0x10:
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
                    this.result.hasStatus = input.ReadUInt32(ref this.result.status_);
                }
                return this;
            }

            private ModChatRoomNotify PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    ModChatRoomNotify result = this.result;
                    this.result = new ModChatRoomNotify();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public ModChatRoomNotify.Builder SetChatRoomName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasChatRoomName = true;
                this.result.chatRoomName_ = value;
                return this;
            }

            public ModChatRoomNotify.Builder SetChatRoomName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasChatRoomName = true;
                this.result.chatRoomName_ = builderForValue.Build();
                return this;
            }

            public ModChatRoomNotify.Builder SetStatus(uint value)
            {
                this.PrepareBuilder();
                this.result.hasStatus = true;
                this.result.status_ = value;
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

            public override ModChatRoomNotify DefaultInstanceForType
            {
                get
                {
                    return ModChatRoomNotify.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override ModChatRoomNotify MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
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

            protected override ModChatRoomNotify.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


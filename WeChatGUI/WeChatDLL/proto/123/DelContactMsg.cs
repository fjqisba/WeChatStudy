namespace micromsg
{
    using Google.ProtocolBuffers;
    
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

    
    public sealed class DelContactMsg : GeneratedMessageLite<DelContactMsg, DelContactMsg.Builder>
    {
        private static readonly string[] _delContactMsgFieldNames = new string[] { "MaxMsgId", "UserName" };
        private static readonly uint[] _delContactMsgFieldTags = new uint[] { 0x10, 10 };
        private static readonly DelContactMsg defaultInstance = new DelContactMsg().MakeReadOnly();
        private bool hasMaxMsgId;
        private bool hasUserName;
        private int maxMsgId_;
        public const int MaxMsgIdFieldNumber = 2;
        private int memoizedSerializedSize = -1;
        private SKBuiltinString_t userName_;
        public const int UserNameFieldNumber = 1;

        static DelContactMsg()
        {
            //object.ReferenceEquals(DelContactMsg.Descriptor, null);
        }

        private DelContactMsg()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(DelContactMsg prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            DelContactMsg msg = obj as DelContactMsg;
            if (msg == null)
            {
                return false;
            }
            if ((this.hasUserName != msg.hasUserName) || (this.hasUserName && !this.userName_.Equals(msg.userName_)))
            {
                return false;
            }
            return ((this.hasMaxMsgId == msg.hasMaxMsgId) && (!this.hasMaxMsgId || this.maxMsgId_.Equals(msg.maxMsgId_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasUserName)
            {
                hashCode ^= this.userName_.GetHashCode();
            }
            if (this.hasMaxMsgId)
            {
                hashCode ^= this.maxMsgId_.GetHashCode();
            }
            return hashCode;
        }

        private DelContactMsg MakeReadOnly()
        {
            return this;
        }

        public static DelContactMsg ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<DelContactMsg, Builder>.PrintField("UserName", this.hasUserName, this.userName_, writer);
            GeneratedMessageLite<DelContactMsg, Builder>.PrintField("MaxMsgId", this.hasMaxMsgId, this.maxMsgId_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _delContactMsgFieldNames;
            if (this.hasUserName)
            {
                output.WriteMessage(1, strArray[1], this.UserName);
            }
            if (this.hasMaxMsgId)
            {
                output.WriteInt32(2, strArray[0], this.MaxMsgId);
            }
        }

        public static DelContactMsg DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override DelContactMsg DefaultInstanceForType
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
                if (!this.hasUserName)
                {
                    return false;
                }
                if (!this.hasMaxMsgId)
                {
                    return false;
                }
                return true;
            }
        }

        public int MaxMsgId
        {
            get
            {
                return this.maxMsgId_;
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
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(1, this.UserName);
                    }
                    if (this.hasMaxMsgId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(2, this.MaxMsgId);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override DelContactMsg ThisMessage
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

        
        public sealed class Builder : GeneratedBuilderLite<DelContactMsg, DelContactMsg.Builder>
        {
            private DelContactMsg result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = DelContactMsg.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(DelContactMsg cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override DelContactMsg BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override DelContactMsg.Builder Clear()
            {
                this.result = DelContactMsg.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public DelContactMsg.Builder ClearMaxMsgId()
            {
                this.PrepareBuilder();
                this.result.hasMaxMsgId = false;
                this.result.maxMsgId_ = 0;
                return this;
            }

            public DelContactMsg.Builder ClearUserName()
            {
                this.PrepareBuilder();
                this.result.hasUserName = false;
                this.result.userName_ = null;
                return this;
            }

            public override DelContactMsg.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new DelContactMsg.Builder(this.result);
                }
                return new DelContactMsg.Builder().MergeFrom(this.result);
            }

            public override DelContactMsg.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override DelContactMsg.Builder MergeFrom(IMessageLite other)
            {
                if (other is DelContactMsg)
                {
                    return this.MergeFrom((DelContactMsg) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override DelContactMsg.Builder MergeFrom(DelContactMsg other)
            {
                return this;
            }

            public override DelContactMsg.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(DelContactMsg._delContactMsgFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = DelContactMsg._delContactMsgFieldTags[index];
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
                            if (this.result.hasUserName)
                            {
                                builder.MergeFrom(this.UserName);
                            }
                            input.ReadMessage(builder, extensionRegistry);
                            this.UserName = builder.BuildPartial();
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
                    this.result.hasMaxMsgId = input.ReadInt32(ref this.result.maxMsgId_);
                }
                return this;
            }

            public DelContactMsg.Builder MergeUserName(SKBuiltinString_t value)
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

            private DelContactMsg PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    DelContactMsg result = this.result;
                    this.result = new DelContactMsg();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public DelContactMsg.Builder SetMaxMsgId(int value)
            {
                this.PrepareBuilder();
                this.result.hasMaxMsgId = true;
                this.result.maxMsgId_ = value;
                return this;
            }

            public DelContactMsg.Builder SetUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasUserName = true;
                this.result.userName_ = value;
                return this;
            }

            public DelContactMsg.Builder SetUserName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasUserName = true;
                this.result.userName_ = builderForValue.Build();
                return this;
            }

            public override DelContactMsg DefaultInstanceForType
            {
                get
                {
                    return DelContactMsg.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            public int MaxMsgId
            {
                get
                {
                    return this.result.MaxMsgId;
                }
                set
                {
                    this.SetMaxMsgId(value);
                }
            }

            protected override DelContactMsg MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override DelContactMsg.Builder ThisBuilder
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


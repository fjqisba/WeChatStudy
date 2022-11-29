namespace micromsg
{
    using Google.ProtocolBuffers;
   
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

   
    public sealed class DelChatContact : GeneratedMessageLite<DelChatContact, DelChatContact.Builder>
    {
        private static readonly string[] _delChatContactFieldNames = new string[] { "UserName" };
        private static readonly uint[] _delChatContactFieldTags = new uint[] { 10 };
        private static readonly DelChatContact defaultInstance = new DelChatContact().MakeReadOnly();
        private bool hasUserName;
        private int memoizedSerializedSize = -1;
        private SKBuiltinString_t userName_;
        public const int UserNameFieldNumber = 1;

        static DelChatContact()
        {
            //object.ReferenceEquals(DelChatContact.Descriptor, null);
        }

        private DelChatContact()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(DelChatContact prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            DelChatContact contact = obj as DelChatContact;
            if (contact == null)
            {
                return false;
            }
            return ((this.hasUserName == contact.hasUserName) && (!this.hasUserName || this.userName_.Equals(contact.userName_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasUserName)
            {
                hashCode ^= this.userName_.GetHashCode();
            }
            return hashCode;
        }

        private DelChatContact MakeReadOnly()
        {
            return this;
        }

        public static DelChatContact ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<DelChatContact, Builder>.PrintField("UserName", this.hasUserName, this.userName_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _delChatContactFieldNames;
            if (this.hasUserName)
            {
                output.WriteMessage(1, strArray[0], this.UserName);
            }
        }

        public static DelChatContact DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override DelChatContact DefaultInstanceForType
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
                    if (this.hasUserName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(1, this.UserName);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override DelChatContact ThisMessage
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

        
        public sealed class Builder : GeneratedBuilderLite<DelChatContact, DelChatContact.Builder>
        {
            private DelChatContact result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = DelChatContact.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(DelChatContact cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override DelChatContact BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override DelChatContact.Builder Clear()
            {
                this.result = DelChatContact.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public DelChatContact.Builder ClearUserName()
            {
                this.PrepareBuilder();
                this.result.hasUserName = false;
                this.result.userName_ = null;
                return this;
            }

            public override DelChatContact.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new DelChatContact.Builder(this.result);
                }
                return new DelChatContact.Builder().MergeFrom(this.result);
            }

            public override DelChatContact.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override DelChatContact.Builder MergeFrom(IMessageLite other)
            {
                if (other is DelChatContact)
                {
                    return this.MergeFrom((DelChatContact) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override DelChatContact.Builder MergeFrom(DelChatContact other)
            {
                return this;
            }

            public override DelChatContact.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(DelChatContact._delChatContactFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = DelChatContact._delChatContactFieldTags[index];
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
                    }
                    if (WireFormat.IsEndGroupTag(num))
                    {
                        return this;
                    }
                    this.ParseUnknownField(input, extensionRegistry, num, str);
                }
                return this;
            }

            public DelChatContact.Builder MergeUserName(SKBuiltinString_t value)
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

            private DelChatContact PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    DelChatContact result = this.result;
                    this.result = new DelChatContact();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public DelChatContact.Builder SetUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasUserName = true;
                this.result.userName_ = value;
                return this;
            }

            public DelChatContact.Builder SetUserName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasUserName = true;
                this.result.userName_ = builderForValue.Build();
                return this;
            }

            public override DelChatContact DefaultInstanceForType
            {
                get
                {
                    return DelChatContact.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override DelChatContact MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override DelChatContact.Builder ThisBuilder
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


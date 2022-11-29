namespace micromsg
{
    using Google.ProtocolBuffers;
    
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

    //
    public sealed class DelContact : GeneratedMessageLite<DelContact, DelContact.Builder>
    {
        private static readonly string[] _delContactFieldNames = new string[] { "UserName" };
        private static readonly uint[] _delContactFieldTags = new uint[] { 10 };
        private static readonly DelContact defaultInstance = new DelContact().MakeReadOnly();
        private bool hasUserName;
        private int memoizedSerializedSize = -1;
        private SKBuiltinString_t userName_;
        public const int UserNameFieldNumber = 1;

        static DelContact()
        {
            //object.ReferenceEquals(DelContact.Descriptor, null);
        }

        private DelContact()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(DelContact prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            DelContact contact = obj as DelContact;
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

        private DelContact MakeReadOnly()
        {
            return this;
        }

        public static DelContact ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<DelContact, Builder>.PrintField("UserName", this.hasUserName, this.userName_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _delContactFieldNames;
            if (this.hasUserName)
            {
                output.WriteMessage(1, strArray[0], this.UserName);
            }
        }

        public static DelContact DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override DelContact DefaultInstanceForType
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

        protected override DelContact ThisMessage
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

        
        public sealed class Builder : GeneratedBuilderLite<DelContact, DelContact.Builder>
        {
            private DelContact result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = DelContact.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(DelContact cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override DelContact BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override DelContact.Builder Clear()
            {
                this.result = DelContact.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public DelContact.Builder ClearUserName()
            {
                this.PrepareBuilder();
                this.result.hasUserName = false;
                this.result.userName_ = null;
                return this;
            }

            public override DelContact.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new DelContact.Builder(this.result);
                }
                return new DelContact.Builder().MergeFrom(this.result);
            }

            public override DelContact.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override DelContact.Builder MergeFrom(IMessageLite other)
            {
                if (other is DelContact)
                {
                    return this.MergeFrom((DelContact) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override DelContact.Builder MergeFrom(DelContact other)
            {
                return this;
            }

            public override DelContact.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(DelContact._delContactFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = DelContact._delContactFieldTags[index];
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

            public DelContact.Builder MergeUserName(SKBuiltinString_t value)
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

            private DelContact PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    DelContact result = this.result;
                    this.result = new DelContact();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public DelContact.Builder SetUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasUserName = true;
                this.result.userName_ = value;
                return this;
            }

            public DelContact.Builder SetUserName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasUserName = true;
                this.result.userName_ = builderForValue.Build();
                return this;
            }

            public override DelContact DefaultInstanceForType
            {
                get
                {
                    return DelContact.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override DelContact MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override DelContact.Builder ThisBuilder
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


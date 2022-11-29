namespace micromsg
{
    using Google.ProtocolBuffers;
    
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

    //
    public sealed class DelUserDomainEmail : GeneratedMessageLite<DelUserDomainEmail, DelUserDomainEmail.Builder>
    {
        private static readonly string[] _delUserDomainEmailFieldNames = new string[] { "Email", "UserName" };
        private static readonly uint[] _delUserDomainEmailFieldTags = new uint[] { 0x12, 10 };
        private static readonly DelUserDomainEmail defaultInstance = new DelUserDomainEmail().MakeReadOnly();
        private SKBuiltinString_t email_;
        public const int EmailFieldNumber = 2;
        private bool hasEmail;
        private bool hasUserName;
        private int memoizedSerializedSize = -1;
        private SKBuiltinString_t userName_;
        public const int UserNameFieldNumber = 1;

        static DelUserDomainEmail()
        {
            //object.ReferenceEquals(DelUserDomainEmail.Descriptor, null);
        }

        private DelUserDomainEmail()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(DelUserDomainEmail prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            DelUserDomainEmail email = obj as DelUserDomainEmail;
            if (email == null)
            {
                return false;
            }
            if ((this.hasUserName != email.hasUserName) || (this.hasUserName && !this.userName_.Equals(email.userName_)))
            {
                return false;
            }
            return ((this.hasEmail == email.hasEmail) && (!this.hasEmail || this.email_.Equals(email.email_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasUserName)
            {
                hashCode ^= this.userName_.GetHashCode();
            }
            if (this.hasEmail)
            {
                hashCode ^= this.email_.GetHashCode();
            }
            return hashCode;
        }

        private DelUserDomainEmail MakeReadOnly()
        {
            return this;
        }

        public static DelUserDomainEmail ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<DelUserDomainEmail, Builder>.PrintField("UserName", this.hasUserName, this.userName_, writer);
            GeneratedMessageLite<DelUserDomainEmail, Builder>.PrintField("Email", this.hasEmail, this.email_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _delUserDomainEmailFieldNames;
            if (this.hasUserName)
            {
                output.WriteMessage(1, strArray[1], this.UserName);
            }
            if (this.hasEmail)
            {
                output.WriteMessage(2, strArray[0], this.Email);
            }
        }

        public static DelUserDomainEmail DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override DelUserDomainEmail DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public SKBuiltinString_t Email
        {
            get
            {
                return (this.email_ ?? SKBuiltinString_t.DefaultInstance);
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
                if (!this.hasEmail)
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
                    if (this.hasEmail)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(2, this.Email);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override DelUserDomainEmail ThisMessage
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

        
        public sealed class Builder : GeneratedBuilderLite<DelUserDomainEmail, DelUserDomainEmail.Builder>
        {
            private DelUserDomainEmail result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = DelUserDomainEmail.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(DelUserDomainEmail cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override DelUserDomainEmail BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override DelUserDomainEmail.Builder Clear()
            {
                this.result = DelUserDomainEmail.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public DelUserDomainEmail.Builder ClearEmail()
            {
                this.PrepareBuilder();
                this.result.hasEmail = false;
                this.result.email_ = null;
                return this;
            }

            public DelUserDomainEmail.Builder ClearUserName()
            {
                this.PrepareBuilder();
                this.result.hasUserName = false;
                this.result.userName_ = null;
                return this;
            }

            public override DelUserDomainEmail.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new DelUserDomainEmail.Builder(this.result);
                }
                return new DelUserDomainEmail.Builder().MergeFrom(this.result);
            }

            public DelUserDomainEmail.Builder MergeEmail(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasEmail && (this.result.email_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.email_ = SKBuiltinString_t.CreateBuilder(this.result.email_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.email_ = value;
                }
                this.result.hasEmail = true;
                return this;
            }

            public override DelUserDomainEmail.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override DelUserDomainEmail.Builder MergeFrom(IMessageLite other)
            {
                if (other is DelUserDomainEmail)
                {
                    return this.MergeFrom((DelUserDomainEmail) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override DelUserDomainEmail.Builder MergeFrom(DelUserDomainEmail other)
            {
                return this;
            }

            public override DelUserDomainEmail.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(DelUserDomainEmail._delUserDomainEmailFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = DelUserDomainEmail._delUserDomainEmailFieldTags[index];
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
                        case 0x12:
                        {
                            SKBuiltinString_t.Builder builder2 = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasEmail)
                            {
                                builder2.MergeFrom(this.Email);
                            }
                            input.ReadMessage(builder2, extensionRegistry);
                            this.Email = builder2.BuildPartial();
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

            public DelUserDomainEmail.Builder MergeUserName(SKBuiltinString_t value)
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

            private DelUserDomainEmail PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    DelUserDomainEmail result = this.result;
                    this.result = new DelUserDomainEmail();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public DelUserDomainEmail.Builder SetEmail(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasEmail = true;
                this.result.email_ = value;
                return this;
            }

            public DelUserDomainEmail.Builder SetEmail(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasEmail = true;
                this.result.email_ = builderForValue.Build();
                return this;
            }

            public DelUserDomainEmail.Builder SetUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasUserName = true;
                this.result.userName_ = value;
                return this;
            }

            public DelUserDomainEmail.Builder SetUserName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasUserName = true;
                this.result.userName_ = builderForValue.Build();
                return this;
            }

            public override DelUserDomainEmail DefaultInstanceForType
            {
                get
                {
                    return DelUserDomainEmail.DefaultInstance;
                }
            }

            public SKBuiltinString_t Email
            {
                get
                {
                    return this.result.Email;
                }
                set
                {
                    this.SetEmail(value);
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override DelUserDomainEmail MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override DelUserDomainEmail.Builder ThisBuilder
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


namespace micromsg
{
    using Google.ProtocolBuffers;
   
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

    //
    public sealed class VerifyUser : GeneratedMessageLite<VerifyUser, VerifyUser.Builder>
    {
        private static readonly string[] _verifyUserFieldNames = new string[] { "Value", "VerifyUserTicket" };
        private static readonly uint[] _verifyUserFieldTags = new uint[] { 10, 0x12 };
        private static readonly VerifyUser defaultInstance = new VerifyUser().MakeReadOnly();
        private bool hasValue;
        private bool hasVerifyUserTicket;
        private int memoizedSerializedSize = -1;
        private string value_ = "";
        public const int ValueFieldNumber = 1;
        private string verifyUserTicket_ = "";
        public const int VerifyUserTicketFieldNumber = 2;

        static VerifyUser()
        {
            //object.ReferenceEquals(VerifyUser.Descriptor, null);
        }

        private VerifyUser()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(VerifyUser prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            VerifyUser user = obj as VerifyUser;
            if (user == null)
            {
                return false;
            }
            if ((this.hasValue != user.hasValue) || (this.hasValue && !this.value_.Equals(user.value_)))
            {
                return false;
            }
            return ((this.hasVerifyUserTicket == user.hasVerifyUserTicket) && (!this.hasVerifyUserTicket || this.verifyUserTicket_.Equals(user.verifyUserTicket_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasValue)
            {
                hashCode ^= this.value_.GetHashCode();
            }
            if (this.hasVerifyUserTicket)
            {
                hashCode ^= this.verifyUserTicket_.GetHashCode();
            }
            return hashCode;
        }

        private VerifyUser MakeReadOnly()
        {
            return this;
        }

        public static VerifyUser ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<VerifyUser, Builder>.PrintField("Value", this.hasValue, this.value_, writer);
            GeneratedMessageLite<VerifyUser, Builder>.PrintField("VerifyUserTicket", this.hasVerifyUserTicket, this.verifyUserTicket_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _verifyUserFieldNames;
            if (this.hasValue)
            {
                output.WriteString(1, strArray[0], this.Value);
            }
            if (this.hasVerifyUserTicket)
            {
                output.WriteString(2, strArray[1], this.VerifyUserTicket);
            }
        }

        public static VerifyUser DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override VerifyUser DefaultInstanceForType
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
                    if (this.hasValue)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(1, this.Value);
                    }
                    if (this.hasVerifyUserTicket)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(2, this.VerifyUserTicket);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override VerifyUser ThisMessage
        {
            get
            {
                return this;
            }
        }

        public string Value
        {
            get
            {
                return this.value_;
            }
        }

        public string VerifyUserTicket
        {
            get
            {
                return this.verifyUserTicket_;
            }
        }

        //
        public sealed class Builder : GeneratedBuilderLite<VerifyUser, VerifyUser.Builder>
        {
            private VerifyUser result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = VerifyUser.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(VerifyUser cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override VerifyUser BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override VerifyUser.Builder Clear()
            {
                this.result = VerifyUser.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public VerifyUser.Builder ClearValue()
            {
                this.PrepareBuilder();
                this.result.hasValue = false;
                this.result.value_ = "";
                return this;
            }

            public VerifyUser.Builder ClearVerifyUserTicket()
            {
                this.PrepareBuilder();
                this.result.hasVerifyUserTicket = false;
                this.result.verifyUserTicket_ = "";
                return this;
            }

            public override VerifyUser.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new VerifyUser.Builder(this.result);
                }
                return new VerifyUser.Builder().MergeFrom(this.result);
            }

            public override VerifyUser.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override VerifyUser.Builder MergeFrom(IMessageLite other)
            {
                if (other is VerifyUser)
                {
                    return this.MergeFrom((VerifyUser) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override VerifyUser.Builder MergeFrom(VerifyUser other)
            {
                return this;
            }

            public override VerifyUser.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(VerifyUser._verifyUserFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = VerifyUser._verifyUserFieldTags[index];
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
                            this.result.hasValue = input.ReadString(ref this.result.value_);
                            continue;
                        }
                        case 0x12:
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
                    this.result.hasVerifyUserTicket = input.ReadString(ref this.result.verifyUserTicket_);
                }
                return this;
            }

            private VerifyUser PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    VerifyUser result = this.result;
                    this.result = new VerifyUser();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public VerifyUser.Builder SetValue(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasValue = true;
                this.result.value_ = value;
                return this;
            }

            public VerifyUser.Builder SetVerifyUserTicket(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasVerifyUserTicket = true;
                this.result.verifyUserTicket_ = value;
                return this;
            }

            public override VerifyUser DefaultInstanceForType
            {
                get
                {
                    return VerifyUser.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override VerifyUser MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override VerifyUser.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }

            public string Value
            {
                get
                {
                    return this.result.Value;
                }
                set
                {
                    this.SetValue(value);
                }
            }

            public string VerifyUserTicket
            {
                get
                {
                    return this.result.VerifyUserTicket;
                }
                set
                {
                    this.SetVerifyUserTicket(value);
                }
            }
        }
    }
}


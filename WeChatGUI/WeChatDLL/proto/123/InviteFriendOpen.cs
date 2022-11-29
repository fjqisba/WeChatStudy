namespace micromsg
{
    using Google.ProtocolBuffers;
    
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

    //
    public sealed class InviteFriendOpen : GeneratedMessageLite<InviteFriendOpen, InviteFriendOpen.Builder>
    {
        private static readonly string[] _inviteFriendOpenFieldNames = new string[] { "FriendType", "UserName" };
        private static readonly uint[] _inviteFriendOpenFieldTags = new uint[] { 0x10, 10 };
        private static readonly InviteFriendOpen defaultInstance = new InviteFriendOpen().MakeReadOnly();
        private uint friendType_;
        public const int FriendTypeFieldNumber = 2;
        private bool hasFriendType;
        private bool hasUserName;
        private int memoizedSerializedSize = -1;
        private string userName_ = "";
        public const int UserNameFieldNumber = 1;

        static InviteFriendOpen()
        {
           // object.ReferenceEquals(InviteFriendOpen.Descriptor, null);
        }

        private InviteFriendOpen()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(InviteFriendOpen prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            InviteFriendOpen open = obj as InviteFriendOpen;
            if (open == null)
            {
                return false;
            }
            if ((this.hasUserName != open.hasUserName) || (this.hasUserName && !this.userName_.Equals(open.userName_)))
            {
                return false;
            }
            return ((this.hasFriendType == open.hasFriendType) && (!this.hasFriendType || this.friendType_.Equals(open.friendType_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasUserName)
            {
                hashCode ^= this.userName_.GetHashCode();
            }
            if (this.hasFriendType)
            {
                hashCode ^= this.friendType_.GetHashCode();
            }
            return hashCode;
        }

        private InviteFriendOpen MakeReadOnly()
        {
            return this;
        }

        public static InviteFriendOpen ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<InviteFriendOpen, Builder>.PrintField("UserName", this.hasUserName, this.userName_, writer);
            GeneratedMessageLite<InviteFriendOpen, Builder>.PrintField("FriendType", this.hasFriendType, this.friendType_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _inviteFriendOpenFieldNames;
            if (this.hasUserName)
            {
                output.WriteString(1, strArray[1], this.UserName);
            }
            if (this.hasFriendType)
            {
                output.WriteUInt32(2, strArray[0], this.FriendType);
            }
        }

        public static InviteFriendOpen DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override InviteFriendOpen DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public uint FriendType
        {
            get
            {
                return this.friendType_;
            }
        }

        public override bool IsInitialized
        {
            get
            {
                if (!this.hasFriendType)
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
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(1, this.UserName);
                    }
                    if (this.hasFriendType)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(2, this.FriendType);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override InviteFriendOpen ThisMessage
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

        
        public sealed class Builder : GeneratedBuilderLite<InviteFriendOpen, InviteFriendOpen.Builder>
        {
            private InviteFriendOpen result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = InviteFriendOpen.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(InviteFriendOpen cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override InviteFriendOpen BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override InviteFriendOpen.Builder Clear()
            {
                this.result = InviteFriendOpen.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public InviteFriendOpen.Builder ClearFriendType()
            {
                this.PrepareBuilder();
                this.result.hasFriendType = false;
                this.result.friendType_ = 0;
                return this;
            }

            public InviteFriendOpen.Builder ClearUserName()
            {
                this.PrepareBuilder();
                this.result.hasUserName = false;
                this.result.userName_ = "";
                return this;
            }

            public override InviteFriendOpen.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new InviteFriendOpen.Builder(this.result);
                }
                return new InviteFriendOpen.Builder().MergeFrom(this.result);
            }

            public override InviteFriendOpen.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override InviteFriendOpen.Builder MergeFrom(IMessageLite other)
            {
                if (other is InviteFriendOpen)
                {
                    return this.MergeFrom((InviteFriendOpen) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override InviteFriendOpen.Builder MergeFrom(InviteFriendOpen other)
            {
                return this;
            }

            public override InviteFriendOpen.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(InviteFriendOpen._inviteFriendOpenFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = InviteFriendOpen._inviteFriendOpenFieldTags[index];
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
                    this.result.hasFriendType = input.ReadUInt32(ref this.result.friendType_);
                }
                return this;
            }

            private InviteFriendOpen PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    InviteFriendOpen result = this.result;
                    this.result = new InviteFriendOpen();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public InviteFriendOpen.Builder SetFriendType(uint value)
            {
                this.PrepareBuilder();
                this.result.hasFriendType = true;
                this.result.friendType_ = value;
                return this;
            }

            public InviteFriendOpen.Builder SetUserName(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasUserName = true;
                this.result.userName_ = value;
                return this;
            }

            public override InviteFriendOpen DefaultInstanceForType
            {
                get
                {
                    return InviteFriendOpen.DefaultInstance;
                }
            }

            public uint FriendType
            {
                get
                {
                    return this.result.FriendType;
                }
                set
                {
                    this.SetFriendType(value);
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override InviteFriendOpen MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override InviteFriendOpen.Builder ThisBuilder
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
        }
    }
}


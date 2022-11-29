namespace micromsg
{
    using Google.ProtocolBuffers;
   
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

    //
    public sealed class QContact : GeneratedMessageLite<QContact, QContact.Builder>
    {
        private static readonly string[] _qContactFieldNames = new string[] { "DisplayName", "ExtInfoSeq", "ImgUpdateSeq", "UserName" };
        private static readonly uint[] _qContactFieldTags = new uint[] { 0x12, 0x18, 0x20, 10 };
        private static readonly QContact defaultInstance = new QContact().MakeReadOnly();
        private string displayName_ = "";
        public const int DisplayNameFieldNumber = 2;
        private uint extInfoSeq_;
        public const int ExtInfoSeqFieldNumber = 3;
        private bool hasDisplayName;
        private bool hasExtInfoSeq;
        private bool hasImgUpdateSeq;
        private bool hasUserName;
        private uint imgUpdateSeq_;
        public const int ImgUpdateSeqFieldNumber = 4;
        private int memoizedSerializedSize = -1;
        private string userName_ = "";
        public const int UserNameFieldNumber = 1;

        static QContact()
        {
            //object.ReferenceEquals(QContact.Descriptor, null);
        }

        private QContact()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(QContact prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            QContact contact = obj as QContact;
            if (contact == null)
            {
                return false;
            }
            if ((this.hasUserName != contact.hasUserName) || (this.hasUserName && !this.userName_.Equals(contact.userName_)))
            {
                return false;
            }
            if ((this.hasDisplayName != contact.hasDisplayName) || (this.hasDisplayName && !this.displayName_.Equals(contact.displayName_)))
            {
                return false;
            }
            if ((this.hasExtInfoSeq != contact.hasExtInfoSeq) || (this.hasExtInfoSeq && !this.extInfoSeq_.Equals(contact.extInfoSeq_)))
            {
                return false;
            }
            return ((this.hasImgUpdateSeq == contact.hasImgUpdateSeq) && (!this.hasImgUpdateSeq || this.imgUpdateSeq_.Equals(contact.imgUpdateSeq_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasUserName)
            {
                hashCode ^= this.userName_.GetHashCode();
            }
            if (this.hasDisplayName)
            {
                hashCode ^= this.displayName_.GetHashCode();
            }
            if (this.hasExtInfoSeq)
            {
                hashCode ^= this.extInfoSeq_.GetHashCode();
            }
            if (this.hasImgUpdateSeq)
            {
                hashCode ^= this.imgUpdateSeq_.GetHashCode();
            }
            return hashCode;
        }

        private QContact MakeReadOnly()
        {
            return this;
        }

        public static QContact ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<QContact, Builder>.PrintField("UserName", this.hasUserName, this.userName_, writer);
            GeneratedMessageLite<QContact, Builder>.PrintField("DisplayName", this.hasDisplayName, this.displayName_, writer);
            GeneratedMessageLite<QContact, Builder>.PrintField("ExtInfoSeq", this.hasExtInfoSeq, this.extInfoSeq_, writer);
            GeneratedMessageLite<QContact, Builder>.PrintField("ImgUpdateSeq", this.hasImgUpdateSeq, this.imgUpdateSeq_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _qContactFieldNames;
            if (this.hasUserName)
            {
                output.WriteString(1, strArray[3], this.UserName);
            }
            if (this.hasDisplayName)
            {
                output.WriteString(2, strArray[0], this.DisplayName);
            }
            if (this.hasExtInfoSeq)
            {
                output.WriteUInt32(3, strArray[1], this.ExtInfoSeq);
            }
            if (this.hasImgUpdateSeq)
            {
                output.WriteUInt32(4, strArray[2], this.ImgUpdateSeq);
            }
        }

        public static QContact DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override QContact DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public string DisplayName
        {
            get
            {
                return this.displayName_;
            }
        }

        public uint ExtInfoSeq
        {
            get
            {
                return this.extInfoSeq_;
            }
        }

        public uint ImgUpdateSeq
        {
            get
            {
                return this.imgUpdateSeq_;
            }
        }

        public override bool IsInitialized
        {
            get
            {
                if (!this.hasExtInfoSeq)
                {
                    return false;
                }
                if (!this.hasImgUpdateSeq)
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
                    if (this.hasDisplayName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(2, this.DisplayName);
                    }
                    if (this.hasExtInfoSeq)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(3, this.ExtInfoSeq);
                    }
                    if (this.hasImgUpdateSeq)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(4, this.ImgUpdateSeq);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override QContact ThisMessage
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

        
        public sealed class Builder : GeneratedBuilderLite<QContact, QContact.Builder>
        {
            private QContact result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = QContact.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(QContact cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override QContact BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override QContact.Builder Clear()
            {
                this.result = QContact.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public QContact.Builder ClearDisplayName()
            {
                this.PrepareBuilder();
                this.result.hasDisplayName = false;
                this.result.displayName_ = "";
                return this;
            }

            public QContact.Builder ClearExtInfoSeq()
            {
                this.PrepareBuilder();
                this.result.hasExtInfoSeq = false;
                this.result.extInfoSeq_ = 0;
                return this;
            }

            public QContact.Builder ClearImgUpdateSeq()
            {
                this.PrepareBuilder();
                this.result.hasImgUpdateSeq = false;
                this.result.imgUpdateSeq_ = 0;
                return this;
            }

            public QContact.Builder ClearUserName()
            {
                this.PrepareBuilder();
                this.result.hasUserName = false;
                this.result.userName_ = "";
                return this;
            }

            public override QContact.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new QContact.Builder(this.result);
                }
                return new QContact.Builder().MergeFrom(this.result);
            }

            public override QContact.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override QContact.Builder MergeFrom(IMessageLite other)
            {
                if (other is QContact)
                {
                    return this.MergeFrom((QContact) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override QContact.Builder MergeFrom(QContact other)
            {
                return this;
            }

            public override QContact.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(QContact._qContactFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = QContact._qContactFieldTags[index];
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
                        case 0x12:
                        {
                            this.result.hasDisplayName = input.ReadString(ref this.result.displayName_);
                            continue;
                        }
                        case 0x18:
                        {
                            this.result.hasExtInfoSeq = input.ReadUInt32(ref this.result.extInfoSeq_);
                            continue;
                        }
                        case 0x20:
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
                    this.result.hasImgUpdateSeq = input.ReadUInt32(ref this.result.imgUpdateSeq_);
                }
                return this;
            }

            private QContact PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    QContact result = this.result;
                    this.result = new QContact();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public QContact.Builder SetDisplayName(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasDisplayName = true;
                this.result.displayName_ = value;
                return this;
            }

            public QContact.Builder SetExtInfoSeq(uint value)
            {
                this.PrepareBuilder();
                this.result.hasExtInfoSeq = true;
                this.result.extInfoSeq_ = value;
                return this;
            }

            public QContact.Builder SetImgUpdateSeq(uint value)
            {
                this.PrepareBuilder();
                this.result.hasImgUpdateSeq = true;
                this.result.imgUpdateSeq_ = value;
                return this;
            }

            public QContact.Builder SetUserName(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasUserName = true;
                this.result.userName_ = value;
                return this;
            }

            public override QContact DefaultInstanceForType
            {
                get
                {
                    return QContact.DefaultInstance;
                }
            }

            public string DisplayName
            {
                get
                {
                    return this.result.DisplayName;
                }
                set
                {
                    this.SetDisplayName(value);
                }
            }

            public uint ExtInfoSeq
            {
                get
                {
                    return this.result.ExtInfoSeq;
                }
                set
                {
                    this.SetExtInfoSeq(value);
                }
            }

            public uint ImgUpdateSeq
            {
                get
                {
                    return this.result.ImgUpdateSeq;
                }
                set
                {
                    this.SetImgUpdateSeq(value);
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override QContact MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override QContact.Builder ThisBuilder
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


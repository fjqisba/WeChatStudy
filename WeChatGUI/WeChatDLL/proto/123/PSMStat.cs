namespace micromsg
{
    using Google.ProtocolBuffers;
    
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

    
    public sealed class PSMStat : GeneratedMessageLite<PSMStat, PSMStat.Builder>
    {
        private static readonly string[] _pSMStatFieldNames = new string[] { "AType", "MType" };
        private static readonly uint[] _pSMStatFieldTags = new uint[] { 0x12, 8 };
        private string aType_ = "";
        public const int ATypeFieldNumber = 2;
        private static readonly PSMStat defaultInstance = new PSMStat().MakeReadOnly();
        private bool hasAType;
        private bool hasMType;
        private int memoizedSerializedSize = -1;
        private uint mType_;
        public const int MTypeFieldNumber = 1;

        static PSMStat()
        {
            //object.ReferenceEquals(PSMStat.Descriptor, null);
        }

        private PSMStat()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(PSMStat prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            PSMStat stat = obj as PSMStat;
            if (stat == null)
            {
                return false;
            }
            if ((this.hasMType != stat.hasMType) || (this.hasMType && !this.mType_.Equals(stat.mType_)))
            {
                return false;
            }
            return ((this.hasAType == stat.hasAType) && (!this.hasAType || this.aType_.Equals(stat.aType_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasMType)
            {
                hashCode ^= this.mType_.GetHashCode();
            }
            if (this.hasAType)
            {
                hashCode ^= this.aType_.GetHashCode();
            }
            return hashCode;
        }

        private PSMStat MakeReadOnly()
        {
            return this;
        }

        public static PSMStat ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<PSMStat, Builder>.PrintField("MType", this.hasMType, this.mType_, writer);
            GeneratedMessageLite<PSMStat, Builder>.PrintField("AType", this.hasAType, this.aType_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _pSMStatFieldNames;
            if (this.hasMType)
            {
                output.WriteUInt32(1, strArray[1], this.MType);
            }
            if (this.hasAType)
            {
                output.WriteString(2, strArray[0], this.AType);
            }
        }

        public string AType
        {
            get
            {
                return this.aType_;
            }
        }

        public static PSMStat DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override PSMStat DefaultInstanceForType
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
                if (!this.hasMType)
                {
                    return false;
                }
                return true;
            }
        }

        public uint MType
        {
            get
            {
                return this.mType_;
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
                    if (this.hasMType)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(1, this.MType);
                    }
                    if (this.hasAType)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(2, this.AType);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override PSMStat ThisMessage
        {
            get
            {
                return this;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<PSMStat, PSMStat.Builder>
        {
            private PSMStat result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = PSMStat.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(PSMStat cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override PSMStat BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override PSMStat.Builder Clear()
            {
                this.result = PSMStat.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public PSMStat.Builder ClearAType()
            {
                this.PrepareBuilder();
                this.result.hasAType = false;
                this.result.aType_ = "";
                return this;
            }

            public PSMStat.Builder ClearMType()
            {
                this.PrepareBuilder();
                this.result.hasMType = false;
                this.result.mType_ = 0;
                return this;
            }

            public override PSMStat.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new PSMStat.Builder(this.result);
                }
                return new PSMStat.Builder().MergeFrom(this.result);
            }

            public override PSMStat.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override PSMStat.Builder MergeFrom(IMessageLite other)
            {
                if (other is PSMStat)
                {
                    return this.MergeFrom((PSMStat) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override PSMStat.Builder MergeFrom(PSMStat other)
            {
                return this;
            }

            public override PSMStat.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(PSMStat._pSMStatFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = PSMStat._pSMStatFieldTags[index];
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

                        case 8:
                        {
                            this.result.hasMType = input.ReadUInt32(ref this.result.mType_);
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
                    this.result.hasAType = input.ReadString(ref this.result.aType_);
                }
                return this;
            }

            private PSMStat PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    PSMStat result = this.result;
                    this.result = new PSMStat();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public PSMStat.Builder SetAType(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasAType = true;
                this.result.aType_ = value;
                return this;
            }

            public PSMStat.Builder SetMType(uint value)
            {
                this.PrepareBuilder();
                this.result.hasMType = true;
                this.result.mType_ = value;
                return this;
            }

            public string AType
            {
                get
                {
                    return this.result.AType;
                }
                set
                {
                    this.SetAType(value);
                }
            }

            public override PSMStat DefaultInstanceForType
            {
                get
                {
                    return PSMStat.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override PSMStat MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public uint MType
            {
                get
                {
                    return this.result.MType;
                }
                set
                {
                    this.SetMType(value);
                }
            }

            protected override PSMStat.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


namespace micromsg
{
    using Google.ProtocolBuffers;
    
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

    //
    public sealed class GmailInfo : GeneratedMessageLite<GmailInfo, GmailInfo.Builder>
    {
        private static readonly string[] _gmailInfoFieldNames = new string[] { "GmailAcct", "GmailErrCode", "GmailSwitch" };
        private static readonly uint[] _gmailInfoFieldTags = new uint[] { 10, 0x18, 0x10 };
        private static readonly GmailInfo defaultInstance = new GmailInfo().MakeReadOnly();
        private string gmailAcct_ = "";
        public const int GmailAcctFieldNumber = 1;
        private uint gmailErrCode_;
        public const int GmailErrCodeFieldNumber = 3;
        private uint gmailSwitch_;
        public const int GmailSwitchFieldNumber = 2;
        private bool hasGmailAcct;
        private bool hasGmailErrCode;
        private bool hasGmailSwitch;
        private int memoizedSerializedSize = -1;

        static GmailInfo()
        {
           // object.ReferenceEquals(GmailInfo.Descriptor, null);
        }

        private GmailInfo()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(GmailInfo prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            GmailInfo info = obj as GmailInfo;
            if (info == null)
            {
                return false;
            }
            if ((this.hasGmailAcct != info.hasGmailAcct) || (this.hasGmailAcct && !this.gmailAcct_.Equals(info.gmailAcct_)))
            {
                return false;
            }
            if ((this.hasGmailSwitch != info.hasGmailSwitch) || (this.hasGmailSwitch && !this.gmailSwitch_.Equals(info.gmailSwitch_)))
            {
                return false;
            }
            return ((this.hasGmailErrCode == info.hasGmailErrCode) && (!this.hasGmailErrCode || this.gmailErrCode_.Equals(info.gmailErrCode_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasGmailAcct)
            {
                hashCode ^= this.gmailAcct_.GetHashCode();
            }
            if (this.hasGmailSwitch)
            {
                hashCode ^= this.gmailSwitch_.GetHashCode();
            }
            if (this.hasGmailErrCode)
            {
                hashCode ^= this.gmailErrCode_.GetHashCode();
            }
            return hashCode;
        }

        private GmailInfo MakeReadOnly()
        {
            return this;
        }

        public static GmailInfo ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<GmailInfo, Builder>.PrintField("GmailAcct", this.hasGmailAcct, this.gmailAcct_, writer);
            GeneratedMessageLite<GmailInfo, Builder>.PrintField("GmailSwitch", this.hasGmailSwitch, this.gmailSwitch_, writer);
            GeneratedMessageLite<GmailInfo, Builder>.PrintField("GmailErrCode", this.hasGmailErrCode, this.gmailErrCode_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _gmailInfoFieldNames;
            if (this.hasGmailAcct)
            {
                output.WriteString(1, strArray[0], this.GmailAcct);
            }
            if (this.hasGmailSwitch)
            {
                output.WriteUInt32(2, strArray[2], this.GmailSwitch);
            }
            if (this.hasGmailErrCode)
            {
                output.WriteUInt32(3, strArray[1], this.GmailErrCode);
            }
        }

        public static GmailInfo DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override GmailInfo DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public string GmailAcct
        {
            get
            {
                return this.gmailAcct_;
            }
        }

        public uint GmailErrCode
        {
            get
            {
                return this.gmailErrCode_;
            }
        }

        public uint GmailSwitch
        {
            get
            {
                return this.gmailSwitch_;
            }
        }

        public override bool IsInitialized
        {
            get
            {
                if (!this.hasGmailSwitch)
                {
                    return false;
                }
                if (!this.hasGmailErrCode)
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
                    if (this.hasGmailAcct)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(1, this.GmailAcct);
                    }
                    if (this.hasGmailSwitch)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(2, this.GmailSwitch);
                    }
                    if (this.hasGmailErrCode)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(3, this.GmailErrCode);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override GmailInfo ThisMessage
        {
            get
            {
                return this;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<GmailInfo, GmailInfo.Builder>
        {
            private GmailInfo result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = GmailInfo.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(GmailInfo cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override GmailInfo BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override GmailInfo.Builder Clear()
            {
                this.result = GmailInfo.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public GmailInfo.Builder ClearGmailAcct()
            {
                this.PrepareBuilder();
                this.result.hasGmailAcct = false;
                this.result.gmailAcct_ = "";
                return this;
            }

            public GmailInfo.Builder ClearGmailErrCode()
            {
                this.PrepareBuilder();
                this.result.hasGmailErrCode = false;
                this.result.gmailErrCode_ = 0;
                return this;
            }

            public GmailInfo.Builder ClearGmailSwitch()
            {
                this.PrepareBuilder();
                this.result.hasGmailSwitch = false;
                this.result.gmailSwitch_ = 0;
                return this;
            }

            public override GmailInfo.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new GmailInfo.Builder(this.result);
                }
                return new GmailInfo.Builder().MergeFrom(this.result);
            }

            public override GmailInfo.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override GmailInfo.Builder MergeFrom(IMessageLite other)
            {
                if (other is GmailInfo)
                {
                    return this.MergeFrom((GmailInfo) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override GmailInfo.Builder MergeFrom(GmailInfo other)
            {
                return this;
            }

            public override GmailInfo.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(GmailInfo._gmailInfoFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = GmailInfo._gmailInfoFieldTags[index];
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
                            this.result.hasGmailAcct = input.ReadString(ref this.result.gmailAcct_);
                            continue;
                        }
                        case 0x10:
                        {
                            this.result.hasGmailSwitch = input.ReadUInt32(ref this.result.gmailSwitch_);
                            continue;
                        }
                        case 0x18:
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
                    this.result.hasGmailErrCode = input.ReadUInt32(ref this.result.gmailErrCode_);
                }
                return this;
            }

            private GmailInfo PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    GmailInfo result = this.result;
                    this.result = new GmailInfo();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public GmailInfo.Builder SetGmailAcct(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasGmailAcct = true;
                this.result.gmailAcct_ = value;
                return this;
            }

            public GmailInfo.Builder SetGmailErrCode(uint value)
            {
                this.PrepareBuilder();
                this.result.hasGmailErrCode = true;
                this.result.gmailErrCode_ = value;
                return this;
            }

            public GmailInfo.Builder SetGmailSwitch(uint value)
            {
                this.PrepareBuilder();
                this.result.hasGmailSwitch = true;
                this.result.gmailSwitch_ = value;
                return this;
            }

            public override GmailInfo DefaultInstanceForType
            {
                get
                {
                    return GmailInfo.DefaultInstance;
                }
            }

            public string GmailAcct
            {
                get
                {
                    return this.result.GmailAcct;
                }
                set
                {
                    this.SetGmailAcct(value);
                }
            }

            public uint GmailErrCode
            {
                get
                {
                    return this.result.GmailErrCode;
                }
                set
                {
                    this.SetGmailErrCode(value);
                }
            }

            public uint GmailSwitch
            {
                get
                {
                    return this.result.GmailSwitch;
                }
                set
                {
                    this.SetGmailSwitch(value);
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override GmailInfo MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override GmailInfo.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


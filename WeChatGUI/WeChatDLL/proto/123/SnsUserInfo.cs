namespace micromsg
{
    using Google.ProtocolBuffers;
    
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

    //
    public sealed class SnsUserInfo : GeneratedMessageLite<SnsUserInfo, SnsUserInfo.Builder>
    {
        private static readonly string[] _snsUserInfoFieldNames = new string[] { "SnsBGImgID", "SnsBGObjectID", "SnsFlag" };
        private static readonly uint[] _snsUserInfoFieldTags = new uint[] { 0x12, 0x18, 8 };
        private static readonly SnsUserInfo defaultInstance = new SnsUserInfo().MakeReadOnly();
        private bool hasSnsBGImgID;
        private bool hasSnsBGObjectID;
        private bool hasSnsFlag;
        private int memoizedSerializedSize = -1;
        private string snsBGImgID_ = "";
        public const int SnsBGImgIDFieldNumber = 2;
        private ulong snsBGObjectID_;
        public const int SnsBGObjectIDFieldNumber = 3;
        private uint snsFlag_;
        public const int SnsFlagFieldNumber = 1;

        static SnsUserInfo()
        {
            //object.ReferenceEquals(SnsUserInfo.Descriptor, null);
        }

        private SnsUserInfo()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(SnsUserInfo prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            SnsUserInfo info = obj as SnsUserInfo;
            if (info == null)
            {
                return false;
            }
            if ((this.hasSnsFlag != info.hasSnsFlag) || (this.hasSnsFlag && !this.snsFlag_.Equals(info.snsFlag_)))
            {
                return false;
            }
            if ((this.hasSnsBGImgID != info.hasSnsBGImgID) || (this.hasSnsBGImgID && !this.snsBGImgID_.Equals(info.snsBGImgID_)))
            {
                return false;
            }
            return ((this.hasSnsBGObjectID == info.hasSnsBGObjectID) && (!this.hasSnsBGObjectID || this.snsBGObjectID_.Equals(info.snsBGObjectID_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasSnsFlag)
            {
                hashCode ^= this.snsFlag_.GetHashCode();
            }
            if (this.hasSnsBGImgID)
            {
                hashCode ^= this.snsBGImgID_.GetHashCode();
            }
            if (this.hasSnsBGObjectID)
            {
                hashCode ^= this.snsBGObjectID_.GetHashCode();
            }
            return hashCode;
        }

        private SnsUserInfo MakeReadOnly()
        {
            return this;
        }

        public static SnsUserInfo ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<SnsUserInfo, Builder>.PrintField("SnsFlag", this.hasSnsFlag, this.snsFlag_, writer);
            GeneratedMessageLite<SnsUserInfo, Builder>.PrintField("SnsBGImgID", this.hasSnsBGImgID, this.snsBGImgID_, writer);
            GeneratedMessageLite<SnsUserInfo, Builder>.PrintField("SnsBGObjectID", this.hasSnsBGObjectID, this.snsBGObjectID_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _snsUserInfoFieldNames;
            if (this.hasSnsFlag)
            {
                output.WriteUInt32(1, strArray[2], this.SnsFlag);
            }
            if (this.hasSnsBGImgID)
            {
                output.WriteString(2, strArray[0], this.SnsBGImgID);
            }
            if (this.hasSnsBGObjectID)
            {
                output.WriteUInt64(3, strArray[1], this.SnsBGObjectID);
            }
        }

        public static SnsUserInfo DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override SnsUserInfo DefaultInstanceForType
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
                if (!this.hasSnsFlag)
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
                    if (this.hasSnsFlag)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(1, this.SnsFlag);
                    }
                    if (this.hasSnsBGImgID)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(2, this.SnsBGImgID);
                    }
                    if (this.hasSnsBGObjectID)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt64Size(3, this.SnsBGObjectID);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        public string SnsBGImgID
        {
            get
            {
                return this.snsBGImgID_;
            }
        }

        public ulong SnsBGObjectID
        {
            get
            {
                return this.snsBGObjectID_;
            }
        }

        public uint SnsFlag
        {
            get
            {
                return this.snsFlag_;
            }
        }

        protected override SnsUserInfo ThisMessage
        {
            get
            {
                return this;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<SnsUserInfo, SnsUserInfo.Builder>
        {
            private SnsUserInfo result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = SnsUserInfo.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(SnsUserInfo cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override SnsUserInfo BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override SnsUserInfo.Builder Clear()
            {
                this.result = SnsUserInfo.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public SnsUserInfo.Builder ClearSnsBGImgID()
            {
                this.PrepareBuilder();
                this.result.hasSnsBGImgID = false;
                this.result.snsBGImgID_ = "";
                return this;
            }

            public SnsUserInfo.Builder ClearSnsBGObjectID()
            {
                this.PrepareBuilder();
                this.result.hasSnsBGObjectID = false;
                this.result.snsBGObjectID_ = 0L;
                return this;
            }

            public SnsUserInfo.Builder ClearSnsFlag()
            {
                this.PrepareBuilder();
                this.result.hasSnsFlag = false;
                this.result.snsFlag_ = 0;
                return this;
            }

            public override SnsUserInfo.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new SnsUserInfo.Builder(this.result);
                }
                return new SnsUserInfo.Builder().MergeFrom(this.result);
            }

            public override SnsUserInfo.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override SnsUserInfo.Builder MergeFrom(IMessageLite other)
            {
                if (other is SnsUserInfo)
                {
                    return this.MergeFrom((SnsUserInfo) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override SnsUserInfo.Builder MergeFrom(SnsUserInfo other)
            {
                return this;
            }

            public override SnsUserInfo.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(SnsUserInfo._snsUserInfoFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = SnsUserInfo._snsUserInfoFieldTags[index];
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
                            this.result.hasSnsFlag = input.ReadUInt32(ref this.result.snsFlag_);
                            continue;
                        }
                        case 0x12:
                        {
                            this.result.hasSnsBGImgID = input.ReadString(ref this.result.snsBGImgID_);
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
                    this.result.hasSnsBGObjectID = input.ReadUInt64(ref this.result.snsBGObjectID_);
                }
                return this;
            }

            private SnsUserInfo PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    SnsUserInfo result = this.result;
                    this.result = new SnsUserInfo();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public SnsUserInfo.Builder SetSnsBGImgID(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSnsBGImgID = true;
                this.result.snsBGImgID_ = value;
                return this;
            }

            public SnsUserInfo.Builder SetSnsBGObjectID(ulong value)
            {
                this.PrepareBuilder();
                this.result.hasSnsBGObjectID = true;
                this.result.snsBGObjectID_ = value;
                return this;
            }

            public SnsUserInfo.Builder SetSnsFlag(uint value)
            {
                this.PrepareBuilder();
                this.result.hasSnsFlag = true;
                this.result.snsFlag_ = value;
                return this;
            }

            public override SnsUserInfo DefaultInstanceForType
            {
                get
                {
                    return SnsUserInfo.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override SnsUserInfo MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public string SnsBGImgID
            {
                get
                {
                    return this.result.SnsBGImgID;
                }
                set
                {
                    this.SetSnsBGImgID(value);
                }
            }

            public ulong SnsBGObjectID
            {
                get
                {
                    return this.result.SnsBGObjectID;
                }
                set
                {
                    this.SetSnsBGObjectID(value);
                }
            }

            public uint SnsFlag
            {
                get
                {
                    return this.result.SnsFlag;
                }
                set
                {
                    this.SetSnsFlag(value);
                }
            }

            protected override SnsUserInfo.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


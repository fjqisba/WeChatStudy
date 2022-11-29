namespace micromsg
{
    using Google.ProtocolBuffers;
    
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

    //
    public sealed class ModUserImg : GeneratedMessageLite<ModUserImg, ModUserImg.Builder>
    {
        private static readonly string[] _modUserImgFieldNames = new string[] { "BigHeadImgUrl", "ImgBuf", "ImgLen", "ImgMd5", "ImgType", "SmallHeadImgUrl" };
        private static readonly uint[] _modUserImgFieldTags = new uint[] { 0x2a, 0x1a, 0x10, 0x22, 8, 50 };
        private string bigHeadImgUrl_ = "";
        public const int BigHeadImgUrlFieldNumber = 5;
        private static readonly ModUserImg defaultInstance = new ModUserImg().MakeReadOnly();
        private bool hasBigHeadImgUrl;
        private bool hasImgBuf;
        private bool hasImgLen;
        private bool hasImgMd5;
        private bool hasImgType;
        private bool hasSmallHeadImgUrl;
        private ByteString imgBuf_ = ByteString.Empty;
        public const int ImgBufFieldNumber = 3;
        private uint imgLen_;
        public const int ImgLenFieldNumber = 2;
        private string imgMd5_ = "";
        public const int ImgMd5FieldNumber = 4;
        private uint imgType_;
        public const int ImgTypeFieldNumber = 1;
        private int memoizedSerializedSize = -1;
        private string smallHeadImgUrl_ = "";
        public const int SmallHeadImgUrlFieldNumber = 6;

        static ModUserImg()
        {
            //object.ReferenceEquals(ModUserImg.Descriptor, null);
        }

        private ModUserImg()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(ModUserImg prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            ModUserImg img = obj as ModUserImg;
            if (img == null)
            {
                return false;
            }
            if ((this.hasImgType != img.hasImgType) || (this.hasImgType && !this.imgType_.Equals(img.imgType_)))
            {
                return false;
            }
            if ((this.hasImgLen != img.hasImgLen) || (this.hasImgLen && !this.imgLen_.Equals(img.imgLen_)))
            {
                return false;
            }
            if ((this.hasImgBuf != img.hasImgBuf) || (this.hasImgBuf && !this.imgBuf_.Equals(img.imgBuf_)))
            {
                return false;
            }
            if ((this.hasImgMd5 != img.hasImgMd5) || (this.hasImgMd5 && !this.imgMd5_.Equals(img.imgMd5_)))
            {
                return false;
            }
            if ((this.hasBigHeadImgUrl != img.hasBigHeadImgUrl) || (this.hasBigHeadImgUrl && !this.bigHeadImgUrl_.Equals(img.bigHeadImgUrl_)))
            {
                return false;
            }
            return ((this.hasSmallHeadImgUrl == img.hasSmallHeadImgUrl) && (!this.hasSmallHeadImgUrl || this.smallHeadImgUrl_.Equals(img.smallHeadImgUrl_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasImgType)
            {
                hashCode ^= this.imgType_.GetHashCode();
            }
            if (this.hasImgLen)
            {
                hashCode ^= this.imgLen_.GetHashCode();
            }
            if (this.hasImgBuf)
            {
                hashCode ^= this.imgBuf_.GetHashCode();
            }
            if (this.hasImgMd5)
            {
                hashCode ^= this.imgMd5_.GetHashCode();
            }
            if (this.hasBigHeadImgUrl)
            {
                hashCode ^= this.bigHeadImgUrl_.GetHashCode();
            }
            if (this.hasSmallHeadImgUrl)
            {
                hashCode ^= this.smallHeadImgUrl_.GetHashCode();
            }
            return hashCode;
        }

        private ModUserImg MakeReadOnly()
        {
            return this;
        }

        public static ModUserImg ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<ModUserImg, Builder>.PrintField("ImgType", this.hasImgType, this.imgType_, writer);
            GeneratedMessageLite<ModUserImg, Builder>.PrintField("ImgLen", this.hasImgLen, this.imgLen_, writer);
            GeneratedMessageLite<ModUserImg, Builder>.PrintField("ImgBuf", this.hasImgBuf, this.imgBuf_, writer);
            GeneratedMessageLite<ModUserImg, Builder>.PrintField("ImgMd5", this.hasImgMd5, this.imgMd5_, writer);
            GeneratedMessageLite<ModUserImg, Builder>.PrintField("BigHeadImgUrl", this.hasBigHeadImgUrl, this.bigHeadImgUrl_, writer);
            GeneratedMessageLite<ModUserImg, Builder>.PrintField("SmallHeadImgUrl", this.hasSmallHeadImgUrl, this.smallHeadImgUrl_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _modUserImgFieldNames;
            if (this.hasImgType)
            {
                output.WriteUInt32(1, strArray[4], this.ImgType);
            }
            if (this.hasImgLen)
            {
                output.WriteUInt32(2, strArray[2], this.ImgLen);
            }
            if (this.hasImgBuf)
            {
                output.WriteBytes(3, strArray[1], this.ImgBuf);
            }
            if (this.hasImgMd5)
            {
                output.WriteString(4, strArray[3], this.ImgMd5);
            }
            if (this.hasBigHeadImgUrl)
            {
                output.WriteString(5, strArray[0], this.BigHeadImgUrl);
            }
            if (this.hasSmallHeadImgUrl)
            {
                output.WriteString(6, strArray[5], this.SmallHeadImgUrl);
            }
        }

        public string BigHeadImgUrl
        {
            get
            {
                return this.bigHeadImgUrl_;
            }
        }

        public static ModUserImg DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override ModUserImg DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public ByteString ImgBuf
        {
            get
            {
                return this.imgBuf_;
            }
        }

        public uint ImgLen
        {
            get
            {
                return this.imgLen_;
            }
        }

        public string ImgMd5
        {
            get
            {
                return this.imgMd5_;
            }
        }

        public uint ImgType
        {
            get
            {
                return this.imgType_;
            }
        }

        public override bool IsInitialized
        {
            get
            {
                if (!this.hasImgType)
                {
                    return false;
                }
                if (!this.hasImgLen)
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
                    if (this.hasImgType)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(1, this.ImgType);
                    }
                    if (this.hasImgLen)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(2, this.ImgLen);
                    }
                    if (this.hasImgBuf)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeBytesSize(3, this.ImgBuf);
                    }
                    if (this.hasImgMd5)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(4, this.ImgMd5);
                    }
                    if (this.hasBigHeadImgUrl)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(5, this.BigHeadImgUrl);
                    }
                    if (this.hasSmallHeadImgUrl)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(6, this.SmallHeadImgUrl);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        public string SmallHeadImgUrl
        {
            get
            {
                return this.smallHeadImgUrl_;
            }
        }

        protected override ModUserImg ThisMessage
        {
            get
            {
                return this;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<ModUserImg, ModUserImg.Builder>
        {
            private ModUserImg result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = ModUserImg.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(ModUserImg cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override ModUserImg BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override ModUserImg.Builder Clear()
            {
                this.result = ModUserImg.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public ModUserImg.Builder ClearBigHeadImgUrl()
            {
                this.PrepareBuilder();
                this.result.hasBigHeadImgUrl = false;
                this.result.bigHeadImgUrl_ = "";
                return this;
            }

            public ModUserImg.Builder ClearImgBuf()
            {
                this.PrepareBuilder();
                this.result.hasImgBuf = false;
                this.result.imgBuf_ = ByteString.Empty;
                return this;
            }

            public ModUserImg.Builder ClearImgLen()
            {
                this.PrepareBuilder();
                this.result.hasImgLen = false;
                this.result.imgLen_ = 0;
                return this;
            }

            public ModUserImg.Builder ClearImgMd5()
            {
                this.PrepareBuilder();
                this.result.hasImgMd5 = false;
                this.result.imgMd5_ = "";
                return this;
            }

            public ModUserImg.Builder ClearImgType()
            {
                this.PrepareBuilder();
                this.result.hasImgType = false;
                this.result.imgType_ = 0;
                return this;
            }

            public ModUserImg.Builder ClearSmallHeadImgUrl()
            {
                this.PrepareBuilder();
                this.result.hasSmallHeadImgUrl = false;
                this.result.smallHeadImgUrl_ = "";
                return this;
            }

            public override ModUserImg.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new ModUserImg.Builder(this.result);
                }
                return new ModUserImg.Builder().MergeFrom(this.result);
            }

            public override ModUserImg.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override ModUserImg.Builder MergeFrom(IMessageLite other)
            {
                if (other is ModUserImg)
                {
                    return this.MergeFrom((ModUserImg) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override ModUserImg.Builder MergeFrom(ModUserImg other)
            {
                return this;
            }

            public override ModUserImg.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(ModUserImg._modUserImgFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = ModUserImg._modUserImgFieldTags[index];
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
                            this.result.hasImgType = input.ReadUInt32(ref this.result.imgType_);
                            continue;
                        }
                        case 0x10:
                        {
                            this.result.hasImgLen = input.ReadUInt32(ref this.result.imgLen_);
                            continue;
                        }
                        case 0x1a:
                        {
                            this.result.hasImgBuf = input.ReadBytes(ref this.result.imgBuf_);
                            continue;
                        }
                        case 0x22:
                        {
                            this.result.hasImgMd5 = input.ReadString(ref this.result.imgMd5_);
                            continue;
                        }
                        case 0x2a:
                        {
                            this.result.hasBigHeadImgUrl = input.ReadString(ref this.result.bigHeadImgUrl_);
                            continue;
                        }
                        case 50:
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
                    this.result.hasSmallHeadImgUrl = input.ReadString(ref this.result.smallHeadImgUrl_);
                }
                return this;
            }

            private ModUserImg PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    ModUserImg result = this.result;
                    this.result = new ModUserImg();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public ModUserImg.Builder SetBigHeadImgUrl(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBigHeadImgUrl = true;
                this.result.bigHeadImgUrl_ = value;
                return this;
            }

            public ModUserImg.Builder SetImgBuf(ByteString value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasImgBuf = true;
                this.result.imgBuf_ = value;
                return this;
            }

            public ModUserImg.Builder SetImgLen(uint value)
            {
                this.PrepareBuilder();
                this.result.hasImgLen = true;
                this.result.imgLen_ = value;
                return this;
            }

            public ModUserImg.Builder SetImgMd5(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasImgMd5 = true;
                this.result.imgMd5_ = value;
                return this;
            }

            public ModUserImg.Builder SetImgType(uint value)
            {
                this.PrepareBuilder();
                this.result.hasImgType = true;
                this.result.imgType_ = value;
                return this;
            }

            public ModUserImg.Builder SetSmallHeadImgUrl(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSmallHeadImgUrl = true;
                this.result.smallHeadImgUrl_ = value;
                return this;
            }

            public string BigHeadImgUrl
            {
                get
                {
                    return this.result.BigHeadImgUrl;
                }
                set
                {
                    this.SetBigHeadImgUrl(value);
                }
            }

            public override ModUserImg DefaultInstanceForType
            {
                get
                {
                    return ModUserImg.DefaultInstance;
                }
            }

            public ByteString ImgBuf
            {
                get
                {
                    return this.result.ImgBuf;
                }
                set
                {
                    this.SetImgBuf(value);
                }
            }

            public uint ImgLen
            {
                get
                {
                    return this.result.ImgLen;
                }
                set
                {
                    this.SetImgLen(value);
                }
            }

            public string ImgMd5
            {
                get
                {
                    return this.result.ImgMd5;
                }
                set
                {
                    this.SetImgMd5(value);
                }
            }

            public uint ImgType
            {
                get
                {
                    return this.result.ImgType;
                }
                set
                {
                    this.SetImgType(value);
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override ModUserImg MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public string SmallHeadImgUrl
            {
                get
                {
                    return this.result.SmallHeadImgUrl;
                }
                set
                {
                    this.SetSmallHeadImgUrl(value);
                }
            }

            protected override ModUserImg.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


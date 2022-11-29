namespace micromsg
{
    using Google.ProtocolBuffers;
    
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

    
    public sealed class CustomizedInfo : GeneratedMessageLite<CustomizedInfo, CustomizedInfo.Builder>
    {
        private static readonly string[] _customizedInfoFieldNames = new string[] { "BrandFlag", "BrandIconURL", "BrandInfo", "ExternalInfo" };
        private static readonly uint[] _customizedInfoFieldTags = new uint[] { 8, 0x22, 0x1a, 0x12 };
        private uint brandFlag_;
        public const int BrandFlagFieldNumber = 1;
        private string brandIconURL_ = "";
        public const int BrandIconURLFieldNumber = 4;
        private string brandInfo_ = "";
        public const int BrandInfoFieldNumber = 3;
        private static readonly CustomizedInfo defaultInstance = new CustomizedInfo().MakeReadOnly();
        private string externalInfo_ = "";
        public const int ExternalInfoFieldNumber = 2;
        private bool hasBrandFlag;
        private bool hasBrandIconURL;
        private bool hasBrandInfo;
        private bool hasExternalInfo;
        private int memoizedSerializedSize = -1;

        static CustomizedInfo()
        {
            //object.ReferenceEquals(CustomizedInfo.Descriptor, null);
        }

        private CustomizedInfo()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(CustomizedInfo prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            CustomizedInfo info = obj as CustomizedInfo;
            if (info == null)
            {
                return false;
            }
            if ((this.hasBrandFlag != info.hasBrandFlag) || (this.hasBrandFlag && !this.brandFlag_.Equals(info.brandFlag_)))
            {
                return false;
            }
            if ((this.hasExternalInfo != info.hasExternalInfo) || (this.hasExternalInfo && !this.externalInfo_.Equals(info.externalInfo_)))
            {
                return false;
            }
            if ((this.hasBrandInfo != info.hasBrandInfo) || (this.hasBrandInfo && !this.brandInfo_.Equals(info.brandInfo_)))
            {
                return false;
            }
            return ((this.hasBrandIconURL == info.hasBrandIconURL) && (!this.hasBrandIconURL || this.brandIconURL_.Equals(info.brandIconURL_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasBrandFlag)
            {
                hashCode ^= this.brandFlag_.GetHashCode();
            }
            if (this.hasExternalInfo)
            {
                hashCode ^= this.externalInfo_.GetHashCode();
            }
            if (this.hasBrandInfo)
            {
                hashCode ^= this.brandInfo_.GetHashCode();
            }
            if (this.hasBrandIconURL)
            {
                hashCode ^= this.brandIconURL_.GetHashCode();
            }
            return hashCode;
        }

        private CustomizedInfo MakeReadOnly()
        {
            return this;
        }

        public static CustomizedInfo ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<CustomizedInfo, Builder>.PrintField("BrandFlag", this.hasBrandFlag, this.brandFlag_, writer);
            GeneratedMessageLite<CustomizedInfo, Builder>.PrintField("ExternalInfo", this.hasExternalInfo, this.externalInfo_, writer);
            GeneratedMessageLite<CustomizedInfo, Builder>.PrintField("BrandInfo", this.hasBrandInfo, this.brandInfo_, writer);
            GeneratedMessageLite<CustomizedInfo, Builder>.PrintField("BrandIconURL", this.hasBrandIconURL, this.brandIconURL_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _customizedInfoFieldNames;
            if (this.hasBrandFlag)
            {
                output.WriteUInt32(1, strArray[0], this.BrandFlag);
            }
            if (this.hasExternalInfo)
            {
                output.WriteString(2, strArray[3], this.ExternalInfo);
            }
            if (this.hasBrandInfo)
            {
                output.WriteString(3, strArray[2], this.BrandInfo);
            }
            if (this.hasBrandIconURL)
            {
                output.WriteString(4, strArray[1], this.BrandIconURL);
            }
        }

        public uint BrandFlag
        {
            get
            {
                return this.brandFlag_;
            }
        }

        public string BrandIconURL
        {
            get
            {
                return this.brandIconURL_;
            }
        }

        public string BrandInfo
        {
            get
            {
                return this.brandInfo_;
            }
        }

        public static CustomizedInfo DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override CustomizedInfo DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public string ExternalInfo
        {
            get
            {
                return this.externalInfo_;
            }
        }

        public override bool IsInitialized
        {
            get
            {
                if (!this.hasBrandFlag)
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
                    if (this.hasBrandFlag)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(1, this.BrandFlag);
                    }
                    if (this.hasExternalInfo)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(2, this.ExternalInfo);
                    }
                    if (this.hasBrandInfo)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(3, this.BrandInfo);
                    }
                    if (this.hasBrandIconURL)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(4, this.BrandIconURL);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override CustomizedInfo ThisMessage
        {
            get
            {
                return this;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<CustomizedInfo, CustomizedInfo.Builder>
        {
            private CustomizedInfo result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = CustomizedInfo.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(CustomizedInfo cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override CustomizedInfo BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override CustomizedInfo.Builder Clear()
            {
                this.result = CustomizedInfo.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public CustomizedInfo.Builder ClearBrandFlag()
            {
                this.PrepareBuilder();
                this.result.hasBrandFlag = false;
                this.result.brandFlag_ = 0;
                return this;
            }

            public CustomizedInfo.Builder ClearBrandIconURL()
            {
                this.PrepareBuilder();
                this.result.hasBrandIconURL = false;
                this.result.brandIconURL_ = "";
                return this;
            }

            public CustomizedInfo.Builder ClearBrandInfo()
            {
                this.PrepareBuilder();
                this.result.hasBrandInfo = false;
                this.result.brandInfo_ = "";
                return this;
            }

            public CustomizedInfo.Builder ClearExternalInfo()
            {
                this.PrepareBuilder();
                this.result.hasExternalInfo = false;
                this.result.externalInfo_ = "";
                return this;
            }

            public override CustomizedInfo.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new CustomizedInfo.Builder(this.result);
                }
                return new CustomizedInfo.Builder().MergeFrom(this.result);
            }

            public override CustomizedInfo.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override CustomizedInfo.Builder MergeFrom(IMessageLite other)
            {
                if (other is CustomizedInfo)
                {
                    return this.MergeFrom((CustomizedInfo) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override CustomizedInfo.Builder MergeFrom(CustomizedInfo other)
            {
                return this;
            }

            public override CustomizedInfo.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(CustomizedInfo._customizedInfoFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = CustomizedInfo._customizedInfoFieldTags[index];
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
                            this.result.hasBrandFlag = input.ReadUInt32(ref this.result.brandFlag_);
                            continue;
                        }
                        case 0x12:
                        {
                            this.result.hasExternalInfo = input.ReadString(ref this.result.externalInfo_);
                            continue;
                        }
                        case 0x1a:
                        {
                            this.result.hasBrandInfo = input.ReadString(ref this.result.brandInfo_);
                            continue;
                        }
                        case 0x22:
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
                    this.result.hasBrandIconURL = input.ReadString(ref this.result.brandIconURL_);
                }
                return this;
            }

            private CustomizedInfo PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    CustomizedInfo result = this.result;
                    this.result = new CustomizedInfo();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public CustomizedInfo.Builder SetBrandFlag(uint value)
            {
                this.PrepareBuilder();
                this.result.hasBrandFlag = true;
                this.result.brandFlag_ = value;
                return this;
            }

            public CustomizedInfo.Builder SetBrandIconURL(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBrandIconURL = true;
                this.result.brandIconURL_ = value;
                return this;
            }

            public CustomizedInfo.Builder SetBrandInfo(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBrandInfo = true;
                this.result.brandInfo_ = value;
                return this;
            }

            public CustomizedInfo.Builder SetExternalInfo(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasExternalInfo = true;
                this.result.externalInfo_ = value;
                return this;
            }

            public uint BrandFlag
            {
                get
                {
                    return this.result.BrandFlag;
                }
                set
                {
                    this.SetBrandFlag(value);
                }
            }

            public string BrandIconURL
            {
                get
                {
                    return this.result.BrandIconURL;
                }
                set
                {
                    this.SetBrandIconURL(value);
                }
            }

            public string BrandInfo
            {
                get
                {
                    return this.result.BrandInfo;
                }
                set
                {
                    this.SetBrandInfo(value);
                }
            }

            public override CustomizedInfo DefaultInstanceForType
            {
                get
                {
                    return CustomizedInfo.DefaultInstance;
                }
            }

            public string ExternalInfo
            {
                get
                {
                    return this.result.ExternalInfo;
                }
                set
                {
                    this.SetExternalInfo(value);
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override CustomizedInfo MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override CustomizedInfo.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


namespace micromsg
{
    using Google.ProtocolBuffers;
    
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

    //
    public sealed class ModBottleContact : GeneratedMessageLite<ModBottleContact, ModBottleContact.Builder>
    {
        private static readonly string[] _modBottleContactFieldNames = new string[] { "BigHeadImgUrl", "City", "Country", "HDImgFlag", "ImgFlag", "Province", "Sex", "Signature", "SmallHeadImgUrl", "Type", "UserName" };
        private static readonly uint[] _modBottleContactFieldTags = new uint[] { 0x52, 0x22, 0x4a, 0x40, 0x38, 0x2a, 0x18, 50, 90, 0x10, 10 };
        private string bigHeadImgUrl_ = "";
        public const int BigHeadImgUrlFieldNumber = 10;
        private string city_ = "";
        public const int CityFieldNumber = 4;
        private string country_ = "";
        public const int CountryFieldNumber = 9;
        private static readonly ModBottleContact defaultInstance = new ModBottleContact().MakeReadOnly();
        private bool hasBigHeadImgUrl;
        private bool hasCity;
        private bool hasCountry;
        private bool hasHDImgFlag;
        private bool hasImgFlag;
        private bool hasProvince;
        private bool hasSex;
        private bool hasSignature;
        private bool hasSmallHeadImgUrl;
        private bool hasType;
        private bool hasUserName;
        private uint hDImgFlag_;
        public const int HDImgFlagFieldNumber = 8;
        private uint imgFlag_;
        public const int ImgFlagFieldNumber = 7;
        private int memoizedSerializedSize = -1;
        private string province_ = "";
        public const int ProvinceFieldNumber = 5;
        private uint sex_;
        public const int SexFieldNumber = 3;
        private string signature_ = "";
        public const int SignatureFieldNumber = 6;
        private string smallHeadImgUrl_ = "";
        public const int SmallHeadImgUrlFieldNumber = 11;
        private uint type_;
        public const int TypeFieldNumber = 2;
        private string userName_ = "";
        public const int UserNameFieldNumber = 1;

        static ModBottleContact()
        {
            //object.ReferenceEquals(ModBottleContact.Descriptor, null);
        }

        private ModBottleContact()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(ModBottleContact prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            ModBottleContact contact = obj as ModBottleContact;
            if (contact == null)
            {
                return false;
            }
            if ((this.hasUserName != contact.hasUserName) || (this.hasUserName && !this.userName_.Equals(contact.userName_)))
            {
                return false;
            }
            if ((this.hasType != contact.hasType) || (this.hasType && !this.type_.Equals(contact.type_)))
            {
                return false;
            }
            if ((this.hasSex != contact.hasSex) || (this.hasSex && !this.sex_.Equals(contact.sex_)))
            {
                return false;
            }
            if ((this.hasCity != contact.hasCity) || (this.hasCity && !this.city_.Equals(contact.city_)))
            {
                return false;
            }
            if ((this.hasProvince != contact.hasProvince) || (this.hasProvince && !this.province_.Equals(contact.province_)))
            {
                return false;
            }
            if ((this.hasSignature != contact.hasSignature) || (this.hasSignature && !this.signature_.Equals(contact.signature_)))
            {
                return false;
            }
            if ((this.hasImgFlag != contact.hasImgFlag) || (this.hasImgFlag && !this.imgFlag_.Equals(contact.imgFlag_)))
            {
                return false;
            }
            if ((this.hasHDImgFlag != contact.hasHDImgFlag) || (this.hasHDImgFlag && !this.hDImgFlag_.Equals(contact.hDImgFlag_)))
            {
                return false;
            }
            if ((this.hasCountry != contact.hasCountry) || (this.hasCountry && !this.country_.Equals(contact.country_)))
            {
                return false;
            }
            if ((this.hasBigHeadImgUrl != contact.hasBigHeadImgUrl) || (this.hasBigHeadImgUrl && !this.bigHeadImgUrl_.Equals(contact.bigHeadImgUrl_)))
            {
                return false;
            }
            return ((this.hasSmallHeadImgUrl == contact.hasSmallHeadImgUrl) && (!this.hasSmallHeadImgUrl || this.smallHeadImgUrl_.Equals(contact.smallHeadImgUrl_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasUserName)
            {
                hashCode ^= this.userName_.GetHashCode();
            }
            if (this.hasType)
            {
                hashCode ^= this.type_.GetHashCode();
            }
            if (this.hasSex)
            {
                hashCode ^= this.sex_.GetHashCode();
            }
            if (this.hasCity)
            {
                hashCode ^= this.city_.GetHashCode();
            }
            if (this.hasProvince)
            {
                hashCode ^= this.province_.GetHashCode();
            }
            if (this.hasSignature)
            {
                hashCode ^= this.signature_.GetHashCode();
            }
            if (this.hasImgFlag)
            {
                hashCode ^= this.imgFlag_.GetHashCode();
            }
            if (this.hasHDImgFlag)
            {
                hashCode ^= this.hDImgFlag_.GetHashCode();
            }
            if (this.hasCountry)
            {
                hashCode ^= this.country_.GetHashCode();
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

        private ModBottleContact MakeReadOnly()
        {
            return this;
        }

        public static ModBottleContact ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<ModBottleContact, Builder>.PrintField("UserName", this.hasUserName, this.userName_, writer);
            GeneratedMessageLite<ModBottleContact, Builder>.PrintField("Type", this.hasType, this.type_, writer);
            GeneratedMessageLite<ModBottleContact, Builder>.PrintField("Sex", this.hasSex, this.sex_, writer);
            GeneratedMessageLite<ModBottleContact, Builder>.PrintField("City", this.hasCity, this.city_, writer);
            GeneratedMessageLite<ModBottleContact, Builder>.PrintField("Province", this.hasProvince, this.province_, writer);
            GeneratedMessageLite<ModBottleContact, Builder>.PrintField("Signature", this.hasSignature, this.signature_, writer);
            GeneratedMessageLite<ModBottleContact, Builder>.PrintField("ImgFlag", this.hasImgFlag, this.imgFlag_, writer);
            GeneratedMessageLite<ModBottleContact, Builder>.PrintField("HDImgFlag", this.hasHDImgFlag, this.hDImgFlag_, writer);
            GeneratedMessageLite<ModBottleContact, Builder>.PrintField("Country", this.hasCountry, this.country_, writer);
            GeneratedMessageLite<ModBottleContact, Builder>.PrintField("BigHeadImgUrl", this.hasBigHeadImgUrl, this.bigHeadImgUrl_, writer);
            GeneratedMessageLite<ModBottleContact, Builder>.PrintField("SmallHeadImgUrl", this.hasSmallHeadImgUrl, this.smallHeadImgUrl_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _modBottleContactFieldNames;
            if (this.hasUserName)
            {
                output.WriteString(1, strArray[10], this.UserName);
            }
            if (this.hasType)
            {
                output.WriteUInt32(2, strArray[9], this.Type);
            }
            if (this.hasSex)
            {
                output.WriteUInt32(3, strArray[6], this.Sex);
            }
            if (this.hasCity)
            {
                output.WriteString(4, strArray[1], this.City);
            }
            if (this.hasProvince)
            {
                output.WriteString(5, strArray[5], this.Province);
            }
            if (this.hasSignature)
            {
                output.WriteString(6, strArray[7], this.Signature);
            }
            if (this.hasImgFlag)
            {
                output.WriteUInt32(7, strArray[4], this.ImgFlag);
            }
            if (this.hasHDImgFlag)
            {
                output.WriteUInt32(8, strArray[3], this.HDImgFlag);
            }
            if (this.hasCountry)
            {
                output.WriteString(9, strArray[2], this.Country);
            }
            if (this.hasBigHeadImgUrl)
            {
                output.WriteString(10, strArray[0], this.BigHeadImgUrl);
            }
            if (this.hasSmallHeadImgUrl)
            {
                output.WriteString(11, strArray[8], this.SmallHeadImgUrl);
            }
        }

        public string BigHeadImgUrl
        {
            get
            {
                return this.bigHeadImgUrl_;
            }
        }

        public string City
        {
            get
            {
                return this.city_;
            }
        }

        public string Country
        {
            get
            {
                return this.country_;
            }
        }

        public static ModBottleContact DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override ModBottleContact DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public uint HDImgFlag
        {
            get
            {
                return this.hDImgFlag_;
            }
        }

        public uint ImgFlag
        {
            get
            {
                return this.imgFlag_;
            }
        }

        public override bool IsInitialized
        {
            get
            {
                if (!this.hasType)
                {
                    return false;
                }
                if (!this.hasSex)
                {
                    return false;
                }
                if (!this.hasImgFlag)
                {
                    return false;
                }
                if (!this.hasHDImgFlag)
                {
                    return false;
                }
                return true;
            }
        }

        public string Province
        {
            get
            {
                return this.province_;
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
                    if (this.hasType)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(2, this.Type);
                    }
                    if (this.hasSex)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(3, this.Sex);
                    }
                    if (this.hasCity)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(4, this.City);
                    }
                    if (this.hasProvince)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(5, this.Province);
                    }
                    if (this.hasSignature)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(6, this.Signature);
                    }
                    if (this.hasImgFlag)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(7, this.ImgFlag);
                    }
                    if (this.hasHDImgFlag)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(8, this.HDImgFlag);
                    }
                    if (this.hasCountry)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(9, this.Country);
                    }
                    if (this.hasBigHeadImgUrl)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(10, this.BigHeadImgUrl);
                    }
                    if (this.hasSmallHeadImgUrl)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(11, this.SmallHeadImgUrl);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        public uint Sex
        {
            get
            {
                return this.sex_;
            }
        }

        public string Signature
        {
            get
            {
                return this.signature_;
            }
        }

        public string SmallHeadImgUrl
        {
            get
            {
                return this.smallHeadImgUrl_;
            }
        }

        protected override ModBottleContact ThisMessage
        {
            get
            {
                return this;
            }
        }

        public uint Type
        {
            get
            {
                return this.type_;
            }
        }

        public string UserName
        {
            get
            {
                return this.userName_;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<ModBottleContact, ModBottleContact.Builder>
        {
            private ModBottleContact result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = ModBottleContact.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(ModBottleContact cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override ModBottleContact BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override ModBottleContact.Builder Clear()
            {
                this.result = ModBottleContact.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public ModBottleContact.Builder ClearBigHeadImgUrl()
            {
                this.PrepareBuilder();
                this.result.hasBigHeadImgUrl = false;
                this.result.bigHeadImgUrl_ = "";
                return this;
            }

            public ModBottleContact.Builder ClearCity()
            {
                this.PrepareBuilder();
                this.result.hasCity = false;
                this.result.city_ = "";
                return this;
            }

            public ModBottleContact.Builder ClearCountry()
            {
                this.PrepareBuilder();
                this.result.hasCountry = false;
                this.result.country_ = "";
                return this;
            }

            public ModBottleContact.Builder ClearHDImgFlag()
            {
                this.PrepareBuilder();
                this.result.hasHDImgFlag = false;
                this.result.hDImgFlag_ = 0;
                return this;
            }

            public ModBottleContact.Builder ClearImgFlag()
            {
                this.PrepareBuilder();
                this.result.hasImgFlag = false;
                this.result.imgFlag_ = 0;
                return this;
            }

            public ModBottleContact.Builder ClearProvince()
            {
                this.PrepareBuilder();
                this.result.hasProvince = false;
                this.result.province_ = "";
                return this;
            }

            public ModBottleContact.Builder ClearSex()
            {
                this.PrepareBuilder();
                this.result.hasSex = false;
                this.result.sex_ = 0;
                return this;
            }

            public ModBottleContact.Builder ClearSignature()
            {
                this.PrepareBuilder();
                this.result.hasSignature = false;
                this.result.signature_ = "";
                return this;
            }

            public ModBottleContact.Builder ClearSmallHeadImgUrl()
            {
                this.PrepareBuilder();
                this.result.hasSmallHeadImgUrl = false;
                this.result.smallHeadImgUrl_ = "";
                return this;
            }

            public ModBottleContact.Builder ClearType()
            {
                this.PrepareBuilder();
                this.result.hasType = false;
                this.result.type_ = 0;
                return this;
            }

            public ModBottleContact.Builder ClearUserName()
            {
                this.PrepareBuilder();
                this.result.hasUserName = false;
                this.result.userName_ = "";
                return this;
            }

            public override ModBottleContact.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new ModBottleContact.Builder(this.result);
                }
                return new ModBottleContact.Builder().MergeFrom(this.result);
            }

            public override ModBottleContact.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override ModBottleContact.Builder MergeFrom(IMessageLite other)
            {
                if (other is ModBottleContact)
                {
                    return this.MergeFrom((ModBottleContact) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override ModBottleContact.Builder MergeFrom(ModBottleContact other)
            {
                return this;
            }

            public override ModBottleContact.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(ModBottleContact._modBottleContactFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = ModBottleContact._modBottleContactFieldTags[index];
                        }
                        else
                        {
                            this.ParseUnknownField(input, extensionRegistry, num, str);
                            continue;
                        }
                    }
                    switch (num)
                    {
                        case 0x18:
                        {
                            this.result.hasSex = input.ReadUInt32(ref this.result.sex_);
                            continue;
                        }
                        case 0x22:
                        {
                            this.result.hasCity = input.ReadString(ref this.result.city_);
                            continue;
                        }
                        case 0x2a:
                        {
                            this.result.hasProvince = input.ReadString(ref this.result.province_);
                            continue;
                        }
                        case 0:
                            throw InvalidProtocolBufferException.InvalidTag();

                        case 10:
                        {
                            this.result.hasUserName = input.ReadString(ref this.result.userName_);
                            continue;
                        }
                        case 0x10:
                        {
                            this.result.hasType = input.ReadUInt32(ref this.result.type_);
                            continue;
                        }
                        case 50:
                        {
                            this.result.hasSignature = input.ReadString(ref this.result.signature_);
                            continue;
                        }
                        case 0x38:
                        {
                            this.result.hasImgFlag = input.ReadUInt32(ref this.result.imgFlag_);
                            continue;
                        }
                        case 0x40:
                        {
                            this.result.hasHDImgFlag = input.ReadUInt32(ref this.result.hDImgFlag_);
                            continue;
                        }
                        case 0x4a:
                        {
                            this.result.hasCountry = input.ReadString(ref this.result.country_);
                            continue;
                        }
                        case 0x52:
                        {
                            this.result.hasBigHeadImgUrl = input.ReadString(ref this.result.bigHeadImgUrl_);
                            continue;
                        }
                        case 90:
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

            private ModBottleContact PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    ModBottleContact result = this.result;
                    this.result = new ModBottleContact();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public ModBottleContact.Builder SetBigHeadImgUrl(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBigHeadImgUrl = true;
                this.result.bigHeadImgUrl_ = value;
                return this;
            }

            public ModBottleContact.Builder SetCity(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasCity = true;
                this.result.city_ = value;
                return this;
            }

            public ModBottleContact.Builder SetCountry(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasCountry = true;
                this.result.country_ = value;
                return this;
            }

            public ModBottleContact.Builder SetHDImgFlag(uint value)
            {
                this.PrepareBuilder();
                this.result.hasHDImgFlag = true;
                this.result.hDImgFlag_ = value;
                return this;
            }

            public ModBottleContact.Builder SetImgFlag(uint value)
            {
                this.PrepareBuilder();
                this.result.hasImgFlag = true;
                this.result.imgFlag_ = value;
                return this;
            }

            public ModBottleContact.Builder SetProvince(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasProvince = true;
                this.result.province_ = value;
                return this;
            }

            public ModBottleContact.Builder SetSex(uint value)
            {
                this.PrepareBuilder();
                this.result.hasSex = true;
                this.result.sex_ = value;
                return this;
            }

            public ModBottleContact.Builder SetSignature(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSignature = true;
                this.result.signature_ = value;
                return this;
            }

            public ModBottleContact.Builder SetSmallHeadImgUrl(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSmallHeadImgUrl = true;
                this.result.smallHeadImgUrl_ = value;
                return this;
            }

            public ModBottleContact.Builder SetType(uint value)
            {
                this.PrepareBuilder();
                this.result.hasType = true;
                this.result.type_ = value;
                return this;
            }

            public ModBottleContact.Builder SetUserName(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasUserName = true;
                this.result.userName_ = value;
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

            public string City
            {
                get
                {
                    return this.result.City;
                }
                set
                {
                    this.SetCity(value);
                }
            }

            public string Country
            {
                get
                {
                    return this.result.Country;
                }
                set
                {
                    this.SetCountry(value);
                }
            }

            public override ModBottleContact DefaultInstanceForType
            {
                get
                {
                    return ModBottleContact.DefaultInstance;
                }
            }

            public uint HDImgFlag
            {
                get
                {
                    return this.result.HDImgFlag;
                }
                set
                {
                    this.SetHDImgFlag(value);
                }
            }

            public uint ImgFlag
            {
                get
                {
                    return this.result.ImgFlag;
                }
                set
                {
                    this.SetImgFlag(value);
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override ModBottleContact MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public string Province
            {
                get
                {
                    return this.result.Province;
                }
                set
                {
                    this.SetProvince(value);
                }
            }

            public uint Sex
            {
                get
                {
                    return this.result.Sex;
                }
                set
                {
                    this.SetSex(value);
                }
            }

            public string Signature
            {
                get
                {
                    return this.result.Signature;
                }
                set
                {
                    this.SetSignature(value);
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

            protected override ModBottleContact.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }

            public uint Type
            {
                get
                {
                    return this.result.Type;
                }
                set
                {
                    this.SetType(value);
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


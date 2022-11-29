namespace micromsg
{
    using Google.ProtocolBuffers;
    
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

    //
    public sealed class MemberResp : GeneratedMessageLite<MemberResp, MemberResp.Builder>
    {
        private static readonly string[] _memberRespFieldNames = new string[] { 
            "City", "ContactType", "Country", "MemberName", "MemberStatus", "NickName", "PYInitial", "PersonalCard", "Province", "QuanPin", "Remark", "RemarkPYInitial", "RemarkQuanPin", "Sex", "Signature", "VerifyFlag", 
            "VerifyInfo"
         };
        private static readonly uint[] _memberRespFieldTags = new uint[] { 
            0x72, 0x60, 0x9a, 10, 0x10, 0x1a, 0x22, 0x80, 0x6a, 0x2a, 0x4a, 0x52, 90, 0x30, 0x7a, 0x88, 
            0x92
         };
        private string city_ = "";
        public const int CityFieldNumber = 14;
        private uint contactType_;
        public const int ContactTypeFieldNumber = 12;
        private string country_ = "";
        public const int CountryFieldNumber = 0x13;
        private static readonly MemberResp defaultInstance = new MemberResp().MakeReadOnly();
        private bool hasCity;
        private bool hasContactType;
        private bool hasCountry;
        private bool hasMemberName;
        private bool hasMemberStatus;
        private bool hasNickName;
        private bool hasPersonalCard;
        private bool hasProvince;
        private bool hasPYInitial;
        private bool hasQuanPin;
        private bool hasRemark;
        private bool hasRemarkPYInitial;
        private bool hasRemarkQuanPin;
        private bool hasSex;
        private bool hasSignature;
        private bool hasVerifyFlag;
        private bool hasVerifyInfo;
        private SKBuiltinString_t memberName_;
        public const int MemberNameFieldNumber = 1;
        private uint memberStatus_;
        public const int MemberStatusFieldNumber = 2;
        private int memoizedSerializedSize = -1;
        private SKBuiltinString_t nickName_;
        public const int NickNameFieldNumber = 3;
        private uint personalCard_;
        public const int PersonalCardFieldNumber = 0x10;
        private string province_ = "";
        public const int ProvinceFieldNumber = 13;
        private SKBuiltinString_t pYInitial_;
        public const int PYInitialFieldNumber = 4;
        private SKBuiltinString_t quanPin_;
        public const int QuanPinFieldNumber = 5;
        private SKBuiltinString_t remark_;
        public const int RemarkFieldNumber = 9;
        private SKBuiltinString_t remarkPYInitial_;
        public const int RemarkPYInitialFieldNumber = 10;
        private SKBuiltinString_t remarkQuanPin_;
        public const int RemarkQuanPinFieldNumber = 11;
        private int sex_;
        public const int SexFieldNumber = 6;
        private string signature_ = "";
        public const int SignatureFieldNumber = 15;
        private uint verifyFlag_;
        public const int VerifyFlagFieldNumber = 0x11;
        private string verifyInfo_ = "";
        public const int VerifyInfoFieldNumber = 0x12;

        static MemberResp()
        {
            //object.ReferenceEquals(MemberResp.Descriptor, null);
        }

        private MemberResp()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(MemberResp prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            MemberResp resp = obj as MemberResp;
            if (resp == null)
            {
                return false;
            }
            if ((this.hasMemberName != resp.hasMemberName) || (this.hasMemberName && !this.memberName_.Equals(resp.memberName_)))
            {
                return false;
            }
            if ((this.hasMemberStatus != resp.hasMemberStatus) || (this.hasMemberStatus && !this.memberStatus_.Equals(resp.memberStatus_)))
            {
                return false;
            }
            if ((this.hasNickName != resp.hasNickName) || (this.hasNickName && !this.nickName_.Equals(resp.nickName_)))
            {
                return false;
            }
            if ((this.hasPYInitial != resp.hasPYInitial) || (this.hasPYInitial && !this.pYInitial_.Equals(resp.pYInitial_)))
            {
                return false;
            }
            if ((this.hasQuanPin != resp.hasQuanPin) || (this.hasQuanPin && !this.quanPin_.Equals(resp.quanPin_)))
            {
                return false;
            }
            if ((this.hasSex != resp.hasSex) || (this.hasSex && !this.sex_.Equals(resp.sex_)))
            {
                return false;
            }
            if ((this.hasRemark != resp.hasRemark) || (this.hasRemark && !this.remark_.Equals(resp.remark_)))
            {
                return false;
            }
            if ((this.hasRemarkPYInitial != resp.hasRemarkPYInitial) || (this.hasRemarkPYInitial && !this.remarkPYInitial_.Equals(resp.remarkPYInitial_)))
            {
                return false;
            }
            if ((this.hasRemarkQuanPin != resp.hasRemarkQuanPin) || (this.hasRemarkQuanPin && !this.remarkQuanPin_.Equals(resp.remarkQuanPin_)))
            {
                return false;
            }
            if ((this.hasContactType != resp.hasContactType) || (this.hasContactType && !this.contactType_.Equals(resp.contactType_)))
            {
                return false;
            }
            if ((this.hasProvince != resp.hasProvince) || (this.hasProvince && !this.province_.Equals(resp.province_)))
            {
                return false;
            }
            if ((this.hasCity != resp.hasCity) || (this.hasCity && !this.city_.Equals(resp.city_)))
            {
                return false;
            }
            if ((this.hasSignature != resp.hasSignature) || (this.hasSignature && !this.signature_.Equals(resp.signature_)))
            {
                return false;
            }
            if ((this.hasPersonalCard != resp.hasPersonalCard) || (this.hasPersonalCard && !this.personalCard_.Equals(resp.personalCard_)))
            {
                return false;
            }
            if ((this.hasVerifyFlag != resp.hasVerifyFlag) || (this.hasVerifyFlag && !this.verifyFlag_.Equals(resp.verifyFlag_)))
            {
                return false;
            }
            if ((this.hasVerifyInfo != resp.hasVerifyInfo) || (this.hasVerifyInfo && !this.verifyInfo_.Equals(resp.verifyInfo_)))
            {
                return false;
            }
            return ((this.hasCountry == resp.hasCountry) && (!this.hasCountry || this.country_.Equals(resp.country_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasMemberName)
            {
                hashCode ^= this.memberName_.GetHashCode();
            }
            if (this.hasMemberStatus)
            {
                hashCode ^= this.memberStatus_.GetHashCode();
            }
            if (this.hasNickName)
            {
                hashCode ^= this.nickName_.GetHashCode();
            }
            if (this.hasPYInitial)
            {
                hashCode ^= this.pYInitial_.GetHashCode();
            }
            if (this.hasQuanPin)
            {
                hashCode ^= this.quanPin_.GetHashCode();
            }
            if (this.hasSex)
            {
                hashCode ^= this.sex_.GetHashCode();
            }
            if (this.hasRemark)
            {
                hashCode ^= this.remark_.GetHashCode();
            }
            if (this.hasRemarkPYInitial)
            {
                hashCode ^= this.remarkPYInitial_.GetHashCode();
            }
            if (this.hasRemarkQuanPin)
            {
                hashCode ^= this.remarkQuanPin_.GetHashCode();
            }
            if (this.hasContactType)
            {
                hashCode ^= this.contactType_.GetHashCode();
            }
            if (this.hasProvince)
            {
                hashCode ^= this.province_.GetHashCode();
            }
            if (this.hasCity)
            {
                hashCode ^= this.city_.GetHashCode();
            }
            if (this.hasSignature)
            {
                hashCode ^= this.signature_.GetHashCode();
            }
            if (this.hasPersonalCard)
            {
                hashCode ^= this.personalCard_.GetHashCode();
            }
            if (this.hasVerifyFlag)
            {
                hashCode ^= this.verifyFlag_.GetHashCode();
            }
            if (this.hasVerifyInfo)
            {
                hashCode ^= this.verifyInfo_.GetHashCode();
            }
            if (this.hasCountry)
            {
                hashCode ^= this.country_.GetHashCode();
            }
            return hashCode;
        }

        private MemberResp MakeReadOnly()
        {
            return this;
        }

        public static MemberResp ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<MemberResp, Builder>.PrintField("MemberName", this.hasMemberName, this.memberName_, writer);
            GeneratedMessageLite<MemberResp, Builder>.PrintField("MemberStatus", this.hasMemberStatus, this.memberStatus_, writer);
            GeneratedMessageLite<MemberResp, Builder>.PrintField("NickName", this.hasNickName, this.nickName_, writer);
            GeneratedMessageLite<MemberResp, Builder>.PrintField("PYInitial", this.hasPYInitial, this.pYInitial_, writer);
            GeneratedMessageLite<MemberResp, Builder>.PrintField("QuanPin", this.hasQuanPin, this.quanPin_, writer);
            GeneratedMessageLite<MemberResp, Builder>.PrintField("Sex", this.hasSex, this.sex_, writer);
            GeneratedMessageLite<MemberResp, Builder>.PrintField("Remark", this.hasRemark, this.remark_, writer);
            GeneratedMessageLite<MemberResp, Builder>.PrintField("RemarkPYInitial", this.hasRemarkPYInitial, this.remarkPYInitial_, writer);
            GeneratedMessageLite<MemberResp, Builder>.PrintField("RemarkQuanPin", this.hasRemarkQuanPin, this.remarkQuanPin_, writer);
            GeneratedMessageLite<MemberResp, Builder>.PrintField("ContactType", this.hasContactType, this.contactType_, writer);
            GeneratedMessageLite<MemberResp, Builder>.PrintField("Province", this.hasProvince, this.province_, writer);
            GeneratedMessageLite<MemberResp, Builder>.PrintField("City", this.hasCity, this.city_, writer);
            GeneratedMessageLite<MemberResp, Builder>.PrintField("Signature", this.hasSignature, this.signature_, writer);
            GeneratedMessageLite<MemberResp, Builder>.PrintField("PersonalCard", this.hasPersonalCard, this.personalCard_, writer);
            GeneratedMessageLite<MemberResp, Builder>.PrintField("VerifyFlag", this.hasVerifyFlag, this.verifyFlag_, writer);
            GeneratedMessageLite<MemberResp, Builder>.PrintField("VerifyInfo", this.hasVerifyInfo, this.verifyInfo_, writer);
            GeneratedMessageLite<MemberResp, Builder>.PrintField("Country", this.hasCountry, this.country_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _memberRespFieldNames;
            if (this.hasMemberName)
            {
                output.WriteMessage(1, strArray[3], this.MemberName);
            }
            if (this.hasMemberStatus)
            {
                output.WriteUInt32(2, strArray[4], this.MemberStatus);
            }
            if (this.hasNickName)
            {
                output.WriteMessage(3, strArray[5], this.NickName);
            }
            if (this.hasPYInitial)
            {
                output.WriteMessage(4, strArray[6], this.PYInitial);
            }
            if (this.hasQuanPin)
            {
                output.WriteMessage(5, strArray[9], this.QuanPin);
            }
            if (this.hasSex)
            {
                output.WriteInt32(6, strArray[13], this.Sex);
            }
            if (this.hasRemark)
            {
                output.WriteMessage(9, strArray[10], this.Remark);
            }
            if (this.hasRemarkPYInitial)
            {
                output.WriteMessage(10, strArray[11], this.RemarkPYInitial);
            }
            if (this.hasRemarkQuanPin)
            {
                output.WriteMessage(11, strArray[12], this.RemarkQuanPin);
            }
            if (this.hasContactType)
            {
                output.WriteUInt32(12, strArray[1], this.ContactType);
            }
            if (this.hasProvince)
            {
                output.WriteString(13, strArray[8], this.Province);
            }
            if (this.hasCity)
            {
                output.WriteString(14, strArray[0], this.City);
            }
            if (this.hasSignature)
            {
                output.WriteString(15, strArray[14], this.Signature);
            }
            if (this.hasPersonalCard)
            {
                output.WriteUInt32(0x10, strArray[7], this.PersonalCard);
            }
            if (this.hasVerifyFlag)
            {
                output.WriteUInt32(0x11, strArray[15], this.VerifyFlag);
            }
            if (this.hasVerifyInfo)
            {
                output.WriteString(0x12, strArray[0x10], this.VerifyInfo);
            }
            if (this.hasCountry)
            {
                output.WriteString(0x13, strArray[2], this.Country);
            }
        }

        public string City
        {
            get
            {
                return this.city_;
            }
        }

        public uint ContactType
        {
            get
            {
                return this.contactType_;
            }
        }

        public string Country
        {
            get
            {
                return this.country_;
            }
        }

        public static MemberResp DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override MemberResp DefaultInstanceForType
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
                if (!this.hasMemberName)
                {
                    return false;
                }
                if (!this.hasMemberStatus)
                {
                    return false;
                }
                if (!this.hasNickName)
                {
                    return false;
                }
                if (!this.hasPYInitial)
                {
                    return false;
                }
                if (!this.hasQuanPin)
                {
                    return false;
                }
                if (!this.hasSex)
                {
                    return false;
                }
                if (!this.hasRemark)
                {
                    return false;
                }
                if (!this.hasRemarkPYInitial)
                {
                    return false;
                }
                if (!this.hasRemarkQuanPin)
                {
                    return false;
                }
                if (!this.hasContactType)
                {
                    return false;
                }
                return true;
            }
        }

        public SKBuiltinString_t MemberName
        {
            get
            {
                return (this.memberName_ ?? SKBuiltinString_t.DefaultInstance);
            }
        }

        public uint MemberStatus
        {
            get
            {
                return this.memberStatus_;
            }
        }

        public SKBuiltinString_t NickName
        {
            get
            {
                return (this.nickName_ ?? SKBuiltinString_t.DefaultInstance);
            }
        }

        public uint PersonalCard
        {
            get
            {
                return this.personalCard_;
            }
        }

        public string Province
        {
            get
            {
                return this.province_;
            }
        }

        public SKBuiltinString_t PYInitial
        {
            get
            {
                return (this.pYInitial_ ?? SKBuiltinString_t.DefaultInstance);
            }
        }

        public SKBuiltinString_t QuanPin
        {
            get
            {
                return (this.quanPin_ ?? SKBuiltinString_t.DefaultInstance);
            }
        }

        public SKBuiltinString_t Remark
        {
            get
            {
                return (this.remark_ ?? SKBuiltinString_t.DefaultInstance);
            }
        }

        public SKBuiltinString_t RemarkPYInitial
        {
            get
            {
                return (this.remarkPYInitial_ ?? SKBuiltinString_t.DefaultInstance);
            }
        }

        public SKBuiltinString_t RemarkQuanPin
        {
            get
            {
                return (this.remarkQuanPin_ ?? SKBuiltinString_t.DefaultInstance);
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
                    if (this.hasMemberName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(1, this.MemberName);
                    }
                    if (this.hasMemberStatus)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(2, this.MemberStatus);
                    }
                    if (this.hasNickName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(3, this.NickName);
                    }
                    if (this.hasPYInitial)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(4, this.PYInitial);
                    }
                    if (this.hasQuanPin)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(5, this.QuanPin);
                    }
                    if (this.hasSex)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(6, this.Sex);
                    }
                    if (this.hasRemark)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(9, this.Remark);
                    }
                    if (this.hasRemarkPYInitial)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(10, this.RemarkPYInitial);
                    }
                    if (this.hasRemarkQuanPin)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(11, this.RemarkQuanPin);
                    }
                    if (this.hasContactType)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(12, this.ContactType);
                    }
                    if (this.hasProvince)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(13, this.Province);
                    }
                    if (this.hasCity)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(14, this.City);
                    }
                    if (this.hasSignature)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(15, this.Signature);
                    }
                    if (this.hasPersonalCard)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(0x10, this.PersonalCard);
                    }
                    if (this.hasVerifyFlag)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(0x11, this.VerifyFlag);
                    }
                    if (this.hasVerifyInfo)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x12, this.VerifyInfo);
                    }
                    if (this.hasCountry)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x13, this.Country);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        public int Sex
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

        protected override MemberResp ThisMessage
        {
            get
            {
                return this;
            }
        }

        public uint VerifyFlag
        {
            get
            {
                return this.verifyFlag_;
            }
        }

        public string VerifyInfo
        {
            get
            {
                return this.verifyInfo_;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<MemberResp, MemberResp.Builder>
        {
            private MemberResp result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = MemberResp.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(MemberResp cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override MemberResp BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override MemberResp.Builder Clear()
            {
                this.result = MemberResp.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public MemberResp.Builder ClearCity()
            {
                this.PrepareBuilder();
                this.result.hasCity = false;
                this.result.city_ = "";
                return this;
            }

            public MemberResp.Builder ClearContactType()
            {
                this.PrepareBuilder();
                this.result.hasContactType = false;
                this.result.contactType_ = 0;
                return this;
            }

            public MemberResp.Builder ClearCountry()
            {
                this.PrepareBuilder();
                this.result.hasCountry = false;
                this.result.country_ = "";
                return this;
            }

            public MemberResp.Builder ClearMemberName()
            {
                this.PrepareBuilder();
                this.result.hasMemberName = false;
                this.result.memberName_ = null;
                return this;
            }

            public MemberResp.Builder ClearMemberStatus()
            {
                this.PrepareBuilder();
                this.result.hasMemberStatus = false;
                this.result.memberStatus_ = 0;
                return this;
            }

            public MemberResp.Builder ClearNickName()
            {
                this.PrepareBuilder();
                this.result.hasNickName = false;
                this.result.nickName_ = null;
                return this;
            }

            public MemberResp.Builder ClearPersonalCard()
            {
                this.PrepareBuilder();
                this.result.hasPersonalCard = false;
                this.result.personalCard_ = 0;
                return this;
            }

            public MemberResp.Builder ClearProvince()
            {
                this.PrepareBuilder();
                this.result.hasProvince = false;
                this.result.province_ = "";
                return this;
            }

            public MemberResp.Builder ClearPYInitial()
            {
                this.PrepareBuilder();
                this.result.hasPYInitial = false;
                this.result.pYInitial_ = null;
                return this;
            }

            public MemberResp.Builder ClearQuanPin()
            {
                this.PrepareBuilder();
                this.result.hasQuanPin = false;
                this.result.quanPin_ = null;
                return this;
            }

            public MemberResp.Builder ClearRemark()
            {
                this.PrepareBuilder();
                this.result.hasRemark = false;
                this.result.remark_ = null;
                return this;
            }

            public MemberResp.Builder ClearRemarkPYInitial()
            {
                this.PrepareBuilder();
                this.result.hasRemarkPYInitial = false;
                this.result.remarkPYInitial_ = null;
                return this;
            }

            public MemberResp.Builder ClearRemarkQuanPin()
            {
                this.PrepareBuilder();
                this.result.hasRemarkQuanPin = false;
                this.result.remarkQuanPin_ = null;
                return this;
            }

            public MemberResp.Builder ClearSex()
            {
                this.PrepareBuilder();
                this.result.hasSex = false;
                this.result.sex_ = 0;
                return this;
            }

            public MemberResp.Builder ClearSignature()
            {
                this.PrepareBuilder();
                this.result.hasSignature = false;
                this.result.signature_ = "";
                return this;
            }

            public MemberResp.Builder ClearVerifyFlag()
            {
                this.PrepareBuilder();
                this.result.hasVerifyFlag = false;
                this.result.verifyFlag_ = 0;
                return this;
            }

            public MemberResp.Builder ClearVerifyInfo()
            {
                this.PrepareBuilder();
                this.result.hasVerifyInfo = false;
                this.result.verifyInfo_ = "";
                return this;
            }

            public override MemberResp.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new MemberResp.Builder(this.result);
                }
                return new MemberResp.Builder().MergeFrom(this.result);
            }

            public override MemberResp.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override MemberResp.Builder MergeFrom(IMessageLite other)
            {
                if (other is MemberResp)
                {
                    return this.MergeFrom((MemberResp) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override MemberResp.Builder MergeFrom(MemberResp other)
            {
                return this;
            }

            public override MemberResp.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(MemberResp._memberRespFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = MemberResp._memberRespFieldTags[index];
                        }
                        else
                        {
                            this.ParseUnknownField(input, extensionRegistry, num, str);
                            continue;
                        }
                    }
                    switch (num)
                    {
                        case 0x10:
                        {
                            this.result.hasMemberStatus = input.ReadUInt32(ref this.result.memberStatus_);
                            continue;
                        }
                        case 0x1a:
                        {
                            SKBuiltinString_t.Builder builder2 = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasNickName)
                            {
                                builder2.MergeFrom(this.NickName);
                            }
                            input.ReadMessage(builder2, extensionRegistry);
                            this.NickName = builder2.BuildPartial();
                            continue;
                        }
                        case 0:
                            throw InvalidProtocolBufferException.InvalidTag();

                        case 10:
                        {
                            SKBuiltinString_t.Builder builder = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasMemberName)
                            {
                                builder.MergeFrom(this.MemberName);
                            }
                            input.ReadMessage(builder, extensionRegistry);
                            this.MemberName = builder.BuildPartial();
                            continue;
                        }
                        case 0x22:
                        {
                            SKBuiltinString_t.Builder builder3 = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasPYInitial)
                            {
                                builder3.MergeFrom(this.PYInitial);
                            }
                            input.ReadMessage(builder3, extensionRegistry);
                            this.PYInitial = builder3.BuildPartial();
                            continue;
                        }
                        case 0x2a:
                        {
                            SKBuiltinString_t.Builder builder4 = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasQuanPin)
                            {
                                builder4.MergeFrom(this.QuanPin);
                            }
                            input.ReadMessage(builder4, extensionRegistry);
                            this.QuanPin = builder4.BuildPartial();
                            continue;
                        }
                        case 0x30:
                        {
                            this.result.hasSex = input.ReadInt32(ref this.result.sex_);
                            continue;
                        }
                        case 0x4a:
                        {
                            SKBuiltinString_t.Builder builder5 = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasRemark)
                            {
                                builder5.MergeFrom(this.Remark);
                            }
                            input.ReadMessage(builder5, extensionRegistry);
                            this.Remark = builder5.BuildPartial();
                            continue;
                        }
                        case 0x52:
                        {
                            SKBuiltinString_t.Builder builder6 = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasRemarkPYInitial)
                            {
                                builder6.MergeFrom(this.RemarkPYInitial);
                            }
                            input.ReadMessage(builder6, extensionRegistry);
                            this.RemarkPYInitial = builder6.BuildPartial();
                            continue;
                        }
                        case 0x6a:
                        {
                            this.result.hasProvince = input.ReadString(ref this.result.province_);
                            continue;
                        }
                        case 0x72:
                        {
                            this.result.hasCity = input.ReadString(ref this.result.city_);
                            continue;
                        }
                        case 90:
                        {
                            SKBuiltinString_t.Builder builder7 = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasRemarkQuanPin)
                            {
                                builder7.MergeFrom(this.RemarkQuanPin);
                            }
                            input.ReadMessage(builder7, extensionRegistry);
                            this.RemarkQuanPin = builder7.BuildPartial();
                            continue;
                        }
                        case 0x60:
                        {
                            this.result.hasContactType = input.ReadUInt32(ref this.result.contactType_);
                            continue;
                        }
                        case 0x7a:
                        {
                            this.result.hasSignature = input.ReadString(ref this.result.signature_);
                            continue;
                        }
                        case 0x80:
                        {
                            this.result.hasPersonalCard = input.ReadUInt32(ref this.result.personalCard_);
                            continue;
                        }
                        case 0x88:
                        {
                            this.result.hasVerifyFlag = input.ReadUInt32(ref this.result.verifyFlag_);
                            continue;
                        }
                        case 0x92:
                        {
                            this.result.hasVerifyInfo = input.ReadString(ref this.result.verifyInfo_);
                            continue;
                        }
                        case 0x9a:
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
                    this.result.hasCountry = input.ReadString(ref this.result.country_);
                }
                return this;
            }

            public MemberResp.Builder MergeMemberName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasMemberName && (this.result.memberName_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.memberName_ = SKBuiltinString_t.CreateBuilder(this.result.memberName_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.memberName_ = value;
                }
                this.result.hasMemberName = true;
                return this;
            }

            public MemberResp.Builder MergeNickName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasNickName && (this.result.nickName_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.nickName_ = SKBuiltinString_t.CreateBuilder(this.result.nickName_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.nickName_ = value;
                }
                this.result.hasNickName = true;
                return this;
            }

            public MemberResp.Builder MergePYInitial(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasPYInitial && (this.result.pYInitial_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.pYInitial_ = SKBuiltinString_t.CreateBuilder(this.result.pYInitial_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.pYInitial_ = value;
                }
                this.result.hasPYInitial = true;
                return this;
            }

            public MemberResp.Builder MergeQuanPin(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasQuanPin && (this.result.quanPin_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.quanPin_ = SKBuiltinString_t.CreateBuilder(this.result.quanPin_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.quanPin_ = value;
                }
                this.result.hasQuanPin = true;
                return this;
            }

            public MemberResp.Builder MergeRemark(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasRemark && (this.result.remark_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.remark_ = SKBuiltinString_t.CreateBuilder(this.result.remark_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.remark_ = value;
                }
                this.result.hasRemark = true;
                return this;
            }

            public MemberResp.Builder MergeRemarkPYInitial(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasRemarkPYInitial && (this.result.remarkPYInitial_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.remarkPYInitial_ = SKBuiltinString_t.CreateBuilder(this.result.remarkPYInitial_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.remarkPYInitial_ = value;
                }
                this.result.hasRemarkPYInitial = true;
                return this;
            }

            public MemberResp.Builder MergeRemarkQuanPin(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasRemarkQuanPin && (this.result.remarkQuanPin_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.remarkQuanPin_ = SKBuiltinString_t.CreateBuilder(this.result.remarkQuanPin_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.remarkQuanPin_ = value;
                }
                this.result.hasRemarkQuanPin = true;
                return this;
            }

            private MemberResp PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    MemberResp result = this.result;
                    this.result = new MemberResp();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public MemberResp.Builder SetCity(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasCity = true;
                this.result.city_ = value;
                return this;
            }

            public MemberResp.Builder SetContactType(uint value)
            {
                this.PrepareBuilder();
                this.result.hasContactType = true;
                this.result.contactType_ = value;
                return this;
            }

            public MemberResp.Builder SetCountry(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasCountry = true;
                this.result.country_ = value;
                return this;
            }

            public MemberResp.Builder SetMemberName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasMemberName = true;
                this.result.memberName_ = value;
                return this;
            }

            public MemberResp.Builder SetMemberName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasMemberName = true;
                this.result.memberName_ = builderForValue.Build();
                return this;
            }

            public MemberResp.Builder SetMemberStatus(uint value)
            {
                this.PrepareBuilder();
                this.result.hasMemberStatus = true;
                this.result.memberStatus_ = value;
                return this;
            }

            public MemberResp.Builder SetNickName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasNickName = true;
                this.result.nickName_ = value;
                return this;
            }

            public MemberResp.Builder SetNickName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasNickName = true;
                this.result.nickName_ = builderForValue.Build();
                return this;
            }

            public MemberResp.Builder SetPersonalCard(uint value)
            {
                this.PrepareBuilder();
                this.result.hasPersonalCard = true;
                this.result.personalCard_ = value;
                return this;
            }

            public MemberResp.Builder SetProvince(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasProvince = true;
                this.result.province_ = value;
                return this;
            }

            public MemberResp.Builder SetPYInitial(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasPYInitial = true;
                this.result.pYInitial_ = value;
                return this;
            }

            public MemberResp.Builder SetPYInitial(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasPYInitial = true;
                this.result.pYInitial_ = builderForValue.Build();
                return this;
            }

            public MemberResp.Builder SetQuanPin(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasQuanPin = true;
                this.result.quanPin_ = value;
                return this;
            }

            public MemberResp.Builder SetQuanPin(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasQuanPin = true;
                this.result.quanPin_ = builderForValue.Build();
                return this;
            }

            public MemberResp.Builder SetRemark(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasRemark = true;
                this.result.remark_ = value;
                return this;
            }

            public MemberResp.Builder SetRemark(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasRemark = true;
                this.result.remark_ = builderForValue.Build();
                return this;
            }

            public MemberResp.Builder SetRemarkPYInitial(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasRemarkPYInitial = true;
                this.result.remarkPYInitial_ = value;
                return this;
            }

            public MemberResp.Builder SetRemarkPYInitial(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasRemarkPYInitial = true;
                this.result.remarkPYInitial_ = builderForValue.Build();
                return this;
            }

            public MemberResp.Builder SetRemarkQuanPin(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasRemarkQuanPin = true;
                this.result.remarkQuanPin_ = value;
                return this;
            }

            public MemberResp.Builder SetRemarkQuanPin(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasRemarkQuanPin = true;
                this.result.remarkQuanPin_ = builderForValue.Build();
                return this;
            }

            public MemberResp.Builder SetSex(int value)
            {
                this.PrepareBuilder();
                this.result.hasSex = true;
                this.result.sex_ = value;
                return this;
            }

            public MemberResp.Builder SetSignature(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSignature = true;
                this.result.signature_ = value;
                return this;
            }

            public MemberResp.Builder SetVerifyFlag(uint value)
            {
                this.PrepareBuilder();
                this.result.hasVerifyFlag = true;
                this.result.verifyFlag_ = value;
                return this;
            }

            public MemberResp.Builder SetVerifyInfo(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasVerifyInfo = true;
                this.result.verifyInfo_ = value;
                return this;
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

            public uint ContactType
            {
                get
                {
                    return this.result.ContactType;
                }
                set
                {
                    this.SetContactType(value);
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

            public override MemberResp DefaultInstanceForType
            {
                get
                {
                    return MemberResp.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            public SKBuiltinString_t MemberName
            {
                get
                {
                    return this.result.MemberName;
                }
                set
                {
                    this.SetMemberName(value);
                }
            }

            public uint MemberStatus
            {
                get
                {
                    return this.result.MemberStatus;
                }
                set
                {
                    this.SetMemberStatus(value);
                }
            }

            protected override MemberResp MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public SKBuiltinString_t NickName
            {
                get
                {
                    return this.result.NickName;
                }
                set
                {
                    this.SetNickName(value);
                }
            }

            public uint PersonalCard
            {
                get
                {
                    return this.result.PersonalCard;
                }
                set
                {
                    this.SetPersonalCard(value);
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

            public SKBuiltinString_t PYInitial
            {
                get
                {
                    return this.result.PYInitial;
                }
                set
                {
                    this.SetPYInitial(value);
                }
            }

            public SKBuiltinString_t QuanPin
            {
                get
                {
                    return this.result.QuanPin;
                }
                set
                {
                    this.SetQuanPin(value);
                }
            }

            public SKBuiltinString_t Remark
            {
                get
                {
                    return this.result.Remark;
                }
                set
                {
                    this.SetRemark(value);
                }
            }

            public SKBuiltinString_t RemarkPYInitial
            {
                get
                {
                    return this.result.RemarkPYInitial;
                }
                set
                {
                    this.SetRemarkPYInitial(value);
                }
            }

            public SKBuiltinString_t RemarkQuanPin
            {
                get
                {
                    return this.result.RemarkQuanPin;
                }
                set
                {
                    this.SetRemarkQuanPin(value);
                }
            }

            public int Sex
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

            protected override MemberResp.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }

            public uint VerifyFlag
            {
                get
                {
                    return this.result.VerifyFlag;
                }
                set
                {
                    this.SetVerifyFlag(value);
                }
            }

            public string VerifyInfo
            {
                get
                {
                    return this.result.VerifyInfo;
                }
                set
                {
                    this.SetVerifyInfo(value);
                }
            }
        }
    }
}


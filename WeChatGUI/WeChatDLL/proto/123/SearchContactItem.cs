namespace micromsg
{
    using Google.ProtocolBuffers;
 
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    


    public sealed class SearchContactItem : GeneratedMessageLite<SearchContactItem, SearchContactItem.Builder>
    {
        private static readonly string[] _searchContactItemFieldNames = new string[] { 
            "AlbumBGImgID", "AlbumFlag", "AlbumStyle", "Alias", "BigHeadImgUrl", "City", "Country", "CustomizedInfo", "ImgBuf", "MyBrandList", "NickName", "PYInitial", "PersonalCard", "Province", "QuanPin", "Sex", 
            "Signature", "SmallHeadImgUrl", "SnsUserInfo", "UserName", "VerifyFlag", "VerifyInfo", "Weibo", "WeiboFlag", "WeiboNickname"
         };
        private static readonly uint[] _searchContactItemFieldTags = new uint[] { 
            0x9a, 0x90, 0x88, 0x72, 0xc2, 0x42, 170, 0xba, 50, 0xb2, 0x12, 0x1a, 80, 0x3a, 0x22, 40, 
            0x4a, 0xca, 0xa2, 10, 0x58, 0x62, 0x6a, 0x80, 0x7a
         };
        private string albumBGImgID_ = "";
        public const int AlbumBGImgIDFieldNumber = 0x13;
        private int albumFlag_;
        public const int AlbumFlagFieldNumber = 0x12;
        private int albumStyle_;
        public const int AlbumStyleFieldNumber = 0x11;
        private string alias_ = "";
        public const int AliasFieldNumber = 14;
        private string bigHeadImgUrl_ = "";
        public const int BigHeadImgUrlFieldNumber = 0x18;
        private string city_ = "";
        public const int CityFieldNumber = 8;
        private string country_ = "";
        public const int CountryFieldNumber = 0x15;
        private micromsg.CustomizedInfo customizedInfo_;
        public const int CustomizedInfoFieldNumber = 0x17;
        private static readonly SearchContactItem defaultInstance = new SearchContactItem().MakeReadOnly();
        private bool hasAlbumBGImgID;
        private bool hasAlbumFlag;
        private bool hasAlbumStyle;
        private bool hasAlias;
        private bool hasBigHeadImgUrl;
        private bool hasCity;
        private bool hasCountry;
        private bool hasCustomizedInfo;
        private bool hasImgBuf;
        private bool hasMyBrandList;
        private bool hasNickName;
        private bool hasPersonalCard;
        private bool hasProvince;
        private bool hasPYInitial;
        private bool hasQuanPin;
        private bool hasSex;
        private bool hasSignature;
        private bool hasSmallHeadImgUrl;
        private bool hasSnsUserInfo;
        private bool hasUserName;
        private bool hasVerifyFlag;
        private bool hasVerifyInfo;
        private bool hasWeibo;
        private bool hasWeiboFlag;
        private bool hasWeiboNickname;
        private SKBuiltinBuffer_t imgBuf_;
        public const int ImgBufFieldNumber = 6;
        private int memoizedSerializedSize = -1;
        private string myBrandList_ = "";
        public const int MyBrandListFieldNumber = 0x16;
        private SKBuiltinString_t nickName_;
        public const int NickNameFieldNumber = 2;
        private uint personalCard_;
        public const int PersonalCardFieldNumber = 10;
        private string province_ = "";
        public const int ProvinceFieldNumber = 7;
        private SKBuiltinString_t pYInitial_;
        public const int PYInitialFieldNumber = 3;
        private SKBuiltinString_t quanPin_;
        public const int QuanPinFieldNumber = 4;
        private int sex_;
        public const int SexFieldNumber = 5;
        private string signature_ = "";
        public const int SignatureFieldNumber = 9;
        private string smallHeadImgUrl_ = "";
        public const int SmallHeadImgUrlFieldNumber = 0x19;
        private micromsg.SnsUserInfo snsUserInfo_;
        public const int SnsUserInfoFieldNumber = 20;
        private SKBuiltinString_t userName_;
        public const int UserNameFieldNumber = 1;
        private uint verifyFlag_;
        public const int VerifyFlagFieldNumber = 11;
        private string verifyInfo_ = "";
        public const int VerifyInfoFieldNumber = 12;
        private string weibo_ = "";
        public const int WeiboFieldNumber = 13;
        private uint weiboFlag_;
        public const int WeiboFlagFieldNumber = 0x10;
        private string weiboNickname_ = "";
        public const int WeiboNicknameFieldNumber = 15;

        static SearchContactItem()
        {

        }

        private SearchContactItem()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(SearchContactItem prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            SearchContactItem item = obj as SearchContactItem;
            if (item == null)
            {
                return false;
            }
            if ((this.hasUserName != item.hasUserName) || (this.hasUserName && !this.userName_.Equals(item.userName_)))
            {
                return false;
            }
            if ((this.hasNickName != item.hasNickName) || (this.hasNickName && !this.nickName_.Equals(item.nickName_)))
            {
                return false;
            }
            if ((this.hasPYInitial != item.hasPYInitial) || (this.hasPYInitial && !this.pYInitial_.Equals(item.pYInitial_)))
            {
                return false;
            }
            if ((this.hasQuanPin != item.hasQuanPin) || (this.hasQuanPin && !this.quanPin_.Equals(item.quanPin_)))
            {
                return false;
            }
            if ((this.hasSex != item.hasSex) || (this.hasSex && !this.sex_.Equals(item.sex_)))
            {
                return false;
            }
            if ((this.hasImgBuf != item.hasImgBuf) || (this.hasImgBuf && !this.imgBuf_.Equals(item.imgBuf_)))
            {
                return false;
            }
            if ((this.hasProvince != item.hasProvince) || (this.hasProvince && !this.province_.Equals(item.province_)))
            {
                return false;
            }
            if ((this.hasCity != item.hasCity) || (this.hasCity && !this.city_.Equals(item.city_)))
            {
                return false;
            }
            if ((this.hasSignature != item.hasSignature) || (this.hasSignature && !this.signature_.Equals(item.signature_)))
            {
                return false;
            }
            if ((this.hasPersonalCard != item.hasPersonalCard) || (this.hasPersonalCard && !this.personalCard_.Equals(item.personalCard_)))
            {
                return false;
            }
            if ((this.hasVerifyFlag != item.hasVerifyFlag) || (this.hasVerifyFlag && !this.verifyFlag_.Equals(item.verifyFlag_)))
            {
                return false;
            }
            if ((this.hasVerifyInfo != item.hasVerifyInfo) || (this.hasVerifyInfo && !this.verifyInfo_.Equals(item.verifyInfo_)))
            {
                return false;
            }
            if ((this.hasWeibo != item.hasWeibo) || (this.hasWeibo && !this.weibo_.Equals(item.weibo_)))
            {
                return false;
            }
            if ((this.hasAlias != item.hasAlias) || (this.hasAlias && !this.alias_.Equals(item.alias_)))
            {
                return false;
            }
            if ((this.hasWeiboNickname != item.hasWeiboNickname) || (this.hasWeiboNickname && !this.weiboNickname_.Equals(item.weiboNickname_)))
            {
                return false;
            }
            if ((this.hasWeiboFlag != item.hasWeiboFlag) || (this.hasWeiboFlag && !this.weiboFlag_.Equals(item.weiboFlag_)))
            {
                return false;
            }
            if ((this.hasAlbumStyle != item.hasAlbumStyle) || (this.hasAlbumStyle && !this.albumStyle_.Equals(item.albumStyle_)))
            {
                return false;
            }
            if ((this.hasAlbumFlag != item.hasAlbumFlag) || (this.hasAlbumFlag && !this.albumFlag_.Equals(item.albumFlag_)))
            {
                return false;
            }
            if ((this.hasAlbumBGImgID != item.hasAlbumBGImgID) || (this.hasAlbumBGImgID && !this.albumBGImgID_.Equals(item.albumBGImgID_)))
            {
                return false;
            }
            if ((this.hasSnsUserInfo != item.hasSnsUserInfo) || (this.hasSnsUserInfo && !this.snsUserInfo_.Equals(item.snsUserInfo_)))
            {
                return false;
            }
            if ((this.hasCountry != item.hasCountry) || (this.hasCountry && !this.country_.Equals(item.country_)))
            {
                return false;
            }
            if ((this.hasMyBrandList != item.hasMyBrandList) || (this.hasMyBrandList && !this.myBrandList_.Equals(item.myBrandList_)))
            {
                return false;
            }
            if ((this.hasCustomizedInfo != item.hasCustomizedInfo) || (this.hasCustomizedInfo && !this.customizedInfo_.Equals(item.customizedInfo_)))
            {
                return false;
            }
            if ((this.hasBigHeadImgUrl != item.hasBigHeadImgUrl) || (this.hasBigHeadImgUrl && !this.bigHeadImgUrl_.Equals(item.bigHeadImgUrl_)))
            {
                return false;
            }
            return ((this.hasSmallHeadImgUrl == item.hasSmallHeadImgUrl) && (!this.hasSmallHeadImgUrl || this.smallHeadImgUrl_.Equals(item.smallHeadImgUrl_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasUserName)
            {
                hashCode ^= this.userName_.GetHashCode();
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
            if (this.hasImgBuf)
            {
                hashCode ^= this.imgBuf_.GetHashCode();
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
            if (this.hasWeibo)
            {
                hashCode ^= this.weibo_.GetHashCode();
            }
            if (this.hasAlias)
            {
                hashCode ^= this.alias_.GetHashCode();
            }
            if (this.hasWeiboNickname)
            {
                hashCode ^= this.weiboNickname_.GetHashCode();
            }
            if (this.hasWeiboFlag)
            {
                hashCode ^= this.weiboFlag_.GetHashCode();
            }
            if (this.hasAlbumStyle)
            {
                hashCode ^= this.albumStyle_.GetHashCode();
            }
            if (this.hasAlbumFlag)
            {
                hashCode ^= this.albumFlag_.GetHashCode();
            }
            if (this.hasAlbumBGImgID)
            {
                hashCode ^= this.albumBGImgID_.GetHashCode();
            }
            if (this.hasSnsUserInfo)
            {
                hashCode ^= this.snsUserInfo_.GetHashCode();
            }
            if (this.hasCountry)
            {
                hashCode ^= this.country_.GetHashCode();
            }
            if (this.hasMyBrandList)
            {
                hashCode ^= this.myBrandList_.GetHashCode();
            }
            if (this.hasCustomizedInfo)
            {
                hashCode ^= this.customizedInfo_.GetHashCode();
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

        private SearchContactItem MakeReadOnly()
        {
            return this;
        }

        public static SearchContactItem ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<SearchContactItem, Builder>.PrintField("UserName", this.hasUserName, this.userName_, writer);
            GeneratedMessageLite<SearchContactItem, Builder>.PrintField("NickName", this.hasNickName, this.nickName_, writer);
            GeneratedMessageLite<SearchContactItem, Builder>.PrintField("PYInitial", this.hasPYInitial, this.pYInitial_, writer);
            GeneratedMessageLite<SearchContactItem, Builder>.PrintField("QuanPin", this.hasQuanPin, this.quanPin_, writer);
            GeneratedMessageLite<SearchContactItem, Builder>.PrintField("Sex", this.hasSex, this.sex_, writer);
            GeneratedMessageLite<SearchContactItem, Builder>.PrintField("ImgBuf", this.hasImgBuf, this.imgBuf_, writer);
            GeneratedMessageLite<SearchContactItem, Builder>.PrintField("Province", this.hasProvince, this.province_, writer);
            GeneratedMessageLite<SearchContactItem, Builder>.PrintField("City", this.hasCity, this.city_, writer);
            GeneratedMessageLite<SearchContactItem, Builder>.PrintField("Signature", this.hasSignature, this.signature_, writer);
            GeneratedMessageLite<SearchContactItem, Builder>.PrintField("PersonalCard", this.hasPersonalCard, this.personalCard_, writer);
            GeneratedMessageLite<SearchContactItem, Builder>.PrintField("VerifyFlag", this.hasVerifyFlag, this.verifyFlag_, writer);
            GeneratedMessageLite<SearchContactItem, Builder>.PrintField("VerifyInfo", this.hasVerifyInfo, this.verifyInfo_, writer);
            GeneratedMessageLite<SearchContactItem, Builder>.PrintField("Weibo", this.hasWeibo, this.weibo_, writer);
            GeneratedMessageLite<SearchContactItem, Builder>.PrintField("Alias", this.hasAlias, this.alias_, writer);
            GeneratedMessageLite<SearchContactItem, Builder>.PrintField("WeiboNickname", this.hasWeiboNickname, this.weiboNickname_, writer);
            GeneratedMessageLite<SearchContactItem, Builder>.PrintField("WeiboFlag", this.hasWeiboFlag, this.weiboFlag_, writer);
            GeneratedMessageLite<SearchContactItem, Builder>.PrintField("AlbumStyle", this.hasAlbumStyle, this.albumStyle_, writer);
            GeneratedMessageLite<SearchContactItem, Builder>.PrintField("AlbumFlag", this.hasAlbumFlag, this.albumFlag_, writer);
            GeneratedMessageLite<SearchContactItem, Builder>.PrintField("AlbumBGImgID", this.hasAlbumBGImgID, this.albumBGImgID_, writer);
            GeneratedMessageLite<SearchContactItem, Builder>.PrintField("SnsUserInfo", this.hasSnsUserInfo, this.snsUserInfo_, writer);
            GeneratedMessageLite<SearchContactItem, Builder>.PrintField("Country", this.hasCountry, this.country_, writer);
            GeneratedMessageLite<SearchContactItem, Builder>.PrintField("MyBrandList", this.hasMyBrandList, this.myBrandList_, writer);
            GeneratedMessageLite<SearchContactItem, Builder>.PrintField("CustomizedInfo", this.hasCustomizedInfo, this.customizedInfo_, writer);
            GeneratedMessageLite<SearchContactItem, Builder>.PrintField("BigHeadImgUrl", this.hasBigHeadImgUrl, this.bigHeadImgUrl_, writer);
            GeneratedMessageLite<SearchContactItem, Builder>.PrintField("SmallHeadImgUrl", this.hasSmallHeadImgUrl, this.smallHeadImgUrl_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _searchContactItemFieldNames;
            if (this.hasUserName)
            {
                output.WriteMessage(1, strArray[0x13], this.UserName);
            }
            if (this.hasNickName)
            {
                output.WriteMessage(2, strArray[10], this.NickName);
            }
            if (this.hasPYInitial)
            {
                output.WriteMessage(3, strArray[11], this.PYInitial);
            }
            if (this.hasQuanPin)
            {
                output.WriteMessage(4, strArray[14], this.QuanPin);
            }
            if (this.hasSex)
            {
                output.WriteInt32(5, strArray[15], this.Sex);
            }
            if (this.hasImgBuf)
            {
                output.WriteMessage(6, strArray[8], this.ImgBuf);
            }
            if (this.hasProvince)
            {
                output.WriteString(7, strArray[13], this.Province);
            }
            if (this.hasCity)
            {
                output.WriteString(8, strArray[5], this.City);
            }
            if (this.hasSignature)
            {
                output.WriteString(9, strArray[0x10], this.Signature);
            }
            if (this.hasPersonalCard)
            {
                output.WriteUInt32(10, strArray[12], this.PersonalCard);
            }
            if (this.hasVerifyFlag)
            {
                output.WriteUInt32(11, strArray[20], this.VerifyFlag);
            }
            if (this.hasVerifyInfo)
            {
                output.WriteString(12, strArray[0x15], this.VerifyInfo);
            }
            if (this.hasWeibo)
            {
                output.WriteString(13, strArray[0x16], this.Weibo);
            }
            if (this.hasAlias)
            {
                output.WriteString(14, strArray[3], this.Alias);
            }
            if (this.hasWeiboNickname)
            {
                output.WriteString(15, strArray[0x18], this.WeiboNickname);
            }
            if (this.hasWeiboFlag)
            {
                output.WriteUInt32(0x10, strArray[0x17], this.WeiboFlag);
            }
            if (this.hasAlbumStyle)
            {
                output.WriteInt32(0x11, strArray[2], this.AlbumStyle);
            }
            if (this.hasAlbumFlag)
            {
                output.WriteInt32(0x12, strArray[1], this.AlbumFlag);
            }
            if (this.hasAlbumBGImgID)
            {
                output.WriteString(0x13, strArray[0], this.AlbumBGImgID);
            }
            if (this.hasSnsUserInfo)
            {
                output.WriteMessage(20, strArray[0x12], this.SnsUserInfo);
            }
            if (this.hasCountry)
            {
                output.WriteString(0x15, strArray[6], this.Country);
            }
            if (this.hasMyBrandList)
            {
                output.WriteString(0x16, strArray[9], this.MyBrandList);
            }
            if (this.hasCustomizedInfo)
            {
                output.WriteMessage(0x17, strArray[7], this.CustomizedInfo);
            }
            if (this.hasBigHeadImgUrl)
            {
                output.WriteString(0x18, strArray[4], this.BigHeadImgUrl);
            }
            if (this.hasSmallHeadImgUrl)
            {
                output.WriteString(0x19, strArray[0x11], this.SmallHeadImgUrl);
            }
        }

        public string AlbumBGImgID
        {
            get
            {
                return this.albumBGImgID_;
            }
        }

        public int AlbumFlag
        {
            get
            {
                return this.albumFlag_;
            }
        }

        public int AlbumStyle
        {
            get
            {
                return this.albumStyle_;
            }
        }

        public string Alias
        {
            get
            {
                return this.alias_;
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

        public micromsg.CustomizedInfo CustomizedInfo
        {
            get
            {
                return (this.customizedInfo_ ?? micromsg.CustomizedInfo.DefaultInstance);
            }
        }

        public static SearchContactItem DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override SearchContactItem DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public SKBuiltinBuffer_t ImgBuf
        {
            get
            {
                return (this.imgBuf_ ?? SKBuiltinBuffer_t.DefaultInstance);
            }
        }

        public override bool IsInitialized
        {
            get
            {
                if (!this.hasUserName)
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
                if (!this.hasImgBuf)
                {
                    return false;
                }
                if (!this.ImgBuf.IsInitialized)
                {
                    return false;
                }
                return true;
            }
        }

        public string MyBrandList
        {
            get
            {
                return this.myBrandList_;
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
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(1, this.UserName);
                    }
                    if (this.hasNickName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(2, this.NickName);
                    }
                    if (this.hasPYInitial)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(3, this.PYInitial);
                    }
                    if (this.hasQuanPin)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(4, this.QuanPin);
                    }
                    if (this.hasSex)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(5, this.Sex);
                    }
                    if (this.hasImgBuf)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(6, this.ImgBuf);
                    }
                    if (this.hasProvince)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(7, this.Province);
                    }
                    if (this.hasCity)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(8, this.City);
                    }
                    if (this.hasSignature)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(9, this.Signature);
                    }
                    if (this.hasPersonalCard)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(10, this.PersonalCard);
                    }
                    if (this.hasVerifyFlag)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(11, this.VerifyFlag);
                    }
                    if (this.hasVerifyInfo)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(12, this.VerifyInfo);
                    }
                    if (this.hasWeibo)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(13, this.Weibo);
                    }
                    if (this.hasAlias)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(14, this.Alias);
                    }
                    if (this.hasWeiboNickname)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(15, this.WeiboNickname);
                    }
                    if (this.hasWeiboFlag)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(0x10, this.WeiboFlag);
                    }
                    if (this.hasAlbumStyle)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(0x11, this.AlbumStyle);
                    }
                    if (this.hasAlbumFlag)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(0x12, this.AlbumFlag);
                    }
                    if (this.hasAlbumBGImgID)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x13, this.AlbumBGImgID);
                    }
                    if (this.hasSnsUserInfo)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(20, this.SnsUserInfo);
                    }
                    if (this.hasCountry)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x15, this.Country);
                    }
                    if (this.hasMyBrandList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x16, this.MyBrandList);
                    }
                    if (this.hasCustomizedInfo)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(0x17, this.CustomizedInfo);
                    }
                    if (this.hasBigHeadImgUrl)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x18, this.BigHeadImgUrl);
                    }
                    if (this.hasSmallHeadImgUrl)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x19, this.SmallHeadImgUrl);
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

        public string SmallHeadImgUrl
        {
            get
            {
                return this.smallHeadImgUrl_;
            }
        }

        public micromsg.SnsUserInfo SnsUserInfo
        {
            get
            {
                return (this.snsUserInfo_ ?? micromsg.SnsUserInfo.DefaultInstance);
            }
        }

        protected override SearchContactItem ThisMessage
        {
            get
            {
                return this;
            }
        }

        public SKBuiltinString_t UserName
        {
            get
            {
                return (this.userName_ ?? SKBuiltinString_t.DefaultInstance);
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

        public string Weibo
        {
            get
            {
                return this.weibo_;
            }
        }

        public uint WeiboFlag
        {
            get
            {
                return this.weiboFlag_;
            }
        }

        public string WeiboNickname
        {
            get
            {
                return this.weiboNickname_;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<SearchContactItem, SearchContactItem.Builder>
        {
            private SearchContactItem result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = SearchContactItem.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(SearchContactItem cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override SearchContactItem BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override SearchContactItem.Builder Clear()
            {
                this.result = SearchContactItem.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public SearchContactItem.Builder ClearAlbumBGImgID()
            {
                this.PrepareBuilder();
                this.result.hasAlbumBGImgID = false;
                this.result.albumBGImgID_ = "";
                return this;
            }

            public SearchContactItem.Builder ClearAlbumFlag()
            {
                this.PrepareBuilder();
                this.result.hasAlbumFlag = false;
                this.result.albumFlag_ = 0;
                return this;
            }

            public SearchContactItem.Builder ClearAlbumStyle()
            {
                this.PrepareBuilder();
                this.result.hasAlbumStyle = false;
                this.result.albumStyle_ = 0;
                return this;
            }

            public SearchContactItem.Builder ClearAlias()
            {
                this.PrepareBuilder();
                this.result.hasAlias = false;
                this.result.alias_ = "";
                return this;
            }

            public SearchContactItem.Builder ClearBigHeadImgUrl()
            {
                this.PrepareBuilder();
                this.result.hasBigHeadImgUrl = false;
                this.result.bigHeadImgUrl_ = "";
                return this;
            }

            public SearchContactItem.Builder ClearCity()
            {
                this.PrepareBuilder();
                this.result.hasCity = false;
                this.result.city_ = "";
                return this;
            }

            public SearchContactItem.Builder ClearCountry()
            {
                this.PrepareBuilder();
                this.result.hasCountry = false;
                this.result.country_ = "";
                return this;
            }

            public SearchContactItem.Builder ClearCustomizedInfo()
            {
                this.PrepareBuilder();
                this.result.hasCustomizedInfo = false;
                this.result.customizedInfo_ = null;
                return this;
            }

            public SearchContactItem.Builder ClearImgBuf()
            {
                this.PrepareBuilder();
                this.result.hasImgBuf = false;
                this.result.imgBuf_ = null;
                return this;
            }

            public SearchContactItem.Builder ClearMyBrandList()
            {
                this.PrepareBuilder();
                this.result.hasMyBrandList = false;
                this.result.myBrandList_ = "";
                return this;
            }

            public SearchContactItem.Builder ClearNickName()
            {
                this.PrepareBuilder();
                this.result.hasNickName = false;
                this.result.nickName_ = null;
                return this;
            }

            public SearchContactItem.Builder ClearPersonalCard()
            {
                this.PrepareBuilder();
                this.result.hasPersonalCard = false;
                this.result.personalCard_ = 0;
                return this;
            }

            public SearchContactItem.Builder ClearProvince()
            {
                this.PrepareBuilder();
                this.result.hasProvince = false;
                this.result.province_ = "";
                return this;
            }

            public SearchContactItem.Builder ClearPYInitial()
            {
                this.PrepareBuilder();
                this.result.hasPYInitial = false;
                this.result.pYInitial_ = null;
                return this;
            }

            public SearchContactItem.Builder ClearQuanPin()
            {
                this.PrepareBuilder();
                this.result.hasQuanPin = false;
                this.result.quanPin_ = null;
                return this;
            }

            public SearchContactItem.Builder ClearSex()
            {
                this.PrepareBuilder();
                this.result.hasSex = false;
                this.result.sex_ = 0;
                return this;
            }

            public SearchContactItem.Builder ClearSignature()
            {
                this.PrepareBuilder();
                this.result.hasSignature = false;
                this.result.signature_ = "";
                return this;
            }

            public SearchContactItem.Builder ClearSmallHeadImgUrl()
            {
                this.PrepareBuilder();
                this.result.hasSmallHeadImgUrl = false;
                this.result.smallHeadImgUrl_ = "";
                return this;
            }

            public SearchContactItem.Builder ClearSnsUserInfo()
            {
                this.PrepareBuilder();
                this.result.hasSnsUserInfo = false;
                this.result.snsUserInfo_ = null;
                return this;
            }

            public SearchContactItem.Builder ClearUserName()
            {
                this.PrepareBuilder();
                this.result.hasUserName = false;
                this.result.userName_ = null;
                return this;
            }

            public SearchContactItem.Builder ClearVerifyFlag()
            {
                this.PrepareBuilder();
                this.result.hasVerifyFlag = false;
                this.result.verifyFlag_ = 0;
                return this;
            }

            public SearchContactItem.Builder ClearVerifyInfo()
            {
                this.PrepareBuilder();
                this.result.hasVerifyInfo = false;
                this.result.verifyInfo_ = "";
                return this;
            }

            public SearchContactItem.Builder ClearWeibo()
            {
                this.PrepareBuilder();
                this.result.hasWeibo = false;
                this.result.weibo_ = "";
                return this;
            }

            public SearchContactItem.Builder ClearWeiboFlag()
            {
                this.PrepareBuilder();
                this.result.hasWeiboFlag = false;
                this.result.weiboFlag_ = 0;
                return this;
            }

            public SearchContactItem.Builder ClearWeiboNickname()
            {
                this.PrepareBuilder();
                this.result.hasWeiboNickname = false;
                this.result.weiboNickname_ = "";
                return this;
            }

            public override SearchContactItem.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new SearchContactItem.Builder(this.result);
                }
                return new SearchContactItem.Builder().MergeFrom(this.result);
            }

            public SearchContactItem.Builder MergeCustomizedInfo(micromsg.CustomizedInfo value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasCustomizedInfo && (this.result.customizedInfo_ != micromsg.CustomizedInfo.DefaultInstance))
                {
                    this.result.customizedInfo_ = micromsg.CustomizedInfo.CreateBuilder(this.result.customizedInfo_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.customizedInfo_ = value;
                }
                this.result.hasCustomizedInfo = true;
                return this;
            }

            public override SearchContactItem.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override SearchContactItem.Builder MergeFrom(IMessageLite other)
            {
                if (other is SearchContactItem)
                {
                    return this.MergeFrom((SearchContactItem) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override SearchContactItem.Builder MergeFrom(SearchContactItem other)
            {
                return this;
            }

            public override SearchContactItem.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(SearchContactItem._searchContactItemFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = SearchContactItem._searchContactItemFieldTags[index];
                        }
                        else
                        {
                            this.ParseUnknownField(input, extensionRegistry, num, str);
                            continue;
                        }
                    }
                    switch (num)
                    {
                        case 0x1a:
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
                        case 0x22:
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
                        case 40:
                        {
                            this.result.hasSex = input.ReadInt32(ref this.result.sex_);
                            continue;
                        }
                        case 0:
                            throw InvalidProtocolBufferException.InvalidTag();

                        case 10:
                        {
                            SKBuiltinString_t.Builder builder = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasUserName)
                            {
                                builder.MergeFrom(this.UserName);
                            }
                            input.ReadMessage(builder, extensionRegistry);
                            this.UserName = builder.BuildPartial();
                            continue;
                        }
                        case 0x12:
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
                        case 50:
                        {
                            SKBuiltinBuffer_t.Builder builder5 = SKBuiltinBuffer_t.CreateBuilder();
                            if (this.result.hasImgBuf)
                            {
                                builder5.MergeFrom(this.ImgBuf);
                            }
                            input.ReadMessage(builder5, extensionRegistry);
                            this.ImgBuf = builder5.BuildPartial();
                            continue;
                        }
                        case 0x3a:
                        {
                            this.result.hasProvince = input.ReadString(ref this.result.province_);
                            continue;
                        }
                        case 0x42:
                        {
                            this.result.hasCity = input.ReadString(ref this.result.city_);
                            continue;
                        }
                        case 0x58:
                        {
                            this.result.hasVerifyFlag = input.ReadUInt32(ref this.result.verifyFlag_);
                            continue;
                        }
                        case 0x62:
                        {
                            this.result.hasVerifyInfo = input.ReadString(ref this.result.verifyInfo_);
                            continue;
                        }
                        case 0x4a:
                        {
                            this.result.hasSignature = input.ReadString(ref this.result.signature_);
                            continue;
                        }
                        case 80:
                        {
                            this.result.hasPersonalCard = input.ReadUInt32(ref this.result.personalCard_);
                            continue;
                        }
                        case 0x80:
                        {
                            this.result.hasWeiboFlag = input.ReadUInt32(ref this.result.weiboFlag_);
                            continue;
                        }
                        case 0x88:
                        {
                            this.result.hasAlbumStyle = input.ReadInt32(ref this.result.albumStyle_);
                            continue;
                        }
                        case 0x90:
                        {
                            this.result.hasAlbumFlag = input.ReadInt32(ref this.result.albumFlag_);
                            continue;
                        }
                        case 0x6a:
                        {
                            this.result.hasWeibo = input.ReadString(ref this.result.weibo_);
                            continue;
                        }
                        case 0x72:
                        {
                            this.result.hasAlias = input.ReadString(ref this.result.alias_);
                            continue;
                        }
                        case 0x7a:
                        {
                            this.result.hasWeiboNickname = input.ReadString(ref this.result.weiboNickname_);
                            continue;
                        }
                        case 0x9a:
                        {
                            this.result.hasAlbumBGImgID = input.ReadString(ref this.result.albumBGImgID_);
                            continue;
                        }
                        case 0xa2:
                        {
                            micromsg.SnsUserInfo.Builder builder6 = micromsg.SnsUserInfo.CreateBuilder();
                            if (this.result.hasSnsUserInfo)
                            {
                                builder6.MergeFrom(this.SnsUserInfo);
                            }
                            input.ReadMessage(builder6, extensionRegistry);
                            this.SnsUserInfo = builder6.BuildPartial();
                            continue;
                        }
                        case 170:
                        {
                            this.result.hasCountry = input.ReadString(ref this.result.country_);
                            continue;
                        }
                        case 0xb2:
                        {
                            this.result.hasMyBrandList = input.ReadString(ref this.result.myBrandList_);
                            continue;
                        }
                        case 0xba:
                        {
                            micromsg.CustomizedInfo.Builder builder7 = micromsg.CustomizedInfo.CreateBuilder();
                            if (this.result.hasCustomizedInfo)
                            {
                                builder7.MergeFrom(this.CustomizedInfo);
                            }
                            input.ReadMessage(builder7, extensionRegistry);
                            this.CustomizedInfo = builder7.BuildPartial();
                            continue;
                        }
                        case 0xc2:
                        {
                            this.result.hasBigHeadImgUrl = input.ReadString(ref this.result.bigHeadImgUrl_);
                            continue;
                        }
                        case 0xca:
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

            public SearchContactItem.Builder MergeImgBuf(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasImgBuf && (this.result.imgBuf_ != SKBuiltinBuffer_t.DefaultInstance))
                {
                    this.result.imgBuf_ = SKBuiltinBuffer_t.CreateBuilder(this.result.imgBuf_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.imgBuf_ = value;
                }
                this.result.hasImgBuf = true;
                return this;
            }

            public SearchContactItem.Builder MergeNickName(SKBuiltinString_t value)
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

            public SearchContactItem.Builder MergePYInitial(SKBuiltinString_t value)
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

            public SearchContactItem.Builder MergeQuanPin(SKBuiltinString_t value)
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

            public SearchContactItem.Builder MergeSnsUserInfo(micromsg.SnsUserInfo value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasSnsUserInfo && (this.result.snsUserInfo_ != micromsg.SnsUserInfo.DefaultInstance))
                {
                    this.result.snsUserInfo_ = micromsg.SnsUserInfo.CreateBuilder(this.result.snsUserInfo_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.snsUserInfo_ = value;
                }
                this.result.hasSnsUserInfo = true;
                return this;
            }

            public SearchContactItem.Builder MergeUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasUserName && (this.result.userName_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.userName_ = SKBuiltinString_t.CreateBuilder(this.result.userName_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.userName_ = value;
                }
                this.result.hasUserName = true;
                return this;
            }

            private SearchContactItem PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    SearchContactItem result = this.result;
                    this.result = new SearchContactItem();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public SearchContactItem.Builder SetAlbumBGImgID(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasAlbumBGImgID = true;
                this.result.albumBGImgID_ = value;
                return this;
            }

            public SearchContactItem.Builder SetAlbumFlag(int value)
            {
                this.PrepareBuilder();
                this.result.hasAlbumFlag = true;
                this.result.albumFlag_ = value;
                return this;
            }

            public SearchContactItem.Builder SetAlbumStyle(int value)
            {
                this.PrepareBuilder();
                this.result.hasAlbumStyle = true;
                this.result.albumStyle_ = value;
                return this;
            }

            public SearchContactItem.Builder SetAlias(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasAlias = true;
                this.result.alias_ = value;
                return this;
            }

            public SearchContactItem.Builder SetBigHeadImgUrl(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBigHeadImgUrl = true;
                this.result.bigHeadImgUrl_ = value;
                return this;
            }

            public SearchContactItem.Builder SetCity(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasCity = true;
                this.result.city_ = value;
                return this;
            }

            public SearchContactItem.Builder SetCountry(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasCountry = true;
                this.result.country_ = value;
                return this;
            }

            public SearchContactItem.Builder SetCustomizedInfo(micromsg.CustomizedInfo value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasCustomizedInfo = true;
                this.result.customizedInfo_ = value;
                return this;
            }

            public SearchContactItem.Builder SetCustomizedInfo(micromsg.CustomizedInfo.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasCustomizedInfo = true;
                this.result.customizedInfo_ = builderForValue.Build();
                return this;
            }

            public SearchContactItem.Builder SetImgBuf(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasImgBuf = true;
                this.result.imgBuf_ = value;
                return this;
            }

            public SearchContactItem.Builder SetImgBuf(SKBuiltinBuffer_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasImgBuf = true;
                this.result.imgBuf_ = builderForValue.Build();
                return this;
            }

            public SearchContactItem.Builder SetMyBrandList(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasMyBrandList = true;
                this.result.myBrandList_ = value;
                return this;
            }

            public SearchContactItem.Builder SetNickName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasNickName = true;
                this.result.nickName_ = value;
                return this;
            }

            public SearchContactItem.Builder SetNickName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasNickName = true;
                this.result.nickName_ = builderForValue.Build();
                return this;
            }

            public SearchContactItem.Builder SetPersonalCard(uint value)
            {
                this.PrepareBuilder();
                this.result.hasPersonalCard = true;
                this.result.personalCard_ = value;
                return this;
            }

            public SearchContactItem.Builder SetProvince(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasProvince = true;
                this.result.province_ = value;
                return this;
            }

            public SearchContactItem.Builder SetPYInitial(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasPYInitial = true;
                this.result.pYInitial_ = value;
                return this;
            }

            public SearchContactItem.Builder SetPYInitial(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasPYInitial = true;
                this.result.pYInitial_ = builderForValue.Build();
                return this;
            }

            public SearchContactItem.Builder SetQuanPin(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasQuanPin = true;
                this.result.quanPin_ = value;
                return this;
            }

            public SearchContactItem.Builder SetQuanPin(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasQuanPin = true;
                this.result.quanPin_ = builderForValue.Build();
                return this;
            }

            public SearchContactItem.Builder SetSex(int value)
            {
                this.PrepareBuilder();
                this.result.hasSex = true;
                this.result.sex_ = value;
                return this;
            }

            public SearchContactItem.Builder SetSignature(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSignature = true;
                this.result.signature_ = value;
                return this;
            }

            public SearchContactItem.Builder SetSmallHeadImgUrl(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSmallHeadImgUrl = true;
                this.result.smallHeadImgUrl_ = value;
                return this;
            }

            public SearchContactItem.Builder SetSnsUserInfo(micromsg.SnsUserInfo value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSnsUserInfo = true;
                this.result.snsUserInfo_ = value;
                return this;
            }

            public SearchContactItem.Builder SetSnsUserInfo(micromsg.SnsUserInfo.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasSnsUserInfo = true;
                this.result.snsUserInfo_ = builderForValue.Build();
                return this;
            }

            public SearchContactItem.Builder SetUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasUserName = true;
                this.result.userName_ = value;
                return this;
            }

            public SearchContactItem.Builder SetUserName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasUserName = true;
                this.result.userName_ = builderForValue.Build();
                return this;
            }

            public SearchContactItem.Builder SetVerifyFlag(uint value)
            {
                this.PrepareBuilder();
                this.result.hasVerifyFlag = true;
                this.result.verifyFlag_ = value;
                return this;
            }

            public SearchContactItem.Builder SetVerifyInfo(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasVerifyInfo = true;
                this.result.verifyInfo_ = value;
                return this;
            }

            public SearchContactItem.Builder SetWeibo(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasWeibo = true;
                this.result.weibo_ = value;
                return this;
            }

            public SearchContactItem.Builder SetWeiboFlag(uint value)
            {
                this.PrepareBuilder();
                this.result.hasWeiboFlag = true;
                this.result.weiboFlag_ = value;
                return this;
            }

            public SearchContactItem.Builder SetWeiboNickname(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasWeiboNickname = true;
                this.result.weiboNickname_ = value;
                return this;
            }

            public string AlbumBGImgID
            {
                get
                {
                    return this.result.AlbumBGImgID;
                }
                set
                {
                    this.SetAlbumBGImgID(value);
                }
            }

            public int AlbumFlag
            {
                get
                {
                    return this.result.AlbumFlag;
                }
                set
                {
                    this.SetAlbumFlag(value);
                }
            }

            public int AlbumStyle
            {
                get
                {
                    return this.result.AlbumStyle;
                }
                set
                {
                    this.SetAlbumStyle(value);
                }
            }

            public string Alias
            {
                get
                {
                    return this.result.Alias;
                }
                set
                {
                    this.SetAlias(value);
                }
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

            public micromsg.CustomizedInfo CustomizedInfo
            {
                get
                {
                    return this.result.CustomizedInfo;
                }
                set
                {
                    this.SetCustomizedInfo(value);
                }
            }

            public override SearchContactItem DefaultInstanceForType
            {
                get
                {
                    return SearchContactItem.DefaultInstance;
                }
            }

            public SKBuiltinBuffer_t ImgBuf
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

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override SearchContactItem MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public string MyBrandList
            {
                get
                {
                    return this.result.MyBrandList;
                }
                set
                {
                    this.SetMyBrandList(value);
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

            public micromsg.SnsUserInfo SnsUserInfo
            {
                get
                {
                    return this.result.SnsUserInfo;
                }
                set
                {
                    this.SetSnsUserInfo(value);
                }
            }

            protected override SearchContactItem.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }

            public SKBuiltinString_t UserName
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

            public string Weibo
            {
                get
                {
                    return this.result.Weibo;
                }
                set
                {
                    this.SetWeibo(value);
                }
            }

            public uint WeiboFlag
            {
                get
                {
                    return this.result.WeiboFlag;
                }
                set
                {
                    this.SetWeiboFlag(value);
                }
            }

            public string WeiboNickname
            {
                get
                {
                    return this.result.WeiboNickname;
                }
                set
                {
                    this.SetWeiboNickname(value);
                }
            }
        }
    }
}


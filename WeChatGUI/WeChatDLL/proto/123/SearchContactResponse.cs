namespace micromsg
{
    using Google.ProtocolBuffers;
    using Google.ProtocolBuffers.Collections;

    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    
    public sealed class SearchContactResponse : GeneratedMessageLite<SearchContactResponse, SearchContactResponse.Builder>
    {
        private static readonly string[] _searchContactResponseFieldNames = new string[] { 
            "AlbumBGImgID", "AlbumFlag", "AlbumStyle", "Alias", "BaseResponse", "BigHeadImgUrl", "City", "ContactCount", "ContactList", "Country", "CustomizedInfo", "ImgBuf", "MyBrandList", "NickName", "PYInitial", "PersonalCard", 
            "Province", "QuanPin", "Sex", "Signature", "SmallHeadImgUrl", "SnsUserInfo", "UserName", "VerifyFlag", "VerifyInfo", "Weibo", "WeiboFlag", "WeiboNickname"
         };
        private static readonly uint[] _searchContactResponseFieldTags = new uint[] { 
            0xa2, 0x98, 0x90, 0x7a, 10, 0xda, 0x4a, 200, 210, 0xb2, 0xc2, 0x3a, 0xba, 0x1a, 0x22, 0x58, 
            0x42, 0x2a, 0x30, 0x52, 0xe2, 170, 0x12, 0x60, 0x6a, 0x72, 0x88, 130
         };
        private string albumBGImgID_ = "";
        public const int AlbumBGImgIDFieldNumber = 20;
        private int albumFlag_;
        public const int AlbumFlagFieldNumber = 0x13;
        private int albumStyle_;
        public const int AlbumStyleFieldNumber = 0x12;
        private string alias_ = "";
        public const int AliasFieldNumber = 15;
        private micromsg.BaseResponse baseResponse_;
        public const int BaseResponseFieldNumber = 1;
        private string bigHeadImgUrl_ = "";
        public const int BigHeadImgUrlFieldNumber = 0x1b;
        private string city_ = "";
        public const int CityFieldNumber = 9;
        private uint contactCount_;
        public const int ContactCountFieldNumber = 0x19;
        private PopsicleList<SearchContactItem> contactList_ = new PopsicleList<SearchContactItem>();
        public const int ContactListFieldNumber = 0x1a;
        private string country_ = "";
        public const int CountryFieldNumber = 0x16;
        private micromsg.CustomizedInfo customizedInfo_;
        public const int CustomizedInfoFieldNumber = 0x18;
        private static readonly SearchContactResponse defaultInstance = new SearchContactResponse().MakeReadOnly();
        private bool hasAlbumBGImgID;
        private bool hasAlbumFlag;
        private bool hasAlbumStyle;
        private bool hasAlias;
        private bool hasBaseResponse;
        private bool hasBigHeadImgUrl;
        private bool hasCity;
        private bool hasContactCount;
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
        public const int ImgBufFieldNumber = 7;
        private int memoizedSerializedSize = -1;
        private string myBrandList_ = "";
        public const int MyBrandListFieldNumber = 0x17;
        private SKBuiltinString_t nickName_;
        public const int NickNameFieldNumber = 3;
        private uint personalCard_;
        public const int PersonalCardFieldNumber = 11;
        private string province_ = "";
        public const int ProvinceFieldNumber = 8;
        private SKBuiltinString_t pYInitial_;
        public const int PYInitialFieldNumber = 4;
        private SKBuiltinString_t quanPin_;
        public const int QuanPinFieldNumber = 5;
        private int sex_;
        public const int SexFieldNumber = 6;
        private string signature_ = "";
        public const int SignatureFieldNumber = 10;
        private string smallHeadImgUrl_ = "";
        public const int SmallHeadImgUrlFieldNumber = 0x1c;
        private micromsg.SnsUserInfo snsUserInfo_;
        public const int SnsUserInfoFieldNumber = 0x15;
        private SKBuiltinString_t userName_;
        public const int UserNameFieldNumber = 2;
        private uint verifyFlag_;
        public const int VerifyFlagFieldNumber = 12;
        private string verifyInfo_ = "";
        public const int VerifyInfoFieldNumber = 13;
        private string weibo_ = "";
        public const int WeiboFieldNumber = 14;
        private uint weiboFlag_;
        public const int WeiboFlagFieldNumber = 0x11;
        private string weiboNickname_ = "";
        public const int WeiboNicknameFieldNumber = 0x10;

        static SearchContactResponse()
        {
        }

        private SearchContactResponse()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(SearchContactResponse prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            SearchContactResponse response = obj as SearchContactResponse;
            if (response == null)
            {
                return false;
            }
            if ((this.hasBaseResponse != response.hasBaseResponse) || (this.hasBaseResponse && !this.baseResponse_.Equals(response.baseResponse_)))
            {
                return false;
            }
            if ((this.hasUserName != response.hasUserName) || (this.hasUserName && !this.userName_.Equals(response.userName_)))
            {
                return false;
            }
            if ((this.hasNickName != response.hasNickName) || (this.hasNickName && !this.nickName_.Equals(response.nickName_)))
            {
                return false;
            }
            if ((this.hasPYInitial != response.hasPYInitial) || (this.hasPYInitial && !this.pYInitial_.Equals(response.pYInitial_)))
            {
                return false;
            }
            if ((this.hasQuanPin != response.hasQuanPin) || (this.hasQuanPin && !this.quanPin_.Equals(response.quanPin_)))
            {
                return false;
            }
            if ((this.hasSex != response.hasSex) || (this.hasSex && !this.sex_.Equals(response.sex_)))
            {
                return false;
            }
            if ((this.hasImgBuf != response.hasImgBuf) || (this.hasImgBuf && !this.imgBuf_.Equals(response.imgBuf_)))
            {
                return false;
            }
            if ((this.hasProvince != response.hasProvince) || (this.hasProvince && !this.province_.Equals(response.province_)))
            {
                return false;
            }
            if ((this.hasCity != response.hasCity) || (this.hasCity && !this.city_.Equals(response.city_)))
            {
                return false;
            }
            if ((this.hasSignature != response.hasSignature) || (this.hasSignature && !this.signature_.Equals(response.signature_)))
            {
                return false;
            }
            if ((this.hasPersonalCard != response.hasPersonalCard) || (this.hasPersonalCard && !this.personalCard_.Equals(response.personalCard_)))
            {
                return false;
            }
            if ((this.hasVerifyFlag != response.hasVerifyFlag) || (this.hasVerifyFlag && !this.verifyFlag_.Equals(response.verifyFlag_)))
            {
                return false;
            }
            if ((this.hasVerifyInfo != response.hasVerifyInfo) || (this.hasVerifyInfo && !this.verifyInfo_.Equals(response.verifyInfo_)))
            {
                return false;
            }
            if ((this.hasWeibo != response.hasWeibo) || (this.hasWeibo && !this.weibo_.Equals(response.weibo_)))
            {
                return false;
            }
            if ((this.hasAlias != response.hasAlias) || (this.hasAlias && !this.alias_.Equals(response.alias_)))
            {
                return false;
            }
            if ((this.hasWeiboNickname != response.hasWeiboNickname) || (this.hasWeiboNickname && !this.weiboNickname_.Equals(response.weiboNickname_)))
            {
                return false;
            }
            if ((this.hasWeiboFlag != response.hasWeiboFlag) || (this.hasWeiboFlag && !this.weiboFlag_.Equals(response.weiboFlag_)))
            {
                return false;
            }
            if ((this.hasAlbumStyle != response.hasAlbumStyle) || (this.hasAlbumStyle && !this.albumStyle_.Equals(response.albumStyle_)))
            {
                return false;
            }
            if ((this.hasAlbumFlag != response.hasAlbumFlag) || (this.hasAlbumFlag && !this.albumFlag_.Equals(response.albumFlag_)))
            {
                return false;
            }
            if ((this.hasAlbumBGImgID != response.hasAlbumBGImgID) || (this.hasAlbumBGImgID && !this.albumBGImgID_.Equals(response.albumBGImgID_)))
            {
                return false;
            }
            if ((this.hasSnsUserInfo != response.hasSnsUserInfo) || (this.hasSnsUserInfo && !this.snsUserInfo_.Equals(response.snsUserInfo_)))
            {
                return false;
            }
            if ((this.hasCountry != response.hasCountry) || (this.hasCountry && !this.country_.Equals(response.country_)))
            {
                return false;
            }
            if ((this.hasMyBrandList != response.hasMyBrandList) || (this.hasMyBrandList && !this.myBrandList_.Equals(response.myBrandList_)))
            {
                return false;
            }
            if ((this.hasCustomizedInfo != response.hasCustomizedInfo) || (this.hasCustomizedInfo && !this.customizedInfo_.Equals(response.customizedInfo_)))
            {
                return false;
            }
            if ((this.hasContactCount != response.hasContactCount) || (this.hasContactCount && !this.contactCount_.Equals(response.contactCount_)))
            {
                return false;
            }
            if (this.contactList_.Count != response.contactList_.Count)
            {
                return false;
            }
            for (int i = 0; i < this.contactList_.Count; i++)
            {
                if (!this.contactList_[i].Equals(response.contactList_[i]))
                {
                    return false;
                }
            }
            if ((this.hasBigHeadImgUrl != response.hasBigHeadImgUrl) || (this.hasBigHeadImgUrl && !this.bigHeadImgUrl_.Equals(response.bigHeadImgUrl_)))
            {
                return false;
            }
            return ((this.hasSmallHeadImgUrl == response.hasSmallHeadImgUrl) && (!this.hasSmallHeadImgUrl || this.smallHeadImgUrl_.Equals(response.smallHeadImgUrl_)));
        }

        public SearchContactItem GetContactList(int index)
        {
            return this.contactList_[index];
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasBaseResponse)
            {
                hashCode ^= this.baseResponse_.GetHashCode();
            }
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
            if (this.hasContactCount)
            {
                hashCode ^= this.contactCount_.GetHashCode();
            }
            foreach (SearchContactItem item in this.contactList_)
            {
                hashCode ^= item.GetHashCode();
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

        private SearchContactResponse MakeReadOnly()
        {
            this.contactList_.MakeReadOnly();
            return this;
        }

        public static SearchContactResponse ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<SearchContactResponse, Builder>.PrintField("BaseResponse", this.hasBaseResponse, this.baseResponse_, writer);
            GeneratedMessageLite<SearchContactResponse, Builder>.PrintField("UserName", this.hasUserName, this.userName_, writer);
            GeneratedMessageLite<SearchContactResponse, Builder>.PrintField("NickName", this.hasNickName, this.nickName_, writer);
            GeneratedMessageLite<SearchContactResponse, Builder>.PrintField("PYInitial", this.hasPYInitial, this.pYInitial_, writer);
            GeneratedMessageLite<SearchContactResponse, Builder>.PrintField("QuanPin", this.hasQuanPin, this.quanPin_, writer);
            GeneratedMessageLite<SearchContactResponse, Builder>.PrintField("Sex", this.hasSex, this.sex_, writer);
            GeneratedMessageLite<SearchContactResponse, Builder>.PrintField("ImgBuf", this.hasImgBuf, this.imgBuf_, writer);
            GeneratedMessageLite<SearchContactResponse, Builder>.PrintField("Province", this.hasProvince, this.province_, writer);
            GeneratedMessageLite<SearchContactResponse, Builder>.PrintField("City", this.hasCity, this.city_, writer);
            GeneratedMessageLite<SearchContactResponse, Builder>.PrintField("Signature", this.hasSignature, this.signature_, writer);
            GeneratedMessageLite<SearchContactResponse, Builder>.PrintField("PersonalCard", this.hasPersonalCard, this.personalCard_, writer);
            GeneratedMessageLite<SearchContactResponse, Builder>.PrintField("VerifyFlag", this.hasVerifyFlag, this.verifyFlag_, writer);
            GeneratedMessageLite<SearchContactResponse, Builder>.PrintField("VerifyInfo", this.hasVerifyInfo, this.verifyInfo_, writer);
            GeneratedMessageLite<SearchContactResponse, Builder>.PrintField("Weibo", this.hasWeibo, this.weibo_, writer);
            GeneratedMessageLite<SearchContactResponse, Builder>.PrintField("Alias", this.hasAlias, this.alias_, writer);
            GeneratedMessageLite<SearchContactResponse, Builder>.PrintField("WeiboNickname", this.hasWeiboNickname, this.weiboNickname_, writer);
            GeneratedMessageLite<SearchContactResponse, Builder>.PrintField("WeiboFlag", this.hasWeiboFlag, this.weiboFlag_, writer);
            GeneratedMessageLite<SearchContactResponse, Builder>.PrintField("AlbumStyle", this.hasAlbumStyle, this.albumStyle_, writer);
            GeneratedMessageLite<SearchContactResponse, Builder>.PrintField("AlbumFlag", this.hasAlbumFlag, this.albumFlag_, writer);
            GeneratedMessageLite<SearchContactResponse, Builder>.PrintField("AlbumBGImgID", this.hasAlbumBGImgID, this.albumBGImgID_, writer);
            GeneratedMessageLite<SearchContactResponse, Builder>.PrintField("SnsUserInfo", this.hasSnsUserInfo, this.snsUserInfo_, writer);
            GeneratedMessageLite<SearchContactResponse, Builder>.PrintField("Country", this.hasCountry, this.country_, writer);
            GeneratedMessageLite<SearchContactResponse, Builder>.PrintField("MyBrandList", this.hasMyBrandList, this.myBrandList_, writer);
            GeneratedMessageLite<SearchContactResponse, Builder>.PrintField("CustomizedInfo", this.hasCustomizedInfo, this.customizedInfo_, writer);
            GeneratedMessageLite<SearchContactResponse, Builder>.PrintField("ContactCount", this.hasContactCount, this.contactCount_, writer);
            GeneratedMessageLite<SearchContactResponse, Builder>.PrintField<SearchContactItem>("ContactList", this.contactList_, writer);
            GeneratedMessageLite<SearchContactResponse, Builder>.PrintField("BigHeadImgUrl", this.hasBigHeadImgUrl, this.bigHeadImgUrl_, writer);
            GeneratedMessageLite<SearchContactResponse, Builder>.PrintField("SmallHeadImgUrl", this.hasSmallHeadImgUrl, this.smallHeadImgUrl_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _searchContactResponseFieldNames;
            if (this.hasBaseResponse)
            {
                output.WriteMessage(1, strArray[4], this.BaseResponse);
            }
            if (this.hasUserName)
            {
                output.WriteMessage(2, strArray[0x16], this.UserName);
            }
            if (this.hasNickName)
            {
                output.WriteMessage(3, strArray[13], this.NickName);
            }
            if (this.hasPYInitial)
            {
                output.WriteMessage(4, strArray[14], this.PYInitial);
            }
            if (this.hasQuanPin)
            {
                output.WriteMessage(5, strArray[0x11], this.QuanPin);
            }
            if (this.hasSex)
            {
                output.WriteInt32(6, strArray[0x12], this.Sex);
            }
            if (this.hasImgBuf)
            {
                output.WriteMessage(7, strArray[11], this.ImgBuf);
            }
            if (this.hasProvince)
            {
                output.WriteString(8, strArray[0x10], this.Province);
            }
            if (this.hasCity)
            {
                output.WriteString(9, strArray[6], this.City);
            }
            if (this.hasSignature)
            {
                output.WriteString(10, strArray[0x13], this.Signature);
            }
            if (this.hasPersonalCard)
            {
                output.WriteUInt32(11, strArray[15], this.PersonalCard);
            }
            if (this.hasVerifyFlag)
            {
                output.WriteUInt32(12, strArray[0x17], this.VerifyFlag);
            }
            if (this.hasVerifyInfo)
            {
                output.WriteString(13, strArray[0x18], this.VerifyInfo);
            }
            if (this.hasWeibo)
            {
                output.WriteString(14, strArray[0x19], this.Weibo);
            }
            if (this.hasAlias)
            {
                output.WriteString(15, strArray[3], this.Alias);
            }
            if (this.hasWeiboNickname)
            {
                output.WriteString(0x10, strArray[0x1b], this.WeiboNickname);
            }
            if (this.hasWeiboFlag)
            {
                output.WriteUInt32(0x11, strArray[0x1a], this.WeiboFlag);
            }
            if (this.hasAlbumStyle)
            {
                output.WriteInt32(0x12, strArray[2], this.AlbumStyle);
            }
            if (this.hasAlbumFlag)
            {
                output.WriteInt32(0x13, strArray[1], this.AlbumFlag);
            }
            if (this.hasAlbumBGImgID)
            {
                output.WriteString(20, strArray[0], this.AlbumBGImgID);
            }
            if (this.hasSnsUserInfo)
            {
                output.WriteMessage(0x15, strArray[0x15], this.SnsUserInfo);
            }
            if (this.hasCountry)
            {
                output.WriteString(0x16, strArray[9], this.Country);
            }
            if (this.hasMyBrandList)
            {
                output.WriteString(0x17, strArray[12], this.MyBrandList);
            }
            if (this.hasCustomizedInfo)
            {
                output.WriteMessage(0x18, strArray[10], this.CustomizedInfo);
            }
            if (this.hasContactCount)
            {
                output.WriteUInt32(0x19, strArray[7], this.ContactCount);
            }
            if (this.contactList_.Count > 0)
            {
                output.WriteMessageArray<SearchContactItem>(0x1a, strArray[8], this.contactList_);
            }
            if (this.hasBigHeadImgUrl)
            {
                output.WriteString(0x1b, strArray[5], this.BigHeadImgUrl);
            }
            if (this.hasSmallHeadImgUrl)
            {
                output.WriteString(0x1c, strArray[20], this.SmallHeadImgUrl);
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

        public micromsg.BaseResponse BaseResponse
        {
            get
            {
                return (this.baseResponse_ ?? micromsg.BaseResponse.DefaultInstance);
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

        public uint ContactCount
        {
            get
            {
                return this.contactCount_;
            }
        }

        public int ContactListCount
        {
            get
            {
                return this.contactList_.Count;
            }
        }

        public IList<SearchContactItem> ContactListList
        {
            get
            {
                return this.contactList_;
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

        public static SearchContactResponse DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override SearchContactResponse DefaultInstanceForType
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
                if (!this.hasBaseResponse)
                {
                    return false;
                }
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
                if (!this.BaseResponse.IsInitialized)
                {
                    return false;
                }
                if (!this.ImgBuf.IsInitialized)
                {
                    return false;
                }
                foreach (SearchContactItem item in this.ContactListList)
                {
                    if (!item.IsInitialized)
                    {
                        return false;
                    }
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
                    if (this.hasBaseResponse)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(1, this.BaseResponse);
                    }
                    if (this.hasUserName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(2, this.UserName);
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
                    if (this.hasImgBuf)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(7, this.ImgBuf);
                    }
                    if (this.hasProvince)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(8, this.Province);
                    }
                    if (this.hasCity)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(9, this.City);
                    }
                    if (this.hasSignature)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(10, this.Signature);
                    }
                    if (this.hasPersonalCard)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(11, this.PersonalCard);
                    }
                    if (this.hasVerifyFlag)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(12, this.VerifyFlag);
                    }
                    if (this.hasVerifyInfo)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(13, this.VerifyInfo);
                    }
                    if (this.hasWeibo)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(14, this.Weibo);
                    }
                    if (this.hasAlias)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(15, this.Alias);
                    }
                    if (this.hasWeiboNickname)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x10, this.WeiboNickname);
                    }
                    if (this.hasWeiboFlag)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(0x11, this.WeiboFlag);
                    }
                    if (this.hasAlbumStyle)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(0x12, this.AlbumStyle);
                    }
                    if (this.hasAlbumFlag)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(0x13, this.AlbumFlag);
                    }
                    if (this.hasAlbumBGImgID)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(20, this.AlbumBGImgID);
                    }
                    if (this.hasSnsUserInfo)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(0x15, this.SnsUserInfo);
                    }
                    if (this.hasCountry)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x16, this.Country);
                    }
                    if (this.hasMyBrandList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x17, this.MyBrandList);
                    }
                    if (this.hasCustomizedInfo)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(0x18, this.CustomizedInfo);
                    }
                    if (this.hasContactCount)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(0x19, this.ContactCount);
                    }
                    foreach (SearchContactItem item in this.ContactListList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(0x1a, item);
                    }
                    if (this.hasBigHeadImgUrl)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x1b, this.BigHeadImgUrl);
                    }
                    if (this.hasSmallHeadImgUrl)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x1c, this.SmallHeadImgUrl);
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

        protected override SearchContactResponse ThisMessage
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

        
        public sealed class Builder : GeneratedBuilderLite<SearchContactResponse, SearchContactResponse.Builder>
        {
            private SearchContactResponse result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = SearchContactResponse.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(SearchContactResponse cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public SearchContactResponse.Builder AddContactList(SearchContactItem value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.contactList_.Add(value);
                return this;
            }

            public SearchContactResponse.Builder AddContactList(SearchContactItem.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.contactList_.Add(builderForValue.Build());
                return this;
            }

            public SearchContactResponse.Builder AddRangeContactList(IEnumerable<SearchContactItem> values)
            {
                this.PrepareBuilder();
                this.result.contactList_.Add(values);
                return this;
            }

            public override SearchContactResponse BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override SearchContactResponse.Builder Clear()
            {
                this.result = SearchContactResponse.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public SearchContactResponse.Builder ClearAlbumBGImgID()
            {
                this.PrepareBuilder();
                this.result.hasAlbumBGImgID = false;
                this.result.albumBGImgID_ = "";
                return this;
            }

            public SearchContactResponse.Builder ClearAlbumFlag()
            {
                this.PrepareBuilder();
                this.result.hasAlbumFlag = false;
                this.result.albumFlag_ = 0;
                return this;
            }

            public SearchContactResponse.Builder ClearAlbumStyle()
            {
                this.PrepareBuilder();
                this.result.hasAlbumStyle = false;
                this.result.albumStyle_ = 0;
                return this;
            }

            public SearchContactResponse.Builder ClearAlias()
            {
                this.PrepareBuilder();
                this.result.hasAlias = false;
                this.result.alias_ = "";
                return this;
            }

            public SearchContactResponse.Builder ClearBaseResponse()
            {
                this.PrepareBuilder();
                this.result.hasBaseResponse = false;
                this.result.baseResponse_ = null;
                return this;
            }

            public SearchContactResponse.Builder ClearBigHeadImgUrl()
            {
                this.PrepareBuilder();
                this.result.hasBigHeadImgUrl = false;
                this.result.bigHeadImgUrl_ = "";
                return this;
            }

            public SearchContactResponse.Builder ClearCity()
            {
                this.PrepareBuilder();
                this.result.hasCity = false;
                this.result.city_ = "";
                return this;
            }

            public SearchContactResponse.Builder ClearContactCount()
            {
                this.PrepareBuilder();
                this.result.hasContactCount = false;
                this.result.contactCount_ = 0;
                return this;
            }

            public SearchContactResponse.Builder ClearContactList()
            {
                this.PrepareBuilder();
                this.result.contactList_.Clear();
                return this;
            }

            public SearchContactResponse.Builder ClearCountry()
            {
                this.PrepareBuilder();
                this.result.hasCountry = false;
                this.result.country_ = "";
                return this;
            }

            public SearchContactResponse.Builder ClearCustomizedInfo()
            {
                this.PrepareBuilder();
                this.result.hasCustomizedInfo = false;
                this.result.customizedInfo_ = null;
                return this;
            }

            public SearchContactResponse.Builder ClearImgBuf()
            {
                this.PrepareBuilder();
                this.result.hasImgBuf = false;
                this.result.imgBuf_ = null;
                return this;
            }

            public SearchContactResponse.Builder ClearMyBrandList()
            {
                this.PrepareBuilder();
                this.result.hasMyBrandList = false;
                this.result.myBrandList_ = "";
                return this;
            }

            public SearchContactResponse.Builder ClearNickName()
            {
                this.PrepareBuilder();
                this.result.hasNickName = false;
                this.result.nickName_ = null;
                return this;
            }

            public SearchContactResponse.Builder ClearPersonalCard()
            {
                this.PrepareBuilder();
                this.result.hasPersonalCard = false;
                this.result.personalCard_ = 0;
                return this;
            }

            public SearchContactResponse.Builder ClearProvince()
            {
                this.PrepareBuilder();
                this.result.hasProvince = false;
                this.result.province_ = "";
                return this;
            }

            public SearchContactResponse.Builder ClearPYInitial()
            {
                this.PrepareBuilder();
                this.result.hasPYInitial = false;
                this.result.pYInitial_ = null;
                return this;
            }

            public SearchContactResponse.Builder ClearQuanPin()
            {
                this.PrepareBuilder();
                this.result.hasQuanPin = false;
                this.result.quanPin_ = null;
                return this;
            }

            public SearchContactResponse.Builder ClearSex()
            {
                this.PrepareBuilder();
                this.result.hasSex = false;
                this.result.sex_ = 0;
                return this;
            }

            public SearchContactResponse.Builder ClearSignature()
            {
                this.PrepareBuilder();
                this.result.hasSignature = false;
                this.result.signature_ = "";
                return this;
            }

            public SearchContactResponse.Builder ClearSmallHeadImgUrl()
            {
                this.PrepareBuilder();
                this.result.hasSmallHeadImgUrl = false;
                this.result.smallHeadImgUrl_ = "";
                return this;
            }

            public SearchContactResponse.Builder ClearSnsUserInfo()
            {
                this.PrepareBuilder();
                this.result.hasSnsUserInfo = false;
                this.result.snsUserInfo_ = null;
                return this;
            }

            public SearchContactResponse.Builder ClearUserName()
            {
                this.PrepareBuilder();
                this.result.hasUserName = false;
                this.result.userName_ = null;
                return this;
            }

            public SearchContactResponse.Builder ClearVerifyFlag()
            {
                this.PrepareBuilder();
                this.result.hasVerifyFlag = false;
                this.result.verifyFlag_ = 0;
                return this;
            }

            public SearchContactResponse.Builder ClearVerifyInfo()
            {
                this.PrepareBuilder();
                this.result.hasVerifyInfo = false;
                this.result.verifyInfo_ = "";
                return this;
            }

            public SearchContactResponse.Builder ClearWeibo()
            {
                this.PrepareBuilder();
                this.result.hasWeibo = false;
                this.result.weibo_ = "";
                return this;
            }

            public SearchContactResponse.Builder ClearWeiboFlag()
            {
                this.PrepareBuilder();
                this.result.hasWeiboFlag = false;
                this.result.weiboFlag_ = 0;
                return this;
            }

            public SearchContactResponse.Builder ClearWeiboNickname()
            {
                this.PrepareBuilder();
                this.result.hasWeiboNickname = false;
                this.result.weiboNickname_ = "";
                return this;
            }

            public override SearchContactResponse.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new SearchContactResponse.Builder(this.result);
                }
                return new SearchContactResponse.Builder().MergeFrom(this.result);
            }

            public SearchContactItem GetContactList(int index)
            {
                return this.result.GetContactList(index);
            }

            public SearchContactResponse.Builder MergeBaseResponse(micromsg.BaseResponse value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasBaseResponse && (this.result.baseResponse_ != micromsg.BaseResponse.DefaultInstance))
                {
                    this.result.baseResponse_ = micromsg.BaseResponse.CreateBuilder(this.result.baseResponse_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.baseResponse_ = value;
                }
                this.result.hasBaseResponse = true;
                return this;
            }

            public SearchContactResponse.Builder MergeCustomizedInfo(micromsg.CustomizedInfo value)
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

            public override SearchContactResponse.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override SearchContactResponse.Builder MergeFrom(IMessageLite other)
            {
                if (other is SearchContactResponse)
                {
                    return this.MergeFrom((SearchContactResponse) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override SearchContactResponse.Builder MergeFrom(SearchContactResponse other)
            {
                return this;
            }

            public override SearchContactResponse.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(SearchContactResponse._searchContactResponseFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = SearchContactResponse._searchContactResponseFieldTags[index];
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
                            micromsg.BaseResponse.Builder builder = micromsg.BaseResponse.CreateBuilder();
                            if (this.result.hasBaseResponse)
                            {
                                builder.MergeFrom(this.BaseResponse);
                            }
                            input.ReadMessage(builder, extensionRegistry);
                            this.BaseResponse = builder.BuildPartial();
                            continue;
                        }
                        case 0x12:
                        {
                            SKBuiltinString_t.Builder builder2 = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasUserName)
                            {
                                builder2.MergeFrom(this.UserName);
                            }
                            input.ReadMessage(builder2, extensionRegistry);
                            this.UserName = builder2.BuildPartial();
                            continue;
                        }
                        case 0x2a:
                        {
                            SKBuiltinString_t.Builder builder5 = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasQuanPin)
                            {
                                builder5.MergeFrom(this.QuanPin);
                            }
                            input.ReadMessage(builder5, extensionRegistry);
                            this.QuanPin = builder5.BuildPartial();
                            continue;
                        }
                        case 0x30:
                        {
                            this.result.hasSex = input.ReadInt32(ref this.result.sex_);
                            continue;
                        }
                        case 0x1a:
                        {
                            SKBuiltinString_t.Builder builder3 = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasNickName)
                            {
                                builder3.MergeFrom(this.NickName);
                            }
                            input.ReadMessage(builder3, extensionRegistry);
                            this.NickName = builder3.BuildPartial();
                            continue;
                        }
                        case 0x22:
                        {
                            SKBuiltinString_t.Builder builder4 = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasPYInitial)
                            {
                                builder4.MergeFrom(this.PYInitial);
                            }
                            input.ReadMessage(builder4, extensionRegistry);
                            this.PYInitial = builder4.BuildPartial();
                            continue;
                        }
                        case 0x3a:
                        {
                            SKBuiltinBuffer_t.Builder builder6 = SKBuiltinBuffer_t.CreateBuilder();
                            if (this.result.hasImgBuf)
                            {
                                builder6.MergeFrom(this.ImgBuf);
                            }
                            input.ReadMessage(builder6, extensionRegistry);
                            this.ImgBuf = builder6.BuildPartial();
                            continue;
                        }
                        case 0x42:
                        {
                            this.result.hasProvince = input.ReadString(ref this.result.province_);
                            continue;
                        }
                        case 0x4a:
                        {
                            this.result.hasCity = input.ReadString(ref this.result.city_);
                            continue;
                        }
                        case 0x60:
                        {
                            this.result.hasVerifyFlag = input.ReadUInt32(ref this.result.verifyFlag_);
                            continue;
                        }
                        case 0x6a:
                        {
                            this.result.hasVerifyInfo = input.ReadString(ref this.result.verifyInfo_);
                            continue;
                        }
                        case 0x52:
                        {
                            this.result.hasSignature = input.ReadString(ref this.result.signature_);
                            continue;
                        }
                        case 0x58:
                        {
                            this.result.hasPersonalCard = input.ReadUInt32(ref this.result.personalCard_);
                            continue;
                        }
                        case 0x72:
                        {
                            this.result.hasWeibo = input.ReadString(ref this.result.weibo_);
                            continue;
                        }
                        case 0x7a:
                        {
                            this.result.hasAlias = input.ReadString(ref this.result.alias_);
                            continue;
                        }
                        case 130:
                        {
                            this.result.hasWeiboNickname = input.ReadString(ref this.result.weiboNickname_);
                            continue;
                        }
                        case 0x98:
                        {
                            this.result.hasAlbumFlag = input.ReadInt32(ref this.result.albumFlag_);
                            continue;
                        }
                        case 0xa2:
                        {
                            this.result.hasAlbumBGImgID = input.ReadString(ref this.result.albumBGImgID_);
                            continue;
                        }
                        case 0x88:
                        {
                            this.result.hasWeiboFlag = input.ReadUInt32(ref this.result.weiboFlag_);
                            continue;
                        }
                        case 0x90:
                        {
                            this.result.hasAlbumStyle = input.ReadInt32(ref this.result.albumStyle_);
                            continue;
                        }
                        case 0xba:
                        {
                            this.result.hasMyBrandList = input.ReadString(ref this.result.myBrandList_);
                            continue;
                        }
                        case 0xc2:
                        {
                            micromsg.CustomizedInfo.Builder builder8 = micromsg.CustomizedInfo.CreateBuilder();
                            if (this.result.hasCustomizedInfo)
                            {
                                builder8.MergeFrom(this.CustomizedInfo);
                            }
                            input.ReadMessage(builder8, extensionRegistry);
                            this.CustomizedInfo = builder8.BuildPartial();
                            continue;
                        }
                        case 170:
                        {
                            micromsg.SnsUserInfo.Builder builder7 = micromsg.SnsUserInfo.CreateBuilder();
                            if (this.result.hasSnsUserInfo)
                            {
                                builder7.MergeFrom(this.SnsUserInfo);
                            }
                            input.ReadMessage(builder7, extensionRegistry);
                            this.SnsUserInfo = builder7.BuildPartial();
                            continue;
                        }
                        case 0xb2:
                        {
                            this.result.hasCountry = input.ReadString(ref this.result.country_);
                            continue;
                        }
                        case 200:
                        {
                            this.result.hasContactCount = input.ReadUInt32(ref this.result.contactCount_);
                            continue;
                        }
                        case 210:
                        {
                            input.ReadMessageArray<SearchContactItem>(num, str, this.result.contactList_, SearchContactItem.DefaultInstance, extensionRegistry);
                            continue;
                        }
                        case 0xda:
                        {
                            this.result.hasBigHeadImgUrl = input.ReadString(ref this.result.bigHeadImgUrl_);
                            continue;
                        }
                        case 0xe2:
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

            public SearchContactResponse.Builder MergeImgBuf(SKBuiltinBuffer_t value)
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

            public SearchContactResponse.Builder MergeNickName(SKBuiltinString_t value)
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

            public SearchContactResponse.Builder MergePYInitial(SKBuiltinString_t value)
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

            public SearchContactResponse.Builder MergeQuanPin(SKBuiltinString_t value)
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

            public SearchContactResponse.Builder MergeSnsUserInfo(micromsg.SnsUserInfo value)
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

            public SearchContactResponse.Builder MergeUserName(SKBuiltinString_t value)
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

            private SearchContactResponse PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    SearchContactResponse result = this.result;
                    this.result = new SearchContactResponse();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public SearchContactResponse.Builder SetAlbumBGImgID(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasAlbumBGImgID = true;
                this.result.albumBGImgID_ = value;
                return this;
            }

            public SearchContactResponse.Builder SetAlbumFlag(int value)
            {
                this.PrepareBuilder();
                this.result.hasAlbumFlag = true;
                this.result.albumFlag_ = value;
                return this;
            }

            public SearchContactResponse.Builder SetAlbumStyle(int value)
            {
                this.PrepareBuilder();
                this.result.hasAlbumStyle = true;
                this.result.albumStyle_ = value;
                return this;
            }

            public SearchContactResponse.Builder SetAlias(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasAlias = true;
                this.result.alias_ = value;
                return this;
            }

            public SearchContactResponse.Builder SetBaseResponse(micromsg.BaseResponse value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = value;
                return this;
            }

            public SearchContactResponse.Builder SetBaseResponse(micromsg.BaseResponse.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = builderForValue.Build();
                return this;
            }

            public SearchContactResponse.Builder SetBigHeadImgUrl(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBigHeadImgUrl = true;
                this.result.bigHeadImgUrl_ = value;
                return this;
            }

            public SearchContactResponse.Builder SetCity(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasCity = true;
                this.result.city_ = value;
                return this;
            }

            public SearchContactResponse.Builder SetContactCount(uint value)
            {
                this.PrepareBuilder();
                this.result.hasContactCount = true;
                this.result.contactCount_ = value;
                return this;
            }

            public SearchContactResponse.Builder SetContactList(int index, SearchContactItem value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.contactList_[index] = value;
                return this;
            }

            public SearchContactResponse.Builder SetContactList(int index, SearchContactItem.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.contactList_[index] = builderForValue.Build();
                return this;
            }

            public SearchContactResponse.Builder SetCountry(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasCountry = true;
                this.result.country_ = value;
                return this;
            }

            public SearchContactResponse.Builder SetCustomizedInfo(micromsg.CustomizedInfo value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasCustomizedInfo = true;
                this.result.customizedInfo_ = value;
                return this;
            }

            public SearchContactResponse.Builder SetCustomizedInfo(micromsg.CustomizedInfo.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasCustomizedInfo = true;
                this.result.customizedInfo_ = builderForValue.Build();
                return this;
            }

            public SearchContactResponse.Builder SetImgBuf(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasImgBuf = true;
                this.result.imgBuf_ = value;
                return this;
            }

            public SearchContactResponse.Builder SetImgBuf(SKBuiltinBuffer_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasImgBuf = true;
                this.result.imgBuf_ = builderForValue.Build();
                return this;
            }

            public SearchContactResponse.Builder SetMyBrandList(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasMyBrandList = true;
                this.result.myBrandList_ = value;
                return this;
            }

            public SearchContactResponse.Builder SetNickName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasNickName = true;
                this.result.nickName_ = value;
                return this;
            }

            public SearchContactResponse.Builder SetNickName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasNickName = true;
                this.result.nickName_ = builderForValue.Build();
                return this;
            }

            public SearchContactResponse.Builder SetPersonalCard(uint value)
            {
                this.PrepareBuilder();
                this.result.hasPersonalCard = true;
                this.result.personalCard_ = value;
                return this;
            }

            public SearchContactResponse.Builder SetProvince(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasProvince = true;
                this.result.province_ = value;
                return this;
            }

            public SearchContactResponse.Builder SetPYInitial(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasPYInitial = true;
                this.result.pYInitial_ = value;
                return this;
            }

            public SearchContactResponse.Builder SetPYInitial(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasPYInitial = true;
                this.result.pYInitial_ = builderForValue.Build();
                return this;
            }

            public SearchContactResponse.Builder SetQuanPin(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasQuanPin = true;
                this.result.quanPin_ = value;
                return this;
            }

            public SearchContactResponse.Builder SetQuanPin(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasQuanPin = true;
                this.result.quanPin_ = builderForValue.Build();
                return this;
            }

            public SearchContactResponse.Builder SetSex(int value)
            {
                this.PrepareBuilder();
                this.result.hasSex = true;
                this.result.sex_ = value;
                return this;
            }

            public SearchContactResponse.Builder SetSignature(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSignature = true;
                this.result.signature_ = value;
                return this;
            }

            public SearchContactResponse.Builder SetSmallHeadImgUrl(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSmallHeadImgUrl = true;
                this.result.smallHeadImgUrl_ = value;
                return this;
            }

            public SearchContactResponse.Builder SetSnsUserInfo(micromsg.SnsUserInfo value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSnsUserInfo = true;
                this.result.snsUserInfo_ = value;
                return this;
            }

            public SearchContactResponse.Builder SetSnsUserInfo(micromsg.SnsUserInfo.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasSnsUserInfo = true;
                this.result.snsUserInfo_ = builderForValue.Build();
                return this;
            }

            public SearchContactResponse.Builder SetUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasUserName = true;
                this.result.userName_ = value;
                return this;
            }

            public SearchContactResponse.Builder SetUserName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasUserName = true;
                this.result.userName_ = builderForValue.Build();
                return this;
            }

            public SearchContactResponse.Builder SetVerifyFlag(uint value)
            {
                this.PrepareBuilder();
                this.result.hasVerifyFlag = true;
                this.result.verifyFlag_ = value;
                return this;
            }

            public SearchContactResponse.Builder SetVerifyInfo(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasVerifyInfo = true;
                this.result.verifyInfo_ = value;
                return this;
            }

            public SearchContactResponse.Builder SetWeibo(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasWeibo = true;
                this.result.weibo_ = value;
                return this;
            }

            public SearchContactResponse.Builder SetWeiboFlag(uint value)
            {
                this.PrepareBuilder();
                this.result.hasWeiboFlag = true;
                this.result.weiboFlag_ = value;
                return this;
            }

            public SearchContactResponse.Builder SetWeiboNickname(string value)
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

            public micromsg.BaseResponse BaseResponse
            {
                get
                {
                    return this.result.BaseResponse;
                }
                set
                {
                    this.SetBaseResponse(value);
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

            public uint ContactCount
            {
                get
                {
                    return this.result.ContactCount;
                }
                set
                {
                    this.SetContactCount(value);
                }
            }

            public int ContactListCount
            {
                get
                {
                    return this.result.ContactListCount;
                }
            }

            public IPopsicleList<SearchContactItem> ContactListList
            {
                get
                {
                    return this.PrepareBuilder().contactList_;
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

            public override SearchContactResponse DefaultInstanceForType
            {
                get
                {
                    return SearchContactResponse.DefaultInstance;
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

            protected override SearchContactResponse MessageBeingBuilt
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

            protected override SearchContactResponse.Builder ThisBuilder
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


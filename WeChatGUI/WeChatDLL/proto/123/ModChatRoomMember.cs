namespace micromsg
{
    using Google.ProtocolBuffers;
   
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

    //
    public sealed class ModChatRoomMember : GeneratedMessageLite<ModChatRoomMember, ModChatRoomMember.Builder>
    {
        private static readonly string[] _modChatRoomMemberFieldNames = new string[] { 
            "AlbumBGImgID", "AlbumFlag", "AlbumStyle", "Alias", "BigHeadImgUrl", "City", "ContactType", "Country", "CustomizedInfo", "ImgBuf", "ImgFlag", "MyBrandList", "NickName", "PYInitial", "PersonalCard", "Province", 
            "QuanPin", "Remark", "RemarkPYInitial", "RemarkQuanPin", "Sex", "Signature", "SmallHeadImgUrl", "SnsUserInfo", "UserName", "VerifyContent", "VerifyFlag", "VerifyInfo", "Weibo", "WeiboFlag", "WeiboNickname"
         };
        private static readonly uint[] _modChatRoomMemberFieldTags = new uint[] { 
            0xc2, 0xb8, 0xb0, 0xca, 0xe2, 0x6a, 0x58, 0xda, 250, 50, 0x38, 0xf2, 0x12, 0x1a, 120, 0x62, 
            0x22, 0x42, 0x4a, 0x52, 40, 0x72, 0xea, 210, 10, 0x9a, 0x80, 0x8a, 0x92, 0xa8, 0xa2
         };
        private string albumBGImgID_ = "";
        public const int AlbumBGImgIDFieldNumber = 0x18;
        private int albumFlag_;
        public const int AlbumFlagFieldNumber = 0x17;
        private int albumStyle_;
        public const int AlbumStyleFieldNumber = 0x16;
        private string alias_ = "";
        public const int AliasFieldNumber = 0x19;
        private string bigHeadImgUrl_ = "";
        public const int BigHeadImgUrlFieldNumber = 0x1c;
        private string city_ = "";
        public const int CityFieldNumber = 13;
        private uint contactType_;
        public const int ContactTypeFieldNumber = 11;
        private string country_ = "";
        public const int CountryFieldNumber = 0x1b;
        private micromsg.CustomizedInfo customizedInfo_;
        public const int CustomizedInfoFieldNumber = 0x1f;
        private static readonly ModChatRoomMember defaultInstance = new ModChatRoomMember().MakeReadOnly();
        private bool hasAlbumBGImgID;
        private bool hasAlbumFlag;
        private bool hasAlbumStyle;
        private bool hasAlias;
        private bool hasBigHeadImgUrl;
        private bool hasCity;
        private bool hasContactType;
        private bool hasCountry;
        private bool hasCustomizedInfo;
        private bool hasImgBuf;
        private bool hasImgFlag;
        private bool hasMyBrandList;
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
        private bool hasSmallHeadImgUrl;
        private bool hasSnsUserInfo;
        private bool hasUserName;
        private bool hasVerifyContent;
        private bool hasVerifyFlag;
        private bool hasVerifyInfo;
        private bool hasWeibo;
        private bool hasWeiboFlag;
        private bool hasWeiboNickname;
        private SKBuiltinBuffer_t imgBuf_;
        public const int ImgBufFieldNumber = 6;
        private uint imgFlag_;
        public const int ImgFlagFieldNumber = 7;
        private int memoizedSerializedSize = -1;
        private string myBrandList_ = "";
        public const int MyBrandListFieldNumber = 30;
        private SKBuiltinString_t nickName_;
        public const int NickNameFieldNumber = 2;
        private uint personalCard_;
        public const int PersonalCardFieldNumber = 15;
        private string province_ = "";
        public const int ProvinceFieldNumber = 12;
        private SKBuiltinString_t pYInitial_;
        public const int PYInitialFieldNumber = 3;
        private SKBuiltinString_t quanPin_;
        public const int QuanPinFieldNumber = 4;
        private SKBuiltinString_t remark_;
        public const int RemarkFieldNumber = 8;
        private SKBuiltinString_t remarkPYInitial_;
        public const int RemarkPYInitialFieldNumber = 9;
        private SKBuiltinString_t remarkQuanPin_;
        public const int RemarkQuanPinFieldNumber = 10;
        private int sex_;
        public const int SexFieldNumber = 5;
        private string signature_ = "";
        public const int SignatureFieldNumber = 14;
        private string smallHeadImgUrl_ = "";
        public const int SmallHeadImgUrlFieldNumber = 0x1d;
        private micromsg.SnsUserInfo snsUserInfo_;
        public const int SnsUserInfoFieldNumber = 0x1a;
        private SKBuiltinString_t userName_;
        public const int UserNameFieldNumber = 1;
        private string verifyContent_ = "";
        public const int VerifyContentFieldNumber = 0x13;
        private uint verifyFlag_;
        public const int VerifyFlagFieldNumber = 0x10;
        private string verifyInfo_ = "";
        public const int VerifyInfoFieldNumber = 0x11;
        private string weibo_ = "";
        public const int WeiboFieldNumber = 0x12;
        private uint weiboFlag_;
        public const int WeiboFlagFieldNumber = 0x15;
        private string weiboNickname_ = "";
        public const int WeiboNicknameFieldNumber = 20;

        static ModChatRoomMember()
        {
            //object.ReferenceEquals(ModChatRoomMember.Descriptor, null);
        }

        private ModChatRoomMember()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(ModChatRoomMember prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            ModChatRoomMember member = obj as ModChatRoomMember;
            if (member == null)
            {
                return false;
            }
            if ((this.hasUserName != member.hasUserName) || (this.hasUserName && !this.userName_.Equals(member.userName_)))
            {
                return false;
            }
            if ((this.hasNickName != member.hasNickName) || (this.hasNickName && !this.nickName_.Equals(member.nickName_)))
            {
                return false;
            }
            if ((this.hasPYInitial != member.hasPYInitial) || (this.hasPYInitial && !this.pYInitial_.Equals(member.pYInitial_)))
            {
                return false;
            }
            if ((this.hasQuanPin != member.hasQuanPin) || (this.hasQuanPin && !this.quanPin_.Equals(member.quanPin_)))
            {
                return false;
            }
            if ((this.hasSex != member.hasSex) || (this.hasSex && !this.sex_.Equals(member.sex_)))
            {
                return false;
            }
            if ((this.hasImgBuf != member.hasImgBuf) || (this.hasImgBuf && !this.imgBuf_.Equals(member.imgBuf_)))
            {
                return false;
            }
            if ((this.hasImgFlag != member.hasImgFlag) || (this.hasImgFlag && !this.imgFlag_.Equals(member.imgFlag_)))
            {
                return false;
            }
            if ((this.hasRemark != member.hasRemark) || (this.hasRemark && !this.remark_.Equals(member.remark_)))
            {
                return false;
            }
            if ((this.hasRemarkPYInitial != member.hasRemarkPYInitial) || (this.hasRemarkPYInitial && !this.remarkPYInitial_.Equals(member.remarkPYInitial_)))
            {
                return false;
            }
            if ((this.hasRemarkQuanPin != member.hasRemarkQuanPin) || (this.hasRemarkQuanPin && !this.remarkQuanPin_.Equals(member.remarkQuanPin_)))
            {
                return false;
            }
            if ((this.hasContactType != member.hasContactType) || (this.hasContactType && !this.contactType_.Equals(member.contactType_)))
            {
                return false;
            }
            if ((this.hasProvince != member.hasProvince) || (this.hasProvince && !this.province_.Equals(member.province_)))
            {
                return false;
            }
            if ((this.hasCity != member.hasCity) || (this.hasCity && !this.city_.Equals(member.city_)))
            {
                return false;
            }
            if ((this.hasSignature != member.hasSignature) || (this.hasSignature && !this.signature_.Equals(member.signature_)))
            {
                return false;
            }
            if ((this.hasPersonalCard != member.hasPersonalCard) || (this.hasPersonalCard && !this.personalCard_.Equals(member.personalCard_)))
            {
                return false;
            }
            if ((this.hasVerifyFlag != member.hasVerifyFlag) || (this.hasVerifyFlag && !this.verifyFlag_.Equals(member.verifyFlag_)))
            {
                return false;
            }
            if ((this.hasVerifyInfo != member.hasVerifyInfo) || (this.hasVerifyInfo && !this.verifyInfo_.Equals(member.verifyInfo_)))
            {
                return false;
            }
            if ((this.hasWeibo != member.hasWeibo) || (this.hasWeibo && !this.weibo_.Equals(member.weibo_)))
            {
                return false;
            }
            if ((this.hasVerifyContent != member.hasVerifyContent) || (this.hasVerifyContent && !this.verifyContent_.Equals(member.verifyContent_)))
            {
                return false;
            }
            if ((this.hasWeiboNickname != member.hasWeiboNickname) || (this.hasWeiboNickname && !this.weiboNickname_.Equals(member.weiboNickname_)))
            {
                return false;
            }
            if ((this.hasWeiboFlag != member.hasWeiboFlag) || (this.hasWeiboFlag && !this.weiboFlag_.Equals(member.weiboFlag_)))
            {
                return false;
            }
            if ((this.hasAlbumStyle != member.hasAlbumStyle) || (this.hasAlbumStyle && !this.albumStyle_.Equals(member.albumStyle_)))
            {
                return false;
            }
            if ((this.hasAlbumFlag != member.hasAlbumFlag) || (this.hasAlbumFlag && !this.albumFlag_.Equals(member.albumFlag_)))
            {
                return false;
            }
            if ((this.hasAlbumBGImgID != member.hasAlbumBGImgID) || (this.hasAlbumBGImgID && !this.albumBGImgID_.Equals(member.albumBGImgID_)))
            {
                return false;
            }
            if ((this.hasAlias != member.hasAlias) || (this.hasAlias && !this.alias_.Equals(member.alias_)))
            {
                return false;
            }
            if ((this.hasSnsUserInfo != member.hasSnsUserInfo) || (this.hasSnsUserInfo && !this.snsUserInfo_.Equals(member.snsUserInfo_)))
            {
                return false;
            }
            if ((this.hasCountry != member.hasCountry) || (this.hasCountry && !this.country_.Equals(member.country_)))
            {
                return false;
            }
            if ((this.hasBigHeadImgUrl != member.hasBigHeadImgUrl) || (this.hasBigHeadImgUrl && !this.bigHeadImgUrl_.Equals(member.bigHeadImgUrl_)))
            {
                return false;
            }
            if ((this.hasSmallHeadImgUrl != member.hasSmallHeadImgUrl) || (this.hasSmallHeadImgUrl && !this.smallHeadImgUrl_.Equals(member.smallHeadImgUrl_)))
            {
                return false;
            }
            if ((this.hasMyBrandList != member.hasMyBrandList) || (this.hasMyBrandList && !this.myBrandList_.Equals(member.myBrandList_)))
            {
                return false;
            }
            return ((this.hasCustomizedInfo == member.hasCustomizedInfo) && (!this.hasCustomizedInfo || this.customizedInfo_.Equals(member.customizedInfo_)));
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
            if (this.hasImgFlag)
            {
                hashCode ^= this.imgFlag_.GetHashCode();
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
            if (this.hasWeibo)
            {
                hashCode ^= this.weibo_.GetHashCode();
            }
            if (this.hasVerifyContent)
            {
                hashCode ^= this.verifyContent_.GetHashCode();
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
            if (this.hasAlias)
            {
                hashCode ^= this.alias_.GetHashCode();
            }
            if (this.hasSnsUserInfo)
            {
                hashCode ^= this.snsUserInfo_.GetHashCode();
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
            if (this.hasMyBrandList)
            {
                hashCode ^= this.myBrandList_.GetHashCode();
            }
            if (this.hasCustomizedInfo)
            {
                hashCode ^= this.customizedInfo_.GetHashCode();
            }
            return hashCode;
        }

        private ModChatRoomMember MakeReadOnly()
        {
            return this;
        }

        public static ModChatRoomMember ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<ModChatRoomMember, Builder>.PrintField("UserName", this.hasUserName, this.userName_, writer);
            GeneratedMessageLite<ModChatRoomMember, Builder>.PrintField("NickName", this.hasNickName, this.nickName_, writer);
            GeneratedMessageLite<ModChatRoomMember, Builder>.PrintField("PYInitial", this.hasPYInitial, this.pYInitial_, writer);
            GeneratedMessageLite<ModChatRoomMember, Builder>.PrintField("QuanPin", this.hasQuanPin, this.quanPin_, writer);
            GeneratedMessageLite<ModChatRoomMember, Builder>.PrintField("Sex", this.hasSex, this.sex_, writer);
            GeneratedMessageLite<ModChatRoomMember, Builder>.PrintField("ImgBuf", this.hasImgBuf, this.imgBuf_, writer);
            GeneratedMessageLite<ModChatRoomMember, Builder>.PrintField("ImgFlag", this.hasImgFlag, this.imgFlag_, writer);
            GeneratedMessageLite<ModChatRoomMember, Builder>.PrintField("Remark", this.hasRemark, this.remark_, writer);
            GeneratedMessageLite<ModChatRoomMember, Builder>.PrintField("RemarkPYInitial", this.hasRemarkPYInitial, this.remarkPYInitial_, writer);
            GeneratedMessageLite<ModChatRoomMember, Builder>.PrintField("RemarkQuanPin", this.hasRemarkQuanPin, this.remarkQuanPin_, writer);
            GeneratedMessageLite<ModChatRoomMember, Builder>.PrintField("ContactType", this.hasContactType, this.contactType_, writer);
            GeneratedMessageLite<ModChatRoomMember, Builder>.PrintField("Province", this.hasProvince, this.province_, writer);
            GeneratedMessageLite<ModChatRoomMember, Builder>.PrintField("City", this.hasCity, this.city_, writer);
            GeneratedMessageLite<ModChatRoomMember, Builder>.PrintField("Signature", this.hasSignature, this.signature_, writer);
            GeneratedMessageLite<ModChatRoomMember, Builder>.PrintField("PersonalCard", this.hasPersonalCard, this.personalCard_, writer);
            GeneratedMessageLite<ModChatRoomMember, Builder>.PrintField("VerifyFlag", this.hasVerifyFlag, this.verifyFlag_, writer);
            GeneratedMessageLite<ModChatRoomMember, Builder>.PrintField("VerifyInfo", this.hasVerifyInfo, this.verifyInfo_, writer);
            GeneratedMessageLite<ModChatRoomMember, Builder>.PrintField("Weibo", this.hasWeibo, this.weibo_, writer);
            GeneratedMessageLite<ModChatRoomMember, Builder>.PrintField("VerifyContent", this.hasVerifyContent, this.verifyContent_, writer);
            GeneratedMessageLite<ModChatRoomMember, Builder>.PrintField("WeiboNickname", this.hasWeiboNickname, this.weiboNickname_, writer);
            GeneratedMessageLite<ModChatRoomMember, Builder>.PrintField("WeiboFlag", this.hasWeiboFlag, this.weiboFlag_, writer);
            GeneratedMessageLite<ModChatRoomMember, Builder>.PrintField("AlbumStyle", this.hasAlbumStyle, this.albumStyle_, writer);
            GeneratedMessageLite<ModChatRoomMember, Builder>.PrintField("AlbumFlag", this.hasAlbumFlag, this.albumFlag_, writer);
            GeneratedMessageLite<ModChatRoomMember, Builder>.PrintField("AlbumBGImgID", this.hasAlbumBGImgID, this.albumBGImgID_, writer);
            GeneratedMessageLite<ModChatRoomMember, Builder>.PrintField("Alias", this.hasAlias, this.alias_, writer);
            GeneratedMessageLite<ModChatRoomMember, Builder>.PrintField("SnsUserInfo", this.hasSnsUserInfo, this.snsUserInfo_, writer);
            GeneratedMessageLite<ModChatRoomMember, Builder>.PrintField("Country", this.hasCountry, this.country_, writer);
            GeneratedMessageLite<ModChatRoomMember, Builder>.PrintField("BigHeadImgUrl", this.hasBigHeadImgUrl, this.bigHeadImgUrl_, writer);
            GeneratedMessageLite<ModChatRoomMember, Builder>.PrintField("SmallHeadImgUrl", this.hasSmallHeadImgUrl, this.smallHeadImgUrl_, writer);
            GeneratedMessageLite<ModChatRoomMember, Builder>.PrintField("MyBrandList", this.hasMyBrandList, this.myBrandList_, writer);
            GeneratedMessageLite<ModChatRoomMember, Builder>.PrintField("CustomizedInfo", this.hasCustomizedInfo, this.customizedInfo_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _modChatRoomMemberFieldNames;
            if (this.hasUserName)
            {
                output.WriteMessage(1, strArray[0x18], this.UserName);
            }
            if (this.hasNickName)
            {
                output.WriteMessage(2, strArray[12], this.NickName);
            }
            if (this.hasPYInitial)
            {
                output.WriteMessage(3, strArray[13], this.PYInitial);
            }
            if (this.hasQuanPin)
            {
                output.WriteMessage(4, strArray[0x10], this.QuanPin);
            }
            if (this.hasSex)
            {
                output.WriteInt32(5, strArray[20], this.Sex);
            }
            if (this.hasImgBuf)
            {
                output.WriteMessage(6, strArray[9], this.ImgBuf);
            }
            if (this.hasImgFlag)
            {
                output.WriteUInt32(7, strArray[10], this.ImgFlag);
            }
            if (this.hasRemark)
            {
                output.WriteMessage(8, strArray[0x11], this.Remark);
            }
            if (this.hasRemarkPYInitial)
            {
                output.WriteMessage(9, strArray[0x12], this.RemarkPYInitial);
            }
            if (this.hasRemarkQuanPin)
            {
                output.WriteMessage(10, strArray[0x13], this.RemarkQuanPin);
            }
            if (this.hasContactType)
            {
                output.WriteUInt32(11, strArray[6], this.ContactType);
            }
            if (this.hasProvince)
            {
                output.WriteString(12, strArray[15], this.Province);
            }
            if (this.hasCity)
            {
                output.WriteString(13, strArray[5], this.City);
            }
            if (this.hasSignature)
            {
                output.WriteString(14, strArray[0x15], this.Signature);
            }
            if (this.hasPersonalCard)
            {
                output.WriteUInt32(15, strArray[14], this.PersonalCard);
            }
            if (this.hasVerifyFlag)
            {
                output.WriteUInt32(0x10, strArray[0x1a], this.VerifyFlag);
            }
            if (this.hasVerifyInfo)
            {
                output.WriteString(0x11, strArray[0x1b], this.VerifyInfo);
            }
            if (this.hasWeibo)
            {
                output.WriteString(0x12, strArray[0x1c], this.Weibo);
            }
            if (this.hasVerifyContent)
            {
                output.WriteString(0x13, strArray[0x19], this.VerifyContent);
            }
            if (this.hasWeiboNickname)
            {
                output.WriteString(20, strArray[30], this.WeiboNickname);
            }
            if (this.hasWeiboFlag)
            {
                output.WriteUInt32(0x15, strArray[0x1d], this.WeiboFlag);
            }
            if (this.hasAlbumStyle)
            {
                output.WriteInt32(0x16, strArray[2], this.AlbumStyle);
            }
            if (this.hasAlbumFlag)
            {
                output.WriteInt32(0x17, strArray[1], this.AlbumFlag);
            }
            if (this.hasAlbumBGImgID)
            {
                output.WriteString(0x18, strArray[0], this.AlbumBGImgID);
            }
            if (this.hasAlias)
            {
                output.WriteString(0x19, strArray[3], this.Alias);
            }
            if (this.hasSnsUserInfo)
            {
                output.WriteMessage(0x1a, strArray[0x17], this.SnsUserInfo);
            }
            if (this.hasCountry)
            {
                output.WriteString(0x1b, strArray[7], this.Country);
            }
            if (this.hasBigHeadImgUrl)
            {
                output.WriteString(0x1c, strArray[4], this.BigHeadImgUrl);
            }
            if (this.hasSmallHeadImgUrl)
            {
                output.WriteString(0x1d, strArray[0x16], this.SmallHeadImgUrl);
            }
            if (this.hasMyBrandList)
            {
                output.WriteString(30, strArray[11], this.MyBrandList);
            }
            if (this.hasCustomizedInfo)
            {
                output.WriteMessage(0x1f, strArray[8], this.CustomizedInfo);
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

        public micromsg.CustomizedInfo CustomizedInfo
        {
            get
            {
                return (this.customizedInfo_ ?? micromsg.CustomizedInfo.DefaultInstance);
            }
        }

        public static ModChatRoomMember DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override ModChatRoomMember DefaultInstanceForType
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
                if (!this.hasImgFlag)
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
                    if (this.hasImgFlag)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(7, this.ImgFlag);
                    }
                    if (this.hasRemark)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(8, this.Remark);
                    }
                    if (this.hasRemarkPYInitial)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(9, this.RemarkPYInitial);
                    }
                    if (this.hasRemarkQuanPin)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(10, this.RemarkQuanPin);
                    }
                    if (this.hasContactType)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(11, this.ContactType);
                    }
                    if (this.hasProvince)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(12, this.Province);
                    }
                    if (this.hasCity)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(13, this.City);
                    }
                    if (this.hasSignature)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(14, this.Signature);
                    }
                    if (this.hasPersonalCard)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(15, this.PersonalCard);
                    }
                    if (this.hasVerifyFlag)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(0x10, this.VerifyFlag);
                    }
                    if (this.hasVerifyInfo)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x11, this.VerifyInfo);
                    }
                    if (this.hasWeibo)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x12, this.Weibo);
                    }
                    if (this.hasVerifyContent)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x13, this.VerifyContent);
                    }
                    if (this.hasWeiboNickname)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(20, this.WeiboNickname);
                    }
                    if (this.hasWeiboFlag)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(0x15, this.WeiboFlag);
                    }
                    if (this.hasAlbumStyle)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(0x16, this.AlbumStyle);
                    }
                    if (this.hasAlbumFlag)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(0x17, this.AlbumFlag);
                    }
                    if (this.hasAlbumBGImgID)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x18, this.AlbumBGImgID);
                    }
                    if (this.hasAlias)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x19, this.Alias);
                    }
                    if (this.hasSnsUserInfo)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(0x1a, this.SnsUserInfo);
                    }
                    if (this.hasCountry)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x1b, this.Country);
                    }
                    if (this.hasBigHeadImgUrl)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x1c, this.BigHeadImgUrl);
                    }
                    if (this.hasSmallHeadImgUrl)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x1d, this.SmallHeadImgUrl);
                    }
                    if (this.hasMyBrandList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(30, this.MyBrandList);
                    }
                    if (this.hasCustomizedInfo)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(0x1f, this.CustomizedInfo);
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

        protected override ModChatRoomMember ThisMessage
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

        public string VerifyContent
        {
            get
            {
                return this.verifyContent_;
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

        
        public sealed class Builder : GeneratedBuilderLite<ModChatRoomMember, ModChatRoomMember.Builder>
        {
            private ModChatRoomMember result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = ModChatRoomMember.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(ModChatRoomMember cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override ModChatRoomMember BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override ModChatRoomMember.Builder Clear()
            {
                this.result = ModChatRoomMember.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public ModChatRoomMember.Builder ClearAlbumBGImgID()
            {
                this.PrepareBuilder();
                this.result.hasAlbumBGImgID = false;
                this.result.albumBGImgID_ = "";
                return this;
            }

            public ModChatRoomMember.Builder ClearAlbumFlag()
            {
                this.PrepareBuilder();
                this.result.hasAlbumFlag = false;
                this.result.albumFlag_ = 0;
                return this;
            }

            public ModChatRoomMember.Builder ClearAlbumStyle()
            {
                this.PrepareBuilder();
                this.result.hasAlbumStyle = false;
                this.result.albumStyle_ = 0;
                return this;
            }

            public ModChatRoomMember.Builder ClearAlias()
            {
                this.PrepareBuilder();
                this.result.hasAlias = false;
                this.result.alias_ = "";
                return this;
            }

            public ModChatRoomMember.Builder ClearBigHeadImgUrl()
            {
                this.PrepareBuilder();
                this.result.hasBigHeadImgUrl = false;
                this.result.bigHeadImgUrl_ = "";
                return this;
            }

            public ModChatRoomMember.Builder ClearCity()
            {
                this.PrepareBuilder();
                this.result.hasCity = false;
                this.result.city_ = "";
                return this;
            }

            public ModChatRoomMember.Builder ClearContactType()
            {
                this.PrepareBuilder();
                this.result.hasContactType = false;
                this.result.contactType_ = 0;
                return this;
            }

            public ModChatRoomMember.Builder ClearCountry()
            {
                this.PrepareBuilder();
                this.result.hasCountry = false;
                this.result.country_ = "";
                return this;
            }

            public ModChatRoomMember.Builder ClearCustomizedInfo()
            {
                this.PrepareBuilder();
                this.result.hasCustomizedInfo = false;
                this.result.customizedInfo_ = null;
                return this;
            }

            public ModChatRoomMember.Builder ClearImgBuf()
            {
                this.PrepareBuilder();
                this.result.hasImgBuf = false;
                this.result.imgBuf_ = null;
                return this;
            }

            public ModChatRoomMember.Builder ClearImgFlag()
            {
                this.PrepareBuilder();
                this.result.hasImgFlag = false;
                this.result.imgFlag_ = 0;
                return this;
            }

            public ModChatRoomMember.Builder ClearMyBrandList()
            {
                this.PrepareBuilder();
                this.result.hasMyBrandList = false;
                this.result.myBrandList_ = "";
                return this;
            }

            public ModChatRoomMember.Builder ClearNickName()
            {
                this.PrepareBuilder();
                this.result.hasNickName = false;
                this.result.nickName_ = null;
                return this;
            }

            public ModChatRoomMember.Builder ClearPersonalCard()
            {
                this.PrepareBuilder();
                this.result.hasPersonalCard = false;
                this.result.personalCard_ = 0;
                return this;
            }

            public ModChatRoomMember.Builder ClearProvince()
            {
                this.PrepareBuilder();
                this.result.hasProvince = false;
                this.result.province_ = "";
                return this;
            }

            public ModChatRoomMember.Builder ClearPYInitial()
            {
                this.PrepareBuilder();
                this.result.hasPYInitial = false;
                this.result.pYInitial_ = null;
                return this;
            }

            public ModChatRoomMember.Builder ClearQuanPin()
            {
                this.PrepareBuilder();
                this.result.hasQuanPin = false;
                this.result.quanPin_ = null;
                return this;
            }

            public ModChatRoomMember.Builder ClearRemark()
            {
                this.PrepareBuilder();
                this.result.hasRemark = false;
                this.result.remark_ = null;
                return this;
            }

            public ModChatRoomMember.Builder ClearRemarkPYInitial()
            {
                this.PrepareBuilder();
                this.result.hasRemarkPYInitial = false;
                this.result.remarkPYInitial_ = null;
                return this;
            }

            public ModChatRoomMember.Builder ClearRemarkQuanPin()
            {
                this.PrepareBuilder();
                this.result.hasRemarkQuanPin = false;
                this.result.remarkQuanPin_ = null;
                return this;
            }

            public ModChatRoomMember.Builder ClearSex()
            {
                this.PrepareBuilder();
                this.result.hasSex = false;
                this.result.sex_ = 0;
                return this;
            }

            public ModChatRoomMember.Builder ClearSignature()
            {
                this.PrepareBuilder();
                this.result.hasSignature = false;
                this.result.signature_ = "";
                return this;
            }

            public ModChatRoomMember.Builder ClearSmallHeadImgUrl()
            {
                this.PrepareBuilder();
                this.result.hasSmallHeadImgUrl = false;
                this.result.smallHeadImgUrl_ = "";
                return this;
            }

            public ModChatRoomMember.Builder ClearSnsUserInfo()
            {
                this.PrepareBuilder();
                this.result.hasSnsUserInfo = false;
                this.result.snsUserInfo_ = null;
                return this;
            }

            public ModChatRoomMember.Builder ClearUserName()
            {
                this.PrepareBuilder();
                this.result.hasUserName = false;
                this.result.userName_ = null;
                return this;
            }

            public ModChatRoomMember.Builder ClearVerifyContent()
            {
                this.PrepareBuilder();
                this.result.hasVerifyContent = false;
                this.result.verifyContent_ = "";
                return this;
            }

            public ModChatRoomMember.Builder ClearVerifyFlag()
            {
                this.PrepareBuilder();
                this.result.hasVerifyFlag = false;
                this.result.verifyFlag_ = 0;
                return this;
            }

            public ModChatRoomMember.Builder ClearVerifyInfo()
            {
                this.PrepareBuilder();
                this.result.hasVerifyInfo = false;
                this.result.verifyInfo_ = "";
                return this;
            }

            public ModChatRoomMember.Builder ClearWeibo()
            {
                this.PrepareBuilder();
                this.result.hasWeibo = false;
                this.result.weibo_ = "";
                return this;
            }

            public ModChatRoomMember.Builder ClearWeiboFlag()
            {
                this.PrepareBuilder();
                this.result.hasWeiboFlag = false;
                this.result.weiboFlag_ = 0;
                return this;
            }

            public ModChatRoomMember.Builder ClearWeiboNickname()
            {
                this.PrepareBuilder();
                this.result.hasWeiboNickname = false;
                this.result.weiboNickname_ = "";
                return this;
            }

            public override ModChatRoomMember.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new ModChatRoomMember.Builder(this.result);
                }
                return new ModChatRoomMember.Builder().MergeFrom(this.result);
            }

            public ModChatRoomMember.Builder MergeCustomizedInfo(micromsg.CustomizedInfo value)
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

            public override ModChatRoomMember.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override ModChatRoomMember.Builder MergeFrom(IMessageLite other)
            {
                if (other is ModChatRoomMember)
                {
                    return this.MergeFrom((ModChatRoomMember) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override ModChatRoomMember.Builder MergeFrom(ModChatRoomMember other)
            {
                return this;
            }

            public override ModChatRoomMember.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(ModChatRoomMember._modChatRoomMemberFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = ModChatRoomMember._modChatRoomMemberFieldTags[index];
                        }
                        else
                        {
                            this.ParseUnknownField(input, extensionRegistry, num, str);
                            continue;
                        }
                    }
                    switch (num)
                    {
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
                        case 0x38:
                        {
                            this.result.hasImgFlag = input.ReadUInt32(ref this.result.imgFlag_);
                            continue;
                        }
                        case 0x52:
                        {
                            SKBuiltinString_t.Builder builder8 = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasRemarkQuanPin)
                            {
                                builder8.MergeFrom(this.RemarkQuanPin);
                            }
                            input.ReadMessage(builder8, extensionRegistry);
                            this.RemarkQuanPin = builder8.BuildPartial();
                            continue;
                        }
                        case 0x58:
                        {
                            this.result.hasContactType = input.ReadUInt32(ref this.result.contactType_);
                            continue;
                        }
                        case 0x42:
                        {
                            SKBuiltinString_t.Builder builder6 = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasRemark)
                            {
                                builder6.MergeFrom(this.Remark);
                            }
                            input.ReadMessage(builder6, extensionRegistry);
                            this.Remark = builder6.BuildPartial();
                            continue;
                        }
                        case 0x4a:
                        {
                            SKBuiltinString_t.Builder builder7 = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasRemarkPYInitial)
                            {
                                builder7.MergeFrom(this.RemarkPYInitial);
                            }
                            input.ReadMessage(builder7, extensionRegistry);
                            this.RemarkPYInitial = builder7.BuildPartial();
                            continue;
                        }
                        case 0x62:
                        {
                            this.result.hasProvince = input.ReadString(ref this.result.province_);
                            continue;
                        }
                        case 0x6a:
                        {
                            this.result.hasCity = input.ReadString(ref this.result.city_);
                            continue;
                        }
                        case 0x72:
                        {
                            this.result.hasSignature = input.ReadString(ref this.result.signature_);
                            continue;
                        }
                        case 120:
                        {
                            this.result.hasPersonalCard = input.ReadUInt32(ref this.result.personalCard_);
                            continue;
                        }
                        case 0x92:
                        {
                            this.result.hasWeibo = input.ReadString(ref this.result.weibo_);
                            continue;
                        }
                        case 0x9a:
                        {
                            this.result.hasVerifyContent = input.ReadString(ref this.result.verifyContent_);
                            continue;
                        }
                        case 0x80:
                        {
                            this.result.hasVerifyFlag = input.ReadUInt32(ref this.result.verifyFlag_);
                            continue;
                        }
                        case 0x8a:
                        {
                            this.result.hasVerifyInfo = input.ReadString(ref this.result.verifyInfo_);
                            continue;
                        }
                        case 0xa2:
                        {
                            this.result.hasWeiboNickname = input.ReadString(ref this.result.weiboNickname_);
                            continue;
                        }
                        case 0xa8:
                        {
                            this.result.hasWeiboFlag = input.ReadUInt32(ref this.result.weiboFlag_);
                            continue;
                        }
                        case 0xb0:
                        {
                            this.result.hasAlbumStyle = input.ReadInt32(ref this.result.albumStyle_);
                            continue;
                        }
                        case 0xb8:
                        {
                            this.result.hasAlbumFlag = input.ReadInt32(ref this.result.albumFlag_);
                            continue;
                        }
                        case 210:
                        {
                            micromsg.SnsUserInfo.Builder builder9 = micromsg.SnsUserInfo.CreateBuilder();
                            if (this.result.hasSnsUserInfo)
                            {
                                builder9.MergeFrom(this.SnsUserInfo);
                            }
                            input.ReadMessage(builder9, extensionRegistry);
                            this.SnsUserInfo = builder9.BuildPartial();
                            continue;
                        }
                        case 0xda:
                        {
                            this.result.hasCountry = input.ReadString(ref this.result.country_);
                            continue;
                        }
                        case 0xc2:
                        {
                            this.result.hasAlbumBGImgID = input.ReadString(ref this.result.albumBGImgID_);
                            continue;
                        }
                        case 0xca:
                        {
                            this.result.hasAlias = input.ReadString(ref this.result.alias_);
                            continue;
                        }
                        case 0xe2:
                        {
                            this.result.hasBigHeadImgUrl = input.ReadString(ref this.result.bigHeadImgUrl_);
                            continue;
                        }
                        case 0xea:
                        {
                            this.result.hasSmallHeadImgUrl = input.ReadString(ref this.result.smallHeadImgUrl_);
                            continue;
                        }
                        case 0xf2:
                        {
                            this.result.hasMyBrandList = input.ReadString(ref this.result.myBrandList_);
                            continue;
                        }
                        case 250:
                        {
                            micromsg.CustomizedInfo.Builder builder10 = micromsg.CustomizedInfo.CreateBuilder();
                            if (this.result.hasCustomizedInfo)
                            {
                                builder10.MergeFrom(this.CustomizedInfo);
                            }
                            input.ReadMessage(builder10, extensionRegistry);
                            this.CustomizedInfo = builder10.BuildPartial();
                            continue;
                        }
                    }
                    if (WireFormat.IsEndGroupTag(num))
                    {
                        return this;
                    }
                    this.ParseUnknownField(input, extensionRegistry, num, str);
                }
                return this;
            }

            public ModChatRoomMember.Builder MergeImgBuf(SKBuiltinBuffer_t value)
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

            public ModChatRoomMember.Builder MergeNickName(SKBuiltinString_t value)
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

            public ModChatRoomMember.Builder MergePYInitial(SKBuiltinString_t value)
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

            public ModChatRoomMember.Builder MergeQuanPin(SKBuiltinString_t value)
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

            public ModChatRoomMember.Builder MergeRemark(SKBuiltinString_t value)
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

            public ModChatRoomMember.Builder MergeRemarkPYInitial(SKBuiltinString_t value)
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

            public ModChatRoomMember.Builder MergeRemarkQuanPin(SKBuiltinString_t value)
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

            public ModChatRoomMember.Builder MergeSnsUserInfo(micromsg.SnsUserInfo value)
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

            public ModChatRoomMember.Builder MergeUserName(SKBuiltinString_t value)
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

            private ModChatRoomMember PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    ModChatRoomMember result = this.result;
                    this.result = new ModChatRoomMember();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public ModChatRoomMember.Builder SetAlbumBGImgID(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasAlbumBGImgID = true;
                this.result.albumBGImgID_ = value;
                return this;
            }

            public ModChatRoomMember.Builder SetAlbumFlag(int value)
            {
                this.PrepareBuilder();
                this.result.hasAlbumFlag = true;
                this.result.albumFlag_ = value;
                return this;
            }

            public ModChatRoomMember.Builder SetAlbumStyle(int value)
            {
                this.PrepareBuilder();
                this.result.hasAlbumStyle = true;
                this.result.albumStyle_ = value;
                return this;
            }

            public ModChatRoomMember.Builder SetAlias(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasAlias = true;
                this.result.alias_ = value;
                return this;
            }

            public ModChatRoomMember.Builder SetBigHeadImgUrl(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBigHeadImgUrl = true;
                this.result.bigHeadImgUrl_ = value;
                return this;
            }

            public ModChatRoomMember.Builder SetCity(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasCity = true;
                this.result.city_ = value;
                return this;
            }

            public ModChatRoomMember.Builder SetContactType(uint value)
            {
                this.PrepareBuilder();
                this.result.hasContactType = true;
                this.result.contactType_ = value;
                return this;
            }

            public ModChatRoomMember.Builder SetCountry(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasCountry = true;
                this.result.country_ = value;
                return this;
            }

            public ModChatRoomMember.Builder SetCustomizedInfo(micromsg.CustomizedInfo value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasCustomizedInfo = true;
                this.result.customizedInfo_ = value;
                return this;
            }

            public ModChatRoomMember.Builder SetCustomizedInfo(micromsg.CustomizedInfo.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasCustomizedInfo = true;
                this.result.customizedInfo_ = builderForValue.Build();
                return this;
            }

            public ModChatRoomMember.Builder SetImgBuf(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasImgBuf = true;
                this.result.imgBuf_ = value;
                return this;
            }

            public ModChatRoomMember.Builder SetImgBuf(SKBuiltinBuffer_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasImgBuf = true;
                this.result.imgBuf_ = builderForValue.Build();
                return this;
            }

            public ModChatRoomMember.Builder SetImgFlag(uint value)
            {
                this.PrepareBuilder();
                this.result.hasImgFlag = true;
                this.result.imgFlag_ = value;
                return this;
            }

            public ModChatRoomMember.Builder SetMyBrandList(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasMyBrandList = true;
                this.result.myBrandList_ = value;
                return this;
            }

            public ModChatRoomMember.Builder SetNickName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasNickName = true;
                this.result.nickName_ = value;
                return this;
            }

            public ModChatRoomMember.Builder SetNickName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasNickName = true;
                this.result.nickName_ = builderForValue.Build();
                return this;
            }

            public ModChatRoomMember.Builder SetPersonalCard(uint value)
            {
                this.PrepareBuilder();
                this.result.hasPersonalCard = true;
                this.result.personalCard_ = value;
                return this;
            }

            public ModChatRoomMember.Builder SetProvince(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasProvince = true;
                this.result.province_ = value;
                return this;
            }

            public ModChatRoomMember.Builder SetPYInitial(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasPYInitial = true;
                this.result.pYInitial_ = value;
                return this;
            }

            public ModChatRoomMember.Builder SetPYInitial(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasPYInitial = true;
                this.result.pYInitial_ = builderForValue.Build();
                return this;
            }

            public ModChatRoomMember.Builder SetQuanPin(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasQuanPin = true;
                this.result.quanPin_ = value;
                return this;
            }

            public ModChatRoomMember.Builder SetQuanPin(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasQuanPin = true;
                this.result.quanPin_ = builderForValue.Build();
                return this;
            }

            public ModChatRoomMember.Builder SetRemark(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasRemark = true;
                this.result.remark_ = value;
                return this;
            }

            public ModChatRoomMember.Builder SetRemark(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasRemark = true;
                this.result.remark_ = builderForValue.Build();
                return this;
            }

            public ModChatRoomMember.Builder SetRemarkPYInitial(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasRemarkPYInitial = true;
                this.result.remarkPYInitial_ = value;
                return this;
            }

            public ModChatRoomMember.Builder SetRemarkPYInitial(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasRemarkPYInitial = true;
                this.result.remarkPYInitial_ = builderForValue.Build();
                return this;
            }

            public ModChatRoomMember.Builder SetRemarkQuanPin(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasRemarkQuanPin = true;
                this.result.remarkQuanPin_ = value;
                return this;
            }

            public ModChatRoomMember.Builder SetRemarkQuanPin(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasRemarkQuanPin = true;
                this.result.remarkQuanPin_ = builderForValue.Build();
                return this;
            }

            public ModChatRoomMember.Builder SetSex(int value)
            {
                this.PrepareBuilder();
                this.result.hasSex = true;
                this.result.sex_ = value;
                return this;
            }

            public ModChatRoomMember.Builder SetSignature(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSignature = true;
                this.result.signature_ = value;
                return this;
            }

            public ModChatRoomMember.Builder SetSmallHeadImgUrl(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSmallHeadImgUrl = true;
                this.result.smallHeadImgUrl_ = value;
                return this;
            }

            public ModChatRoomMember.Builder SetSnsUserInfo(micromsg.SnsUserInfo value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSnsUserInfo = true;
                this.result.snsUserInfo_ = value;
                return this;
            }

            public ModChatRoomMember.Builder SetSnsUserInfo(micromsg.SnsUserInfo.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasSnsUserInfo = true;
                this.result.snsUserInfo_ = builderForValue.Build();
                return this;
            }

            public ModChatRoomMember.Builder SetUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasUserName = true;
                this.result.userName_ = value;
                return this;
            }

            public ModChatRoomMember.Builder SetUserName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasUserName = true;
                this.result.userName_ = builderForValue.Build();
                return this;
            }

            public ModChatRoomMember.Builder SetVerifyContent(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasVerifyContent = true;
                this.result.verifyContent_ = value;
                return this;
            }

            public ModChatRoomMember.Builder SetVerifyFlag(uint value)
            {
                this.PrepareBuilder();
                this.result.hasVerifyFlag = true;
                this.result.verifyFlag_ = value;
                return this;
            }

            public ModChatRoomMember.Builder SetVerifyInfo(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasVerifyInfo = true;
                this.result.verifyInfo_ = value;
                return this;
            }

            public ModChatRoomMember.Builder SetWeibo(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasWeibo = true;
                this.result.weibo_ = value;
                return this;
            }

            public ModChatRoomMember.Builder SetWeiboFlag(uint value)
            {
                this.PrepareBuilder();
                this.result.hasWeiboFlag = true;
                this.result.weiboFlag_ = value;
                return this;
            }

            public ModChatRoomMember.Builder SetWeiboNickname(string value)
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

            public override ModChatRoomMember DefaultInstanceForType
            {
                get
                {
                    return ModChatRoomMember.DefaultInstance;
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

            protected override ModChatRoomMember MessageBeingBuilt
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

            protected override ModChatRoomMember.Builder ThisBuilder
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

            public string VerifyContent
            {
                get
                {
                    return this.result.VerifyContent;
                }
                set
                {
                    this.SetVerifyContent(value);
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


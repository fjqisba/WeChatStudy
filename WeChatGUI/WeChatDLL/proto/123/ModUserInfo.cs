namespace micromsg
{
    using Google.ProtocolBuffers;
    
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

    
    public sealed class ModUserInfo : GeneratedMessageLite<ModUserInfo, ModUserInfo.Builder>
    {
        private static readonly string[] _modUserInfoFieldNames = new string[] { 
            "AlbumBGImgID", "AlbumFlag", "AlbumStyle", "Alias", "BindEmail", "BindMobile", "BindUin", "BitFlag", "City", "Country", "DisturbSetting", "Experience", "FBToken", "FBUserID", "FBUserName", "FaceBookFlag", 
            "GmailList", "GrayscaleFlag", "ImgBuf", "ImgLen", "Level", "LevelHighExp", "LevelLowExp", "NickName", "PersonalCard", "PluginFlag", "PluginSwitch", "Point", "Province", "Sex", "Signature", "Status", 
            "TXNewsCategory", "UserName", "VerifyFlag", "VerifyInfo", "Weibo", "WeiboFlag", "WeiboNickname"
         };
        private static readonly uint[] _modUserInfoFieldTags = new uint[] { 
            0x11a, 0x110, 0x108, 0xda, 0x2a, 50, 0x20, 8, 0x62, 0x132, 0x7a, 160, 0x12a, 0xf8, 0x102, 240, 
            210, 0x138, 0x4a, 0x40, 0xa8, 0xb8, 0xb0, 0x1a, 0x70, 0x80, 200, 0x98, 90, 80, 0x6a, 0x38, 
            0x120, 0x12, 0x88, 0x92, 0xc2, 0xe8, 0xe2
         };
        private string albumBGImgID_ = "";
        public const int AlbumBGImgIDFieldNumber = 0x23;
        private int albumFlag_;
        public const int AlbumFlagFieldNumber = 0x22;
        private int albumStyle_;
        public const int AlbumStyleFieldNumber = 0x21;
        private string alias_ = "";
        public const int AliasFieldNumber = 0x1b;
        private SKBuiltinString_t bindEmail_;
        public const int BindEmailFieldNumber = 5;
        private SKBuiltinString_t bindMobile_;
        public const int BindMobileFieldNumber = 6;
        private uint bindUin_;
        public const int BindUinFieldNumber = 4;
        private uint bitFlag_;
        public const int BitFlagFieldNumber = 1;
        private string city_ = "";
        public const int CityFieldNumber = 12;
        private string country_ = "";
        public const int CountryFieldNumber = 0x26;
        private static readonly ModUserInfo defaultInstance = new ModUserInfo().MakeReadOnly();
        private micromsg.DisturbSetting disturbSetting_;
        public const int DisturbSettingFieldNumber = 15;
        private int experience_;
        public const int ExperienceFieldNumber = 20;
        private uint faceBookFlag_;
        public const int FaceBookFlagFieldNumber = 30;
        private string fBToken_ = "";
        public const int FBTokenFieldNumber = 0x25;
        private ulong fBUserID_;
        public const int FBUserIDFieldNumber = 0x1f;
        private string fBUserName_ = "";
        public const int FBUserNameFieldNumber = 0x20;
        private micromsg.GmailList gmailList_;
        public const int GmailListFieldNumber = 0x1a;
        private uint grayscaleFlag_;
        public const int GrayscaleFlagFieldNumber = 0x27;
        private bool hasAlbumBGImgID;
        private bool hasAlbumFlag;
        private bool hasAlbumStyle;
        private bool hasAlias;
        private bool hasBindEmail;
        private bool hasBindMobile;
        private bool hasBindUin;
        private bool hasBitFlag;
        private bool hasCity;
        private bool hasCountry;
        private bool hasDisturbSetting;
        private bool hasExperience;
        private bool hasFaceBookFlag;
        private bool hasFBToken;
        private bool hasFBUserID;
        private bool hasFBUserName;
        private bool hasGmailList;
        private bool hasGrayscaleFlag;
        private bool hasImgBuf;
        private bool hasImgLen;
        private bool hasLevel;
        private bool hasLevelHighExp;
        private bool hasLevelLowExp;
        private bool hasNickName;
        private bool hasPersonalCard;
        private bool hasPluginFlag;
        private bool hasPluginSwitch;
        private bool hasPoint;
        private bool hasProvince;
        private bool hasSex;
        private bool hasSignature;
        private bool hasStatus;
        private bool hasTXNewsCategory;
        private bool hasUserName;
        private bool hasVerifyFlag;
        private bool hasVerifyInfo;
        private bool hasWeibo;
        private bool hasWeiboFlag;
        private bool hasWeiboNickname;
        private ByteString imgBuf_ = ByteString.Empty;
        public const int ImgBufFieldNumber = 9;
        private uint imgLen_;
        public const int ImgLenFieldNumber = 8;
        private int level_;
        public const int LevelFieldNumber = 0x15;
        private int levelHighExp_;
        public const int LevelHighExpFieldNumber = 0x17;
        private int levelLowExp_;
        public const int LevelLowExpFieldNumber = 0x16;
        private int memoizedSerializedSize = -1;
        private SKBuiltinString_t nickName_;
        public const int NickNameFieldNumber = 3;
        private uint personalCard_;
        public const int PersonalCardFieldNumber = 14;
        private uint pluginFlag_;
        public const int PluginFlagFieldNumber = 0x10;
        private uint pluginSwitch_;
        public const int PluginSwitchFieldNumber = 0x19;
        private int point_;
        public const int PointFieldNumber = 0x13;
        private string province_ = "";
        public const int ProvinceFieldNumber = 11;
        private int sex_;
        public const int SexFieldNumber = 10;
        private string signature_ = "";
        public const int SignatureFieldNumber = 13;
        private uint status_;
        public const int StatusFieldNumber = 7;
        private uint tXNewsCategory_;
        public const int TXNewsCategoryFieldNumber = 0x24;
        private SKBuiltinString_t userName_;
        public const int UserNameFieldNumber = 2;
        private uint verifyFlag_;
        public const int VerifyFlagFieldNumber = 0x11;
        private string verifyInfo_ = "";
        public const int VerifyInfoFieldNumber = 0x12;
        private string weibo_ = "";
        public const int WeiboFieldNumber = 0x18;
        private uint weiboFlag_;
        public const int WeiboFlagFieldNumber = 0x1d;
        private string weiboNickname_ = "";
        public const int WeiboNicknameFieldNumber = 0x1c;

        static ModUserInfo()
        {
           // object.ReferenceEquals(ModUserInfo.Descriptor, null);
        }

        private ModUserInfo()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(ModUserInfo prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            ModUserInfo info = obj as ModUserInfo;
            if (info == null)
            {
                return false;
            }
            if ((this.hasBitFlag != info.hasBitFlag) || (this.hasBitFlag && !this.bitFlag_.Equals(info.bitFlag_)))
            {
                return false;
            }
            if ((this.hasUserName != info.hasUserName) || (this.hasUserName && !this.userName_.Equals(info.userName_)))
            {
                return false;
            }
            if ((this.hasNickName != info.hasNickName) || (this.hasNickName && !this.nickName_.Equals(info.nickName_)))
            {
                return false;
            }
            if ((this.hasBindUin != info.hasBindUin) || (this.hasBindUin && !this.bindUin_.Equals(info.bindUin_)))
            {
                return false;
            }
            if ((this.hasBindEmail != info.hasBindEmail) || (this.hasBindEmail && !this.bindEmail_.Equals(info.bindEmail_)))
            {
                return false;
            }
            if ((this.hasBindMobile != info.hasBindMobile) || (this.hasBindMobile && !this.bindMobile_.Equals(info.bindMobile_)))
            {
                return false;
            }
            if ((this.hasStatus != info.hasStatus) || (this.hasStatus && !this.status_.Equals(info.status_)))
            {
                return false;
            }
            if ((this.hasImgLen != info.hasImgLen) || (this.hasImgLen && !this.imgLen_.Equals(info.imgLen_)))
            {
                return false;
            }
            if ((this.hasImgBuf != info.hasImgBuf) || (this.hasImgBuf && !this.imgBuf_.Equals(info.imgBuf_)))
            {
                return false;
            }
            if ((this.hasSex != info.hasSex) || (this.hasSex && !this.sex_.Equals(info.sex_)))
            {
                return false;
            }
            if ((this.hasProvince != info.hasProvince) || (this.hasProvince && !this.province_.Equals(info.province_)))
            {
                return false;
            }
            if ((this.hasCity != info.hasCity) || (this.hasCity && !this.city_.Equals(info.city_)))
            {
                return false;
            }
            if ((this.hasSignature != info.hasSignature) || (this.hasSignature && !this.signature_.Equals(info.signature_)))
            {
                return false;
            }
            if ((this.hasPersonalCard != info.hasPersonalCard) || (this.hasPersonalCard && !this.personalCard_.Equals(info.personalCard_)))
            {
                return false;
            }
            if ((this.hasDisturbSetting != info.hasDisturbSetting) || (this.hasDisturbSetting && !this.disturbSetting_.Equals(info.disturbSetting_)))
            {
                return false;
            }
            if ((this.hasPluginFlag != info.hasPluginFlag) || (this.hasPluginFlag && !this.pluginFlag_.Equals(info.pluginFlag_)))
            {
                return false;
            }
            if ((this.hasVerifyFlag != info.hasVerifyFlag) || (this.hasVerifyFlag && !this.verifyFlag_.Equals(info.verifyFlag_)))
            {
                return false;
            }
            if ((this.hasVerifyInfo != info.hasVerifyInfo) || (this.hasVerifyInfo && !this.verifyInfo_.Equals(info.verifyInfo_)))
            {
                return false;
            }
            if ((this.hasPoint != info.hasPoint) || (this.hasPoint && !this.point_.Equals(info.point_)))
            {
                return false;
            }
            if ((this.hasExperience != info.hasExperience) || (this.hasExperience && !this.experience_.Equals(info.experience_)))
            {
                return false;
            }
            if ((this.hasLevel != info.hasLevel) || (this.hasLevel && !this.level_.Equals(info.level_)))
            {
                return false;
            }
            if ((this.hasLevelLowExp != info.hasLevelLowExp) || (this.hasLevelLowExp && !this.levelLowExp_.Equals(info.levelLowExp_)))
            {
                return false;
            }
            if ((this.hasLevelHighExp != info.hasLevelHighExp) || (this.hasLevelHighExp && !this.levelHighExp_.Equals(info.levelHighExp_)))
            {
                return false;
            }
            if ((this.hasWeibo != info.hasWeibo) || (this.hasWeibo && !this.weibo_.Equals(info.weibo_)))
            {
                return false;
            }
            if ((this.hasPluginSwitch != info.hasPluginSwitch) || (this.hasPluginSwitch && !this.pluginSwitch_.Equals(info.pluginSwitch_)))
            {
                return false;
            }
            if ((this.hasGmailList != info.hasGmailList) || (this.hasGmailList && !this.gmailList_.Equals(info.gmailList_)))
            {
                return false;
            }
            if ((this.hasAlias != info.hasAlias) || (this.hasAlias && !this.alias_.Equals(info.alias_)))
            {
                return false;
            }
            if ((this.hasWeiboNickname != info.hasWeiboNickname) || (this.hasWeiboNickname && !this.weiboNickname_.Equals(info.weiboNickname_)))
            {
                return false;
            }
            if ((this.hasWeiboFlag != info.hasWeiboFlag) || (this.hasWeiboFlag && !this.weiboFlag_.Equals(info.weiboFlag_)))
            {
                return false;
            }
            if ((this.hasFaceBookFlag != info.hasFaceBookFlag) || (this.hasFaceBookFlag && !this.faceBookFlag_.Equals(info.faceBookFlag_)))
            {
                return false;
            }
            if ((this.hasFBUserID != info.hasFBUserID) || (this.hasFBUserID && !this.fBUserID_.Equals(info.fBUserID_)))
            {
                return false;
            }
            if ((this.hasFBUserName != info.hasFBUserName) || (this.hasFBUserName && !this.fBUserName_.Equals(info.fBUserName_)))
            {
                return false;
            }
            if ((this.hasAlbumStyle != info.hasAlbumStyle) || (this.hasAlbumStyle && !this.albumStyle_.Equals(info.albumStyle_)))
            {
                return false;
            }
            if ((this.hasAlbumFlag != info.hasAlbumFlag) || (this.hasAlbumFlag && !this.albumFlag_.Equals(info.albumFlag_)))
            {
                return false;
            }
            if ((this.hasAlbumBGImgID != info.hasAlbumBGImgID) || (this.hasAlbumBGImgID && !this.albumBGImgID_.Equals(info.albumBGImgID_)))
            {
                return false;
            }
            if ((this.hasTXNewsCategory != info.hasTXNewsCategory) || (this.hasTXNewsCategory && !this.tXNewsCategory_.Equals(info.tXNewsCategory_)))
            {
                return false;
            }
            if ((this.hasFBToken != info.hasFBToken) || (this.hasFBToken && !this.fBToken_.Equals(info.fBToken_)))
            {
                return false;
            }
            if ((this.hasCountry != info.hasCountry) || (this.hasCountry && !this.country_.Equals(info.country_)))
            {
                return false;
            }
            return ((this.hasGrayscaleFlag == info.hasGrayscaleFlag) && (!this.hasGrayscaleFlag || this.grayscaleFlag_.Equals(info.grayscaleFlag_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasBitFlag)
            {
                hashCode ^= this.bitFlag_.GetHashCode();
            }
            if (this.hasUserName)
            {
                hashCode ^= this.userName_.GetHashCode();
            }
            if (this.hasNickName)
            {
                hashCode ^= this.nickName_.GetHashCode();
            }
            if (this.hasBindUin)
            {
                hashCode ^= this.bindUin_.GetHashCode();
            }
            if (this.hasBindEmail)
            {
                hashCode ^= this.bindEmail_.GetHashCode();
            }
            if (this.hasBindMobile)
            {
                hashCode ^= this.bindMobile_.GetHashCode();
            }
            if (this.hasStatus)
            {
                hashCode ^= this.status_.GetHashCode();
            }
            if (this.hasImgLen)
            {
                hashCode ^= this.imgLen_.GetHashCode();
            }
            if (this.hasImgBuf)
            {
                hashCode ^= this.imgBuf_.GetHashCode();
            }
            if (this.hasSex)
            {
                hashCode ^= this.sex_.GetHashCode();
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
            if (this.hasDisturbSetting)
            {
                hashCode ^= this.disturbSetting_.GetHashCode();
            }
            if (this.hasPluginFlag)
            {
                hashCode ^= this.pluginFlag_.GetHashCode();
            }
            if (this.hasVerifyFlag)
            {
                hashCode ^= this.verifyFlag_.GetHashCode();
            }
            if (this.hasVerifyInfo)
            {
                hashCode ^= this.verifyInfo_.GetHashCode();
            }
            if (this.hasPoint)
            {
                hashCode ^= this.point_.GetHashCode();
            }
            if (this.hasExperience)
            {
                hashCode ^= this.experience_.GetHashCode();
            }
            if (this.hasLevel)
            {
                hashCode ^= this.level_.GetHashCode();
            }
            if (this.hasLevelLowExp)
            {
                hashCode ^= this.levelLowExp_.GetHashCode();
            }
            if (this.hasLevelHighExp)
            {
                hashCode ^= this.levelHighExp_.GetHashCode();
            }
            if (this.hasWeibo)
            {
                hashCode ^= this.weibo_.GetHashCode();
            }
            if (this.hasPluginSwitch)
            {
                hashCode ^= this.pluginSwitch_.GetHashCode();
            }
            if (this.hasGmailList)
            {
                hashCode ^= this.gmailList_.GetHashCode();
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
            if (this.hasFaceBookFlag)
            {
                hashCode ^= this.faceBookFlag_.GetHashCode();
            }
            if (this.hasFBUserID)
            {
                hashCode ^= this.fBUserID_.GetHashCode();
            }
            if (this.hasFBUserName)
            {
                hashCode ^= this.fBUserName_.GetHashCode();
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
            if (this.hasTXNewsCategory)
            {
                hashCode ^= this.tXNewsCategory_.GetHashCode();
            }
            if (this.hasFBToken)
            {
                hashCode ^= this.fBToken_.GetHashCode();
            }
            if (this.hasCountry)
            {
                hashCode ^= this.country_.GetHashCode();
            }
            if (this.hasGrayscaleFlag)
            {
                hashCode ^= this.grayscaleFlag_.GetHashCode();
            }
            return hashCode;
        }

        private ModUserInfo MakeReadOnly()
        {
            return this;
        }

        public static ModUserInfo ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<ModUserInfo, Builder>.PrintField("BitFlag", this.hasBitFlag, this.bitFlag_, writer);
            GeneratedMessageLite<ModUserInfo, Builder>.PrintField("UserName", this.hasUserName, this.userName_, writer);
            GeneratedMessageLite<ModUserInfo, Builder>.PrintField("NickName", this.hasNickName, this.nickName_, writer);
            GeneratedMessageLite<ModUserInfo, Builder>.PrintField("BindUin", this.hasBindUin, this.bindUin_, writer);
            GeneratedMessageLite<ModUserInfo, Builder>.PrintField("BindEmail", this.hasBindEmail, this.bindEmail_, writer);
            GeneratedMessageLite<ModUserInfo, Builder>.PrintField("BindMobile", this.hasBindMobile, this.bindMobile_, writer);
            GeneratedMessageLite<ModUserInfo, Builder>.PrintField("Status", this.hasStatus, this.status_, writer);
            GeneratedMessageLite<ModUserInfo, Builder>.PrintField("ImgLen", this.hasImgLen, this.imgLen_, writer);
            GeneratedMessageLite<ModUserInfo, Builder>.PrintField("ImgBuf", this.hasImgBuf, this.imgBuf_, writer);
            GeneratedMessageLite<ModUserInfo, Builder>.PrintField("Sex", this.hasSex, this.sex_, writer);
            GeneratedMessageLite<ModUserInfo, Builder>.PrintField("Province", this.hasProvince, this.province_, writer);
            GeneratedMessageLite<ModUserInfo, Builder>.PrintField("City", this.hasCity, this.city_, writer);
            GeneratedMessageLite<ModUserInfo, Builder>.PrintField("Signature", this.hasSignature, this.signature_, writer);
            GeneratedMessageLite<ModUserInfo, Builder>.PrintField("PersonalCard", this.hasPersonalCard, this.personalCard_, writer);
            GeneratedMessageLite<ModUserInfo, Builder>.PrintField("DisturbSetting", this.hasDisturbSetting, this.disturbSetting_, writer);
            GeneratedMessageLite<ModUserInfo, Builder>.PrintField("PluginFlag", this.hasPluginFlag, this.pluginFlag_, writer);
            GeneratedMessageLite<ModUserInfo, Builder>.PrintField("VerifyFlag", this.hasVerifyFlag, this.verifyFlag_, writer);
            GeneratedMessageLite<ModUserInfo, Builder>.PrintField("VerifyInfo", this.hasVerifyInfo, this.verifyInfo_, writer);
            GeneratedMessageLite<ModUserInfo, Builder>.PrintField("Point", this.hasPoint, this.point_, writer);
            GeneratedMessageLite<ModUserInfo, Builder>.PrintField("Experience", this.hasExperience, this.experience_, writer);
            GeneratedMessageLite<ModUserInfo, Builder>.PrintField("Level", this.hasLevel, this.level_, writer);
            GeneratedMessageLite<ModUserInfo, Builder>.PrintField("LevelLowExp", this.hasLevelLowExp, this.levelLowExp_, writer);
            GeneratedMessageLite<ModUserInfo, Builder>.PrintField("LevelHighExp", this.hasLevelHighExp, this.levelHighExp_, writer);
            GeneratedMessageLite<ModUserInfo, Builder>.PrintField("Weibo", this.hasWeibo, this.weibo_, writer);
            GeneratedMessageLite<ModUserInfo, Builder>.PrintField("PluginSwitch", this.hasPluginSwitch, this.pluginSwitch_, writer);
            GeneratedMessageLite<ModUserInfo, Builder>.PrintField("GmailList", this.hasGmailList, this.gmailList_, writer);
            GeneratedMessageLite<ModUserInfo, Builder>.PrintField("Alias", this.hasAlias, this.alias_, writer);
            GeneratedMessageLite<ModUserInfo, Builder>.PrintField("WeiboNickname", this.hasWeiboNickname, this.weiboNickname_, writer);
            GeneratedMessageLite<ModUserInfo, Builder>.PrintField("WeiboFlag", this.hasWeiboFlag, this.weiboFlag_, writer);
            GeneratedMessageLite<ModUserInfo, Builder>.PrintField("FaceBookFlag", this.hasFaceBookFlag, this.faceBookFlag_, writer);
            GeneratedMessageLite<ModUserInfo, Builder>.PrintField("FBUserID", this.hasFBUserID, this.fBUserID_, writer);
            GeneratedMessageLite<ModUserInfo, Builder>.PrintField("FBUserName", this.hasFBUserName, this.fBUserName_, writer);
            GeneratedMessageLite<ModUserInfo, Builder>.PrintField("AlbumStyle", this.hasAlbumStyle, this.albumStyle_, writer);
            GeneratedMessageLite<ModUserInfo, Builder>.PrintField("AlbumFlag", this.hasAlbumFlag, this.albumFlag_, writer);
            GeneratedMessageLite<ModUserInfo, Builder>.PrintField("AlbumBGImgID", this.hasAlbumBGImgID, this.albumBGImgID_, writer);
            GeneratedMessageLite<ModUserInfo, Builder>.PrintField("TXNewsCategory", this.hasTXNewsCategory, this.tXNewsCategory_, writer);
            GeneratedMessageLite<ModUserInfo, Builder>.PrintField("FBToken", this.hasFBToken, this.fBToken_, writer);
            GeneratedMessageLite<ModUserInfo, Builder>.PrintField("Country", this.hasCountry, this.country_, writer);
            GeneratedMessageLite<ModUserInfo, Builder>.PrintField("GrayscaleFlag", this.hasGrayscaleFlag, this.grayscaleFlag_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _modUserInfoFieldNames;
            if (this.hasBitFlag)
            {
                output.WriteUInt32(1, strArray[7], this.BitFlag);
            }
            if (this.hasUserName)
            {
                output.WriteMessage(2, strArray[0x21], this.UserName);
            }
            if (this.hasNickName)
            {
                output.WriteMessage(3, strArray[0x17], this.NickName);
            }
            if (this.hasBindUin)
            {
                output.WriteUInt32(4, strArray[6], this.BindUin);
            }
            if (this.hasBindEmail)
            {
                output.WriteMessage(5, strArray[4], this.BindEmail);
            }
            if (this.hasBindMobile)
            {
                output.WriteMessage(6, strArray[5], this.BindMobile);
            }
            if (this.hasStatus)
            {
                output.WriteUInt32(7, strArray[0x1f], this.Status);
            }
            if (this.hasImgLen)
            {
                output.WriteUInt32(8, strArray[0x13], this.ImgLen);
            }
            if (this.hasImgBuf)
            {
                output.WriteBytes(9, strArray[0x12], this.ImgBuf);
            }
            if (this.hasSex)
            {
                output.WriteInt32(10, strArray[0x1d], this.Sex);
            }
            if (this.hasProvince)
            {
                output.WriteString(11, strArray[0x1c], this.Province);
            }
            if (this.hasCity)
            {
                output.WriteString(12, strArray[8], this.City);
            }
            if (this.hasSignature)
            {
                output.WriteString(13, strArray[30], this.Signature);
            }
            if (this.hasPersonalCard)
            {
                output.WriteUInt32(14, strArray[0x18], this.PersonalCard);
            }
            if (this.hasDisturbSetting)
            {
                output.WriteMessage(15, strArray[10], this.DisturbSetting);
            }
            if (this.hasPluginFlag)
            {
                output.WriteUInt32(0x10, strArray[0x19], this.PluginFlag);
            }
            if (this.hasVerifyFlag)
            {
                output.WriteUInt32(0x11, strArray[0x22], this.VerifyFlag);
            }
            if (this.hasVerifyInfo)
            {
                output.WriteString(0x12, strArray[0x23], this.VerifyInfo);
            }
            if (this.hasPoint)
            {
                output.WriteInt32(0x13, strArray[0x1b], this.Point);
            }
            if (this.hasExperience)
            {
                output.WriteInt32(20, strArray[11], this.Experience);
            }
            if (this.hasLevel)
            {
                output.WriteInt32(0x15, strArray[20], this.Level);
            }
            if (this.hasLevelLowExp)
            {
                output.WriteInt32(0x16, strArray[0x16], this.LevelLowExp);
            }
            if (this.hasLevelHighExp)
            {
                output.WriteInt32(0x17, strArray[0x15], this.LevelHighExp);
            }
            if (this.hasWeibo)
            {
                output.WriteString(0x18, strArray[0x24], this.Weibo);
            }
            if (this.hasPluginSwitch)
            {
                output.WriteUInt32(0x19, strArray[0x1a], this.PluginSwitch);
            }
            if (this.hasGmailList)
            {
                output.WriteMessage(0x1a, strArray[0x10], this.GmailList);
            }
            if (this.hasAlias)
            {
                output.WriteString(0x1b, strArray[3], this.Alias);
            }
            if (this.hasWeiboNickname)
            {
                output.WriteString(0x1c, strArray[0x26], this.WeiboNickname);
            }
            if (this.hasWeiboFlag)
            {
                output.WriteUInt32(0x1d, strArray[0x25], this.WeiboFlag);
            }
            if (this.hasFaceBookFlag)
            {
                output.WriteUInt32(30, strArray[15], this.FaceBookFlag);
            }
            if (this.hasFBUserID)
            {
                output.WriteUInt64(0x1f, strArray[13], this.FBUserID);
            }
            if (this.hasFBUserName)
            {
                output.WriteString(0x20, strArray[14], this.FBUserName);
            }
            if (this.hasAlbumStyle)
            {
                output.WriteInt32(0x21, strArray[2], this.AlbumStyle);
            }
            if (this.hasAlbumFlag)
            {
                output.WriteInt32(0x22, strArray[1], this.AlbumFlag);
            }
            if (this.hasAlbumBGImgID)
            {
                output.WriteString(0x23, strArray[0], this.AlbumBGImgID);
            }
            if (this.hasTXNewsCategory)
            {
                output.WriteUInt32(0x24, strArray[0x20], this.TXNewsCategory);
            }
            if (this.hasFBToken)
            {
                output.WriteString(0x25, strArray[12], this.FBToken);
            }
            if (this.hasCountry)
            {
                output.WriteString(0x26, strArray[9], this.Country);
            }
            if (this.hasGrayscaleFlag)
            {
                output.WriteUInt32(0x27, strArray[0x11], this.GrayscaleFlag);
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

        public SKBuiltinString_t BindEmail
        {
            get
            {
                return (this.bindEmail_ ?? SKBuiltinString_t.DefaultInstance);
            }
        }

        public SKBuiltinString_t BindMobile
        {
            get
            {
                return (this.bindMobile_ ?? SKBuiltinString_t.DefaultInstance);
            }
        }

        public uint BindUin
        {
            get
            {
                return this.bindUin_;
            }
        }

        public uint BitFlag
        {
            get
            {
                return this.bitFlag_;
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

        public static ModUserInfo DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override ModUserInfo DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public micromsg.DisturbSetting DisturbSetting
        {
            get
            {
                return (this.disturbSetting_ ?? micromsg.DisturbSetting.DefaultInstance);
            }
        }

        public int Experience
        {
            get
            {
                return this.experience_;
            }
        }

        public uint FaceBookFlag
        {
            get
            {
                return this.faceBookFlag_;
            }
        }

        public string FBToken
        {
            get
            {
                return this.fBToken_;
            }
        }

        public ulong FBUserID
        {
            get
            {
                return this.fBUserID_;
            }
        }

        public string FBUserName
        {
            get
            {
                return this.fBUserName_;
            }
        }

        public micromsg.GmailList GmailList
        {
            get
            {
                return (this.gmailList_ ?? micromsg.GmailList.DefaultInstance);
            }
        }

        public uint GrayscaleFlag
        {
            get
            {
                return this.grayscaleFlag_;
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

        public override bool IsInitialized
        {
            get
            {
                if (!this.hasBitFlag)
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
                if (!this.hasBindUin)
                {
                    return false;
                }
                if (!this.hasBindEmail)
                {
                    return false;
                }
                if (!this.hasBindMobile)
                {
                    return false;
                }
                if (!this.hasStatus)
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

        public int Level
        {
            get
            {
                return this.level_;
            }
        }

        public int LevelHighExp
        {
            get
            {
                return this.levelHighExp_;
            }
        }

        public int LevelLowExp
        {
            get
            {
                return this.levelLowExp_;
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

        public uint PluginFlag
        {
            get
            {
                return this.pluginFlag_;
            }
        }

        public uint PluginSwitch
        {
            get
            {
                return this.pluginSwitch_;
            }
        }

        public int Point
        {
            get
            {
                return this.point_;
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
                    if (this.hasBitFlag)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(1, this.BitFlag);
                    }
                    if (this.hasUserName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(2, this.UserName);
                    }
                    if (this.hasNickName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(3, this.NickName);
                    }
                    if (this.hasBindUin)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(4, this.BindUin);
                    }
                    if (this.hasBindEmail)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(5, this.BindEmail);
                    }
                    if (this.hasBindMobile)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(6, this.BindMobile);
                    }
                    if (this.hasStatus)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(7, this.Status);
                    }
                    if (this.hasImgLen)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(8, this.ImgLen);
                    }
                    if (this.hasImgBuf)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeBytesSize(9, this.ImgBuf);
                    }
                    if (this.hasSex)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(10, this.Sex);
                    }
                    if (this.hasProvince)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(11, this.Province);
                    }
                    if (this.hasCity)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(12, this.City);
                    }
                    if (this.hasSignature)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(13, this.Signature);
                    }
                    if (this.hasPersonalCard)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(14, this.PersonalCard);
                    }
                    if (this.hasDisturbSetting)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(15, this.DisturbSetting);
                    }
                    if (this.hasPluginFlag)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(0x10, this.PluginFlag);
                    }
                    if (this.hasVerifyFlag)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(0x11, this.VerifyFlag);
                    }
                    if (this.hasVerifyInfo)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x12, this.VerifyInfo);
                    }
                    if (this.hasPoint)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(0x13, this.Point);
                    }
                    if (this.hasExperience)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(20, this.Experience);
                    }
                    if (this.hasLevel)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(0x15, this.Level);
                    }
                    if (this.hasLevelLowExp)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(0x16, this.LevelLowExp);
                    }
                    if (this.hasLevelHighExp)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(0x17, this.LevelHighExp);
                    }
                    if (this.hasWeibo)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x18, this.Weibo);
                    }
                    if (this.hasPluginSwitch)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(0x19, this.PluginSwitch);
                    }
                    if (this.hasGmailList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(0x1a, this.GmailList);
                    }
                    if (this.hasAlias)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x1b, this.Alias);
                    }
                    if (this.hasWeiboNickname)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x1c, this.WeiboNickname);
                    }
                    if (this.hasWeiboFlag)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(0x1d, this.WeiboFlag);
                    }
                    if (this.hasFaceBookFlag)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(30, this.FaceBookFlag);
                    }
                    if (this.hasFBUserID)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt64Size(0x1f, this.FBUserID);
                    }
                    if (this.hasFBUserName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x20, this.FBUserName);
                    }
                    if (this.hasAlbumStyle)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(0x21, this.AlbumStyle);
                    }
                    if (this.hasAlbumFlag)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(0x22, this.AlbumFlag);
                    }
                    if (this.hasAlbumBGImgID)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x23, this.AlbumBGImgID);
                    }
                    if (this.hasTXNewsCategory)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(0x24, this.TXNewsCategory);
                    }
                    if (this.hasFBToken)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x25, this.FBToken);
                    }
                    if (this.hasCountry)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x26, this.Country);
                    }
                    if (this.hasGrayscaleFlag)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(0x27, this.GrayscaleFlag);
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

        public uint Status
        {
            get
            {
                return this.status_;
            }
        }

        protected override ModUserInfo ThisMessage
        {
            get
            {
                return this;
            }
        }

        public uint TXNewsCategory
        {
            get
            {
                return this.tXNewsCategory_;
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

        
        public sealed class Builder : GeneratedBuilderLite<ModUserInfo, ModUserInfo.Builder>
        {
            private ModUserInfo result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = ModUserInfo.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(ModUserInfo cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override ModUserInfo BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override ModUserInfo.Builder Clear()
            {
                this.result = ModUserInfo.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public ModUserInfo.Builder ClearAlbumBGImgID()
            {
                this.PrepareBuilder();
                this.result.hasAlbumBGImgID = false;
                this.result.albumBGImgID_ = "";
                return this;
            }

            public ModUserInfo.Builder ClearAlbumFlag()
            {
                this.PrepareBuilder();
                this.result.hasAlbumFlag = false;
                this.result.albumFlag_ = 0;
                return this;
            }

            public ModUserInfo.Builder ClearAlbumStyle()
            {
                this.PrepareBuilder();
                this.result.hasAlbumStyle = false;
                this.result.albumStyle_ = 0;
                return this;
            }

            public ModUserInfo.Builder ClearAlias()
            {
                this.PrepareBuilder();
                this.result.hasAlias = false;
                this.result.alias_ = "";
                return this;
            }

            public ModUserInfo.Builder ClearBindEmail()
            {
                this.PrepareBuilder();
                this.result.hasBindEmail = false;
                this.result.bindEmail_ = null;
                return this;
            }

            public ModUserInfo.Builder ClearBindMobile()
            {
                this.PrepareBuilder();
                this.result.hasBindMobile = false;
                this.result.bindMobile_ = null;
                return this;
            }

            public ModUserInfo.Builder ClearBindUin()
            {
                this.PrepareBuilder();
                this.result.hasBindUin = false;
                this.result.bindUin_ = 0;
                return this;
            }

            public ModUserInfo.Builder ClearBitFlag()
            {
                this.PrepareBuilder();
                this.result.hasBitFlag = false;
                this.result.bitFlag_ = 0;
                return this;
            }

            public ModUserInfo.Builder ClearCity()
            {
                this.PrepareBuilder();
                this.result.hasCity = false;
                this.result.city_ = "";
                return this;
            }

            public ModUserInfo.Builder ClearCountry()
            {
                this.PrepareBuilder();
                this.result.hasCountry = false;
                this.result.country_ = "";
                return this;
            }

            public ModUserInfo.Builder ClearDisturbSetting()
            {
                this.PrepareBuilder();
                this.result.hasDisturbSetting = false;
                this.result.disturbSetting_ = null;
                return this;
            }

            public ModUserInfo.Builder ClearExperience()
            {
                this.PrepareBuilder();
                this.result.hasExperience = false;
                this.result.experience_ = 0;
                return this;
            }

            public ModUserInfo.Builder ClearFaceBookFlag()
            {
                this.PrepareBuilder();
                this.result.hasFaceBookFlag = false;
                this.result.faceBookFlag_ = 0;
                return this;
            }

            public ModUserInfo.Builder ClearFBToken()
            {
                this.PrepareBuilder();
                this.result.hasFBToken = false;
                this.result.fBToken_ = "";
                return this;
            }

            public ModUserInfo.Builder ClearFBUserID()
            {
                this.PrepareBuilder();
                this.result.hasFBUserID = false;
                this.result.fBUserID_ = 0L;
                return this;
            }

            public ModUserInfo.Builder ClearFBUserName()
            {
                this.PrepareBuilder();
                this.result.hasFBUserName = false;
                this.result.fBUserName_ = "";
                return this;
            }

            public ModUserInfo.Builder ClearGmailList()
            {
                this.PrepareBuilder();
                this.result.hasGmailList = false;
                this.result.gmailList_ = null;
                return this;
            }

            public ModUserInfo.Builder ClearGrayscaleFlag()
            {
                this.PrepareBuilder();
                this.result.hasGrayscaleFlag = false;
                this.result.grayscaleFlag_ = 0;
                return this;
            }

            public ModUserInfo.Builder ClearImgBuf()
            {
                this.PrepareBuilder();
                this.result.hasImgBuf = false;
                this.result.imgBuf_ = ByteString.Empty;
                return this;
            }

            public ModUserInfo.Builder ClearImgLen()
            {
                this.PrepareBuilder();
                this.result.hasImgLen = false;
                this.result.imgLen_ = 0;
                return this;
            }

            public ModUserInfo.Builder ClearLevel()
            {
                this.PrepareBuilder();
                this.result.hasLevel = false;
                this.result.level_ = 0;
                return this;
            }

            public ModUserInfo.Builder ClearLevelHighExp()
            {
                this.PrepareBuilder();
                this.result.hasLevelHighExp = false;
                this.result.levelHighExp_ = 0;
                return this;
            }

            public ModUserInfo.Builder ClearLevelLowExp()
            {
                this.PrepareBuilder();
                this.result.hasLevelLowExp = false;
                this.result.levelLowExp_ = 0;
                return this;
            }

            public ModUserInfo.Builder ClearNickName()
            {
                this.PrepareBuilder();
                this.result.hasNickName = false;
                this.result.nickName_ = null;
                return this;
            }

            public ModUserInfo.Builder ClearPersonalCard()
            {
                this.PrepareBuilder();
                this.result.hasPersonalCard = false;
                this.result.personalCard_ = 0;
                return this;
            }

            public ModUserInfo.Builder ClearPluginFlag()
            {
                this.PrepareBuilder();
                this.result.hasPluginFlag = false;
                this.result.pluginFlag_ = 0;
                return this;
            }

            public ModUserInfo.Builder ClearPluginSwitch()
            {
                this.PrepareBuilder();
                this.result.hasPluginSwitch = false;
                this.result.pluginSwitch_ = 0;
                return this;
            }

            public ModUserInfo.Builder ClearPoint()
            {
                this.PrepareBuilder();
                this.result.hasPoint = false;
                this.result.point_ = 0;
                return this;
            }

            public ModUserInfo.Builder ClearProvince()
            {
                this.PrepareBuilder();
                this.result.hasProvince = false;
                this.result.province_ = "";
                return this;
            }

            public ModUserInfo.Builder ClearSex()
            {
                this.PrepareBuilder();
                this.result.hasSex = false;
                this.result.sex_ = 0;
                return this;
            }

            public ModUserInfo.Builder ClearSignature()
            {
                this.PrepareBuilder();
                this.result.hasSignature = false;
                this.result.signature_ = "";
                return this;
            }

            public ModUserInfo.Builder ClearStatus()
            {
                this.PrepareBuilder();
                this.result.hasStatus = false;
                this.result.status_ = 0;
                return this;
            }

            public ModUserInfo.Builder ClearTXNewsCategory()
            {
                this.PrepareBuilder();
                this.result.hasTXNewsCategory = false;
                this.result.tXNewsCategory_ = 0;
                return this;
            }

            public ModUserInfo.Builder ClearUserName()
            {
                this.PrepareBuilder();
                this.result.hasUserName = false;
                this.result.userName_ = null;
                return this;
            }

            public ModUserInfo.Builder ClearVerifyFlag()
            {
                this.PrepareBuilder();
                this.result.hasVerifyFlag = false;
                this.result.verifyFlag_ = 0;
                return this;
            }

            public ModUserInfo.Builder ClearVerifyInfo()
            {
                this.PrepareBuilder();
                this.result.hasVerifyInfo = false;
                this.result.verifyInfo_ = "";
                return this;
            }

            public ModUserInfo.Builder ClearWeibo()
            {
                this.PrepareBuilder();
                this.result.hasWeibo = false;
                this.result.weibo_ = "";
                return this;
            }

            public ModUserInfo.Builder ClearWeiboFlag()
            {
                this.PrepareBuilder();
                this.result.hasWeiboFlag = false;
                this.result.weiboFlag_ = 0;
                return this;
            }

            public ModUserInfo.Builder ClearWeiboNickname()
            {
                this.PrepareBuilder();
                this.result.hasWeiboNickname = false;
                this.result.weiboNickname_ = "";
                return this;
            }

            public override ModUserInfo.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new ModUserInfo.Builder(this.result);
                }
                return new ModUserInfo.Builder().MergeFrom(this.result);
            }

            public ModUserInfo.Builder MergeBindEmail(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasBindEmail && (this.result.bindEmail_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.bindEmail_ = SKBuiltinString_t.CreateBuilder(this.result.bindEmail_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.bindEmail_ = value;
                }
                this.result.hasBindEmail = true;
                return this;
            }

            public ModUserInfo.Builder MergeBindMobile(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasBindMobile && (this.result.bindMobile_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.bindMobile_ = SKBuiltinString_t.CreateBuilder(this.result.bindMobile_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.bindMobile_ = value;
                }
                this.result.hasBindMobile = true;
                return this;
            }

            public ModUserInfo.Builder MergeDisturbSetting(micromsg.DisturbSetting value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasDisturbSetting && (this.result.disturbSetting_ != micromsg.DisturbSetting.DefaultInstance))
                {
                    this.result.disturbSetting_ = micromsg.DisturbSetting.CreateBuilder(this.result.disturbSetting_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.disturbSetting_ = value;
                }
                this.result.hasDisturbSetting = true;
                return this;
            }

            public override ModUserInfo.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override ModUserInfo.Builder MergeFrom(IMessageLite other)
            {
                if (other is ModUserInfo)
                {
                    return this.MergeFrom((ModUserInfo) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override ModUserInfo.Builder MergeFrom(ModUserInfo other)
            {
                return this;
            }

            public override ModUserInfo.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(ModUserInfo._modUserInfoFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = ModUserInfo._modUserInfoFieldTags[index];
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
                            SKBuiltinString_t.Builder builder = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasUserName)
                            {
                                builder.MergeFrom(this.UserName);
                            }
                            input.ReadMessage(builder, extensionRegistry);
                            this.UserName = builder.BuildPartial();
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
                        case 0x20:
                        {
                            this.result.hasBindUin = input.ReadUInt32(ref this.result.bindUin_);
                            continue;
                        }
                        case 0:
                            throw InvalidProtocolBufferException.InvalidTag();

                        case 8:
                        {
                            this.result.hasBitFlag = input.ReadUInt32(ref this.result.bitFlag_);
                            continue;
                        }
                        case 0x2a:
                        {
                            SKBuiltinString_t.Builder builder3 = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasBindEmail)
                            {
                                builder3.MergeFrom(this.BindEmail);
                            }
                            input.ReadMessage(builder3, extensionRegistry);
                            this.BindEmail = builder3.BuildPartial();
                            continue;
                        }
                        case 50:
                        {
                            SKBuiltinString_t.Builder builder4 = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasBindMobile)
                            {
                                builder4.MergeFrom(this.BindMobile);
                            }
                            input.ReadMessage(builder4, extensionRegistry);
                            this.BindMobile = builder4.BuildPartial();
                            continue;
                        }
                        case 0x38:
                        {
                            this.result.hasStatus = input.ReadUInt32(ref this.result.status_);
                            continue;
                        }
                        case 0x40:
                        {
                            this.result.hasImgLen = input.ReadUInt32(ref this.result.imgLen_);
                            continue;
                        }
                        case 0x4a:
                        {
                            this.result.hasImgBuf = input.ReadBytes(ref this.result.imgBuf_);
                            continue;
                        }
                        case 0x62:
                        {
                            this.result.hasCity = input.ReadString(ref this.result.city_);
                            continue;
                        }
                        case 0x6a:
                        {
                            this.result.hasSignature = input.ReadString(ref this.result.signature_);
                            continue;
                        }
                        case 0x70:
                        {
                            this.result.hasPersonalCard = input.ReadUInt32(ref this.result.personalCard_);
                            continue;
                        }
                        case 80:
                        {
                            this.result.hasSex = input.ReadInt32(ref this.result.sex_);
                            continue;
                        }
                        case 90:
                        {
                            this.result.hasProvince = input.ReadString(ref this.result.province_);
                            continue;
                        }
                        case 0x7a:
                        {
                            micromsg.DisturbSetting.Builder builder5 = micromsg.DisturbSetting.CreateBuilder();
                            if (this.result.hasDisturbSetting)
                            {
                                builder5.MergeFrom(this.DisturbSetting);
                            }
                            input.ReadMessage(builder5, extensionRegistry);
                            this.DisturbSetting = builder5.BuildPartial();
                            continue;
                        }
                        case 0x80:
                        {
                            this.result.hasPluginFlag = input.ReadUInt32(ref this.result.pluginFlag_);
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
                        case 0x98:
                        {
                            this.result.hasPoint = input.ReadInt32(ref this.result.point_);
                            continue;
                        }
                        case 0xb0:
                        {
                            this.result.hasLevelLowExp = input.ReadInt32(ref this.result.levelLowExp_);
                            continue;
                        }
                        case 0xb8:
                        {
                            this.result.hasLevelHighExp = input.ReadInt32(ref this.result.levelHighExp_);
                            continue;
                        }
                        case 0xc2:
                        {
                            this.result.hasWeibo = input.ReadString(ref this.result.weibo_);
                            continue;
                        }
                        case 160:
                        {
                            this.result.hasExperience = input.ReadInt32(ref this.result.experience_);
                            continue;
                        }
                        case 0xa8:
                        {
                            this.result.hasLevel = input.ReadInt32(ref this.result.level_);
                            continue;
                        }
                        case 200:
                        {
                            this.result.hasPluginSwitch = input.ReadUInt32(ref this.result.pluginSwitch_);
                            continue;
                        }
                        case 210:
                        {
                            micromsg.GmailList.Builder builder6 = micromsg.GmailList.CreateBuilder();
                            if (this.result.hasGmailList)
                            {
                                builder6.MergeFrom(this.GmailList);
                            }
                            input.ReadMessage(builder6, extensionRegistry);
                            this.GmailList = builder6.BuildPartial();
                            continue;
                        }
                        case 0xda:
                        {
                            this.result.hasAlias = input.ReadString(ref this.result.alias_);
                            continue;
                        }
                        case 0xe2:
                        {
                            this.result.hasWeiboNickname = input.ReadString(ref this.result.weiboNickname_);
                            continue;
                        }
                        case 0xe8:
                        {
                            this.result.hasWeiboFlag = input.ReadUInt32(ref this.result.weiboFlag_);
                            continue;
                        }
                        case 0x102:
                        {
                            this.result.hasFBUserName = input.ReadString(ref this.result.fBUserName_);
                            continue;
                        }
                        case 0x108:
                        {
                            this.result.hasAlbumStyle = input.ReadInt32(ref this.result.albumStyle_);
                            continue;
                        }
                        case 0x110:
                        {
                            this.result.hasAlbumFlag = input.ReadInt32(ref this.result.albumFlag_);
                            continue;
                        }
                        case 240:
                        {
                            this.result.hasFaceBookFlag = input.ReadUInt32(ref this.result.faceBookFlag_);
                            continue;
                        }
                        case 0xf8:
                        {
                            this.result.hasFBUserID = input.ReadUInt64(ref this.result.fBUserID_);
                            continue;
                        }
                        case 0x11a:
                        {
                            this.result.hasAlbumBGImgID = input.ReadString(ref this.result.albumBGImgID_);
                            continue;
                        }
                        case 0x120:
                        {
                            this.result.hasTXNewsCategory = input.ReadUInt32(ref this.result.tXNewsCategory_);
                            continue;
                        }
                        case 0x12a:
                        {
                            this.result.hasFBToken = input.ReadString(ref this.result.fBToken_);
                            continue;
                        }
                        case 0x132:
                        {
                            this.result.hasCountry = input.ReadString(ref this.result.country_);
                            continue;
                        }
                        case 0x138:
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
                    this.result.hasGrayscaleFlag = input.ReadUInt32(ref this.result.grayscaleFlag_);
                }
                return this;
            }

            public ModUserInfo.Builder MergeGmailList(micromsg.GmailList value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasGmailList && (this.result.gmailList_ != micromsg.GmailList.DefaultInstance))
                {
                    this.result.gmailList_ = micromsg.GmailList.CreateBuilder(this.result.gmailList_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.gmailList_ = value;
                }
                this.result.hasGmailList = true;
                return this;
            }

            public ModUserInfo.Builder MergeNickName(SKBuiltinString_t value)
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

            public ModUserInfo.Builder MergeUserName(SKBuiltinString_t value)
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

            private ModUserInfo PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    ModUserInfo result = this.result;
                    this.result = new ModUserInfo();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public ModUserInfo.Builder SetAlbumBGImgID(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasAlbumBGImgID = true;
                this.result.albumBGImgID_ = value;
                return this;
            }

            public ModUserInfo.Builder SetAlbumFlag(int value)
            {
                this.PrepareBuilder();
                this.result.hasAlbumFlag = true;
                this.result.albumFlag_ = value;
                return this;
            }

            public ModUserInfo.Builder SetAlbumStyle(int value)
            {
                this.PrepareBuilder();
                this.result.hasAlbumStyle = true;
                this.result.albumStyle_ = value;
                return this;
            }

            public ModUserInfo.Builder SetAlias(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasAlias = true;
                this.result.alias_ = value;
                return this;
            }

            public ModUserInfo.Builder SetBindEmail(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBindEmail = true;
                this.result.bindEmail_ = value;
                return this;
            }

            public ModUserInfo.Builder SetBindEmail(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBindEmail = true;
                this.result.bindEmail_ = builderForValue.Build();
                return this;
            }

            public ModUserInfo.Builder SetBindMobile(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBindMobile = true;
                this.result.bindMobile_ = value;
                return this;
            }

            public ModUserInfo.Builder SetBindMobile(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBindMobile = true;
                this.result.bindMobile_ = builderForValue.Build();
                return this;
            }

            public ModUserInfo.Builder SetBindUin(uint value)
            {
                this.PrepareBuilder();
                this.result.hasBindUin = true;
                this.result.bindUin_ = value;
                return this;
            }

            public ModUserInfo.Builder SetBitFlag(uint value)
            {
                this.PrepareBuilder();
                this.result.hasBitFlag = true;
                this.result.bitFlag_ = value;
                return this;
            }

            public ModUserInfo.Builder SetCity(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasCity = true;
                this.result.city_ = value;
                return this;
            }

            public ModUserInfo.Builder SetCountry(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasCountry = true;
                this.result.country_ = value;
                return this;
            }

            public ModUserInfo.Builder SetDisturbSetting(micromsg.DisturbSetting value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasDisturbSetting = true;
                this.result.disturbSetting_ = value;
                return this;
            }

            public ModUserInfo.Builder SetDisturbSetting(micromsg.DisturbSetting.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasDisturbSetting = true;
                this.result.disturbSetting_ = builderForValue.Build();
                return this;
            }

            public ModUserInfo.Builder SetExperience(int value)
            {
                this.PrepareBuilder();
                this.result.hasExperience = true;
                this.result.experience_ = value;
                return this;
            }

            public ModUserInfo.Builder SetFaceBookFlag(uint value)
            {
                this.PrepareBuilder();
                this.result.hasFaceBookFlag = true;
                this.result.faceBookFlag_ = value;
                return this;
            }

            public ModUserInfo.Builder SetFBToken(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasFBToken = true;
                this.result.fBToken_ = value;
                return this;
            }

            public ModUserInfo.Builder SetFBUserID(ulong value)
            {
                this.PrepareBuilder();
                this.result.hasFBUserID = true;
                this.result.fBUserID_ = value;
                return this;
            }

            public ModUserInfo.Builder SetFBUserName(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasFBUserName = true;
                this.result.fBUserName_ = value;
                return this;
            }

            public ModUserInfo.Builder SetGmailList(micromsg.GmailList value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasGmailList = true;
                this.result.gmailList_ = value;
                return this;
            }

            public ModUserInfo.Builder SetGmailList(micromsg.GmailList.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasGmailList = true;
                this.result.gmailList_ = builderForValue.Build();
                return this;
            }

            public ModUserInfo.Builder SetGrayscaleFlag(uint value)
            {
                this.PrepareBuilder();
                this.result.hasGrayscaleFlag = true;
                this.result.grayscaleFlag_ = value;
                return this;
            }

            public ModUserInfo.Builder SetImgBuf(ByteString value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasImgBuf = true;
                this.result.imgBuf_ = value;
                return this;
            }

            public ModUserInfo.Builder SetImgLen(uint value)
            {
                this.PrepareBuilder();
                this.result.hasImgLen = true;
                this.result.imgLen_ = value;
                return this;
            }

            public ModUserInfo.Builder SetLevel(int value)
            {
                this.PrepareBuilder();
                this.result.hasLevel = true;
                this.result.level_ = value;
                return this;
            }

            public ModUserInfo.Builder SetLevelHighExp(int value)
            {
                this.PrepareBuilder();
                this.result.hasLevelHighExp = true;
                this.result.levelHighExp_ = value;
                return this;
            }

            public ModUserInfo.Builder SetLevelLowExp(int value)
            {
                this.PrepareBuilder();
                this.result.hasLevelLowExp = true;
                this.result.levelLowExp_ = value;
                return this;
            }

            public ModUserInfo.Builder SetNickName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasNickName = true;
                this.result.nickName_ = value;
                return this;
            }

            public ModUserInfo.Builder SetNickName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasNickName = true;
                this.result.nickName_ = builderForValue.Build();
                return this;
            }

            public ModUserInfo.Builder SetPersonalCard(uint value)
            {
                this.PrepareBuilder();
                this.result.hasPersonalCard = true;
                this.result.personalCard_ = value;
                return this;
            }

            public ModUserInfo.Builder SetPluginFlag(uint value)
            {
                this.PrepareBuilder();
                this.result.hasPluginFlag = true;
                this.result.pluginFlag_ = value;
                return this;
            }

            public ModUserInfo.Builder SetPluginSwitch(uint value)
            {
                this.PrepareBuilder();
                this.result.hasPluginSwitch = true;
                this.result.pluginSwitch_ = value;
                return this;
            }

            public ModUserInfo.Builder SetPoint(int value)
            {
                this.PrepareBuilder();
                this.result.hasPoint = true;
                this.result.point_ = value;
                return this;
            }

            public ModUserInfo.Builder SetProvince(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasProvince = true;
                this.result.province_ = value;
                return this;
            }

            public ModUserInfo.Builder SetSex(int value)
            {
                this.PrepareBuilder();
                this.result.hasSex = true;
                this.result.sex_ = value;
                return this;
            }

            public ModUserInfo.Builder SetSignature(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSignature = true;
                this.result.signature_ = value;
                return this;
            }

            public ModUserInfo.Builder SetStatus(uint value)
            {
                this.PrepareBuilder();
                this.result.hasStatus = true;
                this.result.status_ = value;
                return this;
            }

            public ModUserInfo.Builder SetTXNewsCategory(uint value)
            {
                this.PrepareBuilder();
                this.result.hasTXNewsCategory = true;
                this.result.tXNewsCategory_ = value;
                return this;
            }

            public ModUserInfo.Builder SetUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasUserName = true;
                this.result.userName_ = value;
                return this;
            }

            public ModUserInfo.Builder SetUserName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasUserName = true;
                this.result.userName_ = builderForValue.Build();
                return this;
            }

            public ModUserInfo.Builder SetVerifyFlag(uint value)
            {
                this.PrepareBuilder();
                this.result.hasVerifyFlag = true;
                this.result.verifyFlag_ = value;
                return this;
            }

            public ModUserInfo.Builder SetVerifyInfo(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasVerifyInfo = true;
                this.result.verifyInfo_ = value;
                return this;
            }

            public ModUserInfo.Builder SetWeibo(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasWeibo = true;
                this.result.weibo_ = value;
                return this;
            }

            public ModUserInfo.Builder SetWeiboFlag(uint value)
            {
                this.PrepareBuilder();
                this.result.hasWeiboFlag = true;
                this.result.weiboFlag_ = value;
                return this;
            }

            public ModUserInfo.Builder SetWeiboNickname(string value)
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

            public SKBuiltinString_t BindEmail
            {
                get
                {
                    return this.result.BindEmail;
                }
                set
                {
                    this.SetBindEmail(value);
                }
            }

            public SKBuiltinString_t BindMobile
            {
                get
                {
                    return this.result.BindMobile;
                }
                set
                {
                    this.SetBindMobile(value);
                }
            }

            public uint BindUin
            {
                get
                {
                    return this.result.BindUin;
                }
                set
                {
                    this.SetBindUin(value);
                }
            }

            public uint BitFlag
            {
                get
                {
                    return this.result.BitFlag;
                }
                set
                {
                    this.SetBitFlag(value);
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

            public override ModUserInfo DefaultInstanceForType
            {
                get
                {
                    return ModUserInfo.DefaultInstance;
                }
            }

            public micromsg.DisturbSetting DisturbSetting
            {
                get
                {
                    return this.result.DisturbSetting;
                }
                set
                {
                    this.SetDisturbSetting(value);
                }
            }

            public int Experience
            {
                get
                {
                    return this.result.Experience;
                }
                set
                {
                    this.SetExperience(value);
                }
            }

            public uint FaceBookFlag
            {
                get
                {
                    return this.result.FaceBookFlag;
                }
                set
                {
                    this.SetFaceBookFlag(value);
                }
            }

            public string FBToken
            {
                get
                {
                    return this.result.FBToken;
                }
                set
                {
                    this.SetFBToken(value);
                }
            }

            public ulong FBUserID
            {
                get
                {
                    return this.result.FBUserID;
                }
                set
                {
                    this.SetFBUserID(value);
                }
            }

            public string FBUserName
            {
                get
                {
                    return this.result.FBUserName;
                }
                set
                {
                    this.SetFBUserName(value);
                }
            }

            public micromsg.GmailList GmailList
            {
                get
                {
                    return this.result.GmailList;
                }
                set
                {
                    this.SetGmailList(value);
                }
            }

            public uint GrayscaleFlag
            {
                get
                {
                    return this.result.GrayscaleFlag;
                }
                set
                {
                    this.SetGrayscaleFlag(value);
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

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            public int Level
            {
                get
                {
                    return this.result.Level;
                }
                set
                {
                    this.SetLevel(value);
                }
            }

            public int LevelHighExp
            {
                get
                {
                    return this.result.LevelHighExp;
                }
                set
                {
                    this.SetLevelHighExp(value);
                }
            }

            public int LevelLowExp
            {
                get
                {
                    return this.result.LevelLowExp;
                }
                set
                {
                    this.SetLevelLowExp(value);
                }
            }

            protected override ModUserInfo MessageBeingBuilt
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

            public uint PluginFlag
            {
                get
                {
                    return this.result.PluginFlag;
                }
                set
                {
                    this.SetPluginFlag(value);
                }
            }

            public uint PluginSwitch
            {
                get
                {
                    return this.result.PluginSwitch;
                }
                set
                {
                    this.SetPluginSwitch(value);
                }
            }

            public int Point
            {
                get
                {
                    return this.result.Point;
                }
                set
                {
                    this.SetPoint(value);
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

            public uint Status
            {
                get
                {
                    return this.result.Status;
                }
                set
                {
                    this.SetStatus(value);
                }
            }

            protected override ModUserInfo.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }

            public uint TXNewsCategory
            {
                get
                {
                    return this.result.TXNewsCategory;
                }
                set
                {
                    this.SetTXNewsCategory(value);
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


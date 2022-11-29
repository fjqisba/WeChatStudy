namespace micromsg
{
    using Google.ProtocolBuffers;
    using Google.ProtocolBuffers.Collections;

    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Runtime.CompilerServices;


    public sealed class ModContact : GeneratedMessageLite<ModContact, ModContact.Builder>
    {
        private static readonly string[] _modContactFieldNames = new string[] { 
            "AddContactScene", "AdditionalContactList", "AlbumBGImgID", "AlbumFlag", "AlbumStyle", "Alias", "BigHeadImgUrl", "BitMask", "BitVal", "CardImgUrl", "ChatRoomData", "ChatRoomNotify", "ChatRoomOwner", "ChatroomMaxCount", "ChatroomType", "ChatroomVersion", 
            "City", "ContactType", "Country", "CustomizedInfo", "DeleteFlag", "Description", "DomainList", "EncryptUserName", "ExtInfo", "HasWeiXinHdHeadImg", "HeadImgMd5", "IDCardNum", "ImgBuf", "ImgFlag", "LabelIDList", "Level", 
            "MobileFullHash", "MobileHash", "MyBrandList", "NewChatroomData", "NickName", "PYInitial", "PersonalCard", "Province", "QuanPin", "RealName", "Remark", "RemarkPYInitial", "RemarkQuanPin", "RoomInfoCount", "RoomInfoList", "Sex", 
            "Signature", "SmallHeadImgUrl", "SnsUserInfo", "Source", "UserName", "VerifyContent", "VerifyFlag", "VerifyInfo", "Weibo", "WeiboFlag", "WeiboNickname"
         };
        private static readonly uint[] _modContactFieldTags = new uint[] { 
            0x90, 0x192, 290, 280, 0x110, 0xf2, 0x13a, 0x38, 0x40, 0x1e2, 0x15a, 0x88, 250, 440, 0x1c0, 0x1a8, 
            0xa2, 0x68, 0x132, 0x152, 0x1d0, 0x1da, 130, 0x16a, 0x1b2, 0xb8, 0x162, 370, 50, 0x48, 490, 0xd0, 
            0x18a, 0x182, 330, 0x1ca, 0x12, 0x1a, 0xb0, 0x9a, 0x22, 0x17a, 0x52, 90, 0x62, 0x70, 0x7a, 40, 
            170, 0x142, 0x12a, 0xd8, 10, 0xea, 0xc0, 0xca, 0xe2, 0x108, 0x102
         };
        private uint addContactScene_;
        public const int AddContactSceneFieldNumber = 0x12;
        private AdditionalContactList additionalContactList_;
        public const int AdditionalContactListFieldNumber = 50;
        private string albumBGImgID_ = "";
        public const int AlbumBGImgIDFieldNumber = 0x24;
        private int albumFlag_;
        public const int AlbumFlagFieldNumber = 0x23;
        private int albumStyle_;
        public const int AlbumStyleFieldNumber = 0x22;
        private string alias_ = "";
        public const int AliasFieldNumber = 30;
        private string bigHeadImgUrl_ = "";
        public const int BigHeadImgUrlFieldNumber = 0x27;
        private uint bitMask_;
        public const int BitMaskFieldNumber = 7;
        private uint bitVal_;
        public const int BitValFieldNumber = 8;
        private string cardImgUrl_ = "";
        public const int CardImgUrlFieldNumber = 60;
        private string chatRoomData_ = "";
        public const int ChatRoomDataFieldNumber = 0x2b;
        private uint chatroomMaxCount_;
        public const int ChatroomMaxCountFieldNumber = 0x37;
        private uint chatRoomNotify_;
        public const int ChatRoomNotifyFieldNumber = 0x11;
        private string chatRoomOwner_ = "";
        public const int ChatRoomOwnerFieldNumber = 0x1f;
        private uint chatroomType_;
        public const int ChatroomTypeFieldNumber = 0x38;
        private uint chatroomVersion_;
        public const int ChatroomVersionFieldNumber = 0x35;
        private string city_ = "";
        public const int CityFieldNumber = 20;
        private uint contactType_;
        public const int ContactTypeFieldNumber = 13;
        private string country_ = "";
        public const int CountryFieldNumber = 0x26;
        private CustomizedInfo customizedInfo_;
        public const int CustomizedInfoFieldNumber = 0x2a;
        private static readonly ModContact defaultInstance = new ModContact().MakeReadOnly();
        private int deleteFlag_;
        public const int DeleteFlagFieldNumber = 0x3a;
        private string description_ = "";
        public const int DescriptionFieldNumber = 0x3b;
        private SKBuiltinString_t domainList_;
        public const int DomainListFieldNumber = 0x10;
        private string encryptUserName_ = "";
        public const int EncryptUserNameFieldNumber = 0x2d;
        private string extInfo_ = "";
        public const int ExtInfoFieldNumber = 0x36;
        private bool hasAddContactScene;
        private bool hasAdditionalContactList;
        private bool hasAlbumBGImgID;
        private bool hasAlbumFlag;
        private bool hasAlbumStyle;
        private bool hasAlias;
        private bool hasBigHeadImgUrl;
        private bool hasBitMask;
        private bool hasBitVal;
        private bool hasCardImgUrl;
        private bool hasChatRoomData;
        private bool hasChatroomMaxCount;
        private bool hasChatRoomNotify;
        private bool hasChatRoomOwner;
        private bool hasChatroomType;
        private bool hasChatroomVersion;
        private bool hasCity;
        private bool hasContactType;
        private bool hasCountry;
        private bool hasCustomizedInfo;
        private bool hasDeleteFlag;
        private bool hasDescription;
        private bool hasDomainList;
        private bool hasEncryptUserName;
        private bool hasExtInfo;
        private bool hasHasWeiXinHdHeadImg;
        private bool hasHeadImgMd5;
        private bool hasIDCardNum;
        private bool hasImgBuf;
        private bool hasImgFlag;
        private bool hasLabelIDList;
        private bool hasLevel;
        private bool hasMobileFullHash;
        private bool hasMobileHash;
        private bool hasMyBrandList;
        private bool hasNewChatroomData;
        private bool hasNickName;
        private bool hasPersonalCard;
        private bool hasProvince;
        private bool hasPYInitial;
        private bool hasQuanPin;
        private bool hasRealName;
        private bool hasRemark;
        private bool hasRemarkPYInitial;
        private bool hasRemarkQuanPin;
        private bool hasRoomInfoCount;
        private bool hasSex;
        private bool hasSignature;
        private bool hasSmallHeadImgUrl;
        private bool hasSnsUserInfo;
        private bool hasSource;
        private bool hasUserName;
        private bool hasVerifyContent;
        private bool hasVerifyFlag;
        private bool hasVerifyInfo;
        private bool hasWeibo;
        private bool hasWeiboFlag;
        private bool hasWeiboNickname;
        private uint hasWeiXinHdHeadImg_;
        public const int HasWeiXinHdHeadImgFieldNumber = 0x17;
        private string headImgMd5_ = "";
        public const int HeadImgMd5FieldNumber = 0x2c;
        private string iDCardNum_ = "";
        public const int IDCardNumFieldNumber = 0x2e;
        private SKBuiltinBuffer_t imgBuf_;
        public const int ImgBufFieldNumber = 6;
        private uint imgFlag_;
        public const int ImgFlagFieldNumber = 9;
        private string labelIDList_ = "";
        public const int LabelIDListFieldNumber = 0x3d;
        private int level_;
        public const int LevelFieldNumber = 0x1a;
        private int memoizedSerializedSize = -1;
        private string mobileFullHash_ = "";
        public const int MobileFullHashFieldNumber = 0x31;
        private string mobileHash_ = "";
        public const int MobileHashFieldNumber = 0x30;
        private string myBrandList_ = "";
        public const int MyBrandListFieldNumber = 0x29;
        private ChatRoomMemberData newChatroomData_;
        public const int NewChatroomDataFieldNumber = 0x39;
        private SKBuiltinString_t nickName_;
        public const int NickNameFieldNumber = 2;
        private uint personalCard_;
        public const int PersonalCardFieldNumber = 0x16;
        private string province_ = "";
        public const int ProvinceFieldNumber = 0x13;
        private SKBuiltinString_t pYInitial_;
        public const int PYInitialFieldNumber = 3;
        private SKBuiltinString_t quanPin_;
        public const int QuanPinFieldNumber = 4;
        private string realName_ = "";
        public const int RealNameFieldNumber = 0x2f;
        private SKBuiltinString_t remark_;
        public const int RemarkFieldNumber = 10;
        private SKBuiltinString_t remarkPYInitial_;
        public const int RemarkPYInitialFieldNumber = 11;
        private SKBuiltinString_t remarkQuanPin_;
        public const int RemarkQuanPinFieldNumber = 12;
        private uint roomInfoCount_;
        public const int RoomInfoCountFieldNumber = 14;
        private PopsicleList<RoomInfo> roomInfoList_ = new PopsicleList<RoomInfo>();
        public const int RoomInfoListFieldNumber = 15;
        private int sex_;
        public const int SexFieldNumber = 5;
        private string signature_ = "";
        public const int SignatureFieldNumber = 0x15;
        private string smallHeadImgUrl_ = "";
        public const int SmallHeadImgUrlFieldNumber = 40;
        private SnsUserInfo snsUserInfo_;
        public const int SnsUserInfoFieldNumber = 0x25;
        private uint source_;
        public const int SourceFieldNumber = 0x1b;
        private SKBuiltinString_t userName_;
        public const int UserNameFieldNumber = 1;
        private string verifyContent_ = "";
        public const int VerifyContentFieldNumber = 0x1d;
        private uint verifyFlag_;
        public const int VerifyFlagFieldNumber = 0x18;
        private string verifyInfo_ = "";
        public const int VerifyInfoFieldNumber = 0x19;
        private string weibo_ = "";
        public const int WeiboFieldNumber = 0x1c;
        private uint weiboFlag_;
        public const int WeiboFlagFieldNumber = 0x21;
        private string weiboNickname_ = "";
        public const int WeiboNicknameFieldNumber = 0x20;

        static ModContact()
        {

        }

        private ModContact()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(ModContact prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            ModContact contact = obj as ModContact;
            if (contact == null)
            {
                return false;
            }
            if ((this.hasUserName != contact.hasUserName) || (this.hasUserName && !this.userName_.Equals(contact.userName_)))
            {
                return false;
            }
            if ((this.hasNickName != contact.hasNickName) || (this.hasNickName && !this.nickName_.Equals(contact.nickName_)))
            {
                return false;
            }
            if ((this.hasPYInitial != contact.hasPYInitial) || (this.hasPYInitial && !this.pYInitial_.Equals(contact.pYInitial_)))
            {
                return false;
            }
            if ((this.hasQuanPin != contact.hasQuanPin) || (this.hasQuanPin && !this.quanPin_.Equals(contact.quanPin_)))
            {
                return false;
            }
            if ((this.hasSex != contact.hasSex) || (this.hasSex && !this.sex_.Equals(contact.sex_)))
            {
                return false;
            }
            if ((this.hasImgBuf != contact.hasImgBuf) || (this.hasImgBuf && !this.imgBuf_.Equals(contact.imgBuf_)))
            {
                return false;
            }
            if ((this.hasBitMask != contact.hasBitMask) || (this.hasBitMask && !this.bitMask_.Equals(contact.bitMask_)))
            {
                return false;
            }
            if ((this.hasBitVal != contact.hasBitVal) || (this.hasBitVal && !this.bitVal_.Equals(contact.bitVal_)))
            {
                return false;
            }
            if ((this.hasImgFlag != contact.hasImgFlag) || (this.hasImgFlag && !this.imgFlag_.Equals(contact.imgFlag_)))
            {
                return false;
            }
            if ((this.hasRemark != contact.hasRemark) || (this.hasRemark && !this.remark_.Equals(contact.remark_)))
            {
                return false;
            }
            if ((this.hasRemarkPYInitial != contact.hasRemarkPYInitial) || (this.hasRemarkPYInitial && !this.remarkPYInitial_.Equals(contact.remarkPYInitial_)))
            {
                return false;
            }
            if ((this.hasRemarkQuanPin != contact.hasRemarkQuanPin) || (this.hasRemarkQuanPin && !this.remarkQuanPin_.Equals(contact.remarkQuanPin_)))
            {
                return false;
            }
            if ((this.hasContactType != contact.hasContactType) || (this.hasContactType && !this.contactType_.Equals(contact.contactType_)))
            {
                return false;
            }
            if ((this.hasRoomInfoCount != contact.hasRoomInfoCount) || (this.hasRoomInfoCount && !this.roomInfoCount_.Equals(contact.roomInfoCount_)))
            {
                return false;
            }
            if (this.roomInfoList_.Count != contact.roomInfoList_.Count)
            {
                return false;
            }
            for (int i = 0; i < this.roomInfoList_.Count; i++)
            {
                if (!this.roomInfoList_[i].Equals(contact.roomInfoList_[i]))
                {
                    return false;
                }
            }
            if ((this.hasDomainList != contact.hasDomainList) || (this.hasDomainList && !this.domainList_.Equals(contact.domainList_)))
            {
                return false;
            }
            if ((this.hasChatRoomNotify != contact.hasChatRoomNotify) || (this.hasChatRoomNotify && !this.chatRoomNotify_.Equals(contact.chatRoomNotify_)))
            {
                return false;
            }
            if ((this.hasAddContactScene != contact.hasAddContactScene) || (this.hasAddContactScene && !this.addContactScene_.Equals(contact.addContactScene_)))
            {
                return false;
            }
            if ((this.hasProvince != contact.hasProvince) || (this.hasProvince && !this.province_.Equals(contact.province_)))
            {
                return false;
            }
            if ((this.hasCity != contact.hasCity) || (this.hasCity && !this.city_.Equals(contact.city_)))
            {
                return false;
            }
            if ((this.hasSignature != contact.hasSignature) || (this.hasSignature && !this.signature_.Equals(contact.signature_)))
            {
                return false;
            }
            if ((this.hasPersonalCard != contact.hasPersonalCard) || (this.hasPersonalCard && !this.personalCard_.Equals(contact.personalCard_)))
            {
                return false;
            }
            if ((this.hasHasWeiXinHdHeadImg != contact.hasHasWeiXinHdHeadImg) || (this.hasHasWeiXinHdHeadImg && !this.hasWeiXinHdHeadImg_.Equals(contact.hasWeiXinHdHeadImg_)))
            {
                return false;
            }
            if ((this.hasVerifyFlag != contact.hasVerifyFlag) || (this.hasVerifyFlag && !this.verifyFlag_.Equals(contact.verifyFlag_)))
            {
                return false;
            }
            if ((this.hasVerifyInfo != contact.hasVerifyInfo) || (this.hasVerifyInfo && !this.verifyInfo_.Equals(contact.verifyInfo_)))
            {
                return false;
            }
            if ((this.hasLevel != contact.hasLevel) || (this.hasLevel && !this.level_.Equals(contact.level_)))
            {
                return false;
            }
            if ((this.hasSource != contact.hasSource) || (this.hasSource && !this.source_.Equals(contact.source_)))
            {
                return false;
            }
            if ((this.hasWeibo != contact.hasWeibo) || (this.hasWeibo && !this.weibo_.Equals(contact.weibo_)))
            {
                return false;
            }
            if ((this.hasVerifyContent != contact.hasVerifyContent) || (this.hasVerifyContent && !this.verifyContent_.Equals(contact.verifyContent_)))
            {
                return false;
            }
            if ((this.hasAlias != contact.hasAlias) || (this.hasAlias && !this.alias_.Equals(contact.alias_)))
            {
                return false;
            }
            if ((this.hasChatRoomOwner != contact.hasChatRoomOwner) || (this.hasChatRoomOwner && !this.chatRoomOwner_.Equals(contact.chatRoomOwner_)))
            {
                return false;
            }
            if ((this.hasWeiboNickname != contact.hasWeiboNickname) || (this.hasWeiboNickname && !this.weiboNickname_.Equals(contact.weiboNickname_)))
            {
                return false;
            }
            if ((this.hasWeiboFlag != contact.hasWeiboFlag) || (this.hasWeiboFlag && !this.weiboFlag_.Equals(contact.weiboFlag_)))
            {
                return false;
            }
            if ((this.hasAlbumStyle != contact.hasAlbumStyle) || (this.hasAlbumStyle && !this.albumStyle_.Equals(contact.albumStyle_)))
            {
                return false;
            }
            if ((this.hasAlbumFlag != contact.hasAlbumFlag) || (this.hasAlbumFlag && !this.albumFlag_.Equals(contact.albumFlag_)))
            {
                return false;
            }
            if ((this.hasAlbumBGImgID != contact.hasAlbumBGImgID) || (this.hasAlbumBGImgID && !this.albumBGImgID_.Equals(contact.albumBGImgID_)))
            {
                return false;
            }
            if ((this.hasSnsUserInfo != contact.hasSnsUserInfo) || (this.hasSnsUserInfo && !this.snsUserInfo_.Equals(contact.snsUserInfo_)))
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
            if ((this.hasSmallHeadImgUrl != contact.hasSmallHeadImgUrl) || (this.hasSmallHeadImgUrl && !this.smallHeadImgUrl_.Equals(contact.smallHeadImgUrl_)))
            {
                return false;
            }
            if ((this.hasMyBrandList != contact.hasMyBrandList) || (this.hasMyBrandList && !this.myBrandList_.Equals(contact.myBrandList_)))
            {
                return false;
            }
            if ((this.hasCustomizedInfo != contact.hasCustomizedInfo) || (this.hasCustomizedInfo && !this.customizedInfo_.Equals(contact.customizedInfo_)))
            {
                return false;
            }
            if ((this.hasChatRoomData != contact.hasChatRoomData) || (this.hasChatRoomData && !this.chatRoomData_.Equals(contact.chatRoomData_)))
            {
                return false;
            }
            if ((this.hasHeadImgMd5 != contact.hasHeadImgMd5) || (this.hasHeadImgMd5 && !this.headImgMd5_.Equals(contact.headImgMd5_)))
            {
                return false;
            }
            if ((this.hasEncryptUserName != contact.hasEncryptUserName) || (this.hasEncryptUserName && !this.encryptUserName_.Equals(contact.encryptUserName_)))
            {
                return false;
            }
            if ((this.hasIDCardNum != contact.hasIDCardNum) || (this.hasIDCardNum && !this.iDCardNum_.Equals(contact.iDCardNum_)))
            {
                return false;
            }
            if ((this.hasRealName != contact.hasRealName) || (this.hasRealName && !this.realName_.Equals(contact.realName_)))
            {
                return false;
            }
            if ((this.hasMobileHash != contact.hasMobileHash) || (this.hasMobileHash && !this.mobileHash_.Equals(contact.mobileHash_)))
            {
                return false;
            }
            if ((this.hasMobileFullHash != contact.hasMobileFullHash) || (this.hasMobileFullHash && !this.mobileFullHash_.Equals(contact.mobileFullHash_)))
            {
                return false;
            }
            if ((this.hasAdditionalContactList != contact.hasAdditionalContactList) || (this.hasAdditionalContactList && !this.additionalContactList_.Equals(contact.additionalContactList_)))
            {
                return false;
            }
            if ((this.hasChatroomVersion != contact.hasChatroomVersion) || (this.hasChatroomVersion && !this.chatroomVersion_.Equals(contact.chatroomVersion_)))
            {
                return false;
            }
            if ((this.hasExtInfo != contact.hasExtInfo) || (this.hasExtInfo && !this.extInfo_.Equals(contact.extInfo_)))
            {
                return false;
            }
            if ((this.hasChatroomMaxCount != contact.hasChatroomMaxCount) || (this.hasChatroomMaxCount && !this.chatroomMaxCount_.Equals(contact.chatroomMaxCount_)))
            {
                return false;
            }
            if ((this.hasChatroomType != contact.hasChatroomType) || (this.hasChatroomType && !this.chatroomType_.Equals(contact.chatroomType_)))
            {
                return false;
            }
            if ((this.hasNewChatroomData != contact.hasNewChatroomData) || (this.hasNewChatroomData && !this.newChatroomData_.Equals(contact.newChatroomData_)))
            {
                return false;
            }
            if ((this.hasDeleteFlag != contact.hasDeleteFlag) || (this.hasDeleteFlag && !this.deleteFlag_.Equals(contact.deleteFlag_)))
            {
                return false;
            }
            if ((this.hasDescription != contact.hasDescription) || (this.hasDescription && !this.description_.Equals(contact.description_)))
            {
                return false;
            }
            if ((this.hasCardImgUrl != contact.hasCardImgUrl) || (this.hasCardImgUrl && !this.cardImgUrl_.Equals(contact.cardImgUrl_)))
            {
                return false;
            }
            return ((this.hasLabelIDList == contact.hasLabelIDList) && (!this.hasLabelIDList || this.labelIDList_.Equals(contact.labelIDList_)));
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
            if (this.hasBitMask)
            {
                hashCode ^= this.bitMask_.GetHashCode();
            }
            if (this.hasBitVal)
            {
                hashCode ^= this.bitVal_.GetHashCode();
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
            if (this.hasRoomInfoCount)
            {
                hashCode ^= this.roomInfoCount_.GetHashCode();
            }
            foreach (RoomInfo info in this.roomInfoList_)
            {
                hashCode ^= info.GetHashCode();
            }
            if (this.hasDomainList)
            {
                hashCode ^= this.domainList_.GetHashCode();
            }
            if (this.hasChatRoomNotify)
            {
                hashCode ^= this.chatRoomNotify_.GetHashCode();
            }
            if (this.hasAddContactScene)
            {
                hashCode ^= this.addContactScene_.GetHashCode();
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
            if (this.hasHasWeiXinHdHeadImg)
            {
                hashCode ^= this.hasWeiXinHdHeadImg_.GetHashCode();
            }
            if (this.hasVerifyFlag)
            {
                hashCode ^= this.verifyFlag_.GetHashCode();
            }
            if (this.hasVerifyInfo)
            {
                hashCode ^= this.verifyInfo_.GetHashCode();
            }
            if (this.hasLevel)
            {
                hashCode ^= this.level_.GetHashCode();
            }
            if (this.hasSource)
            {
                hashCode ^= this.source_.GetHashCode();
            }
            if (this.hasWeibo)
            {
                hashCode ^= this.weibo_.GetHashCode();
            }
            if (this.hasVerifyContent)
            {
                hashCode ^= this.verifyContent_.GetHashCode();
            }
            if (this.hasAlias)
            {
                hashCode ^= this.alias_.GetHashCode();
            }
            if (this.hasChatRoomOwner)
            {
                hashCode ^= this.chatRoomOwner_.GetHashCode();
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
            if (this.hasChatRoomData)
            {
                hashCode ^= this.chatRoomData_.GetHashCode();
            }
            if (this.hasHeadImgMd5)
            {
                hashCode ^= this.headImgMd5_.GetHashCode();
            }
            if (this.hasEncryptUserName)
            {
                hashCode ^= this.encryptUserName_.GetHashCode();
            }
            if (this.hasIDCardNum)
            {
                hashCode ^= this.iDCardNum_.GetHashCode();
            }
            if (this.hasRealName)
            {
                hashCode ^= this.realName_.GetHashCode();
            }
            if (this.hasMobileHash)
            {
                hashCode ^= this.mobileHash_.GetHashCode();
            }
            if (this.hasMobileFullHash)
            {
                hashCode ^= this.mobileFullHash_.GetHashCode();
            }
            if (this.hasAdditionalContactList)
            {
                hashCode ^= this.additionalContactList_.GetHashCode();
            }
            if (this.hasChatroomVersion)
            {
                hashCode ^= this.chatroomVersion_.GetHashCode();
            }
            if (this.hasExtInfo)
            {
                hashCode ^= this.extInfo_.GetHashCode();
            }
            if (this.hasChatroomMaxCount)
            {
                hashCode ^= this.chatroomMaxCount_.GetHashCode();
            }
            if (this.hasChatroomType)
            {
                hashCode ^= this.chatroomType_.GetHashCode();
            }
            if (this.hasNewChatroomData)
            {
                hashCode ^= this.newChatroomData_.GetHashCode();
            }
            if (this.hasDeleteFlag)
            {
                hashCode ^= this.deleteFlag_.GetHashCode();
            }
            if (this.hasDescription)
            {
                hashCode ^= this.description_.GetHashCode();
            }
            if (this.hasCardImgUrl)
            {
                hashCode ^= this.cardImgUrl_.GetHashCode();
            }
            if (this.hasLabelIDList)
            {
                hashCode ^= this.labelIDList_.GetHashCode();
            }
            return hashCode;
        }

        public RoomInfo GetRoomInfoList(int index)
        {
            return this.roomInfoList_[index];
        }

        private ModContact MakeReadOnly()
        {
            this.roomInfoList_.MakeReadOnly();
            return this;
        }

        public static ModContact ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<ModContact, Builder>.PrintField("UserName", this.hasUserName, this.userName_, writer);
            GeneratedMessageLite<ModContact, Builder>.PrintField("NickName", this.hasNickName, this.nickName_, writer);
            GeneratedMessageLite<ModContact, Builder>.PrintField("PYInitial", this.hasPYInitial, this.pYInitial_, writer);
            GeneratedMessageLite<ModContact, Builder>.PrintField("QuanPin", this.hasQuanPin, this.quanPin_, writer);
            GeneratedMessageLite<ModContact, Builder>.PrintField("Sex", this.hasSex, this.sex_, writer);
            GeneratedMessageLite<ModContact, Builder>.PrintField("ImgBuf", this.hasImgBuf, this.imgBuf_, writer);
            GeneratedMessageLite<ModContact, Builder>.PrintField("BitMask", this.hasBitMask, this.bitMask_, writer);
            GeneratedMessageLite<ModContact, Builder>.PrintField("BitVal", this.hasBitVal, this.bitVal_, writer);
            GeneratedMessageLite<ModContact, Builder>.PrintField("ImgFlag", this.hasImgFlag, this.imgFlag_, writer);
            GeneratedMessageLite<ModContact, Builder>.PrintField("Remark", this.hasRemark, this.remark_, writer);
            GeneratedMessageLite<ModContact, Builder>.PrintField("RemarkPYInitial", this.hasRemarkPYInitial, this.remarkPYInitial_, writer);
            GeneratedMessageLite<ModContact, Builder>.PrintField("RemarkQuanPin", this.hasRemarkQuanPin, this.remarkQuanPin_, writer);
            GeneratedMessageLite<ModContact, Builder>.PrintField("ContactType", this.hasContactType, this.contactType_, writer);
            GeneratedMessageLite<ModContact, Builder>.PrintField("RoomInfoCount", this.hasRoomInfoCount, this.roomInfoCount_, writer);
            GeneratedMessageLite<ModContact, Builder>.PrintField<RoomInfo>("RoomInfoList", this.roomInfoList_, writer);
            GeneratedMessageLite<ModContact, Builder>.PrintField("DomainList", this.hasDomainList, this.domainList_, writer);
            GeneratedMessageLite<ModContact, Builder>.PrintField("ChatRoomNotify", this.hasChatRoomNotify, this.chatRoomNotify_, writer);
            GeneratedMessageLite<ModContact, Builder>.PrintField("AddContactScene", this.hasAddContactScene, this.addContactScene_, writer);
            GeneratedMessageLite<ModContact, Builder>.PrintField("Province", this.hasProvince, this.province_, writer);
            GeneratedMessageLite<ModContact, Builder>.PrintField("City", this.hasCity, this.city_, writer);
            GeneratedMessageLite<ModContact, Builder>.PrintField("Signature", this.hasSignature, this.signature_, writer);
            GeneratedMessageLite<ModContact, Builder>.PrintField("PersonalCard", this.hasPersonalCard, this.personalCard_, writer);
            GeneratedMessageLite<ModContact, Builder>.PrintField("HasWeiXinHdHeadImg", this.hasHasWeiXinHdHeadImg, this.hasWeiXinHdHeadImg_, writer);
            GeneratedMessageLite<ModContact, Builder>.PrintField("VerifyFlag", this.hasVerifyFlag, this.verifyFlag_, writer);
            GeneratedMessageLite<ModContact, Builder>.PrintField("VerifyInfo", this.hasVerifyInfo, this.verifyInfo_, writer);
            GeneratedMessageLite<ModContact, Builder>.PrintField("Level", this.hasLevel, this.level_, writer);
            GeneratedMessageLite<ModContact, Builder>.PrintField("Source", this.hasSource, this.source_, writer);
            GeneratedMessageLite<ModContact, Builder>.PrintField("Weibo", this.hasWeibo, this.weibo_, writer);
            GeneratedMessageLite<ModContact, Builder>.PrintField("VerifyContent", this.hasVerifyContent, this.verifyContent_, writer);
            GeneratedMessageLite<ModContact, Builder>.PrintField("Alias", this.hasAlias, this.alias_, writer);
            GeneratedMessageLite<ModContact, Builder>.PrintField("ChatRoomOwner", this.hasChatRoomOwner, this.chatRoomOwner_, writer);
            GeneratedMessageLite<ModContact, Builder>.PrintField("WeiboNickname", this.hasWeiboNickname, this.weiboNickname_, writer);
            GeneratedMessageLite<ModContact, Builder>.PrintField("WeiboFlag", this.hasWeiboFlag, this.weiboFlag_, writer);
            GeneratedMessageLite<ModContact, Builder>.PrintField("AlbumStyle", this.hasAlbumStyle, this.albumStyle_, writer);
            GeneratedMessageLite<ModContact, Builder>.PrintField("AlbumFlag", this.hasAlbumFlag, this.albumFlag_, writer);
            GeneratedMessageLite<ModContact, Builder>.PrintField("AlbumBGImgID", this.hasAlbumBGImgID, this.albumBGImgID_, writer);
            GeneratedMessageLite<ModContact, Builder>.PrintField("SnsUserInfo", this.hasSnsUserInfo, this.snsUserInfo_, writer);
            GeneratedMessageLite<ModContact, Builder>.PrintField("Country", this.hasCountry, this.country_, writer);
            GeneratedMessageLite<ModContact, Builder>.PrintField("BigHeadImgUrl", this.hasBigHeadImgUrl, this.bigHeadImgUrl_, writer);
            GeneratedMessageLite<ModContact, Builder>.PrintField("SmallHeadImgUrl", this.hasSmallHeadImgUrl, this.smallHeadImgUrl_, writer);
            GeneratedMessageLite<ModContact, Builder>.PrintField("MyBrandList", this.hasMyBrandList, this.myBrandList_, writer);
            GeneratedMessageLite<ModContact, Builder>.PrintField("CustomizedInfo", this.hasCustomizedInfo, this.customizedInfo_, writer);
            GeneratedMessageLite<ModContact, Builder>.PrintField("ChatRoomData", this.hasChatRoomData, this.chatRoomData_, writer);
            GeneratedMessageLite<ModContact, Builder>.PrintField("HeadImgMd5", this.hasHeadImgMd5, this.headImgMd5_, writer);
            GeneratedMessageLite<ModContact, Builder>.PrintField("EncryptUserName", this.hasEncryptUserName, this.encryptUserName_, writer);
            GeneratedMessageLite<ModContact, Builder>.PrintField("IDCardNum", this.hasIDCardNum, this.iDCardNum_, writer);
            GeneratedMessageLite<ModContact, Builder>.PrintField("RealName", this.hasRealName, this.realName_, writer);
            GeneratedMessageLite<ModContact, Builder>.PrintField("MobileHash", this.hasMobileHash, this.mobileHash_, writer);
            GeneratedMessageLite<ModContact, Builder>.PrintField("MobileFullHash", this.hasMobileFullHash, this.mobileFullHash_, writer);
            GeneratedMessageLite<ModContact, Builder>.PrintField("AdditionalContactList", this.hasAdditionalContactList, this.additionalContactList_, writer);
            GeneratedMessageLite<ModContact, Builder>.PrintField("ChatroomVersion", this.hasChatroomVersion, this.chatroomVersion_, writer);
            GeneratedMessageLite<ModContact, Builder>.PrintField("ExtInfo", this.hasExtInfo, this.extInfo_, writer);
            GeneratedMessageLite<ModContact, Builder>.PrintField("ChatroomMaxCount", this.hasChatroomMaxCount, this.chatroomMaxCount_, writer);
            GeneratedMessageLite<ModContact, Builder>.PrintField("ChatroomType", this.hasChatroomType, this.chatroomType_, writer);
            GeneratedMessageLite<ModContact, Builder>.PrintField("NewChatroomData", this.hasNewChatroomData, this.newChatroomData_, writer);
            GeneratedMessageLite<ModContact, Builder>.PrintField("DeleteFlag", this.hasDeleteFlag, this.deleteFlag_, writer);
            GeneratedMessageLite<ModContact, Builder>.PrintField("Description", this.hasDescription, this.description_, writer);
            GeneratedMessageLite<ModContact, Builder>.PrintField("CardImgUrl", this.hasCardImgUrl, this.cardImgUrl_, writer);
            GeneratedMessageLite<ModContact, Builder>.PrintField("LabelIDList", this.hasLabelIDList, this.labelIDList_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _modContactFieldNames;
            if (this.hasUserName)
            {
                output.WriteMessage(1, strArray[0x34], this.UserName);
            }
            if (this.hasNickName)
            {
                output.WriteMessage(2, strArray[0x24], this.NickName);
            }
            if (this.hasPYInitial)
            {
                output.WriteMessage(3, strArray[0x25], this.PYInitial);
            }
            if (this.hasQuanPin)
            {
                output.WriteMessage(4, strArray[40], this.QuanPin);
            }
            if (this.hasSex)
            {
                output.WriteInt32(5, strArray[0x2f], this.Sex);
            }
            if (this.hasImgBuf)
            {
                output.WriteMessage(6, strArray[0x1c], this.ImgBuf);
            }
            if (this.hasBitMask)
            {
                output.WriteUInt32(7, strArray[7], this.BitMask);
            }
            if (this.hasBitVal)
            {
                output.WriteUInt32(8, strArray[8], this.BitVal);
            }
            if (this.hasImgFlag)
            {
                output.WriteUInt32(9, strArray[0x1d], this.ImgFlag);
            }
            if (this.hasRemark)
            {
                output.WriteMessage(10, strArray[0x2a], this.Remark);
            }
            if (this.hasRemarkPYInitial)
            {
                output.WriteMessage(11, strArray[0x2b], this.RemarkPYInitial);
            }
            if (this.hasRemarkQuanPin)
            {
                output.WriteMessage(12, strArray[0x2c], this.RemarkQuanPin);
            }
            if (this.hasContactType)
            {
                output.WriteUInt32(13, strArray[0x11], this.ContactType);
            }
            if (this.hasRoomInfoCount)
            {
                output.WriteUInt32(14, strArray[0x2d], this.RoomInfoCount);
            }
            if (this.roomInfoList_.Count > 0)
            {
                output.WriteMessageArray<RoomInfo>(15, strArray[0x2e], this.roomInfoList_);
            }
            if (this.hasDomainList)
            {
                output.WriteMessage(0x10, strArray[0x16], this.DomainList);
            }
            if (this.hasChatRoomNotify)
            {
                output.WriteUInt32(0x11, strArray[11], this.ChatRoomNotify);
            }
            if (this.hasAddContactScene)
            {
                output.WriteUInt32(0x12, strArray[0], this.AddContactScene);
            }
            if (this.hasProvince)
            {
                output.WriteString(0x13, strArray[0x27], this.Province);
            }
            if (this.hasCity)
            {
                output.WriteString(20, strArray[0x10], this.City);
            }
            if (this.hasSignature)
            {
                output.WriteString(0x15, strArray[0x30], this.Signature);
            }
            if (this.hasPersonalCard)
            {
                output.WriteUInt32(0x16, strArray[0x26], this.PersonalCard);
            }
            if (this.hasHasWeiXinHdHeadImg)
            {
                output.WriteUInt32(0x17, strArray[0x19], this.HasWeiXinHdHeadImg);
            }
            if (this.hasVerifyFlag)
            {
                output.WriteUInt32(0x18, strArray[0x36], this.VerifyFlag);
            }
            if (this.hasVerifyInfo)
            {
                output.WriteString(0x19, strArray[0x37], this.VerifyInfo);
            }
            if (this.hasLevel)
            {
                output.WriteInt32(0x1a, strArray[0x1f], this.Level);
            }
            if (this.hasSource)
            {
                output.WriteUInt32(0x1b, strArray[0x33], this.Source);
            }
            if (this.hasWeibo)
            {
                output.WriteString(0x1c, strArray[0x38], this.Weibo);
            }
            if (this.hasVerifyContent)
            {
                output.WriteString(0x1d, strArray[0x35], this.VerifyContent);
            }
            if (this.hasAlias)
            {
                output.WriteString(30, strArray[5], this.Alias);
            }
            if (this.hasChatRoomOwner)
            {
                output.WriteString(0x1f, strArray[12], this.ChatRoomOwner);
            }
            if (this.hasWeiboNickname)
            {
                output.WriteString(0x20, strArray[0x3a], this.WeiboNickname);
            }
            if (this.hasWeiboFlag)
            {
                output.WriteUInt32(0x21, strArray[0x39], this.WeiboFlag);
            }
            if (this.hasAlbumStyle)
            {
                output.WriteInt32(0x22, strArray[4], this.AlbumStyle);
            }
            if (this.hasAlbumFlag)
            {
                output.WriteInt32(0x23, strArray[3], this.AlbumFlag);
            }
            if (this.hasAlbumBGImgID)
            {
                output.WriteString(0x24, strArray[2], this.AlbumBGImgID);
            }
            if (this.hasSnsUserInfo)
            {
                output.WriteMessage(0x25, strArray[50], this.SnsUserInfo);
            }
            if (this.hasCountry)
            {
                output.WriteString(0x26, strArray[0x12], this.Country);
            }
            if (this.hasBigHeadImgUrl)
            {
                output.WriteString(0x27, strArray[6], this.BigHeadImgUrl);
            }
            if (this.hasSmallHeadImgUrl)
            {
                output.WriteString(40, strArray[0x31], this.SmallHeadImgUrl);
            }
            if (this.hasMyBrandList)
            {
                output.WriteString(0x29, strArray[0x22], this.MyBrandList);
            }
            if (this.hasCustomizedInfo)
            {
                output.WriteMessage(0x2a, strArray[0x13], this.CustomizedInfo);
            }
            if (this.hasChatRoomData)
            {
                output.WriteString(0x2b, strArray[10], this.ChatRoomData);
            }
            if (this.hasHeadImgMd5)
            {
                output.WriteString(0x2c, strArray[0x1a], this.HeadImgMd5);
            }
            if (this.hasEncryptUserName)
            {
                output.WriteString(0x2d, strArray[0x17], this.EncryptUserName);
            }
            if (this.hasIDCardNum)
            {
                output.WriteString(0x2e, strArray[0x1b], this.IDCardNum);
            }
            if (this.hasRealName)
            {
                output.WriteString(0x2f, strArray[0x29], this.RealName);
            }
            if (this.hasMobileHash)
            {
                output.WriteString(0x30, strArray[0x21], this.MobileHash);
            }
            if (this.hasMobileFullHash)
            {
                output.WriteString(0x31, strArray[0x20], this.MobileFullHash);
            }
            if (this.hasAdditionalContactList)
            {
                output.WriteMessage(50, strArray[1], this.AdditionalContactList);
            }
            if (this.hasChatroomVersion)
            {
                output.WriteUInt32(0x35, strArray[15], this.ChatroomVersion);
            }
            if (this.hasExtInfo)
            {
                output.WriteString(0x36, strArray[0x18], this.ExtInfo);
            }
            if (this.hasChatroomMaxCount)
            {
                output.WriteUInt32(0x37, strArray[13], this.ChatroomMaxCount);
            }
            if (this.hasChatroomType)
            {
                output.WriteUInt32(0x38, strArray[14], this.ChatroomType);
            }
            if (this.hasNewChatroomData)
            {
                output.WriteMessage(0x39, strArray[0x23], this.NewChatroomData);
            }
            if (this.hasDeleteFlag)
            {
                output.WriteInt32(0x3a, strArray[20], this.DeleteFlag);
            }
            if (this.hasDescription)
            {
                output.WriteString(0x3b, strArray[0x15], this.Description);
            }
            if (this.hasCardImgUrl)
            {
                output.WriteString(60, strArray[9], this.CardImgUrl);
            }
            if (this.hasLabelIDList)
            {
                output.WriteString(0x3d, strArray[30], this.LabelIDList);
            }
        }

        public uint AddContactScene
        {
            get
            {
                return this.addContactScene_;
            }
        }

        public AdditionalContactList AdditionalContactList
        {
            get
            {
                return (this.additionalContactList_ ?? AdditionalContactList.DefaultInstance);
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

        public uint BitMask
        {
            get
            {
                return this.bitMask_;
            }
        }

        public uint BitVal
        {
            get
            {
                return this.bitVal_;
            }
        }

        public string CardImgUrl
        {
            get
            {
                return this.cardImgUrl_;
            }
        }

        public string ChatRoomData
        {
            get
            {
                return this.chatRoomData_;
            }
        }

        public uint ChatroomMaxCount
        {
            get
            {
                return this.chatroomMaxCount_;
            }
        }

        public uint ChatRoomNotify
        {
            get
            {
                return this.chatRoomNotify_;
            }
        }

        public string ChatRoomOwner
        {
            get
            {
                return this.chatRoomOwner_;
            }
        }

        public uint ChatroomType
        {
            get
            {
                return this.chatroomType_;
            }
        }

        public uint ChatroomVersion
        {
            get
            {
                return this.chatroomVersion_;
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

        public CustomizedInfo CustomizedInfo
        {
            get
            {
                return (this.customizedInfo_ ?? CustomizedInfo.DefaultInstance);
            }
        }

        public static ModContact DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override ModContact DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public int DeleteFlag
        {
            get
            {
                return this.deleteFlag_;
            }
        }

        public string Description
        {
            get
            {
                return this.description_;
            }
        }

        public SKBuiltinString_t DomainList
        {
            get
            {
                return (this.domainList_ ?? SKBuiltinString_t.DefaultInstance);
            }
        }

        public string EncryptUserName
        {
            get
            {
                return this.encryptUserName_;
            }
        }

        public string ExtInfo
        {
            get
            {
                return this.extInfo_;
            }
        }

        public uint HasWeiXinHdHeadImg
        {
            get
            {
                return this.hasWeiXinHdHeadImg_;
            }
        }

        public string HeadImgMd5
        {
            get
            {
                return this.headImgMd5_;
            }
        }

        public string IDCardNum
        {
            get
            {
                return this.iDCardNum_;
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
                if (!this.hasBitMask)
                {
                    return false;
                }
                if (!this.hasBitVal)
                {
                    return false;
                }
                if (!this.hasImgFlag)
                {
                    return false;
                }
                if (!this.ImgBuf.IsInitialized)
                {
                    return false;
                }
                foreach (RoomInfo info in this.RoomInfoListList)
                {
                    if (!info.IsInitialized)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public string LabelIDList
        {
            get
            {
                return this.labelIDList_;
            }
        }

        public int Level
        {
            get
            {
                return this.level_;
            }
        }

        public string MobileFullHash
        {
            get
            {
                return this.mobileFullHash_;
            }
        }

        public string MobileHash
        {
            get
            {
                return this.mobileHash_;
            }
        }

        public string MyBrandList
        {
            get
            {
                return this.myBrandList_;
            }
        }

        public ChatRoomMemberData NewChatroomData
        {
            get
            {
                return (this.newChatroomData_ ?? ChatRoomMemberData.DefaultInstance);
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

        public string RealName
        {
            get
            {
                return this.realName_;
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

        public uint RoomInfoCount
        {
            get
            {
                return this.roomInfoCount_;
            }
        }

        public int RoomInfoListCount
        {
            get
            {
                return this.roomInfoList_.Count;
            }
        }

        public IList<RoomInfo> RoomInfoListList
        {
            get
            {
                return this.roomInfoList_;
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
                    if (this.hasBitMask)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(7, this.BitMask);
                    }
                    if (this.hasBitVal)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(8, this.BitVal);
                    }
                    if (this.hasImgFlag)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(9, this.ImgFlag);
                    }
                    if (this.hasRemark)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(10, this.Remark);
                    }
                    if (this.hasRemarkPYInitial)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(11, this.RemarkPYInitial);
                    }
                    if (this.hasRemarkQuanPin)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(12, this.RemarkQuanPin);
                    }
                    if (this.hasContactType)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(13, this.ContactType);
                    }
                    if (this.hasRoomInfoCount)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(14, this.RoomInfoCount);
                    }
                    foreach (RoomInfo info in this.RoomInfoListList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(15, info);
                    }
                    if (this.hasDomainList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(0x10, this.DomainList);
                    }
                    if (this.hasChatRoomNotify)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(0x11, this.ChatRoomNotify);
                    }
                    if (this.hasAddContactScene)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(0x12, this.AddContactScene);
                    }
                    if (this.hasProvince)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x13, this.Province);
                    }
                    if (this.hasCity)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(20, this.City);
                    }
                    if (this.hasSignature)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x15, this.Signature);
                    }
                    if (this.hasPersonalCard)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(0x16, this.PersonalCard);
                    }
                    if (this.hasHasWeiXinHdHeadImg)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(0x17, this.HasWeiXinHdHeadImg);
                    }
                    if (this.hasVerifyFlag)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(0x18, this.VerifyFlag);
                    }
                    if (this.hasVerifyInfo)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x19, this.VerifyInfo);
                    }
                    if (this.hasLevel)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(0x1a, this.Level);
                    }
                    if (this.hasSource)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(0x1b, this.Source);
                    }
                    if (this.hasWeibo)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x1c, this.Weibo);
                    }
                    if (this.hasVerifyContent)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x1d, this.VerifyContent);
                    }
                    if (this.hasAlias)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(30, this.Alias);
                    }
                    if (this.hasChatRoomOwner)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x1f, this.ChatRoomOwner);
                    }
                    if (this.hasWeiboNickname)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x20, this.WeiboNickname);
                    }
                    if (this.hasWeiboFlag)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(0x21, this.WeiboFlag);
                    }
                    if (this.hasAlbumStyle)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(0x22, this.AlbumStyle);
                    }
                    if (this.hasAlbumFlag)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(0x23, this.AlbumFlag);
                    }
                    if (this.hasAlbumBGImgID)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x24, this.AlbumBGImgID);
                    }
                    if (this.hasSnsUserInfo)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(0x25, this.SnsUserInfo);
                    }
                    if (this.hasCountry)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x26, this.Country);
                    }
                    if (this.hasBigHeadImgUrl)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x27, this.BigHeadImgUrl);
                    }
                    if (this.hasSmallHeadImgUrl)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(40, this.SmallHeadImgUrl);
                    }
                    if (this.hasMyBrandList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x29, this.MyBrandList);
                    }
                    if (this.hasCustomizedInfo)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(0x2a, this.CustomizedInfo);
                    }
                    if (this.hasChatRoomData)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x2b, this.ChatRoomData);
                    }
                    if (this.hasHeadImgMd5)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x2c, this.HeadImgMd5);
                    }
                    if (this.hasEncryptUserName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x2d, this.EncryptUserName);
                    }
                    if (this.hasIDCardNum)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x2e, this.IDCardNum);
                    }
                    if (this.hasRealName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x2f, this.RealName);
                    }
                    if (this.hasMobileHash)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x30, this.MobileHash);
                    }
                    if (this.hasMobileFullHash)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x31, this.MobileFullHash);
                    }
                    if (this.hasAdditionalContactList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(50, this.AdditionalContactList);
                    }
                    if (this.hasChatroomVersion)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(0x35, this.ChatroomVersion);
                    }
                    if (this.hasExtInfo)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x36, this.ExtInfo);
                    }
                    if (this.hasChatroomMaxCount)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(0x37, this.ChatroomMaxCount);
                    }
                    if (this.hasChatroomType)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(0x38, this.ChatroomType);
                    }
                    if (this.hasNewChatroomData)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(0x39, this.NewChatroomData);
                    }
                    if (this.hasDeleteFlag)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(0x3a, this.DeleteFlag);
                    }
                    if (this.hasDescription)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x3b, this.Description);
                    }
                    if (this.hasCardImgUrl)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(60, this.CardImgUrl);
                    }
                    if (this.hasLabelIDList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x3d, this.LabelIDList);
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

        public SnsUserInfo SnsUserInfo
        {
            get
            {
                return (this.snsUserInfo_ ?? SnsUserInfo.DefaultInstance);
            }
        }

        public uint Source
        {
            get
            {
                return this.source_;
            }
        }

        protected override ModContact ThisMessage
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

        [DebuggerNonUserCode, CompilerGenerated, GeneratedCode("ProtoGen", "2.3.0.277")]
        public sealed class Builder : GeneratedBuilderLite<ModContact, ModContact.Builder>
        {
            private ModContact result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = ModContact.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(ModContact cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public ModContact.Builder AddRangeRoomInfoList(IEnumerable<RoomInfo> values)
            {
                this.PrepareBuilder();
                this.result.roomInfoList_.Add(values);
                return this;
            }

            public ModContact.Builder AddRoomInfoList(RoomInfo value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.roomInfoList_.Add(value);
                return this;
            }

            public ModContact.Builder AddRoomInfoList(RoomInfo.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.roomInfoList_.Add(builderForValue.Build());
                return this;
            }

            public override ModContact BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override ModContact.Builder Clear()
            {
                this.result = ModContact.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public ModContact.Builder ClearAddContactScene()
            {
                this.PrepareBuilder();
                this.result.hasAddContactScene = false;
                this.result.addContactScene_ = 0;
                return this;
            }

            public ModContact.Builder ClearAdditionalContactList()
            {
                this.PrepareBuilder();
                this.result.hasAdditionalContactList = false;
                this.result.additionalContactList_ = null;
                return this;
            }

            public ModContact.Builder ClearAlbumBGImgID()
            {
                this.PrepareBuilder();
                this.result.hasAlbumBGImgID = false;
                this.result.albumBGImgID_ = "";
                return this;
            }

            public ModContact.Builder ClearAlbumFlag()
            {
                this.PrepareBuilder();
                this.result.hasAlbumFlag = false;
                this.result.albumFlag_ = 0;
                return this;
            }

            public ModContact.Builder ClearAlbumStyle()
            {
                this.PrepareBuilder();
                this.result.hasAlbumStyle = false;
                this.result.albumStyle_ = 0;
                return this;
            }

            public ModContact.Builder ClearAlias()
            {
                this.PrepareBuilder();
                this.result.hasAlias = false;
                this.result.alias_ = "";
                return this;
            }

            public ModContact.Builder ClearBigHeadImgUrl()
            {
                this.PrepareBuilder();
                this.result.hasBigHeadImgUrl = false;
                this.result.bigHeadImgUrl_ = "";
                return this;
            }

            public ModContact.Builder ClearBitMask()
            {
                this.PrepareBuilder();
                this.result.hasBitMask = false;
                this.result.bitMask_ = 0;
                return this;
            }

            public ModContact.Builder ClearBitVal()
            {
                this.PrepareBuilder();
                this.result.hasBitVal = false;
                this.result.bitVal_ = 0;
                return this;
            }

            public ModContact.Builder ClearCardImgUrl()
            {
                this.PrepareBuilder();
                this.result.hasCardImgUrl = false;
                this.result.cardImgUrl_ = "";
                return this;
            }

            public ModContact.Builder ClearChatRoomData()
            {
                this.PrepareBuilder();
                this.result.hasChatRoomData = false;
                this.result.chatRoomData_ = "";
                return this;
            }

            public ModContact.Builder ClearChatroomMaxCount()
            {
                this.PrepareBuilder();
                this.result.hasChatroomMaxCount = false;
                this.result.chatroomMaxCount_ = 0;
                return this;
            }

            public ModContact.Builder ClearChatRoomNotify()
            {
                this.PrepareBuilder();
                this.result.hasChatRoomNotify = false;
                this.result.chatRoomNotify_ = 0;
                return this;
            }

            public ModContact.Builder ClearChatRoomOwner()
            {
                this.PrepareBuilder();
                this.result.hasChatRoomOwner = false;
                this.result.chatRoomOwner_ = "";
                return this;
            }

            public ModContact.Builder ClearChatroomType()
            {
                this.PrepareBuilder();
                this.result.hasChatroomType = false;
                this.result.chatroomType_ = 0;
                return this;
            }

            public ModContact.Builder ClearChatroomVersion()
            {
                this.PrepareBuilder();
                this.result.hasChatroomVersion = false;
                this.result.chatroomVersion_ = 0;
                return this;
            }

            public ModContact.Builder ClearCity()
            {
                this.PrepareBuilder();
                this.result.hasCity = false;
                this.result.city_ = "";
                return this;
            }

            public ModContact.Builder ClearContactType()
            {
                this.PrepareBuilder();
                this.result.hasContactType = false;
                this.result.contactType_ = 0;
                return this;
            }

            public ModContact.Builder ClearCountry()
            {
                this.PrepareBuilder();
                this.result.hasCountry = false;
                this.result.country_ = "";
                return this;
            }

            public ModContact.Builder ClearCustomizedInfo()
            {
                this.PrepareBuilder();
                this.result.hasCustomizedInfo = false;
                this.result.customizedInfo_ = null;
                return this;
            }

            public ModContact.Builder ClearDeleteFlag()
            {
                this.PrepareBuilder();
                this.result.hasDeleteFlag = false;
                this.result.deleteFlag_ = 0;
                return this;
            }

            public ModContact.Builder ClearDescription()
            {
                this.PrepareBuilder();
                this.result.hasDescription = false;
                this.result.description_ = "";
                return this;
            }

            public ModContact.Builder ClearDomainList()
            {
                this.PrepareBuilder();
                this.result.hasDomainList = false;
                this.result.domainList_ = null;
                return this;
            }

            public ModContact.Builder ClearEncryptUserName()
            {
                this.PrepareBuilder();
                this.result.hasEncryptUserName = false;
                this.result.encryptUserName_ = "";
                return this;
            }

            public ModContact.Builder ClearExtInfo()
            {
                this.PrepareBuilder();
                this.result.hasExtInfo = false;
                this.result.extInfo_ = "";
                return this;
            }

            public ModContact.Builder ClearHasWeiXinHdHeadImg()
            {
                this.PrepareBuilder();
                this.result.hasHasWeiXinHdHeadImg = false;
                this.result.hasWeiXinHdHeadImg_ = 0;
                return this;
            }

            public ModContact.Builder ClearHeadImgMd5()
            {
                this.PrepareBuilder();
                this.result.hasHeadImgMd5 = false;
                this.result.headImgMd5_ = "";
                return this;
            }

            public ModContact.Builder ClearIDCardNum()
            {
                this.PrepareBuilder();
                this.result.hasIDCardNum = false;
                this.result.iDCardNum_ = "";
                return this;
            }

            public ModContact.Builder ClearImgBuf()
            {
                this.PrepareBuilder();
                this.result.hasImgBuf = false;
                this.result.imgBuf_ = null;
                return this;
            }

            public ModContact.Builder ClearImgFlag()
            {
                this.PrepareBuilder();
                this.result.hasImgFlag = false;
                this.result.imgFlag_ = 0;
                return this;
            }

            public ModContact.Builder ClearLabelIDList()
            {
                this.PrepareBuilder();
                this.result.hasLabelIDList = false;
                this.result.labelIDList_ = "";
                return this;
            }

            public ModContact.Builder ClearLevel()
            {
                this.PrepareBuilder();
                this.result.hasLevel = false;
                this.result.level_ = 0;
                return this;
            }

            public ModContact.Builder ClearMobileFullHash()
            {
                this.PrepareBuilder();
                this.result.hasMobileFullHash = false;
                this.result.mobileFullHash_ = "";
                return this;
            }

            public ModContact.Builder ClearMobileHash()
            {
                this.PrepareBuilder();
                this.result.hasMobileHash = false;
                this.result.mobileHash_ = "";
                return this;
            }

            public ModContact.Builder ClearMyBrandList()
            {
                this.PrepareBuilder();
                this.result.hasMyBrandList = false;
                this.result.myBrandList_ = "";
                return this;
            }

            public ModContact.Builder ClearNewChatroomData()
            {
                this.PrepareBuilder();
                this.result.hasNewChatroomData = false;
                this.result.newChatroomData_ = null;
                return this;
            }

            public ModContact.Builder ClearNickName()
            {
                this.PrepareBuilder();
                this.result.hasNickName = false;
                this.result.nickName_ = null;
                return this;
            }

            public ModContact.Builder ClearPersonalCard()
            {
                this.PrepareBuilder();
                this.result.hasPersonalCard = false;
                this.result.personalCard_ = 0;
                return this;
            }

            public ModContact.Builder ClearProvince()
            {
                this.PrepareBuilder();
                this.result.hasProvince = false;
                this.result.province_ = "";
                return this;
            }

            public ModContact.Builder ClearPYInitial()
            {
                this.PrepareBuilder();
                this.result.hasPYInitial = false;
                this.result.pYInitial_ = null;
                return this;
            }

            public ModContact.Builder ClearQuanPin()
            {
                this.PrepareBuilder();
                this.result.hasQuanPin = false;
                this.result.quanPin_ = null;
                return this;
            }

            public ModContact.Builder ClearRealName()
            {
                this.PrepareBuilder();
                this.result.hasRealName = false;
                this.result.realName_ = "";
                return this;
            }

            public ModContact.Builder ClearRemark()
            {
                this.PrepareBuilder();
                this.result.hasRemark = false;
                this.result.remark_ = null;
                return this;
            }

            public ModContact.Builder ClearRemarkPYInitial()
            {
                this.PrepareBuilder();
                this.result.hasRemarkPYInitial = false;
                this.result.remarkPYInitial_ = null;
                return this;
            }

            public ModContact.Builder ClearRemarkQuanPin()
            {
                this.PrepareBuilder();
                this.result.hasRemarkQuanPin = false;
                this.result.remarkQuanPin_ = null;
                return this;
            }

            public ModContact.Builder ClearRoomInfoCount()
            {
                this.PrepareBuilder();
                this.result.hasRoomInfoCount = false;
                this.result.roomInfoCount_ = 0;
                return this;
            }

            public ModContact.Builder ClearRoomInfoList()
            {
                this.PrepareBuilder();
                this.result.roomInfoList_.Clear();
                return this;
            }

            public ModContact.Builder ClearSex()
            {
                this.PrepareBuilder();
                this.result.hasSex = false;
                this.result.sex_ = 0;
                return this;
            }

            public ModContact.Builder ClearSignature()
            {
                this.PrepareBuilder();
                this.result.hasSignature = false;
                this.result.signature_ = "";
                return this;
            }

            public ModContact.Builder ClearSmallHeadImgUrl()
            {
                this.PrepareBuilder();
                this.result.hasSmallHeadImgUrl = false;
                this.result.smallHeadImgUrl_ = "";
                return this;
            }

            public ModContact.Builder ClearSnsUserInfo()
            {
                this.PrepareBuilder();
                this.result.hasSnsUserInfo = false;
                this.result.snsUserInfo_ = null;
                return this;
            }

            public ModContact.Builder ClearSource()
            {
                this.PrepareBuilder();
                this.result.hasSource = false;
                this.result.source_ = 0;
                return this;
            }

            public ModContact.Builder ClearUserName()
            {
                this.PrepareBuilder();
                this.result.hasUserName = false;
                this.result.userName_ = null;
                return this;
            }

            public ModContact.Builder ClearVerifyContent()
            {
                this.PrepareBuilder();
                this.result.hasVerifyContent = false;
                this.result.verifyContent_ = "";
                return this;
            }

            public ModContact.Builder ClearVerifyFlag()
            {
                this.PrepareBuilder();
                this.result.hasVerifyFlag = false;
                this.result.verifyFlag_ = 0;
                return this;
            }

            public ModContact.Builder ClearVerifyInfo()
            {
                this.PrepareBuilder();
                this.result.hasVerifyInfo = false;
                this.result.verifyInfo_ = "";
                return this;
            }

            public ModContact.Builder ClearWeibo()
            {
                this.PrepareBuilder();
                this.result.hasWeibo = false;
                this.result.weibo_ = "";
                return this;
            }

            public ModContact.Builder ClearWeiboFlag()
            {
                this.PrepareBuilder();
                this.result.hasWeiboFlag = false;
                this.result.weiboFlag_ = 0;
                return this;
            }

            public ModContact.Builder ClearWeiboNickname()
            {
                this.PrepareBuilder();
                this.result.hasWeiboNickname = false;
                this.result.weiboNickname_ = "";
                return this;
            }

            public override ModContact.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new ModContact.Builder(this.result);
                }
                return new ModContact.Builder().MergeFrom(this.result);
            }

            public RoomInfo GetRoomInfoList(int index)
            {
                return this.result.GetRoomInfoList(index);
            }

            public ModContact.Builder MergeAdditionalContactList(AdditionalContactList value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasAdditionalContactList && (this.result.additionalContactList_ != AdditionalContactList.DefaultInstance))
                {
                    this.result.additionalContactList_ = AdditionalContactList.CreateBuilder(this.result.additionalContactList_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.additionalContactList_ = value;
                }
                this.result.hasAdditionalContactList = true;
                return this;
            }

            public ModContact.Builder MergeCustomizedInfo(CustomizedInfo value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasCustomizedInfo && (this.result.customizedInfo_ != CustomizedInfo.DefaultInstance))
                {
                    this.result.customizedInfo_ = CustomizedInfo.CreateBuilder(this.result.customizedInfo_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.customizedInfo_ = value;
                }
                this.result.hasCustomizedInfo = true;
                return this;
            }

            public ModContact.Builder MergeDomainList(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasDomainList && (this.result.domainList_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.domainList_ = SKBuiltinString_t.CreateBuilder(this.result.domainList_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.domainList_ = value;
                }
                this.result.hasDomainList = true;
                return this;
            }

            public override ModContact.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override ModContact.Builder MergeFrom(IMessageLite other)
            {
                if (other is ModContact)
                {
                    return this.MergeFrom((ModContact)other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override ModContact.Builder MergeFrom(ModContact other)
            {
                return this;
            }

            public override ModContact.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(ModContact._modContactFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = ModContact._modContactFieldTags[index];
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
                        case 0x48:
                            {
                                this.result.hasImgFlag = input.ReadUInt32(ref this.result.imgFlag_);
                                continue;
                            }
                        case 0x52:
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
                        case 0x38:
                            {
                                this.result.hasBitMask = input.ReadUInt32(ref this.result.bitMask_);
                                continue;
                            }
                        case 0x40:
                            {
                                this.result.hasBitVal = input.ReadUInt32(ref this.result.bitVal_);
                                continue;
                            }
                        case 90:
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
                                SKBuiltinString_t.Builder builder8 = SKBuiltinString_t.CreateBuilder();
                                if (this.result.hasRemarkQuanPin)
                                {
                                    builder8.MergeFrom(this.RemarkQuanPin);
                                }
                                input.ReadMessage(builder8, extensionRegistry);
                                this.RemarkQuanPin = builder8.BuildPartial();
                                continue;
                            }
                        case 0x68:
                            {
                                this.result.hasContactType = input.ReadUInt32(ref this.result.contactType_);
                                continue;
                            }
                        case 0x70:
                            {
                                this.result.hasRoomInfoCount = input.ReadUInt32(ref this.result.roomInfoCount_);
                                continue;
                            }
                        case 0x7a:
                            {
                                input.ReadMessageArray<RoomInfo>(num, str, this.result.roomInfoList_, RoomInfo.DefaultInstance, extensionRegistry);
                                continue;
                            }
                        case 130:
                            {
                                SKBuiltinString_t.Builder builder9 = SKBuiltinString_t.CreateBuilder();
                                if (this.result.hasDomainList)
                                {
                                    builder9.MergeFrom(this.DomainList);
                                }
                                input.ReadMessage(builder9, extensionRegistry);
                                this.DomainList = builder9.BuildPartial();
                                continue;
                            }
                        case 0x88:
                            {
                                this.result.hasChatRoomNotify = input.ReadUInt32(ref this.result.chatRoomNotify_);
                                continue;
                            }
                        case 0xa2:
                            {
                                this.result.hasCity = input.ReadString(ref this.result.city_);
                                continue;
                            }
                        case 170:
                            {
                                this.result.hasSignature = input.ReadString(ref this.result.signature_);
                                continue;
                            }
                        case 0x90:
                            {
                                this.result.hasAddContactScene = input.ReadUInt32(ref this.result.addContactScene_);
                                continue;
                            }
                        case 0x9a:
                            {
                                this.result.hasProvince = input.ReadString(ref this.result.province_);
                                continue;
                            }
                        case 0xc0:
                            {
                                this.result.hasVerifyFlag = input.ReadUInt32(ref this.result.verifyFlag_);
                                continue;
                            }
                        case 0xca:
                            {
                                this.result.hasVerifyInfo = input.ReadString(ref this.result.verifyInfo_);
                                continue;
                            }
                        case 0xb0:
                            {
                                this.result.hasPersonalCard = input.ReadUInt32(ref this.result.personalCard_);
                                continue;
                            }
                        case 0xb8:
                            {
                                this.result.hasHasWeiXinHdHeadImg = input.ReadUInt32(ref this.result.hasWeiXinHdHeadImg_);
                                continue;
                            }
                        case 0xd0:
                            {
                                this.result.hasLevel = input.ReadInt32(ref this.result.level_);
                                continue;
                            }
                        case 0xd8:
                            {
                                this.result.hasSource = input.ReadUInt32(ref this.result.source_);
                                continue;
                            }
                        case 0xe2:
                            {
                                this.result.hasWeibo = input.ReadString(ref this.result.weibo_);
                                continue;
                            }
                        case 0xea:
                            {
                                this.result.hasVerifyContent = input.ReadString(ref this.result.verifyContent_);
                                continue;
                            }
                        case 0xf2:
                            {
                                this.result.hasAlias = input.ReadString(ref this.result.alias_);
                                continue;
                            }
                        case 250:
                            {
                                this.result.hasChatRoomOwner = input.ReadString(ref this.result.chatRoomOwner_);
                                continue;
                            }
                        case 0x102:
                            {
                                this.result.hasWeiboNickname = input.ReadString(ref this.result.weiboNickname_);
                                continue;
                            }
                        case 280:
                            {
                                this.result.hasAlbumFlag = input.ReadInt32(ref this.result.albumFlag_);
                                continue;
                            }
                        case 290:
                            {
                                this.result.hasAlbumBGImgID = input.ReadString(ref this.result.albumBGImgID_);
                                continue;
                            }
                        case 0x108:
                            {
                                this.result.hasWeiboFlag = input.ReadUInt32(ref this.result.weiboFlag_);
                                continue;
                            }
                        case 0x110:
                            {
                                this.result.hasAlbumStyle = input.ReadInt32(ref this.result.albumStyle_);
                                continue;
                            }
                        case 0x13a:
                            {
                                this.result.hasBigHeadImgUrl = input.ReadString(ref this.result.bigHeadImgUrl_);
                                continue;
                            }
                        case 0x142:
                            {
                                this.result.hasSmallHeadImgUrl = input.ReadString(ref this.result.smallHeadImgUrl_);
                                continue;
                            }
                        case 0x12a:
                            {
                                SnsUserInfo.Builder builder10 = SnsUserInfo.CreateBuilder();
                                if (this.result.hasSnsUserInfo)
                                {
                                    builder10.MergeFrom(this.SnsUserInfo);
                                }
                                input.ReadMessage(builder10, extensionRegistry);
                                this.SnsUserInfo = builder10.BuildPartial();
                                continue;
                            }
                        case 0x132:
                            {
                                this.result.hasCountry = input.ReadString(ref this.result.country_);
                                continue;
                            }
                        case 330:
                            {
                                this.result.hasMyBrandList = input.ReadString(ref this.result.myBrandList_);
                                continue;
                            }
                        case 0x152:
                            {
                                CustomizedInfo.Builder builder11 = CustomizedInfo.CreateBuilder();
                                if (this.result.hasCustomizedInfo)
                                {
                                    builder11.MergeFrom(this.CustomizedInfo);
                                }
                                input.ReadMessage(builder11, extensionRegistry);
                                this.CustomizedInfo = builder11.BuildPartial();
                                continue;
                            }
                        case 0x15a:
                            {
                                this.result.hasChatRoomData = input.ReadString(ref this.result.chatRoomData_);
                                continue;
                            }
                        case 0x162:
                            {
                                this.result.hasHeadImgMd5 = input.ReadString(ref this.result.headImgMd5_);
                                continue;
                            }
                        case 0x16a:
                            {
                                this.result.hasEncryptUserName = input.ReadString(ref this.result.encryptUserName_);
                                continue;
                            }
                        case 370:
                            {
                                this.result.hasIDCardNum = input.ReadString(ref this.result.iDCardNum_);
                                continue;
                            }
                        case 0x17a:
                            {
                                this.result.hasRealName = input.ReadString(ref this.result.realName_);
                                continue;
                            }
                        case 0x192:
                            {
                                AdditionalContactList.Builder builder12 = AdditionalContactList.CreateBuilder();
                                if (this.result.hasAdditionalContactList)
                                {
                                    builder12.MergeFrom(this.AdditionalContactList);
                                }
                                input.ReadMessage(builder12, extensionRegistry);
                                this.AdditionalContactList = builder12.BuildPartial();
                                continue;
                            }
                        case 0x1a8:
                            {
                                this.result.hasChatroomVersion = input.ReadUInt32(ref this.result.chatroomVersion_);
                                continue;
                            }
                        case 0x182:
                            {
                                this.result.hasMobileHash = input.ReadString(ref this.result.mobileHash_);
                                continue;
                            }
                        case 0x18a:
                            {
                                this.result.hasMobileFullHash = input.ReadString(ref this.result.mobileFullHash_);
                                continue;
                            }
                        case 0x1c0:
                            {
                                this.result.hasChatroomType = input.ReadUInt32(ref this.result.chatroomType_);
                                continue;
                            }
                        case 0x1ca:
                            {
                                ChatRoomMemberData.Builder builder13 = ChatRoomMemberData.CreateBuilder();
                                if (this.result.hasNewChatroomData)
                                {
                                    builder13.MergeFrom(this.NewChatroomData);
                                }
                                input.ReadMessage(builder13, extensionRegistry);
                                this.NewChatroomData = builder13.BuildPartial();
                                continue;
                            }
                        case 0x1b2:
                            {
                                this.result.hasExtInfo = input.ReadString(ref this.result.extInfo_);
                                continue;
                            }
                        case 440:
                            {
                                this.result.hasChatroomMaxCount = input.ReadUInt32(ref this.result.chatroomMaxCount_);
                                continue;
                            }
                        case 0x1d0:
                            {
                                this.result.hasDeleteFlag = input.ReadInt32(ref this.result.deleteFlag_);
                                continue;
                            }
                        case 0x1da:
                            {
                                this.result.hasDescription = input.ReadString(ref this.result.description_);
                                continue;
                            }
                        case 0x1e2:
                            {
                                this.result.hasCardImgUrl = input.ReadString(ref this.result.cardImgUrl_);
                                continue;
                            }
                        case 490:
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
                    this.result.hasLabelIDList = input.ReadString(ref this.result.labelIDList_);
                }
                return this;
            }

            public ModContact.Builder MergeImgBuf(SKBuiltinBuffer_t value)
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

            public ModContact.Builder MergeNewChatroomData(ChatRoomMemberData value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasNewChatroomData && (this.result.newChatroomData_ != ChatRoomMemberData.DefaultInstance))
                {
                    this.result.newChatroomData_ = ChatRoomMemberData.CreateBuilder(this.result.newChatroomData_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.newChatroomData_ = value;
                }
                this.result.hasNewChatroomData = true;
                return this;
            }

            public ModContact.Builder MergeNickName(SKBuiltinString_t value)
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

            public ModContact.Builder MergePYInitial(SKBuiltinString_t value)
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

            public ModContact.Builder MergeQuanPin(SKBuiltinString_t value)
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

            public ModContact.Builder MergeRemark(SKBuiltinString_t value)
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

            public ModContact.Builder MergeRemarkPYInitial(SKBuiltinString_t value)
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

            public ModContact.Builder MergeRemarkQuanPin(SKBuiltinString_t value)
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

            public ModContact.Builder MergeSnsUserInfo(SnsUserInfo value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasSnsUserInfo && (this.result.snsUserInfo_ != SnsUserInfo.DefaultInstance))
                {
                    this.result.snsUserInfo_ = SnsUserInfo.CreateBuilder(this.result.snsUserInfo_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.snsUserInfo_ = value;
                }
                this.result.hasSnsUserInfo = true;
                return this;
            }

            public ModContact.Builder MergeUserName(SKBuiltinString_t value)
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

            private ModContact PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    ModContact result = this.result;
                    this.result = new ModContact();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public ModContact.Builder SetAddContactScene(uint value)
            {
                this.PrepareBuilder();
                this.result.hasAddContactScene = true;
                this.result.addContactScene_ = value;
                return this;
            }

            public ModContact.Builder SetAdditionalContactList(AdditionalContactList value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasAdditionalContactList = true;
                this.result.additionalContactList_ = value;
                return this;
            }

            public ModContact.Builder SetAdditionalContactList(AdditionalContactList.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasAdditionalContactList = true;
                this.result.additionalContactList_ = builderForValue.Build();
                return this;
            }

            public ModContact.Builder SetAlbumBGImgID(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasAlbumBGImgID = true;
                this.result.albumBGImgID_ = value;
                return this;
            }

            public ModContact.Builder SetAlbumFlag(int value)
            {
                this.PrepareBuilder();
                this.result.hasAlbumFlag = true;
                this.result.albumFlag_ = value;
                return this;
            }

            public ModContact.Builder SetAlbumStyle(int value)
            {
                this.PrepareBuilder();
                this.result.hasAlbumStyle = true;
                this.result.albumStyle_ = value;
                return this;
            }

            public ModContact.Builder SetAlias(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasAlias = true;
                this.result.alias_ = value;
                return this;
            }

            public ModContact.Builder SetBigHeadImgUrl(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBigHeadImgUrl = true;
                this.result.bigHeadImgUrl_ = value;
                return this;
            }

            public ModContact.Builder SetBitMask(uint value)
            {
                this.PrepareBuilder();
                this.result.hasBitMask = true;
                this.result.bitMask_ = value;
                return this;
            }

            public ModContact.Builder SetBitVal(uint value)
            {
                this.PrepareBuilder();
                this.result.hasBitVal = true;
                this.result.bitVal_ = value;
                return this;
            }

            public ModContact.Builder SetCardImgUrl(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasCardImgUrl = true;
                this.result.cardImgUrl_ = value;
                return this;
            }

            public ModContact.Builder SetChatRoomData(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasChatRoomData = true;
                this.result.chatRoomData_ = value;
                return this;
            }

            public ModContact.Builder SetChatroomMaxCount(uint value)
            {
                this.PrepareBuilder();
                this.result.hasChatroomMaxCount = true;
                this.result.chatroomMaxCount_ = value;
                return this;
            }

            public ModContact.Builder SetChatRoomNotify(uint value)
            {
                this.PrepareBuilder();
                this.result.hasChatRoomNotify = true;
                this.result.chatRoomNotify_ = value;
                return this;
            }

            public ModContact.Builder SetChatRoomOwner(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasChatRoomOwner = true;
                this.result.chatRoomOwner_ = value;
                return this;
            }

            public ModContact.Builder SetChatroomType(uint value)
            {
                this.PrepareBuilder();
                this.result.hasChatroomType = true;
                this.result.chatroomType_ = value;
                return this;
            }

            public ModContact.Builder SetChatroomVersion(uint value)
            {
                this.PrepareBuilder();
                this.result.hasChatroomVersion = true;
                this.result.chatroomVersion_ = value;
                return this;
            }

            public ModContact.Builder SetCity(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasCity = true;
                this.result.city_ = value;
                return this;
            }

            public ModContact.Builder SetContactType(uint value)
            {
                this.PrepareBuilder();
                this.result.hasContactType = true;
                this.result.contactType_ = value;
                return this;
            }

            public ModContact.Builder SetCountry(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasCountry = true;
                this.result.country_ = value;
                return this;
            }

            public ModContact.Builder SetCustomizedInfo(CustomizedInfo value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasCustomizedInfo = true;
                this.result.customizedInfo_ = value;
                return this;
            }

            public ModContact.Builder SetCustomizedInfo(CustomizedInfo.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasCustomizedInfo = true;
                this.result.customizedInfo_ = builderForValue.Build();
                return this;
            }

            public ModContact.Builder SetDeleteFlag(int value)
            {
                this.PrepareBuilder();
                this.result.hasDeleteFlag = true;
                this.result.deleteFlag_ = value;
                return this;
            }

            public ModContact.Builder SetDescription(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasDescription = true;
                this.result.description_ = value;
                return this;
            }

            public ModContact.Builder SetDomainList(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasDomainList = true;
                this.result.domainList_ = value;
                return this;
            }

            public ModContact.Builder SetDomainList(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasDomainList = true;
                this.result.domainList_ = builderForValue.Build();
                return this;
            }

            public ModContact.Builder SetEncryptUserName(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasEncryptUserName = true;
                this.result.encryptUserName_ = value;
                return this;
            }

            public ModContact.Builder SetExtInfo(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasExtInfo = true;
                this.result.extInfo_ = value;
                return this;
            }

            public ModContact.Builder SetHasWeiXinHdHeadImg(uint value)
            {
                this.PrepareBuilder();
                this.result.hasHasWeiXinHdHeadImg = true;
                this.result.hasWeiXinHdHeadImg_ = value;
                return this;
            }

            public ModContact.Builder SetHeadImgMd5(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasHeadImgMd5 = true;
                this.result.headImgMd5_ = value;
                return this;
            }

            public ModContact.Builder SetIDCardNum(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasIDCardNum = true;
                this.result.iDCardNum_ = value;
                return this;
            }

            public ModContact.Builder SetImgBuf(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasImgBuf = true;
                this.result.imgBuf_ = value;
                return this;
            }

            public ModContact.Builder SetImgBuf(SKBuiltinBuffer_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasImgBuf = true;
                this.result.imgBuf_ = builderForValue.Build();
                return this;
            }

            public ModContact.Builder SetImgFlag(uint value)
            {
                this.PrepareBuilder();
                this.result.hasImgFlag = true;
                this.result.imgFlag_ = value;
                return this;
            }

            public ModContact.Builder SetLabelIDList(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasLabelIDList = true;
                this.result.labelIDList_ = value;
                return this;
            }

            public ModContact.Builder SetLevel(int value)
            {
                this.PrepareBuilder();
                this.result.hasLevel = true;
                this.result.level_ = value;
                return this;
            }

            public ModContact.Builder SetMobileFullHash(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasMobileFullHash = true;
                this.result.mobileFullHash_ = value;
                return this;
            }

            public ModContact.Builder SetMobileHash(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasMobileHash = true;
                this.result.mobileHash_ = value;
                return this;
            }

            public ModContact.Builder SetMyBrandList(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasMyBrandList = true;
                this.result.myBrandList_ = value;
                return this;
            }

            public ModContact.Builder SetNewChatroomData(ChatRoomMemberData value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasNewChatroomData = true;
                this.result.newChatroomData_ = value;
                return this;
            }

            public ModContact.Builder SetNewChatroomData(ChatRoomMemberData.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasNewChatroomData = true;
                this.result.newChatroomData_ = builderForValue.Build();
                return this;
            }

            public ModContact.Builder SetNickName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasNickName = true;
                this.result.nickName_ = value;
                return this;
            }

            public ModContact.Builder SetNickName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasNickName = true;
                this.result.nickName_ = builderForValue.Build();
                return this;
            }

            public ModContact.Builder SetPersonalCard(uint value)
            {
                this.PrepareBuilder();
                this.result.hasPersonalCard = true;
                this.result.personalCard_ = value;
                return this;
            }

            public ModContact.Builder SetProvince(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasProvince = true;
                this.result.province_ = value;
                return this;
            }

            public ModContact.Builder SetPYInitial(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasPYInitial = true;
                this.result.pYInitial_ = value;
                return this;
            }

            public ModContact.Builder SetPYInitial(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasPYInitial = true;
                this.result.pYInitial_ = builderForValue.Build();
                return this;
            }

            public ModContact.Builder SetQuanPin(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasQuanPin = true;
                this.result.quanPin_ = value;
                return this;
            }

            public ModContact.Builder SetQuanPin(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasQuanPin = true;
                this.result.quanPin_ = builderForValue.Build();
                return this;
            }

            public ModContact.Builder SetRealName(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasRealName = true;
                this.result.realName_ = value;
                return this;
            }

            public ModContact.Builder SetRemark(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasRemark = true;
                this.result.remark_ = value;
                return this;
            }

            public ModContact.Builder SetRemark(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasRemark = true;
                this.result.remark_ = builderForValue.Build();
                return this;
            }

            public ModContact.Builder SetRemarkPYInitial(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasRemarkPYInitial = true;
                this.result.remarkPYInitial_ = value;
                return this;
            }

            public ModContact.Builder SetRemarkPYInitial(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasRemarkPYInitial = true;
                this.result.remarkPYInitial_ = builderForValue.Build();
                return this;
            }

            public ModContact.Builder SetRemarkQuanPin(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasRemarkQuanPin = true;
                this.result.remarkQuanPin_ = value;
                return this;
            }

            public ModContact.Builder SetRemarkQuanPin(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasRemarkQuanPin = true;
                this.result.remarkQuanPin_ = builderForValue.Build();
                return this;
            }

            public ModContact.Builder SetRoomInfoCount(uint value)
            {
                this.PrepareBuilder();
                this.result.hasRoomInfoCount = true;
                this.result.roomInfoCount_ = value;
                return this;
            }

            public ModContact.Builder SetRoomInfoList(int index, RoomInfo value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.roomInfoList_[index] = value;
                return this;
            }

            public ModContact.Builder SetRoomInfoList(int index, RoomInfo.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.roomInfoList_[index] = builderForValue.Build();
                return this;
            }

            public ModContact.Builder SetSex(int value)
            {
                this.PrepareBuilder();
                this.result.hasSex = true;
                this.result.sex_ = value;
                return this;
            }

            public ModContact.Builder SetSignature(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSignature = true;
                this.result.signature_ = value;
                return this;
            }

            public ModContact.Builder SetSmallHeadImgUrl(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSmallHeadImgUrl = true;
                this.result.smallHeadImgUrl_ = value;
                return this;
            }

            public ModContact.Builder SetSnsUserInfo(SnsUserInfo value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSnsUserInfo = true;
                this.result.snsUserInfo_ = value;
                return this;
            }

            public ModContact.Builder SetSnsUserInfo(SnsUserInfo.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasSnsUserInfo = true;
                this.result.snsUserInfo_ = builderForValue.Build();
                return this;
            }

            public ModContact.Builder SetSource(uint value)
            {
                this.PrepareBuilder();
                this.result.hasSource = true;
                this.result.source_ = value;
                return this;
            }

            public ModContact.Builder SetUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasUserName = true;
                this.result.userName_ = value;
                return this;
            }

            public ModContact.Builder SetUserName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasUserName = true;
                this.result.userName_ = builderForValue.Build();
                return this;
            }

            public ModContact.Builder SetVerifyContent(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasVerifyContent = true;
                this.result.verifyContent_ = value;
                return this;
            }

            public ModContact.Builder SetVerifyFlag(uint value)
            {
                this.PrepareBuilder();
                this.result.hasVerifyFlag = true;
                this.result.verifyFlag_ = value;
                return this;
            }

            public ModContact.Builder SetVerifyInfo(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasVerifyInfo = true;
                this.result.verifyInfo_ = value;
                return this;
            }

            public ModContact.Builder SetWeibo(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasWeibo = true;
                this.result.weibo_ = value;
                return this;
            }

            public ModContact.Builder SetWeiboFlag(uint value)
            {
                this.PrepareBuilder();
                this.result.hasWeiboFlag = true;
                this.result.weiboFlag_ = value;
                return this;
            }

            public ModContact.Builder SetWeiboNickname(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasWeiboNickname = true;
                this.result.weiboNickname_ = value;
                return this;
            }

            public uint AddContactScene
            {
                get
                {
                    return this.result.AddContactScene;
                }
                set
                {
                    this.SetAddContactScene(value);
                }
            }

            public AdditionalContactList AdditionalContactList
            {
                get
                {
                    return this.result.AdditionalContactList;
                }
                set
                {
                    this.SetAdditionalContactList(value);
                }
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

            public uint BitMask
            {
                get
                {
                    return this.result.BitMask;
                }
                set
                {
                    this.SetBitMask(value);
                }
            }

            public uint BitVal
            {
                get
                {
                    return this.result.BitVal;
                }
                set
                {
                    this.SetBitVal(value);
                }
            }

            public string CardImgUrl
            {
                get
                {
                    return this.result.CardImgUrl;
                }
                set
                {
                    this.SetCardImgUrl(value);
                }
            }

            public string ChatRoomData
            {
                get
                {
                    return this.result.ChatRoomData;
                }
                set
                {
                    this.SetChatRoomData(value);
                }
            }

            public uint ChatroomMaxCount
            {
                get
                {
                    return this.result.ChatroomMaxCount;
                }
                set
                {
                    this.SetChatroomMaxCount(value);
                }
            }

            public uint ChatRoomNotify
            {
                get
                {
                    return this.result.ChatRoomNotify;
                }
                set
                {
                    this.SetChatRoomNotify(value);
                }
            }

            public string ChatRoomOwner
            {
                get
                {
                    return this.result.ChatRoomOwner;
                }
                set
                {
                    this.SetChatRoomOwner(value);
                }
            }

            public uint ChatroomType
            {
                get
                {
                    return this.result.ChatroomType;
                }
                set
                {
                    this.SetChatroomType(value);
                }
            }

            public uint ChatroomVersion
            {
                get
                {
                    return this.result.ChatroomVersion;
                }
                set
                {
                    this.SetChatroomVersion(value);
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

            public CustomizedInfo CustomizedInfo
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

            public override ModContact DefaultInstanceForType
            {
                get
                {
                    return ModContact.DefaultInstance;
                }
            }

            public int DeleteFlag
            {
                get
                {
                    return this.result.DeleteFlag;
                }
                set
                {
                    this.SetDeleteFlag(value);
                }
            }

            public string Description
            {
                get
                {
                    return this.result.Description;
                }
                set
                {
                    this.SetDescription(value);
                }
            }

            public SKBuiltinString_t DomainList
            {
                get
                {
                    return this.result.DomainList;
                }
                set
                {
                    this.SetDomainList(value);
                }
            }

            public string EncryptUserName
            {
                get
                {
                    return this.result.EncryptUserName;
                }
                set
                {
                    this.SetEncryptUserName(value);
                }
            }

            public string ExtInfo
            {
                get
                {
                    return this.result.ExtInfo;
                }
                set
                {
                    this.SetExtInfo(value);
                }
            }

            public uint HasWeiXinHdHeadImg
            {
                get
                {
                    return this.result.HasWeiXinHdHeadImg;
                }
                set
                {
                    this.SetHasWeiXinHdHeadImg(value);
                }
            }

            public string HeadImgMd5
            {
                get
                {
                    return this.result.HeadImgMd5;
                }
                set
                {
                    this.SetHeadImgMd5(value);
                }
            }

            public string IDCardNum
            {
                get
                {
                    return this.result.IDCardNum;
                }
                set
                {
                    this.SetIDCardNum(value);
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

            public string LabelIDList
            {
                get
                {
                    return this.result.LabelIDList;
                }
                set
                {
                    this.SetLabelIDList(value);
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

            protected override ModContact MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public string MobileFullHash
            {
                get
                {
                    return this.result.MobileFullHash;
                }
                set
                {
                    this.SetMobileFullHash(value);
                }
            }

            public string MobileHash
            {
                get
                {
                    return this.result.MobileHash;
                }
                set
                {
                    this.SetMobileHash(value);
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

            public ChatRoomMemberData NewChatroomData
            {
                get
                {
                    return this.result.NewChatroomData;
                }
                set
                {
                    this.SetNewChatroomData(value);
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

            public string RealName
            {
                get
                {
                    return this.result.RealName;
                }
                set
                {
                    this.SetRealName(value);
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

            public uint RoomInfoCount
            {
                get
                {
                    return this.result.RoomInfoCount;
                }
                set
                {
                    this.SetRoomInfoCount(value);
                }
            }

            public int RoomInfoListCount
            {
                get
                {
                    return this.result.RoomInfoListCount;
                }
            }

            public IPopsicleList<RoomInfo> RoomInfoListList
            {
                get
                {
                    return this.PrepareBuilder().roomInfoList_;
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

            public SnsUserInfo SnsUserInfo
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

            public uint Source
            {
                get
                {
                    return this.result.Source;
                }
                set
                {
                    this.SetSource(value);
                }
            }

            protected override ModContact.Builder ThisBuilder
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

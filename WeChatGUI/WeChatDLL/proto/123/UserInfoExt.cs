namespace micromsg
{
    using Google.ProtocolBuffers;
    
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

    
    public sealed class UserInfoExt : GeneratedMessageLite<UserInfoExt, UserInfoExt.Builder>
    {
        private static readonly string[] _userInfoExtFieldNames = new string[] { "BigChatRoomInvite", "BigChatRoomQuota", "BigChatRoomSize", "BigHeadImgUrl", "ExtXml", "GrayscaleFlag", "MainAcctType", "MsgPushSound", "MyBrandList", "SafeDevice", "SafeDeviceList", "SafeMobile", "SmallHeadImgUrl", "SnsUserInfo", "VoipPushSound" };
        private static readonly uint[] _userInfoExtFieldTags = new uint[] { 0x38, 0x30, 40, 0x4a, 0x62, 120, 0x58, 0x1a, 0x12, 0x70, 0x6a, 0x42, 0x52, 10, 0x22 };
        private uint bigChatRoomInvite_;
        public const int BigChatRoomInviteFieldNumber = 7;
        private uint bigChatRoomQuota_;
        public const int BigChatRoomQuotaFieldNumber = 6;
        private uint bigChatRoomSize_;
        public const int BigChatRoomSizeFieldNumber = 5;
        private string bigHeadImgUrl_ = "";
        public const int BigHeadImgUrlFieldNumber = 9;
        private static readonly UserInfoExt defaultInstance = new UserInfoExt().MakeReadOnly();
        private SKBuiltinString_t extXml_;
        public const int ExtXmlFieldNumber = 12;
        private uint grayscaleFlag_;
        public const int GrayscaleFlagFieldNumber = 15;
        private bool hasBigChatRoomInvite;
        private bool hasBigChatRoomQuota;
        private bool hasBigChatRoomSize;
        private bool hasBigHeadImgUrl;
        private bool hasExtXml;
        private bool hasGrayscaleFlag;
        private bool hasMainAcctType;
        private bool hasMsgPushSound;
        private bool hasMyBrandList;
        private bool hasSafeDevice;
        private bool hasSafeDeviceList;
        private bool hasSafeMobile;
        private bool hasSmallHeadImgUrl;
        private bool hasSnsUserInfo;
        private bool hasVoipPushSound;
        private uint mainAcctType_;
        public const int MainAcctTypeFieldNumber = 11;
        private int memoizedSerializedSize = -1;
        private string msgPushSound_ = "";
        public const int MsgPushSoundFieldNumber = 3;
        private string myBrandList_ = "";
        public const int MyBrandListFieldNumber = 2;
        private uint safeDevice_;
        public const int SafeDeviceFieldNumber = 14;
        private micromsg.SafeDeviceList safeDeviceList_;
        public const int SafeDeviceListFieldNumber = 13;
        private string safeMobile_ = "";
        public const int SafeMobileFieldNumber = 8;
        private string smallHeadImgUrl_ = "";
        public const int SmallHeadImgUrlFieldNumber = 10;
        private micromsg.SnsUserInfo snsUserInfo_;
        public const int SnsUserInfoFieldNumber = 1;
        private string voipPushSound_ = "";
        public const int VoipPushSoundFieldNumber = 4;

        static UserInfoExt()
        {
           // object.ReferenceEquals(UserInfoExt.Descriptor, null);
        }

        private UserInfoExt()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(UserInfoExt prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            UserInfoExt ext = obj as UserInfoExt;
            if (ext == null)
            {
                return false;
            }
            if ((this.hasSnsUserInfo != ext.hasSnsUserInfo) || (this.hasSnsUserInfo && !this.snsUserInfo_.Equals(ext.snsUserInfo_)))
            {
                return false;
            }
            if ((this.hasMyBrandList != ext.hasMyBrandList) || (this.hasMyBrandList && !this.myBrandList_.Equals(ext.myBrandList_)))
            {
                return false;
            }
            if ((this.hasMsgPushSound != ext.hasMsgPushSound) || (this.hasMsgPushSound && !this.msgPushSound_.Equals(ext.msgPushSound_)))
            {
                return false;
            }
            if ((this.hasVoipPushSound != ext.hasVoipPushSound) || (this.hasVoipPushSound && !this.voipPushSound_.Equals(ext.voipPushSound_)))
            {
                return false;
            }
            if ((this.hasBigChatRoomSize != ext.hasBigChatRoomSize) || (this.hasBigChatRoomSize && !this.bigChatRoomSize_.Equals(ext.bigChatRoomSize_)))
            {
                return false;
            }
            if ((this.hasBigChatRoomQuota != ext.hasBigChatRoomQuota) || (this.hasBigChatRoomQuota && !this.bigChatRoomQuota_.Equals(ext.bigChatRoomQuota_)))
            {
                return false;
            }
            if ((this.hasBigChatRoomInvite != ext.hasBigChatRoomInvite) || (this.hasBigChatRoomInvite && !this.bigChatRoomInvite_.Equals(ext.bigChatRoomInvite_)))
            {
                return false;
            }
            if ((this.hasSafeMobile != ext.hasSafeMobile) || (this.hasSafeMobile && !this.safeMobile_.Equals(ext.safeMobile_)))
            {
                return false;
            }
            if ((this.hasBigHeadImgUrl != ext.hasBigHeadImgUrl) || (this.hasBigHeadImgUrl && !this.bigHeadImgUrl_.Equals(ext.bigHeadImgUrl_)))
            {
                return false;
            }
            if ((this.hasSmallHeadImgUrl != ext.hasSmallHeadImgUrl) || (this.hasSmallHeadImgUrl && !this.smallHeadImgUrl_.Equals(ext.smallHeadImgUrl_)))
            {
                return false;
            }
            if ((this.hasMainAcctType != ext.hasMainAcctType) || (this.hasMainAcctType && !this.mainAcctType_.Equals(ext.mainAcctType_)))
            {
                return false;
            }
            if ((this.hasExtXml != ext.hasExtXml) || (this.hasExtXml && !this.extXml_.Equals(ext.extXml_)))
            {
                return false;
            }
            if ((this.hasSafeDeviceList != ext.hasSafeDeviceList) || (this.hasSafeDeviceList && !this.safeDeviceList_.Equals(ext.safeDeviceList_)))
            {
                return false;
            }
            if ((this.hasSafeDevice != ext.hasSafeDevice) || (this.hasSafeDevice && !this.safeDevice_.Equals(ext.safeDevice_)))
            {
                return false;
            }
            return ((this.hasGrayscaleFlag == ext.hasGrayscaleFlag) && (!this.hasGrayscaleFlag || this.grayscaleFlag_.Equals(ext.grayscaleFlag_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasSnsUserInfo)
            {
                hashCode ^= this.snsUserInfo_.GetHashCode();
            }
            if (this.hasMyBrandList)
            {
                hashCode ^= this.myBrandList_.GetHashCode();
            }
            if (this.hasMsgPushSound)
            {
                hashCode ^= this.msgPushSound_.GetHashCode();
            }
            if (this.hasVoipPushSound)
            {
                hashCode ^= this.voipPushSound_.GetHashCode();
            }
            if (this.hasBigChatRoomSize)
            {
                hashCode ^= this.bigChatRoomSize_.GetHashCode();
            }
            if (this.hasBigChatRoomQuota)
            {
                hashCode ^= this.bigChatRoomQuota_.GetHashCode();
            }
            if (this.hasBigChatRoomInvite)
            {
                hashCode ^= this.bigChatRoomInvite_.GetHashCode();
            }
            if (this.hasSafeMobile)
            {
                hashCode ^= this.safeMobile_.GetHashCode();
            }
            if (this.hasBigHeadImgUrl)
            {
                hashCode ^= this.bigHeadImgUrl_.GetHashCode();
            }
            if (this.hasSmallHeadImgUrl)
            {
                hashCode ^= this.smallHeadImgUrl_.GetHashCode();
            }
            if (this.hasMainAcctType)
            {
                hashCode ^= this.mainAcctType_.GetHashCode();
            }
            if (this.hasExtXml)
            {
                hashCode ^= this.extXml_.GetHashCode();
            }
            if (this.hasSafeDeviceList)
            {
                hashCode ^= this.safeDeviceList_.GetHashCode();
            }
            if (this.hasSafeDevice)
            {
                hashCode ^= this.safeDevice_.GetHashCode();
            }
            if (this.hasGrayscaleFlag)
            {
                hashCode ^= this.grayscaleFlag_.GetHashCode();
            }
            return hashCode;
        }

        private UserInfoExt MakeReadOnly()
        {
            return this;
        }

        public static UserInfoExt ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<UserInfoExt, Builder>.PrintField("SnsUserInfo", this.hasSnsUserInfo, this.snsUserInfo_, writer);
            GeneratedMessageLite<UserInfoExt, Builder>.PrintField("MyBrandList", this.hasMyBrandList, this.myBrandList_, writer);
            GeneratedMessageLite<UserInfoExt, Builder>.PrintField("MsgPushSound", this.hasMsgPushSound, this.msgPushSound_, writer);
            GeneratedMessageLite<UserInfoExt, Builder>.PrintField("VoipPushSound", this.hasVoipPushSound, this.voipPushSound_, writer);
            GeneratedMessageLite<UserInfoExt, Builder>.PrintField("BigChatRoomSize", this.hasBigChatRoomSize, this.bigChatRoomSize_, writer);
            GeneratedMessageLite<UserInfoExt, Builder>.PrintField("BigChatRoomQuota", this.hasBigChatRoomQuota, this.bigChatRoomQuota_, writer);
            GeneratedMessageLite<UserInfoExt, Builder>.PrintField("BigChatRoomInvite", this.hasBigChatRoomInvite, this.bigChatRoomInvite_, writer);
            GeneratedMessageLite<UserInfoExt, Builder>.PrintField("SafeMobile", this.hasSafeMobile, this.safeMobile_, writer);
            GeneratedMessageLite<UserInfoExt, Builder>.PrintField("BigHeadImgUrl", this.hasBigHeadImgUrl, this.bigHeadImgUrl_, writer);
            GeneratedMessageLite<UserInfoExt, Builder>.PrintField("SmallHeadImgUrl", this.hasSmallHeadImgUrl, this.smallHeadImgUrl_, writer);
            GeneratedMessageLite<UserInfoExt, Builder>.PrintField("MainAcctType", this.hasMainAcctType, this.mainAcctType_, writer);
            GeneratedMessageLite<UserInfoExt, Builder>.PrintField("ExtXml", this.hasExtXml, this.extXml_, writer);
            GeneratedMessageLite<UserInfoExt, Builder>.PrintField("SafeDeviceList", this.hasSafeDeviceList, this.safeDeviceList_, writer);
            GeneratedMessageLite<UserInfoExt, Builder>.PrintField("SafeDevice", this.hasSafeDevice, this.safeDevice_, writer);
            GeneratedMessageLite<UserInfoExt, Builder>.PrintField("GrayscaleFlag", this.hasGrayscaleFlag, this.grayscaleFlag_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _userInfoExtFieldNames;
            if (this.hasSnsUserInfo)
            {
                output.WriteMessage(1, strArray[13], this.SnsUserInfo);
            }
            if (this.hasMyBrandList)
            {
                output.WriteString(2, strArray[8], this.MyBrandList);
            }
            if (this.hasMsgPushSound)
            {
                output.WriteString(3, strArray[7], this.MsgPushSound);
            }
            if (this.hasVoipPushSound)
            {
                output.WriteString(4, strArray[14], this.VoipPushSound);
            }
            if (this.hasBigChatRoomSize)
            {
                output.WriteUInt32(5, strArray[2], this.BigChatRoomSize);
            }
            if (this.hasBigChatRoomQuota)
            {
                output.WriteUInt32(6, strArray[1], this.BigChatRoomQuota);
            }
            if (this.hasBigChatRoomInvite)
            {
                output.WriteUInt32(7, strArray[0], this.BigChatRoomInvite);
            }
            if (this.hasSafeMobile)
            {
                output.WriteString(8, strArray[11], this.SafeMobile);
            }
            if (this.hasBigHeadImgUrl)
            {
                output.WriteString(9, strArray[3], this.BigHeadImgUrl);
            }
            if (this.hasSmallHeadImgUrl)
            {
                output.WriteString(10, strArray[12], this.SmallHeadImgUrl);
            }
            if (this.hasMainAcctType)
            {
                output.WriteUInt32(11, strArray[6], this.MainAcctType);
            }
            if (this.hasExtXml)
            {
                output.WriteMessage(12, strArray[4], this.ExtXml);
            }
            if (this.hasSafeDeviceList)
            {
                output.WriteMessage(13, strArray[10], this.SafeDeviceList);
            }
            if (this.hasSafeDevice)
            {
                output.WriteUInt32(14, strArray[9], this.SafeDevice);
            }
            if (this.hasGrayscaleFlag)
            {
                output.WriteUInt32(15, strArray[5], this.GrayscaleFlag);
            }
        }

        public uint BigChatRoomInvite
        {
            get
            {
                return this.bigChatRoomInvite_;
            }
        }

        public uint BigChatRoomQuota
        {
            get
            {
                return this.bigChatRoomQuota_;
            }
        }

        public uint BigChatRoomSize
        {
            get
            {
                return this.bigChatRoomSize_;
            }
        }

        public string BigHeadImgUrl
        {
            get
            {
                return this.bigHeadImgUrl_;
            }
        }

        public static UserInfoExt DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override UserInfoExt DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public SKBuiltinString_t ExtXml
        {
            get
            {
                return (this.extXml_ ?? SKBuiltinString_t.DefaultInstance);
            }
        }

        public uint GrayscaleFlag
        {
            get
            {
                return this.grayscaleFlag_;
            }
        }

        public override bool IsInitialized
        {
            get
            {
                if (!this.hasSnsUserInfo)
                {
                    return false;
                }
                if (!this.SnsUserInfo.IsInitialized)
                {
                    return false;
                }
                return true;
            }
        }

        public uint MainAcctType
        {
            get
            {
                return this.mainAcctType_;
            }
        }

        public string MsgPushSound
        {
            get
            {
                return this.msgPushSound_;
            }
        }

        public string MyBrandList
        {
            get
            {
                return this.myBrandList_;
            }
        }

        public uint SafeDevice
        {
            get
            {
                return this.safeDevice_;
            }
        }

        public micromsg.SafeDeviceList SafeDeviceList
        {
            get
            {
                return (this.safeDeviceList_ ?? micromsg.SafeDeviceList.DefaultInstance);
            }
        }

        public string SafeMobile
        {
            get
            {
                return this.safeMobile_;
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
                    if (this.hasSnsUserInfo)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(1, this.SnsUserInfo);
                    }
                    if (this.hasMyBrandList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(2, this.MyBrandList);
                    }
                    if (this.hasMsgPushSound)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(3, this.MsgPushSound);
                    }
                    if (this.hasVoipPushSound)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(4, this.VoipPushSound);
                    }
                    if (this.hasBigChatRoomSize)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(5, this.BigChatRoomSize);
                    }
                    if (this.hasBigChatRoomQuota)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(6, this.BigChatRoomQuota);
                    }
                    if (this.hasBigChatRoomInvite)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(7, this.BigChatRoomInvite);
                    }
                    if (this.hasSafeMobile)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(8, this.SafeMobile);
                    }
                    if (this.hasBigHeadImgUrl)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(9, this.BigHeadImgUrl);
                    }
                    if (this.hasSmallHeadImgUrl)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(10, this.SmallHeadImgUrl);
                    }
                    if (this.hasMainAcctType)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(11, this.MainAcctType);
                    }
                    if (this.hasExtXml)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(12, this.ExtXml);
                    }
                    if (this.hasSafeDeviceList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(13, this.SafeDeviceList);
                    }
                    if (this.hasSafeDevice)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(14, this.SafeDevice);
                    }
                    if (this.hasGrayscaleFlag)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(15, this.GrayscaleFlag);
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

        public micromsg.SnsUserInfo SnsUserInfo
        {
            get
            {
                return (this.snsUserInfo_ ?? micromsg.SnsUserInfo.DefaultInstance);
            }
        }

        protected override UserInfoExt ThisMessage
        {
            get
            {
                return this;
            }
        }

        public string VoipPushSound
        {
            get
            {
                return this.voipPushSound_;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<UserInfoExt, UserInfoExt.Builder>
        {
            private UserInfoExt result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = UserInfoExt.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(UserInfoExt cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override UserInfoExt BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override UserInfoExt.Builder Clear()
            {
                this.result = UserInfoExt.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public UserInfoExt.Builder ClearBigChatRoomInvite()
            {
                this.PrepareBuilder();
                this.result.hasBigChatRoomInvite = false;
                this.result.bigChatRoomInvite_ = 0;
                return this;
            }

            public UserInfoExt.Builder ClearBigChatRoomQuota()
            {
                this.PrepareBuilder();
                this.result.hasBigChatRoomQuota = false;
                this.result.bigChatRoomQuota_ = 0;
                return this;
            }

            public UserInfoExt.Builder ClearBigChatRoomSize()
            {
                this.PrepareBuilder();
                this.result.hasBigChatRoomSize = false;
                this.result.bigChatRoomSize_ = 0;
                return this;
            }

            public UserInfoExt.Builder ClearBigHeadImgUrl()
            {
                this.PrepareBuilder();
                this.result.hasBigHeadImgUrl = false;
                this.result.bigHeadImgUrl_ = "";
                return this;
            }

            public UserInfoExt.Builder ClearExtXml()
            {
                this.PrepareBuilder();
                this.result.hasExtXml = false;
                this.result.extXml_ = null;
                return this;
            }

            public UserInfoExt.Builder ClearGrayscaleFlag()
            {
                this.PrepareBuilder();
                this.result.hasGrayscaleFlag = false;
                this.result.grayscaleFlag_ = 0;
                return this;
            }

            public UserInfoExt.Builder ClearMainAcctType()
            {
                this.PrepareBuilder();
                this.result.hasMainAcctType = false;
                this.result.mainAcctType_ = 0;
                return this;
            }

            public UserInfoExt.Builder ClearMsgPushSound()
            {
                this.PrepareBuilder();
                this.result.hasMsgPushSound = false;
                this.result.msgPushSound_ = "";
                return this;
            }

            public UserInfoExt.Builder ClearMyBrandList()
            {
                this.PrepareBuilder();
                this.result.hasMyBrandList = false;
                this.result.myBrandList_ = "";
                return this;
            }

            public UserInfoExt.Builder ClearSafeDevice()
            {
                this.PrepareBuilder();
                this.result.hasSafeDevice = false;
                this.result.safeDevice_ = 0;
                return this;
            }

            public UserInfoExt.Builder ClearSafeDeviceList()
            {
                this.PrepareBuilder();
                this.result.hasSafeDeviceList = false;
                this.result.safeDeviceList_ = null;
                return this;
            }

            public UserInfoExt.Builder ClearSafeMobile()
            {
                this.PrepareBuilder();
                this.result.hasSafeMobile = false;
                this.result.safeMobile_ = "";
                return this;
            }

            public UserInfoExt.Builder ClearSmallHeadImgUrl()
            {
                this.PrepareBuilder();
                this.result.hasSmallHeadImgUrl = false;
                this.result.smallHeadImgUrl_ = "";
                return this;
            }

            public UserInfoExt.Builder ClearSnsUserInfo()
            {
                this.PrepareBuilder();
                this.result.hasSnsUserInfo = false;
                this.result.snsUserInfo_ = null;
                return this;
            }

            public UserInfoExt.Builder ClearVoipPushSound()
            {
                this.PrepareBuilder();
                this.result.hasVoipPushSound = false;
                this.result.voipPushSound_ = "";
                return this;
            }

            public override UserInfoExt.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new UserInfoExt.Builder(this.result);
                }
                return new UserInfoExt.Builder().MergeFrom(this.result);
            }

            public UserInfoExt.Builder MergeExtXml(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasExtXml && (this.result.extXml_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.extXml_ = SKBuiltinString_t.CreateBuilder(this.result.extXml_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.extXml_ = value;
                }
                this.result.hasExtXml = true;
                return this;
            }

            public override UserInfoExt.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override UserInfoExt.Builder MergeFrom(IMessageLite other)
            {
                if (other is UserInfoExt)
                {
                    return this.MergeFrom((UserInfoExt) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override UserInfoExt.Builder MergeFrom(UserInfoExt other)
            {
                return this;
            }

            public override UserInfoExt.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(UserInfoExt._userInfoExtFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = UserInfoExt._userInfoExtFieldTags[index];
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
                            this.result.hasMyBrandList = input.ReadString(ref this.result.myBrandList_);
                            continue;
                        }
                        case 0x1a:
                        {
                            this.result.hasMsgPushSound = input.ReadString(ref this.result.msgPushSound_);
                            continue;
                        }
                        case 0:
                            throw InvalidProtocolBufferException.InvalidTag();

                        case 10:
                        {
                            micromsg.SnsUserInfo.Builder builder = micromsg.SnsUserInfo.CreateBuilder();
                            if (this.result.hasSnsUserInfo)
                            {
                                builder.MergeFrom(this.SnsUserInfo);
                            }
                            input.ReadMessage(builder, extensionRegistry);
                            this.SnsUserInfo = builder.BuildPartial();
                            continue;
                        }
                        case 0x22:
                        {
                            this.result.hasVoipPushSound = input.ReadString(ref this.result.voipPushSound_);
                            continue;
                        }
                        case 40:
                        {
                            this.result.hasBigChatRoomSize = input.ReadUInt32(ref this.result.bigChatRoomSize_);
                            continue;
                        }
                        case 0x30:
                        {
                            this.result.hasBigChatRoomQuota = input.ReadUInt32(ref this.result.bigChatRoomQuota_);
                            continue;
                        }
                        case 0x38:
                        {
                            this.result.hasBigChatRoomInvite = input.ReadUInt32(ref this.result.bigChatRoomInvite_);
                            continue;
                        }
                        case 0x52:
                        {
                            this.result.hasSmallHeadImgUrl = input.ReadString(ref this.result.smallHeadImgUrl_);
                            continue;
                        }
                        case 0x58:
                        {
                            this.result.hasMainAcctType = input.ReadUInt32(ref this.result.mainAcctType_);
                            continue;
                        }
                        case 0x42:
                        {
                            this.result.hasSafeMobile = input.ReadString(ref this.result.safeMobile_);
                            continue;
                        }
                        case 0x4a:
                        {
                            this.result.hasBigHeadImgUrl = input.ReadString(ref this.result.bigHeadImgUrl_);
                            continue;
                        }
                        case 0x62:
                        {
                            SKBuiltinString_t.Builder builder2 = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasExtXml)
                            {
                                builder2.MergeFrom(this.ExtXml);
                            }
                            input.ReadMessage(builder2, extensionRegistry);
                            this.ExtXml = builder2.BuildPartial();
                            continue;
                        }
                        case 0x6a:
                        {
                            micromsg.SafeDeviceList.Builder builder3 = micromsg.SafeDeviceList.CreateBuilder();
                            if (this.result.hasSafeDeviceList)
                            {
                                builder3.MergeFrom(this.SafeDeviceList);
                            }
                            input.ReadMessage(builder3, extensionRegistry);
                            this.SafeDeviceList = builder3.BuildPartial();
                            continue;
                        }
                        case 0x70:
                        {
                            this.result.hasSafeDevice = input.ReadUInt32(ref this.result.safeDevice_);
                            continue;
                        }
                        case 120:
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

            public UserInfoExt.Builder MergeSafeDeviceList(micromsg.SafeDeviceList value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasSafeDeviceList && (this.result.safeDeviceList_ != micromsg.SafeDeviceList.DefaultInstance))
                {
                    this.result.safeDeviceList_ = micromsg.SafeDeviceList.CreateBuilder(this.result.safeDeviceList_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.safeDeviceList_ = value;
                }
                this.result.hasSafeDeviceList = true;
                return this;
            }

            public UserInfoExt.Builder MergeSnsUserInfo(micromsg.SnsUserInfo value)
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

            private UserInfoExt PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    UserInfoExt result = this.result;
                    this.result = new UserInfoExt();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public UserInfoExt.Builder SetBigChatRoomInvite(uint value)
            {
                this.PrepareBuilder();
                this.result.hasBigChatRoomInvite = true;
                this.result.bigChatRoomInvite_ = value;
                return this;
            }

            public UserInfoExt.Builder SetBigChatRoomQuota(uint value)
            {
                this.PrepareBuilder();
                this.result.hasBigChatRoomQuota = true;
                this.result.bigChatRoomQuota_ = value;
                return this;
            }

            public UserInfoExt.Builder SetBigChatRoomSize(uint value)
            {
                this.PrepareBuilder();
                this.result.hasBigChatRoomSize = true;
                this.result.bigChatRoomSize_ = value;
                return this;
            }

            public UserInfoExt.Builder SetBigHeadImgUrl(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBigHeadImgUrl = true;
                this.result.bigHeadImgUrl_ = value;
                return this;
            }

            public UserInfoExt.Builder SetExtXml(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasExtXml = true;
                this.result.extXml_ = value;
                return this;
            }

            public UserInfoExt.Builder SetExtXml(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasExtXml = true;
                this.result.extXml_ = builderForValue.Build();
                return this;
            }

            public UserInfoExt.Builder SetGrayscaleFlag(uint value)
            {
                this.PrepareBuilder();
                this.result.hasGrayscaleFlag = true;
                this.result.grayscaleFlag_ = value;
                return this;
            }

            public UserInfoExt.Builder SetMainAcctType(uint value)
            {
                this.PrepareBuilder();
                this.result.hasMainAcctType = true;
                this.result.mainAcctType_ = value;
                return this;
            }

            public UserInfoExt.Builder SetMsgPushSound(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasMsgPushSound = true;
                this.result.msgPushSound_ = value;
                return this;
            }

            public UserInfoExt.Builder SetMyBrandList(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasMyBrandList = true;
                this.result.myBrandList_ = value;
                return this;
            }

            public UserInfoExt.Builder SetSafeDevice(uint value)
            {
                this.PrepareBuilder();
                this.result.hasSafeDevice = true;
                this.result.safeDevice_ = value;
                return this;
            }

            public UserInfoExt.Builder SetSafeDeviceList(micromsg.SafeDeviceList value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSafeDeviceList = true;
                this.result.safeDeviceList_ = value;
                return this;
            }

            public UserInfoExt.Builder SetSafeDeviceList(micromsg.SafeDeviceList.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasSafeDeviceList = true;
                this.result.safeDeviceList_ = builderForValue.Build();
                return this;
            }

            public UserInfoExt.Builder SetSafeMobile(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSafeMobile = true;
                this.result.safeMobile_ = value;
                return this;
            }

            public UserInfoExt.Builder SetSmallHeadImgUrl(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSmallHeadImgUrl = true;
                this.result.smallHeadImgUrl_ = value;
                return this;
            }

            public UserInfoExt.Builder SetSnsUserInfo(micromsg.SnsUserInfo value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSnsUserInfo = true;
                this.result.snsUserInfo_ = value;
                return this;
            }

            public UserInfoExt.Builder SetSnsUserInfo(micromsg.SnsUserInfo.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasSnsUserInfo = true;
                this.result.snsUserInfo_ = builderForValue.Build();
                return this;
            }

            public UserInfoExt.Builder SetVoipPushSound(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasVoipPushSound = true;
                this.result.voipPushSound_ = value;
                return this;
            }

            public uint BigChatRoomInvite
            {
                get
                {
                    return this.result.BigChatRoomInvite;
                }
                set
                {
                    this.SetBigChatRoomInvite(value);
                }
            }

            public uint BigChatRoomQuota
            {
                get
                {
                    return this.result.BigChatRoomQuota;
                }
                set
                {
                    this.SetBigChatRoomQuota(value);
                }
            }

            public uint BigChatRoomSize
            {
                get
                {
                    return this.result.BigChatRoomSize;
                }
                set
                {
                    this.SetBigChatRoomSize(value);
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

            public override UserInfoExt DefaultInstanceForType
            {
                get
                {
                    return UserInfoExt.DefaultInstance;
                }
            }

            public SKBuiltinString_t ExtXml
            {
                get
                {
                    return this.result.ExtXml;
                }
                set
                {
                    this.SetExtXml(value);
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

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            public uint MainAcctType
            {
                get
                {
                    return this.result.MainAcctType;
                }
                set
                {
                    this.SetMainAcctType(value);
                }
            }

            protected override UserInfoExt MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public string MsgPushSound
            {
                get
                {
                    return this.result.MsgPushSound;
                }
                set
                {
                    this.SetMsgPushSound(value);
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

            public uint SafeDevice
            {
                get
                {
                    return this.result.SafeDevice;
                }
                set
                {
                    this.SetSafeDevice(value);
                }
            }

            public micromsg.SafeDeviceList SafeDeviceList
            {
                get
                {
                    return this.result.SafeDeviceList;
                }
                set
                {
                    this.SetSafeDeviceList(value);
                }
            }

            public string SafeMobile
            {
                get
                {
                    return this.result.SafeMobile;
                }
                set
                {
                    this.SetSafeMobile(value);
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

            protected override UserInfoExt.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }

            public string VoipPushSound
            {
                get
                {
                    return this.result.VoipPushSound;
                }
                set
                {
                    this.SetVoipPushSound(value);
                }
            }
        }
    }
}


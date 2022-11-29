namespace micromsg
{
    using Google.ProtocolBuffers;

    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    using System.Runtime.CompilerServices;


    public sealed class NewAuthRequest : GeneratedMessageLite<NewAuthRequest, NewAuthRequest.Builder>
    {
        private static readonly string[] _NewAuthRequestFieldNames = new string[] { 
            "AdSource", "AuthTicket", "AutoAuthTicket", "BaseRequest", "BuiltinIPSeq", "BundleID", "Channel", "CliDBEncryptInfo", "CliDBEncryptKey", "ClientSeqID", "DeviceBrand", "DeviceModel", "DeviceName", "DeviceType", "IMEI", "IPhoneVer", 
            "ImgCode", "ImgEncryptKey", "ImgSid", "InputType", "KSid", "Language", "OSType", "Pwd", "Pwd2", "RandomEncryKey", "RealCountry", "Signature", "SoftType", "TimeStamp", "TimeZone", "UserName", 
            "VerifyContent", "VerifySignature", "WTLoginReqBuff", "extPwd", "extPwd2"
         };
        private static readonly uint[] _NewAuthRequestFieldTags = new uint[] { 
            0x10a, 0xba, 0xda, 10, 0x38, 0x102, 0x68, 0x11a, 0x112, 250, 0x92, 0x9a, 0xe2, 170, 0x62, 0x72, 
            0x2a, 0x7a, 0x22, 240, 130, 90, 0xa2, 0x1a, 50, 210, 0xc2, 0xca, 0xb2, 0x88, 0x52, 0x12, 
            0x12a, 290, 0xea, 0x42, 0x4a
         };
        private string adSource_ = "";
        public const int AdSourceFieldNumber = 0x21;
        private string authTicket_ = "";
        public const int AuthTicketFieldNumber = 0x17;
        private string autoAuthTicket_ = "";
        public const int AutoAuthTicketFieldNumber = 0x1b;
        private BaseRequest baseRequest_;
        public const int BaseRequestFieldNumber = 1;
        private uint builtinIPSeq_;
        public const int BuiltinIPSeqFieldNumber = 7;
        private string bundleID_ = "";
        public const int BundleIDFieldNumber = 0x20;
        private int channel_;
        public const int ChannelFieldNumber = 13;
        private SKBuiltinBuffer_t cliDBEncryptInfo_;
        public const int CliDBEncryptInfoFieldNumber = 0x23;
        private SKBuiltinBuffer_t cliDBEncryptKey_;
        public const int CliDBEncryptKeyFieldNumber = 0x22;
        private string clientSeqID_ = "";
        public const int ClientSeqIDFieldNumber = 0x1f;
        private static readonly NewAuthRequest defaultInstance = new NewAuthRequest().MakeReadOnly();
        private string deviceBrand_ = "";
        public const int DeviceBrandFieldNumber = 0x12;
        private string deviceModel_ = "";
        public const int DeviceModelFieldNumber = 0x13;
        private string deviceName_ = "";
        public const int DeviceNameFieldNumber = 0x1c;
        private string deviceType_ = "";
        public const int DeviceTypeFieldNumber = 0x15;
        private string extPwd_ = "";
        private string extPwd2_ = "";
        public const int ExtPwd2FieldNumber = 9;
        public const int ExtPwdFieldNumber = 8;
        private bool hasAdSource;
        private bool hasAuthTicket;
        private bool hasAutoAuthTicket;
        private bool hasBaseRequest;
        private bool hasBuiltinIPSeq;
        private bool hasBundleID;
        private bool hasChannel;
        private bool hasCliDBEncryptInfo;
        private bool hasCliDBEncryptKey;
        private bool hasClientSeqID;
        private bool hasDeviceBrand;
        private bool hasDeviceModel;
        private bool hasDeviceName;
        private bool hasDeviceType;
        private bool hasExtPwd;
        private bool hasExtPwd2;
        private bool hasIMEI;
        private bool hasImgCode;
        private bool hasImgEncryptKey;
        private bool hasImgSid;
        private bool hasInputType;
        private bool hasIPhoneVer;
        private bool hasKSid;
        private bool hasLanguage;
        private bool hasOSType;
        private bool hasPwd;
        private bool hasPwd2;
        private bool hasRandomEncryKey;
        private bool hasRealCountry;
        private bool hasSignature;
        private bool hasSoftType;
        private bool hasTimeStamp;
        private bool hasTimeZone;
        private bool hasUserName;
        private bool hasVerifyContent;
        private bool hasVerifySignature;
        private bool hasWTLoginReqBuff;
        private string iMEI_ = "";
        public const int IMEIFieldNumber = 12;
        private SKBuiltinString_t imgCode_;
        public const int ImgCodeFieldNumber = 5;
        private SKBuiltinString_t imgEncryptKey_;
        public const int ImgEncryptKeyFieldNumber = 15;
        private SKBuiltinString_t imgSid_;
        public const int ImgSidFieldNumber = 4;
        private uint inputType_;
        public const int InputTypeFieldNumber = 30;
        private string iPhoneVer_ = "";
        public const int IPhoneVerFieldNumber = 14;
        private SKBuiltinBuffer_t kSid_;
        public const int KSidFieldNumber = 0x10;
        private string language_ = "";
        public const int LanguageFieldNumber = 11;
        private int memoizedSerializedSize = -1;
        private string oSType_ = "";
        public const int OSTypeFieldNumber = 20;
        private SKBuiltinString_t pwd_;
        private string pwd2_ = "";
        public const int Pwd2FieldNumber = 6;
        public const int PwdFieldNumber = 3;
        private SKBuiltinBuffer_t randomEncryKey_;
        public const int RandomEncryKeyFieldNumber = 0x1a;
        private string realCountry_ = "";
        public const int RealCountryFieldNumber = 0x18;
        private string signature_ = "";
        public const int SignatureFieldNumber = 0x19;
        private string softType_ = "";
        public const int SoftTypeFieldNumber = 0x16;
        private uint timeStamp_;
        public const int TimeStampFieldNumber = 0x11;
        private string timeZone_ = "";
        public const int TimeZoneFieldNumber = 10;
        private SKBuiltinString_t userName_;
        public const int UserNameFieldNumber = 2;
        private string verifyContent_ = "";
        public const int VerifyContentFieldNumber = 0x25;
        private string verifySignature_ = "";
        public const int VerifySignatureFieldNumber = 0x24;
        private SKBuiltinBuffer_t wTLoginReqBuff_;
        public const int WTLoginReqBuffFieldNumber = 0x1d;

        static NewAuthRequest()
        {

        }

        private NewAuthRequest()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(NewAuthRequest prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            NewAuthRequest request = obj as NewAuthRequest;
            if (request == null)
            {
                return false;
            }
            if ((this.hasBaseRequest != request.hasBaseRequest) || (this.hasBaseRequest && !this.baseRequest_.Equals(request.baseRequest_)))
            {
                return false;
            }
            if ((this.hasUserName != request.hasUserName) || (this.hasUserName && !this.userName_.Equals(request.userName_)))
            {
                return false;
            }
            if ((this.hasPwd != request.hasPwd) || (this.hasPwd && !this.pwd_.Equals(request.pwd_)))
            {
                return false;
            }
            if ((this.hasImgSid != request.hasImgSid) || (this.hasImgSid && !this.imgSid_.Equals(request.imgSid_)))
            {
                return false;
            }
            if ((this.hasImgCode != request.hasImgCode) || (this.hasImgCode && !this.imgCode_.Equals(request.imgCode_)))
            {
                return false;
            }
            if ((this.hasPwd2 != request.hasPwd2) || (this.hasPwd2 && !this.pwd2_.Equals(request.pwd2_)))
            {
                return false;
            }
            if ((this.hasBuiltinIPSeq != request.hasBuiltinIPSeq) || (this.hasBuiltinIPSeq && !this.builtinIPSeq_.Equals(request.builtinIPSeq_)))
            {
                return false;
            }
            if ((this.hasExtPwd != request.hasExtPwd) || (this.hasExtPwd && !this.extPwd_.Equals(request.extPwd_)))
            {
                return false;
            }
            if ((this.hasExtPwd2 != request.hasExtPwd2) || (this.hasExtPwd2 && !this.extPwd2_.Equals(request.extPwd2_)))
            {
                return false;
            }
            if ((this.hasTimeZone != request.hasTimeZone) || (this.hasTimeZone && !this.timeZone_.Equals(request.timeZone_)))
            {
                return false;
            }
            if ((this.hasLanguage != request.hasLanguage) || (this.hasLanguage && !this.language_.Equals(request.language_)))
            {
                return false;
            }
            if ((this.hasIMEI != request.hasIMEI) || (this.hasIMEI && !this.iMEI_.Equals(request.iMEI_)))
            {
                return false;
            }
            if ((this.hasChannel != request.hasChannel) || (this.hasChannel && !this.channel_.Equals(request.channel_)))
            {
                return false;
            }
            if ((this.hasIPhoneVer != request.hasIPhoneVer) || (this.hasIPhoneVer && !this.iPhoneVer_.Equals(request.iPhoneVer_)))
            {
                return false;
            }
            if ((this.hasImgEncryptKey != request.hasImgEncryptKey) || (this.hasImgEncryptKey && !this.imgEncryptKey_.Equals(request.imgEncryptKey_)))
            {
                return false;
            }
            if ((this.hasKSid != request.hasKSid) || (this.hasKSid && !this.kSid_.Equals(request.kSid_)))
            {
                return false;
            }
            if ((this.hasTimeStamp != request.hasTimeStamp) || (this.hasTimeStamp && !this.timeStamp_.Equals(request.timeStamp_)))
            {
                return false;
            }
            if ((this.hasDeviceBrand != request.hasDeviceBrand) || (this.hasDeviceBrand && !this.deviceBrand_.Equals(request.deviceBrand_)))
            {
                return false;
            }
            if ((this.hasDeviceModel != request.hasDeviceModel) || (this.hasDeviceModel && !this.deviceModel_.Equals(request.deviceModel_)))
            {
                return false;
            }
            if ((this.hasOSType != request.hasOSType) || (this.hasOSType && !this.oSType_.Equals(request.oSType_)))
            {
                return false;
            }
            if ((this.hasDeviceType != request.hasDeviceType) || (this.hasDeviceType && !this.deviceType_.Equals(request.deviceType_)))
            {
                return false;
            }
            if ((this.hasSoftType != request.hasSoftType) || (this.hasSoftType && !this.softType_.Equals(request.softType_)))
            {
                return false;
            }
            if ((this.hasAuthTicket != request.hasAuthTicket) || (this.hasAuthTicket && !this.authTicket_.Equals(request.authTicket_)))
            {
                return false;
            }
            if ((this.hasRealCountry != request.hasRealCountry) || (this.hasRealCountry && !this.realCountry_.Equals(request.realCountry_)))
            {
                return false;
            }
            if ((this.hasSignature != request.hasSignature) || (this.hasSignature && !this.signature_.Equals(request.signature_)))
            {
                return false;
            }
            if ((this.hasRandomEncryKey != request.hasRandomEncryKey) || (this.hasRandomEncryKey && !this.randomEncryKey_.Equals(request.randomEncryKey_)))
            {
                return false;
            }
            if ((this.hasAutoAuthTicket != request.hasAutoAuthTicket) || (this.hasAutoAuthTicket && !this.autoAuthTicket_.Equals(request.autoAuthTicket_)))
            {
                return false;
            }
            if ((this.hasDeviceName != request.hasDeviceName) || (this.hasDeviceName && !this.deviceName_.Equals(request.deviceName_)))
            {
                return false;
            }
            if ((this.hasWTLoginReqBuff != request.hasWTLoginReqBuff) || (this.hasWTLoginReqBuff && !this.wTLoginReqBuff_.Equals(request.wTLoginReqBuff_)))
            {
                return false;
            }
            if ((this.hasInputType != request.hasInputType) || (this.hasInputType && !this.inputType_.Equals(request.inputType_)))
            {
                return false;
            }
            if ((this.hasClientSeqID != request.hasClientSeqID) || (this.hasClientSeqID && !this.clientSeqID_.Equals(request.clientSeqID_)))
            {
                return false;
            }
            if ((this.hasBundleID != request.hasBundleID) || (this.hasBundleID && !this.bundleID_.Equals(request.bundleID_)))
            {
                return false;
            }
            if ((this.hasAdSource != request.hasAdSource) || (this.hasAdSource && !this.adSource_.Equals(request.adSource_)))
            {
                return false;
            }
            if ((this.hasCliDBEncryptKey != request.hasCliDBEncryptKey) || (this.hasCliDBEncryptKey && !this.cliDBEncryptKey_.Equals(request.cliDBEncryptKey_)))
            {
                return false;
            }
            if ((this.hasCliDBEncryptInfo != request.hasCliDBEncryptInfo) || (this.hasCliDBEncryptInfo && !this.cliDBEncryptInfo_.Equals(request.cliDBEncryptInfo_)))
            {
                return false;
            }
            if ((this.hasVerifySignature != request.hasVerifySignature) || (this.hasVerifySignature && !this.verifySignature_.Equals(request.verifySignature_)))
            {
                return false;
            }
            return ((this.hasVerifyContent == request.hasVerifyContent) && (!this.hasVerifyContent || this.verifyContent_.Equals(request.verifyContent_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasBaseRequest)
            {
                hashCode ^= this.baseRequest_.GetHashCode();
            }
            if (this.hasUserName)
            {
                hashCode ^= this.userName_.GetHashCode();
            }
            if (this.hasPwd)
            {
                hashCode ^= this.pwd_.GetHashCode();
            }
            if (this.hasImgSid)
            {
                hashCode ^= this.imgSid_.GetHashCode();
            }
            if (this.hasImgCode)
            {
                hashCode ^= this.imgCode_.GetHashCode();
            }
            if (this.hasPwd2)
            {
                hashCode ^= this.pwd2_.GetHashCode();
            }
            if (this.hasBuiltinIPSeq)
            {
                hashCode ^= this.builtinIPSeq_.GetHashCode();
            }
            if (this.hasExtPwd)
            {
                hashCode ^= this.extPwd_.GetHashCode();
            }
            if (this.hasExtPwd2)
            {
                hashCode ^= this.extPwd2_.GetHashCode();
            }
            if (this.hasTimeZone)
            {
                hashCode ^= this.timeZone_.GetHashCode();
            }
            if (this.hasLanguage)
            {
                hashCode ^= this.language_.GetHashCode();
            }
            if (this.hasIMEI)
            {
                hashCode ^= this.iMEI_.GetHashCode();
            }
            if (this.hasChannel)
            {
                hashCode ^= this.channel_.GetHashCode();
            }
            if (this.hasIPhoneVer)
            {
                hashCode ^= this.iPhoneVer_.GetHashCode();
            }
            if (this.hasImgEncryptKey)
            {
                hashCode ^= this.imgEncryptKey_.GetHashCode();
            }
            if (this.hasKSid)
            {
                hashCode ^= this.kSid_.GetHashCode();
            }
            if (this.hasTimeStamp)
            {
                hashCode ^= this.timeStamp_.GetHashCode();
            }
            if (this.hasDeviceBrand)
            {
                hashCode ^= this.deviceBrand_.GetHashCode();
            }
            if (this.hasDeviceModel)
            {
                hashCode ^= this.deviceModel_.GetHashCode();
            }
            if (this.hasOSType)
            {
                hashCode ^= this.oSType_.GetHashCode();
            }
            if (this.hasDeviceType)
            {
                hashCode ^= this.deviceType_.GetHashCode();
            }
            if (this.hasSoftType)
            {
                hashCode ^= this.softType_.GetHashCode();
            }
            if (this.hasAuthTicket)
            {
                hashCode ^= this.authTicket_.GetHashCode();
            }
            if (this.hasRealCountry)
            {
                hashCode ^= this.realCountry_.GetHashCode();
            }
            if (this.hasSignature)
            {
                hashCode ^= this.signature_.GetHashCode();
            }
            if (this.hasRandomEncryKey)
            {
                hashCode ^= this.randomEncryKey_.GetHashCode();
            }
            if (this.hasAutoAuthTicket)
            {
                hashCode ^= this.autoAuthTicket_.GetHashCode();
            }
            if (this.hasDeviceName)
            {
                hashCode ^= this.deviceName_.GetHashCode();
            }
            if (this.hasWTLoginReqBuff)
            {
                hashCode ^= this.wTLoginReqBuff_.GetHashCode();
            }
            if (this.hasInputType)
            {
                hashCode ^= this.inputType_.GetHashCode();
            }
            if (this.hasClientSeqID)
            {
                hashCode ^= this.clientSeqID_.GetHashCode();
            }
            if (this.hasBundleID)
            {
                hashCode ^= this.bundleID_.GetHashCode();
            }
            if (this.hasAdSource)
            {
                hashCode ^= this.adSource_.GetHashCode();
            }
            if (this.hasCliDBEncryptKey)
            {
                hashCode ^= this.cliDBEncryptKey_.GetHashCode();
            }
            if (this.hasCliDBEncryptInfo)
            {
                hashCode ^= this.cliDBEncryptInfo_.GetHashCode();
            }
            if (this.hasVerifySignature)
            {
                hashCode ^= this.verifySignature_.GetHashCode();
            }
            if (this.hasVerifyContent)
            {
                hashCode ^= this.verifyContent_.GetHashCode();
            }
            return hashCode;
        }

        private NewAuthRequest MakeReadOnly()
        {
            return this;
        }

        public static NewAuthRequest ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<NewAuthRequest, Builder>.PrintField("BaseRequest", this.hasBaseRequest, this.baseRequest_, writer);
            GeneratedMessageLite<NewAuthRequest, Builder>.PrintField("UserName", this.hasUserName, this.userName_, writer);
            GeneratedMessageLite<NewAuthRequest, Builder>.PrintField("Pwd", this.hasPwd, this.pwd_, writer);
            GeneratedMessageLite<NewAuthRequest, Builder>.PrintField("ImgSid", this.hasImgSid, this.imgSid_, writer);
            GeneratedMessageLite<NewAuthRequest, Builder>.PrintField("ImgCode", this.hasImgCode, this.imgCode_, writer);
            GeneratedMessageLite<NewAuthRequest, Builder>.PrintField("Pwd2", this.hasPwd2, this.pwd2_, writer);
            GeneratedMessageLite<NewAuthRequest, Builder>.PrintField("BuiltinIPSeq", this.hasBuiltinIPSeq, this.builtinIPSeq_, writer);
            GeneratedMessageLite<NewAuthRequest, Builder>.PrintField("extPwd", this.hasExtPwd, this.extPwd_, writer);
            GeneratedMessageLite<NewAuthRequest, Builder>.PrintField("extPwd2", this.hasExtPwd2, this.extPwd2_, writer);
            GeneratedMessageLite<NewAuthRequest, Builder>.PrintField("TimeZone", this.hasTimeZone, this.timeZone_, writer);
            GeneratedMessageLite<NewAuthRequest, Builder>.PrintField("Language", this.hasLanguage, this.language_, writer);
            GeneratedMessageLite<NewAuthRequest, Builder>.PrintField("IMEI", this.hasIMEI, this.iMEI_, writer);
            GeneratedMessageLite<NewAuthRequest, Builder>.PrintField("Channel", this.hasChannel, this.channel_, writer);
            GeneratedMessageLite<NewAuthRequest, Builder>.PrintField("IPhoneVer", this.hasIPhoneVer, this.iPhoneVer_, writer);
            GeneratedMessageLite<NewAuthRequest, Builder>.PrintField("ImgEncryptKey", this.hasImgEncryptKey, this.imgEncryptKey_, writer);
            GeneratedMessageLite<NewAuthRequest, Builder>.PrintField("KSid", this.hasKSid, this.kSid_, writer);
            GeneratedMessageLite<NewAuthRequest, Builder>.PrintField("TimeStamp", this.hasTimeStamp, this.timeStamp_, writer);
            GeneratedMessageLite<NewAuthRequest, Builder>.PrintField("DeviceBrand", this.hasDeviceBrand, this.deviceBrand_, writer);
            GeneratedMessageLite<NewAuthRequest, Builder>.PrintField("DeviceModel", this.hasDeviceModel, this.deviceModel_, writer);
            GeneratedMessageLite<NewAuthRequest, Builder>.PrintField("OSType", this.hasOSType, this.oSType_, writer);
            GeneratedMessageLite<NewAuthRequest, Builder>.PrintField("DeviceType", this.hasDeviceType, this.deviceType_, writer);
            GeneratedMessageLite<NewAuthRequest, Builder>.PrintField("SoftType", this.hasSoftType, this.softType_, writer);
            GeneratedMessageLite<NewAuthRequest, Builder>.PrintField("AuthTicket", this.hasAuthTicket, this.authTicket_, writer);
            GeneratedMessageLite<NewAuthRequest, Builder>.PrintField("RealCountry", this.hasRealCountry, this.realCountry_, writer);
            GeneratedMessageLite<NewAuthRequest, Builder>.PrintField("Signature", this.hasSignature, this.signature_, writer);
            GeneratedMessageLite<NewAuthRequest, Builder>.PrintField("RandomEncryKey", this.hasRandomEncryKey, this.randomEncryKey_, writer);
            GeneratedMessageLite<NewAuthRequest, Builder>.PrintField("AutoAuthTicket", this.hasAutoAuthTicket, this.autoAuthTicket_, writer);
            GeneratedMessageLite<NewAuthRequest, Builder>.PrintField("DeviceName", this.hasDeviceName, this.deviceName_, writer);
            GeneratedMessageLite<NewAuthRequest, Builder>.PrintField("WTLoginReqBuff", this.hasWTLoginReqBuff, this.wTLoginReqBuff_, writer);
            GeneratedMessageLite<NewAuthRequest, Builder>.PrintField("InputType", this.hasInputType, this.inputType_, writer);
            GeneratedMessageLite<NewAuthRequest, Builder>.PrintField("ClientSeqID", this.hasClientSeqID, this.clientSeqID_, writer);
            GeneratedMessageLite<NewAuthRequest, Builder>.PrintField("BundleID", this.hasBundleID, this.bundleID_, writer);
            GeneratedMessageLite<NewAuthRequest, Builder>.PrintField("AdSource", this.hasAdSource, this.adSource_, writer);
            GeneratedMessageLite<NewAuthRequest, Builder>.PrintField("CliDBEncryptKey", this.hasCliDBEncryptKey, this.cliDBEncryptKey_, writer);
            GeneratedMessageLite<NewAuthRequest, Builder>.PrintField("CliDBEncryptInfo", this.hasCliDBEncryptInfo, this.cliDBEncryptInfo_, writer);
            GeneratedMessageLite<NewAuthRequest, Builder>.PrintField("VerifySignature", this.hasVerifySignature, this.verifySignature_, writer);
            GeneratedMessageLite<NewAuthRequest, Builder>.PrintField("VerifyContent", this.hasVerifyContent, this.verifyContent_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _NewAuthRequestFieldNames;
            if (this.hasBaseRequest)
            {
                output.WriteMessage(1, strArray[3], this.BaseRequest);
            }
            if (this.hasUserName)
            {
                output.WriteMessage(2, strArray[0x1f], this.UserName);
            }
            if (this.hasPwd)
            {
                output.WriteMessage(3, strArray[0x17], this.Pwd);
            }
            if (this.hasImgSid)
            {
                output.WriteMessage(4, strArray[0x12], this.ImgSid);
            }
            if (this.hasImgCode)
            {
                output.WriteMessage(5, strArray[0x10], this.ImgCode);
            }
            if (this.hasPwd2)
            {
                output.WriteString(6, strArray[0x18], this.Pwd2);
            }
            if (this.hasBuiltinIPSeq)
            {
                output.WriteUInt32(7, strArray[4], this.BuiltinIPSeq);
            }
            if (this.hasExtPwd)
            {
                output.WriteString(8, strArray[0x23], this.ExtPwd);
            }
            if (this.hasExtPwd2)
            {
                output.WriteString(9, strArray[0x24], this.ExtPwd2);
            }
            if (this.hasTimeZone)
            {
                output.WriteString(10, strArray[30], this.TimeZone);
            }
            if (this.hasLanguage)
            {
                output.WriteString(11, strArray[0x15], this.Language);
            }
            if (this.hasIMEI)
            {
                output.WriteString(12, strArray[14], this.IMEI);
            }
            if (this.hasChannel)
            {
                output.WriteInt32(13, strArray[6], this.Channel);
            }
            if (this.hasIPhoneVer)
            {
                output.WriteString(14, strArray[15], this.IPhoneVer);
            }
            if (this.hasImgEncryptKey)
            {
                output.WriteMessage(15, strArray[0x11], this.ImgEncryptKey);
            }
            if (this.hasKSid)
            {
                output.WriteMessage(0x10, strArray[20], this.KSid);
            }
            if (this.hasTimeStamp)
            {
                output.WriteUInt32(0x11, strArray[0x1d], this.TimeStamp);
            }
            if (this.hasDeviceBrand)
            {
                output.WriteString(0x12, strArray[10], this.DeviceBrand);
            }
            if (this.hasDeviceModel)
            {
                output.WriteString(0x13, strArray[11], this.DeviceModel);
            }
            if (this.hasOSType)
            {
                output.WriteString(20, strArray[0x16], this.OSType);
            }
            if (this.hasDeviceType)
            {
                output.WriteString(0x15, strArray[13], this.DeviceType);
            }
            if (this.hasSoftType)
            {
                output.WriteString(0x16, strArray[0x1c], this.SoftType);
            }
            if (this.hasAuthTicket)
            {
                output.WriteString(0x17, strArray[1], this.AuthTicket);
            }
            if (this.hasRealCountry)
            {
                output.WriteString(0x18, strArray[0x1a], this.RealCountry);
            }
            if (this.hasSignature)
            {
                output.WriteString(0x19, strArray[0x1b], this.Signature);
            }
            if (this.hasRandomEncryKey)
            {
                output.WriteMessage(0x1a, strArray[0x19], this.RandomEncryKey);
            }
            if (this.hasAutoAuthTicket)
            {
                output.WriteString(0x1b, strArray[2], this.AutoAuthTicket);
            }
            if (this.hasDeviceName)
            {
                output.WriteString(0x1c, strArray[12], this.DeviceName);
            }
            if (this.hasWTLoginReqBuff)
            {
                output.WriteMessage(0x1d, strArray[0x22], this.WTLoginReqBuff);
            }
            if (this.hasInputType)
            {
                output.WriteUInt32(30, strArray[0x13], this.InputType);
            }
            if (this.hasClientSeqID)
            {
                output.WriteString(0x1f, strArray[9], this.ClientSeqID);
            }
            if (this.hasBundleID)
            {
                output.WriteString(0x20, strArray[5], this.BundleID);
            }
            if (this.hasAdSource)
            {
                output.WriteString(0x21, strArray[0], this.AdSource);
            }
            if (this.hasCliDBEncryptKey)
            {
                output.WriteMessage(0x22, strArray[8], this.CliDBEncryptKey);
            }
            if (this.hasCliDBEncryptInfo)
            {
                output.WriteMessage(0x23, strArray[7], this.CliDBEncryptInfo);
            }
            if (this.hasVerifySignature)
            {
                output.WriteString(0x24, strArray[0x21], this.VerifySignature);
            }
            if (this.hasVerifyContent)
            {
                output.WriteString(0x25, strArray[0x20], this.VerifyContent);
            }
        }

        public string AdSource
        {
            get
            {
                return this.adSource_;
            }
        }

        public string AuthTicket
        {
            get
            {
                return this.authTicket_;
            }
        }

        public string AutoAuthTicket
        {
            get
            {
                return this.autoAuthTicket_;
            }
        }

        public BaseRequest BaseRequest
        {
            get
            {
                return (this.baseRequest_ ?? BaseRequest.DefaultInstance);
            }
        }

        public uint BuiltinIPSeq
        {
            get
            {
                return this.builtinIPSeq_;
            }
        }

        public string BundleID
        {
            get
            {
                return this.bundleID_;
            }
        }

        public int Channel
        {
            get
            {
                return this.channel_;
            }
        }

        public SKBuiltinBuffer_t CliDBEncryptInfo
        {
            get
            {
                return (this.cliDBEncryptInfo_ ?? SKBuiltinBuffer_t.DefaultInstance);
            }
        }

        public SKBuiltinBuffer_t CliDBEncryptKey
        {
            get
            {
                return (this.cliDBEncryptKey_ ?? SKBuiltinBuffer_t.DefaultInstance);
            }
        }

        public string ClientSeqID
        {
            get
            {
                return this.clientSeqID_;
            }
        }

        public static NewAuthRequest DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override NewAuthRequest DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public string DeviceBrand
        {
            get
            {
                return this.deviceBrand_;
            }
        }

        public string DeviceModel
        {
            get
            {
                return this.deviceModel_;
            }
        }

        public string DeviceName
        {
            get
            {
                return this.deviceName_;
            }
        }

        public string DeviceType
        {
            get
            {
                return this.deviceType_;
            }
        }

        public string ExtPwd
        {
            get
            {
                return this.extPwd_;
            }
        }

        public string ExtPwd2
        {
            get
            {
                return this.extPwd2_;
            }
        }

        public string IMEI
        {
            get
            {
                return this.iMEI_;
            }
        }

        public SKBuiltinString_t ImgCode
        {
            get
            {
                return (this.imgCode_ ?? SKBuiltinString_t.DefaultInstance);
            }
        }

        public SKBuiltinString_t ImgEncryptKey
        {
            get
            {
                return (this.imgEncryptKey_ ?? SKBuiltinString_t.DefaultInstance);
            }
        }

        public SKBuiltinString_t ImgSid
        {
            get
            {
                return (this.imgSid_ ?? SKBuiltinString_t.DefaultInstance);
            }
        }

        public uint InputType
        {
            get
            {
                return this.inputType_;
            }
        }

        public string IPhoneVer
        {
            get
            {
                return this.iPhoneVer_;
            }
        }

        public override bool IsInitialized
        {
            get
            {
                if (!this.hasBaseRequest)
                {
                    return false;
                }
                if (!this.hasUserName)
                {
                    return false;
                }
                if (!this.hasPwd)
                {
                    return false;
                }
                if (!this.hasImgSid)
                {
                    return false;
                }
                if (!this.hasImgCode)
                {
                    return false;
                }
                if (!this.hasRandomEncryKey)
                {
                    return false;
                }
                if (!this.BaseRequest.IsInitialized)
                {
                    return false;
                }
                if (!this.RandomEncryKey.IsInitialized)
                {
                    return false;
                }
                return true;
            }
        }

        public SKBuiltinBuffer_t KSid
        {
            get
            {
                return (this.kSid_ ?? SKBuiltinBuffer_t.DefaultInstance);
            }
        }

        public string Language
        {
            get
            {
                return this.language_;
            }
        }

        public string OSType
        {
            get
            {
                return this.oSType_;
            }
        }

        public SKBuiltinString_t Pwd
        {
            get
            {
                return (this.pwd_ ?? SKBuiltinString_t.DefaultInstance);
            }
        }

        public string Pwd2
        {
            get
            {
                return this.pwd2_;
            }
        }

        public SKBuiltinBuffer_t RandomEncryKey
        {
            get
            {
                return (this.randomEncryKey_ ?? SKBuiltinBuffer_t.DefaultInstance);
            }
        }

        public string RealCountry
        {
            get
            {
                return this.realCountry_;
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
                    if (this.hasBaseRequest)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(1, this.BaseRequest);
                    }
                    if (this.hasUserName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(2, this.UserName);
                    }
                    if (this.hasPwd)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(3, this.Pwd);
                    }
                    if (this.hasImgSid)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(4, this.ImgSid);
                    }
                    if (this.hasImgCode)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(5, this.ImgCode);
                    }
                    if (this.hasPwd2)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(6, this.Pwd2);
                    }
                    if (this.hasBuiltinIPSeq)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(7, this.BuiltinIPSeq);
                    }
                    if (this.hasExtPwd)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(8, this.ExtPwd);
                    }
                    if (this.hasExtPwd2)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(9, this.ExtPwd2);
                    }
                    if (this.hasTimeZone)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(10, this.TimeZone);
                    }
                    if (this.hasLanguage)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(11, this.Language);
                    }
                    if (this.hasIMEI)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(12, this.IMEI);
                    }
                    if (this.hasChannel)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(13, this.Channel);
                    }
                    if (this.hasIPhoneVer)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(14, this.IPhoneVer);
                    }
                    if (this.hasImgEncryptKey)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(15, this.ImgEncryptKey);
                    }
                    if (this.hasKSid)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(0x10, this.KSid);
                    }
                    if (this.hasTimeStamp)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(0x11, this.TimeStamp);
                    }
                    if (this.hasDeviceBrand)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x12, this.DeviceBrand);
                    }
                    if (this.hasDeviceModel)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x13, this.DeviceModel);
                    }
                    if (this.hasOSType)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(20, this.OSType);
                    }
                    if (this.hasDeviceType)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x15, this.DeviceType);
                    }
                    if (this.hasSoftType)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x16, this.SoftType);
                    }
                    if (this.hasAuthTicket)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x17, this.AuthTicket);
                    }
                    if (this.hasRealCountry)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x18, this.RealCountry);
                    }
                    if (this.hasSignature)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x19, this.Signature);
                    }
                    if (this.hasRandomEncryKey)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(0x1a, this.RandomEncryKey);
                    }
                    if (this.hasAutoAuthTicket)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x1b, this.AutoAuthTicket);
                    }
                    if (this.hasDeviceName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x1c, this.DeviceName);
                    }
                    if (this.hasWTLoginReqBuff)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(0x1d, this.WTLoginReqBuff);
                    }
                    if (this.hasInputType)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(30, this.InputType);
                    }
                    if (this.hasClientSeqID)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x1f, this.ClientSeqID);
                    }
                    if (this.hasBundleID)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x20, this.BundleID);
                    }
                    if (this.hasAdSource)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x21, this.AdSource);
                    }
                    if (this.hasCliDBEncryptKey)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(0x22, this.CliDBEncryptKey);
                    }
                    if (this.hasCliDBEncryptInfo)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(0x23, this.CliDBEncryptInfo);
                    }
                    if (this.hasVerifySignature)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x24, this.VerifySignature);
                    }
                    if (this.hasVerifyContent)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x25, this.VerifyContent);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        public string Signature
        {
            get
            {
                return this.signature_;
            }
        }

        public string SoftType
        {
            get
            {
                return this.softType_;
            }
        }

        protected override NewAuthRequest ThisMessage
        {
            get
            {
                return this;
            }
        }

        public uint TimeStamp
        {
            get
            {
                return this.timeStamp_;
            }
        }

        public string TimeZone
        {
            get
            {
                return this.timeZone_;
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

        public string VerifySignature
        {
            get
            {
                return this.verifySignature_;
            }
        }

        public SKBuiltinBuffer_t WTLoginReqBuff
        {
            get
            {
                return (this.wTLoginReqBuff_ ?? SKBuiltinBuffer_t.DefaultInstance);
            }
        }

        [GeneratedCode("ProtoGen", "2.3.0.277"), DebuggerNonUserCode, CompilerGenerated]
        public sealed class Builder : GeneratedBuilderLite<NewAuthRequest, NewAuthRequest.Builder>
        {
            private NewAuthRequest result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = NewAuthRequest.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(NewAuthRequest cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override NewAuthRequest BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override NewAuthRequest.Builder Clear()
            {
                this.result = NewAuthRequest.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public NewAuthRequest.Builder ClearAdSource()
            {
                this.PrepareBuilder();
                this.result.hasAdSource = false;
                this.result.adSource_ = "";
                return this;
            }

            public NewAuthRequest.Builder ClearAuthTicket()
            {
                this.PrepareBuilder();
                this.result.hasAuthTicket = false;
                this.result.authTicket_ = "";
                return this;
            }

            public NewAuthRequest.Builder ClearAutoAuthTicket()
            {
                this.PrepareBuilder();
                this.result.hasAutoAuthTicket = false;
                this.result.autoAuthTicket_ = "";
                return this;
            }

            public NewAuthRequest.Builder ClearBaseRequest()
            {
                this.PrepareBuilder();
                this.result.hasBaseRequest = false;
                this.result.baseRequest_ = null;
                return this;
            }

            public NewAuthRequest.Builder ClearBuiltinIPSeq()
            {
                this.PrepareBuilder();
                this.result.hasBuiltinIPSeq = false;
                this.result.builtinIPSeq_ = 0;
                return this;
            }

            public NewAuthRequest.Builder ClearBundleID()
            {
                this.PrepareBuilder();
                this.result.hasBundleID = false;
                this.result.bundleID_ = "";
                return this;
            }

            public NewAuthRequest.Builder ClearChannel()
            {
                this.PrepareBuilder();
                this.result.hasChannel = false;
                this.result.channel_ = 0;
                return this;
            }

            public NewAuthRequest.Builder ClearCliDBEncryptInfo()
            {
                this.PrepareBuilder();
                this.result.hasCliDBEncryptInfo = false;
                this.result.cliDBEncryptInfo_ = null;
                return this;
            }

            public NewAuthRequest.Builder ClearCliDBEncryptKey()
            {
                this.PrepareBuilder();
                this.result.hasCliDBEncryptKey = false;
                this.result.cliDBEncryptKey_ = null;
                return this;
            }

            public NewAuthRequest.Builder ClearClientSeqID()
            {
                this.PrepareBuilder();
                this.result.hasClientSeqID = false;
                this.result.clientSeqID_ = "";
                return this;
            }

            public NewAuthRequest.Builder ClearDeviceBrand()
            {
                this.PrepareBuilder();
                this.result.hasDeviceBrand = false;
                this.result.deviceBrand_ = "";
                return this;
            }

            public NewAuthRequest.Builder ClearDeviceModel()
            {
                this.PrepareBuilder();
                this.result.hasDeviceModel = false;
                this.result.deviceModel_ = "";
                return this;
            }

            public NewAuthRequest.Builder ClearDeviceName()
            {
                this.PrepareBuilder();
                this.result.hasDeviceName = false;
                this.result.deviceName_ = "";
                return this;
            }

            public NewAuthRequest.Builder ClearDeviceType()
            {
                this.PrepareBuilder();
                this.result.hasDeviceType = false;
                this.result.deviceType_ = "";
                return this;
            }

            public NewAuthRequest.Builder ClearExtPwd()
            {
                this.PrepareBuilder();
                this.result.hasExtPwd = false;
                this.result.extPwd_ = "";
                return this;
            }

            public NewAuthRequest.Builder ClearExtPwd2()
            {
                this.PrepareBuilder();
                this.result.hasExtPwd2 = false;
                this.result.extPwd2_ = "";
                return this;
            }

            public NewAuthRequest.Builder ClearIMEI()
            {
                this.PrepareBuilder();
                this.result.hasIMEI = false;
                this.result.iMEI_ = "";
                return this;
            }

            public NewAuthRequest.Builder ClearImgCode()
            {
                this.PrepareBuilder();
                this.result.hasImgCode = false;
                this.result.imgCode_ = null;
                return this;
            }

            public NewAuthRequest.Builder ClearImgEncryptKey()
            {
                this.PrepareBuilder();
                this.result.hasImgEncryptKey = false;
                this.result.imgEncryptKey_ = null;
                return this;
            }

            public NewAuthRequest.Builder ClearImgSid()
            {
                this.PrepareBuilder();
                this.result.hasImgSid = false;
                this.result.imgSid_ = null;
                return this;
            }

            public NewAuthRequest.Builder ClearInputType()
            {
                this.PrepareBuilder();
                this.result.hasInputType = false;
                this.result.inputType_ = 0;
                return this;
            }

            public NewAuthRequest.Builder ClearIPhoneVer()
            {
                this.PrepareBuilder();
                this.result.hasIPhoneVer = false;
                this.result.iPhoneVer_ = "";
                return this;
            }

            public NewAuthRequest.Builder ClearKSid()
            {
                this.PrepareBuilder();
                this.result.hasKSid = false;
                this.result.kSid_ = null;
                return this;
            }

            public NewAuthRequest.Builder ClearLanguage()
            {
                this.PrepareBuilder();
                this.result.hasLanguage = false;
                this.result.language_ = "";
                return this;
            }

            public NewAuthRequest.Builder ClearOSType()
            {
                this.PrepareBuilder();
                this.result.hasOSType = false;
                this.result.oSType_ = "";
                return this;
            }

            public NewAuthRequest.Builder ClearPwd()
            {
                this.PrepareBuilder();
                this.result.hasPwd = false;
                this.result.pwd_ = null;
                return this;
            }

            public NewAuthRequest.Builder ClearPwd2()
            {
                this.PrepareBuilder();
                this.result.hasPwd2 = false;
                this.result.pwd2_ = "";
                return this;
            }

            public NewAuthRequest.Builder ClearRandomEncryKey()
            {
                this.PrepareBuilder();
                this.result.hasRandomEncryKey = false;
                this.result.randomEncryKey_ = null;
                return this;
            }

            public NewAuthRequest.Builder ClearRealCountry()
            {
                this.PrepareBuilder();
                this.result.hasRealCountry = false;
                this.result.realCountry_ = "";
                return this;
            }

            public NewAuthRequest.Builder ClearSignature()
            {
                this.PrepareBuilder();
                this.result.hasSignature = false;
                this.result.signature_ = "";
                return this;
            }

            public NewAuthRequest.Builder ClearSoftType()
            {
                this.PrepareBuilder();
                this.result.hasSoftType = false;
                this.result.softType_ = "";
                return this;
            }

            public NewAuthRequest.Builder ClearTimeStamp()
            {
                this.PrepareBuilder();
                this.result.hasTimeStamp = false;
                this.result.timeStamp_ = 0;
                return this;
            }

            public NewAuthRequest.Builder ClearTimeZone()
            {
                this.PrepareBuilder();
                this.result.hasTimeZone = false;
                this.result.timeZone_ = "";
                return this;
            }

            public NewAuthRequest.Builder ClearUserName()
            {
                this.PrepareBuilder();
                this.result.hasUserName = false;
                this.result.userName_ = null;
                return this;
            }

            public NewAuthRequest.Builder ClearVerifyContent()
            {
                this.PrepareBuilder();
                this.result.hasVerifyContent = false;
                this.result.verifyContent_ = "";
                return this;
            }

            public NewAuthRequest.Builder ClearVerifySignature()
            {
                this.PrepareBuilder();
                this.result.hasVerifySignature = false;
                this.result.verifySignature_ = "";
                return this;
            }

            public NewAuthRequest.Builder ClearWTLoginReqBuff()
            {
                this.PrepareBuilder();
                this.result.hasWTLoginReqBuff = false;
                this.result.wTLoginReqBuff_ = null;
                return this;
            }

            public override NewAuthRequest.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new NewAuthRequest.Builder(this.result);
                }
                return new NewAuthRequest.Builder().MergeFrom(this.result);
            }

            public NewAuthRequest.Builder MergeBaseRequest(BaseRequest value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasBaseRequest && (this.result.baseRequest_ != BaseRequest.DefaultInstance))
                {
                    this.result.baseRequest_ = BaseRequest.CreateBuilder(this.result.baseRequest_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.baseRequest_ = value;
                }
                this.result.hasBaseRequest = true;
                return this;
            }

            public NewAuthRequest.Builder MergeCliDBEncryptInfo(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasCliDBEncryptInfo && (this.result.cliDBEncryptInfo_ != SKBuiltinBuffer_t.DefaultInstance))
                {
                    this.result.cliDBEncryptInfo_ = SKBuiltinBuffer_t.CreateBuilder(this.result.cliDBEncryptInfo_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.cliDBEncryptInfo_ = value;
                }
                this.result.hasCliDBEncryptInfo = true;
                return this;
            }

            public NewAuthRequest.Builder MergeCliDBEncryptKey(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasCliDBEncryptKey && (this.result.cliDBEncryptKey_ != SKBuiltinBuffer_t.DefaultInstance))
                {
                    this.result.cliDBEncryptKey_ = SKBuiltinBuffer_t.CreateBuilder(this.result.cliDBEncryptKey_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.cliDBEncryptKey_ = value;
                }
                this.result.hasCliDBEncryptKey = true;
                return this;
            }

            public override NewAuthRequest.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override NewAuthRequest.Builder MergeFrom(IMessageLite other)
            {
                if (other is NewAuthRequest)
                {
                    return this.MergeFrom((NewAuthRequest)other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override NewAuthRequest.Builder MergeFrom(NewAuthRequest other)
            {
                return this;
            }

            public override NewAuthRequest.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(NewAuthRequest._NewAuthRequestFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = NewAuthRequest._NewAuthRequestFieldTags[index];
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
                                if (this.result.hasUserName)
                                {
                                    builder2.MergeFrom(this.UserName);
                                }
                                input.ReadMessage(builder2, extensionRegistry);
                                this.UserName = builder2.BuildPartial();
                                continue;
                            }
                        case 0x1a:
                            {
                                SKBuiltinString_t.Builder builder3 = SKBuiltinString_t.CreateBuilder();
                                if (this.result.hasPwd)
                                {
                                    builder3.MergeFrom(this.Pwd);
                                }
                                input.ReadMessage(builder3, extensionRegistry);
                                this.Pwd = builder3.BuildPartial();
                                continue;
                            }
                        case 0:
                            throw InvalidProtocolBufferException.InvalidTag();

                        case 10:
                            {
                                BaseRequest.Builder builder = BaseRequest.CreateBuilder();
                                if (this.result.hasBaseRequest)
                                {
                                    builder.MergeFrom(this.BaseRequest);
                                }
                                input.ReadMessage(builder, extensionRegistry);
                                this.BaseRequest = builder.BuildPartial();
                                continue;
                            }
                        case 0x22:
                            {
                                SKBuiltinString_t.Builder builder4 = SKBuiltinString_t.CreateBuilder();
                                if (this.result.hasImgSid)
                                {
                                    builder4.MergeFrom(this.ImgSid);
                                }
                                input.ReadMessage(builder4, extensionRegistry);
                                this.ImgSid = builder4.BuildPartial();
                                continue;
                            }
                        case 0x2a:
                            {
                                SKBuiltinString_t.Builder builder5 = SKBuiltinString_t.CreateBuilder();
                                if (this.result.hasImgCode)
                                {
                                    builder5.MergeFrom(this.ImgCode);
                                }
                                input.ReadMessage(builder5, extensionRegistry);
                                this.ImgCode = builder5.BuildPartial();
                                continue;
                            }
                        case 50:
                            {
                                this.result.hasPwd2 = input.ReadString(ref this.result.pwd2_);
                                continue;
                            }
                        case 0x38:
                            {
                                this.result.hasBuiltinIPSeq = input.ReadUInt32(ref this.result.builtinIPSeq_);
                                continue;
                            }
                        case 0x42:
                            {
                                this.result.hasExtPwd = input.ReadString(ref this.result.extPwd_);
                                continue;
                            }
                        case 90:
                            {
                                this.result.hasLanguage = input.ReadString(ref this.result.language_);
                                continue;
                            }
                        case 0x62:
                            {
                                this.result.hasIMEI = input.ReadString(ref this.result.iMEI_);
                                continue;
                            }
                        case 0x68:
                            {
                                this.result.hasChannel = input.ReadInt32(ref this.result.channel_);
                                continue;
                            }
                        case 0x4a:
                            {
                                this.result.hasExtPwd2 = input.ReadString(ref this.result.extPwd2_);
                                continue;
                            }
                        case 0x52:
                            {
                                this.result.hasTimeZone = input.ReadString(ref this.result.timeZone_);
                                continue;
                            }
                        case 0x72:
                            {
                                this.result.hasIPhoneVer = input.ReadString(ref this.result.iPhoneVer_);
                                continue;
                            }
                        case 0x7a:
                            {
                                SKBuiltinString_t.Builder builder6 = SKBuiltinString_t.CreateBuilder();
                                if (this.result.hasImgEncryptKey)
                                {
                                    builder6.MergeFrom(this.ImgEncryptKey);
                                }
                                input.ReadMessage(builder6, extensionRegistry);
                                this.ImgEncryptKey = builder6.BuildPartial();
                                continue;
                            }
                        case 130:
                            {
                                SKBuiltinBuffer_t.Builder builder7 = SKBuiltinBuffer_t.CreateBuilder();
                                if (this.result.hasKSid)
                                {
                                    builder7.MergeFrom(this.KSid);
                                }
                                input.ReadMessage(builder7, extensionRegistry);
                                this.KSid = builder7.BuildPartial();
                                continue;
                            }
                        case 0x88:
                            {
                                this.result.hasTimeStamp = input.ReadUInt32(ref this.result.timeStamp_);
                                continue;
                            }
                        case 0x92:
                            {
                                this.result.hasDeviceBrand = input.ReadString(ref this.result.deviceBrand_);
                                continue;
                            }
                        case 170:
                            {
                                this.result.hasDeviceType = input.ReadString(ref this.result.deviceType_);
                                continue;
                            }
                        case 0xb2:
                            {
                                this.result.hasSoftType = input.ReadString(ref this.result.softType_);
                                continue;
                            }
                        case 0x9a:
                            {
                                this.result.hasDeviceModel = input.ReadString(ref this.result.deviceModel_);
                                continue;
                            }
                        case 0xa2:
                            {
                                this.result.hasOSType = input.ReadString(ref this.result.oSType_);
                                continue;
                            }
                        case 0xba:
                            {
                                this.result.hasAuthTicket = input.ReadString(ref this.result.authTicket_);
                                continue;
                            }
                        case 0xc2:
                            {
                                this.result.hasRealCountry = input.ReadString(ref this.result.realCountry_);
                                continue;
                            }
                        case 0xca:
                            {
                                this.result.hasSignature = input.ReadString(ref this.result.signature_);
                                continue;
                            }
                        case 210:
                            {
                                SKBuiltinBuffer_t.Builder builder8 = SKBuiltinBuffer_t.CreateBuilder();
                                if (this.result.hasRandomEncryKey)
                                {
                                    builder8.MergeFrom(this.RandomEncryKey);
                                }
                                input.ReadMessage(builder8, extensionRegistry);
                                this.RandomEncryKey = builder8.BuildPartial();
                                continue;
                            }
                        case 0xda:
                            {
                                this.result.hasAutoAuthTicket = input.ReadString(ref this.result.autoAuthTicket_);
                                continue;
                            }
                        case 240:
                            {
                                this.result.hasInputType = input.ReadUInt32(ref this.result.inputType_);
                                continue;
                            }
                        case 250:
                            {
                                this.result.hasClientSeqID = input.ReadString(ref this.result.clientSeqID_);
                                continue;
                            }
                        case 0x102:
                            {
                                this.result.hasBundleID = input.ReadString(ref this.result.bundleID_);
                                continue;
                            }
                        case 0xe2:
                            {
                                this.result.hasDeviceName = input.ReadString(ref this.result.deviceName_);
                                continue;
                            }
                        case 0xea:
                            {
                                SKBuiltinBuffer_t.Builder builder9 = SKBuiltinBuffer_t.CreateBuilder();
                                if (this.result.hasWTLoginReqBuff)
                                {
                                    builder9.MergeFrom(this.WTLoginReqBuff);
                                }
                                input.ReadMessage(builder9, extensionRegistry);
                                this.WTLoginReqBuff = builder9.BuildPartial();
                                continue;
                            }
                        case 0x10a:
                            {
                                this.result.hasAdSource = input.ReadString(ref this.result.adSource_);
                                continue;
                            }
                        case 0x112:
                            {
                                SKBuiltinBuffer_t.Builder builder10 = SKBuiltinBuffer_t.CreateBuilder();
                                if (this.result.hasCliDBEncryptKey)
                                {
                                    builder10.MergeFrom(this.CliDBEncryptKey);
                                }
                                input.ReadMessage(builder10, extensionRegistry);
                                this.CliDBEncryptKey = builder10.BuildPartial();
                                continue;
                            }
                        case 0x11a:
                            {
                                SKBuiltinBuffer_t.Builder builder11 = SKBuiltinBuffer_t.CreateBuilder();
                                if (this.result.hasCliDBEncryptInfo)
                                {
                                    builder11.MergeFrom(this.CliDBEncryptInfo);
                                }
                                input.ReadMessage(builder11, extensionRegistry);
                                this.CliDBEncryptInfo = builder11.BuildPartial();
                                continue;
                            }
                        case 290:
                            {
                                this.result.hasVerifySignature = input.ReadString(ref this.result.verifySignature_);
                                continue;
                            }
                        case 0x12a:
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
                    this.result.hasVerifyContent = input.ReadString(ref this.result.verifyContent_);
                }
                return this;
            }

            public NewAuthRequest.Builder MergeImgCode(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasImgCode && (this.result.imgCode_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.imgCode_ = SKBuiltinString_t.CreateBuilder(this.result.imgCode_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.imgCode_ = value;
                }
                this.result.hasImgCode = true;
                return this;
            }

            public NewAuthRequest.Builder MergeImgEncryptKey(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasImgEncryptKey && (this.result.imgEncryptKey_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.imgEncryptKey_ = SKBuiltinString_t.CreateBuilder(this.result.imgEncryptKey_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.imgEncryptKey_ = value;
                }
                this.result.hasImgEncryptKey = true;
                return this;
            }

            public NewAuthRequest.Builder MergeImgSid(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasImgSid && (this.result.imgSid_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.imgSid_ = SKBuiltinString_t.CreateBuilder(this.result.imgSid_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.imgSid_ = value;
                }
                this.result.hasImgSid = true;
                return this;
            }

            public NewAuthRequest.Builder MergeKSid(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasKSid && (this.result.kSid_ != SKBuiltinBuffer_t.DefaultInstance))
                {
                    this.result.kSid_ = SKBuiltinBuffer_t.CreateBuilder(this.result.kSid_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.kSid_ = value;
                }
                this.result.hasKSid = true;
                return this;
            }

            public NewAuthRequest.Builder MergePwd(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasPwd && (this.result.pwd_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.pwd_ = SKBuiltinString_t.CreateBuilder(this.result.pwd_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.pwd_ = value;
                }
                this.result.hasPwd = true;
                return this;
            }

            public NewAuthRequest.Builder MergeRandomEncryKey(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasRandomEncryKey && (this.result.randomEncryKey_ != SKBuiltinBuffer_t.DefaultInstance))
                {
                    this.result.randomEncryKey_ = SKBuiltinBuffer_t.CreateBuilder(this.result.randomEncryKey_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.randomEncryKey_ = value;
                }
                this.result.hasRandomEncryKey = true;
                return this;
            }

            public NewAuthRequest.Builder MergeUserName(SKBuiltinString_t value)
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

            public NewAuthRequest.Builder MergeWTLoginReqBuff(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasWTLoginReqBuff && (this.result.wTLoginReqBuff_ != SKBuiltinBuffer_t.DefaultInstance))
                {
                    this.result.wTLoginReqBuff_ = SKBuiltinBuffer_t.CreateBuilder(this.result.wTLoginReqBuff_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.wTLoginReqBuff_ = value;
                }
                this.result.hasWTLoginReqBuff = true;
                return this;
            }

            private NewAuthRequest PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    NewAuthRequest result = this.result;
                    this.result = new NewAuthRequest();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public NewAuthRequest.Builder SetAdSource(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasAdSource = true;
                this.result.adSource_ = value;
                return this;
            }

            public NewAuthRequest.Builder SetAuthTicket(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasAuthTicket = true;
                this.result.authTicket_ = value;
                return this;
            }

            public NewAuthRequest.Builder SetAutoAuthTicket(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasAutoAuthTicket = true;
                this.result.autoAuthTicket_ = value;
                return this;
            }

            public NewAuthRequest.Builder SetBaseRequest(BaseRequest value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = value;
                return this;
            }

            public NewAuthRequest.Builder SetBaseRequest(BaseRequest.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = builderForValue.Build();
                return this;
            }

            public NewAuthRequest.Builder SetBuiltinIPSeq(uint value)
            {
                this.PrepareBuilder();
                this.result.hasBuiltinIPSeq = true;
                this.result.builtinIPSeq_ = value;
                return this;
            }

            public NewAuthRequest.Builder SetBundleID(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBundleID = true;
                this.result.bundleID_ = value;
                return this;
            }

            public NewAuthRequest.Builder SetChannel(int value)
            {
                this.PrepareBuilder();
                this.result.hasChannel = true;
                this.result.channel_ = value;
                return this;
            }

            public NewAuthRequest.Builder SetCliDBEncryptInfo(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasCliDBEncryptInfo = true;
                this.result.cliDBEncryptInfo_ = value;
                return this;
            }

            public NewAuthRequest.Builder SetCliDBEncryptInfo(SKBuiltinBuffer_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasCliDBEncryptInfo = true;
                this.result.cliDBEncryptInfo_ = builderForValue.Build();
                return this;
            }

            public NewAuthRequest.Builder SetCliDBEncryptKey(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasCliDBEncryptKey = true;
                this.result.cliDBEncryptKey_ = value;
                return this;
            }

            public NewAuthRequest.Builder SetCliDBEncryptKey(SKBuiltinBuffer_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasCliDBEncryptKey = true;
                this.result.cliDBEncryptKey_ = builderForValue.Build();
                return this;
            }

            public NewAuthRequest.Builder SetClientSeqID(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasClientSeqID = true;
                this.result.clientSeqID_ = value;
                return this;
            }

            public NewAuthRequest.Builder SetDeviceBrand(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasDeviceBrand = true;
                this.result.deviceBrand_ = value;
                return this;
            }

            public NewAuthRequest.Builder SetDeviceModel(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasDeviceModel = true;
                this.result.deviceModel_ = value;
                return this;
            }

            public NewAuthRequest.Builder SetDeviceName(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasDeviceName = true;
                this.result.deviceName_ = value;
                return this;
            }

            public NewAuthRequest.Builder SetDeviceType(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasDeviceType = true;
                this.result.deviceType_ = value;
                return this;
            }

            public NewAuthRequest.Builder SetExtPwd(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasExtPwd = true;
                this.result.extPwd_ = value;
                return this;
            }

            public NewAuthRequest.Builder SetExtPwd2(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasExtPwd2 = true;
                this.result.extPwd2_ = value;
                return this;
            }

            public NewAuthRequest.Builder SetIMEI(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasIMEI = true;
                this.result.iMEI_ = value;
                return this;
            }

            public NewAuthRequest.Builder SetImgCode(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasImgCode = true;
                this.result.imgCode_ = value;
                return this;
            }

            public NewAuthRequest.Builder SetImgCode(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasImgCode = true;
                this.result.imgCode_ = builderForValue.Build();
                return this;
            }

            public NewAuthRequest.Builder SetImgEncryptKey(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasImgEncryptKey = true;
                this.result.imgEncryptKey_ = value;
                return this;
            }

            public NewAuthRequest.Builder SetImgEncryptKey(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasImgEncryptKey = true;
                this.result.imgEncryptKey_ = builderForValue.Build();
                return this;
            }

            public NewAuthRequest.Builder SetImgSid(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasImgSid = true;
                this.result.imgSid_ = value;
                return this;
            }

            public NewAuthRequest.Builder SetImgSid(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasImgSid = true;
                this.result.imgSid_ = builderForValue.Build();
                return this;
            }

            public NewAuthRequest.Builder SetInputType(uint value)
            {
                this.PrepareBuilder();
                this.result.hasInputType = true;
                this.result.inputType_ = value;
                return this;
            }

            public NewAuthRequest.Builder SetIPhoneVer(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasIPhoneVer = true;
                this.result.iPhoneVer_ = value;
                return this;
            }

            public NewAuthRequest.Builder SetKSid(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasKSid = true;
                this.result.kSid_ = value;
                return this;
            }

            public NewAuthRequest.Builder SetKSid(SKBuiltinBuffer_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasKSid = true;
                this.result.kSid_ = builderForValue.Build();
                return this;
            }

            public NewAuthRequest.Builder SetLanguage(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasLanguage = true;
                this.result.language_ = value;
                return this;
            }

            public NewAuthRequest.Builder SetOSType(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasOSType = true;
                this.result.oSType_ = value;
                return this;
            }

            public NewAuthRequest.Builder SetPwd(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasPwd = true;
                this.result.pwd_ = value;
                return this;
            }

            public NewAuthRequest.Builder SetPwd(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasPwd = true;
                this.result.pwd_ = builderForValue.Build();
                return this;
            }

            public NewAuthRequest.Builder SetPwd2(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasPwd2 = true;
                this.result.pwd2_ = value;
                return this;
            }

            public NewAuthRequest.Builder SetRandomEncryKey(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasRandomEncryKey = true;
                this.result.randomEncryKey_ = value;
                return this;
            }

            public NewAuthRequest.Builder SetRandomEncryKey(SKBuiltinBuffer_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasRandomEncryKey = true;
                this.result.randomEncryKey_ = builderForValue.Build();
                return this;
            }

            public NewAuthRequest.Builder SetRealCountry(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasRealCountry = true;
                this.result.realCountry_ = value;
                return this;
            }

            public NewAuthRequest.Builder SetSignature(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSignature = true;
                this.result.signature_ = value;
                return this;
            }

            public NewAuthRequest.Builder SetSoftType(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSoftType = true;
                this.result.softType_ = value;
                return this;
            }

            public NewAuthRequest.Builder SetTimeStamp(uint value)
            {
                this.PrepareBuilder();
                this.result.hasTimeStamp = true;
                this.result.timeStamp_ = value;
                return this;
            }

            public NewAuthRequest.Builder SetTimeZone(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasTimeZone = true;
                this.result.timeZone_ = value;
                return this;
            }

            public NewAuthRequest.Builder SetUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasUserName = true;
                this.result.userName_ = value;
                return this;
            }

            public NewAuthRequest.Builder SetUserName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasUserName = true;
                this.result.userName_ = builderForValue.Build();
                return this;
            }

            public NewAuthRequest.Builder SetVerifyContent(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasVerifyContent = true;
                this.result.verifyContent_ = value;
                return this;
            }

            public NewAuthRequest.Builder SetVerifySignature(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasVerifySignature = true;
                this.result.verifySignature_ = value;
                return this;
            }

            public NewAuthRequest.Builder SetWTLoginReqBuff(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasWTLoginReqBuff = true;
                this.result.wTLoginReqBuff_ = value;
                return this;
            }

            public NewAuthRequest.Builder SetWTLoginReqBuff(SKBuiltinBuffer_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasWTLoginReqBuff = true;
                this.result.wTLoginReqBuff_ = builderForValue.Build();
                return this;
            }

            public string AdSource
            {
                get
                {
                    return this.result.AdSource;
                }
                set
                {
                    this.SetAdSource(value);
                }
            }

            public string AuthTicket
            {
                get
                {
                    return this.result.AuthTicket;
                }
                set
                {
                    this.SetAuthTicket(value);
                }
            }

            public string AutoAuthTicket
            {
                get
                {
                    return this.result.AutoAuthTicket;
                }
                set
                {
                    this.SetAutoAuthTicket(value);
                }
            }

            public BaseRequest BaseRequest
            {
                get
                {
                    return this.result.BaseRequest;
                }
                set
                {
                    this.SetBaseRequest(value);
                }
            }

            public uint BuiltinIPSeq
            {
                get
                {
                    return this.result.BuiltinIPSeq;
                }
                set
                {
                    this.SetBuiltinIPSeq(value);
                }
            }

            public string BundleID
            {
                get
                {
                    return this.result.BundleID;
                }
                set
                {
                    this.SetBundleID(value);
                }
            }

            public int Channel
            {
                get
                {
                    return this.result.Channel;
                }
                set
                {
                    this.SetChannel(value);
                }
            }

            public SKBuiltinBuffer_t CliDBEncryptInfo
            {
                get
                {
                    return this.result.CliDBEncryptInfo;
                }
                set
                {
                    this.SetCliDBEncryptInfo(value);
                }
            }

            public SKBuiltinBuffer_t CliDBEncryptKey
            {
                get
                {
                    return this.result.CliDBEncryptKey;
                }
                set
                {
                    this.SetCliDBEncryptKey(value);
                }
            }

            public string ClientSeqID
            {
                get
                {
                    return this.result.ClientSeqID;
                }
                set
                {
                    this.SetClientSeqID(value);
                }
            }

            public override NewAuthRequest DefaultInstanceForType
            {
                get
                {
                    return NewAuthRequest.DefaultInstance;
                }
            }

            public string DeviceBrand
            {
                get
                {
                    return this.result.DeviceBrand;
                }
                set
                {
                    this.SetDeviceBrand(value);
                }
            }

            public string DeviceModel
            {
                get
                {
                    return this.result.DeviceModel;
                }
                set
                {
                    this.SetDeviceModel(value);
                }
            }

            public string DeviceName
            {
                get
                {
                    return this.result.DeviceName;
                }
                set
                {
                    this.SetDeviceName(value);
                }
            }

            public string DeviceType
            {
                get
                {
                    return this.result.DeviceType;
                }
                set
                {
                    this.SetDeviceType(value);
                }
            }

            public string ExtPwd
            {
                get
                {
                    return this.result.ExtPwd;
                }
                set
                {
                    this.SetExtPwd(value);
                }
            }

            public string ExtPwd2
            {
                get
                {
                    return this.result.ExtPwd2;
                }
                set
                {
                    this.SetExtPwd2(value);
                }
            }

            public string IMEI
            {
                get
                {
                    return this.result.IMEI;
                }
                set
                {
                    this.SetIMEI(value);
                }
            }

            public SKBuiltinString_t ImgCode
            {
                get
                {
                    return this.result.ImgCode;
                }
                set
                {
                    this.SetImgCode(value);
                }
            }

            public SKBuiltinString_t ImgEncryptKey
            {
                get
                {
                    return this.result.ImgEncryptKey;
                }
                set
                {
                    this.SetImgEncryptKey(value);
                }
            }

            public SKBuiltinString_t ImgSid
            {
                get
                {
                    return this.result.ImgSid;
                }
                set
                {
                    this.SetImgSid(value);
                }
            }

            public uint InputType
            {
                get
                {
                    return this.result.InputType;
                }
                set
                {
                    this.SetInputType(value);
                }
            }

            public string IPhoneVer
            {
                get
                {
                    return this.result.IPhoneVer;
                }
                set
                {
                    this.SetIPhoneVer(value);
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            public SKBuiltinBuffer_t KSid
            {
                get
                {
                    return this.result.KSid;
                }
                set
                {
                    this.SetKSid(value);
                }
            }

            public string Language
            {
                get
                {
                    return this.result.Language;
                }
                set
                {
                    this.SetLanguage(value);
                }
            }

            protected override NewAuthRequest MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public string OSType
            {
                get
                {
                    return this.result.OSType;
                }
                set
                {
                    this.SetOSType(value);
                }
            }

            public SKBuiltinString_t Pwd
            {
                get
                {
                    return this.result.Pwd;
                }
                set
                {
                    this.SetPwd(value);
                }
            }

            public string Pwd2
            {
                get
                {
                    return this.result.Pwd2;
                }
                set
                {
                    this.SetPwd2(value);
                }
            }

            public SKBuiltinBuffer_t RandomEncryKey
            {
                get
                {
                    return this.result.RandomEncryKey;
                }
                set
                {
                    this.SetRandomEncryKey(value);
                }
            }

            public string RealCountry
            {
                get
                {
                    return this.result.RealCountry;
                }
                set
                {
                    this.SetRealCountry(value);
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

            public string SoftType
            {
                get
                {
                    return this.result.SoftType;
                }
                set
                {
                    this.SetSoftType(value);
                }
            }

            protected override NewAuthRequest.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }

            public uint TimeStamp
            {
                get
                {
                    return this.result.TimeStamp;
                }
                set
                {
                    this.SetTimeStamp(value);
                }
            }

            public string TimeZone
            {
                get
                {
                    return this.result.TimeZone;
                }
                set
                {
                    this.SetTimeZone(value);
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

            public string VerifySignature
            {
                get
                {
                    return this.result.VerifySignature;
                }
                set
                {
                    this.SetVerifySignature(value);
                }
            }

            public SKBuiltinBuffer_t WTLoginReqBuff
            {
                get
                {
                    return this.result.WTLoginReqBuff;
                }
                set
                {
                    this.SetWTLoginReqBuff(value);
                }
            }
        }
    }
}

namespace micromsg
{
    using Google.ProtocolBuffers;
   
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

    public sealed class BindOpMobileRequest : GeneratedMessageLite<BindOpMobileRequest, BindOpMobileRequest.Builder>
    {
        private static readonly string[] _bindOpMobileRequestFieldNames = new string[] { "AuthTicket", "BaseRequest", "DialFlag", "DialLang", "ForceReg", "Mobile", "Opcode", "SafeDeviceName", "SafeDeviceType", "UserName", "Verifycode" };
        private static readonly uint[] _bindOpMobileRequestFieldTags = new uint[] { 0x42, 10, 0x30, 0x3a, 0x48, 0x1a, 0x20, 0x52, 90, 0x12, 0x2a };
        private string authTicket_ = "";
        public const int AuthTicketFieldNumber = 8;
        private micromsg.BaseRequest baseRequest_;
        public const int BaseRequestFieldNumber = 1;
        private static readonly BindOpMobileRequest defaultInstance = new BindOpMobileRequest().MakeReadOnly();
        private int dialFlag_;
        public const int DialFlagFieldNumber = 6;
        private string dialLang_ = "";
        public const int DialLangFieldNumber = 7;
        private uint forceReg_;
        public const int ForceRegFieldNumber = 9;
        private bool hasAuthTicket;
        private bool hasBaseRequest;
        private bool hasDialFlag;
        private bool hasDialLang;
        private bool hasForceReg;
        private bool hasMobile;
        private bool hasOpcode;
        private bool hasSafeDeviceName;
        private bool hasSafeDeviceType;
        private bool hasUserName;
        private bool hasVerifycode;
        private int memoizedSerializedSize = -1;
        private string mobile_ = "";
        public const int MobileFieldNumber = 3;
        private int opcode_;
        public const int OpcodeFieldNumber = 4;
        private string safeDeviceName_ = "";
        public const int SafeDeviceNameFieldNumber = 10;
        private string safeDeviceType_ = "";
        public const int SafeDeviceTypeFieldNumber = 11;
        private string userName_ = "";
        public const int UserNameFieldNumber = 2;
        private string verifycode_ = "";
        public const int VerifycodeFieldNumber = 5;

        static BindOpMobileRequest()
        {

        }

        private BindOpMobileRequest()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(BindOpMobileRequest prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            BindOpMobileRequest request = obj as BindOpMobileRequest;
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
            if ((this.hasMobile != request.hasMobile) || (this.hasMobile && !this.mobile_.Equals(request.mobile_)))
            {
                return false;
            }
            if ((this.hasOpcode != request.hasOpcode) || (this.hasOpcode && !this.opcode_.Equals(request.opcode_)))
            {
                return false;
            }
            if ((this.hasVerifycode != request.hasVerifycode) || (this.hasVerifycode && !this.verifycode_.Equals(request.verifycode_)))
            {
                return false;
            }
            if ((this.hasDialFlag != request.hasDialFlag) || (this.hasDialFlag && !this.dialFlag_.Equals(request.dialFlag_)))
            {
                return false;
            }
            if ((this.hasDialLang != request.hasDialLang) || (this.hasDialLang && !this.dialLang_.Equals(request.dialLang_)))
            {
                return false;
            }
            if ((this.hasAuthTicket != request.hasAuthTicket) || (this.hasAuthTicket && !this.authTicket_.Equals(request.authTicket_)))
            {
                return false;
            }
            if ((this.hasForceReg != request.hasForceReg) || (this.hasForceReg && !this.forceReg_.Equals(request.forceReg_)))
            {
                return false;
            }
            if ((this.hasSafeDeviceName != request.hasSafeDeviceName) || (this.hasSafeDeviceName && !this.safeDeviceName_.Equals(request.safeDeviceName_)))
            {
                return false;
            }
            return ((this.hasSafeDeviceType == request.hasSafeDeviceType) && (!this.hasSafeDeviceType || this.safeDeviceType_.Equals(request.safeDeviceType_)));
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
            if (this.hasMobile)
            {
                hashCode ^= this.mobile_.GetHashCode();
            }
            if (this.hasOpcode)
            {
                hashCode ^= this.opcode_.GetHashCode();
            }
            if (this.hasVerifycode)
            {
                hashCode ^= this.verifycode_.GetHashCode();
            }
            if (this.hasDialFlag)
            {
                hashCode ^= this.dialFlag_.GetHashCode();
            }
            if (this.hasDialLang)
            {
                hashCode ^= this.dialLang_.GetHashCode();
            }
            if (this.hasAuthTicket)
            {
                hashCode ^= this.authTicket_.GetHashCode();
            }
            if (this.hasForceReg)
            {
                hashCode ^= this.forceReg_.GetHashCode();
            }
            if (this.hasSafeDeviceName)
            {
                hashCode ^= this.safeDeviceName_.GetHashCode();
            }
            if (this.hasSafeDeviceType)
            {
                hashCode ^= this.safeDeviceType_.GetHashCode();
            }
            return hashCode;
        }

        private BindOpMobileRequest MakeReadOnly()
        {
            return this;
        }

        public static BindOpMobileRequest ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<BindOpMobileRequest, Builder>.PrintField("BaseRequest", this.hasBaseRequest, this.baseRequest_, writer);
            GeneratedMessageLite<BindOpMobileRequest, Builder>.PrintField("UserName", this.hasUserName, this.userName_, writer);
            GeneratedMessageLite<BindOpMobileRequest, Builder>.PrintField("Mobile", this.hasMobile, this.mobile_, writer);
            GeneratedMessageLite<BindOpMobileRequest, Builder>.PrintField("Opcode", this.hasOpcode, this.opcode_, writer);
            GeneratedMessageLite<BindOpMobileRequest, Builder>.PrintField("Verifycode", this.hasVerifycode, this.verifycode_, writer);
            GeneratedMessageLite<BindOpMobileRequest, Builder>.PrintField("DialFlag", this.hasDialFlag, this.dialFlag_, writer);
            GeneratedMessageLite<BindOpMobileRequest, Builder>.PrintField("DialLang", this.hasDialLang, this.dialLang_, writer);
            GeneratedMessageLite<BindOpMobileRequest, Builder>.PrintField("AuthTicket", this.hasAuthTicket, this.authTicket_, writer);
            GeneratedMessageLite<BindOpMobileRequest, Builder>.PrintField("ForceReg", this.hasForceReg, this.forceReg_, writer);
            GeneratedMessageLite<BindOpMobileRequest, Builder>.PrintField("SafeDeviceName", this.hasSafeDeviceName, this.safeDeviceName_, writer);
            GeneratedMessageLite<BindOpMobileRequest, Builder>.PrintField("SafeDeviceType", this.hasSafeDeviceType, this.safeDeviceType_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _bindOpMobileRequestFieldNames;
            if (this.hasBaseRequest)
            {
                output.WriteMessage(1, strArray[1], this.BaseRequest);
            }
            if (this.hasUserName)
            {
                output.WriteString(2, strArray[9], this.UserName);
            }
            if (this.hasMobile)
            {
                output.WriteString(3, strArray[5], this.Mobile);
            }
            if (this.hasOpcode)
            {
                output.WriteInt32(4, strArray[6], this.Opcode);
            }
            if (this.hasVerifycode)
            {
                output.WriteString(5, strArray[10], this.Verifycode);
            }
            if (this.hasDialFlag)
            {
                output.WriteInt32(6, strArray[2], this.DialFlag);
            }
            if (this.hasDialLang)
            {
                output.WriteString(7, strArray[3], this.DialLang);
            }
            if (this.hasAuthTicket)
            {
                output.WriteString(8, strArray[0], this.AuthTicket);
            }
            if (this.hasForceReg)
            {
                output.WriteUInt32(9, strArray[4], this.ForceReg);
            }
            if (this.hasSafeDeviceName)
            {
                output.WriteString(10, strArray[7], this.SafeDeviceName);
            }
            if (this.hasSafeDeviceType)
            {
                output.WriteString(11, strArray[8], this.SafeDeviceType);
            }
        }

        public string AuthTicket
        {
            get
            {
                return this.authTicket_;
            }
        }

        public micromsg.BaseRequest BaseRequest
        {
            get
            {
                return (this.baseRequest_ ?? micromsg.BaseRequest.DefaultInstance);
            }
        }

        public static BindOpMobileRequest DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override BindOpMobileRequest DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public int DialFlag
        {
            get
            {
                return this.dialFlag_;
            }
        }

        public string DialLang
        {
            get
            {
                return this.dialLang_;
            }
        }

        public uint ForceReg
        {
            get
            {
                return this.forceReg_;
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
                if (!this.hasOpcode)
                {
                    return false;
                }
                if (!this.BaseRequest.IsInitialized)
                {
                    return false;
                }
                return true;
            }
        }

        public string Mobile
        {
            get
            {
                return this.mobile_;
            }
        }

        public int Opcode
        {
            get
            {
                return this.opcode_;
            }
        }

        public string SafeDeviceName
        {
            get
            {
                return this.safeDeviceName_;
            }
        }

        public string SafeDeviceType
        {
            get
            {
                return this.safeDeviceType_;
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
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(2, this.UserName);
                    }
                    if (this.hasMobile)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(3, this.Mobile);
                    }
                    if (this.hasOpcode)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(4, this.Opcode);
                    }
                    if (this.hasVerifycode)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(5, this.Verifycode);
                    }
                    if (this.hasDialFlag)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(6, this.DialFlag);
                    }
                    if (this.hasDialLang)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(7, this.DialLang);
                    }
                    if (this.hasAuthTicket)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(8, this.AuthTicket);
                    }
                    if (this.hasForceReg)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(9, this.ForceReg);
                    }
                    if (this.hasSafeDeviceName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(10, this.SafeDeviceName);
                    }
                    if (this.hasSafeDeviceType)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(11, this.SafeDeviceType);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override BindOpMobileRequest ThisMessage
        {
            get
            {
                return this;
            }
        }

        public string UserName
        {
            get
            {
                return this.userName_;
            }
        }

        public string Verifycode
        {
            get
            {
                return this.verifycode_;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<BindOpMobileRequest, BindOpMobileRequest.Builder>
        {
            private BindOpMobileRequest result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = BindOpMobileRequest.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(BindOpMobileRequest cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override BindOpMobileRequest BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override BindOpMobileRequest.Builder Clear()
            {
                this.result = BindOpMobileRequest.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public BindOpMobileRequest.Builder ClearAuthTicket()
            {
                this.PrepareBuilder();
                this.result.hasAuthTicket = false;
                this.result.authTicket_ = "";
                return this;
            }

            public BindOpMobileRequest.Builder ClearBaseRequest()
            {
                this.PrepareBuilder();
                this.result.hasBaseRequest = false;
                this.result.baseRequest_ = null;
                return this;
            }

            public BindOpMobileRequest.Builder ClearDialFlag()
            {
                this.PrepareBuilder();
                this.result.hasDialFlag = false;
                this.result.dialFlag_ = 0;
                return this;
            }

            public BindOpMobileRequest.Builder ClearDialLang()
            {
                this.PrepareBuilder();
                this.result.hasDialLang = false;
                this.result.dialLang_ = "";
                return this;
            }

            public BindOpMobileRequest.Builder ClearForceReg()
            {
                this.PrepareBuilder();
                this.result.hasForceReg = false;
                this.result.forceReg_ = 0;
                return this;
            }

            public BindOpMobileRequest.Builder ClearMobile()
            {
                this.PrepareBuilder();
                this.result.hasMobile = false;
                this.result.mobile_ = "";
                return this;
            }

            public BindOpMobileRequest.Builder ClearOpcode()
            {
                this.PrepareBuilder();
                this.result.hasOpcode = false;
                this.result.opcode_ = 0;
                return this;
            }

            public BindOpMobileRequest.Builder ClearSafeDeviceName()
            {
                this.PrepareBuilder();
                this.result.hasSafeDeviceName = false;
                this.result.safeDeviceName_ = "";
                return this;
            }

            public BindOpMobileRequest.Builder ClearSafeDeviceType()
            {
                this.PrepareBuilder();
                this.result.hasSafeDeviceType = false;
                this.result.safeDeviceType_ = "";
                return this;
            }

            public BindOpMobileRequest.Builder ClearUserName()
            {
                this.PrepareBuilder();
                this.result.hasUserName = false;
                this.result.userName_ = "";
                return this;
            }

            public BindOpMobileRequest.Builder ClearVerifycode()
            {
                this.PrepareBuilder();
                this.result.hasVerifycode = false;
                this.result.verifycode_ = "";
                return this;
            }

            public override BindOpMobileRequest.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new BindOpMobileRequest.Builder(this.result);
                }
                return new BindOpMobileRequest.Builder().MergeFrom(this.result);
            }

            public BindOpMobileRequest.Builder MergeBaseRequest(micromsg.BaseRequest value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasBaseRequest && (this.result.baseRequest_ != micromsg.BaseRequest.DefaultInstance))
                {
                    this.result.baseRequest_ = micromsg.BaseRequest.CreateBuilder(this.result.baseRequest_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.baseRequest_ = value;
                }
                this.result.hasBaseRequest = true;
                return this;
            }

            public override BindOpMobileRequest.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override BindOpMobileRequest.Builder MergeFrom(IMessageLite other)
            {
                if (other is BindOpMobileRequest)
                {
                    return this.MergeFrom((BindOpMobileRequest) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override BindOpMobileRequest.Builder MergeFrom(BindOpMobileRequest other)
            {
                return this;
            }

            public override BindOpMobileRequest.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(BindOpMobileRequest._bindOpMobileRequestFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = BindOpMobileRequest._bindOpMobileRequestFieldTags[index];
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
                            this.result.hasMobile = input.ReadString(ref this.result.mobile_);
                            continue;
                        }
                        case 0x20:
                        {
                            this.result.hasOpcode = input.ReadInt32(ref this.result.opcode_);
                            continue;
                        }
                        case 0x2a:
                        {
                            this.result.hasVerifycode = input.ReadString(ref this.result.verifycode_);
                            continue;
                        }
                        case 0:
                            throw InvalidProtocolBufferException.InvalidTag();

                        case 10:
                        {
                            micromsg.BaseRequest.Builder builder = micromsg.BaseRequest.CreateBuilder();
                            if (this.result.hasBaseRequest)
                            {
                                builder.MergeFrom(this.BaseRequest);
                            }
                            input.ReadMessage(builder, extensionRegistry);
                            this.BaseRequest = builder.BuildPartial();
                            continue;
                        }
                        case 0x12:
                        {
                            this.result.hasUserName = input.ReadString(ref this.result.userName_);
                            continue;
                        }
                        case 0x30:
                        {
                            this.result.hasDialFlag = input.ReadInt32(ref this.result.dialFlag_);
                            continue;
                        }
                        case 0x3a:
                        {
                            this.result.hasDialLang = input.ReadString(ref this.result.dialLang_);
                            continue;
                        }
                        case 0x42:
                        {
                            this.result.hasAuthTicket = input.ReadString(ref this.result.authTicket_);
                            continue;
                        }
                        case 0x48:
                        {
                            this.result.hasForceReg = input.ReadUInt32(ref this.result.forceReg_);
                            continue;
                        }
                        case 0x52:
                        {
                            this.result.hasSafeDeviceName = input.ReadString(ref this.result.safeDeviceName_);
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
                    this.result.hasSafeDeviceType = input.ReadString(ref this.result.safeDeviceType_);
                }
                return this;
            }

            private BindOpMobileRequest PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    BindOpMobileRequest result = this.result;
                    this.result = new BindOpMobileRequest();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public BindOpMobileRequest.Builder SetAuthTicket(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasAuthTicket = true;
                this.result.authTicket_ = value;
                return this;
            }

            public BindOpMobileRequest.Builder SetBaseRequest(micromsg.BaseRequest value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = value;
                return this;
            }

            public BindOpMobileRequest.Builder SetBaseRequest(micromsg.BaseRequest.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = builderForValue.Build();
                return this;
            }

            public BindOpMobileRequest.Builder SetDialFlag(int value)
            {
                this.PrepareBuilder();
                this.result.hasDialFlag = true;
                this.result.dialFlag_ = value;
                return this;
            }

            public BindOpMobileRequest.Builder SetDialLang(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasDialLang = true;
                this.result.dialLang_ = value;
                return this;
            }

            public BindOpMobileRequest.Builder SetForceReg(uint value)
            {
                this.PrepareBuilder();
                this.result.hasForceReg = true;
                this.result.forceReg_ = value;
                return this;
            }

            public BindOpMobileRequest.Builder SetMobile(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasMobile = true;
                this.result.mobile_ = value;
                return this;
            }

            public BindOpMobileRequest.Builder SetOpcode(int value)
            {
                this.PrepareBuilder();
                this.result.hasOpcode = true;
                this.result.opcode_ = value;
                return this;
            }

            public BindOpMobileRequest.Builder SetSafeDeviceName(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSafeDeviceName = true;
                this.result.safeDeviceName_ = value;
                return this;
            }

            public BindOpMobileRequest.Builder SetSafeDeviceType(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSafeDeviceType = true;
                this.result.safeDeviceType_ = value;
                return this;
            }

            public BindOpMobileRequest.Builder SetUserName(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasUserName = true;
                this.result.userName_ = value;
                return this;
            }

            public BindOpMobileRequest.Builder SetVerifycode(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasVerifycode = true;
                this.result.verifycode_ = value;
                return this;
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

            public micromsg.BaseRequest BaseRequest
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

            public override BindOpMobileRequest DefaultInstanceForType
            {
                get
                {
                    return BindOpMobileRequest.DefaultInstance;
                }
            }

            public int DialFlag
            {
                get
                {
                    return this.result.DialFlag;
                }
                set
                {
                    this.SetDialFlag(value);
                }
            }

            public string DialLang
            {
                get
                {
                    return this.result.DialLang;
                }
                set
                {
                    this.SetDialLang(value);
                }
            }

            public uint ForceReg
            {
                get
                {
                    return this.result.ForceReg;
                }
                set
                {
                    this.SetForceReg(value);
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override BindOpMobileRequest MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public string Mobile
            {
                get
                {
                    return this.result.Mobile;
                }
                set
                {
                    this.SetMobile(value);
                }
            }

            public int Opcode
            {
                get
                {
                    return this.result.Opcode;
                }
                set
                {
                    this.SetOpcode(value);
                }
            }

            public string SafeDeviceName
            {
                get
                {
                    return this.result.SafeDeviceName;
                }
                set
                {
                    this.SetSafeDeviceName(value);
                }
            }

            public string SafeDeviceType
            {
                get
                {
                    return this.result.SafeDeviceType;
                }
                set
                {
                    this.SetSafeDeviceType(value);
                }
            }

            protected override BindOpMobileRequest.Builder ThisBuilder
            {
                get
                {
                    return this;
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

            public string Verifycode
            {
                get
                {
                    return this.result.Verifycode;
                }
                set
                {
                    this.SetVerifycode(value);
                }
            }
        }
    }
}


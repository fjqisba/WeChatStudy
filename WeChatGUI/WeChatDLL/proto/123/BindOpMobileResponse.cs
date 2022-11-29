namespace micromsg
{
    using Google.ProtocolBuffers;
    
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

   // 
    public sealed class BindOpMobileResponse : GeneratedMessageLite<BindOpMobileResponse, BindOpMobileResponse.Builder>
    {
        private static readonly string[] _bindOpMobileResponseFieldNames = new string[] { "AuthTicket", "BaseResponse", "BuiltinIPList", "MainAcct", "MainAcctType", "NeedSetPwd", "NetworkControl", "NewHostList", "Pwd", "SafeDevice", "SafeDeviceList", "SmsNo", "Username", "ticket" };
        private static readonly uint[] _bindOpMobileResponseFieldTags = new uint[] { 0x52, 10, 0x42, 0x62, 0x68, 0x20, 0x4a, 0x3a, 0x2a, 0x58, 0x72, 0x1a, 50, 0x12 };
        private string authTicket_ = "";
        public const int AuthTicketFieldNumber = 10;
        private micromsg.BaseResponse baseResponse_;
        public const int BaseResponseFieldNumber = 1;
        private micromsg.BuiltinIPList builtinIPList_;
        public const int BuiltinIPListFieldNumber = 8;
        private static readonly BindOpMobileResponse defaultInstance = new BindOpMobileResponse().MakeReadOnly();
        private bool hasAuthTicket;
        private bool hasBaseResponse;
        private bool hasBuiltinIPList;
        private bool hasMainAcct;
        private bool hasMainAcctType;
        private bool hasNeedSetPwd;
        private bool hasNetworkControl;
        private bool hasNewHostList;
        private bool hasPwd;
        private bool hasSafeDevice;
        private bool hasSafeDeviceList;
        private bool hasSmsNo;
        private bool hasTicket;
        private bool hasUsername;
        private string mainAcct_ = "";
        public const int MainAcctFieldNumber = 12;
        private uint mainAcctType_;
        public const int MainAcctTypeFieldNumber = 13;
        private int memoizedSerializedSize = -1;
        private uint needSetPwd_;
        public const int NeedSetPwdFieldNumber = 4;
        private micromsg.NetworkControl networkControl_;
        public const int NetworkControlFieldNumber = 9;
        private HostList newHostList_;
        public const int NewHostListFieldNumber = 7;
        private string pwd_ = "";
        public const int PwdFieldNumber = 5;
        private uint safeDevice_;
        public const int SafeDeviceFieldNumber = 11;
        private micromsg.SafeDeviceList safeDeviceList_;
        public const int SafeDeviceListFieldNumber = 14;
        private string smsNo_ = "";
        public const int SmsNoFieldNumber = 3;
        private string ticket_ = "";
        public const int TicketFieldNumber = 2;
        private string username_ = "";
        public const int UsernameFieldNumber = 6;

        static BindOpMobileResponse()
        {
            
        }

        private BindOpMobileResponse()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(BindOpMobileResponse prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            BindOpMobileResponse response = obj as BindOpMobileResponse;
            if (response == null)
            {
                return false;
            }
            if ((this.hasBaseResponse != response.hasBaseResponse) || (this.hasBaseResponse && !this.baseResponse_.Equals(response.baseResponse_)))
            {
                return false;
            }
            if ((this.hasTicket != response.hasTicket) || (this.hasTicket && !this.ticket_.Equals(response.ticket_)))
            {
                return false;
            }
            if ((this.hasSmsNo != response.hasSmsNo) || (this.hasSmsNo && !this.smsNo_.Equals(response.smsNo_)))
            {
                return false;
            }
            if ((this.hasNeedSetPwd != response.hasNeedSetPwd) || (this.hasNeedSetPwd && !this.needSetPwd_.Equals(response.needSetPwd_)))
            {
                return false;
            }
            if ((this.hasPwd != response.hasPwd) || (this.hasPwd && !this.pwd_.Equals(response.pwd_)))
            {
                return false;
            }
            if ((this.hasUsername != response.hasUsername) || (this.hasUsername && !this.username_.Equals(response.username_)))
            {
                return false;
            }
            if ((this.hasNewHostList != response.hasNewHostList) || (this.hasNewHostList && !this.newHostList_.Equals(response.newHostList_)))
            {
                return false;
            }
            if ((this.hasBuiltinIPList != response.hasBuiltinIPList) || (this.hasBuiltinIPList && !this.builtinIPList_.Equals(response.builtinIPList_)))
            {
                return false;
            }
            if ((this.hasNetworkControl != response.hasNetworkControl) || (this.hasNetworkControl && !this.networkControl_.Equals(response.networkControl_)))
            {
                return false;
            }
            if ((this.hasAuthTicket != response.hasAuthTicket) || (this.hasAuthTicket && !this.authTicket_.Equals(response.authTicket_)))
            {
                return false;
            }
            if ((this.hasSafeDevice != response.hasSafeDevice) || (this.hasSafeDevice && !this.safeDevice_.Equals(response.safeDevice_)))
            {
                return false;
            }
            if ((this.hasMainAcct != response.hasMainAcct) || (this.hasMainAcct && !this.mainAcct_.Equals(response.mainAcct_)))
            {
                return false;
            }
            if ((this.hasMainAcctType != response.hasMainAcctType) || (this.hasMainAcctType && !this.mainAcctType_.Equals(response.mainAcctType_)))
            {
                return false;
            }
            return ((this.hasSafeDeviceList == response.hasSafeDeviceList) && (!this.hasSafeDeviceList || this.safeDeviceList_.Equals(response.safeDeviceList_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasBaseResponse)
            {
                hashCode ^= this.baseResponse_.GetHashCode();
            }
            if (this.hasTicket)
            {
                hashCode ^= this.ticket_.GetHashCode();
            }
            if (this.hasSmsNo)
            {
                hashCode ^= this.smsNo_.GetHashCode();
            }
            if (this.hasNeedSetPwd)
            {
                hashCode ^= this.needSetPwd_.GetHashCode();
            }
            if (this.hasPwd)
            {
                hashCode ^= this.pwd_.GetHashCode();
            }
            if (this.hasUsername)
            {
                hashCode ^= this.username_.GetHashCode();
            }
            if (this.hasNewHostList)
            {
                hashCode ^= this.newHostList_.GetHashCode();
            }
            if (this.hasBuiltinIPList)
            {
                hashCode ^= this.builtinIPList_.GetHashCode();
            }
            if (this.hasNetworkControl)
            {
                hashCode ^= this.networkControl_.GetHashCode();
            }
            if (this.hasAuthTicket)
            {
                hashCode ^= this.authTicket_.GetHashCode();
            }
            if (this.hasSafeDevice)
            {
                hashCode ^= this.safeDevice_.GetHashCode();
            }
            if (this.hasMainAcct)
            {
                hashCode ^= this.mainAcct_.GetHashCode();
            }
            if (this.hasMainAcctType)
            {
                hashCode ^= this.mainAcctType_.GetHashCode();
            }
            if (this.hasSafeDeviceList)
            {
                hashCode ^= this.safeDeviceList_.GetHashCode();
            }
            return hashCode;
        }

        private BindOpMobileResponse MakeReadOnly()
        {
            return this;
        }

        public static BindOpMobileResponse ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<BindOpMobileResponse, Builder>.PrintField("BaseResponse", this.hasBaseResponse, this.baseResponse_, writer);
            GeneratedMessageLite<BindOpMobileResponse, Builder>.PrintField("ticket", this.hasTicket, this.ticket_, writer);
            GeneratedMessageLite<BindOpMobileResponse, Builder>.PrintField("SmsNo", this.hasSmsNo, this.smsNo_, writer);
            GeneratedMessageLite<BindOpMobileResponse, Builder>.PrintField("NeedSetPwd", this.hasNeedSetPwd, this.needSetPwd_, writer);
            GeneratedMessageLite<BindOpMobileResponse, Builder>.PrintField("Pwd", this.hasPwd, this.pwd_, writer);
            GeneratedMessageLite<BindOpMobileResponse, Builder>.PrintField("Username", this.hasUsername, this.username_, writer);
            GeneratedMessageLite<BindOpMobileResponse, Builder>.PrintField("NewHostList", this.hasNewHostList, this.newHostList_, writer);
            GeneratedMessageLite<BindOpMobileResponse, Builder>.PrintField("BuiltinIPList", this.hasBuiltinIPList, this.builtinIPList_, writer);
            GeneratedMessageLite<BindOpMobileResponse, Builder>.PrintField("NetworkControl", this.hasNetworkControl, this.networkControl_, writer);
            GeneratedMessageLite<BindOpMobileResponse, Builder>.PrintField("AuthTicket", this.hasAuthTicket, this.authTicket_, writer);
            GeneratedMessageLite<BindOpMobileResponse, Builder>.PrintField("SafeDevice", this.hasSafeDevice, this.safeDevice_, writer);
            GeneratedMessageLite<BindOpMobileResponse, Builder>.PrintField("MainAcct", this.hasMainAcct, this.mainAcct_, writer);
            GeneratedMessageLite<BindOpMobileResponse, Builder>.PrintField("MainAcctType", this.hasMainAcctType, this.mainAcctType_, writer);
            GeneratedMessageLite<BindOpMobileResponse, Builder>.PrintField("SafeDeviceList", this.hasSafeDeviceList, this.safeDeviceList_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _bindOpMobileResponseFieldNames;
            if (this.hasBaseResponse)
            {
                output.WriteMessage(1, strArray[1], this.BaseResponse);
            }
            if (this.hasTicket)
            {
                output.WriteString(2, strArray[13], this.Ticket);
            }
            if (this.hasSmsNo)
            {
                output.WriteString(3, strArray[11], this.SmsNo);
            }
            if (this.hasNeedSetPwd)
            {
                output.WriteUInt32(4, strArray[5], this.NeedSetPwd);
            }
            if (this.hasPwd)
            {
                output.WriteString(5, strArray[8], this.Pwd);
            }
            if (this.hasUsername)
            {
                output.WriteString(6, strArray[12], this.Username);
            }
            if (this.hasNewHostList)
            {
                output.WriteMessage(7, strArray[7], this.NewHostList);
            }
            if (this.hasBuiltinIPList)
            {
                output.WriteMessage(8, strArray[2], this.BuiltinIPList);
            }
            if (this.hasNetworkControl)
            {
                output.WriteMessage(9, strArray[6], this.NetworkControl);
            }
            if (this.hasAuthTicket)
            {
                output.WriteString(10, strArray[0], this.AuthTicket);
            }
            if (this.hasSafeDevice)
            {
                output.WriteUInt32(11, strArray[9], this.SafeDevice);
            }
            if (this.hasMainAcct)
            {
                output.WriteString(12, strArray[3], this.MainAcct);
            }
            if (this.hasMainAcctType)
            {
                output.WriteUInt32(13, strArray[4], this.MainAcctType);
            }
            if (this.hasSafeDeviceList)
            {
                output.WriteMessage(14, strArray[10], this.SafeDeviceList);
            }
        }

        public string AuthTicket
        {
            get
            {
                return this.authTicket_;
            }
        }

        public micromsg.BaseResponse BaseResponse
        {
            get
            {
                return (this.baseResponse_ ?? micromsg.BaseResponse.DefaultInstance);
            }
        }

        public micromsg.BuiltinIPList BuiltinIPList
        {
            get
            {
                return (this.builtinIPList_ ?? micromsg.BuiltinIPList.DefaultInstance);
            }
        }

        public static BindOpMobileResponse DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override BindOpMobileResponse DefaultInstanceForType
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
                if (!this.hasBaseResponse)
                {
                    return false;
                }
                if (!this.BaseResponse.IsInitialized)
                {
                    return false;
                }
                return true;
            }
        }

        public string MainAcct
        {
            get
            {
                return this.mainAcct_;
            }
        }

        public uint MainAcctType
        {
            get
            {
                return this.mainAcctType_;
            }
        }

        public uint NeedSetPwd
        {
            get
            {
                return this.needSetPwd_;
            }
        }

        public micromsg.NetworkControl NetworkControl
        {
            get
            {
                return (this.networkControl_ ?? micromsg.NetworkControl.DefaultInstance);
            }
        }

        public HostList NewHostList
        {
            get
            {
                return (this.newHostList_ ?? HostList.DefaultInstance);
            }
        }

        public string Pwd
        {
            get
            {
                return this.pwd_;
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
                    if (this.hasTicket)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(2, this.Ticket);
                    }
                    if (this.hasSmsNo)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(3, this.SmsNo);
                    }
                    if (this.hasNeedSetPwd)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(4, this.NeedSetPwd);
                    }
                    if (this.hasPwd)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(5, this.Pwd);
                    }
                    if (this.hasUsername)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(6, this.Username);
                    }
                    if (this.hasNewHostList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(7, this.NewHostList);
                    }
                    if (this.hasBuiltinIPList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(8, this.BuiltinIPList);
                    }
                    if (this.hasNetworkControl)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(9, this.NetworkControl);
                    }
                    if (this.hasAuthTicket)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(10, this.AuthTicket);
                    }
                    if (this.hasSafeDevice)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(11, this.SafeDevice);
                    }
                    if (this.hasMainAcct)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(12, this.MainAcct);
                    }
                    if (this.hasMainAcctType)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(13, this.MainAcctType);
                    }
                    if (this.hasSafeDeviceList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(14, this.SafeDeviceList);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        public string SmsNo
        {
            get
            {
                return this.smsNo_;
            }
        }

        protected override BindOpMobileResponse ThisMessage
        {
            get
            {
                return this;
            }
        }

        public string Ticket
        {
            get
            {
                return this.ticket_;
            }
        }

        public string Username
        {
            get
            {
                return this.username_;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<BindOpMobileResponse, BindOpMobileResponse.Builder>
        {
            private BindOpMobileResponse result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = BindOpMobileResponse.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(BindOpMobileResponse cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override BindOpMobileResponse BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override BindOpMobileResponse.Builder Clear()
            {
                this.result = BindOpMobileResponse.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public BindOpMobileResponse.Builder ClearAuthTicket()
            {
                this.PrepareBuilder();
                this.result.hasAuthTicket = false;
                this.result.authTicket_ = "";
                return this;
            }

            public BindOpMobileResponse.Builder ClearBaseResponse()
            {
                this.PrepareBuilder();
                this.result.hasBaseResponse = false;
                this.result.baseResponse_ = null;
                return this;
            }

            public BindOpMobileResponse.Builder ClearBuiltinIPList()
            {
                this.PrepareBuilder();
                this.result.hasBuiltinIPList = false;
                this.result.builtinIPList_ = null;
                return this;
            }

            public BindOpMobileResponse.Builder ClearMainAcct()
            {
                this.PrepareBuilder();
                this.result.hasMainAcct = false;
                this.result.mainAcct_ = "";
                return this;
            }

            public BindOpMobileResponse.Builder ClearMainAcctType()
            {
                this.PrepareBuilder();
                this.result.hasMainAcctType = false;
                this.result.mainAcctType_ = 0;
                return this;
            }

            public BindOpMobileResponse.Builder ClearNeedSetPwd()
            {
                this.PrepareBuilder();
                this.result.hasNeedSetPwd = false;
                this.result.needSetPwd_ = 0;
                return this;
            }

            public BindOpMobileResponse.Builder ClearNetworkControl()
            {
                this.PrepareBuilder();
                this.result.hasNetworkControl = false;
                this.result.networkControl_ = null;
                return this;
            }

            public BindOpMobileResponse.Builder ClearNewHostList()
            {
                this.PrepareBuilder();
                this.result.hasNewHostList = false;
                this.result.newHostList_ = null;
                return this;
            }

            public BindOpMobileResponse.Builder ClearPwd()
            {
                this.PrepareBuilder();
                this.result.hasPwd = false;
                this.result.pwd_ = "";
                return this;
            }

            public BindOpMobileResponse.Builder ClearSafeDevice()
            {
                this.PrepareBuilder();
                this.result.hasSafeDevice = false;
                this.result.safeDevice_ = 0;
                return this;
            }

            public BindOpMobileResponse.Builder ClearSafeDeviceList()
            {
                this.PrepareBuilder();
                this.result.hasSafeDeviceList = false;
                this.result.safeDeviceList_ = null;
                return this;
            }

            public BindOpMobileResponse.Builder ClearSmsNo()
            {
                this.PrepareBuilder();
                this.result.hasSmsNo = false;
                this.result.smsNo_ = "";
                return this;
            }

            public BindOpMobileResponse.Builder ClearTicket()
            {
                this.PrepareBuilder();
                this.result.hasTicket = false;
                this.result.ticket_ = "";
                return this;
            }

            public BindOpMobileResponse.Builder ClearUsername()
            {
                this.PrepareBuilder();
                this.result.hasUsername = false;
                this.result.username_ = "";
                return this;
            }

            public override BindOpMobileResponse.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new BindOpMobileResponse.Builder(this.result);
                }
                return new BindOpMobileResponse.Builder().MergeFrom(this.result);
            }

            public BindOpMobileResponse.Builder MergeBaseResponse(micromsg.BaseResponse value)
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

            public BindOpMobileResponse.Builder MergeBuiltinIPList(micromsg.BuiltinIPList value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasBuiltinIPList && (this.result.builtinIPList_ != micromsg.BuiltinIPList.DefaultInstance))
                {
                    this.result.builtinIPList_ = micromsg.BuiltinIPList.CreateBuilder(this.result.builtinIPList_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.builtinIPList_ = value;
                }
                this.result.hasBuiltinIPList = true;
                return this;
            }

            public override BindOpMobileResponse.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override BindOpMobileResponse.Builder MergeFrom(IMessageLite other)
            {
                if (other is BindOpMobileResponse)
                {
                    return this.MergeFrom((BindOpMobileResponse) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override BindOpMobileResponse.Builder MergeFrom(BindOpMobileResponse other)
            {
                return this;
            }

            public override BindOpMobileResponse.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(BindOpMobileResponse._bindOpMobileResponseFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = BindOpMobileResponse._bindOpMobileResponseFieldTags[index];
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
                            this.result.hasTicket = input.ReadString(ref this.result.ticket_);
                            continue;
                        }
                        case 0x2a:
                        {
                            this.result.hasPwd = input.ReadString(ref this.result.pwd_);
                            continue;
                        }
                        case 50:
                        {
                            this.result.hasUsername = input.ReadString(ref this.result.username_);
                            continue;
                        }
                        case 0x1a:
                        {
                            this.result.hasSmsNo = input.ReadString(ref this.result.smsNo_);
                            continue;
                        }
                        case 0x20:
                        {
                            this.result.hasNeedSetPwd = input.ReadUInt32(ref this.result.needSetPwd_);
                            continue;
                        }
                        case 0x4a:
                        {
                            micromsg.NetworkControl.Builder builder4 = micromsg.NetworkControl.CreateBuilder();
                            if (this.result.hasNetworkControl)
                            {
                                builder4.MergeFrom(this.NetworkControl);
                            }
                            input.ReadMessage(builder4, extensionRegistry);
                            this.NetworkControl = builder4.BuildPartial();
                            continue;
                        }
                        case 0x52:
                        {
                            this.result.hasAuthTicket = input.ReadString(ref this.result.authTicket_);
                            continue;
                        }
                        case 0x3a:
                        {
                            HostList.Builder builder2 = HostList.CreateBuilder();
                            if (this.result.hasNewHostList)
                            {
                                builder2.MergeFrom(this.NewHostList);
                            }
                            input.ReadMessage(builder2, extensionRegistry);
                            this.NewHostList = builder2.BuildPartial();
                            continue;
                        }
                        case 0x42:
                        {
                            micromsg.BuiltinIPList.Builder builder3 = micromsg.BuiltinIPList.CreateBuilder();
                            if (this.result.hasBuiltinIPList)
                            {
                                builder3.MergeFrom(this.BuiltinIPList);
                            }
                            input.ReadMessage(builder3, extensionRegistry);
                            this.BuiltinIPList = builder3.BuildPartial();
                            continue;
                        }
                        case 0x58:
                        {
                            this.result.hasSafeDevice = input.ReadUInt32(ref this.result.safeDevice_);
                            continue;
                        }
                        case 0x62:
                        {
                            this.result.hasMainAcct = input.ReadString(ref this.result.mainAcct_);
                            continue;
                        }
                        case 0x68:
                        {
                            this.result.hasMainAcctType = input.ReadUInt32(ref this.result.mainAcctType_);
                            continue;
                        }
                        case 0x72:
                        {
                            micromsg.SafeDeviceList.Builder builder5 = micromsg.SafeDeviceList.CreateBuilder();
                            if (this.result.hasSafeDeviceList)
                            {
                                builder5.MergeFrom(this.SafeDeviceList);
                            }
                            input.ReadMessage(builder5, extensionRegistry);
                            this.SafeDeviceList = builder5.BuildPartial();
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

            public BindOpMobileResponse.Builder MergeNetworkControl(micromsg.NetworkControl value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasNetworkControl && (this.result.networkControl_ != micromsg.NetworkControl.DefaultInstance))
                {
                    this.result.networkControl_ = micromsg.NetworkControl.CreateBuilder(this.result.networkControl_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.networkControl_ = value;
                }
                this.result.hasNetworkControl = true;
                return this;
            }

            public BindOpMobileResponse.Builder MergeNewHostList(HostList value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasNewHostList && (this.result.newHostList_ != HostList.DefaultInstance))
                {
                    this.result.newHostList_ = HostList.CreateBuilder(this.result.newHostList_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.newHostList_ = value;
                }
                this.result.hasNewHostList = true;
                return this;
            }

            public BindOpMobileResponse.Builder MergeSafeDeviceList(micromsg.SafeDeviceList value)
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

            private BindOpMobileResponse PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    BindOpMobileResponse result = this.result;
                    this.result = new BindOpMobileResponse();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public BindOpMobileResponse.Builder SetAuthTicket(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasAuthTicket = true;
                this.result.authTicket_ = value;
                return this;
            }

            public BindOpMobileResponse.Builder SetBaseResponse(micromsg.BaseResponse value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = value;
                return this;
            }

            public BindOpMobileResponse.Builder SetBaseResponse(micromsg.BaseResponse.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = builderForValue.Build();
                return this;
            }

            public BindOpMobileResponse.Builder SetBuiltinIPList(micromsg.BuiltinIPList value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBuiltinIPList = true;
                this.result.builtinIPList_ = value;
                return this;
            }

            public BindOpMobileResponse.Builder SetBuiltinIPList(micromsg.BuiltinIPList.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBuiltinIPList = true;
                this.result.builtinIPList_ = builderForValue.Build();
                return this;
            }

            public BindOpMobileResponse.Builder SetMainAcct(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasMainAcct = true;
                this.result.mainAcct_ = value;
                return this;
            }

            public BindOpMobileResponse.Builder SetMainAcctType(uint value)
            {
                this.PrepareBuilder();
                this.result.hasMainAcctType = true;
                this.result.mainAcctType_ = value;
                return this;
            }

            public BindOpMobileResponse.Builder SetNeedSetPwd(uint value)
            {
                this.PrepareBuilder();
                this.result.hasNeedSetPwd = true;
                this.result.needSetPwd_ = value;
                return this;
            }

            public BindOpMobileResponse.Builder SetNetworkControl(micromsg.NetworkControl value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasNetworkControl = true;
                this.result.networkControl_ = value;
                return this;
            }

            public BindOpMobileResponse.Builder SetNetworkControl(micromsg.NetworkControl.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasNetworkControl = true;
                this.result.networkControl_ = builderForValue.Build();
                return this;
            }

            public BindOpMobileResponse.Builder SetNewHostList(HostList value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasNewHostList = true;
                this.result.newHostList_ = value;
                return this;
            }

            public BindOpMobileResponse.Builder SetNewHostList(HostList.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasNewHostList = true;
                this.result.newHostList_ = builderForValue.Build();
                return this;
            }

            public BindOpMobileResponse.Builder SetPwd(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasPwd = true;
                this.result.pwd_ = value;
                return this;
            }

            public BindOpMobileResponse.Builder SetSafeDevice(uint value)
            {
                this.PrepareBuilder();
                this.result.hasSafeDevice = true;
                this.result.safeDevice_ = value;
                return this;
            }

            public BindOpMobileResponse.Builder SetSafeDeviceList(micromsg.SafeDeviceList value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSafeDeviceList = true;
                this.result.safeDeviceList_ = value;
                return this;
            }

            public BindOpMobileResponse.Builder SetSafeDeviceList(micromsg.SafeDeviceList.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasSafeDeviceList = true;
                this.result.safeDeviceList_ = builderForValue.Build();
                return this;
            }

            public BindOpMobileResponse.Builder SetSmsNo(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSmsNo = true;
                this.result.smsNo_ = value;
                return this;
            }

            public BindOpMobileResponse.Builder SetTicket(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasTicket = true;
                this.result.ticket_ = value;
                return this;
            }

            public BindOpMobileResponse.Builder SetUsername(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasUsername = true;
                this.result.username_ = value;
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

            public micromsg.BuiltinIPList BuiltinIPList
            {
                get
                {
                    return this.result.BuiltinIPList;
                }
                set
                {
                    this.SetBuiltinIPList(value);
                }
            }

            public override BindOpMobileResponse DefaultInstanceForType
            {
                get
                {
                    return BindOpMobileResponse.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            public string MainAcct
            {
                get
                {
                    return this.result.MainAcct;
                }
                set
                {
                    this.SetMainAcct(value);
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

            protected override BindOpMobileResponse MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public uint NeedSetPwd
            {
                get
                {
                    return this.result.NeedSetPwd;
                }
                set
                {
                    this.SetNeedSetPwd(value);
                }
            }

            public micromsg.NetworkControl NetworkControl
            {
                get
                {
                    return this.result.NetworkControl;
                }
                set
                {
                    this.SetNetworkControl(value);
                }
            }

            public HostList NewHostList
            {
                get
                {
                    return this.result.NewHostList;
                }
                set
                {
                    this.SetNewHostList(value);
                }
            }

            public string Pwd
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

            public string SmsNo
            {
                get
                {
                    return this.result.SmsNo;
                }
                set
                {
                    this.SetSmsNo(value);
                }
            }

            protected override BindOpMobileResponse.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }

            public string Ticket
            {
                get
                {
                    return this.result.Ticket;
                }
                set
                {
                    this.SetTicket(value);
                }
            }

            public string Username
            {
                get
                {
                    return this.result.Username;
                }
                set
                {
                    this.SetUsername(value);
                }
            }
        }
    }
}


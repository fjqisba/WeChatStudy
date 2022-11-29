namespace micromsg
{
    using Google.ProtocolBuffers;
 
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

    public sealed class GetUserNameRequest : GeneratedMessageLite<GetUserNameRequest, GetUserNameRequest.Builder>
    {
        private static readonly string[] _getUserNameRequestFieldNames = new string[] { "BaseRequest", "BindUin", "Mobile", "NickName", "OpCode", "Pwd", "Ticket" };
        private static readonly uint[] _getUserNameRequestFieldTags = new uint[] { 10, 0x10, 50, 0x1a, 0x38, 0x2a, 0x22 };
        private micromsg.BaseRequest baseRequest_;
        public const int BaseRequestFieldNumber = 1;
        private uint bindUin_;
        public const int BindUinFieldNumber = 2;
        private static readonly GetUserNameRequest defaultInstance = new GetUserNameRequest().MakeReadOnly();
        private bool hasBaseRequest;
        private bool hasBindUin;
        private bool hasMobile;
        private bool hasNickName;
        private bool hasOpCode;
        private bool hasPwd;
        private bool hasTicket;
        private int memoizedSerializedSize = -1;
        private string mobile_ = "";
        public const int MobileFieldNumber = 6;
        private string nickName_ = "";
        public const int NickNameFieldNumber = 3;
        private uint opCode_;
        public const int OpCodeFieldNumber = 7;
        private string pwd_ = "";
        public const int PwdFieldNumber = 5;
        private string ticket_ = "";
        public const int TicketFieldNumber = 4;

        static GetUserNameRequest()
        {
           
        }

        private GetUserNameRequest()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(GetUserNameRequest prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            GetUserNameRequest request = obj as GetUserNameRequest;
            if (request == null)
            {
                return false;
            }
            if ((this.hasBaseRequest != request.hasBaseRequest) || (this.hasBaseRequest && !this.baseRequest_.Equals(request.baseRequest_)))
            {
                return false;
            }
            if ((this.hasBindUin != request.hasBindUin) || (this.hasBindUin && !this.bindUin_.Equals(request.bindUin_)))
            {
                return false;
            }
            if ((this.hasNickName != request.hasNickName) || (this.hasNickName && !this.nickName_.Equals(request.nickName_)))
            {
                return false;
            }
            if ((this.hasTicket != request.hasTicket) || (this.hasTicket && !this.ticket_.Equals(request.ticket_)))
            {
                return false;
            }
            if ((this.hasPwd != request.hasPwd) || (this.hasPwd && !this.pwd_.Equals(request.pwd_)))
            {
                return false;
            }
            if ((this.hasMobile != request.hasMobile) || (this.hasMobile && !this.mobile_.Equals(request.mobile_)))
            {
                return false;
            }
            return ((this.hasOpCode == request.hasOpCode) && (!this.hasOpCode || this.opCode_.Equals(request.opCode_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasBaseRequest)
            {
                hashCode ^= this.baseRequest_.GetHashCode();
            }
            if (this.hasBindUin)
            {
                hashCode ^= this.bindUin_.GetHashCode();
            }
            if (this.hasNickName)
            {
                hashCode ^= this.nickName_.GetHashCode();
            }
            if (this.hasTicket)
            {
                hashCode ^= this.ticket_.GetHashCode();
            }
            if (this.hasPwd)
            {
                hashCode ^= this.pwd_.GetHashCode();
            }
            if (this.hasMobile)
            {
                hashCode ^= this.mobile_.GetHashCode();
            }
            if (this.hasOpCode)
            {
                hashCode ^= this.opCode_.GetHashCode();
            }
            return hashCode;
        }

        private GetUserNameRequest MakeReadOnly()
        {
            return this;
        }

        public static GetUserNameRequest ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<GetUserNameRequest, Builder>.PrintField("BaseRequest", this.hasBaseRequest, this.baseRequest_, writer);
            GeneratedMessageLite<GetUserNameRequest, Builder>.PrintField("BindUin", this.hasBindUin, this.bindUin_, writer);
            GeneratedMessageLite<GetUserNameRequest, Builder>.PrintField("NickName", this.hasNickName, this.nickName_, writer);
            GeneratedMessageLite<GetUserNameRequest, Builder>.PrintField("Ticket", this.hasTicket, this.ticket_, writer);
            GeneratedMessageLite<GetUserNameRequest, Builder>.PrintField("Pwd", this.hasPwd, this.pwd_, writer);
            GeneratedMessageLite<GetUserNameRequest, Builder>.PrintField("Mobile", this.hasMobile, this.mobile_, writer);
            GeneratedMessageLite<GetUserNameRequest, Builder>.PrintField("OpCode", this.hasOpCode, this.opCode_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _getUserNameRequestFieldNames;
            if (this.hasBaseRequest)
            {
                output.WriteMessage(1, strArray[0], this.BaseRequest);
            }
            if (this.hasBindUin)
            {
                output.WriteUInt32(2, strArray[1], this.BindUin);
            }
            if (this.hasNickName)
            {
                output.WriteString(3, strArray[3], this.NickName);
            }
            if (this.hasTicket)
            {
                output.WriteString(4, strArray[6], this.Ticket);
            }
            if (this.hasPwd)
            {
                output.WriteString(5, strArray[5], this.Pwd);
            }
            if (this.hasMobile)
            {
                output.WriteString(6, strArray[2], this.Mobile);
            }
            if (this.hasOpCode)
            {
                output.WriteUInt32(7, strArray[4], this.OpCode);
            }
        }

        public micromsg.BaseRequest BaseRequest
        {
            get
            {
                return (this.baseRequest_ ?? micromsg.BaseRequest.DefaultInstance);
            }
        }

        public uint BindUin
        {
            get
            {
                return this.bindUin_;
            }
        }

        public static GetUserNameRequest DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override GetUserNameRequest DefaultInstanceForType
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
                if (!this.hasBaseRequest)
                {
                    return false;
                }
                if (!this.hasBindUin)
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

        public string NickName
        {
            get
            {
                return this.nickName_;
            }
        }

        public uint OpCode
        {
            get
            {
                return this.opCode_;
            }
        }

        public string Pwd
        {
            get
            {
                return this.pwd_;
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
                    if (this.hasBindUin)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(2, this.BindUin);
                    }
                    if (this.hasNickName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(3, this.NickName);
                    }
                    if (this.hasTicket)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(4, this.Ticket);
                    }
                    if (this.hasPwd)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(5, this.Pwd);
                    }
                    if (this.hasMobile)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(6, this.Mobile);
                    }
                    if (this.hasOpCode)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(7, this.OpCode);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override GetUserNameRequest ThisMessage
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

        
        public sealed class Builder : GeneratedBuilderLite<GetUserNameRequest, GetUserNameRequest.Builder>
        {
            private GetUserNameRequest result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = GetUserNameRequest.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(GetUserNameRequest cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override GetUserNameRequest BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override GetUserNameRequest.Builder Clear()
            {
                this.result = GetUserNameRequest.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public GetUserNameRequest.Builder ClearBaseRequest()
            {
                this.PrepareBuilder();
                this.result.hasBaseRequest = false;
                this.result.baseRequest_ = null;
                return this;
            }

            public GetUserNameRequest.Builder ClearBindUin()
            {
                this.PrepareBuilder();
                this.result.hasBindUin = false;
                this.result.bindUin_ = 0;
                return this;
            }

            public GetUserNameRequest.Builder ClearMobile()
            {
                this.PrepareBuilder();
                this.result.hasMobile = false;
                this.result.mobile_ = "";
                return this;
            }

            public GetUserNameRequest.Builder ClearNickName()
            {
                this.PrepareBuilder();
                this.result.hasNickName = false;
                this.result.nickName_ = "";
                return this;
            }

            public GetUserNameRequest.Builder ClearOpCode()
            {
                this.PrepareBuilder();
                this.result.hasOpCode = false;
                this.result.opCode_ = 0;
                return this;
            }

            public GetUserNameRequest.Builder ClearPwd()
            {
                this.PrepareBuilder();
                this.result.hasPwd = false;
                this.result.pwd_ = "";
                return this;
            }

            public GetUserNameRequest.Builder ClearTicket()
            {
                this.PrepareBuilder();
                this.result.hasTicket = false;
                this.result.ticket_ = "";
                return this;
            }

            public override GetUserNameRequest.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new GetUserNameRequest.Builder(this.result);
                }
                return new GetUserNameRequest.Builder().MergeFrom(this.result);
            }

            public GetUserNameRequest.Builder MergeBaseRequest(micromsg.BaseRequest value)
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

            public override GetUserNameRequest.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override GetUserNameRequest.Builder MergeFrom(IMessageLite other)
            {
                if (other is GetUserNameRequest)
                {
                    return this.MergeFrom((GetUserNameRequest) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override GetUserNameRequest.Builder MergeFrom(GetUserNameRequest other)
            {
                return this;
            }

            public override GetUserNameRequest.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(GetUserNameRequest._getUserNameRequestFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = GetUserNameRequest._getUserNameRequestFieldTags[index];
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
                            this.result.hasBindUin = input.ReadUInt32(ref this.result.bindUin_);
                            continue;
                        }
                        case 0x1a:
                        {
                            this.result.hasNickName = input.ReadString(ref this.result.nickName_);
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
                        case 0x22:
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
                            this.result.hasMobile = input.ReadString(ref this.result.mobile_);
                            continue;
                        }
                        case 0x38:
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
                    this.result.hasOpCode = input.ReadUInt32(ref this.result.opCode_);
                }
                return this;
            }

            private GetUserNameRequest PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    GetUserNameRequest result = this.result;
                    this.result = new GetUserNameRequest();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public GetUserNameRequest.Builder SetBaseRequest(micromsg.BaseRequest value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = value;
                return this;
            }

            public GetUserNameRequest.Builder SetBaseRequest(micromsg.BaseRequest.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = builderForValue.Build();
                return this;
            }

            public GetUserNameRequest.Builder SetBindUin(uint value)
            {
                this.PrepareBuilder();
                this.result.hasBindUin = true;
                this.result.bindUin_ = value;
                return this;
            }

            public GetUserNameRequest.Builder SetMobile(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasMobile = true;
                this.result.mobile_ = value;
                return this;
            }

            public GetUserNameRequest.Builder SetNickName(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasNickName = true;
                this.result.nickName_ = value;
                return this;
            }

            public GetUserNameRequest.Builder SetOpCode(uint value)
            {
                this.PrepareBuilder();
                this.result.hasOpCode = true;
                this.result.opCode_ = value;
                return this;
            }

            public GetUserNameRequest.Builder SetPwd(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasPwd = true;
                this.result.pwd_ = value;
                return this;
            }

            public GetUserNameRequest.Builder SetTicket(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasTicket = true;
                this.result.ticket_ = value;
                return this;
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

            public override GetUserNameRequest DefaultInstanceForType
            {
                get
                {
                    return GetUserNameRequest.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override GetUserNameRequest MessageBeingBuilt
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

            public string NickName
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

            public uint OpCode
            {
                get
                {
                    return this.result.OpCode;
                }
                set
                {
                    this.SetOpCode(value);
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

            protected override GetUserNameRequest.Builder ThisBuilder
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
        }
    }
}


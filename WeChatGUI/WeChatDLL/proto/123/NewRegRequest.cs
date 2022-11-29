namespace micromsg
{
    using Google.ProtocolBuffers;

    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

    public sealed class NewRegRequest : GeneratedMessageLite<NewRegRequest, NewRegRequest.Builder>
    {
        private static readonly string[] _newRegRequestFieldNames = new string[] { "BaseRequest", "BindEmail", "BindMobile", "BindUin", "BuiltinIPSeq", "DLSrc", "Language", "NickName", "Pwd", "RegMode", "Ticket", "TimeZone", "UserName" };
        private static readonly uint[] _newRegRequestFieldTags = new uint[] { 10, 50, 0x3a, 40, 0x60, 0x68, 130, 0x22, 0x1a, 0x70, 0x42, 0x7a, 0x12 };
        private micromsg.BaseRequest baseRequest_;
        public const int BaseRequestFieldNumber = 1;
        private string bindEmail_ = "";
        public const int BindEmailFieldNumber = 6;
        private string bindMobile_ = "";
        public const int BindMobileFieldNumber = 7;
        private uint bindUin_;
        public const int BindUinFieldNumber = 5;
        private uint builtinIPSeq_;
        public const int BuiltinIPSeqFieldNumber = 12;
        private static readonly NewRegRequest defaultInstance = new NewRegRequest().MakeReadOnly();
        private uint dLSrc_;
        public const int DLSrcFieldNumber = 13;
        private bool hasBaseRequest;
        private bool hasBindEmail;
        private bool hasBindMobile;
        private bool hasBindUin;
        private bool hasBuiltinIPSeq;
        private bool hasDLSrc;
        private bool hasLanguage;
        private bool hasNickName;
        private bool hasPwd;
        private bool hasRegMode;
        private bool hasTicket;
        private bool hasTimeZone;
        private bool hasUserName;
        private string language_ = "";
        public const int LanguageFieldNumber = 0x10;
        private int memoizedSerializedSize = -1;
        private string nickName_ = "";
        public const int NickNameFieldNumber = 4;
        private string pwd_ = "";
        public const int PwdFieldNumber = 3;
        private uint regMode_;
        public const int RegModeFieldNumber = 14;
        private string ticket_ = "";
        public const int TicketFieldNumber = 8;
        private string timeZone_ = "";
        public const int TimeZoneFieldNumber = 15;
        private string userName_ = "";
        public const int UserNameFieldNumber = 2;

        static NewRegRequest()
        {
           
        }

        private NewRegRequest()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(NewRegRequest prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            NewRegRequest request = obj as NewRegRequest;
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
            if ((this.hasNickName != request.hasNickName) || (this.hasNickName && !this.nickName_.Equals(request.nickName_)))
            {
                return false;
            }
            if ((this.hasBindUin != request.hasBindUin) || (this.hasBindUin && !this.bindUin_.Equals(request.bindUin_)))
            {
                return false;
            }
            if ((this.hasBindEmail != request.hasBindEmail) || (this.hasBindEmail && !this.bindEmail_.Equals(request.bindEmail_)))
            {
                return false;
            }
            if ((this.hasBindMobile != request.hasBindMobile) || (this.hasBindMobile && !this.bindMobile_.Equals(request.bindMobile_)))
            {
                return false;
            }
            if ((this.hasTicket != request.hasTicket) || (this.hasTicket && !this.ticket_.Equals(request.ticket_)))
            {
                return false;
            }
            if ((this.hasBuiltinIPSeq != request.hasBuiltinIPSeq) || (this.hasBuiltinIPSeq && !this.builtinIPSeq_.Equals(request.builtinIPSeq_)))
            {
                return false;
            }
            if ((this.hasDLSrc != request.hasDLSrc) || (this.hasDLSrc && !this.dLSrc_.Equals(request.dLSrc_)))
            {
                return false;
            }
            if ((this.hasRegMode != request.hasRegMode) || (this.hasRegMode && !this.regMode_.Equals(request.regMode_)))
            {
                return false;
            }
            if ((this.hasTimeZone != request.hasTimeZone) || (this.hasTimeZone && !this.timeZone_.Equals(request.timeZone_)))
            {
                return false;
            }
            return ((this.hasLanguage == request.hasLanguage) && (!this.hasLanguage || this.language_.Equals(request.language_)));
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
            if (this.hasTicket)
            {
                hashCode ^= this.ticket_.GetHashCode();
            }
            if (this.hasBuiltinIPSeq)
            {
                hashCode ^= this.builtinIPSeq_.GetHashCode();
            }
            if (this.hasDLSrc)
            {
                hashCode ^= this.dLSrc_.GetHashCode();
            }
            if (this.hasRegMode)
            {
                hashCode ^= this.regMode_.GetHashCode();
            }
            if (this.hasTimeZone)
            {
                hashCode ^= this.timeZone_.GetHashCode();
            }
            if (this.hasLanguage)
            {
                hashCode ^= this.language_.GetHashCode();
            }
            return hashCode;
        }

        private NewRegRequest MakeReadOnly()
        {
            return this;
        }

        public static NewRegRequest ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<NewRegRequest, Builder>.PrintField("BaseRequest", this.hasBaseRequest, this.baseRequest_, writer);
            GeneratedMessageLite<NewRegRequest, Builder>.PrintField("UserName", this.hasUserName, this.userName_, writer);
            GeneratedMessageLite<NewRegRequest, Builder>.PrintField("Pwd", this.hasPwd, this.pwd_, writer);
            GeneratedMessageLite<NewRegRequest, Builder>.PrintField("NickName", this.hasNickName, this.nickName_, writer);
            GeneratedMessageLite<NewRegRequest, Builder>.PrintField("BindUin", this.hasBindUin, this.bindUin_, writer);
            GeneratedMessageLite<NewRegRequest, Builder>.PrintField("BindEmail", this.hasBindEmail, this.bindEmail_, writer);
            GeneratedMessageLite<NewRegRequest, Builder>.PrintField("BindMobile", this.hasBindMobile, this.bindMobile_, writer);
            GeneratedMessageLite<NewRegRequest, Builder>.PrintField("Ticket", this.hasTicket, this.ticket_, writer);
            GeneratedMessageLite<NewRegRequest, Builder>.PrintField("BuiltinIPSeq", this.hasBuiltinIPSeq, this.builtinIPSeq_, writer);
            GeneratedMessageLite<NewRegRequest, Builder>.PrintField("DLSrc", this.hasDLSrc, this.dLSrc_, writer);
            GeneratedMessageLite<NewRegRequest, Builder>.PrintField("RegMode", this.hasRegMode, this.regMode_, writer);
            GeneratedMessageLite<NewRegRequest, Builder>.PrintField("TimeZone", this.hasTimeZone, this.timeZone_, writer);
            GeneratedMessageLite<NewRegRequest, Builder>.PrintField("Language", this.hasLanguage, this.language_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _newRegRequestFieldNames;
            if (this.hasBaseRequest)
            {
                output.WriteMessage(1, strArray[0], this.BaseRequest);
            }
            if (this.hasUserName)
            {
                output.WriteString(2, strArray[12], this.UserName);
            }
            if (this.hasPwd)
            {
                output.WriteString(3, strArray[8], this.Pwd);
            }
            if (this.hasNickName)
            {
                output.WriteString(4, strArray[7], this.NickName);
            }
            if (this.hasBindUin)
            {
                output.WriteUInt32(5, strArray[3], this.BindUin);
            }
            if (this.hasBindEmail)
            {
                output.WriteString(6, strArray[1], this.BindEmail);
            }
            if (this.hasBindMobile)
            {
                output.WriteString(7, strArray[2], this.BindMobile);
            }
            if (this.hasTicket)
            {
                output.WriteString(8, strArray[10], this.Ticket);
            }
            if (this.hasBuiltinIPSeq)
            {
                output.WriteUInt32(12, strArray[4], this.BuiltinIPSeq);
            }
            if (this.hasDLSrc)
            {
                output.WriteUInt32(13, strArray[5], this.DLSrc);
            }
            if (this.hasRegMode)
            {
                output.WriteUInt32(14, strArray[9], this.RegMode);
            }
            if (this.hasTimeZone)
            {
                output.WriteString(15, strArray[11], this.TimeZone);
            }
            if (this.hasLanguage)
            {
                output.WriteString(0x10, strArray[6], this.Language);
            }
        }

        public micromsg.BaseRequest BaseRequest
        {
            get
            {
                return (this.baseRequest_ ?? micromsg.BaseRequest.DefaultInstance);
            }
        }

        public string BindEmail
        {
            get
            {
                return this.bindEmail_;
            }
        }

        public string BindMobile
        {
            get
            {
                return this.bindMobile_;
            }
        }

        public uint BindUin
        {
            get
            {
                return this.bindUin_;
            }
        }

        public uint BuiltinIPSeq
        {
            get
            {
                return this.builtinIPSeq_;
            }
        }

        public static NewRegRequest DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override NewRegRequest DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public uint DLSrc
        {
            get
            {
                return this.dLSrc_;
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

        public string Language
        {
            get
            {
                return this.language_;
            }
        }

        public string NickName
        {
            get
            {
                return this.nickName_;
            }
        }

        public string Pwd
        {
            get
            {
                return this.pwd_;
            }
        }

        public uint RegMode
        {
            get
            {
                return this.regMode_;
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
                    if (this.hasPwd)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(3, this.Pwd);
                    }
                    if (this.hasNickName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(4, this.NickName);
                    }
                    if (this.hasBindUin)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(5, this.BindUin);
                    }
                    if (this.hasBindEmail)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(6, this.BindEmail);
                    }
                    if (this.hasBindMobile)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(7, this.BindMobile);
                    }
                    if (this.hasTicket)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(8, this.Ticket);
                    }
                    if (this.hasBuiltinIPSeq)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(12, this.BuiltinIPSeq);
                    }
                    if (this.hasDLSrc)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(13, this.DLSrc);
                    }
                    if (this.hasRegMode)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(14, this.RegMode);
                    }
                    if (this.hasTimeZone)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(15, this.TimeZone);
                    }
                    if (this.hasLanguage)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x10, this.Language);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override NewRegRequest ThisMessage
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

        public string TimeZone
        {
            get
            {
                return this.timeZone_;
            }
        }

        public string UserName
        {
            get
            {
                return this.userName_;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<NewRegRequest, NewRegRequest.Builder>
        {
            private NewRegRequest result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = NewRegRequest.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(NewRegRequest cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override NewRegRequest BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override NewRegRequest.Builder Clear()
            {
                this.result = NewRegRequest.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public NewRegRequest.Builder ClearBaseRequest()
            {
                this.PrepareBuilder();
                this.result.hasBaseRequest = false;
                this.result.baseRequest_ = null;
                return this;
            }

            public NewRegRequest.Builder ClearBindEmail()
            {
                this.PrepareBuilder();
                this.result.hasBindEmail = false;
                this.result.bindEmail_ = "";
                return this;
            }

            public NewRegRequest.Builder ClearBindMobile()
            {
                this.PrepareBuilder();
                this.result.hasBindMobile = false;
                this.result.bindMobile_ = "";
                return this;
            }

            public NewRegRequest.Builder ClearBindUin()
            {
                this.PrepareBuilder();
                this.result.hasBindUin = false;
                this.result.bindUin_ = 0;
                return this;
            }

            public NewRegRequest.Builder ClearBuiltinIPSeq()
            {
                this.PrepareBuilder();
                this.result.hasBuiltinIPSeq = false;
                this.result.builtinIPSeq_ = 0;
                return this;
            }

            public NewRegRequest.Builder ClearDLSrc()
            {
                this.PrepareBuilder();
                this.result.hasDLSrc = false;
                this.result.dLSrc_ = 0;
                return this;
            }

            public NewRegRequest.Builder ClearLanguage()
            {
                this.PrepareBuilder();
                this.result.hasLanguage = false;
                this.result.language_ = "";
                return this;
            }

            public NewRegRequest.Builder ClearNickName()
            {
                this.PrepareBuilder();
                this.result.hasNickName = false;
                this.result.nickName_ = "";
                return this;
            }

            public NewRegRequest.Builder ClearPwd()
            {
                this.PrepareBuilder();
                this.result.hasPwd = false;
                this.result.pwd_ = "";
                return this;
            }

            public NewRegRequest.Builder ClearRegMode()
            {
                this.PrepareBuilder();
                this.result.hasRegMode = false;
                this.result.regMode_ = 0;
                return this;
            }

            public NewRegRequest.Builder ClearTicket()
            {
                this.PrepareBuilder();
                this.result.hasTicket = false;
                this.result.ticket_ = "";
                return this;
            }

            public NewRegRequest.Builder ClearTimeZone()
            {
                this.PrepareBuilder();
                this.result.hasTimeZone = false;
                this.result.timeZone_ = "";
                return this;
            }

            public NewRegRequest.Builder ClearUserName()
            {
                this.PrepareBuilder();
                this.result.hasUserName = false;
                this.result.userName_ = "";
                return this;
            }

            public override NewRegRequest.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new NewRegRequest.Builder(this.result);
                }
                return new NewRegRequest.Builder().MergeFrom(this.result);
            }

            public NewRegRequest.Builder MergeBaseRequest(micromsg.BaseRequest value)
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

            public override NewRegRequest.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override NewRegRequest.Builder MergeFrom(IMessageLite other)
            {
                if (other is NewRegRequest)
                {
                    return this.MergeFrom((NewRegRequest) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override NewRegRequest.Builder MergeFrom(NewRegRequest other)
            {
                return this;
            }

            public override NewRegRequest.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(NewRegRequest._newRegRequestFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = NewRegRequest._newRegRequestFieldTags[index];
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
                        case 40:
                        {
                            this.result.hasBindUin = input.ReadUInt32(ref this.result.bindUin_);
                            continue;
                        }
                        case 50:
                        {
                            this.result.hasBindEmail = input.ReadString(ref this.result.bindEmail_);
                            continue;
                        }
                        case 0x1a:
                        {
                            this.result.hasPwd = input.ReadString(ref this.result.pwd_);
                            continue;
                        }
                        case 0x22:
                        {
                            this.result.hasNickName = input.ReadString(ref this.result.nickName_);
                            continue;
                        }
                        case 0x3a:
                        {
                            this.result.hasBindMobile = input.ReadString(ref this.result.bindMobile_);
                            continue;
                        }
                        case 0x42:
                        {
                            this.result.hasTicket = input.ReadString(ref this.result.ticket_);
                            continue;
                        }
                        case 0x60:
                        {
                            this.result.hasBuiltinIPSeq = input.ReadUInt32(ref this.result.builtinIPSeq_);
                            continue;
                        }
                        case 0x68:
                        {
                            this.result.hasDLSrc = input.ReadUInt32(ref this.result.dLSrc_);
                            continue;
                        }
                        case 0x70:
                        {
                            this.result.hasRegMode = input.ReadUInt32(ref this.result.regMode_);
                            continue;
                        }
                        case 0x7a:
                        {
                            this.result.hasTimeZone = input.ReadString(ref this.result.timeZone_);
                            continue;
                        }
                        case 130:
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
                    this.result.hasLanguage = input.ReadString(ref this.result.language_);
                }
                return this;
            }

            private NewRegRequest PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    NewRegRequest result = this.result;
                    this.result = new NewRegRequest();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public NewRegRequest.Builder SetBaseRequest(micromsg.BaseRequest value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = value;
                return this;
            }

            public NewRegRequest.Builder SetBaseRequest(micromsg.BaseRequest.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = builderForValue.Build();
                return this;
            }

            public NewRegRequest.Builder SetBindEmail(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBindEmail = true;
                this.result.bindEmail_ = value;
                return this;
            }

            public NewRegRequest.Builder SetBindMobile(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBindMobile = true;
                this.result.bindMobile_ = value;
                return this;
            }

            public NewRegRequest.Builder SetBindUin(uint value)
            {
                this.PrepareBuilder();
                this.result.hasBindUin = true;
                this.result.bindUin_ = value;
                return this;
            }

            public NewRegRequest.Builder SetBuiltinIPSeq(uint value)
            {
                this.PrepareBuilder();
                this.result.hasBuiltinIPSeq = true;
                this.result.builtinIPSeq_ = value;
                return this;
            }

            public NewRegRequest.Builder SetDLSrc(uint value)
            {
                this.PrepareBuilder();
                this.result.hasDLSrc = true;
                this.result.dLSrc_ = value;
                return this;
            }

            public NewRegRequest.Builder SetLanguage(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasLanguage = true;
                this.result.language_ = value;
                return this;
            }

            public NewRegRequest.Builder SetNickName(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasNickName = true;
                this.result.nickName_ = value;
                return this;
            }

            public NewRegRequest.Builder SetPwd(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasPwd = true;
                this.result.pwd_ = value;
                return this;
            }

            public NewRegRequest.Builder SetRegMode(uint value)
            {
                this.PrepareBuilder();
                this.result.hasRegMode = true;
                this.result.regMode_ = value;
                return this;
            }

            public NewRegRequest.Builder SetTicket(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasTicket = true;
                this.result.ticket_ = value;
                return this;
            }

            public NewRegRequest.Builder SetTimeZone(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasTimeZone = true;
                this.result.timeZone_ = value;
                return this;
            }

            public NewRegRequest.Builder SetUserName(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasUserName = true;
                this.result.userName_ = value;
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

            public string BindEmail
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

            public string BindMobile
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

            public override NewRegRequest DefaultInstanceForType
            {
                get
                {
                    return NewRegRequest.DefaultInstance;
                }
            }

            public uint DLSrc
            {
                get
                {
                    return this.result.DLSrc;
                }
                set
                {
                    this.SetDLSrc(value);
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
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

            protected override NewRegRequest MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
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

            public uint RegMode
            {
                get
                {
                    return this.result.RegMode;
                }
                set
                {
                    this.SetRegMode(value);
                }
            }

            protected override NewRegRequest.Builder ThisBuilder
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
        }
    }
}


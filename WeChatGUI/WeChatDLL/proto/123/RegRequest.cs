namespace micromsg
{
    using Google.ProtocolBuffers;

    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    


    public sealed class RegRequest : GeneratedMessageLite<RegRequest, RegRequest.Builder>
    {
        private static readonly string[] _regRequestFieldNames = new string[] { "BaseRequest", "BindEmail", "BindMobile", "BindUin", "BuiltinIPSeq", "DLSrc", "ImgCode", "ImgSid", "Language", "NickName", "Pwd", "Pwd2", "Ticket", "TimeZone", "UserName" };
        private static readonly uint[] _regRequestFieldTags = new uint[] { 10, 50, 0x3a, 40, 0x60, 0x68, 0x4a, 0x42, 0x7a, 0x22, 0x1a, 90, 0x52, 0x72, 0x12 };
        private micromsg.BaseRequest baseRequest_;
        public const int BaseRequestFieldNumber = 1;
        private SKBuiltinString_t bindEmail_;
        public const int BindEmailFieldNumber = 6;
        private SKBuiltinString_t bindMobile_;
        public const int BindMobileFieldNumber = 7;
        private uint bindUin_;
        public const int BindUinFieldNumber = 5;
        private uint builtinIPSeq_;
        public const int BuiltinIPSeqFieldNumber = 12;
        private static readonly RegRequest defaultInstance = new RegRequest().MakeReadOnly();
        private uint dLSrc_;
        public const int DLSrcFieldNumber = 13;
        private bool hasBaseRequest;
        private bool hasBindEmail;
        private bool hasBindMobile;
        private bool hasBindUin;
        private bool hasBuiltinIPSeq;
        private bool hasDLSrc;
        private bool hasImgCode;
        private bool hasImgSid;
        private bool hasLanguage;
        private bool hasNickName;
        private bool hasPwd;
        private bool hasPwd2;
        private bool hasTicket;
        private bool hasTimeZone;
        private bool hasUserName;
        private SKBuiltinString_t imgCode_;
        public const int ImgCodeFieldNumber = 9;
        private SKBuiltinString_t imgSid_;
        public const int ImgSidFieldNumber = 8;
        private string language_ = "";
        public const int LanguageFieldNumber = 15;
        private int memoizedSerializedSize = -1;
        private SKBuiltinString_t nickName_;
        public const int NickNameFieldNumber = 4;
        private SKBuiltinString_t pwd_;
        private string pwd2_ = "";
        public const int Pwd2FieldNumber = 11;
        public const int PwdFieldNumber = 3;
        private SKBuiltinString_t ticket_;
        public const int TicketFieldNumber = 10;
        private string timeZone_ = "";
        public const int TimeZoneFieldNumber = 14;
        private SKBuiltinString_t userName_;
        public const int UserNameFieldNumber = 2;

        static RegRequest()
        {

        }

        private RegRequest()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(RegRequest prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            RegRequest request = obj as RegRequest;
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
            if ((this.hasImgSid != request.hasImgSid) || (this.hasImgSid && !this.imgSid_.Equals(request.imgSid_)))
            {
                return false;
            }
            if ((this.hasImgCode != request.hasImgCode) || (this.hasImgCode && !this.imgCode_.Equals(request.imgCode_)))
            {
                return false;
            }
            if ((this.hasTicket != request.hasTicket) || (this.hasTicket && !this.ticket_.Equals(request.ticket_)))
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
            if ((this.hasDLSrc != request.hasDLSrc) || (this.hasDLSrc && !this.dLSrc_.Equals(request.dLSrc_)))
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
            if (this.hasImgSid)
            {
                hashCode ^= this.imgSid_.GetHashCode();
            }
            if (this.hasImgCode)
            {
                hashCode ^= this.imgCode_.GetHashCode();
            }
            if (this.hasTicket)
            {
                hashCode ^= this.ticket_.GetHashCode();
            }
            if (this.hasPwd2)
            {
                hashCode ^= this.pwd2_.GetHashCode();
            }
            if (this.hasBuiltinIPSeq)
            {
                hashCode ^= this.builtinIPSeq_.GetHashCode();
            }
            if (this.hasDLSrc)
            {
                hashCode ^= this.dLSrc_.GetHashCode();
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

        private RegRequest MakeReadOnly()
        {
            return this;
        }

        public static RegRequest ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<RegRequest, Builder>.PrintField("BaseRequest", this.hasBaseRequest, this.baseRequest_, writer);
            GeneratedMessageLite<RegRequest, Builder>.PrintField("UserName", this.hasUserName, this.userName_, writer);
            GeneratedMessageLite<RegRequest, Builder>.PrintField("Pwd", this.hasPwd, this.pwd_, writer);
            GeneratedMessageLite<RegRequest, Builder>.PrintField("NickName", this.hasNickName, this.nickName_, writer);
            GeneratedMessageLite<RegRequest, Builder>.PrintField("BindUin", this.hasBindUin, this.bindUin_, writer);
            GeneratedMessageLite<RegRequest, Builder>.PrintField("BindEmail", this.hasBindEmail, this.bindEmail_, writer);
            GeneratedMessageLite<RegRequest, Builder>.PrintField("BindMobile", this.hasBindMobile, this.bindMobile_, writer);
            GeneratedMessageLite<RegRequest, Builder>.PrintField("ImgSid", this.hasImgSid, this.imgSid_, writer);
            GeneratedMessageLite<RegRequest, Builder>.PrintField("ImgCode", this.hasImgCode, this.imgCode_, writer);
            GeneratedMessageLite<RegRequest, Builder>.PrintField("Ticket", this.hasTicket, this.ticket_, writer);
            GeneratedMessageLite<RegRequest, Builder>.PrintField("Pwd2", this.hasPwd2, this.pwd2_, writer);
            GeneratedMessageLite<RegRequest, Builder>.PrintField("BuiltinIPSeq", this.hasBuiltinIPSeq, this.builtinIPSeq_, writer);
            GeneratedMessageLite<RegRequest, Builder>.PrintField("DLSrc", this.hasDLSrc, this.dLSrc_, writer);
            GeneratedMessageLite<RegRequest, Builder>.PrintField("TimeZone", this.hasTimeZone, this.timeZone_, writer);
            GeneratedMessageLite<RegRequest, Builder>.PrintField("Language", this.hasLanguage, this.language_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _regRequestFieldNames;
            if (this.hasBaseRequest)
            {
                output.WriteMessage(1, strArray[0], this.BaseRequest);
            }
            if (this.hasUserName)
            {
                output.WriteMessage(2, strArray[14], this.UserName);
            }
            if (this.hasPwd)
            {
                output.WriteMessage(3, strArray[10], this.Pwd);
            }
            if (this.hasNickName)
            {
                output.WriteMessage(4, strArray[9], this.NickName);
            }
            if (this.hasBindUin)
            {
                output.WriteUInt32(5, strArray[3], this.BindUin);
            }
            if (this.hasBindEmail)
            {
                output.WriteMessage(6, strArray[1], this.BindEmail);
            }
            if (this.hasBindMobile)
            {
                output.WriteMessage(7, strArray[2], this.BindMobile);
            }
            if (this.hasImgSid)
            {
                output.WriteMessage(8, strArray[7], this.ImgSid);
            }
            if (this.hasImgCode)
            {
                output.WriteMessage(9, strArray[6], this.ImgCode);
            }
            if (this.hasTicket)
            {
                output.WriteMessage(10, strArray[12], this.Ticket);
            }
            if (this.hasPwd2)
            {
                output.WriteString(11, strArray[11], this.Pwd2);
            }
            if (this.hasBuiltinIPSeq)
            {
                output.WriteUInt32(12, strArray[4], this.BuiltinIPSeq);
            }
            if (this.hasDLSrc)
            {
                output.WriteUInt32(13, strArray[5], this.DLSrc);
            }
            if (this.hasTimeZone)
            {
                output.WriteString(14, strArray[13], this.TimeZone);
            }
            if (this.hasLanguage)
            {
                output.WriteString(15, strArray[8], this.Language);
            }
        }

        public micromsg.BaseRequest BaseRequest
        {
            get
            {
                return (this.baseRequest_ ?? micromsg.BaseRequest.DefaultInstance);
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

        public uint BuiltinIPSeq
        {
            get
            {
                return this.builtinIPSeq_;
            }
        }

        public static RegRequest DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override RegRequest DefaultInstanceForType
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

        public SKBuiltinString_t ImgCode
        {
            get
            {
                return (this.imgCode_ ?? SKBuiltinString_t.DefaultInstance);
            }
        }

        public SKBuiltinString_t ImgSid
        {
            get
            {
                return (this.imgSid_ ?? SKBuiltinString_t.DefaultInstance);
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
                if (!this.hasImgSid)
                {
                    return false;
                }
                if (!this.hasImgCode)
                {
                    return false;
                }
                if (!this.hasTicket)
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

        public SKBuiltinString_t NickName
        {
            get
            {
                return (this.nickName_ ?? SKBuiltinString_t.DefaultInstance);
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
                    if (this.hasNickName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(4, this.NickName);
                    }
                    if (this.hasBindUin)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(5, this.BindUin);
                    }
                    if (this.hasBindEmail)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(6, this.BindEmail);
                    }
                    if (this.hasBindMobile)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(7, this.BindMobile);
                    }
                    if (this.hasImgSid)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(8, this.ImgSid);
                    }
                    if (this.hasImgCode)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(9, this.ImgCode);
                    }
                    if (this.hasTicket)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(10, this.Ticket);
                    }
                    if (this.hasPwd2)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(11, this.Pwd2);
                    }
                    if (this.hasBuiltinIPSeq)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(12, this.BuiltinIPSeq);
                    }
                    if (this.hasDLSrc)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(13, this.DLSrc);
                    }
                    if (this.hasTimeZone)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(14, this.TimeZone);
                    }
                    if (this.hasLanguage)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(15, this.Language);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override RegRequest ThisMessage
        {
            get
            {
                return this;
            }
        }

        public SKBuiltinString_t Ticket
        {
            get
            {
                return (this.ticket_ ?? SKBuiltinString_t.DefaultInstance);
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

        
        public sealed class Builder : GeneratedBuilderLite<RegRequest, RegRequest.Builder>
        {
            private RegRequest result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = RegRequest.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(RegRequest cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override RegRequest BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override RegRequest.Builder Clear()
            {
                this.result = RegRequest.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public RegRequest.Builder ClearBaseRequest()
            {
                this.PrepareBuilder();
                this.result.hasBaseRequest = false;
                this.result.baseRequest_ = null;
                return this;
            }

            public RegRequest.Builder ClearBindEmail()
            {
                this.PrepareBuilder();
                this.result.hasBindEmail = false;
                this.result.bindEmail_ = null;
                return this;
            }

            public RegRequest.Builder ClearBindMobile()
            {
                this.PrepareBuilder();
                this.result.hasBindMobile = false;
                this.result.bindMobile_ = null;
                return this;
            }

            public RegRequest.Builder ClearBindUin()
            {
                this.PrepareBuilder();
                this.result.hasBindUin = false;
                this.result.bindUin_ = 0;
                return this;
            }

            public RegRequest.Builder ClearBuiltinIPSeq()
            {
                this.PrepareBuilder();
                this.result.hasBuiltinIPSeq = false;
                this.result.builtinIPSeq_ = 0;
                return this;
            }

            public RegRequest.Builder ClearDLSrc()
            {
                this.PrepareBuilder();
                this.result.hasDLSrc = false;
                this.result.dLSrc_ = 0;
                return this;
            }

            public RegRequest.Builder ClearImgCode()
            {
                this.PrepareBuilder();
                this.result.hasImgCode = false;
                this.result.imgCode_ = null;
                return this;
            }

            public RegRequest.Builder ClearImgSid()
            {
                this.PrepareBuilder();
                this.result.hasImgSid = false;
                this.result.imgSid_ = null;
                return this;
            }

            public RegRequest.Builder ClearLanguage()
            {
                this.PrepareBuilder();
                this.result.hasLanguage = false;
                this.result.language_ = "";
                return this;
            }

            public RegRequest.Builder ClearNickName()
            {
                this.PrepareBuilder();
                this.result.hasNickName = false;
                this.result.nickName_ = null;
                return this;
            }

            public RegRequest.Builder ClearPwd()
            {
                this.PrepareBuilder();
                this.result.hasPwd = false;
                this.result.pwd_ = null;
                return this;
            }

            public RegRequest.Builder ClearPwd2()
            {
                this.PrepareBuilder();
                this.result.hasPwd2 = false;
                this.result.pwd2_ = "";
                return this;
            }

            public RegRequest.Builder ClearTicket()
            {
                this.PrepareBuilder();
                this.result.hasTicket = false;
                this.result.ticket_ = null;
                return this;
            }

            public RegRequest.Builder ClearTimeZone()
            {
                this.PrepareBuilder();
                this.result.hasTimeZone = false;
                this.result.timeZone_ = "";
                return this;
            }

            public RegRequest.Builder ClearUserName()
            {
                this.PrepareBuilder();
                this.result.hasUserName = false;
                this.result.userName_ = null;
                return this;
            }

            public override RegRequest.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new RegRequest.Builder(this.result);
                }
                return new RegRequest.Builder().MergeFrom(this.result);
            }

            public RegRequest.Builder MergeBaseRequest(micromsg.BaseRequest value)
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

            public RegRequest.Builder MergeBindEmail(SKBuiltinString_t value)
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

            public RegRequest.Builder MergeBindMobile(SKBuiltinString_t value)
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

            public override RegRequest.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override RegRequest.Builder MergeFrom(IMessageLite other)
            {
                if (other is RegRequest)
                {
                    return this.MergeFrom((RegRequest) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override RegRequest.Builder MergeFrom(RegRequest other)
            {
                return this;
            }

            public override RegRequest.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(RegRequest._regRequestFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = RegRequest._regRequestFieldTags[index];
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
                            SKBuiltinString_t.Builder builder4 = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasNickName)
                            {
                                builder4.MergeFrom(this.NickName);
                            }
                            input.ReadMessage(builder4, extensionRegistry);
                            this.NickName = builder4.BuildPartial();
                            continue;
                        }
                        case 40:
                        {
                            this.result.hasBindUin = input.ReadUInt32(ref this.result.bindUin_);
                            continue;
                        }
                        case 50:
                        {
                            SKBuiltinString_t.Builder builder5 = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasBindEmail)
                            {
                                builder5.MergeFrom(this.BindEmail);
                            }
                            input.ReadMessage(builder5, extensionRegistry);
                            this.BindEmail = builder5.BuildPartial();
                            continue;
                        }
                        case 0x3a:
                        {
                            SKBuiltinString_t.Builder builder6 = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasBindMobile)
                            {
                                builder6.MergeFrom(this.BindMobile);
                            }
                            input.ReadMessage(builder6, extensionRegistry);
                            this.BindMobile = builder6.BuildPartial();
                            continue;
                        }
                        case 0x52:
                        {
                            SKBuiltinString_t.Builder builder9 = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasTicket)
                            {
                                builder9.MergeFrom(this.Ticket);
                            }
                            input.ReadMessage(builder9, extensionRegistry);
                            this.Ticket = builder9.BuildPartial();
                            continue;
                        }
                        case 90:
                        {
                            this.result.hasPwd2 = input.ReadString(ref this.result.pwd2_);
                            continue;
                        }
                        case 0x42:
                        {
                            SKBuiltinString_t.Builder builder7 = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasImgSid)
                            {
                                builder7.MergeFrom(this.ImgSid);
                            }
                            input.ReadMessage(builder7, extensionRegistry);
                            this.ImgSid = builder7.BuildPartial();
                            continue;
                        }
                        case 0x4a:
                        {
                            SKBuiltinString_t.Builder builder8 = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasImgCode)
                            {
                                builder8.MergeFrom(this.ImgCode);
                            }
                            input.ReadMessage(builder8, extensionRegistry);
                            this.ImgCode = builder8.BuildPartial();
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
                        case 0x72:
                        {
                            this.result.hasTimeZone = input.ReadString(ref this.result.timeZone_);
                            continue;
                        }
                        case 0x7a:
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

            public RegRequest.Builder MergeImgCode(SKBuiltinString_t value)
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

            public RegRequest.Builder MergeImgSid(SKBuiltinString_t value)
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

            public RegRequest.Builder MergeNickName(SKBuiltinString_t value)
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

            public RegRequest.Builder MergePwd(SKBuiltinString_t value)
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

            public RegRequest.Builder MergeTicket(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasTicket && (this.result.ticket_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.ticket_ = SKBuiltinString_t.CreateBuilder(this.result.ticket_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.ticket_ = value;
                }
                this.result.hasTicket = true;
                return this;
            }

            public RegRequest.Builder MergeUserName(SKBuiltinString_t value)
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

            private RegRequest PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    RegRequest result = this.result;
                    this.result = new RegRequest();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public RegRequest.Builder SetBaseRequest(micromsg.BaseRequest value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = value;
                return this;
            }

            public RegRequest.Builder SetBaseRequest(micromsg.BaseRequest.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = builderForValue.Build();
                return this;
            }

            public RegRequest.Builder SetBindEmail(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBindEmail = true;
                this.result.bindEmail_ = value;
                return this;
            }

            public RegRequest.Builder SetBindEmail(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBindEmail = true;
                this.result.bindEmail_ = builderForValue.Build();
                return this;
            }

            public RegRequest.Builder SetBindMobile(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBindMobile = true;
                this.result.bindMobile_ = value;
                return this;
            }

            public RegRequest.Builder SetBindMobile(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBindMobile = true;
                this.result.bindMobile_ = builderForValue.Build();
                return this;
            }

            public RegRequest.Builder SetBindUin(uint value)
            {
                this.PrepareBuilder();
                this.result.hasBindUin = true;
                this.result.bindUin_ = value;
                return this;
            }

            public RegRequest.Builder SetBuiltinIPSeq(uint value)
            {
                this.PrepareBuilder();
                this.result.hasBuiltinIPSeq = true;
                this.result.builtinIPSeq_ = value;
                return this;
            }

            public RegRequest.Builder SetDLSrc(uint value)
            {
                this.PrepareBuilder();
                this.result.hasDLSrc = true;
                this.result.dLSrc_ = value;
                return this;
            }

            public RegRequest.Builder SetImgCode(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasImgCode = true;
                this.result.imgCode_ = value;
                return this;
            }

            public RegRequest.Builder SetImgCode(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasImgCode = true;
                this.result.imgCode_ = builderForValue.Build();
                return this;
            }

            public RegRequest.Builder SetImgSid(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasImgSid = true;
                this.result.imgSid_ = value;
                return this;
            }

            public RegRequest.Builder SetImgSid(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasImgSid = true;
                this.result.imgSid_ = builderForValue.Build();
                return this;
            }

            public RegRequest.Builder SetLanguage(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasLanguage = true;
                this.result.language_ = value;
                return this;
            }

            public RegRequest.Builder SetNickName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasNickName = true;
                this.result.nickName_ = value;
                return this;
            }

            public RegRequest.Builder SetNickName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasNickName = true;
                this.result.nickName_ = builderForValue.Build();
                return this;
            }

            public RegRequest.Builder SetPwd(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasPwd = true;
                this.result.pwd_ = value;
                return this;
            }

            public RegRequest.Builder SetPwd(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasPwd = true;
                this.result.pwd_ = builderForValue.Build();
                return this;
            }

            public RegRequest.Builder SetPwd2(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasPwd2 = true;
                this.result.pwd2_ = value;
                return this;
            }

            public RegRequest.Builder SetTicket(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasTicket = true;
                this.result.ticket_ = value;
                return this;
            }

            public RegRequest.Builder SetTicket(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasTicket = true;
                this.result.ticket_ = builderForValue.Build();
                return this;
            }

            public RegRequest.Builder SetTimeZone(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasTimeZone = true;
                this.result.timeZone_ = value;
                return this;
            }

            public RegRequest.Builder SetUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasUserName = true;
                this.result.userName_ = value;
                return this;
            }

            public RegRequest.Builder SetUserName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasUserName = true;
                this.result.userName_ = builderForValue.Build();
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

            public override RegRequest DefaultInstanceForType
            {
                get
                {
                    return RegRequest.DefaultInstance;
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

            protected override RegRequest MessageBeingBuilt
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

            protected override RegRequest.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }

            public SKBuiltinString_t Ticket
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
        }
    }
}


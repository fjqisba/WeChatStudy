namespace micromsg
{
    using Google.ProtocolBuffers;
   
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

    //
    public sealed class SendCardRequest : GeneratedMessageLite<SendCardRequest, SendCardRequest.Builder>
    {
        private static readonly string[] _sendCardRequestFieldNames = new string[] { "BaseRequest", "Content", "ContentEx", "SendCardBitFlag", "Style", "UserName" };
        private static readonly uint[] _sendCardRequestFieldTags = new uint[] { 10, 0x1a, 50, 0x20, 40, 0x12 };
        private micromsg.BaseRequest baseRequest_;
        public const int BaseRequestFieldNumber = 1;
        private string content_ = "";
        private string contentEx_ = "";
        public const int ContentExFieldNumber = 6;
        public const int ContentFieldNumber = 3;
        private static readonly SendCardRequest defaultInstance = new SendCardRequest().MakeReadOnly();
        private bool hasBaseRequest;
        private bool hasContent;
        private bool hasContentEx;
        private bool hasSendCardBitFlag;
        private bool hasStyle;
        private bool hasUserName;
        private int memoizedSerializedSize = -1;
        private uint sendCardBitFlag_;
        public const int SendCardBitFlagFieldNumber = 4;
        private uint style_;
        public const int StyleFieldNumber = 5;
        private string userName_ = "";
        public const int UserNameFieldNumber = 2;

        static SendCardRequest()
        {
            //object.ReferenceEquals(SendCardRequest.Descriptor, null);
        }

        private SendCardRequest()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(SendCardRequest prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            SendCardRequest request = obj as SendCardRequest;
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
            if ((this.hasContent != request.hasContent) || (this.hasContent && !this.content_.Equals(request.content_)))
            {
                return false;
            }
            if ((this.hasSendCardBitFlag != request.hasSendCardBitFlag) || (this.hasSendCardBitFlag && !this.sendCardBitFlag_.Equals(request.sendCardBitFlag_)))
            {
                return false;
            }
            if ((this.hasStyle != request.hasStyle) || (this.hasStyle && !this.style_.Equals(request.style_)))
            {
                return false;
            }
            return ((this.hasContentEx == request.hasContentEx) && (!this.hasContentEx || this.contentEx_.Equals(request.contentEx_)));
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
            if (this.hasContent)
            {
                hashCode ^= this.content_.GetHashCode();
            }
            if (this.hasSendCardBitFlag)
            {
                hashCode ^= this.sendCardBitFlag_.GetHashCode();
            }
            if (this.hasStyle)
            {
                hashCode ^= this.style_.GetHashCode();
            }
            if (this.hasContentEx)
            {
                hashCode ^= this.contentEx_.GetHashCode();
            }
            return hashCode;
        }

        private SendCardRequest MakeReadOnly()
        {
            return this;
        }

        public static SendCardRequest ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<SendCardRequest, Builder>.PrintField("BaseRequest", this.hasBaseRequest, this.baseRequest_, writer);
            GeneratedMessageLite<SendCardRequest, Builder>.PrintField("UserName", this.hasUserName, this.userName_, writer);
            GeneratedMessageLite<SendCardRequest, Builder>.PrintField("Content", this.hasContent, this.content_, writer);
            GeneratedMessageLite<SendCardRequest, Builder>.PrintField("SendCardBitFlag", this.hasSendCardBitFlag, this.sendCardBitFlag_, writer);
            GeneratedMessageLite<SendCardRequest, Builder>.PrintField("Style", this.hasStyle, this.style_, writer);
            GeneratedMessageLite<SendCardRequest, Builder>.PrintField("ContentEx", this.hasContentEx, this.contentEx_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _sendCardRequestFieldNames;
            if (this.hasBaseRequest)
            {
                output.WriteMessage(1, strArray[0], this.BaseRequest);
            }
            if (this.hasUserName)
            {
                output.WriteString(2, strArray[5], this.UserName);
            }
            if (this.hasContent)
            {
                output.WriteString(3, strArray[1], this.Content);
            }
            if (this.hasSendCardBitFlag)
            {
                output.WriteUInt32(4, strArray[3], this.SendCardBitFlag);
            }
            if (this.hasStyle)
            {
                output.WriteUInt32(5, strArray[4], this.Style);
            }
            if (this.hasContentEx)
            {
                output.WriteString(6, strArray[2], this.ContentEx);
            }
        }

        public micromsg.BaseRequest BaseRequest
        {
            get
            {
                return (this.baseRequest_ ?? micromsg.BaseRequest.DefaultInstance);
            }
        }

        public string Content
        {
            get
            {
                return this.content_;
            }
        }

        public string ContentEx
        {
            get
            {
                return this.contentEx_;
            }
        }

        public static SendCardRequest DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override SendCardRequest DefaultInstanceForType
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
                if (!this.BaseRequest.IsInitialized)
                {
                    return false;
                }
                return true;
            }
        }

        public uint SendCardBitFlag
        {
            get
            {
                return this.sendCardBitFlag_;
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
                    if (this.hasContent)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(3, this.Content);
                    }
                    if (this.hasSendCardBitFlag)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(4, this.SendCardBitFlag);
                    }
                    if (this.hasStyle)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(5, this.Style);
                    }
                    if (this.hasContentEx)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(6, this.ContentEx);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        public uint Style
        {
            get
            {
                return this.style_;
            }
        }

        protected override SendCardRequest ThisMessage
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

        
        public sealed class Builder : GeneratedBuilderLite<SendCardRequest, SendCardRequest.Builder>
        {
            private SendCardRequest result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = SendCardRequest.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(SendCardRequest cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override SendCardRequest BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override SendCardRequest.Builder Clear()
            {
                this.result = SendCardRequest.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public SendCardRequest.Builder ClearBaseRequest()
            {
                this.PrepareBuilder();
                this.result.hasBaseRequest = false;
                this.result.baseRequest_ = null;
                return this;
            }

            public SendCardRequest.Builder ClearContent()
            {
                this.PrepareBuilder();
                this.result.hasContent = false;
                this.result.content_ = "";
                return this;
            }

            public SendCardRequest.Builder ClearContentEx()
            {
                this.PrepareBuilder();
                this.result.hasContentEx = false;
                this.result.contentEx_ = "";
                return this;
            }

            public SendCardRequest.Builder ClearSendCardBitFlag()
            {
                this.PrepareBuilder();
                this.result.hasSendCardBitFlag = false;
                this.result.sendCardBitFlag_ = 0;
                return this;
            }

            public SendCardRequest.Builder ClearStyle()
            {
                this.PrepareBuilder();
                this.result.hasStyle = false;
                this.result.style_ = 0;
                return this;
            }

            public SendCardRequest.Builder ClearUserName()
            {
                this.PrepareBuilder();
                this.result.hasUserName = false;
                this.result.userName_ = "";
                return this;
            }

            public override SendCardRequest.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new SendCardRequest.Builder(this.result);
                }
                return new SendCardRequest.Builder().MergeFrom(this.result);
            }

            public SendCardRequest.Builder MergeBaseRequest(micromsg.BaseRequest value)
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

            public override SendCardRequest.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override SendCardRequest.Builder MergeFrom(IMessageLite other)
            {
                if (other is SendCardRequest)
                {
                    return this.MergeFrom((SendCardRequest) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override SendCardRequest.Builder MergeFrom(SendCardRequest other)
            {
                return this;
            }

            public override SendCardRequest.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(SendCardRequest._sendCardRequestFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = SendCardRequest._sendCardRequestFieldTags[index];
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
                        case 0x1a:
                        {
                            this.result.hasContent = input.ReadString(ref this.result.content_);
                            continue;
                        }
                        case 0x20:
                        {
                            this.result.hasSendCardBitFlag = input.ReadUInt32(ref this.result.sendCardBitFlag_);
                            continue;
                        }
                        case 40:
                        {
                            this.result.hasStyle = input.ReadUInt32(ref this.result.style_);
                            continue;
                        }
                        case 50:
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
                    this.result.hasContentEx = input.ReadString(ref this.result.contentEx_);
                }
                return this;
            }

            private SendCardRequest PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    SendCardRequest result = this.result;
                    this.result = new SendCardRequest();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public SendCardRequest.Builder SetBaseRequest(micromsg.BaseRequest value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = value;
                return this;
            }

            public SendCardRequest.Builder SetBaseRequest(micromsg.BaseRequest.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = builderForValue.Build();
                return this;
            }

            public SendCardRequest.Builder SetContent(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasContent = true;
                this.result.content_ = value;
                return this;
            }

            public SendCardRequest.Builder SetContentEx(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasContentEx = true;
                this.result.contentEx_ = value;
                return this;
            }

            public SendCardRequest.Builder SetSendCardBitFlag(uint value)
            {
                this.PrepareBuilder();
                this.result.hasSendCardBitFlag = true;
                this.result.sendCardBitFlag_ = value;
                return this;
            }

            public SendCardRequest.Builder SetStyle(uint value)
            {
                this.PrepareBuilder();
                this.result.hasStyle = true;
                this.result.style_ = value;
                return this;
            }

            public SendCardRequest.Builder SetUserName(string value)
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

            public string Content
            {
                get
                {
                    return this.result.Content;
                }
                set
                {
                    this.SetContent(value);
                }
            }

            public string ContentEx
            {
                get
                {
                    return this.result.ContentEx;
                }
                set
                {
                    this.SetContentEx(value);
                }
            }

            public override SendCardRequest DefaultInstanceForType
            {
                get
                {
                    return SendCardRequest.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override SendCardRequest MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public uint SendCardBitFlag
            {
                get
                {
                    return this.result.SendCardBitFlag;
                }
                set
                {
                    this.SetSendCardBitFlag(value);
                }
            }

            public uint Style
            {
                get
                {
                    return this.result.Style;
                }
                set
                {
                    this.SetStyle(value);
                }
            }

            protected override SendCardRequest.Builder ThisBuilder
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
        }
    }
}


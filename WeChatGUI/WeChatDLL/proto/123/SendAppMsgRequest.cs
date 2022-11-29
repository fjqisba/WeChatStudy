namespace micromsg
{
    using Google.ProtocolBuffers;
    
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

    //
    public sealed class SendAppMsgRequest : GeneratedMessageLite<SendAppMsgRequest, SendAppMsgRequest.Builder>
    {
        private static readonly string[] _sendAppMsgRequestFieldNames = new string[] { "BaseRequest", "CommentUrl", "Msg" };
        private static readonly uint[] _sendAppMsgRequestFieldTags = new uint[] { 10, 0x1a, 0x12 };
        private micromsg.BaseRequest baseRequest_;
        public const int BaseRequestFieldNumber = 1;
        private string commentUrl_ = "";
        public const int CommentUrlFieldNumber = 3;
        private static readonly SendAppMsgRequest defaultInstance = new SendAppMsgRequest().MakeReadOnly();
        private bool hasBaseRequest;
        private bool hasCommentUrl;
        private bool hasMsg;
        private int memoizedSerializedSize = -1;
        private AppMsg msg_;
        public const int MsgFieldNumber = 2;

        static SendAppMsgRequest()
        {
           // object.ReferenceEquals(SendAppMsgRequest.Descriptor, null);
        }

        private SendAppMsgRequest()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(SendAppMsgRequest prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            SendAppMsgRequest request = obj as SendAppMsgRequest;
            if (request == null)
            {
                return false;
            }
            if ((this.hasBaseRequest != request.hasBaseRequest) || (this.hasBaseRequest && !this.baseRequest_.Equals(request.baseRequest_)))
            {
                return false;
            }
            if ((this.hasMsg != request.hasMsg) || (this.hasMsg && !this.msg_.Equals(request.msg_)))
            {
                return false;
            }
            return ((this.hasCommentUrl == request.hasCommentUrl) && (!this.hasCommentUrl || this.commentUrl_.Equals(request.commentUrl_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasBaseRequest)
            {
                hashCode ^= this.baseRequest_.GetHashCode();
            }
            if (this.hasMsg)
            {
                hashCode ^= this.msg_.GetHashCode();
            }
            if (this.hasCommentUrl)
            {
                hashCode ^= this.commentUrl_.GetHashCode();
            }
            return hashCode;
        }

        private SendAppMsgRequest MakeReadOnly()
        {
            return this;
        }

        public static SendAppMsgRequest ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<SendAppMsgRequest, Builder>.PrintField("BaseRequest", this.hasBaseRequest, this.baseRequest_, writer);
            GeneratedMessageLite<SendAppMsgRequest, Builder>.PrintField("Msg", this.hasMsg, this.msg_, writer);
            GeneratedMessageLite<SendAppMsgRequest, Builder>.PrintField("CommentUrl", this.hasCommentUrl, this.commentUrl_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _sendAppMsgRequestFieldNames;
            if (this.hasBaseRequest)
            {
                output.WriteMessage(1, strArray[0], this.BaseRequest);
            }
            if (this.hasMsg)
            {
                output.WriteMessage(2, strArray[2], this.Msg);
            }
            if (this.hasCommentUrl)
            {
                output.WriteString(3, strArray[1], this.CommentUrl);
            }
        }

        public micromsg.BaseRequest BaseRequest
        {
            get
            {
                return (this.baseRequest_ ?? micromsg.BaseRequest.DefaultInstance);
            }
        }

        public string CommentUrl
        {
            get
            {
                return this.commentUrl_;
            }
        }

        public static SendAppMsgRequest DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override SendAppMsgRequest DefaultInstanceForType
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
                if (!this.hasMsg)
                {
                    return false;
                }
                if (!this.BaseRequest.IsInitialized)
                {
                    return false;
                }
                if (!this.Msg.IsInitialized)
                {
                    return false;
                }
                return true;
            }
        }

        public AppMsg Msg
        {
            get
            {
                return (this.msg_ ?? AppMsg.DefaultInstance);
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
                    if (this.hasMsg)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(2, this.Msg);
                    }
                    if (this.hasCommentUrl)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(3, this.CommentUrl);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override SendAppMsgRequest ThisMessage
        {
            get
            {
                return this;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<SendAppMsgRequest, SendAppMsgRequest.Builder>
        {
            private SendAppMsgRequest result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = SendAppMsgRequest.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(SendAppMsgRequest cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override SendAppMsgRequest BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override SendAppMsgRequest.Builder Clear()
            {
                this.result = SendAppMsgRequest.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public SendAppMsgRequest.Builder ClearBaseRequest()
            {
                this.PrepareBuilder();
                this.result.hasBaseRequest = false;
                this.result.baseRequest_ = null;
                return this;
            }

            public SendAppMsgRequest.Builder ClearCommentUrl()
            {
                this.PrepareBuilder();
                this.result.hasCommentUrl = false;
                this.result.commentUrl_ = "";
                return this;
            }

            public SendAppMsgRequest.Builder ClearMsg()
            {
                this.PrepareBuilder();
                this.result.hasMsg = false;
                this.result.msg_ = null;
                return this;
            }

            public override SendAppMsgRequest.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new SendAppMsgRequest.Builder(this.result);
                }
                return new SendAppMsgRequest.Builder().MergeFrom(this.result);
            }

            public SendAppMsgRequest.Builder MergeBaseRequest(micromsg.BaseRequest value)
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

            public override SendAppMsgRequest.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override SendAppMsgRequest.Builder MergeFrom(IMessageLite other)
            {
                if (other is SendAppMsgRequest)
                {
                    return this.MergeFrom((SendAppMsgRequest) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override SendAppMsgRequest.Builder MergeFrom(SendAppMsgRequest other)
            {
                return this;
            }

            public override SendAppMsgRequest.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(SendAppMsgRequest._sendAppMsgRequestFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = SendAppMsgRequest._sendAppMsgRequestFieldTags[index];
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
                            AppMsg.Builder builder2 = AppMsg.CreateBuilder();
                            if (this.result.hasMsg)
                            {
                                builder2.MergeFrom(this.Msg);
                            }
                            input.ReadMessage(builder2, extensionRegistry);
                            this.Msg = builder2.BuildPartial();
                            continue;
                        }
                        case 0x1a:
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
                    this.result.hasCommentUrl = input.ReadString(ref this.result.commentUrl_);
                }
                return this;
            }

            public SendAppMsgRequest.Builder MergeMsg(AppMsg value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasMsg && (this.result.msg_ != AppMsg.DefaultInstance))
                {
                    this.result.msg_ = AppMsg.CreateBuilder(this.result.msg_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.msg_ = value;
                }
                this.result.hasMsg = true;
                return this;
            }

            private SendAppMsgRequest PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    SendAppMsgRequest result = this.result;
                    this.result = new SendAppMsgRequest();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public SendAppMsgRequest.Builder SetBaseRequest(micromsg.BaseRequest value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = value;
                return this;
            }

            public SendAppMsgRequest.Builder SetBaseRequest(micromsg.BaseRequest.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = builderForValue.Build();
                return this;
            }

            public SendAppMsgRequest.Builder SetCommentUrl(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasCommentUrl = true;
                this.result.commentUrl_ = value;
                return this;
            }

            public SendAppMsgRequest.Builder SetMsg(AppMsg value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasMsg = true;
                this.result.msg_ = value;
                return this;
            }

            public SendAppMsgRequest.Builder SetMsg(AppMsg.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasMsg = true;
                this.result.msg_ = builderForValue.Build();
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

            public string CommentUrl
            {
                get
                {
                    return this.result.CommentUrl;
                }
                set
                {
                    this.SetCommentUrl(value);
                }
            }

            public override SendAppMsgRequest DefaultInstanceForType
            {
                get
                {
                    return SendAppMsgRequest.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override SendAppMsgRequest MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public AppMsg Msg
            {
                get
                {
                    return this.result.Msg;
                }
                set
                {
                    this.SetMsg(value);
                }
            }

            protected override SendAppMsgRequest.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


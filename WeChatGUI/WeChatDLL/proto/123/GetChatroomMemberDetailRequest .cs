namespace micromsg
{
    using Google.ProtocolBuffers;

    using System;
    using System.IO;



    public sealed class GetChatroomMemberDetailRequest : GeneratedMessageLite<GetChatroomMemberDetailRequest, GetChatroomMemberDetailRequest.Builder>
    {
        private static readonly string[] _getChatroomMemberDetailRequestFieldNames = new string[] { "BaseRequest", "ChatroomUserName", "ClientVersion" };
        private static readonly uint[] _getChatroomMemberDetailRequestFieldTags = new uint[] { 10, 0x12, 0x18 };
        private BaseRequest baseRequest_;
        public const int BaseRequestFieldNumber = 1;
        private string chatroomUserName_ = "";
        public const int ChatroomUserNameFieldNumber = 2;
        private uint clientVersion_;
        public const int ClientVersionFieldNumber = 3;
        private static readonly GetChatroomMemberDetailRequest defaultInstance = new GetChatroomMemberDetailRequest().MakeReadOnly();
        private bool hasBaseRequest;
        private bool hasChatroomUserName;
        private bool hasClientVersion;
        private int memoizedSerializedSize = -1;
 
        private GetChatroomMemberDetailRequest()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(GetChatroomMemberDetailRequest prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            GetChatroomMemberDetailRequest request = obj as GetChatroomMemberDetailRequest;
            if (request == null)
            {
                return false;
            }
            if ((this.hasBaseRequest != request.hasBaseRequest) || (this.hasBaseRequest && !this.baseRequest_.Equals(request.baseRequest_)))
            {
                return false;
            }
            if ((this.hasChatroomUserName != request.hasChatroomUserName) || (this.hasChatroomUserName && !this.chatroomUserName_.Equals(request.chatroomUserName_)))
            {
                return false;
            }
            return ((this.hasClientVersion == request.hasClientVersion) && (!this.hasClientVersion || this.clientVersion_.Equals(request.clientVersion_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasBaseRequest)
            {
                hashCode ^= this.baseRequest_.GetHashCode();
            }
            if (this.hasChatroomUserName)
            {
                hashCode ^= this.chatroomUserName_.GetHashCode();
            }
            if (this.hasClientVersion)
            {
                hashCode ^= this.clientVersion_.GetHashCode();
            }
            return hashCode;
        }

        private GetChatroomMemberDetailRequest MakeReadOnly()
        {
            return this;
        }

        public static GetChatroomMemberDetailRequest ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<GetChatroomMemberDetailRequest, Builder>.PrintField("BaseRequest", this.hasBaseRequest, this.baseRequest_, writer);
            GeneratedMessageLite<GetChatroomMemberDetailRequest, Builder>.PrintField("ChatroomUserName", this.hasChatroomUserName, this.chatroomUserName_, writer);
            GeneratedMessageLite<GetChatroomMemberDetailRequest, Builder>.PrintField("ClientVersion", this.hasClientVersion, this.clientVersion_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _getChatroomMemberDetailRequestFieldNames;
            if (this.hasBaseRequest)
            {
                output.WriteMessage(1, strArray[0], this.BaseRequest);
            }
            if (this.hasChatroomUserName)
            {
                output.WriteString(2, strArray[1], this.ChatroomUserName);
            }
            if (this.hasClientVersion)
            {
                output.WriteUInt32(3, strArray[2], this.ClientVersion);
            }
        }

        public BaseRequest BaseRequest
        {
            get
            {
                return (this.baseRequest_ ?? BaseRequest.DefaultInstance);
            }
        }

        public string ChatroomUserName
        {
            get
            {
                return this.chatroomUserName_;
            }
        }

        public uint ClientVersion
        {
            get
            {
                return this.clientVersion_;
            }
        }

        public static GetChatroomMemberDetailRequest DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override GetChatroomMemberDetailRequest DefaultInstanceForType
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
                if (!this.hasClientVersion)
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
                    if (this.hasChatroomUserName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(2, this.ChatroomUserName);
                    }
                    if (this.hasClientVersion)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(3, this.ClientVersion);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override GetChatroomMemberDetailRequest ThisMessage
        {
            get
            {
                return this;
            }
        }

 
        public sealed class Builder : GeneratedBuilderLite<GetChatroomMemberDetailRequest, GetChatroomMemberDetailRequest.Builder>
        {
            private GetChatroomMemberDetailRequest result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = GetChatroomMemberDetailRequest.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(GetChatroomMemberDetailRequest cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override GetChatroomMemberDetailRequest BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override GetChatroomMemberDetailRequest.Builder Clear()
            {
                this.result = GetChatroomMemberDetailRequest.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public GetChatroomMemberDetailRequest.Builder ClearBaseRequest()
            {
                this.PrepareBuilder();
                this.result.hasBaseRequest = false;
                this.result.baseRequest_ = null;
                return this;
            }

            public GetChatroomMemberDetailRequest.Builder ClearChatroomUserName()
            {
                this.PrepareBuilder();
                this.result.hasChatroomUserName = false;
                this.result.chatroomUserName_ = "";
                return this;
            }

            public GetChatroomMemberDetailRequest.Builder ClearClientVersion()
            {
                this.PrepareBuilder();
                this.result.hasClientVersion = false;
                this.result.clientVersion_ = 0;
                return this;
            }

            public override GetChatroomMemberDetailRequest.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new GetChatroomMemberDetailRequest.Builder(this.result);
                }
                return new GetChatroomMemberDetailRequest.Builder().MergeFrom(this.result);
            }

            public GetChatroomMemberDetailRequest.Builder MergeBaseRequest(BaseRequest value)
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

            public override GetChatroomMemberDetailRequest.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override GetChatroomMemberDetailRequest.Builder MergeFrom(IMessageLite other)
            {
                if (other is GetChatroomMemberDetailRequest)
                {
                    return this.MergeFrom((GetChatroomMemberDetailRequest) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override GetChatroomMemberDetailRequest.Builder MergeFrom(GetChatroomMemberDetailRequest other)
            {
                return this;
            }

            public override GetChatroomMemberDetailRequest.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(GetChatroomMemberDetailRequest._getChatroomMemberDetailRequestFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = GetChatroomMemberDetailRequest._getChatroomMemberDetailRequestFieldTags[index];
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
                            BaseRequest.Builder builder = BaseRequest.CreateBuilder();
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
                            this.result.hasChatroomUserName = input.ReadString(ref this.result.chatroomUserName_);
                            continue;
                        }
                        case 0x18:
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
                    this.result.hasClientVersion = input.ReadUInt32(ref this.result.clientVersion_);
                }
                return this;
            }

            private GetChatroomMemberDetailRequest PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    GetChatroomMemberDetailRequest result = this.result;
                    this.result = new GetChatroomMemberDetailRequest();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public GetChatroomMemberDetailRequest.Builder SetBaseRequest(BaseRequest value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = value;
                return this;
            }

            public GetChatroomMemberDetailRequest.Builder SetBaseRequest(BaseRequest.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = builderForValue.Build();
                return this;
            }

            public GetChatroomMemberDetailRequest.Builder SetChatroomUserName(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasChatroomUserName = true;
                this.result.chatroomUserName_ = value;
                return this;
            }

            public GetChatroomMemberDetailRequest.Builder SetClientVersion(uint value)
            {
                this.PrepareBuilder();
                this.result.hasClientVersion = true;
                this.result.clientVersion_ = value;
                return this;
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

            public string ChatroomUserName
            {
                get
                {
                    return this.result.ChatroomUserName;
                }
                set
                {
                    this.SetChatroomUserName(value);
                }
            }

            public uint ClientVersion
            {
                get
                {
                    return this.result.ClientVersion;
                }
                set
                {
                    this.SetClientVersion(value);
                }
            }

            public override GetChatroomMemberDetailRequest DefaultInstanceForType
            {
                get
                {
                    return GetChatroomMemberDetailRequest.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override GetChatroomMemberDetailRequest MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override GetChatroomMemberDetailRequest.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}

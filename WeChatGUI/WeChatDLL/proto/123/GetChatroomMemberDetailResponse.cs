namespace micromsg
{
    using Google.ProtocolBuffers;

    using System;
    using System.IO;



    public sealed class GetChatroomMemberDetailResponse : GeneratedMessageLite<GetChatroomMemberDetailResponse, GetChatroomMemberDetailResponse.Builder>
    {
        private static readonly string[] _getChatroomMemberDetailResponseFieldNames = new string[] { "BaseResponse", "ChatroomUserName", "NewChatroomData", "ServerVersion" };
        private static readonly uint[] _getChatroomMemberDetailResponseFieldTags = new uint[] { 10, 0x12, 0x22, 0x18 };
        private BaseResponse baseResponse_;
        public const int BaseResponseFieldNumber = 1;
        private string chatroomUserName_ = "";
        public const int ChatroomUserNameFieldNumber = 2;
        private static readonly GetChatroomMemberDetailResponse defaultInstance = new GetChatroomMemberDetailResponse().MakeReadOnly();
        private bool hasBaseResponse;
        private bool hasChatroomUserName;
        private bool hasNewChatroomData;
        private bool hasServerVersion;
        private int memoizedSerializedSize = -1;
        private ChatRoomMemberData newChatroomData_;
        public const int NewChatroomDataFieldNumber = 4;
        private uint serverVersion_;
        public const int ServerVersionFieldNumber = 3;

   

        private GetChatroomMemberDetailResponse()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(GetChatroomMemberDetailResponse prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            GetChatroomMemberDetailResponse response = obj as GetChatroomMemberDetailResponse;
            if (response == null)
            {
                return false;
            }
            if ((this.hasBaseResponse != response.hasBaseResponse) || (this.hasBaseResponse && !this.baseResponse_.Equals(response.baseResponse_)))
            {
                return false;
            }
            if ((this.hasChatroomUserName != response.hasChatroomUserName) || (this.hasChatroomUserName && !this.chatroomUserName_.Equals(response.chatroomUserName_)))
            {
                return false;
            }
            if ((this.hasServerVersion != response.hasServerVersion) || (this.hasServerVersion && !this.serverVersion_.Equals(response.serverVersion_)))
            {
                return false;
            }
            return ((this.hasNewChatroomData == response.hasNewChatroomData) && (!this.hasNewChatroomData || this.newChatroomData_.Equals(response.newChatroomData_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasBaseResponse)
            {
                hashCode ^= this.baseResponse_.GetHashCode();
            }
            if (this.hasChatroomUserName)
            {
                hashCode ^= this.chatroomUserName_.GetHashCode();
            }
            if (this.hasServerVersion)
            {
                hashCode ^= this.serverVersion_.GetHashCode();
            }
            if (this.hasNewChatroomData)
            {
                hashCode ^= this.newChatroomData_.GetHashCode();
            }
            return hashCode;
        }

        private GetChatroomMemberDetailResponse MakeReadOnly()
        {
            return this;
        }

        public static GetChatroomMemberDetailResponse ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<GetChatroomMemberDetailResponse, Builder>.PrintField("BaseResponse", this.hasBaseResponse, this.baseResponse_, writer);
            GeneratedMessageLite<GetChatroomMemberDetailResponse, Builder>.PrintField("ChatroomUserName", this.hasChatroomUserName, this.chatroomUserName_, writer);
            GeneratedMessageLite<GetChatroomMemberDetailResponse, Builder>.PrintField("ServerVersion", this.hasServerVersion, this.serverVersion_, writer);
            GeneratedMessageLite<GetChatroomMemberDetailResponse, Builder>.PrintField("NewChatroomData", this.hasNewChatroomData, this.newChatroomData_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _getChatroomMemberDetailResponseFieldNames;
            if (this.hasBaseResponse)
            {
                output.WriteMessage(1, strArray[0], this.BaseResponse);
            }
            if (this.hasChatroomUserName)
            {
                output.WriteString(2, strArray[1], this.ChatroomUserName);
            }
            if (this.hasServerVersion)
            {
                output.WriteUInt32(3, strArray[3], this.ServerVersion);
            }
            if (this.hasNewChatroomData)
            {
                output.WriteMessage(4, strArray[2], this.NewChatroomData);
            }
        }

        public BaseResponse BaseResponse
        {
            get
            {
                return (this.baseResponse_ ?? BaseResponse.DefaultInstance);
            }
        }

        public string ChatroomUserName
        {
            get
            {
                return this.chatroomUserName_;
            }
        }

        public static GetChatroomMemberDetailResponse DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override GetChatroomMemberDetailResponse DefaultInstanceForType
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
                if (!this.hasServerVersion)
                {
                    return false;
                }
                if (!this.hasNewChatroomData)
                {
                    return false;
                }
                if (!this.BaseResponse.IsInitialized)
                {
                    return false;
                }
                if (!this.NewChatroomData.IsInitialized)
                {
                    return false;
                }
                return true;
            }
        }

        public ChatRoomMemberData NewChatroomData
        {
            get
            {
                return (this.newChatroomData_ ?? ChatRoomMemberData.DefaultInstance);
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
                    if (this.hasChatroomUserName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(2, this.ChatroomUserName);
                    }
                    if (this.hasServerVersion)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(3, this.ServerVersion);
                    }
                    if (this.hasNewChatroomData)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(4, this.NewChatroomData);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        public uint ServerVersion
        {
            get
            {
                return this.serverVersion_;
            }
        }

        protected override GetChatroomMemberDetailResponse ThisMessage
        {
            get
            {
                return this;
            }
        }

 
        public sealed class Builder : GeneratedBuilderLite<GetChatroomMemberDetailResponse, GetChatroomMemberDetailResponse.Builder>
        {
            private GetChatroomMemberDetailResponse result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = GetChatroomMemberDetailResponse.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(GetChatroomMemberDetailResponse cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override GetChatroomMemberDetailResponse BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override GetChatroomMemberDetailResponse.Builder Clear()
            {
                this.result = GetChatroomMemberDetailResponse.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public GetChatroomMemberDetailResponse.Builder ClearBaseResponse()
            {
                this.PrepareBuilder();
                this.result.hasBaseResponse = false;
                this.result.baseResponse_ = null;
                return this;
            }

            public GetChatroomMemberDetailResponse.Builder ClearChatroomUserName()
            {
                this.PrepareBuilder();
                this.result.hasChatroomUserName = false;
                this.result.chatroomUserName_ = "";
                return this;
            }

            public GetChatroomMemberDetailResponse.Builder ClearNewChatroomData()
            {
                this.PrepareBuilder();
                this.result.hasNewChatroomData = false;
                this.result.newChatroomData_ = null;
                return this;
            }

            public GetChatroomMemberDetailResponse.Builder ClearServerVersion()
            {
                this.PrepareBuilder();
                this.result.hasServerVersion = false;
                this.result.serverVersion_ = 0;
                return this;
            }

            public override GetChatroomMemberDetailResponse.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new GetChatroomMemberDetailResponse.Builder(this.result);
                }
                return new GetChatroomMemberDetailResponse.Builder().MergeFrom(this.result);
            }

            public GetChatroomMemberDetailResponse.Builder MergeBaseResponse(BaseResponse value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasBaseResponse && (this.result.baseResponse_ != BaseResponse.DefaultInstance))
                {
                    this.result.baseResponse_ = BaseResponse.CreateBuilder(this.result.baseResponse_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.baseResponse_ = value;
                }
                this.result.hasBaseResponse = true;
                return this;
            }

            public override GetChatroomMemberDetailResponse.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override GetChatroomMemberDetailResponse.Builder MergeFrom(IMessageLite other)
            {
                if (other is GetChatroomMemberDetailResponse)
                {
                    return this.MergeFrom((GetChatroomMemberDetailResponse) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override GetChatroomMemberDetailResponse.Builder MergeFrom(GetChatroomMemberDetailResponse other)
            {
                return this;
            }

            public override GetChatroomMemberDetailResponse.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(GetChatroomMemberDetailResponse._getChatroomMemberDetailResponseFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = GetChatroomMemberDetailResponse._getChatroomMemberDetailResponseFieldTags[index];
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
                            BaseResponse.Builder builder = BaseResponse.CreateBuilder();
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
                            this.result.hasChatroomUserName = input.ReadString(ref this.result.chatroomUserName_);
                            continue;
                        }
                        case 0x18:
                        {
                            this.result.hasServerVersion = input.ReadUInt32(ref this.result.serverVersion_);
                            continue;
                        }
                        case 0x22:
                        {
                            ChatRoomMemberData.Builder builder2 = ChatRoomMemberData.CreateBuilder();
                            if (this.result.hasNewChatroomData)
                            {
                                builder2.MergeFrom(this.NewChatroomData);
                            }
                            input.ReadMessage(builder2, extensionRegistry);
                            this.NewChatroomData = builder2.BuildPartial();
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

            public GetChatroomMemberDetailResponse.Builder MergeNewChatroomData(ChatRoomMemberData value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasNewChatroomData && (this.result.newChatroomData_ != ChatRoomMemberData.DefaultInstance))
                {
                    this.result.newChatroomData_ = ChatRoomMemberData.CreateBuilder(this.result.newChatroomData_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.newChatroomData_ = value;
                }
                this.result.hasNewChatroomData = true;
                return this;
            }

            private GetChatroomMemberDetailResponse PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    GetChatroomMemberDetailResponse result = this.result;
                    this.result = new GetChatroomMemberDetailResponse();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public GetChatroomMemberDetailResponse.Builder SetBaseResponse(BaseResponse value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = value;
                return this;
            }

            public GetChatroomMemberDetailResponse.Builder SetBaseResponse(BaseResponse.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = builderForValue.Build();
                return this;
            }

            public GetChatroomMemberDetailResponse.Builder SetChatroomUserName(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasChatroomUserName = true;
                this.result.chatroomUserName_ = value;
                return this;
            }

            public GetChatroomMemberDetailResponse.Builder SetNewChatroomData(ChatRoomMemberData value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasNewChatroomData = true;
                this.result.newChatroomData_ = value;
                return this;
            }

            public GetChatroomMemberDetailResponse.Builder SetNewChatroomData(ChatRoomMemberData.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasNewChatroomData = true;
                this.result.newChatroomData_ = builderForValue.Build();
                return this;
            }

            public GetChatroomMemberDetailResponse.Builder SetServerVersion(uint value)
            {
                this.PrepareBuilder();
                this.result.hasServerVersion = true;
                this.result.serverVersion_ = value;
                return this;
            }

            public BaseResponse BaseResponse
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

            public override GetChatroomMemberDetailResponse DefaultInstanceForType
            {
                get
                {
                    return GetChatroomMemberDetailResponse.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override GetChatroomMemberDetailResponse MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public ChatRoomMemberData NewChatroomData
            {
                get
                {
                    return this.result.NewChatroomData;
                }
                set
                {
                    this.SetNewChatroomData(value);
                }
            }

            public uint ServerVersion
            {
                get
                {
                    return this.result.ServerVersion;
                }
                set
                {
                    this.SetServerVersion(value);
                }
            }

            protected override GetChatroomMemberDetailResponse.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}

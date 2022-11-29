namespace micromsg
{
    using Google.ProtocolBuffers;

    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

 
    public sealed class GroupCardResponse : GeneratedMessageLite<GroupCardResponse, GroupCardResponse.Builder>
    {
        private static readonly string[] _groupCardResponseFieldNames = new string[] { "BaseResponse", "GroupUserName" };
        private static readonly uint[] _groupCardResponseFieldTags = new uint[] { 10, 0x12 };
        private micromsg.BaseResponse baseResponse_;
        public const int BaseResponseFieldNumber = 1;
        private static readonly GroupCardResponse defaultInstance = new GroupCardResponse().MakeReadOnly();
        private string groupUserName_ = "";
        public const int GroupUserNameFieldNumber = 2;
        private bool hasBaseResponse;
        private bool hasGroupUserName;
        private int memoizedSerializedSize = -1;

        static GroupCardResponse()
        {

        }

        private GroupCardResponse()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(GroupCardResponse prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            GroupCardResponse response = obj as GroupCardResponse;
            if (response == null)
            {
                return false;
            }
            if ((this.hasBaseResponse != response.hasBaseResponse) || (this.hasBaseResponse && !this.baseResponse_.Equals(response.baseResponse_)))
            {
                return false;
            }
            return ((this.hasGroupUserName == response.hasGroupUserName) && (!this.hasGroupUserName || this.groupUserName_.Equals(response.groupUserName_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasBaseResponse)
            {
                hashCode ^= this.baseResponse_.GetHashCode();
            }
            if (this.hasGroupUserName)
            {
                hashCode ^= this.groupUserName_.GetHashCode();
            }
            return hashCode;
        }

        private GroupCardResponse MakeReadOnly()
        {
            return this;
        }

        public static GroupCardResponse ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<GroupCardResponse, Builder>.PrintField("BaseResponse", this.hasBaseResponse, this.baseResponse_, writer);
            GeneratedMessageLite<GroupCardResponse, Builder>.PrintField("GroupUserName", this.hasGroupUserName, this.groupUserName_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _groupCardResponseFieldNames;
            if (this.hasBaseResponse)
            {
                output.WriteMessage(1, strArray[0], this.BaseResponse);
            }
            if (this.hasGroupUserName)
            {
                output.WriteString(2, strArray[1], this.GroupUserName);
            }
        }

        public micromsg.BaseResponse BaseResponse
        {
            get
            {
                return (this.baseResponse_ ?? micromsg.BaseResponse.DefaultInstance);
            }
        }

        public static GroupCardResponse DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override GroupCardResponse DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public string GroupUserName
        {
            get
            {
                return this.groupUserName_;
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
                    if (this.hasGroupUserName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(2, this.GroupUserName);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override GroupCardResponse ThisMessage
        {
            get
            {
                return this;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<GroupCardResponse, GroupCardResponse.Builder>
        {
            private GroupCardResponse result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = GroupCardResponse.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(GroupCardResponse cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override GroupCardResponse BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override GroupCardResponse.Builder Clear()
            {
                this.result = GroupCardResponse.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public GroupCardResponse.Builder ClearBaseResponse()
            {
                this.PrepareBuilder();
                this.result.hasBaseResponse = false;
                this.result.baseResponse_ = null;
                return this;
            }

            public GroupCardResponse.Builder ClearGroupUserName()
            {
                this.PrepareBuilder();
                this.result.hasGroupUserName = false;
                this.result.groupUserName_ = "";
                return this;
            }

            public override GroupCardResponse.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new GroupCardResponse.Builder(this.result);
                }
                return new GroupCardResponse.Builder().MergeFrom(this.result);
            }

            public GroupCardResponse.Builder MergeBaseResponse(micromsg.BaseResponse value)
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

            public override GroupCardResponse.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override GroupCardResponse.Builder MergeFrom(IMessageLite other)
            {
                if (other is GroupCardResponse)
                {
                    return this.MergeFrom((GroupCardResponse) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override GroupCardResponse.Builder MergeFrom(GroupCardResponse other)
            {
                return this;
            }

            public override GroupCardResponse.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(GroupCardResponse._groupCardResponseFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = GroupCardResponse._groupCardResponseFieldTags[index];
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
                    this.result.hasGroupUserName = input.ReadString(ref this.result.groupUserName_);
                }
                return this;
            }

            private GroupCardResponse PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    GroupCardResponse result = this.result;
                    this.result = new GroupCardResponse();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public GroupCardResponse.Builder SetBaseResponse(micromsg.BaseResponse value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = value;
                return this;
            }

            public GroupCardResponse.Builder SetBaseResponse(micromsg.BaseResponse.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = builderForValue.Build();
                return this;
            }

            public GroupCardResponse.Builder SetGroupUserName(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasGroupUserName = true;
                this.result.groupUserName_ = value;
                return this;
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

            public override GroupCardResponse DefaultInstanceForType
            {
                get
                {
                    return GroupCardResponse.DefaultInstance;
                }
            }

            public string GroupUserName
            {
                get
                {
                    return this.result.GroupUserName;
                }
                set
                {
                    this.SetGroupUserName(value);
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override GroupCardResponse MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override GroupCardResponse.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


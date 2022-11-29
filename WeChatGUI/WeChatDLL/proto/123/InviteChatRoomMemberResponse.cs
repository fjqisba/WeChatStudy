namespace micromsg
{
    using Google.ProtocolBuffers;

    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

    
    public sealed class InviteChatRoomMemberResponse : GeneratedMessageLite<InviteChatRoomMemberResponse, InviteChatRoomMemberResponse.Builder>
    {
        private static readonly string[] _inviteChatRoomMemberResponseFieldNames = new string[] { "BaseResponse" };
        private static readonly uint[] _inviteChatRoomMemberResponseFieldTags = new uint[] { 10 };
        private BaseResponse baseResponse_;
        public const int BaseResponseFieldNumber = 1;
        private static readonly InviteChatRoomMemberResponse defaultInstance = new InviteChatRoomMemberResponse().MakeReadOnly();
        private bool hasBaseResponse;
        private int memoizedSerializedSize = -1;

        static InviteChatRoomMemberResponse()
        {
            
        }

        private InviteChatRoomMemberResponse()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(InviteChatRoomMemberResponse prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            InviteChatRoomMemberResponse response = obj as InviteChatRoomMemberResponse;
            if (response == null)
            {
                return false;
            }
            return ((this.hasBaseResponse == response.hasBaseResponse) && (!this.hasBaseResponse || this.baseResponse_.Equals(response.baseResponse_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasBaseResponse)
            {
                hashCode ^= this.baseResponse_.GetHashCode();
            }
            return hashCode;
        }

        private InviteChatRoomMemberResponse MakeReadOnly()
        {
            return this;
        }

        public static InviteChatRoomMemberResponse ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<InviteChatRoomMemberResponse, Builder>.PrintField("BaseResponse", this.hasBaseResponse, this.baseResponse_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _inviteChatRoomMemberResponseFieldNames;
            if (this.hasBaseResponse)
            {
                output.WriteMessage(1, strArray[0], this.BaseResponse);
            }
        }

        public micromsg.BaseResponse BaseResponse
        {
            get
            {
                return (this.baseResponse_ ?? micromsg.BaseResponse.DefaultInstance);
            }
        }

        public static InviteChatRoomMemberResponse DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override InviteChatRoomMemberResponse DefaultInstanceForType
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
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override InviteChatRoomMemberResponse ThisMessage
        {
            get
            {
                return this;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<InviteChatRoomMemberResponse, InviteChatRoomMemberResponse.Builder>
        {
            private InviteChatRoomMemberResponse result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = InviteChatRoomMemberResponse.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(InviteChatRoomMemberResponse cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override InviteChatRoomMemberResponse BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override InviteChatRoomMemberResponse.Builder Clear()
            {
                this.result = InviteChatRoomMemberResponse.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public InviteChatRoomMemberResponse.Builder ClearBaseResponse()
            {
                this.PrepareBuilder();
                this.result.hasBaseResponse = false;
                this.result.baseResponse_ = null;
                return this;
            }

            public override InviteChatRoomMemberResponse.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new InviteChatRoomMemberResponse.Builder(this.result);
                }
                return new InviteChatRoomMemberResponse.Builder().MergeFrom(this.result);
            }

            public InviteChatRoomMemberResponse.Builder MergeBaseResponse(micromsg.BaseResponse value)
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

            public override InviteChatRoomMemberResponse.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override InviteChatRoomMemberResponse.Builder MergeFrom(IMessageLite other)
            {
                if (other is InviteChatRoomMemberResponse)
                {
                    return this.MergeFrom((InviteChatRoomMemberResponse) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override InviteChatRoomMemberResponse.Builder MergeFrom(InviteChatRoomMemberResponse other)
            {
                return this;
            }

            public override InviteChatRoomMemberResponse.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(InviteChatRoomMemberResponse._inviteChatRoomMemberResponseFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = InviteChatRoomMemberResponse._inviteChatRoomMemberResponseFieldTags[index];
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
                    }
                    if (WireFormat.IsEndGroupTag(num))
                    {
                        return this;
                    }
                    this.ParseUnknownField(input, extensionRegistry, num, str);
                }
                return this;
            }

            private InviteChatRoomMemberResponse PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    InviteChatRoomMemberResponse result = this.result;
                    this.result = new InviteChatRoomMemberResponse();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public InviteChatRoomMemberResponse.Builder SetBaseResponse(micromsg.BaseResponse value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = value;
                return this;
            }

            public InviteChatRoomMemberResponse.Builder SetBaseResponse(micromsg.BaseResponse.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = builderForValue.Build();
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

            public override InviteChatRoomMemberResponse DefaultInstanceForType
            {
                get
                {
                    return InviteChatRoomMemberResponse.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override InviteChatRoomMemberResponse MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override InviteChatRoomMemberResponse.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}

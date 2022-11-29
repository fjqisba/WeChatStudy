namespace micromsg
{
    using Google.ProtocolBuffers;
    using Google.ProtocolBuffers.Collections;

    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    


    public sealed class DelChatRoomMemberRequest : GeneratedMessageLite<DelChatRoomMemberRequest, DelChatRoomMemberRequest.Builder>
    {
        private static readonly string[] _delChatRoomMemberRequestFieldNames = new string[] { "BaseRequest", "ChatRoomName", "MemberCount", "MemberList" };
        private static readonly uint[] _delChatRoomMemberRequestFieldTags = new uint[] { 10, 0x22, 0x10, 0x1a };
        private micromsg.BaseRequest baseRequest_;
        public const int BaseRequestFieldNumber = 1;
        private string chatRoomName_ = "";
        public const int ChatRoomNameFieldNumber = 4;
        private static readonly DelChatRoomMemberRequest defaultInstance = new DelChatRoomMemberRequest().MakeReadOnly();
        private bool hasBaseRequest;
        private bool hasChatRoomName;
        private bool hasMemberCount;
        private uint memberCount_;
        public const int MemberCountFieldNumber = 2;
        private PopsicleList<DelMemberReq> memberList_ = new PopsicleList<DelMemberReq>();
        public const int MemberListFieldNumber = 3;
        private int memoizedSerializedSize = -1;

        static DelChatRoomMemberRequest()
        {
        }

        private DelChatRoomMemberRequest()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(DelChatRoomMemberRequest prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            DelChatRoomMemberRequest request = obj as DelChatRoomMemberRequest;
            if (request == null)
            {
                return false;
            }
            if ((this.hasBaseRequest != request.hasBaseRequest) || (this.hasBaseRequest && !this.baseRequest_.Equals(request.baseRequest_)))
            {
                return false;
            }
            if ((this.hasMemberCount != request.hasMemberCount) || (this.hasMemberCount && !this.memberCount_.Equals(request.memberCount_)))
            {
                return false;
            }
            if (this.memberList_.Count != request.memberList_.Count)
            {
                return false;
            }
            for (int i = 0; i < this.memberList_.Count; i++)
            {
                if (!this.memberList_[i].Equals(request.memberList_[i]))
                {
                    return false;
                }
            }
            return ((this.hasChatRoomName == request.hasChatRoomName) && (!this.hasChatRoomName || this.chatRoomName_.Equals(request.chatRoomName_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasBaseRequest)
            {
                hashCode ^= this.baseRequest_.GetHashCode();
            }
            if (this.hasMemberCount)
            {
                hashCode ^= this.memberCount_.GetHashCode();
            }
            foreach (DelMemberReq req in this.memberList_)
            {
                hashCode ^= req.GetHashCode();
            }
            if (this.hasChatRoomName)
            {
                hashCode ^= this.chatRoomName_.GetHashCode();
            }
            return hashCode;
        }

        public DelMemberReq GetMemberList(int index)
        {
            return this.memberList_[index];
        }

        private DelChatRoomMemberRequest MakeReadOnly()
        {
            this.memberList_.MakeReadOnly();
            return this;
        }

        public static DelChatRoomMemberRequest ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<DelChatRoomMemberRequest, Builder>.PrintField("BaseRequest", this.hasBaseRequest, this.baseRequest_, writer);
            GeneratedMessageLite<DelChatRoomMemberRequest, Builder>.PrintField("MemberCount", this.hasMemberCount, this.memberCount_, writer);
            GeneratedMessageLite<DelChatRoomMemberRequest, Builder>.PrintField<DelMemberReq>("MemberList", this.memberList_, writer);
            GeneratedMessageLite<DelChatRoomMemberRequest, Builder>.PrintField("ChatRoomName", this.hasChatRoomName, this.chatRoomName_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _delChatRoomMemberRequestFieldNames;
            if (this.hasBaseRequest)
            {
                output.WriteMessage(1, strArray[0], this.BaseRequest);
            }
            if (this.hasMemberCount)
            {
                output.WriteUInt32(2, strArray[2], this.MemberCount);
            }
            if (this.memberList_.Count > 0)
            {
                output.WriteMessageArray<DelMemberReq>(3, strArray[3], this.memberList_);
            }
            if (this.hasChatRoomName)
            {
                output.WriteString(4, strArray[1], this.ChatRoomName);
            }
        }

        public micromsg.BaseRequest BaseRequest
        {
            get
            {
                return (this.baseRequest_ ?? micromsg.BaseRequest.DefaultInstance);
            }
        }

        public string ChatRoomName
        {
            get
            {
                return this.chatRoomName_;
            }
        }

        public static DelChatRoomMemberRequest DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override DelChatRoomMemberRequest DefaultInstanceForType
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
                if (!this.hasMemberCount)
                {
                    return false;
                }
                if (!this.BaseRequest.IsInitialized)
                {
                    return false;
                }
                foreach (DelMemberReq req in this.MemberListList)
                {
                    if (!req.IsInitialized)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public uint MemberCount
        {
            get
            {
                return this.memberCount_;
            }
        }

        public int MemberListCount
        {
            get
            {
                return this.memberList_.Count;
            }
        }

        public IList<DelMemberReq> MemberListList
        {
            get
            {
                return this.memberList_;
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
                    if (this.hasMemberCount)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(2, this.MemberCount);
                    }
                    foreach (DelMemberReq req in this.MemberListList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(3, req);
                    }
                    if (this.hasChatRoomName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(4, this.ChatRoomName);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override DelChatRoomMemberRequest ThisMessage
        {
            get
            {
                return this;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<DelChatRoomMemberRequest, DelChatRoomMemberRequest.Builder>
        {
            private DelChatRoomMemberRequest result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = DelChatRoomMemberRequest.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(DelChatRoomMemberRequest cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public DelChatRoomMemberRequest.Builder AddMemberList(DelMemberReq value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.memberList_.Add(value);
                return this;
            }

            public DelChatRoomMemberRequest.Builder AddMemberList(DelMemberReq.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.memberList_.Add(builderForValue.Build());
                return this;
            }

            public DelChatRoomMemberRequest.Builder AddRangeMemberList(IEnumerable<DelMemberReq> values)
            {
                this.PrepareBuilder();
                this.result.memberList_.Add(values);
                return this;
            }

            public override DelChatRoomMemberRequest BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override DelChatRoomMemberRequest.Builder Clear()
            {
                this.result = DelChatRoomMemberRequest.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public DelChatRoomMemberRequest.Builder ClearBaseRequest()
            {
                this.PrepareBuilder();
                this.result.hasBaseRequest = false;
                this.result.baseRequest_ = null;
                return this;
            }

            public DelChatRoomMemberRequest.Builder ClearChatRoomName()
            {
                this.PrepareBuilder();
                this.result.hasChatRoomName = false;
                this.result.chatRoomName_ = "";
                return this;
            }

            public DelChatRoomMemberRequest.Builder ClearMemberCount()
            {
                this.PrepareBuilder();
                this.result.hasMemberCount = false;
                this.result.memberCount_ = 0;
                return this;
            }

            public DelChatRoomMemberRequest.Builder ClearMemberList()
            {
                this.PrepareBuilder();
                this.result.memberList_.Clear();
                return this;
            }

            public override DelChatRoomMemberRequest.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new DelChatRoomMemberRequest.Builder(this.result);
                }
                return new DelChatRoomMemberRequest.Builder().MergeFrom(this.result);
            }

            public DelMemberReq GetMemberList(int index)
            {
                return this.result.GetMemberList(index);
            }

            public DelChatRoomMemberRequest.Builder MergeBaseRequest(micromsg.BaseRequest value)
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

            public override DelChatRoomMemberRequest.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override DelChatRoomMemberRequest.Builder MergeFrom(IMessageLite other)
            {
                if (other is DelChatRoomMemberRequest)
                {
                    return this.MergeFrom((DelChatRoomMemberRequest) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override DelChatRoomMemberRequest.Builder MergeFrom(DelChatRoomMemberRequest other)
            {
                return this;
            }

            public override DelChatRoomMemberRequest.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(DelChatRoomMemberRequest._delChatRoomMemberRequestFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = DelChatRoomMemberRequest._delChatRoomMemberRequestFieldTags[index];
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
                        case 0x10:
                        {
                            this.result.hasMemberCount = input.ReadUInt32(ref this.result.memberCount_);
                            continue;
                        }
                        case 0x1a:
                        {
                            input.ReadMessageArray<DelMemberReq>(num, str, this.result.memberList_, DelMemberReq.DefaultInstance, extensionRegistry);
                            continue;
                        }
                        case 0x22:
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
                    this.result.hasChatRoomName = input.ReadString(ref this.result.chatRoomName_);
                }
                return this;
            }

            private DelChatRoomMemberRequest PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    DelChatRoomMemberRequest result = this.result;
                    this.result = new DelChatRoomMemberRequest();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public DelChatRoomMemberRequest.Builder SetBaseRequest(micromsg.BaseRequest value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = value;
                return this;
            }

            public DelChatRoomMemberRequest.Builder SetBaseRequest(micromsg.BaseRequest.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = builderForValue.Build();
                return this;
            }

            public DelChatRoomMemberRequest.Builder SetChatRoomName(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasChatRoomName = true;
                this.result.chatRoomName_ = value;
                return this;
            }

            public DelChatRoomMemberRequest.Builder SetMemberCount(uint value)
            {
                this.PrepareBuilder();
                this.result.hasMemberCount = true;
                this.result.memberCount_ = value;
                return this;
            }

            public DelChatRoomMemberRequest.Builder SetMemberList(int index, DelMemberReq value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.memberList_[index] = value;
                return this;
            }

            public DelChatRoomMemberRequest.Builder SetMemberList(int index, DelMemberReq.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.memberList_[index] = builderForValue.Build();
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

            public string ChatRoomName
            {
                get
                {
                    return this.result.ChatRoomName;
                }
                set
                {
                    this.SetChatRoomName(value);
                }
            }

            public override DelChatRoomMemberRequest DefaultInstanceForType
            {
                get
                {
                    return DelChatRoomMemberRequest.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            public uint MemberCount
            {
                get
                {
                    return this.result.MemberCount;
                }
                set
                {
                    this.SetMemberCount(value);
                }
            }

            public int MemberListCount
            {
                get
                {
                    return this.result.MemberListCount;
                }
            }

            public IPopsicleList<DelMemberReq> MemberListList
            {
                get
                {
                    return this.PrepareBuilder().memberList_;
                }
            }

            protected override DelChatRoomMemberRequest MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override DelChatRoomMemberRequest.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


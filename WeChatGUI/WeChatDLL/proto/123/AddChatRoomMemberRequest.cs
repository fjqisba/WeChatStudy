namespace micromsg
{
    using Google.ProtocolBuffers;
    using Google.ProtocolBuffers.Collections;

    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    

   
    public sealed class AddChatRoomMemberRequest : GeneratedMessageLite<AddChatRoomMemberRequest, AddChatRoomMemberRequest.Builder>
    {
        private static readonly string[] _addChatRoomMemberRequestFieldNames = new string[] { "BaseRequest", "ChatRoomName", "MemberCount", "MemberList" };
        private static readonly uint[] _addChatRoomMemberRequestFieldTags = new uint[] { 10, 0x22, 0x10, 0x1a };
        private micromsg.BaseRequest baseRequest_;
        public const int BaseRequestFieldNumber = 1;
        private SKBuiltinString_t chatRoomName_;
        public const int ChatRoomNameFieldNumber = 4;
        private static readonly AddChatRoomMemberRequest defaultInstance = new AddChatRoomMemberRequest().MakeReadOnly();
        private bool hasBaseRequest;
        private bool hasChatRoomName;
        private bool hasMemberCount;
        private uint memberCount_;
        public const int MemberCountFieldNumber = 2;
        private PopsicleList<MemberReq> memberList_ = new PopsicleList<MemberReq>();
        public const int MemberListFieldNumber = 3;
        private int memoizedSerializedSize = -1;

        static AddChatRoomMemberRequest()
        {

        }

        private AddChatRoomMemberRequest()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(AddChatRoomMemberRequest prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            AddChatRoomMemberRequest request = obj as AddChatRoomMemberRequest;
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
            foreach (MemberReq req in this.memberList_)
            {
                hashCode ^= req.GetHashCode();
            }
            if (this.hasChatRoomName)
            {
                hashCode ^= this.chatRoomName_.GetHashCode();
            }
            return hashCode;
        }

        public MemberReq GetMemberList(int index)
        {
            return this.memberList_[index];
        }

        private AddChatRoomMemberRequest MakeReadOnly()
        {
            this.memberList_.MakeReadOnly();
            return this;
        }

        public static AddChatRoomMemberRequest ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<AddChatRoomMemberRequest, Builder>.PrintField("BaseRequest", this.hasBaseRequest, this.baseRequest_, writer);
            GeneratedMessageLite<AddChatRoomMemberRequest, Builder>.PrintField("MemberCount", this.hasMemberCount, this.memberCount_, writer);
            GeneratedMessageLite<AddChatRoomMemberRequest, Builder>.PrintField<MemberReq>("MemberList", this.memberList_, writer);
            GeneratedMessageLite<AddChatRoomMemberRequest, Builder>.PrintField("ChatRoomName", this.hasChatRoomName, this.chatRoomName_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _addChatRoomMemberRequestFieldNames;
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
                output.WriteMessageArray<MemberReq>(3, strArray[3], this.memberList_);
            }
            if (this.hasChatRoomName)
            {
                output.WriteMessage(4, strArray[1], this.ChatRoomName);
            }
        }

        public micromsg.BaseRequest BaseRequest
        {
            get
            {
                return (this.baseRequest_ ?? micromsg.BaseRequest.DefaultInstance);
            }
        }

        public SKBuiltinString_t ChatRoomName
        {
            get
            {
                return (this.chatRoomName_ ?? SKBuiltinString_t.DefaultInstance);
            }
        }

        public static AddChatRoomMemberRequest DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override AddChatRoomMemberRequest DefaultInstanceForType
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
                if (!this.hasChatRoomName)
                {
                    return false;
                }
                if (!this.BaseRequest.IsInitialized)
                {
                    return false;
                }
                foreach (MemberReq req in this.MemberListList)
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

        public IList<MemberReq> MemberListList
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
                    foreach (MemberReq req in this.MemberListList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(3, req);
                    }
                    if (this.hasChatRoomName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(4, this.ChatRoomName);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override AddChatRoomMemberRequest ThisMessage
        {
            get
            {
                return this;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<AddChatRoomMemberRequest, AddChatRoomMemberRequest.Builder>
        {
            private AddChatRoomMemberRequest result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = AddChatRoomMemberRequest.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(AddChatRoomMemberRequest cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public AddChatRoomMemberRequest.Builder AddMemberList(MemberReq value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.memberList_.Add(value);
                return this;
            }

            public AddChatRoomMemberRequest.Builder AddMemberList(MemberReq.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.memberList_.Add(builderForValue.Build());
                return this;
            }

            public AddChatRoomMemberRequest.Builder AddRangeMemberList(IEnumerable<MemberReq> values)
            {
                this.PrepareBuilder();
                this.result.memberList_.Add(values);
                return this;
            }

            public override AddChatRoomMemberRequest BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override AddChatRoomMemberRequest.Builder Clear()
            {
                this.result = AddChatRoomMemberRequest.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public AddChatRoomMemberRequest.Builder ClearBaseRequest()
            {
                this.PrepareBuilder();
                this.result.hasBaseRequest = false;
                this.result.baseRequest_ = null;
                return this;
            }

            public AddChatRoomMemberRequest.Builder ClearChatRoomName()
            {
                this.PrepareBuilder();
                this.result.hasChatRoomName = false;
                this.result.chatRoomName_ = null;
                return this;
            }

            public AddChatRoomMemberRequest.Builder ClearMemberCount()
            {
                this.PrepareBuilder();
                this.result.hasMemberCount = false;
                this.result.memberCount_ = 0;
                return this;
            }

            public AddChatRoomMemberRequest.Builder ClearMemberList()
            {
                this.PrepareBuilder();
                this.result.memberList_.Clear();
                return this;
            }

            public override AddChatRoomMemberRequest.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new AddChatRoomMemberRequest.Builder(this.result);
                }
                return new AddChatRoomMemberRequest.Builder().MergeFrom(this.result);
            }

            public MemberReq GetMemberList(int index)
            {
                return this.result.GetMemberList(index);
            }

            public AddChatRoomMemberRequest.Builder MergeBaseRequest(micromsg.BaseRequest value)
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

            public AddChatRoomMemberRequest.Builder MergeChatRoomName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasChatRoomName && (this.result.chatRoomName_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.chatRoomName_ = SKBuiltinString_t.CreateBuilder(this.result.chatRoomName_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.chatRoomName_ = value;
                }
                this.result.hasChatRoomName = true;
                return this;
            }

            public override AddChatRoomMemberRequest.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override AddChatRoomMemberRequest.Builder MergeFrom(IMessageLite other)
            {
                if (other is AddChatRoomMemberRequest)
                {
                    return this.MergeFrom((AddChatRoomMemberRequest) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override AddChatRoomMemberRequest.Builder MergeFrom(AddChatRoomMemberRequest other)
            {
                return this;
            }

            public override AddChatRoomMemberRequest.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(AddChatRoomMemberRequest._addChatRoomMemberRequestFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = AddChatRoomMemberRequest._addChatRoomMemberRequestFieldTags[index];
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
                            input.ReadMessageArray<MemberReq>(num, str, this.result.memberList_, MemberReq.DefaultInstance, extensionRegistry);
                            continue;
                        }
                        case 0x22:
                        {
                            SKBuiltinString_t.Builder builder2 = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasChatRoomName)
                            {
                                builder2.MergeFrom(this.ChatRoomName);
                            }
                            input.ReadMessage(builder2, extensionRegistry);
                            this.ChatRoomName = builder2.BuildPartial();
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

            private AddChatRoomMemberRequest PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    AddChatRoomMemberRequest result = this.result;
                    this.result = new AddChatRoomMemberRequest();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public AddChatRoomMemberRequest.Builder SetBaseRequest(micromsg.BaseRequest value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = value;
                return this;
            }

            public AddChatRoomMemberRequest.Builder SetBaseRequest(micromsg.BaseRequest.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = builderForValue.Build();
                return this;
            }

            public AddChatRoomMemberRequest.Builder SetChatRoomName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasChatRoomName = true;
                this.result.chatRoomName_ = value;
                return this;
            }

            public AddChatRoomMemberRequest.Builder SetChatRoomName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasChatRoomName = true;
                this.result.chatRoomName_ = builderForValue.Build();
                return this;
            }

            public AddChatRoomMemberRequest.Builder SetMemberCount(uint value)
            {
                this.PrepareBuilder();
                this.result.hasMemberCount = true;
                this.result.memberCount_ = value;
                return this;
            }

            public AddChatRoomMemberRequest.Builder SetMemberList(int index, MemberReq value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.memberList_[index] = value;
                return this;
            }

            public AddChatRoomMemberRequest.Builder SetMemberList(int index, MemberReq.Builder builderForValue)
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

            public SKBuiltinString_t ChatRoomName
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

            public override AddChatRoomMemberRequest DefaultInstanceForType
            {
                get
                {
                    return AddChatRoomMemberRequest.DefaultInstance;
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

            public IPopsicleList<MemberReq> MemberListList
            {
                get
                {
                    return this.PrepareBuilder().memberList_;
                }
            }

            protected override AddChatRoomMemberRequest MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override AddChatRoomMemberRequest.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


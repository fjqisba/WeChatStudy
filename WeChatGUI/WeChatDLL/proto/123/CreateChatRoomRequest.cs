namespace micromsg
{
    using Google.ProtocolBuffers;
    using Google.ProtocolBuffers.Collections;

    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    

   
    public sealed class CreateChatRoomRequest : GeneratedMessageLite<CreateChatRoomRequest, CreateChatRoomRequest.Builder>
    {
        private static readonly string[] _createChatRoomRequestFieldNames = new string[] { "BaseRequest", "MemberCount", "MemberList", "Topic" };
        private static readonly uint[] _createChatRoomRequestFieldTags = new uint[] { 10, 0x18, 0x22, 0x12 };
        private micromsg.BaseRequest baseRequest_;
        public const int BaseRequestFieldNumber = 1;
        private static readonly CreateChatRoomRequest defaultInstance = new CreateChatRoomRequest().MakeReadOnly();
        private bool hasBaseRequest;
        private bool hasMemberCount;
        private bool hasTopic;
        private uint memberCount_;
        public const int MemberCountFieldNumber = 3;
        private PopsicleList<MemberReq> memberList_ = new PopsicleList<MemberReq>();
        public const int MemberListFieldNumber = 4;
        private int memoizedSerializedSize = -1;
        private SKBuiltinString_t topic_;
        public const int TopicFieldNumber = 2;

        static CreateChatRoomRequest()
        {

        }

        private CreateChatRoomRequest()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(CreateChatRoomRequest prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            CreateChatRoomRequest request = obj as CreateChatRoomRequest;
            if (request == null)
            {
                return false;
            }
            if ((this.hasBaseRequest != request.hasBaseRequest) || (this.hasBaseRequest && !this.baseRequest_.Equals(request.baseRequest_)))
            {
                return false;
            }
            if ((this.hasTopic != request.hasTopic) || (this.hasTopic && !this.topic_.Equals(request.topic_)))
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
            return true;
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasBaseRequest)
            {
                hashCode ^= this.baseRequest_.GetHashCode();
            }
            if (this.hasTopic)
            {
                hashCode ^= this.topic_.GetHashCode();
            }
            if (this.hasMemberCount)
            {
                hashCode ^= this.memberCount_.GetHashCode();
            }
            foreach (MemberReq req in this.memberList_)
            {
                hashCode ^= req.GetHashCode();
            }
            return hashCode;
        }

        public MemberReq GetMemberList(int index)
        {
            return this.memberList_[index];
        }

        private CreateChatRoomRequest MakeReadOnly()
        {
            this.memberList_.MakeReadOnly();
            return this;
        }

        public static CreateChatRoomRequest ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<CreateChatRoomRequest, Builder>.PrintField("BaseRequest", this.hasBaseRequest, this.baseRequest_, writer);
            GeneratedMessageLite<CreateChatRoomRequest, Builder>.PrintField("Topic", this.hasTopic, this.topic_, writer);
            GeneratedMessageLite<CreateChatRoomRequest, Builder>.PrintField("MemberCount", this.hasMemberCount, this.memberCount_, writer);
            GeneratedMessageLite<CreateChatRoomRequest, Builder>.PrintField<MemberReq>("MemberList", this.memberList_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _createChatRoomRequestFieldNames;
            if (this.hasBaseRequest)
            {
                output.WriteMessage(1, strArray[0], this.BaseRequest);
            }
            if (this.hasTopic)
            {
                output.WriteMessage(2, strArray[3], this.Topic);
            }
            if (this.hasMemberCount)
            {
                output.WriteUInt32(3, strArray[1], this.MemberCount);
            }
            if (this.memberList_.Count > 0)
            {
                output.WriteMessageArray<MemberReq>(4, strArray[2], this.memberList_);
            }
        }

        public micromsg.BaseRequest BaseRequest
        {
            get
            {
                return (this.baseRequest_ ?? micromsg.BaseRequest.DefaultInstance);
            }
        }

        public static CreateChatRoomRequest DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override CreateChatRoomRequest DefaultInstanceForType
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
                if (!this.hasTopic)
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
                    if (this.hasTopic)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(2, this.Topic);
                    }
                    if (this.hasMemberCount)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(3, this.MemberCount);
                    }
                    foreach (MemberReq req in this.MemberListList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(4, req);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override CreateChatRoomRequest ThisMessage
        {
            get
            {
                return this;
            }
        }

        public SKBuiltinString_t Topic
        {
            get
            {
                return (this.topic_ ?? SKBuiltinString_t.DefaultInstance);
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<CreateChatRoomRequest, CreateChatRoomRequest.Builder>
        {
            private CreateChatRoomRequest result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = CreateChatRoomRequest.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(CreateChatRoomRequest cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public CreateChatRoomRequest.Builder AddMemberList(MemberReq value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.memberList_.Add(value);
                return this;
            }

            public CreateChatRoomRequest.Builder AddMemberList(MemberReq.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.memberList_.Add(builderForValue.Build());
                return this;
            }

            public CreateChatRoomRequest.Builder AddRangeMemberList(IEnumerable<MemberReq> values)
            {
                this.PrepareBuilder();
                this.result.memberList_.Add(values);
                return this;
            }

            public override CreateChatRoomRequest BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override CreateChatRoomRequest.Builder Clear()
            {
                this.result = CreateChatRoomRequest.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public CreateChatRoomRequest.Builder ClearBaseRequest()
            {
                this.PrepareBuilder();
                this.result.hasBaseRequest = false;
                this.result.baseRequest_ = null;
                return this;
            }

            public CreateChatRoomRequest.Builder ClearMemberCount()
            {
                this.PrepareBuilder();
                this.result.hasMemberCount = false;
                this.result.memberCount_ = 0;
                return this;
            }

            public CreateChatRoomRequest.Builder ClearMemberList()
            {
                this.PrepareBuilder();
                this.result.memberList_.Clear();
                return this;
            }

            public CreateChatRoomRequest.Builder ClearTopic()
            {
                this.PrepareBuilder();
                this.result.hasTopic = false;
                this.result.topic_ = null;
                return this;
            }

            public override CreateChatRoomRequest.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new CreateChatRoomRequest.Builder(this.result);
                }
                return new CreateChatRoomRequest.Builder().MergeFrom(this.result);
            }

            public MemberReq GetMemberList(int index)
            {
                return this.result.GetMemberList(index);
            }

            public CreateChatRoomRequest.Builder MergeBaseRequest(micromsg.BaseRequest value)
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

            public override CreateChatRoomRequest.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override CreateChatRoomRequest.Builder MergeFrom(IMessageLite other)
            {
                if (other is CreateChatRoomRequest)
                {
                    return this.MergeFrom((CreateChatRoomRequest) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override CreateChatRoomRequest.Builder MergeFrom(CreateChatRoomRequest other)
            {
                return this;
            }

            public override CreateChatRoomRequest.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(CreateChatRoomRequest._createChatRoomRequestFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = CreateChatRoomRequest._createChatRoomRequestFieldTags[index];
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
                            SKBuiltinString_t.Builder builder2 = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasTopic)
                            {
                                builder2.MergeFrom(this.Topic);
                            }
                            input.ReadMessage(builder2, extensionRegistry);
                            this.Topic = builder2.BuildPartial();
                            continue;
                        }
                        case 0x18:
                        {
                            this.result.hasMemberCount = input.ReadUInt32(ref this.result.memberCount_);
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
                    input.ReadMessageArray<MemberReq>(num, str, this.result.memberList_, MemberReq.DefaultInstance, extensionRegistry);
                }
                return this;
            }

            public CreateChatRoomRequest.Builder MergeTopic(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasTopic && (this.result.topic_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.topic_ = SKBuiltinString_t.CreateBuilder(this.result.topic_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.topic_ = value;
                }
                this.result.hasTopic = true;
                return this;
            }

            private CreateChatRoomRequest PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    CreateChatRoomRequest result = this.result;
                    this.result = new CreateChatRoomRequest();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public CreateChatRoomRequest.Builder SetBaseRequest(micromsg.BaseRequest value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = value;
                return this;
            }

            public CreateChatRoomRequest.Builder SetBaseRequest(micromsg.BaseRequest.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = builderForValue.Build();
                return this;
            }

            public CreateChatRoomRequest.Builder SetMemberCount(uint value)
            {
                this.PrepareBuilder();
                this.result.hasMemberCount = true;
                this.result.memberCount_ = value;
                return this;
            }

            public CreateChatRoomRequest.Builder SetMemberList(int index, MemberReq value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.memberList_[index] = value;
                return this;
            }

            public CreateChatRoomRequest.Builder SetMemberList(int index, MemberReq.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.memberList_[index] = builderForValue.Build();
                return this;
            }

            public CreateChatRoomRequest.Builder SetTopic(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasTopic = true;
                this.result.topic_ = value;
                return this;
            }

            public CreateChatRoomRequest.Builder SetTopic(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasTopic = true;
                this.result.topic_ = builderForValue.Build();
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

            public override CreateChatRoomRequest DefaultInstanceForType
            {
                get
                {
                    return CreateChatRoomRequest.DefaultInstance;
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

            protected override CreateChatRoomRequest MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override CreateChatRoomRequest.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }

            public SKBuiltinString_t Topic
            {
                get
                {
                    return this.result.Topic;
                }
                set
                {
                    this.SetTopic(value);
                }
            }
        }
    }
}


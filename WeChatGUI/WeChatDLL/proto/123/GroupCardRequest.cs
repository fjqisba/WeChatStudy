namespace micromsg
{
    using Google.ProtocolBuffers;
    using Google.ProtocolBuffers.Collections;

    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    

    public sealed class GroupCardRequest : GeneratedMessageLite<GroupCardRequest, GroupCardRequest.Builder>
    {
        private static readonly string[] _groupCardRequestFieldNames = new string[] { "BaseRequest", "GroupNickName", "GroupUserName", "MemberCount", "MemberList", "OpCode" };
        private static readonly uint[] _groupCardRequestFieldTags = new uint[] { 10, 0x1a, 50, 0x20, 0x2a, 0x10 };
        private micromsg.BaseRequest baseRequest_;
        public const int BaseRequestFieldNumber = 1;
        private static readonly GroupCardRequest defaultInstance = new GroupCardRequest().MakeReadOnly();
        private string groupNickName_ = "";
        public const int GroupNickNameFieldNumber = 3;
        private string groupUserName_ = "";
        public const int GroupUserNameFieldNumber = 6;
        private bool hasBaseRequest;
        private bool hasGroupNickName;
        private bool hasGroupUserName;
        private bool hasMemberCount;
        private bool hasOpCode;
        private uint memberCount_;
        public const int MemberCountFieldNumber = 4;
        private PopsicleList<RoomInfo> memberList_ = new PopsicleList<RoomInfo>();
        public const int MemberListFieldNumber = 5;
        private int memoizedSerializedSize = -1;
        private uint opCode_;
        public const int OpCodeFieldNumber = 2;

        static GroupCardRequest()
        {

        }

        private GroupCardRequest()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(GroupCardRequest prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            GroupCardRequest request = obj as GroupCardRequest;
            if (request == null)
            {
                return false;
            }
            if ((this.hasBaseRequest != request.hasBaseRequest) || (this.hasBaseRequest && !this.baseRequest_.Equals(request.baseRequest_)))
            {
                return false;
            }
            if ((this.hasOpCode != request.hasOpCode) || (this.hasOpCode && !this.opCode_.Equals(request.opCode_)))
            {
                return false;
            }
            if ((this.hasGroupNickName != request.hasGroupNickName) || (this.hasGroupNickName && !this.groupNickName_.Equals(request.groupNickName_)))
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
            return ((this.hasGroupUserName == request.hasGroupUserName) && (!this.hasGroupUserName || this.groupUserName_.Equals(request.groupUserName_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasBaseRequest)
            {
                hashCode ^= this.baseRequest_.GetHashCode();
            }
            if (this.hasOpCode)
            {
                hashCode ^= this.opCode_.GetHashCode();
            }
            if (this.hasGroupNickName)
            {
                hashCode ^= this.groupNickName_.GetHashCode();
            }
            if (this.hasMemberCount)
            {
                hashCode ^= this.memberCount_.GetHashCode();
            }
            foreach (RoomInfo info in this.memberList_)
            {
                hashCode ^= info.GetHashCode();
            }
            if (this.hasGroupUserName)
            {
                hashCode ^= this.groupUserName_.GetHashCode();
            }
            return hashCode;
        }

        public RoomInfo GetMemberList(int index)
        {
            return this.memberList_[index];
        }

        private GroupCardRequest MakeReadOnly()
        {
            this.memberList_.MakeReadOnly();
            return this;
        }

        public static GroupCardRequest ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<GroupCardRequest, Builder>.PrintField("BaseRequest", this.hasBaseRequest, this.baseRequest_, writer);
            GeneratedMessageLite<GroupCardRequest, Builder>.PrintField("OpCode", this.hasOpCode, this.opCode_, writer);
            GeneratedMessageLite<GroupCardRequest, Builder>.PrintField("GroupNickName", this.hasGroupNickName, this.groupNickName_, writer);
            GeneratedMessageLite<GroupCardRequest, Builder>.PrintField("MemberCount", this.hasMemberCount, this.memberCount_, writer);
            GeneratedMessageLite<GroupCardRequest, Builder>.PrintField<RoomInfo>("MemberList", this.memberList_, writer);
            GeneratedMessageLite<GroupCardRequest, Builder>.PrintField("GroupUserName", this.hasGroupUserName, this.groupUserName_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _groupCardRequestFieldNames;
            if (this.hasBaseRequest)
            {
                output.WriteMessage(1, strArray[0], this.BaseRequest);
            }
            if (this.hasOpCode)
            {
                output.WriteUInt32(2, strArray[5], this.OpCode);
            }
            if (this.hasGroupNickName)
            {
                output.WriteString(3, strArray[1], this.GroupNickName);
            }
            if (this.hasMemberCount)
            {
                output.WriteUInt32(4, strArray[3], this.MemberCount);
            }
            if (this.memberList_.Count > 0)
            {
                output.WriteMessageArray<RoomInfo>(5, strArray[4], this.memberList_);
            }
            if (this.hasGroupUserName)
            {
                output.WriteString(6, strArray[2], this.GroupUserName);
            }
        }

        public micromsg.BaseRequest BaseRequest
        {
            get
            {
                return (this.baseRequest_ ?? micromsg.BaseRequest.DefaultInstance);
            }
        }

        public static GroupCardRequest DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override GroupCardRequest DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public string GroupNickName
        {
            get
            {
                return this.groupNickName_;
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
                if (!this.hasBaseRequest)
                {
                    return false;
                }
                if (!this.hasOpCode)
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
                foreach (RoomInfo info in this.MemberListList)
                {
                    if (!info.IsInitialized)
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

        public IList<RoomInfo> MemberListList
        {
            get
            {
                return this.memberList_;
            }
        }

        public uint OpCode
        {
            get
            {
                return this.opCode_;
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
                    if (this.hasOpCode)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(2, this.OpCode);
                    }
                    if (this.hasGroupNickName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(3, this.GroupNickName);
                    }
                    if (this.hasMemberCount)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(4, this.MemberCount);
                    }
                    foreach (RoomInfo info in this.MemberListList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(5, info);
                    }
                    if (this.hasGroupUserName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(6, this.GroupUserName);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override GroupCardRequest ThisMessage
        {
            get
            {
                return this;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<GroupCardRequest, GroupCardRequest.Builder>
        {
            private GroupCardRequest result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = GroupCardRequest.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(GroupCardRequest cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public GroupCardRequest.Builder AddMemberList(RoomInfo value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.memberList_.Add(value);
                return this;
            }

            public GroupCardRequest.Builder AddMemberList(RoomInfo.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.memberList_.Add(builderForValue.Build());
                return this;
            }

            public GroupCardRequest.Builder AddRangeMemberList(IEnumerable<RoomInfo> values)
            {
                this.PrepareBuilder();
                this.result.memberList_.Add(values);
                return this;
            }

            public override GroupCardRequest BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override GroupCardRequest.Builder Clear()
            {
                this.result = GroupCardRequest.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public GroupCardRequest.Builder ClearBaseRequest()
            {
                this.PrepareBuilder();
                this.result.hasBaseRequest = false;
                this.result.baseRequest_ = null;
                return this;
            }

            public GroupCardRequest.Builder ClearGroupNickName()
            {
                this.PrepareBuilder();
                this.result.hasGroupNickName = false;
                this.result.groupNickName_ = "";
                return this;
            }

            public GroupCardRequest.Builder ClearGroupUserName()
            {
                this.PrepareBuilder();
                this.result.hasGroupUserName = false;
                this.result.groupUserName_ = "";
                return this;
            }

            public GroupCardRequest.Builder ClearMemberCount()
            {
                this.PrepareBuilder();
                this.result.hasMemberCount = false;
                this.result.memberCount_ = 0;
                return this;
            }

            public GroupCardRequest.Builder ClearMemberList()
            {
                this.PrepareBuilder();
                this.result.memberList_.Clear();
                return this;
            }

            public GroupCardRequest.Builder ClearOpCode()
            {
                this.PrepareBuilder();
                this.result.hasOpCode = false;
                this.result.opCode_ = 0;
                return this;
            }

            public override GroupCardRequest.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new GroupCardRequest.Builder(this.result);
                }
                return new GroupCardRequest.Builder().MergeFrom(this.result);
            }

            public RoomInfo GetMemberList(int index)
            {
                return this.result.GetMemberList(index);
            }

            public GroupCardRequest.Builder MergeBaseRequest(micromsg.BaseRequest value)
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

            public override GroupCardRequest.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override GroupCardRequest.Builder MergeFrom(IMessageLite other)
            {
                if (other is GroupCardRequest)
                {
                    return this.MergeFrom((GroupCardRequest) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override GroupCardRequest.Builder MergeFrom(GroupCardRequest other)
            {
                return this;
            }

            public override GroupCardRequest.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(GroupCardRequest._groupCardRequestFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = GroupCardRequest._groupCardRequestFieldTags[index];
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
                            this.result.hasOpCode = input.ReadUInt32(ref this.result.opCode_);
                            continue;
                        }
                        case 0x1a:
                        {
                            this.result.hasGroupNickName = input.ReadString(ref this.result.groupNickName_);
                            continue;
                        }
                        case 0x20:
                        {
                            this.result.hasMemberCount = input.ReadUInt32(ref this.result.memberCount_);
                            continue;
                        }
                        case 0x2a:
                        {
                            input.ReadMessageArray<RoomInfo>(num, str, this.result.memberList_, RoomInfo.DefaultInstance, extensionRegistry);
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
                    this.result.hasGroupUserName = input.ReadString(ref this.result.groupUserName_);
                }
                return this;
            }

            private GroupCardRequest PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    GroupCardRequest result = this.result;
                    this.result = new GroupCardRequest();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public GroupCardRequest.Builder SetBaseRequest(micromsg.BaseRequest value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = value;
                return this;
            }

            public GroupCardRequest.Builder SetBaseRequest(micromsg.BaseRequest.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = builderForValue.Build();
                return this;
            }

            public GroupCardRequest.Builder SetGroupNickName(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasGroupNickName = true;
                this.result.groupNickName_ = value;
                return this;
            }

            public GroupCardRequest.Builder SetGroupUserName(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasGroupUserName = true;
                this.result.groupUserName_ = value;
                return this;
            }

            public GroupCardRequest.Builder SetMemberCount(uint value)
            {
                this.PrepareBuilder();
                this.result.hasMemberCount = true;
                this.result.memberCount_ = value;
                return this;
            }

            public GroupCardRequest.Builder SetMemberList(int index, RoomInfo value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.memberList_[index] = value;
                return this;
            }

            public GroupCardRequest.Builder SetMemberList(int index, RoomInfo.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.memberList_[index] = builderForValue.Build();
                return this;
            }

            public GroupCardRequest.Builder SetOpCode(uint value)
            {
                this.PrepareBuilder();
                this.result.hasOpCode = true;
                this.result.opCode_ = value;
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

            public override GroupCardRequest DefaultInstanceForType
            {
                get
                {
                    return GroupCardRequest.DefaultInstance;
                }
            }

            public string GroupNickName
            {
                get
                {
                    return this.result.GroupNickName;
                }
                set
                {
                    this.SetGroupNickName(value);
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

            public IPopsicleList<RoomInfo> MemberListList
            {
                get
                {
                    return this.PrepareBuilder().memberList_;
                }
            }

            protected override GroupCardRequest MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public uint OpCode
            {
                get
                {
                    return this.result.OpCode;
                }
                set
                {
                    this.SetOpCode(value);
                }
            }

            protected override GroupCardRequest.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


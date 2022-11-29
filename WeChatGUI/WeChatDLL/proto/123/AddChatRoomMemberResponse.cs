namespace micromsg
{
    using Google.ProtocolBuffers;
    using Google.ProtocolBuffers.Collections;
   
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    

    //
    public sealed class AddChatRoomMemberResponse : GeneratedMessageLite<AddChatRoomMemberResponse, AddChatRoomMemberResponse.Builder>
    {
        private static readonly string[] _addChatRoomMemberResponseFieldNames = new string[] { "BaseResponse", "MemberCount", "MemberList" };
        private static readonly uint[] _addChatRoomMemberResponseFieldTags = new uint[] { 10, 0x10, 0x1a };
        private micromsg.BaseResponse baseResponse_;
        public const int BaseResponseFieldNumber = 1;
        private static readonly AddChatRoomMemberResponse defaultInstance = new AddChatRoomMemberResponse().MakeReadOnly();
        private bool hasBaseResponse;
        private bool hasMemberCount;
        private uint memberCount_;
        public const int MemberCountFieldNumber = 2;
        private PopsicleList<MemberResp> memberList_ = new PopsicleList<MemberResp>();
        public const int MemberListFieldNumber = 3;
        private int memoizedSerializedSize = -1;

        static AddChatRoomMemberResponse()
        {
           // object.ReferenceEquals(AddChatRoomMemberResponse.Descriptor, null);
        }

        private AddChatRoomMemberResponse()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(AddChatRoomMemberResponse prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            AddChatRoomMemberResponse response = obj as AddChatRoomMemberResponse;
            if (response == null)
            {
                return false;
            }
            if ((this.hasBaseResponse != response.hasBaseResponse) || (this.hasBaseResponse && !this.baseResponse_.Equals(response.baseResponse_)))
            {
                return false;
            }
            if ((this.hasMemberCount != response.hasMemberCount) || (this.hasMemberCount && !this.memberCount_.Equals(response.memberCount_)))
            {
                return false;
            }
            if (this.memberList_.Count != response.memberList_.Count)
            {
                return false;
            }
            for (int i = 0; i < this.memberList_.Count; i++)
            {
                if (!this.memberList_[i].Equals(response.memberList_[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasBaseResponse)
            {
                hashCode ^= this.baseResponse_.GetHashCode();
            }
            if (this.hasMemberCount)
            {
                hashCode ^= this.memberCount_.GetHashCode();
            }
            foreach (MemberResp resp in this.memberList_)
            {
                hashCode ^= resp.GetHashCode();
            }
            return hashCode;
        }

        public MemberResp GetMemberList(int index)
        {
            return this.memberList_[index];
        }

        private AddChatRoomMemberResponse MakeReadOnly()
        {
            this.memberList_.MakeReadOnly();
            return this;
        }

        public static AddChatRoomMemberResponse ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<AddChatRoomMemberResponse, Builder>.PrintField("BaseResponse", this.hasBaseResponse, this.baseResponse_, writer);
            GeneratedMessageLite<AddChatRoomMemberResponse, Builder>.PrintField("MemberCount", this.hasMemberCount, this.memberCount_, writer);
            GeneratedMessageLite<AddChatRoomMemberResponse, Builder>.PrintField<MemberResp>("MemberList", this.memberList_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _addChatRoomMemberResponseFieldNames;
            if (this.hasBaseResponse)
            {
                output.WriteMessage(1, strArray[0], this.BaseResponse);
            }
            if (this.hasMemberCount)
            {
                output.WriteUInt32(2, strArray[1], this.MemberCount);
            }
            if (this.memberList_.Count > 0)
            {
                output.WriteMessageArray<MemberResp>(3, strArray[2], this.memberList_);
            }
        }

        public micromsg.BaseResponse BaseResponse
        {
            get
            {
                return (this.baseResponse_ ?? micromsg.BaseResponse.DefaultInstance);
            }
        }

        public static AddChatRoomMemberResponse DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override AddChatRoomMemberResponse DefaultInstanceForType
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
                if (!this.hasMemberCount)
                {
                    return false;
                }
                if (!this.BaseResponse.IsInitialized)
                {
                    return false;
                }
                foreach (MemberResp resp in this.MemberListList)
                {
                    if (!resp.IsInitialized)
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

        public IList<MemberResp> MemberListList
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
                    if (this.hasBaseResponse)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(1, this.BaseResponse);
                    }
                    if (this.hasMemberCount)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(2, this.MemberCount);
                    }
                    foreach (MemberResp resp in this.MemberListList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(3, resp);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override AddChatRoomMemberResponse ThisMessage
        {
            get
            {
                return this;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<AddChatRoomMemberResponse, AddChatRoomMemberResponse.Builder>
        {
            private AddChatRoomMemberResponse result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = AddChatRoomMemberResponse.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(AddChatRoomMemberResponse cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public AddChatRoomMemberResponse.Builder AddMemberList(MemberResp value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.memberList_.Add(value);
                return this;
            }

            public AddChatRoomMemberResponse.Builder AddMemberList(MemberResp.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.memberList_.Add(builderForValue.Build());
                return this;
            }

            public AddChatRoomMemberResponse.Builder AddRangeMemberList(IEnumerable<MemberResp> values)
            {
                this.PrepareBuilder();
                this.result.memberList_.Add(values);
                return this;
            }

            public override AddChatRoomMemberResponse BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override AddChatRoomMemberResponse.Builder Clear()
            {
                this.result = AddChatRoomMemberResponse.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public AddChatRoomMemberResponse.Builder ClearBaseResponse()
            {
                this.PrepareBuilder();
                this.result.hasBaseResponse = false;
                this.result.baseResponse_ = null;
                return this;
            }

            public AddChatRoomMemberResponse.Builder ClearMemberCount()
            {
                this.PrepareBuilder();
                this.result.hasMemberCount = false;
                this.result.memberCount_ = 0;
                return this;
            }

            public AddChatRoomMemberResponse.Builder ClearMemberList()
            {
                this.PrepareBuilder();
                this.result.memberList_.Clear();
                return this;
            }

            public override AddChatRoomMemberResponse.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new AddChatRoomMemberResponse.Builder(this.result);
                }
                return new AddChatRoomMemberResponse.Builder().MergeFrom(this.result);
            }

            public MemberResp GetMemberList(int index)
            {
                return this.result.GetMemberList(index);
            }

            public AddChatRoomMemberResponse.Builder MergeBaseResponse(micromsg.BaseResponse value)
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

            public override AddChatRoomMemberResponse.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override AddChatRoomMemberResponse.Builder MergeFrom(IMessageLite other)
            {
                if (other is AddChatRoomMemberResponse)
                {
                    return this.MergeFrom((AddChatRoomMemberResponse) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override AddChatRoomMemberResponse.Builder MergeFrom(AddChatRoomMemberResponse other)
            {
                return this;
            }

            public override AddChatRoomMemberResponse.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(AddChatRoomMemberResponse._addChatRoomMemberResponseFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = AddChatRoomMemberResponse._addChatRoomMemberResponseFieldTags[index];
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
                        case 0x10:
                        {
                            this.result.hasMemberCount = input.ReadUInt32(ref this.result.memberCount_);
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
                    input.ReadMessageArray<MemberResp>(num, str, this.result.memberList_, MemberResp.DefaultInstance, extensionRegistry);
                }
                return this;
            }

            private AddChatRoomMemberResponse PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    AddChatRoomMemberResponse result = this.result;
                    this.result = new AddChatRoomMemberResponse();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public AddChatRoomMemberResponse.Builder SetBaseResponse(micromsg.BaseResponse value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = value;
                return this;
            }

            public AddChatRoomMemberResponse.Builder SetBaseResponse(micromsg.BaseResponse.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = builderForValue.Build();
                return this;
            }

            public AddChatRoomMemberResponse.Builder SetMemberCount(uint value)
            {
                this.PrepareBuilder();
                this.result.hasMemberCount = true;
                this.result.memberCount_ = value;
                return this;
            }

            public AddChatRoomMemberResponse.Builder SetMemberList(int index, MemberResp value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.memberList_[index] = value;
                return this;
            }

            public AddChatRoomMemberResponse.Builder SetMemberList(int index, MemberResp.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.memberList_[index] = builderForValue.Build();
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

            public override AddChatRoomMemberResponse DefaultInstanceForType
            {
                get
                {
                    return AddChatRoomMemberResponse.DefaultInstance;
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

            public IPopsicleList<MemberResp> MemberListList
            {
                get
                {
                    return this.PrepareBuilder().memberList_;
                }
            }

            protected override AddChatRoomMemberResponse MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override AddChatRoomMemberResponse.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


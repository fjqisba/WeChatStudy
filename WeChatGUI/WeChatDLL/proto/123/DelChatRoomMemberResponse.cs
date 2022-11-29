namespace micromsg
{
    using Google.ProtocolBuffers;
    using Google.ProtocolBuffers.Collections;

    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    


    public sealed class DelChatRoomMemberResponse : GeneratedMessageLite<DelChatRoomMemberResponse, DelChatRoomMemberResponse.Builder>
    {
        private static readonly string[] _delChatRoomMemberResponseFieldNames = new string[] { "BaseResponse", "MemberCount", "MemberList" };
        private static readonly uint[] _delChatRoomMemberResponseFieldTags = new uint[] { 10, 0x10, 0x1a };
        private micromsg.BaseResponse baseResponse_;
        public const int BaseResponseFieldNumber = 1;
        private static readonly DelChatRoomMemberResponse defaultInstance = new DelChatRoomMemberResponse().MakeReadOnly();
        private bool hasBaseResponse;
        private bool hasMemberCount;
        private uint memberCount_;
        public const int MemberCountFieldNumber = 2;
        private PopsicleList<DelMemberResp> memberList_ = new PopsicleList<DelMemberResp>();
        public const int MemberListFieldNumber = 3;
        private int memoizedSerializedSize = -1;

        static DelChatRoomMemberResponse()
        {
      
        }

        private DelChatRoomMemberResponse()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(DelChatRoomMemberResponse prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            DelChatRoomMemberResponse response = obj as DelChatRoomMemberResponse;
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
            foreach (DelMemberResp resp in this.memberList_)
            {
                hashCode ^= resp.GetHashCode();
            }
            return hashCode;
        }

        public DelMemberResp GetMemberList(int index)
        {
            return this.memberList_[index];
        }

        private DelChatRoomMemberResponse MakeReadOnly()
        {
            this.memberList_.MakeReadOnly();
            return this;
        }

        public static DelChatRoomMemberResponse ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<DelChatRoomMemberResponse, Builder>.PrintField("BaseResponse", this.hasBaseResponse, this.baseResponse_, writer);
            GeneratedMessageLite<DelChatRoomMemberResponse, Builder>.PrintField("MemberCount", this.hasMemberCount, this.memberCount_, writer);
            GeneratedMessageLite<DelChatRoomMemberResponse, Builder>.PrintField<DelMemberResp>("MemberList", this.memberList_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _delChatRoomMemberResponseFieldNames;
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
                output.WriteMessageArray<DelMemberResp>(3, strArray[2], this.memberList_);
            }
        }

        public micromsg.BaseResponse BaseResponse
        {
            get
            {
                return (this.baseResponse_ ?? micromsg.BaseResponse.DefaultInstance);
            }
        }

        public static DelChatRoomMemberResponse DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override DelChatRoomMemberResponse DefaultInstanceForType
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
                foreach (DelMemberResp resp in this.MemberListList)
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

        public IList<DelMemberResp> MemberListList
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
                    foreach (DelMemberResp resp in this.MemberListList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(3, resp);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override DelChatRoomMemberResponse ThisMessage
        {
            get
            {
                return this;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<DelChatRoomMemberResponse, DelChatRoomMemberResponse.Builder>
        {
            private DelChatRoomMemberResponse result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = DelChatRoomMemberResponse.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(DelChatRoomMemberResponse cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public DelChatRoomMemberResponse.Builder AddMemberList(DelMemberResp value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.memberList_.Add(value);
                return this;
            }

            public DelChatRoomMemberResponse.Builder AddMemberList(DelMemberResp.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.memberList_.Add(builderForValue.Build());
                return this;
            }

            public DelChatRoomMemberResponse.Builder AddRangeMemberList(IEnumerable<DelMemberResp> values)
            {
                this.PrepareBuilder();
                this.result.memberList_.Add(values);
                return this;
            }

            public override DelChatRoomMemberResponse BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override DelChatRoomMemberResponse.Builder Clear()
            {
                this.result = DelChatRoomMemberResponse.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public DelChatRoomMemberResponse.Builder ClearBaseResponse()
            {
                this.PrepareBuilder();
                this.result.hasBaseResponse = false;
                this.result.baseResponse_ = null;
                return this;
            }

            public DelChatRoomMemberResponse.Builder ClearMemberCount()
            {
                this.PrepareBuilder();
                this.result.hasMemberCount = false;
                this.result.memberCount_ = 0;
                return this;
            }

            public DelChatRoomMemberResponse.Builder ClearMemberList()
            {
                this.PrepareBuilder();
                this.result.memberList_.Clear();
                return this;
            }

            public override DelChatRoomMemberResponse.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new DelChatRoomMemberResponse.Builder(this.result);
                }
                return new DelChatRoomMemberResponse.Builder().MergeFrom(this.result);
            }

            public DelMemberResp GetMemberList(int index)
            {
                return this.result.GetMemberList(index);
            }

            public DelChatRoomMemberResponse.Builder MergeBaseResponse(micromsg.BaseResponse value)
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

            public override DelChatRoomMemberResponse.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override DelChatRoomMemberResponse.Builder MergeFrom(IMessageLite other)
            {
                if (other is DelChatRoomMemberResponse)
                {
                    return this.MergeFrom((DelChatRoomMemberResponse) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override DelChatRoomMemberResponse.Builder MergeFrom(DelChatRoomMemberResponse other)
            {
                return this;
            }

            public override DelChatRoomMemberResponse.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(DelChatRoomMemberResponse._delChatRoomMemberResponseFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = DelChatRoomMemberResponse._delChatRoomMemberResponseFieldTags[index];
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
                    input.ReadMessageArray<DelMemberResp>(num, str, this.result.memberList_, DelMemberResp.DefaultInstance, extensionRegistry);
                }
                return this;
            }

            private DelChatRoomMemberResponse PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    DelChatRoomMemberResponse result = this.result;
                    this.result = new DelChatRoomMemberResponse();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public DelChatRoomMemberResponse.Builder SetBaseResponse(micromsg.BaseResponse value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = value;
                return this;
            }

            public DelChatRoomMemberResponse.Builder SetBaseResponse(micromsg.BaseResponse.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = builderForValue.Build();
                return this;
            }

            public DelChatRoomMemberResponse.Builder SetMemberCount(uint value)
            {
                this.PrepareBuilder();
                this.result.hasMemberCount = true;
                this.result.memberCount_ = value;
                return this;
            }

            public DelChatRoomMemberResponse.Builder SetMemberList(int index, DelMemberResp value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.memberList_[index] = value;
                return this;
            }

            public DelChatRoomMemberResponse.Builder SetMemberList(int index, DelMemberResp.Builder builderForValue)
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

            public override DelChatRoomMemberResponse DefaultInstanceForType
            {
                get
                {
                    return DelChatRoomMemberResponse.DefaultInstance;
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

            public IPopsicleList<DelMemberResp> MemberListList
            {
                get
                {
                    return this.PrepareBuilder().memberList_;
                }
            }

            protected override DelChatRoomMemberResponse MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override DelChatRoomMemberResponse.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


namespace micromsg
{
    using Google.ProtocolBuffers;
    using Google.ProtocolBuffers.Collections;

    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    

   
    public sealed class CreateChatRoomResponse : GeneratedMessageLite<CreateChatRoomResponse, CreateChatRoomResponse.Builder>
    {
        private static readonly string[] _createChatRoomResponseFieldNames = new string[] { "BaseResponse", "BigHeadImgUrl", "ChatRoomName", "ImgBuf", "MemberCount", "MemberList", "PYInitial", "QuanPin", "SmallHeadImgUrl", "Topic" };
        private static readonly uint[] _createChatRoomResponseFieldTags = new uint[] { 10, 0x4a, 0x3a, 0x42, 40, 50, 0x1a, 0x22, 0x52, 0x12 };
        private micromsg.BaseResponse baseResponse_;
        public const int BaseResponseFieldNumber = 1;
        private string bigHeadImgUrl_ = "";
        public const int BigHeadImgUrlFieldNumber = 9;
        private SKBuiltinString_t chatRoomName_;
        public const int ChatRoomNameFieldNumber = 7;
        private static readonly CreateChatRoomResponse defaultInstance = new CreateChatRoomResponse().MakeReadOnly();
        private bool hasBaseResponse;
        private bool hasBigHeadImgUrl;
        private bool hasChatRoomName;
        private bool hasImgBuf;
        private bool hasMemberCount;
        private bool hasPYInitial;
        private bool hasQuanPin;
        private bool hasSmallHeadImgUrl;
        private bool hasTopic;
        private SKBuiltinBuffer_t imgBuf_;
        public const int ImgBufFieldNumber = 8;
        private uint memberCount_;
        public const int MemberCountFieldNumber = 5;
        private PopsicleList<MemberResp> memberList_ = new PopsicleList<MemberResp>();
        public const int MemberListFieldNumber = 6;
        private int memoizedSerializedSize = -1;
        private SKBuiltinString_t pYInitial_;
        public const int PYInitialFieldNumber = 3;
        private SKBuiltinString_t quanPin_;
        public const int QuanPinFieldNumber = 4;
        private string smallHeadImgUrl_ = "";
        public const int SmallHeadImgUrlFieldNumber = 10;
        private SKBuiltinString_t topic_;
        public const int TopicFieldNumber = 2;

        static CreateChatRoomResponse()
        {

        }

        private CreateChatRoomResponse()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(CreateChatRoomResponse prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            CreateChatRoomResponse response = obj as CreateChatRoomResponse;
            if (response == null)
            {
                return false;
            }
            if ((this.hasBaseResponse != response.hasBaseResponse) || (this.hasBaseResponse && !this.baseResponse_.Equals(response.baseResponse_)))
            {
                return false;
            }
            if ((this.hasTopic != response.hasTopic) || (this.hasTopic && !this.topic_.Equals(response.topic_)))
            {
                return false;
            }
            if ((this.hasPYInitial != response.hasPYInitial) || (this.hasPYInitial && !this.pYInitial_.Equals(response.pYInitial_)))
            {
                return false;
            }
            if ((this.hasQuanPin != response.hasQuanPin) || (this.hasQuanPin && !this.quanPin_.Equals(response.quanPin_)))
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
            if ((this.hasChatRoomName != response.hasChatRoomName) || (this.hasChatRoomName && !this.chatRoomName_.Equals(response.chatRoomName_)))
            {
                return false;
            }
            if ((this.hasImgBuf != response.hasImgBuf) || (this.hasImgBuf && !this.imgBuf_.Equals(response.imgBuf_)))
            {
                return false;
            }
            if ((this.hasBigHeadImgUrl != response.hasBigHeadImgUrl) || (this.hasBigHeadImgUrl && !this.bigHeadImgUrl_.Equals(response.bigHeadImgUrl_)))
            {
                return false;
            }
            return ((this.hasSmallHeadImgUrl == response.hasSmallHeadImgUrl) && (!this.hasSmallHeadImgUrl || this.smallHeadImgUrl_.Equals(response.smallHeadImgUrl_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasBaseResponse)
            {
                hashCode ^= this.baseResponse_.GetHashCode();
            }
            if (this.hasTopic)
            {
                hashCode ^= this.topic_.GetHashCode();
            }
            if (this.hasPYInitial)
            {
                hashCode ^= this.pYInitial_.GetHashCode();
            }
            if (this.hasQuanPin)
            {
                hashCode ^= this.quanPin_.GetHashCode();
            }
            if (this.hasMemberCount)
            {
                hashCode ^= this.memberCount_.GetHashCode();
            }
            foreach (MemberResp resp in this.memberList_)
            {
                hashCode ^= resp.GetHashCode();
            }
            if (this.hasChatRoomName)
            {
                hashCode ^= this.chatRoomName_.GetHashCode();
            }
            if (this.hasImgBuf)
            {
                hashCode ^= this.imgBuf_.GetHashCode();
            }
            if (this.hasBigHeadImgUrl)
            {
                hashCode ^= this.bigHeadImgUrl_.GetHashCode();
            }
            if (this.hasSmallHeadImgUrl)
            {
                hashCode ^= this.smallHeadImgUrl_.GetHashCode();
            }
            return hashCode;
        }

        public MemberResp GetMemberList(int index)
        {
            return this.memberList_[index];
        }

        private CreateChatRoomResponse MakeReadOnly()
        {
            this.memberList_.MakeReadOnly();
            return this;
        }

        public static CreateChatRoomResponse ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<CreateChatRoomResponse, Builder>.PrintField("BaseResponse", this.hasBaseResponse, this.baseResponse_, writer);
            GeneratedMessageLite<CreateChatRoomResponse, Builder>.PrintField("Topic", this.hasTopic, this.topic_, writer);
            GeneratedMessageLite<CreateChatRoomResponse, Builder>.PrintField("PYInitial", this.hasPYInitial, this.pYInitial_, writer);
            GeneratedMessageLite<CreateChatRoomResponse, Builder>.PrintField("QuanPin", this.hasQuanPin, this.quanPin_, writer);
            GeneratedMessageLite<CreateChatRoomResponse, Builder>.PrintField("MemberCount", this.hasMemberCount, this.memberCount_, writer);
            GeneratedMessageLite<CreateChatRoomResponse, Builder>.PrintField<MemberResp>("MemberList", this.memberList_, writer);
            GeneratedMessageLite<CreateChatRoomResponse, Builder>.PrintField("ChatRoomName", this.hasChatRoomName, this.chatRoomName_, writer);
            GeneratedMessageLite<CreateChatRoomResponse, Builder>.PrintField("ImgBuf", this.hasImgBuf, this.imgBuf_, writer);
            GeneratedMessageLite<CreateChatRoomResponse, Builder>.PrintField("BigHeadImgUrl", this.hasBigHeadImgUrl, this.bigHeadImgUrl_, writer);
            GeneratedMessageLite<CreateChatRoomResponse, Builder>.PrintField("SmallHeadImgUrl", this.hasSmallHeadImgUrl, this.smallHeadImgUrl_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _createChatRoomResponseFieldNames;
            if (this.hasBaseResponse)
            {
                output.WriteMessage(1, strArray[0], this.BaseResponse);
            }
            if (this.hasTopic)
            {
                output.WriteMessage(2, strArray[9], this.Topic);
            }
            if (this.hasPYInitial)
            {
                output.WriteMessage(3, strArray[6], this.PYInitial);
            }
            if (this.hasQuanPin)
            {
                output.WriteMessage(4, strArray[7], this.QuanPin);
            }
            if (this.hasMemberCount)
            {
                output.WriteUInt32(5, strArray[4], this.MemberCount);
            }
            if (this.memberList_.Count > 0)
            {
                output.WriteMessageArray<MemberResp>(6, strArray[5], this.memberList_);
            }
            if (this.hasChatRoomName)
            {
                output.WriteMessage(7, strArray[2], this.ChatRoomName);
            }
            if (this.hasImgBuf)
            {
                output.WriteMessage(8, strArray[3], this.ImgBuf);
            }
            if (this.hasBigHeadImgUrl)
            {
                output.WriteString(9, strArray[1], this.BigHeadImgUrl);
            }
            if (this.hasSmallHeadImgUrl)
            {
                output.WriteString(10, strArray[8], this.SmallHeadImgUrl);
            }
        }

        public micromsg.BaseResponse BaseResponse
        {
            get
            {
                return (this.baseResponse_ ?? micromsg.BaseResponse.DefaultInstance);
            }
        }

        public string BigHeadImgUrl
        {
            get
            {
                return this.bigHeadImgUrl_;
            }
        }

        public SKBuiltinString_t ChatRoomName
        {
            get
            {
                return (this.chatRoomName_ ?? SKBuiltinString_t.DefaultInstance);
            }
        }

        public static CreateChatRoomResponse DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override CreateChatRoomResponse DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public SKBuiltinBuffer_t ImgBuf
        {
            get
            {
                return (this.imgBuf_ ?? SKBuiltinBuffer_t.DefaultInstance);
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
                if (!this.hasTopic)
                {
                    return false;
                }
                if (!this.hasPYInitial)
                {
                    return false;
                }
                if (!this.hasQuanPin)
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
                if (!this.hasImgBuf)
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
                if (!this.ImgBuf.IsInitialized)
                {
                    return false;
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

        public SKBuiltinString_t PYInitial
        {
            get
            {
                return (this.pYInitial_ ?? SKBuiltinString_t.DefaultInstance);
            }
        }

        public SKBuiltinString_t QuanPin
        {
            get
            {
                return (this.quanPin_ ?? SKBuiltinString_t.DefaultInstance);
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
                    if (this.hasTopic)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(2, this.Topic);
                    }
                    if (this.hasPYInitial)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(3, this.PYInitial);
                    }
                    if (this.hasQuanPin)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(4, this.QuanPin);
                    }
                    if (this.hasMemberCount)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(5, this.MemberCount);
                    }
                    foreach (MemberResp resp in this.MemberListList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(6, resp);
                    }
                    if (this.hasChatRoomName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(7, this.ChatRoomName);
                    }
                    if (this.hasImgBuf)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(8, this.ImgBuf);
                    }
                    if (this.hasBigHeadImgUrl)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(9, this.BigHeadImgUrl);
                    }
                    if (this.hasSmallHeadImgUrl)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(10, this.SmallHeadImgUrl);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        public string SmallHeadImgUrl
        {
            get
            {
                return this.smallHeadImgUrl_;
            }
        }

        protected override CreateChatRoomResponse ThisMessage
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

        
        public sealed class Builder : GeneratedBuilderLite<CreateChatRoomResponse, CreateChatRoomResponse.Builder>
        {
            private CreateChatRoomResponse result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = CreateChatRoomResponse.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(CreateChatRoomResponse cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public CreateChatRoomResponse.Builder AddMemberList(MemberResp value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.memberList_.Add(value);
                return this;
            }

            public CreateChatRoomResponse.Builder AddMemberList(MemberResp.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.memberList_.Add(builderForValue.Build());
                return this;
            }

            public CreateChatRoomResponse.Builder AddRangeMemberList(IEnumerable<MemberResp> values)
            {
                this.PrepareBuilder();
                this.result.memberList_.Add(values);
                return this;
            }

            public override CreateChatRoomResponse BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override CreateChatRoomResponse.Builder Clear()
            {
                this.result = CreateChatRoomResponse.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public CreateChatRoomResponse.Builder ClearBaseResponse()
            {
                this.PrepareBuilder();
                this.result.hasBaseResponse = false;
                this.result.baseResponse_ = null;
                return this;
            }

            public CreateChatRoomResponse.Builder ClearBigHeadImgUrl()
            {
                this.PrepareBuilder();
                this.result.hasBigHeadImgUrl = false;
                this.result.bigHeadImgUrl_ = "";
                return this;
            }

            public CreateChatRoomResponse.Builder ClearChatRoomName()
            {
                this.PrepareBuilder();
                this.result.hasChatRoomName = false;
                this.result.chatRoomName_ = null;
                return this;
            }

            public CreateChatRoomResponse.Builder ClearImgBuf()
            {
                this.PrepareBuilder();
                this.result.hasImgBuf = false;
                this.result.imgBuf_ = null;
                return this;
            }

            public CreateChatRoomResponse.Builder ClearMemberCount()
            {
                this.PrepareBuilder();
                this.result.hasMemberCount = false;
                this.result.memberCount_ = 0;
                return this;
            }

            public CreateChatRoomResponse.Builder ClearMemberList()
            {
                this.PrepareBuilder();
                this.result.memberList_.Clear();
                return this;
            }

            public CreateChatRoomResponse.Builder ClearPYInitial()
            {
                this.PrepareBuilder();
                this.result.hasPYInitial = false;
                this.result.pYInitial_ = null;
                return this;
            }

            public CreateChatRoomResponse.Builder ClearQuanPin()
            {
                this.PrepareBuilder();
                this.result.hasQuanPin = false;
                this.result.quanPin_ = null;
                return this;
            }

            public CreateChatRoomResponse.Builder ClearSmallHeadImgUrl()
            {
                this.PrepareBuilder();
                this.result.hasSmallHeadImgUrl = false;
                this.result.smallHeadImgUrl_ = "";
                return this;
            }

            public CreateChatRoomResponse.Builder ClearTopic()
            {
                this.PrepareBuilder();
                this.result.hasTopic = false;
                this.result.topic_ = null;
                return this;
            }

            public override CreateChatRoomResponse.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new CreateChatRoomResponse.Builder(this.result);
                }
                return new CreateChatRoomResponse.Builder().MergeFrom(this.result);
            }

            public MemberResp GetMemberList(int index)
            {
                return this.result.GetMemberList(index);
            }

            public CreateChatRoomResponse.Builder MergeBaseResponse(micromsg.BaseResponse value)
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

            public CreateChatRoomResponse.Builder MergeChatRoomName(SKBuiltinString_t value)
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

            public override CreateChatRoomResponse.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override CreateChatRoomResponse.Builder MergeFrom(IMessageLite other)
            {
                if (other is CreateChatRoomResponse)
                {
                    return this.MergeFrom((CreateChatRoomResponse) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override CreateChatRoomResponse.Builder MergeFrom(CreateChatRoomResponse other)
            {
                return this;
            }

            public override CreateChatRoomResponse.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(CreateChatRoomResponse._createChatRoomResponseFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = CreateChatRoomResponse._createChatRoomResponseFieldTags[index];
                        }
                        else
                        {
                            this.ParseUnknownField(input, extensionRegistry, num, str);
                            continue;
                        }
                    }
                    switch (num)
                    {
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
                        case 0x1a:
                        {
                            SKBuiltinString_t.Builder builder3 = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasPYInitial)
                            {
                                builder3.MergeFrom(this.PYInitial);
                            }
                            input.ReadMessage(builder3, extensionRegistry);
                            this.PYInitial = builder3.BuildPartial();
                            continue;
                        }
                        case 0x22:
                        {
                            SKBuiltinString_t.Builder builder4 = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasQuanPin)
                            {
                                builder4.MergeFrom(this.QuanPin);
                            }
                            input.ReadMessage(builder4, extensionRegistry);
                            this.QuanPin = builder4.BuildPartial();
                            continue;
                        }
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
                        case 40:
                        {
                            this.result.hasMemberCount = input.ReadUInt32(ref this.result.memberCount_);
                            continue;
                        }
                        case 50:
                        {
                            input.ReadMessageArray<MemberResp>(num, str, this.result.memberList_, MemberResp.DefaultInstance, extensionRegistry);
                            continue;
                        }
                        case 0x3a:
                        {
                            SKBuiltinString_t.Builder builder5 = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasChatRoomName)
                            {
                                builder5.MergeFrom(this.ChatRoomName);
                            }
                            input.ReadMessage(builder5, extensionRegistry);
                            this.ChatRoomName = builder5.BuildPartial();
                            continue;
                        }
                        case 0x42:
                        {
                            SKBuiltinBuffer_t.Builder builder6 = SKBuiltinBuffer_t.CreateBuilder();
                            if (this.result.hasImgBuf)
                            {
                                builder6.MergeFrom(this.ImgBuf);
                            }
                            input.ReadMessage(builder6, extensionRegistry);
                            this.ImgBuf = builder6.BuildPartial();
                            continue;
                        }
                        case 0x4a:
                        {
                            this.result.hasBigHeadImgUrl = input.ReadString(ref this.result.bigHeadImgUrl_);
                            continue;
                        }
                        case 0x52:
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
                    this.result.hasSmallHeadImgUrl = input.ReadString(ref this.result.smallHeadImgUrl_);
                }
                return this;
            }

            public CreateChatRoomResponse.Builder MergeImgBuf(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasImgBuf && (this.result.imgBuf_ != SKBuiltinBuffer_t.DefaultInstance))
                {
                    this.result.imgBuf_ = SKBuiltinBuffer_t.CreateBuilder(this.result.imgBuf_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.imgBuf_ = value;
                }
                this.result.hasImgBuf = true;
                return this;
            }

            public CreateChatRoomResponse.Builder MergePYInitial(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasPYInitial && (this.result.pYInitial_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.pYInitial_ = SKBuiltinString_t.CreateBuilder(this.result.pYInitial_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.pYInitial_ = value;
                }
                this.result.hasPYInitial = true;
                return this;
            }

            public CreateChatRoomResponse.Builder MergeQuanPin(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasQuanPin && (this.result.quanPin_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.quanPin_ = SKBuiltinString_t.CreateBuilder(this.result.quanPin_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.quanPin_ = value;
                }
                this.result.hasQuanPin = true;
                return this;
            }

            public CreateChatRoomResponse.Builder MergeTopic(SKBuiltinString_t value)
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

            private CreateChatRoomResponse PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    CreateChatRoomResponse result = this.result;
                    this.result = new CreateChatRoomResponse();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public CreateChatRoomResponse.Builder SetBaseResponse(micromsg.BaseResponse value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = value;
                return this;
            }

            public CreateChatRoomResponse.Builder SetBaseResponse(micromsg.BaseResponse.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = builderForValue.Build();
                return this;
            }

            public CreateChatRoomResponse.Builder SetBigHeadImgUrl(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBigHeadImgUrl = true;
                this.result.bigHeadImgUrl_ = value;
                return this;
            }

            public CreateChatRoomResponse.Builder SetChatRoomName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasChatRoomName = true;
                this.result.chatRoomName_ = value;
                return this;
            }

            public CreateChatRoomResponse.Builder SetChatRoomName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasChatRoomName = true;
                this.result.chatRoomName_ = builderForValue.Build();
                return this;
            }

            public CreateChatRoomResponse.Builder SetImgBuf(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasImgBuf = true;
                this.result.imgBuf_ = value;
                return this;
            }

            public CreateChatRoomResponse.Builder SetImgBuf(SKBuiltinBuffer_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasImgBuf = true;
                this.result.imgBuf_ = builderForValue.Build();
                return this;
            }

            public CreateChatRoomResponse.Builder SetMemberCount(uint value)
            {
                this.PrepareBuilder();
                this.result.hasMemberCount = true;
                this.result.memberCount_ = value;
                return this;
            }

            public CreateChatRoomResponse.Builder SetMemberList(int index, MemberResp value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.memberList_[index] = value;
                return this;
            }

            public CreateChatRoomResponse.Builder SetMemberList(int index, MemberResp.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.memberList_[index] = builderForValue.Build();
                return this;
            }

            public CreateChatRoomResponse.Builder SetPYInitial(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasPYInitial = true;
                this.result.pYInitial_ = value;
                return this;
            }

            public CreateChatRoomResponse.Builder SetPYInitial(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasPYInitial = true;
                this.result.pYInitial_ = builderForValue.Build();
                return this;
            }

            public CreateChatRoomResponse.Builder SetQuanPin(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasQuanPin = true;
                this.result.quanPin_ = value;
                return this;
            }

            public CreateChatRoomResponse.Builder SetQuanPin(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasQuanPin = true;
                this.result.quanPin_ = builderForValue.Build();
                return this;
            }

            public CreateChatRoomResponse.Builder SetSmallHeadImgUrl(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSmallHeadImgUrl = true;
                this.result.smallHeadImgUrl_ = value;
                return this;
            }

            public CreateChatRoomResponse.Builder SetTopic(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasTopic = true;
                this.result.topic_ = value;
                return this;
            }

            public CreateChatRoomResponse.Builder SetTopic(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasTopic = true;
                this.result.topic_ = builderForValue.Build();
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

            public string BigHeadImgUrl
            {
                get
                {
                    return this.result.BigHeadImgUrl;
                }
                set
                {
                    this.SetBigHeadImgUrl(value);
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

            public override CreateChatRoomResponse DefaultInstanceForType
            {
                get
                {
                    return CreateChatRoomResponse.DefaultInstance;
                }
            }

            public SKBuiltinBuffer_t ImgBuf
            {
                get
                {
                    return this.result.ImgBuf;
                }
                set
                {
                    this.SetImgBuf(value);
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

            protected override CreateChatRoomResponse MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public SKBuiltinString_t PYInitial
            {
                get
                {
                    return this.result.PYInitial;
                }
                set
                {
                    this.SetPYInitial(value);
                }
            }

            public SKBuiltinString_t QuanPin
            {
                get
                {
                    return this.result.QuanPin;
                }
                set
                {
                    this.SetQuanPin(value);
                }
            }

            public string SmallHeadImgUrl
            {
                get
                {
                    return this.result.SmallHeadImgUrl;
                }
                set
                {
                    this.SetSmallHeadImgUrl(value);
                }
            }

            protected override CreateChatRoomResponse.Builder ThisBuilder
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


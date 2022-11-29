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
    public sealed class VerifyUserRequest : GeneratedMessageLite<VerifyUserRequest, VerifyUserRequest.Builder>
    {
        private static readonly string[] _verifyUserRequestFieldNames = new string[] { "BaseRequest", "Opcode", "SceneList", "SceneListNum", "VerifyContent", "VerifyUserList", "VerifyUserListSize" };
        private static readonly uint[] _verifyUserRequestFieldTags = new uint[] { 10, 0x10, 0x3a, 0x30, 0x2a, 0x22, 0x18 };
        private micromsg.BaseRequest baseRequest_;
        public const int BaseRequestFieldNumber = 1;
        private static readonly VerifyUserRequest defaultInstance = new VerifyUserRequest().MakeReadOnly();
        private bool hasBaseRequest;
        private bool hasOpcode;
        private bool hasSceneListNum;
        private bool hasVerifyContent;
        private bool hasVerifyUserListSize;
        private int memoizedSerializedSize = -1;
        private uint opcode_;
        public const int OpcodeFieldNumber = 2;
        private PopsicleList<uint> sceneList_ = new PopsicleList<uint>();
        public const int SceneListFieldNumber = 7;
        private int sceneListMemoizedSerializedSize;
        private uint sceneListNum_;
        public const int SceneListNumFieldNumber = 6;
        private string verifyContent_ = "";
        public const int VerifyContentFieldNumber = 5;
        private PopsicleList<VerifyUser> verifyUserList_ = new PopsicleList<VerifyUser>();
        public const int VerifyUserListFieldNumber = 4;
        private uint verifyUserListSize_;
        public const int VerifyUserListSizeFieldNumber = 3;

        static VerifyUserRequest()
        {
            //object.ReferenceEquals(VerifyUserRequest.Descriptor, null);
        }

        private VerifyUserRequest()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(VerifyUserRequest prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            VerifyUserRequest request = obj as VerifyUserRequest;
            if (request == null)
            {
                return false;
            }
            if ((this.hasBaseRequest != request.hasBaseRequest) || (this.hasBaseRequest && !this.baseRequest_.Equals(request.baseRequest_)))
            {
                return false;
            }
            if ((this.hasOpcode != request.hasOpcode) || (this.hasOpcode && !this.opcode_.Equals(request.opcode_)))
            {
                return false;
            }
            if ((this.hasVerifyUserListSize != request.hasVerifyUserListSize) || (this.hasVerifyUserListSize && !this.verifyUserListSize_.Equals(request.verifyUserListSize_)))
            {
                return false;
            }
            if (this.verifyUserList_.Count != request.verifyUserList_.Count)
            {
                return false;
            }
            for (int i = 0; i < this.verifyUserList_.Count; i++)
            {
                if (!this.verifyUserList_[i].Equals(request.verifyUserList_[i]))
                {
                    return false;
                }
            }
            if ((this.hasVerifyContent != request.hasVerifyContent) || (this.hasVerifyContent && !this.verifyContent_.Equals(request.verifyContent_)))
            {
                return false;
            }
            if ((this.hasSceneListNum != request.hasSceneListNum) || (this.hasSceneListNum && !this.sceneListNum_.Equals(request.sceneListNum_)))
            {
                return false;
            }
            if (this.sceneList_.Count != request.sceneList_.Count)
            {
                return false;
            }
            for (int j = 0; j < this.sceneList_.Count; j++)
            {
                uint num3 = this.sceneList_[j];
                if (!num3.Equals(request.sceneList_[j]))
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
            if (this.hasOpcode)
            {
                hashCode ^= this.opcode_.GetHashCode();
            }
            if (this.hasVerifyUserListSize)
            {
                hashCode ^= this.verifyUserListSize_.GetHashCode();
            }
            foreach (VerifyUser user in this.verifyUserList_)
            {
                hashCode ^= user.GetHashCode();
            }
            if (this.hasVerifyContent)
            {
                hashCode ^= this.verifyContent_.GetHashCode();
            }
            if (this.hasSceneListNum)
            {
                hashCode ^= this.sceneListNum_.GetHashCode();
            }
            foreach (uint num2 in this.sceneList_)
            {
                hashCode ^= num2.GetHashCode();
            }
            return hashCode;
        }

        public uint GetSceneList(int index)
        {
            return this.sceneList_[index];
        }

        public VerifyUser GetVerifyUserList(int index)
        {
            return this.verifyUserList_[index];
        }

        private VerifyUserRequest MakeReadOnly()
        {
            this.verifyUserList_.MakeReadOnly();
            this.sceneList_.MakeReadOnly();
            return this;
        }

        public static VerifyUserRequest ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<VerifyUserRequest, Builder>.PrintField("BaseRequest", this.hasBaseRequest, this.baseRequest_, writer);
            GeneratedMessageLite<VerifyUserRequest, Builder>.PrintField("Opcode", this.hasOpcode, this.opcode_, writer);
            GeneratedMessageLite<VerifyUserRequest, Builder>.PrintField("VerifyUserListSize", this.hasVerifyUserListSize, this.verifyUserListSize_, writer);
            GeneratedMessageLite<VerifyUserRequest, Builder>.PrintField<VerifyUser>("VerifyUserList", this.verifyUserList_, writer);
            GeneratedMessageLite<VerifyUserRequest, Builder>.PrintField("VerifyContent", this.hasVerifyContent, this.verifyContent_, writer);
            GeneratedMessageLite<VerifyUserRequest, Builder>.PrintField("SceneListNum", this.hasSceneListNum, this.sceneListNum_, writer);
            GeneratedMessageLite<VerifyUserRequest, Builder>.PrintField<uint>("SceneList", this.sceneList_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _verifyUserRequestFieldNames;
            if (this.hasBaseRequest)
            {
                output.WriteMessage(1, strArray[0], this.BaseRequest);
            }
            if (this.hasOpcode)
            {
                output.WriteUInt32(2, strArray[1], this.Opcode);
            }
            if (this.hasVerifyUserListSize)
            {
                output.WriteUInt32(3, strArray[6], this.VerifyUserListSize);
            }
            if (this.verifyUserList_.Count > 0)
            {
                output.WriteMessageArray<VerifyUser>(4, strArray[5], this.verifyUserList_);
            }
            if (this.hasVerifyContent)
            {
                output.WriteString(5, strArray[4], this.VerifyContent);
            }
            if (this.hasSceneListNum)
            {
                output.WriteUInt32(6, strArray[3], this.SceneListNum);
            }
            if (this.sceneList_.Count > 0)
            {
                output.WritePackedUInt32Array(7, strArray[2], this.sceneListMemoizedSerializedSize, this.sceneList_);
            }
        }

        public micromsg.BaseRequest BaseRequest
        {
            get
            {
                return (this.baseRequest_ ?? micromsg.BaseRequest.DefaultInstance);
            }
        }

        public static VerifyUserRequest DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override VerifyUserRequest DefaultInstanceForType
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
                if (!this.hasOpcode)
                {
                    return false;
                }
                if (!this.hasVerifyUserListSize)
                {
                    return false;
                }
                if (!this.BaseRequest.IsInitialized)
                {
                    return false;
                }
                return true;
            }
        }

        public uint Opcode
        {
            get
            {
                return this.opcode_;
            }
        }

        public int SceneListCount
        {
            get
            {
                return this.sceneList_.Count;
            }
        }

        public IList<uint> SceneListList
        {
            get
            {
                return this.sceneList_;
            }
        }

        public uint SceneListNum
        {
            get
            {
                return this.sceneListNum_;
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
                    if (this.hasOpcode)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(2, this.Opcode);
                    }
                    if (this.hasVerifyUserListSize)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(3, this.VerifyUserListSize);
                    }
                    foreach (VerifyUser user in this.VerifyUserListList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(4, user);
                    }
                    if (this.hasVerifyContent)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(5, this.VerifyContent);
                    }
                    if (this.hasSceneListNum)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(6, this.SceneListNum);
                    }
                    int num2 = 0;
                    foreach (uint num3 in this.SceneListList)
                    {
                        num2 += CodedOutputStream.ComputeUInt32SizeNoTag(num3);
                    }
                    memoizedSerializedSize += num2;
                    if (this.sceneList_.Count != 0)
                    {
                        memoizedSerializedSize += 1 + CodedOutputStream.ComputeInt32SizeNoTag(num2);
                    }
                    this.sceneListMemoizedSerializedSize = num2;
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override VerifyUserRequest ThisMessage
        {
            get
            {
                return this;
            }
        }

        public string VerifyContent
        {
            get
            {
                return this.verifyContent_;
            }
        }

        public int VerifyUserListCount
        {
            get
            {
                return this.verifyUserList_.Count;
            }
        }

        public IList<VerifyUser> VerifyUserListList
        {
            get
            {
                return this.verifyUserList_;
            }
        }

        public uint VerifyUserListSize
        {
            get
            {
                return this.verifyUserListSize_;
            }
        }

        //
        public sealed class Builder : GeneratedBuilderLite<VerifyUserRequest, VerifyUserRequest.Builder>
        {
            private VerifyUserRequest result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = VerifyUserRequest.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(VerifyUserRequest cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public VerifyUserRequest.Builder AddRangeSceneList(IEnumerable<uint> values)
            {
                this.PrepareBuilder();
                this.result.sceneList_.Add(values);
                return this;
            }

            public VerifyUserRequest.Builder AddRangeVerifyUserList(IEnumerable<VerifyUser> values)
            {
                this.PrepareBuilder();
                this.result.verifyUserList_.Add(values);
                return this;
            }

            public VerifyUserRequest.Builder AddSceneList(uint value)
            {
                this.PrepareBuilder();
                this.result.sceneList_.Add(value);
                return this;
            }

            public VerifyUserRequest.Builder AddVerifyUserList(VerifyUser value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.verifyUserList_.Add(value);
                return this;
            }

            public VerifyUserRequest.Builder AddVerifyUserList(VerifyUser.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.verifyUserList_.Add(builderForValue.Build());
                return this;
            }

            public override VerifyUserRequest BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override VerifyUserRequest.Builder Clear()
            {
                this.result = VerifyUserRequest.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public VerifyUserRequest.Builder ClearBaseRequest()
            {
                this.PrepareBuilder();
                this.result.hasBaseRequest = false;
                this.result.baseRequest_ = null;
                return this;
            }

            public VerifyUserRequest.Builder ClearOpcode()
            {
                this.PrepareBuilder();
                this.result.hasOpcode = false;
                this.result.opcode_ = 0;
                return this;
            }

            public VerifyUserRequest.Builder ClearSceneList()
            {
                this.PrepareBuilder();
                this.result.sceneList_.Clear();
                return this;
            }

            public VerifyUserRequest.Builder ClearSceneListNum()
            {
                this.PrepareBuilder();
                this.result.hasSceneListNum = false;
                this.result.sceneListNum_ = 0;
                return this;
            }

            public VerifyUserRequest.Builder ClearVerifyContent()
            {
                this.PrepareBuilder();
                this.result.hasVerifyContent = false;
                this.result.verifyContent_ = "";
                return this;
            }

            public VerifyUserRequest.Builder ClearVerifyUserList()
            {
                this.PrepareBuilder();
                this.result.verifyUserList_.Clear();
                return this;
            }

            public VerifyUserRequest.Builder ClearVerifyUserListSize()
            {
                this.PrepareBuilder();
                this.result.hasVerifyUserListSize = false;
                this.result.verifyUserListSize_ = 0;
                return this;
            }

            public override VerifyUserRequest.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new VerifyUserRequest.Builder(this.result);
                }
                return new VerifyUserRequest.Builder().MergeFrom(this.result);
            }

            public uint GetSceneList(int index)
            {
                return this.result.GetSceneList(index);
            }

            public VerifyUser GetVerifyUserList(int index)
            {
                return this.result.GetVerifyUserList(index);
            }

            public VerifyUserRequest.Builder MergeBaseRequest(micromsg.BaseRequest value)
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

            public override VerifyUserRequest.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override VerifyUserRequest.Builder MergeFrom(IMessageLite other)
            {
                if (other is VerifyUserRequest)
                {
                    return this.MergeFrom((VerifyUserRequest) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override VerifyUserRequest.Builder MergeFrom(VerifyUserRequest other)
            {
                return this;
            }

            public override VerifyUserRequest.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(VerifyUserRequest._verifyUserRequestFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = VerifyUserRequest._verifyUserRequestFieldTags[index];
                        }
                        else
                        {
                            this.ParseUnknownField(input, extensionRegistry, num, str);
                            continue;
                        }
                    }
                    switch (num)
                    {
                        case 0x10:
                        {
                            this.result.hasOpcode = input.ReadUInt32(ref this.result.opcode_);
                            continue;
                        }
                        case 0x18:
                        {
                            this.result.hasVerifyUserListSize = input.ReadUInt32(ref this.result.verifyUserListSize_);
                            continue;
                        }
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
                        case 0x22:
                        {
                            input.ReadMessageArray<VerifyUser>(num, str, this.result.verifyUserList_, VerifyUser.DefaultInstance, extensionRegistry);
                            continue;
                        }
                        case 0x2a:
                        {
                            this.result.hasVerifyContent = input.ReadString(ref this.result.verifyContent_);
                            continue;
                        }
                        case 0x38:
                        case 0x3a:
                            break;

                        case 0x30:
                        {
                            this.result.hasSceneListNum = input.ReadUInt32(ref this.result.sceneListNum_);
                            continue;
                        }
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
                    input.ReadUInt32Array(num, str, this.result.sceneList_);
                }
                return this;
            }

            private VerifyUserRequest PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    VerifyUserRequest result = this.result;
                    this.result = new VerifyUserRequest();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public VerifyUserRequest.Builder SetBaseRequest(micromsg.BaseRequest value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = value;
                return this;
            }

            public VerifyUserRequest.Builder SetBaseRequest(micromsg.BaseRequest.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = builderForValue.Build();
                return this;
            }

            public VerifyUserRequest.Builder SetOpcode(uint value)
            {
                this.PrepareBuilder();
                this.result.hasOpcode = true;
                this.result.opcode_ = value;
                return this;
            }

            public VerifyUserRequest.Builder SetSceneList(int index, uint value)
            {
                this.PrepareBuilder();
                this.result.sceneList_[index] = value;
                return this;
            }

            public VerifyUserRequest.Builder SetSceneListNum(uint value)
            {
                this.PrepareBuilder();
                this.result.hasSceneListNum = true;
                this.result.sceneListNum_ = value;
                return this;
            }

            public VerifyUserRequest.Builder SetVerifyContent(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasVerifyContent = true;
                this.result.verifyContent_ = value;
                return this;
            }

            public VerifyUserRequest.Builder SetVerifyUserList(int index, VerifyUser value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.verifyUserList_[index] = value;
                return this;
            }

            public VerifyUserRequest.Builder SetVerifyUserList(int index, VerifyUser.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.verifyUserList_[index] = builderForValue.Build();
                return this;
            }

            public VerifyUserRequest.Builder SetVerifyUserListSize(uint value)
            {
                this.PrepareBuilder();
                this.result.hasVerifyUserListSize = true;
                this.result.verifyUserListSize_ = value;
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

            public override VerifyUserRequest DefaultInstanceForType
            {
                get
                {
                    return VerifyUserRequest.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override VerifyUserRequest MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public uint Opcode
            {
                get
                {
                    return this.result.Opcode;
                }
                set
                {
                    this.SetOpcode(value);
                }
            }

            public int SceneListCount
            {
                get
                {
                    return this.result.SceneListCount;
                }
            }

            public IPopsicleList<uint> SceneListList
            {
                get
                {
                    return this.PrepareBuilder().sceneList_;
                }
            }

            public uint SceneListNum
            {
                get
                {
                    return this.result.SceneListNum;
                }
                set
                {
                    this.SetSceneListNum(value);
                }
            }

            protected override VerifyUserRequest.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }

            public string VerifyContent
            {
                get
                {
                    return this.result.VerifyContent;
                }
                set
                {
                    this.SetVerifyContent(value);
                }
            }

            public int VerifyUserListCount
            {
                get
                {
                    return this.result.VerifyUserListCount;
                }
            }

            public IPopsicleList<VerifyUser> VerifyUserListList
            {
                get
                {
                    return this.PrepareBuilder().verifyUserList_;
                }
            }

            public uint VerifyUserListSize
            {
                get
                {
                    return this.result.VerifyUserListSize;
                }
                set
                {
                    this.SetVerifyUserListSize(value);
                }
            }
        }
    }
}


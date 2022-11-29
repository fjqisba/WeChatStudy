namespace micromsg
{
    using Google.ProtocolBuffers;
    using Google.ProtocolBuffers.Collections;
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Runtime.CompilerServices;


    public sealed class SnsPostRequest : GeneratedMessageLite<SnsPostRequest, SnsPostRequest.Builder>
    {
        private static readonly string[] _snsPostRequestFieldNames = new string[] { 
            "BaseRequest", "BlackList", "BlackListNum", "ClientId", "CtocUploadInfo", "GroupIds", "GroupNum", "GroupUser", "GroupUserNum", "ObjectDesc", "ObjectSource", "PostBGImgType", "Privacy", "ReferId", "SyncFlag", "TwitterInfo", 
            "WithUserList", "WithUserListNum"
         };
        private static readonly uint[] _snsPostRequestFieldTags = new uint[] { 
            10, 0x72, 0x68, 0x3a, 0x92, 0x52, 0x48, 0x8a, 0x80, 0x12, 0x58, 0x40, 40, 0x60, 0x30, 0x7a, 
            0x22, 0x18
         };
        private BaseRequest baseRequest_;
        public const int BaseRequestFieldNumber = 1;
        private PopsicleList<SKBuiltinString_t> blackList_ = new PopsicleList<SKBuiltinString_t>();
        public const int BlackListFieldNumber = 14;
        private uint blackListNum_;
        public const int BlackListNumFieldNumber = 13;
        private string clientId_ = "";
        public const int ClientIdFieldNumber = 7;
        private SnsPostCtocUploadInfo ctocUploadInfo_;
        public const int CtocUploadInfoFieldNumber = 0x12;
        private static readonly SnsPostRequest defaultInstance = new SnsPostRequest().MakeReadOnly();
        private PopsicleList<SnsGroup> groupIds_ = new PopsicleList<SnsGroup>();
        public const int GroupIdsFieldNumber = 10;
        private uint groupNum_;
        public const int GroupNumFieldNumber = 9;
        private PopsicleList<SKBuiltinString_t> groupUser_ = new PopsicleList<SKBuiltinString_t>();
        public const int GroupUserFieldNumber = 0x11;
        private uint groupUserNum_;
        public const int GroupUserNumFieldNumber = 0x10;
        private bool hasBaseRequest;
        private bool hasBlackListNum;
        private bool hasClientId;
        private bool hasCtocUploadInfo;
        private bool hasGroupNum;
        private bool hasGroupUserNum;
        private bool hasObjectDesc;
        private bool hasObjectSource;
        private bool hasPostBGImgType;
        private bool hasPrivacy;
        private bool hasReferId;
        private bool hasSyncFlag;
        private bool hasTwitterInfo;
        private bool hasWithUserListNum;
        private int memoizedSerializedSize = -1;
        private SKBuiltinBuffer_t objectDesc_;
        public const int ObjectDescFieldNumber = 2;
        private uint objectSource_;
        public const int ObjectSourceFieldNumber = 11;
        private uint postBGImgType_;
        public const int PostBGImgTypeFieldNumber = 8;
        private uint privacy_;
        public const int PrivacyFieldNumber = 5;
        private ulong referId_;
        public const int ReferIdFieldNumber = 12;
        private uint syncFlag_;
        public const int SyncFlagFieldNumber = 6;
        private TwitterInfo twitterInfo_;
        public const int TwitterInfoFieldNumber = 15;
        private PopsicleList<SKBuiltinString_t> withUserList_ = new PopsicleList<SKBuiltinString_t>();
        public const int WithUserListFieldNumber = 4;
        private uint withUserListNum_;
        public const int WithUserListNumFieldNumber = 3;

        static SnsPostRequest()
        {
            
        }

        private SnsPostRequest()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(SnsPostRequest prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            SnsPostRequest request = obj as SnsPostRequest;
            if (request == null)
            {
                return false;
            }
            if ((this.hasBaseRequest != request.hasBaseRequest) || (this.hasBaseRequest && !this.baseRequest_.Equals(request.baseRequest_)))
            {
                return false;
            }
            if ((this.hasObjectDesc != request.hasObjectDesc) || (this.hasObjectDesc && !this.objectDesc_.Equals(request.objectDesc_)))
            {
                return false;
            }
            if ((this.hasWithUserListNum != request.hasWithUserListNum) || (this.hasWithUserListNum && !this.withUserListNum_.Equals(request.withUserListNum_)))
            {
                return false;
            }
            if (this.withUserList_.Count != request.withUserList_.Count)
            {
                return false;
            }
            for (int i = 0; i < this.withUserList_.Count; i++)
            {
                if (!this.withUserList_[i].Equals(request.withUserList_[i]))
                {
                    return false;
                }
            }
            if ((this.hasPrivacy != request.hasPrivacy) || (this.hasPrivacy && !this.privacy_.Equals(request.privacy_)))
            {
                return false;
            }
            if ((this.hasSyncFlag != request.hasSyncFlag) || (this.hasSyncFlag && !this.syncFlag_.Equals(request.syncFlag_)))
            {
                return false;
            }
            if ((this.hasClientId != request.hasClientId) || (this.hasClientId && !this.clientId_.Equals(request.clientId_)))
            {
                return false;
            }
            if ((this.hasPostBGImgType != request.hasPostBGImgType) || (this.hasPostBGImgType && !this.postBGImgType_.Equals(request.postBGImgType_)))
            {
                return false;
            }
            if ((this.hasGroupNum != request.hasGroupNum) || (this.hasGroupNum && !this.groupNum_.Equals(request.groupNum_)))
            {
                return false;
            }
            if (this.groupIds_.Count != request.groupIds_.Count)
            {
                return false;
            }
            for (int j = 0; j < this.groupIds_.Count; j++)
            {
                if (!this.groupIds_[j].Equals(request.groupIds_[j]))
                {
                    return false;
                }
            }
            if ((this.hasObjectSource != request.hasObjectSource) || (this.hasObjectSource && !this.objectSource_.Equals(request.objectSource_)))
            {
                return false;
            }
            if ((this.hasReferId != request.hasReferId) || (this.hasReferId && !this.referId_.Equals(request.referId_)))
            {
                return false;
            }
            if ((this.hasBlackListNum != request.hasBlackListNum) || (this.hasBlackListNum && !this.blackListNum_.Equals(request.blackListNum_)))
            {
                return false;
            }
            if (this.blackList_.Count != request.blackList_.Count)
            {
                return false;
            }
            for (int k = 0; k < this.blackList_.Count; k++)
            {
                if (!this.blackList_[k].Equals(request.blackList_[k]))
                {
                    return false;
                }
            }
            if ((this.hasTwitterInfo != request.hasTwitterInfo) || (this.hasTwitterInfo && !this.twitterInfo_.Equals(request.twitterInfo_)))
            {
                return false;
            }
            if ((this.hasGroupUserNum != request.hasGroupUserNum) || (this.hasGroupUserNum && !this.groupUserNum_.Equals(request.groupUserNum_)))
            {
                return false;
            }
            if (this.groupUser_.Count != request.groupUser_.Count)
            {
                return false;
            }
            for (int m = 0; m < this.groupUser_.Count; m++)
            {
                if (!this.groupUser_[m].Equals(request.groupUser_[m]))
                {
                    return false;
                }
            }
            return ((this.hasCtocUploadInfo == request.hasCtocUploadInfo) && (!this.hasCtocUploadInfo || this.ctocUploadInfo_.Equals(request.ctocUploadInfo_)));
        }

        public SKBuiltinString_t GetBlackList(int index)
        {
            return this.blackList_[index];
        }

        public SnsGroup GetGroupIds(int index)
        {
            return this.groupIds_[index];
        }

        public SKBuiltinString_t GetGroupUser(int index)
        {
            return this.groupUser_[index];
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasBaseRequest)
            {
                hashCode ^= this.baseRequest_.GetHashCode();
            }
            if (this.hasObjectDesc)
            {
                hashCode ^= this.objectDesc_.GetHashCode();
            }
            if (this.hasWithUserListNum)
            {
                hashCode ^= this.withUserListNum_.GetHashCode();
            }
            foreach (SKBuiltinString_t _t in this.withUserList_)
            {
                hashCode ^= _t.GetHashCode();
            }
            if (this.hasPrivacy)
            {
                hashCode ^= this.privacy_.GetHashCode();
            }
            if (this.hasSyncFlag)
            {
                hashCode ^= this.syncFlag_.GetHashCode();
            }
            if (this.hasClientId)
            {
                hashCode ^= this.clientId_.GetHashCode();
            }
            if (this.hasPostBGImgType)
            {
                hashCode ^= this.postBGImgType_.GetHashCode();
            }
            if (this.hasGroupNum)
            {
                hashCode ^= this.groupNum_.GetHashCode();
            }
            foreach (SnsGroup group in this.groupIds_)
            {
                hashCode ^= group.GetHashCode();
            }
            if (this.hasObjectSource)
            {
                hashCode ^= this.objectSource_.GetHashCode();
            }
            if (this.hasReferId)
            {
                hashCode ^= this.referId_.GetHashCode();
            }
            if (this.hasBlackListNum)
            {
                hashCode ^= this.blackListNum_.GetHashCode();
            }
            foreach (SKBuiltinString_t _t2 in this.blackList_)
            {
                hashCode ^= _t2.GetHashCode();
            }
            if (this.hasTwitterInfo)
            {
                hashCode ^= this.twitterInfo_.GetHashCode();
            }
            if (this.hasGroupUserNum)
            {
                hashCode ^= this.groupUserNum_.GetHashCode();
            }
            foreach (SKBuiltinString_t _t3 in this.groupUser_)
            {
                hashCode ^= _t3.GetHashCode();
            }
            if (this.hasCtocUploadInfo)
            {
                hashCode ^= this.ctocUploadInfo_.GetHashCode();
            }
            return hashCode;
        }

        public SKBuiltinString_t GetWithUserList(int index)
        {
            return this.withUserList_[index];
        }

        private SnsPostRequest MakeReadOnly()
        {
            this.withUserList_.MakeReadOnly();
            this.groupIds_.MakeReadOnly();
            this.blackList_.MakeReadOnly();
            this.groupUser_.MakeReadOnly();
            return this;
        }

        public static SnsPostRequest ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<SnsPostRequest, Builder>.PrintField("BaseRequest", this.hasBaseRequest, this.baseRequest_, writer);
            GeneratedMessageLite<SnsPostRequest, Builder>.PrintField("ObjectDesc", this.hasObjectDesc, this.objectDesc_, writer);
            GeneratedMessageLite<SnsPostRequest, Builder>.PrintField("WithUserListNum", this.hasWithUserListNum, this.withUserListNum_, writer);
            GeneratedMessageLite<SnsPostRequest, Builder>.PrintField<SKBuiltinString_t>("WithUserList", this.withUserList_, writer);
            GeneratedMessageLite<SnsPostRequest, Builder>.PrintField("Privacy", this.hasPrivacy, this.privacy_, writer);
            GeneratedMessageLite<SnsPostRequest, Builder>.PrintField("SyncFlag", this.hasSyncFlag, this.syncFlag_, writer);
            GeneratedMessageLite<SnsPostRequest, Builder>.PrintField("ClientId", this.hasClientId, this.clientId_, writer);
            GeneratedMessageLite<SnsPostRequest, Builder>.PrintField("PostBGImgType", this.hasPostBGImgType, this.postBGImgType_, writer);
            GeneratedMessageLite<SnsPostRequest, Builder>.PrintField("GroupNum", this.hasGroupNum, this.groupNum_, writer);
            GeneratedMessageLite<SnsPostRequest, Builder>.PrintField<SnsGroup>("GroupIds", this.groupIds_, writer);
            GeneratedMessageLite<SnsPostRequest, Builder>.PrintField("ObjectSource", this.hasObjectSource, this.objectSource_, writer);
            GeneratedMessageLite<SnsPostRequest, Builder>.PrintField("ReferId", this.hasReferId, this.referId_, writer);
            GeneratedMessageLite<SnsPostRequest, Builder>.PrintField("BlackListNum", this.hasBlackListNum, this.blackListNum_, writer);
            GeneratedMessageLite<SnsPostRequest, Builder>.PrintField<SKBuiltinString_t>("BlackList", this.blackList_, writer);
            GeneratedMessageLite<SnsPostRequest, Builder>.PrintField("TwitterInfo", this.hasTwitterInfo, this.twitterInfo_, writer);
            GeneratedMessageLite<SnsPostRequest, Builder>.PrintField("GroupUserNum", this.hasGroupUserNum, this.groupUserNum_, writer);
            GeneratedMessageLite<SnsPostRequest, Builder>.PrintField<SKBuiltinString_t>("GroupUser", this.groupUser_, writer);
            GeneratedMessageLite<SnsPostRequest, Builder>.PrintField("CtocUploadInfo", this.hasCtocUploadInfo, this.ctocUploadInfo_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _snsPostRequestFieldNames;
            if (this.hasBaseRequest)
            {
                output.WriteMessage(1, strArray[0], this.BaseRequest);
            }
            if (this.hasObjectDesc)
            {
                output.WriteMessage(2, strArray[9], this.ObjectDesc);
            }
            if (this.hasWithUserListNum)
            {
                output.WriteUInt32(3, strArray[0x11], this.WithUserListNum);
            }
            if (this.withUserList_.Count > 0)
            {
                output.WriteMessageArray<SKBuiltinString_t>(4, strArray[0x10], this.withUserList_);
            }
            if (this.hasPrivacy)
            {
                output.WriteUInt32(5, strArray[12], this.Privacy);
            }
            if (this.hasSyncFlag)
            {
                output.WriteUInt32(6, strArray[14], this.SyncFlag);
            }
            if (this.hasClientId)
            {
                output.WriteString(7, strArray[3], this.ClientId);
            }
            if (this.hasPostBGImgType)
            {
                output.WriteUInt32(8, strArray[11], this.PostBGImgType);
            }
            if (this.hasGroupNum)
            {
                output.WriteUInt32(9, strArray[6], this.GroupNum);
            }
            if (this.groupIds_.Count > 0)
            {
                output.WriteMessageArray<SnsGroup>(10, strArray[5], this.groupIds_);
            }
            if (this.hasObjectSource)
            {
                output.WriteUInt32(11, strArray[10], this.ObjectSource);
            }
            if (this.hasReferId)
            {
                output.WriteUInt64(12, strArray[13], this.ReferId);
            }
            if (this.hasBlackListNum)
            {
                output.WriteUInt32(13, strArray[2], this.BlackListNum);
            }
            if (this.blackList_.Count > 0)
            {
                output.WriteMessageArray<SKBuiltinString_t>(14, strArray[1], this.blackList_);
            }
            if (this.hasTwitterInfo)
            {
                output.WriteMessage(15, strArray[15], this.TwitterInfo);
            }
            if (this.hasGroupUserNum)
            {
                output.WriteUInt32(0x10, strArray[8], this.GroupUserNum);
            }
            if (this.groupUser_.Count > 0)
            {
                output.WriteMessageArray<SKBuiltinString_t>(0x11, strArray[7], this.groupUser_);
            }
            if (this.hasCtocUploadInfo)
            {
                output.WriteMessage(0x12, strArray[4], this.CtocUploadInfo);
            }
        }

        public BaseRequest BaseRequest
        {
            get
            {
                return (this.baseRequest_ ?? BaseRequest.DefaultInstance);
            }
        }

        public int BlackListCount
        {
            get
            {
                return this.blackList_.Count;
            }
        }

        public IList<SKBuiltinString_t> BlackListList
        {
            get
            {
                return this.blackList_;
            }
        }

        public uint BlackListNum
        {
            get
            {
                return this.blackListNum_;
            }
        }

        public string ClientId
        {
            get
            {
                return this.clientId_;
            }
        }

        public SnsPostCtocUploadInfo CtocUploadInfo
        {
            get
            {
                return (this.ctocUploadInfo_ ?? SnsPostCtocUploadInfo.DefaultInstance);
            }
        }

        public static SnsPostRequest DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override SnsPostRequest DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public int GroupIdsCount
        {
            get
            {
                return this.groupIds_.Count;
            }
        }

        public IList<SnsGroup> GroupIdsList
        {
            get
            {
                return this.groupIds_;
            }
        }

        public uint GroupNum
        {
            get
            {
                return this.groupNum_;
            }
        }

        public int GroupUserCount
        {
            get
            {
                return this.groupUser_.Count;
            }
        }

        public IList<SKBuiltinString_t> GroupUserList
        {
            get
            {
                return this.groupUser_;
            }
        }

        public uint GroupUserNum
        {
            get
            {
                return this.groupUserNum_;
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
                if (!this.hasObjectDesc)
                {
                    return false;
                }
                if (!this.BaseRequest.IsInitialized)
                {
                    return false;
                }
                if (!this.ObjectDesc.IsInitialized)
                {
                    return false;
                }
                foreach (SnsGroup group in this.GroupIdsList)
                {
                    if (!group.IsInitialized)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public SKBuiltinBuffer_t ObjectDesc
        {
            get
            {
                return (this.objectDesc_ ?? SKBuiltinBuffer_t.DefaultInstance);
            }
        }

        public uint ObjectSource
        {
            get
            {
                return this.objectSource_;
            }
        }

        public uint PostBGImgType
        {
            get
            {
                return this.postBGImgType_;
            }
        }

        public uint Privacy
        {
            get
            {
                return this.privacy_;
            }
        }

        public ulong ReferId
        {
            get
            {
                return this.referId_;
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
                    if (this.hasObjectDesc)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(2, this.ObjectDesc);
                    }
                    if (this.hasWithUserListNum)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(3, this.WithUserListNum);
                    }
                    foreach (SKBuiltinString_t _t in this.WithUserListList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(4, _t);
                    }
                    if (this.hasPrivacy)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(5, this.Privacy);
                    }
                    if (this.hasSyncFlag)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(6, this.SyncFlag);
                    }
                    if (this.hasClientId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(7, this.ClientId);
                    }
                    if (this.hasPostBGImgType)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(8, this.PostBGImgType);
                    }
                    if (this.hasGroupNum)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(9, this.GroupNum);
                    }
                    foreach (SnsGroup group in this.GroupIdsList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(10, group);
                    }
                    if (this.hasObjectSource)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(11, this.ObjectSource);
                    }
                    if (this.hasReferId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt64Size(12, this.ReferId);
                    }
                    if (this.hasBlackListNum)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(13, this.BlackListNum);
                    }
                    foreach (SKBuiltinString_t _t2 in this.BlackListList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(14, _t2);
                    }
                    if (this.hasTwitterInfo)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(15, this.TwitterInfo);
                    }
                    if (this.hasGroupUserNum)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(0x10, this.GroupUserNum);
                    }
                    foreach (SKBuiltinString_t _t3 in this.GroupUserList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(0x11, _t3);
                    }
                    if (this.hasCtocUploadInfo)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(0x12, this.CtocUploadInfo);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        public uint SyncFlag
        {
            get
            {
                return this.syncFlag_;
            }
        }

        protected override SnsPostRequest ThisMessage
        {
            get
            {
                return this;
            }
        }

        public TwitterInfo TwitterInfo
        {
            get
            {
                return (this.twitterInfo_ ?? TwitterInfo.DefaultInstance);
            }
        }

        public int WithUserListCount
        {
            get
            {
                return this.withUserList_.Count;
            }
        }

        public IList<SKBuiltinString_t> WithUserListList
        {
            get
            {
                return this.withUserList_;
            }
        }

        public uint WithUserListNum
        {
            get
            {
                return this.withUserListNum_;
            }
        }

        [DebuggerNonUserCode, CompilerGenerated, GeneratedCode("ProtoGen", "2.3.0.277")]
        public sealed class Builder : GeneratedBuilderLite<SnsPostRequest, SnsPostRequest.Builder>
        {
            private SnsPostRequest result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = SnsPostRequest.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(SnsPostRequest cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public SnsPostRequest.Builder AddBlackList(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.blackList_.Add(value);
                return this;
            }

            public SnsPostRequest.Builder AddBlackList(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.blackList_.Add(builderForValue.Build());
                return this;
            }

            public SnsPostRequest.Builder AddGroupIds(SnsGroup value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.groupIds_.Add(value);
                return this;
            }

            public SnsPostRequest.Builder AddGroupIds(SnsGroup.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.groupIds_.Add(builderForValue.Build());
                return this;
            }

            public SnsPostRequest.Builder AddGroupUser(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.groupUser_.Add(value);
                return this;
            }

            public SnsPostRequest.Builder AddGroupUser(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.groupUser_.Add(builderForValue.Build());
                return this;
            }

            public SnsPostRequest.Builder AddRangeBlackList(IEnumerable<SKBuiltinString_t> values)
            {
                this.PrepareBuilder();
                this.result.blackList_.Add(values);
                return this;
            }

            public SnsPostRequest.Builder AddRangeGroupIds(IEnumerable<SnsGroup> values)
            {
                this.PrepareBuilder();
                this.result.groupIds_.Add(values);
                return this;
            }

            public SnsPostRequest.Builder AddRangeGroupUser(IEnumerable<SKBuiltinString_t> values)
            {
                this.PrepareBuilder();
                this.result.groupUser_.Add(values);
                return this;
            }

            public SnsPostRequest.Builder AddRangeWithUserList(IEnumerable<SKBuiltinString_t> values)
            {
                this.PrepareBuilder();
                this.result.withUserList_.Add(values);
                return this;
            }

            public SnsPostRequest.Builder AddWithUserList(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.withUserList_.Add(value);
                return this;
            }

            public SnsPostRequest.Builder AddWithUserList(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.withUserList_.Add(builderForValue.Build());
                return this;
            }

            public override SnsPostRequest BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override SnsPostRequest.Builder Clear()
            {
                this.result = SnsPostRequest.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public SnsPostRequest.Builder ClearBaseRequest()
            {
                this.PrepareBuilder();
                this.result.hasBaseRequest = false;
                this.result.baseRequest_ = null;
                return this;
            }

            public SnsPostRequest.Builder ClearBlackList()
            {
                this.PrepareBuilder();
                this.result.blackList_.Clear();
                return this;
            }

            public SnsPostRequest.Builder ClearBlackListNum()
            {
                this.PrepareBuilder();
                this.result.hasBlackListNum = false;
                this.result.blackListNum_ = 0;
                return this;
            }

            public SnsPostRequest.Builder ClearClientId()
            {
                this.PrepareBuilder();
                this.result.hasClientId = false;
                this.result.clientId_ = "";
                return this;
            }

            public SnsPostRequest.Builder ClearCtocUploadInfo()
            {
                this.PrepareBuilder();
                this.result.hasCtocUploadInfo = false;
                this.result.ctocUploadInfo_ = null;
                return this;
            }

            public SnsPostRequest.Builder ClearGroupIds()
            {
                this.PrepareBuilder();
                this.result.groupIds_.Clear();
                return this;
            }

            public SnsPostRequest.Builder ClearGroupNum()
            {
                this.PrepareBuilder();
                this.result.hasGroupNum = false;
                this.result.groupNum_ = 0;
                return this;
            }

            public SnsPostRequest.Builder ClearGroupUser()
            {
                this.PrepareBuilder();
                this.result.groupUser_.Clear();
                return this;
            }

            public SnsPostRequest.Builder ClearGroupUserNum()
            {
                this.PrepareBuilder();
                this.result.hasGroupUserNum = false;
                this.result.groupUserNum_ = 0;
                return this;
            }

            public SnsPostRequest.Builder ClearObjectDesc()
            {
                this.PrepareBuilder();
                this.result.hasObjectDesc = false;
                this.result.objectDesc_ = null;
                return this;
            }

            public SnsPostRequest.Builder ClearObjectSource()
            {
                this.PrepareBuilder();
                this.result.hasObjectSource = false;
                this.result.objectSource_ = 0;
                return this;
            }

            public SnsPostRequest.Builder ClearPostBGImgType()
            {
                this.PrepareBuilder();
                this.result.hasPostBGImgType = false;
                this.result.postBGImgType_ = 0;
                return this;
            }

            public SnsPostRequest.Builder ClearPrivacy()
            {
                this.PrepareBuilder();
                this.result.hasPrivacy = false;
                this.result.privacy_ = 0;
                return this;
            }

            public SnsPostRequest.Builder ClearReferId()
            {
                this.PrepareBuilder();
                this.result.hasReferId = false;
                this.result.referId_ = 0L;
                return this;
            }

            public SnsPostRequest.Builder ClearSyncFlag()
            {
                this.PrepareBuilder();
                this.result.hasSyncFlag = false;
                this.result.syncFlag_ = 0;
                return this;
            }

            public SnsPostRequest.Builder ClearTwitterInfo()
            {
                this.PrepareBuilder();
                this.result.hasTwitterInfo = false;
                this.result.twitterInfo_ = null;
                return this;
            }

            public SnsPostRequest.Builder ClearWithUserList()
            {
                this.PrepareBuilder();
                this.result.withUserList_.Clear();
                return this;
            }

            public SnsPostRequest.Builder ClearWithUserListNum()
            {
                this.PrepareBuilder();
                this.result.hasWithUserListNum = false;
                this.result.withUserListNum_ = 0;
                return this;
            }

            public override SnsPostRequest.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new SnsPostRequest.Builder(this.result);
                }
                return new SnsPostRequest.Builder().MergeFrom(this.result);
            }

            public SKBuiltinString_t GetBlackList(int index)
            {
                return this.result.GetBlackList(index);
            }

            public SnsGroup GetGroupIds(int index)
            {
                return this.result.GetGroupIds(index);
            }

            public SKBuiltinString_t GetGroupUser(int index)
            {
                return this.result.GetGroupUser(index);
            }

            public SKBuiltinString_t GetWithUserList(int index)
            {
                return this.result.GetWithUserList(index);
            }

            public SnsPostRequest.Builder MergeBaseRequest(BaseRequest value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasBaseRequest && (this.result.baseRequest_ != BaseRequest.DefaultInstance))
                {
                    this.result.baseRequest_ = BaseRequest.CreateBuilder(this.result.baseRequest_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.baseRequest_ = value;
                }
                this.result.hasBaseRequest = true;
                return this;
            }

            public SnsPostRequest.Builder MergeCtocUploadInfo(SnsPostCtocUploadInfo value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasCtocUploadInfo && (this.result.ctocUploadInfo_ != SnsPostCtocUploadInfo.DefaultInstance))
                {
                    this.result.ctocUploadInfo_ = SnsPostCtocUploadInfo.CreateBuilder(this.result.ctocUploadInfo_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.ctocUploadInfo_ = value;
                }
                this.result.hasCtocUploadInfo = true;
                return this;
            }

            public override SnsPostRequest.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override SnsPostRequest.Builder MergeFrom(IMessageLite other)
            {
                if (other is SnsPostRequest)
                {
                    return this.MergeFrom((SnsPostRequest) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override SnsPostRequest.Builder MergeFrom(SnsPostRequest other)
            {
                return this;
            }

            public override SnsPostRequest.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(SnsPostRequest._snsPostRequestFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = SnsPostRequest._snsPostRequestFieldTags[index];
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
                            SKBuiltinBuffer_t.Builder builder2 = SKBuiltinBuffer_t.CreateBuilder();
                            if (this.result.hasObjectDesc)
                            {
                                builder2.MergeFrom(this.ObjectDesc);
                            }
                            input.ReadMessage(builder2, extensionRegistry);
                            this.ObjectDesc = builder2.BuildPartial();
                            continue;
                        }
                        case 0x18:
                        {
                            this.result.hasWithUserListNum = input.ReadUInt32(ref this.result.withUserListNum_);
                            continue;
                        }
                        case 0:
                            throw InvalidProtocolBufferException.InvalidTag();

                        case 10:
                        {
                            BaseRequest.Builder builder = BaseRequest.CreateBuilder();
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
                            input.ReadMessageArray<SKBuiltinString_t>(num, str, this.result.withUserList_, SKBuiltinString_t.DefaultInstance, extensionRegistry);
                            continue;
                        }
                        case 40:
                        {
                            this.result.hasPrivacy = input.ReadUInt32(ref this.result.privacy_);
                            continue;
                        }
                        case 0x30:
                        {
                            this.result.hasSyncFlag = input.ReadUInt32(ref this.result.syncFlag_);
                            continue;
                        }
                        case 0x3a:
                        {
                            this.result.hasClientId = input.ReadString(ref this.result.clientId_);
                            continue;
                        }
                        case 0x40:
                        {
                            this.result.hasPostBGImgType = input.ReadUInt32(ref this.result.postBGImgType_);
                            continue;
                        }
                        case 0x58:
                        {
                            this.result.hasObjectSource = input.ReadUInt32(ref this.result.objectSource_);
                            continue;
                        }
                        case 0x60:
                        {
                            this.result.hasReferId = input.ReadUInt64(ref this.result.referId_);
                            continue;
                        }
                        case 0x68:
                        {
                            this.result.hasBlackListNum = input.ReadUInt32(ref this.result.blackListNum_);
                            continue;
                        }
                        case 0x48:
                        {
                            this.result.hasGroupNum = input.ReadUInt32(ref this.result.groupNum_);
                            continue;
                        }
                        case 0x52:
                        {
                            input.ReadMessageArray<SnsGroup>(num, str, this.result.groupIds_, SnsGroup.DefaultInstance, extensionRegistry);
                            continue;
                        }
                        case 0x72:
                        {
                            input.ReadMessageArray<SKBuiltinString_t>(num, str, this.result.blackList_, SKBuiltinString_t.DefaultInstance, extensionRegistry);
                            continue;
                        }
                        case 0x7a:
                        {
                            TwitterInfo.Builder builder3 = TwitterInfo.CreateBuilder();
                            if (this.result.hasTwitterInfo)
                            {
                                builder3.MergeFrom(this.TwitterInfo);
                            }
                            input.ReadMessage(builder3, extensionRegistry);
                            this.TwitterInfo = builder3.BuildPartial();
                            continue;
                        }
                        case 0x80:
                        {
                            this.result.hasGroupUserNum = input.ReadUInt32(ref this.result.groupUserNum_);
                            continue;
                        }
                        case 0x8a:
                        {
                            input.ReadMessageArray<SKBuiltinString_t>(num, str, this.result.groupUser_, SKBuiltinString_t.DefaultInstance, extensionRegistry);
                            continue;
                        }
                        case 0x92:
                        {
                            SnsPostCtocUploadInfo.Builder builder4 = SnsPostCtocUploadInfo.CreateBuilder();
                            if (this.result.hasCtocUploadInfo)
                            {
                                builder4.MergeFrom(this.CtocUploadInfo);
                            }
                            input.ReadMessage(builder4, extensionRegistry);
                            this.CtocUploadInfo = builder4.BuildPartial();
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

            public SnsPostRequest.Builder MergeObjectDesc(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasObjectDesc && (this.result.objectDesc_ != SKBuiltinBuffer_t.DefaultInstance))
                {
                    this.result.objectDesc_ = SKBuiltinBuffer_t.CreateBuilder(this.result.objectDesc_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.objectDesc_ = value;
                }
                this.result.hasObjectDesc = true;
                return this;
            }

            public SnsPostRequest.Builder MergeTwitterInfo(TwitterInfo value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasTwitterInfo && (this.result.twitterInfo_ != TwitterInfo.DefaultInstance))
                {
                    this.result.twitterInfo_ = TwitterInfo.CreateBuilder(this.result.twitterInfo_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.twitterInfo_ = value;
                }
                this.result.hasTwitterInfo = true;
                return this;
            }

            private SnsPostRequest PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    SnsPostRequest result = this.result;
                    this.result = new SnsPostRequest();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public SnsPostRequest.Builder SetBaseRequest(BaseRequest value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = value;
                return this;
            }

            public SnsPostRequest.Builder SetBaseRequest(BaseRequest.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = builderForValue.Build();
                return this;
            }

            public SnsPostRequest.Builder SetBlackList(int index, SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.blackList_[index] = value;
                return this;
            }

            public SnsPostRequest.Builder SetBlackList(int index, SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.blackList_[index] = builderForValue.Build();
                return this;
            }

            public SnsPostRequest.Builder SetBlackListNum(uint value)
            {
                this.PrepareBuilder();
                this.result.hasBlackListNum = true;
                this.result.blackListNum_ = value;
                return this;
            }

            public SnsPostRequest.Builder SetClientId(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasClientId = true;
                this.result.clientId_ = value;
                return this;
            }

            public SnsPostRequest.Builder SetCtocUploadInfo(SnsPostCtocUploadInfo value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasCtocUploadInfo = true;
                this.result.ctocUploadInfo_ = value;
                return this;
            }

            public SnsPostRequest.Builder SetCtocUploadInfo(SnsPostCtocUploadInfo.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasCtocUploadInfo = true;
                this.result.ctocUploadInfo_ = builderForValue.Build();
                return this;
            }

            public SnsPostRequest.Builder SetGroupIds(int index, SnsGroup value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.groupIds_[index] = value;
                return this;
            }

            public SnsPostRequest.Builder SetGroupIds(int index, SnsGroup.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.groupIds_[index] = builderForValue.Build();
                return this;
            }

            public SnsPostRequest.Builder SetGroupNum(uint value)
            {
                this.PrepareBuilder();
                this.result.hasGroupNum = true;
                this.result.groupNum_ = value;
                return this;
            }

            public SnsPostRequest.Builder SetGroupUser(int index, SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.groupUser_[index] = value;
                return this;
            }

            public SnsPostRequest.Builder SetGroupUser(int index, SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.groupUser_[index] = builderForValue.Build();
                return this;
            }

            public SnsPostRequest.Builder SetGroupUserNum(uint value)
            {
                this.PrepareBuilder();
                this.result.hasGroupUserNum = true;
                this.result.groupUserNum_ = value;
                return this;
            }

            public SnsPostRequest.Builder SetObjectDesc(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasObjectDesc = true;
                this.result.objectDesc_ = value;
                return this;
            }

            public SnsPostRequest.Builder SetObjectDesc(SKBuiltinBuffer_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasObjectDesc = true;
                this.result.objectDesc_ = builderForValue.Build();
                return this;
            }

            public SnsPostRequest.Builder SetObjectSource(uint value)
            {
                this.PrepareBuilder();
                this.result.hasObjectSource = true;
                this.result.objectSource_ = value;
                return this;
            }

            public SnsPostRequest.Builder SetPostBGImgType(uint value)
            {
                this.PrepareBuilder();
                this.result.hasPostBGImgType = true;
                this.result.postBGImgType_ = value;
                return this;
            }

            public SnsPostRequest.Builder SetPrivacy(uint value)
            {
                this.PrepareBuilder();
                this.result.hasPrivacy = true;
                this.result.privacy_ = value;
                return this;
            }

            public SnsPostRequest.Builder SetReferId(ulong value)
            {
                this.PrepareBuilder();
                this.result.hasReferId = true;
                this.result.referId_ = value;
                return this;
            }

            public SnsPostRequest.Builder SetSyncFlag(uint value)
            {
                this.PrepareBuilder();
                this.result.hasSyncFlag = true;
                this.result.syncFlag_ = value;
                return this;
            }

            public SnsPostRequest.Builder SetTwitterInfo(TwitterInfo value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasTwitterInfo = true;
                this.result.twitterInfo_ = value;
                return this;
            }

            public SnsPostRequest.Builder SetTwitterInfo(TwitterInfo.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasTwitterInfo = true;
                this.result.twitterInfo_ = builderForValue.Build();
                return this;
            }

            public SnsPostRequest.Builder SetWithUserList(int index, SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.withUserList_[index] = value;
                return this;
            }

            public SnsPostRequest.Builder SetWithUserList(int index, SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.withUserList_[index] = builderForValue.Build();
                return this;
            }

            public SnsPostRequest.Builder SetWithUserListNum(uint value)
            {
                this.PrepareBuilder();
                this.result.hasWithUserListNum = true;
                this.result.withUserListNum_ = value;
                return this;
            }

            public BaseRequest BaseRequest
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

            public int BlackListCount
            {
                get
                {
                    return this.result.BlackListCount;
                }
            }

            public IPopsicleList<SKBuiltinString_t> BlackListList
            {
                get
                {
                    return this.PrepareBuilder().blackList_;
                }
            }

            public uint BlackListNum
            {
                get
                {
                    return this.result.BlackListNum;
                }
                set
                {
                    this.SetBlackListNum(value);
                }
            }

            public string ClientId
            {
                get
                {
                    return this.result.ClientId;
                }
                set
                {
                    this.SetClientId(value);
                }
            }

            public SnsPostCtocUploadInfo CtocUploadInfo
            {
                get
                {
                    return this.result.CtocUploadInfo;
                }
                set
                {
                    this.SetCtocUploadInfo(value);
                }
            }

            public override SnsPostRequest DefaultInstanceForType
            {
                get
                {
                    return SnsPostRequest.DefaultInstance;
                }
            }

            public int GroupIdsCount
            {
                get
                {
                    return this.result.GroupIdsCount;
                }
            }

            public IPopsicleList<SnsGroup> GroupIdsList
            {
                get
                {
                    return this.PrepareBuilder().groupIds_;
                }
            }

            public uint GroupNum
            {
                get
                {
                    return this.result.GroupNum;
                }
                set
                {
                    this.SetGroupNum(value);
                }
            }

            public int GroupUserCount
            {
                get
                {
                    return this.result.GroupUserCount;
                }
            }

            public IPopsicleList<SKBuiltinString_t> GroupUserList
            {
                get
                {
                    return this.PrepareBuilder().groupUser_;
                }
            }

            public uint GroupUserNum
            {
                get
                {
                    return this.result.GroupUserNum;
                }
                set
                {
                    this.SetGroupUserNum(value);
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override SnsPostRequest MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public SKBuiltinBuffer_t ObjectDesc
            {
                get
                {
                    return this.result.ObjectDesc;
                }
                set
                {
                    this.SetObjectDesc(value);
                }
            }

            public uint ObjectSource
            {
                get
                {
                    return this.result.ObjectSource;
                }
                set
                {
                    this.SetObjectSource(value);
                }
            }

            public uint PostBGImgType
            {
                get
                {
                    return this.result.PostBGImgType;
                }
                set
                {
                    this.SetPostBGImgType(value);
                }
            }

            public uint Privacy
            {
                get
                {
                    return this.result.Privacy;
                }
                set
                {
                    this.SetPrivacy(value);
                }
            }

            public ulong ReferId
            {
                get
                {
                    return this.result.ReferId;
                }
                set
                {
                    this.SetReferId(value);
                }
            }

            public uint SyncFlag
            {
                get
                {
                    return this.result.SyncFlag;
                }
                set
                {
                    this.SetSyncFlag(value);
                }
            }

            protected override SnsPostRequest.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }

            public TwitterInfo TwitterInfo
            {
                get
                {
                    return this.result.TwitterInfo;
                }
                set
                {
                    this.SetTwitterInfo(value);
                }
            }

            public int WithUserListCount
            {
                get
                {
                    return this.result.WithUserListCount;
                }
            }

            public IPopsicleList<SKBuiltinString_t> WithUserListList
            {
                get
                {
                    return this.PrepareBuilder().withUserList_;
                }
            }

            public uint WithUserListNum
            {
                get
                {
                    return this.result.WithUserListNum;
                }
                set
                {
                    this.SetWithUserListNum(value);
                }
            }
        }
    }
}

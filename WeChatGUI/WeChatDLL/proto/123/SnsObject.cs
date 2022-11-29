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


    public sealed class SnsObject : GeneratedMessageLite<SnsObject, SnsObject.Builder>
    {
        private static readonly string[] _snsObjectFieldNames = new string[] { 
            "BlackList", "BlackListNum", "CommentCount", "CommentUserList", "CommentUserListNum", "CreateTime", "DeleteFlag", "ExtFlag", "GroupList", "GroupNum", "GroupUser", "GroupUserNum", "Id", "IsNotRichText", "LikeCount", "LikeFlag", 
            "LikeUserList", "LikeUserListNum", "Nickname", "NoChange", "ObjectDesc", "ReferId", "ReferUsername", "Username", "WithUserCount", "WithUserList", "WithUserListNum"
         };
        private static readonly uint[] _snsObjectFieldTags = new uint[] { 
            0xc2, 0xb8, 80, 0x62, 0x58, 0x20, 200, 0x80, 0x9a, 0x90, 0xda, 0xd0, 8, 160, 0x38, 0x30, 
            0x4a, 0x40, 0x1a, 0x88, 0x2a, 0xb0, 170, 0x12, 0x68, 0x7a, 0x70
         };
        private PopsicleList<SKBuiltinString_t> blackList_ = new PopsicleList<SKBuiltinString_t>();
        public const int BlackListFieldNumber = 0x18;
        private uint blackListNum_;
        public const int BlackListNumFieldNumber = 0x17;
        private uint commentCount_;
        public const int CommentCountFieldNumber = 10;
        private PopsicleList<SnsCommentInfo> commentUserList_ = new PopsicleList<SnsCommentInfo>();
        public const int CommentUserListFieldNumber = 12;
        private uint commentUserListNum_;
        public const int CommentUserListNumFieldNumber = 11;
        private uint createTime_;
        public const int CreateTimeFieldNumber = 4;
        private static readonly SnsObject defaultInstance = new SnsObject().MakeReadOnly();
        private uint deleteFlag_;
        public const int DeleteFlagFieldNumber = 0x19;
        private uint extFlag_;
        public const int ExtFlagFieldNumber = 0x10;
        private PopsicleList<SnsGroup> groupList_ = new PopsicleList<SnsGroup>();
        public const int GroupListFieldNumber = 0x13;
        private uint groupNum_;
        public const int GroupNumFieldNumber = 0x12;
        private PopsicleList<SKBuiltinString_t> groupUser_ = new PopsicleList<SKBuiltinString_t>();
        public const int GroupUserFieldNumber = 0x1b;
        private uint groupUserNum_;
        public const int GroupUserNumFieldNumber = 0x1a;
        private bool hasBlackListNum;
        private bool hasCommentCount;
        private bool hasCommentUserListNum;
        private bool hasCreateTime;
        private bool hasDeleteFlag;
        private bool hasExtFlag;
        private bool hasGroupNum;
        private bool hasGroupUserNum;
        private bool hasId;
        private bool hasIsNotRichText;
        private bool hasLikeCount;
        private bool hasLikeFlag;
        private bool hasLikeUserListNum;
        private bool hasNickname;
        private bool hasNoChange;
        private bool hasObjectDesc;
        private bool hasReferId;
        private bool hasReferUsername;
        private bool hasUsername;
        private bool hasWithUserCount;
        private bool hasWithUserListNum;
        private ulong id_;
        public const int IdFieldNumber = 1;
        private uint isNotRichText_;
        public const int IsNotRichTextFieldNumber = 20;
        private uint likeCount_;
        public const int LikeCountFieldNumber = 7;
        private uint likeFlag_;
        public const int LikeFlagFieldNumber = 6;
        private PopsicleList<SnsCommentInfo> likeUserList_ = new PopsicleList<SnsCommentInfo>();
        public const int LikeUserListFieldNumber = 9;
        private uint likeUserListNum_;
        public const int LikeUserListNumFieldNumber = 8;
        private int memoizedSerializedSize = -1;
        private string nickname_ = "";
        public const int NicknameFieldNumber = 3;
        private uint noChange_;
        public const int NoChangeFieldNumber = 0x11;
        private SKBuiltinBuffer_t objectDesc_;
        public const int ObjectDescFieldNumber = 5;
        private ulong referId_;
        public const int ReferIdFieldNumber = 0x16;
        private string referUsername_ = "";
        public const int ReferUsernameFieldNumber = 0x15;
        private string username_ = "";
        public const int UsernameFieldNumber = 2;
        private uint withUserCount_;
        public const int WithUserCountFieldNumber = 13;
        private PopsicleList<SnsCommentInfo> withUserList_ = new PopsicleList<SnsCommentInfo>();
        public const int WithUserListFieldNumber = 15;
        private uint withUserListNum_;
        public const int WithUserListNumFieldNumber = 14;

        static SnsObject()
        {
      
        }

        private SnsObject()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(SnsObject prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            SnsObject obj2 = obj as SnsObject;
            if (obj2 == null)
            {
                return false;
            }
            if ((this.hasId != obj2.hasId) || (this.hasId && !this.id_.Equals(obj2.id_)))
            {
                return false;
            }
            if ((this.hasUsername != obj2.hasUsername) || (this.hasUsername && !this.username_.Equals(obj2.username_)))
            {
                return false;
            }
            if ((this.hasNickname != obj2.hasNickname) || (this.hasNickname && !this.nickname_.Equals(obj2.nickname_)))
            {
                return false;
            }
            if ((this.hasCreateTime != obj2.hasCreateTime) || (this.hasCreateTime && !this.createTime_.Equals(obj2.createTime_)))
            {
                return false;
            }
            if ((this.hasObjectDesc != obj2.hasObjectDesc) || (this.hasObjectDesc && !this.objectDesc_.Equals(obj2.objectDesc_)))
            {
                return false;
            }
            if ((this.hasLikeFlag != obj2.hasLikeFlag) || (this.hasLikeFlag && !this.likeFlag_.Equals(obj2.likeFlag_)))
            {
                return false;
            }
            if ((this.hasLikeCount != obj2.hasLikeCount) || (this.hasLikeCount && !this.likeCount_.Equals(obj2.likeCount_)))
            {
                return false;
            }
            if ((this.hasLikeUserListNum != obj2.hasLikeUserListNum) || (this.hasLikeUserListNum && !this.likeUserListNum_.Equals(obj2.likeUserListNum_)))
            {
                return false;
            }
            if (this.likeUserList_.Count != obj2.likeUserList_.Count)
            {
                return false;
            }
            for (int i = 0; i < this.likeUserList_.Count; i++)
            {
                if (!this.likeUserList_[i].Equals(obj2.likeUserList_[i]))
                {
                    return false;
                }
            }
            if ((this.hasCommentCount != obj2.hasCommentCount) || (this.hasCommentCount && !this.commentCount_.Equals(obj2.commentCount_)))
            {
                return false;
            }
            if ((this.hasCommentUserListNum != obj2.hasCommentUserListNum) || (this.hasCommentUserListNum && !this.commentUserListNum_.Equals(obj2.commentUserListNum_)))
            {
                return false;
            }
            if (this.commentUserList_.Count != obj2.commentUserList_.Count)
            {
                return false;
            }
            for (int j = 0; j < this.commentUserList_.Count; j++)
            {
                if (!this.commentUserList_[j].Equals(obj2.commentUserList_[j]))
                {
                    return false;
                }
            }
            if ((this.hasWithUserCount != obj2.hasWithUserCount) || (this.hasWithUserCount && !this.withUserCount_.Equals(obj2.withUserCount_)))
            {
                return false;
            }
            if ((this.hasWithUserListNum != obj2.hasWithUserListNum) || (this.hasWithUserListNum && !this.withUserListNum_.Equals(obj2.withUserListNum_)))
            {
                return false;
            }
            if (this.withUserList_.Count != obj2.withUserList_.Count)
            {
                return false;
            }
            for (int k = 0; k < this.withUserList_.Count; k++)
            {
                if (!this.withUserList_[k].Equals(obj2.withUserList_[k]))
                {
                    return false;
                }
            }
            if ((this.hasExtFlag != obj2.hasExtFlag) || (this.hasExtFlag && !this.extFlag_.Equals(obj2.extFlag_)))
            {
                return false;
            }
            if ((this.hasNoChange != obj2.hasNoChange) || (this.hasNoChange && !this.noChange_.Equals(obj2.noChange_)))
            {
                return false;
            }
            if ((this.hasGroupNum != obj2.hasGroupNum) || (this.hasGroupNum && !this.groupNum_.Equals(obj2.groupNum_)))
            {
                return false;
            }
            if (this.groupList_.Count != obj2.groupList_.Count)
            {
                return false;
            }
            for (int m = 0; m < this.groupList_.Count; m++)
            {
                if (!this.groupList_[m].Equals(obj2.groupList_[m]))
                {
                    return false;
                }
            }
            if ((this.hasIsNotRichText != obj2.hasIsNotRichText) || (this.hasIsNotRichText && !this.isNotRichText_.Equals(obj2.isNotRichText_)))
            {
                return false;
            }
            if ((this.hasReferUsername != obj2.hasReferUsername) || (this.hasReferUsername && !this.referUsername_.Equals(obj2.referUsername_)))
            {
                return false;
            }
            if ((this.hasReferId != obj2.hasReferId) || (this.hasReferId && !this.referId_.Equals(obj2.referId_)))
            {
                return false;
            }
            if ((this.hasBlackListNum != obj2.hasBlackListNum) || (this.hasBlackListNum && !this.blackListNum_.Equals(obj2.blackListNum_)))
            {
                return false;
            }
            if (this.blackList_.Count != obj2.blackList_.Count)
            {
                return false;
            }
            for (int n = 0; n < this.blackList_.Count; n++)
            {
                if (!this.blackList_[n].Equals(obj2.blackList_[n]))
                {
                    return false;
                }
            }
            if ((this.hasDeleteFlag != obj2.hasDeleteFlag) || (this.hasDeleteFlag && !this.deleteFlag_.Equals(obj2.deleteFlag_)))
            {
                return false;
            }
            if ((this.hasGroupUserNum != obj2.hasGroupUserNum) || (this.hasGroupUserNum && !this.groupUserNum_.Equals(obj2.groupUserNum_)))
            {
                return false;
            }
            if (this.groupUser_.Count != obj2.groupUser_.Count)
            {
                return false;
            }
            for (int num6 = 0; num6 < this.groupUser_.Count; num6++)
            {
                if (!this.groupUser_[num6].Equals(obj2.groupUser_[num6]))
                {
                    return false;
                }
            }
            return true;
        }

        public SKBuiltinString_t GetBlackList(int index)
        {
            return this.blackList_[index];
        }

        public SnsCommentInfo GetCommentUserList(int index)
        {
            return this.commentUserList_[index];
        }

        public SnsGroup GetGroupList(int index)
        {
            return this.groupList_[index];
        }

        public SKBuiltinString_t GetGroupUser(int index)
        {
            return this.groupUser_[index];
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasId)
            {
                hashCode ^= this.id_.GetHashCode();
            }
            if (this.hasUsername)
            {
                hashCode ^= this.username_.GetHashCode();
            }
            if (this.hasNickname)
            {
                hashCode ^= this.nickname_.GetHashCode();
            }
            if (this.hasCreateTime)
            {
                hashCode ^= this.createTime_.GetHashCode();
            }
            if (this.hasObjectDesc)
            {
                hashCode ^= this.objectDesc_.GetHashCode();
            }
            if (this.hasLikeFlag)
            {
                hashCode ^= this.likeFlag_.GetHashCode();
            }
            if (this.hasLikeCount)
            {
                hashCode ^= this.likeCount_.GetHashCode();
            }
            if (this.hasLikeUserListNum)
            {
                hashCode ^= this.likeUserListNum_.GetHashCode();
            }
            foreach (SnsCommentInfo info in this.likeUserList_)
            {
                hashCode ^= info.GetHashCode();
            }
            if (this.hasCommentCount)
            {
                hashCode ^= this.commentCount_.GetHashCode();
            }
            if (this.hasCommentUserListNum)
            {
                hashCode ^= this.commentUserListNum_.GetHashCode();
            }
            foreach (SnsCommentInfo info2 in this.commentUserList_)
            {
                hashCode ^= info2.GetHashCode();
            }
            if (this.hasWithUserCount)
            {
                hashCode ^= this.withUserCount_.GetHashCode();
            }
            if (this.hasWithUserListNum)
            {
                hashCode ^= this.withUserListNum_.GetHashCode();
            }
            foreach (SnsCommentInfo info3 in this.withUserList_)
            {
                hashCode ^= info3.GetHashCode();
            }
            if (this.hasExtFlag)
            {
                hashCode ^= this.extFlag_.GetHashCode();
            }
            if (this.hasNoChange)
            {
                hashCode ^= this.noChange_.GetHashCode();
            }
            if (this.hasGroupNum)
            {
                hashCode ^= this.groupNum_.GetHashCode();
            }
            foreach (SnsGroup group in this.groupList_)
            {
                hashCode ^= group.GetHashCode();
            }
            if (this.hasIsNotRichText)
            {
                hashCode ^= this.isNotRichText_.GetHashCode();
            }
            if (this.hasReferUsername)
            {
                hashCode ^= this.referUsername_.GetHashCode();
            }
            if (this.hasReferId)
            {
                hashCode ^= this.referId_.GetHashCode();
            }
            if (this.hasBlackListNum)
            {
                hashCode ^= this.blackListNum_.GetHashCode();
            }
            foreach (SKBuiltinString_t _t in this.blackList_)
            {
                hashCode ^= _t.GetHashCode();
            }
            if (this.hasDeleteFlag)
            {
                hashCode ^= this.deleteFlag_.GetHashCode();
            }
            if (this.hasGroupUserNum)
            {
                hashCode ^= this.groupUserNum_.GetHashCode();
            }
            foreach (SKBuiltinString_t _t2 in this.groupUser_)
            {
                hashCode ^= _t2.GetHashCode();
            }
            return hashCode;
        }

        public SnsCommentInfo GetLikeUserList(int index)
        {
            return this.likeUserList_[index];
        }

        public SnsCommentInfo GetWithUserList(int index)
        {
            return this.withUserList_[index];
        }

        private SnsObject MakeReadOnly()
        {
            this.likeUserList_.MakeReadOnly();
            this.commentUserList_.MakeReadOnly();
            this.withUserList_.MakeReadOnly();
            this.groupList_.MakeReadOnly();
            this.blackList_.MakeReadOnly();
            this.groupUser_.MakeReadOnly();
            return this;
        }

        public static SnsObject ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<SnsObject, Builder>.PrintField("Id", this.hasId, this.id_, writer);
            GeneratedMessageLite<SnsObject, Builder>.PrintField("Username", this.hasUsername, this.username_, writer);
            GeneratedMessageLite<SnsObject, Builder>.PrintField("Nickname", this.hasNickname, this.nickname_, writer);
            GeneratedMessageLite<SnsObject, Builder>.PrintField("CreateTime", this.hasCreateTime, this.createTime_, writer);
            GeneratedMessageLite<SnsObject, Builder>.PrintField("ObjectDesc", this.hasObjectDesc, this.objectDesc_, writer);
            GeneratedMessageLite<SnsObject, Builder>.PrintField("LikeFlag", this.hasLikeFlag, this.likeFlag_, writer);
            GeneratedMessageLite<SnsObject, Builder>.PrintField("LikeCount", this.hasLikeCount, this.likeCount_, writer);
            GeneratedMessageLite<SnsObject, Builder>.PrintField("LikeUserListNum", this.hasLikeUserListNum, this.likeUserListNum_, writer);
            GeneratedMessageLite<SnsObject, Builder>.PrintField<SnsCommentInfo>("LikeUserList", this.likeUserList_, writer);
            GeneratedMessageLite<SnsObject, Builder>.PrintField("CommentCount", this.hasCommentCount, this.commentCount_, writer);
            GeneratedMessageLite<SnsObject, Builder>.PrintField("CommentUserListNum", this.hasCommentUserListNum, this.commentUserListNum_, writer);
            GeneratedMessageLite<SnsObject, Builder>.PrintField<SnsCommentInfo>("CommentUserList", this.commentUserList_, writer);
            GeneratedMessageLite<SnsObject, Builder>.PrintField("WithUserCount", this.hasWithUserCount, this.withUserCount_, writer);
            GeneratedMessageLite<SnsObject, Builder>.PrintField("WithUserListNum", this.hasWithUserListNum, this.withUserListNum_, writer);
            GeneratedMessageLite<SnsObject, Builder>.PrintField<SnsCommentInfo>("WithUserList", this.withUserList_, writer);
            GeneratedMessageLite<SnsObject, Builder>.PrintField("ExtFlag", this.hasExtFlag, this.extFlag_, writer);
            GeneratedMessageLite<SnsObject, Builder>.PrintField("NoChange", this.hasNoChange, this.noChange_, writer);
            GeneratedMessageLite<SnsObject, Builder>.PrintField("GroupNum", this.hasGroupNum, this.groupNum_, writer);
            GeneratedMessageLite<SnsObject, Builder>.PrintField<SnsGroup>("GroupList", this.groupList_, writer);
            GeneratedMessageLite<SnsObject, Builder>.PrintField("IsNotRichText", this.hasIsNotRichText, this.isNotRichText_, writer);
            GeneratedMessageLite<SnsObject, Builder>.PrintField("ReferUsername", this.hasReferUsername, this.referUsername_, writer);
            GeneratedMessageLite<SnsObject, Builder>.PrintField("ReferId", this.hasReferId, this.referId_, writer);
            GeneratedMessageLite<SnsObject, Builder>.PrintField("BlackListNum", this.hasBlackListNum, this.blackListNum_, writer);
            GeneratedMessageLite<SnsObject, Builder>.PrintField<SKBuiltinString_t>("BlackList", this.blackList_, writer);
            GeneratedMessageLite<SnsObject, Builder>.PrintField("DeleteFlag", this.hasDeleteFlag, this.deleteFlag_, writer);
            GeneratedMessageLite<SnsObject, Builder>.PrintField("GroupUserNum", this.hasGroupUserNum, this.groupUserNum_, writer);
            GeneratedMessageLite<SnsObject, Builder>.PrintField<SKBuiltinString_t>("GroupUser", this.groupUser_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _snsObjectFieldNames;
            if (this.hasId)
            {
                output.WriteUInt64(1, strArray[12], this.Id);
            }
            if (this.hasUsername)
            {
                output.WriteString(2, strArray[0x17], this.Username);
            }
            if (this.hasNickname)
            {
                output.WriteString(3, strArray[0x12], this.Nickname);
            }
            if (this.hasCreateTime)
            {
                output.WriteUInt32(4, strArray[5], this.CreateTime);
            }
            if (this.hasObjectDesc)
            {
                output.WriteMessage(5, strArray[20], this.ObjectDesc);
            }
            if (this.hasLikeFlag)
            {
                output.WriteUInt32(6, strArray[15], this.LikeFlag);
            }
            if (this.hasLikeCount)
            {
                output.WriteUInt32(7, strArray[14], this.LikeCount);
            }
            if (this.hasLikeUserListNum)
            {
                output.WriteUInt32(8, strArray[0x11], this.LikeUserListNum);
            }
            if (this.likeUserList_.Count > 0)
            {
                output.WriteMessageArray<SnsCommentInfo>(9, strArray[0x10], this.likeUserList_);
            }
            if (this.hasCommentCount)
            {
                output.WriteUInt32(10, strArray[2], this.CommentCount);
            }
            if (this.hasCommentUserListNum)
            {
                output.WriteUInt32(11, strArray[4], this.CommentUserListNum);
            }
            if (this.commentUserList_.Count > 0)
            {
                output.WriteMessageArray<SnsCommentInfo>(12, strArray[3], this.commentUserList_);
            }
            if (this.hasWithUserCount)
            {
                output.WriteUInt32(13, strArray[0x18], this.WithUserCount);
            }
            if (this.hasWithUserListNum)
            {
                output.WriteUInt32(14, strArray[0x1a], this.WithUserListNum);
            }
            if (this.withUserList_.Count > 0)
            {
                output.WriteMessageArray<SnsCommentInfo>(15, strArray[0x19], this.withUserList_);
            }
            if (this.hasExtFlag)
            {
                output.WriteUInt32(0x10, strArray[7], this.ExtFlag);
            }
            if (this.hasNoChange)
            {
                output.WriteUInt32(0x11, strArray[0x13], this.NoChange);
            }
            if (this.hasGroupNum)
            {
                output.WriteUInt32(0x12, strArray[9], this.GroupNum);
            }
            if (this.groupList_.Count > 0)
            {
                output.WriteMessageArray<SnsGroup>(0x13, strArray[8], this.groupList_);
            }
            if (this.hasIsNotRichText)
            {
                output.WriteUInt32(20, strArray[13], this.IsNotRichText);
            }
            if (this.hasReferUsername)
            {
                output.WriteString(0x15, strArray[0x16], this.ReferUsername);
            }
            if (this.hasReferId)
            {
                output.WriteUInt64(0x16, strArray[0x15], this.ReferId);
            }
            if (this.hasBlackListNum)
            {
                output.WriteUInt32(0x17, strArray[1], this.BlackListNum);
            }
            if (this.blackList_.Count > 0)
            {
                output.WriteMessageArray<SKBuiltinString_t>(0x18, strArray[0], this.blackList_);
            }
            if (this.hasDeleteFlag)
            {
                output.WriteUInt32(0x19, strArray[6], this.DeleteFlag);
            }
            if (this.hasGroupUserNum)
            {
                output.WriteUInt32(0x1a, strArray[11], this.GroupUserNum);
            }
            if (this.groupUser_.Count > 0)
            {
                output.WriteMessageArray<SKBuiltinString_t>(0x1b, strArray[10], this.groupUser_);
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

        public uint CommentCount
        {
            get
            {
                return this.commentCount_;
            }
        }

        public int CommentUserListCount
        {
            get
            {
                return this.commentUserList_.Count;
            }
        }

        public IList<SnsCommentInfo> CommentUserListList
        {
            get
            {
                return this.commentUserList_;
            }
        }

        public uint CommentUserListNum
        {
            get
            {
                return this.commentUserListNum_;
            }
        }

        public uint CreateTime
        {
            get
            {
                return this.createTime_;
            }
        }

        public static SnsObject DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override SnsObject DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public uint DeleteFlag
        {
            get
            {
                return this.deleteFlag_;
            }
        }

        public uint ExtFlag
        {
            get
            {
                return this.extFlag_;
            }
        }

        public int GroupListCount
        {
            get
            {
                return this.groupList_.Count;
            }
        }

        public IList<SnsGroup> GroupListList
        {
            get
            {
                return this.groupList_;
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

        public ulong Id
        {
            get
            {
                return this.id_;
            }
        }

        public override bool IsInitialized
        {
            get
            {
                if (!this.hasId)
                {
                    return false;
                }
                if (!this.hasCreateTime)
                {
                    return false;
                }
                if (!this.hasObjectDesc)
                {
                    return false;
                }
                if (!this.hasLikeFlag)
                {
                    return false;
                }
                if (!this.hasLikeCount)
                {
                    return false;
                }
                if (!this.hasLikeUserListNum)
                {
                    return false;
                }
                if (!this.hasCommentCount)
                {
                    return false;
                }
                if (!this.hasCommentUserListNum)
                {
                    return false;
                }
                if (!this.hasWithUserCount)
                {
                    return false;
                }
                if (!this.hasWithUserListNum)
                {
                    return false;
                }
                if (!this.ObjectDesc.IsInitialized)
                {
                    return false;
                }
                foreach (SnsCommentInfo info in this.LikeUserListList)
                {
                    if (!info.IsInitialized)
                    {
                        return false;
                    }
                }
                foreach (SnsCommentInfo info2 in this.CommentUserListList)
                {
                    if (!info2.IsInitialized)
                    {
                        return false;
                    }
                }
                foreach (SnsCommentInfo info3 in this.WithUserListList)
                {
                    if (!info3.IsInitialized)
                    {
                        return false;
                    }
                }
                foreach (SnsGroup group in this.GroupListList)
                {
                    if (!group.IsInitialized)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public uint IsNotRichText
        {
            get
            {
                return this.isNotRichText_;
            }
        }

        public uint LikeCount
        {
            get
            {
                return this.likeCount_;
            }
        }

        public uint LikeFlag
        {
            get
            {
                return this.likeFlag_;
            }
        }

        public int LikeUserListCount
        {
            get
            {
                return this.likeUserList_.Count;
            }
        }

        public IList<SnsCommentInfo> LikeUserListList
        {
            get
            {
                return this.likeUserList_;
            }
        }

        public uint LikeUserListNum
        {
            get
            {
                return this.likeUserListNum_;
            }
        }

        public string Nickname
        {
            get
            {
                return this.nickname_;
            }
        }

        public uint NoChange
        {
            get
            {
                return this.noChange_;
            }
        }

        public SKBuiltinBuffer_t ObjectDesc
        {
            get
            {
                return (this.objectDesc_ ?? SKBuiltinBuffer_t.DefaultInstance);
            }
        }

        public ulong ReferId
        {
            get
            {
                return this.referId_;
            }
        }

        public string ReferUsername
        {
            get
            {
                return this.referUsername_;
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
                    if (this.hasId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt64Size(1, this.Id);
                    }
                    if (this.hasUsername)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(2, this.Username);
                    }
                    if (this.hasNickname)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(3, this.Nickname);
                    }
                    if (this.hasCreateTime)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(4, this.CreateTime);
                    }
                    if (this.hasObjectDesc)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(5, this.ObjectDesc);
                    }
                    if (this.hasLikeFlag)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(6, this.LikeFlag);
                    }
                    if (this.hasLikeCount)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(7, this.LikeCount);
                    }
                    if (this.hasLikeUserListNum)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(8, this.LikeUserListNum);
                    }
                    foreach (SnsCommentInfo info in this.LikeUserListList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(9, info);
                    }
                    if (this.hasCommentCount)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(10, this.CommentCount);
                    }
                    if (this.hasCommentUserListNum)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(11, this.CommentUserListNum);
                    }
                    foreach (SnsCommentInfo info2 in this.CommentUserListList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(12, info2);
                    }
                    if (this.hasWithUserCount)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(13, this.WithUserCount);
                    }
                    if (this.hasWithUserListNum)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(14, this.WithUserListNum);
                    }
                    foreach (SnsCommentInfo info3 in this.WithUserListList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(15, info3);
                    }
                    if (this.hasExtFlag)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(0x10, this.ExtFlag);
                    }
                    if (this.hasNoChange)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(0x11, this.NoChange);
                    }
                    if (this.hasGroupNum)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(0x12, this.GroupNum);
                    }
                    foreach (SnsGroup group in this.GroupListList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(0x13, group);
                    }
                    if (this.hasIsNotRichText)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(20, this.IsNotRichText);
                    }
                    if (this.hasReferUsername)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x15, this.ReferUsername);
                    }
                    if (this.hasReferId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt64Size(0x16, this.ReferId);
                    }
                    if (this.hasBlackListNum)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(0x17, this.BlackListNum);
                    }
                    foreach (SKBuiltinString_t _t in this.BlackListList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(0x18, _t);
                    }
                    if (this.hasDeleteFlag)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(0x19, this.DeleteFlag);
                    }
                    if (this.hasGroupUserNum)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(0x1a, this.GroupUserNum);
                    }
                    foreach (SKBuiltinString_t _t2 in this.GroupUserList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(0x1b, _t2);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override SnsObject ThisMessage
        {
            get
            {
                return this;
            }
        }

        public string Username
        {
            get
            {
                return this.username_;
            }
        }

        public uint WithUserCount
        {
            get
            {
                return this.withUserCount_;
            }
        }

        public int WithUserListCount
        {
            get
            {
                return this.withUserList_.Count;
            }
        }

        public IList<SnsCommentInfo> WithUserListList
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
        public sealed class Builder : GeneratedBuilderLite<SnsObject, SnsObject.Builder>
        {
            private SnsObject result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = SnsObject.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(SnsObject cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public SnsObject.Builder AddBlackList(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.blackList_.Add(value);
                return this;
            }

            public SnsObject.Builder AddBlackList(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.blackList_.Add(builderForValue.Build());
                return this;
            }

            public SnsObject.Builder AddCommentUserList(SnsCommentInfo value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.commentUserList_.Add(value);
                return this;
            }

            public SnsObject.Builder AddCommentUserList(SnsCommentInfo.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.commentUserList_.Add(builderForValue.Build());
                return this;
            }

            public SnsObject.Builder AddGroupList(SnsGroup value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.groupList_.Add(value);
                return this;
            }

            public SnsObject.Builder AddGroupList(SnsGroup.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.groupList_.Add(builderForValue.Build());
                return this;
            }

            public SnsObject.Builder AddGroupUser(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.groupUser_.Add(value);
                return this;
            }

            public SnsObject.Builder AddGroupUser(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.groupUser_.Add(builderForValue.Build());
                return this;
            }

            public SnsObject.Builder AddLikeUserList(SnsCommentInfo value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.likeUserList_.Add(value);
                return this;
            }

            public SnsObject.Builder AddLikeUserList(SnsCommentInfo.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.likeUserList_.Add(builderForValue.Build());
                return this;
            }

            public SnsObject.Builder AddRangeBlackList(IEnumerable<SKBuiltinString_t> values)
            {
                this.PrepareBuilder();
                this.result.blackList_.Add(values);
                return this;
            }

            public SnsObject.Builder AddRangeCommentUserList(IEnumerable<SnsCommentInfo> values)
            {
                this.PrepareBuilder();
                this.result.commentUserList_.Add(values);
                return this;
            }

            public SnsObject.Builder AddRangeGroupList(IEnumerable<SnsGroup> values)
            {
                this.PrepareBuilder();
                this.result.groupList_.Add(values);
                return this;
            }

            public SnsObject.Builder AddRangeGroupUser(IEnumerable<SKBuiltinString_t> values)
            {
                this.PrepareBuilder();
                this.result.groupUser_.Add(values);
                return this;
            }

            public SnsObject.Builder AddRangeLikeUserList(IEnumerable<SnsCommentInfo> values)
            {
                this.PrepareBuilder();
                this.result.likeUserList_.Add(values);
                return this;
            }

            public SnsObject.Builder AddRangeWithUserList(IEnumerable<SnsCommentInfo> values)
            {
                this.PrepareBuilder();
                this.result.withUserList_.Add(values);
                return this;
            }

            public SnsObject.Builder AddWithUserList(SnsCommentInfo value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.withUserList_.Add(value);
                return this;
            }

            public SnsObject.Builder AddWithUserList(SnsCommentInfo.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.withUserList_.Add(builderForValue.Build());
                return this;
            }

            public override SnsObject BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override SnsObject.Builder Clear()
            {
                this.result = SnsObject.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public SnsObject.Builder ClearBlackList()
            {
                this.PrepareBuilder();
                this.result.blackList_.Clear();
                return this;
            }

            public SnsObject.Builder ClearBlackListNum()
            {
                this.PrepareBuilder();
                this.result.hasBlackListNum = false;
                this.result.blackListNum_ = 0;
                return this;
            }

            public SnsObject.Builder ClearCommentCount()
            {
                this.PrepareBuilder();
                this.result.hasCommentCount = false;
                this.result.commentCount_ = 0;
                return this;
            }

            public SnsObject.Builder ClearCommentUserList()
            {
                this.PrepareBuilder();
                this.result.commentUserList_.Clear();
                return this;
            }

            public SnsObject.Builder ClearCommentUserListNum()
            {
                this.PrepareBuilder();
                this.result.hasCommentUserListNum = false;
                this.result.commentUserListNum_ = 0;
                return this;
            }

            public SnsObject.Builder ClearCreateTime()
            {
                this.PrepareBuilder();
                this.result.hasCreateTime = false;
                this.result.createTime_ = 0;
                return this;
            }

            public SnsObject.Builder ClearDeleteFlag()
            {
                this.PrepareBuilder();
                this.result.hasDeleteFlag = false;
                this.result.deleteFlag_ = 0;
                return this;
            }

            public SnsObject.Builder ClearExtFlag()
            {
                this.PrepareBuilder();
                this.result.hasExtFlag = false;
                this.result.extFlag_ = 0;
                return this;
            }

            public SnsObject.Builder ClearGroupList()
            {
                this.PrepareBuilder();
                this.result.groupList_.Clear();
                return this;
            }

            public SnsObject.Builder ClearGroupNum()
            {
                this.PrepareBuilder();
                this.result.hasGroupNum = false;
                this.result.groupNum_ = 0;
                return this;
            }

            public SnsObject.Builder ClearGroupUser()
            {
                this.PrepareBuilder();
                this.result.groupUser_.Clear();
                return this;
            }

            public SnsObject.Builder ClearGroupUserNum()
            {
                this.PrepareBuilder();
                this.result.hasGroupUserNum = false;
                this.result.groupUserNum_ = 0;
                return this;
            }

            public SnsObject.Builder ClearId()
            {
                this.PrepareBuilder();
                this.result.hasId = false;
                this.result.id_ = 0L;
                return this;
            }

            public SnsObject.Builder ClearIsNotRichText()
            {
                this.PrepareBuilder();
                this.result.hasIsNotRichText = false;
                this.result.isNotRichText_ = 0;
                return this;
            }

            public SnsObject.Builder ClearLikeCount()
            {
                this.PrepareBuilder();
                this.result.hasLikeCount = false;
                this.result.likeCount_ = 0;
                return this;
            }

            public SnsObject.Builder ClearLikeFlag()
            {
                this.PrepareBuilder();
                this.result.hasLikeFlag = false;
                this.result.likeFlag_ = 0;
                return this;
            }

            public SnsObject.Builder ClearLikeUserList()
            {
                this.PrepareBuilder();
                this.result.likeUserList_.Clear();
                return this;
            }

            public SnsObject.Builder ClearLikeUserListNum()
            {
                this.PrepareBuilder();
                this.result.hasLikeUserListNum = false;
                this.result.likeUserListNum_ = 0;
                return this;
            }

            public SnsObject.Builder ClearNickname()
            {
                this.PrepareBuilder();
                this.result.hasNickname = false;
                this.result.nickname_ = "";
                return this;
            }

            public SnsObject.Builder ClearNoChange()
            {
                this.PrepareBuilder();
                this.result.hasNoChange = false;
                this.result.noChange_ = 0;
                return this;
            }

            public SnsObject.Builder ClearObjectDesc()
            {
                this.PrepareBuilder();
                this.result.hasObjectDesc = false;
                this.result.objectDesc_ = null;
                return this;
            }

            public SnsObject.Builder ClearReferId()
            {
                this.PrepareBuilder();
                this.result.hasReferId = false;
                this.result.referId_ = 0L;
                return this;
            }

            public SnsObject.Builder ClearReferUsername()
            {
                this.PrepareBuilder();
                this.result.hasReferUsername = false;
                this.result.referUsername_ = "";
                return this;
            }

            public SnsObject.Builder ClearUsername()
            {
                this.PrepareBuilder();
                this.result.hasUsername = false;
                this.result.username_ = "";
                return this;
            }

            public SnsObject.Builder ClearWithUserCount()
            {
                this.PrepareBuilder();
                this.result.hasWithUserCount = false;
                this.result.withUserCount_ = 0;
                return this;
            }

            public SnsObject.Builder ClearWithUserList()
            {
                this.PrepareBuilder();
                this.result.withUserList_.Clear();
                return this;
            }

            public SnsObject.Builder ClearWithUserListNum()
            {
                this.PrepareBuilder();
                this.result.hasWithUserListNum = false;
                this.result.withUserListNum_ = 0;
                return this;
            }

            public override SnsObject.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new SnsObject.Builder(this.result);
                }
                return new SnsObject.Builder().MergeFrom(this.result);
            }

            public SKBuiltinString_t GetBlackList(int index)
            {
                return this.result.GetBlackList(index);
            }

            public SnsCommentInfo GetCommentUserList(int index)
            {
                return this.result.GetCommentUserList(index);
            }

            public SnsGroup GetGroupList(int index)
            {
                return this.result.GetGroupList(index);
            }

            public SKBuiltinString_t GetGroupUser(int index)
            {
                return this.result.GetGroupUser(index);
            }

            public SnsCommentInfo GetLikeUserList(int index)
            {
                return this.result.GetLikeUserList(index);
            }

            public SnsCommentInfo GetWithUserList(int index)
            {
                return this.result.GetWithUserList(index);
            }

            public override SnsObject.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override SnsObject.Builder MergeFrom(IMessageLite other)
            {
                if (other is SnsObject)
                {
                    return this.MergeFrom((SnsObject)other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override SnsObject.Builder MergeFrom(SnsObject other)
            {
                return this;
            }

            public override SnsObject.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(SnsObject._snsObjectFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = SnsObject._snsObjectFieldTags[index];
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

                        case 8:
                            {
                                this.result.hasId = input.ReadUInt64(ref this.result.id_);
                                continue;
                            }
                        case 0x12:
                            {
                                this.result.hasUsername = input.ReadString(ref this.result.username_);
                                continue;
                            }
                        case 0x2a:
                            {
                                SKBuiltinBuffer_t.Builder builder = SKBuiltinBuffer_t.CreateBuilder();
                                if (this.result.hasObjectDesc)
                                {
                                    builder.MergeFrom(this.ObjectDesc);
                                }
                                input.ReadMessage(builder, extensionRegistry);
                                this.ObjectDesc = builder.BuildPartial();
                                continue;
                            }
                        case 0x30:
                            {
                                this.result.hasLikeFlag = input.ReadUInt32(ref this.result.likeFlag_);
                                continue;
                            }
                        case 0x1a:
                            {
                                this.result.hasNickname = input.ReadString(ref this.result.nickname_);
                                continue;
                            }
                        case 0x20:
                            {
                                this.result.hasCreateTime = input.ReadUInt32(ref this.result.createTime_);
                                continue;
                            }
                        case 0x38:
                            {
                                this.result.hasLikeCount = input.ReadUInt32(ref this.result.likeCount_);
                                continue;
                            }
                        case 0x40:
                            {
                                this.result.hasLikeUserListNum = input.ReadUInt32(ref this.result.likeUserListNum_);
                                continue;
                            }
                        case 0x4a:
                            {
                                input.ReadMessageArray<SnsCommentInfo>(num, str, this.result.likeUserList_, SnsCommentInfo.DefaultInstance, extensionRegistry);
                                continue;
                            }
                        case 0x62:
                            {
                                input.ReadMessageArray<SnsCommentInfo>(num, str, this.result.commentUserList_, SnsCommentInfo.DefaultInstance, extensionRegistry);
                                continue;
                            }
                        case 0x68:
                            {
                                this.result.hasWithUserCount = input.ReadUInt32(ref this.result.withUserCount_);
                                continue;
                            }
                        case 80:
                            {
                                this.result.hasCommentCount = input.ReadUInt32(ref this.result.commentCount_);
                                continue;
                            }
                        case 0x58:
                            {
                                this.result.hasCommentUserListNum = input.ReadUInt32(ref this.result.commentUserListNum_);
                                continue;
                            }
                        case 0x70:
                            {
                                this.result.hasWithUserListNum = input.ReadUInt32(ref this.result.withUserListNum_);
                                continue;
                            }
                        case 0x7a:
                            {
                                input.ReadMessageArray<SnsCommentInfo>(num, str, this.result.withUserList_, SnsCommentInfo.DefaultInstance, extensionRegistry);
                                continue;
                            }
                        case 0x80:
                            {
                                this.result.hasExtFlag = input.ReadUInt32(ref this.result.extFlag_);
                                continue;
                            }
                        case 0x9a:
                            {
                                input.ReadMessageArray<SnsGroup>(num, str, this.result.groupList_, SnsGroup.DefaultInstance, extensionRegistry);
                                continue;
                            }
                        case 160:
                            {
                                this.result.hasIsNotRichText = input.ReadUInt32(ref this.result.isNotRichText_);
                                continue;
                            }
                        case 0x88:
                            {
                                this.result.hasNoChange = input.ReadUInt32(ref this.result.noChange_);
                                continue;
                            }
                        case 0x90:
                            {
                                this.result.hasGroupNum = input.ReadUInt32(ref this.result.groupNum_);
                                continue;
                            }
                        case 170:
                            {
                                this.result.hasReferUsername = input.ReadString(ref this.result.referUsername_);
                                continue;
                            }
                        case 0xb0:
                            {
                                this.result.hasReferId = input.ReadUInt64(ref this.result.referId_);
                                continue;
                            }
                        case 0xb8:
                            {
                                this.result.hasBlackListNum = input.ReadUInt32(ref this.result.blackListNum_);
                                continue;
                            }
                        case 0xc2:
                            {
                                input.ReadMessageArray<SKBuiltinString_t>(num, str, this.result.blackList_, SKBuiltinString_t.DefaultInstance, extensionRegistry);
                                continue;
                            }
                        case 200:
                            {
                                this.result.hasDeleteFlag = input.ReadUInt32(ref this.result.deleteFlag_);
                                continue;
                            }
                        case 0xd0:
                            {
                                this.result.hasGroupUserNum = input.ReadUInt32(ref this.result.groupUserNum_);
                                continue;
                            }
                        case 0xda:
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
                    input.ReadMessageArray<SKBuiltinString_t>(num, str, this.result.groupUser_, SKBuiltinString_t.DefaultInstance, extensionRegistry);
                }
                return this;
            }

            public SnsObject.Builder MergeObjectDesc(SKBuiltinBuffer_t value)
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

            private SnsObject PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    SnsObject result = this.result;
                    this.result = new SnsObject();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public SnsObject.Builder SetBlackList(int index, SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.blackList_[index] = value;
                return this;
            }

            public SnsObject.Builder SetBlackList(int index, SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.blackList_[index] = builderForValue.Build();
                return this;
            }

            public SnsObject.Builder SetBlackListNum(uint value)
            {
                this.PrepareBuilder();
                this.result.hasBlackListNum = true;
                this.result.blackListNum_ = value;
                return this;
            }

            public SnsObject.Builder SetCommentCount(uint value)
            {
                this.PrepareBuilder();
                this.result.hasCommentCount = true;
                this.result.commentCount_ = value;
                return this;
            }

            public SnsObject.Builder SetCommentUserList(int index, SnsCommentInfo value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.commentUserList_[index] = value;
                return this;
            }

            public SnsObject.Builder SetCommentUserList(int index, SnsCommentInfo.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.commentUserList_[index] = builderForValue.Build();
                return this;
            }

            public SnsObject.Builder SetCommentUserListNum(uint value)
            {
                this.PrepareBuilder();
                this.result.hasCommentUserListNum = true;
                this.result.commentUserListNum_ = value;
                return this;
            }

            public SnsObject.Builder SetCreateTime(uint value)
            {
                this.PrepareBuilder();
                this.result.hasCreateTime = true;
                this.result.createTime_ = value;
                return this;
            }

            public SnsObject.Builder SetDeleteFlag(uint value)
            {
                this.PrepareBuilder();
                this.result.hasDeleteFlag = true;
                this.result.deleteFlag_ = value;
                return this;
            }

            public SnsObject.Builder SetExtFlag(uint value)
            {
                this.PrepareBuilder();
                this.result.hasExtFlag = true;
                this.result.extFlag_ = value;
                return this;
            }

            public SnsObject.Builder SetGroupList(int index, SnsGroup value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.groupList_[index] = value;
                return this;
            }

            public SnsObject.Builder SetGroupList(int index, SnsGroup.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.groupList_[index] = builderForValue.Build();
                return this;
            }

            public SnsObject.Builder SetGroupNum(uint value)
            {
                this.PrepareBuilder();
                this.result.hasGroupNum = true;
                this.result.groupNum_ = value;
                return this;
            }

            public SnsObject.Builder SetGroupUser(int index, SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.groupUser_[index] = value;
                return this;
            }

            public SnsObject.Builder SetGroupUser(int index, SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.groupUser_[index] = builderForValue.Build();
                return this;
            }

            public SnsObject.Builder SetGroupUserNum(uint value)
            {
                this.PrepareBuilder();
                this.result.hasGroupUserNum = true;
                this.result.groupUserNum_ = value;
                return this;
            }

            public SnsObject.Builder SetId(ulong value)
            {
                this.PrepareBuilder();
                this.result.hasId = true;
                this.result.id_ = value;
                return this;
            }

            public SnsObject.Builder SetIsNotRichText(uint value)
            {
                this.PrepareBuilder();
                this.result.hasIsNotRichText = true;
                this.result.isNotRichText_ = value;
                return this;
            }

            public SnsObject.Builder SetLikeCount(uint value)
            {
                this.PrepareBuilder();
                this.result.hasLikeCount = true;
                this.result.likeCount_ = value;
                return this;
            }

            public SnsObject.Builder SetLikeFlag(uint value)
            {
                this.PrepareBuilder();
                this.result.hasLikeFlag = true;
                this.result.likeFlag_ = value;
                return this;
            }

            public SnsObject.Builder SetLikeUserList(int index, SnsCommentInfo value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.likeUserList_[index] = value;
                return this;
            }

            public SnsObject.Builder SetLikeUserList(int index, SnsCommentInfo.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.likeUserList_[index] = builderForValue.Build();
                return this;
            }

            public SnsObject.Builder SetLikeUserListNum(uint value)
            {
                this.PrepareBuilder();
                this.result.hasLikeUserListNum = true;
                this.result.likeUserListNum_ = value;
                return this;
            }

            public SnsObject.Builder SetNickname(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasNickname = true;
                this.result.nickname_ = value;
                return this;
            }

            public SnsObject.Builder SetNoChange(uint value)
            {
                this.PrepareBuilder();
                this.result.hasNoChange = true;
                this.result.noChange_ = value;
                return this;
            }

            public SnsObject.Builder SetObjectDesc(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasObjectDesc = true;
                this.result.objectDesc_ = value;
                return this;
            }

            public SnsObject.Builder SetObjectDesc(SKBuiltinBuffer_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasObjectDesc = true;
                this.result.objectDesc_ = builderForValue.Build();
                return this;
            }

            public SnsObject.Builder SetReferId(ulong value)
            {
                this.PrepareBuilder();
                this.result.hasReferId = true;
                this.result.referId_ = value;
                return this;
            }

            public SnsObject.Builder SetReferUsername(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasReferUsername = true;
                this.result.referUsername_ = value;
                return this;
            }

            public SnsObject.Builder SetUsername(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasUsername = true;
                this.result.username_ = value;
                return this;
            }

            public SnsObject.Builder SetWithUserCount(uint value)
            {
                this.PrepareBuilder();
                this.result.hasWithUserCount = true;
                this.result.withUserCount_ = value;
                return this;
            }

            public SnsObject.Builder SetWithUserList(int index, SnsCommentInfo value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.withUserList_[index] = value;
                return this;
            }

            public SnsObject.Builder SetWithUserList(int index, SnsCommentInfo.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.withUserList_[index] = builderForValue.Build();
                return this;
            }

            public SnsObject.Builder SetWithUserListNum(uint value)
            {
                this.PrepareBuilder();
                this.result.hasWithUserListNum = true;
                this.result.withUserListNum_ = value;
                return this;
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

            public uint CommentCount
            {
                get
                {
                    return this.result.CommentCount;
                }
                set
                {
                    this.SetCommentCount(value);
                }
            }

            public int CommentUserListCount
            {
                get
                {
                    return this.result.CommentUserListCount;
                }
            }

            public IPopsicleList<SnsCommentInfo> CommentUserListList
            {
                get
                {
                    return this.PrepareBuilder().commentUserList_;
                }
            }

            public uint CommentUserListNum
            {
                get
                {
                    return this.result.CommentUserListNum;
                }
                set
                {
                    this.SetCommentUserListNum(value);
                }
            }

            public uint CreateTime
            {
                get
                {
                    return this.result.CreateTime;
                }
                set
                {
                    this.SetCreateTime(value);
                }
            }

            public override SnsObject DefaultInstanceForType
            {
                get
                {
                    return SnsObject.DefaultInstance;
                }
            }

            public uint DeleteFlag
            {
                get
                {
                    return this.result.DeleteFlag;
                }
                set
                {
                    this.SetDeleteFlag(value);
                }
            }

            public uint ExtFlag
            {
                get
                {
                    return this.result.ExtFlag;
                }
                set
                {
                    this.SetExtFlag(value);
                }
            }

            public int GroupListCount
            {
                get
                {
                    return this.result.GroupListCount;
                }
            }

            public IPopsicleList<SnsGroup> GroupListList
            {
                get
                {
                    return this.PrepareBuilder().groupList_;
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

            public ulong Id
            {
                get
                {
                    return this.result.Id;
                }
                set
                {
                    this.SetId(value);
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            public uint IsNotRichText
            {
                get
                {
                    return this.result.IsNotRichText;
                }
                set
                {
                    this.SetIsNotRichText(value);
                }
            }

            public uint LikeCount
            {
                get
                {
                    return this.result.LikeCount;
                }
                set
                {
                    this.SetLikeCount(value);
                }
            }

            public uint LikeFlag
            {
                get
                {
                    return this.result.LikeFlag;
                }
                set
                {
                    this.SetLikeFlag(value);
                }
            }

            public int LikeUserListCount
            {
                get
                {
                    return this.result.LikeUserListCount;
                }
            }

            public IPopsicleList<SnsCommentInfo> LikeUserListList
            {
                get
                {
                    return this.PrepareBuilder().likeUserList_;
                }
            }

            public uint LikeUserListNum
            {
                get
                {
                    return this.result.LikeUserListNum;
                }
                set
                {
                    this.SetLikeUserListNum(value);
                }
            }

            protected override SnsObject MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public string Nickname
            {
                get
                {
                    return this.result.Nickname;
                }
                set
                {
                    this.SetNickname(value);
                }
            }

            public uint NoChange
            {
                get
                {
                    return this.result.NoChange;
                }
                set
                {
                    this.SetNoChange(value);
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

            public string ReferUsername
            {
                get
                {
                    return this.result.ReferUsername;
                }
                set
                {
                    this.SetReferUsername(value);
                }
            }

            protected override SnsObject.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }

            public string Username
            {
                get
                {
                    return this.result.Username;
                }
                set
                {
                    this.SetUsername(value);
                }
            }

            public uint WithUserCount
            {
                get
                {
                    return this.result.WithUserCount;
                }
                set
                {
                    this.SetWithUserCount(value);
                }
            }

            public int WithUserListCount
            {
                get
                {
                    return this.result.WithUserListCount;
                }
            }

            public IPopsicleList<SnsCommentInfo> WithUserListList
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

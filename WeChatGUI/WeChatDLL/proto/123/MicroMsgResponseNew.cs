namespace micromsg
{
    using Google.ProtocolBuffers;

    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    using System.Runtime.CompilerServices;

    public sealed class MicroMsgResponseNew : GeneratedMessageLite<MicroMsgResponseNew, MicroMsgResponseNew.Builder>
    {
        private static readonly string[] _microMsgResponseNewFieldNames = new string[] { "ClientMsgId", "CreateTime", "MsgId", "NewMsgId", "Ret", "ServerTime", "ToUserName", "Type" };
        private static readonly uint[] _microMsgResponseNewFieldTags = new uint[] { 0x20, 40, 0x18, 0x40, 8, 0x30, 0x12, 0x38 };
        private uint clientMsgId_;
        public const int ClientMsgIdFieldNumber = 4;
        private uint createTime_;
        public const int CreateTimeFieldNumber = 5;
        private static readonly MicroMsgResponseNew defaultInstance = new MicroMsgResponseNew().MakeReadOnly();
        private bool hasClientMsgId;
        private bool hasCreateTime;
        private bool hasMsgId;
        private bool hasNewMsgId;
        private bool hasRet;
        private bool hasServerTime;
        private bool hasToUserName;
        private bool hasType;
        private int memoizedSerializedSize = -1;
        private uint msgId_;
        public const int MsgIdFieldNumber = 3;
        private ulong newMsgId_;
        public const int NewMsgIdFieldNumber = 8;
        private int ret_;
        public const int RetFieldNumber = 1;
        private uint serverTime_;
        public const int ServerTimeFieldNumber = 6;
        private SKBuiltinString_t toUserName_;
        public const int ToUserNameFieldNumber = 2;
        private uint type_;
        public const int TypeFieldNumber = 7;

        static MicroMsgResponseNew()
        {
            
        }

        private MicroMsgResponseNew()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(MicroMsgResponseNew prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            MicroMsgResponseNew new2 = obj as MicroMsgResponseNew;
            if (new2 == null)
            {
                return false;
            }
            if ((this.hasRet != new2.hasRet) || (this.hasRet && !this.ret_.Equals(new2.ret_)))
            {
                return false;
            }
            if ((this.hasToUserName != new2.hasToUserName) || (this.hasToUserName && !this.toUserName_.Equals(new2.toUserName_)))
            {
                return false;
            }
            if ((this.hasMsgId != new2.hasMsgId) || (this.hasMsgId && !this.msgId_.Equals(new2.msgId_)))
            {
                return false;
            }
            if ((this.hasClientMsgId != new2.hasClientMsgId) || (this.hasClientMsgId && !this.clientMsgId_.Equals(new2.clientMsgId_)))
            {
                return false;
            }
            if ((this.hasCreateTime != new2.hasCreateTime) || (this.hasCreateTime && !this.createTime_.Equals(new2.createTime_)))
            {
                return false;
            }
            if ((this.hasServerTime != new2.hasServerTime) || (this.hasServerTime && !this.serverTime_.Equals(new2.serverTime_)))
            {
                return false;
            }
            if ((this.hasType != new2.hasType) || (this.hasType && !this.type_.Equals(new2.type_)))
            {
                return false;
            }
            return ((this.hasNewMsgId == new2.hasNewMsgId) && (!this.hasNewMsgId || this.newMsgId_.Equals(new2.newMsgId_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasRet)
            {
                hashCode ^= this.ret_.GetHashCode();
            }
            if (this.hasToUserName)
            {
                hashCode ^= this.toUserName_.GetHashCode();
            }
            if (this.hasMsgId)
            {
                hashCode ^= this.msgId_.GetHashCode();
            }
            if (this.hasClientMsgId)
            {
                hashCode ^= this.clientMsgId_.GetHashCode();
            }
            if (this.hasCreateTime)
            {
                hashCode ^= this.createTime_.GetHashCode();
            }
            if (this.hasServerTime)
            {
                hashCode ^= this.serverTime_.GetHashCode();
            }
            if (this.hasType)
            {
                hashCode ^= this.type_.GetHashCode();
            }
            if (this.hasNewMsgId)
            {
                hashCode ^= this.newMsgId_.GetHashCode();
            }
            return hashCode;
        }

        private MicroMsgResponseNew MakeReadOnly()
        {
            return this;
        }

        public static MicroMsgResponseNew ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<MicroMsgResponseNew, Builder>.PrintField("Ret", this.hasRet, this.ret_, writer);
            GeneratedMessageLite<MicroMsgResponseNew, Builder>.PrintField("ToUserName", this.hasToUserName, this.toUserName_, writer);
            GeneratedMessageLite<MicroMsgResponseNew, Builder>.PrintField("MsgId", this.hasMsgId, this.msgId_, writer);
            GeneratedMessageLite<MicroMsgResponseNew, Builder>.PrintField("ClientMsgId", this.hasClientMsgId, this.clientMsgId_, writer);
            GeneratedMessageLite<MicroMsgResponseNew, Builder>.PrintField("CreateTime", this.hasCreateTime, this.createTime_, writer);
            GeneratedMessageLite<MicroMsgResponseNew, Builder>.PrintField("ServerTime", this.hasServerTime, this.serverTime_, writer);
            GeneratedMessageLite<MicroMsgResponseNew, Builder>.PrintField("Type", this.hasType, this.type_, writer);
            GeneratedMessageLite<MicroMsgResponseNew, Builder>.PrintField("NewMsgId", this.hasNewMsgId, this.newMsgId_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _microMsgResponseNewFieldNames;
            if (this.hasRet)
            {
                output.WriteInt32(1, strArray[4], this.Ret);
            }
            if (this.hasToUserName)
            {
                output.WriteMessage(2, strArray[6], this.ToUserName);
            }
            if (this.hasMsgId)
            {
                output.WriteUInt32(3, strArray[2], this.MsgId);
            }
            if (this.hasClientMsgId)
            {
                output.WriteUInt32(4, strArray[0], this.ClientMsgId);
            }
            if (this.hasCreateTime)
            {
                output.WriteUInt32(5, strArray[1], this.CreateTime);
            }
            if (this.hasServerTime)
            {
                output.WriteUInt32(6, strArray[5], this.ServerTime);
            }
            if (this.hasType)
            {
                output.WriteUInt32(7, strArray[7], this.Type);
            }
            if (this.hasNewMsgId)
            {
                output.WriteUInt64(8, strArray[3], this.NewMsgId);
            }
        }

        public uint ClientMsgId
        {
            get
            {
                return this.clientMsgId_;
            }
        }

        public uint CreateTime
        {
            get
            {
                return this.createTime_;
            }
        }

        public static MicroMsgResponseNew DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override MicroMsgResponseNew DefaultInstanceForType
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
                if (!this.hasRet)
                {
                    return false;
                }
                if (!this.hasToUserName)
                {
                    return false;
                }
                if (!this.hasMsgId)
                {
                    return false;
                }
                if (!this.hasClientMsgId)
                {
                    return false;
                }
                if (!this.hasCreateTime)
                {
                    return false;
                }
                if (!this.hasServerTime)
                {
                    return false;
                }
                if (!this.hasType)
                {
                    return false;
                }
                return true;
            }
        }

        public uint MsgId
        {
            get
            {
                return this.msgId_;
            }
        }

        public ulong NewMsgId
        {
            get
            {
                return this.newMsgId_;
            }
        }

        public int Ret
        {
            get
            {
                return this.ret_;
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
                    if (this.hasRet)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(1, this.Ret);
                    }
                    if (this.hasToUserName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(2, this.ToUserName);
                    }
                    if (this.hasMsgId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(3, this.MsgId);
                    }
                    if (this.hasClientMsgId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(4, this.ClientMsgId);
                    }
                    if (this.hasCreateTime)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(5, this.CreateTime);
                    }
                    if (this.hasServerTime)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(6, this.ServerTime);
                    }
                    if (this.hasType)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(7, this.Type);
                    }
                    if (this.hasNewMsgId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt64Size(8, this.NewMsgId);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        public uint ServerTime
        {
            get
            {
                return this.serverTime_;
            }
        }

        protected override MicroMsgResponseNew ThisMessage
        {
            get
            {
                return this;
            }
        }

        public SKBuiltinString_t ToUserName
        {
            get
            {
                return (this.toUserName_ ?? SKBuiltinString_t.DefaultInstance);
            }
        }

        public uint Type
        {
            get
            {
                return this.type_;
            }
        }

        [CompilerGenerated, DebuggerNonUserCode, GeneratedCode("ProtoGen", "2.3.0.277")]
        public sealed class Builder : GeneratedBuilderLite<MicroMsgResponseNew, MicroMsgResponseNew.Builder>
        {
            private MicroMsgResponseNew result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = MicroMsgResponseNew.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(MicroMsgResponseNew cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override MicroMsgResponseNew BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override MicroMsgResponseNew.Builder Clear()
            {
                this.result = MicroMsgResponseNew.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public MicroMsgResponseNew.Builder ClearClientMsgId()
            {
                this.PrepareBuilder();
                this.result.hasClientMsgId = false;
                this.result.clientMsgId_ = 0;
                return this;
            }

            public MicroMsgResponseNew.Builder ClearCreateTime()
            {
                this.PrepareBuilder();
                this.result.hasCreateTime = false;
                this.result.createTime_ = 0;
                return this;
            }

            public MicroMsgResponseNew.Builder ClearMsgId()
            {
                this.PrepareBuilder();
                this.result.hasMsgId = false;
                this.result.msgId_ = 0;
                return this;
            }

            public MicroMsgResponseNew.Builder ClearNewMsgId()
            {
                this.PrepareBuilder();
                this.result.hasNewMsgId = false;
                this.result.newMsgId_ = 0L;
                return this;
            }

            public MicroMsgResponseNew.Builder ClearRet()
            {
                this.PrepareBuilder();
                this.result.hasRet = false;
                this.result.ret_ = 0;
                return this;
            }

            public MicroMsgResponseNew.Builder ClearServerTime()
            {
                this.PrepareBuilder();
                this.result.hasServerTime = false;
                this.result.serverTime_ = 0;
                return this;
            }

            public MicroMsgResponseNew.Builder ClearToUserName()
            {
                this.PrepareBuilder();
                this.result.hasToUserName = false;
                this.result.toUserName_ = null;
                return this;
            }

            public MicroMsgResponseNew.Builder ClearType()
            {
                this.PrepareBuilder();
                this.result.hasType = false;
                this.result.type_ = 0;
                return this;
            }

            public override MicroMsgResponseNew.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new MicroMsgResponseNew.Builder(this.result);
                }
                return new MicroMsgResponseNew.Builder().MergeFrom(this.result);
            }

            public override MicroMsgResponseNew.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override MicroMsgResponseNew.Builder MergeFrom(IMessageLite other)
            {
                if (other is MicroMsgResponseNew)
                {
                    return this.MergeFrom((MicroMsgResponseNew) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override MicroMsgResponseNew.Builder MergeFrom(MicroMsgResponseNew other)
            {
                return this;
            }

            public override MicroMsgResponseNew.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(MicroMsgResponseNew._microMsgResponseNewFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = MicroMsgResponseNew._microMsgResponseNewFieldTags[index];
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
                            SKBuiltinString_t.Builder builder = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasToUserName)
                            {
                                builder.MergeFrom(this.ToUserName);
                            }
                            input.ReadMessage(builder, extensionRegistry);
                            this.ToUserName = builder.BuildPartial();
                            continue;
                        }
                        case 0x18:
                        {
                            this.result.hasMsgId = input.ReadUInt32(ref this.result.msgId_);
                            continue;
                        }
                        case 0:
                            throw InvalidProtocolBufferException.InvalidTag();

                        case 8:
                        {
                            this.result.hasRet = input.ReadInt32(ref this.result.ret_);
                            continue;
                        }
                        case 0x20:
                        {
                            this.result.hasClientMsgId = input.ReadUInt32(ref this.result.clientMsgId_);
                            continue;
                        }
                        case 40:
                        {
                            this.result.hasCreateTime = input.ReadUInt32(ref this.result.createTime_);
                            continue;
                        }
                        case 0x30:
                        {
                            this.result.hasServerTime = input.ReadUInt32(ref this.result.serverTime_);
                            continue;
                        }
                        case 0x38:
                        {
                            this.result.hasType = input.ReadUInt32(ref this.result.type_);
                            continue;
                        }
                        case 0x40:
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
                    this.result.hasNewMsgId = input.ReadUInt64(ref this.result.newMsgId_);
                }
                return this;
            }

            public MicroMsgResponseNew.Builder MergeToUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasToUserName && (this.result.toUserName_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.toUserName_ = SKBuiltinString_t.CreateBuilder(this.result.toUserName_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.toUserName_ = value;
                }
                this.result.hasToUserName = true;
                return this;
            }

            private MicroMsgResponseNew PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    MicroMsgResponseNew result = this.result;
                    this.result = new MicroMsgResponseNew();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public MicroMsgResponseNew.Builder SetClientMsgId(uint value)
            {
                this.PrepareBuilder();
                this.result.hasClientMsgId = true;
                this.result.clientMsgId_ = value;
                return this;
            }

            public MicroMsgResponseNew.Builder SetCreateTime(uint value)
            {
                this.PrepareBuilder();
                this.result.hasCreateTime = true;
                this.result.createTime_ = value;
                return this;
            }

            public MicroMsgResponseNew.Builder SetMsgId(uint value)
            {
                this.PrepareBuilder();
                this.result.hasMsgId = true;
                this.result.msgId_ = value;
                return this;
            }

            public MicroMsgResponseNew.Builder SetNewMsgId(ulong value)
            {
                this.PrepareBuilder();
                this.result.hasNewMsgId = true;
                this.result.newMsgId_ = value;
                return this;
            }

            public MicroMsgResponseNew.Builder SetRet(int value)
            {
                this.PrepareBuilder();
                this.result.hasRet = true;
                this.result.ret_ = value;
                return this;
            }

            public MicroMsgResponseNew.Builder SetServerTime(uint value)
            {
                this.PrepareBuilder();
                this.result.hasServerTime = true;
                this.result.serverTime_ = value;
                return this;
            }

            public MicroMsgResponseNew.Builder SetToUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasToUserName = true;
                this.result.toUserName_ = value;
                return this;
            }

            public MicroMsgResponseNew.Builder SetToUserName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasToUserName = true;
                this.result.toUserName_ = builderForValue.Build();
                return this;
            }

            public MicroMsgResponseNew.Builder SetType(uint value)
            {
                this.PrepareBuilder();
                this.result.hasType = true;
                this.result.type_ = value;
                return this;
            }

            public uint ClientMsgId
            {
                get
                {
                    return this.result.ClientMsgId;
                }
                set
                {
                    this.SetClientMsgId(value);
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

            public override MicroMsgResponseNew DefaultInstanceForType
            {
                get
                {
                    return MicroMsgResponseNew.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override MicroMsgResponseNew MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public uint MsgId
            {
                get
                {
                    return this.result.MsgId;
                }
                set
                {
                    this.SetMsgId(value);
                }
            }

            public ulong NewMsgId
            {
                get
                {
                    return this.result.NewMsgId;
                }
                set
                {
                    this.SetNewMsgId(value);
                }
            }

            public int Ret
            {
                get
                {
                    return this.result.Ret;
                }
                set
                {
                    this.SetRet(value);
                }
            }

            public uint ServerTime
            {
                get
                {
                    return this.result.ServerTime;
                }
                set
                {
                    this.SetServerTime(value);
                }
            }

            protected override MicroMsgResponseNew.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }

            public SKBuiltinString_t ToUserName
            {
                get
                {
                    return this.result.ToUserName;
                }
                set
                {
                    this.SetToUserName(value);
                }
            }

            public uint Type
            {
                get
                {
                    return this.result.Type;
                }
                set
                {
                    this.SetType(value);
                }
            }
        }
    }
}

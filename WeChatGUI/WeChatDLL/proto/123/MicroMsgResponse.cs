namespace micromsg
{
    using Google.ProtocolBuffers;
   
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

    
    public sealed class MicroMsgResponse : GeneratedMessageLite<MicroMsgResponse, MicroMsgResponse.Builder>
    {
        private static readonly string[] _microMsgResponseFieldNames = new string[] { "ClientMsgId", "CreateTime", "FromUserName", "MsgId", "Ret", "ToUserName", "Type" };
        private static readonly uint[] _microMsgResponseFieldTags = new uint[] { 0x2a, 0x30, 0x12, 0x20, 8, 0x1a, 0x38 };
        private string clientMsgId_ = "";
        public const int ClientMsgIdFieldNumber = 5;
        private uint createTime_;
        public const int CreateTimeFieldNumber = 6;
        private static readonly MicroMsgResponse defaultInstance = new MicroMsgResponse().MakeReadOnly();
        private SKBuiltinString_t fromUserName_;
        public const int FromUserNameFieldNumber = 2;
        private bool hasClientMsgId;
        private bool hasCreateTime;
        private bool hasFromUserName;
        private bool hasMsgId;
        private bool hasRet;
        private bool hasToUserName;
        private bool hasType;
        private int memoizedSerializedSize = -1;
        private uint msgId_;
        public const int MsgIdFieldNumber = 4;
        private int ret_;
        public const int RetFieldNumber = 1;
        private SKBuiltinString_t toUserName_;
        public const int ToUserNameFieldNumber = 3;
        private uint type_;
        public const int TypeFieldNumber = 7;

        static MicroMsgResponse()
        {
           // object.ReferenceEquals(MicroMsgResponse.Descriptor, null);
        }

        private MicroMsgResponse()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(MicroMsgResponse prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            MicroMsgResponse response = obj as MicroMsgResponse;
            if (response == null)
            {
                return false;
            }
            if ((this.hasRet != response.hasRet) || (this.hasRet && !this.ret_.Equals(response.ret_)))
            {
                return false;
            }
            if ((this.hasFromUserName != response.hasFromUserName) || (this.hasFromUserName && !this.fromUserName_.Equals(response.fromUserName_)))
            {
                return false;
            }
            if ((this.hasToUserName != response.hasToUserName) || (this.hasToUserName && !this.toUserName_.Equals(response.toUserName_)))
            {
                return false;
            }
            if ((this.hasMsgId != response.hasMsgId) || (this.hasMsgId && !this.msgId_.Equals(response.msgId_)))
            {
                return false;
            }
            if ((this.hasClientMsgId != response.hasClientMsgId) || (this.hasClientMsgId && !this.clientMsgId_.Equals(response.clientMsgId_)))
            {
                return false;
            }
            if ((this.hasCreateTime != response.hasCreateTime) || (this.hasCreateTime && !this.createTime_.Equals(response.createTime_)))
            {
                return false;
            }
            return ((this.hasType == response.hasType) && (!this.hasType || this.type_.Equals(response.type_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasRet)
            {
                hashCode ^= this.ret_.GetHashCode();
            }
            if (this.hasFromUserName)
            {
                hashCode ^= this.fromUserName_.GetHashCode();
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
            if (this.hasType)
            {
                hashCode ^= this.type_.GetHashCode();
            }
            return hashCode;
        }

        private MicroMsgResponse MakeReadOnly()
        {
            return this;
        }

        public static MicroMsgResponse ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<MicroMsgResponse, Builder>.PrintField("Ret", this.hasRet, this.ret_, writer);
            GeneratedMessageLite<MicroMsgResponse, Builder>.PrintField("FromUserName", this.hasFromUserName, this.fromUserName_, writer);
            GeneratedMessageLite<MicroMsgResponse, Builder>.PrintField("ToUserName", this.hasToUserName, this.toUserName_, writer);
            GeneratedMessageLite<MicroMsgResponse, Builder>.PrintField("MsgId", this.hasMsgId, this.msgId_, writer);
            GeneratedMessageLite<MicroMsgResponse, Builder>.PrintField("ClientMsgId", this.hasClientMsgId, this.clientMsgId_, writer);
            GeneratedMessageLite<MicroMsgResponse, Builder>.PrintField("CreateTime", this.hasCreateTime, this.createTime_, writer);
            GeneratedMessageLite<MicroMsgResponse, Builder>.PrintField("Type", this.hasType, this.type_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _microMsgResponseFieldNames;
            if (this.hasRet)
            {
                output.WriteInt32(1, strArray[4], this.Ret);
            }
            if (this.hasFromUserName)
            {
                output.WriteMessage(2, strArray[2], this.FromUserName);
            }
            if (this.hasToUserName)
            {
                output.WriteMessage(3, strArray[5], this.ToUserName);
            }
            if (this.hasMsgId)
            {
                output.WriteUInt32(4, strArray[3], this.MsgId);
            }
            if (this.hasClientMsgId)
            {
                output.WriteString(5, strArray[0], this.ClientMsgId);
            }
            if (this.hasCreateTime)
            {
                output.WriteUInt32(6, strArray[1], this.CreateTime);
            }
            if (this.hasType)
            {
                output.WriteUInt32(7, strArray[6], this.Type);
            }
        }

        public string ClientMsgId
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

        public static MicroMsgResponse DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override MicroMsgResponse DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public SKBuiltinString_t FromUserName
        {
            get
            {
                return (this.fromUserName_ ?? SKBuiltinString_t.DefaultInstance);
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
                if (!this.hasFromUserName)
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
                if (!this.hasCreateTime)
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
                    if (this.hasFromUserName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(2, this.FromUserName);
                    }
                    if (this.hasToUserName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(3, this.ToUserName);
                    }
                    if (this.hasMsgId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(4, this.MsgId);
                    }
                    if (this.hasClientMsgId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(5, this.ClientMsgId);
                    }
                    if (this.hasCreateTime)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(6, this.CreateTime);
                    }
                    if (this.hasType)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(7, this.Type);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override MicroMsgResponse ThisMessage
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

        
        public sealed class Builder : GeneratedBuilderLite<MicroMsgResponse, MicroMsgResponse.Builder>
        {
            private MicroMsgResponse result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = MicroMsgResponse.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(MicroMsgResponse cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override MicroMsgResponse BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override MicroMsgResponse.Builder Clear()
            {
                this.result = MicroMsgResponse.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public MicroMsgResponse.Builder ClearClientMsgId()
            {
                this.PrepareBuilder();
                this.result.hasClientMsgId = false;
                this.result.clientMsgId_ = "";
                return this;
            }

            public MicroMsgResponse.Builder ClearCreateTime()
            {
                this.PrepareBuilder();
                this.result.hasCreateTime = false;
                this.result.createTime_ = 0;
                return this;
            }

            public MicroMsgResponse.Builder ClearFromUserName()
            {
                this.PrepareBuilder();
                this.result.hasFromUserName = false;
                this.result.fromUserName_ = null;
                return this;
            }

            public MicroMsgResponse.Builder ClearMsgId()
            {
                this.PrepareBuilder();
                this.result.hasMsgId = false;
                this.result.msgId_ = 0;
                return this;
            }

            public MicroMsgResponse.Builder ClearRet()
            {
                this.PrepareBuilder();
                this.result.hasRet = false;
                this.result.ret_ = 0;
                return this;
            }

            public MicroMsgResponse.Builder ClearToUserName()
            {
                this.PrepareBuilder();
                this.result.hasToUserName = false;
                this.result.toUserName_ = null;
                return this;
            }

            public MicroMsgResponse.Builder ClearType()
            {
                this.PrepareBuilder();
                this.result.hasType = false;
                this.result.type_ = 0;
                return this;
            }

            public override MicroMsgResponse.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new MicroMsgResponse.Builder(this.result);
                }
                return new MicroMsgResponse.Builder().MergeFrom(this.result);
            }

            public override MicroMsgResponse.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override MicroMsgResponse.Builder MergeFrom(IMessageLite other)
            {
                if (other is MicroMsgResponse)
                {
                    return this.MergeFrom((MicroMsgResponse) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override MicroMsgResponse.Builder MergeFrom(MicroMsgResponse other)
            {
                return this;
            }

            public override MicroMsgResponse.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(MicroMsgResponse._microMsgResponseFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = MicroMsgResponse._microMsgResponseFieldTags[index];
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
                            if (this.result.hasFromUserName)
                            {
                                builder.MergeFrom(this.FromUserName);
                            }
                            input.ReadMessage(builder, extensionRegistry);
                            this.FromUserName = builder.BuildPartial();
                            continue;
                        }
                        case 0x1a:
                        {
                            SKBuiltinString_t.Builder builder2 = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasToUserName)
                            {
                                builder2.MergeFrom(this.ToUserName);
                            }
                            input.ReadMessage(builder2, extensionRegistry);
                            this.ToUserName = builder2.BuildPartial();
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
                            this.result.hasMsgId = input.ReadUInt32(ref this.result.msgId_);
                            continue;
                        }
                        case 0x2a:
                        {
                            this.result.hasClientMsgId = input.ReadString(ref this.result.clientMsgId_);
                            continue;
                        }
                        case 0x30:
                        {
                            this.result.hasCreateTime = input.ReadUInt32(ref this.result.createTime_);
                            continue;
                        }
                        case 0x38:
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
                    this.result.hasType = input.ReadUInt32(ref this.result.type_);
                }
                return this;
            }

            public MicroMsgResponse.Builder MergeFromUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasFromUserName && (this.result.fromUserName_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.fromUserName_ = SKBuiltinString_t.CreateBuilder(this.result.fromUserName_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.fromUserName_ = value;
                }
                this.result.hasFromUserName = true;
                return this;
            }

            public MicroMsgResponse.Builder MergeToUserName(SKBuiltinString_t value)
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

            private MicroMsgResponse PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    MicroMsgResponse result = this.result;
                    this.result = new MicroMsgResponse();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public MicroMsgResponse.Builder SetClientMsgId(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasClientMsgId = true;
                this.result.clientMsgId_ = value;
                return this;
            }

            public MicroMsgResponse.Builder SetCreateTime(uint value)
            {
                this.PrepareBuilder();
                this.result.hasCreateTime = true;
                this.result.createTime_ = value;
                return this;
            }

            public MicroMsgResponse.Builder SetFromUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasFromUserName = true;
                this.result.fromUserName_ = value;
                return this;
            }

            public MicroMsgResponse.Builder SetFromUserName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasFromUserName = true;
                this.result.fromUserName_ = builderForValue.Build();
                return this;
            }

            public MicroMsgResponse.Builder SetMsgId(uint value)
            {
                this.PrepareBuilder();
                this.result.hasMsgId = true;
                this.result.msgId_ = value;
                return this;
            }

            public MicroMsgResponse.Builder SetRet(int value)
            {
                this.PrepareBuilder();
                this.result.hasRet = true;
                this.result.ret_ = value;
                return this;
            }

            public MicroMsgResponse.Builder SetToUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasToUserName = true;
                this.result.toUserName_ = value;
                return this;
            }

            public MicroMsgResponse.Builder SetToUserName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasToUserName = true;
                this.result.toUserName_ = builderForValue.Build();
                return this;
            }

            public MicroMsgResponse.Builder SetType(uint value)
            {
                this.PrepareBuilder();
                this.result.hasType = true;
                this.result.type_ = value;
                return this;
            }

            public string ClientMsgId
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

            public override MicroMsgResponse DefaultInstanceForType
            {
                get
                {
                    return MicroMsgResponse.DefaultInstance;
                }
            }

            public SKBuiltinString_t FromUserName
            {
                get
                {
                    return this.result.FromUserName;
                }
                set
                {
                    this.SetFromUserName(value);
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override MicroMsgResponse MessageBeingBuilt
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

            protected override MicroMsgResponse.Builder ThisBuilder
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


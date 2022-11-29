namespace micromsg
{
    using Google.ProtocolBuffers;
 
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    using System.Runtime.CompilerServices;

    public sealed class NewSyncResponse : GeneratedMessageLite<NewSyncResponse, NewSyncResponse.Builder>
    {
        private static readonly string[] _newSyncResponseFieldNames = new string[] { "CmdList", "ContinueFlag", "KeyBuf", "OnlineVersion", "Ret", "Status" };
        private static readonly uint[] _newSyncResponseFieldTags = new uint[] { 0x12, 0x18, 0x22, 0x30, 8, 40 };
        private CmdList cmdList_;
        public const int CmdListFieldNumber = 2;
        private uint continueFlag_;
        public const int ContinueFlagFieldNumber = 3;
        private static readonly NewSyncResponse defaultInstance = new NewSyncResponse().MakeReadOnly();
        private bool hasCmdList;
        private bool hasContinueFlag;
        private bool hasKeyBuf;
        private bool hasOnlineVersion;
        private bool hasRet;
        private bool hasStatus;
        private SKBuiltinBuffer_t keyBuf_;
        public const int KeyBufFieldNumber = 4;
        private int memoizedSerializedSize = -1;
        private uint onlineVersion_;
        public const int OnlineVersionFieldNumber = 6;
        private int ret_;
        public const int RetFieldNumber = 1;
        private uint status_;
        public const int StatusFieldNumber = 5;

        static NewSyncResponse()
        {

        }

        private NewSyncResponse()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(NewSyncResponse prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            NewSyncResponse response = obj as NewSyncResponse;
            if (response == null)
            {
                return false;
            }
            if ((this.hasRet != response.hasRet) || (this.hasRet && !this.ret_.Equals(response.ret_)))
            {
                return false;
            }
            if ((this.hasCmdList != response.hasCmdList) || (this.hasCmdList && !this.cmdList_.Equals(response.cmdList_)))
            {
                return false;
            }
            if ((this.hasContinueFlag != response.hasContinueFlag) || (this.hasContinueFlag && !this.continueFlag_.Equals(response.continueFlag_)))
            {
                return false;
            }
            if ((this.hasKeyBuf != response.hasKeyBuf) || (this.hasKeyBuf && !this.keyBuf_.Equals(response.keyBuf_)))
            {
                return false;
            }
            if ((this.hasStatus != response.hasStatus) || (this.hasStatus && !this.status_.Equals(response.status_)))
            {
                return false;
            }
            return ((this.hasOnlineVersion == response.hasOnlineVersion) && (!this.hasOnlineVersion || this.onlineVersion_.Equals(response.onlineVersion_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasRet)
            {
                hashCode ^= this.ret_.GetHashCode();
            }
            if (this.hasCmdList)
            {
                hashCode ^= this.cmdList_.GetHashCode();
            }
            if (this.hasContinueFlag)
            {
                hashCode ^= this.continueFlag_.GetHashCode();
            }
            if (this.hasKeyBuf)
            {
                hashCode ^= this.keyBuf_.GetHashCode();
            }
            if (this.hasStatus)
            {
                hashCode ^= this.status_.GetHashCode();
            }
            if (this.hasOnlineVersion)
            {
                hashCode ^= this.onlineVersion_.GetHashCode();
            }
            return hashCode;
        }

        private NewSyncResponse MakeReadOnly()
        {
            return this;
        }

        public static NewSyncResponse ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<NewSyncResponse, Builder>.PrintField("Ret", this.hasRet, this.ret_, writer);
            GeneratedMessageLite<NewSyncResponse, Builder>.PrintField("CmdList", this.hasCmdList, this.cmdList_, writer);
            GeneratedMessageLite<NewSyncResponse, Builder>.PrintField("ContinueFlag", this.hasContinueFlag, this.continueFlag_, writer);
            GeneratedMessageLite<NewSyncResponse, Builder>.PrintField("KeyBuf", this.hasKeyBuf, this.keyBuf_, writer);
            GeneratedMessageLite<NewSyncResponse, Builder>.PrintField("Status", this.hasStatus, this.status_, writer);
            GeneratedMessageLite<NewSyncResponse, Builder>.PrintField("OnlineVersion", this.hasOnlineVersion, this.onlineVersion_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _newSyncResponseFieldNames;
            if (this.hasRet)
            {
                output.WriteInt32(1, strArray[4], this.Ret);
            }
            if (this.hasCmdList)
            {
                output.WriteMessage(2, strArray[0], this.CmdList);
            }
            if (this.hasContinueFlag)
            {
                output.WriteUInt32(3, strArray[1], this.ContinueFlag);
            }
            if (this.hasKeyBuf)
            {
                output.WriteMessage(4, strArray[2], this.KeyBuf);
            }
            if (this.hasStatus)
            {
                output.WriteUInt32(5, strArray[5], this.Status);
            }
            if (this.hasOnlineVersion)
            {
                output.WriteUInt32(6, strArray[3], this.OnlineVersion);
            }
        }

        public CmdList CmdList
        {
            get
            {
                return (this.cmdList_ ?? CmdList.DefaultInstance);
            }
        }

        public uint ContinueFlag
        {
            get
            {
                return this.continueFlag_;
            }
        }

        public static NewSyncResponse DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override NewSyncResponse DefaultInstanceForType
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
                if (!this.hasCmdList)
                {
                    return false;
                }
                if (!this.hasContinueFlag)
                {
                    return false;
                }
                if (!this.hasKeyBuf)
                {
                    return false;
                }
                if (!this.CmdList.IsInitialized)
                {
                    return false;
                }
                if (!this.KeyBuf.IsInitialized)
                {
                    return false;
                }
                return true;
            }
        }

        public SKBuiltinBuffer_t KeyBuf
        {
            get
            {
                return (this.keyBuf_ ?? SKBuiltinBuffer_t.DefaultInstance);
            }
        }

        public uint OnlineVersion
        {
            get
            {
                return this.onlineVersion_;
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
                    if (this.hasCmdList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(2, this.CmdList);
                    }
                    if (this.hasContinueFlag)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(3, this.ContinueFlag);
                    }
                    if (this.hasKeyBuf)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(4, this.KeyBuf);
                    }
                    if (this.hasStatus)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(5, this.Status);
                    }
                    if (this.hasOnlineVersion)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(6, this.OnlineVersion);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        public uint Status
        {
            get
            {
                return this.status_;
            }
        }

        protected override NewSyncResponse ThisMessage
        {
            get
            {
                return this;
            }
        }

        [CompilerGenerated, GeneratedCode("ProtoGen", "2.3.0.277"), DebuggerNonUserCode]
        public sealed class Builder : GeneratedBuilderLite<NewSyncResponse, NewSyncResponse.Builder>
        {
            private NewSyncResponse result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = NewSyncResponse.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(NewSyncResponse cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override NewSyncResponse BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override NewSyncResponse.Builder Clear()
            {
                this.result = NewSyncResponse.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public NewSyncResponse.Builder ClearCmdList()
            {
                this.PrepareBuilder();
                this.result.hasCmdList = false;
                this.result.cmdList_ = null;
                return this;
            }

            public NewSyncResponse.Builder ClearContinueFlag()
            {
                this.PrepareBuilder();
                this.result.hasContinueFlag = false;
                this.result.continueFlag_ = 0;
                return this;
            }

            public NewSyncResponse.Builder ClearKeyBuf()
            {
                this.PrepareBuilder();
                this.result.hasKeyBuf = false;
                this.result.keyBuf_ = null;
                return this;
            }

            public NewSyncResponse.Builder ClearOnlineVersion()
            {
                this.PrepareBuilder();
                this.result.hasOnlineVersion = false;
                this.result.onlineVersion_ = 0;
                return this;
            }

            public NewSyncResponse.Builder ClearRet()
            {
                this.PrepareBuilder();
                this.result.hasRet = false;
                this.result.ret_ = 0;
                return this;
            }

            public NewSyncResponse.Builder ClearStatus()
            {
                this.PrepareBuilder();
                this.result.hasStatus = false;
                this.result.status_ = 0;
                return this;
            }

            public override NewSyncResponse.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new NewSyncResponse.Builder(this.result);
                }
                return new NewSyncResponse.Builder().MergeFrom(this.result);
            }

            public NewSyncResponse.Builder MergeCmdList(CmdList value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasCmdList && (this.result.cmdList_ != CmdList.DefaultInstance))
                {
                    this.result.cmdList_ = CmdList.CreateBuilder(this.result.cmdList_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.cmdList_ = value;
                }
                this.result.hasCmdList = true;
                return this;
            }

            public override NewSyncResponse.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override NewSyncResponse.Builder MergeFrom(IMessageLite other)
            {
                if (other is NewSyncResponse)
                {
                    return this.MergeFrom((NewSyncResponse) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override NewSyncResponse.Builder MergeFrom(NewSyncResponse other)
            {
                return this;
            }

            public override NewSyncResponse.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(NewSyncResponse._newSyncResponseFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = NewSyncResponse._newSyncResponseFieldTags[index];
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
                            this.result.hasRet = input.ReadInt32(ref this.result.ret_);
                            continue;
                        }
                        case 0x12:
                        {
                            CmdList.Builder builder = CmdList.CreateBuilder();
                            if (this.result.hasCmdList)
                            {
                                builder.MergeFrom(this.CmdList);
                            }
                            input.ReadMessage(builder, extensionRegistry);
                            this.CmdList = builder.BuildPartial();
                            continue;
                        }
                        case 0x18:
                        {
                            this.result.hasContinueFlag = input.ReadUInt32(ref this.result.continueFlag_);
                            continue;
                        }
                        case 0x22:
                        {
                            SKBuiltinBuffer_t.Builder builder2 = SKBuiltinBuffer_t.CreateBuilder();
                            if (this.result.hasKeyBuf)
                            {
                                builder2.MergeFrom(this.KeyBuf);
                            }
                            input.ReadMessage(builder2, extensionRegistry);
                            this.KeyBuf = builder2.BuildPartial();
                            continue;
                        }
                        case 40:
                        {
                            this.result.hasStatus = input.ReadUInt32(ref this.result.status_);
                            continue;
                        }
                        case 0x30:
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
                    this.result.hasOnlineVersion = input.ReadUInt32(ref this.result.onlineVersion_);
                }
                return this;
            }

            public NewSyncResponse.Builder MergeKeyBuf(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasKeyBuf && (this.result.keyBuf_ != SKBuiltinBuffer_t.DefaultInstance))
                {
                    this.result.keyBuf_ = SKBuiltinBuffer_t.CreateBuilder(this.result.keyBuf_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.keyBuf_ = value;
                }
                this.result.hasKeyBuf = true;
                return this;
            }

            private NewSyncResponse PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    NewSyncResponse result = this.result;
                    this.result = new NewSyncResponse();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public NewSyncResponse.Builder SetCmdList(CmdList value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasCmdList = true;
                this.result.cmdList_ = value;
                return this;
            }

            public NewSyncResponse.Builder SetCmdList(CmdList.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasCmdList = true;
                this.result.cmdList_ = builderForValue.Build();
                return this;
            }

            public NewSyncResponse.Builder SetContinueFlag(uint value)
            {
                this.PrepareBuilder();
                this.result.hasContinueFlag = true;
                this.result.continueFlag_ = value;
                return this;
            }

            public NewSyncResponse.Builder SetKeyBuf(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasKeyBuf = true;
                this.result.keyBuf_ = value;
                return this;
            }

            public NewSyncResponse.Builder SetKeyBuf(SKBuiltinBuffer_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasKeyBuf = true;
                this.result.keyBuf_ = builderForValue.Build();
                return this;
            }

            public NewSyncResponse.Builder SetOnlineVersion(uint value)
            {
                this.PrepareBuilder();
                this.result.hasOnlineVersion = true;
                this.result.onlineVersion_ = value;
                return this;
            }

            public NewSyncResponse.Builder SetRet(int value)
            {
                this.PrepareBuilder();
                this.result.hasRet = true;
                this.result.ret_ = value;
                return this;
            }

            public NewSyncResponse.Builder SetStatus(uint value)
            {
                this.PrepareBuilder();
                this.result.hasStatus = true;
                this.result.status_ = value;
                return this;
            }

            public CmdList CmdList
            {
                get
                {
                    return this.result.CmdList;
                }
                set
                {
                    this.SetCmdList(value);
                }
            }

            public uint ContinueFlag
            {
                get
                {
                    return this.result.ContinueFlag;
                }
                set
                {
                    this.SetContinueFlag(value);
                }
            }

            public override NewSyncResponse DefaultInstanceForType
            {
                get
                {
                    return NewSyncResponse.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            public SKBuiltinBuffer_t KeyBuf
            {
                get
                {
                    return this.result.KeyBuf;
                }
                set
                {
                    this.SetKeyBuf(value);
                }
            }

            protected override NewSyncResponse MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public uint OnlineVersion
            {
                get
                {
                    return this.result.OnlineVersion;
                }
                set
                {
                    this.SetOnlineVersion(value);
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

            public uint Status
            {
                get
                {
                    return this.result.Status;
                }
                set
                {
                    this.SetStatus(value);
                }
            }

            protected override NewSyncResponse.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}

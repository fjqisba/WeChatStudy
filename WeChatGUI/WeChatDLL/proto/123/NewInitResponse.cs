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
    public sealed class NewInitResponse : GeneratedMessageLite<NewInitResponse, NewInitResponse.Builder>
    {
        private static readonly string[] _newInitResponseFieldNames = new string[] { "BaseResponse", "CmdCount", "CmdList", "ContinueFlag", "CurrentSynckey", "MaxSynckey", "Ratio", "SelectBitmap" };
        private static readonly uint[] _newInitResponseFieldTags = new uint[] { 10, 0x30, 0x3a, 0x20, 0x12, 0x1a, 0x40, 40 };
        private micromsg.BaseResponse baseResponse_;
        public const int BaseResponseFieldNumber = 1;
        private uint cmdCount_;
        public const int CmdCountFieldNumber = 6;
        private PopsicleList<CmdItem> cmdList_ = new PopsicleList<CmdItem>();
        public const int CmdListFieldNumber = 7;
        private uint continueFlag_;
        public const int ContinueFlagFieldNumber = 4;
        private SKBuiltinBuffer_t currentSynckey_;
        public const int CurrentSynckeyFieldNumber = 2;
        private static readonly NewInitResponse defaultInstance = new NewInitResponse().MakeReadOnly();
        private bool hasBaseResponse;
        private bool hasCmdCount;
        private bool hasContinueFlag;
        private bool hasCurrentSynckey;
        private bool hasMaxSynckey;
        private bool hasRatio;
        private bool hasSelectBitmap;
        private SKBuiltinBuffer_t maxSynckey_;
        public const int MaxSynckeyFieldNumber = 3;
        private int memoizedSerializedSize = -1;
        private uint ratio_;
        public const int RatioFieldNumber = 8;
        private uint selectBitmap_;
        public const int SelectBitmapFieldNumber = 5;

        static NewInitResponse()
        {
           // object.ReferenceEquals(NewInitResponse.Descriptor, null);
        }

        private NewInitResponse()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(NewInitResponse prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            NewInitResponse response = obj as NewInitResponse;
            if (response == null)
            {
                return false;
            }
            if ((this.hasBaseResponse != response.hasBaseResponse) || (this.hasBaseResponse && !this.baseResponse_.Equals(response.baseResponse_)))
            {
                return false;
            }
            if ((this.hasCurrentSynckey != response.hasCurrentSynckey) || (this.hasCurrentSynckey && !this.currentSynckey_.Equals(response.currentSynckey_)))
            {
                return false;
            }
            if ((this.hasMaxSynckey != response.hasMaxSynckey) || (this.hasMaxSynckey && !this.maxSynckey_.Equals(response.maxSynckey_)))
            {
                return false;
            }
            if ((this.hasContinueFlag != response.hasContinueFlag) || (this.hasContinueFlag && !this.continueFlag_.Equals(response.continueFlag_)))
            {
                return false;
            }
            if ((this.hasSelectBitmap != response.hasSelectBitmap) || (this.hasSelectBitmap && !this.selectBitmap_.Equals(response.selectBitmap_)))
            {
                return false;
            }
            if ((this.hasCmdCount != response.hasCmdCount) || (this.hasCmdCount && !this.cmdCount_.Equals(response.cmdCount_)))
            {
                return false;
            }
            if (this.cmdList_.Count != response.cmdList_.Count)
            {
                return false;
            }
            for (int i = 0; i < this.cmdList_.Count; i++)
            {
                if (!this.cmdList_[i].Equals(response.cmdList_[i]))
                {
                    return false;
                }
            }
            return ((this.hasRatio == response.hasRatio) && (!this.hasRatio || this.ratio_.Equals(response.ratio_)));
        }

        public CmdItem GetCmdList(int index)
        {
            return this.cmdList_[index];
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasBaseResponse)
            {
                hashCode ^= this.baseResponse_.GetHashCode();
            }
            if (this.hasCurrentSynckey)
            {
                hashCode ^= this.currentSynckey_.GetHashCode();
            }
            if (this.hasMaxSynckey)
            {
                hashCode ^= this.maxSynckey_.GetHashCode();
            }
            if (this.hasContinueFlag)
            {
                hashCode ^= this.continueFlag_.GetHashCode();
            }
            if (this.hasSelectBitmap)
            {
                hashCode ^= this.selectBitmap_.GetHashCode();
            }
            if (this.hasCmdCount)
            {
                hashCode ^= this.cmdCount_.GetHashCode();
            }
            foreach (CmdItem item in this.cmdList_)
            {
                hashCode ^= item.GetHashCode();
            }
            if (this.hasRatio)
            {
                hashCode ^= this.ratio_.GetHashCode();
            }
            return hashCode;
        }

        private NewInitResponse MakeReadOnly()
        {
            this.cmdList_.MakeReadOnly();
            return this;
        }

        public static NewInitResponse ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<NewInitResponse, Builder>.PrintField("BaseResponse", this.hasBaseResponse, this.baseResponse_, writer);
            GeneratedMessageLite<NewInitResponse, Builder>.PrintField("CurrentSynckey", this.hasCurrentSynckey, this.currentSynckey_, writer);
            GeneratedMessageLite<NewInitResponse, Builder>.PrintField("MaxSynckey", this.hasMaxSynckey, this.maxSynckey_, writer);
            GeneratedMessageLite<NewInitResponse, Builder>.PrintField("ContinueFlag", this.hasContinueFlag, this.continueFlag_, writer);
            GeneratedMessageLite<NewInitResponse, Builder>.PrintField("SelectBitmap", this.hasSelectBitmap, this.selectBitmap_, writer);
            GeneratedMessageLite<NewInitResponse, Builder>.PrintField("CmdCount", this.hasCmdCount, this.cmdCount_, writer);
            GeneratedMessageLite<NewInitResponse, Builder>.PrintField<CmdItem>("CmdList", this.cmdList_, writer);
            GeneratedMessageLite<NewInitResponse, Builder>.PrintField("Ratio", this.hasRatio, this.ratio_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _newInitResponseFieldNames;
            if (this.hasBaseResponse)
            {
                output.WriteMessage(1, strArray[0], this.BaseResponse);
            }
            if (this.hasCurrentSynckey)
            {
                output.WriteMessage(2, strArray[4], this.CurrentSynckey);
            }
            if (this.hasMaxSynckey)
            {
                output.WriteMessage(3, strArray[5], this.MaxSynckey);
            }
            if (this.hasContinueFlag)
            {
                output.WriteUInt32(4, strArray[3], this.ContinueFlag);
            }
            if (this.hasSelectBitmap)
            {
                output.WriteUInt32(5, strArray[7], this.SelectBitmap);
            }
            if (this.hasCmdCount)
            {
                output.WriteUInt32(6, strArray[1], this.CmdCount);
            }
            if (this.cmdList_.Count > 0)
            {
                output.WriteMessageArray<CmdItem>(7, strArray[2], this.cmdList_);
            }
            if (this.hasRatio)
            {
                output.WriteUInt32(8, strArray[6], this.Ratio);
            }
        }

        public micromsg.BaseResponse BaseResponse
        {
            get
            {
                return (this.baseResponse_ ?? micromsg.BaseResponse.DefaultInstance);
            }
        }

        public uint CmdCount
        {
            get
            {
                return this.cmdCount_;
            }
        }

        public int CmdListCount
        {
            get
            {
                return this.cmdList_.Count;
            }
        }

        public IList<CmdItem> CmdListList
        {
            get
            {
                return this.cmdList_;
            }
        }

        public uint ContinueFlag
        {
            get
            {
                return this.continueFlag_;
            }
        }

        public SKBuiltinBuffer_t CurrentSynckey
        {
            get
            {
                return (this.currentSynckey_ ?? SKBuiltinBuffer_t.DefaultInstance);
            }
        }

        public static NewInitResponse DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override NewInitResponse DefaultInstanceForType
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
                if (!this.hasCurrentSynckey)
                {
                    return false;
                }
                if (!this.hasMaxSynckey)
                {
                    return false;
                }
                if (!this.hasContinueFlag)
                {
                    return false;
                }
                if (!this.hasSelectBitmap)
                {
                    return false;
                }
                if (!this.hasCmdCount)
                {
                    return false;
                }
                if (!this.hasRatio)
                {
                    return false;
                }
                if (!this.BaseResponse.IsInitialized)
                {
                    return false;
                }
                if (!this.CurrentSynckey.IsInitialized)
                {
                    return false;
                }
                if (!this.MaxSynckey.IsInitialized)
                {
                    return false;
                }
                foreach (CmdItem item in this.CmdListList)
                {
                    if (!item.IsInitialized)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public SKBuiltinBuffer_t MaxSynckey
        {
            get
            {
                return (this.maxSynckey_ ?? SKBuiltinBuffer_t.DefaultInstance);
            }
        }

        public uint Ratio
        {
            get
            {
                return this.ratio_;
            }
        }

        public uint SelectBitmap
        {
            get
            {
                return this.selectBitmap_;
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
                    if (this.hasCurrentSynckey)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(2, this.CurrentSynckey);
                    }
                    if (this.hasMaxSynckey)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(3, this.MaxSynckey);
                    }
                    if (this.hasContinueFlag)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(4, this.ContinueFlag);
                    }
                    if (this.hasSelectBitmap)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(5, this.SelectBitmap);
                    }
                    if (this.hasCmdCount)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(6, this.CmdCount);
                    }
                    foreach (CmdItem item in this.CmdListList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(7, item);
                    }
                    if (this.hasRatio)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(8, this.Ratio);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override NewInitResponse ThisMessage
        {
            get
            {
                return this;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<NewInitResponse, NewInitResponse.Builder>
        {
            private NewInitResponse result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = NewInitResponse.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(NewInitResponse cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public NewInitResponse.Builder AddCmdList(CmdItem value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.cmdList_.Add(value);
                return this;
            }

            public NewInitResponse.Builder AddCmdList(CmdItem.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.cmdList_.Add(builderForValue.Build());
                return this;
            }

            public NewInitResponse.Builder AddRangeCmdList(IEnumerable<CmdItem> values)
            {
                this.PrepareBuilder();
                this.result.cmdList_.Add(values);
                return this;
            }

            public override NewInitResponse BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override NewInitResponse.Builder Clear()
            {
                this.result = NewInitResponse.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public NewInitResponse.Builder ClearBaseResponse()
            {
                this.PrepareBuilder();
                this.result.hasBaseResponse = false;
                this.result.baseResponse_ = null;
                return this;
            }

            public NewInitResponse.Builder ClearCmdCount()
            {
                this.PrepareBuilder();
                this.result.hasCmdCount = false;
                this.result.cmdCount_ = 0;
                return this;
            }

            public NewInitResponse.Builder ClearCmdList()
            {
                this.PrepareBuilder();
                this.result.cmdList_.Clear();
                return this;
            }

            public NewInitResponse.Builder ClearContinueFlag()
            {
                this.PrepareBuilder();
                this.result.hasContinueFlag = false;
                this.result.continueFlag_ = 0;
                return this;
            }

            public NewInitResponse.Builder ClearCurrentSynckey()
            {
                this.PrepareBuilder();
                this.result.hasCurrentSynckey = false;
                this.result.currentSynckey_ = null;
                return this;
            }

            public NewInitResponse.Builder ClearMaxSynckey()
            {
                this.PrepareBuilder();
                this.result.hasMaxSynckey = false;
                this.result.maxSynckey_ = null;
                return this;
            }

            public NewInitResponse.Builder ClearRatio()
            {
                this.PrepareBuilder();
                this.result.hasRatio = false;
                this.result.ratio_ = 0;
                return this;
            }

            public NewInitResponse.Builder ClearSelectBitmap()
            {
                this.PrepareBuilder();
                this.result.hasSelectBitmap = false;
                this.result.selectBitmap_ = 0;
                return this;
            }

            public override NewInitResponse.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new NewInitResponse.Builder(this.result);
                }
                return new NewInitResponse.Builder().MergeFrom(this.result);
            }

            public CmdItem GetCmdList(int index)
            {
                return this.result.GetCmdList(index);
            }

            public NewInitResponse.Builder MergeBaseResponse(micromsg.BaseResponse value)
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

            public NewInitResponse.Builder MergeCurrentSynckey(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasCurrentSynckey && (this.result.currentSynckey_ != SKBuiltinBuffer_t.DefaultInstance))
                {
                    this.result.currentSynckey_ = SKBuiltinBuffer_t.CreateBuilder(this.result.currentSynckey_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.currentSynckey_ = value;
                }
                this.result.hasCurrentSynckey = true;
                return this;
            }

            public override NewInitResponse.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override NewInitResponse.Builder MergeFrom(IMessageLite other)
            {
                if (other is NewInitResponse)
                {
                    return this.MergeFrom((NewInitResponse) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override NewInitResponse.Builder MergeFrom(NewInitResponse other)
            {
                return this;
            }

            public override NewInitResponse.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(NewInitResponse._newInitResponseFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = NewInitResponse._newInitResponseFieldTags[index];
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
                            if (this.result.hasCurrentSynckey)
                            {
                                builder2.MergeFrom(this.CurrentSynckey);
                            }
                            input.ReadMessage(builder2, extensionRegistry);
                            this.CurrentSynckey = builder2.BuildPartial();
                            continue;
                        }
                        case 0x1a:
                        {
                            SKBuiltinBuffer_t.Builder builder3 = SKBuiltinBuffer_t.CreateBuilder();
                            if (this.result.hasMaxSynckey)
                            {
                                builder3.MergeFrom(this.MaxSynckey);
                            }
                            input.ReadMessage(builder3, extensionRegistry);
                            this.MaxSynckey = builder3.BuildPartial();
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
                        case 0x20:
                        {
                            this.result.hasContinueFlag = input.ReadUInt32(ref this.result.continueFlag_);
                            continue;
                        }
                        case 40:
                        {
                            this.result.hasSelectBitmap = input.ReadUInt32(ref this.result.selectBitmap_);
                            continue;
                        }
                        case 0x30:
                        {
                            this.result.hasCmdCount = input.ReadUInt32(ref this.result.cmdCount_);
                            continue;
                        }
                        case 0x3a:
                        {
                            input.ReadMessageArray<CmdItem>(num, str, this.result.cmdList_, CmdItem.DefaultInstance, extensionRegistry);
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
                    this.result.hasRatio = input.ReadUInt32(ref this.result.ratio_);
                }
                return this;
            }

            public NewInitResponse.Builder MergeMaxSynckey(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasMaxSynckey && (this.result.maxSynckey_ != SKBuiltinBuffer_t.DefaultInstance))
                {
                    this.result.maxSynckey_ = SKBuiltinBuffer_t.CreateBuilder(this.result.maxSynckey_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.maxSynckey_ = value;
                }
                this.result.hasMaxSynckey = true;
                return this;
            }

            private NewInitResponse PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    NewInitResponse result = this.result;
                    this.result = new NewInitResponse();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public NewInitResponse.Builder SetBaseResponse(micromsg.BaseResponse value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = value;
                return this;
            }

            public NewInitResponse.Builder SetBaseResponse(micromsg.BaseResponse.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = builderForValue.Build();
                return this;
            }

            public NewInitResponse.Builder SetCmdCount(uint value)
            {
                this.PrepareBuilder();
                this.result.hasCmdCount = true;
                this.result.cmdCount_ = value;
                return this;
            }

            public NewInitResponse.Builder SetCmdList(int index, CmdItem value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.cmdList_[index] = value;
                return this;
            }

            public NewInitResponse.Builder SetCmdList(int index, CmdItem.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.cmdList_[index] = builderForValue.Build();
                return this;
            }

            public NewInitResponse.Builder SetContinueFlag(uint value)
            {
                this.PrepareBuilder();
                this.result.hasContinueFlag = true;
                this.result.continueFlag_ = value;
                return this;
            }

            public NewInitResponse.Builder SetCurrentSynckey(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasCurrentSynckey = true;
                this.result.currentSynckey_ = value;
                return this;
            }

            public NewInitResponse.Builder SetCurrentSynckey(SKBuiltinBuffer_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasCurrentSynckey = true;
                this.result.currentSynckey_ = builderForValue.Build();
                return this;
            }

            public NewInitResponse.Builder SetMaxSynckey(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasMaxSynckey = true;
                this.result.maxSynckey_ = value;
                return this;
            }

            public NewInitResponse.Builder SetMaxSynckey(SKBuiltinBuffer_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasMaxSynckey = true;
                this.result.maxSynckey_ = builderForValue.Build();
                return this;
            }

            public NewInitResponse.Builder SetRatio(uint value)
            {
                this.PrepareBuilder();
                this.result.hasRatio = true;
                this.result.ratio_ = value;
                return this;
            }

            public NewInitResponse.Builder SetSelectBitmap(uint value)
            {
                this.PrepareBuilder();
                this.result.hasSelectBitmap = true;
                this.result.selectBitmap_ = value;
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

            public uint CmdCount
            {
                get
                {
                    return this.result.CmdCount;
                }
                set
                {
                    this.SetCmdCount(value);
                }
            }

            public int CmdListCount
            {
                get
                {
                    return this.result.CmdListCount;
                }
            }

            public IPopsicleList<CmdItem> CmdListList
            {
                get
                {
                    return this.PrepareBuilder().cmdList_;
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

            public SKBuiltinBuffer_t CurrentSynckey
            {
                get
                {
                    return this.result.CurrentSynckey;
                }
                set
                {
                    this.SetCurrentSynckey(value);
                }
            }

            public override NewInitResponse DefaultInstanceForType
            {
                get
                {
                    return NewInitResponse.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            public SKBuiltinBuffer_t MaxSynckey
            {
                get
                {
                    return this.result.MaxSynckey;
                }
                set
                {
                    this.SetMaxSynckey(value);
                }
            }

            protected override NewInitResponse MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public uint Ratio
            {
                get
                {
                    return this.result.Ratio;
                }
                set
                {
                    this.SetRatio(value);
                }
            }

            public uint SelectBitmap
            {
                get
                {
                    return this.result.SelectBitmap;
                }
                set
                {
                    this.SetSelectBitmap(value);
                }
            }

            protected override NewInitResponse.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


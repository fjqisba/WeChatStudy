namespace micromsg
{
    using Google.ProtocolBuffers;
   
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

    
    public sealed class CmdItem : GeneratedMessageLite<CmdItem, CmdItem.Builder>
    {
        private static readonly string[] _cmdItemFieldNames = new string[] { "CmdBuf", "CmdId" };
        private static readonly uint[] _cmdItemFieldTags = new uint[] { 0x12, 8 };
        private SKBuiltinBuffer_t cmdBuf_;
        public const int CmdBufFieldNumber = 2;
        private int cmdId_;
        public const int CmdIdFieldNumber = 1;
        private static readonly CmdItem defaultInstance = new CmdItem().MakeReadOnly();
        private bool hasCmdBuf;
        private bool hasCmdId;
        private int memoizedSerializedSize = -1;

        static CmdItem()
        {
            //object.ReferenceEquals(CmdItem.Descriptor, null);
        }

        private CmdItem()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(CmdItem prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            CmdItem item = obj as CmdItem;
            if (item == null)
            {
                return false;
            }
            if ((this.hasCmdId != item.hasCmdId) || (this.hasCmdId && !this.cmdId_.Equals(item.cmdId_)))
            {
                return false;
            }
            return ((this.hasCmdBuf == item.hasCmdBuf) && (!this.hasCmdBuf || this.cmdBuf_.Equals(item.cmdBuf_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasCmdId)
            {
                hashCode ^= this.cmdId_.GetHashCode();
            }
            if (this.hasCmdBuf)
            {
                hashCode ^= this.cmdBuf_.GetHashCode();
            }
            return hashCode;
        }

        private CmdItem MakeReadOnly()
        {
            return this;
        }

        public static CmdItem ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<CmdItem, Builder>.PrintField("CmdId", this.hasCmdId, this.cmdId_, writer);
            GeneratedMessageLite<CmdItem, Builder>.PrintField("CmdBuf", this.hasCmdBuf, this.cmdBuf_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _cmdItemFieldNames;
            if (this.hasCmdId)
            {
                output.WriteInt32(1, strArray[1], this.CmdId);
            }
            if (this.hasCmdBuf)
            {
                output.WriteMessage(2, strArray[0], this.CmdBuf);
            }
        }

        public SKBuiltinBuffer_t CmdBuf
        {
            get
            {
                return (this.cmdBuf_ ?? SKBuiltinBuffer_t.DefaultInstance);
            }
        }

        public int CmdId
        {
            get
            {
                return this.cmdId_;
            }
        }

        public static CmdItem DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override CmdItem DefaultInstanceForType
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
                if (!this.hasCmdId)
                {
                    return false;
                }
                if (!this.hasCmdBuf)
                {
                    return false;
                }
                if (!this.CmdBuf.IsInitialized)
                {
                    return false;
                }
                return true;
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
                    if (this.hasCmdId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(1, this.CmdId);
                    }
                    if (this.hasCmdBuf)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(2, this.CmdBuf);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override CmdItem ThisMessage
        {
            get
            {
                return this;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<CmdItem, CmdItem.Builder>
        {
            private CmdItem result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = CmdItem.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(CmdItem cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override CmdItem BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override CmdItem.Builder Clear()
            {
                this.result = CmdItem.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public CmdItem.Builder ClearCmdBuf()
            {
                this.PrepareBuilder();
                this.result.hasCmdBuf = false;
                this.result.cmdBuf_ = null;
                return this;
            }

            public CmdItem.Builder ClearCmdId()
            {
                this.PrepareBuilder();
                this.result.hasCmdId = false;
                this.result.cmdId_ = 0;
                return this;
            }

            public override CmdItem.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new CmdItem.Builder(this.result);
                }
                return new CmdItem.Builder().MergeFrom(this.result);
            }

            public CmdItem.Builder MergeCmdBuf(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasCmdBuf && (this.result.cmdBuf_ != SKBuiltinBuffer_t.DefaultInstance))
                {
                    this.result.cmdBuf_ = SKBuiltinBuffer_t.CreateBuilder(this.result.cmdBuf_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.cmdBuf_ = value;
                }
                this.result.hasCmdBuf = true;
                return this;
            }

            public override CmdItem.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override CmdItem.Builder MergeFrom(IMessageLite other)
            {
                if (other is CmdItem)
                {
                    return this.MergeFrom((CmdItem) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override CmdItem.Builder MergeFrom(CmdItem other)
            {
                return this;
            }

            public override CmdItem.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(CmdItem._cmdItemFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = CmdItem._cmdItemFieldTags[index];
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
                            this.result.hasCmdId = input.ReadInt32(ref this.result.cmdId_);
                            continue;
                        }
                        case 0x12:
                        {
                            SKBuiltinBuffer_t.Builder builder = SKBuiltinBuffer_t.CreateBuilder();
                            if (this.result.hasCmdBuf)
                            {
                                builder.MergeFrom(this.CmdBuf);
                            }
                            input.ReadMessage(builder, extensionRegistry);
                            this.CmdBuf = builder.BuildPartial();
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

            private CmdItem PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    CmdItem result = this.result;
                    this.result = new CmdItem();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public CmdItem.Builder SetCmdBuf(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasCmdBuf = true;
                this.result.cmdBuf_ = value;
                return this;
            }

            public CmdItem.Builder SetCmdBuf(SKBuiltinBuffer_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasCmdBuf = true;
                this.result.cmdBuf_ = builderForValue.Build();
                return this;
            }

            public CmdItem.Builder SetCmdId(int value)
            {
                this.PrepareBuilder();
                this.result.hasCmdId = true;
                this.result.cmdId_ = value;
                return this;
            }

            public SKBuiltinBuffer_t CmdBuf
            {
                get
                {
                    return this.result.CmdBuf;
                }
                set
                {
                    this.SetCmdBuf(value);
                }
            }

            public int CmdId
            {
                get
                {
                    return this.result.CmdId;
                }
                set
                {
                    this.SetCmdId(value);
                }
            }

            public override CmdItem DefaultInstanceForType
            {
                get
                {
                    return CmdItem.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override CmdItem MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override CmdItem.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


namespace micromsg
{
    using Google.ProtocolBuffers;
   
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

    //
    public sealed class SnsObjectOp : GeneratedMessageLite<SnsObjectOp, SnsObjectOp.Builder>
    {
        private static readonly string[] _snsObjectOpFieldNames = new string[] { "Ext", "Id", "OpType" };
        private static readonly uint[] _snsObjectOpFieldTags = new uint[] { 0x1a, 8, 0x10 };
        private static readonly SnsObjectOp defaultInstance = new SnsObjectOp().MakeReadOnly();
        private SKBuiltinBuffer_t ext_;
        public const int ExtFieldNumber = 3;
        private bool hasExt;
        private bool hasId;
        private bool hasOpType;
        private ulong id_;
        public const int IdFieldNumber = 1;
        private int memoizedSerializedSize = -1;
        private uint opType_;
        public const int OpTypeFieldNumber = 2;

        static SnsObjectOp()
        {
           // object.ReferenceEquals(SnsObjectOp.Descriptor, null);
        }

        private SnsObjectOp()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(SnsObjectOp prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            SnsObjectOp op = obj as SnsObjectOp;
            if (op == null)
            {
                return false;
            }
            if ((this.hasId != op.hasId) || (this.hasId && !this.id_.Equals(op.id_)))
            {
                return false;
            }
            if ((this.hasOpType != op.hasOpType) || (this.hasOpType && !this.opType_.Equals(op.opType_)))
            {
                return false;
            }
            return ((this.hasExt == op.hasExt) && (!this.hasExt || this.ext_.Equals(op.ext_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasId)
            {
                hashCode ^= this.id_.GetHashCode();
            }
            if (this.hasOpType)
            {
                hashCode ^= this.opType_.GetHashCode();
            }
            if (this.hasExt)
            {
                hashCode ^= this.ext_.GetHashCode();
            }
            return hashCode;
        }

        private SnsObjectOp MakeReadOnly()
        {
            return this;
        }

        public static SnsObjectOp ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<SnsObjectOp, Builder>.PrintField("Id", this.hasId, this.id_, writer);
            GeneratedMessageLite<SnsObjectOp, Builder>.PrintField("OpType", this.hasOpType, this.opType_, writer);
            GeneratedMessageLite<SnsObjectOp, Builder>.PrintField("Ext", this.hasExt, this.ext_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _snsObjectOpFieldNames;
            if (this.hasId)
            {
                output.WriteUInt64(1, strArray[1], this.Id);
            }
            if (this.hasOpType)
            {
                output.WriteUInt32(2, strArray[2], this.OpType);
            }
            if (this.hasExt)
            {
                output.WriteMessage(3, strArray[0], this.Ext);
            }
        }

        public static SnsObjectOp DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override SnsObjectOp DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public SKBuiltinBuffer_t Ext
        {
            get
            {
                return (this.ext_ ?? SKBuiltinBuffer_t.DefaultInstance);
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
                if (!this.hasOpType)
                {
                    return false;
                }
                return true;
            }
        }

        public uint OpType
        {
            get
            {
                return this.opType_;
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
                    if (this.hasOpType)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(2, this.OpType);
                    }
                    if (this.hasExt)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(3, this.Ext);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override SnsObjectOp ThisMessage
        {
            get
            {
                return this;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<SnsObjectOp, SnsObjectOp.Builder>
        {
            private SnsObjectOp result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = SnsObjectOp.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(SnsObjectOp cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override SnsObjectOp BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override SnsObjectOp.Builder Clear()
            {
                this.result = SnsObjectOp.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public SnsObjectOp.Builder ClearExt()
            {
                this.PrepareBuilder();
                this.result.hasExt = false;
                this.result.ext_ = null;
                return this;
            }

            public SnsObjectOp.Builder ClearId()
            {
                this.PrepareBuilder();
                this.result.hasId = false;
                this.result.id_ = 0L;
                return this;
            }

            public SnsObjectOp.Builder ClearOpType()
            {
                this.PrepareBuilder();
                this.result.hasOpType = false;
                this.result.opType_ = 0;
                return this;
            }

            public override SnsObjectOp.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new SnsObjectOp.Builder(this.result);
                }
                return new SnsObjectOp.Builder().MergeFrom(this.result);
            }

            public SnsObjectOp.Builder MergeExt(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasExt && (this.result.ext_ != SKBuiltinBuffer_t.DefaultInstance))
                {
                    this.result.ext_ = SKBuiltinBuffer_t.CreateBuilder(this.result.ext_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.ext_ = value;
                }
                this.result.hasExt = true;
                return this;
            }

            public override SnsObjectOp.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override SnsObjectOp.Builder MergeFrom(IMessageLite other)
            {
                if (other is SnsObjectOp)
                {
                    return this.MergeFrom((SnsObjectOp) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override SnsObjectOp.Builder MergeFrom(SnsObjectOp other)
            {
                return this;
            }

            public override SnsObjectOp.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(SnsObjectOp._snsObjectOpFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = SnsObjectOp._snsObjectOpFieldTags[index];
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
                        case 0x10:
                        {
                            this.result.hasOpType = input.ReadUInt32(ref this.result.opType_);
                            continue;
                        }
                        case 0x1a:
                        {
                            SKBuiltinBuffer_t.Builder builder = SKBuiltinBuffer_t.CreateBuilder();
                            if (this.result.hasExt)
                            {
                                builder.MergeFrom(this.Ext);
                            }
                            input.ReadMessage(builder, extensionRegistry);
                            this.Ext = builder.BuildPartial();
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

            private SnsObjectOp PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    SnsObjectOp result = this.result;
                    this.result = new SnsObjectOp();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public SnsObjectOp.Builder SetExt(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasExt = true;
                this.result.ext_ = value;
                return this;
            }

            public SnsObjectOp.Builder SetExt(SKBuiltinBuffer_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasExt = true;
                this.result.ext_ = builderForValue.Build();
                return this;
            }

            public SnsObjectOp.Builder SetId(ulong value)
            {
                this.PrepareBuilder();
                this.result.hasId = true;
                this.result.id_ = value;
                return this;
            }

            public SnsObjectOp.Builder SetOpType(uint value)
            {
                this.PrepareBuilder();
                this.result.hasOpType = true;
                this.result.opType_ = value;
                return this;
            }

            public override SnsObjectOp DefaultInstanceForType
            {
                get
                {
                    return SnsObjectOp.DefaultInstance;
                }
            }

            public SKBuiltinBuffer_t Ext
            {
                get
                {
                    return this.result.Ext;
                }
                set
                {
                    this.SetExt(value);
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

            protected override SnsObjectOp MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public uint OpType
            {
                get
                {
                    return this.result.OpType;
                }
                set
                {
                    this.SetOpType(value);
                }
            }

            protected override SnsObjectOp.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


namespace micromsg
{
    using Google.ProtocolBuffers;

    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    


    public sealed class SnsActionGroup : GeneratedMessageLite<SnsActionGroup, SnsActionGroup.Builder>
    {
        private static readonly string[] _snsActionGroupFieldNames = new string[] { "CurrentAction", "Id", "ParentId", "ReferAction" };
        private static readonly uint[] _snsActionGroupFieldTags = new uint[] { 0x1a, 8, 0x10, 0x22 };
        private SnsAction currentAction_;
        public const int CurrentActionFieldNumber = 3;
        private static readonly SnsActionGroup defaultInstance = new SnsActionGroup().MakeReadOnly();
        private bool hasCurrentAction;
        private bool hasId;
        private bool hasParentId;
        private bool hasReferAction;
        private ulong id_;
        public const int IdFieldNumber = 1;
        private int memoizedSerializedSize = -1;
        private ulong parentId_;
        public const int ParentIdFieldNumber = 2;
        private SnsAction referAction_;
        public const int ReferActionFieldNumber = 4;

        static SnsActionGroup()
        {
            //object.ReferenceEquals(SnsActionGroup.Descriptor, null);
        }

        private SnsActionGroup()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(SnsActionGroup prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            SnsActionGroup group = obj as SnsActionGroup;
            if (group == null)
            {
                return false;
            }
            if ((this.hasId != group.hasId) || (this.hasId && !this.id_.Equals(group.id_)))
            {
                return false;
            }
            if ((this.hasParentId != group.hasParentId) || (this.hasParentId && !this.parentId_.Equals(group.parentId_)))
            {
                return false;
            }
            if ((this.hasCurrentAction != group.hasCurrentAction) || (this.hasCurrentAction && !this.currentAction_.Equals(group.currentAction_)))
            {
                return false;
            }
            return ((this.hasReferAction == group.hasReferAction) && (!this.hasReferAction || this.referAction_.Equals(group.referAction_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasId)
            {
                hashCode ^= this.id_.GetHashCode();
            }
            if (this.hasParentId)
            {
                hashCode ^= this.parentId_.GetHashCode();
            }
            if (this.hasCurrentAction)
            {
                hashCode ^= this.currentAction_.GetHashCode();
            }
            if (this.hasReferAction)
            {
                hashCode ^= this.referAction_.GetHashCode();
            }
            return hashCode;
        }

        private SnsActionGroup MakeReadOnly()
        {
            return this;
        }

        public static SnsActionGroup ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<SnsActionGroup, Builder>.PrintField("Id", this.hasId, this.id_, writer);
            GeneratedMessageLite<SnsActionGroup, Builder>.PrintField("ParentId", this.hasParentId, this.parentId_, writer);
            GeneratedMessageLite<SnsActionGroup, Builder>.PrintField("CurrentAction", this.hasCurrentAction, this.currentAction_, writer);
            GeneratedMessageLite<SnsActionGroup, Builder>.PrintField("ReferAction", this.hasReferAction, this.referAction_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _snsActionGroupFieldNames;
            if (this.hasId)
            {
                output.WriteUInt64(1, strArray[1], this.Id);
            }
            if (this.hasParentId)
            {
                output.WriteUInt64(2, strArray[2], this.ParentId);
            }
            if (this.hasCurrentAction)
            {
                output.WriteMessage(3, strArray[0], this.CurrentAction);
            }
            if (this.hasReferAction)
            {
                output.WriteMessage(4, strArray[3], this.ReferAction);
            }
        }

        public SnsAction CurrentAction
        {
            get
            {
                return (this.currentAction_ ?? SnsAction.DefaultInstance);
            }
        }

        public static SnsActionGroup DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override SnsActionGroup DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
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
                if (!this.hasCurrentAction)
                {
                    return false;
                }
                if (!this.CurrentAction.IsInitialized)
                {
                    return false;
                }
                return true;
            }
        }

        public ulong ParentId
        {
            get
            {
                return this.parentId_;
            }
        }

        public SnsAction ReferAction
        {
            get
            {
                return (this.referAction_ ?? SnsAction.DefaultInstance);
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
                    if (this.hasParentId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt64Size(2, this.ParentId);
                    }
                    if (this.hasCurrentAction)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(3, this.CurrentAction);
                    }
                    if (this.hasReferAction)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(4, this.ReferAction);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override SnsActionGroup ThisMessage
        {
            get
            {
                return this;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<SnsActionGroup, SnsActionGroup.Builder>
        {
            private SnsActionGroup result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = SnsActionGroup.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(SnsActionGroup cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override SnsActionGroup BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override SnsActionGroup.Builder Clear()
            {
                this.result = SnsActionGroup.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public SnsActionGroup.Builder ClearCurrentAction()
            {
                this.PrepareBuilder();
                this.result.hasCurrentAction = false;
                this.result.currentAction_ = null;
                return this;
            }

            public SnsActionGroup.Builder ClearId()
            {
                this.PrepareBuilder();
                this.result.hasId = false;
                this.result.id_ = 0L;
                return this;
            }

            public SnsActionGroup.Builder ClearParentId()
            {
                this.PrepareBuilder();
                this.result.hasParentId = false;
                this.result.parentId_ = 0L;
                return this;
            }

            public SnsActionGroup.Builder ClearReferAction()
            {
                this.PrepareBuilder();
                this.result.hasReferAction = false;
                this.result.referAction_ = null;
                return this;
            }

            public override SnsActionGroup.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new SnsActionGroup.Builder(this.result);
                }
                return new SnsActionGroup.Builder().MergeFrom(this.result);
            }

            public SnsActionGroup.Builder MergeCurrentAction(SnsAction value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasCurrentAction && (this.result.currentAction_ != SnsAction.DefaultInstance))
                {
                    this.result.currentAction_ = SnsAction.CreateBuilder(this.result.currentAction_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.currentAction_ = value;
                }
                this.result.hasCurrentAction = true;
                return this;
            }

            public override SnsActionGroup.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override SnsActionGroup.Builder MergeFrom(IMessageLite other)
            {
                if (other is SnsActionGroup)
                {
                    return this.MergeFrom((SnsActionGroup) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override SnsActionGroup.Builder MergeFrom(SnsActionGroup other)
            {
                return this;
            }

            public override SnsActionGroup.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(SnsActionGroup._snsActionGroupFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = SnsActionGroup._snsActionGroupFieldTags[index];
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
                            this.result.hasParentId = input.ReadUInt64(ref this.result.parentId_);
                            continue;
                        }
                        case 0x1a:
                        {
                            SnsAction.Builder builder = SnsAction.CreateBuilder();
                            if (this.result.hasCurrentAction)
                            {
                                builder.MergeFrom(this.CurrentAction);
                            }
                            input.ReadMessage(builder, extensionRegistry);
                            this.CurrentAction = builder.BuildPartial();
                            continue;
                        }
                        case 0x22:
                        {
                            SnsAction.Builder builder2 = SnsAction.CreateBuilder();
                            if (this.result.hasReferAction)
                            {
                                builder2.MergeFrom(this.ReferAction);
                            }
                            input.ReadMessage(builder2, extensionRegistry);
                            this.ReferAction = builder2.BuildPartial();
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

            public SnsActionGroup.Builder MergeReferAction(SnsAction value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasReferAction && (this.result.referAction_ != SnsAction.DefaultInstance))
                {
                    this.result.referAction_ = SnsAction.CreateBuilder(this.result.referAction_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.referAction_ = value;
                }
                this.result.hasReferAction = true;
                return this;
            }

            private SnsActionGroup PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    SnsActionGroup result = this.result;
                    this.result = new SnsActionGroup();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public SnsActionGroup.Builder SetCurrentAction(SnsAction value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasCurrentAction = true;
                this.result.currentAction_ = value;
                return this;
            }

            public SnsActionGroup.Builder SetCurrentAction(SnsAction.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasCurrentAction = true;
                this.result.currentAction_ = builderForValue.Build();
                return this;
            }

            public SnsActionGroup.Builder SetId(ulong value)
            {
                this.PrepareBuilder();
                this.result.hasId = true;
                this.result.id_ = value;
                return this;
            }

            public SnsActionGroup.Builder SetParentId(ulong value)
            {
                this.PrepareBuilder();
                this.result.hasParentId = true;
                this.result.parentId_ = value;
                return this;
            }

            public SnsActionGroup.Builder SetReferAction(SnsAction value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasReferAction = true;
                this.result.referAction_ = value;
                return this;
            }

            public SnsActionGroup.Builder SetReferAction(SnsAction.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasReferAction = true;
                this.result.referAction_ = builderForValue.Build();
                return this;
            }

            public SnsAction CurrentAction
            {
                get
                {
                    return this.result.CurrentAction;
                }
                set
                {
                    this.SetCurrentAction(value);
                }
            }

            public override SnsActionGroup DefaultInstanceForType
            {
                get
                {
                    return SnsActionGroup.DefaultInstance;
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

            protected override SnsActionGroup MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public ulong ParentId
            {
                get
                {
                    return this.result.ParentId;
                }
                set
                {
                    this.SetParentId(value);
                }
            }

            public SnsAction ReferAction
            {
                get
                {
                    return this.result.ReferAction;
                }
                set
                {
                    this.SetReferAction(value);
                }
            }

            protected override SnsActionGroup.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


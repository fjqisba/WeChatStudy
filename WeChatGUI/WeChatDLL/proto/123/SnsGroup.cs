namespace micromsg
{
    using Google.ProtocolBuffers;
    
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    


    public sealed class SnsGroup : GeneratedMessageLite<SnsGroup, SnsGroup.Builder>
    {
        private static readonly string[] _snsGroupFieldNames = new string[] { "GroupId" };
        private static readonly uint[] _snsGroupFieldTags = new uint[] { 8 };
        private static readonly SnsGroup defaultInstance = new SnsGroup().MakeReadOnly();
        private ulong groupId_;
        public const int GroupIdFieldNumber = 1;
        private bool hasGroupId;
        private int memoizedSerializedSize = -1;

        static SnsGroup()
        {
           // object.ReferenceEquals(SnsGroup.Descriptor, null);
        }

        private SnsGroup()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(SnsGroup prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            SnsGroup group = obj as SnsGroup;
            if (group == null)
            {
                return false;
            }
            return ((this.hasGroupId == group.hasGroupId) && (!this.hasGroupId || this.groupId_.Equals(group.groupId_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasGroupId)
            {
                hashCode ^= this.groupId_.GetHashCode();
            }
            return hashCode;
        }

        private SnsGroup MakeReadOnly()
        {
            return this;
        }

        public static SnsGroup ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<SnsGroup, Builder>.PrintField("GroupId", this.hasGroupId, this.groupId_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _snsGroupFieldNames;
            if (this.hasGroupId)
            {
                output.WriteUInt64(1, strArray[0], this.GroupId);
            }
        }

        public static SnsGroup DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override SnsGroup DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public ulong GroupId
        {
            get
            {
                return this.groupId_;
            }
        }

        public override bool IsInitialized
        {
            get
            {
                if (!this.hasGroupId)
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
                    if (this.hasGroupId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt64Size(1, this.GroupId);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override SnsGroup ThisMessage
        {
            get
            {
                return this;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<SnsGroup, SnsGroup.Builder>
        {
            private SnsGroup result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = SnsGroup.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(SnsGroup cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override SnsGroup BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override SnsGroup.Builder Clear()
            {
                this.result = SnsGroup.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public SnsGroup.Builder ClearGroupId()
            {
                this.PrepareBuilder();
                this.result.hasGroupId = false;
                this.result.groupId_ = 0L;
                return this;
            }

            public override SnsGroup.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new SnsGroup.Builder(this.result);
                }
                return new SnsGroup.Builder().MergeFrom(this.result);
            }

            public override SnsGroup.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override SnsGroup.Builder MergeFrom(IMessageLite other)
            {
                if (other is SnsGroup)
                {
                    return this.MergeFrom((SnsGroup) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override SnsGroup.Builder MergeFrom(SnsGroup other)
            {
                return this;
            }

            public override SnsGroup.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(SnsGroup._snsGroupFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = SnsGroup._snsGroupFieldTags[index];
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
                    this.result.hasGroupId = input.ReadUInt64(ref this.result.groupId_);
                }
                return this;
            }

            private SnsGroup PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    SnsGroup result = this.result;
                    this.result = new SnsGroup();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public SnsGroup.Builder SetGroupId(ulong value)
            {
                this.PrepareBuilder();
                this.result.hasGroupId = true;
                this.result.groupId_ = value;
                return this;
            }

            public override SnsGroup DefaultInstanceForType
            {
                get
                {
                    return SnsGroup.DefaultInstance;
                }
            }

            public ulong GroupId
            {
                get
                {
                    return this.result.GroupId;
                }
                set
                {
                    this.SetGroupId(value);
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override SnsGroup MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override SnsGroup.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


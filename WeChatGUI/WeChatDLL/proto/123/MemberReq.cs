namespace micromsg
{
    using Google.ProtocolBuffers;

    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

    
    public sealed class MemberReq : GeneratedMessageLite<MemberReq, MemberReq.Builder>
    {
        private static readonly string[] _memberReqFieldNames = new string[] { "MemberName" };
        private static readonly uint[] _memberReqFieldTags = new uint[] { 10 };
        private static readonly MemberReq defaultInstance = new MemberReq().MakeReadOnly();
        private bool hasMemberName;
        private SKBuiltinString_t memberName_;
        public const int MemberNameFieldNumber = 1;
        private int memoizedSerializedSize = -1;

        static MemberReq()
        {

        }

        private MemberReq()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(MemberReq prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            MemberReq req = obj as MemberReq;
            if (req == null)
            {
                return false;
            }
            return ((this.hasMemberName == req.hasMemberName) && (!this.hasMemberName || this.memberName_.Equals(req.memberName_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasMemberName)
            {
                hashCode ^= this.memberName_.GetHashCode();
            }
            return hashCode;
        }

        private MemberReq MakeReadOnly()
        {
            return this;
        }

        public static MemberReq ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<MemberReq, Builder>.PrintField("MemberName", this.hasMemberName, this.memberName_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _memberReqFieldNames;
            if (this.hasMemberName)
            {
                output.WriteMessage(1, strArray[0], this.MemberName);
            }
        }

        public static MemberReq DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override MemberReq DefaultInstanceForType
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
                if (!this.hasMemberName)
                {
                    return false;
                }
                return true;
            }
        }

        public SKBuiltinString_t MemberName
        {
            get
            {
                return (this.memberName_ ?? SKBuiltinString_t.DefaultInstance);
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
                    if (this.hasMemberName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(1, this.MemberName);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override MemberReq ThisMessage
        {
            get
            {
                return this;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<MemberReq, MemberReq.Builder>
        {
            private MemberReq result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = MemberReq.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(MemberReq cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override MemberReq BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override MemberReq.Builder Clear()
            {
                this.result = MemberReq.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public MemberReq.Builder ClearMemberName()
            {
                this.PrepareBuilder();
                this.result.hasMemberName = false;
                this.result.memberName_ = null;
                return this;
            }

            public override MemberReq.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new MemberReq.Builder(this.result);
                }
                return new MemberReq.Builder().MergeFrom(this.result);
            }

            public override MemberReq.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override MemberReq.Builder MergeFrom(IMessageLite other)
            {
                if (other is MemberReq)
                {
                    return this.MergeFrom((MemberReq) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override MemberReq.Builder MergeFrom(MemberReq other)
            {
                return this;
            }

            public override MemberReq.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(MemberReq._memberReqFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = MemberReq._memberReqFieldTags[index];
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

                        case 10:
                        {
                            SKBuiltinString_t.Builder builder = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasMemberName)
                            {
                                builder.MergeFrom(this.MemberName);
                            }
                            input.ReadMessage(builder, extensionRegistry);
                            this.MemberName = builder.BuildPartial();
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

            public MemberReq.Builder MergeMemberName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasMemberName && (this.result.memberName_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.memberName_ = SKBuiltinString_t.CreateBuilder(this.result.memberName_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.memberName_ = value;
                }
                this.result.hasMemberName = true;
                return this;
            }

            private MemberReq PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    MemberReq result = this.result;
                    this.result = new MemberReq();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public MemberReq.Builder SetMemberName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasMemberName = true;
                this.result.memberName_ = value;
                return this;
            }

            public MemberReq.Builder SetMemberName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasMemberName = true;
                this.result.memberName_ = builderForValue.Build();
                return this;
            }

            public override MemberReq DefaultInstanceForType
            {
                get
                {
                    return MemberReq.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            public SKBuiltinString_t MemberName
            {
                get
                {
                    return this.result.MemberName;
                }
                set
                {
                    this.SetMemberName(value);
                }
            }

            protected override MemberReq MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override MemberReq.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


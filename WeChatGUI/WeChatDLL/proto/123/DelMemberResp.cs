namespace micromsg
{
    using Google.ProtocolBuffers;

    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

    public sealed class DelMemberResp : GeneratedMessageLite<DelMemberResp, DelMemberResp.Builder>
    {
        private static readonly string[] _delMemberRespFieldNames = new string[] { "MemberName" };
        private static readonly uint[] _delMemberRespFieldTags = new uint[] { 10 };
        private static readonly DelMemberResp defaultInstance = new DelMemberResp().MakeReadOnly();
        private bool hasMemberName;
        private SKBuiltinString_t memberName_;
        public const int MemberNameFieldNumber = 1;
        private int memoizedSerializedSize = -1;

        static DelMemberResp()
        {

        }

        private DelMemberResp()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(DelMemberResp prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            DelMemberResp resp = obj as DelMemberResp;
            if (resp == null)
            {
                return false;
            }
            return ((this.hasMemberName == resp.hasMemberName) && (!this.hasMemberName || this.memberName_.Equals(resp.memberName_)));
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

        private DelMemberResp MakeReadOnly()
        {
            return this;
        }

        public static DelMemberResp ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<DelMemberResp, Builder>.PrintField("MemberName", this.hasMemberName, this.memberName_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _delMemberRespFieldNames;
            if (this.hasMemberName)
            {
                output.WriteMessage(1, strArray[0], this.MemberName);
            }
        }

        public static DelMemberResp DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override DelMemberResp DefaultInstanceForType
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

        protected override DelMemberResp ThisMessage
        {
            get
            {
                return this;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<DelMemberResp, DelMemberResp.Builder>
        {
            private DelMemberResp result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = DelMemberResp.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(DelMemberResp cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override DelMemberResp BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override DelMemberResp.Builder Clear()
            {
                this.result = DelMemberResp.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public DelMemberResp.Builder ClearMemberName()
            {
                this.PrepareBuilder();
                this.result.hasMemberName = false;
                this.result.memberName_ = null;
                return this;
            }

            public override DelMemberResp.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new DelMemberResp.Builder(this.result);
                }
                return new DelMemberResp.Builder().MergeFrom(this.result);
            }

            public override DelMemberResp.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override DelMemberResp.Builder MergeFrom(IMessageLite other)
            {
                if (other is DelMemberResp)
                {
                    return this.MergeFrom((DelMemberResp) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override DelMemberResp.Builder MergeFrom(DelMemberResp other)
            {
                return this;
            }

            public override DelMemberResp.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(DelMemberResp._delMemberRespFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = DelMemberResp._delMemberRespFieldTags[index];
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

            public DelMemberResp.Builder MergeMemberName(SKBuiltinString_t value)
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

            private DelMemberResp PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    DelMemberResp result = this.result;
                    this.result = new DelMemberResp();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public DelMemberResp.Builder SetMemberName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasMemberName = true;
                this.result.memberName_ = value;
                return this;
            }

            public DelMemberResp.Builder SetMemberName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasMemberName = true;
                this.result.memberName_ = builderForValue.Build();
                return this;
            }

            public override DelMemberResp DefaultInstanceForType
            {
                get
                {
                    return DelMemberResp.DefaultInstance;
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

            protected override DelMemberResp MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override DelMemberResp.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


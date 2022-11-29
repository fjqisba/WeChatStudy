namespace micromsg
{
    using Google.ProtocolBuffers;
    
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

    //
    public sealed class CloseMicroBlog : GeneratedMessageLite<CloseMicroBlog, CloseMicroBlog.Builder>
    {
        private static readonly string[] _closeMicroBlogFieldNames = new string[] { "MicroBlogUserName" };
        private static readonly uint[] _closeMicroBlogFieldTags = new uint[] { 10 };
        private static readonly CloseMicroBlog defaultInstance = new CloseMicroBlog().MakeReadOnly();
        private bool hasMicroBlogUserName;
        private int memoizedSerializedSize = -1;
        private SKBuiltinString_t microBlogUserName_;
        public const int MicroBlogUserNameFieldNumber = 1;

        static CloseMicroBlog()
        {
           // object.ReferenceEquals(CloseMicroBlog.Descriptor, null);
        }

        private CloseMicroBlog()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(CloseMicroBlog prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            CloseMicroBlog blog = obj as CloseMicroBlog;
            if (blog == null)
            {
                return false;
            }
            return ((this.hasMicroBlogUserName == blog.hasMicroBlogUserName) && (!this.hasMicroBlogUserName || this.microBlogUserName_.Equals(blog.microBlogUserName_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasMicroBlogUserName)
            {
                hashCode ^= this.microBlogUserName_.GetHashCode();
            }
            return hashCode;
        }

        private CloseMicroBlog MakeReadOnly()
        {
            return this;
        }

        public static CloseMicroBlog ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<CloseMicroBlog, Builder>.PrintField("MicroBlogUserName", this.hasMicroBlogUserName, this.microBlogUserName_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _closeMicroBlogFieldNames;
            if (this.hasMicroBlogUserName)
            {
                output.WriteMessage(1, strArray[0], this.MicroBlogUserName);
            }
        }

        public static CloseMicroBlog DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override CloseMicroBlog DefaultInstanceForType
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
                if (!this.hasMicroBlogUserName)
                {
                    return false;
                }
                return true;
            }
        }

        public SKBuiltinString_t MicroBlogUserName
        {
            get
            {
                return (this.microBlogUserName_ ?? SKBuiltinString_t.DefaultInstance);
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
                    if (this.hasMicroBlogUserName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(1, this.MicroBlogUserName);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override CloseMicroBlog ThisMessage
        {
            get
            {
                return this;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<CloseMicroBlog, CloseMicroBlog.Builder>
        {
            private CloseMicroBlog result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = CloseMicroBlog.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(CloseMicroBlog cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override CloseMicroBlog BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override CloseMicroBlog.Builder Clear()
            {
                this.result = CloseMicroBlog.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public CloseMicroBlog.Builder ClearMicroBlogUserName()
            {
                this.PrepareBuilder();
                this.result.hasMicroBlogUserName = false;
                this.result.microBlogUserName_ = null;
                return this;
            }

            public override CloseMicroBlog.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new CloseMicroBlog.Builder(this.result);
                }
                return new CloseMicroBlog.Builder().MergeFrom(this.result);
            }

            public override CloseMicroBlog.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override CloseMicroBlog.Builder MergeFrom(IMessageLite other)
            {
                if (other is CloseMicroBlog)
                {
                    return this.MergeFrom((CloseMicroBlog) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override CloseMicroBlog.Builder MergeFrom(CloseMicroBlog other)
            {
                return this;
            }

            public override CloseMicroBlog.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(CloseMicroBlog._closeMicroBlogFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = CloseMicroBlog._closeMicroBlogFieldTags[index];
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
                            if (this.result.hasMicroBlogUserName)
                            {
                                builder.MergeFrom(this.MicroBlogUserName);
                            }
                            input.ReadMessage(builder, extensionRegistry);
                            this.MicroBlogUserName = builder.BuildPartial();
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

            public CloseMicroBlog.Builder MergeMicroBlogUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasMicroBlogUserName && (this.result.microBlogUserName_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.microBlogUserName_ = SKBuiltinString_t.CreateBuilder(this.result.microBlogUserName_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.microBlogUserName_ = value;
                }
                this.result.hasMicroBlogUserName = true;
                return this;
            }

            private CloseMicroBlog PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    CloseMicroBlog result = this.result;
                    this.result = new CloseMicroBlog();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public CloseMicroBlog.Builder SetMicroBlogUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasMicroBlogUserName = true;
                this.result.microBlogUserName_ = value;
                return this;
            }

            public CloseMicroBlog.Builder SetMicroBlogUserName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasMicroBlogUserName = true;
                this.result.microBlogUserName_ = builderForValue.Build();
                return this;
            }

            public override CloseMicroBlog DefaultInstanceForType
            {
                get
                {
                    return CloseMicroBlog.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override CloseMicroBlog MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public SKBuiltinString_t MicroBlogUserName
            {
                get
                {
                    return this.result.MicroBlogUserName;
                }
                set
                {
                    this.SetMicroBlogUserName(value);
                }
            }

            protected override CloseMicroBlog.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


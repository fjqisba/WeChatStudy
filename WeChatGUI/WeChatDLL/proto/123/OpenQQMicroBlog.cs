namespace micromsg
{
    using Google.ProtocolBuffers;
   
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

   
    public sealed class OpenQQMicroBlog : GeneratedMessageLite<OpenQQMicroBlog, OpenQQMicroBlog.Builder>
    {
        private static readonly string[] _openQQMicroBlogFieldNames = new string[] { "MicroBlogUserName" };
        private static readonly uint[] _openQQMicroBlogFieldTags = new uint[] { 10 };
        private static readonly OpenQQMicroBlog defaultInstance = new OpenQQMicroBlog().MakeReadOnly();
        private bool hasMicroBlogUserName;
        private int memoizedSerializedSize = -1;
        private SKBuiltinString_t microBlogUserName_;
        public const int MicroBlogUserNameFieldNumber = 1;

        static OpenQQMicroBlog()
        {
            //object.ReferenceEquals(OpenQQMicroBlog.Descriptor, null);
        }

        private OpenQQMicroBlog()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(OpenQQMicroBlog prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            OpenQQMicroBlog blog = obj as OpenQQMicroBlog;
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

        private OpenQQMicroBlog MakeReadOnly()
        {
            return this;
        }

        public static OpenQQMicroBlog ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<OpenQQMicroBlog, Builder>.PrintField("MicroBlogUserName", this.hasMicroBlogUserName, this.microBlogUserName_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _openQQMicroBlogFieldNames;
            if (this.hasMicroBlogUserName)
            {
                output.WriteMessage(1, strArray[0], this.MicroBlogUserName);
            }
        }

        public static OpenQQMicroBlog DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override OpenQQMicroBlog DefaultInstanceForType
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

        protected override OpenQQMicroBlog ThisMessage
        {
            get
            {
                return this;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<OpenQQMicroBlog, OpenQQMicroBlog.Builder>
        {
            private OpenQQMicroBlog result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = OpenQQMicroBlog.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(OpenQQMicroBlog cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override OpenQQMicroBlog BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override OpenQQMicroBlog.Builder Clear()
            {
                this.result = OpenQQMicroBlog.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public OpenQQMicroBlog.Builder ClearMicroBlogUserName()
            {
                this.PrepareBuilder();
                this.result.hasMicroBlogUserName = false;
                this.result.microBlogUserName_ = null;
                return this;
            }

            public override OpenQQMicroBlog.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new OpenQQMicroBlog.Builder(this.result);
                }
                return new OpenQQMicroBlog.Builder().MergeFrom(this.result);
            }

            public override OpenQQMicroBlog.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override OpenQQMicroBlog.Builder MergeFrom(IMessageLite other)
            {
                if (other is OpenQQMicroBlog)
                {
                    return this.MergeFrom((OpenQQMicroBlog) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override OpenQQMicroBlog.Builder MergeFrom(OpenQQMicroBlog other)
            {
                return this;
            }

            public override OpenQQMicroBlog.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(OpenQQMicroBlog._openQQMicroBlogFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = OpenQQMicroBlog._openQQMicroBlogFieldTags[index];
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

            public OpenQQMicroBlog.Builder MergeMicroBlogUserName(SKBuiltinString_t value)
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

            private OpenQQMicroBlog PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    OpenQQMicroBlog result = this.result;
                    this.result = new OpenQQMicroBlog();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public OpenQQMicroBlog.Builder SetMicroBlogUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasMicroBlogUserName = true;
                this.result.microBlogUserName_ = value;
                return this;
            }

            public OpenQQMicroBlog.Builder SetMicroBlogUserName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasMicroBlogUserName = true;
                this.result.microBlogUserName_ = builderForValue.Build();
                return this;
            }

            public override OpenQQMicroBlog DefaultInstanceForType
            {
                get
                {
                    return OpenQQMicroBlog.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override OpenQQMicroBlog MessageBeingBuilt
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

            protected override OpenQQMicroBlog.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


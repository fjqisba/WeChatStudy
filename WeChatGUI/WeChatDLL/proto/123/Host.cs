namespace micromsg
{
    using Google.ProtocolBuffers;
   
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

    
    public sealed class Host : GeneratedMessageLite<Host, Host.Builder>
    {
        private static readonly string[] _hostFieldNames = new string[] { "Origin", "Substitute" };
        private static readonly uint[] _hostFieldTags = new uint[] { 10, 0x12 };
        private static readonly Host defaultInstance = new Host().MakeReadOnly();
        private bool hasOrigin;
        private bool hasSubstitute;
        private int memoizedSerializedSize = -1;
        private string origin_ = "";
        public const int OriginFieldNumber = 1;
        private string substitute_ = "";
        public const int SubstituteFieldNumber = 2;

        static Host()
        {
            //object.ReferenceEquals(Host.Descriptor, null);
        }

        private Host()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(Host prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            Host host = obj as Host;
            if (host == null)
            {
                return false;
            }
            if ((this.hasOrigin != host.hasOrigin) || (this.hasOrigin && !this.origin_.Equals(host.origin_)))
            {
                return false;
            }
            return ((this.hasSubstitute == host.hasSubstitute) && (!this.hasSubstitute || this.substitute_.Equals(host.substitute_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasOrigin)
            {
                hashCode ^= this.origin_.GetHashCode();
            }
            if (this.hasSubstitute)
            {
                hashCode ^= this.substitute_.GetHashCode();
            }
            return hashCode;
        }

        private Host MakeReadOnly()
        {
            return this;
        }

        public static Host ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<Host, Builder>.PrintField("Origin", this.hasOrigin, this.origin_, writer);
            GeneratedMessageLite<Host, Builder>.PrintField("Substitute", this.hasSubstitute, this.substitute_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _hostFieldNames;
            if (this.hasOrigin)
            {
                output.WriteString(1, strArray[0], this.Origin);
            }
            if (this.hasSubstitute)
            {
                output.WriteString(2, strArray[1], this.Substitute);
            }
        }

        public static Host DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override Host DefaultInstanceForType
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
                return true;
            }
        }

        public string Origin
        {
            get
            {
                return this.origin_;
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
                    if (this.hasOrigin)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(1, this.Origin);
                    }
                    if (this.hasSubstitute)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(2, this.Substitute);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        public string Substitute
        {
            get
            {
                return this.substitute_;
            }
        }

        protected override Host ThisMessage
        {
            get
            {
                return this;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<Host, Host.Builder>
        {
            private Host result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = Host.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(Host cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override Host BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override Host.Builder Clear()
            {
                this.result = Host.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public Host.Builder ClearOrigin()
            {
                this.PrepareBuilder();
                this.result.hasOrigin = false;
                this.result.origin_ = "";
                return this;
            }

            public Host.Builder ClearSubstitute()
            {
                this.PrepareBuilder();
                this.result.hasSubstitute = false;
                this.result.substitute_ = "";
                return this;
            }

            public override Host.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new Host.Builder(this.result);
                }
                return new Host.Builder().MergeFrom(this.result);
            }

            public override Host.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override Host.Builder MergeFrom(IMessageLite other)
            {
                if (other is Host)
                {
                    return this.MergeFrom((Host) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override Host.Builder MergeFrom(Host other)
            {
                return this;
            }

            public override Host.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(Host._hostFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = Host._hostFieldTags[index];
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
                            this.result.hasOrigin = input.ReadString(ref this.result.origin_);
                            continue;
                        }
                        case 0x12:
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
                    this.result.hasSubstitute = input.ReadString(ref this.result.substitute_);
                }
                return this;
            }

            private Host PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    Host result = this.result;
                    this.result = new Host();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public Host.Builder SetOrigin(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasOrigin = true;
                this.result.origin_ = value;
                return this;
            }

            public Host.Builder SetSubstitute(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSubstitute = true;
                this.result.substitute_ = value;
                return this;
            }

            public override Host DefaultInstanceForType
            {
                get
                {
                    return Host.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override Host MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public string Origin
            {
                get
                {
                    return this.result.Origin;
                }
                set
                {
                    this.SetOrigin(value);
                }
            }

            public string Substitute
            {
                get
                {
                    return this.result.Substitute;
                }
                set
                {
                    this.SetSubstitute(value);
                }
            }

            protected override Host.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


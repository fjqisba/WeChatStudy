namespace micromsg
{
    using Google.ProtocolBuffers;
   
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

    
    public sealed class BuiltinIP : GeneratedMessageLite<BuiltinIP, BuiltinIP.Builder>
    {
        private static readonly string[] _builtinIPFieldNames = new string[] { "IP", "port", "type" };
        private static readonly uint[] _builtinIPFieldTags = new uint[] { 0x1a, 0x10, 8 };
        private static readonly BuiltinIP defaultInstance = new BuiltinIP().MakeReadOnly();
        private bool hasIP;
        private bool hasPort;
        private bool hasType;
        private ByteString iP_ = ByteString.Empty;
        public const int IPFieldNumber = 3;
        private int memoizedSerializedSize = -1;
        private uint port_;
        public const int PortFieldNumber = 2;
        private uint type_;
        public const int TypeFieldNumber = 1;

        static BuiltinIP()
        {
           // object.ReferenceEquals(BuiltinIP.Descriptor, null);
        }

        private BuiltinIP()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(BuiltinIP prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            BuiltinIP nip = obj as BuiltinIP;
            if (nip == null)
            {
                return false;
            }
            if ((this.hasType != nip.hasType) || (this.hasType && !this.type_.Equals(nip.type_)))
            {
                return false;
            }
            if ((this.hasPort != nip.hasPort) || (this.hasPort && !this.port_.Equals(nip.port_)))
            {
                return false;
            }
            return ((this.hasIP == nip.hasIP) && (!this.hasIP || this.iP_.Equals(nip.iP_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasType)
            {
                hashCode ^= this.type_.GetHashCode();
            }
            if (this.hasPort)
            {
                hashCode ^= this.port_.GetHashCode();
            }
            if (this.hasIP)
            {
                hashCode ^= this.iP_.GetHashCode();
            }
            return hashCode;
        }

        private BuiltinIP MakeReadOnly()
        {
            return this;
        }

        public static BuiltinIP ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<BuiltinIP, Builder>.PrintField("type", this.hasType, this.type_, writer);
            GeneratedMessageLite<BuiltinIP, Builder>.PrintField("port", this.hasPort, this.port_, writer);
            GeneratedMessageLite<BuiltinIP, Builder>.PrintField("IP", this.hasIP, this.iP_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _builtinIPFieldNames;
            if (this.hasType)
            {
                output.WriteUInt32(1, strArray[2], this.Type);
            }
            if (this.hasPort)
            {
                output.WriteUInt32(2, strArray[1], this.Port);
            }
            if (this.hasIP)
            {
                output.WriteBytes(3, strArray[0], this.IP);
            }
        }

        public static BuiltinIP DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override BuiltinIP DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public ByteString IP
        {
            get
            {
                return this.iP_;
            }
        }

        public override bool IsInitialized
        {
            get
            {
                if (!this.hasType)
                {
                    return false;
                }
                if (!this.hasPort)
                {
                    return false;
                }
                if (!this.hasIP)
                {
                    return false;
                }
                return true;
            }
        }

        public uint Port
        {
            get
            {
                return this.port_;
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
                    if (this.hasType)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(1, this.Type);
                    }
                    if (this.hasPort)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(2, this.Port);
                    }
                    if (this.hasIP)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeBytesSize(3, this.IP);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override BuiltinIP ThisMessage
        {
            get
            {
                return this;
            }
        }

        public uint Type
        {
            get
            {
                return this.type_;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<BuiltinIP, BuiltinIP.Builder>
        {
            private BuiltinIP result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = BuiltinIP.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(BuiltinIP cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override BuiltinIP BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override BuiltinIP.Builder Clear()
            {
                this.result = BuiltinIP.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public BuiltinIP.Builder ClearIP()
            {
                this.PrepareBuilder();
                this.result.hasIP = false;
                this.result.iP_ = ByteString.Empty;
                return this;
            }

            public BuiltinIP.Builder ClearPort()
            {
                this.PrepareBuilder();
                this.result.hasPort = false;
                this.result.port_ = 0;
                return this;
            }

            public BuiltinIP.Builder ClearType()
            {
                this.PrepareBuilder();
                this.result.hasType = false;
                this.result.type_ = 0;
                return this;
            }

            public override BuiltinIP.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new BuiltinIP.Builder(this.result);
                }
                return new BuiltinIP.Builder().MergeFrom(this.result);
            }

            public override BuiltinIP.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override BuiltinIP.Builder MergeFrom(IMessageLite other)
            {
                if (other is BuiltinIP)
                {
                    return this.MergeFrom((BuiltinIP) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override BuiltinIP.Builder MergeFrom(BuiltinIP other)
            {
                return this;
            }

            public override BuiltinIP.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(BuiltinIP._builtinIPFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = BuiltinIP._builtinIPFieldTags[index];
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
                            this.result.hasType = input.ReadUInt32(ref this.result.type_);
                            continue;
                        }
                        case 0x10:
                        {
                            this.result.hasPort = input.ReadUInt32(ref this.result.port_);
                            continue;
                        }
                        case 0x1a:
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
                    this.result.hasIP = input.ReadBytes(ref this.result.iP_);
                }
                return this;
            }

            private BuiltinIP PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    BuiltinIP result = this.result;
                    this.result = new BuiltinIP();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public BuiltinIP.Builder SetIP(ByteString value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasIP = true;
                this.result.iP_ = value;
                return this;
            }

            public BuiltinIP.Builder SetPort(uint value)
            {
                this.PrepareBuilder();
                this.result.hasPort = true;
                this.result.port_ = value;
                return this;
            }

            public BuiltinIP.Builder SetType(uint value)
            {
                this.PrepareBuilder();
                this.result.hasType = true;
                this.result.type_ = value;
                return this;
            }

            public override BuiltinIP DefaultInstanceForType
            {
                get
                {
                    return BuiltinIP.DefaultInstance;
                }
            }

            public ByteString IP
            {
                get
                {
                    return this.result.IP;
                }
                set
                {
                    this.SetIP(value);
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override BuiltinIP MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public uint Port
            {
                get
                {
                    return this.result.Port;
                }
                set
                {
                    this.SetPort(value);
                }
            }

            protected override BuiltinIP.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }

            public uint Type
            {
                get
                {
                    return this.result.Type;
                }
                set
                {
                    this.SetType(value);
                }
            }
        }
    }
}


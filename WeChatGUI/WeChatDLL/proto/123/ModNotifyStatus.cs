namespace micromsg
{
    using Google.ProtocolBuffers;
    
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

    //
    public sealed class ModNotifyStatus : GeneratedMessageLite<ModNotifyStatus, ModNotifyStatus.Builder>
    {
        private static readonly string[] _modNotifyStatusFieldNames = new string[] { "Status", "UserName" };
        private static readonly uint[] _modNotifyStatusFieldTags = new uint[] { 0x10, 10 };
        private static readonly ModNotifyStatus defaultInstance = new ModNotifyStatus().MakeReadOnly();
        private bool hasStatus;
        private bool hasUserName;
        private int memoizedSerializedSize = -1;
        private uint status_;
        public const int StatusFieldNumber = 2;
        private SKBuiltinString_t userName_;
        public const int UserNameFieldNumber = 1;

        static ModNotifyStatus()
        {
            //object.ReferenceEquals(ModNotifyStatus.Descriptor, null);
        }

        private ModNotifyStatus()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(ModNotifyStatus prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            ModNotifyStatus status = obj as ModNotifyStatus;
            if (status == null)
            {
                return false;
            }
            if ((this.hasUserName != status.hasUserName) || (this.hasUserName && !this.userName_.Equals(status.userName_)))
            {
                return false;
            }
            return ((this.hasStatus == status.hasStatus) && (!this.hasStatus || this.status_.Equals(status.status_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasUserName)
            {
                hashCode ^= this.userName_.GetHashCode();
            }
            if (this.hasStatus)
            {
                hashCode ^= this.status_.GetHashCode();
            }
            return hashCode;
        }

        private ModNotifyStatus MakeReadOnly()
        {
            return this;
        }

        public static ModNotifyStatus ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<ModNotifyStatus, Builder>.PrintField("UserName", this.hasUserName, this.userName_, writer);
            GeneratedMessageLite<ModNotifyStatus, Builder>.PrintField("Status", this.hasStatus, this.status_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _modNotifyStatusFieldNames;
            if (this.hasUserName)
            {
                output.WriteMessage(1, strArray[1], this.UserName);
            }
            if (this.hasStatus)
            {
                output.WriteUInt32(2, strArray[0], this.Status);
            }
        }

        public static ModNotifyStatus DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override ModNotifyStatus DefaultInstanceForType
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
                if (!this.hasUserName)
                {
                    return false;
                }
                if (!this.hasStatus)
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
                    if (this.hasUserName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(1, this.UserName);
                    }
                    if (this.hasStatus)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(2, this.Status);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        public uint Status
        {
            get
            {
                return this.status_;
            }
        }

        protected override ModNotifyStatus ThisMessage
        {
            get
            {
                return this;
            }
        }

        public SKBuiltinString_t UserName
        {
            get
            {
                return (this.userName_ ?? SKBuiltinString_t.DefaultInstance);
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<ModNotifyStatus, ModNotifyStatus.Builder>
        {
            private ModNotifyStatus result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = ModNotifyStatus.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(ModNotifyStatus cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override ModNotifyStatus BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override ModNotifyStatus.Builder Clear()
            {
                this.result = ModNotifyStatus.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public ModNotifyStatus.Builder ClearStatus()
            {
                this.PrepareBuilder();
                this.result.hasStatus = false;
                this.result.status_ = 0;
                return this;
            }

            public ModNotifyStatus.Builder ClearUserName()
            {
                this.PrepareBuilder();
                this.result.hasUserName = false;
                this.result.userName_ = null;
                return this;
            }

            public override ModNotifyStatus.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new ModNotifyStatus.Builder(this.result);
                }
                return new ModNotifyStatus.Builder().MergeFrom(this.result);
            }

            public override ModNotifyStatus.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override ModNotifyStatus.Builder MergeFrom(IMessageLite other)
            {
                if (other is ModNotifyStatus)
                {
                    return this.MergeFrom((ModNotifyStatus) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override ModNotifyStatus.Builder MergeFrom(ModNotifyStatus other)
            {
                return this;
            }

            public override ModNotifyStatus.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(ModNotifyStatus._modNotifyStatusFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = ModNotifyStatus._modNotifyStatusFieldTags[index];
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
                            if (this.result.hasUserName)
                            {
                                builder.MergeFrom(this.UserName);
                            }
                            input.ReadMessage(builder, extensionRegistry);
                            this.UserName = builder.BuildPartial();
                            continue;
                        }
                        case 0x10:
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
                    this.result.hasStatus = input.ReadUInt32(ref this.result.status_);
                }
                return this;
            }

            public ModNotifyStatus.Builder MergeUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasUserName && (this.result.userName_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.userName_ = SKBuiltinString_t.CreateBuilder(this.result.userName_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.userName_ = value;
                }
                this.result.hasUserName = true;
                return this;
            }

            private ModNotifyStatus PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    ModNotifyStatus result = this.result;
                    this.result = new ModNotifyStatus();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public ModNotifyStatus.Builder SetStatus(uint value)
            {
                this.PrepareBuilder();
                this.result.hasStatus = true;
                this.result.status_ = value;
                return this;
            }

            public ModNotifyStatus.Builder SetUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasUserName = true;
                this.result.userName_ = value;
                return this;
            }

            public ModNotifyStatus.Builder SetUserName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasUserName = true;
                this.result.userName_ = builderForValue.Build();
                return this;
            }

            public override ModNotifyStatus DefaultInstanceForType
            {
                get
                {
                    return ModNotifyStatus.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override ModNotifyStatus MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public uint Status
            {
                get
                {
                    return this.result.Status;
                }
                set
                {
                    this.SetStatus(value);
                }
            }

            protected override ModNotifyStatus.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }

            public SKBuiltinString_t UserName
            {
                get
                {
                    return this.result.UserName;
                }
                set
                {
                    this.SetUserName(value);
                }
            }
        }
    }
}


namespace micromsg
{
    using Google.ProtocolBuffers;
    
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

   // 
    public sealed class ModMicroBlogInfo : GeneratedMessageLite<ModMicroBlogInfo, ModMicroBlogInfo.Builder>
    {
        private static readonly string[] _modMicroBlogInfoFieldNames = new string[] { "DeleteFlag", "MicroBlogType", "NotifyStatus", "UserName" };
        private static readonly uint[] _modMicroBlogInfoFieldTags = new uint[] { 0x20, 0x10, 0x18, 10 };
        private static readonly ModMicroBlogInfo defaultInstance = new ModMicroBlogInfo().MakeReadOnly();
        private uint deleteFlag_;
        public const int DeleteFlagFieldNumber = 4;
        private bool hasDeleteFlag;
        private bool hasMicroBlogType;
        private bool hasNotifyStatus;
        private bool hasUserName;
        private int memoizedSerializedSize = -1;
        private uint microBlogType_;
        public const int MicroBlogTypeFieldNumber = 2;
        private uint notifyStatus_;
        public const int NotifyStatusFieldNumber = 3;
        private SKBuiltinString_t userName_;
        public const int UserNameFieldNumber = 1;

        static ModMicroBlogInfo()
        {
           // object.ReferenceEquals(ModMicroBlogInfo.Descriptor, null);
        }

        private ModMicroBlogInfo()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(ModMicroBlogInfo prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            ModMicroBlogInfo info = obj as ModMicroBlogInfo;
            if (info == null)
            {
                return false;
            }
            if ((this.hasUserName != info.hasUserName) || (this.hasUserName && !this.userName_.Equals(info.userName_)))
            {
                return false;
            }
            if ((this.hasMicroBlogType != info.hasMicroBlogType) || (this.hasMicroBlogType && !this.microBlogType_.Equals(info.microBlogType_)))
            {
                return false;
            }
            if ((this.hasNotifyStatus != info.hasNotifyStatus) || (this.hasNotifyStatus && !this.notifyStatus_.Equals(info.notifyStatus_)))
            {
                return false;
            }
            return ((this.hasDeleteFlag == info.hasDeleteFlag) && (!this.hasDeleteFlag || this.deleteFlag_.Equals(info.deleteFlag_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasUserName)
            {
                hashCode ^= this.userName_.GetHashCode();
            }
            if (this.hasMicroBlogType)
            {
                hashCode ^= this.microBlogType_.GetHashCode();
            }
            if (this.hasNotifyStatus)
            {
                hashCode ^= this.notifyStatus_.GetHashCode();
            }
            if (this.hasDeleteFlag)
            {
                hashCode ^= this.deleteFlag_.GetHashCode();
            }
            return hashCode;
        }

        private ModMicroBlogInfo MakeReadOnly()
        {
            return this;
        }

        public static ModMicroBlogInfo ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<ModMicroBlogInfo, Builder>.PrintField("UserName", this.hasUserName, this.userName_, writer);
            GeneratedMessageLite<ModMicroBlogInfo, Builder>.PrintField("MicroBlogType", this.hasMicroBlogType, this.microBlogType_, writer);
            GeneratedMessageLite<ModMicroBlogInfo, Builder>.PrintField("NotifyStatus", this.hasNotifyStatus, this.notifyStatus_, writer);
            GeneratedMessageLite<ModMicroBlogInfo, Builder>.PrintField("DeleteFlag", this.hasDeleteFlag, this.deleteFlag_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _modMicroBlogInfoFieldNames;
            if (this.hasUserName)
            {
                output.WriteMessage(1, strArray[3], this.UserName);
            }
            if (this.hasMicroBlogType)
            {
                output.WriteUInt32(2, strArray[1], this.MicroBlogType);
            }
            if (this.hasNotifyStatus)
            {
                output.WriteUInt32(3, strArray[2], this.NotifyStatus);
            }
            if (this.hasDeleteFlag)
            {
                output.WriteUInt32(4, strArray[0], this.DeleteFlag);
            }
        }

        public static ModMicroBlogInfo DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override ModMicroBlogInfo DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public uint DeleteFlag
        {
            get
            {
                return this.deleteFlag_;
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
                if (!this.hasMicroBlogType)
                {
                    return false;
                }
                if (!this.hasNotifyStatus)
                {
                    return false;
                }
                if (!this.hasDeleteFlag)
                {
                    return false;
                }
                return true;
            }
        }

        public uint MicroBlogType
        {
            get
            {
                return this.microBlogType_;
            }
        }

        public uint NotifyStatus
        {
            get
            {
                return this.notifyStatus_;
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
                    if (this.hasMicroBlogType)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(2, this.MicroBlogType);
                    }
                    if (this.hasNotifyStatus)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(3, this.NotifyStatus);
                    }
                    if (this.hasDeleteFlag)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(4, this.DeleteFlag);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override ModMicroBlogInfo ThisMessage
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

        
        public sealed class Builder : GeneratedBuilderLite<ModMicroBlogInfo, ModMicroBlogInfo.Builder>
        {
            private ModMicroBlogInfo result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = ModMicroBlogInfo.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(ModMicroBlogInfo cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override ModMicroBlogInfo BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override ModMicroBlogInfo.Builder Clear()
            {
                this.result = ModMicroBlogInfo.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public ModMicroBlogInfo.Builder ClearDeleteFlag()
            {
                this.PrepareBuilder();
                this.result.hasDeleteFlag = false;
                this.result.deleteFlag_ = 0;
                return this;
            }

            public ModMicroBlogInfo.Builder ClearMicroBlogType()
            {
                this.PrepareBuilder();
                this.result.hasMicroBlogType = false;
                this.result.microBlogType_ = 0;
                return this;
            }

            public ModMicroBlogInfo.Builder ClearNotifyStatus()
            {
                this.PrepareBuilder();
                this.result.hasNotifyStatus = false;
                this.result.notifyStatus_ = 0;
                return this;
            }

            public ModMicroBlogInfo.Builder ClearUserName()
            {
                this.PrepareBuilder();
                this.result.hasUserName = false;
                this.result.userName_ = null;
                return this;
            }

            public override ModMicroBlogInfo.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new ModMicroBlogInfo.Builder(this.result);
                }
                return new ModMicroBlogInfo.Builder().MergeFrom(this.result);
            }

            public override ModMicroBlogInfo.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override ModMicroBlogInfo.Builder MergeFrom(IMessageLite other)
            {
                if (other is ModMicroBlogInfo)
                {
                    return this.MergeFrom((ModMicroBlogInfo) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override ModMicroBlogInfo.Builder MergeFrom(ModMicroBlogInfo other)
            {
                return this;
            }

            public override ModMicroBlogInfo.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(ModMicroBlogInfo._modMicroBlogInfoFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = ModMicroBlogInfo._modMicroBlogInfoFieldTags[index];
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
                        {
                            this.result.hasMicroBlogType = input.ReadUInt32(ref this.result.microBlogType_);
                            continue;
                        }
                        case 0x18:
                        {
                            this.result.hasNotifyStatus = input.ReadUInt32(ref this.result.notifyStatus_);
                            continue;
                        }
                        case 0x20:
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
                    this.result.hasDeleteFlag = input.ReadUInt32(ref this.result.deleteFlag_);
                }
                return this;
            }

            public ModMicroBlogInfo.Builder MergeUserName(SKBuiltinString_t value)
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

            private ModMicroBlogInfo PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    ModMicroBlogInfo result = this.result;
                    this.result = new ModMicroBlogInfo();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public ModMicroBlogInfo.Builder SetDeleteFlag(uint value)
            {
                this.PrepareBuilder();
                this.result.hasDeleteFlag = true;
                this.result.deleteFlag_ = value;
                return this;
            }

            public ModMicroBlogInfo.Builder SetMicroBlogType(uint value)
            {
                this.PrepareBuilder();
                this.result.hasMicroBlogType = true;
                this.result.microBlogType_ = value;
                return this;
            }

            public ModMicroBlogInfo.Builder SetNotifyStatus(uint value)
            {
                this.PrepareBuilder();
                this.result.hasNotifyStatus = true;
                this.result.notifyStatus_ = value;
                return this;
            }

            public ModMicroBlogInfo.Builder SetUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasUserName = true;
                this.result.userName_ = value;
                return this;
            }

            public ModMicroBlogInfo.Builder SetUserName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasUserName = true;
                this.result.userName_ = builderForValue.Build();
                return this;
            }

            public override ModMicroBlogInfo DefaultInstanceForType
            {
                get
                {
                    return ModMicroBlogInfo.DefaultInstance;
                }
            }

            public uint DeleteFlag
            {
                get
                {
                    return this.result.DeleteFlag;
                }
                set
                {
                    this.SetDeleteFlag(value);
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override ModMicroBlogInfo MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public uint MicroBlogType
            {
                get
                {
                    return this.result.MicroBlogType;
                }
                set
                {
                    this.SetMicroBlogType(value);
                }
            }

            public uint NotifyStatus
            {
                get
                {
                    return this.result.NotifyStatus;
                }
                set
                {
                    this.SetNotifyStatus(value);
                }
            }

            protected override ModMicroBlogInfo.Builder ThisBuilder
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


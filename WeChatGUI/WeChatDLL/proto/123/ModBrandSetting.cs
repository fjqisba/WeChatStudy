namespace micromsg
{
    using Google.ProtocolBuffers;
    
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

    //
    public sealed class ModBrandSetting : GeneratedMessageLite<ModBrandSetting, ModBrandSetting.Builder>
    {
        private static readonly string[] _modBrandSettingFieldNames = new string[] { "BrandFlag", "UserName" };
        private static readonly uint[] _modBrandSettingFieldTags = new uint[] { 8, 0x12 };
        private uint brandFlag_;
        public const int BrandFlagFieldNumber = 1;
        private static readonly ModBrandSetting defaultInstance = new ModBrandSetting().MakeReadOnly();
        private bool hasBrandFlag;
        private bool hasUserName;
        private int memoizedSerializedSize = -1;
        private string userName_ = "";
        public const int UserNameFieldNumber = 2;

        static ModBrandSetting()
        {
           // object.ReferenceEquals(ModBrandSetting.Descriptor, null);
        }

        private ModBrandSetting()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(ModBrandSetting prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            ModBrandSetting setting = obj as ModBrandSetting;
            if (setting == null)
            {
                return false;
            }
            if ((this.hasBrandFlag != setting.hasBrandFlag) || (this.hasBrandFlag && !this.brandFlag_.Equals(setting.brandFlag_)))
            {
                return false;
            }
            return ((this.hasUserName == setting.hasUserName) && (!this.hasUserName || this.userName_.Equals(setting.userName_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasBrandFlag)
            {
                hashCode ^= this.brandFlag_.GetHashCode();
            }
            if (this.hasUserName)
            {
                hashCode ^= this.userName_.GetHashCode();
            }
            return hashCode;
        }

        private ModBrandSetting MakeReadOnly()
        {
            return this;
        }

        public static ModBrandSetting ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<ModBrandSetting, Builder>.PrintField("BrandFlag", this.hasBrandFlag, this.brandFlag_, writer);
            GeneratedMessageLite<ModBrandSetting, Builder>.PrintField("UserName", this.hasUserName, this.userName_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _modBrandSettingFieldNames;
            if (this.hasBrandFlag)
            {
                output.WriteUInt32(1, strArray[0], this.BrandFlag);
            }
            if (this.hasUserName)
            {
                output.WriteString(2, strArray[1], this.UserName);
            }
        }

        public uint BrandFlag
        {
            get
            {
                return this.brandFlag_;
            }
        }

        public static ModBrandSetting DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override ModBrandSetting DefaultInstanceForType
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
                if (!this.hasBrandFlag)
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
                    if (this.hasBrandFlag)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(1, this.BrandFlag);
                    }
                    if (this.hasUserName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(2, this.UserName);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override ModBrandSetting ThisMessage
        {
            get
            {
                return this;
            }
        }

        public string UserName
        {
            get
            {
                return this.userName_;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<ModBrandSetting, ModBrandSetting.Builder>
        {
            private ModBrandSetting result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = ModBrandSetting.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(ModBrandSetting cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override ModBrandSetting BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override ModBrandSetting.Builder Clear()
            {
                this.result = ModBrandSetting.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public ModBrandSetting.Builder ClearBrandFlag()
            {
                this.PrepareBuilder();
                this.result.hasBrandFlag = false;
                this.result.brandFlag_ = 0;
                return this;
            }

            public ModBrandSetting.Builder ClearUserName()
            {
                this.PrepareBuilder();
                this.result.hasUserName = false;
                this.result.userName_ = "";
                return this;
            }

            public override ModBrandSetting.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new ModBrandSetting.Builder(this.result);
                }
                return new ModBrandSetting.Builder().MergeFrom(this.result);
            }

            public override ModBrandSetting.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override ModBrandSetting.Builder MergeFrom(IMessageLite other)
            {
                if (other is ModBrandSetting)
                {
                    return this.MergeFrom((ModBrandSetting) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override ModBrandSetting.Builder MergeFrom(ModBrandSetting other)
            {
                return this;
            }

            public override ModBrandSetting.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(ModBrandSetting._modBrandSettingFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = ModBrandSetting._modBrandSettingFieldTags[index];
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
                            this.result.hasBrandFlag = input.ReadUInt32(ref this.result.brandFlag_);
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
                    this.result.hasUserName = input.ReadString(ref this.result.userName_);
                }
                return this;
            }

            private ModBrandSetting PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    ModBrandSetting result = this.result;
                    this.result = new ModBrandSetting();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public ModBrandSetting.Builder SetBrandFlag(uint value)
            {
                this.PrepareBuilder();
                this.result.hasBrandFlag = true;
                this.result.brandFlag_ = value;
                return this;
            }

            public ModBrandSetting.Builder SetUserName(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasUserName = true;
                this.result.userName_ = value;
                return this;
            }

            public uint BrandFlag
            {
                get
                {
                    return this.result.BrandFlag;
                }
                set
                {
                    this.SetBrandFlag(value);
                }
            }

            public override ModBrandSetting DefaultInstanceForType
            {
                get
                {
                    return ModBrandSetting.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override ModBrandSetting MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override ModBrandSetting.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }

            public string UserName
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


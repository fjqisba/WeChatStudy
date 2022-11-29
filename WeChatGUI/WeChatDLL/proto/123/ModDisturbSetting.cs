namespace micromsg
{
    using Google.ProtocolBuffers;
    
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

    
    public sealed class ModDisturbSetting : GeneratedMessageLite<ModDisturbSetting, ModDisturbSetting.Builder>
    {
        private static readonly string[] _modDisturbSettingFieldNames = new string[] { "DisturbSetting" };
        private static readonly uint[] _modDisturbSettingFieldTags = new uint[] { 10 };
        private static readonly ModDisturbSetting defaultInstance = new ModDisturbSetting().MakeReadOnly();
        private micromsg.DisturbSetting disturbSetting_;
        public const int DisturbSettingFieldNumber = 1;
        private bool hasDisturbSetting;
        private int memoizedSerializedSize = -1;

        static ModDisturbSetting()
        {
            //object.ReferenceEquals(ModDisturbSetting.Descriptor, null);
        }

        private ModDisturbSetting()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(ModDisturbSetting prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            ModDisturbSetting setting = obj as ModDisturbSetting;
            if (setting == null)
            {
                return false;
            }
            return ((this.hasDisturbSetting == setting.hasDisturbSetting) && (!this.hasDisturbSetting || this.disturbSetting_.Equals(setting.disturbSetting_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasDisturbSetting)
            {
                hashCode ^= this.disturbSetting_.GetHashCode();
            }
            return hashCode;
        }

        private ModDisturbSetting MakeReadOnly()
        {
            return this;
        }

        public static ModDisturbSetting ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<ModDisturbSetting, Builder>.PrintField("DisturbSetting", this.hasDisturbSetting, this.disturbSetting_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _modDisturbSettingFieldNames;
            if (this.hasDisturbSetting)
            {
                output.WriteMessage(1, strArray[0], this.DisturbSetting);
            }
        }

        public static ModDisturbSetting DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override ModDisturbSetting DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public micromsg.DisturbSetting DisturbSetting
        {
            get
            {
                return (this.disturbSetting_ ?? micromsg.DisturbSetting.DefaultInstance);
            }
        }

        public override bool IsInitialized
        {
            get
            {
                if (!this.hasDisturbSetting)
                {
                    return false;
                }
                if (!this.DisturbSetting.IsInitialized)
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
                    if (this.hasDisturbSetting)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(1, this.DisturbSetting);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override ModDisturbSetting ThisMessage
        {
            get
            {
                return this;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<ModDisturbSetting, ModDisturbSetting.Builder>
        {
            private ModDisturbSetting result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = ModDisturbSetting.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(ModDisturbSetting cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override ModDisturbSetting BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override ModDisturbSetting.Builder Clear()
            {
                this.result = ModDisturbSetting.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public ModDisturbSetting.Builder ClearDisturbSetting()
            {
                this.PrepareBuilder();
                this.result.hasDisturbSetting = false;
                this.result.disturbSetting_ = null;
                return this;
            }

            public override ModDisturbSetting.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new ModDisturbSetting.Builder(this.result);
                }
                return new ModDisturbSetting.Builder().MergeFrom(this.result);
            }

            public ModDisturbSetting.Builder MergeDisturbSetting(micromsg.DisturbSetting value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasDisturbSetting && (this.result.disturbSetting_ != micromsg.DisturbSetting.DefaultInstance))
                {
                    this.result.disturbSetting_ = micromsg.DisturbSetting.CreateBuilder(this.result.disturbSetting_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.disturbSetting_ = value;
                }
                this.result.hasDisturbSetting = true;
                return this;
            }

            public override ModDisturbSetting.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override ModDisturbSetting.Builder MergeFrom(IMessageLite other)
            {
                if (other is ModDisturbSetting)
                {
                    return this.MergeFrom((ModDisturbSetting) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override ModDisturbSetting.Builder MergeFrom(ModDisturbSetting other)
            {
                return this;
            }

            public override ModDisturbSetting.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(ModDisturbSetting._modDisturbSettingFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = ModDisturbSetting._modDisturbSettingFieldTags[index];
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
                            micromsg.DisturbSetting.Builder builder = micromsg.DisturbSetting.CreateBuilder();
                            if (this.result.hasDisturbSetting)
                            {
                                builder.MergeFrom(this.DisturbSetting);
                            }
                            input.ReadMessage(builder, extensionRegistry);
                            this.DisturbSetting = builder.BuildPartial();
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

            private ModDisturbSetting PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    ModDisturbSetting result = this.result;
                    this.result = new ModDisturbSetting();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public ModDisturbSetting.Builder SetDisturbSetting(micromsg.DisturbSetting value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasDisturbSetting = true;
                this.result.disturbSetting_ = value;
                return this;
            }

            public ModDisturbSetting.Builder SetDisturbSetting(micromsg.DisturbSetting.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasDisturbSetting = true;
                this.result.disturbSetting_ = builderForValue.Build();
                return this;
            }

            public override ModDisturbSetting DefaultInstanceForType
            {
                get
                {
                    return ModDisturbSetting.DefaultInstance;
                }
            }

            public micromsg.DisturbSetting DisturbSetting
            {
                get
                {
                    return this.result.DisturbSetting;
                }
                set
                {
                    this.SetDisturbSetting(value);
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override ModDisturbSetting MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override ModDisturbSetting.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


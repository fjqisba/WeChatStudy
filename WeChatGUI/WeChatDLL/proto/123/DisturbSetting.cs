namespace micromsg
{
    using Google.ProtocolBuffers;
    
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    


    public sealed class DisturbSetting : GeneratedMessageLite<DisturbSetting, DisturbSetting.Builder>
    {
        private static readonly string[] _disturbSettingFieldNames = new string[] { "AllDaySetting", "AllDayTime", "NightSetting", "NightTime" };
        private static readonly uint[] _disturbSettingFieldTags = new uint[] { 0x18, 0x22, 8, 0x12 };
        private uint allDaySetting_;
        public const int AllDaySettingFieldNumber = 3;
        private DisturbTimeSpan allDayTime_;
        public const int AllDayTimeFieldNumber = 4;
        private static readonly DisturbSetting defaultInstance = new DisturbSetting().MakeReadOnly();
        private bool hasAllDaySetting;
        private bool hasAllDayTime;
        private bool hasNightSetting;
        private bool hasNightTime;
        private int memoizedSerializedSize = -1;
        private uint nightSetting_;
        public const int NightSettingFieldNumber = 1;
        private DisturbTimeSpan nightTime_;
        public const int NightTimeFieldNumber = 2;

        static DisturbSetting()
        {
            //object.ReferenceEquals(DisturbSetting.Descriptor, null);
        }

        private DisturbSetting()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(DisturbSetting prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            DisturbSetting setting = obj as DisturbSetting;
            if (setting == null)
            {
                return false;
            }
            if ((this.hasNightSetting != setting.hasNightSetting) || (this.hasNightSetting && !this.nightSetting_.Equals(setting.nightSetting_)))
            {
                return false;
            }
            if ((this.hasNightTime != setting.hasNightTime) || (this.hasNightTime && !this.nightTime_.Equals(setting.nightTime_)))
            {
                return false;
            }
            if ((this.hasAllDaySetting != setting.hasAllDaySetting) || (this.hasAllDaySetting && !this.allDaySetting_.Equals(setting.allDaySetting_)))
            {
                return false;
            }
            return ((this.hasAllDayTime == setting.hasAllDayTime) && (!this.hasAllDayTime || this.allDayTime_.Equals(setting.allDayTime_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasNightSetting)
            {
                hashCode ^= this.nightSetting_.GetHashCode();
            }
            if (this.hasNightTime)
            {
                hashCode ^= this.nightTime_.GetHashCode();
            }
            if (this.hasAllDaySetting)
            {
                hashCode ^= this.allDaySetting_.GetHashCode();
            }
            if (this.hasAllDayTime)
            {
                hashCode ^= this.allDayTime_.GetHashCode();
            }
            return hashCode;
        }

        private DisturbSetting MakeReadOnly()
        {
            return this;
        }

        public static DisturbSetting ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<DisturbSetting, Builder>.PrintField("NightSetting", this.hasNightSetting, this.nightSetting_, writer);
            GeneratedMessageLite<DisturbSetting, Builder>.PrintField("NightTime", this.hasNightTime, this.nightTime_, writer);
            GeneratedMessageLite<DisturbSetting, Builder>.PrintField("AllDaySetting", this.hasAllDaySetting, this.allDaySetting_, writer);
            GeneratedMessageLite<DisturbSetting, Builder>.PrintField("AllDayTime", this.hasAllDayTime, this.allDayTime_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _disturbSettingFieldNames;
            if (this.hasNightSetting)
            {
                output.WriteUInt32(1, strArray[2], this.NightSetting);
            }
            if (this.hasNightTime)
            {
                output.WriteMessage(2, strArray[3], this.NightTime);
            }
            if (this.hasAllDaySetting)
            {
                output.WriteUInt32(3, strArray[0], this.AllDaySetting);
            }
            if (this.hasAllDayTime)
            {
                output.WriteMessage(4, strArray[1], this.AllDayTime);
            }
        }

        public uint AllDaySetting
        {
            get
            {
                return this.allDaySetting_;
            }
        }

        public DisturbTimeSpan AllDayTime
        {
            get
            {
                return (this.allDayTime_ ?? DisturbTimeSpan.DefaultInstance);
            }
        }

        public static DisturbSetting DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override DisturbSetting DefaultInstanceForType
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
                if (!this.hasNightSetting)
                {
                    return false;
                }
                if (!this.hasNightTime)
                {
                    return false;
                }
                if (!this.hasAllDaySetting)
                {
                    return false;
                }
                if (!this.hasAllDayTime)
                {
                    return false;
                }
                if (!this.NightTime.IsInitialized)
                {
                    return false;
                }
                if (!this.AllDayTime.IsInitialized)
                {
                    return false;
                }
                return true;
            }
        }

        public uint NightSetting
        {
            get
            {
                return this.nightSetting_;
            }
        }

        public DisturbTimeSpan NightTime
        {
            get
            {
                return (this.nightTime_ ?? DisturbTimeSpan.DefaultInstance);
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
                    if (this.hasNightSetting)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(1, this.NightSetting);
                    }
                    if (this.hasNightTime)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(2, this.NightTime);
                    }
                    if (this.hasAllDaySetting)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(3, this.AllDaySetting);
                    }
                    if (this.hasAllDayTime)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(4, this.AllDayTime);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override DisturbSetting ThisMessage
        {
            get
            {
                return this;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<DisturbSetting, DisturbSetting.Builder>
        {
            private DisturbSetting result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = DisturbSetting.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(DisturbSetting cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override DisturbSetting BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override DisturbSetting.Builder Clear()
            {
                this.result = DisturbSetting.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public DisturbSetting.Builder ClearAllDaySetting()
            {
                this.PrepareBuilder();
                this.result.hasAllDaySetting = false;
                this.result.allDaySetting_ = 0;
                return this;
            }

            public DisturbSetting.Builder ClearAllDayTime()
            {
                this.PrepareBuilder();
                this.result.hasAllDayTime = false;
                this.result.allDayTime_ = null;
                return this;
            }

            public DisturbSetting.Builder ClearNightSetting()
            {
                this.PrepareBuilder();
                this.result.hasNightSetting = false;
                this.result.nightSetting_ = 0;
                return this;
            }

            public DisturbSetting.Builder ClearNightTime()
            {
                this.PrepareBuilder();
                this.result.hasNightTime = false;
                this.result.nightTime_ = null;
                return this;
            }

            public override DisturbSetting.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new DisturbSetting.Builder(this.result);
                }
                return new DisturbSetting.Builder().MergeFrom(this.result);
            }

            public DisturbSetting.Builder MergeAllDayTime(DisturbTimeSpan value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasAllDayTime && (this.result.allDayTime_ != DisturbTimeSpan.DefaultInstance))
                {
                    this.result.allDayTime_ = DisturbTimeSpan.CreateBuilder(this.result.allDayTime_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.allDayTime_ = value;
                }
                this.result.hasAllDayTime = true;
                return this;
            }

            public override DisturbSetting.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override DisturbSetting.Builder MergeFrom(IMessageLite other)
            {
                if (other is DisturbSetting)
                {
                    return this.MergeFrom((DisturbSetting) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override DisturbSetting.Builder MergeFrom(DisturbSetting other)
            {
                return this;
            }

            public override DisturbSetting.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(DisturbSetting._disturbSettingFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = DisturbSetting._disturbSettingFieldTags[index];
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
                            this.result.hasNightSetting = input.ReadUInt32(ref this.result.nightSetting_);
                            continue;
                        }
                        case 0x12:
                        {
                            DisturbTimeSpan.Builder builder = DisturbTimeSpan.CreateBuilder();
                            if (this.result.hasNightTime)
                            {
                                builder.MergeFrom(this.NightTime);
                            }
                            input.ReadMessage(builder, extensionRegistry);
                            this.NightTime = builder.BuildPartial();
                            continue;
                        }
                        case 0x18:
                        {
                            this.result.hasAllDaySetting = input.ReadUInt32(ref this.result.allDaySetting_);
                            continue;
                        }
                        case 0x22:
                        {
                            DisturbTimeSpan.Builder builder2 = DisturbTimeSpan.CreateBuilder();
                            if (this.result.hasAllDayTime)
                            {
                                builder2.MergeFrom(this.AllDayTime);
                            }
                            input.ReadMessage(builder2, extensionRegistry);
                            this.AllDayTime = builder2.BuildPartial();
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

            public DisturbSetting.Builder MergeNightTime(DisturbTimeSpan value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasNightTime && (this.result.nightTime_ != DisturbTimeSpan.DefaultInstance))
                {
                    this.result.nightTime_ = DisturbTimeSpan.CreateBuilder(this.result.nightTime_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.nightTime_ = value;
                }
                this.result.hasNightTime = true;
                return this;
            }

            private DisturbSetting PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    DisturbSetting result = this.result;
                    this.result = new DisturbSetting();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public DisturbSetting.Builder SetAllDaySetting(uint value)
            {
                this.PrepareBuilder();
                this.result.hasAllDaySetting = true;
                this.result.allDaySetting_ = value;
                return this;
            }

            public DisturbSetting.Builder SetAllDayTime(DisturbTimeSpan value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasAllDayTime = true;
                this.result.allDayTime_ = value;
                return this;
            }

            public DisturbSetting.Builder SetAllDayTime(DisturbTimeSpan.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasAllDayTime = true;
                this.result.allDayTime_ = builderForValue.Build();
                return this;
            }

            public DisturbSetting.Builder SetNightSetting(uint value)
            {
                this.PrepareBuilder();
                this.result.hasNightSetting = true;
                this.result.nightSetting_ = value;
                return this;
            }

            public DisturbSetting.Builder SetNightTime(DisturbTimeSpan value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasNightTime = true;
                this.result.nightTime_ = value;
                return this;
            }

            public DisturbSetting.Builder SetNightTime(DisturbTimeSpan.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasNightTime = true;
                this.result.nightTime_ = builderForValue.Build();
                return this;
            }

            public uint AllDaySetting
            {
                get
                {
                    return this.result.AllDaySetting;
                }
                set
                {
                    this.SetAllDaySetting(value);
                }
            }

            public DisturbTimeSpan AllDayTime
            {
                get
                {
                    return this.result.AllDayTime;
                }
                set
                {
                    this.SetAllDayTime(value);
                }
            }

            public override DisturbSetting DefaultInstanceForType
            {
                get
                {
                    return DisturbSetting.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override DisturbSetting MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public uint NightSetting
            {
                get
                {
                    return this.result.NightSetting;
                }
                set
                {
                    this.SetNightSetting(value);
                }
            }

            public DisturbTimeSpan NightTime
            {
                get
                {
                    return this.result.NightTime;
                }
                set
                {
                    this.SetNightTime(value);
                }
            }

            protected override DisturbSetting.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


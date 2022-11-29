namespace micromsg
{
    using Google.ProtocolBuffers;
    
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

    
    public sealed class SafeDevice : GeneratedMessageLite<SafeDevice, SafeDevice.Builder>
    {
        private static readonly string[] _safeDeviceFieldNames = new string[] { "CreateTime", "DeviceType", "Name", "Uuid" };
        private static readonly uint[] _safeDeviceFieldTags = new uint[] { 0x20, 0x1a, 10, 0x12 };
        private uint createTime_;
        public const int CreateTimeFieldNumber = 4;
        private static readonly SafeDevice defaultInstance = new SafeDevice().MakeReadOnly();
        private string deviceType_ = "";
        public const int DeviceTypeFieldNumber = 3;
        private bool hasCreateTime;
        private bool hasDeviceType;
        private bool hasName;
        private bool hasUuid;
        private int memoizedSerializedSize = -1;
        private string name_ = "";
        public const int NameFieldNumber = 1;
        private string uuid_ = "";
        public const int UuidFieldNumber = 2;

        static SafeDevice()
        {
           // object.ReferenceEquals(SafeDevice.Descriptor, null);
        }

        private SafeDevice()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(SafeDevice prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            SafeDevice device = obj as SafeDevice;
            if (device == null)
            {
                return false;
            }
            if ((this.hasName != device.hasName) || (this.hasName && !this.name_.Equals(device.name_)))
            {
                return false;
            }
            if ((this.hasUuid != device.hasUuid) || (this.hasUuid && !this.uuid_.Equals(device.uuid_)))
            {
                return false;
            }
            if ((this.hasDeviceType != device.hasDeviceType) || (this.hasDeviceType && !this.deviceType_.Equals(device.deviceType_)))
            {
                return false;
            }
            return ((this.hasCreateTime == device.hasCreateTime) && (!this.hasCreateTime || this.createTime_.Equals(device.createTime_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasName)
            {
                hashCode ^= this.name_.GetHashCode();
            }
            if (this.hasUuid)
            {
                hashCode ^= this.uuid_.GetHashCode();
            }
            if (this.hasDeviceType)
            {
                hashCode ^= this.deviceType_.GetHashCode();
            }
            if (this.hasCreateTime)
            {
                hashCode ^= this.createTime_.GetHashCode();
            }
            return hashCode;
        }

        private SafeDevice MakeReadOnly()
        {
            return this;
        }

        public static SafeDevice ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<SafeDevice, Builder>.PrintField("Name", this.hasName, this.name_, writer);
            GeneratedMessageLite<SafeDevice, Builder>.PrintField("Uuid", this.hasUuid, this.uuid_, writer);
            GeneratedMessageLite<SafeDevice, Builder>.PrintField("DeviceType", this.hasDeviceType, this.deviceType_, writer);
            GeneratedMessageLite<SafeDevice, Builder>.PrintField("CreateTime", this.hasCreateTime, this.createTime_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _safeDeviceFieldNames;
            if (this.hasName)
            {
                output.WriteString(1, strArray[2], this.Name);
            }
            if (this.hasUuid)
            {
                output.WriteString(2, strArray[3], this.Uuid);
            }
            if (this.hasDeviceType)
            {
                output.WriteString(3, strArray[1], this.DeviceType);
            }
            if (this.hasCreateTime)
            {
                output.WriteUInt32(4, strArray[0], this.CreateTime);
            }
        }

        public uint CreateTime
        {
            get
            {
                return this.createTime_;
            }
        }

        public static SafeDevice DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override SafeDevice DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public string DeviceType
        {
            get
            {
                return this.deviceType_;
            }
        }

        public override bool IsInitialized
        {
            get
            {
                if (!this.hasCreateTime)
                {
                    return false;
                }
                return true;
            }
        }

        public string Name
        {
            get
            {
                return this.name_;
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
                    if (this.hasName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(1, this.Name);
                    }
                    if (this.hasUuid)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(2, this.Uuid);
                    }
                    if (this.hasDeviceType)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(3, this.DeviceType);
                    }
                    if (this.hasCreateTime)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(4, this.CreateTime);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override SafeDevice ThisMessage
        {
            get
            {
                return this;
            }
        }

        public string Uuid
        {
            get
            {
                return this.uuid_;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<SafeDevice, SafeDevice.Builder>
        {
            private SafeDevice result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = SafeDevice.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(SafeDevice cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override SafeDevice BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override SafeDevice.Builder Clear()
            {
                this.result = SafeDevice.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public SafeDevice.Builder ClearCreateTime()
            {
                this.PrepareBuilder();
                this.result.hasCreateTime = false;
                this.result.createTime_ = 0;
                return this;
            }

            public SafeDevice.Builder ClearDeviceType()
            {
                this.PrepareBuilder();
                this.result.hasDeviceType = false;
                this.result.deviceType_ = "";
                return this;
            }

            public SafeDevice.Builder ClearName()
            {
                this.PrepareBuilder();
                this.result.hasName = false;
                this.result.name_ = "";
                return this;
            }

            public SafeDevice.Builder ClearUuid()
            {
                this.PrepareBuilder();
                this.result.hasUuid = false;
                this.result.uuid_ = "";
                return this;
            }

            public override SafeDevice.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new SafeDevice.Builder(this.result);
                }
                return new SafeDevice.Builder().MergeFrom(this.result);
            }

            public override SafeDevice.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override SafeDevice.Builder MergeFrom(IMessageLite other)
            {
                if (other is SafeDevice)
                {
                    return this.MergeFrom((SafeDevice) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override SafeDevice.Builder MergeFrom(SafeDevice other)
            {
                return this;
            }

            public override SafeDevice.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(SafeDevice._safeDeviceFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = SafeDevice._safeDeviceFieldTags[index];
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
                            this.result.hasName = input.ReadString(ref this.result.name_);
                            continue;
                        }
                        case 0x12:
                        {
                            this.result.hasUuid = input.ReadString(ref this.result.uuid_);
                            continue;
                        }
                        case 0x1a:
                        {
                            this.result.hasDeviceType = input.ReadString(ref this.result.deviceType_);
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
                    this.result.hasCreateTime = input.ReadUInt32(ref this.result.createTime_);
                }
                return this;
            }

            private SafeDevice PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    SafeDevice result = this.result;
                    this.result = new SafeDevice();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public SafeDevice.Builder SetCreateTime(uint value)
            {
                this.PrepareBuilder();
                this.result.hasCreateTime = true;
                this.result.createTime_ = value;
                return this;
            }

            public SafeDevice.Builder SetDeviceType(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasDeviceType = true;
                this.result.deviceType_ = value;
                return this;
            }

            public SafeDevice.Builder SetName(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasName = true;
                this.result.name_ = value;
                return this;
            }

            public SafeDevice.Builder SetUuid(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasUuid = true;
                this.result.uuid_ = value;
                return this;
            }

            public uint CreateTime
            {
                get
                {
                    return this.result.CreateTime;
                }
                set
                {
                    this.SetCreateTime(value);
                }
            }

            public override SafeDevice DefaultInstanceForType
            {
                get
                {
                    return SafeDevice.DefaultInstance;
                }
            }

            public string DeviceType
            {
                get
                {
                    return this.result.DeviceType;
                }
                set
                {
                    this.SetDeviceType(value);
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override SafeDevice MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public string Name
            {
                get
                {
                    return this.result.Name;
                }
                set
                {
                    this.SetName(value);
                }
            }

            protected override SafeDevice.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }

            public string Uuid
            {
                get
                {
                    return this.result.Uuid;
                }
                set
                {
                    this.SetUuid(value);
                }
            }
        }
    }
}


namespace micromsg
{
    using Google.ProtocolBuffers;
    using Google.ProtocolBuffers.Collections;
    
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    

   // 
    public sealed class SafeDeviceList : GeneratedMessageLite<SafeDeviceList, SafeDeviceList.Builder>
    {
        private static readonly string[] _safeDeviceListFieldNames = new string[] { "Count", "List" };
        private static readonly uint[] _safeDeviceListFieldTags = new uint[] { 8, 0x12 };
        private uint count_;
        public const int CountFieldNumber = 1;
        private static readonly SafeDeviceList defaultInstance = new SafeDeviceList().MakeReadOnly();
        private bool hasCount;
        private PopsicleList<SafeDevice> list_ = new PopsicleList<SafeDevice>();
        public const int ListFieldNumber = 2;
        private int memoizedSerializedSize = -1;

        static SafeDeviceList()
        {
            //object.ReferenceEquals(SafeDeviceList.Descriptor, null);
        }

        private SafeDeviceList()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(SafeDeviceList prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            SafeDeviceList list = obj as SafeDeviceList;
            if (list == null)
            {
                return false;
            }
            if ((this.hasCount != list.hasCount) || (this.hasCount && !this.count_.Equals(list.count_)))
            {
                return false;
            }
            if (this.list_.Count != list.list_.Count)
            {
                return false;
            }
            for (int i = 0; i < this.list_.Count; i++)
            {
                if (!this.list_[i].Equals(list.list_[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasCount)
            {
                hashCode ^= this.count_.GetHashCode();
            }
            foreach (SafeDevice device in this.list_)
            {
                hashCode ^= device.GetHashCode();
            }
            return hashCode;
        }

        public SafeDevice GetList(int index)
        {
            return this.list_[index];
        }

        private SafeDeviceList MakeReadOnly()
        {
            this.list_.MakeReadOnly();
            return this;
        }

        public static SafeDeviceList ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<SafeDeviceList, Builder>.PrintField("Count", this.hasCount, this.count_, writer);
            GeneratedMessageLite<SafeDeviceList, Builder>.PrintField<SafeDevice>("List", this.list_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _safeDeviceListFieldNames;
            if (this.hasCount)
            {
                output.WriteUInt32(1, strArray[0], this.Count);
            }
            if (this.list_.Count > 0)
            {
                output.WriteMessageArray<SafeDevice>(2, strArray[1], this.list_);
            }
        }

        public uint Count
        {
            get
            {
                return this.count_;
            }
        }

        public static SafeDeviceList DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override SafeDeviceList DefaultInstanceForType
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
                if (!this.hasCount)
                {
                    return false;
                }
                foreach (SafeDevice device in this.ListList)
                {
                    if (!device.IsInitialized)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public int ListCount
        {
            get
            {
                return this.list_.Count;
            }
        }

        public IList<SafeDevice> ListList
        {
            get
            {
                return this.list_;
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
                    if (this.hasCount)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(1, this.Count);
                    }
                    foreach (SafeDevice device in this.ListList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(2, device);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override SafeDeviceList ThisMessage
        {
            get
            {
                return this;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<SafeDeviceList, SafeDeviceList.Builder>
        {
            private SafeDeviceList result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = SafeDeviceList.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(SafeDeviceList cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public SafeDeviceList.Builder AddList(SafeDevice value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.list_.Add(value);
                return this;
            }

            public SafeDeviceList.Builder AddList(SafeDevice.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.list_.Add(builderForValue.Build());
                return this;
            }

            public SafeDeviceList.Builder AddRangeList(IEnumerable<SafeDevice> values)
            {
                this.PrepareBuilder();
                this.result.list_.Add(values);
                return this;
            }

            public override SafeDeviceList BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override SafeDeviceList.Builder Clear()
            {
                this.result = SafeDeviceList.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public SafeDeviceList.Builder ClearCount()
            {
                this.PrepareBuilder();
                this.result.hasCount = false;
                this.result.count_ = 0;
                return this;
            }

            public SafeDeviceList.Builder ClearList()
            {
                this.PrepareBuilder();
                this.result.list_.Clear();
                return this;
            }

            public override SafeDeviceList.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new SafeDeviceList.Builder(this.result);
                }
                return new SafeDeviceList.Builder().MergeFrom(this.result);
            }

            public SafeDevice GetList(int index)
            {
                return this.result.GetList(index);
            }

            public override SafeDeviceList.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override SafeDeviceList.Builder MergeFrom(IMessageLite other)
            {
                if (other is SafeDeviceList)
                {
                    return this.MergeFrom((SafeDeviceList) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override SafeDeviceList.Builder MergeFrom(SafeDeviceList other)
            {
                return this;
            }

            public override SafeDeviceList.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(SafeDeviceList._safeDeviceListFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = SafeDeviceList._safeDeviceListFieldTags[index];
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
                            this.result.hasCount = input.ReadUInt32(ref this.result.count_);
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
                    input.ReadMessageArray<SafeDevice>(num, str, this.result.list_, SafeDevice.DefaultInstance, extensionRegistry);
                }
                return this;
            }

            private SafeDeviceList PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    SafeDeviceList result = this.result;
                    this.result = new SafeDeviceList();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public SafeDeviceList.Builder SetCount(uint value)
            {
                this.PrepareBuilder();
                this.result.hasCount = true;
                this.result.count_ = value;
                return this;
            }

            public SafeDeviceList.Builder SetList(int index, SafeDevice value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.list_[index] = value;
                return this;
            }

            public SafeDeviceList.Builder SetList(int index, SafeDevice.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.list_[index] = builderForValue.Build();
                return this;
            }

            public uint Count
            {
                get
                {
                    return this.result.Count;
                }
                set
                {
                    this.SetCount(value);
                }
            }

            public override SafeDeviceList DefaultInstanceForType
            {
                get
                {
                    return SafeDeviceList.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            public int ListCount
            {
                get
                {
                    return this.result.ListCount;
                }
            }

            public IPopsicleList<SafeDevice> ListList
            {
                get
                {
                    return this.PrepareBuilder().list_;
                }
            }

            protected override SafeDeviceList MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override SafeDeviceList.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


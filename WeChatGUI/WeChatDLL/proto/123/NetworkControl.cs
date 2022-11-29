namespace micromsg
{
    using Google.ProtocolBuffers;
    
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

    
    public sealed class NetworkControl : GeneratedMessageLite<NetworkControl, NetworkControl.Builder>
    {
        private static readonly string[] _networkControlFieldNames = new string[] { "PortList", "TimeoutList" };
        private static readonly uint[] _networkControlFieldTags = new uint[] { 10, 0x12 };
        private static readonly NetworkControl defaultInstance = new NetworkControl().MakeReadOnly();
        private bool hasPortList;
        private bool hasTimeoutList;
        private int memoizedSerializedSize = -1;
        private string portList_ = "";
        public const int PortListFieldNumber = 1;
        private string timeoutList_ = "";
        public const int TimeoutListFieldNumber = 2;

        static NetworkControl()
        {
           //object.ReferenceEquals(NetworkControl.Descriptor, null);
        }

        private NetworkControl()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(NetworkControl prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            NetworkControl control = obj as NetworkControl;
            if (control == null)
            {
                return false;
            }
            if ((this.hasPortList != control.hasPortList) || (this.hasPortList && !this.portList_.Equals(control.portList_)))
            {
                return false;
            }
            return ((this.hasTimeoutList == control.hasTimeoutList) && (!this.hasTimeoutList || this.timeoutList_.Equals(control.timeoutList_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasPortList)
            {
                hashCode ^= this.portList_.GetHashCode();
            }
            if (this.hasTimeoutList)
            {
                hashCode ^= this.timeoutList_.GetHashCode();
            }
            return hashCode;
        }

        private NetworkControl MakeReadOnly()
        {
            return this;
        }

        public static NetworkControl ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<NetworkControl, Builder>.PrintField("PortList", this.hasPortList, this.portList_, writer);
            GeneratedMessageLite<NetworkControl, Builder>.PrintField("TimeoutList", this.hasTimeoutList, this.timeoutList_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _networkControlFieldNames;
            if (this.hasPortList)
            {
                output.WriteString(1, strArray[0], this.PortList);
            }
            if (this.hasTimeoutList)
            {
                output.WriteString(2, strArray[1], this.TimeoutList);
            }
        }

        public static NetworkControl DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override NetworkControl DefaultInstanceForType
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

        public string PortList
        {
            get
            {
                return this.portList_;
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
                    if (this.hasPortList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(1, this.PortList);
                    }
                    if (this.hasTimeoutList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(2, this.TimeoutList);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override NetworkControl ThisMessage
        {
            get
            {
                return this;
            }
        }

        public string TimeoutList
        {
            get
            {
                return this.timeoutList_;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<NetworkControl, NetworkControl.Builder>
        {
            private NetworkControl result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = NetworkControl.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(NetworkControl cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override NetworkControl BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override NetworkControl.Builder Clear()
            {
                this.result = NetworkControl.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public NetworkControl.Builder ClearPortList()
            {
                this.PrepareBuilder();
                this.result.hasPortList = false;
                this.result.portList_ = "";
                return this;
            }

            public NetworkControl.Builder ClearTimeoutList()
            {
                this.PrepareBuilder();
                this.result.hasTimeoutList = false;
                this.result.timeoutList_ = "";
                return this;
            }

            public override NetworkControl.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new NetworkControl.Builder(this.result);
                }
                return new NetworkControl.Builder().MergeFrom(this.result);
            }

            public override NetworkControl.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override NetworkControl.Builder MergeFrom(IMessageLite other)
            {
                if (other is NetworkControl)
                {
                    return this.MergeFrom((NetworkControl) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override NetworkControl.Builder MergeFrom(NetworkControl other)
            {
                return this;
            }

            public override NetworkControl.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(NetworkControl._networkControlFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = NetworkControl._networkControlFieldTags[index];
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
                            this.result.hasPortList = input.ReadString(ref this.result.portList_);
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
                    this.result.hasTimeoutList = input.ReadString(ref this.result.timeoutList_);
                }
                return this;
            }

            private NetworkControl PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    NetworkControl result = this.result;
                    this.result = new NetworkControl();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public NetworkControl.Builder SetPortList(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasPortList = true;
                this.result.portList_ = value;
                return this;
            }

            public NetworkControl.Builder SetTimeoutList(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasTimeoutList = true;
                this.result.timeoutList_ = value;
                return this;
            }

            public override NetworkControl DefaultInstanceForType
            {
                get
                {
                    return NetworkControl.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override NetworkControl MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public string PortList
            {
                get
                {
                    return this.result.PortList;
                }
                set
                {
                    this.SetPortList(value);
                }
            }

            protected override NetworkControl.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }

            public string TimeoutList
            {
                get
                {
                    return this.result.TimeoutList;
                }
                set
                {
                    this.SetTimeoutList(value);
                }
            }
        }
    }
}


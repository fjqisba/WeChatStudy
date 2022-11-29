namespace micromsg
{
    using Google.ProtocolBuffers;
    
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

   // 
    public sealed class FunctionSwitch : GeneratedMessageLite<FunctionSwitch, FunctionSwitch.Builder>
    {
        private static readonly string[] _functionSwitchFieldNames = new string[] { "FunctionId", "SwitchValue" };
        private static readonly uint[] _functionSwitchFieldTags = new uint[] { 8, 0x10 };
        private static readonly FunctionSwitch defaultInstance = new FunctionSwitch().MakeReadOnly();
        private uint functionId_;
        public const int FunctionIdFieldNumber = 1;
        private bool hasFunctionId;
        private bool hasSwitchValue;
        private int memoizedSerializedSize = -1;
        private uint switchValue_;
        public const int SwitchValueFieldNumber = 2;

        static FunctionSwitch()
        {
            //object.ReferenceEquals(FunctionSwitch.Descriptor, null);
        }

        private FunctionSwitch()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(FunctionSwitch prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            FunctionSwitch switch2 = obj as FunctionSwitch;
            if (switch2 == null)
            {
                return false;
            }
            if ((this.hasFunctionId != switch2.hasFunctionId) || (this.hasFunctionId && !this.functionId_.Equals(switch2.functionId_)))
            {
                return false;
            }
            return ((this.hasSwitchValue == switch2.hasSwitchValue) && (!this.hasSwitchValue || this.switchValue_.Equals(switch2.switchValue_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasFunctionId)
            {
                hashCode ^= this.functionId_.GetHashCode();
            }
            if (this.hasSwitchValue)
            {
                hashCode ^= this.switchValue_.GetHashCode();
            }
            return hashCode;
        }

        private FunctionSwitch MakeReadOnly()
        {
            return this;
        }

        public static FunctionSwitch ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<FunctionSwitch, Builder>.PrintField("FunctionId", this.hasFunctionId, this.functionId_, writer);
            GeneratedMessageLite<FunctionSwitch, Builder>.PrintField("SwitchValue", this.hasSwitchValue, this.switchValue_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _functionSwitchFieldNames;
            if (this.hasFunctionId)
            {
                output.WriteUInt32(1, strArray[0], this.FunctionId);
            }
            if (this.hasSwitchValue)
            {
                output.WriteUInt32(2, strArray[1], this.SwitchValue);
            }
        }

        public static FunctionSwitch DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override FunctionSwitch DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public uint FunctionId
        {
            get
            {
                return this.functionId_;
            }
        }

        public override bool IsInitialized
        {
            get
            {
                if (!this.hasFunctionId)
                {
                    return false;
                }
                if (!this.hasSwitchValue)
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
                    if (this.hasFunctionId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(1, this.FunctionId);
                    }
                    if (this.hasSwitchValue)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(2, this.SwitchValue);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        public uint SwitchValue
        {
            get
            {
                return this.switchValue_;
            }
        }

        protected override FunctionSwitch ThisMessage
        {
            get
            {
                return this;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<FunctionSwitch, FunctionSwitch.Builder>
        {
            private FunctionSwitch result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = FunctionSwitch.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(FunctionSwitch cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override FunctionSwitch BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override FunctionSwitch.Builder Clear()
            {
                this.result = FunctionSwitch.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public FunctionSwitch.Builder ClearFunctionId()
            {
                this.PrepareBuilder();
                this.result.hasFunctionId = false;
                this.result.functionId_ = 0;
                return this;
            }

            public FunctionSwitch.Builder ClearSwitchValue()
            {
                this.PrepareBuilder();
                this.result.hasSwitchValue = false;
                this.result.switchValue_ = 0;
                return this;
            }

            public override FunctionSwitch.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new FunctionSwitch.Builder(this.result);
                }
                return new FunctionSwitch.Builder().MergeFrom(this.result);
            }

            public override FunctionSwitch.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override FunctionSwitch.Builder MergeFrom(IMessageLite other)
            {
                if (other is FunctionSwitch)
                {
                    return this.MergeFrom((FunctionSwitch) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override FunctionSwitch.Builder MergeFrom(FunctionSwitch other)
            {
                return this;
            }

            public override FunctionSwitch.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(FunctionSwitch._functionSwitchFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = FunctionSwitch._functionSwitchFieldTags[index];
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
                            this.result.hasFunctionId = input.ReadUInt32(ref this.result.functionId_);
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
                    this.result.hasSwitchValue = input.ReadUInt32(ref this.result.switchValue_);
                }
                return this;
            }

            private FunctionSwitch PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    FunctionSwitch result = this.result;
                    this.result = new FunctionSwitch();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public FunctionSwitch.Builder SetFunctionId(uint value)
            {
                this.PrepareBuilder();
                this.result.hasFunctionId = true;
                this.result.functionId_ = value;
                return this;
            }

            public FunctionSwitch.Builder SetSwitchValue(uint value)
            {
                this.PrepareBuilder();
                this.result.hasSwitchValue = true;
                this.result.switchValue_ = value;
                return this;
            }

            public override FunctionSwitch DefaultInstanceForType
            {
                get
                {
                    return FunctionSwitch.DefaultInstance;
                }
            }

            public uint FunctionId
            {
                get
                {
                    return this.result.FunctionId;
                }
                set
                {
                    this.SetFunctionId(value);
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override FunctionSwitch MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public uint SwitchValue
            {
                get
                {
                    return this.result.SwitchValue;
                }
                set
                {
                    this.SetSwitchValue(value);
                }
            }

            protected override FunctionSwitch.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


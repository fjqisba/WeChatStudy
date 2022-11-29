namespace micromsg
{
    using Google.ProtocolBuffers;
    
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

    //
    public sealed class DisturbTimeSpan : GeneratedMessageLite<DisturbTimeSpan, DisturbTimeSpan.Builder>
    {
        private static readonly string[] _disturbTimeSpanFieldNames = new string[] { "BeginTime", "EndTime" };
        private static readonly uint[] _disturbTimeSpanFieldTags = new uint[] { 8, 0x10 };
        private uint beginTime_;
        public const int BeginTimeFieldNumber = 1;
        private static readonly DisturbTimeSpan defaultInstance = new DisturbTimeSpan().MakeReadOnly();
        private uint endTime_;
        public const int EndTimeFieldNumber = 2;
        private bool hasBeginTime;
        private bool hasEndTime;
        private int memoizedSerializedSize = -1;

        static DisturbTimeSpan()
        {
            //object.ReferenceEquals(DisturbTimeSpan.Descriptor, null);
        }

        private DisturbTimeSpan()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(DisturbTimeSpan prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            DisturbTimeSpan span = obj as DisturbTimeSpan;
            if (span == null)
            {
                return false;
            }
            if ((this.hasBeginTime != span.hasBeginTime) || (this.hasBeginTime && !this.beginTime_.Equals(span.beginTime_)))
            {
                return false;
            }
            return ((this.hasEndTime == span.hasEndTime) && (!this.hasEndTime || this.endTime_.Equals(span.endTime_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasBeginTime)
            {
                hashCode ^= this.beginTime_.GetHashCode();
            }
            if (this.hasEndTime)
            {
                hashCode ^= this.endTime_.GetHashCode();
            }
            return hashCode;
        }

        private DisturbTimeSpan MakeReadOnly()
        {
            return this;
        }

        public static DisturbTimeSpan ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<DisturbTimeSpan, Builder>.PrintField("BeginTime", this.hasBeginTime, this.beginTime_, writer);
            GeneratedMessageLite<DisturbTimeSpan, Builder>.PrintField("EndTime", this.hasEndTime, this.endTime_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _disturbTimeSpanFieldNames;
            if (this.hasBeginTime)
            {
                output.WriteUInt32(1, strArray[0], this.BeginTime);
            }
            if (this.hasEndTime)
            {
                output.WriteUInt32(2, strArray[1], this.EndTime);
            }
        }

        public uint BeginTime
        {
            get
            {
                return this.beginTime_;
            }
        }

        public static DisturbTimeSpan DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override DisturbTimeSpan DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public uint EndTime
        {
            get
            {
                return this.endTime_;
            }
        }

        public override bool IsInitialized
        {
            get
            {
                if (!this.hasBeginTime)
                {
                    return false;
                }
                if (!this.hasEndTime)
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
                    if (this.hasBeginTime)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(1, this.BeginTime);
                    }
                    if (this.hasEndTime)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(2, this.EndTime);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override DisturbTimeSpan ThisMessage
        {
            get
            {
                return this;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<DisturbTimeSpan, DisturbTimeSpan.Builder>
        {
            private DisturbTimeSpan result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = DisturbTimeSpan.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(DisturbTimeSpan cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override DisturbTimeSpan BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override DisturbTimeSpan.Builder Clear()
            {
                this.result = DisturbTimeSpan.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public DisturbTimeSpan.Builder ClearBeginTime()
            {
                this.PrepareBuilder();
                this.result.hasBeginTime = false;
                this.result.beginTime_ = 0;
                return this;
            }

            public DisturbTimeSpan.Builder ClearEndTime()
            {
                this.PrepareBuilder();
                this.result.hasEndTime = false;
                this.result.endTime_ = 0;
                return this;
            }

            public override DisturbTimeSpan.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new DisturbTimeSpan.Builder(this.result);
                }
                return new DisturbTimeSpan.Builder().MergeFrom(this.result);
            }

            public override DisturbTimeSpan.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override DisturbTimeSpan.Builder MergeFrom(IMessageLite other)
            {
                if (other is DisturbTimeSpan)
                {
                    return this.MergeFrom((DisturbTimeSpan) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override DisturbTimeSpan.Builder MergeFrom(DisturbTimeSpan other)
            {
                return this;
            }

            public override DisturbTimeSpan.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(DisturbTimeSpan._disturbTimeSpanFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = DisturbTimeSpan._disturbTimeSpanFieldTags[index];
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
                            this.result.hasBeginTime = input.ReadUInt32(ref this.result.beginTime_);
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
                    this.result.hasEndTime = input.ReadUInt32(ref this.result.endTime_);
                }
                return this;
            }

            private DisturbTimeSpan PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    DisturbTimeSpan result = this.result;
                    this.result = new DisturbTimeSpan();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public DisturbTimeSpan.Builder SetBeginTime(uint value)
            {
                this.PrepareBuilder();
                this.result.hasBeginTime = true;
                this.result.beginTime_ = value;
                return this;
            }

            public DisturbTimeSpan.Builder SetEndTime(uint value)
            {
                this.PrepareBuilder();
                this.result.hasEndTime = true;
                this.result.endTime_ = value;
                return this;
            }

            public uint BeginTime
            {
                get
                {
                    return this.result.BeginTime;
                }
                set
                {
                    this.SetBeginTime(value);
                }
            }

            public override DisturbTimeSpan DefaultInstanceForType
            {
                get
                {
                    return DisturbTimeSpan.DefaultInstance;
                }
            }

            public uint EndTime
            {
                get
                {
                    return this.result.EndTime;
                }
                set
                {
                    this.SetEndTime(value);
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override DisturbTimeSpan MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override DisturbTimeSpan.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


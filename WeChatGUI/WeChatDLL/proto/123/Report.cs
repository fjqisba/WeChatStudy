namespace micromsg
{
    using Google.ProtocolBuffers;
    
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

   // 
    public sealed class Report : GeneratedMessageLite<Report, Report.Builder>
    {
        private static readonly string[] _reportFieldNames = new string[] { "Log" };
        private static readonly uint[] _reportFieldTags = new uint[] { 10 };
        private static readonly Report defaultInstance = new Report().MakeReadOnly();
        private bool hasLog;
        private string log_ = "";
        public const int LogFieldNumber = 1;
        private int memoizedSerializedSize = -1;

        static Report()
        {
            //object.ReferenceEquals(Report.Descriptor, null);
        }

        private Report()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(Report prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            Report report = obj as Report;
            if (report == null)
            {
                return false;
            }
            return ((this.hasLog == report.hasLog) && (!this.hasLog || this.log_.Equals(report.log_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasLog)
            {
                hashCode ^= this.log_.GetHashCode();
            }
            return hashCode;
        }

        private Report MakeReadOnly()
        {
            return this;
        }

        public static Report ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<Report, Builder>.PrintField("Log", this.hasLog, this.log_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _reportFieldNames;
            if (this.hasLog)
            {
                output.WriteString(1, strArray[0], this.Log);
            }
        }

        public static Report DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override Report DefaultInstanceForType
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

        public string Log
        {
            get
            {
                return this.log_;
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
                    if (this.hasLog)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(1, this.Log);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override Report ThisMessage
        {
            get
            {
                return this;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<Report, Report.Builder>
        {
            private Report result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = Report.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(Report cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override Report BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override Report.Builder Clear()
            {
                this.result = Report.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public Report.Builder ClearLog()
            {
                this.PrepareBuilder();
                this.result.hasLog = false;
                this.result.log_ = "";
                return this;
            }

            public override Report.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new Report.Builder(this.result);
                }
                return new Report.Builder().MergeFrom(this.result);
            }

            public override Report.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override Report.Builder MergeFrom(IMessageLite other)
            {
                if (other is Report)
                {
                    return this.MergeFrom((Report) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override Report.Builder MergeFrom(Report other)
            {
                return this;
            }

            public override Report.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(Report._reportFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = Report._reportFieldTags[index];
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
                    this.result.hasLog = input.ReadString(ref this.result.log_);
                }
                return this;
            }

            private Report PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    Report result = this.result;
                    this.result = new Report();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public Report.Builder SetLog(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasLog = true;
                this.result.log_ = value;
                return this;
            }

            public override Report DefaultInstanceForType
            {
                get
                {
                    return Report.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            public string Log
            {
                get
                {
                    return this.result.Log;
                }
                set
                {
                    this.SetLog(value);
                }
            }

            protected override Report MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override Report.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


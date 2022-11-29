namespace micromsg
{
    using Google.ProtocolBuffers;
    
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

   // 
    public sealed class UpdateStatOpLog : GeneratedMessageLite<UpdateStatOpLog, UpdateStatOpLog.Builder>
    {
        private static readonly string[] _updateStatOpLogFieldNames = new string[] { "OpCode" };
        private static readonly uint[] _updateStatOpLogFieldTags = new uint[] { 8 };
        private static readonly UpdateStatOpLog defaultInstance = new UpdateStatOpLog().MakeReadOnly();
        private bool hasOpCode;
        private int memoizedSerializedSize = -1;
        private uint opCode_;
        public const int OpCodeFieldNumber = 1;

        static UpdateStatOpLog()
        {
            //object.ReferenceEquals(UpdateStatOpLog.Descriptor, null);
        }

        private UpdateStatOpLog()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(UpdateStatOpLog prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            UpdateStatOpLog log = obj as UpdateStatOpLog;
            if (log == null)
            {
                return false;
            }
            return ((this.hasOpCode == log.hasOpCode) && (!this.hasOpCode || this.opCode_.Equals(log.opCode_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasOpCode)
            {
                hashCode ^= this.opCode_.GetHashCode();
            }
            return hashCode;
        }

        private UpdateStatOpLog MakeReadOnly()
        {
            return this;
        }

        public static UpdateStatOpLog ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<UpdateStatOpLog, Builder>.PrintField("OpCode", this.hasOpCode, this.opCode_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _updateStatOpLogFieldNames;
            if (this.hasOpCode)
            {
                output.WriteUInt32(1, strArray[0], this.OpCode);
            }
        }

        public static UpdateStatOpLog DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override UpdateStatOpLog DefaultInstanceForType
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
                if (!this.hasOpCode)
                {
                    return false;
                }
                return true;
            }
        }

        public uint OpCode
        {
            get
            {
                return this.opCode_;
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
                    if (this.hasOpCode)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(1, this.OpCode);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override UpdateStatOpLog ThisMessage
        {
            get
            {
                return this;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<UpdateStatOpLog, UpdateStatOpLog.Builder>
        {
            private UpdateStatOpLog result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = UpdateStatOpLog.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(UpdateStatOpLog cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override UpdateStatOpLog BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override UpdateStatOpLog.Builder Clear()
            {
                this.result = UpdateStatOpLog.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public UpdateStatOpLog.Builder ClearOpCode()
            {
                this.PrepareBuilder();
                this.result.hasOpCode = false;
                this.result.opCode_ = 0;
                return this;
            }

            public override UpdateStatOpLog.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new UpdateStatOpLog.Builder(this.result);
                }
                return new UpdateStatOpLog.Builder().MergeFrom(this.result);
            }

            public override UpdateStatOpLog.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override UpdateStatOpLog.Builder MergeFrom(IMessageLite other)
            {
                if (other is UpdateStatOpLog)
                {
                    return this.MergeFrom((UpdateStatOpLog) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override UpdateStatOpLog.Builder MergeFrom(UpdateStatOpLog other)
            {
                return this;
            }

            public override UpdateStatOpLog.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(UpdateStatOpLog._updateStatOpLogFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = UpdateStatOpLog._updateStatOpLogFieldTags[index];
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
                    this.result.hasOpCode = input.ReadUInt32(ref this.result.opCode_);
                }
                return this;
            }

            private UpdateStatOpLog PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    UpdateStatOpLog result = this.result;
                    this.result = new UpdateStatOpLog();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public UpdateStatOpLog.Builder SetOpCode(uint value)
            {
                this.PrepareBuilder();
                this.result.hasOpCode = true;
                this.result.opCode_ = value;
                return this;
            }

            public override UpdateStatOpLog DefaultInstanceForType
            {
                get
                {
                    return UpdateStatOpLog.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override UpdateStatOpLog MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public uint OpCode
            {
                get
                {
                    return this.result.OpCode;
                }
                set
                {
                    this.SetOpCode(value);
                }
            }

            protected override UpdateStatOpLog.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


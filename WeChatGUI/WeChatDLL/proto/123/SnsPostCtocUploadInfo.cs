namespace micromsg
{
    using Google.ProtocolBuffers;
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    using System.Runtime.CompilerServices;

    public sealed class SnsPostCtocUploadInfo : GeneratedMessageLite<SnsPostCtocUploadInfo, SnsPostCtocUploadInfo.Builder>
    {
        private static readonly string[] _snsPostCtocUploadInfoFieldNames = new string[] { "Flag", "PhotoCount" };
        private static readonly uint[] _snsPostCtocUploadInfoFieldTags = new uint[] { 8, 0x10 };
        private static readonly SnsPostCtocUploadInfo defaultInstance = new SnsPostCtocUploadInfo().MakeReadOnly();
        private uint flag_;
        public const int FlagFieldNumber = 1;
        private bool hasFlag;
        private bool hasPhotoCount;
        private int memoizedSerializedSize = -1;
        private uint photoCount_;
        public const int PhotoCountFieldNumber = 2;

        static SnsPostCtocUploadInfo()
        {
           
        }

        private SnsPostCtocUploadInfo()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(SnsPostCtocUploadInfo prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            SnsPostCtocUploadInfo info = obj as SnsPostCtocUploadInfo;
            if (info == null)
            {
                return false;
            }
            if ((this.hasFlag != info.hasFlag) || (this.hasFlag && !this.flag_.Equals(info.flag_)))
            {
                return false;
            }
            return ((this.hasPhotoCount == info.hasPhotoCount) && (!this.hasPhotoCount || this.photoCount_.Equals(info.photoCount_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasFlag)
            {
                hashCode ^= this.flag_.GetHashCode();
            }
            if (this.hasPhotoCount)
            {
                hashCode ^= this.photoCount_.GetHashCode();
            }
            return hashCode;
        }

        private SnsPostCtocUploadInfo MakeReadOnly()
        {
            return this;
        }

        public static SnsPostCtocUploadInfo ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<SnsPostCtocUploadInfo, Builder>.PrintField("Flag", this.hasFlag, this.flag_, writer);
            GeneratedMessageLite<SnsPostCtocUploadInfo, Builder>.PrintField("PhotoCount", this.hasPhotoCount, this.photoCount_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _snsPostCtocUploadInfoFieldNames;
            if (this.hasFlag)
            {
                output.WriteUInt32(1, strArray[0], this.Flag);
            }
            if (this.hasPhotoCount)
            {
                output.WriteUInt32(2, strArray[1], this.PhotoCount);
            }
        }

        public static SnsPostCtocUploadInfo DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override SnsPostCtocUploadInfo DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public uint Flag
        {
            get
            {
                return this.flag_;
            }
        }

        public override bool IsInitialized
        {
            get
            {
                if (!this.hasFlag)
                {
                    return false;
                }
                if (!this.hasPhotoCount)
                {
                    return false;
                }
                return true;
            }
        }

        public uint PhotoCount
        {
            get
            {
                return this.photoCount_;
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
                    if (this.hasFlag)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(1, this.Flag);
                    }
                    if (this.hasPhotoCount)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(2, this.PhotoCount);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override SnsPostCtocUploadInfo ThisMessage
        {
            get
            {
                return this;
            }
        }

        [GeneratedCode("ProtoGen", "2.3.0.277"), DebuggerNonUserCode, CompilerGenerated]
        public sealed class Builder : GeneratedBuilderLite<SnsPostCtocUploadInfo, SnsPostCtocUploadInfo.Builder>
        {
            private SnsPostCtocUploadInfo result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = SnsPostCtocUploadInfo.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(SnsPostCtocUploadInfo cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override SnsPostCtocUploadInfo BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override SnsPostCtocUploadInfo.Builder Clear()
            {
                this.result = SnsPostCtocUploadInfo.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public SnsPostCtocUploadInfo.Builder ClearFlag()
            {
                this.PrepareBuilder();
                this.result.hasFlag = false;
                this.result.flag_ = 0;
                return this;
            }

            public SnsPostCtocUploadInfo.Builder ClearPhotoCount()
            {
                this.PrepareBuilder();
                this.result.hasPhotoCount = false;
                this.result.photoCount_ = 0;
                return this;
            }

            public override SnsPostCtocUploadInfo.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new SnsPostCtocUploadInfo.Builder(this.result);
                }
                return new SnsPostCtocUploadInfo.Builder().MergeFrom(this.result);
            }

            public override SnsPostCtocUploadInfo.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override SnsPostCtocUploadInfo.Builder MergeFrom(IMessageLite other)
            {
                if (other is SnsPostCtocUploadInfo)
                {
                    return this.MergeFrom((SnsPostCtocUploadInfo) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override SnsPostCtocUploadInfo.Builder MergeFrom(SnsPostCtocUploadInfo other)
            {
                return this;
            }

            public override SnsPostCtocUploadInfo.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(SnsPostCtocUploadInfo._snsPostCtocUploadInfoFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = SnsPostCtocUploadInfo._snsPostCtocUploadInfoFieldTags[index];
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
                            this.result.hasFlag = input.ReadUInt32(ref this.result.flag_);
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
                    this.result.hasPhotoCount = input.ReadUInt32(ref this.result.photoCount_);
                }
                return this;
            }

            private SnsPostCtocUploadInfo PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    SnsPostCtocUploadInfo result = this.result;
                    this.result = new SnsPostCtocUploadInfo();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public SnsPostCtocUploadInfo.Builder SetFlag(uint value)
            {
                this.PrepareBuilder();
                this.result.hasFlag = true;
                this.result.flag_ = value;
                return this;
            }

            public SnsPostCtocUploadInfo.Builder SetPhotoCount(uint value)
            {
                this.PrepareBuilder();
                this.result.hasPhotoCount = true;
                this.result.photoCount_ = value;
                return this;
            }

            public override SnsPostCtocUploadInfo DefaultInstanceForType
            {
                get
                {
                    return SnsPostCtocUploadInfo.DefaultInstance;
                }
            }

            public uint Flag
            {
                get
                {
                    return this.result.Flag;
                }
                set
                {
                    this.SetFlag(value);
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override SnsPostCtocUploadInfo MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public uint PhotoCount
            {
                get
                {
                    return this.result.PhotoCount;
                }
                set
                {
                    this.SetPhotoCount(value);
                }
            }

            protected override SnsPostCtocUploadInfo.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}

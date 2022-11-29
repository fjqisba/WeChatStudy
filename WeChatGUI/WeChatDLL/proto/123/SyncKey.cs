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
    public sealed class SyncKey : GeneratedMessageLite<SyncKey, SyncKey.Builder>
    {
        private static readonly string[] _syncKeyFieldNames = new string[] { "Key", "KeyNum" };
        private static readonly uint[] _syncKeyFieldTags = new uint[] { 0x12, 8 };
        private static readonly SyncKey defaultInstance = new SyncKey().MakeReadOnly();
        private bool hasKeyNum;
        private PopsicleList<KeyVal> key_ = new PopsicleList<KeyVal>();
        public const int KeyFieldNumber = 2;
        private uint keyNum_;
        public const int KeyNumFieldNumber = 1;
        private int memoizedSerializedSize = -1;

        static SyncKey()
        {
            //object.ReferenceEquals(SyncKey.Descriptor, null);
        }

        private SyncKey()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(SyncKey prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            SyncKey key = obj as SyncKey;
            if (key == null)
            {
                return false;
            }
            if ((this.hasKeyNum != key.hasKeyNum) || (this.hasKeyNum && !this.keyNum_.Equals(key.keyNum_)))
            {
                return false;
            }
            if (this.key_.Count != key.key_.Count)
            {
                return false;
            }
            for (int i = 0; i < this.key_.Count; i++)
            {
                if (!this.key_[i].Equals(key.key_[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasKeyNum)
            {
                hashCode ^= this.keyNum_.GetHashCode();
            }
            foreach (KeyVal val in this.key_)
            {
                hashCode ^= val.GetHashCode();
            }
            return hashCode;
        }

        public KeyVal GetKey(int index)
        {
            return this.key_[index];
        }

        private SyncKey MakeReadOnly()
        {
            this.key_.MakeReadOnly();
            return this;
        }

        public static SyncKey ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<SyncKey, Builder>.PrintField("KeyNum", this.hasKeyNum, this.keyNum_, writer);
            GeneratedMessageLite<SyncKey, Builder>.PrintField<KeyVal>("Key", this.key_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _syncKeyFieldNames;
            if (this.hasKeyNum)
            {
                output.WriteUInt32(1, strArray[1], this.KeyNum);
            }
            if (this.key_.Count > 0)
            {
                output.WriteMessageArray<KeyVal>(2, strArray[0], this.key_);
            }
        }

        public static SyncKey DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override SyncKey DefaultInstanceForType
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
                if (!this.hasKeyNum)
                {
                    return false;
                }
                foreach (KeyVal val in this.KeyList)
                {
                    if (!val.IsInitialized)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public int KeyCount
        {
            get
            {
                return this.key_.Count;
            }
        }

        public IList<KeyVal> KeyList
        {
            get
            {
                return this.key_;
            }
        }

        public uint KeyNum
        {
            get
            {
                return this.keyNum_;
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
                    if (this.hasKeyNum)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(1, this.KeyNum);
                    }
                    foreach (KeyVal val in this.KeyList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(2, val);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override SyncKey ThisMessage
        {
            get
            {
                return this;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<SyncKey, SyncKey.Builder>
        {
            private SyncKey result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = SyncKey.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(SyncKey cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public SyncKey.Builder AddKey(KeyVal value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.key_.Add(value);
                return this;
            }

            public SyncKey.Builder AddKey(KeyVal.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.key_.Add(builderForValue.Build());
                return this;
            }

            public SyncKey.Builder AddRangeKey(IEnumerable<KeyVal> values)
            {
                this.PrepareBuilder();
                this.result.key_.Add(values);
                return this;
            }

            public override SyncKey BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override SyncKey.Builder Clear()
            {
                this.result = SyncKey.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public SyncKey.Builder ClearKey()
            {
                this.PrepareBuilder();
                this.result.key_.Clear();
                return this;
            }

            public SyncKey.Builder ClearKeyNum()
            {
                this.PrepareBuilder();
                this.result.hasKeyNum = false;
                this.result.keyNum_ = 0;
                return this;
            }

            public override SyncKey.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new SyncKey.Builder(this.result);
                }
                return new SyncKey.Builder().MergeFrom(this.result);
            }

            public KeyVal GetKey(int index)
            {
                return this.result.GetKey(index);
            }

            public override SyncKey.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override SyncKey.Builder MergeFrom(IMessageLite other)
            {
                if (other is SyncKey)
                {
                    return this.MergeFrom((SyncKey) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override SyncKey.Builder MergeFrom(SyncKey other)
            {
                return this;
            }

            public override SyncKey.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(SyncKey._syncKeyFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = SyncKey._syncKeyFieldTags[index];
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
                            this.result.hasKeyNum = input.ReadUInt32(ref this.result.keyNum_);
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
                    input.ReadMessageArray<KeyVal>(num, str, this.result.key_, KeyVal.DefaultInstance, extensionRegistry);
                }
                return this;
            }

            private SyncKey PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    SyncKey result = this.result;
                    this.result = new SyncKey();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public SyncKey.Builder SetKey(int index, KeyVal value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.key_[index] = value;
                return this;
            }

            public SyncKey.Builder SetKey(int index, KeyVal.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.key_[index] = builderForValue.Build();
                return this;
            }

            public SyncKey.Builder SetKeyNum(uint value)
            {
                this.PrepareBuilder();
                this.result.hasKeyNum = true;
                this.result.keyNum_ = value;
                return this;
            }

            public override SyncKey DefaultInstanceForType
            {
                get
                {
                    return SyncKey.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            public int KeyCount
            {
                get
                {
                    return this.result.KeyCount;
                }
            }

            public IPopsicleList<KeyVal> KeyList
            {
                get
                {
                    return this.PrepareBuilder().key_;
                }
            }

            public uint KeyNum
            {
                get
                {
                    return this.result.KeyNum;
                }
                set
                {
                    this.SetKeyNum(value);
                }
            }

            protected override SyncKey MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override SyncKey.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


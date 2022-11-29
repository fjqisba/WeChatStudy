namespace micromsg
{
    using Google.ProtocolBuffers;
    using Google.ProtocolBuffers.Collections;

    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Runtime.CompilerServices;

    public sealed class ShowStyleKey : GeneratedMessageLite<ShowStyleKey, ShowStyleKey.Builder>
    {
        private static readonly string[] _showStyleKeyFieldNames = new string[] { "Key", "KeyCount" };
        private static readonly uint[] _showStyleKeyFieldTags = new uint[] { 0x12, 8 };
        private static readonly ShowStyleKey defaultInstance = new ShowStyleKey().MakeReadOnly();
        private bool hasKeyCount;
        private PopsicleList<StyleKeyVal> key_ = new PopsicleList<StyleKeyVal>();
        private uint keyCount_;
        public const int KeyCountFieldNumber = 1;
        public const int KeyFieldNumber = 2;
        private int memoizedSerializedSize = -1;

        static ShowStyleKey()
        {

        }

        private ShowStyleKey()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(ShowStyleKey prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            ShowStyleKey key = obj as ShowStyleKey;
            if (key == null)
            {
                return false;
            }
            if ((this.hasKeyCount != key.hasKeyCount) || (this.hasKeyCount && !this.keyCount_.Equals(key.keyCount_)))
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
            if (this.hasKeyCount)
            {
                hashCode ^= this.keyCount_.GetHashCode();
            }
            foreach (StyleKeyVal val in this.key_)
            {
                hashCode ^= val.GetHashCode();
            }
            return hashCode;
        }

        public StyleKeyVal GetKey(int index)
        {
            return this.key_[index];
        }

        private ShowStyleKey MakeReadOnly()
        {
            this.key_.MakeReadOnly();
            return this;
        }

        public static ShowStyleKey ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<ShowStyleKey, Builder>.PrintField("KeyCount", this.hasKeyCount, this.keyCount_, writer);
            GeneratedMessageLite<ShowStyleKey, Builder>.PrintField<StyleKeyVal>("Key", this.key_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _showStyleKeyFieldNames;
            if (this.hasKeyCount)
            {
                output.WriteUInt32(1, strArray[1], this.KeyCount);
            }
            if (this.key_.Count > 0)
            {
                output.WriteMessageArray<StyleKeyVal>(2, strArray[0], this.key_);
            }
        }

        public static ShowStyleKey DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override ShowStyleKey DefaultInstanceForType
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
                if (!this.hasKeyCount)
                {
                    return false;
                }
                foreach (StyleKeyVal val in this.KeyList)
                {
                    if (!val.IsInitialized)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public uint KeyCount
        {
            get
            {
                return this.keyCount_;
            }
        }

        public IList<StyleKeyVal> KeyList
        {
            get
            {
                return this.key_;
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
                    if (this.hasKeyCount)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(1, this.KeyCount);
                    }
                    foreach (StyleKeyVal val in this.KeyList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(2, val);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override ShowStyleKey ThisMessage
        {
            get
            {
                return this;
            }
        }

        [GeneratedCode("ProtoGen", "2.3.0.277"), CompilerGenerated, DebuggerNonUserCode]
        public sealed class Builder : GeneratedBuilderLite<ShowStyleKey, ShowStyleKey.Builder>
        {
            private ShowStyleKey result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = ShowStyleKey.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(ShowStyleKey cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public ShowStyleKey.Builder AddKey(StyleKeyVal value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.key_.Add(value);
                return this;
            }

            public ShowStyleKey.Builder AddKey(StyleKeyVal.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.key_.Add(builderForValue.Build());
                return this;
            }

            public ShowStyleKey.Builder AddRangeKey(IEnumerable<StyleKeyVal> values)
            {
                this.PrepareBuilder();
                this.result.key_.Add(values);
                return this;
            }

            public override ShowStyleKey BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override ShowStyleKey.Builder Clear()
            {
                this.result = ShowStyleKey.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public ShowStyleKey.Builder ClearKey()
            {
                this.PrepareBuilder();
                this.result.key_.Clear();
                return this;
            }

            public ShowStyleKey.Builder ClearKeyCount()
            {
                this.PrepareBuilder();
                this.result.hasKeyCount = false;
                this.result.keyCount_ = 0;
                return this;
            }

            public override ShowStyleKey.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new ShowStyleKey.Builder(this.result);
                }
                return new ShowStyleKey.Builder().MergeFrom(this.result);
            }

            public StyleKeyVal GetKey(int index)
            {
                return this.result.GetKey(index);
            }

            public override ShowStyleKey.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override ShowStyleKey.Builder MergeFrom(IMessageLite other)
            {
                if (other is ShowStyleKey)
                {
                    return this.MergeFrom((ShowStyleKey) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override ShowStyleKey.Builder MergeFrom(ShowStyleKey other)
            {
                return this;
            }

            public override ShowStyleKey.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(ShowStyleKey._showStyleKeyFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = ShowStyleKey._showStyleKeyFieldTags[index];
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
                            this.result.hasKeyCount = input.ReadUInt32(ref this.result.keyCount_);
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
                    input.ReadMessageArray<StyleKeyVal>(num, str, this.result.key_, StyleKeyVal.DefaultInstance, extensionRegistry);
                }
                return this;
            }

            private ShowStyleKey PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    ShowStyleKey result = this.result;
                    this.result = new ShowStyleKey();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public ShowStyleKey.Builder SetKey(int index, StyleKeyVal value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.key_[index] = value;
                return this;
            }

            public ShowStyleKey.Builder SetKey(int index, StyleKeyVal.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.key_[index] = builderForValue.Build();
                return this;
            }

            public ShowStyleKey.Builder SetKeyCount(uint value)
            {
                this.PrepareBuilder();
                this.result.hasKeyCount = true;
                this.result.keyCount_ = value;
                return this;
            }

            public override ShowStyleKey DefaultInstanceForType
            {
                get
                {
                    return ShowStyleKey.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            public uint KeyCount
            {
                get
                {
                    return this.result.KeyCount;
                }
                set
                {
                    this.SetKeyCount(value);
                }
            }

            public IPopsicleList<StyleKeyVal> KeyList
            {
                get
                {
                    return this.PrepareBuilder().key_;
                }
            }

            protected override ShowStyleKey MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override ShowStyleKey.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}

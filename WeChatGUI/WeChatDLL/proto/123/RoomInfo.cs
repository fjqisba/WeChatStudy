namespace micromsg
{
    using Google.ProtocolBuffers;
   
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

    //
    public sealed class RoomInfo : GeneratedMessageLite<RoomInfo, RoomInfo.Builder>
    {
        private static readonly string[] _roomInfoFieldNames = new string[] { "NickName", "UserName" };
        private static readonly uint[] _roomInfoFieldTags = new uint[] { 0x12, 10 };
        private static readonly RoomInfo defaultInstance = new RoomInfo().MakeReadOnly();
        private bool hasNickName;
        private bool hasUserName;
        private int memoizedSerializedSize = -1;
        private SKBuiltinString_t nickName_;
        public const int NickNameFieldNumber = 2;
        private SKBuiltinString_t userName_;
        public const int UserNameFieldNumber = 1;

        static RoomInfo()
        {
            //object.ReferenceEquals(RoomInfo.Descriptor, null);
        }

        private RoomInfo()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(RoomInfo prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            RoomInfo info = obj as RoomInfo;
            if (info == null)
            {
                return false;
            }
            if ((this.hasUserName != info.hasUserName) || (this.hasUserName && !this.userName_.Equals(info.userName_)))
            {
                return false;
            }
            return ((this.hasNickName == info.hasNickName) && (!this.hasNickName || this.nickName_.Equals(info.nickName_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasUserName)
            {
                hashCode ^= this.userName_.GetHashCode();
            }
            if (this.hasNickName)
            {
                hashCode ^= this.nickName_.GetHashCode();
            }
            return hashCode;
        }

        private RoomInfo MakeReadOnly()
        {
            return this;
        }

        public static RoomInfo ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<RoomInfo, Builder>.PrintField("UserName", this.hasUserName, this.userName_, writer);
            GeneratedMessageLite<RoomInfo, Builder>.PrintField("NickName", this.hasNickName, this.nickName_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _roomInfoFieldNames;
            if (this.hasUserName)
            {
                output.WriteMessage(1, strArray[1], this.UserName);
            }
            if (this.hasNickName)
            {
                output.WriteMessage(2, strArray[0], this.NickName);
            }
        }

        public static RoomInfo DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override RoomInfo DefaultInstanceForType
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
                if (!this.hasUserName)
                {
                    return false;
                }
                if (!this.hasNickName)
                {
                    return false;
                }
                return true;
            }
        }

        public SKBuiltinString_t NickName
        {
            get
            {
                return (this.nickName_ ?? SKBuiltinString_t.DefaultInstance);
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
                    if (this.hasUserName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(1, this.UserName);
                    }
                    if (this.hasNickName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(2, this.NickName);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override RoomInfo ThisMessage
        {
            get
            {
                return this;
            }
        }

        public SKBuiltinString_t UserName
        {
            get
            {
                return (this.userName_ ?? SKBuiltinString_t.DefaultInstance);
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<RoomInfo, RoomInfo.Builder>
        {
            private RoomInfo result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = RoomInfo.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(RoomInfo cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override RoomInfo BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override RoomInfo.Builder Clear()
            {
                this.result = RoomInfo.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public RoomInfo.Builder ClearNickName()
            {
                this.PrepareBuilder();
                this.result.hasNickName = false;
                this.result.nickName_ = null;
                return this;
            }

            public RoomInfo.Builder ClearUserName()
            {
                this.PrepareBuilder();
                this.result.hasUserName = false;
                this.result.userName_ = null;
                return this;
            }

            public override RoomInfo.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new RoomInfo.Builder(this.result);
                }
                return new RoomInfo.Builder().MergeFrom(this.result);
            }

            public override RoomInfo.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override RoomInfo.Builder MergeFrom(IMessageLite other)
            {
                if (other is RoomInfo)
                {
                    return this.MergeFrom((RoomInfo) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override RoomInfo.Builder MergeFrom(RoomInfo other)
            {
                return this;
            }

            public override RoomInfo.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(RoomInfo._roomInfoFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = RoomInfo._roomInfoFieldTags[index];
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
                            SKBuiltinString_t.Builder builder = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasUserName)
                            {
                                builder.MergeFrom(this.UserName);
                            }
                            input.ReadMessage(builder, extensionRegistry);
                            this.UserName = builder.BuildPartial();
                            continue;
                        }
                        case 0x12:
                        {
                            SKBuiltinString_t.Builder builder2 = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasNickName)
                            {
                                builder2.MergeFrom(this.NickName);
                            }
                            input.ReadMessage(builder2, extensionRegistry);
                            this.NickName = builder2.BuildPartial();
                            continue;
                        }
                    }
                    if (WireFormat.IsEndGroupTag(num))
                    {
                        return this;
                    }
                    this.ParseUnknownField(input, extensionRegistry, num, str);
                }
                return this;
            }

            public RoomInfo.Builder MergeNickName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasNickName && (this.result.nickName_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.nickName_ = SKBuiltinString_t.CreateBuilder(this.result.nickName_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.nickName_ = value;
                }
                this.result.hasNickName = true;
                return this;
            }

            public RoomInfo.Builder MergeUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasUserName && (this.result.userName_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.userName_ = SKBuiltinString_t.CreateBuilder(this.result.userName_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.userName_ = value;
                }
                this.result.hasUserName = true;
                return this;
            }

            private RoomInfo PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    RoomInfo result = this.result;
                    this.result = new RoomInfo();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public RoomInfo.Builder SetNickName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasNickName = true;
                this.result.nickName_ = value;
                return this;
            }

            public RoomInfo.Builder SetNickName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasNickName = true;
                this.result.nickName_ = builderForValue.Build();
                return this;
            }

            public RoomInfo.Builder SetUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasUserName = true;
                this.result.userName_ = value;
                return this;
            }

            public RoomInfo.Builder SetUserName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasUserName = true;
                this.result.userName_ = builderForValue.Build();
                return this;
            }

            public override RoomInfo DefaultInstanceForType
            {
                get
                {
                    return RoomInfo.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override RoomInfo MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public SKBuiltinString_t NickName
            {
                get
                {
                    return this.result.NickName;
                }
                set
                {
                    this.SetNickName(value);
                }
            }

            protected override RoomInfo.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }

            public SKBuiltinString_t UserName
            {
                get
                {
                    return this.result.UserName;
                }
                set
                {
                    this.SetUserName(value);
                }
            }
        }
    }
}


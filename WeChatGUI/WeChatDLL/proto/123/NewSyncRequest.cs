namespace micromsg
{
    using Google.ProtocolBuffers;

    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    using System.Runtime.CompilerServices;

    public sealed class NewSyncRequest : GeneratedMessageLite<NewSyncRequest, NewSyncRequest.Builder>
    {
        private static readonly string[] _newSyncRequestFieldNames = new string[] { "DeviceType", "KeyBuf", "Oplog", "Scene", "Selector" };
        private static readonly uint[] _newSyncRequestFieldTags = new uint[] { 0x2a, 0x1a, 10, 0x20, 0x10 };
        private static readonly NewSyncRequest defaultInstance = new NewSyncRequest().MakeReadOnly();
        private ByteString deviceType_ = ByteString.Empty;
        public const int DeviceTypeFieldNumber = 5;
        private bool hasDeviceType;
        private bool hasKeyBuf;
        private bool hasOplog;
        private bool hasScene;
        private bool hasSelector;
        private SKBuiltinBuffer_t keyBuf_;
        public const int KeyBufFieldNumber = 3;
        private int memoizedSerializedSize = -1;
        private CmdList oplog_;
        public const int OplogFieldNumber = 1;
        private uint scene_;
        public const int SceneFieldNumber = 4;
        private uint selector_;
        public const int SelectorFieldNumber = 2;

        static NewSyncRequest()
        {

        }

        private NewSyncRequest()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(NewSyncRequest prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            NewSyncRequest request = obj as NewSyncRequest;
            if (request == null)
            {
                return false;
            }
            if ((this.hasOplog != request.hasOplog) || (this.hasOplog && !this.oplog_.Equals(request.oplog_)))
            {
                return false;
            }
            if ((this.hasSelector != request.hasSelector) || (this.hasSelector && !this.selector_.Equals(request.selector_)))
            {
                return false;
            }
            if ((this.hasKeyBuf != request.hasKeyBuf) || (this.hasKeyBuf && !this.keyBuf_.Equals(request.keyBuf_)))
            {
                return false;
            }
            if ((this.hasScene != request.hasScene) || (this.hasScene && !this.scene_.Equals(request.scene_)))
            {
                return false;
            }
            return ((this.hasDeviceType == request.hasDeviceType) && (!this.hasDeviceType || this.deviceType_.Equals(request.deviceType_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasOplog)
            {
                hashCode ^= this.oplog_.GetHashCode();
            }
            if (this.hasSelector)
            {
                hashCode ^= this.selector_.GetHashCode();
            }
            if (this.hasKeyBuf)
            {
                hashCode ^= this.keyBuf_.GetHashCode();
            }
            if (this.hasScene)
            {
                hashCode ^= this.scene_.GetHashCode();
            }
            if (this.hasDeviceType)
            {
                hashCode ^= this.deviceType_.GetHashCode();
            }
            return hashCode;
        }

        private NewSyncRequest MakeReadOnly()
        {
            return this;
        }

        public static NewSyncRequest ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<NewSyncRequest, Builder>.PrintField("Oplog", this.hasOplog, this.oplog_, writer);
            GeneratedMessageLite<NewSyncRequest, Builder>.PrintField("Selector", this.hasSelector, this.selector_, writer);
            GeneratedMessageLite<NewSyncRequest, Builder>.PrintField("KeyBuf", this.hasKeyBuf, this.keyBuf_, writer);
            GeneratedMessageLite<NewSyncRequest, Builder>.PrintField("Scene", this.hasScene, this.scene_, writer);
            GeneratedMessageLite<NewSyncRequest, Builder>.PrintField("DeviceType", this.hasDeviceType, this.deviceType_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _newSyncRequestFieldNames;
            if (this.hasOplog)
            {
                output.WriteMessage(1, strArray[2], this.Oplog);
            }
            if (this.hasSelector)
            {
                output.WriteUInt32(2, strArray[4], this.Selector);
            }
            if (this.hasKeyBuf)
            {
                output.WriteMessage(3, strArray[1], this.KeyBuf);
            }
            if (this.hasScene)
            {
                output.WriteUInt32(4, strArray[3], this.Scene);
            }
            if (this.hasDeviceType)
            {
                //output.WriteString(5, strArray[0], this.DeviceType);
                output.WriteBytes(5, strArray[0], this.DeviceType);
            }
        }

        public static NewSyncRequest DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override NewSyncRequest DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public ByteString DeviceType
        {
            get
            {
                return this.deviceType_;
            }
        }

        public override bool IsInitialized
        {
            get
            {
                if (!this.hasOplog)
                {
                    return false;
                }
                if (!this.hasSelector)
                {
                    return false;
                }
                if (!this.hasKeyBuf)
                {
                    return false;
                }
                if (!this.Oplog.IsInitialized)
                {
                    return false;
                }
                if (!this.KeyBuf.IsInitialized)
                {
                    return false;
                }
                return true;
            }
        }

        public SKBuiltinBuffer_t KeyBuf
        {
            get
            {
                return (this.keyBuf_ ?? SKBuiltinBuffer_t.DefaultInstance);
            }
        }

        public CmdList Oplog
        {
            get
            {
                return (this.oplog_ ?? CmdList.DefaultInstance);
            }
        }

        public uint Scene
        {
            get
            {
                return this.scene_;
            }
        }

        public uint Selector
        {
            get
            {
                return this.selector_;
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
                    if (this.hasOplog)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(1, this.Oplog);
                    }
                    if (this.hasSelector)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(2, this.Selector);
                    }
                    if (this.hasKeyBuf)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(3, this.KeyBuf);
                    }
                    if (this.hasScene)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(4, this.Scene);
                    }
                    if (this.hasDeviceType)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeBytesSize(5, this.DeviceType);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override NewSyncRequest ThisMessage
        {
            get
            {
                return this;
            }
        }

        [DebuggerNonUserCode, CompilerGenerated, GeneratedCode("ProtoGen", "2.3.0.277")]
        public sealed class Builder : GeneratedBuilderLite<NewSyncRequest, NewSyncRequest.Builder>
        {
            private NewSyncRequest result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = NewSyncRequest.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(NewSyncRequest cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override NewSyncRequest BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override NewSyncRequest.Builder Clear()
            {
                this.result = NewSyncRequest.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public NewSyncRequest.Builder ClearDeviceType()
            {
                this.PrepareBuilder();
                this.result.hasDeviceType = false;
                this.result.deviceType_ = ByteString.Empty;
                return this;
            }

            public NewSyncRequest.Builder ClearKeyBuf()
            {
                this.PrepareBuilder();
                this.result.hasKeyBuf = false;
                this.result.keyBuf_ = null;
                return this;
            }

            public NewSyncRequest.Builder ClearOplog()
            {
                this.PrepareBuilder();
                this.result.hasOplog = false;
                this.result.oplog_ = null;
                return this;
            }

            public NewSyncRequest.Builder ClearScene()
            {
                this.PrepareBuilder();
                this.result.hasScene = false;
                this.result.scene_ = 0;
                return this;
            }

            public NewSyncRequest.Builder ClearSelector()
            {
                this.PrepareBuilder();
                this.result.hasSelector = false;
                this.result.selector_ = 0;
                return this;
            }

            public override NewSyncRequest.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new NewSyncRequest.Builder(this.result);
                }
                return new NewSyncRequest.Builder().MergeFrom(this.result);
            }

            public override NewSyncRequest.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override NewSyncRequest.Builder MergeFrom(IMessageLite other)
            {
                if (other is NewSyncRequest)
                {
                    return this.MergeFrom((NewSyncRequest) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override NewSyncRequest.Builder MergeFrom(NewSyncRequest other)
            {
                return this;
            }

            public override NewSyncRequest.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(NewSyncRequest._newSyncRequestFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = NewSyncRequest._newSyncRequestFieldTags[index];
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
                            CmdList.Builder builder = CmdList.CreateBuilder();
                            if (this.result.hasOplog)
                            {
                                builder.MergeFrom(this.Oplog);
                            }
                            input.ReadMessage(builder, extensionRegistry);
                            this.Oplog = builder.BuildPartial();
                            continue;
                        }
                        case 0x10:
                        {
                            this.result.hasSelector = input.ReadUInt32(ref this.result.selector_);
                            continue;
                        }
                        case 0x1a:
                        {
                            SKBuiltinBuffer_t.Builder builder2 = SKBuiltinBuffer_t.CreateBuilder();
                            if (this.result.hasKeyBuf)
                            {
                                builder2.MergeFrom(this.KeyBuf);
                            }
                            input.ReadMessage(builder2, extensionRegistry);
                            this.KeyBuf = builder2.BuildPartial();
                            continue;
                        }
                        case 0x20:
                        {
                            this.result.hasScene = input.ReadUInt32(ref this.result.scene_);
                            continue;
                        }
                        case 0x2a:
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
                    this.result.hasDeviceType = input.ReadBytes(ref this.result.deviceType_); //input.ReadString(ref this.result.deviceType_);
                }
                return this;
            }

            public NewSyncRequest.Builder MergeKeyBuf(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasKeyBuf && (this.result.keyBuf_ != SKBuiltinBuffer_t.DefaultInstance))
                {
                    this.result.keyBuf_ = SKBuiltinBuffer_t.CreateBuilder(this.result.keyBuf_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.keyBuf_ = value;
                }
                this.result.hasKeyBuf = true;
                return this;
            }

            public NewSyncRequest.Builder MergeOplog(CmdList value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasOplog && (this.result.oplog_ != CmdList.DefaultInstance))
                {
                    this.result.oplog_ = CmdList.CreateBuilder(this.result.oplog_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.oplog_ = value;
                }
                this.result.hasOplog = true;
                return this;
            }

            private NewSyncRequest PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    NewSyncRequest result = this.result;
                    this.result = new NewSyncRequest();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public NewSyncRequest.Builder SetDeviceType(ByteString value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasDeviceType = true;
                this.result.deviceType_ = value;
                return this;
            }

            public NewSyncRequest.Builder SetKeyBuf(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasKeyBuf = true;
                this.result.keyBuf_ = value;
                return this;
            }

            public NewSyncRequest.Builder SetKeyBuf(SKBuiltinBuffer_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasKeyBuf = true;
                this.result.keyBuf_ = builderForValue.Build();
                return this;
            }

            public NewSyncRequest.Builder SetOplog(CmdList value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasOplog = true;
                this.result.oplog_ = value;
                return this;
            }

            public NewSyncRequest.Builder SetOplog(CmdList.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasOplog = true;
                this.result.oplog_ = builderForValue.Build();
                return this;
            }

            public NewSyncRequest.Builder SetScene(uint value)
            {
                this.PrepareBuilder();
                this.result.hasScene = true;
                this.result.scene_ = value;
                return this;
            }

            public NewSyncRequest.Builder SetSelector(uint value)
            {
                this.PrepareBuilder();
                this.result.hasSelector = true;
                this.result.selector_ = value;
                return this;
            }

            public override NewSyncRequest DefaultInstanceForType
            {
                get
                {
                    return NewSyncRequest.DefaultInstance;
                }
            }

            public ByteString DeviceType
            {
                get
                {
                    return this.result.DeviceType;
                }
                set
                {
                    this.SetDeviceType(value);
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            public SKBuiltinBuffer_t KeyBuf
            {
                get
                {
                    return this.result.KeyBuf;
                }
                set
                {
                    this.SetKeyBuf(value);
                }
            }

            protected override NewSyncRequest MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public CmdList Oplog
            {
                get
                {
                    return this.result.Oplog;
                }
                set
                {
                    this.SetOplog(value);
                }
            }

            public uint Scene
            {
                get
                {
                    return this.result.Scene;
                }
                set
                {
                    this.SetScene(value);
                }
            }

            public uint Selector
            {
                get
                {
                    return this.result.Selector;
                }
                set
                {
                    this.SetSelector(value);
                }
            }

            protected override NewSyncRequest.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}

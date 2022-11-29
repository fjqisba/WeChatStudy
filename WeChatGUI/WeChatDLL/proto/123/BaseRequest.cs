namespace micromsg
{
    using Google.ProtocolBuffers;
    
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

    
    public sealed class BaseRequest : GeneratedMessageLite<BaseRequest, BaseRequest.Builder>
    {
        private static readonly string[] _baseRequestFieldNames = new string[] { "ClientVersion", "DeviceID", "DeviceType", "Scene", "SessionKey", "Uin" };
        private static readonly uint[] _baseRequestFieldTags = new uint[] { 0x20, 0x1a, 0x2a, 0x30, 10, 0x10 };
        private int clientVersion_;
        public const int ClientVersionFieldNumber = 4;
        private static readonly BaseRequest defaultInstance = new BaseRequest().MakeReadOnly();
        private ByteString deviceID_ = ByteString.Empty;
        public const int DeviceIDFieldNumber = 3;
        private ByteString deviceType_ = ByteString.Empty;
        public const int DeviceTypeFieldNumber = 5;
        private bool hasClientVersion;
        private bool hasDeviceID;
        private bool hasDeviceType;
        private bool hasScene;
        private bool hasSessionKey;
        private bool hasUin;
        private int memoizedSerializedSize = -1;
        private uint scene_;
        public const int SceneFieldNumber = 6;
        private ByteString sessionKey_ = ByteString.Empty;
        public const int SessionKeyFieldNumber = 1;
        private uint uin_;
        public const int UinFieldNumber = 2;

        static BaseRequest()
        {
            //object.ReferenceEquals(BaseRequest.Descriptor, null);
        }

        private BaseRequest()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(BaseRequest prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            BaseRequest request = obj as BaseRequest;
            if (request == null)
            {
                return false;
            }
            if ((this.hasSessionKey != request.hasSessionKey) || (this.hasSessionKey && !this.sessionKey_.Equals(request.sessionKey_)))
            {
                return false;
            }
            if ((this.hasUin != request.hasUin) || (this.hasUin && !this.uin_.Equals(request.uin_)))
            {
                return false;
            }
            if ((this.hasDeviceID != request.hasDeviceID) || (this.hasDeviceID && !this.deviceID_.Equals(request.deviceID_)))
            {
                return false;
            }
            if ((this.hasClientVersion != request.hasClientVersion) || (this.hasClientVersion && !this.clientVersion_.Equals(request.clientVersion_)))
            {
                return false;
            }
            if ((this.hasDeviceType != request.hasDeviceType) || (this.hasDeviceType && !this.deviceType_.Equals(request.deviceType_)))
            {
                return false;
            }
            return ((this.hasScene == request.hasScene) && (!this.hasScene || this.scene_.Equals(request.scene_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasSessionKey)
            {
                hashCode ^= this.sessionKey_.GetHashCode();
            }
            if (this.hasUin)
            {
                hashCode ^= this.uin_.GetHashCode();
            }
            if (this.hasDeviceID)
            {
                hashCode ^= this.deviceID_.GetHashCode();
            }
            if (this.hasClientVersion)
            {
                hashCode ^= this.clientVersion_.GetHashCode();
            }
            if (this.hasDeviceType)
            {
                hashCode ^= this.deviceType_.GetHashCode();
            }
            if (this.hasScene)
            {
                hashCode ^= this.scene_.GetHashCode();
            }
            return hashCode;
        }

        private BaseRequest MakeReadOnly()
        {
            return this;
        }

        public static BaseRequest ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<BaseRequest, Builder>.PrintField("SessionKey", this.hasSessionKey, this.sessionKey_, writer);
            GeneratedMessageLite<BaseRequest, Builder>.PrintField("Uin", this.hasUin, this.uin_, writer);
            GeneratedMessageLite<BaseRequest, Builder>.PrintField("DeviceID", this.hasDeviceID, this.deviceID_, writer);
            GeneratedMessageLite<BaseRequest, Builder>.PrintField("ClientVersion", this.hasClientVersion, this.clientVersion_, writer);
            GeneratedMessageLite<BaseRequest, Builder>.PrintField("DeviceType", this.hasDeviceType, this.deviceType_, writer);
            GeneratedMessageLite<BaseRequest, Builder>.PrintField("Scene", this.hasScene, this.scene_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _baseRequestFieldNames;
            if (this.hasSessionKey)
            {
                output.WriteBytes(1, strArray[4], this.SessionKey);
            }
            if (this.hasUin)
            {
                output.WriteUInt32(2, strArray[5], this.Uin);
            }
            if (this.hasDeviceID)
            {
                output.WriteBytes(3, strArray[1], this.DeviceID);
            }
            if (this.hasClientVersion)
            {
                output.WriteInt32(4, strArray[0], this.ClientVersion);
            }
            if (this.hasDeviceType)
            {
                output.WriteBytes(5, strArray[2], this.DeviceType);
            }
            if (this.hasScene)
            {
                output.WriteUInt32(6, strArray[3], this.Scene);
            }
        }

        public int ClientVersion
        {
            get
            {
                return this.clientVersion_;
            }
        }

        public static BaseRequest DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override BaseRequest DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public ByteString DeviceID
        {
            get
            {
                return this.deviceID_;
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
                if (!this.hasSessionKey)
                {
                    return false;
                }
                if (!this.hasUin)
                {
                    return false;
                }
                if (!this.hasDeviceID)
                {
                    return false;
                }
                if (!this.hasClientVersion)
                {
                    return false;
                }
                if (!this.hasDeviceType)
                {
                    return false;
                }
                return true;
            }
        }

        public uint Scene
        {
            get
            {
                return this.scene_;
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
                    if (this.hasSessionKey)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeBytesSize(1, this.SessionKey);
                    }
                    if (this.hasUin)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(2, this.Uin);
                    }
                    if (this.hasDeviceID)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeBytesSize(3, this.DeviceID);
                    }
                    if (this.hasClientVersion)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(4, this.ClientVersion);
                    }
                    if (this.hasDeviceType)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeBytesSize(5, this.DeviceType);
                    }
                    if (this.hasScene)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(6, this.Scene);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        public ByteString SessionKey
        {
            get
            {
                return this.sessionKey_;
            }
        }

        protected override BaseRequest ThisMessage
        {
            get
            {
                return this;
            }
        }

        public uint Uin
        {
            get
            {
                return this.uin_;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<BaseRequest, BaseRequest.Builder>
        {
            private BaseRequest result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = BaseRequest.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(BaseRequest cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override BaseRequest BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override BaseRequest.Builder Clear()
            {
                this.result = BaseRequest.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public BaseRequest.Builder ClearClientVersion()
            {
                this.PrepareBuilder();
                this.result.hasClientVersion = false;
                this.result.clientVersion_ = 0;
                return this;
            }

            public BaseRequest.Builder ClearDeviceID()
            {
                this.PrepareBuilder();
                this.result.hasDeviceID = false;
                this.result.deviceID_ = ByteString.Empty;
                return this;
            }

            public BaseRequest.Builder ClearDeviceType()
            {
                this.PrepareBuilder();
                this.result.hasDeviceType = false;
                this.result.deviceType_ = ByteString.Empty;
                return this;
            }

            public BaseRequest.Builder ClearScene()
            {
                this.PrepareBuilder();
                this.result.hasScene = false;
                this.result.scene_ = 0;
                return this;
            }

            public BaseRequest.Builder ClearSessionKey()
            {
                this.PrepareBuilder();
                this.result.hasSessionKey = false;
                this.result.sessionKey_ = ByteString.Empty;
                return this;
            }

            public BaseRequest.Builder ClearUin()
            {
                this.PrepareBuilder();
                this.result.hasUin = false;
                this.result.uin_ = 0;
                return this;
            }

            public override BaseRequest.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new BaseRequest.Builder(this.result);
                }
                return new BaseRequest.Builder().MergeFrom(this.result);
            }

            public override BaseRequest.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override BaseRequest.Builder MergeFrom(IMessageLite other)
            {
                if (other is BaseRequest)
                {
                    return this.MergeFrom((BaseRequest) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override BaseRequest.Builder MergeFrom(BaseRequest other)
            {
                return this;
            }

            public override BaseRequest.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(BaseRequest._baseRequestFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = BaseRequest._baseRequestFieldTags[index];
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
                            this.result.hasSessionKey = input.ReadBytes(ref this.result.sessionKey_);
                            continue;
                        }
                        case 0x10:
                        {
                            this.result.hasUin = input.ReadUInt32(ref this.result.uin_);
                            continue;
                        }
                        case 0x1a:
                        {
                            this.result.hasDeviceID = input.ReadBytes(ref this.result.deviceID_);
                            continue;
                        }
                        case 0x20:
                        {
                            this.result.hasClientVersion = input.ReadInt32(ref this.result.clientVersion_);
                            continue;
                        }
                        case 0x2a:
                        {
                            this.result.hasDeviceType = input.ReadBytes(ref this.result.deviceType_);
                            continue;
                        }
                        case 0x30:
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
                    this.result.hasScene = input.ReadUInt32(ref this.result.scene_);
                }
                return this;
            }

            private BaseRequest PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    BaseRequest result = this.result;
                    this.result = new BaseRequest();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public BaseRequest.Builder SetClientVersion(int value)
            {
                this.PrepareBuilder();
                this.result.hasClientVersion = true;
                this.result.clientVersion_ = value;
                return this;
            }

            public BaseRequest.Builder SetDeviceID(ByteString value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasDeviceID = true;
                this.result.deviceID_ = value;
                return this;
            }

            public BaseRequest.Builder SetDeviceType(ByteString value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasDeviceType = true;
                this.result.deviceType_ = value;
                return this;
            }

            public BaseRequest.Builder SetScene(uint value)
            {
                this.PrepareBuilder();
                this.result.hasScene = true;
                this.result.scene_ = value;
                return this;
            }

            public BaseRequest.Builder SetSessionKey(ByteString value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSessionKey = true;
                this.result.sessionKey_ = value;
                return this;
            }

            public BaseRequest.Builder SetUin(uint value)
            {
                this.PrepareBuilder();
                this.result.hasUin = true;
                this.result.uin_ = value;
                return this;
            }

            public int ClientVersion
            {
                get
                {
                    return this.result.ClientVersion;
                }
                set
                {
                    this.SetClientVersion(value);
                }
            }

            public override BaseRequest DefaultInstanceForType
            {
                get
                {
                    return BaseRequest.DefaultInstance;
                }
            }

            public ByteString DeviceID
            {
                get
                {
                    return this.result.DeviceID;
                }
                set
                {
                    this.SetDeviceID(value);
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

            protected override BaseRequest MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
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

            public ByteString SessionKey
            {
                get
                {
                    return this.result.SessionKey;
                }
                set
                {
                    this.SetSessionKey(value);
                }
            }

            protected override BaseRequest.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }

            public uint Uin
            {
                get
                {
                    return this.result.Uin;
                }
                set
                {
                    this.SetUin(value);
                }
            }
        }
    }
}


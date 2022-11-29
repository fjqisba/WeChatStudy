namespace micromsg
{
    using Google.ProtocolBuffers;

    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    using System.Runtime.CompilerServices;

    public sealed class AddSafeDeviceRequest : GeneratedMessageLite<AddSafeDeviceRequest, AddSafeDeviceRequest.Builder>
    {
        private static readonly string[] _addSafeDeviceRequestFieldNames = new string[] { "AuthTicket", "BaseRequest", "DeviceType", "Name" };
        private static readonly uint[] _addSafeDeviceRequestFieldTags = new uint[] { 0x12, 10, 0x22, 0x1a };
        private string authTicket_ = "";
        public const int AuthTicketFieldNumber = 2;
        private micromsg.BaseRequest baseRequest_;
        public const int BaseRequestFieldNumber = 1;
        private static readonly AddSafeDeviceRequest defaultInstance = new AddSafeDeviceRequest().MakeReadOnly();
        private string deviceType_ = "";
        public const int DeviceTypeFieldNumber = 4;
        private bool hasAuthTicket;
        private bool hasBaseRequest;
        private bool hasDeviceType;
        private bool hasName;
        private int memoizedSerializedSize = -1;
        private string name_ = "";
        public const int NameFieldNumber = 3;

        static AddSafeDeviceRequest()
        {
        
        }

        private AddSafeDeviceRequest()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(AddSafeDeviceRequest prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            AddSafeDeviceRequest request = obj as AddSafeDeviceRequest;
            if (request == null)
            {
                return false;
            }
            if ((this.hasBaseRequest != request.hasBaseRequest) || (this.hasBaseRequest && !this.baseRequest_.Equals(request.baseRequest_)))
            {
                return false;
            }
            if ((this.hasAuthTicket != request.hasAuthTicket) || (this.hasAuthTicket && !this.authTicket_.Equals(request.authTicket_)))
            {
                return false;
            }
            if ((this.hasName != request.hasName) || (this.hasName && !this.name_.Equals(request.name_)))
            {
                return false;
            }
            return ((this.hasDeviceType == request.hasDeviceType) && (!this.hasDeviceType || this.deviceType_.Equals(request.deviceType_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasBaseRequest)
            {
                hashCode ^= this.baseRequest_.GetHashCode();
            }
            if (this.hasAuthTicket)
            {
                hashCode ^= this.authTicket_.GetHashCode();
            }
            if (this.hasName)
            {
                hashCode ^= this.name_.GetHashCode();
            }
            if (this.hasDeviceType)
            {
                hashCode ^= this.deviceType_.GetHashCode();
            }
            return hashCode;
        }

        private AddSafeDeviceRequest MakeReadOnly()
        {
            return this;
        }

        public static AddSafeDeviceRequest ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<AddSafeDeviceRequest, Builder>.PrintField("BaseRequest", this.hasBaseRequest, this.baseRequest_, writer);
            GeneratedMessageLite<AddSafeDeviceRequest, Builder>.PrintField("AuthTicket", this.hasAuthTicket, this.authTicket_, writer);
            GeneratedMessageLite<AddSafeDeviceRequest, Builder>.PrintField("Name", this.hasName, this.name_, writer);
            GeneratedMessageLite<AddSafeDeviceRequest, Builder>.PrintField("DeviceType", this.hasDeviceType, this.deviceType_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _addSafeDeviceRequestFieldNames;
            if (this.hasBaseRequest)
            {
                output.WriteMessage(1, strArray[1], this.BaseRequest);
            }
            if (this.hasAuthTicket)
            {
                output.WriteString(2, strArray[0], this.AuthTicket);
            }
            if (this.hasName)
            {
                output.WriteString(3, strArray[3], this.Name);
            }
            if (this.hasDeviceType)
            {
                output.WriteString(4, strArray[2], this.DeviceType);
            }
        }

        public string AuthTicket
        {
            get
            {
                return this.authTicket_;
            }
        }

        public micromsg.BaseRequest BaseRequest
        {
            get
            {
                return (this.baseRequest_ ?? micromsg.BaseRequest.DefaultInstance);
            }
        }

        public static AddSafeDeviceRequest DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override AddSafeDeviceRequest DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public string DeviceType
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
                if (!this.hasBaseRequest)
                {
                    return false;
                }
                if (!this.BaseRequest.IsInitialized)
                {
                    return false;
                }
                return true;
            }
        }

        public string Name
        {
            get
            {
                return this.name_;
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
                    if (this.hasBaseRequest)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(1, this.BaseRequest);
                    }
                    if (this.hasAuthTicket)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(2, this.AuthTicket);
                    }
                    if (this.hasName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(3, this.Name);
                    }
                    if (this.hasDeviceType)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(4, this.DeviceType);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override AddSafeDeviceRequest ThisMessage
        {
            get
            {
                return this;
            }
        }

        [DebuggerNonUserCode, GeneratedCode("ProtoGen", "2.3.0.277"), CompilerGenerated]
        public sealed class Builder : GeneratedBuilderLite<AddSafeDeviceRequest, AddSafeDeviceRequest.Builder>
        {
            private AddSafeDeviceRequest result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = AddSafeDeviceRequest.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(AddSafeDeviceRequest cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override AddSafeDeviceRequest BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override AddSafeDeviceRequest.Builder Clear()
            {
                this.result = AddSafeDeviceRequest.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public AddSafeDeviceRequest.Builder ClearAuthTicket()
            {
                this.PrepareBuilder();
                this.result.hasAuthTicket = false;
                this.result.authTicket_ = "";
                return this;
            }

            public AddSafeDeviceRequest.Builder ClearBaseRequest()
            {
                this.PrepareBuilder();
                this.result.hasBaseRequest = false;
                this.result.baseRequest_ = null;
                return this;
            }

            public AddSafeDeviceRequest.Builder ClearDeviceType()
            {
                this.PrepareBuilder();
                this.result.hasDeviceType = false;
                this.result.deviceType_ = "";
                return this;
            }

            public AddSafeDeviceRequest.Builder ClearName()
            {
                this.PrepareBuilder();
                this.result.hasName = false;
                this.result.name_ = "";
                return this;
            }

            public override AddSafeDeviceRequest.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new AddSafeDeviceRequest.Builder(this.result);
                }
                return new AddSafeDeviceRequest.Builder().MergeFrom(this.result);
            }

            public AddSafeDeviceRequest.Builder MergeBaseRequest(micromsg.BaseRequest value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasBaseRequest && (this.result.baseRequest_ != micromsg.BaseRequest.DefaultInstance))
                {
                    this.result.baseRequest_ = micromsg.BaseRequest.CreateBuilder(this.result.baseRequest_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.baseRequest_ = value;
                }
                this.result.hasBaseRequest = true;
                return this;
            }

            public override AddSafeDeviceRequest.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override AddSafeDeviceRequest.Builder MergeFrom(IMessageLite other)
            {
                if (other is AddSafeDeviceRequest)
                {
                    return this.MergeFrom((AddSafeDeviceRequest) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override AddSafeDeviceRequest.Builder MergeFrom(AddSafeDeviceRequest other)
            {
                return this;
            }

            public override AddSafeDeviceRequest.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(AddSafeDeviceRequest._addSafeDeviceRequestFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = AddSafeDeviceRequest._addSafeDeviceRequestFieldTags[index];
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
                            micromsg.BaseRequest.Builder builder = micromsg.BaseRequest.CreateBuilder();
                            if (this.result.hasBaseRequest)
                            {
                                builder.MergeFrom(this.BaseRequest);
                            }
                            input.ReadMessage(builder, extensionRegistry);
                            this.BaseRequest = builder.BuildPartial();
                            continue;
                        }
                        case 0x12:
                        {
                            this.result.hasAuthTicket = input.ReadString(ref this.result.authTicket_);
                            continue;
                        }
                        case 0x1a:
                        {
                            this.result.hasName = input.ReadString(ref this.result.name_);
                            continue;
                        }
                        case 0x22:
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
                    this.result.hasDeviceType = input.ReadString(ref this.result.deviceType_);
                }
                return this;
            }

            private AddSafeDeviceRequest PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    AddSafeDeviceRequest result = this.result;
                    this.result = new AddSafeDeviceRequest();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public AddSafeDeviceRequest.Builder SetAuthTicket(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasAuthTicket = true;
                this.result.authTicket_ = value;
                return this;
            }

            public AddSafeDeviceRequest.Builder SetBaseRequest(micromsg.BaseRequest value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = value;
                return this;
            }

            public AddSafeDeviceRequest.Builder SetBaseRequest(micromsg.BaseRequest.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = builderForValue.Build();
                return this;
            }

            public AddSafeDeviceRequest.Builder SetDeviceType(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasDeviceType = true;
                this.result.deviceType_ = value;
                return this;
            }

            public AddSafeDeviceRequest.Builder SetName(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasName = true;
                this.result.name_ = value;
                return this;
            }

            public string AuthTicket
            {
                get
                {
                    return this.result.AuthTicket;
                }
                set
                {
                    this.SetAuthTicket(value);
                }
            }

            public micromsg.BaseRequest BaseRequest
            {
                get
                {
                    return this.result.BaseRequest;
                }
                set
                {
                    this.SetBaseRequest(value);
                }
            }

            public override AddSafeDeviceRequest DefaultInstanceForType
            {
                get
                {
                    return AddSafeDeviceRequest.DefaultInstance;
                }
            }

            public string DeviceType
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

            protected override AddSafeDeviceRequest MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public string Name
            {
                get
                {
                    return this.result.Name;
                }
                set
                {
                    this.SetName(value);
                }
            }

            protected override AddSafeDeviceRequest.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


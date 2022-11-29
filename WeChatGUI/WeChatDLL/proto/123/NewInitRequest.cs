namespace micromsg
{
    using Google.ProtocolBuffers;
   
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

    
    public sealed class NewInitRequest : GeneratedMessageLite<NewInitRequest, NewInitRequest.Builder>
    {
        private static readonly string[] _newInitRequestFieldNames = new string[] { "BaseRequest", "CurrentSynckey", "Language", "MaxSynckey", "UserName" };
        private static readonly uint[] _newInitRequestFieldTags = new uint[] { 10, 0x1a, 0x2a, 0x22, 0x12 };
        private micromsg.BaseRequest baseRequest_;
        public const int BaseRequestFieldNumber = 1;
        private SKBuiltinBuffer_t currentSynckey_;
        public const int CurrentSynckeyFieldNumber = 3;
        private static readonly NewInitRequest defaultInstance = new NewInitRequest().MakeReadOnly();
        private bool hasBaseRequest;
        private bool hasCurrentSynckey;
        private bool hasLanguage;
        private bool hasMaxSynckey;
        private bool hasUserName;
        private string language_ = "";
        public const int LanguageFieldNumber = 5;
        private SKBuiltinBuffer_t maxSynckey_;
        public const int MaxSynckeyFieldNumber = 4;
        private int memoizedSerializedSize = -1;
        private string userName_ = "";
        public const int UserNameFieldNumber = 2;

        static NewInitRequest()
        {
           // object.ReferenceEquals(NewInitRequest.Descriptor, null);
        }

        private NewInitRequest()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(NewInitRequest prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            NewInitRequest request = obj as NewInitRequest;
            if (request == null)
            {
                return false;
            }
            if ((this.hasBaseRequest != request.hasBaseRequest) || (this.hasBaseRequest && !this.baseRequest_.Equals(request.baseRequest_)))
            {
                return false;
            }
            if ((this.hasUserName != request.hasUserName) || (this.hasUserName && !this.userName_.Equals(request.userName_)))
            {
                return false;
            }
            if ((this.hasCurrentSynckey != request.hasCurrentSynckey) || (this.hasCurrentSynckey && !this.currentSynckey_.Equals(request.currentSynckey_)))
            {
                return false;
            }
            if ((this.hasMaxSynckey != request.hasMaxSynckey) || (this.hasMaxSynckey && !this.maxSynckey_.Equals(request.maxSynckey_)))
            {
                return false;
            }
            return ((this.hasLanguage == request.hasLanguage) && (!this.hasLanguage || this.language_.Equals(request.language_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasBaseRequest)
            {
                hashCode ^= this.baseRequest_.GetHashCode();
            }
            if (this.hasUserName)
            {
                hashCode ^= this.userName_.GetHashCode();
            }
            if (this.hasCurrentSynckey)
            {
                hashCode ^= this.currentSynckey_.GetHashCode();
            }
            if (this.hasMaxSynckey)
            {
                hashCode ^= this.maxSynckey_.GetHashCode();
            }
            if (this.hasLanguage)
            {
                hashCode ^= this.language_.GetHashCode();
            }
            return hashCode;
        }

        private NewInitRequest MakeReadOnly()
        {
            return this;
        }

        public static NewInitRequest ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<NewInitRequest, Builder>.PrintField("BaseRequest", this.hasBaseRequest, this.baseRequest_, writer);
            GeneratedMessageLite<NewInitRequest, Builder>.PrintField("UserName", this.hasUserName, this.userName_, writer);
            GeneratedMessageLite<NewInitRequest, Builder>.PrintField("CurrentSynckey", this.hasCurrentSynckey, this.currentSynckey_, writer);
            GeneratedMessageLite<NewInitRequest, Builder>.PrintField("MaxSynckey", this.hasMaxSynckey, this.maxSynckey_, writer);
            GeneratedMessageLite<NewInitRequest, Builder>.PrintField("Language", this.hasLanguage, this.language_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _newInitRequestFieldNames;
            if (this.hasBaseRequest)
            {
                output.WriteMessage(1, strArray[0], this.BaseRequest);
            }
            if (this.hasUserName)
            {
                output.WriteString(2, strArray[4], this.UserName);
            }
            if (this.hasCurrentSynckey)
            {
                output.WriteMessage(3, strArray[1], this.CurrentSynckey);
            }
            if (this.hasMaxSynckey)
            {
                output.WriteMessage(4, strArray[3], this.MaxSynckey);
            }
            if (this.hasLanguage)
            {
                output.WriteString(5, strArray[2], this.Language);
            }
        }

        public micromsg.BaseRequest BaseRequest
        {
            get
            {
                return (this.baseRequest_ ?? micromsg.BaseRequest.DefaultInstance);
            }
        }

        public SKBuiltinBuffer_t CurrentSynckey
        {
            get
            {
                return (this.currentSynckey_ ?? SKBuiltinBuffer_t.DefaultInstance);
            }
        }

        public static NewInitRequest DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override NewInitRequest DefaultInstanceForType
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
                if (!this.hasBaseRequest)
                {
                    return false;
                }
                if (!this.hasCurrentSynckey)
                {
                    return false;
                }
                if (!this.hasMaxSynckey)
                {
                    return false;
                }
                if (!this.BaseRequest.IsInitialized)
                {
                    return false;
                }
                if (!this.CurrentSynckey.IsInitialized)
                {
                    return false;
                }
                if (!this.MaxSynckey.IsInitialized)
                {
                    return false;
                }
                return true;
            }
        }

        public string Language
        {
            get
            {
                return this.language_;
            }
        }

        public SKBuiltinBuffer_t MaxSynckey
        {
            get
            {
                return (this.maxSynckey_ ?? SKBuiltinBuffer_t.DefaultInstance);
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
                    if (this.hasUserName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(2, this.UserName);
                    }
                    if (this.hasCurrentSynckey)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(3, this.CurrentSynckey);
                    }
                    if (this.hasMaxSynckey)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(4, this.MaxSynckey);
                    }
                    if (this.hasLanguage)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(5, this.Language);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override NewInitRequest ThisMessage
        {
            get
            {
                return this;
            }
        }

        public string UserName
        {
            get
            {
                return this.userName_;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<NewInitRequest, NewInitRequest.Builder>
        {
            private NewInitRequest result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = NewInitRequest.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(NewInitRequest cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override NewInitRequest BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override NewInitRequest.Builder Clear()
            {
                this.result = NewInitRequest.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public NewInitRequest.Builder ClearBaseRequest()
            {
                this.PrepareBuilder();
                this.result.hasBaseRequest = false;
                this.result.baseRequest_ = null;
                return this;
            }

            public NewInitRequest.Builder ClearCurrentSynckey()
            {
                this.PrepareBuilder();
                this.result.hasCurrentSynckey = false;
                this.result.currentSynckey_ = null;
                return this;
            }

            public NewInitRequest.Builder ClearLanguage()
            {
                this.PrepareBuilder();
                this.result.hasLanguage = false;
                this.result.language_ = "";
                return this;
            }

            public NewInitRequest.Builder ClearMaxSynckey()
            {
                this.PrepareBuilder();
                this.result.hasMaxSynckey = false;
                this.result.maxSynckey_ = null;
                return this;
            }

            public NewInitRequest.Builder ClearUserName()
            {
                this.PrepareBuilder();
                this.result.hasUserName = false;
                this.result.userName_ = "";
                return this;
            }

            public override NewInitRequest.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new NewInitRequest.Builder(this.result);
                }
                return new NewInitRequest.Builder().MergeFrom(this.result);
            }

            public NewInitRequest.Builder MergeBaseRequest(micromsg.BaseRequest value)
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

            public NewInitRequest.Builder MergeCurrentSynckey(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasCurrentSynckey && (this.result.currentSynckey_ != SKBuiltinBuffer_t.DefaultInstance))
                {
                    this.result.currentSynckey_ = SKBuiltinBuffer_t.CreateBuilder(this.result.currentSynckey_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.currentSynckey_ = value;
                }
                this.result.hasCurrentSynckey = true;
                return this;
            }

            public override NewInitRequest.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override NewInitRequest.Builder MergeFrom(IMessageLite other)
            {
                if (other is NewInitRequest)
                {
                    return this.MergeFrom((NewInitRequest) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override NewInitRequest.Builder MergeFrom(NewInitRequest other)
            {
                return this;
            }

            public override NewInitRequest.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(NewInitRequest._newInitRequestFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = NewInitRequest._newInitRequestFieldTags[index];
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
                            this.result.hasUserName = input.ReadString(ref this.result.userName_);
                            continue;
                        }
                        case 0x1a:
                        {
                            SKBuiltinBuffer_t.Builder builder2 = SKBuiltinBuffer_t.CreateBuilder();
                            if (this.result.hasCurrentSynckey)
                            {
                                builder2.MergeFrom(this.CurrentSynckey);
                            }
                            input.ReadMessage(builder2, extensionRegistry);
                            this.CurrentSynckey = builder2.BuildPartial();
                            continue;
                        }
                        case 0x22:
                        {
                            SKBuiltinBuffer_t.Builder builder3 = SKBuiltinBuffer_t.CreateBuilder();
                            if (this.result.hasMaxSynckey)
                            {
                                builder3.MergeFrom(this.MaxSynckey);
                            }
                            input.ReadMessage(builder3, extensionRegistry);
                            this.MaxSynckey = builder3.BuildPartial();
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
                    this.result.hasLanguage = input.ReadString(ref this.result.language_);
                }
                return this;
            }

            public NewInitRequest.Builder MergeMaxSynckey(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasMaxSynckey && (this.result.maxSynckey_ != SKBuiltinBuffer_t.DefaultInstance))
                {
                    this.result.maxSynckey_ = SKBuiltinBuffer_t.CreateBuilder(this.result.maxSynckey_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.maxSynckey_ = value;
                }
                this.result.hasMaxSynckey = true;
                return this;
            }

            private NewInitRequest PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    NewInitRequest result = this.result;
                    this.result = new NewInitRequest();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public NewInitRequest.Builder SetBaseRequest(micromsg.BaseRequest value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = value;
                return this;
            }

            public NewInitRequest.Builder SetBaseRequest(micromsg.BaseRequest.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = builderForValue.Build();
                return this;
            }

            public NewInitRequest.Builder SetCurrentSynckey(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasCurrentSynckey = true;
                this.result.currentSynckey_ = value;
                return this;
            }

            public NewInitRequest.Builder SetCurrentSynckey(SKBuiltinBuffer_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasCurrentSynckey = true;
                this.result.currentSynckey_ = builderForValue.Build();
                return this;
            }

            public NewInitRequest.Builder SetLanguage(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasLanguage = true;
                this.result.language_ = value;
                return this;
            }

            public NewInitRequest.Builder SetMaxSynckey(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasMaxSynckey = true;
                this.result.maxSynckey_ = value;
                return this;
            }

            public NewInitRequest.Builder SetMaxSynckey(SKBuiltinBuffer_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasMaxSynckey = true;
                this.result.maxSynckey_ = builderForValue.Build();
                return this;
            }

            public NewInitRequest.Builder SetUserName(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasUserName = true;
                this.result.userName_ = value;
                return this;
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

            public SKBuiltinBuffer_t CurrentSynckey
            {
                get
                {
                    return this.result.CurrentSynckey;
                }
                set
                {
                    this.SetCurrentSynckey(value);
                }
            }

            public override NewInitRequest DefaultInstanceForType
            {
                get
                {
                    return NewInitRequest.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            public string Language
            {
                get
                {
                    return this.result.Language;
                }
                set
                {
                    this.SetLanguage(value);
                }
            }

            public SKBuiltinBuffer_t MaxSynckey
            {
                get
                {
                    return this.result.MaxSynckey;
                }
                set
                {
                    this.SetMaxSynckey(value);
                }
            }

            protected override NewInitRequest MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override NewInitRequest.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }

            public string UserName
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


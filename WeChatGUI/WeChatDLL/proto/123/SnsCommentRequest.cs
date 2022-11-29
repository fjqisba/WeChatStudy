namespace micromsg
{
    using Google.ProtocolBuffers;

    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    using System.Runtime.CompilerServices;


    public sealed class SnsCommentRequest : GeneratedMessageLite<SnsCommentRequest, SnsCommentRequest.Builder>
    {
        private static readonly string[] _snsCommentRequestFieldNames = new string[] { "Action", "BaseRequest", "ClientId" };
        private static readonly uint[] _snsCommentRequestFieldTags = new uint[] { 0x12, 10, 0x1a };
        private SnsActionGroup action_;
        public const int ActionFieldNumber = 2;
        private micromsg.BaseRequest baseRequest_;
        public const int BaseRequestFieldNumber = 1;
        private string clientId_ = "";
        public const int ClientIdFieldNumber = 3;
        private static readonly SnsCommentRequest defaultInstance = new SnsCommentRequest().MakeReadOnly();
        private bool hasAction;
        private bool hasBaseRequest;
        private bool hasClientId;
        private int memoizedSerializedSize = -1;

        static SnsCommentRequest()
        {

        }

        private SnsCommentRequest()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(SnsCommentRequest prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            SnsCommentRequest request = obj as SnsCommentRequest;
            if (request == null)
            {
                return false;
            }
            if ((this.hasBaseRequest != request.hasBaseRequest) || (this.hasBaseRequest && !this.baseRequest_.Equals(request.baseRequest_)))
            {
                return false;
            }
            if ((this.hasAction != request.hasAction) || (this.hasAction && !this.action_.Equals(request.action_)))
            {
                return false;
            }
            return ((this.hasClientId == request.hasClientId) && (!this.hasClientId || this.clientId_.Equals(request.clientId_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasBaseRequest)
            {
                hashCode ^= this.baseRequest_.GetHashCode();
            }
            if (this.hasAction)
            {
                hashCode ^= this.action_.GetHashCode();
            }
            if (this.hasClientId)
            {
                hashCode ^= this.clientId_.GetHashCode();
            }
            return hashCode;
        }

        private SnsCommentRequest MakeReadOnly()
        {
            return this;
        }

        public static SnsCommentRequest ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<SnsCommentRequest, Builder>.PrintField("BaseRequest", this.hasBaseRequest, this.baseRequest_, writer);
            GeneratedMessageLite<SnsCommentRequest, Builder>.PrintField("Action", this.hasAction, this.action_, writer);
            GeneratedMessageLite<SnsCommentRequest, Builder>.PrintField("ClientId", this.hasClientId, this.clientId_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _snsCommentRequestFieldNames;
            if (this.hasBaseRequest)
            {
                output.WriteMessage(1, strArray[1], this.BaseRequest);
            }
            if (this.hasAction)
            {
                output.WriteMessage(2, strArray[0], this.Action);
            }
            if (this.hasClientId)
            {
                output.WriteString(3, strArray[2], this.ClientId);
            }
        }

        public SnsActionGroup Action
        {
            get
            {
                return (this.action_ ?? SnsActionGroup.DefaultInstance);
            }
        }

        public micromsg.BaseRequest BaseRequest
        {
            get
            {
                return (this.baseRequest_ ?? micromsg.BaseRequest.DefaultInstance);
            }
        }

        public string ClientId
        {
            get
            {
                return this.clientId_;
            }
        }

        public static SnsCommentRequest DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override SnsCommentRequest DefaultInstanceForType
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
                if (!this.hasAction)
                {
                    return false;
                }
                if (!this.BaseRequest.IsInitialized)
                {
                    return false;
                }
                if (!this.Action.IsInitialized)
                {
                    return false;
                }
                return true;
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
                    if (this.hasAction)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(2, this.Action);
                    }
                    if (this.hasClientId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(3, this.ClientId);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override SnsCommentRequest ThisMessage
        {
            get
            {
                return this;
            }
        }

        [DebuggerNonUserCode, CompilerGenerated, GeneratedCode("ProtoGen", "2.3.0.277")]
        public sealed class Builder : GeneratedBuilderLite<SnsCommentRequest, SnsCommentRequest.Builder>
        {
            private SnsCommentRequest result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = SnsCommentRequest.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(SnsCommentRequest cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override SnsCommentRequest BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override SnsCommentRequest.Builder Clear()
            {
                this.result = SnsCommentRequest.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public SnsCommentRequest.Builder ClearAction()
            {
                this.PrepareBuilder();
                this.result.hasAction = false;
                this.result.action_ = null;
                return this;
            }

            public SnsCommentRequest.Builder ClearBaseRequest()
            {
                this.PrepareBuilder();
                this.result.hasBaseRequest = false;
                this.result.baseRequest_ = null;
                return this;
            }

            public SnsCommentRequest.Builder ClearClientId()
            {
                this.PrepareBuilder();
                this.result.hasClientId = false;
                this.result.clientId_ = "";
                return this;
            }

            public override SnsCommentRequest.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new SnsCommentRequest.Builder(this.result);
                }
                return new SnsCommentRequest.Builder().MergeFrom(this.result);
            }

            public SnsCommentRequest.Builder MergeAction(SnsActionGroup value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasAction && (this.result.action_ != SnsActionGroup.DefaultInstance))
                {
                    this.result.action_ = SnsActionGroup.CreateBuilder(this.result.action_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.action_ = value;
                }
                this.result.hasAction = true;
                return this;
            }

            public SnsCommentRequest.Builder MergeBaseRequest(micromsg.BaseRequest value)
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

            public override SnsCommentRequest.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override SnsCommentRequest.Builder MergeFrom(IMessageLite other)
            {
                if (other is SnsCommentRequest)
                {
                    return this.MergeFrom((SnsCommentRequest) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override SnsCommentRequest.Builder MergeFrom(SnsCommentRequest other)
            {
                return this;
            }

            public override SnsCommentRequest.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(SnsCommentRequest._snsCommentRequestFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = SnsCommentRequest._snsCommentRequestFieldTags[index];
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
                            SnsActionGroup.Builder builder2 = SnsActionGroup.CreateBuilder();
                            if (this.result.hasAction)
                            {
                                builder2.MergeFrom(this.Action);
                            }
                            input.ReadMessage(builder2, extensionRegistry);
                            this.Action = builder2.BuildPartial();
                            continue;
                        }
                        case 0x1a:
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
                    this.result.hasClientId = input.ReadString(ref this.result.clientId_);
                }
                return this;
            }

            private SnsCommentRequest PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    SnsCommentRequest result = this.result;
                    this.result = new SnsCommentRequest();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public SnsCommentRequest.Builder SetAction(SnsActionGroup value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasAction = true;
                this.result.action_ = value;
                return this;
            }

            public SnsCommentRequest.Builder SetAction(SnsActionGroup.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasAction = true;
                this.result.action_ = builderForValue.Build();
                return this;
            }

            public SnsCommentRequest.Builder SetBaseRequest(micromsg.BaseRequest value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = value;
                return this;
            }

            public SnsCommentRequest.Builder SetBaseRequest(micromsg.BaseRequest.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = builderForValue.Build();
                return this;
            }

            public SnsCommentRequest.Builder SetClientId(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasClientId = true;
                this.result.clientId_ = value;
                return this;
            }

            public SnsActionGroup Action
            {
                get
                {
                    return this.result.Action;
                }
                set
                {
                    this.SetAction(value);
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

            public string ClientId
            {
                get
                {
                    return this.result.ClientId;
                }
                set
                {
                    this.SetClientId(value);
                }
            }

            public override SnsCommentRequest DefaultInstanceForType
            {
                get
                {
                    return SnsCommentRequest.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override SnsCommentRequest MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override SnsCommentRequest.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


namespace micromsg
{
    using Google.ProtocolBuffers;

    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

    public sealed class GetA8KeyReq : GeneratedMessageLite<GetA8KeyReq, GetA8KeyReq.Builder>
    {
        private static readonly string[] _getA8KeyReqFieldNames = new string[] { "A2Key", "AppID", "BaseRequest", "FriendQQ", "FriendUserName", "OpCode", "ReqUrl", "Scene", "Scope", "State", "UserName" };
        private static readonly uint[] _getA8KeyReqFieldTags = new uint[] { 0x1a, 0x22, 10, 0x48, 0x42, 0x10, 0x3a, 80, 0x2a, 50, 90 };
        private SKBuiltinBuffer_t a2Key_;
        public const int A2KeyFieldNumber = 3;
        private SKBuiltinString_t appID_;
        public const int AppIDFieldNumber = 4;
        private micromsg.BaseRequest baseRequest_;
        public const int BaseRequestFieldNumber = 1;
        private static readonly GetA8KeyReq defaultInstance = new GetA8KeyReq().MakeReadOnly();
        private uint friendQQ_;
        public const int FriendQQFieldNumber = 9;
        private string friendUserName_ = "";
        public const int FriendUserNameFieldNumber = 8;
        private bool hasA2Key;
        private bool hasAppID;
        private bool hasBaseRequest;
        private bool hasFriendQQ;
        private bool hasFriendUserName;
        private bool hasOpCode;
        private bool hasReqUrl;
        private bool hasScene;
        private bool hasScope;
        private bool hasState;
        private bool hasUserName;
        private int memoizedSerializedSize = -1;
        private uint opCode_;
        public const int OpCodeFieldNumber = 2;
        private SKBuiltinString_t reqUrl_;
        public const int ReqUrlFieldNumber = 7;
        private uint scene_;
        public const int SceneFieldNumber = 10;
        private SKBuiltinString_t scope_;
        public const int ScopeFieldNumber = 5;
        private SKBuiltinString_t state_;
        public const int StateFieldNumber = 6;
        private string userName_ = "";
        public const int UserNameFieldNumber = 11;

        static GetA8KeyReq()
        {

        }

        private GetA8KeyReq()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(GetA8KeyReq prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            GetA8KeyReq req = obj as GetA8KeyReq;
            if (req == null)
            {
                return false;
            }
            if ((this.hasBaseRequest != req.hasBaseRequest) || (this.hasBaseRequest && !this.baseRequest_.Equals(req.baseRequest_)))
            {
                return false;
            }
            if ((this.hasOpCode != req.hasOpCode) || (this.hasOpCode && !this.opCode_.Equals(req.opCode_)))
            {
                return false;
            }
            if ((this.hasA2Key != req.hasA2Key) || (this.hasA2Key && !this.a2Key_.Equals(req.a2Key_)))
            {
                return false;
            }
            if ((this.hasAppID != req.hasAppID) || (this.hasAppID && !this.appID_.Equals(req.appID_)))
            {
                return false;
            }
            if ((this.hasScope != req.hasScope) || (this.hasScope && !this.scope_.Equals(req.scope_)))
            {
                return false;
            }
            if ((this.hasState != req.hasState) || (this.hasState && !this.state_.Equals(req.state_)))
            {
                return false;
            }
            if ((this.hasReqUrl != req.hasReqUrl) || (this.hasReqUrl && !this.reqUrl_.Equals(req.reqUrl_)))
            {
                return false;
            }
            if ((this.hasFriendUserName != req.hasFriendUserName) || (this.hasFriendUserName && !this.friendUserName_.Equals(req.friendUserName_)))
            {
                return false;
            }
            if ((this.hasFriendQQ != req.hasFriendQQ) || (this.hasFriendQQ && !this.friendQQ_.Equals(req.friendQQ_)))
            {
                return false;
            }
            if ((this.hasScene != req.hasScene) || (this.hasScene && !this.scene_.Equals(req.scene_)))
            {
                return false;
            }
            return ((this.hasUserName == req.hasUserName) && (!this.hasUserName || this.userName_.Equals(req.userName_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasBaseRequest)
            {
                hashCode ^= this.baseRequest_.GetHashCode();
            }
            if (this.hasOpCode)
            {
                hashCode ^= this.opCode_.GetHashCode();
            }
            if (this.hasA2Key)
            {
                hashCode ^= this.a2Key_.GetHashCode();
            }
            if (this.hasAppID)
            {
                hashCode ^= this.appID_.GetHashCode();
            }
            if (this.hasScope)
            {
                hashCode ^= this.scope_.GetHashCode();
            }
            if (this.hasState)
            {
                hashCode ^= this.state_.GetHashCode();
            }
            if (this.hasReqUrl)
            {
                hashCode ^= this.reqUrl_.GetHashCode();
            }
            if (this.hasFriendUserName)
            {
                hashCode ^= this.friendUserName_.GetHashCode();
            }
            if (this.hasFriendQQ)
            {
                hashCode ^= this.friendQQ_.GetHashCode();
            }
            if (this.hasScene)
            {
                hashCode ^= this.scene_.GetHashCode();
            }
            if (this.hasUserName)
            {
                hashCode ^= this.userName_.GetHashCode();
            }
            return hashCode;
        }

        private GetA8KeyReq MakeReadOnly()
        {
            return this;
        }

        public static GetA8KeyReq ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<GetA8KeyReq, Builder>.PrintField("BaseRequest", this.hasBaseRequest, this.baseRequest_, writer);
            GeneratedMessageLite<GetA8KeyReq, Builder>.PrintField("OpCode", this.hasOpCode, this.opCode_, writer);
            GeneratedMessageLite<GetA8KeyReq, Builder>.PrintField("A2Key", this.hasA2Key, this.a2Key_, writer);
            GeneratedMessageLite<GetA8KeyReq, Builder>.PrintField("AppID", this.hasAppID, this.appID_, writer);
            GeneratedMessageLite<GetA8KeyReq, Builder>.PrintField("Scope", this.hasScope, this.scope_, writer);
            GeneratedMessageLite<GetA8KeyReq, Builder>.PrintField("State", this.hasState, this.state_, writer);
            GeneratedMessageLite<GetA8KeyReq, Builder>.PrintField("ReqUrl", this.hasReqUrl, this.reqUrl_, writer);
            GeneratedMessageLite<GetA8KeyReq, Builder>.PrintField("FriendUserName", this.hasFriendUserName, this.friendUserName_, writer);
            GeneratedMessageLite<GetA8KeyReq, Builder>.PrintField("FriendQQ", this.hasFriendQQ, this.friendQQ_, writer);
            GeneratedMessageLite<GetA8KeyReq, Builder>.PrintField("Scene", this.hasScene, this.scene_, writer);
            GeneratedMessageLite<GetA8KeyReq, Builder>.PrintField("UserName", this.hasUserName, this.userName_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _getA8KeyReqFieldNames;
            if (this.hasBaseRequest)
            {
                output.WriteMessage(1, strArray[2], this.BaseRequest);
            }
            if (this.hasOpCode)
            {
                output.WriteUInt32(2, strArray[5], this.OpCode);
            }
            if (this.hasA2Key)
            {
                output.WriteMessage(3, strArray[0], this.A2Key);
            }
            if (this.hasAppID)
            {
                output.WriteMessage(4, strArray[1], this.AppID);
            }
            if (this.hasScope)
            {
                output.WriteMessage(5, strArray[8], this.Scope);
            }
            if (this.hasState)
            {
                output.WriteMessage(6, strArray[9], this.State);
            }
            if (this.hasReqUrl)
            {
                output.WriteMessage(7, strArray[6], this.ReqUrl);
            }
            if (this.hasFriendUserName)
            {
                output.WriteString(8, strArray[4], this.FriendUserName);
            }
            if (this.hasFriendQQ)
            {
                output.WriteUInt32(9, strArray[3], this.FriendQQ);
            }
            if (this.hasScene)
            {
                output.WriteUInt32(10, strArray[7], this.Scene);
            }
            if (this.hasUserName)
            {
                output.WriteString(11, strArray[10], this.UserName);
            }
        }

        public SKBuiltinBuffer_t A2Key
        {
            get
            {
                return (this.a2Key_ ?? SKBuiltinBuffer_t.DefaultInstance);
            }
        }

        public SKBuiltinString_t AppID
        {
            get
            {
                return (this.appID_ ?? SKBuiltinString_t.DefaultInstance);
            }
        }

        public micromsg.BaseRequest BaseRequest
        {
            get
            {
                return (this.baseRequest_ ?? micromsg.BaseRequest.DefaultInstance);
            }
        }

        public static GetA8KeyReq DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override GetA8KeyReq DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public uint FriendQQ
        {
            get
            {
                return this.friendQQ_;
            }
        }

        public string FriendUserName
        {
            get
            {
                return this.friendUserName_;
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
                if (!this.hasOpCode)
                {
                    return false;
                }
                if (!this.hasA2Key)
                {
                    return false;
                }
                if (!this.BaseRequest.IsInitialized)
                {
                    return false;
                }
                if (!this.A2Key.IsInitialized)
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

        public SKBuiltinString_t ReqUrl
        {
            get
            {
                return (this.reqUrl_ ?? SKBuiltinString_t.DefaultInstance);
            }
        }

        public uint Scene
        {
            get
            {
                return this.scene_;
            }
        }

        public SKBuiltinString_t Scope
        {
            get
            {
                return (this.scope_ ?? SKBuiltinString_t.DefaultInstance);
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
                    if (this.hasOpCode)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(2, this.OpCode);
                    }
                    if (this.hasA2Key)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(3, this.A2Key);
                    }
                    if (this.hasAppID)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(4, this.AppID);
                    }
                    if (this.hasScope)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(5, this.Scope);
                    }
                    if (this.hasState)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(6, this.State);
                    }
                    if (this.hasReqUrl)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(7, this.ReqUrl);
                    }
                    if (this.hasFriendUserName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(8, this.FriendUserName);
                    }
                    if (this.hasFriendQQ)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(9, this.FriendQQ);
                    }
                    if (this.hasScene)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(10, this.Scene);
                    }
                    if (this.hasUserName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(11, this.UserName);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        public SKBuiltinString_t State
        {
            get
            {
                return (this.state_ ?? SKBuiltinString_t.DefaultInstance);
            }
        }

        protected override GetA8KeyReq ThisMessage
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

        
        public sealed class Builder : GeneratedBuilderLite<GetA8KeyReq, GetA8KeyReq.Builder>
        {
            private GetA8KeyReq result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = GetA8KeyReq.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(GetA8KeyReq cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override GetA8KeyReq BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override GetA8KeyReq.Builder Clear()
            {
                this.result = GetA8KeyReq.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public GetA8KeyReq.Builder ClearA2Key()
            {
                this.PrepareBuilder();
                this.result.hasA2Key = false;
                this.result.a2Key_ = null;
                return this;
            }

            public GetA8KeyReq.Builder ClearAppID()
            {
                this.PrepareBuilder();
                this.result.hasAppID = false;
                this.result.appID_ = null;
                return this;
            }

            public GetA8KeyReq.Builder ClearBaseRequest()
            {
                this.PrepareBuilder();
                this.result.hasBaseRequest = false;
                this.result.baseRequest_ = null;
                return this;
            }

            public GetA8KeyReq.Builder ClearFriendQQ()
            {
                this.PrepareBuilder();
                this.result.hasFriendQQ = false;
                this.result.friendQQ_ = 0;
                return this;
            }

            public GetA8KeyReq.Builder ClearFriendUserName()
            {
                this.PrepareBuilder();
                this.result.hasFriendUserName = false;
                this.result.friendUserName_ = "";
                return this;
            }

            public GetA8KeyReq.Builder ClearOpCode()
            {
                this.PrepareBuilder();
                this.result.hasOpCode = false;
                this.result.opCode_ = 0;
                return this;
            }

            public GetA8KeyReq.Builder ClearReqUrl()
            {
                this.PrepareBuilder();
                this.result.hasReqUrl = false;
                this.result.reqUrl_ = null;
                return this;
            }

            public GetA8KeyReq.Builder ClearScene()
            {
                this.PrepareBuilder();
                this.result.hasScene = false;
                this.result.scene_ = 0;
                return this;
            }

            public GetA8KeyReq.Builder ClearScope()
            {
                this.PrepareBuilder();
                this.result.hasScope = false;
                this.result.scope_ = null;
                return this;
            }

            public GetA8KeyReq.Builder ClearState()
            {
                this.PrepareBuilder();
                this.result.hasState = false;
                this.result.state_ = null;
                return this;
            }

            public GetA8KeyReq.Builder ClearUserName()
            {
                this.PrepareBuilder();
                this.result.hasUserName = false;
                this.result.userName_ = "";
                return this;
            }

            public override GetA8KeyReq.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new GetA8KeyReq.Builder(this.result);
                }
                return new GetA8KeyReq.Builder().MergeFrom(this.result);
            }

            public GetA8KeyReq.Builder MergeA2Key(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasA2Key && (this.result.a2Key_ != SKBuiltinBuffer_t.DefaultInstance))
                {
                    this.result.a2Key_ = SKBuiltinBuffer_t.CreateBuilder(this.result.a2Key_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.a2Key_ = value;
                }
                this.result.hasA2Key = true;
                return this;
            }

            public GetA8KeyReq.Builder MergeAppID(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasAppID && (this.result.appID_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.appID_ = SKBuiltinString_t.CreateBuilder(this.result.appID_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.appID_ = value;
                }
                this.result.hasAppID = true;
                return this;
            }

            public GetA8KeyReq.Builder MergeBaseRequest(micromsg.BaseRequest value)
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

            public override GetA8KeyReq.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override GetA8KeyReq.Builder MergeFrom(IMessageLite other)
            {
                if (other is GetA8KeyReq)
                {
                    return this.MergeFrom((GetA8KeyReq) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override GetA8KeyReq.Builder MergeFrom(GetA8KeyReq other)
            {
                return this;
            }

            public override GetA8KeyReq.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(GetA8KeyReq._getA8KeyReqFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = GetA8KeyReq._getA8KeyReqFieldTags[index];
                        }
                        else
                        {
                            this.ParseUnknownField(input, extensionRegistry, num, str);
                            continue;
                        }
                    }
                    switch (num)
                    {
                        case 0x1a:
                        {
                            SKBuiltinBuffer_t.Builder builder2 = SKBuiltinBuffer_t.CreateBuilder();
                            if (this.result.hasA2Key)
                            {
                                builder2.MergeFrom(this.A2Key);
                            }
                            input.ReadMessage(builder2, extensionRegistry);
                            this.A2Key = builder2.BuildPartial();
                            continue;
                        }
                        case 0x22:
                        {
                            SKBuiltinString_t.Builder builder3 = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasAppID)
                            {
                                builder3.MergeFrom(this.AppID);
                            }
                            input.ReadMessage(builder3, extensionRegistry);
                            this.AppID = builder3.BuildPartial();
                            continue;
                        }
                        case 0x2a:
                        {
                            SKBuiltinString_t.Builder builder4 = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasScope)
                            {
                                builder4.MergeFrom(this.Scope);
                            }
                            input.ReadMessage(builder4, extensionRegistry);
                            this.Scope = builder4.BuildPartial();
                            continue;
                        }
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
                        case 0x10:
                        {
                            this.result.hasOpCode = input.ReadUInt32(ref this.result.opCode_);
                            continue;
                        }
                        case 50:
                        {
                            SKBuiltinString_t.Builder builder5 = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasState)
                            {
                                builder5.MergeFrom(this.State);
                            }
                            input.ReadMessage(builder5, extensionRegistry);
                            this.State = builder5.BuildPartial();
                            continue;
                        }
                        case 0x3a:
                        {
                            SKBuiltinString_t.Builder builder6 = SKBuiltinString_t.CreateBuilder();
                            if (this.result.hasReqUrl)
                            {
                                builder6.MergeFrom(this.ReqUrl);
                            }
                            input.ReadMessage(builder6, extensionRegistry);
                            this.ReqUrl = builder6.BuildPartial();
                            continue;
                        }
                        case 0x42:
                        {
                            this.result.hasFriendUserName = input.ReadString(ref this.result.friendUserName_);
                            continue;
                        }
                        case 0x48:
                        {
                            this.result.hasFriendQQ = input.ReadUInt32(ref this.result.friendQQ_);
                            continue;
                        }
                        case 80:
                        {
                            this.result.hasScene = input.ReadUInt32(ref this.result.scene_);
                            continue;
                        }
                        case 90:
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
                    this.result.hasUserName = input.ReadString(ref this.result.userName_);
                }
                return this;
            }

            public GetA8KeyReq.Builder MergeReqUrl(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasReqUrl && (this.result.reqUrl_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.reqUrl_ = SKBuiltinString_t.CreateBuilder(this.result.reqUrl_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.reqUrl_ = value;
                }
                this.result.hasReqUrl = true;
                return this;
            }

            public GetA8KeyReq.Builder MergeScope(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasScope && (this.result.scope_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.scope_ = SKBuiltinString_t.CreateBuilder(this.result.scope_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.scope_ = value;
                }
                this.result.hasScope = true;
                return this;
            }

            public GetA8KeyReq.Builder MergeState(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasState && (this.result.state_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.state_ = SKBuiltinString_t.CreateBuilder(this.result.state_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.state_ = value;
                }
                this.result.hasState = true;
                return this;
            }

            private GetA8KeyReq PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    GetA8KeyReq result = this.result;
                    this.result = new GetA8KeyReq();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public GetA8KeyReq.Builder SetA2Key(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasA2Key = true;
                this.result.a2Key_ = value;
                return this;
            }

            public GetA8KeyReq.Builder SetA2Key(SKBuiltinBuffer_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasA2Key = true;
                this.result.a2Key_ = builderForValue.Build();
                return this;
            }

            public GetA8KeyReq.Builder SetAppID(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasAppID = true;
                this.result.appID_ = value;
                return this;
            }

            public GetA8KeyReq.Builder SetAppID(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasAppID = true;
                this.result.appID_ = builderForValue.Build();
                return this;
            }

            public GetA8KeyReq.Builder SetBaseRequest(micromsg.BaseRequest value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = value;
                return this;
            }

            public GetA8KeyReq.Builder SetBaseRequest(micromsg.BaseRequest.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = builderForValue.Build();
                return this;
            }

            public GetA8KeyReq.Builder SetFriendQQ(uint value)
            {
                this.PrepareBuilder();
                this.result.hasFriendQQ = true;
                this.result.friendQQ_ = value;
                return this;
            }

            public GetA8KeyReq.Builder SetFriendUserName(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasFriendUserName = true;
                this.result.friendUserName_ = value;
                return this;
            }

            public GetA8KeyReq.Builder SetOpCode(uint value)
            {
                this.PrepareBuilder();
                this.result.hasOpCode = true;
                this.result.opCode_ = value;
                return this;
            }

            public GetA8KeyReq.Builder SetReqUrl(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasReqUrl = true;
                this.result.reqUrl_ = value;
                return this;
            }

            public GetA8KeyReq.Builder SetReqUrl(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasReqUrl = true;
                this.result.reqUrl_ = builderForValue.Build();
                return this;
            }

            public GetA8KeyReq.Builder SetScene(uint value)
            {
                this.PrepareBuilder();
                this.result.hasScene = true;
                this.result.scene_ = value;
                return this;
            }

            public GetA8KeyReq.Builder SetScope(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasScope = true;
                this.result.scope_ = value;
                return this;
            }

            public GetA8KeyReq.Builder SetScope(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasScope = true;
                this.result.scope_ = builderForValue.Build();
                return this;
            }

            public GetA8KeyReq.Builder SetState(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasState = true;
                this.result.state_ = value;
                return this;
            }

            public GetA8KeyReq.Builder SetState(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasState = true;
                this.result.state_ = builderForValue.Build();
                return this;
            }

            public GetA8KeyReq.Builder SetUserName(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasUserName = true;
                this.result.userName_ = value;
                return this;
            }

            public SKBuiltinBuffer_t A2Key
            {
                get
                {
                    return this.result.A2Key;
                }
                set
                {
                    this.SetA2Key(value);
                }
            }

            public SKBuiltinString_t AppID
            {
                get
                {
                    return this.result.AppID;
                }
                set
                {
                    this.SetAppID(value);
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

            public override GetA8KeyReq DefaultInstanceForType
            {
                get
                {
                    return GetA8KeyReq.DefaultInstance;
                }
            }

            public uint FriendQQ
            {
                get
                {
                    return this.result.FriendQQ;
                }
                set
                {
                    this.SetFriendQQ(value);
                }
            }

            public string FriendUserName
            {
                get
                {
                    return this.result.FriendUserName;
                }
                set
                {
                    this.SetFriendUserName(value);
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override GetA8KeyReq MessageBeingBuilt
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

            public SKBuiltinString_t ReqUrl
            {
                get
                {
                    return this.result.ReqUrl;
                }
                set
                {
                    this.SetReqUrl(value);
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

            public SKBuiltinString_t Scope
            {
                get
                {
                    return this.result.Scope;
                }
                set
                {
                    this.SetScope(value);
                }
            }

            public SKBuiltinString_t State
            {
                get
                {
                    return this.result.State;
                }
                set
                {
                    this.SetState(value);
                }
            }

            protected override GetA8KeyReq.Builder ThisBuilder
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


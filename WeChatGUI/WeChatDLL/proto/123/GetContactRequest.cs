namespace micromsg
{
    using Google.ProtocolBuffers;
    using Google.ProtocolBuffers.Collections;

    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    


    public sealed class GetContactRequest : GeneratedMessageLite<GetContactRequest, GetContactRequest.Builder>
    {
        private static readonly string[] _getContactRequestFieldNames = new string[] { "BaseRequest", "UserCount", "UserNameList" };
        private static readonly uint[] _getContactRequestFieldTags = new uint[] { 10, 0x10, 0x1a };
        private micromsg.BaseRequest baseRequest_;
        public const int BaseRequestFieldNumber = 1;
        private static readonly GetContactRequest defaultInstance = new GetContactRequest();
        private bool hasBaseRequest;
        private bool hasUserCount;
        private int memoizedSerializedSize = -1;
        private uint userCount_;
        public const int UserCountFieldNumber = 2;
        private PopsicleList<SKBuiltinString_t> userNameList_ = new PopsicleList<SKBuiltinString_t>();
        public const int UserNameListFieldNumber = 3;

        static GetContactRequest()
        {

        }

        private GetContactRequest()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(GetContactRequest prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            GetContactRequest request = obj as GetContactRequest;
            if (request == null)
            {
                return false;
            }
            if ((this.hasBaseRequest != request.hasBaseRequest) || (this.hasBaseRequest && !this.baseRequest_.Equals(request.baseRequest_)))
            {
                return false;
            }
            if ((this.hasUserCount != request.hasUserCount) || (this.hasUserCount && !this.userCount_.Equals(request.userCount_)))
            {
                return false;
            }
            if (this.userNameList_.Count != request.userNameList_.Count)
            {
                return false;
            }
            for (int i = 0; i < this.userNameList_.Count; i++)
            {
                if (!this.userNameList_[i].Equals(request.userNameList_[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasBaseRequest)
            {
                hashCode ^= this.baseRequest_.GetHashCode();
            }
            if (this.hasUserCount)
            {
                hashCode ^= this.userCount_.GetHashCode();
            }
            foreach (SKBuiltinString_t _t in this.userNameList_)
            {
                hashCode ^= _t.GetHashCode();
            }
            return hashCode;
        }

        public SKBuiltinString_t GetUserNameList(int index)
        {
            return this.userNameList_[index];
        }

        private GetContactRequest MakeReadOnly()
        {
            this.userNameList_.MakeReadOnly();
            return this;
        }

        public static GetContactRequest ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<GetContactRequest, Builder>.PrintField("BaseRequest", this.hasBaseRequest, this.baseRequest_, writer);
            GeneratedMessageLite<GetContactRequest, Builder>.PrintField("UserCount", this.hasUserCount, this.userCount_, writer);
            GeneratedMessageLite<GetContactRequest, Builder>.PrintField<SKBuiltinString_t>("UserNameList", this.userNameList_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _getContactRequestFieldNames;
            if (this.hasBaseRequest)
            {
                output.WriteMessage(1, strArray[0], this.BaseRequest);
            }
            if (this.hasUserCount)
            {
                output.WriteUInt32(2, strArray[1], this.UserCount);
            }
            if (this.userNameList_.Count > 0)
            {
                output.WriteMessageArray<SKBuiltinString_t>(3, strArray[2], this.userNameList_);
            }
        }

        public micromsg.BaseRequest BaseRequest
        {
            get
            {
                return (this.baseRequest_ ?? micromsg.BaseRequest.DefaultInstance);
            }
        }

        public static GetContactRequest DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override GetContactRequest DefaultInstanceForType
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
                if (!this.hasUserCount)
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
                    if (this.hasUserCount)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(2, this.UserCount);
                    }
                    foreach (SKBuiltinString_t _t in this.UserNameListList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(3, _t);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override GetContactRequest ThisMessage
        {
            get
            {
                return this;
            }
        }

        public uint UserCount
        {
            get
            {
                return this.userCount_;
            }
        }

        public int UserNameListCount
        {
            get
            {
                return this.userNameList_.Count;
            }
        }

        public IList<SKBuiltinString_t> UserNameListList
        {
            get
            {
                return this.userNameList_;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<GetContactRequest, GetContactRequest.Builder>
        {
            private GetContactRequest result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = GetContactRequest.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(GetContactRequest cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public GetContactRequest.Builder AddRangeUserNameList(IEnumerable<SKBuiltinString_t> values)
            {
                this.PrepareBuilder();
                this.result.userNameList_.Add(values);
                return this;
            }

            public GetContactRequest.Builder AddUserNameList(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.userNameList_.Add(value);
                return this;
            }

            public GetContactRequest.Builder AddUserNameList(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.userNameList_.Add(builderForValue.Build());
                return this;
            }

            public override GetContactRequest BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override GetContactRequest.Builder Clear()
            {
                this.result = GetContactRequest.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public GetContactRequest.Builder ClearBaseRequest()
            {
                this.PrepareBuilder();
                this.result.hasBaseRequest = false;
                this.result.baseRequest_ = null;
                return this;
            }

            public GetContactRequest.Builder ClearUserCount()
            {
                this.PrepareBuilder();
                this.result.hasUserCount = false;
                this.result.userCount_ = 0;
                return this;
            }

            public GetContactRequest.Builder ClearUserNameList()
            {
                this.PrepareBuilder();
                this.result.userNameList_.Clear();
                return this;
            }

            public override GetContactRequest.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new GetContactRequest.Builder(this.result);
                }
                return new GetContactRequest.Builder().MergeFrom(this.result);
            }

            public SKBuiltinString_t GetUserNameList(int index)
            {
                return this.result.GetUserNameList(index);
            }

            public GetContactRequest.Builder MergeBaseRequest(micromsg.BaseRequest value)
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

            public override GetContactRequest.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override GetContactRequest.Builder MergeFrom(IMessageLite other)
            {
                if (other is GetContactRequest)
                {
                    return this.MergeFrom((GetContactRequest) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override GetContactRequest.Builder MergeFrom(GetContactRequest other)
            {
                return this;
            }

            public override GetContactRequest.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(GetContactRequest._getContactRequestFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = GetContactRequest._getContactRequestFieldTags[index];
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
                        case 0x10:
                        {
                            this.result.hasUserCount = input.ReadUInt32(ref this.result.userCount_);
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
                    input.ReadMessageArray<SKBuiltinString_t>(num, str, this.result.userNameList_, SKBuiltinString_t.DefaultInstance, extensionRegistry);
                }
                return this;
            }

            private GetContactRequest PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    GetContactRequest result = this.result;
                    this.result = new GetContactRequest();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public GetContactRequest.Builder SetBaseRequest(micromsg.BaseRequest value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = value;
                return this;
            }

            public GetContactRequest.Builder SetBaseRequest(micromsg.BaseRequest.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = builderForValue.Build();
                return this;
            }

            public GetContactRequest.Builder SetUserCount(uint value)
            {
                this.PrepareBuilder();
                this.result.hasUserCount = true;
                this.result.userCount_ = value;
                return this;
            }

            public GetContactRequest.Builder SetUserNameList(int index, SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.userNameList_[index] = value;
                return this;
            }

            public GetContactRequest.Builder SetUserNameList(int index, SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.userNameList_[index] = builderForValue.Build();
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

            public override GetContactRequest DefaultInstanceForType
            {
                get
                {
                    return GetContactRequest.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override GetContactRequest MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override GetContactRequest.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }

            public uint UserCount
            {
                get
                {
                    return this.result.UserCount;
                }
                set
                {
                    this.SetUserCount(value);
                }
            }

            public int UserNameListCount
            {
                get
                {
                    return this.result.UserNameListCount;
                }
            }

            public IPopsicleList<SKBuiltinString_t> UserNameListList
            {
                get
                {
                    return this.PrepareBuilder().userNameList_;
                }
            }
        }
    }
}


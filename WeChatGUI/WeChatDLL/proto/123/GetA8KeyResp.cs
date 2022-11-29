namespace micromsg
{
    using Google.ProtocolBuffers;

    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

    public sealed class GetA8KeyResp : GeneratedMessageLite<GetA8KeyResp, GetA8KeyResp.Builder>
    {
        private static readonly string[] _getA8KeyRespFieldNames = new string[] { "A8Key", "ActionCode", "BaseResponse", "Content", "FullURL", "GeneralControlBitSet", "JSAPIPermission", "Title" };
        private static readonly uint[] _getA8KeyRespFieldTags = new uint[] { 0x1a, 0x20, 10, 50, 0x12, 0x42, 0x3a, 0x2a };
        private string a8Key_ = "";
        public const int A8KeyFieldNumber = 3;
        private uint actionCode_;
        public const int ActionCodeFieldNumber = 4;
        private micromsg.BaseResponse baseResponse_;
        public const int BaseResponseFieldNumber = 1;
        private string content_ = "";
        public const int ContentFieldNumber = 6;
        private static readonly GetA8KeyResp defaultInstance = new GetA8KeyResp().MakeReadOnly();
        private string fullURL_ = "";
        public const int FullURLFieldNumber = 2;
        private micromsg.GeneralControlBitSet generalControlBitSet_;
        public const int GeneralControlBitSetFieldNumber = 8;
        private bool hasA8Key;
        private bool hasActionCode;
        private bool hasBaseResponse;
        private bool hasContent;
        private bool hasFullURL;
        private bool hasGeneralControlBitSet;
        private bool hasJSAPIPermission;
        private bool hasTitle;
        private JSAPIPermissionBitSet jSAPIPermission_;
        public const int JSAPIPermissionFieldNumber = 7;
        private int memoizedSerializedSize = -1;
        private string title_ = "";
        public const int TitleFieldNumber = 5;

        static GetA8KeyResp()
        {

        }

        private GetA8KeyResp()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(GetA8KeyResp prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            GetA8KeyResp resp = obj as GetA8KeyResp;
            if (resp == null)
            {
                return false;
            }
            if ((this.hasBaseResponse != resp.hasBaseResponse) || (this.hasBaseResponse && !this.baseResponse_.Equals(resp.baseResponse_)))
            {
                return false;
            }
            if ((this.hasFullURL != resp.hasFullURL) || (this.hasFullURL && !this.fullURL_.Equals(resp.fullURL_)))
            {
                return false;
            }
            if ((this.hasA8Key != resp.hasA8Key) || (this.hasA8Key && !this.a8Key_.Equals(resp.a8Key_)))
            {
                return false;
            }
            if ((this.hasActionCode != resp.hasActionCode) || (this.hasActionCode && !this.actionCode_.Equals(resp.actionCode_)))
            {
                return false;
            }
            if ((this.hasTitle != resp.hasTitle) || (this.hasTitle && !this.title_.Equals(resp.title_)))
            {
                return false;
            }
            if ((this.hasContent != resp.hasContent) || (this.hasContent && !this.content_.Equals(resp.content_)))
            {
                return false;
            }
            if ((this.hasJSAPIPermission != resp.hasJSAPIPermission) || (this.hasJSAPIPermission && !this.jSAPIPermission_.Equals(resp.jSAPIPermission_)))
            {
                return false;
            }
            return ((this.hasGeneralControlBitSet == resp.hasGeneralControlBitSet) && (!this.hasGeneralControlBitSet || this.generalControlBitSet_.Equals(resp.generalControlBitSet_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasBaseResponse)
            {
                hashCode ^= this.baseResponse_.GetHashCode();
            }
            if (this.hasFullURL)
            {
                hashCode ^= this.fullURL_.GetHashCode();
            }
            if (this.hasA8Key)
            {
                hashCode ^= this.a8Key_.GetHashCode();
            }
            if (this.hasActionCode)
            {
                hashCode ^= this.actionCode_.GetHashCode();
            }
            if (this.hasTitle)
            {
                hashCode ^= this.title_.GetHashCode();
            }
            if (this.hasContent)
            {
                hashCode ^= this.content_.GetHashCode();
            }
            if (this.hasJSAPIPermission)
            {
                hashCode ^= this.jSAPIPermission_.GetHashCode();
            }
            if (this.hasGeneralControlBitSet)
            {
                hashCode ^= this.generalControlBitSet_.GetHashCode();
            }
            return hashCode;
        }

        private GetA8KeyResp MakeReadOnly()
        {
            return this;
        }

        public static GetA8KeyResp ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<GetA8KeyResp, Builder>.PrintField("BaseResponse", this.hasBaseResponse, this.baseResponse_, writer);
            GeneratedMessageLite<GetA8KeyResp, Builder>.PrintField("FullURL", this.hasFullURL, this.fullURL_, writer);
            GeneratedMessageLite<GetA8KeyResp, Builder>.PrintField("A8Key", this.hasA8Key, this.a8Key_, writer);
            GeneratedMessageLite<GetA8KeyResp, Builder>.PrintField("ActionCode", this.hasActionCode, this.actionCode_, writer);
            GeneratedMessageLite<GetA8KeyResp, Builder>.PrintField("Title", this.hasTitle, this.title_, writer);
            GeneratedMessageLite<GetA8KeyResp, Builder>.PrintField("Content", this.hasContent, this.content_, writer);
            GeneratedMessageLite<GetA8KeyResp, Builder>.PrintField("JSAPIPermission", this.hasJSAPIPermission, this.jSAPIPermission_, writer);
            GeneratedMessageLite<GetA8KeyResp, Builder>.PrintField("GeneralControlBitSet", this.hasGeneralControlBitSet, this.generalControlBitSet_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _getA8KeyRespFieldNames;
            if (this.hasBaseResponse)
            {
                output.WriteMessage(1, strArray[2], this.BaseResponse);
            }
            if (this.hasFullURL)
            {
                output.WriteString(2, strArray[4], this.FullURL);
            }
            if (this.hasA8Key)
            {
                output.WriteString(3, strArray[0], this.A8Key);
            }
            if (this.hasActionCode)
            {
                output.WriteUInt32(4, strArray[1], this.ActionCode);
            }
            if (this.hasTitle)
            {
                output.WriteString(5, strArray[7], this.Title);
            }
            if (this.hasContent)
            {
                output.WriteString(6, strArray[3], this.Content);
            }
            if (this.hasJSAPIPermission)
            {
                output.WriteMessage(7, strArray[6], this.JSAPIPermission);
            }
            if (this.hasGeneralControlBitSet)
            {
                output.WriteMessage(8, strArray[5], this.GeneralControlBitSet);
            }
        }

        public string A8Key
        {
            get
            {
                return this.a8Key_;
            }
        }

        public uint ActionCode
        {
            get
            {
                return this.actionCode_;
            }
        }

        public micromsg.BaseResponse BaseResponse
        {
            get
            {
                return (this.baseResponse_ ?? micromsg.BaseResponse.DefaultInstance);
            }
        }

        public string Content
        {
            get
            {
                return this.content_;
            }
        }

        public static GetA8KeyResp DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override GetA8KeyResp DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public string FullURL
        {
            get
            {
                return this.fullURL_;
            }
        }

        public micromsg.GeneralControlBitSet GeneralControlBitSet
        {
            get
            {
                return (this.generalControlBitSet_ ?? micromsg.GeneralControlBitSet.DefaultInstance);
            }
        }

        public override bool IsInitialized
        {
            get
            {
                if (!this.hasBaseResponse)
                {
                    return false;
                }
                if (!this.BaseResponse.IsInitialized)
                {
                    return false;
                }
                return true;
            }
        }

        public JSAPIPermissionBitSet JSAPIPermission
        {
            get
            {
                return (this.jSAPIPermission_ ?? JSAPIPermissionBitSet.DefaultInstance);
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
                    if (this.hasBaseResponse)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(1, this.BaseResponse);
                    }
                    if (this.hasFullURL)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(2, this.FullURL);
                    }
                    if (this.hasA8Key)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(3, this.A8Key);
                    }
                    if (this.hasActionCode)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(4, this.ActionCode);
                    }
                    if (this.hasTitle)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(5, this.Title);
                    }
                    if (this.hasContent)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(6, this.Content);
                    }
                    if (this.hasJSAPIPermission)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(7, this.JSAPIPermission);
                    }
                    if (this.hasGeneralControlBitSet)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(8, this.GeneralControlBitSet);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override GetA8KeyResp ThisMessage
        {
            get
            {
                return this;
            }
        }

        public string Title
        {
            get
            {
                return this.title_;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<GetA8KeyResp, GetA8KeyResp.Builder>
        {
            private GetA8KeyResp result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = GetA8KeyResp.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(GetA8KeyResp cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override GetA8KeyResp BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override GetA8KeyResp.Builder Clear()
            {
                this.result = GetA8KeyResp.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public GetA8KeyResp.Builder ClearA8Key()
            {
                this.PrepareBuilder();
                this.result.hasA8Key = false;
                this.result.a8Key_ = "";
                return this;
            }

            public GetA8KeyResp.Builder ClearActionCode()
            {
                this.PrepareBuilder();
                this.result.hasActionCode = false;
                this.result.actionCode_ = 0;
                return this;
            }

            public GetA8KeyResp.Builder ClearBaseResponse()
            {
                this.PrepareBuilder();
                this.result.hasBaseResponse = false;
                this.result.baseResponse_ = null;
                return this;
            }

            public GetA8KeyResp.Builder ClearContent()
            {
                this.PrepareBuilder();
                this.result.hasContent = false;
                this.result.content_ = "";
                return this;
            }

            public GetA8KeyResp.Builder ClearFullURL()
            {
                this.PrepareBuilder();
                this.result.hasFullURL = false;
                this.result.fullURL_ = "";
                return this;
            }

            public GetA8KeyResp.Builder ClearGeneralControlBitSet()
            {
                this.PrepareBuilder();
                this.result.hasGeneralControlBitSet = false;
                this.result.generalControlBitSet_ = null;
                return this;
            }

            public GetA8KeyResp.Builder ClearJSAPIPermission()
            {
                this.PrepareBuilder();
                this.result.hasJSAPIPermission = false;
                this.result.jSAPIPermission_ = null;
                return this;
            }

            public GetA8KeyResp.Builder ClearTitle()
            {
                this.PrepareBuilder();
                this.result.hasTitle = false;
                this.result.title_ = "";
                return this;
            }

            public override GetA8KeyResp.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new GetA8KeyResp.Builder(this.result);
                }
                return new GetA8KeyResp.Builder().MergeFrom(this.result);
            }

            public GetA8KeyResp.Builder MergeBaseResponse(micromsg.BaseResponse value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasBaseResponse && (this.result.baseResponse_ != micromsg.BaseResponse.DefaultInstance))
                {
                    this.result.baseResponse_ = micromsg.BaseResponse.CreateBuilder(this.result.baseResponse_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.baseResponse_ = value;
                }
                this.result.hasBaseResponse = true;
                return this;
            }

            public override GetA8KeyResp.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override GetA8KeyResp.Builder MergeFrom(IMessageLite other)
            {
                if (other is GetA8KeyResp)
                {
                    return this.MergeFrom((GetA8KeyResp) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override GetA8KeyResp.Builder MergeFrom(GetA8KeyResp other)
            {
                return this;
            }

            public override GetA8KeyResp.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(GetA8KeyResp._getA8KeyRespFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = GetA8KeyResp._getA8KeyRespFieldTags[index];
                        }
                        else
                        {
                            this.ParseUnknownField(input, extensionRegistry, num, str);
                            continue;
                        }
                    }
                    switch (num)
                    {
                        case 0x12:
                        {
                            this.result.hasFullURL = input.ReadString(ref this.result.fullURL_);
                            continue;
                        }
                        case 0x1a:
                        {
                            this.result.hasA8Key = input.ReadString(ref this.result.a8Key_);
                            continue;
                        }
                        case 0:
                            throw InvalidProtocolBufferException.InvalidTag();

                        case 10:
                        {
                            micromsg.BaseResponse.Builder builder = micromsg.BaseResponse.CreateBuilder();
                            if (this.result.hasBaseResponse)
                            {
                                builder.MergeFrom(this.BaseResponse);
                            }
                            input.ReadMessage(builder, extensionRegistry);
                            this.BaseResponse = builder.BuildPartial();
                            continue;
                        }
                        case 0x20:
                        {
                            this.result.hasActionCode = input.ReadUInt32(ref this.result.actionCode_);
                            continue;
                        }
                        case 0x2a:
                        {
                            this.result.hasTitle = input.ReadString(ref this.result.title_);
                            continue;
                        }
                        case 50:
                        {
                            this.result.hasContent = input.ReadString(ref this.result.content_);
                            continue;
                        }
                        case 0x3a:
                        {
                            JSAPIPermissionBitSet.Builder builder2 = JSAPIPermissionBitSet.CreateBuilder();
                            if (this.result.hasJSAPIPermission)
                            {
                                builder2.MergeFrom(this.JSAPIPermission);
                            }
                            input.ReadMessage(builder2, extensionRegistry);
                            this.JSAPIPermission = builder2.BuildPartial();
                            continue;
                        }
                        case 0x42:
                        {
                            micromsg.GeneralControlBitSet.Builder builder3 = micromsg.GeneralControlBitSet.CreateBuilder();
                            if (this.result.hasGeneralControlBitSet)
                            {
                                builder3.MergeFrom(this.GeneralControlBitSet);
                            }
                            input.ReadMessage(builder3, extensionRegistry);
                            this.GeneralControlBitSet = builder3.BuildPartial();
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

            public GetA8KeyResp.Builder MergeGeneralControlBitSet(micromsg.GeneralControlBitSet value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasGeneralControlBitSet && (this.result.generalControlBitSet_ != micromsg.GeneralControlBitSet.DefaultInstance))
                {
                    this.result.generalControlBitSet_ = micromsg.GeneralControlBitSet.CreateBuilder(this.result.generalControlBitSet_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.generalControlBitSet_ = value;
                }
                this.result.hasGeneralControlBitSet = true;
                return this;
            }

            public GetA8KeyResp.Builder MergeJSAPIPermission(JSAPIPermissionBitSet value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasJSAPIPermission && (this.result.jSAPIPermission_ != JSAPIPermissionBitSet.DefaultInstance))
                {
                    this.result.jSAPIPermission_ = JSAPIPermissionBitSet.CreateBuilder(this.result.jSAPIPermission_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.jSAPIPermission_ = value;
                }
                this.result.hasJSAPIPermission = true;
                return this;
            }

            private GetA8KeyResp PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    GetA8KeyResp result = this.result;
                    this.result = new GetA8KeyResp();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public GetA8KeyResp.Builder SetA8Key(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasA8Key = true;
                this.result.a8Key_ = value;
                return this;
            }

            public GetA8KeyResp.Builder SetActionCode(uint value)
            {
                this.PrepareBuilder();
                this.result.hasActionCode = true;
                this.result.actionCode_ = value;
                return this;
            }

            public GetA8KeyResp.Builder SetBaseResponse(micromsg.BaseResponse value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = value;
                return this;
            }

            public GetA8KeyResp.Builder SetBaseResponse(micromsg.BaseResponse.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = builderForValue.Build();
                return this;
            }

            public GetA8KeyResp.Builder SetContent(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasContent = true;
                this.result.content_ = value;
                return this;
            }

            public GetA8KeyResp.Builder SetFullURL(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasFullURL = true;
                this.result.fullURL_ = value;
                return this;
            }

            public GetA8KeyResp.Builder SetGeneralControlBitSet(micromsg.GeneralControlBitSet value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasGeneralControlBitSet = true;
                this.result.generalControlBitSet_ = value;
                return this;
            }

            public GetA8KeyResp.Builder SetGeneralControlBitSet(micromsg.GeneralControlBitSet.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasGeneralControlBitSet = true;
                this.result.generalControlBitSet_ = builderForValue.Build();
                return this;
            }

            public GetA8KeyResp.Builder SetJSAPIPermission(JSAPIPermissionBitSet value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasJSAPIPermission = true;
                this.result.jSAPIPermission_ = value;
                return this;
            }

            public GetA8KeyResp.Builder SetJSAPIPermission(JSAPIPermissionBitSet.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasJSAPIPermission = true;
                this.result.jSAPIPermission_ = builderForValue.Build();
                return this;
            }

            public GetA8KeyResp.Builder SetTitle(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasTitle = true;
                this.result.title_ = value;
                return this;
            }

            public string A8Key
            {
                get
                {
                    return this.result.A8Key;
                }
                set
                {
                    this.SetA8Key(value);
                }
            }

            public uint ActionCode
            {
                get
                {
                    return this.result.ActionCode;
                }
                set
                {
                    this.SetActionCode(value);
                }
            }

            public micromsg.BaseResponse BaseResponse
            {
                get
                {
                    return this.result.BaseResponse;
                }
                set
                {
                    this.SetBaseResponse(value);
                }
            }

            public string Content
            {
                get
                {
                    return this.result.Content;
                }
                set
                {
                    this.SetContent(value);
                }
            }

            public override GetA8KeyResp DefaultInstanceForType
            {
                get
                {
                    return GetA8KeyResp.DefaultInstance;
                }
            }

            public string FullURL
            {
                get
                {
                    return this.result.FullURL;
                }
                set
                {
                    this.SetFullURL(value);
                }
            }

            public micromsg.GeneralControlBitSet GeneralControlBitSet
            {
                get
                {
                    return this.result.GeneralControlBitSet;
                }
                set
                {
                    this.SetGeneralControlBitSet(value);
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            public JSAPIPermissionBitSet JSAPIPermission
            {
                get
                {
                    return this.result.JSAPIPermission;
                }
                set
                {
                    this.SetJSAPIPermission(value);
                }
            }

            protected override GetA8KeyResp MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override GetA8KeyResp.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }

            public string Title
            {
                get
                {
                    return this.result.Title;
                }
                set
                {
                    this.SetTitle(value);
                }
            }
        }
    }
}


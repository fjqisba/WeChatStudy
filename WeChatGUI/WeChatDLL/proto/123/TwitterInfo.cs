namespace micromsg
{
    using Google.ProtocolBuffers;

    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    using System.Runtime.CompilerServices;


    public sealed class TwitterInfo : GeneratedMessageLite<TwitterInfo, TwitterInfo.Builder>
    {
        private static readonly string[] _twitterInfoFieldNames = new string[] { "Oauth_Token", "Oauth_Token_Secret" };
        private static readonly uint[] _twitterInfoFieldTags = new uint[] { 10, 0x12 };
        private static readonly TwitterInfo defaultInstance = new TwitterInfo().MakeReadOnly();
        private bool hasOauthToken;
        private bool hasOauthTokenSecret;
        private int memoizedSerializedSize = -1;
        private string oauthToken_ = "";
        public const int OauthTokenFieldNumber = 1;
        private string oauthTokenSecret_ = "";
        public const int OauthTokenSecretFieldNumber = 2;

        static TwitterInfo()
        {
  
        }

        private TwitterInfo()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(TwitterInfo prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            TwitterInfo info = obj as TwitterInfo;
            if (info == null)
            {
                return false;
            }
            if ((this.hasOauthToken != info.hasOauthToken) || (this.hasOauthToken && !this.oauthToken_.Equals(info.oauthToken_)))
            {
                return false;
            }
            return ((this.hasOauthTokenSecret == info.hasOauthTokenSecret) && (!this.hasOauthTokenSecret || this.oauthTokenSecret_.Equals(info.oauthTokenSecret_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasOauthToken)
            {
                hashCode ^= this.oauthToken_.GetHashCode();
            }
            if (this.hasOauthTokenSecret)
            {
                hashCode ^= this.oauthTokenSecret_.GetHashCode();
            }
            return hashCode;
        }

        private TwitterInfo MakeReadOnly()
        {
            return this;
        }

        public static TwitterInfo ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<TwitterInfo, Builder>.PrintField("Oauth_Token", this.hasOauthToken, this.oauthToken_, writer);
            GeneratedMessageLite<TwitterInfo, Builder>.PrintField("Oauth_Token_Secret", this.hasOauthTokenSecret, this.oauthTokenSecret_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _twitterInfoFieldNames;
            if (this.hasOauthToken)
            {
                output.WriteString(1, strArray[0], this.OauthToken);
            }
            if (this.hasOauthTokenSecret)
            {
                output.WriteString(2, strArray[1], this.OauthTokenSecret);
            }
        }

        public static TwitterInfo DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override TwitterInfo DefaultInstanceForType
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
                return true;
            }
        }

        public string OauthToken
        {
            get
            {
                return this.oauthToken_;
            }
        }

        public string OauthTokenSecret
        {
            get
            {
                return this.oauthTokenSecret_;
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
                    if (this.hasOauthToken)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(1, this.OauthToken);
                    }
                    if (this.hasOauthTokenSecret)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(2, this.OauthTokenSecret);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override TwitterInfo ThisMessage
        {
            get
            {
                return this;
            }
        }

        [GeneratedCode("ProtoGen", "2.3.0.277"), DebuggerNonUserCode, CompilerGenerated]
        public sealed class Builder : GeneratedBuilderLite<TwitterInfo, TwitterInfo.Builder>
        {
            private TwitterInfo result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = TwitterInfo.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(TwitterInfo cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override TwitterInfo BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override TwitterInfo.Builder Clear()
            {
                this.result = TwitterInfo.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public TwitterInfo.Builder ClearOauthToken()
            {
                this.PrepareBuilder();
                this.result.hasOauthToken = false;
                this.result.oauthToken_ = "";
                return this;
            }

            public TwitterInfo.Builder ClearOauthTokenSecret()
            {
                this.PrepareBuilder();
                this.result.hasOauthTokenSecret = false;
                this.result.oauthTokenSecret_ = "";
                return this;
            }

            public override TwitterInfo.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new TwitterInfo.Builder(this.result);
                }
                return new TwitterInfo.Builder().MergeFrom(this.result);
            }

            public override TwitterInfo.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override TwitterInfo.Builder MergeFrom(IMessageLite other)
            {
                if (other is TwitterInfo)
                {
                    return this.MergeFrom((TwitterInfo) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override TwitterInfo.Builder MergeFrom(TwitterInfo other)
            {
                return this;
            }

            public override TwitterInfo.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(TwitterInfo._twitterInfoFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = TwitterInfo._twitterInfoFieldTags[index];
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
                            this.result.hasOauthToken = input.ReadString(ref this.result.oauthToken_);
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
                    this.result.hasOauthTokenSecret = input.ReadString(ref this.result.oauthTokenSecret_);
                }
                return this;
            }

            private TwitterInfo PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    TwitterInfo result = this.result;
                    this.result = new TwitterInfo();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public TwitterInfo.Builder SetOauthToken(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasOauthToken = true;
                this.result.oauthToken_ = value;
                return this;
            }

            public TwitterInfo.Builder SetOauthTokenSecret(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasOauthTokenSecret = true;
                this.result.oauthTokenSecret_ = value;
                return this;
            }

            public override TwitterInfo DefaultInstanceForType
            {
                get
                {
                    return TwitterInfo.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override TwitterInfo MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public string OauthToken
            {
                get
                {
                    return this.result.OauthToken;
                }
                set
                {
                    this.SetOauthToken(value);
                }
            }

            public string OauthTokenSecret
            {
                get
                {
                    return this.result.OauthTokenSecret;
                }
                set
                {
                    this.SetOauthTokenSecret(value);
                }
            }

            protected override TwitterInfo.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}

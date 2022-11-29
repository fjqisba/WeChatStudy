namespace micromsg
{
    using Google.ProtocolBuffers;

    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    using System.Runtime.CompilerServices;


    public sealed class LinkedinContactItem : GeneratedMessageLite<LinkedinContactItem, LinkedinContactItem.Builder>
    {
        private static readonly string[] _linkedinContactItemFieldNames = new string[] { "LinkedinMemberID", "LinkedinName", "LinkedinPublicUrl" };
        private static readonly uint[] _linkedinContactItemFieldTags = new uint[] { 0x12, 10, 0x1a };
        private static readonly LinkedinContactItem defaultInstance = new LinkedinContactItem().MakeReadOnly();
        private bool hasLinkedinMemberID;
        private bool hasLinkedinName;
        private bool hasLinkedinPublicUrl;
        private string linkedinMemberID_ = "";
        public const int LinkedinMemberIDFieldNumber = 2;
        private string linkedinName_ = "";
        public const int LinkedinNameFieldNumber = 1;
        private string linkedinPublicUrl_ = "";
        public const int LinkedinPublicUrlFieldNumber = 3;
        private int memoizedSerializedSize = -1;

        static LinkedinContactItem()
        {
         
        }

        private LinkedinContactItem()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(LinkedinContactItem prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            LinkedinContactItem item = obj as LinkedinContactItem;
            if (item == null)
            {
                return false;
            }
            if ((this.hasLinkedinName != item.hasLinkedinName) || (this.hasLinkedinName && !this.linkedinName_.Equals(item.linkedinName_)))
            {
                return false;
            }
            if ((this.hasLinkedinMemberID != item.hasLinkedinMemberID) || (this.hasLinkedinMemberID && !this.linkedinMemberID_.Equals(item.linkedinMemberID_)))
            {
                return false;
            }
            return ((this.hasLinkedinPublicUrl == item.hasLinkedinPublicUrl) && (!this.hasLinkedinPublicUrl || this.linkedinPublicUrl_.Equals(item.linkedinPublicUrl_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasLinkedinName)
            {
                hashCode ^= this.linkedinName_.GetHashCode();
            }
            if (this.hasLinkedinMemberID)
            {
                hashCode ^= this.linkedinMemberID_.GetHashCode();
            }
            if (this.hasLinkedinPublicUrl)
            {
                hashCode ^= this.linkedinPublicUrl_.GetHashCode();
            }
            return hashCode;
        }

        private LinkedinContactItem MakeReadOnly()
        {
            return this;
        }

        public static LinkedinContactItem ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<LinkedinContactItem, Builder>.PrintField("LinkedinName", this.hasLinkedinName, this.linkedinName_, writer);
            GeneratedMessageLite<LinkedinContactItem, Builder>.PrintField("LinkedinMemberID", this.hasLinkedinMemberID, this.linkedinMemberID_, writer);
            GeneratedMessageLite<LinkedinContactItem, Builder>.PrintField("LinkedinPublicUrl", this.hasLinkedinPublicUrl, this.linkedinPublicUrl_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _linkedinContactItemFieldNames;
            if (this.hasLinkedinName)
            {
                output.WriteString(1, strArray[1], this.LinkedinName);
            }
            if (this.hasLinkedinMemberID)
            {
                output.WriteString(2, strArray[0], this.LinkedinMemberID);
            }
            if (this.hasLinkedinPublicUrl)
            {
                output.WriteString(3, strArray[2], this.LinkedinPublicUrl);
            }
        }

        public static LinkedinContactItem DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override LinkedinContactItem DefaultInstanceForType
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

        public string LinkedinMemberID
        {
            get
            {
                return this.linkedinMemberID_;
            }
        }

        public string LinkedinName
        {
            get
            {
                return this.linkedinName_;
            }
        }

        public string LinkedinPublicUrl
        {
            get
            {
                return this.linkedinPublicUrl_;
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
                    if (this.hasLinkedinName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(1, this.LinkedinName);
                    }
                    if (this.hasLinkedinMemberID)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(2, this.LinkedinMemberID);
                    }
                    if (this.hasLinkedinPublicUrl)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(3, this.LinkedinPublicUrl);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override LinkedinContactItem ThisMessage
        {
            get
            {
                return this;
            }
        }

        [GeneratedCode("ProtoGen", "2.3.0.277"), DebuggerNonUserCode, CompilerGenerated]
        public sealed class Builder : GeneratedBuilderLite<LinkedinContactItem, LinkedinContactItem.Builder>
        {
            private LinkedinContactItem result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = LinkedinContactItem.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(LinkedinContactItem cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override LinkedinContactItem BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override LinkedinContactItem.Builder Clear()
            {
                this.result = LinkedinContactItem.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public LinkedinContactItem.Builder ClearLinkedinMemberID()
            {
                this.PrepareBuilder();
                this.result.hasLinkedinMemberID = false;
                this.result.linkedinMemberID_ = "";
                return this;
            }

            public LinkedinContactItem.Builder ClearLinkedinName()
            {
                this.PrepareBuilder();
                this.result.hasLinkedinName = false;
                this.result.linkedinName_ = "";
                return this;
            }

            public LinkedinContactItem.Builder ClearLinkedinPublicUrl()
            {
                this.PrepareBuilder();
                this.result.hasLinkedinPublicUrl = false;
                this.result.linkedinPublicUrl_ = "";
                return this;
            }

            public override LinkedinContactItem.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new LinkedinContactItem.Builder(this.result);
                }
                return new LinkedinContactItem.Builder().MergeFrom(this.result);
            }

            public override LinkedinContactItem.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override LinkedinContactItem.Builder MergeFrom(IMessageLite other)
            {
                if (other is LinkedinContactItem)
                {
                    return this.MergeFrom((LinkedinContactItem) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override LinkedinContactItem.Builder MergeFrom(LinkedinContactItem other)
            {
                return this;
            }

            public override LinkedinContactItem.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(LinkedinContactItem._linkedinContactItemFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = LinkedinContactItem._linkedinContactItemFieldTags[index];
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
                            this.result.hasLinkedinName = input.ReadString(ref this.result.linkedinName_);
                            continue;
                        }
                        case 0x12:
                        {
                            this.result.hasLinkedinMemberID = input.ReadString(ref this.result.linkedinMemberID_);
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
                    this.result.hasLinkedinPublicUrl = input.ReadString(ref this.result.linkedinPublicUrl_);
                }
                return this;
            }

            private LinkedinContactItem PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    LinkedinContactItem result = this.result;
                    this.result = new LinkedinContactItem();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public LinkedinContactItem.Builder SetLinkedinMemberID(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasLinkedinMemberID = true;
                this.result.linkedinMemberID_ = value;
                return this;
            }

            public LinkedinContactItem.Builder SetLinkedinName(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasLinkedinName = true;
                this.result.linkedinName_ = value;
                return this;
            }

            public LinkedinContactItem.Builder SetLinkedinPublicUrl(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasLinkedinPublicUrl = true;
                this.result.linkedinPublicUrl_ = value;
                return this;
            }

            public override LinkedinContactItem DefaultInstanceForType
            {
                get
                {
                    return LinkedinContactItem.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            public string LinkedinMemberID
            {
                get
                {
                    return this.result.LinkedinMemberID;
                }
                set
                {
                    this.SetLinkedinMemberID(value);
                }
            }

            public string LinkedinName
            {
                get
                {
                    return this.result.LinkedinName;
                }
                set
                {
                    this.SetLinkedinName(value);
                }
            }

            public string LinkedinPublicUrl
            {
                get
                {
                    return this.result.LinkedinPublicUrl;
                }
                set
                {
                    this.SetLinkedinPublicUrl(value);
                }
            }

            protected override LinkedinContactItem MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override LinkedinContactItem.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}

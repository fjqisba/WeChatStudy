namespace micromsg
{
    using Google.ProtocolBuffers;

    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    using System.Runtime.CompilerServices;


    public sealed class AdditionalContactList : GeneratedMessageLite<AdditionalContactList, AdditionalContactList.Builder>
    {
        private static readonly string[] _additionalContactListFieldNames = new string[] { "LinkedinContactItem" };
        private static readonly uint[] _additionalContactListFieldTags = new uint[] { 10 };
        private static readonly AdditionalContactList defaultInstance = new AdditionalContactList().MakeReadOnly();
        private bool hasLinkedinContactItem;
        private LinkedinContactItem linkedinContactItem_;
        public const int LinkedinContactItemFieldNumber = 1;
        private int memoizedSerializedSize = -1;

        static AdditionalContactList()
        {
            
        }

        private AdditionalContactList()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(AdditionalContactList prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            AdditionalContactList list = obj as AdditionalContactList;
            if (list == null)
            {
                return false;
            }
            return ((this.hasLinkedinContactItem == list.hasLinkedinContactItem) && (!this.hasLinkedinContactItem || this.linkedinContactItem_.Equals(list.linkedinContactItem_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasLinkedinContactItem)
            {
                hashCode ^= this.linkedinContactItem_.GetHashCode();
            }
            return hashCode;
        }

        private AdditionalContactList MakeReadOnly()
        {
            return this;
        }

        public static AdditionalContactList ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<AdditionalContactList, Builder>.PrintField("LinkedinContactItem", this.hasLinkedinContactItem, this.linkedinContactItem_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _additionalContactListFieldNames;
            if (this.hasLinkedinContactItem)
            {
                output.WriteMessage(1, strArray[0], this.LinkedinContactItem);
            }
        }

        public static AdditionalContactList DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override AdditionalContactList DefaultInstanceForType
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

        public LinkedinContactItem LinkedinContactItem
        {
            get
            {
                return (this.linkedinContactItem_ ?? LinkedinContactItem.DefaultInstance);
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
                    if (this.hasLinkedinContactItem)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(1, this.LinkedinContactItem);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override AdditionalContactList ThisMessage
        {
            get
            {
                return this;
            }
        }

        [GeneratedCode("ProtoGen", "2.3.0.277"), DebuggerNonUserCode, CompilerGenerated]
        public sealed class Builder : GeneratedBuilderLite<AdditionalContactList, AdditionalContactList.Builder>
        {
            private AdditionalContactList result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = AdditionalContactList.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(AdditionalContactList cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override AdditionalContactList BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override AdditionalContactList.Builder Clear()
            {
                this.result = AdditionalContactList.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public AdditionalContactList.Builder ClearLinkedinContactItem()
            {
                this.PrepareBuilder();
                this.result.hasLinkedinContactItem = false;
                this.result.linkedinContactItem_ = null;
                return this;
            }

            public override AdditionalContactList.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new AdditionalContactList.Builder(this.result);
                }
                return new AdditionalContactList.Builder().MergeFrom(this.result);
            }

            public override AdditionalContactList.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override AdditionalContactList.Builder MergeFrom(IMessageLite other)
            {
                if (other is AdditionalContactList)
                {
                    return this.MergeFrom((AdditionalContactList) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override AdditionalContactList.Builder MergeFrom(AdditionalContactList other)
            {
                return this;
            }

            public override AdditionalContactList.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(AdditionalContactList._additionalContactListFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = AdditionalContactList._additionalContactListFieldTags[index];
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
                            LinkedinContactItem.Builder builder = LinkedinContactItem.CreateBuilder();
                            if (this.result.hasLinkedinContactItem)
                            {
                                builder.MergeFrom(this.LinkedinContactItem);
                            }
                            input.ReadMessage(builder, extensionRegistry);
                            this.LinkedinContactItem = builder.BuildPartial();
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

            public AdditionalContactList.Builder MergeLinkedinContactItem(LinkedinContactItem value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasLinkedinContactItem && (this.result.linkedinContactItem_ != LinkedinContactItem.DefaultInstance))
                {
                    this.result.linkedinContactItem_ = LinkedinContactItem.CreateBuilder(this.result.linkedinContactItem_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.linkedinContactItem_ = value;
                }
                this.result.hasLinkedinContactItem = true;
                return this;
            }

            private AdditionalContactList PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    AdditionalContactList result = this.result;
                    this.result = new AdditionalContactList();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public AdditionalContactList.Builder SetLinkedinContactItem(LinkedinContactItem value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasLinkedinContactItem = true;
                this.result.linkedinContactItem_ = value;
                return this;
            }

            public AdditionalContactList.Builder SetLinkedinContactItem(LinkedinContactItem.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasLinkedinContactItem = true;
                this.result.linkedinContactItem_ = builderForValue.Build();
                return this;
            }

            public override AdditionalContactList DefaultInstanceForType
            {
                get
                {
                    return AdditionalContactList.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            public LinkedinContactItem LinkedinContactItem
            {
                get
                {
                    return this.result.LinkedinContactItem;
                }
                set
                {
                    this.SetLinkedinContactItem(value);
                }
            }

            protected override AdditionalContactList MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override AdditionalContactList.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}

namespace micromsg
{
    using Google.ProtocolBuffers;
    
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

   
    public sealed class DeleteBottle : GeneratedMessageLite<DeleteBottle, DeleteBottle.Builder>
    {
        private static readonly string[] _deleteBottleFieldNames = new string[] { "BottleId", "ThrowBackType" };
        private static readonly uint[] _deleteBottleFieldTags = new uint[] { 10, 0x10 };
        private string bottleId_ = "";
        public const int BottleIdFieldNumber = 1;
        private static readonly DeleteBottle defaultInstance = new DeleteBottle().MakeReadOnly();
        private bool hasBottleId;
        private bool hasThrowBackType;
        private int memoizedSerializedSize = -1;
        private int throwBackType_;
        public const int ThrowBackTypeFieldNumber = 2;

        static DeleteBottle()
        {
            //object.ReferenceEquals(DeleteBottle.Descriptor, null);
        }

        private DeleteBottle()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(DeleteBottle prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            DeleteBottle bottle = obj as DeleteBottle;
            if (bottle == null)
            {
                return false;
            }
            if ((this.hasBottleId != bottle.hasBottleId) || (this.hasBottleId && !this.bottleId_.Equals(bottle.bottleId_)))
            {
                return false;
            }
            return ((this.hasThrowBackType == bottle.hasThrowBackType) && (!this.hasThrowBackType || this.throwBackType_.Equals(bottle.throwBackType_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasBottleId)
            {
                hashCode ^= this.bottleId_.GetHashCode();
            }
            if (this.hasThrowBackType)
            {
                hashCode ^= this.throwBackType_.GetHashCode();
            }
            return hashCode;
        }

        private DeleteBottle MakeReadOnly()
        {
            return this;
        }

        public static DeleteBottle ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<DeleteBottle, Builder>.PrintField("BottleId", this.hasBottleId, this.bottleId_, writer);
            GeneratedMessageLite<DeleteBottle, Builder>.PrintField("ThrowBackType", this.hasThrowBackType, this.throwBackType_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _deleteBottleFieldNames;
            if (this.hasBottleId)
            {
                output.WriteString(1, strArray[0], this.BottleId);
            }
            if (this.hasThrowBackType)
            {
                output.WriteInt32(2, strArray[1], this.ThrowBackType);
            }
        }

        public string BottleId
        {
            get
            {
                return this.bottleId_;
            }
        }

        public static DeleteBottle DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override DeleteBottle DefaultInstanceForType
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
                if (!this.hasThrowBackType)
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
                    if (this.hasBottleId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(1, this.BottleId);
                    }
                    if (this.hasThrowBackType)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(2, this.ThrowBackType);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override DeleteBottle ThisMessage
        {
            get
            {
                return this;
            }
        }

        public int ThrowBackType
        {
            get
            {
                return this.throwBackType_;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<DeleteBottle, DeleteBottle.Builder>
        {
            private DeleteBottle result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = DeleteBottle.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(DeleteBottle cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override DeleteBottle BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override DeleteBottle.Builder Clear()
            {
                this.result = DeleteBottle.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public DeleteBottle.Builder ClearBottleId()
            {
                this.PrepareBuilder();
                this.result.hasBottleId = false;
                this.result.bottleId_ = "";
                return this;
            }

            public DeleteBottle.Builder ClearThrowBackType()
            {
                this.PrepareBuilder();
                this.result.hasThrowBackType = false;
                this.result.throwBackType_ = 0;
                return this;
            }

            public override DeleteBottle.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new DeleteBottle.Builder(this.result);
                }
                return new DeleteBottle.Builder().MergeFrom(this.result);
            }

            public override DeleteBottle.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override DeleteBottle.Builder MergeFrom(IMessageLite other)
            {
                if (other is DeleteBottle)
                {
                    return this.MergeFrom((DeleteBottle) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override DeleteBottle.Builder MergeFrom(DeleteBottle other)
            {
                return this;
            }

            public override DeleteBottle.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(DeleteBottle._deleteBottleFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = DeleteBottle._deleteBottleFieldTags[index];
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
                            this.result.hasBottleId = input.ReadString(ref this.result.bottleId_);
                            continue;
                        }
                        case 0x10:
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
                    this.result.hasThrowBackType = input.ReadInt32(ref this.result.throwBackType_);
                }
                return this;
            }

            private DeleteBottle PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    DeleteBottle result = this.result;
                    this.result = new DeleteBottle();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public DeleteBottle.Builder SetBottleId(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBottleId = true;
                this.result.bottleId_ = value;
                return this;
            }

            public DeleteBottle.Builder SetThrowBackType(int value)
            {
                this.PrepareBuilder();
                this.result.hasThrowBackType = true;
                this.result.throwBackType_ = value;
                return this;
            }

            public string BottleId
            {
                get
                {
                    return this.result.BottleId;
                }
                set
                {
                    this.SetBottleId(value);
                }
            }

            public override DeleteBottle DefaultInstanceForType
            {
                get
                {
                    return DeleteBottle.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override DeleteBottle MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override DeleteBottle.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }

            public int ThrowBackType
            {
                get
                {
                    return this.result.ThrowBackType;
                }
                set
                {
                    this.SetThrowBackType(value);
                }
            }
        }
    }
}


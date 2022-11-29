namespace micromsg
{
    using Google.ProtocolBuffers;
    
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

    //
    public sealed class SnsObjectOpDeleteComment : GeneratedMessageLite<SnsObjectOpDeleteComment, SnsObjectOpDeleteComment.Builder>
    {
        private static readonly string[] _snsObjectOpDeleteCommentFieldNames = new string[] { "CommentId" };
        private static readonly uint[] _snsObjectOpDeleteCommentFieldTags = new uint[] { 8 };
        private int commentId_;
        public const int CommentIdFieldNumber = 1;
        private static readonly SnsObjectOpDeleteComment defaultInstance = new SnsObjectOpDeleteComment().MakeReadOnly();
        private bool hasCommentId;
        private int memoizedSerializedSize = -1;

        static SnsObjectOpDeleteComment()
        {
           // object.ReferenceEquals(SnsObjectOpDeleteComment.Descriptor, null);
        }

        private SnsObjectOpDeleteComment()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(SnsObjectOpDeleteComment prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            SnsObjectOpDeleteComment comment = obj as SnsObjectOpDeleteComment;
            if (comment == null)
            {
                return false;
            }
            return ((this.hasCommentId == comment.hasCommentId) && (!this.hasCommentId || this.commentId_.Equals(comment.commentId_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasCommentId)
            {
                hashCode ^= this.commentId_.GetHashCode();
            }
            return hashCode;
        }

        private SnsObjectOpDeleteComment MakeReadOnly()
        {
            return this;
        }

        public static SnsObjectOpDeleteComment ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<SnsObjectOpDeleteComment, Builder>.PrintField("CommentId", this.hasCommentId, this.commentId_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _snsObjectOpDeleteCommentFieldNames;
            if (this.hasCommentId)
            {
                output.WriteInt32(1, strArray[0], this.CommentId);
            }
        }

        public int CommentId
        {
            get
            {
                return this.commentId_;
            }
        }

        public static SnsObjectOpDeleteComment DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override SnsObjectOpDeleteComment DefaultInstanceForType
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
                if (!this.hasCommentId)
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
                    if (this.hasCommentId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(1, this.CommentId);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override SnsObjectOpDeleteComment ThisMessage
        {
            get
            {
                return this;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<SnsObjectOpDeleteComment, SnsObjectOpDeleteComment.Builder>
        {
            private SnsObjectOpDeleteComment result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = SnsObjectOpDeleteComment.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(SnsObjectOpDeleteComment cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override SnsObjectOpDeleteComment BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override SnsObjectOpDeleteComment.Builder Clear()
            {
                this.result = SnsObjectOpDeleteComment.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public SnsObjectOpDeleteComment.Builder ClearCommentId()
            {
                this.PrepareBuilder();
                this.result.hasCommentId = false;
                this.result.commentId_ = 0;
                return this;
            }

            public override SnsObjectOpDeleteComment.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new SnsObjectOpDeleteComment.Builder(this.result);
                }
                return new SnsObjectOpDeleteComment.Builder().MergeFrom(this.result);
            }

            public override SnsObjectOpDeleteComment.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override SnsObjectOpDeleteComment.Builder MergeFrom(IMessageLite other)
            {
                if (other is SnsObjectOpDeleteComment)
                {
                    return this.MergeFrom((SnsObjectOpDeleteComment) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override SnsObjectOpDeleteComment.Builder MergeFrom(SnsObjectOpDeleteComment other)
            {
                return this;
            }

            public override SnsObjectOpDeleteComment.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(SnsObjectOpDeleteComment._snsObjectOpDeleteCommentFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = SnsObjectOpDeleteComment._snsObjectOpDeleteCommentFieldTags[index];
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

                        case 8:
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
                    this.result.hasCommentId = input.ReadInt32(ref this.result.commentId_);
                }
                return this;
            }

            private SnsObjectOpDeleteComment PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    SnsObjectOpDeleteComment result = this.result;
                    this.result = new SnsObjectOpDeleteComment();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public SnsObjectOpDeleteComment.Builder SetCommentId(int value)
            {
                this.PrepareBuilder();
                this.result.hasCommentId = true;
                this.result.commentId_ = value;
                return this;
            }

            public int CommentId
            {
                get
                {
                    return this.result.CommentId;
                }
                set
                {
                    this.SetCommentId(value);
                }
            }

            public override SnsObjectOpDeleteComment DefaultInstanceForType
            {
                get
                {
                    return SnsObjectOpDeleteComment.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override SnsObjectOpDeleteComment MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override SnsObjectOpDeleteComment.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


namespace micromsg
{
    using Google.ProtocolBuffers;
    using Google.ProtocolBuffers.Collections;

    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    


    public sealed class GetContactResponse : GeneratedMessageLite<GetContactResponse, GetContactResponse.Builder>
    {
        private static readonly string[] _getContactResponseFieldNames = new string[] { "BaseResponse", "ContactCount", "ContactList", "Ret" };
        private static readonly uint[] _getContactResponseFieldTags = new uint[] { 10, 0x10, 0x1a, 0x22 };
        private micromsg.BaseResponse baseResponse_;
        public const int BaseResponseFieldNumber = 1;
        private uint contactCount_;
        public const int ContactCountFieldNumber = 2;
        private PopsicleList<ModContact> contactList_ = new PopsicleList<ModContact>();
        public const int ContactListFieldNumber = 3;
        private static readonly GetContactResponse defaultInstance = new GetContactResponse().MakeReadOnly();
        private bool hasBaseResponse;
        private bool hasContactCount;
        private int memoizedSerializedSize = -1;
        private PopsicleList<int> ret_ = new PopsicleList<int>();
        public const int RetFieldNumber = 4;
        private int retMemoizedSerializedSize;

        static GetContactResponse()
        {
   
        }

        private GetContactResponse()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(GetContactResponse prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            GetContactResponse response = obj as GetContactResponse;
            if (response == null)
            {
                return false;
            }
            if ((this.hasBaseResponse != response.hasBaseResponse) || (this.hasBaseResponse && !this.baseResponse_.Equals(response.baseResponse_)))
            {
                return false;
            }
            if ((this.hasContactCount != response.hasContactCount) || (this.hasContactCount && !this.contactCount_.Equals(response.contactCount_)))
            {
                return false;
            }
            if (this.contactList_.Count != response.contactList_.Count)
            {
                return false;
            }
            for (int i = 0; i < this.contactList_.Count; i++)
            {
                if (!this.contactList_[i].Equals(response.contactList_[i]))
                {
                    return false;
                }
            }
            if (this.ret_.Count != response.ret_.Count)
            {
                return false;
            }
            for (int j = 0; j < this.ret_.Count; j++)
            {
                int num3 = this.ret_[j];
                if (!num3.Equals(response.ret_[j]))
                {
                    return false;
                }
            }
            return true;
        }

        public ModContact GetContactList(int index)
        {
            return this.contactList_[index];
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasBaseResponse)
            {
                hashCode ^= this.baseResponse_.GetHashCode();
            }
            if (this.hasContactCount)
            {
                hashCode ^= this.contactCount_.GetHashCode();
            }
            foreach (ModContact contact in this.contactList_)
            {
                hashCode ^= contact.GetHashCode();
            }
            foreach (int num2 in this.ret_)
            {
                hashCode ^= num2.GetHashCode();
            }
            return hashCode;
        }

        public int GetRet(int index)
        {
            return this.ret_[index];
        }

        private GetContactResponse MakeReadOnly()
        {
            this.contactList_.MakeReadOnly();
            this.ret_.MakeReadOnly();
            return this;
        }

        public static GetContactResponse ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<GetContactResponse, Builder>.PrintField("BaseResponse", this.hasBaseResponse, this.baseResponse_, writer);
            GeneratedMessageLite<GetContactResponse, Builder>.PrintField("ContactCount", this.hasContactCount, this.contactCount_, writer);
            GeneratedMessageLite<GetContactResponse, Builder>.PrintField<ModContact>("ContactList", this.contactList_, writer);
            GeneratedMessageLite<GetContactResponse, Builder>.PrintField<int>("Ret", this.ret_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _getContactResponseFieldNames;
            if (this.hasBaseResponse)
            {
                output.WriteMessage(1, strArray[0], this.BaseResponse);
            }
            if (this.hasContactCount)
            {
                output.WriteUInt32(2, strArray[1], this.ContactCount);
            }
            if (this.contactList_.Count > 0)
            {
                output.WriteMessageArray<ModContact>(3, strArray[2], this.contactList_);
            }
            if (this.ret_.Count > 0)
            {
                output.WritePackedInt32Array(4, strArray[3], this.retMemoizedSerializedSize, this.ret_);
            }
        }

        public micromsg.BaseResponse BaseResponse
        {
            get
            {
                return (this.baseResponse_ ?? micromsg.BaseResponse.DefaultInstance);
            }
        }

        public uint ContactCount
        {
            get
            {
                return this.contactCount_;
            }
        }

        public int ContactListCount
        {
            get
            {
                return this.contactList_.Count;
            }
        }

        public IList<ModContact> ContactListList
        {
            get
            {
                return this.contactList_;
            }
        }

        public static GetContactResponse DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override GetContactResponse DefaultInstanceForType
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
                if (!this.hasBaseResponse)
                {
                    return false;
                }
                if (!this.hasContactCount)
                {
                    return false;
                }
                if (!this.BaseResponse.IsInitialized)
                {
                    return false;
                }
                foreach (ModContact contact in this.ContactListList)
                {
                    if (!contact.IsInitialized)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public int RetCount
        {
            get
            {
                return this.ret_.Count;
            }
        }

        public IList<int> RetList
        {
            get
            {
                return Lists.AsReadOnly<int>(this.ret_);
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
                    if (this.hasContactCount)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(2, this.ContactCount);
                    }
                    foreach (ModContact contact in this.ContactListList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(3, contact);
                    }
                    int num2 = 0;
                    foreach (int num3 in this.RetList)
                    {
                        num2 += CodedOutputStream.ComputeInt32SizeNoTag(num3);
                    }
                    memoizedSerializedSize += num2;
                    if (this.ret_.Count != 0)
                    {
                        memoizedSerializedSize += 1 + CodedOutputStream.ComputeInt32SizeNoTag(num2);
                    }
                    this.retMemoizedSerializedSize = num2;
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override GetContactResponse ThisMessage
        {
            get
            {
                return this;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<GetContactResponse, GetContactResponse.Builder>
        {
            private GetContactResponse result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = GetContactResponse.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(GetContactResponse cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public GetContactResponse.Builder AddContactList(ModContact value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.contactList_.Add(value);
                return this;
            }

            public GetContactResponse.Builder AddContactList(ModContact.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.contactList_.Add(builderForValue.Build());
                return this;
            }

            public GetContactResponse.Builder AddRangeContactList(IEnumerable<ModContact> values)
            {
                this.PrepareBuilder();
                this.result.contactList_.Add(values);
                return this;
            }

            public GetContactResponse.Builder AddRangeRet(IEnumerable<int> values)
            {
                this.PrepareBuilder();
                this.result.ret_.Add(values);
                return this;
            }

            public GetContactResponse.Builder AddRet(int value)
            {
                this.PrepareBuilder();
                this.result.ret_.Add(value);
                return this;
            }

            public override GetContactResponse BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override GetContactResponse.Builder Clear()
            {
                this.result = GetContactResponse.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public GetContactResponse.Builder ClearBaseResponse()
            {
                this.PrepareBuilder();
                this.result.hasBaseResponse = false;
                this.result.baseResponse_ = null;
                return this;
            }

            public GetContactResponse.Builder ClearContactCount()
            {
                this.PrepareBuilder();
                this.result.hasContactCount = false;
                this.result.contactCount_ = 0;
                return this;
            }

            public GetContactResponse.Builder ClearContactList()
            {
                this.PrepareBuilder();
                this.result.contactList_.Clear();
                return this;
            }

            public GetContactResponse.Builder ClearRet()
            {
                this.PrepareBuilder();
                this.result.ret_.Clear();
                return this;
            }

            public override GetContactResponse.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new GetContactResponse.Builder(this.result);
                }
                return new GetContactResponse.Builder().MergeFrom(this.result);
            }

            public ModContact GetContactList(int index)
            {
                return this.result.GetContactList(index);
            }

            public int GetRet(int index)
            {
                return this.result.GetRet(index);
            }

            public GetContactResponse.Builder MergeBaseResponse(micromsg.BaseResponse value)
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

            public override GetContactResponse.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override GetContactResponse.Builder MergeFrom(IMessageLite other)
            {
                if (other is GetContactResponse)
                {
                    return this.MergeFrom((GetContactResponse) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override GetContactResponse.Builder MergeFrom(GetContactResponse other)
            {
                return this;
            }

            public override GetContactResponse.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(GetContactResponse._getContactResponseFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = GetContactResponse._getContactResponseFieldTags[index];
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
                        case 0x22:
                            break;

                        case 0x1a:
                        {
                            input.ReadMessageArray<ModContact>(num, str, this.result.contactList_, ModContact.DefaultInstance, extensionRegistry);
                            continue;
                        }
                        case 0x10:
                        {
                            this.result.hasContactCount = input.ReadUInt32(ref this.result.contactCount_);
                            continue;
                        }
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
                    input.ReadInt32Array(num, str, this.result.ret_);
                }
                return this;
            }

            private GetContactResponse PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    GetContactResponse result = this.result;
                    this.result = new GetContactResponse();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public GetContactResponse.Builder SetBaseResponse(micromsg.BaseResponse value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = value;
                return this;
            }

            public GetContactResponse.Builder SetBaseResponse(micromsg.BaseResponse.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseResponse = true;
                this.result.baseResponse_ = builderForValue.Build();
                return this;
            }

            public GetContactResponse.Builder SetContactCount(uint value)
            {
                this.PrepareBuilder();
                this.result.hasContactCount = true;
                this.result.contactCount_ = value;
                return this;
            }

            public GetContactResponse.Builder SetContactList(int index, ModContact value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.contactList_[index] = value;
                return this;
            }

            public GetContactResponse.Builder SetContactList(int index, ModContact.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.contactList_[index] = builderForValue.Build();
                return this;
            }

            public GetContactResponse.Builder SetRet(int index, int value)
            {
                this.PrepareBuilder();
                this.result.ret_[index] = value;
                return this;
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

            public uint ContactCount
            {
                get
                {
                    return this.result.ContactCount;
                }
                set
                {
                    this.SetContactCount(value);
                }
            }

            public int ContactListCount
            {
                get
                {
                    return this.result.ContactListCount;
                }
            }

            public IPopsicleList<ModContact> ContactListList
            {
                get
                {
                    return this.PrepareBuilder().contactList_;
                }
            }

            public override GetContactResponse DefaultInstanceForType
            {
                get
                {
                    return GetContactResponse.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override GetContactResponse MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public int RetCount
            {
                get
                {
                    return this.result.RetCount;
                }
            }

            public IPopsicleList<int> RetList
            {
                get
                {
                    return this.PrepareBuilder().ret_;
                }
            }

            protected override GetContactResponse.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}


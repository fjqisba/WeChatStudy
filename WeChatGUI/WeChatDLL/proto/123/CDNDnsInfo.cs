namespace micromsg
{
    using Google.ProtocolBuffers;
    using Google.ProtocolBuffers.Collections;
    
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    

    
    public sealed class CDNDnsInfo : GeneratedMessageLite<CDNDnsInfo, CDNDnsInfo.Builder>
    {
        private static readonly string[] _cDNDnsInfoFieldNames = new string[] { "AuthKey", "ExpireTime", "FrontID", "FrontIPCount", "FrontIPList", "Uin", "Ver", "ZoneDomain", "ZoneID", "ZoneIPCount", "ZoneIPList" };
        private static readonly uint[] _cDNDnsInfoFieldTags = new uint[] { 0x42, 0x18, 0x20, 40, 50, 0x10, 8, 0x3a, 0x48, 80, 90 };
        private SKBuiltinBuffer_t authKey_;
        public const int AuthKeyFieldNumber = 8;
        private static readonly CDNDnsInfo defaultInstance = new CDNDnsInfo().MakeReadOnly();
        private uint expireTime_;
        public const int ExpireTimeFieldNumber = 3;
        private int frontID_;
        public const int FrontIDFieldNumber = 4;
        private int frontIPCount_;
        public const int FrontIPCountFieldNumber = 5;
        private PopsicleList<SKBuiltinString_t> frontIPList_ = new PopsicleList<SKBuiltinString_t>();
        public const int FrontIPListFieldNumber = 6;
        private bool hasAuthKey;
        private bool hasExpireTime;
        private bool hasFrontID;
        private bool hasFrontIPCount;
        private bool hasUin;
        private bool hasVer;
        private bool hasZoneDomain;
        private bool hasZoneID;
        private bool hasZoneIPCount;
        private int memoizedSerializedSize = -1;
        private uint uin_;
        public const int UinFieldNumber = 2;
        private uint ver_;
        public const int VerFieldNumber = 1;
        private string zoneDomain_ = "";
        public const int ZoneDomainFieldNumber = 7;
        private int zoneID_;
        public const int ZoneIDFieldNumber = 9;
        private int zoneIPCount_;
        public const int ZoneIPCountFieldNumber = 10;
        private PopsicleList<SKBuiltinString_t> zoneIPList_ = new PopsicleList<SKBuiltinString_t>();
        public const int ZoneIPListFieldNumber = 11;

        static CDNDnsInfo()
        {
            //object.ReferenceEquals(CDNDnsInfo.Descriptor, null);
        }

        private CDNDnsInfo()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(CDNDnsInfo prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            CDNDnsInfo info = obj as CDNDnsInfo;
            if (info == null)
            {
                return false;
            }
            if ((this.hasVer != info.hasVer) || (this.hasVer && !this.ver_.Equals(info.ver_)))
            {
                return false;
            }
            if ((this.hasUin != info.hasUin) || (this.hasUin && !this.uin_.Equals(info.uin_)))
            {
                return false;
            }
            if ((this.hasExpireTime != info.hasExpireTime) || (this.hasExpireTime && !this.expireTime_.Equals(info.expireTime_)))
            {
                return false;
            }
            if ((this.hasFrontID != info.hasFrontID) || (this.hasFrontID && !this.frontID_.Equals(info.frontID_)))
            {
                return false;
            }
            if ((this.hasFrontIPCount != info.hasFrontIPCount) || (this.hasFrontIPCount && !this.frontIPCount_.Equals(info.frontIPCount_)))
            {
                return false;
            }
            if (this.frontIPList_.Count != info.frontIPList_.Count)
            {
                return false;
            }
            for (int i = 0; i < this.frontIPList_.Count; i++)
            {
                if (!this.frontIPList_[i].Equals(info.frontIPList_[i]))
                {
                    return false;
                }
            }
            if ((this.hasZoneDomain != info.hasZoneDomain) || (this.hasZoneDomain && !this.zoneDomain_.Equals(info.zoneDomain_)))
            {
                return false;
            }
            if ((this.hasAuthKey != info.hasAuthKey) || (this.hasAuthKey && !this.authKey_.Equals(info.authKey_)))
            {
                return false;
            }
            if ((this.hasZoneID != info.hasZoneID) || (this.hasZoneID && !this.zoneID_.Equals(info.zoneID_)))
            {
                return false;
            }
            if ((this.hasZoneIPCount != info.hasZoneIPCount) || (this.hasZoneIPCount && !this.zoneIPCount_.Equals(info.zoneIPCount_)))
            {
                return false;
            }
            if (this.zoneIPList_.Count != info.zoneIPList_.Count)
            {
                return false;
            }
            for (int j = 0; j < this.zoneIPList_.Count; j++)
            {
                if (!this.zoneIPList_[j].Equals(info.zoneIPList_[j]))
                {
                    return false;
                }
            }
            return true;
        }

        public SKBuiltinString_t GetFrontIPList(int index)
        {
            return this.frontIPList_[index];
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasVer)
            {
                hashCode ^= this.ver_.GetHashCode();
            }
            if (this.hasUin)
            {
                hashCode ^= this.uin_.GetHashCode();
            }
            if (this.hasExpireTime)
            {
                hashCode ^= this.expireTime_.GetHashCode();
            }
            if (this.hasFrontID)
            {
                hashCode ^= this.frontID_.GetHashCode();
            }
            if (this.hasFrontIPCount)
            {
                hashCode ^= this.frontIPCount_.GetHashCode();
            }
            foreach (SKBuiltinString_t _t in this.frontIPList_)
            {
                hashCode ^= _t.GetHashCode();
            }
            if (this.hasZoneDomain)
            {
                hashCode ^= this.zoneDomain_.GetHashCode();
            }
            if (this.hasAuthKey)
            {
                hashCode ^= this.authKey_.GetHashCode();
            }
            if (this.hasZoneID)
            {
                hashCode ^= this.zoneID_.GetHashCode();
            }
            if (this.hasZoneIPCount)
            {
                hashCode ^= this.zoneIPCount_.GetHashCode();
            }
            foreach (SKBuiltinString_t _t2 in this.zoneIPList_)
            {
                hashCode ^= _t2.GetHashCode();
            }
            return hashCode;
        }

        public SKBuiltinString_t GetZoneIPList(int index)
        {
            return this.zoneIPList_[index];
        }

        private CDNDnsInfo MakeReadOnly()
        {
            this.frontIPList_.MakeReadOnly();
            this.zoneIPList_.MakeReadOnly();
            return this;
        }

        public static CDNDnsInfo ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<CDNDnsInfo, Builder>.PrintField("Ver", this.hasVer, this.ver_, writer);
            GeneratedMessageLite<CDNDnsInfo, Builder>.PrintField("Uin", this.hasUin, this.uin_, writer);
            GeneratedMessageLite<CDNDnsInfo, Builder>.PrintField("ExpireTime", this.hasExpireTime, this.expireTime_, writer);
            GeneratedMessageLite<CDNDnsInfo, Builder>.PrintField("FrontID", this.hasFrontID, this.frontID_, writer);
            GeneratedMessageLite<CDNDnsInfo, Builder>.PrintField("FrontIPCount", this.hasFrontIPCount, this.frontIPCount_, writer);
            GeneratedMessageLite<CDNDnsInfo, Builder>.PrintField<SKBuiltinString_t>("FrontIPList", this.frontIPList_, writer);
            GeneratedMessageLite<CDNDnsInfo, Builder>.PrintField("ZoneDomain", this.hasZoneDomain, this.zoneDomain_, writer);
            GeneratedMessageLite<CDNDnsInfo, Builder>.PrintField("AuthKey", this.hasAuthKey, this.authKey_, writer);
            GeneratedMessageLite<CDNDnsInfo, Builder>.PrintField("ZoneID", this.hasZoneID, this.zoneID_, writer);
            GeneratedMessageLite<CDNDnsInfo, Builder>.PrintField("ZoneIPCount", this.hasZoneIPCount, this.zoneIPCount_, writer);
            GeneratedMessageLite<CDNDnsInfo, Builder>.PrintField<SKBuiltinString_t>("ZoneIPList", this.zoneIPList_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _cDNDnsInfoFieldNames;
            if (this.hasVer)
            {
                output.WriteUInt32(1, strArray[6], this.Ver);
            }
            if (this.hasUin)
            {
                output.WriteUInt32(2, strArray[5], this.Uin);
            }
            if (this.hasExpireTime)
            {
                output.WriteUInt32(3, strArray[1], this.ExpireTime);
            }
            if (this.hasFrontID)
            {
                output.WriteInt32(4, strArray[2], this.FrontID);
            }
            if (this.hasFrontIPCount)
            {
                output.WriteInt32(5, strArray[3], this.FrontIPCount);
            }
            if (this.frontIPList_.Count > 0)
            {
                output.WriteMessageArray<SKBuiltinString_t>(6, strArray[4], this.frontIPList_);
            }
            if (this.hasZoneDomain)
            {
                output.WriteString(7, strArray[7], this.ZoneDomain);
            }
            if (this.hasAuthKey)
            {
                output.WriteMessage(8, strArray[0], this.AuthKey);
            }
            if (this.hasZoneID)
            {
                output.WriteInt32(9, strArray[8], this.ZoneID);
            }
            if (this.hasZoneIPCount)
            {
                output.WriteInt32(10, strArray[9], this.ZoneIPCount);
            }
            if (this.zoneIPList_.Count > 0)
            {
                output.WriteMessageArray<SKBuiltinString_t>(11, strArray[10], this.zoneIPList_);
            }
        }

        public SKBuiltinBuffer_t AuthKey
        {
            get
            {
                return (this.authKey_ ?? SKBuiltinBuffer_t.DefaultInstance);
            }
        }

        public static CDNDnsInfo DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override CDNDnsInfo DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public uint ExpireTime
        {
            get
            {
                return this.expireTime_;
            }
        }

        public int FrontID
        {
            get
            {
                return this.frontID_;
            }
        }

        public int FrontIPCount
        {
            get
            {
                return this.frontIPCount_;
            }
        }

        public int FrontIPListCount
        {
            get
            {
                return this.frontIPList_.Count;
            }
        }

        public IList<SKBuiltinString_t> FrontIPListList
        {
            get
            {
                return this.frontIPList_;
            }
        }

        public override bool IsInitialized
        {
            get
            {
                if (!this.hasVer)
                {
                    return false;
                }
                if (!this.hasUin)
                {
                    return false;
                }
                if (!this.hasExpireTime)
                {
                    return false;
                }
                if (!this.hasFrontID)
                {
                    return false;
                }
                if (!this.hasFrontIPCount)
                {
                    return false;
                }
                if (!this.hasAuthKey)
                {
                    return false;
                }
                if (!this.hasZoneID)
                {
                    return false;
                }
                if (!this.hasZoneIPCount)
                {
                    return false;
                }
                if (!this.AuthKey.IsInitialized)
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
                    if (this.hasVer)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(1, this.Ver);
                    }
                    if (this.hasUin)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(2, this.Uin);
                    }
                    if (this.hasExpireTime)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(3, this.ExpireTime);
                    }
                    if (this.hasFrontID)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(4, this.FrontID);
                    }
                    if (this.hasFrontIPCount)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(5, this.FrontIPCount);
                    }
                    foreach (SKBuiltinString_t _t in this.FrontIPListList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(6, _t);
                    }
                    if (this.hasZoneDomain)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(7, this.ZoneDomain);
                    }
                    if (this.hasAuthKey)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(8, this.AuthKey);
                    }
                    if (this.hasZoneID)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(9, this.ZoneID);
                    }
                    if (this.hasZoneIPCount)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(10, this.ZoneIPCount);
                    }
                    foreach (SKBuiltinString_t _t2 in this.ZoneIPListList)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(11, _t2);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override CDNDnsInfo ThisMessage
        {
            get
            {
                return this;
            }
        }

        public uint Uin
        {
            get
            {
                return this.uin_;
            }
        }

        public uint Ver
        {
            get
            {
                return this.ver_;
            }
        }

        public string ZoneDomain
        {
            get
            {
                return this.zoneDomain_;
            }
        }

        public int ZoneID
        {
            get
            {
                return this.zoneID_;
            }
        }

        public int ZoneIPCount
        {
            get
            {
                return this.zoneIPCount_;
            }
        }

        public int ZoneIPListCount
        {
            get
            {
                return this.zoneIPList_.Count;
            }
        }

        public IList<SKBuiltinString_t> ZoneIPListList
        {
            get
            {
                return this.zoneIPList_;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<CDNDnsInfo, CDNDnsInfo.Builder>
        {
            private CDNDnsInfo result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = CDNDnsInfo.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(CDNDnsInfo cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public CDNDnsInfo.Builder AddFrontIPList(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.frontIPList_.Add(value);
                return this;
            }

            public CDNDnsInfo.Builder AddFrontIPList(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.frontIPList_.Add(builderForValue.Build());
                return this;
            }

            public CDNDnsInfo.Builder AddRangeFrontIPList(IEnumerable<SKBuiltinString_t> values)
            {
                this.PrepareBuilder();
                this.result.frontIPList_.Add(values);
                return this;
            }

            public CDNDnsInfo.Builder AddRangeZoneIPList(IEnumerable<SKBuiltinString_t> values)
            {
                this.PrepareBuilder();
                this.result.zoneIPList_.Add(values);
                return this;
            }

            public CDNDnsInfo.Builder AddZoneIPList(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.zoneIPList_.Add(value);
                return this;
            }

            public CDNDnsInfo.Builder AddZoneIPList(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.zoneIPList_.Add(builderForValue.Build());
                return this;
            }

            public override CDNDnsInfo BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override CDNDnsInfo.Builder Clear()
            {
                this.result = CDNDnsInfo.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public CDNDnsInfo.Builder ClearAuthKey()
            {
                this.PrepareBuilder();
                this.result.hasAuthKey = false;
                this.result.authKey_ = null;
                return this;
            }

            public CDNDnsInfo.Builder ClearExpireTime()
            {
                this.PrepareBuilder();
                this.result.hasExpireTime = false;
                this.result.expireTime_ = 0;
                return this;
            }

            public CDNDnsInfo.Builder ClearFrontID()
            {
                this.PrepareBuilder();
                this.result.hasFrontID = false;
                this.result.frontID_ = 0;
                return this;
            }

            public CDNDnsInfo.Builder ClearFrontIPCount()
            {
                this.PrepareBuilder();
                this.result.hasFrontIPCount = false;
                this.result.frontIPCount_ = 0;
                return this;
            }

            public CDNDnsInfo.Builder ClearFrontIPList()
            {
                this.PrepareBuilder();
                this.result.frontIPList_.Clear();
                return this;
            }

            public CDNDnsInfo.Builder ClearUin()
            {
                this.PrepareBuilder();
                this.result.hasUin = false;
                this.result.uin_ = 0;
                return this;
            }

            public CDNDnsInfo.Builder ClearVer()
            {
                this.PrepareBuilder();
                this.result.hasVer = false;
                this.result.ver_ = 0;
                return this;
            }

            public CDNDnsInfo.Builder ClearZoneDomain()
            {
                this.PrepareBuilder();
                this.result.hasZoneDomain = false;
                this.result.zoneDomain_ = "";
                return this;
            }

            public CDNDnsInfo.Builder ClearZoneID()
            {
                this.PrepareBuilder();
                this.result.hasZoneID = false;
                this.result.zoneID_ = 0;
                return this;
            }

            public CDNDnsInfo.Builder ClearZoneIPCount()
            {
                this.PrepareBuilder();
                this.result.hasZoneIPCount = false;
                this.result.zoneIPCount_ = 0;
                return this;
            }

            public CDNDnsInfo.Builder ClearZoneIPList()
            {
                this.PrepareBuilder();
                this.result.zoneIPList_.Clear();
                return this;
            }

            public override CDNDnsInfo.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new CDNDnsInfo.Builder(this.result);
                }
                return new CDNDnsInfo.Builder().MergeFrom(this.result);
            }

            public SKBuiltinString_t GetFrontIPList(int index)
            {
                return this.result.GetFrontIPList(index);
            }

            public SKBuiltinString_t GetZoneIPList(int index)
            {
                return this.result.GetZoneIPList(index);
            }

            public CDNDnsInfo.Builder MergeAuthKey(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasAuthKey && (this.result.authKey_ != SKBuiltinBuffer_t.DefaultInstance))
                {
                    this.result.authKey_ = SKBuiltinBuffer_t.CreateBuilder(this.result.authKey_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.authKey_ = value;
                }
                this.result.hasAuthKey = true;
                return this;
            }

            public override CDNDnsInfo.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override CDNDnsInfo.Builder MergeFrom(IMessageLite other)
            {
                if (other is CDNDnsInfo)
                {
                    return this.MergeFrom((CDNDnsInfo) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override CDNDnsInfo.Builder MergeFrom(CDNDnsInfo other)
            {
                return this;
            }

            public override CDNDnsInfo.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(CDNDnsInfo._cDNDnsInfoFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = CDNDnsInfo._cDNDnsInfoFieldTags[index];
                        }
                        else
                        {
                            this.ParseUnknownField(input, extensionRegistry, num, str);
                            continue;
                        }
                    }
                    switch (num)
                    {
                        case 0x18:
                        {
                            this.result.hasExpireTime = input.ReadUInt32(ref this.result.expireTime_);
                            continue;
                        }
                        case 0x20:
                        {
                            this.result.hasFrontID = input.ReadInt32(ref this.result.frontID_);
                            continue;
                        }
                        case 40:
                        {
                            this.result.hasFrontIPCount = input.ReadInt32(ref this.result.frontIPCount_);
                            continue;
                        }
                        case 0:
                            throw InvalidProtocolBufferException.InvalidTag();

                        case 8:
                        {
                            this.result.hasVer = input.ReadUInt32(ref this.result.ver_);
                            continue;
                        }
                        case 0x10:
                        {
                            this.result.hasUin = input.ReadUInt32(ref this.result.uin_);
                            continue;
                        }
                        case 50:
                        {
                            input.ReadMessageArray<SKBuiltinString_t>(num, str, this.result.frontIPList_, SKBuiltinString_t.DefaultInstance, extensionRegistry);
                            continue;
                        }
                        case 0x3a:
                        {
                            this.result.hasZoneDomain = input.ReadString(ref this.result.zoneDomain_);
                            continue;
                        }
                        case 0x42:
                        {
                            SKBuiltinBuffer_t.Builder builder = SKBuiltinBuffer_t.CreateBuilder();
                            if (this.result.hasAuthKey)
                            {
                                builder.MergeFrom(this.AuthKey);
                            }
                            input.ReadMessage(builder, extensionRegistry);
                            this.AuthKey = builder.BuildPartial();
                            continue;
                        }
                        case 0x48:
                        {
                            this.result.hasZoneID = input.ReadInt32(ref this.result.zoneID_);
                            continue;
                        }
                        case 80:
                        {
                            this.result.hasZoneIPCount = input.ReadInt32(ref this.result.zoneIPCount_);
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
                    input.ReadMessageArray<SKBuiltinString_t>(num, str, this.result.zoneIPList_, SKBuiltinString_t.DefaultInstance, extensionRegistry);
                }
                return this;
            }

            private CDNDnsInfo PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    CDNDnsInfo result = this.result;
                    this.result = new CDNDnsInfo();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public CDNDnsInfo.Builder SetAuthKey(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasAuthKey = true;
                this.result.authKey_ = value;
                return this;
            }

            public CDNDnsInfo.Builder SetAuthKey(SKBuiltinBuffer_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasAuthKey = true;
                this.result.authKey_ = builderForValue.Build();
                return this;
            }

            public CDNDnsInfo.Builder SetExpireTime(uint value)
            {
                this.PrepareBuilder();
                this.result.hasExpireTime = true;
                this.result.expireTime_ = value;
                return this;
            }

            public CDNDnsInfo.Builder SetFrontID(int value)
            {
                this.PrepareBuilder();
                this.result.hasFrontID = true;
                this.result.frontID_ = value;
                return this;
            }

            public CDNDnsInfo.Builder SetFrontIPCount(int value)
            {
                this.PrepareBuilder();
                this.result.hasFrontIPCount = true;
                this.result.frontIPCount_ = value;
                return this;
            }

            public CDNDnsInfo.Builder SetFrontIPList(int index, SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.frontIPList_[index] = value;
                return this;
            }

            public CDNDnsInfo.Builder SetFrontIPList(int index, SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.frontIPList_[index] = builderForValue.Build();
                return this;
            }

            public CDNDnsInfo.Builder SetUin(uint value)
            {
                this.PrepareBuilder();
                this.result.hasUin = true;
                this.result.uin_ = value;
                return this;
            }

            public CDNDnsInfo.Builder SetVer(uint value)
            {
                this.PrepareBuilder();
                this.result.hasVer = true;
                this.result.ver_ = value;
                return this;
            }

            public CDNDnsInfo.Builder SetZoneDomain(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasZoneDomain = true;
                this.result.zoneDomain_ = value;
                return this;
            }

            public CDNDnsInfo.Builder SetZoneID(int value)
            {
                this.PrepareBuilder();
                this.result.hasZoneID = true;
                this.result.zoneID_ = value;
                return this;
            }

            public CDNDnsInfo.Builder SetZoneIPCount(int value)
            {
                this.PrepareBuilder();
                this.result.hasZoneIPCount = true;
                this.result.zoneIPCount_ = value;
                return this;
            }

            public CDNDnsInfo.Builder SetZoneIPList(int index, SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.zoneIPList_[index] = value;
                return this;
            }

            public CDNDnsInfo.Builder SetZoneIPList(int index, SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.zoneIPList_[index] = builderForValue.Build();
                return this;
            }

            public SKBuiltinBuffer_t AuthKey
            {
                get
                {
                    return this.result.AuthKey;
                }
                set
                {
                    this.SetAuthKey(value);
                }
            }

            public override CDNDnsInfo DefaultInstanceForType
            {
                get
                {
                    return CDNDnsInfo.DefaultInstance;
                }
            }

            public uint ExpireTime
            {
                get
                {
                    return this.result.ExpireTime;
                }
                set
                {
                    this.SetExpireTime(value);
                }
            }

            public int FrontID
            {
                get
                {
                    return this.result.FrontID;
                }
                set
                {
                    this.SetFrontID(value);
                }
            }

            public int FrontIPCount
            {
                get
                {
                    return this.result.FrontIPCount;
                }
                set
                {
                    this.SetFrontIPCount(value);
                }
            }

            public int FrontIPListCount
            {
                get
                {
                    return this.result.FrontIPListCount;
                }
            }

            public IPopsicleList<SKBuiltinString_t> FrontIPListList
            {
                get
                {
                    return this.PrepareBuilder().frontIPList_;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override CDNDnsInfo MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override CDNDnsInfo.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }

            public uint Uin
            {
                get
                {
                    return this.result.Uin;
                }
                set
                {
                    this.SetUin(value);
                }
            }

            public uint Ver
            {
                get
                {
                    return this.result.Ver;
                }
                set
                {
                    this.SetVer(value);
                }
            }

            public string ZoneDomain
            {
                get
                {
                    return this.result.ZoneDomain;
                }
                set
                {
                    this.SetZoneDomain(value);
                }
            }

            public int ZoneID
            {
                get
                {
                    return this.result.ZoneID;
                }
                set
                {
                    this.SetZoneID(value);
                }
            }

            public int ZoneIPCount
            {
                get
                {
                    return this.result.ZoneIPCount;
                }
                set
                {
                    this.SetZoneIPCount(value);
                }
            }

            public int ZoneIPListCount
            {
                get
                {
                    return this.result.ZoneIPListCount;
                }
            }

            public IPopsicleList<SKBuiltinString_t> ZoneIPListList
            {
                get
                {
                    return this.PrepareBuilder().zoneIPList_;
                }
            }
        }
    }
}


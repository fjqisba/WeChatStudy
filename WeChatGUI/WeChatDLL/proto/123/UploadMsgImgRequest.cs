namespace micromsg
{
    using Google.ProtocolBuffers;

    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    using System.Runtime.CompilerServices;


    public sealed class UploadMsgImgRequest : GeneratedMessageLite<UploadMsgImgRequest, UploadMsgImgRequest.Builder>
    {
        private static readonly string[] _uploadMsgImgRequestFieldNames = new string[] { 
            "AESKey", "BaseRequest", "CDNBigImgSize", "CDNBigImgUrl", "CDNMidImgSize", "CDNMidImgUrl", "CDNThumbAESKey", "CDNThumbImgHeight", "CDNThumbImgSize", "CDNThumbImgUrl", "CDNThumbImgWidth", "ClientImgId", "CompressType", "Data", "DataLen", "EncryVer", 
            "FromUserName", "MediaId", "MsgSource", "MsgType", "NetType", "PhotoFrom", "StartPos", "ToUserName", "TotalLen"
         };
        private static readonly uint[] _uploadMsgImgRequestFieldTags = new uint[] { 
            0x8a, 10, 0x98, 0x7a, 160, 130, 0xca, 0xb8, 0xb0, 170, 0xc0, 0x12, 0x58, 0x42, 0x38, 0x90, 
            0x1a, 0x72, 0x52, 0x48, 0x60, 0x68, 0x30, 0x22, 40
         };
        private string aESKey_ = "";
        public const int AESKeyFieldNumber = 0x11;
        private BaseRequest baseRequest_;
        public const int BaseRequestFieldNumber = 1;
        private int cDNBigImgSize_;
        public const int CDNBigImgSizeFieldNumber = 0x13;
        private string cDNBigImgUrl_ = "";
        public const int CDNBigImgUrlFieldNumber = 15;
        private int cDNMidImgSize_;
        public const int CDNMidImgSizeFieldNumber = 20;
        private string cDNMidImgUrl_ = "";
        public const int CDNMidImgUrlFieldNumber = 0x10;
        private string cDNThumbAESKey_ = "";
        public const int CDNThumbAESKeyFieldNumber = 0x19;
        private int cDNThumbImgHeight_;
        public const int CDNThumbImgHeightFieldNumber = 0x17;
        private int cDNThumbImgSize_;
        public const int CDNThumbImgSizeFieldNumber = 0x16;
        private string cDNThumbImgUrl_ = "";
        public const int CDNThumbImgUrlFieldNumber = 0x15;
        private int cDNThumbImgWidth_;
        public const int CDNThumbImgWidthFieldNumber = 0x18;
        private SKBuiltinString_t clientImgId_;
        public const int ClientImgIdFieldNumber = 2;
        private uint compressType_;
        public const int CompressTypeFieldNumber = 11;
        private SKBuiltinBuffer_t data_;
        public const int DataFieldNumber = 8;
        private uint dataLen_;
        public const int DataLenFieldNumber = 7;
        private static readonly UploadMsgImgRequest defaultInstance = new UploadMsgImgRequest().MakeReadOnly();
        private int encryVer_;
        public const int EncryVerFieldNumber = 0x12;
        private SKBuiltinString_t fromUserName_;
        public const int FromUserNameFieldNumber = 3;
        private bool hasAESKey;
        private bool hasBaseRequest;
        private bool hasCDNBigImgSize;
        private bool hasCDNBigImgUrl;
        private bool hasCDNMidImgSize;
        private bool hasCDNMidImgUrl;
        private bool hasCDNThumbAESKey;
        private bool hasCDNThumbImgHeight;
        private bool hasCDNThumbImgSize;
        private bool hasCDNThumbImgUrl;
        private bool hasCDNThumbImgWidth;
        private bool hasClientImgId;
        private bool hasCompressType;
        private bool hasData;
        private bool hasDataLen;
        private bool hasEncryVer;
        private bool hasFromUserName;
        private bool hasMediaId;
        private bool hasMsgSource;
        private bool hasMsgType;
        private bool hasNetType;
        private bool hasPhotoFrom;
        private bool hasStartPos;
        private bool hasTotalLen;
        private bool hasToUserName;
        private string mediaId_ = "";
        public const int MediaIdFieldNumber = 14;
        private int memoizedSerializedSize = -1;
        private string msgSource_ = "";
        public const int MsgSourceFieldNumber = 10;
        private uint msgType_;
        public const int MsgTypeFieldNumber = 9;
        private int netType_;
        public const int NetTypeFieldNumber = 12;
        private int photoFrom_;
        public const int PhotoFromFieldNumber = 13;
        private uint startPos_;
        public const int StartPosFieldNumber = 6;
        private uint totalLen_;
        public const int TotalLenFieldNumber = 5;
        private SKBuiltinString_t toUserName_;
        public const int ToUserNameFieldNumber = 4;

        static UploadMsgImgRequest()
        {

        }

        private UploadMsgImgRequest()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(UploadMsgImgRequest prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            UploadMsgImgRequest request = obj as UploadMsgImgRequest;
            if (request == null)
            {
                return false;
            }
            if ((this.hasBaseRequest != request.hasBaseRequest) || (this.hasBaseRequest && !this.baseRequest_.Equals(request.baseRequest_)))
            {
                return false;
            }
            if ((this.hasClientImgId != request.hasClientImgId) || (this.hasClientImgId && !this.clientImgId_.Equals(request.clientImgId_)))
            {
                return false;
            }
            if ((this.hasFromUserName != request.hasFromUserName) || (this.hasFromUserName && !this.fromUserName_.Equals(request.fromUserName_)))
            {
                return false;
            }
            if ((this.hasToUserName != request.hasToUserName) || (this.hasToUserName && !this.toUserName_.Equals(request.toUserName_)))
            {
                return false;
            }
            if ((this.hasTotalLen != request.hasTotalLen) || (this.hasTotalLen && !this.totalLen_.Equals(request.totalLen_)))
            {
                return false;
            }
            if ((this.hasStartPos != request.hasStartPos) || (this.hasStartPos && !this.startPos_.Equals(request.startPos_)))
            {
                return false;
            }
            if ((this.hasDataLen != request.hasDataLen) || (this.hasDataLen && !this.dataLen_.Equals(request.dataLen_)))
            {
                return false;
            }
            if ((this.hasData != request.hasData) || (this.hasData && !this.data_.Equals(request.data_)))
            {
                return false;
            }
            if ((this.hasMsgType != request.hasMsgType) || (this.hasMsgType && !this.msgType_.Equals(request.msgType_)))
            {
                return false;
            }
            if ((this.hasMsgSource != request.hasMsgSource) || (this.hasMsgSource && !this.msgSource_.Equals(request.msgSource_)))
            {
                return false;
            }
            if ((this.hasCompressType != request.hasCompressType) || (this.hasCompressType && !this.compressType_.Equals(request.compressType_)))
            {
                return false;
            }
            if ((this.hasNetType != request.hasNetType) || (this.hasNetType && !this.netType_.Equals(request.netType_)))
            {
                return false;
            }
            if ((this.hasPhotoFrom != request.hasPhotoFrom) || (this.hasPhotoFrom && !this.photoFrom_.Equals(request.photoFrom_)))
            {
                return false;
            }
            if ((this.hasMediaId != request.hasMediaId) || (this.hasMediaId && !this.mediaId_.Equals(request.mediaId_)))
            {
                return false;
            }
            if ((this.hasCDNBigImgUrl != request.hasCDNBigImgUrl) || (this.hasCDNBigImgUrl && !this.cDNBigImgUrl_.Equals(request.cDNBigImgUrl_)))
            {
                return false;
            }
            if ((this.hasCDNMidImgUrl != request.hasCDNMidImgUrl) || (this.hasCDNMidImgUrl && !this.cDNMidImgUrl_.Equals(request.cDNMidImgUrl_)))
            {
                return false;
            }
            if ((this.hasAESKey != request.hasAESKey) || (this.hasAESKey && !this.aESKey_.Equals(request.aESKey_)))
            {
                return false;
            }
            if ((this.hasEncryVer != request.hasEncryVer) || (this.hasEncryVer && !this.encryVer_.Equals(request.encryVer_)))
            {
                return false;
            }
            if ((this.hasCDNBigImgSize != request.hasCDNBigImgSize) || (this.hasCDNBigImgSize && !this.cDNBigImgSize_.Equals(request.cDNBigImgSize_)))
            {
                return false;
            }
            if ((this.hasCDNMidImgSize != request.hasCDNMidImgSize) || (this.hasCDNMidImgSize && !this.cDNMidImgSize_.Equals(request.cDNMidImgSize_)))
            {
                return false;
            }
            if ((this.hasCDNThumbImgUrl != request.hasCDNThumbImgUrl) || (this.hasCDNThumbImgUrl && !this.cDNThumbImgUrl_.Equals(request.cDNThumbImgUrl_)))
            {
                return false;
            }
            if ((this.hasCDNThumbImgSize != request.hasCDNThumbImgSize) || (this.hasCDNThumbImgSize && !this.cDNThumbImgSize_.Equals(request.cDNThumbImgSize_)))
            {
                return false;
            }
            if ((this.hasCDNThumbImgHeight != request.hasCDNThumbImgHeight) || (this.hasCDNThumbImgHeight && !this.cDNThumbImgHeight_.Equals(request.cDNThumbImgHeight_)))
            {
                return false;
            }
            if ((this.hasCDNThumbImgWidth != request.hasCDNThumbImgWidth) || (this.hasCDNThumbImgWidth && !this.cDNThumbImgWidth_.Equals(request.cDNThumbImgWidth_)))
            {
                return false;
            }
            return ((this.hasCDNThumbAESKey == request.hasCDNThumbAESKey) && (!this.hasCDNThumbAESKey || this.cDNThumbAESKey_.Equals(request.cDNThumbAESKey_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasBaseRequest)
            {
                hashCode ^= this.baseRequest_.GetHashCode();
            }
            if (this.hasClientImgId)
            {
                hashCode ^= this.clientImgId_.GetHashCode();
            }
            if (this.hasFromUserName)
            {
                hashCode ^= this.fromUserName_.GetHashCode();
            }
            if (this.hasToUserName)
            {
                hashCode ^= this.toUserName_.GetHashCode();
            }
            if (this.hasTotalLen)
            {
                hashCode ^= this.totalLen_.GetHashCode();
            }
            if (this.hasStartPos)
            {
                hashCode ^= this.startPos_.GetHashCode();
            }
            if (this.hasDataLen)
            {
                hashCode ^= this.dataLen_.GetHashCode();
            }
            if (this.hasData)
            {
                hashCode ^= this.data_.GetHashCode();
            }
            if (this.hasMsgType)
            {
                hashCode ^= this.msgType_.GetHashCode();
            }
            if (this.hasMsgSource)
            {
                hashCode ^= this.msgSource_.GetHashCode();
            }
            if (this.hasCompressType)
            {
                hashCode ^= this.compressType_.GetHashCode();
            }
            if (this.hasNetType)
            {
                hashCode ^= this.netType_.GetHashCode();
            }
            if (this.hasPhotoFrom)
            {
                hashCode ^= this.photoFrom_.GetHashCode();
            }
            if (this.hasMediaId)
            {
                hashCode ^= this.mediaId_.GetHashCode();
            }
            if (this.hasCDNBigImgUrl)
            {
                hashCode ^= this.cDNBigImgUrl_.GetHashCode();
            }
            if (this.hasCDNMidImgUrl)
            {
                hashCode ^= this.cDNMidImgUrl_.GetHashCode();
            }
            if (this.hasAESKey)
            {
                hashCode ^= this.aESKey_.GetHashCode();
            }
            if (this.hasEncryVer)
            {
                hashCode ^= this.encryVer_.GetHashCode();
            }
            if (this.hasCDNBigImgSize)
            {
                hashCode ^= this.cDNBigImgSize_.GetHashCode();
            }
            if (this.hasCDNMidImgSize)
            {
                hashCode ^= this.cDNMidImgSize_.GetHashCode();
            }
            if (this.hasCDNThumbImgUrl)
            {
                hashCode ^= this.cDNThumbImgUrl_.GetHashCode();
            }
            if (this.hasCDNThumbImgSize)
            {
                hashCode ^= this.cDNThumbImgSize_.GetHashCode();
            }
            if (this.hasCDNThumbImgHeight)
            {
                hashCode ^= this.cDNThumbImgHeight_.GetHashCode();
            }
            if (this.hasCDNThumbImgWidth)
            {
                hashCode ^= this.cDNThumbImgWidth_.GetHashCode();
            }
            if (this.hasCDNThumbAESKey)
            {
                hashCode ^= this.cDNThumbAESKey_.GetHashCode();
            }
            return hashCode;
        }

        private UploadMsgImgRequest MakeReadOnly()
        {
            return this;
        }

        public static UploadMsgImgRequest ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<UploadMsgImgRequest, Builder>.PrintField("BaseRequest", this.hasBaseRequest, this.baseRequest_, writer);
            GeneratedMessageLite<UploadMsgImgRequest, Builder>.PrintField("ClientImgId", this.hasClientImgId, this.clientImgId_, writer);
            GeneratedMessageLite<UploadMsgImgRequest, Builder>.PrintField("FromUserName", this.hasFromUserName, this.fromUserName_, writer);
            GeneratedMessageLite<UploadMsgImgRequest, Builder>.PrintField("ToUserName", this.hasToUserName, this.toUserName_, writer);
            GeneratedMessageLite<UploadMsgImgRequest, Builder>.PrintField("TotalLen", this.hasTotalLen, this.totalLen_, writer);
            GeneratedMessageLite<UploadMsgImgRequest, Builder>.PrintField("StartPos", this.hasStartPos, this.startPos_, writer);
            GeneratedMessageLite<UploadMsgImgRequest, Builder>.PrintField("DataLen", this.hasDataLen, this.dataLen_, writer);
            GeneratedMessageLite<UploadMsgImgRequest, Builder>.PrintField("Data", this.hasData, this.data_, writer);
            GeneratedMessageLite<UploadMsgImgRequest, Builder>.PrintField("MsgType", this.hasMsgType, this.msgType_, writer);
            GeneratedMessageLite<UploadMsgImgRequest, Builder>.PrintField("MsgSource", this.hasMsgSource, this.msgSource_, writer);
            GeneratedMessageLite<UploadMsgImgRequest, Builder>.PrintField("CompressType", this.hasCompressType, this.compressType_, writer);
            GeneratedMessageLite<UploadMsgImgRequest, Builder>.PrintField("NetType", this.hasNetType, this.netType_, writer);
            GeneratedMessageLite<UploadMsgImgRequest, Builder>.PrintField("PhotoFrom", this.hasPhotoFrom, this.photoFrom_, writer);
            GeneratedMessageLite<UploadMsgImgRequest, Builder>.PrintField("MediaId", this.hasMediaId, this.mediaId_, writer);
            GeneratedMessageLite<UploadMsgImgRequest, Builder>.PrintField("CDNBigImgUrl", this.hasCDNBigImgUrl, this.cDNBigImgUrl_, writer);
            GeneratedMessageLite<UploadMsgImgRequest, Builder>.PrintField("CDNMidImgUrl", this.hasCDNMidImgUrl, this.cDNMidImgUrl_, writer);
            GeneratedMessageLite<UploadMsgImgRequest, Builder>.PrintField("AESKey", this.hasAESKey, this.aESKey_, writer);
            GeneratedMessageLite<UploadMsgImgRequest, Builder>.PrintField("EncryVer", this.hasEncryVer, this.encryVer_, writer);
            GeneratedMessageLite<UploadMsgImgRequest, Builder>.PrintField("CDNBigImgSize", this.hasCDNBigImgSize, this.cDNBigImgSize_, writer);
            GeneratedMessageLite<UploadMsgImgRequest, Builder>.PrintField("CDNMidImgSize", this.hasCDNMidImgSize, this.cDNMidImgSize_, writer);
            GeneratedMessageLite<UploadMsgImgRequest, Builder>.PrintField("CDNThumbImgUrl", this.hasCDNThumbImgUrl, this.cDNThumbImgUrl_, writer);
            GeneratedMessageLite<UploadMsgImgRequest, Builder>.PrintField("CDNThumbImgSize", this.hasCDNThumbImgSize, this.cDNThumbImgSize_, writer);
            GeneratedMessageLite<UploadMsgImgRequest, Builder>.PrintField("CDNThumbImgHeight", this.hasCDNThumbImgHeight, this.cDNThumbImgHeight_, writer);
            GeneratedMessageLite<UploadMsgImgRequest, Builder>.PrintField("CDNThumbImgWidth", this.hasCDNThumbImgWidth, this.cDNThumbImgWidth_, writer);
            GeneratedMessageLite<UploadMsgImgRequest, Builder>.PrintField("CDNThumbAESKey", this.hasCDNThumbAESKey, this.cDNThumbAESKey_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _uploadMsgImgRequestFieldNames;
            if (this.hasBaseRequest)
            {
                output.WriteMessage(1, strArray[1], this.BaseRequest);
            }
            if (this.hasClientImgId)
            {
                output.WriteMessage(2, strArray[11], this.ClientImgId);
            }
            if (this.hasFromUserName)
            {
                output.WriteMessage(3, strArray[0x10], this.FromUserName);
            }
            if (this.hasToUserName)
            {
                output.WriteMessage(4, strArray[0x17], this.ToUserName);
            }
            if (this.hasTotalLen)
            {
                output.WriteUInt32(5, strArray[0x18], this.TotalLen);
            }
            if (this.hasStartPos)
            {
                output.WriteUInt32(6, strArray[0x16], this.StartPos);
            }
            if (this.hasDataLen)
            {
                output.WriteUInt32(7, strArray[14], this.DataLen);
            }
            if (this.hasData)
            {
                output.WriteMessage(8, strArray[13], this.Data);
            }
            if (this.hasMsgType)
            {
                output.WriteUInt32(9, strArray[0x13], this.MsgType);
            }
            if (this.hasMsgSource)
            {
                output.WriteString(10, strArray[0x12], this.MsgSource);
            }
            if (this.hasCompressType)
            {
                output.WriteUInt32(11, strArray[12], this.CompressType);
            }
            if (this.hasNetType)
            {
                output.WriteInt32(12, strArray[20], this.NetType);
            }
            if (this.hasPhotoFrom)
            {
                output.WriteInt32(13, strArray[0x15], this.PhotoFrom);
            }
            if (this.hasMediaId)
            {
                output.WriteString(14, strArray[0x11], this.MediaId);
            }
            if (this.hasCDNBigImgUrl)
            {
                output.WriteString(15, strArray[3], this.CDNBigImgUrl);
            }
            if (this.hasCDNMidImgUrl)
            {
                output.WriteString(0x10, strArray[5], this.CDNMidImgUrl);
            }
            if (this.hasAESKey)
            {
                output.WriteString(0x11, strArray[0], this.AESKey);
            }
            if (this.hasEncryVer)
            {
                output.WriteInt32(0x12, strArray[15], this.EncryVer);
            }
            if (this.hasCDNBigImgSize)
            {
                output.WriteInt32(0x13, strArray[2], this.CDNBigImgSize);
            }
            if (this.hasCDNMidImgSize)
            {
                output.WriteInt32(20, strArray[4], this.CDNMidImgSize);
            }
            if (this.hasCDNThumbImgUrl)
            {
                output.WriteString(0x15, strArray[9], this.CDNThumbImgUrl);
            }
            if (this.hasCDNThumbImgSize)
            {
                output.WriteInt32(0x16, strArray[8], this.CDNThumbImgSize);
            }
            if (this.hasCDNThumbImgHeight)
            {
                output.WriteInt32(0x17, strArray[7], this.CDNThumbImgHeight);
            }
            if (this.hasCDNThumbImgWidth)
            {
                output.WriteInt32(0x18, strArray[10], this.CDNThumbImgWidth);
            }
            if (this.hasCDNThumbAESKey)
            {
                output.WriteString(0x19, strArray[6], this.CDNThumbAESKey);
            }
        }

        public string AESKey
        {
            get
            {
                return this.aESKey_;
            }
        }

        public BaseRequest BaseRequest
        {
            get
            {
                return (this.baseRequest_ ?? BaseRequest.DefaultInstance);
            }
        }

        public int CDNBigImgSize
        {
            get
            {
                return this.cDNBigImgSize_;
            }
        }

        public string CDNBigImgUrl
        {
            get
            {
                return this.cDNBigImgUrl_;
            }
        }

        public int CDNMidImgSize
        {
            get
            {
                return this.cDNMidImgSize_;
            }
        }

        public string CDNMidImgUrl
        {
            get
            {
                return this.cDNMidImgUrl_;
            }
        }

        public string CDNThumbAESKey
        {
            get
            {
                return this.cDNThumbAESKey_;
            }
        }

        public int CDNThumbImgHeight
        {
            get
            {
                return this.cDNThumbImgHeight_;
            }
        }

        public int CDNThumbImgSize
        {
            get
            {
                return this.cDNThumbImgSize_;
            }
        }

        public string CDNThumbImgUrl
        {
            get
            {
                return this.cDNThumbImgUrl_;
            }
        }

        public int CDNThumbImgWidth
        {
            get
            {
                return this.cDNThumbImgWidth_;
            }
        }

        public SKBuiltinString_t ClientImgId
        {
            get
            {
                return (this.clientImgId_ ?? SKBuiltinString_t.DefaultInstance);
            }
        }

        public uint CompressType
        {
            get
            {
                return this.compressType_;
            }
        }

        public SKBuiltinBuffer_t Data
        {
            get
            {
                return (this.data_ ?? SKBuiltinBuffer_t.DefaultInstance);
            }
        }

        public uint DataLen
        {
            get
            {
                return this.dataLen_;
            }
        }

        public static UploadMsgImgRequest DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override UploadMsgImgRequest DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public int EncryVer
        {
            get
            {
                return this.encryVer_;
            }
        }

        public SKBuiltinString_t FromUserName
        {
            get
            {
                return (this.fromUserName_ ?? SKBuiltinString_t.DefaultInstance);
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
                if (!this.hasClientImgId)
                {
                    return false;
                }
                if (!this.hasFromUserName)
                {
                    return false;
                }
                if (!this.hasToUserName)
                {
                    return false;
                }
                if (!this.hasTotalLen)
                {
                    return false;
                }
                if (!this.hasStartPos)
                {
                    return false;
                }
                if (!this.hasDataLen)
                {
                    return false;
                }
                if (!this.hasData)
                {
                    return false;
                }
                if (!this.BaseRequest.IsInitialized)
                {
                    return false;
                }
                if (!this.Data.IsInitialized)
                {
                    return false;
                }
                return true;
            }
        }

        public string MediaId
        {
            get
            {
                return this.mediaId_;
            }
        }

        public string MsgSource
        {
            get
            {
                return this.msgSource_;
            }
        }

        public uint MsgType
        {
            get
            {
                return this.msgType_;
            }
        }

        public int NetType
        {
            get
            {
                return this.netType_;
            }
        }

        public int PhotoFrom
        {
            get
            {
                return this.photoFrom_;
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
                    if (this.hasClientImgId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(2, this.ClientImgId);
                    }
                    if (this.hasFromUserName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(3, this.FromUserName);
                    }
                    if (this.hasToUserName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(4, this.ToUserName);
                    }
                    if (this.hasTotalLen)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(5, this.TotalLen);
                    }
                    if (this.hasStartPos)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(6, this.StartPos);
                    }
                    if (this.hasDataLen)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(7, this.DataLen);
                    }
                    if (this.hasData)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(8, this.Data);
                    }
                    if (this.hasMsgType)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(9, this.MsgType);
                    }
                    if (this.hasMsgSource)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(10, this.MsgSource);
                    }
                    if (this.hasCompressType)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(11, this.CompressType);
                    }
                    if (this.hasNetType)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(12, this.NetType);
                    }
                    if (this.hasPhotoFrom)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(13, this.PhotoFrom);
                    }
                    if (this.hasMediaId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(14, this.MediaId);
                    }
                    if (this.hasCDNBigImgUrl)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(15, this.CDNBigImgUrl);
                    }
                    if (this.hasCDNMidImgUrl)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x10, this.CDNMidImgUrl);
                    }
                    if (this.hasAESKey)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x11, this.AESKey);
                    }
                    if (this.hasEncryVer)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(0x12, this.EncryVer);
                    }
                    if (this.hasCDNBigImgSize)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(0x13, this.CDNBigImgSize);
                    }
                    if (this.hasCDNMidImgSize)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(20, this.CDNMidImgSize);
                    }
                    if (this.hasCDNThumbImgUrl)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x15, this.CDNThumbImgUrl);
                    }
                    if (this.hasCDNThumbImgSize)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(0x16, this.CDNThumbImgSize);
                    }
                    if (this.hasCDNThumbImgHeight)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(0x17, this.CDNThumbImgHeight);
                    }
                    if (this.hasCDNThumbImgWidth)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(0x18, this.CDNThumbImgWidth);
                    }
                    if (this.hasCDNThumbAESKey)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x19, this.CDNThumbAESKey);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        public uint StartPos
        {
            get
            {
                return this.startPos_;
            }
        }

        protected override UploadMsgImgRequest ThisMessage
        {
            get
            {
                return this;
            }
        }

        public uint TotalLen
        {
            get
            {
                return this.totalLen_;
            }
        }

        public SKBuiltinString_t ToUserName
        {
            get
            {
                return (this.toUserName_ ?? SKBuiltinString_t.DefaultInstance);
            }
        }

        [DebuggerNonUserCode, GeneratedCode("ProtoGen", "2.3.0.277"), CompilerGenerated]
        public sealed class Builder : GeneratedBuilderLite<UploadMsgImgRequest, UploadMsgImgRequest.Builder>
        {
            private UploadMsgImgRequest result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = UploadMsgImgRequest.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(UploadMsgImgRequest cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override UploadMsgImgRequest BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override UploadMsgImgRequest.Builder Clear()
            {
                this.result = UploadMsgImgRequest.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public UploadMsgImgRequest.Builder ClearAESKey()
            {
                this.PrepareBuilder();
                this.result.hasAESKey = false;
                this.result.aESKey_ = "";
                return this;
            }

            public UploadMsgImgRequest.Builder ClearBaseRequest()
            {
                this.PrepareBuilder();
                this.result.hasBaseRequest = false;
                this.result.baseRequest_ = null;
                return this;
            }

            public UploadMsgImgRequest.Builder ClearCDNBigImgSize()
            {
                this.PrepareBuilder();
                this.result.hasCDNBigImgSize = false;
                this.result.cDNBigImgSize_ = 0;
                return this;
            }

            public UploadMsgImgRequest.Builder ClearCDNBigImgUrl()
            {
                this.PrepareBuilder();
                this.result.hasCDNBigImgUrl = false;
                this.result.cDNBigImgUrl_ = "";
                return this;
            }

            public UploadMsgImgRequest.Builder ClearCDNMidImgSize()
            {
                this.PrepareBuilder();
                this.result.hasCDNMidImgSize = false;
                this.result.cDNMidImgSize_ = 0;
                return this;
            }

            public UploadMsgImgRequest.Builder ClearCDNMidImgUrl()
            {
                this.PrepareBuilder();
                this.result.hasCDNMidImgUrl = false;
                this.result.cDNMidImgUrl_ = "";
                return this;
            }

            public UploadMsgImgRequest.Builder ClearCDNThumbAESKey()
            {
                this.PrepareBuilder();
                this.result.hasCDNThumbAESKey = false;
                this.result.cDNThumbAESKey_ = "";
                return this;
            }

            public UploadMsgImgRequest.Builder ClearCDNThumbImgHeight()
            {
                this.PrepareBuilder();
                this.result.hasCDNThumbImgHeight = false;
                this.result.cDNThumbImgHeight_ = 0;
                return this;
            }

            public UploadMsgImgRequest.Builder ClearCDNThumbImgSize()
            {
                this.PrepareBuilder();
                this.result.hasCDNThumbImgSize = false;
                this.result.cDNThumbImgSize_ = 0;
                return this;
            }

            public UploadMsgImgRequest.Builder ClearCDNThumbImgUrl()
            {
                this.PrepareBuilder();
                this.result.hasCDNThumbImgUrl = false;
                this.result.cDNThumbImgUrl_ = "";
                return this;
            }

            public UploadMsgImgRequest.Builder ClearCDNThumbImgWidth()
            {
                this.PrepareBuilder();
                this.result.hasCDNThumbImgWidth = false;
                this.result.cDNThumbImgWidth_ = 0;
                return this;
            }

            public UploadMsgImgRequest.Builder ClearClientImgId()
            {
                this.PrepareBuilder();
                this.result.hasClientImgId = false;
                this.result.clientImgId_ = null;
                return this;
            }

            public UploadMsgImgRequest.Builder ClearCompressType()
            {
                this.PrepareBuilder();
                this.result.hasCompressType = false;
                this.result.compressType_ = 0;
                return this;
            }

            public UploadMsgImgRequest.Builder ClearData()
            {
                this.PrepareBuilder();
                this.result.hasData = false;
                this.result.data_ = null;
                return this;
            }

            public UploadMsgImgRequest.Builder ClearDataLen()
            {
                this.PrepareBuilder();
                this.result.hasDataLen = false;
                this.result.dataLen_ = 0;
                return this;
            }

            public UploadMsgImgRequest.Builder ClearEncryVer()
            {
                this.PrepareBuilder();
                this.result.hasEncryVer = false;
                this.result.encryVer_ = 0;
                return this;
            }

            public UploadMsgImgRequest.Builder ClearFromUserName()
            {
                this.PrepareBuilder();
                this.result.hasFromUserName = false;
                this.result.fromUserName_ = null;
                return this;
            }

            public UploadMsgImgRequest.Builder ClearMediaId()
            {
                this.PrepareBuilder();
                this.result.hasMediaId = false;
                this.result.mediaId_ = "";
                return this;
            }

            public UploadMsgImgRequest.Builder ClearMsgSource()
            {
                this.PrepareBuilder();
                this.result.hasMsgSource = false;
                this.result.msgSource_ = "";
                return this;
            }

            public UploadMsgImgRequest.Builder ClearMsgType()
            {
                this.PrepareBuilder();
                this.result.hasMsgType = false;
                this.result.msgType_ = 0;
                return this;
            }

            public UploadMsgImgRequest.Builder ClearNetType()
            {
                this.PrepareBuilder();
                this.result.hasNetType = false;
                this.result.netType_ = 0;
                return this;
            }

            public UploadMsgImgRequest.Builder ClearPhotoFrom()
            {
                this.PrepareBuilder();
                this.result.hasPhotoFrom = false;
                this.result.photoFrom_ = 0;
                return this;
            }

            public UploadMsgImgRequest.Builder ClearStartPos()
            {
                this.PrepareBuilder();
                this.result.hasStartPos = false;
                this.result.startPos_ = 0;
                return this;
            }

            public UploadMsgImgRequest.Builder ClearTotalLen()
            {
                this.PrepareBuilder();
                this.result.hasTotalLen = false;
                this.result.totalLen_ = 0;
                return this;
            }

            public UploadMsgImgRequest.Builder ClearToUserName()
            {
                this.PrepareBuilder();
                this.result.hasToUserName = false;
                this.result.toUserName_ = null;
                return this;
            }

            public override UploadMsgImgRequest.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new UploadMsgImgRequest.Builder(this.result);
                }
                return new UploadMsgImgRequest.Builder().MergeFrom(this.result);
            }

            public UploadMsgImgRequest.Builder MergeBaseRequest(BaseRequest value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasBaseRequest && (this.result.baseRequest_ != BaseRequest.DefaultInstance))
                {
                    this.result.baseRequest_ = BaseRequest.CreateBuilder(this.result.baseRequest_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.baseRequest_ = value;
                }
                this.result.hasBaseRequest = true;
                return this;
            }

            public UploadMsgImgRequest.Builder MergeClientImgId(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasClientImgId && (this.result.clientImgId_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.clientImgId_ = SKBuiltinString_t.CreateBuilder(this.result.clientImgId_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.clientImgId_ = value;
                }
                this.result.hasClientImgId = true;
                return this;
            }

            public UploadMsgImgRequest.Builder MergeData(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasData && (this.result.data_ != SKBuiltinBuffer_t.DefaultInstance))
                {
                    this.result.data_ = SKBuiltinBuffer_t.CreateBuilder(this.result.data_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.data_ = value;
                }
                this.result.hasData = true;
                return this;
            }

            public override UploadMsgImgRequest.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override UploadMsgImgRequest.Builder MergeFrom(IMessageLite other)
            {
                if (other is UploadMsgImgRequest)
                {
                    return this.MergeFrom((UploadMsgImgRequest)other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override UploadMsgImgRequest.Builder MergeFrom(UploadMsgImgRequest other)
            {
                return this;
            }

            public override UploadMsgImgRequest.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(UploadMsgImgRequest._uploadMsgImgRequestFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = UploadMsgImgRequest._uploadMsgImgRequestFieldTags[index];
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
                                SKBuiltinString_t.Builder builder3 = SKBuiltinString_t.CreateBuilder();
                                if (this.result.hasFromUserName)
                                {
                                    builder3.MergeFrom(this.FromUserName);
                                }
                                input.ReadMessage(builder3, extensionRegistry);
                                this.FromUserName = builder3.BuildPartial();
                                continue;
                            }
                        case 0x22:
                            {
                                SKBuiltinString_t.Builder builder4 = SKBuiltinString_t.CreateBuilder();
                                if (this.result.hasToUserName)
                                {
                                    builder4.MergeFrom(this.ToUserName);
                                }
                                input.ReadMessage(builder4, extensionRegistry);
                                this.ToUserName = builder4.BuildPartial();
                                continue;
                            }
                        case 40:
                            {
                                this.result.hasTotalLen = input.ReadUInt32(ref this.result.totalLen_);
                                continue;
                            }
                        case 0:
                            throw InvalidProtocolBufferException.InvalidTag();

                        case 10:
                            {
                                BaseRequest.Builder builder = BaseRequest.CreateBuilder();
                                if (this.result.hasBaseRequest)
                                {
                                    builder.MergeFrom(this.BaseRequest);
                                }
                                input.ReadMessage(builder, extensionRegistry);
                                this.BaseRequest = builder.BuildPartial();
                                continue;
                            }
                        case 0x12:
                            {
                                SKBuiltinString_t.Builder builder2 = SKBuiltinString_t.CreateBuilder();
                                if (this.result.hasClientImgId)
                                {
                                    builder2.MergeFrom(this.ClientImgId);
                                }
                                input.ReadMessage(builder2, extensionRegistry);
                                this.ClientImgId = builder2.BuildPartial();
                                continue;
                            }
                        case 0x30:
                            {
                                this.result.hasStartPos = input.ReadUInt32(ref this.result.startPos_);
                                continue;
                            }
                        case 0x38:
                            {
                                this.result.hasDataLen = input.ReadUInt32(ref this.result.dataLen_);
                                continue;
                            }
                        case 0x42:
                            {
                                SKBuiltinBuffer_t.Builder builder5 = SKBuiltinBuffer_t.CreateBuilder();
                                if (this.result.hasData)
                                {
                                    builder5.MergeFrom(this.Data);
                                }
                                input.ReadMessage(builder5, extensionRegistry);
                                this.Data = builder5.BuildPartial();
                                continue;
                            }
                        case 0x58:
                            {
                                this.result.hasCompressType = input.ReadUInt32(ref this.result.compressType_);
                                continue;
                            }
                        case 0x60:
                            {
                                this.result.hasNetType = input.ReadInt32(ref this.result.netType_);
                                continue;
                            }
                        case 0x48:
                            {
                                this.result.hasMsgType = input.ReadUInt32(ref this.result.msgType_);
                                continue;
                            }
                        case 0x52:
                            {
                                this.result.hasMsgSource = input.ReadString(ref this.result.msgSource_);
                                continue;
                            }
                        case 130:
                            {
                                this.result.hasCDNMidImgUrl = input.ReadString(ref this.result.cDNMidImgUrl_);
                                continue;
                            }
                        case 0x8a:
                            {
                                this.result.hasAESKey = input.ReadString(ref this.result.aESKey_);
                                continue;
                            }
                        case 0x90:
                            {
                                this.result.hasEncryVer = input.ReadInt32(ref this.result.encryVer_);
                                continue;
                            }
                        case 0x68:
                            {
                                this.result.hasPhotoFrom = input.ReadInt32(ref this.result.photoFrom_);
                                continue;
                            }
                        case 0x72:
                            {
                                this.result.hasMediaId = input.ReadString(ref this.result.mediaId_);
                                continue;
                            }
                        case 0x7a:
                            {
                                this.result.hasCDNBigImgUrl = input.ReadString(ref this.result.cDNBigImgUrl_);
                                continue;
                            }
                        case 0x98:
                            {
                                this.result.hasCDNBigImgSize = input.ReadInt32(ref this.result.cDNBigImgSize_);
                                continue;
                            }
                        case 160:
                            {
                                this.result.hasCDNMidImgSize = input.ReadInt32(ref this.result.cDNMidImgSize_);
                                continue;
                            }
                        case 170:
                            {
                                this.result.hasCDNThumbImgUrl = input.ReadString(ref this.result.cDNThumbImgUrl_);
                                continue;
                            }
                        case 0xb0:
                            {
                                this.result.hasCDNThumbImgSize = input.ReadInt32(ref this.result.cDNThumbImgSize_);
                                continue;
                            }
                        case 0xb8:
                            {
                                this.result.hasCDNThumbImgHeight = input.ReadInt32(ref this.result.cDNThumbImgHeight_);
                                continue;
                            }
                        case 0xc0:
                            {
                                this.result.hasCDNThumbImgWidth = input.ReadInt32(ref this.result.cDNThumbImgWidth_);
                                continue;
                            }
                        case 0xca:
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
                    this.result.hasCDNThumbAESKey = input.ReadString(ref this.result.cDNThumbAESKey_);
                }
                return this;
            }

            public UploadMsgImgRequest.Builder MergeFromUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasFromUserName && (this.result.fromUserName_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.fromUserName_ = SKBuiltinString_t.CreateBuilder(this.result.fromUserName_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.fromUserName_ = value;
                }
                this.result.hasFromUserName = true;
                return this;
            }

            public UploadMsgImgRequest.Builder MergeToUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasToUserName && (this.result.toUserName_ != SKBuiltinString_t.DefaultInstance))
                {
                    this.result.toUserName_ = SKBuiltinString_t.CreateBuilder(this.result.toUserName_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.toUserName_ = value;
                }
                this.result.hasToUserName = true;
                return this;
            }

            private UploadMsgImgRequest PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    UploadMsgImgRequest result = this.result;
                    this.result = new UploadMsgImgRequest();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public UploadMsgImgRequest.Builder SetAESKey(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasAESKey = true;
                this.result.aESKey_ = value;
                return this;
            }

            public UploadMsgImgRequest.Builder SetBaseRequest(BaseRequest value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = value;
                return this;
            }

            public UploadMsgImgRequest.Builder SetBaseRequest(BaseRequest.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = builderForValue.Build();
                return this;
            }

            public UploadMsgImgRequest.Builder SetCDNBigImgSize(int value)
            {
                this.PrepareBuilder();
                this.result.hasCDNBigImgSize = true;
                this.result.cDNBigImgSize_ = value;
                return this;
            }

            public UploadMsgImgRequest.Builder SetCDNBigImgUrl(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasCDNBigImgUrl = true;
                this.result.cDNBigImgUrl_ = value;
                return this;
            }

            public UploadMsgImgRequest.Builder SetCDNMidImgSize(int value)
            {
                this.PrepareBuilder();
                this.result.hasCDNMidImgSize = true;
                this.result.cDNMidImgSize_ = value;
                return this;
            }

            public UploadMsgImgRequest.Builder SetCDNMidImgUrl(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasCDNMidImgUrl = true;
                this.result.cDNMidImgUrl_ = value;
                return this;
            }

            public UploadMsgImgRequest.Builder SetCDNThumbAESKey(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasCDNThumbAESKey = true;
                this.result.cDNThumbAESKey_ = value;
                return this;
            }

            public UploadMsgImgRequest.Builder SetCDNThumbImgHeight(int value)
            {
                this.PrepareBuilder();
                this.result.hasCDNThumbImgHeight = true;
                this.result.cDNThumbImgHeight_ = value;
                return this;
            }

            public UploadMsgImgRequest.Builder SetCDNThumbImgSize(int value)
            {
                this.PrepareBuilder();
                this.result.hasCDNThumbImgSize = true;
                this.result.cDNThumbImgSize_ = value;
                return this;
            }

            public UploadMsgImgRequest.Builder SetCDNThumbImgUrl(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasCDNThumbImgUrl = true;
                this.result.cDNThumbImgUrl_ = value;
                return this;
            }

            public UploadMsgImgRequest.Builder SetCDNThumbImgWidth(int value)
            {
                this.PrepareBuilder();
                this.result.hasCDNThumbImgWidth = true;
                this.result.cDNThumbImgWidth_ = value;
                return this;
            }

            public UploadMsgImgRequest.Builder SetClientImgId(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasClientImgId = true;
                this.result.clientImgId_ = value;
                return this;
            }

            public UploadMsgImgRequest.Builder SetClientImgId(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasClientImgId = true;
                this.result.clientImgId_ = builderForValue.Build();
                return this;
            }

            public UploadMsgImgRequest.Builder SetCompressType(uint value)
            {
                this.PrepareBuilder();
                this.result.hasCompressType = true;
                this.result.compressType_ = value;
                return this;
            }

            public UploadMsgImgRequest.Builder SetData(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasData = true;
                this.result.data_ = value;
                return this;
            }

            public UploadMsgImgRequest.Builder SetData(SKBuiltinBuffer_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasData = true;
                this.result.data_ = builderForValue.Build();
                return this;
            }

            public UploadMsgImgRequest.Builder SetDataLen(uint value)
            {
                this.PrepareBuilder();
                this.result.hasDataLen = true;
                this.result.dataLen_ = value;
                return this;
            }

            public UploadMsgImgRequest.Builder SetEncryVer(int value)
            {
                this.PrepareBuilder();
                this.result.hasEncryVer = true;
                this.result.encryVer_ = value;
                return this;
            }

            public UploadMsgImgRequest.Builder SetFromUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasFromUserName = true;
                this.result.fromUserName_ = value;
                return this;
            }

            public UploadMsgImgRequest.Builder SetFromUserName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasFromUserName = true;
                this.result.fromUserName_ = builderForValue.Build();
                return this;
            }

            public UploadMsgImgRequest.Builder SetMediaId(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasMediaId = true;
                this.result.mediaId_ = value;
                return this;
            }

            public UploadMsgImgRequest.Builder SetMsgSource(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasMsgSource = true;
                this.result.msgSource_ = value;
                return this;
            }

            public UploadMsgImgRequest.Builder SetMsgType(uint value)
            {
                this.PrepareBuilder();
                this.result.hasMsgType = true;
                this.result.msgType_ = value;
                return this;
            }

            public UploadMsgImgRequest.Builder SetNetType(int value)
            {
                this.PrepareBuilder();
                this.result.hasNetType = true;
                this.result.netType_ = value;
                return this;
            }

            public UploadMsgImgRequest.Builder SetPhotoFrom(int value)
            {
                this.PrepareBuilder();
                this.result.hasPhotoFrom = true;
                this.result.photoFrom_ = value;
                return this;
            }

            public UploadMsgImgRequest.Builder SetStartPos(uint value)
            {
                this.PrepareBuilder();
                this.result.hasStartPos = true;
                this.result.startPos_ = value;
                return this;
            }

            public UploadMsgImgRequest.Builder SetTotalLen(uint value)
            {
                this.PrepareBuilder();
                this.result.hasTotalLen = true;
                this.result.totalLen_ = value;
                return this;
            }

            public UploadMsgImgRequest.Builder SetToUserName(SKBuiltinString_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasToUserName = true;
                this.result.toUserName_ = value;
                return this;
            }

            public UploadMsgImgRequest.Builder SetToUserName(SKBuiltinString_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasToUserName = true;
                this.result.toUserName_ = builderForValue.Build();
                return this;
            }

            public string AESKey
            {
                get
                {
                    return this.result.AESKey;
                }
                set
                {
                    this.SetAESKey(value);
                }
            }

            public BaseRequest BaseRequest
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

            public int CDNBigImgSize
            {
                get
                {
                    return this.result.CDNBigImgSize;
                }
                set
                {
                    this.SetCDNBigImgSize(value);
                }
            }

            public string CDNBigImgUrl
            {
                get
                {
                    return this.result.CDNBigImgUrl;
                }
                set
                {
                    this.SetCDNBigImgUrl(value);
                }
            }

            public int CDNMidImgSize
            {
                get
                {
                    return this.result.CDNMidImgSize;
                }
                set
                {
                    this.SetCDNMidImgSize(value);
                }
            }

            public string CDNMidImgUrl
            {
                get
                {
                    return this.result.CDNMidImgUrl;
                }
                set
                {
                    this.SetCDNMidImgUrl(value);
                }
            }

            public string CDNThumbAESKey
            {
                get
                {
                    return this.result.CDNThumbAESKey;
                }
                set
                {
                    this.SetCDNThumbAESKey(value);
                }
            }

            public int CDNThumbImgHeight
            {
                get
                {
                    return this.result.CDNThumbImgHeight;
                }
                set
                {
                    this.SetCDNThumbImgHeight(value);
                }
            }

            public int CDNThumbImgSize
            {
                get
                {
                    return this.result.CDNThumbImgSize;
                }
                set
                {
                    this.SetCDNThumbImgSize(value);
                }
            }

            public string CDNThumbImgUrl
            {
                get
                {
                    return this.result.CDNThumbImgUrl;
                }
                set
                {
                    this.SetCDNThumbImgUrl(value);
                }
            }

            public int CDNThumbImgWidth
            {
                get
                {
                    return this.result.CDNThumbImgWidth;
                }
                set
                {
                    this.SetCDNThumbImgWidth(value);
                }
            }

            public SKBuiltinString_t ClientImgId
            {
                get
                {
                    return this.result.ClientImgId;
                }
                set
                {
                    this.SetClientImgId(value);
                }
            }

            public uint CompressType
            {
                get
                {
                    return this.result.CompressType;
                }
                set
                {
                    this.SetCompressType(value);
                }
            }

            public SKBuiltinBuffer_t Data
            {
                get
                {
                    return this.result.Data;
                }
                set
                {
                    this.SetData(value);
                }
            }

            public uint DataLen
            {
                get
                {
                    return this.result.DataLen;
                }
                set
                {
                    this.SetDataLen(value);
                }
            }

            public override UploadMsgImgRequest DefaultInstanceForType
            {
                get
                {
                    return UploadMsgImgRequest.DefaultInstance;
                }
            }

            public int EncryVer
            {
                get
                {
                    return this.result.EncryVer;
                }
                set
                {
                    this.SetEncryVer(value);
                }
            }

            public SKBuiltinString_t FromUserName
            {
                get
                {
                    return this.result.FromUserName;
                }
                set
                {
                    this.SetFromUserName(value);
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            public string MediaId
            {
                get
                {
                    return this.result.MediaId;
                }
                set
                {
                    this.SetMediaId(value);
                }
            }

            protected override UploadMsgImgRequest MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public string MsgSource
            {
                get
                {
                    return this.result.MsgSource;
                }
                set
                {
                    this.SetMsgSource(value);
                }
            }

            public uint MsgType
            {
                get
                {
                    return this.result.MsgType;
                }
                set
                {
                    this.SetMsgType(value);
                }
            }

            public int NetType
            {
                get
                {
                    return this.result.NetType;
                }
                set
                {
                    this.SetNetType(value);
                }
            }

            public int PhotoFrom
            {
                get
                {
                    return this.result.PhotoFrom;
                }
                set
                {
                    this.SetPhotoFrom(value);
                }
            }

            public uint StartPos
            {
                get
                {
                    return this.result.StartPos;
                }
                set
                {
                    this.SetStartPos(value);
                }
            }

            protected override UploadMsgImgRequest.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }

            public uint TotalLen
            {
                get
                {
                    return this.result.TotalLen;
                }
                set
                {
                    this.SetTotalLen(value);
                }
            }

            public SKBuiltinString_t ToUserName
            {
                get
                {
                    return this.result.ToUserName;
                }
                set
                {
                    this.SetToUserName(value);
                }
            }
        }
    }
}

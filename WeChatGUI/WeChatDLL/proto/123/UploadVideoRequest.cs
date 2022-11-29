namespace micromsg
{
    using Google.ProtocolBuffers;

    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.IO;
    

    
    public sealed class UploadVideoRequest : GeneratedMessageLite<UploadVideoRequest, UploadVideoRequest.Builder>
    {
        private static readonly string[] _uploadVideoRequestFieldNames = new string[] { 
            "AESKey", "BaseRequest", "CDNThumbAESKey", "CDNThumbImgHeight", "CDNThumbImgSize", "CDNThumbImgWidth", "CDNThumbUrl", "CDNVideoUrl", "CameraType", "ClientMsgId", "EncryVer", "FromUserName", "FuncFlag", "MsgSource", "NetworkEnv", "PlayLength", 
            "ReqTime", "ThumbData", "ThumbStartPos", "ThumbTotalLen", "ToUserName", "VideoData", "VideoFrom", "VideoMd5", "VideoStartPos", "VideoTotalLen"
         };
        private static readonly uint[] _uploadVideoRequestFieldTags = new uint[] { 
            0x8a, 10, 0xba, 0xa8, 160, 0xb0, 0x9a, 130, 0x68, 0x12, 0x90, 0x1a, 0x70, 0x7a, 0x60, 0x58, 
            200, 0x3a, 0x30, 40, 0x22, 0x52, 0xc0, 210, 0x48, 0x40
         };
        private string aESKey_ = "";
        public const int AESKeyFieldNumber = 0x11;
        private BaseRequest baseRequest_;
        public const int BaseRequestFieldNumber = 1;
        private uint cameraType_;
        public const int CameraTypeFieldNumber = 13;
        private string cDNThumbAESKey_ = "";
        public const int CDNThumbAESKeyFieldNumber = 0x17;
        private int cDNThumbImgHeight_;
        public const int CDNThumbImgHeightFieldNumber = 0x15;
        private int cDNThumbImgSize_;
        public const int CDNThumbImgSizeFieldNumber = 20;
        private int cDNThumbImgWidth_;
        public const int CDNThumbImgWidthFieldNumber = 0x16;
        private string cDNThumbUrl_ = "";
        public const int CDNThumbUrlFieldNumber = 0x13;
        private string cDNVideoUrl_ = "";
        public const int CDNVideoUrlFieldNumber = 0x10;
        private string clientMsgId_ = "";
        public const int ClientMsgIdFieldNumber = 2;
        private static readonly UploadVideoRequest defaultInstance = new UploadVideoRequest().MakeReadOnly();
        private int encryVer_;
        public const int EncryVerFieldNumber = 0x12;
        private string fromUserName_ = "";
        public const int FromUserNameFieldNumber = 3;
        private uint funcFlag_;
        public const int FuncFlagFieldNumber = 14;
        private bool hasAESKey;
        private bool hasBaseRequest;
        private bool hasCameraType;
        private bool hasCDNThumbAESKey;
        private bool hasCDNThumbImgHeight;
        private bool hasCDNThumbImgSize;
        private bool hasCDNThumbImgWidth;
        private bool hasCDNThumbUrl;
        private bool hasCDNVideoUrl;
        private bool hasClientMsgId;
        private bool hasEncryVer;
        private bool hasFromUserName;
        private bool hasFuncFlag;
        private bool hasMsgSource;
        private bool hasNetworkEnv;
        private bool hasPlayLength;
        private bool hasReqTime;
        private bool hasThumbData;
        private bool hasThumbStartPos;
        private bool hasThumbTotalLen;
        private bool hasToUserName;
        private bool hasVideoData;
        private bool hasVideoFrom;
        private bool hasVideoMd5;
        private bool hasVideoStartPos;
        private bool hasVideoTotalLen;
        private int memoizedSerializedSize = -1;
        private string msgSource_ = "";
        public const int MsgSourceFieldNumber = 15;
        private uint networkEnv_;
        public const int NetworkEnvFieldNumber = 12;
        private uint playLength_;
        public const int PlayLengthFieldNumber = 11;
        private uint reqTime_;
        public const int ReqTimeFieldNumber = 0x19;
        private SKBuiltinBuffer_t thumbData_;
        public const int ThumbDataFieldNumber = 7;
        private uint thumbStartPos_;
        public const int ThumbStartPosFieldNumber = 6;
        private uint thumbTotalLen_;
        public const int ThumbTotalLenFieldNumber = 5;
        private string toUserName_ = "";
        public const int ToUserNameFieldNumber = 4;
        private SKBuiltinBuffer_t videoData_;
        public const int VideoDataFieldNumber = 10;
        private int videoFrom_;
        public const int VideoFromFieldNumber = 0x18;
        private string videoMd5_ = "";
        public const int VideoMd5FieldNumber = 0x1a;
        private uint videoStartPos_;
        public const int VideoStartPosFieldNumber = 9;
        private uint videoTotalLen_;
        public const int VideoTotalLenFieldNumber = 8;

        static UploadVideoRequest()
        {
        }

        private UploadVideoRequest()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(UploadVideoRequest prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            UploadVideoRequest request = obj as UploadVideoRequest;
            if (request == null)
            {
                return false;
            }
            if ((this.hasBaseRequest != request.hasBaseRequest) || (this.hasBaseRequest && !this.baseRequest_.Equals(request.baseRequest_)))
            {
                return false;
            }
            if ((this.hasClientMsgId != request.hasClientMsgId) || (this.hasClientMsgId && !this.clientMsgId_.Equals(request.clientMsgId_)))
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
            if ((this.hasThumbTotalLen != request.hasThumbTotalLen) || (this.hasThumbTotalLen && !this.thumbTotalLen_.Equals(request.thumbTotalLen_)))
            {
                return false;
            }
            if ((this.hasThumbStartPos != request.hasThumbStartPos) || (this.hasThumbStartPos && !this.thumbStartPos_.Equals(request.thumbStartPos_)))
            {
                return false;
            }
            if ((this.hasThumbData != request.hasThumbData) || (this.hasThumbData && !this.thumbData_.Equals(request.thumbData_)))
            {
                return false;
            }
            if ((this.hasVideoTotalLen != request.hasVideoTotalLen) || (this.hasVideoTotalLen && !this.videoTotalLen_.Equals(request.videoTotalLen_)))
            {
                return false;
            }
            if ((this.hasVideoStartPos != request.hasVideoStartPos) || (this.hasVideoStartPos && !this.videoStartPos_.Equals(request.videoStartPos_)))
            {
                return false;
            }
            if ((this.hasVideoData != request.hasVideoData) || (this.hasVideoData && !this.videoData_.Equals(request.videoData_)))
            {
                return false;
            }
            if ((this.hasPlayLength != request.hasPlayLength) || (this.hasPlayLength && !this.playLength_.Equals(request.playLength_)))
            {
                return false;
            }
            if ((this.hasNetworkEnv != request.hasNetworkEnv) || (this.hasNetworkEnv && !this.networkEnv_.Equals(request.networkEnv_)))
            {
                return false;
            }
            if ((this.hasCameraType != request.hasCameraType) || (this.hasCameraType && !this.cameraType_.Equals(request.cameraType_)))
            {
                return false;
            }
            if ((this.hasFuncFlag != request.hasFuncFlag) || (this.hasFuncFlag && !this.funcFlag_.Equals(request.funcFlag_)))
            {
                return false;
            }
            if ((this.hasMsgSource != request.hasMsgSource) || (this.hasMsgSource && !this.msgSource_.Equals(request.msgSource_)))
            {
                return false;
            }
            if ((this.hasCDNVideoUrl != request.hasCDNVideoUrl) || (this.hasCDNVideoUrl && !this.cDNVideoUrl_.Equals(request.cDNVideoUrl_)))
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
            if ((this.hasCDNThumbUrl != request.hasCDNThumbUrl) || (this.hasCDNThumbUrl && !this.cDNThumbUrl_.Equals(request.cDNThumbUrl_)))
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
            if ((this.hasCDNThumbAESKey != request.hasCDNThumbAESKey) || (this.hasCDNThumbAESKey && !this.cDNThumbAESKey_.Equals(request.cDNThumbAESKey_)))
            {
                return false;
            }
            if ((this.hasVideoFrom != request.hasVideoFrom) || (this.hasVideoFrom && !this.videoFrom_.Equals(request.videoFrom_)))
            {
                return false;
            }
            if ((this.hasReqTime != request.hasReqTime) || (this.hasReqTime && !this.reqTime_.Equals(request.reqTime_)))
            {
                return false;
            }
            return ((this.hasVideoMd5 == request.hasVideoMd5) && (!this.hasVideoMd5 || this.videoMd5_.Equals(request.videoMd5_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasBaseRequest)
            {
                hashCode ^= this.baseRequest_.GetHashCode();
            }
            if (this.hasClientMsgId)
            {
                hashCode ^= this.clientMsgId_.GetHashCode();
            }
            if (this.hasFromUserName)
            {
                hashCode ^= this.fromUserName_.GetHashCode();
            }
            if (this.hasToUserName)
            {
                hashCode ^= this.toUserName_.GetHashCode();
            }
            if (this.hasThumbTotalLen)
            {
                hashCode ^= this.thumbTotalLen_.GetHashCode();
            }
            if (this.hasThumbStartPos)
            {
                hashCode ^= this.thumbStartPos_.GetHashCode();
            }
            if (this.hasThumbData)
            {
                hashCode ^= this.thumbData_.GetHashCode();
            }
            if (this.hasVideoTotalLen)
            {
                hashCode ^= this.videoTotalLen_.GetHashCode();
            }
            if (this.hasVideoStartPos)
            {
                hashCode ^= this.videoStartPos_.GetHashCode();
            }
            if (this.hasVideoData)
            {
                hashCode ^= this.videoData_.GetHashCode();
            }
            if (this.hasPlayLength)
            {
                hashCode ^= this.playLength_.GetHashCode();
            }
            if (this.hasNetworkEnv)
            {
                hashCode ^= this.networkEnv_.GetHashCode();
            }
            if (this.hasCameraType)
            {
                hashCode ^= this.cameraType_.GetHashCode();
            }
            if (this.hasFuncFlag)
            {
                hashCode ^= this.funcFlag_.GetHashCode();
            }
            if (this.hasMsgSource)
            {
                hashCode ^= this.msgSource_.GetHashCode();
            }
            if (this.hasCDNVideoUrl)
            {
                hashCode ^= this.cDNVideoUrl_.GetHashCode();
            }
            if (this.hasAESKey)
            {
                hashCode ^= this.aESKey_.GetHashCode();
            }
            if (this.hasEncryVer)
            {
                hashCode ^= this.encryVer_.GetHashCode();
            }
            if (this.hasCDNThumbUrl)
            {
                hashCode ^= this.cDNThumbUrl_.GetHashCode();
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
            if (this.hasVideoFrom)
            {
                hashCode ^= this.videoFrom_.GetHashCode();
            }
            if (this.hasReqTime)
            {
                hashCode ^= this.reqTime_.GetHashCode();
            }
            if (this.hasVideoMd5)
            {
                hashCode ^= this.videoMd5_.GetHashCode();
            }
            return hashCode;
        }

        private UploadVideoRequest MakeReadOnly()
        {
            return this;
        }

        public static UploadVideoRequest ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<UploadVideoRequest, Builder>.PrintField("BaseRequest", this.hasBaseRequest, this.baseRequest_, writer);
            GeneratedMessageLite<UploadVideoRequest, Builder>.PrintField("ClientMsgId", this.hasClientMsgId, this.clientMsgId_, writer);
            GeneratedMessageLite<UploadVideoRequest, Builder>.PrintField("FromUserName", this.hasFromUserName, this.fromUserName_, writer);
            GeneratedMessageLite<UploadVideoRequest, Builder>.PrintField("ToUserName", this.hasToUserName, this.toUserName_, writer);
            GeneratedMessageLite<UploadVideoRequest, Builder>.PrintField("ThumbTotalLen", this.hasThumbTotalLen, this.thumbTotalLen_, writer);
            GeneratedMessageLite<UploadVideoRequest, Builder>.PrintField("ThumbStartPos", this.hasThumbStartPos, this.thumbStartPos_, writer);
            GeneratedMessageLite<UploadVideoRequest, Builder>.PrintField("ThumbData", this.hasThumbData, this.thumbData_, writer);
            GeneratedMessageLite<UploadVideoRequest, Builder>.PrintField("VideoTotalLen", this.hasVideoTotalLen, this.videoTotalLen_, writer);
            GeneratedMessageLite<UploadVideoRequest, Builder>.PrintField("VideoStartPos", this.hasVideoStartPos, this.videoStartPos_, writer);
            GeneratedMessageLite<UploadVideoRequest, Builder>.PrintField("VideoData", this.hasVideoData, this.videoData_, writer);
            GeneratedMessageLite<UploadVideoRequest, Builder>.PrintField("PlayLength", this.hasPlayLength, this.playLength_, writer);
            GeneratedMessageLite<UploadVideoRequest, Builder>.PrintField("NetworkEnv", this.hasNetworkEnv, this.networkEnv_, writer);
            GeneratedMessageLite<UploadVideoRequest, Builder>.PrintField("CameraType", this.hasCameraType, this.cameraType_, writer);
            GeneratedMessageLite<UploadVideoRequest, Builder>.PrintField("FuncFlag", this.hasFuncFlag, this.funcFlag_, writer);
            GeneratedMessageLite<UploadVideoRequest, Builder>.PrintField("MsgSource", this.hasMsgSource, this.msgSource_, writer);
            GeneratedMessageLite<UploadVideoRequest, Builder>.PrintField("CDNVideoUrl", this.hasCDNVideoUrl, this.cDNVideoUrl_, writer);
            GeneratedMessageLite<UploadVideoRequest, Builder>.PrintField("AESKey", this.hasAESKey, this.aESKey_, writer);
            GeneratedMessageLite<UploadVideoRequest, Builder>.PrintField("EncryVer", this.hasEncryVer, this.encryVer_, writer);
            GeneratedMessageLite<UploadVideoRequest, Builder>.PrintField("CDNThumbUrl", this.hasCDNThumbUrl, this.cDNThumbUrl_, writer);
            GeneratedMessageLite<UploadVideoRequest, Builder>.PrintField("CDNThumbImgSize", this.hasCDNThumbImgSize, this.cDNThumbImgSize_, writer);
            GeneratedMessageLite<UploadVideoRequest, Builder>.PrintField("CDNThumbImgHeight", this.hasCDNThumbImgHeight, this.cDNThumbImgHeight_, writer);
            GeneratedMessageLite<UploadVideoRequest, Builder>.PrintField("CDNThumbImgWidth", this.hasCDNThumbImgWidth, this.cDNThumbImgWidth_, writer);
            GeneratedMessageLite<UploadVideoRequest, Builder>.PrintField("CDNThumbAESKey", this.hasCDNThumbAESKey, this.cDNThumbAESKey_, writer);
            GeneratedMessageLite<UploadVideoRequest, Builder>.PrintField("VideoFrom", this.hasVideoFrom, this.videoFrom_, writer);
            GeneratedMessageLite<UploadVideoRequest, Builder>.PrintField("ReqTime", this.hasReqTime, this.reqTime_, writer);
            GeneratedMessageLite<UploadVideoRequest, Builder>.PrintField("VideoMd5", this.hasVideoMd5, this.videoMd5_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _uploadVideoRequestFieldNames;
            if (this.hasBaseRequest)
            {
                output.WriteMessage(1, strArray[1], this.BaseRequest);
            }
            if (this.hasClientMsgId)
            {
                output.WriteString(2, strArray[9], this.ClientMsgId);
            }
            if (this.hasFromUserName)
            {
                output.WriteString(3, strArray[11], this.FromUserName);
            }
            if (this.hasToUserName)
            {
                output.WriteString(4, strArray[20], this.ToUserName);
            }
            if (this.hasThumbTotalLen)
            {
                output.WriteUInt32(5, strArray[0x13], this.ThumbTotalLen);
            }
            if (this.hasThumbStartPos)
            {
                output.WriteUInt32(6, strArray[0x12], this.ThumbStartPos);
            }
            if (this.hasThumbData)
            {
                output.WriteMessage(7, strArray[0x11], this.ThumbData);
            }
            if (this.hasVideoTotalLen)
            {
                output.WriteUInt32(8, strArray[0x19], this.VideoTotalLen);
            }
            if (this.hasVideoStartPos)
            {
                output.WriteUInt32(9, strArray[0x18], this.VideoStartPos);
            }
            if (this.hasVideoData)
            {
                output.WriteMessage(10, strArray[0x15], this.VideoData);
            }
            if (this.hasPlayLength)
            {
                output.WriteUInt32(11, strArray[15], this.PlayLength);
            }
            if (this.hasNetworkEnv)
            {
                output.WriteUInt32(12, strArray[14], this.NetworkEnv);
            }
            if (this.hasCameraType)
            {
                output.WriteUInt32(13, strArray[8], this.CameraType);
            }
            if (this.hasFuncFlag)
            {
                output.WriteUInt32(14, strArray[12], this.FuncFlag);
            }
            if (this.hasMsgSource)
            {
                output.WriteString(15, strArray[13], this.MsgSource);
            }
            if (this.hasCDNVideoUrl)
            {
                output.WriteString(0x10, strArray[7], this.CDNVideoUrl);
            }
            if (this.hasAESKey)
            {
                output.WriteString(0x11, strArray[0], this.AESKey);
            }
            if (this.hasEncryVer)
            {
                output.WriteInt32(0x12, strArray[10], this.EncryVer);
            }
            if (this.hasCDNThumbUrl)
            {
                output.WriteString(0x13, strArray[6], this.CDNThumbUrl);
            }
            if (this.hasCDNThumbImgSize)
            {
                output.WriteInt32(20, strArray[4], this.CDNThumbImgSize);
            }
            if (this.hasCDNThumbImgHeight)
            {
                output.WriteInt32(0x15, strArray[3], this.CDNThumbImgHeight);
            }
            if (this.hasCDNThumbImgWidth)
            {
                output.WriteInt32(0x16, strArray[5], this.CDNThumbImgWidth);
            }
            if (this.hasCDNThumbAESKey)
            {
                output.WriteString(0x17, strArray[2], this.CDNThumbAESKey);
            }
            if (this.hasVideoFrom)
            {
                output.WriteInt32(0x18, strArray[0x16], this.VideoFrom);
            }
            if (this.hasReqTime)
            {
                output.WriteUInt32(0x19, strArray[0x10], this.ReqTime);
            }
            if (this.hasVideoMd5)
            {
                output.WriteString(0x1a, strArray[0x17], this.VideoMd5);
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

        public uint CameraType
        {
            get
            {
                return this.cameraType_;
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

        public int CDNThumbImgWidth
        {
            get
            {
                return this.cDNThumbImgWidth_;
            }
        }

        public string CDNThumbUrl
        {
            get
            {
                return this.cDNThumbUrl_;
            }
        }

        public string CDNVideoUrl
        {
            get
            {
                return this.cDNVideoUrl_;
            }
        }

        public string ClientMsgId
        {
            get
            {
                return this.clientMsgId_;
            }
        }

        public static UploadVideoRequest DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override UploadVideoRequest DefaultInstanceForType
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

        public string FromUserName
        {
            get
            {
                return this.fromUserName_;
            }
        }

        public uint FuncFlag
        {
            get
            {
                return this.funcFlag_;
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
                if (!this.hasThumbTotalLen)
                {
                    return false;
                }
                if (!this.hasThumbStartPos)
                {
                    return false;
                }
                if (!this.hasThumbData)
                {
                    return false;
                }
                if (!this.hasVideoTotalLen)
                {
                    return false;
                }
                if (!this.hasVideoStartPos)
                {
                    return false;
                }
                if (!this.hasVideoData)
                {
                    return false;
                }
                if (!this.hasPlayLength)
                {
                    return false;
                }
                if (!this.BaseRequest.IsInitialized)
                {
                    return false;
                }
                if (!this.ThumbData.IsInitialized)
                {
                    return false;
                }
                if (!this.VideoData.IsInitialized)
                {
                    return false;
                }
                return true;
            }
        }

        public string MsgSource
        {
            get
            {
                return this.msgSource_;
            }
        }

        public uint NetworkEnv
        {
            get
            {
                return this.networkEnv_;
            }
        }

        public uint PlayLength
        {
            get
            {
                return this.playLength_;
            }
        }

        public uint ReqTime
        {
            get
            {
                return this.reqTime_;
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
                    if (this.hasClientMsgId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(2, this.ClientMsgId);
                    }
                    if (this.hasFromUserName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(3, this.FromUserName);
                    }
                    if (this.hasToUserName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(4, this.ToUserName);
                    }
                    if (this.hasThumbTotalLen)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(5, this.ThumbTotalLen);
                    }
                    if (this.hasThumbStartPos)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(6, this.ThumbStartPos);
                    }
                    if (this.hasThumbData)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(7, this.ThumbData);
                    }
                    if (this.hasVideoTotalLen)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(8, this.VideoTotalLen);
                    }
                    if (this.hasVideoStartPos)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(9, this.VideoStartPos);
                    }
                    if (this.hasVideoData)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(10, this.VideoData);
                    }
                    if (this.hasPlayLength)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(11, this.PlayLength);
                    }
                    if (this.hasNetworkEnv)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(12, this.NetworkEnv);
                    }
                    if (this.hasCameraType)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(13, this.CameraType);
                    }
                    if (this.hasFuncFlag)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(14, this.FuncFlag);
                    }
                    if (this.hasMsgSource)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(15, this.MsgSource);
                    }
                    if (this.hasCDNVideoUrl)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x10, this.CDNVideoUrl);
                    }
                    if (this.hasAESKey)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x11, this.AESKey);
                    }
                    if (this.hasEncryVer)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(0x12, this.EncryVer);
                    }
                    if (this.hasCDNThumbUrl)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x13, this.CDNThumbUrl);
                    }
                    if (this.hasCDNThumbImgSize)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(20, this.CDNThumbImgSize);
                    }
                    if (this.hasCDNThumbImgHeight)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(0x15, this.CDNThumbImgHeight);
                    }
                    if (this.hasCDNThumbImgWidth)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(0x16, this.CDNThumbImgWidth);
                    }
                    if (this.hasCDNThumbAESKey)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x17, this.CDNThumbAESKey);
                    }
                    if (this.hasVideoFrom)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(0x18, this.VideoFrom);
                    }
                    if (this.hasReqTime)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(0x19, this.ReqTime);
                    }
                    if (this.hasVideoMd5)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(0x1a, this.VideoMd5);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override UploadVideoRequest ThisMessage
        {
            get
            {
                return this;
            }
        }

        public SKBuiltinBuffer_t ThumbData
        {
            get
            {
                return (this.thumbData_ ?? SKBuiltinBuffer_t.DefaultInstance);
            }
        }

        public uint ThumbStartPos
        {
            get
            {
                return this.thumbStartPos_;
            }
        }

        public uint ThumbTotalLen
        {
            get
            {
                return this.thumbTotalLen_;
            }
        }

        public string ToUserName
        {
            get
            {
                return this.toUserName_;
            }
        }

        public SKBuiltinBuffer_t VideoData
        {
            get
            {
                return (this.videoData_ ?? SKBuiltinBuffer_t.DefaultInstance);
            }
        }

        public int VideoFrom
        {
            get
            {
                return this.videoFrom_;
            }
        }

        public string VideoMd5
        {
            get
            {
                return this.videoMd5_;
            }
        }

        public uint VideoStartPos
        {
            get
            {
                return this.videoStartPos_;
            }
        }

        public uint VideoTotalLen
        {
            get
            {
                return this.videoTotalLen_;
            }
        }

        
        public sealed class Builder : GeneratedBuilderLite<UploadVideoRequest, UploadVideoRequest.Builder>
        {
            private UploadVideoRequest result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = UploadVideoRequest.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(UploadVideoRequest cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override UploadVideoRequest BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override UploadVideoRequest.Builder Clear()
            {
                this.result = UploadVideoRequest.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public UploadVideoRequest.Builder ClearAESKey()
            {
                this.PrepareBuilder();
                this.result.hasAESKey = false;
                this.result.aESKey_ = "";
                return this;
            }

            public UploadVideoRequest.Builder ClearBaseRequest()
            {
                this.PrepareBuilder();
                this.result.hasBaseRequest = false;
                this.result.baseRequest_ = null;
                return this;
            }

            public UploadVideoRequest.Builder ClearCameraType()
            {
                this.PrepareBuilder();
                this.result.hasCameraType = false;
                this.result.cameraType_ = 0;
                return this;
            }

            public UploadVideoRequest.Builder ClearCDNThumbAESKey()
            {
                this.PrepareBuilder();
                this.result.hasCDNThumbAESKey = false;
                this.result.cDNThumbAESKey_ = "";
                return this;
            }

            public UploadVideoRequest.Builder ClearCDNThumbImgHeight()
            {
                this.PrepareBuilder();
                this.result.hasCDNThumbImgHeight = false;
                this.result.cDNThumbImgHeight_ = 0;
                return this;
            }

            public UploadVideoRequest.Builder ClearCDNThumbImgSize()
            {
                this.PrepareBuilder();
                this.result.hasCDNThumbImgSize = false;
                this.result.cDNThumbImgSize_ = 0;
                return this;
            }

            public UploadVideoRequest.Builder ClearCDNThumbImgWidth()
            {
                this.PrepareBuilder();
                this.result.hasCDNThumbImgWidth = false;
                this.result.cDNThumbImgWidth_ = 0;
                return this;
            }

            public UploadVideoRequest.Builder ClearCDNThumbUrl()
            {
                this.PrepareBuilder();
                this.result.hasCDNThumbUrl = false;
                this.result.cDNThumbUrl_ = "";
                return this;
            }

            public UploadVideoRequest.Builder ClearCDNVideoUrl()
            {
                this.PrepareBuilder();
                this.result.hasCDNVideoUrl = false;
                this.result.cDNVideoUrl_ = "";
                return this;
            }

            public UploadVideoRequest.Builder ClearClientMsgId()
            {
                this.PrepareBuilder();
                this.result.hasClientMsgId = false;
                this.result.clientMsgId_ = "";
                return this;
            }

            public UploadVideoRequest.Builder ClearEncryVer()
            {
                this.PrepareBuilder();
                this.result.hasEncryVer = false;
                this.result.encryVer_ = 0;
                return this;
            }

            public UploadVideoRequest.Builder ClearFromUserName()
            {
                this.PrepareBuilder();
                this.result.hasFromUserName = false;
                this.result.fromUserName_ = "";
                return this;
            }

            public UploadVideoRequest.Builder ClearFuncFlag()
            {
                this.PrepareBuilder();
                this.result.hasFuncFlag = false;
                this.result.funcFlag_ = 0;
                return this;
            }

            public UploadVideoRequest.Builder ClearMsgSource()
            {
                this.PrepareBuilder();
                this.result.hasMsgSource = false;
                this.result.msgSource_ = "";
                return this;
            }

            public UploadVideoRequest.Builder ClearNetworkEnv()
            {
                this.PrepareBuilder();
                this.result.hasNetworkEnv = false;
                this.result.networkEnv_ = 0;
                return this;
            }

            public UploadVideoRequest.Builder ClearPlayLength()
            {
                this.PrepareBuilder();
                this.result.hasPlayLength = false;
                this.result.playLength_ = 0;
                return this;
            }

            public UploadVideoRequest.Builder ClearReqTime()
            {
                this.PrepareBuilder();
                this.result.hasReqTime = false;
                this.result.reqTime_ = 0;
                return this;
            }

            public UploadVideoRequest.Builder ClearThumbData()
            {
                this.PrepareBuilder();
                this.result.hasThumbData = false;
                this.result.thumbData_ = null;
                return this;
            }

            public UploadVideoRequest.Builder ClearThumbStartPos()
            {
                this.PrepareBuilder();
                this.result.hasThumbStartPos = false;
                this.result.thumbStartPos_ = 0;
                return this;
            }

            public UploadVideoRequest.Builder ClearThumbTotalLen()
            {
                this.PrepareBuilder();
                this.result.hasThumbTotalLen = false;
                this.result.thumbTotalLen_ = 0;
                return this;
            }

            public UploadVideoRequest.Builder ClearToUserName()
            {
                this.PrepareBuilder();
                this.result.hasToUserName = false;
                this.result.toUserName_ = "";
                return this;
            }

            public UploadVideoRequest.Builder ClearVideoData()
            {
                this.PrepareBuilder();
                this.result.hasVideoData = false;
                this.result.videoData_ = null;
                return this;
            }

            public UploadVideoRequest.Builder ClearVideoFrom()
            {
                this.PrepareBuilder();
                this.result.hasVideoFrom = false;
                this.result.videoFrom_ = 0;
                return this;
            }

            public UploadVideoRequest.Builder ClearVideoMd5()
            {
                this.PrepareBuilder();
                this.result.hasVideoMd5 = false;
                this.result.videoMd5_ = "";
                return this;
            }

            public UploadVideoRequest.Builder ClearVideoStartPos()
            {
                this.PrepareBuilder();
                this.result.hasVideoStartPos = false;
                this.result.videoStartPos_ = 0;
                return this;
            }

            public UploadVideoRequest.Builder ClearVideoTotalLen()
            {
                this.PrepareBuilder();
                this.result.hasVideoTotalLen = false;
                this.result.videoTotalLen_ = 0;
                return this;
            }

            public override UploadVideoRequest.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new UploadVideoRequest.Builder(this.result);
                }
                return new UploadVideoRequest.Builder().MergeFrom(this.result);
            }

            public UploadVideoRequest.Builder MergeBaseRequest(BaseRequest value)
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

            public override UploadVideoRequest.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override UploadVideoRequest.Builder MergeFrom(IMessageLite other)
            {
                if (other is UploadVideoRequest)
                {
                    return this.MergeFrom((UploadVideoRequest) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override UploadVideoRequest.Builder MergeFrom(UploadVideoRequest other)
            {
                return this;
            }

            public override UploadVideoRequest.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(UploadVideoRequest._uploadVideoRequestFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = UploadVideoRequest._uploadVideoRequestFieldTags[index];
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
                            this.result.hasFromUserName = input.ReadString(ref this.result.fromUserName_);
                            continue;
                        }
                        case 0x22:
                        {
                            this.result.hasToUserName = input.ReadString(ref this.result.toUserName_);
                            continue;
                        }
                        case 40:
                        {
                            this.result.hasThumbTotalLen = input.ReadUInt32(ref this.result.thumbTotalLen_);
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
                            this.result.hasClientMsgId = input.ReadString(ref this.result.clientMsgId_);
                            continue;
                        }
                        case 0x30:
                        {
                            this.result.hasThumbStartPos = input.ReadUInt32(ref this.result.thumbStartPos_);
                            continue;
                        }
                        case 0x3a:
                        {
                            SKBuiltinBuffer_t.Builder builder2 = SKBuiltinBuffer_t.CreateBuilder();
                            if (this.result.hasThumbData)
                            {
                                builder2.MergeFrom(this.ThumbData);
                            }
                            input.ReadMessage(builder2, extensionRegistry);
                            this.ThumbData = builder2.BuildPartial();
                            continue;
                        }
                        case 0x40:
                        {
                            this.result.hasVideoTotalLen = input.ReadUInt32(ref this.result.videoTotalLen_);
                            continue;
                        }
                        case 0x58:
                        {
                            this.result.hasPlayLength = input.ReadUInt32(ref this.result.playLength_);
                            continue;
                        }
                        case 0x60:
                        {
                            this.result.hasNetworkEnv = input.ReadUInt32(ref this.result.networkEnv_);
                            continue;
                        }
                        case 0x48:
                        {
                            this.result.hasVideoStartPos = input.ReadUInt32(ref this.result.videoStartPos_);
                            continue;
                        }
                        case 0x52:
                        {
                            SKBuiltinBuffer_t.Builder builder3 = SKBuiltinBuffer_t.CreateBuilder();
                            if (this.result.hasVideoData)
                            {
                                builder3.MergeFrom(this.VideoData);
                            }
                            input.ReadMessage(builder3, extensionRegistry);
                            this.VideoData = builder3.BuildPartial();
                            continue;
                        }
                        case 0x68:
                        {
                            this.result.hasCameraType = input.ReadUInt32(ref this.result.cameraType_);
                            continue;
                        }
                        case 0x70:
                        {
                            this.result.hasFuncFlag = input.ReadUInt32(ref this.result.funcFlag_);
                            continue;
                        }
                        case 0x7a:
                        {
                            this.result.hasMsgSource = input.ReadString(ref this.result.msgSource_);
                            continue;
                        }
                        case 0x90:
                        {
                            this.result.hasEncryVer = input.ReadInt32(ref this.result.encryVer_);
                            continue;
                        }
                        case 0x9a:
                        {
                            this.result.hasCDNThumbUrl = input.ReadString(ref this.result.cDNThumbUrl_);
                            continue;
                        }
                        case 130:
                        {
                            this.result.hasCDNVideoUrl = input.ReadString(ref this.result.cDNVideoUrl_);
                            continue;
                        }
                        case 0x8a:
                        {
                            this.result.hasAESKey = input.ReadString(ref this.result.aESKey_);
                            continue;
                        }
                        case 160:
                        {
                            this.result.hasCDNThumbImgSize = input.ReadInt32(ref this.result.cDNThumbImgSize_);
                            continue;
                        }
                        case 0xa8:
                        {
                            this.result.hasCDNThumbImgHeight = input.ReadInt32(ref this.result.cDNThumbImgHeight_);
                            continue;
                        }
                        case 0xb0:
                        {
                            this.result.hasCDNThumbImgWidth = input.ReadInt32(ref this.result.cDNThumbImgWidth_);
                            continue;
                        }
                        case 0xba:
                        {
                            this.result.hasCDNThumbAESKey = input.ReadString(ref this.result.cDNThumbAESKey_);
                            continue;
                        }
                        case 0xc0:
                        {
                            this.result.hasVideoFrom = input.ReadInt32(ref this.result.videoFrom_);
                            continue;
                        }
                        case 200:
                        {
                            this.result.hasReqTime = input.ReadUInt32(ref this.result.reqTime_);
                            continue;
                        }
                        case 210:
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
                    this.result.hasVideoMd5 = input.ReadString(ref this.result.videoMd5_);
                }
                return this;
            }

            public UploadVideoRequest.Builder MergeThumbData(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasThumbData && (this.result.thumbData_ != SKBuiltinBuffer_t.DefaultInstance))
                {
                    this.result.thumbData_ = SKBuiltinBuffer_t.CreateBuilder(this.result.thumbData_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.thumbData_ = value;
                }
                this.result.hasThumbData = true;
                return this;
            }

            public UploadVideoRequest.Builder MergeVideoData(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasVideoData && (this.result.videoData_ != SKBuiltinBuffer_t.DefaultInstance))
                {
                    this.result.videoData_ = SKBuiltinBuffer_t.CreateBuilder(this.result.videoData_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.videoData_ = value;
                }
                this.result.hasVideoData = true;
                return this;
            }

            private UploadVideoRequest PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    UploadVideoRequest result = this.result;
                    this.result = new UploadVideoRequest();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public UploadVideoRequest.Builder SetAESKey(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasAESKey = true;
                this.result.aESKey_ = value;
                return this;
            }

            public UploadVideoRequest.Builder SetBaseRequest(BaseRequest value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = value;
                return this;
            }

            public UploadVideoRequest.Builder SetBaseRequest(BaseRequest.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBaseRequest = true;
                this.result.baseRequest_ = builderForValue.Build();
                return this;
            }

            public UploadVideoRequest.Builder SetCameraType(uint value)
            {
                this.PrepareBuilder();
                this.result.hasCameraType = true;
                this.result.cameraType_ = value;
                return this;
            }

            public UploadVideoRequest.Builder SetCDNThumbAESKey(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasCDNThumbAESKey = true;
                this.result.cDNThumbAESKey_ = value;
                return this;
            }

            public UploadVideoRequest.Builder SetCDNThumbImgHeight(int value)
            {
                this.PrepareBuilder();
                this.result.hasCDNThumbImgHeight = true;
                this.result.cDNThumbImgHeight_ = value;
                return this;
            }

            public UploadVideoRequest.Builder SetCDNThumbImgSize(int value)
            {
                this.PrepareBuilder();
                this.result.hasCDNThumbImgSize = true;
                this.result.cDNThumbImgSize_ = value;
                return this;
            }

            public UploadVideoRequest.Builder SetCDNThumbImgWidth(int value)
            {
                this.PrepareBuilder();
                this.result.hasCDNThumbImgWidth = true;
                this.result.cDNThumbImgWidth_ = value;
                return this;
            }

            public UploadVideoRequest.Builder SetCDNThumbUrl(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasCDNThumbUrl = true;
                this.result.cDNThumbUrl_ = value;
                return this;
            }

            public UploadVideoRequest.Builder SetCDNVideoUrl(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasCDNVideoUrl = true;
                this.result.cDNVideoUrl_ = value;
                return this;
            }

            public UploadVideoRequest.Builder SetClientMsgId(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasClientMsgId = true;
                this.result.clientMsgId_ = value;
                return this;
            }

            public UploadVideoRequest.Builder SetEncryVer(int value)
            {
                this.PrepareBuilder();
                this.result.hasEncryVer = true;
                this.result.encryVer_ = value;
                return this;
            }

            public UploadVideoRequest.Builder SetFromUserName(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasFromUserName = true;
                this.result.fromUserName_ = value;
                return this;
            }

            public UploadVideoRequest.Builder SetFuncFlag(uint value)
            {
                this.PrepareBuilder();
                this.result.hasFuncFlag = true;
                this.result.funcFlag_ = value;
                return this;
            }

            public UploadVideoRequest.Builder SetMsgSource(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasMsgSource = true;
                this.result.msgSource_ = value;
                return this;
            }

            public UploadVideoRequest.Builder SetNetworkEnv(uint value)
            {
                this.PrepareBuilder();
                this.result.hasNetworkEnv = true;
                this.result.networkEnv_ = value;
                return this;
            }

            public UploadVideoRequest.Builder SetPlayLength(uint value)
            {
                this.PrepareBuilder();
                this.result.hasPlayLength = true;
                this.result.playLength_ = value;
                return this;
            }

            public UploadVideoRequest.Builder SetReqTime(uint value)
            {
                this.PrepareBuilder();
                this.result.hasReqTime = true;
                this.result.reqTime_ = value;
                return this;
            }

            public UploadVideoRequest.Builder SetThumbData(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasThumbData = true;
                this.result.thumbData_ = value;
                return this;
            }

            public UploadVideoRequest.Builder SetThumbData(SKBuiltinBuffer_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasThumbData = true;
                this.result.thumbData_ = builderForValue.Build();
                return this;
            }

            public UploadVideoRequest.Builder SetThumbStartPos(uint value)
            {
                this.PrepareBuilder();
                this.result.hasThumbStartPos = true;
                this.result.thumbStartPos_ = value;
                return this;
            }

            public UploadVideoRequest.Builder SetThumbTotalLen(uint value)
            {
                this.PrepareBuilder();
                this.result.hasThumbTotalLen = true;
                this.result.thumbTotalLen_ = value;
                return this;
            }

            public UploadVideoRequest.Builder SetToUserName(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasToUserName = true;
                this.result.toUserName_ = value;
                return this;
            }

            public UploadVideoRequest.Builder SetVideoData(SKBuiltinBuffer_t value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasVideoData = true;
                this.result.videoData_ = value;
                return this;
            }

            public UploadVideoRequest.Builder SetVideoData(SKBuiltinBuffer_t.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasVideoData = true;
                this.result.videoData_ = builderForValue.Build();
                return this;
            }

            public UploadVideoRequest.Builder SetVideoFrom(int value)
            {
                this.PrepareBuilder();
                this.result.hasVideoFrom = true;
                this.result.videoFrom_ = value;
                return this;
            }

            public UploadVideoRequest.Builder SetVideoMd5(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasVideoMd5 = true;
                this.result.videoMd5_ = value;
                return this;
            }

            public UploadVideoRequest.Builder SetVideoStartPos(uint value)
            {
                this.PrepareBuilder();
                this.result.hasVideoStartPos = true;
                this.result.videoStartPos_ = value;
                return this;
            }

            public UploadVideoRequest.Builder SetVideoTotalLen(uint value)
            {
                this.PrepareBuilder();
                this.result.hasVideoTotalLen = true;
                this.result.videoTotalLen_ = value;
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

            public uint CameraType
            {
                get
                {
                    return this.result.CameraType;
                }
                set
                {
                    this.SetCameraType(value);
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

            public string CDNThumbUrl
            {
                get
                {
                    return this.result.CDNThumbUrl;
                }
                set
                {
                    this.SetCDNThumbUrl(value);
                }
            }

            public string CDNVideoUrl
            {
                get
                {
                    return this.result.CDNVideoUrl;
                }
                set
                {
                    this.SetCDNVideoUrl(value);
                }
            }

            public string ClientMsgId
            {
                get
                {
                    return this.result.ClientMsgId;
                }
                set
                {
                    this.SetClientMsgId(value);
                }
            }

            public override UploadVideoRequest DefaultInstanceForType
            {
                get
                {
                    return UploadVideoRequest.DefaultInstance;
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

            public string FromUserName
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

            public uint FuncFlag
            {
                get
                {
                    return this.result.FuncFlag;
                }
                set
                {
                    this.SetFuncFlag(value);
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override UploadVideoRequest MessageBeingBuilt
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

            public uint NetworkEnv
            {
                get
                {
                    return this.result.NetworkEnv;
                }
                set
                {
                    this.SetNetworkEnv(value);
                }
            }

            public uint PlayLength
            {
                get
                {
                    return this.result.PlayLength;
                }
                set
                {
                    this.SetPlayLength(value);
                }
            }

            public uint ReqTime
            {
                get
                {
                    return this.result.ReqTime;
                }
                set
                {
                    this.SetReqTime(value);
                }
            }

            protected override UploadVideoRequest.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }

            public SKBuiltinBuffer_t ThumbData
            {
                get
                {
                    return this.result.ThumbData;
                }
                set
                {
                    this.SetThumbData(value);
                }
            }

            public uint ThumbStartPos
            {
                get
                {
                    return this.result.ThumbStartPos;
                }
                set
                {
                    this.SetThumbStartPos(value);
                }
            }

            public uint ThumbTotalLen
            {
                get
                {
                    return this.result.ThumbTotalLen;
                }
                set
                {
                    this.SetThumbTotalLen(value);
                }
            }

            public string ToUserName
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

            public SKBuiltinBuffer_t VideoData
            {
                get
                {
                    return this.result.VideoData;
                }
                set
                {
                    this.SetVideoData(value);
                }
            }

            public int VideoFrom
            {
                get
                {
                    return this.result.VideoFrom;
                }
                set
                {
                    this.SetVideoFrom(value);
                }
            }

            public string VideoMd5
            {
                get
                {
                    return this.result.VideoMd5;
                }
                set
                {
                    this.SetVideoMd5(value);
                }
            }

            public uint VideoStartPos
            {
                get
                {
                    return this.result.VideoStartPos;
                }
                set
                {
                    this.SetVideoStartPos(value);
                }
            }

            public uint VideoTotalLen
            {
                get
                {
                    return this.result.VideoTotalLen;
                }
                set
                {
                    this.SetVideoTotalLen(value);
                }
            }
        }
    }
}

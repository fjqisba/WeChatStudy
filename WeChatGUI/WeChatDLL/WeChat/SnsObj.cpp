#include "SnsObj.h"
#include "../public/Strings.h"

void loadMediaData(SnsMedia* pMediaStart, SnsMedia* pMediaEnd, MyTimeLineResp& outResp)
{
	if (!pMediaStart) {
		return;
	}
	unsigned int count = pMediaEnd - pMediaStart;
	for (unsigned int n = 0; n < count; n++) {
		MySnsMedia tmpMedia;
		//大概是图片
		if (pMediaStart->type == 2) {
			tmpMedia.url = copyMMString(&pMediaStart->Url);
		}
		outResp.mediaList.push_back(tmpMedia);
		pMediaStart++;
	}
}

MyTimeLineResp CopyTimeLineResp(TimelineResp* pTimelineResp)
{
	MyTimeLineResp retResp;

	retResp.id = pTimelineResp->id;
	retResp.sendTime = pTimelineResp->coreMsg.sendTime;
	retResp.sendWxid = copyMMString(&pTimelineResp->coreMsg.senderName);
	retResp.content = copyMMString(&pTimelineResp->coreMsg.contentDesc);
	SnsContentObject* pContentObject = &pTimelineResp->coreMsg.contentObject;
	//图片
	if (pContentObject->contentStyle == 1) {
		loadMediaData(pContentObject->pSnsMediaStart, pContentObject->pSnsMediaEnd, retResp);
		return retResp;
	}
	//转发文案3
	//视频15
	//视频号28
	retResp.title = copyMMString(&pContentObject->title);
	retResp.description = copyMMString(&pContentObject->description);
	retResp.contentUrl = copyMMString(&pContentObject->contentUrl);
	return retResp;
}
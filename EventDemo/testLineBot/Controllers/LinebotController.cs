using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace testLineBot.Controllers
{
    public class LinebotController : ApiController
    {
        //設定ChannelAccessToken
        string ChannelAccessToken = "Fn2CdIjmBCz3kFdur9fiJX2pT84q74Uc6Vy3FxvrbnVd5qqc0GGvfquxHpvIdchsT3Zr+jc/UThviWjhWn5enxJSnqGcmPN2TiLz0jg6Yn3RCGwh4xebVTVHa6EpTucnOG5q1AHMEpdfkvfylauswQdB04t89/1O/w1cDnyilFU=";

        [HttpPost]
        public IHttpActionResult POST()
        {
            try
            {
                 //取得 http Post RawData(should be JSON)
                string postData = Request.Content.ReadAsStringAsync().Result;
                //剖析JSON
                var ReceivedMessage = isRock.LineBot.Utility.Parsing(postData);
                //取得Line Event
                var LineEvent = ReceivedMessage.events.FirstOrDefault();
                var responseMsg = "";
                //準備回覆訊息
                if (LineEvent.type.ToLower() == "message" && LineEvent.message.type == "text")
                    responseMsg = $"你說了: {LineEvent.message.text}";
                else
                    responseMsg = $"收到 event : {LineEvent.type} type: {(LineEvent.type.ToLower() == "message" ? LineEvent.message.type : "")}";
                //回覆訊息
                isRock.LineBot.Utility.ReplyMessage(LineEvent.replyToken, responseMsg, this.ChannelAccessToken);
                //response OK
                return Ok();
            }
            catch (Exception ex)
            {
                //回覆訊息
                isRock.LineBot.Utility.PushMessage("U6ca03b0fc595c152d361896126809a5f", "發生錯誤:\n" + ex.Message, this.ChannelAccessToken);
                //response OK
                return Ok();
            }
        }
    }
}

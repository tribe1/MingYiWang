using Senparc.Weixin.MP;
using Senparc.Weixin.MP.Entities.Request;
using System.Web.Configuration;
using System.Web.Mvc;

namespace MingYiWang.WebAPI.Controllers
{
    public class WeChatController : Controller
    {
        public static readonly string Token = WebConfigurationManager.AppSettings["MPToken"];
        //与微信公众账号后台的Token设置保持一致，区分大小写。
        public static readonly string EncodingAESKey = WebConfigurationManager.AppSettings["MPEncodingAESKey"];
        //与微信公众账号后台的EncodingAESKey设置保持一致，区分大小写。
        public static readonly string AppId = WebConfigurationManager.AppSettings["MPAppId"];
        //与微信公众账号后台的AppId设置保持一致，区分大小写。
        [HttpGet]
        [ActionName("Index")]
        public ActionResult Get(PostModel postModel, string echostr)
        {
            if (CheckSignature.Check(postModel.Signature, postModel.Timestamp, postModel.Nonce, Token))
            {
                return Content(echostr); //返回随机字符串则表示验证通过
            }
            else
            {
                return Content("failed:" + postModel.Signature + "," + Senparc.Weixin.MP.CheckSignature.GetSignature(postModel.Timestamp, postModel.Nonce, Token) + "。" +
                    "如果你在浏览器中看到这句话，说明此地址可以被作为微信公众账号后台的Url，请注意保持Token一致。");
            }
        }
    }
}

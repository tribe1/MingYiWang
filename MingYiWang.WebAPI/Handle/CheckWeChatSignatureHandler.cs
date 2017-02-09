using iHealthwoo.WeChat.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace MingYiWang.WebAPI.Handle
{
    public class CheckWeChatSignatureHandler : DelegatingHandler
    {

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var formDataDic = request.Content.ReadAsFormDataAsync().Result;
            string signature = formDataDic[WeChatSignaturePropKeys.SignatureKey];
            string timestamp = formDataDic[WeChatSignaturePropKeys.TimestampKey];
            string nonce = formDataDic[WeChatSignaturePropKeys.NonceKey];
            string token = formDataDic[WeChatSignaturePropKeys.TokenKey];
            var result = CheckWeChatSignature.CheckSignature(signature, timestamp, nonce, token);
            if (!result)
            {
                return new Task<HttpResponseMessage>(() =>
                    {
                        return request.CreateErrorResponse(System.Net.HttpStatusCode.Unauthorized, "不是有效消息请求");
                    });

            }
            return base.SendAsync(request, cancellationToken);
        }


    }
}
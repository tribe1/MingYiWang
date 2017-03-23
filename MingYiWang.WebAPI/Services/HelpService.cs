using MingYiWang.Business;
using Senparc.Weixin.MP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace MingYiWang.WebAPI.Services
{
    public class HelpService
    {
        public static ResponseMessageText GetResponseMessage(RequestMessageText requestMessage)
        {
            var responseMessage = ResponseMessageBase.CreateFromRequestMessage<ResponseMessageText>(requestMessage);
            responseMessage.Content = string.Format("此页面是帮助页面。更多帮助请联系管理员");
            return responseMessage;
        }
    }
}
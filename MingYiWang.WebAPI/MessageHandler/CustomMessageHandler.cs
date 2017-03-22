using Senparc.Weixin.MP.MessageHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Senparc.Weixin.MP.Entities;
using Senparc.Weixin.Context;
using System.IO;
using Senparc.Weixin.MP.Entities.Request;
using MingYiWang.WebAPI.Services;

namespace MingYiWang.WebAPI.MessageHandler
{
    public class CustomMessageHandler : MessageHandler<MessageContext<IRequestMessageBase, IResponseMessageBase>>
    {
        public override IResponseMessageBase DefaultResponseMessage(IRequestMessageBase requestMessage)
        {
            throw new NotImplementedException();
        }

        public CustomMessageHandler(Stream inputStream, PostModel postModel, int maxRecordCount = 0)
           : base(inputStream, postModel, maxRecordCount)
        {

        }

        public override IResponseMessageBase OnTextRequest(RequestMessageText requestMessage)
        {
            var responseMessage = base.CreateResponseMessage<ResponseMessageText>();
            if (requestMessage.Content == null)
            {

            }
            else if (requestMessage.Content == "帮助")
            {
            }
            else if (requestMessage.Content == "科室")
            {
                responseMessage = DeptServices.GetResponseMessage(requestMessage);
            }
            return responseMessage;
        }
    }
}
using MingYiWang.Business;
using Senparc.Weixin.MP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace MingYiWang.WebAPI.Services
{
    public class DeptServices
    {
        public static ResponseMessageText GetResponseMessage(RequestMessageText requestMessage)
        {
            var responseMessage = ResponseMessageBase.CreateFromRequestMessage<ResponseMessageText>(requestMessage);
            var sb = new StringBuilder();
            var result = DeptBiz.GetDepts();
            foreach (var dept in result.Data)
            {
                sb.Append(string.Format("编码：{0},科室：{1}\r\n", dept.DeptId, dept.DeptName));
            }
            responseMessage.Content = sb.ToString();
            return responseMessage;
        }
    }
}
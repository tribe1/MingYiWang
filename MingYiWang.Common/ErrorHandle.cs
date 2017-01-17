using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MingYiWang.Common.Model;

namespace MingYiWang.Common
{
    public class ErrorHandle
    {

        public ResultApi<string> DefaultError()
        {
            return new ResultApi<string>()
            {
                Sucess = false,
                ReturnCode = ReturnCodeResource.UnKnownErr,
                Data = "",
                ReturnMsg = "系统未知错误"
            };

        }


    }
}

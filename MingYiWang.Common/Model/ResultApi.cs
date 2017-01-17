using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MingYiWang.Common.Model
{
    /// <summary>
    /// Web Api 结果
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ResultApi<T>
    {

        /// <summary>
        /// 接口调用结果。True 表示成功， False 表示失败。
        /// </summary>
        public bool Sucess { get; set; }

        /// <summary>
        /// 返回码。通常是0000表示成功。 其他错误码，参见ReturnCode定义
        /// </summary>
        public string ReturnCode { get; set; }

        /// <summary>
        /// 返回消息。通常
        /// </summary>
        public string ReturnMsg { get; set; }

        /// <summary>
        ///  接口调用结果
        /// </summary>
        public T Data { get; set; }

    




    }


}

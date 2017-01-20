using MingYiWang.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MingYiWang.Business
{
    public interface IChangeUserInfo
    {
        /// <summary>
        /// 更新用户信息
        /// </summary>
        /// <returns></returns>
        ResultApi<string> ChangeInfo();
    }
}

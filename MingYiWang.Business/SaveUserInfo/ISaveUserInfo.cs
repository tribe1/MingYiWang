using MingYiWang.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MingYiWang.Business
{
    /// <summary>
    /// 保存用户信息
    /// </summary>
    public interface ISaveUserInfo
    {
        /// <summary>
        /// 保存用户信息
        /// </summary>
        /// <returns></returns>
        ResultApi<string> SaveInfo();

    }
}

using MingYiWang.Business;
using MingYiWang.Business.Model;
using MingYiWang.Common.Model;
using MingYiWang.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MingYiWang.WebAPI.Controllers
{
    /// <summary>
    /// 用户管理
    /// </summary>
    public class UserController : ApiController
    {
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public ResultApi<string> Register([FromBody]UserRequest req)
        {
            var user = new User();
            user.eMail = req.eMail;
            user.UserName = req.UserName;
            user.Password = req.Password;
            var userInfo = new SaveUserInfo(user);
            return userInfo.SaveInfo();
        }



    }
}

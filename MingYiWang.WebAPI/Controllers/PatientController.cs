using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using MingYiWang.Common.Model;
using MingYiWang.WebAPI.Models;
using MingYiWang.Business;
using MingYiWang.Business.Model;

namespace MingYiWang.WebAPI.Controllers
{
    public class PatientController : ApiController
    {
        /// <summary>
        /// 登记用户信息
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public ResultApi<string> Register([FromBody] PatientRegisterRequest req)
        {
            var saveUserInfo = new SavePatientInfo(new Patient()
            {
                Id = Guid.NewGuid().ToString("N"),
                Name = req.Name,
                Gender = req.Gender,
                Tel = req.Tel,
            });

            return saveUserInfo.SaveInfo();
        }

        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public ResultApi<string> ChangInfo([FromBody] PatientInfoChangeRequest req)
        {
            return new ResultApi<string>();
        }
    }
}

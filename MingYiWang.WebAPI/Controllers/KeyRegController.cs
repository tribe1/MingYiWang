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
    /// 一键预约
    /// </summary>
    public class KeyRegController : ApiController
    {
        /// <summary>
        /// 预约
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>

        public ResultApi<List<DoctorQueryResponse>> Reg([FromBody] KeyRegRequest req)
        {

            return new ResultApi<List<DoctorQueryResponse>>();
        }
       


    }
}

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
    /// 医院控制器
    /// </summary>
    public class HospitalController : ApiController
    {

        public ResultApi<List<CommboxItem>> List([FromBody] HospitalRequest req)
        {

            return new ResultApi<List<CommboxItem>>();
        }

    }
}

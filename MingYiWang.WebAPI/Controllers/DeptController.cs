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
    public class DeptController : ApiController
    {

        public ResultApi<List<CommboxItem>> List([FromBody] DeptRequest req)
        {

            return new ResultApi<List<CommboxItem>>();
        }

    }
}

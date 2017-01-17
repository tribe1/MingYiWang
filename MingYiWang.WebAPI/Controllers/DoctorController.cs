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
    public class DoctorController : ApiController
    {
        public ResultApi<string> Register([FromBody] DoctorRegisterRequest req)
        {
            return new ResultApi<string>();
        }
    }
}
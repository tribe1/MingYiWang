using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using MingYiWang.Common.Model;
using MingYiWang.WebAPI.Models;

namespace MingYiWang.WebAPI.Controllers
{
    public class PatientController : ApiController
    {
        public ResultApi<string> Register([FromBody] PatientRegisterRequest req)
        {
            return new ResultApi<string>();
        }
    }
}

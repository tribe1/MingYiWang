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
    }
}

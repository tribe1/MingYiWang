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
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public ResultApi<string> Register([FromBody]DoctorRegisterRequest req)
        {
            return new ResultApi<string>();
        }

        [HttpGet]
        [ActionName("api/Doctor/Doctors")]
        /// <summary>
        /// 医生列表
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public ResultApi<List<DoctorQueryResponse>> List([FromBody] DoctorQueryRequest req)
        {

            var lst = new List<DoctorQueryResponse>();
            var doctor = new DoctorQueryResponse
            {
                DeptName = "脑科",
                DoctorCertNO = "0001",
                DoctorName = "测试医生列表",
                SkillDesc = "具有丰富的临床经验，学科带头人",
                HospitalName = "上海华山医院",
                OrderCount = 20,
                Title = "教授"
            };
            doctor.DirectReg.DeptId = "0001";
            doctor.DirectReg.DoctorId = "0001";
            doctor.DirectReg.HospitalId = "0001";
            lst.Add(doctor);
            lst.Add(doctor);
            var result = new ResultApi<List<DoctorQueryResponse>>();
            result.Data = lst;
            return result;

        }









    }
}
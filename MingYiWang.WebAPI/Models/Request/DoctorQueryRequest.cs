using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MingYiWang.WebAPI.Models
{
    /// <summary>
    /// 医生查询类
    /// </summary>
    public class DoctorQueryRequest
    {
        /// <summary>
        /// 医院
        /// </summary>
        public string HospitalId { get; set; }

        /// <summary>
        /// 科室
        /// </summary>
        public string DeptId { get; set; }

        /// <summary>
        /// 医生名字
        /// </summary>
        public string DoctorName { get; set; }
    }
}
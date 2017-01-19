using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MingYiWang.WebAPI.Models
{
    /// <summary>
    /// 一键预约
    /// </summary>
    public class KeyReg
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
        /// 医生Id
        /// </summary>
        public string DoctorId { get; set; }
    }
}
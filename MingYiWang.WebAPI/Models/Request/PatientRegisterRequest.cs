using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MingYiWang.WebAPI.Models
{
    public class PatientRegisterRequest
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        public string Tel { get; set; }


        /// <summary>
        /// 描述
        /// </summary>
        public string Desc { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MingYiWang.WebAPI.Models
{
    /// <summary>
    /// 新建一个科室
    /// </summary>
    public class NewDeptRequest
    {

        /// <summary>
        /// 科室Id    
        /// </summary>
        public string DeptId { get; set; }

        /// <summary>
        /// 科室名称
        /// </summary>
        public string DeptName { get; set; }


        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MingYiWang.Business.Model
{
    /// <summary>
    /// 工作时间
    /// </summary>
    public class WorkTime
    {

        /// <summary>
        /// 标识Id
        /// </summary>
        public string Id { get; set; }


        public string Name { get; set; }


        /// <summary>
        /// 是否可预约
        /// </summary>
        public string CanReg { get; set; }
    }
}

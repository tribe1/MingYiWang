using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MingYiWang.Business.Model
{
    /// <summary>
    /// 工作日
    /// </summary>
    public class WorkDay
    {

        public string Id { get; set; }

        /// <summary>
        /// 显示名称 格式为“yyyy-MM-dd”，如2017-01-19
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// 一个星期中的星期几， 如星期四
        /// </summary>
        public string WeekName { get; set; }

        /// <summary>
        /// 是否出诊
        /// </summary>
        public string IsNormal { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MingYiWang.Business.Model
{
    public class Advice
    {

        /// <summary>
        /// 医生建议
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>

        public string CreateTime { get; set; }





        /// <summary>
        /// 创建者
        /// </summary>
        public string CreateId { get; set; }


        public string AuditId { get; set; }

        public string AuditTime { get; set; }

        public AdviceStatus Status { get; set; }

    }


    /// <summary>
    /// 建议状态
    /// </summary>
    public enum AdviceStatus
    {
        /// <summary>
        /// 新建
        /// </summary>
        New,

        /// <summary>
        /// 已经审核通过
        /// </summary>
        Audited,

        /// <summary>
        /// 审核不通过
        /// </summary>
        UnAudited,

        /// <summary>
        /// 已经删除
        /// </summary>

        Deleted






    }
}

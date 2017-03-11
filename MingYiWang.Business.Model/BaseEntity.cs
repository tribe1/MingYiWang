using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MingYiWang.Business.Model
{
    public class BaseEntity
    {
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// 默认值是0. 0:启用。1：删除
        /// </summary>
        public int IsDel { get; set; }

        public BaseEntity()
        {
            CreateTime = DateTime.Now;
            UpdateTime = DateTime.Now;
            IsDel = 0;
        }

    }

}

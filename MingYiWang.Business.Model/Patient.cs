using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MingYiWang.Business.Model
{
    public class Patient : Person
    {
        /// <summary>
        /// 身份证号码
        /// </summary>
        public string IdCardNo { get; set; }

    }
}

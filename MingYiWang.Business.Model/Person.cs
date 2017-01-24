using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MingYiWang.Business.Model
{
    public class Person
    {

        public string Id { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// 出生年月
        /// </summary>
        public string BirthDay { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        public string Tel { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public string Gender { get; set; }
    }
}

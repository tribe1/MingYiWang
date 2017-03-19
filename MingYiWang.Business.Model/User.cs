using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace MingYiWang.Business.Model
{

    [Table("User")]
    public class User: BaseEntity
    {
        [Key]
        public string eMail { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        public string Tel { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }
    }
}

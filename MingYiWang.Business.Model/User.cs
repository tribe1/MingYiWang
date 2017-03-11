using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace MingYiWang.Business.Model
{
    public class User: BaseEntity
    {
        [Key]
        public string eMail { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }
    }
}

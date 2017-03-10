using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MingYiWang.WebAPI.Models
{
    public class DoctorRegisterRequest
    {
        public string eMail { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string CfmPassword { get; set; }
    }
}
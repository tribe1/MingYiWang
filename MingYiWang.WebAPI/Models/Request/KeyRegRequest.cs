using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MingYiWang.WebAPI.Models
{
    public class KeyRegRequest
    {
        /// <summary>
        /// 直接预约
        /// </summary>
        public KeyReg DirectReg { get; set; }

        /// <summary>
        /// 病人Id
        /// </summary>
        public string PatientId { get; set; }

    }
}
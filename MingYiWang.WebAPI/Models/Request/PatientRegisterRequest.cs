using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MingYiWang.WebAPI.Models
{
    public class PatientRegisterRequest
    {
        public string Name { get; set; }

        public string Tel { get; set; }

        public string Gender { get; set; }
    }
}
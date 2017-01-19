using MingYiWang.Business.Model;
using MingYiWang.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MingYiWang.Business
{
    public class SaveDoctorInfo : ISaveUserInfo
    {

        private readonly Doctor _doctor = null;
        public SaveDoctorInfo(Doctor doctor)
        {
            _doctor = doctor;
        }
        public ResultApi<string> SaveInfo()
        {
            throw new NotImplementedException();
        }
    }
}

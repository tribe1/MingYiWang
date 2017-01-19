using MingYiWang.Business.Model;
using MingYiWang.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MingYiWang.Business
{
    public class SavePatientInfo : ISaveUserInfo
    {

        private readonly Patient _patient = null;
        public SavePatientInfo(Patient patient)
        {
            _patient = patient;
        }

        public ResultApi<string> SaveInfo()
        {
            throw new NotImplementedException();
        }
    }
}

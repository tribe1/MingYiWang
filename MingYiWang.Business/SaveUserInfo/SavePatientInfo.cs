using MingYiWang.Business.Model;
using MingYiWang.Common.Model;
using MingYiWang.DataAccess.MySql;
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
            var result = new ResultApi<string>();
            try
            {
                var dbContext = new PatientContext();
                dbContext.Patients.Add(_patient);
                dbContext.Save();
                result.Sucess = true;
                result.ReturnMsg = "保存信息成功";
            }
            catch (Exception exp)
            {

                result.ReturnMsg = exp.Message;
                result.Sucess = false;
                result.Data = "保存失败";
            }
            return result;
        }
    }
}

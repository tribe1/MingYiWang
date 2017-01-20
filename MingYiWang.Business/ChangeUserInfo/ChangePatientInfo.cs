using MingYiWang.Business.Model;
using MingYiWang.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MingYiWang.Business
{
    public class ChangePatientInfo : IChangeUserInfo
    {


        public ChangePatientInfo(Patient patient)
        {

        }
        public ResultApi<string> ChangeInfo()
        {
            throw new NotImplementedException();
        }
    }
}

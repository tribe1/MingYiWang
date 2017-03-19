using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MingYiWang.Common.Model;
using MingYiWang.Business.Model;
using MingYiWang.DataAccess.SqLite;

namespace MingYiWang.Business
{
    public class SaveUserInfo : ISaveUserInfo
    {
        private readonly User _user;
        public SaveUserInfo(User user)
        {
            _user = user;
        }

        public ResultApi<string> SaveInfo()
        {
            var result = new ResultApi<string>();
            try
            {
                var dbContext = new UserContext();
                dbContext.Users.Add(_user);
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

using MingYiWang.Business.Model;
using MingYiWang.Common.Model;
using MingYiWang.DataAccess.MySql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MingYiWang.Business
{
    /// <summary>
    /// 科室业务
    /// </summary>
    public class DeptBiz
    {

        public readonly Dept _dept;
        /// <summary>
        /// 科室
        /// </summary>
        /// <param name="dept"></param>
        public DeptBiz(Dept dept)
        {
            _dept = dept;
        }

        public ResultApi<string> SaveInfo()
        {
            var result = new ResultApi<string>();
            try
            {
                var dbContext = new DeptContext();
                dbContext.Depts.Add(_dept);
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

using MingYiWang.Business;
using MingYiWang.Business.Model;
using MingYiWang.Common.Model;
using MingYiWang.DataAccess.MySql;
using MingYiWang.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MingYiWang.WebAPI.Controllers
{
    /// <summary>
    /// 科室管理
    /// </summary>
    public class DeptController : ApiController
    {
        private readonly DeptContext dbContext = new DeptContext();
        /// <summary>
        /// 获取科室集合
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public ResultApi<List<Dept>> GetDepts()
        {
            var result = new ResultApi<List<Dept>>();
            result.Data = dbContext.Depts.ToList();
            return result;
        }

        /// <summary>
        /// 创建科室
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public ResultApi<string> PostDept(NewDeptRequest req)
        {
            var biz = new DeptBiz(TransferTo(req));
            return biz.SaveInfo(); ;
        }

        private Dept TransferTo(NewDeptRequest req)
        {

            if (null == req)
            {
                throw new Exception("参数不能为空");
            }
            return new Dept { DeptId = req.DeptId, Remark = req.Remark, DeptName = req.DeptName };

        }


        /// <summary>
        /// 删除科室，因为科室是公共数据，所有操作都是逻辑删除
        /// </summary>
        /// <param name="deptId"></param>
        /// <returns></returns>
        [HttpPost]
        public ResultApi<string> DeleteDept(string deptId)
        {
            var result = new ResultApi<string>();
            return result;
        }
    }
}

using MingYiWang.Common.Model;
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
        /// <summary>
        /// 获取科室集合
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public ResultApi<List<CommboxItem>> GetDepts()
        {
            var lst = new List<CommboxItem>();
            lst.Add(new CommboxItem { Text = "心内科", Id = "0001" });
            lst.Add(new CommboxItem { Text = "脑科", Id = "0002" });
            lst.Add(new CommboxItem { Text = "耳鼻喉科", Id = "0003" });
            var result = new ResultApi<List<CommboxItem>>();
            result.Data = lst;
            return result;
        }

        /// <summary>
        /// 创建科室
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public ResultApi<string> PostDept(NewDeptRequest req)
        {
            var result = new ResultApi<string>();

            return result;
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

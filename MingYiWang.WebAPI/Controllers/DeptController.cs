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
    public class DeptController : ApiController
    {
        [HttpGet]
        [ActionName("api/dept/Depts")]
        public ResultApi<List<CommboxItem>> List([FromBody] DeptRequest req)
        {
            var lst = new List<CommboxItem>();
            lst.Add(new CommboxItem { Text = "心内科", Id = "0001" });
            lst.Add(new CommboxItem { Text = "脑科", Id = "0002" });
            lst.Add(new CommboxItem { Text = "耳鼻喉科", Id = "0003" });
            var result = new ResultApi<List<CommboxItem>>();
            result.Data = lst;
            return result;
        }

    }
}

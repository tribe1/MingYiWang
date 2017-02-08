using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MingYiWang.WebAPI.Models
{
    public class HospitalRequest
    {

        /// <summary>
        /// 分类
        /// </summary>
        public string Catalog { get; set; }

        /// <summary>
        /// 所在城市
        /// </summary>
        public string CityId { get; set; }

    }
}
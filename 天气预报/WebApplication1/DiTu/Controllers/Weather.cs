using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace DiTu.Controllers
{
    public class Weather
    {
        [DisplayName("温度")]
        public string Temperature { get; set; }

        [DisplayName("城市")]
        public string city { get; set; }

        [DisplayName("湿度")]
        public string Humidity { get; set; }

    }
}
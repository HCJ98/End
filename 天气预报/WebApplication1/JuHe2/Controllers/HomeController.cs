using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JuHe2.Controllers;
using Juhe.common;

namespace JuHe2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var data = WeayherHelper.GetWeatherBycityName("柳州");
            return View(data);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
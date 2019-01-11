using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;


namespace WebApplication1.Controllers //命名空间
{
    public class TestController : Controller //定义类
    {
        public string GetString() //定义方法
        {
            return "你好,MVC！";
        }
        public Customer getCustomer()
        {
            Customer ct = new Customer();
            ct.CustomerNmae = "ABC";
            ct.Address = "AEF";
            return ct;

        }
        public ActionResult GetView()
        {
            string greeting;
            //获取当前时间
            DateTime dt = DateTime.Now;
            int hour = dt.Hour;

            if (hour < 12)
            {
                greeting ="早上好";
            }

            else
            {
                greeting="下午好";
            }
            ViewData["greeting"] = greeting;
            Employee emp = new Employee();
            emp.Name = "锦歌";
            emp.Salary = 68468;
            ViewData["Empkey"] = emp;
            return View("MyView");
        }
}
}
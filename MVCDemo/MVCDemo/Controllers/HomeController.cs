using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(string id)
        {
            ViewData["userinput"] = id;
            return View();
        }

        public ActionResult SayGoodMorning()
        {
            return View();
        }

        [HttpPost]
        public ActionResult showuserinput(string input1)
        {
            return Redirect("/Home/Index/" + input1);
        }
    }
}
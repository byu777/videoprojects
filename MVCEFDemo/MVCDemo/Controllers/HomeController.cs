using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        bendbmsEntities _db;

        public HomeController()
        {
            _db = new bendbmsEntities();
        }
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

        public ActionResult ShowCustomers()
        {
            ViewData.Model = _db.Customers.Select (
                customer => new Models.CustomerSubset
                {
                    LastName = customer.LastName,
                    FirstName = customer.FirstName
                }).ToList();
            return View();
        }

        [HttpPost]
        public ActionResult showuserinput(string input1)
        {
            return Redirect("/Home/Index/" + input1);
        }
    }
}
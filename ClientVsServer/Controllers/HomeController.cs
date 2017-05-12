using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Identity;
using System.Web;
using System.Web.Mvc;
using ClientVsServer.Models;
using Newtonsoft.Json;


namespace ClientVsServer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]    
        public JsonResult GetCurrentUser()
        {

            var id = User.Identity.GetUserId();
            if (id != null)
            {
                var db = new ApplicationDbContext();
                var user = db.Users.Find(id);
                return Json(user, JsonRequestBehavior.AllowGet);
            }
            return null;

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

        public ActionResult SQLInjection()
        {
            return View();
        }

        [ValidateInput(false)]
        [HttpPost]
        public ActionResult Inject(string FirstName)
        {
            List<Customer> result = new List<Customer>();
            //string result = "";
            var query = "select * From Customers WHERE FirstName = '" + FirstName + "'";
            using (var db = new ApplicationDbContext())
            {
                result = db.Database.SqlQuery<Customer>(query).ToList();
            }

            return Content(JsonConvert.SerializeObject( result));
        }
    }
}
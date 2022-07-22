using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EClerx.MVC.Day26.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
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

        public ActionResult Test(int? id)
        {
            //if (id.HasValue)
            //{
            //    return Content($"Value of id :{id.Value}");
            //}
            //return Content("No ID given");
            //return HttpNotFound("Product Id doesn't exist");
            ViewBag.Message = "This is Test Action Method";
            return View();
        }

        public ActionResult Details(int? custId)
        {
            if (custId.HasValue)
            {
                return Content($"Customer ID :{custId.Value}");
            }
            return Content("No Customer ID");
        }

        //GET
        //Home/SearchByIdAndName/101/Jagan
        public ActionResult SearchByIdAndName(int? id, string name)
        {
            if (id.HasValue && !string.IsNullOrEmpty(name))
            {
                return Content($"Id :{id.Value}\tName :{name}");
            }
            return Content("No Data");
        }
    }
}
using EClerx.MVC.Day26.Models;
using EClerx.MVC.Day26.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EClerx.MVC.Day26.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _dbContext = null;

        public HomeController()
        {
            _dbContext = new ApplicationDbContext();
        }

        public ViewResult Index()
        {
            var customer = _dbContext.Customers.FirstOrDefault(c => c.Id == 1);
            var product = _dbContext.Products.FirstOrDefault(p => p.Id == 2);
            ProductAndCustomerVM vm = new ProductAndCustomerVM();
            vm.Name = customer.Name;
            vm.DateOfBirth = customer.DateOfBirth;
            vm.Product = product;
            return View(vm);
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
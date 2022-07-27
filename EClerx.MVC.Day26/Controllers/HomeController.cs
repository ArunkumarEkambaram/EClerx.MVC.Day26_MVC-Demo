using EClerx.MVC.Day26.Models;
using EClerx.MVC.Day26.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace EClerx.MVC.Day26.Controllers
{    
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _dbContext = null;

        public HomeController()
        {
            _dbContext = new ApplicationDbContext();
        }

        private IEnumerable<SelectListItem> PopulateCategories()
        {
            return _dbContext.Categories.Select(c => new SelectListItem
            {
                Value = c.Name,
                Text = c.Name,
            }).AsEnumerable();
        }

        public ActionResult Index()
        {
            ProductsByCategoryVM productsByCategory = new ProductsByCategoryVM();
            var categories = PopulateCategories();
            productsByCategory.Categories = categories;
            return View(productsByCategory);
        }

        //[HttpGet]
        public ActionResult GetProducts(string CategoryName)
        {
            ProductsByCategoryVM productsByCategory = new ProductsByCategoryVM();
            var products = _dbContext.Products.Include(p => p.Category).Where(p => p.Category.Name == CategoryName);
            productsByCategory.Products = products;

            var categories = PopulateCategories();
            productsByCategory.Categories = categories;
            return View("Index", productsByCategory);
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
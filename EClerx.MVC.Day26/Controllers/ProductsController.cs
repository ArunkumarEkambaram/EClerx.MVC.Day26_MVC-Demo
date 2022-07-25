using EClerx.MVC.Day26.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace EClerx.MVC.Day26.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _dbContext = null;

        public ProductsController()
        {
            _dbContext = new ApplicationDbContext();
        }

        // GET: Products
        public ActionResult Index()
        {
            //var products = GetProducts();

            var products = _dbContext.Products.ToList();
            return View(products);//return list of product
        }

        //GET
        public ActionResult Details(int id)
        {
            var product = _dbContext.Products.Include(p => p.Category).FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                return View(product);
            }
            return HttpNotFound();
        }

        //GET
        [HttpGet]
        public ActionResult Create()
        {
            var categories = _dbContext.Categories.ToList();
            ViewBag.Categories = categories;
            return View();
        }

        //[HttpPost]
        //public ActionResult Create()
        //{
        //    return View();
        //}

    }
}
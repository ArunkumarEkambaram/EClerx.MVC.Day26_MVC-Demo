using EClerx.MVC.Day26.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EClerx.MVC.Day26.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            var products = GetProducts();
            return View(products);//return list of product
        }

        //Data for Product Class
        public List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product { Id=1, ProductName="AMD Ryzen 5", Category="Processor", Price=18000, Quantity=20},
                new Product { Id=2, ProductName="Water Bottle", Category="Home", Price=550, Quantity=230},
                new Product { Id=3, ProductName="LG 24inch Monitor", Category="Monitor", Price=13000, Quantity=20},
                new Product { Id=4, ProductName="Logitech Mouse", Category="Accessories", Price=1250, Quantity=60},
            };
        }
    }
}
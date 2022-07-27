using EClerx.MVC.Day26.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EClerx.MVC.Day26.ViewModels
{
    public class ProductsByCategoryVM
    {        
        public IEnumerable<SelectListItem> Categories { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
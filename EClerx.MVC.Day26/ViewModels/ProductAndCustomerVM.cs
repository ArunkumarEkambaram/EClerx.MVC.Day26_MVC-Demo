using EClerx.MVC.Day26.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EClerx.MVC.Day26.ViewModels
{
    public class ProductAndCustomerVM
    {
        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public Product Product { get; set; }

        //public List<Product> Products { get; set; }

        //public string ProductName { get; set; }

        //public decimal Price { get; set; }

        //public short Quantity { get; set; }
    }
}
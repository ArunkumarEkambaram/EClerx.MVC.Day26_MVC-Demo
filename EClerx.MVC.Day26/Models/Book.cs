using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EClerx.MVC.Day26.Models
{
    public class Book
    {
       // [Key]
        public string BookId { get; set; }
        public string BookName { get; set; }
    }
}
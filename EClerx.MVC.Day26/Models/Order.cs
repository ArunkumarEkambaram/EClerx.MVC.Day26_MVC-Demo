using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EClerx.MVC.Day26.Models
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime OrderedDate { get; set; } = DateTime.Now;

        public short TotalQuantity { get; set; }

        public decimal TotalPrice { get; set; }

        public DateTime? EstimatedDeliveryDate { get; set; }

        //Reference Table - Product
        public Product Product { get; set; }
        public int? ProductId { get; set; }

        //Reference Table - Customer
        public Customer Customer { get; set; }
        public int? CustomerId { get; set; }
    }
}
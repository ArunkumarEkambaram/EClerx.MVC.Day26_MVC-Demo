using System;

namespace EClerx.MVC.Day26.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }       
        public decimal Price { get; set; }
        public short Quantity { get; set; }

        //Auditable Column
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }

        //Reference Table
        public Category Category { get; set; }
        //Foreign Key Column
        public int CategoryId { get; set; }
    }
}
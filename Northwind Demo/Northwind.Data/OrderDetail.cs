using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Northwind.Data
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        //TODO: Finish the order detail column mappings

        public int OrderID { get; set; }
        public int ProductID { get; set; }

        public decimal UnitPrice { get; set; }

        public int Quantity { get; set; }

        public double Discount { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}

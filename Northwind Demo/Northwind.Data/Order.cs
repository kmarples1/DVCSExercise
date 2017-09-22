using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Northwind.Data
{
    public class Order
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public int? EmployeeID { get; set; }

        public DateTime? OrderDate { get; set; }

        public DateTime? RequiredDate { get; set; }

        public DateTime? ShippedDate { get; set; }

        public int? ShipVia { get; set; }

        public decimal? Freight { get; set; }

        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; } //collections - green?

        [ForeignKey("ShipVia")] // <-- Tells entity framework which propery to use as the foreign key as there is two "Shipper"
        public virtual Shipper Shipper { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Shipper ShipViaShipper { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Data
{
    [Table("CustomerCustomerDemo")]
    public class CustomerCustomerDemo
    {
        public char[] CustomerID { get; set; }
        public char[] CstomerTypeID { get; set; }

        public virtual Customer Customers { get; set; }
        public virtual CustomerDemographic CustomerDemographics { get; set; }
    }
}

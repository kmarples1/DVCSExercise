using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Data
{
    [Table("CustomerDemographics")]
    public class CustomerDemographic
    {
        public char[] CustomerTypeID { get; set; }
        public string CustomerDescription { get; set; }

        public virtual ICollection<CustomerCustomerDemo> CustomerCustomerDemos { get; set; }
    }
}

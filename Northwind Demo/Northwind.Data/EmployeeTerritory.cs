using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Data
{
    [Table("EmployeeTerritories")]
    public class EmployeeTerritory
    {
        public int EmployeeID { get; set; }

        public string TerritoryID { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }

        public virtual ICollection<Territory> Territories { get; set; }

    }
}

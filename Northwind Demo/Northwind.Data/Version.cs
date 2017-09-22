using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Data
{
    [Table("Version")]
    public class Version
    {
        public Int16 Major { get; set; }

        public Int16 Minor { get; set; }

        public Int16 Maintenance { get; set; }

        public int Build { get; set; }

        public DateTime VersionDate { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}

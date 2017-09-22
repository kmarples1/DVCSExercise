using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Data
{
    [Table("VersionDDLEventLog")]
    public class VersionDDLEventLog
    {
        public int ID { get; set; }
        public DateTime? EventTime { get; set; }

        public string EventType { get; set; }

        public string ServerName { get; set; }

        public string DatabaseName { get; set; }

        public string SchemaName { get; set; }

        public string ObjectType { get; set; }

        public string ObjectName { get; set; }

        public string UserName { get; set; }
        
        public string CommandText { get; set; }

        public string XMlEvent { get; set; }
    }
}

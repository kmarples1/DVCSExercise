using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindData.App.DTOs
{

        public class ProductCategory // DTO some are built in, but the IEnumerable is not a built in datatype (we defined it ourselves)
        {
            // Properties for Name/Description/Picture/Products

            public string Name { get; set; }
            public string Description { get; set; }
            public byte[] Picture { get; set; }
            public IEnumerable<ProductInfo> Products { get; set; }
        }
    
}

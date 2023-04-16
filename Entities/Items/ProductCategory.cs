using Entities.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Items
{
    public class ProductCategory : CoreEntity
    {
        public string CategoryName { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}

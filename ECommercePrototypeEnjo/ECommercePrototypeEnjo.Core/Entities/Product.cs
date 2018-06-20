using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommercePrototypeEnjo.Core
{
    public class Product : AuditableEntity
    {
        public string Title { get; set; }
        public string Thumbnail { get; set; }
        public double Price { get; set; }
    }
}

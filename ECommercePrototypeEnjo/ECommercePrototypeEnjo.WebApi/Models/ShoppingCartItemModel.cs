using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECommercePrototypeEnjo.WebApi.Models
{
    public class ShoppingCartItemModel
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int Quantity { get; set; }
        public double CartItemPrice { get; set; }

        public int ProductId { get; set; }
        public string ProductTitle { get; set; }
        public double ProductPrice { get; set; }
    }
}
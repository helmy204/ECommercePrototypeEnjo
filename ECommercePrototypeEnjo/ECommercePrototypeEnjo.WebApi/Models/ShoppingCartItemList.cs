using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECommercePrototypeEnjo.WebApi.Models
{
    public class ShoppingCartItemList
    {
        public ShoppingCartItemList()
        {
            ShoppingCartItems = new List<ShoppingCartItemModel>();
        }

        public List<ShoppingCartItemModel> ShoppingCartItems { get; set; }

        public double TotalPrice { get; set; }
    }
}
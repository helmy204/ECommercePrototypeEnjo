using ECommercePrototypeEnjo.Core;
using ECommercePrototypeEnjo.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECommercePrototypeEnjo.WebApi
{
    public static class ShoppingCartItemExtensions
    {
        public static ShoppingCartItem ToEntity(this ShoppingCartItemModel shoppingCartItemModel)
        {
            ShoppingCartItem shoppingCartItem = new ShoppingCartItem()
            {
                Id = shoppingCartItemModel.Id,
                CustomerId = shoppingCartItemModel.CustomerId,
                ProductId = shoppingCartItemModel.ProductId,
                Quantity = shoppingCartItemModel.Quantity
            };

            return shoppingCartItem;
        }
    }
}
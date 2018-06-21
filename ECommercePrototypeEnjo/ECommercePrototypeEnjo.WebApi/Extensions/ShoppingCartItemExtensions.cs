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

        public static ShoppingCartItemList ToModels(this IEnumerable<ShoppingCartItem> shoppingCartItems)
        {
            ShoppingCartItemList shoppingCartItemList = new ShoppingCartItemList();

            foreach (ShoppingCartItem shoppingCartItem in shoppingCartItems)
            {
                ShoppingCartItemModel shoppingCartItemModel = shoppingCartItem.ToModel();
                shoppingCartItemList.ShoppingCartItems.Add(shoppingCartItemModel);
                shoppingCartItemList.TotalPrice += shoppingCartItemModel.CartItemPrice;
            }


            return shoppingCartItemList;
        }

        public static ShoppingCartItemModel ToModel(this ShoppingCartItem shoppingCartItem)
        {
            ShoppingCartItemModel shoppingCartItemModel=   new ShoppingCartItemModel()
            {
                Id = shoppingCartItem.Id,
                Quantity = shoppingCartItem.Quantity,
                ProductId=shoppingCartItem.ProductId,
                ProductTitle = shoppingCartItem.Product.Title,
                ProductPrice = shoppingCartItem.Product.Price
            };

            shoppingCartItemModel.CartItemPrice = shoppingCartItem.Product.Price * shoppingCartItem.Quantity;

            return shoppingCartItemModel;
        }
    }
}
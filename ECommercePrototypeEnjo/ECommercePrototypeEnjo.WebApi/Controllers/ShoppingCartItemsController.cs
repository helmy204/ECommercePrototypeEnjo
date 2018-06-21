using ECommercePrototypeEnjo.Core;
using ECommercePrototypeEnjo.Service;
using ECommercePrototypeEnjo.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ECommercePrototypeEnjo.WebApi.Controllers
{
    public class ShoppingCartItemsController : ApiController
    {
        private readonly IShoppingCartItemService _shoppingCartItemService;

        public ShoppingCartItemsController(IShoppingCartItemService shoppingCartItemService)
        {
            _shoppingCartItemService = shoppingCartItemService;
        }

        public void Post([FromBody]ShoppingCartItemModel shoppingCartItemModel)
        {
            ShoppingCartItem shoppingCartItem = shoppingCartItemModel.ToEntity();
            _shoppingCartItemService.Insert(shoppingCartItem);
        }

        public void Put([FromBody]ShoppingCartItemModel shoppingCartItemModel)
        {
            ShoppingCartItem shoppingCartItem= shoppingCartItemModel.ToEntity();
            _shoppingCartItemService.UpdateProductQuantity(shoppingCartItem);
        }

        public void Delete(int id)
        {
            _shoppingCartItemService.Delete(id);
        }
    }
}

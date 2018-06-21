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

        public ShoppingCartItemList Get(int customerId)
        {
            IEnumerable<ShoppingCartItem> shoppingCartItems = _shoppingCartItemService.GetAllCartItems(customerId);
            ShoppingCartItemList shoppingCartItemList = shoppingCartItems.ToModels();
            return shoppingCartItemList;
        }

        public HttpStatusCode Post([FromBody]ShoppingCartItemModel shoppingCartItemModel)
        {
            try
            {
                ShoppingCartItem shoppingCartItem = shoppingCartItemModel.ToEntity();
                _shoppingCartItemService.Insert(shoppingCartItem);
                return HttpStatusCode.OK;
            }
            catch (Exception ex)
            {
                return HttpStatusCode.InternalServerError;
            }
        }

        public HttpStatusCode Put([FromBody]ShoppingCartItemModel shoppingCartItemModel)
        {
            try
            {
                ShoppingCartItem shoppingCartItem = shoppingCartItemModel.ToEntity();
                _shoppingCartItemService.UpdateProductQuantity(shoppingCartItem);
                return HttpStatusCode.OK;
            }
            catch (Exception ex)
            {
                return HttpStatusCode.InternalServerError;
            }
        }

        public HttpStatusCode Delete(int id)
        {
            try
            {
                _shoppingCartItemService.Delete(id);
                return HttpStatusCode.OK;
            }
            catch (Exception ex)
            {
                return HttpStatusCode.InternalServerError;
            }
        }
    }
}

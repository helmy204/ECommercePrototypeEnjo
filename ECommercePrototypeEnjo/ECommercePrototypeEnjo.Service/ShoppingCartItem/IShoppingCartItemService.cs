using ECommercePrototypeEnjo.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommercePrototypeEnjo.Service
{
   public interface IShoppingCartItemService
    {
        void Insert(ShoppingCartItem shoppingCartItem);
        void Delete(int id);
        void UpdateProductQuantity(ShoppingCartItem shoppingCartItem);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommercePrototypeEnjo.Core;
using ECommercePrototypeEnjo.Data;

namespace ECommercePrototypeEnjo.Service
{
    public class ShoppingCartItemService : IShoppingCartItemService
    {
        #region Fields

        private readonly IRepository<ShoppingCartItem> _shoppingCartItemRepository;

        #endregion Fields

        #region Ctor

        public ShoppingCartItemService(IRepository<ShoppingCartItem> shoppingCartItemRepository)
        {
            _shoppingCartItemRepository = shoppingCartItemRepository;
        }

        #endregion Ctor

        public void Insert(ShoppingCartItem shoppingCartItem)
        {
            shoppingCartItem.InsertedOn = DateTime.Now;
            shoppingCartItem.InsertedBy = shoppingCartItem.CustomerId;

            _shoppingCartItemRepository.Insert(shoppingCartItem);
        }

        public void Delete(int id)
        {
            Check.ArgumentNotNullOrDefault<int>("id", id);

            ShoppingCartItem shoppingCartItem = _shoppingCartItemRepository.GetById(id);

            Check.EntityNotNull("shoppingCartItem",shoppingCartItem);

            _shoppingCartItemRepository.Delete(shoppingCartItem);
        }

        public void UpdateProductQuantity(ShoppingCartItem shoppingCartItem)
        {
            Check.ArgumentNotNullOrDefault<int>("shoppingCartItem.Id", shoppingCartItem.Id);

            ShoppingCartItem entity = _shoppingCartItemRepository.GetById(shoppingCartItem.Id);

            Check.EntityNotNull("shoppingCartItem", entity);

            entity.Quantity = shoppingCartItem.Quantity;
            entity.UpdatedOn = DateTime.Now;
            entity.UpdatedBy = entity.CustomerId;

            _shoppingCartItemRepository.Update(entity);
        }

        public List<ShoppingCartItem> GetAllCartItems(int customerId)
        {
            Check.ArgumentNotNullOrDefault<int>("customerId", customerId);

            IQueryable<ShoppingCartItem> shoppingCartItems = _shoppingCartItemRepository.Table.Where(c => c.CustomerId == customerId);

            return shoppingCartItems.ToList();
        }
    }
}

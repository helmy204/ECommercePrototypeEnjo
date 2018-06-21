using ECommercePrototypeEnjo.Core;
using ECommercePrototypeEnjo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommercePrototypeEnjo.Service
{
    public class CustomerService : ICustomerService
    {
        #region Fields

        private readonly IRepository<Customer> _customerRepository;
        private readonly IRepository<ShoppingCartItem> _shoppingCartItemRepository;

        #endregion Fields

        #region Ctor

        public CustomerService(IRepository<Customer> customerRepository,
            IRepository<ShoppingCartItem> shoppingCartItemRepository)
        {
            _customerRepository = customerRepository;
            _shoppingCartItemRepository = shoppingCartItemRepository;
        }

        #endregion Ctor

        public void ClearShoppingCart(int customerId)
        {
            Check.ArgumentNotNullOrDefault<int>("customerId", customerId);

            Customer customer = _customerRepository.GetById(customerId);

            Check.EntityNotNull("customer", customer);

            foreach (var item in customer.ShoppingCartItems)
            {
                Check.ArgumentNotNullOrDefault<int>("shoppingCartItem.Id", item.Id);

                ShoppingCartItem shoppingCartItem = _shoppingCartItemRepository.GetById(item.Id);

                Check.EntityNotNull("shoppingCartItem", shoppingCartItem);

                _shoppingCartItemRepository.Delete(shoppingCartItem);
            }

            _customerRepository.Update(customer);
        }
    }
}

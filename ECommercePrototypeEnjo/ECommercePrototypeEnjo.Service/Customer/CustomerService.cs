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
            Customer customer = _customerRepository.GetById(customerId);

            foreach (var item in customer.ShoppingCartItems)
            {
                ShoppingCartItem shoppingCartItem = _shoppingCartItemRepository.GetById(item.Id);
                _shoppingCartItemRepository.Delete(shoppingCartItem);
            }

            _customerRepository.Update(customer);
        }
    }
}

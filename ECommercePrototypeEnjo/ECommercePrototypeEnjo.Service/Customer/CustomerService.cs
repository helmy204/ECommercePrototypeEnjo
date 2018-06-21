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

        #endregion Fields

        #region Ctor

        public CustomerService(IRepository<Customer> customerRepository)
        {
            _customerRepository = customerRepository;
        }

        #endregion Ctor

        public void ClearShoppingCart(int customerId)
        {
            Customer customer = _customerRepository.GetById(customerId);
            customer.ClearShoppingCart();

            _customerRepository.Update(customer);
        }
    }
}

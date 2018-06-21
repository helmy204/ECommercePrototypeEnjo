using ECommercePrototypeEnjo.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ECommercePrototypeEnjo.WebApi.Controllers
{
    public class CustomersController : ApiController
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpPut]
        public void ClearShoppingCart(int customerId)
        {
            _customerService.ClearShoppingCart(customerId);
        }
    }
}

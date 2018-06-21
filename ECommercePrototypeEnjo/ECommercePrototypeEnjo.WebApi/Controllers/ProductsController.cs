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
    public class ProductsController : ApiController
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        // GET api/products
        public List<ProductModel> Get()
        {
            IEnumerable<Product> products = _productService.GetAllProducts();
            List<ProductModel> lstProducts = products.ToModels();
            return lstProducts;
        }
    }
}

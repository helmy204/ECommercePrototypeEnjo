using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommercePrototypeEnjo.Core;
using ECommercePrototypeEnjo.Data;

namespace ECommercePrototypeEnjo.Service
{
    public class ProductService : IProductService
    {
        #region Fields

        private readonly IRepository<Product> _productRepository;

        #endregion Fields

        #region Ctor

        public ProductService(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        #endregion Ctor

        public IEnumerable<Product> GetAllProducts()
        {
            IQueryable<Product> products = _productRepository.Table;
            return products.ToList();
        }
    }
}

using ECommercePrototypeEnjo.Core;
using ECommercePrototypeEnjo.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECommercePrototypeEnjo.WebApi
{
    public static class ProductExtensions
    {
        public static List<ProductModel> ToModels(this IEnumerable<Product> products)
        {
            List<ProductModel> productModels = new List<ProductModel>();

            foreach (var product in products)
            {
                productModels.Add(new ProductModel()
                {
                    Id = product.Id,
                    Price = product.Price,
                    Thumbnail = product.Thumbnail,
                    Title = product.Title
                });
            }

            return productModels;
        }
    }
}
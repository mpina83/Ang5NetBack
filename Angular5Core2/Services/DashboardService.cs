using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Angular5Core2.Models;

namespace Angular5Core2.Services
{
    public static class DashboardService
    {
        public static List<ProductModel> CreateProducts() {
            List<ProductModel> productsList = new List<ProductModel>();

            productsList.Add(AddProduct("Pen","Utility", 3));
            productsList.Add(AddProduct("Rubber","Utility", 10));
            productsList.Add(AddProduct("Oranges","Fruit", 8));
            productsList.Add(AddProduct("Apples","Fruit", 15));
            productsList.Add(AddProduct("Beer","Drink", 50));
            return productsList;
        }

        private static ProductModel AddProduct(string name, string type, int quantity)
        {
            ProductModel product = new ProductModel()
            {
                Name = name,
                Type = type,
                Quantity = quantity
            };

            return product;
        }
    }
}
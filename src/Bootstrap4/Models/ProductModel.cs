using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bootstrap4.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public bool Discontinued { get; set; }
        public string Status { get; set; }

        public static List<ProductModel> GetProducts()
        {
            var model = new List<ProductModel>();
            var product1 = new ProductModel
            {
                Name = "Chai",
                UnitPrice = 18,
                UnitsInStock = 35,
                Discontinued = false,
                Id = 1,
                Status = "active"
            };
            var product2 = new ProductModel
            {
                Name = "Chang",
                UnitPrice = 19,
                UnitsInStock = 17,
                Discontinued = false,
                Id = 2,
                Status = "success"
            };
            var product3 = new ProductModel
            {
                Name = "Aniseed Syrup",
                UnitPrice = 10,
                UnitsInStock = 13,
                Discontinued = false,
                Id = 3,
                Status = "info"
            };
            var product4 = new ProductModel
            {
                Name = "Pavlova",
                UnitPrice = 17,
                UnitsInStock = 29,
                Discontinued = false,
                Id = 4,
                Status = "warning"
            };
            var product5 = new ProductModel
            {
                Name = "Carnarvon Tigers",
                UnitPrice = 62,
                UnitsInStock = 42,
                Discontinued = true,
                Id = 5,
                Status = "danger"
            };
            model.AddRange(new[]
            { product1, product2, product3, product4, product5 });
            return model;
        }
    }
}

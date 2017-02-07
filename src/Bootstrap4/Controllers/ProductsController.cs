using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Bootstrap4.Models;

namespace Bootstrap4.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
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
            model.AddRange(new[] { product1, product2, product3, product4, product5 });
            return View(model);
        }
    }
}
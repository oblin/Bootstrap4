using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bootstrap4.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bootstrap4.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index(string query)
        {
            ViewBag.SearchQuery = query;
            var products = ProductModel.GetProducts();
            if (!string.IsNullOrEmpty(query))
            {
                var results = products.Where(p => p.Name.Contains(query));
                return View(results);
            }
            return View(products);
        }
    }
}
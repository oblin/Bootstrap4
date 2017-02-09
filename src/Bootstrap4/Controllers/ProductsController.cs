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
        public IActionResult Index(int? page)
        {
            var model = new ProductPagingViewModel();

            int pageSize = 10;
            var currentPageNum = page.HasValue ? page.Value : 1;
            var offset = (pageSize * currentPageNum) - pageSize;

            model.Products = ProductModel.GetProducts()
                .Skip(offset).Take(pageSize).OrderBy(p => p.Name).ToList();
            model.Paging.CurrentPage = currentPageNum;
            model.Paging.ItemsPerPage = pageSize;
            model.Paging.TotalItems = ProductModel.GetProducts().Count;

            return View(model);
        }
    }
}
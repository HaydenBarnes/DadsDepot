﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheDadsDepot.Models;
using TheDadsDepot.Models.ViewModels;

namespace TheDadsDepot.Controllers
{
    public class HomeController : Controller
    {
        private IDepotRepository repository;
        public int PageSize = 4;

        public HomeController(IDepotRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index(string category, int productPage = 1)
            => View(new ProductsListViewModel
            {
                Products = repository.Products
                    .Where(p => category == null || p.Category == category)
                    .OrderBy(p => p.ProductID)
                    .Skip((productPage - 1) * PageSize)
                    .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                     CurrentPage = productPage,
                     ItemsPerPage = PageSize,
                     TotalItems = category == null ?
                        repository.Products.Count() :
                        repository.Products.Where(e =>
                            e.Category == category).Count()
                },
                 CurrentCategory = category
             });


    }
}

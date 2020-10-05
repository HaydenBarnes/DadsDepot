using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheDadsDepot.Models;

namespace TheDadsDepot.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IDepotRepository repository;

        public NavigationMenuViewComponent(IDepotRepository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(repository.Products
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}

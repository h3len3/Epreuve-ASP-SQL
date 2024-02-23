using ASP_Epreuve_hd.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

using Microsoft.AspNetCore.Http;


using BLL_Epreuve_hd.Entities;
using ASP_Epreuve_hd.Handlers;
using Shared_Epreuve_hd.Repositories;
using System.Reflection;
using static System.Collections.Specialized.BitVector32;
using ASP_Epreuve_hd.Models.Product;

namespace ASP_Epreuve_hd.Controllers
{
    public class HomeController : Controller
    {     
        private readonly IProductRepository<Product> _productRepository;

        public HomeController(IProductRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult Index(string[]? selectedCateg)
        {
            IEnumerable<ProductListItemViewModel> model;

            if (selectedCateg != null && selectedCateg.Length > 0)
            {
                List<ProductListItemViewModel> categ = new List<ProductListItemViewModel>();
                foreach (string categoryName in selectedCateg)
                {
                    categ.AddRange(_productRepository.GetByCategory(categoryName).Select(d => d.ToListItem()));
                }
                model = categ.Distinct();
            }

            else
            {

                model = _productRepository.Get().Select(d => d.ToListItem());
            }

            return View(model);
        }

        public ActionResult DetailsProduct(int id)
        {
            ProductDetailsViewModel model = _productRepository.Get(id).ToDetails();
            return View(model);
        }

        public ActionResult CategoryFilter(string[] selectedCateg)
        {
         
            IEnumerable<ProductListItemViewModel> model;

            if (selectedCateg != null )
            {
                List<ProductListItemViewModel> categ = new List<ProductListItemViewModel>();
                foreach (string categoryName in selectedCateg)
                {
                    categ.AddRange(_productRepository.GetByCategory(categoryName).Select(d => d.ToListItem()));
                }
                model = categ.Distinct();
            }

            else
            {

                model = _productRepository.Get().Select(d => d.ToListItem());
            }

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
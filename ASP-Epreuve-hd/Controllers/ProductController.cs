using ASP_Epreuve_hd.Handlers;
using ASP_Epreuve_hd.Models;
using ASP_Epreuve_hd.Models.Product;
using BLL_Epreuve_hd.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared_Epreuve_hd.Repositories;

namespace ASP_Epreuve_hd.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository<Product> _productRepository;

        public ProductController(IProductRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }


        // GET: Product

        //[Route("adminProduct")]
        public ActionResult Index()
        {
            IEnumerable<ProductListItemViewModel> model = _productRepository.Get().Select(d => d.ToListItem());

            return View(model);
        }

        // GET: Product/Details/5
      
        public ActionResult DetailsProduct(int id)
        {
            ProductDetailsViewModel model = _productRepository.Get(id).ToDetails();
            return View(model);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }
        /*
        // POST: Product/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(StudentCreateForm form)
        //{
        //    try
        //    {
        //        if (form is null) ModelState.AddModelError(nameof(form), "Pas de données reçues");
        //        if (!ModelState.IsValid) throw new Exception();
        //        int id = _studentRepository.Insert(form.ToBLL());
        //        return RedirectToAction(nameof(Details), new { id });
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}*/

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductCreateForm form)
        {
            try
            {
                if (form is null) ModelState.AddModelError(nameof(form), "Pas de données reçues");
                if (!ModelState.IsValid) throw new Exception();
                int id = _productRepository.Insert(form.ToBLL());
                return RedirectToAction(nameof(DetailsProduct), new { id });
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            ProductEditForm model = _productRepository.Get(id).ToEditForm();
            return View(model);
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, ProductEditForm form)
        {
            try
            {
                if (form is null) ModelState.AddModelError(nameof(form), "Le formulaire ne correspond pas");
                if (!ModelState.IsValid) throw new Exception();
                form.Id_Product = id;
                _productRepository.Update(form.ToBLL());
              
                return RedirectToAction(nameof(DetailsProduct), new { id });
            }
            catch
            {
                return View(form);
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                ProductDeleteViewModel model = _productRepository.Get(id).Delete();
                if (model is null) throw new InvalidDataException();
                return View(model);
            }

            catch (Exception)
            {
                TempData["ErrorMessage"] = $"L'identifiant {id} est invalide.";
                return RedirectToAction(nameof(Index));
            }
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, ProductDeleteViewModel model)
        {
            try
            {
                _productRepository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }
        }

    }
}

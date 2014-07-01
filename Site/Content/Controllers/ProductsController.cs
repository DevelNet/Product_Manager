using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using Data.Repositories;
using Site.ViewModel;

namespace Site.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ProductsController : Controller
    {
        private readonly ProductRepository _productRepository;
        public ProductsController()
        {
            _productRepository = new ProductRepository();

        }
        [HttpGet]
        //
        // GET: /Products/
        public ActionResult Index(int numberOfElements=10,int page=1)
        {
            var model = new PageViewModel();
            model.Page = page;
            model.NumberOfElements = numberOfElements;
            model.PageAll = _productRepository.GetAll().Count/numberOfElements;
            model.product = _productRepository.GetByPage(model.NumberOfElements,model.Page);
            return View(model);
        }
        
        [HttpGet]
        public ActionResult Add()
        {
            var model = new ProductCreateNewViewModel();
            var categories = _productRepository.GetCategories();
            model = model.CreateDropDowmList(categories);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(ProductCreateNewViewModel model)
        {
            var categories = _productRepository.GetCategories();
            if (!ModelState.IsValid)
            {
                model = model.CreateDropDowmList(categories);
                return View(model);
            }

            var newProduct = model.GetModel(categories);

            _productRepository.Add(newProduct);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var model = new ProductDetailViewModel();
            var currentProduct = _productRepository.GetById(id);
            model.MapProduct(currentProduct);
            var categories = _productRepository.GetCategories();
            model.CreateDropDowmList(categories);
            return View(model);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = new ProductEditViewModel();
            var currentProduct = _productRepository.GetById(id);
            model.MapProduct(currentProduct);
            var categories = _productRepository.GetCategories();
            model.CreateDropDowmList(categories);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(ProductEditViewModel model)
        {
            var categories = _productRepository.GetCategories();
            if (!ModelState.IsValid)
            {
                model.CreateDropDowmList(categories);
                return View(model);
            }
            var oldProduct = _productRepository.GetById(model.Id);
            var updatedProduct = model.UpdateProduct(oldProduct,categories);
            _productRepository.Update(updatedProduct);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Remove(int id)
        {
            var product = _productRepository.GetById(id);
            _productRepository.Delete(product);
            return RedirectToAction("Index");
        }
    }
}
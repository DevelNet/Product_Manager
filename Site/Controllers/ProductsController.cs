﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using Site.Models;
using Site.Repositories;
using Site.ViewModel;

namespace Site.Controllers
{
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
        public ActionResult Index()
        {
            return View(_productRepository.GetAll());
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
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Remove(int id)
        {
            return View();
        }
    }
}
﻿using AlayıBurada.Bll;
using AlayıBurada.Dal.Concrete.EntityFramework.Repository;
using AlayıBurada.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlayıBurada.MvcUI.Controllers
{
    public class ProductController : Controller
    {
        //IProductService productService = new ProductManager(new EfProductRepository());
        IProductService ProductService;

        public ProductController(IProductService productService)
        {
            ProductService = productService;
        }

        public ActionResult Index()
        {
            return View();
        }

    
    }
}
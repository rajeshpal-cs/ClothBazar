﻿using ClothBazar.Entities;
using ClothBazar.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClothBazar.Web.Controllers
{
    public class CategoryController : Controller
    {

        CategoriesService categoryservice = new CategoriesService();
        // GET: Category
        [HttpGet]
        public ActionResult Index()
        {
            var categories = categoryservice.GetCategory();
            return View(categories);
        }
        [HttpGet]
        public ActionResult Create ()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Category category)
        {
            categoryservice.SaveCategory(category);
            return View();
        }
    }
}
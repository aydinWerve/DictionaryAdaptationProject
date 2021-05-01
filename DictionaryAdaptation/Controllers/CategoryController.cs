using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business.Concrete;
using Entities.Concrete;

namespace DictionaryAdaptation.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryManager categoryManager = new CategoryManager();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAll()
        {
            var categoryValues = categoryManager.GetAll();
            return View(categoryValues);
        }

        public ActionResult Add(Category category)
        {
            categoryManager.Add(category);
            return RedirectToAction("GetAll"); // Ekleme işlemi gerçekleştikten sonra GetAll methoduna yönlendirir
        }
    }
}
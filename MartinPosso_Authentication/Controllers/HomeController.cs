using MartinPosso_Authentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MartinPosso_Authentication.Controllers
{
    public class HomeController : Controller
    {
        private ShopDB db = new ShopDB();
        public ActionResult Index(string searchString, string sortOrder)
        {
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.CategorySortParm = sortOrder == "CategoryName" ? "cate_desc" : "Category";

            var products = from s in db.Products select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(s => s.ProductName.StartsWith(searchString));
                return View(products.ToList());
            }

            switch (sortOrder)
            {
                case "name_desc":
                    products = products.OrderByDescending(s => s.ProductName);
                    break;
                case "cate_desc":
                    products = products.OrderByDescending(s => s.Category.CategoryName);
                    break;
                case "Category":
                    products = products.OrderBy(s => s.Category.CategoryName);
                    break;
                default:
                    products = products.OrderBy(s => s.ProductName);
                    break;
            }
            return View(products.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
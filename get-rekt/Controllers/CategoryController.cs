using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace get_rekt.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index(int categoryId)
        {
            return View();
        }
    }
}
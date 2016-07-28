using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace get_rekt.Controllers
{
    public class AjaxController : Controller
    {
        // GET: Ajax
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RektVote(int videoId)
        {
            return Json(new { valid = "true", baz = "Blech" }, JsonRequestBehavior.AllowGet);
        }

    }
}
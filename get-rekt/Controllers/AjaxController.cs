using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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
            string ipaddress = new WebClient().DownloadString(@"http://icanhazip.com").Trim();

            return Json(new { valid = "true", ip = ipaddress }, JsonRequestBehavior.AllowGet);
        }
        

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace get_rekt.Controllers
{
    public class VideoController : Controller
    {
        // GET: Video
        public ActionResult Watch(int id)
        {

            return View();
        }

        public ActionResult WaitList()
        {

            return View();
        }
    }
}
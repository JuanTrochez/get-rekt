using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using get_rekt.Dao;
using get_rekt.Dao.video;
using get_rekt.Models;

namespace get_rekt.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            IVideoDao dao = FactoryDao.GetVideoDao();
            List<VideoModel> Model = dao.getAllVideoByPublication(1);
            return View(Model);
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
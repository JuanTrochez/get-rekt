using get_rekt.Dao.Rekt;
using get_rekt.Dao.video;
using get_rekt.Models;
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

            RektModel rekt = new RektDaoDb().getRektByIpAndVideoId(ipaddress, videoId);

            if (rekt == null)
            {
                rekt = new RektModel();
                rekt.Ip = ipaddress;
                rekt.Rekt = 1;
                rekt.Video_id = videoId;
                new RektDaoDb().insertRekt(rekt);
            }
            else
            {
                rekt.Rekt = (rekt.Rekt == 0) ? (byte) 1 : (byte) 0;

                new RektDaoDb().updateRekt(rekt);
            }

            return Json(new { valid = "true", data = rekt }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult PublishVideo(int videoId)
        {

            VideoModel video = new VideoDaoDb().getVideo(videoId);

            video.Published = (video.Published == 0) ? 1 : 0;
            new VideoDaoDb().updateVideo(video);

            return Json(new { valid = "true", data = video }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult DeleteVideo(int videoId)
        {
            new VideoDaoDb().deleteVideoById(videoId);

            return Json(new { valid = "true" }, JsonRequestBehavior.AllowGet);
        }


    }
}
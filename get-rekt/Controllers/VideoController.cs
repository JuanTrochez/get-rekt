using get_rekt.Dao.category;
using get_rekt.Dao.user;
using get_rekt.Models;
using System;
using System.Collections.Generic;
using System.IO;
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

        public ActionResult AddVideo()
        {
            List<CategoryModel> categories = CategoryDaoDb.getAllCategories();
            ViewBag.categories = categories;
            return View();
        }
        [HttpPost]
        public ActionResult FileUpload([Bind(Include = "title, description, videolink")]VideoModel video, HttpPostedFileBase file)
        {
            if (file != null)
            {
                string pic = System.IO.Path.GetFileName(file.FileName);
                string path = System.IO.Path.Combine(
                                       Server.MapPath("~/pictures"), pic);
                // file is uploaded
                file.SaveAs(path);

                // save the image path path to the database or you can send image
                // directly to database
                // in-case if you want to store byte[] ie. for DB
                using (MemoryStream ms = new MemoryStream())
                {
                    file.InputStream.CopyTo(ms);
                    byte[] array = ms.GetBuffer();
                }

            }
            if(video != null)
            {
                video.CategoryId = int.Parse(Request.Form["categorie"]);

                UserModel user = new UserModel();
                user.Email = Request.Form["email"];
                user.Username = Request.Form["pseudo"];

                UserDaoDb userdb = new UserDaoDb();
                video.User_id = userdb.insertUser(user);


            }
            // after successfully uploading redirect the user
            return RedirectToAction("ajouter-video", "Video");
        }
    }
}
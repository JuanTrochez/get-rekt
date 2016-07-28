using get_rekt.Dao.category;
using get_rekt.Dao.Picture;
using get_rekt.Dao.user;
using get_rekt.Dao.video;
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
            List<CategoryModel> categories = new CategoryDaoDb().getAllCategories();
            ViewBag.categories = categories;
            return View();
        }
        [HttpPost]
        public ActionResult FileUpload([Bind(Include = "title, description, videolink")]VideoModel video, HttpPostedFileBase file)
        {
            PictureModel picture = new PictureModel();
            if (file != null)
            {
                string pic = System.IO.Path.GetFileName(file.FileName);
                string path = System.IO.Path.Combine(
                                       Server.MapPath("~/pictures"), pic);
                // file is uploaded
                file.SaveAs(path);
                picture.Link = file.FileName;
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
                video.Date = DateTime.Now;

                UserDaoDb userdb = new UserDaoDb();
                UserModel user = userdb.getUser(Request.Form["email"]);

                if(user == null)
                {
                    user = new UserModel();
                    user.Email = Request.Form["email"];
                    user.Username = Request.Form["pseudo"];
                    video.User_id = userdb.insertUser(user);
                } else
                {
                    user.Username = Request.Form["pseudo"];
                    video.User_id = userdb.updateUser(user);
                }
                

                PictureDaoDb picturedb = new PictureDaoDb();
                video.PictureId = picturedb.insertPicture(picture);

                VideoDaoDb videodb = new VideoDaoDb();
                videodb.insertVideo(video);
            }
            // after successfully uploading redirect the user
            return RedirectToAction("ajouter", "Video");
        }
    }
}
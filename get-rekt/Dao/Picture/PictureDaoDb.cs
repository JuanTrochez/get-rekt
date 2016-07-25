using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using get_rekt.Models;

namespace get_rekt.Dao.Picture
{
    public class PictureDaoDb : IPictureDao
    {
        public PictureDaoDb() { }

        public PictureModel getPicture(int id)
        {
            Context contextPicture = new Context();
            PictureModel picture = contextPicture.Pictures.Where(p => p.Id == id).FirstOrDefault();
            return picture;
        }
    }
}
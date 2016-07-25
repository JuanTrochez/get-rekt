using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using get_rekt.Dao.video;
using get_rekt.Dao.user;
using get_rekt.Dao.category;
using get_rekt.Dao.Picture;
using get_rekt.Dao.Rekt;

namespace get_rekt.Dao
{
    public class FactoryDao
    {
        public static IVideoDao GetVideoDao()
        {
            return new VideoDaoDb();
        }

        public static IUserDao GetUserDao()
        {
            return new UserDaoDb();
        }

        public static IRektDao GetRektDao()
        {
            return new RektDaoDb();
        }

        public static ICategoryDao GetCategoryDao()
        {
            return new CategoryDaoDb();
        }

        public static IPictureDao GetPictureDao()
        {
            return new PictureDaoDb();
        }
        

    }
}
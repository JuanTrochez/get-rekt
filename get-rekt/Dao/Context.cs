using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;
using get_rekt.Models;

namespace get_rekt.Dao
{
    public class Context: DbContext
    {
        public Context(): base("getRekt")
        {

        }

        public DbSet<VideoModel> Videos { get; set; }

        public DbSet<RektModel> Rekts { get; set; }

        public DbSet<UserModel> Users { get; set; }

        public DbSet<CategoryModel> Categories { get; set; }

        public DbSet<PictureModel> Pictures { get; set; }
    }
}
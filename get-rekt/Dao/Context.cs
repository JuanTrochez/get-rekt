using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;
using get_rekt.Models;

namespace get_rekt.Dao.video
{
    public class Context: DbContext
    {
        public Context(): base("")
        {

        }

        public DbSet<VideoModel> Videos { get; set; }
    }
}
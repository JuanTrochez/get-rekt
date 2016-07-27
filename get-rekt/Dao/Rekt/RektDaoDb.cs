using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using get_rekt.Models;

namespace get_rekt.Dao.Rekt
{
    public class RektDaoDb : IRektDao
    {
        public RektDaoDb() { }
        public RektModel getRekt(int videoId)
        {
            Context contextRekt = new Context();

            RektModel rekt = contextRekt.Rekts.Where(v => v.Video_id == videoId).FirstOrDefault();
            throw new NotImplementedException();
        }
    }
}
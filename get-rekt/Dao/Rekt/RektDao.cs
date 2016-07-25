using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using get_rekt.Models;

namespace get_rekt.Dao.Rekt
{
    public class RektDao:IRektDao
    {
        RektModel Rekt = new RektModel();

        public RektModel getRekt(int videoId)
        {
            throw new NotImplementedException();
        }
    }
}
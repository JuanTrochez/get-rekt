using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using get_rekt.Models;

namespace get_rekt.Dao.Rekt
{
    interface IRektDao
    {
        RektModel getRekt(int videoId);
    }
}

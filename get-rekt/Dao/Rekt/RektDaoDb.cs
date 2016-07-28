using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using get_rekt.Models;
using System.Data.Entity;

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

        public void insertRekt(RektModel rekt)
        {
            Context contextRekt = new Context();
            contextRekt.Rekts.Add(rekt);
            contextRekt.SaveChanges();
        }

        public void updateRekt(RektModel rekt)
        {
            Context contextRekt = new Context();
            contextRekt.Rekts.Attach(rekt);
            contextRekt.Entry(rekt).State = EntityState.Modified;
            contextRekt.SaveChanges();
        }

        public RektModel getRektByIpAndVideoId(String ip, int Id)
        {
            Context contextRekt = new Context();
            RektModel rekt = contextRekt.Rekts.Where(v => v.Video_id == Id && v.Ip == ip).FirstOrDefault();
            
            return rekt;
        }

        public int getCountRektByVideoId(int videoId)
        {
            Context contextRekt = new Context();
            int rekts = contextRekt.Rekts.Where(v => v.Video_id == videoId && v.Rekt == 1).Count();
            return rekts;
        }

        public void deleteRektsByVideoId(int videoId)
        {
            Context contextRekt = new Context();
            List<RektModel> rekts = contextRekt.Rekts.Where(v => v.Video_id == videoId && v.Rekt == 1).ToList();

            foreach (var rekt in rekts)
            {
                RektModel rektmodel = rekt;
                contextRekt.Rekts.Attach(rektmodel);
                contextRekt.Rekts.Remove(rektmodel);
                contextRekt.SaveChanges();
            }
        }
    }
}
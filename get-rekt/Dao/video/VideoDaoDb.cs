using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using get_rekt.Models;

namespace get_rekt.Dao.video
{
    public class VideoDaoDb : IVideoDao
    {
        public VideoDaoDb() { }
        public VideoModel getVideo(int id)
        {
            Context contextVideo = new Context();

            VideoModel video = contextVideo.Videos.Where(v => v.Id == id).FirstOrDefault();

            return video;
        }
    }
}
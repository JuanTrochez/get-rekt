using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using get_rekt.Models;

namespace get_rekt.Dao.video
{
    public class VideoDao : IVideoDao
    {
        VideoModel video = new VideoModel();

        public VideoModel getVideo(int id)
        {
            throw new NotImplementedException();
        }
    }
}
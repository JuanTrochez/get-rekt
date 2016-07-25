using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
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

        public List<VideoModel> getAllVideoByPublication(int published)
        {
            Context contextVideo = new Context();

            List<VideoModel> videos = contextVideo.Videos
                .Where(v => v.Published == published)
                .ToList();

            return videos;
        }
    }
}
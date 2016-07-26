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
            List<VideoModel> listVideos = new List<VideoModel>();

            var videos = contextVideo.Videos
                .GroupJoin(
                    contextVideo.Pictures,
                    video => video.PictureId,
                    picture => picture.Id,
                    (video, picture) => new { videoResult = video, pictureObject = picture}
                )
                .Where(v => v.videoResult.Published == published);


            int i = 0;
            foreach (var video in videos)
            {
                video.videoResult.Picture = (PictureModel) video.pictureObject.ToArray().GetValue(i);
                listVideos.Add(video.videoResult);
                i++;
            }

            return listVideos;
        }
    }
}
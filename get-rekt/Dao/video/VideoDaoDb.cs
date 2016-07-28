using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using get_rekt.Models;
using System.Data.Entity;

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

        public List<VideoModel> getAllVideoByCategories(int categoryid)
        {
            Context contextVideo = new Context();
            List<VideoModel> listVideos = new List<VideoModel>();

            var videos = contextVideo.Videos
                .Join(
                    contextVideo.Pictures,
                    video => video.PictureId,
                    picture => picture.Id,
                    (video, picture) => new { videoResult = video, pictureObject = picture }
                )
                .Join(
                     contextVideo.Categories,
                     video => video.videoResult.CategoryId,
                     category => category.Id,
                     (video, category) => new { videoResult = video, category = category }
                     )
                .Join(
                    contextVideo.Users,
                    video => video.videoResult.videoResult.User_id,
                    user => user.Id,
                    (video, user) => new { videoResult = video, user = user }
                    )
                .Where(v => v.videoResult.videoResult.videoResult.CategoryId == categoryid);


            int i = 0;
            foreach (var video in videos)
            {
                VideoModel v = video.videoResult.videoResult.videoResult;
                listVideos.Add(v);
                i++;
            }
            return listVideos;
        }

        public List<VideoModel> getAllVideoByPublication(int published)
        {
            Context contextVideo = new Context();
            List<VideoModel> listVideos = new List<VideoModel>();

            var videos = contextVideo.Videos
                .Join(
                    contextVideo.Pictures,
                    video => video.PictureId,
                    picture => picture.Id,
                    (video, picture) => new { videoResult = video, pictureObject = picture}
                )
                .Join(
                     contextVideo.Categories,
                     video => video.videoResult.CategoryId,
                     category => category.Id,
                     (video, category) => new { videoResult = video, category = category }
                     )
                .Join(
                    contextVideo.Users,
                    video => video.videoResult.videoResult.User_id,
                    user => user.Id,
                    (video, user) => new { videoResult = video, user = user }
                    )
                .Where(v => v.videoResult.videoResult.videoResult.Published == published);


            int i = 0;
            foreach (var video in videos)
            {
                VideoModel v = video.videoResult.videoResult.videoResult;
                listVideos.Add(v);
                i++;
            }

            return listVideos;
        }

        public void insertVideo(VideoModel video)
        {
            Context contextVideo = new Context();
            contextVideo.Videos.Add(video);
            contextVideo.SaveChanges();
        }

        public void updateVideo(VideoModel video)
        {
            Context contextVideo = new Context();
            contextVideo.Videos.Attach(video);
            contextVideo.Entry(video).State = EntityState.Modified;
            contextVideo.SaveChanges();
        }

        public void deleteVideoById(int id)
        {
            Context contextVideo = new Context();
            VideoModel video = getVideo(id);
            contextVideo.Videos.Attach(video);
            contextVideo.Videos.Remove(video);
            contextVideo.SaveChanges();
        }
    }
}
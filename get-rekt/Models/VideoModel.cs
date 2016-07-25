using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace get_rekt.Models
{
    [Table("Video")]
    public class VideoModel
    {
        private int id;
        private String title;
        private String description;
        private int published;
        private String videoLink;
        private DateTime date;
        private int userId;
        private int categoryId;
        private int pictureId;

        [Key]
        [Column("id")]
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        [Column("title")]
        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        [Column("description")]
        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        [Column("published")]
        public int Published
        {
            get
            {
                return published;
            }

            set
            {
                published = value;
            }
        }

        [Column("video_link")]
        public string VideoLink
        {
            get
            {
                return videoLink;
            }

            set
            {
                videoLink = value;
            }
        }

        [Column("date")]
        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        [Column("user_id")]
        public int UserId
        {
            get
            {
                return userId;
            }

            set
            {
                userId = value;
            }
        }

        [Column("category_id")]
        public int CategoryId
        {
            get
            {
                return categoryId;
            }

            set
            {
                categoryId = value;
            }
        }

        [Column("picture_id")]
        public int PictureId
        {
            get
            {
                return pictureId;
            }

            set
            {
                pictureId = value;
            }
        }
    }
}
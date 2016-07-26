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
        private UserModel userId;
        private CategoryModel categoryId;
        private PictureModel pictureId;

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

        [ForeignKey("user_id")]
        public UserModel UserId
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

        [ForeignKey("category_id")]
        public CategoryModel CategoryId
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
        
        [ForeignKey("picture_id")]
        public PictureModel PictureId
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
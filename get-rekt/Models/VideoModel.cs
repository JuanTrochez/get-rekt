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
        private int user_id;
        private UserModel user;
        private int category_id;
        private CategoryModel category;
        private PictureModel picture;
        private int picture_id;

        [Key]
        [Column("Id")]
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

        [ForeignKey("User")]
        [Column("user_id")]
        public int User_id
        {
            get
            {
                return user_id;
            }

            set
            {
                user_id = value;
            }
        }

        public UserModel User
        {
            get
            {
                return user;
            }

            set
            {
                user = value;
            }
        }

        [ForeignKey("Category")]
        [Column("category_id")]
        public int CategoryId
        {
            get
            {
                return category_id;
            }

            set
            {
                category_id = value;
            }
        }
        
        public CategoryModel Category
        {
            get
            {
                return category;
            }

            set
            {
                category = value;
            }
        }
        
        public PictureModel Picture
        {
            get
            {
                return picture;
            }

            set
            {
                picture = value;
            }
        }

        [ForeignKey("Picture")]
        [Column("picture_id")]
        public int PictureId
        {
            get
            {
                return picture_id;
            }

            set
            {
                picture_id = value;
            }
        }
        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace get_rekt.Models
{
    public class VideoModel
    {
        private int id;
        private String title;
        private String description;
        private bool published;
        private String videoLink;
        private DateTime date;
        private int userId;
        private int categoryId;
        private int pictureId;

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

        public bool Published
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
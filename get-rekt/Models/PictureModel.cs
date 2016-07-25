using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace get_rekt.Models
{
    public class PictureModel
    {
        private int id;
        private String link;

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

        public string Link
        {
            get
            {
                return link;
            }

            set
            {
                link = value;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace get_rekt.Models
{
    public class RektModel
    {
        private int id;
        private int videoId;
        private bool rekt;
        private bool notRekt;
        private String ip;

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

        public int VideoId
        {
            get
            {
                return videoId;
            }

            set
            {
                videoId = value;
            }
        }

        public bool Rekt
        {
            get
            {
                return rekt;
            }

            set
            {
                rekt = value;
            }
        }

        public bool NotRekt
        {
            get
            {
                return notRekt;
            }

            set
            {
                notRekt = value;
            }
        }

        public string Ip
        {
            get
            {
                return ip;
            }

            set
            {
                ip = value;
            }
        }
    }
}
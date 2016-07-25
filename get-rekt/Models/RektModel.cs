using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace get_rekt.Models
{
    [Table("Rekt")]
    public class RektModel
    {
        private int id;
        private int videoId;
        private bool rekt;
        private bool notRekt;
        private String ip;

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

        [Column("video_id")]
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

        [Column("rekt")]
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

        [Column("not_rekt")]
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

        [Column("ip")]
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
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
        private int video_id;
        private VideoModel video;
        private byte rekt;
        private byte notRekt;
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

        [ForeignKey("Video")]
        public int Video_id
        {
            get
            {
                return video_id;
            }

            set
            {
                video_id = value;
            }
        }

        public VideoModel Video
        {
            get
            {
                return video;
            }

            set
            {
                video = value;
            }
        }

        [Column("rekt")]
        public byte Rekt
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
        public byte NotRekt
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
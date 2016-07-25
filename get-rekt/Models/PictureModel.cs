using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace get_rekt.Models
{
    [Table("Picture")]
    public class PictureModel
    {
        private int id;
        private String link;

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

        [Column("link")]
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
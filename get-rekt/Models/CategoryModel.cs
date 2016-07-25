using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace get_rekt.Models
{
    public class CategoryModel
    {
        private int id;
        private String name;

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

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
    }
}
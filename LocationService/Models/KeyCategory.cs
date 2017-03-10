using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocationService.Models
{
    public class KeyCategory
    {
        private int idKeyCategory;
        private String nameKeyCategory;
        private int idCateggory;

        public int IdKeyCategory
        {
            get
            {
                return idKeyCategory;
            }

            set
            {
                idKeyCategory = value;
            }
        }

        public string NameKeyCategory
        {
            get
            {
                return nameKeyCategory;
            }

            set
            {
                nameKeyCategory = value;
            }
        }

        public int IdCateggory
        {
            get
            {
                return idCateggory;
            }

            set
            {
                idCateggory = value;
            }
        }
    }
}
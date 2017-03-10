using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocationService.Models
{
    public class KeyPlace
    {
        private int idKeyPlace;
        private String nameKeyPlace;
        private int idPlace;

        public int IdKeyPlace
        {
            get
            {
                return idKeyPlace;
            }

            set
            {
                idKeyPlace = value;
            }
        }

        public string NameKeyPlace
        {
            get
            {
                return nameKeyPlace;
            }

            set
            {
                nameKeyPlace = value;
            }
        }

        public int IdPlace
        {
            get
            {
                return idPlace;
            }

            set
            {
                idPlace = value;
            }
        }
    }
}
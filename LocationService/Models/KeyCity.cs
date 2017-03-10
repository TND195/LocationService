using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocationService.Models
{
    public class KeyCity
    {
        private int idKeyCity;
        private String nameKeyCity;
        private int idCity;

        public int IdKeyCity
        {
            get
            {
                return idKeyCity;
            }

            set
            {
                idKeyCity = value;
            }
        }

        public string NameKeyCity
        {
            get
            {
                return nameKeyCity;
            }

            set
            {
                nameKeyCity = value;
            }
        }

        public int IdCity
        {
            get
            {
                return idCity;
            }

            set
            {
                idCity = value;
            }
        }
    }
}
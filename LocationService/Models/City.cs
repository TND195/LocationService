using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocationService.Models
{
    public class City
    {
        private int idCity;
        private String nameCity;

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

        public string NameCity
        {
            get
            {
                return nameCity;
            }

            set
            {
                nameCity = value;
            }
        }
    }
}
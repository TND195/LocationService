using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocationService.Models
{
    public class District
    {
        private int idDistrict;
        private String nameDistrict;

        public int IdDistrict
        {
            get
            {
                return idDistrict;
            }

            set
            {
                idDistrict = value;
            }
        }

        public string NameDistrict
        {
            get
            {
                return nameDistrict;
            }

            set
            {
                nameDistrict = value;
            }
        }
    }
}
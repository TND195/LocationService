using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocationService.Models
{
    public class KeyDistrict
    {
        private int idKeyDistrict;
        private String nameKeyDistrict;
        private int idDistrict;

        public int IdKeyDistrict
        {
            get
            {
                return idKeyDistrict;
            }

            set
            {
                idKeyDistrict = value;
            }
        }

        public string NameKeyDistrict
        {
            get
            {
                return nameKeyDistrict;
            }

            set
            {
                nameKeyDistrict = value;
            }
        }

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
    }
}
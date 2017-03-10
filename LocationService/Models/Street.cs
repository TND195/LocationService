using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocationService.Models
{
    public class Street
    {
        private int idStreet;
        private String nameStreet;

        public int IdStreet
        {
            get
            {
                return idStreet;
            }

            set
            {
                idStreet = value;
            }
        }

        public string NameStreet
        {
            get
            {
                return nameStreet;
            }

            set
            {
                nameStreet = value;
            }
        }
    }
}
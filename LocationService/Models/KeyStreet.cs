using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocationService.Models
{
    public class KeyStreet
    {
        private int idKeyStreet;
        private String nameStreet;
        private int idStreet;

        public int IdKeyStreet
        {
            get
            {
                return idKeyStreet;
            }

            set
            {
                idKeyStreet = value;
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
    }
}
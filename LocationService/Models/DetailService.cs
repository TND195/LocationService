using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocationService.Models
{
    public class DetailService
    {
        private int idPlace;
        private int idDetailService;
        private string name;
        private String price;
        private string note;

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

        public int IdDetailService
        {
            get
            {
                return idDetailService;
            }

            set
            {
                idDetailService = value;
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

     

        public string Note
        {
            get
            {
                return note;
            }

            set
            {
                note = value;
            }
        }

        public string Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }
    }
}
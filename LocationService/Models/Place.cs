using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocationService.Models
{
    public class Place
    {
        private int idPlace;
        private String namePlace;
        private String category;
        private String number;
        private String street;
        private String ward;
        private String district;
        private String city;
        private double longitude;
        private double latitude;
        private String note;
        private String imagecategory;
        private float scores;

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

        public string NamePlace
        {
            get
            {
                return namePlace;
            }

            set
            {
                namePlace = value;
            }
        }

        public string Category
        {
            get
            {
                return category;
            }

            set
            {
                category = value;
            }
        }

        public string Number
        {
            get
            {
                return number;
            }

            set
            {
                number = value;
            }
        }

        public string Street
        {
            get
            {
                return street;
            }

            set
            {
                street = value;
            }
        }

        public string Ward
        {
            get
            {
                return ward;
            }

            set
            {
                ward = value;
            }
        }

        public string District
        {
            get
            {
                return district;
            }

            set
            {
                district = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }

        public double Longitude
        {
            get
            {
                return longitude;
            }

            set
            {
                longitude = value;
            }
        }

        public double Latitude
        {
            get
            {
                return latitude;
            }

            set
            {
                latitude = value;
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

        public float Scores
        {
            get
            {
                return scores;
            }

            set
            {
                scores = value;
            }
        }

        public string Imagecategory
        {
            get
            {
                return imagecategory;
            }

            set
            {
                imagecategory = value;
            }
        }
    }
}
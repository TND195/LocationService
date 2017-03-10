using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocationService.Models
{
    public class Rates
    {
        private String id;
        private int idPlace;
        private float scores;

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
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
    }
}
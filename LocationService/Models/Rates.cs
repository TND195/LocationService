using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocationService.Models
{
    public class Rates
    {
        private String idUser;
        private int idPlace;
        private float scores;
        private String content;
        private String time;
        private String name;
        private String avatar;
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

        public string IdUser
        {
            get
            {
                return idUser;
            }

            set
            {
                idUser = value;
            }
        }

        public string Content
        {
            get
            {
                return content;
            }

            set
            {
                content = value;
            }
        }

        public string Time
        {
            get
            {
                return time;
            }

            set
            {
                time = value;
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

        public string Avatar
        {
            get
            {
                return avatar;
            }

            set
            {
                avatar = value;
            }
        }
    }
}
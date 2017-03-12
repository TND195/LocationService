using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocationService.Models
{
    public class Comment
    {
        private int idComment;
        private String idUser;
        private String content;
        private String time;
        private int idPlace;
        private String name;
        private String avatar;

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

        public String Time
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

        public int IdComment
        {
            get
            {
                return idComment;
            }

            set
            {
                idComment = value;
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
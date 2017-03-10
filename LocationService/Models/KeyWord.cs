using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocationService.Models
{
    public class KeyWord
    {
        private int id;
        private String strKeyFirst;
        private String strKeyLast;

        public int Id
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

        public string StrKeyFirst
        {
            get
            {
                return strKeyFirst;
            }

            set
            {
                strKeyFirst = value;
            }
        }

        public string StrKeyLast
        {
            get
            {
                return strKeyLast;
            }

            set
            {
                strKeyLast = value;
            }
        }
    }
}
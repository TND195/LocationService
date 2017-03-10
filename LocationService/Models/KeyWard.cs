using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocationService.Models
{
    public class KeyWard
    {
        private int idKeyWard;
        private String nameKeyWard;
        private int idWard;

        public int IdKeyWard
        {
            get
            {
                return idKeyWard;
            }

            set
            {
                idKeyWard = value;
            }
        }

        public string NameKeyWard
        {
            get
            {
                return nameKeyWard;
            }

            set
            {
                nameKeyWard = value;
            }
        }

        public int IdWard
        {
            get
            {
                return idWard;
            }

            set
            {
                idWard = value;
            }
        }
    }
}
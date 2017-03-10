using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocationService.Models
{
    public class Ward
    {
        private int idWard;
        private String nameWard;

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

        public string NameWard
        {
            get
            {
                return nameWard;
            }

            set
            {
                nameWard = value;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FroggyRestServer.Models
{
    public class Address
    {
        public String Street { get; set; }
        public int StreetNumber { get; set; }

        public int PostCode { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public String Country { get; set; }


    }
}
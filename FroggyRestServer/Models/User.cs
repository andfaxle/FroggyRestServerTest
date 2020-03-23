using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FroggyRestServer.Models
{
    public class User
    {
        public String Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String PhoneNumber { get; set; }

        public Date Birthdate { get; set; }
        public DateInterval OperationalReadiness { get; set; }

        public Address Address { get; set; }
        public List<Fence> AssignedFences { get; set; }


    }
}
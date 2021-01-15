using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogSpot.Models.Parameters
{
    public struct PramUserInfo
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DisplayName { get; set; }
        public DateTime BirthDay { get; set; }
        public string Nationality { get; set; }
        public bool Freelance { get; set; }
        public string City { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public string SocialNetWork { get; set; }
        public string Languages { get; set; }
    }
}
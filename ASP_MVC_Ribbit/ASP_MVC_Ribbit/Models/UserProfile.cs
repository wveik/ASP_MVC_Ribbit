using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_MVC_Ribbit.Models
{
    public class UserProfile
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
        public string WebsiteUrl { get; set; }
    }
}
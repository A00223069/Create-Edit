using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace PublicProfiler.Models
{
    public class Social
    {
        public int SocialId { get; set; }
        public string Website { get; set; }
        public string SocialMediaURL { get; set; }
        public DateTime ActiveSince { get; set; }

        //Relationship Properties
        public int UserId { get; set; } // This will detect the relationship - Like a foreign key in the datatbase
        public User User { get; set; } //navigation property - We can navigate to the User from here
    }
}

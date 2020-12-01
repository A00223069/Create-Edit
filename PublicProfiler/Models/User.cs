using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace PublicProfiler.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string RealName { get; set; }
        public string Alias { get; set; }
        public DateTime Birthday { get; set; }

        //Relationship Properties
        //Here we have related 'User' to 'Social' class - A user can have multiple social media links
        [JsonIgnore]
        public ICollection<Social> Socials { get;  set; } 

    }
}

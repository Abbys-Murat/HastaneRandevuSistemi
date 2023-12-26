using Microsoft.AspNetCore.Identity;
using System.Diagnostics;

namespace proje.Models
{
    public class AppUser 
    {
        public int Pace { get; set; }

        public int? mileage { get; set; }


        
        public Address? Adresss { get; set; }

        public ICollection<Club> Clubs { get; set; }
        public ICollection<Race> Races { get; set; }

    }
}

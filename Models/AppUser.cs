using System.ComponentModel.DataAnnotations;
namespace proje.Models
{
    public class AppUser
    {
        [Key]

        public string Id { get; set; }
        


        public Address? Adresss { get; set; }

        public ICollection<Polikinlik> Polikinliks { get; set; }
        public ICollection<Doctor> Doctors { get; set; }    
            
        

     }
}

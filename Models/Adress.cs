using System.ComponentModel.DataAnnotations;
namespace proje.Models
{
    public class Address
    {
        [Key]

        public int Id { get; set; }

        public string Name { get; set; }
        public string City { get; set; }

        public string State { get; set; }
        public string Street { get; set; }
    }
}

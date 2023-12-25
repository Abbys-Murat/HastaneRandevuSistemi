namespace proje.Models
{
    public class Adress
    {
        [Key]

        public int Id { get; set; }

        public string Name { get; set; }
        public string City { get; set; }

        public string State { get; set; }
    }
}

namespace proje.Data
{
    public class ApplicationDBContext : DBContext



    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) :base(options)
        { 
            
        
        
        
        }
        public DBSet<Race> Races { get; set; }

        public DBSet<Club> Clubs { get; set; }
        
        public DBSet<Adresss> Addresses{ get; set; }








    }


}

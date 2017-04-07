using ShareEconomy.Classes;
using System.Data.Entity;


namespace ShareEconomy.DomainModel
{
    public class AdvertContext : DbContext
    {
        public DbSet<Advert> Adverts { get; set; }
    }
}

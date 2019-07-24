


namespace AppTeachSolu.Backend.Models
{

    using Domain.Models;

    public class LocalDataContext : DataContext
    {
        public System.Data.Entity.DbSet<AppTeachSolu.Common.Models.Proyect> Proyects { get; set; }

        public System.Data.Entity.DbSet<AppTeachSolu.Common.Models.Services> Services { get; set; }
    }
}
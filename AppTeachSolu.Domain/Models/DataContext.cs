using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTeachSolu.Domain.Models
{
    public class DataContext : DbContext
    {

        public DataContext() :  base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<AppTeachSolu.Common.Models.Services> Services { get; set; }
    }
}

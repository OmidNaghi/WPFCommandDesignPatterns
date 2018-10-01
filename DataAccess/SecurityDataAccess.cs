using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityDataAccess
{
    public class SecurityDataAccessContext : DbContext
    {
        public SecurityDataAccessContext() : base("DefaultConnection")
        {

        }

        public DbSet<Users> Users { get; set; }

    }
}

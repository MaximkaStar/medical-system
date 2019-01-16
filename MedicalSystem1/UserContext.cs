using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalSystem1
{
    public class UserContext : DbContext
    {
        public UserContext() : base("DbConnection") {}

        public DbSet<Doctor> doctors { get; set; }
    }
}

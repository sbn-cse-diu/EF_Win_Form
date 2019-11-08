using DataModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class SchoolDBContext : DbContext
    {
        public SchoolDBContext() : base("SchoolDB")
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Dataa;

namespace DataAccess
{
    public class CodeContext : DbContext
    {
        public CodeContext() { }
        public CodeContext(string connString) : base(connString) { }

        public DbSet<Car> Cars { get; set; }
    }

    internal class Program { static void Main(string[] args) { } }
}

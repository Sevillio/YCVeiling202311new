using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SXDatalaag
{
    public class DatabaseVeilingContext:DbContext
    {
        public DatabaseVeilingContext(DbContextOptions options): base(options) { }
        public DbSet<Veiling> Veiling { get; set; }
    }
}

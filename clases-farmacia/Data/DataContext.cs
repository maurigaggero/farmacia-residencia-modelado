using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace clases_farmacia
{
    public class DataContext : DbContext
    {
        public DataContext()
        {

        }

        public DbSet<Medicamento> Medicamentos {get;set;}
        public DbSet<Inventario> Inventario { get; set; }
    }
}

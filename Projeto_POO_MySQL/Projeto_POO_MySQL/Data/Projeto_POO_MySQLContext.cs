using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Projeto_POO_MySQL.Models
{
    public class Projeto_POO_MySQLContext : DbContext
    {
        public Projeto_POO_MySQLContext (DbContextOptions<Projeto_POO_MySQLContext> options)
            : base(options)
        {
        }

        public DbSet<Projeto_POO_MySQL.Models.Departament> Departament { get; set; }
    }
}

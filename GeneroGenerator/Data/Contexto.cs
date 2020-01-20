using GeneroGenerator.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneroGenerator.Data
{
    public class Contexto : DbContext
    {

        public DbSet<Generos> Genero { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server = (local); Database= Test1_Db; Trusted_Connection = True; ");

        }
    }
}

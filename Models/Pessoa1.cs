using Microsoft.EntityFrameworkCore;

namespace Banco_de_dados_Controllers.Models
{
    public class Contexto : DbContext 
    {
        public Contexto() 
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Your Connection String");
        }

        public DbSet<Pessoa> Pessoa { get; set; }
    }
    
    }


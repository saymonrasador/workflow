// Nesse arquivo é criado a classe ContextoBancoDados no qual dentro dela é mencionado as tabelas existentes
using Microsoft.EntityFrameworkCore;

namespace gcodb
{
    public class ContextoBancoDados : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql(Environment.GetEnvironmentVariable("CONNECTION_STRING"));   //CONNECTION_STRING pega o endereço do SUPABASE
        }

        // Exemplo de criação de tabela chamada "Cliente"
        public DbSet<Cliente> clientes { get; set; }
    }
}
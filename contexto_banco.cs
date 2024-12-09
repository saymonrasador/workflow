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
        // public DbSet<Cliente> clientes { get; set; }

        // após, crie um arquivo tabelas/clientes.cs
        // nesse arquivo clientes.cs voce cria de fato a tabela

        // public class Cliente
        // {
        // public int Id { get; set; }
        // public string Nome { get; set; }
        // public string Email { get; set; }
        // public DateTime DataCadastro { get; set; }
        // }
    }
}
// Nesse arquivo é aplicado um comando que faz com que o Entity Framework aplique todas as migrações pendentes ao banco de dados.
using System;
using Microsoft.EntityFrameworkCore;

// Mensagem de verificação para detectar erros
Console.WriteLine("Using connection string: " + connectionString);

// Comando para aplicar a migração
new ContextoBancoDados().Database.Migrate();  


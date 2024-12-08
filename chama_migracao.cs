// Nesse arquivo é aplicado um comando que faz com que o Entity Framework aplique todas as migrações pendentes ao banco de dados.
using System;
using Microsoft.EntityFrameworkCore;

//Console.WriteLine("Hello, GCO");                // comando teste
new ContextoBancoDados().Database.Migrate();    // comando para aplicar migrações


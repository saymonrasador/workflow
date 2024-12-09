// Nesse arquivo é usado o arquivo contexto_banco.cs para criar uma Migração
using gcodb;        // gcodb foi definido no comando "namespace gcodb" em contexto_banco.cs
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, GCO");
// Comando para aplicar a migração
new ContextoBancoDados().Database.Migrate






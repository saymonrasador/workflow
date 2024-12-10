# **CI/CD Pipeline para Sistema Web com Banco de Dados**

Este repositório contém a configuração de pipelines para um sistema web simples com dois ambientes distintos, integrados com bancos de dados e deploy automatizado. 

O foco principal deste projeto é demonstrar a implementação de **CI/CD** para diferentes branches (`main` e `develop`) com migrações de banco de dados e sites hospedados no Azure Static Web Apps.

---

## **Estrutura do Projeto**

### **1. Pastas Principais**

- **`.git/workflows`**: Contém as pipelines para a branch main e develop
- **`web/index.html`**: Arquivo estático de demonstração.
- **`pipeline.csproj`**: Arquivo de configuração do projeto .NET.
- **`Program.cs`**: Código base para executar a migração.
- **`contexto_banco.cs`**: Configurações da conexão com o banco de dados através de secrets do GitHub
- **`bin`**: Pasta gerada no processo de Migração
- **`Migrations`**: Pasta gerada no processo de Migração
- **`obj`**: Pasta gerada no processo de Migração

---

### **2. Bancos de Dados**
- Dois bancos de dados PostgreSQL hospedados no **Supabase**:
  - **Banco `develop`:** Usado para o ambiente de desenvolvimento (branch `develop`).
  - **Banco `main`:** Usado para o ambiente de produção (branch `main`).
Os bancos de dados possuem controle de migração usando o **Entity Framework Core**.

---

### **3. Configuração de CI/CD**

- **Branch `develop`:**
  - Atualização contínua a cada **push** ou **pull request**.
  - Deploy do site no Azure Static Web Apps.
  - Aplicação das migrações de banco de dados no banco 'develop'

- **Branch `main`:**
  - Atualização agendada para **21:00 todos os dias**.
  - Deploy do site no Azure Static Web Apps.
  - Aplicação das migrações de banco de dados no banco 'main'

Os workflows do GitHub Actions gerenciam esses processos automaticamente.

---

## **Configuração**

### **Variáveis de Ambiente**
Certifique-se de configurar as variáveis de ambiente como secrets no GitHub:
- **Conexão com bancos de dados:**
  - `DEVELOP_DB_URL`: String de conexão para o banco 'develop'.
  - `MAIN_DB_URL`: String de conexão para o banco 'main'.
- **Tokens do Azure Static Web Apps:**
  - `AZURE_STATIC_WEB_APPS_API_TOKEN_WHITE_STONE_0B4E40310`: Token para o site do ambiente `develop`.
  - `AZURE_STATIC_WEB_APPS_API_TOKEN_LEMON_CLIFF_0D55B3310`: Token para o site do ambiente `main`.

---

### **Banco de Dados**
#### Estrutura e Migração:
- A migração de banco de dados é gerenciada pelo **Entity Framework Core**.
- As migrações aplicadas são registradas na tabela interna `__EFMigrationsHistory`.

#### Comandos Úteis:
1. **Criar uma nova migração:**
   ```bash
   dotnet ef migrations add NomeDaMigracao
2. **Aplicar migrações:**
  As migrações são aplicadas automaticamente no banco de dados, pois foi definido na pipeline do workflow

---

### **Ferramentas Utilizadas**
1. **Frameworks e Pacotes:**
- .NET 8.0
- Entity Framework Core 8.0.2
- Npgsql para PostgreSQL
2. **Ferramentas de CI/CD:**
- GitHub Actions
- Azure Static Web Apps
- Supabase PostgreSQL

---

### **Como Gerar uma Migração**
1. **Crie ou modifique uma tabela**
   EX: Clientes.cs
   ```bash
   public class Cliente
    {
    public int Id { get; set; }
    public string Nome { get; set; }
    }
3. **Adicione a tabela no contexto_banco.cs**
   ```bash
   public DbSet<Cliente> clientes { get; set; }
4. **Gere uma Migração**
   ```bash
   dotnet ef migrations add NomeDaMigracao
5. **Agora espere a pipeline executar no GitHub Actions até atualizar o banco de dados do Supabase**
   No Azure o deploy será realizado automaticamente com base nos workflows configurados.
   

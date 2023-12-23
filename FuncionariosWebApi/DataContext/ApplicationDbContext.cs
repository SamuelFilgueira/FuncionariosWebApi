using FuncionariosWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FuncionariosWebApi.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }

        public DbSet<FuncionarioModel> Funcionarios {  get; set; }
    }
}

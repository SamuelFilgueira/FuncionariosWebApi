using FuncionariosWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FuncionariosWebApi.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }

        DbSet<FuncionarioModel> Funcionarios {  get; set; }
    }
}

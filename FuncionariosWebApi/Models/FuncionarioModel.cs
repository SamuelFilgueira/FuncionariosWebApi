using FuncionariosWebApi.Enums;
using System.ComponentModel.DataAnnotations;

namespace FuncionariosWebApi.Models
{
    public class FuncionarioModel
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Sobrenome { get; set; } = string.Empty;
        public DepartamentoEnum Departanemto { get; set; }
        public TurnoEnum Turno { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataDeCriacao { get; set; } = DateTime.Now.ToLocalTime();
        public DateTime DataDeAlteracao { get; set; } = DateTime.Now.ToLocalTime();
    }
}

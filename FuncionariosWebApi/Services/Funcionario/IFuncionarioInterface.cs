using FuncionariosWebApi.Models;

namespace FuncionariosWebApi.Services.Funcionario
{
    public interface IFuncionarioInterface
    {
        Task<ServiceResponse<List<FuncionarioModel>>> GetFuncionarios(); 
        Task<ServiceResponse<List<FuncionarioModel>>> CreateFuncionario(FuncionarioModel novoFuncionario);
        Task<ServiceResponse<List<FuncionarioModel>>> DeleteFuncionario(int id);
        Task<ServiceResponse<List<FuncionarioModel>>> UpdateFuncionario(FuncionarioModel funcionarioAtualizado);
        Task<ServiceResponse<List<FuncionarioModel>>> InativaFuncionario(int id);
        Task<ServiceResponse<FuncionarioModel>> GetFuncionarioById(int id);


    }
}

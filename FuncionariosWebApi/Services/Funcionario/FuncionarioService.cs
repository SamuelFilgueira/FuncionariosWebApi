﻿using FuncionariosWebApi.DataContext;
using FuncionariosWebApi.Models;
using Microsoft.EntityFrameworkCore;


namespace FuncionariosWebApi.Services.Funcionario
{
    public class FuncionarioService : IFuncionarioInterface
    {
        private readonly ApplicationDbContext _context;
        public FuncionarioService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<FuncionarioModel>>> CreateFuncionario(FuncionarioModel novoFuncionario)
        {
            ServiceResponse<List<FuncionarioModel>> serviceResponse = new ServiceResponse<List<FuncionarioModel>>(); 
            
            try
            {
                if (novoFuncionario != null)
                {
                    _context.Funcionarios.Add(novoFuncionario);
                    await _context.SaveChangesAsync();

                    serviceResponse.Dados = _context.Funcionarios.ToList();
                }
                else
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Informar os dados!";
                    serviceResponse.Sucesso = false;
                    return serviceResponse;
                }


            }
            catch(Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso =false;
            }
            return serviceResponse;
        }

        public Task<ServiceResponse<List<FuncionarioModel>>> DeleteFuncionario(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<FuncionarioModel>> GetFuncionarioById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<List<FuncionarioModel>>> GetFuncionarios()
        {
            ServiceResponse<List<FuncionarioModel>> serviceResponse = new ServiceResponse<List<FuncionarioModel>>();

            try
            {
                if(_context.Funcionarios.ToList().Count != 0)
                {
                    serviceResponse.Dados = await _context.Funcionarios.ToListAsync();
                }else
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Sucesso=false;
                    serviceResponse.Mensagem = "Nenhum dado encontrado!";
                }
            }catch(Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }
            return serviceResponse;
        }

        public Task<ServiceResponse<List<FuncionarioModel>>> InativaFuncionario(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<FuncionarioModel>>> UpdateFuncionario(FuncionarioModel funcionarioAtualizado)
        {
            throw new NotImplementedException();
        }
    }
}

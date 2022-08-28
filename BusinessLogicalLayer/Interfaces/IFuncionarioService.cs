using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Interfaces
{
    public interface IFuncionarioService
    {
        Response Insert(Funcionario funcionario);
        Response Update(Funcionario funcionario);
        Response Delete(Funcionario funcionario);
        DataResponse<Funcionario> GetAll();
        SingleResponse<Funcionario> GetById(int id);
        Task<SingleResponse<Funcionario>> GetLogin(Funcionario funcionario);
    }
}

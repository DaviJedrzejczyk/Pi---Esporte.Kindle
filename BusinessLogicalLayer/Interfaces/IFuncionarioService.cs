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
        Task<Response> Insert(Funcionario funcionario);
        Task<Response> Update(Funcionario funcionario);
        Task<Response> Delete(Funcionario funcionario);
        Task<DataResponse<Funcionario>> GetAll();
        Task<SingleResponse<Funcionario>> GetById(Funcionario funcionario);
        Task<SingleResponse<int>> GetLogin(Funcionario funcionario);
    }
}

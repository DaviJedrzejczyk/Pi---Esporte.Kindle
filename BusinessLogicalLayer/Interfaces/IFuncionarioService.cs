using Entities;
using Shared.DataResponses;
using Shared.Responses;
using Shared.SingleResponses;
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
    }
}

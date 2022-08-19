using Entities;
using Shared.DataResponses;
using Shared.Responses;
using Shared.SingleResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IFuncionarioDALService
    {
        Response Insert(Funcionario funcionario);
        Response Update(Funcionario funcionario);
        Response Delete(Funcionario funcionario);
        DataResponse<Funcionario> GetAll();
        SingleResponse<Funcionario> GetById(int id);
    }
}

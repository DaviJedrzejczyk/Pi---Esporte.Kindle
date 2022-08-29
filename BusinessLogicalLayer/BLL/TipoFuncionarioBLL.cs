using BusinessLogicalLayer.Interfaces;
using DataAccessLayer.Interfaces;
using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.BLL
{
    public class TipoFuncionarioBLL : ITipoFuncionarioService
    {
        private readonly ITipoFuncionarioDALService tipoFuncionarioDAL;
        public TipoFuncionarioBLL(ITipoFuncionarioDALService tipoFuncionarioDAL)
        {
            this.tipoFuncionarioDAL = tipoFuncionarioDAL;
        }

        public async Task<DataResponse<TipoFuncionario>> GetAllTipo()
        {
            return await tipoFuncionarioDAL.GetAllTipos();
        }
    }
}

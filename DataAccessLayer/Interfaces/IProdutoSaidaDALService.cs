﻿using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IProdutoSaidaDALService
    {
        Task<Response> Insert(ProdutoSaida produto);
        Task<DataResponse<ProdutoSaidaView>> GetAllBySaidaID(int id);
    }
}

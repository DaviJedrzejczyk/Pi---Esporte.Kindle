﻿using Entities;
using Entities.Enums;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IClienteDALService
    {
        Response Insert(Cliente cliente);
        Response Update(Cliente cliente);
        Response Delete(int cliente);
        DataResponse<Cliente> GetAll();
        SingleResponse<Cliente> GetById(int id);
        SingleResponse<Cliente> GetByCpf(string cpf);
    }
}



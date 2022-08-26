using DataAccessLayer.Interfaces;
using Entities;
using Microsoft.EntityFrameworkCore;
using Shared.SingleResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Implements
{
    public class LoginDAL : ILoginDALService
    {
        private readonly EsporteDB _esporte;
        public LoginDAL(EsporteDB esporte)
        {
            _esporte = esporte;
        }

        public async Task<SingleResponse<int>> GetLogin(Login login)
        {
            try
            {
                int singleResponse = await _esporte.Logins.Where(c => c.Email == login.Email && c.Senha == login.Senha).CountAsync();
                return SingleResponseFactory<int>.CreateSuccessSingleResponse(singleResponse);
            }
            catch (Exception ex)
            {
                return SingleResponseFactory<int>.CreateFailureSingleResponse(ex);    
            }
        }
    }
}

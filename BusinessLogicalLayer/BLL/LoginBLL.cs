using BusinessLogicalLayer.Extensions;
using BusinessLogicalLayer.Interfaces;
using BusinessLogicalLayer.Validator.Logins;
using DataAccessLayer.Interfaces;
using Entities;
using Shared.Responses;
using Shared.SingleResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.BLL
{
    public class LoginBLL : ILoginService
    {
        private readonly ILoginDALService _loginDAL;

        public LoginBLL(ILoginDALService loginDAL)
        {
            _loginDAL = loginDAL;
        }

        public async Task<SingleResponse<int>> GetLogin(Login login)
        {
            LoginEntradaValidator validationRules = new();
            Response response = validationRules.Validate(login).ToResponse();
            if (!response.HasSuccess)
            {
                return (SingleResponse<int>)response;
            }
            return await _loginDAL.GetLogin(login);
        }
    }
}

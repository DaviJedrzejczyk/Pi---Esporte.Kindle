using Entities;
using Shared.SingleResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface ILoginDALService
    {
        Task<SingleResponse<int>> GetLogin(Login login);
    }
}

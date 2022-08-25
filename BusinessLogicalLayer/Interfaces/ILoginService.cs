using Entities;
using Shared.SingleResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Interfaces
{
    public interface ILoginService
    {
        Task<SingleResponse<int>> GetLogin(Login login);
    }
}

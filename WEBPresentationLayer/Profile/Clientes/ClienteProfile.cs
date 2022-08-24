using Entities;
using WEBPresentationLayer.Models.Cliente;

namespace WEBPresentationLayer.Profile.Clientes
{
    public class ClienteProfile : AutoMapper.Profile
    {
        public ClienteProfile()
        {
            CreateMap<Cliente, ClienteInsertViewModel>();
            CreateMap<ClienteInsertViewModel, Cliente>();
            CreateMap<Cliente, ClienteSelectViewModel>();
            CreateMap<ClienteSelectViewModel, Cliente>();
            CreateMap<ClienteUpdateViewModel, Cliente>();
            CreateMap<Cliente, ClienteUpdateViewModel>();
        }
    }
}

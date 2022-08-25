using Entities;
using WEBPresentationLayer.Models.Login;

namespace WEBPresentationLayer.Profile.Logins
{
    public class LoginProfile : AutoMapper.Profile
    {
        public LoginProfile()
        {
            CreateMap<LoginViewModel, Login>();
            CreateMap<Login, LoginViewModel>();
        }
    }
}

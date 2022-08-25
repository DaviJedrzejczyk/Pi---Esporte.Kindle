using AutoMapper;
using BusinessLogicalLayer.Interfaces;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Shared.SingleResponses;
using WEBPresentationLayer.Models.Login;

namespace WEBPresentationLayer.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILoginService _loginService;
        private readonly IMapper _mapper;

        public LoginController(ILoginService loginService, IMapper mapper)
        {
            _loginService = loginService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Logar(LoginViewModel loginView)
        {
            Login login = _mapper.Map<Login>(loginView);
            SingleResponse<int> single = await _loginService.GetLogin(login);
            if(single.Item <= 0)
            {
                return NotFound();
            }
            return RedirectToAction("Index","Home");
        }
    }
}

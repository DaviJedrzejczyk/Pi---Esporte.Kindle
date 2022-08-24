using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shared.DataResponses;
using Shared.Responses;
using Shared.SingleResponses;
using Entities;
using WEBPresentationLayer.Models.Cliente;
using BusinessLogicalLayer.Interfaces;
using AutoMapper;

namespace WEBPresentationLayer.Controllers
{
    //[Authorize(Roles = "Funcionario")]
    public class ClienteController : Controller
    {
        private readonly IClienteService _clienteService;
        private readonly IMapper _mapper;
        public ClienteController(IClienteService clienteService, IMapper mapper)
        {
            _clienteService = clienteService;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            DataResponse<Cliente> dataResponse = _clienteService.GetAll();
            if (!dataResponse.HasSuccess)
            {
                ViewBag.Errors = dataResponse.Message;
                return View();
            }
            List<ClienteSelectViewModel> clientes = _mapper.Map<ClienteSelectViewModel>(dataResponse.Itens);
            return View(clientes);
        }
        //[HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        //[HttPost]
        public IActionResult Create(ClienteInsertViewModel viewModel)
        {
            Cliente cliente = _mapper.Map<ClienteInsertViewModel>(viewModel);
            Response response = _clienteService.Insert(cliente);
            if (!response.HasSuccess)
            {
                ViewBag.Errors = response.Message;
                return View();
            }
            return RedirectToAction(nameof(Index));
        }

        //[HttpGet]
        public IActionResult Edit(int id)
        {
            SingleResponse<Cliente> single = _clienteService.GetById(id);
            if (!single.HasSuccess)
            {
                return View(nameof(Index));
            }
            Cliente cliente = single.Item;
            ClienteUpdateViewModel viewModel = _mapper.Map<ClienteUpdateViewModel>(cliente);
            return View(viewModel);
        }
        //[HttpPost]
        public IActionResult Edit(ClienteUpdateViewModel viewModel)
        {
            Cliente cliente = _mapper.Map<ClienteUpdateViewModel>(viewModel);
            Response response = _clienteService.Update(cliente);
            if (!response.HasSuccess)
            {
                ViewBag.Errors = response.Message;
                return View();
            }
            return RedirectToAction(nameof(Index));
        }
        //[HttpGet]
        public IActionResult Delete(int id)
        {
            SingleResponse<Cliente> singleResponse = _clienteService.GetById(id);
            if (!singleResponse.HasSuccess)
            {
                return View(nameof(Index));
            }
            Cliente cliente = singleResponse.Item;
            ClienteDeleteViewModel viewModel = _mapper.Map<ClienteDeleteViewModel>(cliente);
            return View(viewModel);
        }
        public IActionResult Delete(ClienteDeleteViewModel viewModel)
        {
            return View();
        }

    }
}

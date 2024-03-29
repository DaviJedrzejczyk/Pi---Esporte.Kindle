﻿using DataAccessLayer;
using Ninject.Activation;
using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Implements;
using BusinessLogicalLayer.Interfaces;
using BusinessLogicalLayer.BLL;

namespace WFPresentationLayer.DI
{
    public class FormModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IFuncionarioDALService>().To<FuncionarioDAL>();
            Bind<IFuncionarioService>().To<FuncionarioBLL>();
            Bind<IClienteDALService>().To<ClienteDAL>();
            Bind<IClienteService>().To<ClienteBLL>();
            Bind<IFornecedoraService>().To<FornecedoraBLL>();
            Bind<IFornecedoraDALService>().To<FornecedoraDAL>();
            Bind<IProdutoDALService>().To<ProdutoDAL>();
            Bind<IProdutoService>().To<ProdutoBLL>();
            Bind<IProdutoEntradaService>().To<ProdutoEntradaBLL>();
            Bind<IProdutoEntradaDALService>().To<ProdutoEntradaDAL>();
            Bind<IProdutoSaidaService>().To<ProdutoSaidaBLL>();
            Bind<IProdutoSaidaDALService>().To<ProdutosSaidaDAL>();
            Bind<IEntradaService>().To<EntradaBLL>();
            Bind<IEntradaDALService>().To<EntradaDAL>();
            Bind<IEnderecoDALService>().To<EnderecoDAL>();
            Bind<IEnderecoService>().To<EnderecoBLL>();
            Bind<IEstadoDALService>().To<EstadoDAL>();
            Bind<IEstadoService>().To<EstadoBLL>();
            Bind<ICategoriaDALService>().To<CategoriaDAL>();
            Bind<ICategoriaService>().To<CategoriaBLL>();
            Bind<ISaidaService>().To<SaidaBLL>();
            Bind<ISaidaDALService>().To<SaidaDAL>();
        }
        public static FormModule Craete()
        {
            return new FormModule();
        }
    }
}

using BusinessLogicalLayer.BLL;
using BusinessLogicalLayer.Interfaces;
using DataAccessLayer;
using DataAccessLayer.Implements;
using DataAccessLayer.Interfaces;
using Microsoft.EntityFrameworkCore;
using Ninject.Activation;
using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFPresentationLayer.DI
{
    public class FormModule : NinjectModule
    {
        public override void Load()
        {
            Bind<PIKindleDB>().ToSelf();
            Bind<IFuncionarioDALService>().To<FuncionarioDAL>();
            Bind<IFuncionarioService>().To<FuncionarioBLL>();
            Bind<IClienteDALService>().To<ClienteDAL>();
            Bind<IClienteService>().To<ClienteBLL>();
            Bind<IFornecedoraService>().To<FornecedoraBLL>();
            Bind<IFornecedoraDALService>().To<FornecedoraDAL>();
            Bind<ITipoFuncionarioDALService>().To<TipoFuncionarioDAL>();
            Bind<ITipoFuncionarioService>().To<TipoFuncionarioBLL>();
        }
        public static FormModule Craete()
        {
            return new FormModule();
        }
    }
}

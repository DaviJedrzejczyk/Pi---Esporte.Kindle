using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFPresentationLayer.DI
{
    public class FormResolve
    {
        private static IKernel _kernel;
        public static void Wire(INinjectModule module)
        {
            _kernel = new StandardKernel(module);
        }
        public static T Resolve<T>()
        {
            return _kernel.Get<T>();
        }
    }
}

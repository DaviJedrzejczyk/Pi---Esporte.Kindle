using DataAccessLayer.Interfaces;
using WFPresentationLayer.DI;

namespace WFPresentationLayer
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            ApplicationConfiguration.Initialize();
            FormResolve.Wire(FormModule.Craete());
            Application.Run(FormResolve.Resolve<TelaFornecedor>());
        }
    }
}
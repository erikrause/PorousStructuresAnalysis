using BLL.Infrastructure;
using BLL.Interfaces;
using Ninject;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsFramework.Infrastructure;

namespace WinFormsFramework
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Ninject Bindings:
            var repositoryModule = new RepositoryModule(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);     
            var serviceModule = new ProbModule();       // Правильно ли?
            var kernel = new StandardKernel(repositoryModule, serviceModule);
            //kernel.Load(AppDomain.CurrentDomain.GetAssemblies());

            Application.Run(new Form1(kernel.Get<IProbService>()));
        }
    }
}

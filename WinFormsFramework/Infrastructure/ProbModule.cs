using BLL.Interfaces;
using BLL.Services;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsFramework.Infrastructure
{
    public class ProbModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IProbService>().To<ProbService>();
        }
    }
}

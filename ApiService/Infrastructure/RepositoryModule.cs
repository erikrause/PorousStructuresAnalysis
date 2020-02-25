using ApiDomain.EntityFramework;
using ApiDomain.Interfaces;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiService.Infrastructure
{
    public class RepositoryModule : NinjectModule
    {
        private string ConnectionString;
        public RepositoryModule(string connectionString)
        {
            ConnectionString = connectionString;
        }
        public override void Load()
        {
            Bind<IRepository>().To<SQLRepository>().WithConstructorArgument(ConnectionString); ;
        }
    }
}

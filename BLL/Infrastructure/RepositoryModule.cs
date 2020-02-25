using DAL.Interfaces;
using DAL.Entity_Framework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Infrastructure
{
    public class RepositoryModule : NinjectModule
    {
        private string ConnectionString;
        public RepositoryModule(string connectionString)
        {
            ConnectionString = connectionString;      // debug:
            //ConnectionString = "Server=(localdb)\\mssqllocaldb;Database=Blogging;Trusted_Connection=True";
        }
        public override void Load()
        {
            Bind<IRepository>().To<SQLRepository>().WithConstructorArgument(ConnectionString);
        }
    }
}

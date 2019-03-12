using AspNetSeed.Service;
using AspNetSeed.Domain;
using AspNetSeed.Infrastructure;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetSeed.Web
{
    public class UserModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUserService>().To<UserService>();
            Bind<IUserRepository>().To<MemoryUserRepository>();
        }
    }
}
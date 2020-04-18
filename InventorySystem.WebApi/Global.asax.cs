using InventorySystem.Core;
using InventorySystem.DataAccess.Implementation;
using InventorySystem.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using Unity;

namespace InventorySystem.WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            RootContainer.Container.RegisterType(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        }
    }
}

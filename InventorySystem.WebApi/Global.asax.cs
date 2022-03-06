using InventorySystem.Core;
using InventorySystem.DataAccess.Implementation;
using InventorySystem.DataAccess.Interfaces;
using InventorySystem.Manager.Implementations;
using InventorySystem.Manager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
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

            RootContainer.Instance.Container.RegisterType(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            RootContainer.Instance.Container.RegisterType<IInventoryManager, InventoryManager>();
            RootContainer.Instance.Container.RegisterType<IInvoiceManager, InvoiceManager>();
            RootContainer.Instance.Container.RegisterType<IProductManager, ProductManager>();
            RootContainer.Instance.Container.RegisterType<IProductWorkManager, ProductWorkManager>();
            RootContainer.Instance.Container.RegisterType<IProviderManager, ProviderManager>();
            RootContainer.Instance.Container.RegisterType<IPurchaseInvoiceManager, PurchaseInvoiceManager>();
            RootContainer.Instance.Container.RegisterType<IUnitManager, UnitManager>();
            RootContainer.Instance.Container.RegisterType<IWarehouseProductManager, WarehouseProductManager>();
        }
    }
}

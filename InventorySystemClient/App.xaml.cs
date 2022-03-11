using InventorySystem.Core;
using InventorySystem.DataAccess.Implementation;
using InventorySystem.DataAccess.Interfaces;
using InventorySystem.Manager.Implementations;
using InventorySystem.Manager.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Unity;
using Unity.Lifetime;

namespace InventorySystemClient
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            RootContainer.Instance.Container.RegisterType(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            RootContainer.Instance.Container.RegisterType<IInventoryManager, InventoryManager>();
            RootContainer.Instance.Container.RegisterType<IInvoiceManager, InvoiceManager>();
            RootContainer.Instance.Container.RegisterType<IProductManager, ProductManager>();
            RootContainer.Instance.Container.RegisterType<IProductWorkManager, ProductWorkManager>();
            RootContainer.Instance.Container.RegisterType<IProviderManager, ProviderManager>();
            RootContainer.Instance.Container.RegisterType<IPurchaseInvoiceManager, PurchaseInvoiceManager>();
            RootContainer.Instance.Container.RegisterType<IUnitManager, UnitManager>();
            RootContainer.Instance.Container.RegisterType<IWarehouseProductManager, WarehouseProductManager>(new ContainerControlledLifetimeManager());
        }
    }
}

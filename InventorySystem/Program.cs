using System;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Windows.Forms;
using InventorySystem.Api;
using InventorySystem.Contract;
using InventorySystem.Core;
using InventorySystem.DataAccess.Implementation;
using InventorySystem.DataAccess.Interfaces;
using InventorySystem.Manager;
using InventorySystem.Manager.Implementations;
using InventorySystem.Manager.Interfaces;
using Unity;

namespace InventorySystem
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

            //RootContainer.Instance.Container.RegisterType<IInventoryManager, InventorySystemApi>();
            //RootContainer.Instance.Container.RegisterType<IInvoiceManager, InventorySystemApi>();
            //RootContainer.Instance.Container.RegisterType<IProductManager, InventorySystemApi>();
            //RootContainer.Instance.Container.RegisterType<IProductWorkManager, InventorySystemApi>();
            //RootContainer.Instance.Container.RegisterType<IProviderManager, InventorySystemApi>();
            //RootContainer.Instance.Container.RegisterType<IPurchaseInvoiceManager, InventorySystemApi>();
            //RootContainer.Instance.Container.RegisterType<IUnitManager, InventorySystemApi>();
            //RootContainer.Instance.Container.RegisterType<IWarehouseProductManager, InventorySystemApi>();
            //
            RootContainer.Instance.Container.RegisterType(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            RootContainer.Instance.Container.RegisterType<IInventoryManager, InventoryManager>();
            RootContainer.Instance.Container.RegisterType<IInvoiceManager, InvoiceManager>();
            RootContainer.Instance.Container.RegisterType<IProductManager, ProductManager>();
            RootContainer.Instance.Container.RegisterType<IProductWorkManager, ProductWorkManager>();
            RootContainer.Instance.Container.RegisterType<IProviderManager, ProviderManager>();
            RootContainer.Instance.Container.RegisterType<IPurchaseInvoiceManager, PurchaseInvoiceManager>();
            RootContainer.Instance.Container.RegisterType<IUnitManager, UnitManager>();
            RootContainer.Instance.Container.RegisterType<IWarehouseProductManager, WarehouseProductManager>();

            RootContainer.Instance.Container.RegisterInstance<WarehouseForm>(new WarehouseForm());

            var warehouse = RootContainer.Instance.Container.Resolve<WarehouseForm>();

            Application.Run(warehouse);
        }
    }
}

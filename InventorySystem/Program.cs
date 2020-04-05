using System;
using System.Windows.Forms;
using InventorySystem.Contract;
using InventorySystem.Core;
using InventorySystem.DataAccess;
using InventorySystem.DataAccess.Implementation;
using InventorySystem.DataAccess.Interfaces;
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
            RootContainer.Container.RegisterType(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            RootContainer.Container.RegisterInstance<Warehouse>(new Warehouse());
            RootContainer.Container.RegisterInstance<AddProduct>(new AddProduct());
            RootContainer.Container.RegisterInstance<Purshase>(new Purshase());

            var warehouse = RootContainer.Container.Resolve<Warehouse>();
            Application.Run(warehouse);
        }
    }
}

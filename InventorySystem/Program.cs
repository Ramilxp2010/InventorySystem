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
            //RootContainer.Container.RegisterType<InventoryContext>();
            RootContainer.Container.RegisterType(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Warehouse());
        }
    }
}

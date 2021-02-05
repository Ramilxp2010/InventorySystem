﻿using System;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Windows.Forms;
using InventorySystem.Api;
using InventorySystem.Contract;
using InventorySystem.Core;
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

            RootContainer.Container.RegisterType<IInventorySystemApi, InventorySystemApi>();
            RootContainer.Container.RegisterInstance<WarehouseForm>(new WarehouseForm());

            var warehouse = RootContainer.Container.Resolve<WarehouseForm>();

            Application.Run(warehouse);
        }
    }
}

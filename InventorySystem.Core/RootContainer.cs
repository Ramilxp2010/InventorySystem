using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace InventorySystem.Core
{
    public static class RootContainer
    {
        public static UnityContainer Container;

        static RootContainer()
        {
            Container = new UnityContainer();
        }
    }
}

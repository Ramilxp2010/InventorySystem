using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace InventorySystem.Core
{
    public class RootContainer
    {
        public UnityContainer Container;

        private RootContainer()
        {
            Container = new UnityContainer();
        }

        private static RootContainer _instance;
        public static RootContainer Instance 
        {
            get
            {
                if (_instance == null)
                    _instance = new RootContainer();

                return _instance;
            }
        }

        public void Register()
        {

        }
    }
}

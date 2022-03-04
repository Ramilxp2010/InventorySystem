using System.Collections.Generic;
using System.Linq;
using InventorySystem.Contract;
using InventorySystem.Core;
using InventorySystem.DataAccess.Interfaces;
using Unity;
using NLog;

namespace InventorySystem.Manager
{
    public class LoggingManager
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public void MessageFromUI(Log item)
        {
            switch (item.LogType)
            {
                case LogType.Warning:
                    {
                        Logger.Warn($"{item.Text}");
                        break;
                    }
                case LogType.Trace: 
                    {
                        Logger.Trace($"{item.Text}");
                        break;
                    }
                case LogType.Info:
                    {
                        Logger.Info($"{item.Text}");
                        break;
                    }
                case LogType.Error:
                    {
                        Logger.Error($"{item.Text};[Exception]:{item.Exception}");
                        break;
                    }
            }
        }

    }
}

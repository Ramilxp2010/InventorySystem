using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Contract
{
    public enum LogType 
    {
        Info = 1, Error, Warning
    }

    public class Log
    {
        public Log(string text, LogType logType, Exception ex) 
        {
            Text = text;
            LogType = logType;
            Exception = ex;
        }

        public string Text;

        public LogType LogType;

        public Exception Exception;
    }
}

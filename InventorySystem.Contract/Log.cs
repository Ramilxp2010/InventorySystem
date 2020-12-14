using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Contract
{
    public enum LogType 
    {
        Info = 1, Error, Warning, Trace
    }

    public class Log
    {
        public Log() 
        {

        }

        public Log(string text, LogType logType)
        {
            Text = text;
            LogType = logType;
        }

        public Log(string text, LogType logType, Exception ex) 
        {
            Text = text;
            LogType = logType;
            Exception = ex;
        }

        public string Text { get; set; }

        public LogType LogType { get; set; }

        public Exception Exception { get; set; }
    }
}

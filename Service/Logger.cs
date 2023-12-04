using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toolsuiteapp.Service
{
    public  class Logger
    {
        public void LogException(Exception ex)
        {
            string LogPath = @"C:\Ellamaduagwu\toolsuiteapp\logger.txt";
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Exception Date: "+ DateTime.Now.ToString());
            sb.AppendLine("Exception Message: " + ex.Message);
            sb.AppendLine("Stack Trace: " + ex.StackTrace);

            File.AppendAllText(LogPath, sb.ToString());
        }
    }
}

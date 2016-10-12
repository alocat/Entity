using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnitytIOCMvc.Code.Utility
{
    public class ConsoleLogger:ILogger
    {
        public void Write(string msg)
        {
            Console.WriteLine();
            Console.WriteLine("*** In logger ***");
            Console.WriteLine(String.Format("message {0}", msg));
        }
    }
}

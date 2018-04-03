//using System;
//using System.Collections.Generic;
using System.Text;
using System.IO;
using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateStr = DateTime.Now.ToString("yyyyMMddHHmmss");
            File.WriteAllText(@"datestamp.cmd", "set datetime=" + dateStr);
        }
    }
}
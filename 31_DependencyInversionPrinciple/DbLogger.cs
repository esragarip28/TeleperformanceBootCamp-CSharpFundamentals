using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_DependencyInversionPrinciple
{
    class DbLogger : ILogger
    {
        //public void Log(string text)
        //{

        //}
        public void Log(string text)
        {
            Console.WriteLine(text);
        }
    }
}

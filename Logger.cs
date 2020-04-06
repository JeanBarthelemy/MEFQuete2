using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace MEFQuete2
{
    [Export(typeof(ILogger))]
    internal class Logger : ILogger
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}
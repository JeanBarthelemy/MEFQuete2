using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.IO;

namespace MEFQuete2
{
    [Export(typeof(ILogger))]
    internal class TextLogger : ILogger
    {
        public void Write(string message)
        {
            using (StreamWriter writer = File.CreateText("newfile.txt"))
            {
                writer.WriteLine(message);
            }

        }
    }
}
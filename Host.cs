using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace MEFQuete2
{
    class Host
    {
        private CompositionContainer _container = null;

        [ImportMany]
        private IEnumerable<ILogger> _loggers;

        static void Main(string[] args)
        {
            var program = new Host();
            program.Run();
            Console.Read();
        }

        public Host()
        {
            var catalog = new DirectoryCatalog(".", "MEFQuete2.*");
            _container = new CompositionContainer(catalog);
            _container.ComposeParts(this);
        }

        public void Run()
        {
            foreach (var logger in _loggers)
            {
                logger.Write("Hello !");
            }
               
        }
    }
}

using log4net.Repository;
using System;
using System.IO;
using System.Reflection;

namespace ConsoleApp1Core
{
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            try
            {

                ILoggerRepository repository = log4net.LogManager.GetRepository(Assembly.GetCallingAssembly());
                
                var fileInfo = new FileInfo(@"log4net.config");

                log4net.Config.XmlConfigurator.Configure(repository, fileInfo);

                log.Info("test");

                Console.WriteLine("press any key");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                // logger if using logging framework - console here for brevity
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press any key to exit");
                Console.ReadLine();
            }

        }

    }
}

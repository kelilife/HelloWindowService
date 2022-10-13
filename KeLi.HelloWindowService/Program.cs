using System;
using System.ServiceProcess;

using NLog;

namespace KeLi.HelloWindowService
{
    internal static class Program
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        private static void Main()
        {
            try
            {
                ServiceBase.Run(new TestService());
            }
            catch (Exception e)
            {
                logger.Fatal(e.ToString);
            }
        }
    }
}
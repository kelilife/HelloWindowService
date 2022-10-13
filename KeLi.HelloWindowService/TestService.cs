using System;
using System.ServiceProcess;

using NLog;

namespace KeLi.HelloWindowService
{
    public partial class TestService : ServiceBase
	{
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

		public TestService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            try
            {
                logger.Info("OnStart successful!");
            }
            catch (Exception e)
            {
                logger.Fatal("OnStart error: {0}!", e.ToString());
			}
		}

        protected override void OnStop()
		{
			try
            {
                logger.Info("OnStop successful!");
            }
            catch (Exception e)
            {
                logger.Fatal("OnStop error: {0}!", e.ToString());
            }
		}
    }
}
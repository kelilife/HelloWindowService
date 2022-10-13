using System.ComponentModel;
using System.Configuration.Install;

namespace KeLi.HelloWindowService
{
    [RunInstaller(true)]
    public partial class ProjectInstaller : Installer
    {
        public ProjectInstaller()
        {
            InitializeComponent();
        }
    }
}
using System.Configuration;
using System.IO;
using Prism.Ioc;
using StarDust.IngestManager.Views;
using System.Windows;
using Prism.Modularity;
using StarDust.IngestManager.Module.Ingest;

namespace StarDust.IngestManager
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {

        public string ModulePath = ConfigurationManager.AppSettings["ModulePath"] ?? @".\Modules";
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }


        protected override IModuleCatalog CreateModuleCatalog()
        {
            IModuleCatalog catalog = Directory.Exists(ModulePath) ? new DirectoryModuleCatalog() { ModulePath = ModulePath } : new ModuleCatalog();
            catalog.AddModule(typeof(IngestModule), InitializationMode.WhenAvailable);
            return catalog;
        }
    }
}

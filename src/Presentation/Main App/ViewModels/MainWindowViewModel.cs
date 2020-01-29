using Prism.Mvvm;
using Prism.Regions;
using StarDust.IngestManager.Crosscutting;
using StarDust.IngestManager.Module.Ingest.Views;

namespace StarDust.IngestManager.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Ingest Manager";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        protected IRegionManager RegionManager { get; private set; }

        public MainWindowViewModel(IRegionManager regionManager)
        {
            RegionManager = regionManager;

            RegisterViews();
        }

        protected virtual void RegisterViews()
        {
            RegionManager.RegisterViewWithRegion(RegionNames.MainRegion, typeof(ViewA));
        }
    }
}

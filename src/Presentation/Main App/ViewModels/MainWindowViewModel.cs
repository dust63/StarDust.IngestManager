using Prism.Mvvm;
using Prism.Regions;
using StartDust.IngestManager.Crosscutting;
using StartDust.IngestManager.Module.Ingest.Views;

namespace StartDust.IngestManager.ViewModels
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

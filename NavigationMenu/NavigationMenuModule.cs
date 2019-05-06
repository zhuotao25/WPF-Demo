using Infrastructure;
using Infrastructure.Constants;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace NavigationMenu
{
    [Module(ModuleName = ModuleNames.NAVIGATION_MENU)]
    public class NavigationMenuModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            IRegionManager regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion(RegionNames.MENU_REGION, typeof(NavigationMenu));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}

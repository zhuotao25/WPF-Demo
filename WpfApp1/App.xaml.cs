using Prism.Ioc;
using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<Shell>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //containerRegistry.RegisterDialog<NotificationDialog, NotificationDialogViewModel>();
            //containerRegistry.RegisterDialog<ConfirmationDialog, ConfirmationDialogViewModel>();

            //register a custom window host
            //containerRegistry.RegisterDialogWindow<CustomDialogWindow>();
        }
    }
}

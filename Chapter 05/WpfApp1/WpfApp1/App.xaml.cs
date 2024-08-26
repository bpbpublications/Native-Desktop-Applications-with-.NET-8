using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            this.StartupUri = new Uri("MainWindow.xaml", UriKind.RelativeOrAbsolute);

            //this.Startup += App_Startup;
            //this.DispatcherUnhandledException += App_DispatcherUnhandledException;
            //this.Exit += App_Exit;
         }

        private void App_Startup(object sender, StartupEventArgs e)
        {
            //TODO: Need to write a additional logic need to startup the application.
        }
        private void App_Exit(object sender, ExitEventArgs e)
        {
            //TODO: Need to write a logic which needed when application before getting existed.
        }

        private void App_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            //TODO: Need to write a logic to handle the exceptions at application level.
        }
    }
}

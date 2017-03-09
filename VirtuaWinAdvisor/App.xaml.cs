using System;
using System.Diagnostics;
using System.IO;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Threading;
using System.Windows;
using VirtuaWinAdvisor.IPC;
using VirtuaWinAdvisor.Service;

namespace VirtuaWinAdvisor
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

            ServiceHost host = new ServiceHost(typeof(VirtuaWinService));
            host.Open();
            Debug.WriteLine($"Service host state: {host.State}");
        }

        private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            File.WriteAllText(
                Path.Combine(
                    Environment.CurrentDirectory, typeof(App).Assembly.GetName().Name + ".txt"), 
                e.ExceptionObject.ToString());

            Environment.Exit(1);
        }
    }
}

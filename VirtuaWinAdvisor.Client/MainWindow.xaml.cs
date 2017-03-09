using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VirtuaWinAdvisor.Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IVirtuaWinServiceChannel _virtauWinService;

        public MainWindow()
        {
            InitializeComponent();
            var factory = new ChannelFactory<IVirtuaWinServiceChannel>("default");
            _virtauWinService = factory.CreateChannel();
        }

        private void previousDesktop_Click(object sender, RoutedEventArgs e)
        {
            _virtauWinService.PreviousDesktop();
        }

        private void nextDesktop_Click(object sender, RoutedEventArgs e)
        {
            _virtauWinService.NextDesktop();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtuaWinAdvisor.Client.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Is client connected to server
        /// </summary>
        public bool IsConnected {
            get;
            private set;
        }

        public bool IsAutoConnect
        {
            get;
            set;
        }

        public MainViewModel()
        {
            IsConnected = false;
            IsAutoConnect = true;
        }
    }
}

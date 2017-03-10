using System.ServiceModel;
using VirtuaWinAdvisor.IPC;

namespace VirtuaWinAdvisor.Client.Service
{
    interface IVirtuaWinServiceChannel : IVirtuaWinService, IClientChannel
    {
    }
}
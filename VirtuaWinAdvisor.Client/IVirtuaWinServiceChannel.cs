using System.ServiceModel;
using VirtuaWinAdvisor.IPC;

namespace VirtuaWinAdvisor.Client
{
    interface IVirtuaWinServiceChannel : IVirtuaWinService, IClientChannel
    {
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace VirtuaWinAdvisor.IPC
{
    [ServiceContract]
    public interface IVirtuaWinService
    {
        /// <summary>
        /// Switch VirtuaWin to next desktop
        /// </summary>
        /// <returns>Desktop ID number after switch</returns>
        [OperationContract]
        uint NextDesktop();

        /// <summary>
        /// Switch VirtuaWin to previous desktop
        /// </summary>
        /// <returns>Desktop ID number after switch</returns>
        [OperationContract]
        uint PreviousDesktop();

        /// <summary>
        /// Switch VirtauWin to provided desktop ID.
        /// </summary>
        /// <param name="desktop">Desktop ID</param>
        /// <returns>Desktop ID number after switch</returns>
        [OperationContract]
        uint SetDesktop(uint desktop);

        /// <summary>
        /// Get current VirtauWin desktop ID
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        uint GetDesktop();

        /// <summary>
        /// Return count of desktop in VirtauWin
        /// </summary>
        /// <returns>Desktop count</returns>
        [OperationContract]
        uint GetDesktopCount();
    }
}

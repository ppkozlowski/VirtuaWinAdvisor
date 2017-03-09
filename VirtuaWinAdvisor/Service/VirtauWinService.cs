using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using VirtuaWinAdvisor.IPC;

namespace VirtuaWinAdvisor.Service
{
    public class VirtuaWinService : IVirtuaWinService
    {
        private const string VirtaulWinProcessName = "VirtuaWin";

        private bool _isAppRunning = false;

        private IntPtr _handle;

        public VirtuaWinService()
        {
            var process = Process.GetProcessesByName(VirtaulWinProcessName).FirstOrDefault();

            if(process != null)
            {
                Debug.WriteLine("VirtuaWin application is running.");

                process.EnableRaisingEvents = true;
                process.Exited += Process_Exited;

                _handle = process.MainWindowHandle;
                _isAppRunning = true;
            }
            else
            {
                Debug.WriteLine("VirtuaWin application not running.");
            }
        }

        public uint GetDesktop()
        {
            return Convert.ToUInt32(SendMessage(Native.Messages.VW_CURDESK).ToInt32());
        }

        public uint GetDesktopCount()
        {
            return Convert.ToUInt16(
                    SendMessage(Native.Messages.VW_DESKX).ToInt32() *
                        SendMessage(Native.Messages.VW_DESKY).ToInt32());
        }

        public uint NextDesktop()
        {
            return SwitchDesktop(Native.Messages.VW_STEPNEXT);
        }

        public uint PreviousDesktop()
        {
            return SwitchDesktop(Native.Messages.VW_STEPPREV);
        }

        public uint SetDesktop(uint desktop)
        {
            return SwitchDesktop(desktop);
        }

        private uint SwitchDesktop(uint id)
        {
            var returnId = SendMessage(
                            Native.Messages.VW_CHANGEDESK,
                            new IntPtr(id),
                            IntPtr.Zero);

            return Convert.ToUInt32(returnId.ToInt32());
        }

        private IntPtr SendMessage(uint message, IntPtr wparam = default(IntPtr), IntPtr lparam = default(IntPtr))
        {
            if (!_isAppRunning)
            {
                return IntPtr.Zero;
            }

            return Native.User32.SendMessage(
                    _handle,
                    message,
                    wparam,
                    lparam
                );
        }
        
        private void Process_Exited(object sender, EventArgs e)
        {
            Debug.WriteLine("VirtauWin process exited");
            _isAppRunning = false;
        }
    }
}

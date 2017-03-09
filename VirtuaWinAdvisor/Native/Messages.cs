using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtuaWinAdvisor.Native
{
    /// <summary>
    /// VirtualWin Windows Message definitions 
    /// taken from VirtualWin SDK Messages.h
    /// </summary>
    public static class Messages
    {
        public const uint VW_CHANGEDESK = Native.User32.WM_USER + 10;

        public const uint VW_STEPPREV = Native.User32.WM_USER + 11;

        public const uint VW_STEPNEXT = Native.User32.WM_USER + 12;

        public const uint VW_CLOSE = Native.User32.WM_USER + 15;

        public const uint VW_SETUP = Native.User32.WM_USER + 16;

        public const uint VW_DESKX = Native.User32.WM_USER + 21;

        public const uint VW_DESKY = Native.User32.WM_USER + 22;

        public const uint VW_CURDESK = Native.User32.WM_USER + 24;
    }
}

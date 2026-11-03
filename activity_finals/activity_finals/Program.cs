using System;
using System.Windows.Forms;

namespace activity_finals
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new signin());
        }
    }
}
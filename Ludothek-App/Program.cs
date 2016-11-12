using System;
using System.Windows.Forms;

namespace Ludothek
{
    static class Program
    {
        [System.STAThread]
        public static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(new Application.View.MainView());
        }
    }
}

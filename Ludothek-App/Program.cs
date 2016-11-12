using Ludothek.Application.Model;
using Ludothek.Application.View;
using System;
using System.Windows.Forms;

namespace Ludothek
{
    static class Program
    {
        [System.STAThread]
        public static void Main()
        {
            Repository repo = new Repository();

            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(new MainView(repo));
        }
    }
}

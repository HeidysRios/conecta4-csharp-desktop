using System;
using System.Windows.Forms;

namespace Conecta4Semestral.Clases
{
    internal static class Program
    {
        // Punto de entrada del programa. Se abre el menu principal (Form1).
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

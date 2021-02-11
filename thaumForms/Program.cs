using System;
using System.Windows.Forms;

namespace thaumForms
{
    public class Program
    {
        [STAThread]
        public static void Main()
        {
            //this program does`t know Ukrainian, so i helped her
            //Console.InputEncoding = Encoding.Unicode;
            //Console.OutputEncoding = Encoding.Unicode;
            //Console.ResetColor();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
// Author: EneRgyGOD  
// Thanks DreamerDeLy
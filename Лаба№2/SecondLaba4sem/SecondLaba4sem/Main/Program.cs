using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SecondLaba4sem
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

                       
            MainView view = new MainView();
            Model model = new Model();
            Controller controller = new Controller(view, model);

            Application.Run(controller.CreateFormView());
        }
    }
}

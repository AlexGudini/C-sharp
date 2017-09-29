using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace Idoctor
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            InteractionObjects a = new InteractionObjects(new Point(50, 50), 50, 300);
            bool mm = a.IsLocated(new Point(5, 5), 300, 300);

            GameView view = new GameView();
            GameModel model = new GameModel();
            GameController controller = new GameController(view, model);

            Application.Run(view);
        }
    }
}

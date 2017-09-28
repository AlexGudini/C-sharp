using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Idoctor
{
    public interface IGameController
    {
        GameModel GetGameModel();
    }

    public class GameController
    {
        private GameView view;
        private GameModel model;

        public GameController(GameView view, GameModel model)
        {
            this.view = view;
            this.model = model;
            this.view.SetGameConroller(this);
            this.view.DrawCharacter();

            
        }

        public void TimerMoving()
        {
            bool a = this.view.GetKeyPress().IsDownUp;
            if (this.view.GetKeyPress().IsDownUp == true)
                this.model.GetPlayer().LocateY -= 5;
            if (this.view.GetKeyPress().IsDownRight == true)
                this.model.GetPlayer().LocateX += 5;

            if (this.view.GetKeyPress().IsDownDown == true)
                this.model.GetPlayer().LocateY += 5;
            if (this.view.GetKeyPress().IsDownLeft == true)
                this.model.GetPlayer().LocateX -= 5;
        }

        public GameModel GetGameModel()
        {
            return this.model;
        }
    }
}

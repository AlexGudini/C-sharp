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
    public interface IGameModel
    {
        Player GetPlayer();
    }
    public class GameModel: IGameModel
    {
        private Player playerDoctor;


        public GameModel()
        {
            playerDoctor = new Player();
        }

        public Player GetPlayer()
        {
            return this.playerDoctor;
        }
    }
}

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
        private Patients patient;

        public GameModel()
        {
            playerDoctor = new Player();
            patient = new Patients();
        }

        public Player GetPlayer()
        {
            return this.playerDoctor;
        }
        public Patients GetPatient()
        {
            return this.patient;
        }
    }
}

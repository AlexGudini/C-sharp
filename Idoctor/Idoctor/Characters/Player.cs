using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Idoctor
{
    public enum PositionMoving
    {
        Up, Right, Down, Left, Stop
    }
    public interface IPlayer
    {
        Image GetImagePlayer();
    }

    public class Player: IPlayer
    {
        private int locateX;
        private int locateY;
        private Image imagePlayer = Idoctor.Properties.Resources.doc;
        private PositionMoving positMoving = PositionMoving.Stop;

        public int LocateX { get; set; }
        public int LocateY { get; set; }
        public PositionMoving PositMoving { get; set; }

        public Player()
        {
            this.locateX = 20;
            this.locateY = 20;
        }
        public Image GetImagePlayer()
        {
            return this.imagePlayer;
        }
        

    }
}

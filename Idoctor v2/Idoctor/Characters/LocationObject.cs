using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Idoctor
{

    public class LocationObject
    {
        protected int locateX;
        protected int locateY;
        protected Image imagePlayer = Idoctor.Properties.Resources.doc;
        protected PositionMoving positMoving = PositionMoving.Stop;

        public int LocateX { get; set; }
        public int LocateY { get; set; }
        public PositionMoving PositMoving { get; set; }

        public LocationObject()
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Idoctor
{

    public class MapObject
    {
        protected int locateX;
        protected int locateY;
        protected Image imageMapObject = Idoctor.Properties.Resources.doc;
        
        public int LocateX
        {
            get
            {
                return locateX;
            }
            set { if( value >= 0) locateX = value; }
        }
        public int LocateY
        {
            get
            {
                return locateY;
            }
            set {if( locateY >= 0) locateY = value; }
        }  
        public Image ImagePlayer
        {
            get
            {
                return imageMapObject;
            }
            set { imageMapObject = value; }
        }

        public MapObject()
        {
            this.locateX = 20;
            this.locateY = 20;                                        
        }
        public Image GetImage()
        {
            return this.imageMapObject;
        }
    }
}

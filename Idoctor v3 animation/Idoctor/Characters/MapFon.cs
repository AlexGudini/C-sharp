using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Idoctor
{
    public class MapFon: MapObject
    {
        private Rectangle rectangle;
        
        //  private Bitmap bitmap;

        protected PositionMoving positMoving = PositionMoving.Stop;

        public MapFon(Image image)
        {
            imageMapObject = image;
            this.rectangle = new Rectangle(0, 0, 500, 500);
            

        }

        //public MapFon(int x, int y, )
    }
}

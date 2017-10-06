using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Idoctor
{
    public class Patients: MapObject
    {
        public Patients(int x, int y, Bitmap bitmap): base()
        {
            this.imageMapObject = bitmap ;
            this.LocateX = x;
            this.LocateY = y;
        }
    }
}

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
    // Взаимодействие 2 фигур ( вписанность, пересечение )
    public interface IInteraction
    {
        bool IsLocated(Point leftPointObject, int heightObj, int widthObj);
        bool IsIntersection(Point leftPointObject, int heightObj, int widthObj);
    }

    public class InteractionObjects : IInteraction
    {
        private Point leftPoint;
        private int height;
        private int width;

        public Point LeftPoint
        {
            get
            {
                return leftPoint;
            }
            set { leftPoint = value; }
        }
        public int Height
        {
            get
            {
                return height;
            }
            set { if( value >= 0) height = value; }
        }
        public int Width
        {
            get
            {
                return width;
            }
            set { if( value >= 0) width = value; }
        }

        public InteractionObjects(Point leftPoint, int width, int height )
        {
            this.leftPoint = leftPoint;
            this.height = height;
            this.width = width;
        }
        // Проверка вписан объект один в одного ( да - если меньший объект в больший )
        public bool IsLocated(Point leftPointObject, int widthObj, int heightObj)
        {
            if(leftPoint.X <= leftPointObject.X && leftPoint.Y <= leftPointObject.Y)
                if (leftPoint.X + width >= leftPointObject.X + widthObj 
                    && leftPoint.Y + height >= leftPointObject.Y + heightObj)
                    return true;
            return false;
        }
        // Проверка пересекаются ли один объект с другим
        public bool IsIntersection( Point leftPointObject, int widthObj, int heightObj)
        {
            Rectangle rectang1 = new Rectangle(leftPoint.X, leftPoint.Y, width, height);
            Rectangle rectang2 = new Rectangle(leftPointObject.X, leftPointObject.Y, widthObj, heightObj);
            if (rectang1.IntersectsWith(rectang2))
            {
                return true;
            }
            return false;
        }
    }
}

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
        public InteractionObjects(Point leftPoint, int height, int width)
        {
            this.leftPoint = leftPoint;
            this.height = height;
            this.width = width;
        }

        // Проверка вписан объект один в одного
        public bool IsLocated(Point leftPointObject, int heightObj, int widthObj)
        {
            if(leftPoint.X <= leftPointObject.X && leftPoint.Y <= leftPointObject.Y)
                if (leftPoint.X + width >= leftPointObject.X + widthObj 
                    && leftPoint.Y + height >= leftPointObject.Y + heightObj)
                    return true;
            return false;
        }

        // Проверка пересекаются ли один объект с другим
        public bool IsIntersection( Point leftPointObject, int heightObj, int widthObj)
        {
            Rectangle rectang1 = new Rectangle(leftPoint.X, leftPoint.Y, width, height);
            Rectangle rectang2 = new Rectangle(leftPointObject.X, leftPointObject.Y, widthObj, heightObj);
            if (rectang1.IntersectsWith(rectang2))
            {
                return true;
            }

            return false;
            //bool flag = false;




            //if (IsLocated(leftPointObject, 1, 1, leftPointSubject, widthSub, heightSub) == true)
            //    flag = true;
            //leftPointObject.X += widthObj;

            //if (IsLocated(leftPointObject, 1, 1, leftPointSubject, widthSub, heightSub) == true)
            //     flag = true;
            //leftPointObject.Y += heightObj;

            //if (IsLocated(leftPointObject, 1, 1, leftPointSubject, widthSub, heightSub) == true)
            //     flag = true;
            //leftPointObject.X -= widthObj;

            //if (IsLocated(leftPointObject, 1, 1, leftPointSubject, widthSub, heightSub) == true)
            //     flag = true;

            //if( flag == true)
            //    return false;

        }
    }
}

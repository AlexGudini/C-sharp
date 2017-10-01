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
    public class Player: LocationObject
    {
        // Анимация движения
        private int spriteX = 0;
        private int spriteY = 0;
        private int spriteWidth = 80;
        private int spriteHeigth = 125;
        private Rectangle rectangle;
        private Bitmap bitmap;
        private int timerAnimation = 0;

        public Player() : base()
        {
            locateX = 150;
            locateY = 150;
            imagePlayer = Idoctor.Properties.Resources.anim;
            rectangle = new Rectangle(spriteX, spriteY, spriteWidth, spriteHeigth);
            bitmap = new Bitmap(rectangle.Width, rectangle.Height);
            
        }

        public void AnimationPlayer()
        {
            //using (Graphics g = Graphics.FromImage(bitmap))
            //{
            //    g.DrawImage(imagePlayer, 210, 210, rectangle, GraphicsUnit.Pixel);
            //}
            timerAnimation += 100;
            if (timerAnimation == 200)
            {
                timerAnimation = 0;
                this.spriteX += 84;
                if (this.spriteX >= 410)
                    this.spriteX = 0;
                rectangle = new Rectangle(spriteX, spriteY, spriteWidth, spriteHeigth);
            }
            
        }
        public Rectangle GetRectangle()
        {
            return rectangle;
        }
        public Bitmap GetBitmap()
        {
            return bitmap;
        }

    }
}

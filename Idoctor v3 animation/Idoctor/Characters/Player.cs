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
    public class Player: MapObject
    {
        // Анимация движения
        private int spriteX = 0;
        private int spriteY = 0;
        private int spriteWidth = 80;
        private int spriteHeigth = 125;
        private Rectangle rectangle;
        private Bitmap bitmap;
        private int timerAnimation = 0;
        protected PositionMoving positMoving = PositionMoving.Stop;

        public int SpriteX
        {
            get
            {
                return spriteX;
            }
            set { spriteX = value; }
        }
        public int SpriteY
        {
            get
            {
                return spriteY;
            }
            set {spriteY = value; }
        }
        public int SpriteWidth
        {
            get
            {
                return spriteWidth;
            }
            set { if (spriteWidth >= 0)  spriteWidth = value; }
        }
        public int SpriteHeigth
        {
            get
            {
                return spriteHeigth;
            }
            set { if (spriteHeigth >= 0) spriteHeigth = value; }
        }
        public int TimerAnimation
        {
            get
            {
                return timerAnimation;
            }
            set { timerAnimation = value; }
        }
        public PositionMoving PositMoving
        {
            get
            {
                return positMoving;
            }
            set { positMoving = value; }
        }
        public Rectangle Rectangle
        {
            get
            {
                return rectangle;
            }
            set { rectangle = value; }
        }

        public Player() : base()
        {
            locateX = 150;
            locateY = 150;
            imageMapObject = Idoctor.Properties.Resources.anim;
            rectangle = new Rectangle(spriteX, spriteY, spriteWidth, spriteHeigth);
            bitmap = new Bitmap(rectangle.Width, rectangle.Height);
            
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

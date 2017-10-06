using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idoctor
{
    public class KeyPress
    {
        bool isDownUp = false;
        bool isDownRight = false;
        bool isDownDown = false;
        bool isDownLeft = false;
        bool isDownF = false;

        public bool IsDownUp
        {
            get
            {
                return isDownUp;
            }
            set { isDownUp = value; }
        }
        public bool IsDownDown
        {
            get
            {
                return isDownDown;
            }
            set { isDownDown = value; }
        }
        public bool IsDownLeft
        {
            get
            {
                return isDownLeft;
            }
            set { isDownLeft = value; }
        }
        public bool IsDownRight
        {
            get
            {
                return isDownRight;
            }
            set { isDownRight = value; }
        }
        public bool IsDownF
        {
            get
            {
                return isDownF;
            }
            set { isDownF = value; }
        }
    }
}

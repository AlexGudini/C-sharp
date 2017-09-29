using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idoctor
{
    public class KeyPress
    {
        bool isDownUp;
        bool isDownRight;
        bool isDownDown;
        bool isDownLeft;
        bool isDownF;

        public bool IsDownUp { get; set; }
        public bool IsDownRight { get; set; }
        public bool IsDownDown { get; set; }
        public bool IsDownLeft { get; set; }
        public bool IsDownF { get; set; }

        public KeyPress()
        {
            isDownUp = false;
            isDownRight = false;
            isDownDown = false;
            isDownLeft = false;
            isDownF = false;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Idoctor
{

    public class Patients: LocationObject
    {

        public Patients(): base()
        {
            this.imagePlayer = Idoctor.Properties.Resources.patient;
            this.LocateX = 320;
            this.LocateY = 320;
        }

    }
}

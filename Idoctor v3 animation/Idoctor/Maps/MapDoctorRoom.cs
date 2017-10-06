using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Idoctor
{
    public class MapDoctorRoom /*IEnumerator*/
    {
        //List<MapObject> listMapObjects = new List<MapObject>();
        Patients patient;
        MapFon mapFon;

        public MapDoctorRoom()
        {
            this.patient = new Patients(320, 320, Idoctor.Properties.Resources.patient);
            this.mapFon = new MapFon(Idoctor.Properties.Resources.floor);
        }

        public Patients GetPatient()
        {
            return this.patient;
        }

        public MapFon GetMapFon()
        {
            return this.mapFon;
        }
        //public void DrawRoom(Graphics graphic)
        //{

        //    Image floor = Idoctor.Properties.Resources.floor;
        //    graphic.DrawImage(floor, 0, 0);
        //    graphic.DrawImage(controller.GetGameModel().GetPatient().GetImagePlayer(),
        //       new Point(controller.GetGameModel().GetPatient().LocateX, controller.GetGameModel().GetPatient().LocateY));
        //}
    }
}

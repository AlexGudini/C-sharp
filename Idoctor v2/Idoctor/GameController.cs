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
    public interface IGameController
    {
        GameModel GetGameModel();
    }

    public class GameController
    {
        private GameView view;
        private GameModel model;
        private TaskController taskController;
        public GameController(GameView view, GameModel model)
        {
            this.view = view;
            this.model = model;
            this.view.SetGameConroller(this);
            this.view.DrawCharacter();

            Idoctor.Tasks.TaskView taskView = new Tasks.TaskView();
        }

        public void TimerMoving()
        {
            if (this.view.GetKeyPress().IsDownUp == true)
            {
                InteractionObjects helperWithInteration = new InteractionObjects(view.Location, view.Width, view.Height);
                Point pointSubject = new Point(model.GetPlayer().LocateX + view.Location.X, model.GetPlayer().LocateY + view.Location.Y - 5);
                int widthSubject = model.GetPlayer().GetRectangle().Width;
                int heightSubject = model.GetPlayer().GetRectangle().Height;
                if (helperWithInteration.IsLocated(pointSubject, widthSubject, heightSubject) == true)
                    this.model.GetPlayer().LocateY -= 10;
            }
                
            if (this.view.GetKeyPress().IsDownRight == true)
            {
                // костыль выходит на область сцены
                InteractionObjects helperWithInteration = new InteractionObjects(view.Location, view.Width - 20, view.Height);
                Point pointSubject = new Point(model.GetPlayer().LocateX + view.Location.X + 5, model.GetPlayer().LocateY + view.Location.Y);
                int widthSubject = model.GetPlayer().GetRectangle().Width;
                int heightSubject = model.GetPlayer().GetRectangle().Height;
                if (helperWithInteration.IsLocated(pointSubject, widthSubject, heightSubject) == true)
                    this.model.GetPlayer().LocateX += 10;
            }
                
            if (this.view.GetKeyPress().IsDownDown == true)
            {
                // костыль выходит на область сцены
                InteractionObjects helperWithInteration = new InteractionObjects(view.Location, view.Width, view.Height - 80);
                Point pointSubject = new Point(model.GetPlayer().LocateX + view.Location.X, model.GetPlayer().LocateY + view.Location.Y + 5);
                int widthSubject = model.GetPlayer().GetRectangle().Width;
                int heightSubject = model.GetPlayer().GetRectangle().Height;
                if (helperWithInteration.IsLocated(pointSubject, widthSubject, heightSubject) == true)
                    this.model.GetPlayer().LocateY += 10;
            }
                
            if (this.view.GetKeyPress().IsDownLeft == true)
            {
                InteractionObjects helperWithInteration = new InteractionObjects(view.Location, view.Width, view.Height);
                Point pointSubject = new Point(model.GetPlayer().LocateX + view.Location.X - 5, model.GetPlayer().LocateY + view.Location.Y);
                int widthSubject = model.GetPlayer().GetRectangle().Width;
                int heightSubject = model.GetPlayer().GetRectangle().Height;
                if (helperWithInteration.IsLocated(pointSubject, widthSubject, heightSubject) == true)
                    this.model.GetPlayer().LocateX -= 10;
            }
            
        }
        public void StartTask(bool isDownF)
        {
            if (this.view.GetKeyPress().IsDownF == true)
            {
                Point point = new Point(model.GetPlayer().LocateX, model.GetPlayer().LocateY);
                int w = model.GetPlayer().GetImagePlayer().Width;
                int h = model.GetPlayer().GetImagePlayer().Height;
                InteractionObjects player = new InteractionObjects(point, w, h);                                
                
                if (player.IsIntersection(new Point(model.GetPatient().LocateX - 30,
                                                      model.GetPatient().LocateY - 30),
                                                      model.GetPatient().GetImagePlayer().Width + 60,
                                                      model.GetPatient().GetImagePlayer().Height + 60) == true)
                {
                    this.taskController = new TaskController(new Tasks.TaskView(), new TaskModel());
                    this.taskController.GetTaskView().ShowDialog();
                    this.taskController.GetTaskView().Hide();
                }
                this.view.GetKeyPress().IsDownF = false;
            }
        }
        public GameModel GetGameModel()
        {
            return this.model;
        }
    }
}

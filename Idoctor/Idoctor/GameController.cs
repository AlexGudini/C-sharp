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
           // this.taskController = new TaskController(taskView, new TaskModel());
        }

        public void TimerMoving()
        {
            if (this.view.GetKeyPress().IsDownUp == true)
            {
                InteractionObjects helperWithInteration = new InteractionObjects(view.Location, view.Width, view.Height);
                Point pointSubject = new Point(model.GetPlayer().LocateX + view.Location.X, model.GetPlayer().LocateY + view.Location.Y - 5);
                int widthSubject = model.GetPlayer().GetImagePlayer().Width;
                int heightSubject = model.GetPlayer().GetImagePlayer().Height;
                if (helperWithInteration.IsLocated(pointSubject, widthSubject, heightSubject) == true)
                    this.model.GetPlayer().LocateY -= 5;
            }
                
            if (this.view.GetKeyPress().IsDownRight == true)
            {
                InteractionObjects helperWithInteration = new InteractionObjects(view.Location, view.Width, view.Height);
                Point pointSubject = new Point(model.GetPlayer().LocateX + view.Location.X + 5, model.GetPlayer().LocateY + view.Location.Y);
                int widthSubject = model.GetPlayer().GetImagePlayer().Width;
                int heightSubject = model.GetPlayer().GetImagePlayer().Height;
                if (helperWithInteration.IsLocated(pointSubject, widthSubject, heightSubject) == true)
                    this.model.GetPlayer().LocateX += 5;
            }
                
            if (this.view.GetKeyPress().IsDownDown == true)
            {
                InteractionObjects helperWithInteration = new InteractionObjects(view.Location, view.Width, view.Height);
                Point pointSubject = new Point(model.GetPlayer().LocateX + view.Location.X, model.GetPlayer().LocateY + view.Location.Y + 5);
                int widthSubject = model.GetPlayer().GetImagePlayer().Width;
                int heightSubject = model.GetPlayer().GetImagePlayer().Height;
                if (helperWithInteration.IsLocated(pointSubject, widthSubject, heightSubject) == true)
                    this.model.GetPlayer().LocateY += 5;
            }
                
            if (this.view.GetKeyPress().IsDownLeft == true)
            {
                InteractionObjects helperWithInteration = new InteractionObjects(view.Location, view.Width, view.Height);
                Point pointSubject = new Point(model.GetPlayer().LocateX + view.Location.X - 5, model.GetPlayer().LocateY + view.Location.Y);
                int widthSubject = model.GetPlayer().GetImagePlayer().Width;
                int heightSubject = model.GetPlayer().GetImagePlayer().Height;
                if (helperWithInteration.IsLocated(pointSubject, widthSubject, heightSubject) == true)
                    this.model.GetPlayer().LocateX -= 5;
            }
            

        }
        public void StartTask(bool isDownF)
        {
            if (this.view.GetKeyPress().IsDownF == true)
            {
                this.taskController = new TaskController(new Tasks.TaskView(), new TaskModel());
                this.taskController.GetTaskView().ShowDialog();
                this.taskController.GetTaskView().Hide();
                this.view.GetKeyPress().IsDownF = false;
            }
        }
        public GameModel GetGameModel()
        {
            return this.model;
        }
    }
}

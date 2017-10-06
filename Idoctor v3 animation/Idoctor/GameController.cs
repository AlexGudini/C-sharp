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
        //private TaskController taskController;
        public GameController(GameView view, GameModel model)
        {
            this.view = view;
            this.model = model;
            this.view.SetGameConroller(this);
            this.view.DrawCharacter();

            //Idoctor.Tasks.TaskView taskView = new Tasks.TaskView();
        }

        protected class SubjectInteraction
        {
            InteractionObjects helperInteration;
            Point pointSubject;
            int widthSubject;
            int heightSubject;
            public InteractionObjects HelperInteration
            {
                get
                {
                    return helperInteration;
                }
                set { helperInteration = value; }
            }
            public Point PointSubject
            {
                get
                {
                    return pointSubject;
                }
                set { pointSubject = value; }
            }
            public int WidthSubject
            {
                get
                {
                    return widthSubject;
                }
                set { widthSubject = value; }
            }
            public int HeightSubject
            {
                get
                {
                    return heightSubject;
                }
                set { heightSubject = value; }
            }

            public bool SetSubjectOfInteration( GameController controller, int dx, int dy)
            {
                HelperInteration = new InteractionObjects(controller.view.Location, controller.view.Width - 20, controller.view.Height - 70);
                PointSubject = new Point(controller.model.GetPlayer().LocateX + controller.view.Location.X + dx,
                                         controller.model.GetPlayer().LocateY + controller.view.Location.Y + dy);
                WidthSubject = controller.model.GetPlayer().GetRectangle().Width;
                HeightSubject = controller.model.GetPlayer().GetRectangle().Height;

                if (this.HelperInteration.IsLocated(this.PointSubject, this.WidthSubject, this.HeightSubject) == true)
                    return true;
                return false;
            }
        }

        public void MovingPlayerOnView()
        {
            SubjectInteraction subject = new SubjectInteraction();

            if (this.view.GetKeyPress().IsDownUp == true)
                if (subject.SetSubjectOfInteration(this, 0, -20))
                {
                    this.model.GetPlayer().LocateY -= 20;
                    view.DrawMap();
                }
                    
                
            if (this.view.GetKeyPress().IsDownRight == true)
            {
                if (subject.SetSubjectOfInteration(this, 20, 0))
                { 
                    this.model.GetPlayer().LocateX += 20;
                    view.DrawMap();
                }
            //// костыль выходит на область сцены
            //InteractionObjects helperWithInteration = new InteractionObjects(view.Location, view.Width - 20, view.Height);
            //Point pointSubject = new Point(model.GetPlayer().LocateX + view.Location.X + 15, model.GetPlayer().LocateY + view.Location.Y);
            //int widthSubject = model.GetPlayer().GetRectangle().Width;
            //int heightSubject = model.GetPlayer().GetRectangle().Height;
            //if (helperWithInteration.IsLocated(pointSubject, widthSubject, heightSubject) == true)
            //    this.model.GetPlayer().LocateX += 15;
            }
                
            if (this.view.GetKeyPress().IsDownDown == true)
            {
                if (subject.SetSubjectOfInteration(this, 0, 20))
                {
                    this.model.GetPlayer().LocateY += 20;
                    view.DrawMap();
                }
            }
                
            if (this.view.GetKeyPress().IsDownLeft == true)
            {
                if (subject.SetSubjectOfInteration(this, -20, 0))
                {
                    this.model.GetPlayer().LocateX -= 20;
                    view.DrawMap();
                }
            }
            
        }



        public void StartTask(bool isDownF)
        {
            if (this.view.GetKeyPress().IsDownF == true)
            {
                Point point = new Point(model.GetPlayer().LocateX, model.GetPlayer().LocateY);
                int w = model.GetPlayer().GetImage().Width;
                int h = model.GetPlayer().GetImage().Height;
                InteractionObjects player = new InteractionObjects(point, w, h);                                
                
                if (player.IsIntersection(new Point(model.GetPatient().LocateX - 30,
                                                      model.GetPatient().LocateY - 30),
                                                      model.GetPatient().GetImage().Width + 60,
                                                      model.GetPatient().GetImage().Height + 60) == true)
                {
                    TaskController taskController = new TaskController(new TaskModel(), new Tasks.TaskView() );
                    taskController.GetTaskView().ShowDialog();
                    taskController.GetTaskView().Hide();
                }
                this.view.GetKeyPress().IsDownF = false;
            }
        }

        public GameModel GetGameModel()
        {
            return this.model;
        }

        public void AnimationPlayer()
        {
            model.GetPlayer().TimerAnimation += 100;
            if (model.GetPlayer().TimerAnimation == 600) model.GetPlayer().TimerAnimation = 0;

            if (this.view.GetKeyPress().IsDownLeft == true) AnimationPlayerInLeft();
            else AnimationPlayerInRight();

            //if (this.GetGameModel().GetPlayer().PositMoving == PositionMoving.Stop)
            //    AnimationPlayerStop();
         }

        public void AnimationPlayerInRight()
        {
            model.GetPlayer().SpriteX += 84;
            if (model.GetPlayer().SpriteX >= 410) model.GetPlayer().SpriteX = 0;

            if(model.GetPlayer().SpriteY == 125 ) model.GetPlayer().SpriteY = 0;

            model.GetPlayer().Rectangle = new Rectangle(model.GetPlayer().SpriteX, model.GetPlayer().SpriteY,
                                    model.GetPlayer().SpriteWidth, model.GetPlayer().SpriteHeigth);
        }
        public void AnimationPlayerInLeft()
        {
            model.GetPlayer().SpriteX -= 84;
            if (model.GetPlayer().SpriteX <= 0) model.GetPlayer().SpriteX = 415;

            if (model.GetPlayer().SpriteY == 0) model.GetPlayer().SpriteY = 125;

            model.GetPlayer().Rectangle = new Rectangle(model.GetPlayer().SpriteX, model.GetPlayer().SpriteY,
                                    model.GetPlayer().SpriteWidth, model.GetPlayer().SpriteHeigth);
        }
        public void AnimationPlayerStop()
        {
            model.GetPlayer().SpriteX = 0;
            model.GetPlayer().SpriteY = 250;

            model.GetPlayer().Rectangle = new Rectangle(model.GetPlayer().SpriteX, model.GetPlayer().SpriteY,
                                    model.GetPlayer().SpriteWidth, model.GetPlayer().SpriteHeigth);
        }
    }
}

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
   
    public interface IGameView
    {
        void SetGameConroller(GameController _cotroller);
        KeyPress GetKeyPress();
    }

    public partial class GameView : Form, IGameView
    {
        private GameController controller;
        private KeyPress keyPress;
        
        public GameView()
        {
            InitializeComponent();
            keyPress = new Idoctor.KeyPress();
            
        }
        public void SetGameConroller(GameController _cotroller)
        {
            this.controller = _cotroller;
        }
        public KeyPress GetKeyPress()
        {
            return this.keyPress;
        }
        
        private void DrawGraphics(object sender, PaintEventArgs e)
        {
            DrawCharacter();
        }

        public void DrawCharacter()
        {

            Graphics graphic = this.CreateGraphics();
            graphic.Clear(Color.Wheat);
            graphic.DrawImage(controller.GetGameModel().GetPlayer().GetImagePlayer(), 
                new Point(controller.GetGameModel().GetPlayer().LocateX, controller.GetGameModel().GetPlayer().LocateY)) ;
            graphic.DrawImage(controller.GetGameModel().GetPatient().GetImagePlayer(),
               new Point(controller.GetGameModel().GetPatient().LocateX, controller.GetGameModel().GetPatient().LocateY));

        }

        private void timerMoving_Tick(object sender, EventArgs e)
        {
            controller.TimerMoving();
            DrawCharacter();
        }

        private void GameView_KeyDown(object sender, KeyEventArgs e)
        {
            this.timerMoving.Enabled = true;

            if (e.KeyCode == Keys.Up)
                keyPress.IsDownUp = true;
            if (e.KeyCode == Keys.Left)
                keyPress.IsDownLeft = true;

            if (e.KeyCode == Keys.Right)
                keyPress.IsDownRight = true;
            if (e.KeyCode == Keys.Down)
                keyPress.IsDownDown = true;
            if (e.KeyCode == Keys.F)
            {
                if(keyPress.IsDownF == false)
                {
                    keyPress.IsDownF = true;
                    controller.StartTask(true);
                }
                
            }
                
        }

        private void GameView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                keyPress.IsDownUp = false;
            if (e.KeyCode == Keys.Left)
                keyPress.IsDownLeft = false;

            if (e.KeyCode == Keys.Right)
                keyPress.IsDownRight = false;
            if (e.KeyCode == Keys.Down)
                keyPress.IsDownDown = false;
            
        }

        private void GameView_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}

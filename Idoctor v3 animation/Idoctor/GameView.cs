using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Reflection;
namespace Idoctor
{
    public interface IGameView
    {
        void SetGameConroller(GameController _cotroller);
        KeyPress GetKeyPress();
        void DrawCharacter();
    }

    public partial class GameView : Form, IGameView
    {
        private GameController controller;
        private KeyPress keyPress;
        private Graphics graphic;

        private BufferedGraphicsContext context;
        private BufferedGraphics bufferGraphics;

        public GameView()
        {
            InitializeComponent();
            keyPress = new Idoctor.KeyPress();
            this.graphic = this.CreateGraphics();
            //this.graphic.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //myBitmap = new Bitmap(this.Width, this.Height);
            context = BufferedGraphicsManager.Current;
            bufferGraphics = context.Allocate(graphic, this.DisplayRectangle);
            Timer timerRedrawing = new Timer();
            timerRedrawing.Interval = 100;
            timerRedrawing.Tick += TimerRedrawing_Tick;
            graphic.Clear(Color.Black);
            timerRedrawing.Start();
        }

        private void TimerRedrawing_Tick(object sender, EventArgs e)
        {
            DrawMap();
            DrawCharacter();
            

            bufferGraphics.Render();
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
            
            //this.DoubleBuffered = true;
            DrawCharacter();
        }
        public void DrawMap()
        {
            MapDoctorRoom doctorRoom = new MapDoctorRoom();



            //Image floor = Idoctor.Properties.Resources.floor;
            //graphic.DrawImage(myBitmap, this.Location.X, this.Location.Y);
            bufferGraphics.Graphics.DrawImage(doctorRoom.GetMapFon().GetImage(), 0, 0);

            bufferGraphics.Graphics.DrawImage(doctorRoom.GetPatient().GetImage(),
                              doctorRoom.GetPatient().LocateX,
                              doctorRoom.GetPatient().LocateY);

            //graphic.GetType().GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(graphic, true, null);

        }

        public void DrawCharacter()
        {
           
            Image img1 = controller.GetGameModel().GetPlayer().GetImage();
            int x = controller.GetGameModel().GetPlayer().LocateX;
            int y = controller.GetGameModel().GetPlayer().LocateY;
            Rectangle rect = controller.GetGameModel().GetPlayer().GetRectangle();


            //if (this.GetPlayer().SpriteY = 0)
            //    controller.GetGameModel().GetPlayer().GetImage().RotateFlip(RotateFlipType.Rotate180FlipNone);

            //else if (this.GetKeyPress().IsDownRight == true) { }

            bufferGraphics.Graphics.DrawImage(img1, x, y, rect, GraphicsUnit.Pixel);
            
           
        }

        private void timerMoving_Tick(object sender, EventArgs e)
        {
            //bufferedGraphics.Graphics.DrawImage(0, 0, this.Size);
            //bufferedGraphics.Graphics.DrawImage( this.Size);
            //bufferedGraphics.Render();

            
            //controller.MovingPlayerOnView();
            DrawCharacter();
            controller.AnimationPlayer();
            controller.MovingPlayerOnView();
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
                    timerMoving.Enabled = false;
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
            
            if(keyPress.IsDownUp == keyPress.IsDownLeft == keyPress.IsDownRight == keyPress.IsDownDown)
            {
                timerMoving.Enabled = false;
            }

            controller.GetGameModel().GetPlayer().SpriteX = 0;
        }

        private void GameView_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void GameView_Load(object sender, EventArgs e)
        {

        }
    }
}

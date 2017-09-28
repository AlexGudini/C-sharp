namespace Idoctor
{
    public partial class GameView
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerMoving = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timerMoving
            // 
            this.timerMoving.Interval = 50;
            this.timerMoving.Tick += new System.EventHandler(this.timerMoving_Tick);
            // 
            // GameView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 415);
            this.Name = "GameView";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawGraphics);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameView_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GameView_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameView_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Timer timerMoving;
    }
}


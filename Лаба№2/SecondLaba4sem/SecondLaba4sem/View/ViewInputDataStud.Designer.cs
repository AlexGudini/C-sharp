namespace SecondLaba4sem
{
    partial class ViewInputDataStud
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ViewInputDataStud
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Name = "ViewInputDataStud";
            this.Load += new System.EventHandler(this.ViewInputDataStud_Load);
            this.ResumeLayout(false);

            this.textRemoveSurname = new System.Windows.Forms.TextBox();
            this.textRemoveName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textRemoveSurname
            // 
            this.textRemoveSurname.Location = new System.Drawing.Point(111, 101);
            this.textRemoveSurname.Name = "textRemoveSurname";
            this.textRemoveSurname.Size = new System.Drawing.Size(100, 20);
            this.textRemoveSurname.TabIndex = 0;
            // 
            // textRemoveName
            // 
            this.textRemoveName.Location = new System.Drawing.Point(111, 50);
            this.textRemoveName.Name = "textRemoveName";
            this.textRemoveName.Size = new System.Drawing.Size(100, 20);
            this.textRemoveName.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Имя";
            // 
            // ViewRemoveStud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textRemoveName);
            this.Controls.Add(this.textRemoveSurname);
            this.Name = "ViewRemoveStud";
            this.Text = "ViewRemoveStud";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textRemoveSurname;
        private System.Windows.Forms.TextBox textRemoveName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
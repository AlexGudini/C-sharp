namespace SecondLaba4sem
{
    partial class MainView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.butSaveFile = new System.Windows.Forms.Button();
            this.butOpenFile = new System.Windows.Forms.Button();
            this.butRemoveStud = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonFirstStud = new System.Windows.Forms.Button();
            this.buttonLastStud = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonSearchStud = new System.Windows.Forms.Button();
            this.labelCountStud = new System.Windows.Forms.Label();
            this.comboBoxCountPage = new System.Windows.Forms.ComboBox();
            this.labelCurrentPage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // butSaveFile
            // 
            this.butSaveFile.Location = new System.Drawing.Point(22, 72);
            this.butSaveFile.Name = "butSaveFile";
            this.butSaveFile.Size = new System.Drawing.Size(95, 46);
            this.butSaveFile.TabIndex = 0;
            this.butSaveFile.Text = "Save";
            this.butSaveFile.UseVisualStyleBackColor = true;
            this.butSaveFile.Click += new System.EventHandler(this.butSaveFile_Click);
            // 
            // butOpenFile
            // 
            this.butOpenFile.Location = new System.Drawing.Point(22, 138);
            this.butOpenFile.Name = "butOpenFile";
            this.butOpenFile.Size = new System.Drawing.Size(95, 47);
            this.butOpenFile.TabIndex = 1;
            this.butOpenFile.Text = "Open";
            this.butOpenFile.UseVisualStyleBackColor = true;
            this.butOpenFile.Click += new System.EventHandler(this.butOpenFile_Click);
            // 
            // butRemoveStud
            // 
            this.butRemoveStud.Location = new System.Drawing.Point(197, 3);
            this.butRemoveStud.Name = "butRemoveStud";
            this.butRemoveStud.Size = new System.Drawing.Size(79, 51);
            this.butRemoveStud.TabIndex = 3;
            this.butRemoveStud.Text = "Remove stud";
            this.butRemoveStud.UseVisualStyleBackColor = true;
            this.butRemoveStud.Click += new System.EventHandler(this.butRemoveStud_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(113, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(78, 51);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add student";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView.Location = new System.Drawing.Point(145, 72);
            this.dataGridView.Name = "dataGridView";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView.Size = new System.Drawing.Size(618, 155);
            this.dataGridView.TabIndex = 2;
            // 
            // Column1
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle15;
            this.Column1.FillWeight = 150F;
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "ФИО";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Группа";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle16;
            this.Column3.FillWeight = 200F;
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "По болезни";
            this.Column3.Name = "Column3";
            this.Column3.Width = 84;
            // 
            // Column4
            // 
            this.Column4.Frozen = true;
            this.Column4.HeaderText = "По другим причинам";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Без уважительной причины";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Итого";
            this.Column6.Name = "Column6";
            // 
            // buttonFirstStud
            // 
            this.buttonFirstStud.Location = new System.Drawing.Point(402, 20);
            this.buttonFirstStud.Name = "buttonFirstStud";
            this.buttonFirstStud.Size = new System.Drawing.Size(45, 34);
            this.buttonFirstStud.TabIndex = 4;
            this.buttonFirstStud.Text = "1-ая";
            this.buttonFirstStud.UseVisualStyleBackColor = true;
            this.buttonFirstStud.Click += new System.EventHandler(this.buttonFirstStud_Click);
            // 
            // buttonLastStud
            // 
            this.buttonLastStud.Location = new System.Drawing.Point(444, 20);
            this.buttonLastStud.Name = "buttonLastStud";
            this.buttonLastStud.Size = new System.Drawing.Size(45, 34);
            this.buttonLastStud.TabIndex = 5;
            this.buttonLastStud.UseVisualStyleBackColor = true;
            this.buttonLastStud.Click += new System.EventHandler(this.buttonLastStud_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(485, 20);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(46, 34);
            this.buttonPrevious.TabIndex = 6;
            this.buttonPrevious.Text = "<<";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(526, 20);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(47, 34);
            this.buttonNext.TabIndex = 7;
            this.buttonNext.Text = ">>";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonSearchStud
            // 
            this.buttonSearchStud.Location = new System.Drawing.Point(283, 3);
            this.buttonSearchStud.Name = "buttonSearchStud";
            this.buttonSearchStud.Size = new System.Drawing.Size(82, 51);
            this.buttonSearchStud.TabIndex = 8;
            this.buttonSearchStud.Text = "Search stud";
            this.buttonSearchStud.UseVisualStyleBackColor = true;
            this.buttonSearchStud.Click += new System.EventHandler(this.buttonSearchStud_Click);
            // 
            // labelCountStud
            // 
            this.labelCountStud.AutoSize = true;
            this.labelCountStud.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.labelCountStud.Location = new System.Drawing.Point(590, 22);
            this.labelCountStud.Name = "labelCountStud";
            this.labelCountStud.Size = new System.Drawing.Size(13, 13);
            this.labelCountStud.TabIndex = 9;
            this.labelCountStud.Text = "  ";
            // 
            // comboBoxCountPage
            // 
            this.comboBoxCountPage.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBoxCountPage.FormattingEnabled = true;
            this.comboBoxCountPage.Items.AddRange(new object[] {
            "5",
            "10",
            "15"});
            this.comboBoxCountPage.Location = new System.Drawing.Point(22, 256);
            this.comboBoxCountPage.Name = "comboBoxCountPage";
            this.comboBoxCountPage.Size = new System.Drawing.Size(95, 21);
            this.comboBoxCountPage.TabIndex = 10;
            this.comboBoxCountPage.SelectedIndexChanged += new System.EventHandler(this.comboBoxCountPage_SelectedIndexChanged);
            // 
            // labelCurrentPage
            // 
            this.labelCurrentPage.AutoSize = true;
            this.labelCurrentPage.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelCurrentPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCurrentPage.Location = new System.Drawing.Point(590, 56);
            this.labelCurrentPage.Name = "labelCurrentPage";
            this.labelCurrentPage.Size = new System.Drawing.Size(10, 13);
            this.labelCurrentPage.TabIndex = 11;
            this.labelCurrentPage.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Кол-во строчек";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 451);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCurrentPage);
            this.Controls.Add(this.comboBoxCountPage);
            this.Controls.Add(this.labelCountStud);
            this.Controls.Add(this.buttonSearchStud);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonLastStud);
            this.Controls.Add(this.buttonFirstStud);
            this.Controls.Add(this.butOpenFile);
            this.Controls.Add(this.butSaveFile);
            this.Controls.Add(this.butRemoveStud);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.addButton);
            this.Name = "MainView";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button butRemoveStud;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button butSaveFile;
        private System.Windows.Forms.Button butOpenFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button buttonFirstStud;
        private System.Windows.Forms.Button buttonLastStud;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonSearchStud;
        private System.Windows.Forms.Label labelCountStud;
        private System.Windows.Forms.ComboBox comboBoxCountPage;
        private System.Windows.Forms.Label labelCurrentPage;
        private System.Windows.Forms.Label label1;
    }
}


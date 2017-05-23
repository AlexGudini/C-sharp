using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondLaba4sem
{
    public class ShowMainForms : Form
    {
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button butOptionGenerate;
        private System.Windows.Forms.Button buttonLastStud;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonFirstStud;
        private System.Windows.Forms.Label labelCountStud;
        private System.Windows.Forms.ComboBox comboBoxOptionSearch;
        private System.Windows.Forms.Label labelCurrentPage;
        private System.Windows.Forms.ComboBox comboBoxCountPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        public DataGridView DataGridView
        {
            get { return dataGridView; }
        }
        public Button ButOptionGenerate
        {
            get { return butOptionGenerate; }
        }
        public Button ButtonLastStud
        {
            get { return buttonLastStud; }
        }
        public Button ButtonPrevious
        {
            get { return buttonPrevious; }
        }
        public Button ButtonNext
        {
            get { return buttonNext; }
        }
        public Button ButtonFirstStud
        {
            get { return buttonFirstStud; }
        }

        public Label LabelCountStud
        {
            get { return labelCountStud; }
        }
        public ComboBox ComboBoxOptionSearch
        {
            get { return comboBoxOptionSearch; }
        }
        public Label LabelCurrentPage
        {
            get { return labelCurrentPage; }
        }
        public ComboBox ComboBoxCountPage
        {
            get { return comboBoxCountPage; }
        }
        public Label Label1
        {
            get { return label1; }
        }
        public Label Label2
        {
            get { return label2; }
        }
        public ShowMainForms()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butOptionGenerate = new System.Windows.Forms.Button();
            this.buttonLastStud = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonFirstStud = new System.Windows.Forms.Button();
            this.labelCountStud = new System.Windows.Forms.Label();
            this.comboBoxOptionSearch = new System.Windows.Forms.ComboBox();
            this.labelCurrentPage = new System.Windows.Forms.Label();
            this.comboBoxCountPage = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView.Location = new System.Drawing.Point(-1, 73);
            this.dataGridView.Name = "dataGridView";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView.Size = new System.Drawing.Size(627, 174);
            this.dataGridView.TabIndex = 3;
            // 
            // Column1
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle4;
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
            // butOptionGenerate
            // 
            this.butOptionGenerate.Location = new System.Drawing.Point(740, 63);
            this.butOptionGenerate.Name = "butOptionGenerate";
            this.butOptionGenerate.Size = new System.Drawing.Size(75, 23);
            this.butOptionGenerate.TabIndex = 4;
            this.butOptionGenerate.Text = "Generate";
            this.butOptionGenerate.UseVisualStyleBackColor = true;
            
            // 
            // buttonLastStud
            // 
            this.buttonLastStud.Location = new System.Drawing.Point(209, 23);
            this.buttonLastStud.Name = "buttonLastStud";
            this.buttonLastStud.Size = new System.Drawing.Size(45, 34);
            this.buttonLastStud.TabIndex = 10;
            this.buttonLastStud.UseVisualStyleBackColor = true;
          //  this.buttonLastStud.Click += new System.EventHandler(this.buttonLastStud_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(250, 23);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(46, 34);
            this.buttonPrevious.TabIndex = 11;
            this.buttonPrevious.Text = "<<";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            //this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(291, 23);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(47, 34);
            this.buttonNext.TabIndex = 12;
            this.buttonNext.Text = ">>";
            this.buttonNext.UseVisualStyleBackColor = true;
           // this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonFirstStud
            // 
            this.buttonFirstStud.Location = new System.Drawing.Point(167, 23);
            this.buttonFirstStud.Name = "buttonFirstStud";
            this.buttonFirstStud.Size = new System.Drawing.Size(45, 34);
            this.buttonFirstStud.TabIndex = 9;
            this.buttonFirstStud.Text = "1-ая";
            this.buttonFirstStud.UseVisualStyleBackColor = true;
            //this.buttonFirstStud.Click += new System.EventHandler(this.buttonFirstStud_Click);
            // 
            // labelCountStud
            // 
            this.labelCountStud.AutoSize = true;
            this.labelCountStud.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelCountStud.Location = new System.Drawing.Point(370, 44);
            this.labelCountStud.Name = "labelCountStud";
            this.labelCountStud.Size = new System.Drawing.Size(16, 13);
            this.labelCountStud.TabIndex = 13;
            this.labelCountStud.Text = " 0";
            // 
            // comboBoxOptionSearch
            // 
            this.comboBoxOptionSearch.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBoxOptionSearch.FormattingEnabled = true;
            this.comboBoxOptionSearch.Items.AddRange(new object[] {
            "-по номеру группы и фамилии студента",
            "-по фамилии студента и виду пропуска",
            "-по фамилии студента и количеству пропусков по видам "});
            this.comboBoxOptionSearch.Location = new System.Drawing.Point(632, 96);
            this.comboBoxOptionSearch.Name = "comboBoxOptionSearch";
            this.comboBoxOptionSearch.Size = new System.Drawing.Size(183, 21);
            this.comboBoxOptionSearch.TabIndex = 14;
           // this.comboBoxOptionSearch.SelectedIndexChanged += new System.EventHandler(this.comboBoxOptionSearch_SelectedIndexChanged);
            // 
            // labelCurrentPage
            // 
            this.labelCurrentPage.AutoSize = true;
            this.labelCurrentPage.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelCurrentPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCurrentPage.Location = new System.Drawing.Point(370, 23);
            this.labelCurrentPage.Name = "labelCurrentPage";
            this.labelCurrentPage.Size = new System.Drawing.Size(10, 13);
            this.labelCurrentPage.TabIndex = 15;
            this.labelCurrentPage.Text = " ";
            // 
            // comboBoxCountPage
            // 
            this.comboBoxCountPage.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBoxCountPage.FormattingEnabled = true;
            this.comboBoxCountPage.Items.AddRange(new object[] {
            "5",
            "10",
            "15"});
            this.comboBoxCountPage.Location = new System.Drawing.Point(658, 17);
            this.comboBoxCountPage.Name = "comboBoxCountPage";
            this.comboBoxCountPage.Size = new System.Drawing.Size(95, 21);
            this.comboBoxCountPage.TabIndex = 16;
           // this.comboBoxCountPage.SelectedIndexChanged += new System.EventHandler(this.comboBoxCountPage_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(568, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Кол-во строчек";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(632, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Вариант поиска";
            // 
            // ViewSearchResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 551);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCountPage);
            this.Controls.Add(this.labelCurrentPage);
            this.Controls.Add(this.comboBoxOptionSearch);
            this.Controls.Add(this.labelCountStud);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonLastStud);
            this.Controls.Add(this.buttonFirstStud);
            this.Controls.Add(this.butOptionGenerate);
            this.Controls.Add(this.dataGridView);
            this.Name = "ViewSearchResult";
            this.Text = "ViewSearchResult";
            //this.Load += new System.EventHandler(this.ViewSearchResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

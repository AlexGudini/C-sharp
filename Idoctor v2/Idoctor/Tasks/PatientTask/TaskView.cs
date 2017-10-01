using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Idoctor;
namespace Idoctor.Tasks
{
    public partial class TaskView : Form
    {
        List<Question> listQuest = new List<Question>();
        TaskController controller;
        public event EventHandler answerQuest;
        public TaskView()
        {
            InitializeComponent();
            listQuest = (new ParserXml()).OpenFileFromXml("Tasks.xml");
            SetQuestion();
        }
        public void SetTaskController(TaskController controller)
        {
            this.controller = controller;
        }

        public void SetQuestion()
        {
            foreach (Question quest in this.listQuest)
            {
                this.labelTask.Text = quest.ask;
                this.checkBox1.Text = quest.correct;
                this.checkBox2.Text = quest.mistake1;
                this.checkBox3.Text = quest.mistake2;
            }
        }
        private void btnAnswer_Click(object sender, EventArgs e)
        {
            //answerQuest.Invoke(sender, e);
            if (checkBox1.Checked == true && checkBox2.Checked == false && checkBox3.Checked == false)
                MessageBox.Show(" Правильный ответ");
            else
                MessageBox.Show(" Неправильный ответ");
        }
    }
}

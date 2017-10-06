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
        string listAnswer; // ответ выбранный игроком
        TaskController controller;
        Question intermediateQuest;
        public event EventHandler answerQuest;

        public TaskView()
        {
            InitializeComponent();     
        }
        public void SetTaskController(TaskController controller)
        {
            this.controller = controller;
            DisplayQuestion(); // отображение таска
        }

        public void DisplayQuestion()
        {
            UpdateTaskViewListQuest();
            int chooseQuestion = controller.GenerateQuestion();
            this.intermediateQuest = this.listQuest[chooseQuestion];
 
            List<string> boxxer = new List<string>();
            boxxer.Add(intermediateQuest.Correct);
            boxxer.Add(intermediateQuest.Mistake1);
            boxxer.Add(intermediateQuest.Mistake2);
            boxxer = controller.MixQuestion(boxxer);

            this.labelTask.Text = intermediateQuest.Ask;
            this.checkBox1.Text = boxxer[0];
            this.checkBox2.Text = boxxer[1];
            this.checkBox3.Text = boxxer[2];
        }
        public void UpdateTaskViewListQuest()
        {
            this.listQuest = controller.GetTaskModel().GetListQuestion();
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                listAnswer = checkBox1.Text;
            if (checkBox2.Checked == true)
                listAnswer = checkBox2.Text;
            if (checkBox3.Checked == true)
                listAnswer = checkBox3.Text;

            controller.GetResultQuestion(intermediateQuest, listAnswer);            
            UpdateTaskViewListQuest();//обновление инфо о том как ответил игрок
        }
    }
}

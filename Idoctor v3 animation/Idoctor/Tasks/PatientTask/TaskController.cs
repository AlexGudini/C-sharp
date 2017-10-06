using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using Idoctor.Tasks;

namespace Idoctor
{
    public class TaskController
    {
        TaskModel taskModel;
        TaskView taskView;

        public TaskController(TaskModel taskModel, TaskView taskView )
        {
            this.taskModel = taskModel;
            this.taskView = taskView;
            this.taskView.Enabled = true;
            taskView.answerQuest += TaskView_answerQuest;
            this.taskView.SetTaskController(this);
        }
        public void GetResultQuestion(Question question, string listAnswer)
        {
            int indexQuest = taskModel.GetListQuestion().IndexOf(question);
            if (listAnswer == taskModel.GetListQuestion()[indexQuest].Correct)
            {
                // запомнили что юзер отвечает
                taskModel.GetListQuestion()[indexQuest].AnswerUser = AnswerUser.trueAnswer;
                MessageBox.Show("Правильный ответ");
            }
            else
            {
                taskModel.GetListQuestion()[indexQuest].AnswerUser = AnswerUser.falseAnswer;
                MessageBox.Show("Неправильный ответ");
            }
                
           
        }
        public int GenerateQuestion()
        {
            Random rand = new Random();
            int indexQuestion = rand.Next(0, taskModel.GetListQuestion().Count);
            return indexQuestion;
        }
        public List<string> MixQuestion(List<string> boxxer)
        {
            for (int i = 0; i < 5; i++)
            {
                Random rand = new Random();
                int indexQuestion = rand.Next(0, 3);
                int indexQuestion2 = rand.Next(0, 3);
                string buf = boxxer[indexQuestion];
                boxxer[indexQuestion] = boxxer[indexQuestion2];
                boxxer[indexQuestion2] = buf;
            }
            return boxxer;
        }
        public TaskModel GetTaskModel()
        {
            return taskModel;
        }
        public TaskView GetTaskView()
        {
            return taskView;
        }

        private void TaskView_answerQuest(object sender, EventArgs e)
        {

        }
    }
}

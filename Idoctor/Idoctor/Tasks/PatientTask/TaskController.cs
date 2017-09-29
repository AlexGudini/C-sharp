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

        public TaskController(TaskView taskView, TaskModel taskModel)
        {
            this.taskView = taskView;
            this.taskModel = taskModel;
            this.taskView.Enabled = true;
            taskView.answerQuest += TaskView_answerQuest;
            this.taskView.SetTaskController(this);
        }

        private void TaskView_answerQuest(object sender, EventArgs e)
        {
            //if (taskView.checkBox1.Checked == true)
            //{

            //}
            //if (taskView.checkBox2.Checked == true)
            //{

            //}
            //if (taskView.checkBox3.Checked == true)
            //{

            //}
        }
        public TaskModel GetTaskModel()
        {
            return taskModel;
        }
        public TaskView GetTaskView()
        {
            return taskView;
        }
    }
}

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
    public partial class ViewInputDataStud : Form
    {
        private ViewResult viewResult;
        public Controller controller;
        public ViewInputDataStud(Controller controll)
        {
            controller = controll;
            InitializeComponent();

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Проверка на заполненность полей, если поле должно быть пустым то ставим пробел чтобы схавало
            while (textRemoveName.Text == "" || textRemoveSurname.Text == "")
            {
                return;
            }

            int buf = controller.Model.list.Count; // для подсчета кол-ва удаленных студентов из списка
            controller.RemoveStudent(new Student(new Human(textRemoveName.Text, textRemoveSurname.Text), 0, 0, 0 , 0));
            buf = buf - controller.Model.list.Count;

            if( buf == 0)
                viewResult = new ViewResult(" Не найдено", "");
            else
                viewResult = new ViewResult("  Удаление", "количество: " + buf.ToString());

            viewResult.ShowDialog();
            this.Close();
        }

        private void ViewInputDataStud_Load(object sender, EventArgs e)
        {

        }
    }
}

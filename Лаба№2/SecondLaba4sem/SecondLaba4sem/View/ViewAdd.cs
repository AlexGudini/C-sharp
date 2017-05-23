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

    // Вьюшка для добавление студентов в список
    public partial class ViewAdd : Form
    {
        private Controller controller;

        private ViewResult viewResult;

        public ViewAdd(Controller control)
        {
            controller = control;
            InitializeComponent();


        }

        #region Обработка событий
        private void butFormOk_Click(object sender, EventArgs e)
        {
            // Проверка на заполненность полей, если поле должно быть пустым то ставим пробел чтобы схавало
            while(textBoxName.Text == "" || textBoxSurName.Text == "" || textBoxInputGroup.Text == "" ||
                textBoxCount1.Text == "" || textBoxCount2.Text == "" || textBoxCount3.Text == "")
            {
                return;
            }
                
            controller.AddStudent(new Student(  new Human(textBoxName.Text, textBoxSurName.Text),
                                                Convert.ToInt32(textBoxInputGroup.Text),
                                                Convert.ToInt32(textBoxCount1.Text),
                                                Convert.ToInt32(textBoxCount2.Text),
                                                Convert.ToInt32(textBoxCount3.Text)
                                             )
                                 );
            this.Close();

            viewResult = new ViewResult("Успешное добавление"," "); 
            viewResult.ShowDialog();
        }
        #endregion

        #region Пустые фун-ии
        public void CreateFormView()
        {

        }

        private void FormAdd_Load(object sender, EventArgs e)
        {

        }
        #endregion

        private void ViewAdd_Load(object sender, EventArgs e)
        {

        }
    }
}

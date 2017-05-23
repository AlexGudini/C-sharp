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
    public partial class ViewRemove : ShowMainForms
    {
        public ViewRemove()
        {
           // InitializeComponent();
        }

       
        private FirstOptionComboBox firstOption; //первый вариант поиска
        private SecondOptionComboBox secondOption; //второй вариант поиска
        private ThirdOptionComboBox thirdOption;
        private Controller controller;
        private int indexDataGrid;
        private int countRowDataGrid; // кол-во строчек в DataGridView в данный момент
        private int currentPageDataGrid; // текущая страница таблицы
        private int option;

        public ViewRemove(Controller controller): base()
        {
            
            option = 0;
            indexDataGrid = 0;
            currentPageDataGrid = 1;
            countRowDataGrid = 5; //по умолчанию 5 строчек в таблице отображаются
            firstOption = new FirstOptionComboBox(Controls);
            secondOption = new SecondOptionComboBox(Controls);
            thirdOption = new ThirdOptionComboBox(Controls);
            secondOption.comboBoxSecondOption.SelectedIndexChanged += new System.EventHandler(this.comboBoxSecondOption_SelectedIndexChanged);
            thirdOption.comboBoxThirdOption.SelectedIndexChanged += new System.EventHandler(this.comboBoxThirdOption_SelectedIndexChanged);

            ButOptionGenerate.Click += new System.EventHandler(this.butDeleteResult_Click);

            ButtonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            ButtonNext.Click += new System.EventHandler(this.buttonNext_Click);
            ButtonFirstStud.Click += new System.EventHandler(this.buttonFirstStud_Click);
            ComboBoxOptionSearch.SelectedIndexChanged += new System.EventHandler(this.comboBoxOptionSearch_SelectedIndexChanged);
            ComboBoxCountPage.SelectedIndexChanged += new System.EventHandler(this.comboBoxCountPage_SelectedIndexChanged);

            ButtonLastStud.Click += new System.EventHandler(this.buttonLastStud_Click);
            // ButOptionGenerate.SelectedIndexChanged += new System.EventHandler(this.butDeleteResult_Click);

            ButOptionGenerate.Text = "Delete";
            this.controller = controller;
            UpdateView(controller.Model.list);
        }

        private void butDeleteResult_Click(object sender, EventArgs e)
        {
            if (option == 1) controller.Model.bufferList = firstOption.SortList(controller.Model.list);
            if (option == 3) controller.Model.bufferList = thirdOption.ChooseSortList(controller.Model.list);

            DeleteStudents(controller.Model.list, controller.Model.bufferList);
            UpdateView(controller.Model.list);
        }

        public void DeleteStudents(List<Student> list, List<Student> deleteList)
        {
            
             foreach (Student iStudentBufList in deleteList)
                {
                    controller.Model.list.Remove(iStudentBufList);
                }

            controller.Model.bufferList.Clear();
            foreach (Student iStudentList in controller.Model.list) // Обновление 
            {
                controller.Model.bufferList.Add(iStudentList);
            }

        }

        public void UpdateView(List<Student> list)
        {
            DataGridView.Rows.Clear();
            int nIndex = 0;
            foreach (Student iStudent in list) // Обновление 
            {
                if (indexDataGrid <= nIndex && nIndex < indexDataGrid + countRowDataGrid)
                {

                    DataGridView.Rows.Add(iStudent.GetHuman().GetName() + ' ' + iStudent.GetHuman().GetSurname(),
                                        iStudent.GetGroup(),
                                        iStudent.GetDisease(),
                                        iStudent.GetOtherReason(),
                                        iStudent.GetDisrespectfulReason(),
                                        iStudent.GetTotal()
                                     );

                }
                nIndex++;
            }
            ButtonLastStud.Text = ((list.Count - 1) / countRowDataGrid + 1).ToString() + " ст.";  // кол-во страниц (зависит от мн-во студентов)
            LabelCountStud.Text = "Count: " + (list.Count).ToString(); //отображение кол-ва студентов

            LabelCurrentPage.Text = currentPageDataGrid.ToString() + " из " + ButtonLastStud.Text; //
        }

        private void buttonFirstStud_Click(object sender, EventArgs e)
        {
            currentPageDataGrid = 1;// текущая страница 1
            indexDataGrid = 0;
            UpdateView(controller.Model.bufferList); // лист содержит определенных студентов
        }

        private void buttonLastStud_Click(object sender, EventArgs e)
        {
            currentPageDataGrid = Convert.ToInt32(Math.Ceiling((float)controller.Model.bufferList.Count / (float)countRowDataGrid));// текущая страница последняя

            indexDataGrid = (currentPageDataGrid - 1) * countRowDataGrid; // изменен. индекс первой строчки текущ страницы
            ButtonLastStud.Text = (controller.Model.bufferList.Count / countRowDataGrid).ToString() + " ст.";
            UpdateView(controller.Model.bufferList);
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (currentPageDataGrid - 1 >= 1)
                currentPageDataGrid--; // текущая страница на минус 1

            indexDataGrid = indexDataGrid - countRowDataGrid;
            if (indexDataGrid < 0)
                indexDataGrid = 0;

            UpdateView(controller.Model.bufferList);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (currentPageDataGrid + 1 <= Convert.ToInt32(Math.Ceiling((float)controller.Model.bufferList.Count / (float)countRowDataGrid))) // проверка, 4 ст. из 4, не выходило за пределы
                currentPageDataGrid++;

            if (indexDataGrid + 1 + countRowDataGrid <= controller.Model.bufferList.Count)
                indexDataGrid = indexDataGrid + countRowDataGrid;

            UpdateView(controller.Model.bufferList);
        }

        private void comboBoxOptionSearch_SelectedIndexChanged(object sender, EventArgs e) // вариант поиска
        {
            for (int i = 0; i < ComboBoxOptionSearch.Items.Count; i++)
            {

                if (ComboBoxOptionSearch.SelectedItem.ToString() == "-по номеру группы и фамилии студента")
                {
                    option = 1;
                    firstOption.SetVisible();
                    secondOption.SetInVisible();
                    thirdOption.SetInVisible();
                    break;
                }
                else if (ComboBoxOptionSearch.SelectedItem.ToString() == "-по фамилии студента и виду пропуска")
                {
                    option = 2;
                    secondOption.SetVisible();
                    firstOption.SetInVisible();
                    thirdOption.SetInVisible();
                    break;
                }
                else if (ComboBoxOptionSearch.SelectedItem.ToString() == "-по фамилии студента и количеству пропусков по видам ")
                {
                    option = 3;
                    thirdOption.SetVisible();
                    firstOption.SetInVisible();
                    secondOption.SetInVisible();
                    break;
                }

            }
        }

        private void comboBoxCountPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGridView.Height = 46 + 22 * Convert.ToInt32(ComboBoxCountPage.Text); // 46- заголовок, 22-высота ячейки
            countRowDataGrid = Convert.ToInt32(ComboBoxCountPage.Text); // кол-во строчек в таблице

            indexDataGrid = 0; //при изменении размеров переход на 0 интекс List
            currentPageDataGrid = 1; // при изменении размеров переход на 1 страницу
            if (controller.Model.bufferList.Count != 0)
                UpdateView(controller.Model.bufferList);
            else
                UpdateView(controller.Model.list); // обновить при изменениее
        }

        private void comboBoxSecondOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            int n = secondOption.IndexSecondOptionComboBox();
            if (secondOption.IndexSecondOptionComboBox() == 1)
            {
                controller.Model.bufferList = secondOption.SortList1(controller.Model.list);
            }
            else if (secondOption.IndexSecondOptionComboBox() == 2)
            {
                controller.Model.bufferList = secondOption.SortList2(controller.Model.list);
            }
            else if (secondOption.IndexSecondOptionComboBox() == 3)
            {
                controller.Model.bufferList = secondOption.SortList3(controller.Model.list);
            }
            else if (secondOption.IndexSecondOptionComboBox() == 4)
            {
                controller.Model.bufferList = secondOption.SortList4(controller.Model.list);
            }
        }

        private void comboBoxThirdOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            option = 3;
            int n = thirdOption.IndexThirdOptionComboBox();
        }
        private void ViewRemove_Load(object sender, EventArgs e)
        {

        }
    }
}

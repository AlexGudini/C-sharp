using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SecondLaba4sem
{
    public partial class MainView : Form, IMainView  //View-шка
    {
        //--------------Объявление----------------//
        private Controller controller;

        private ViewAdd formadd;
        private ViewInputDataStud formRemove;
        private ViewResult viewResult;
        //private ViewInputDataForSearch viewSearch;

        private int indexDataGrid;
        private int countRowDataGrid; // кол-во строчек в DataGridView в данный момент
        private int currentPageDataGrid; // текущая страница таблицы
        //--------------Конструктор---------------//

        public MainView()
        {
            InitializeComponent();

            countRowDataGrid = 5; // по умолчанию 5 строчек в DatagridView
            indexDataGrid = 0; // с какого индекса начинается вывод список студентов в DataGridView
            currentPageDataGrid = 1;
        }

        public void SetController(Controller controller)
        {
            /////correct
            this.controller = controller;
        }
        public void UpdateView(List<Student> list) // обновление DataGridView
        {
            dataGridView.Rows.Clear();

            int nIndex = 0;
            foreach (Student i in list) // Обновление 
            {
                if (indexDataGrid <= nIndex && nIndex < indexDataGrid + countRowDataGrid)
                {
                    dataGridView.Rows.Add(i.GetHuman().GetName() + ' ' + i.GetHuman().GetSurname(),
                                        i.GetGroup(),
                                        i.GetDisease(),
                                        i.GetOtherReason(),
                                        i.GetDisrespectfulReason(),
                                        i.GetTotal()
                                     );
                }
                nIndex++;
            }
            buttonLastStud.Text = ((controller.Model.list.Count - 1) / countRowDataGrid + 1).ToString() + " ст.";  // кол-во страниц (зависит от мн-во студентов)
            labelCountStud.Text = "Count: " + (controller.Model.list.Count).ToString(); //отображение кол-ва студентов
            labelCurrentPage.Text = currentPageDataGrid.ToString() + " из " + buttonLastStud.Text; //
        }

        //-----------------События при нажатии------------------------//
        private void addButton_Click(object sender, EventArgs e)
        {
            formadd = new ViewAdd(controller);
            formadd.Hide();
            formadd.ShowDialog();
        }
        private void butRemoveStud_Click(object sender, EventArgs e)
        {

            ViewRemove formRemove = new ViewRemove(controller);
            formRemove.ShowDialog();
            formRemove.Hide();
            UpdateView(controller.Model.list);
        }

        public int CheckCountPages() // убрать
        {
            currentPageDataGrid = Convert.ToInt32(Math.Ceiling((float)controller.Model.list.Count / (float)countRowDataGrid));
            return currentPageDataGrid;
        }

        private void butSaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialogStudents saveFile = new SaveFileDialogStudents("D:\\Универ\\4 Семестр\\ППВиС\\Лаба№2\\SecondLaba4sem\\SecondLaba4sem\\bin\\", "xml");
            saveFile.SaveFileStudents();

            controller.SaveFile(saveFile.GetFileName());
            MessageBox.Show("Успешное сохранение");         
        }

        private void butOpenFile_Click(object sender, EventArgs e)// открытие файла
        {
            OpenFileDialogStudents openFile  = new OpenFileDialogStudents("D:\\Универ\\4 Семестр\\ППВиС\\Лаба№2\\SecondLaba4sem\\SecondLaba4sem\\bin\\", "xml");
            if (true == openFile.OpenFileStudents())
            {
                controller.OpenFile(openFile.GetFileName());
                MessageBox.Show("Данные загружены в программу");         
            }
        }

        private void buttonFirstStud_Click(object sender, EventArgs e)
        {
            currentPageDataGrid = 1;// текущая страница 1
            indexDataGrid = 0;
            UpdateView(controller.Model.list);
        }

        private void buttonLastStud_Click(object sender, EventArgs e)
        {
           // float a = (float)controller.Model.list.Count / (float)countRowDataGrid;
           // double m  = (Math.Ceiling((float)controller.Model.list.Count / (float)countRowDataGrid));


            currentPageDataGrid = Convert.ToInt32(Math.Ceiling((float)controller.Model.list.Count / (float)countRowDataGrid));// текущая страница последняя
            

            indexDataGrid = (currentPageDataGrid - 1) * countRowDataGrid ; // изменен. индекс первой строчки текущ страницы
            buttonLastStud.Text = (controller.Model.list.Count / countRowDataGrid).ToString() + " ст.";
            UpdateView(controller.Model.list);

        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if( currentPageDataGrid -1 >= 1)
                currentPageDataGrid--; // текущая страница на минус 1

            indexDataGrid = indexDataGrid - countRowDataGrid;
            if (indexDataGrid < 0)
                indexDataGrid = 0;

            UpdateView(controller.Model.list);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (currentPageDataGrid + 1 <= Convert.ToInt32(Math.Ceiling((float)controller.Model.list.Count / (float)countRowDataGrid))) // проверка, 4 ст. из 4, не выходило за пределы
                currentPageDataGrid++;

            if ( indexDataGrid + 1 + countRowDataGrid <= controller.Model.list.Count )
                indexDataGrid = indexDataGrid + countRowDataGrid;

            UpdateView(controller.Model.list);
        }

        private void buttonSearchStud_Click(object sender, EventArgs e)//////////////////////////////////////////////////////////////////
        {
            ViewSearchResult viewSearch = new ViewSearchResult(controller);
           // viewSearch = new ViewInputDataForSearch(controller);
            viewSearch.ShowDialog();
        }

        private void comboBoxCountPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView.Height = 46 + 22 * Convert.ToInt32(comboBoxCountPage.Text); // 46- заголовок, 22-высота ячейки
            countRowDataGrid = Convert.ToInt32(comboBoxCountPage.Text); // кол-во строчек в таблице

            indexDataGrid = 0; //при изменении размеров переход на 0 интекс List
            currentPageDataGrid = 1; // при изменении размеров переход на 1 страницу
            UpdateView(controller.Model.list); // обновить при изменениее
        } 




        //-----------------Пустые-функции------------------------//
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainView_Load(object sender, EventArgs e)
        {

        }

        private void MainView_Load_1(object sender, EventArgs e)
        {

        }

       
    }
}

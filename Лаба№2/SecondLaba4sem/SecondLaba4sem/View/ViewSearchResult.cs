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
    

    public partial class ViewSearchResult : Form
    {
        private FirstOptionComboBox firstOption; //первый вариант поиска
        private SecondOptionComboBox secondOption; //второй вариант поиска
        private ThirdOptionComboBox thirdOption;
        private Controller controller;
        private int indexDataGrid;
        private int countRowDataGrid; // кол-во строчек в DataGridView в данный момент
        private int currentPageDataGrid; // текущая страница таблицы
        private int option;
        
        public ViewSearchResult(Controller controller)
        {    
            InitializeComponent();

            option = 0;
            indexDataGrid = 0;
            currentPageDataGrid = 1; 
            countRowDataGrid = 5; //по умолчанию 5 строчек в таблице отображаются
            firstOption = new FirstOptionComboBox(Controls);
            secondOption = new SecondOptionComboBox(Controls);
            thirdOption = new ThirdOptionComboBox(Controls);
            secondOption.comboBoxSecondOption.SelectedIndexChanged += new System.EventHandler(this.comboBoxSecondOption_SelectedIndexChanged);
            thirdOption.comboBoxThirdOption.SelectedIndexChanged += new System.EventHandler(this.comboBoxThirdOption_SelectedIndexChanged);
            this.controller = controller;
            UpdateView(controller.Model.list);
        }

        private void butSearchResult_Click(object sender, EventArgs e)
        {
            if(option == 1) controller.Model.bufferList = firstOption.SortList(controller.Model.list);

            if (option == 3) controller.Model.bufferList = thirdOption.ChooseSortList(controller.Model.list);
            UpdateView(controller.Model.bufferList);
        }

        public void UpdateView(List<Student> list)
        {
            dataGridView.Rows.Clear();
            int nIndex = 0;
            foreach (Student iStudent in list) // Обновление 
            {
                if (indexDataGrid <= nIndex && nIndex < indexDataGrid + countRowDataGrid)
                {

                    dataGridView.Rows.Add(iStudent.GetHuman().GetName() + ' ' + iStudent.GetHuman().GetSurname(),
                                        iStudent.GetGroup(),
                                        iStudent.GetDisease(),
                                        iStudent.GetOtherReason(),
                                        iStudent.GetDisrespectfulReason(),
                                        iStudent.GetTotal()
                                     );

                }
                nIndex++;
            }
            buttonLastStud.Text = ((list.Count - 1) / countRowDataGrid + 1).ToString() + " ст.";  // кол-во страниц (зависит от мн-во студентов)
            labelCountStud.Text = "Count: " + (list.Count).ToString(); //отображение кол-ва студентов

            labelCurrentPage.Text = currentPageDataGrid.ToString() + " из " + buttonLastStud.Text; //
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
            buttonLastStud.Text = (controller.Model.bufferList.Count / countRowDataGrid).ToString() + " ст.";
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


        private void ViewSearchResult_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxOptionSearch_SelectedIndexChanged(object sender, EventArgs e) // вариант поиска
        {
            for (int i = 0; i < comboBoxOptionSearch.Items.Count; i++)
            {
                
                if (comboBoxOptionSearch.SelectedItem.ToString() == "-по номеру группы и фамилии студента")
                {
                    option = 1;
                    firstOption.SetVisible();
                    secondOption.SetInVisible();
                    thirdOption.SetInVisible();
                    break;
                }   
                else if (comboBoxOptionSearch.SelectedItem.ToString() == "-по фамилии студента и виду пропуска")
                {
                    option = 2;
                    secondOption.SetVisible();
                    firstOption.SetInVisible();
                    thirdOption.SetInVisible();
                    break;
                }
                else if (comboBoxOptionSearch.SelectedItem.ToString() == "-по фамилии студента и количеству пропусков по видам ")
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
            dataGridView.Height = 46 + 22 * Convert.ToInt32(comboBoxCountPage.Text); // 46- заголовок, 22-высота ячейки
            countRowDataGrid = Convert.ToInt32(comboBoxCountPage.Text); // кол-во строчек в таблице

            indexDataGrid = 0; //при изменении размеров переход на 0 интекс List
            currentPageDataGrid = 1; // при изменении размеров переход на 1 страницу
            if(controller.Model.bufferList.Count != 0)
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

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }


    public class FirstOptionComboBox : Form //класс первый вариант поиска
    {
        private TextBox textBoxSurname;
        private TextBox textBoxNumberGroup;
        private Control.ControlCollection controls;

        public FirstOptionComboBox(Control.ControlCollection Controls)
        {
            controls = Controls;
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxNumberGroup = new System.Windows.Forms.TextBox();
            this.textBoxSurname.Location = new System.Drawing.Point(633, 125);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(100, 20);
            this.textBoxSurname.TabIndex = 16;
            this.textBoxSurname.Text = "фамилия";
            
            this.textBoxNumberGroup.Location = new System.Drawing.Point(633, 163);
            this.textBoxNumberGroup.Name = "textBoxNumberGroup";
            this.textBoxNumberGroup.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumberGroup.TabIndex = 17;
            this.textBoxNumberGroup.Text = "номер группы";

            this.controls.Add(this.textBoxNumberGroup);
            this.controls.Add(this.textBoxSurname);
            this.textBoxNumberGroup.Visible = false;
            this.textBoxSurname.Visible = false;
        }

        public void SetVisible()
        {
            textBoxSurname.Visible = true;
            textBoxNumberGroup.Visible = true;
        }

        public void SetInVisible()
        {
            textBoxSurname.Visible = false;
            textBoxNumberGroup.Visible = false;
        }
        public string GetTextBoxSurname()
        {
            return textBoxSurname.Text;
        }
        public int GetTextBoxNumberGroup()
        {
            return Convert.ToInt32(textBoxNumberGroup.Text);
        }

        public List<Student> SortList(List<Student>list)
        {
            List<Student> sortList = new List<Student>();
            foreach (Student iStudent in list) // Обновление 
            { 
                if (iStudent.GetHuman().GetSurname() == GetTextBoxSurname() && iStudent.GetGroup() == GetTextBoxNumberGroup())
                {
                    sortList.Add(iStudent); // заносим в буфер
                }
            }
            return sortList;
        }
    }

    public class SecondOptionComboBox : Form //класс первый вариант поиска
    {
        private TextBox textBoxSurname;
        public ComboBox comboBoxSecondOption;
        private Label labelType;
        private Control.ControlCollection controls;

        public SecondOptionComboBox(Control.ControlCollection Controls)
        {
            controls = Controls;
            this.textBoxSurname = new System.Windows.Forms.TextBox();    
            this.textBoxSurname.Location = new System.Drawing.Point(633, 125);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(100, 20);
            this.textBoxSurname.TabIndex = 16;
            this.textBoxSurname.Text = "фамилия";
            this.textBoxSurname.Visible = false;
            this.controls.Add(this.textBoxSurname);

            this.comboBoxSecondOption = new System.Windows.Forms.ComboBox();
            this.labelType = new System.Windows.Forms.Label();
            this.comboBoxSecondOption.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBoxSecondOption.FormattingEnabled = true;
            this.comboBoxSecondOption.Items.AddRange(new object[] {
            "По болезни",
            "По другим причинам",
            "Без уважительной причины",
            "Итого"});
            this.comboBoxSecondOption.Location = new System.Drawing.Point(635, 211);
            this.comboBoxSecondOption.Name = "comboBoxSecondOption";
            this.comboBoxSecondOption.Size = new System.Drawing.Size(141, 21);
            this.comboBoxSecondOption.TabIndex = 19;
            this.comboBoxSecondOption.Visible = false;
            

            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(632, 195);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(76, 13);
            this.labelType.TabIndex = 20;
            this.labelType.Text = "Вид пропуска";
            this.labelType.Visible = false;

            this.controls.Add(this.labelType);
            this.controls.Add(this.comboBoxSecondOption);

        }
        
        public int IndexSecondOptionComboBox()
        {
            for (int i = 0; i < comboBoxSecondOption.Items.Count; i++)
            {
                if (comboBoxSecondOption.SelectedItem.ToString() == "По болезни")
                {
                    return 1;
                }
                else if (comboBoxSecondOption.SelectedItem.ToString() == "По другим причинам")
                {
                    return 2;
                }
                else if (comboBoxSecondOption.SelectedItem.ToString() == "Без уважительной причины")
                {
                    return 3;
                }
                else if (comboBoxSecondOption.SelectedItem.ToString() == "Итого")
                {
                    return 4;
                }

            }
            return 0;
        }

        public void SetVisible()
        {
            textBoxSurname.Visible = true;
            comboBoxSecondOption.Visible = true;
            labelType.Visible = true;
        }

        public void SetInVisible()
        {
            textBoxSurname.Visible = false;
            comboBoxSecondOption.Visible = false;
            labelType.Visible = false;
        }
        public string GetTextBoxSurname()
        {
            return textBoxSurname.Text;
        }


        public List<Student> SortList1(List<Student> list)
        {
            List<Student> sortList = new List<Student>();
            foreach (Student iStudent in list) // Обновление 
            {
                if (iStudent.GetHuman().GetSurname() == GetTextBoxSurname())
                {
                    sortList.Add(iStudent); // заносим в буфер
                }
            }
            sortList.Sort(delegate (Student st1, Student st2) /////////////////&&&&&&&&&&&&&&&&&&&&&&&&&
            { return st2.GetDisease().CompareTo(st1.GetDisease()); });
 
            return sortList;
        }

        public List<Student> SortList2(List<Student> list)
        {
            List<Student> sortList = new List<Student>();
            foreach (Student iStudent in list) // Обновление 
            {
                if (iStudent.GetHuman().GetSurname() == GetTextBoxSurname())
                {
                    sortList.Add(iStudent); // заносим в буфер
                }
            }
            sortList.Sort(delegate (Student st1, Student st2) /////////////////&&&&&&&&&&&&&&&&&&&&&&&&&
            { return st2.GetOtherReason().CompareTo(st1.GetOtherReason()); });
            //sortList.Sort();
            return sortList;
        }

        public List<Student> SortList3(List<Student> list)
        {
            List<Student> sortList = new List<Student>();
            foreach (Student iStudent in list) // Обновление 
            {
                if (iStudent.GetHuman().GetSurname() == GetTextBoxSurname())
                {
                    sortList.Add(iStudent); // заносим в буфер
                }
            }
            sortList.Sort(delegate (Student st1, Student st2) /////////////////&&&&&&&&&&&&&&&&&&&&&&&&&
            { return st2.GetDisrespectfulReason().CompareTo(st1.GetDisrespectfulReason()); });
            //sortList.Sort();
            return sortList;
        }

        public List<Student> SortList4(List<Student> list)
        {
            List<Student> sortList = new List<Student>();
            foreach (Student iStudent in list) // Обновление 
            {
                if (iStudent.GetHuman().GetSurname() == GetTextBoxSurname())
                {
                    sortList.Add(iStudent); // заносим в буфер
                }
            }
            sortList.Sort(delegate (Student st1, Student st2) /////////////////&&&&&&&&&&&&&&&&&&&&&&&&&
            { return st2.GetTotal().CompareTo(st1.GetTotal()); });
            //sortList.Sort();
            return sortList;
        }
    }

    public class ThirdOptionComboBox : Form //класс первый вариант поиска
    {
        private TextBox textBoxSurname;
        public ComboBox comboBoxThirdOption;
        private Label labelType;
        private TextBox textBoxFrom;
        private TextBox textBoxTo;
        private Control.ControlCollection controls;

        public ThirdOptionComboBox(Control.ControlCollection Controls)
        {
            controls = Controls;
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxSurname.Location = new System.Drawing.Point(633, 125);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(100, 20);
            this.textBoxSurname.TabIndex = 16;
            this.textBoxSurname.Text = "фамилия";
            this.textBoxSurname.Visible = false;
            this.controls.Add(this.textBoxSurname);
            //////////////////////////////////////////////////////////////////
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.textBoxFrom.Location = new System.Drawing.Point(633, 255);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(100, 20);
            this.textBoxFrom.TabIndex = 16;
            
            this.textBoxFrom.Visible = false;
            this.controls.Add(this.textBoxFrom);


            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.textBoxTo.Location = new System.Drawing.Point(643, 285);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(100, 20);
            this.textBoxTo.TabIndex = 16;
           
            this.textBoxTo.Visible = false;
            this.controls.Add(this.textBoxTo);

            this.comboBoxThirdOption = new System.Windows.Forms.ComboBox();
            this.labelType = new System.Windows.Forms.Label();
            this.comboBoxThirdOption.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBoxThirdOption.FormattingEnabled = true;
            this.comboBoxThirdOption.Items.AddRange(new object[] {
            "По болезни",
            "По другим причинам",
            "Без уважительной причины",
            "Итого"});
            this.comboBoxThirdOption.Location = new System.Drawing.Point(635, 211);
            this.comboBoxThirdOption.Name = "comboBoxSecondOption";
            this.comboBoxThirdOption.Size = new System.Drawing.Size(141, 21);
            this.comboBoxThirdOption.TabIndex = 19;
            this.comboBoxThirdOption.Visible = false;


            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(632, 195);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(76, 13);
            this.labelType.TabIndex = 20;
            this.labelType.Text = "Вид пропуска";
            this.labelType.Visible = false;

            this.controls.Add(this.labelType);
            this.controls.Add(this.comboBoxThirdOption);

        }

        public int IndexThirdOptionComboBox()
        {
            for (int i = 0; i < comboBoxThirdOption.Items.Count; i++)
            {
                if (comboBoxThirdOption.SelectedItem.ToString() == "По болезни")
                {
                    return 1;
                }
                else if (comboBoxThirdOption.SelectedItem.ToString() == "По другим причинам")
                {
                    return 2;
                }
                else if (comboBoxThirdOption.SelectedItem.ToString() == "Без уважительной причины")
                {
                    return 3;
                }
                else if (comboBoxThirdOption.SelectedItem.ToString() == "Итого")
                {
                    return 4;
                }

            }
            return 0;
        }

        public void SetVisible()
        {
            textBoxSurname.Visible = true;
            comboBoxThirdOption.Visible = true;
            labelType.Visible = true;
            textBoxFrom.Visible = true;
            textBoxTo.Visible = true;
        }

        public void SetInVisible()
        {
            textBoxSurname.Visible = false;
            comboBoxThirdOption.Visible = false;
            labelType.Visible = false;
            textBoxFrom.Visible = false;
            textBoxTo.Visible = false;
        }
        public string GetTextBoxSurname()
        {
            return textBoxSurname.Text;
        }

        public List<Student> ChooseSortList(List<Student> list)
        {
            List<Student> bufList = new List<Student>();
            if (IndexThirdOptionComboBox() == 1)
            {
                bufList = SortList1(list);
            }
            else if (IndexThirdOptionComboBox() == 2)
            {
                bufList = SortList2(list);
            }
            else if (IndexThirdOptionComboBox() == 3)
            {
                bufList = SortList3(list);
            }
            else if (IndexThirdOptionComboBox() == 4)
            {
                bufList = SortList4(list);
            }
            return bufList;
        }

        public List<Student> SortList1(List<Student> list)
        {
            List<Student> sortList = new List<Student>();
            foreach (Student iStudent in list) // Обновление 
            {
                int a = Convert.ToInt32(textBoxFrom.Text);
                int b = iStudent.GetDisease();
                int c = Convert.ToInt32(textBoxFrom.Text);

                if (iStudent.GetHuman().GetSurname() == this.GetTextBoxSurname() &&  
                    Convert.ToInt32(textBoxFrom.Text) <=  iStudent.GetDisease() &&  iStudent.GetDisease() <= Convert.ToInt32(textBoxTo.Text))
                {
                    sortList.Add(iStudent); // заносим в буфер
                }
            }
            sortList.Sort(delegate (Student st1, Student st2) /////////////////&&&&&&&&&&&&&&&&&&&&&&&&&
            { return st2.GetDisease().CompareTo(st1.GetDisease()); });

            return sortList;
        }

        public List<Student> SortList2(List<Student> list)
        {
            List<Student> sortList = new List<Student>();
            foreach (Student iStudent in list) // Обновление 
            {
                //string  m = textBoxFrom.Text;
                //int mm = Convert.ToInt32(m);

                if (iStudent.GetHuman().GetSurname() == this.GetTextBoxSurname() &&
                    Convert.ToInt32(textBoxFrom.Text) <= iStudent.GetOtherReason() && 
                    iStudent.GetOtherReason() <= Convert.ToInt32(textBoxTo.Text))
                {
                    sortList.Add(iStudent); // заносим в буфер
                }
            }
            sortList.Sort(delegate (Student st1, Student st2) /////////////////&&&&&&&&&&&&&&&&&&&&&&&&&
            { return st2.GetOtherReason().CompareTo(st1.GetOtherReason()); });
            //sortList.Sort();
            return sortList;
        }

        public List<Student> SortList3(List<Student> list)
        {
            List<Student> sortList = new List<Student>();
            foreach (Student iStudent in list) // Обновление 
            {
                if (iStudent.GetHuman().GetSurname() == this.GetTextBoxSurname() &&
                    Convert.ToInt32(textBoxFrom.Text) <= iStudent.GetDisrespectfulReason() && iStudent.GetDisrespectfulReason() <= Convert.ToInt32(textBoxTo.Text))
                {
                    sortList.Add(iStudent); // заносим в буфер
                }
            }
            sortList.Sort(delegate (Student st1, Student st2) /////////////////&&&&&&&&&&&&&&&&&&&&&&&&&
            { return st2.GetDisrespectfulReason().CompareTo(st1.GetDisrespectfulReason()); });
            //sortList.Sort();
            return sortList;
        }

        public List<Student> SortList4(List<Student> list)
        {
            List<Student> sortList = new List<Student>();
            foreach (Student iStudent in list) // Обновление 
            {
                if (iStudent.GetHuman().GetSurname() == this.GetTextBoxSurname() &&
                    Convert.ToInt32(textBoxFrom.Text) <= iStudent.GetTotal() && iStudent.GetTotal() <= Convert.ToInt32(textBoxTo.Text))
                {
                    sortList.Add(iStudent); // заносим в буфер
                }
            }
            sortList.Sort(delegate (Student st1, Student st2) /////////////////&&&&&&&&&&&&&&&&&&&&&&&&&
            { return st2.GetTotal().CompareTo(st1.GetTotal()); });
            //sortList.Sort();
            return sortList;
        }
    }
}

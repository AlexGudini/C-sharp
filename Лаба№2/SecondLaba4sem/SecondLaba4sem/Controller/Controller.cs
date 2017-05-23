using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.XPath;

namespace SecondLaba4sem
{
    interface IController
    {
        void AddStudent(Student student);
        void RemoveStudent(Student student);
        Form CreateFormView();
        void SaveFile();
        void OpenFile();
    }
    public class Controller
    {
        //--------------Объявление----------------//
        public MainView view;
        private Model model;
        public Model Model
        {
            get { return model; }
        }

        //--------------Конструктор---------------//
        public Controller(MainView view, Model model)
        {
            this.model = model;
            this.view = view;
        }
 
        //--------------Обращения к Model---------//
        public void AddStudent(Student student) // добавление студента в список
        {
            model.AddStudent(student);
            view.UpdateView(model.list);
        }
        public void RemoveStudent(Student student) // добавление студента в список
        {
            model.RemoveStudent(student);
            view.UpdateView(model.list);
        }

        public Form CreateFormView() // создание MainView, вызов из Main
        {
            view.SetController(this);          
            return view;
        }

        public void SaveFile(string saveFilePath)
        {
            ParserXml parserXml = new ParserXml();
            parserXml.SaveFileToXml(saveFilePath, model.list);
        }

        public void OpenFile(string openFilePath)
        {
            ParserXml parserXml = new ParserXml();
            model.list = parserXml.OpenFileFromXml(openFilePath);
            view.UpdateView(model.list);
        }

        //-----------------Пустые-функции------------------------//
        public void UpdateDataGrid(DataGridView dataGridView)
        {
        }
    }
}

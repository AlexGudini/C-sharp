using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;
using System.Xml;
using System.Xml.XPath;

namespace SecondLaba4sem
{

    public class Model
    {
        public List<Student> list;
        public List<Student> bufferList; //для сортировки и удаления

        public Model()
        {
            list = new List<Student>();
            bufferList = new List<Student>();//
        }

        #region Основные фун-ии
        public void AddStudent(Student student) // добавление студента в список
        {
            //Student = stud;
            list.Add(student);
        }

        public void RemoveStudent(Student student) // удаление студентов из списка
        {
            for(int i = 0; i < list.Count; i++) 
                if (   list[i].GetHuman().GetName() == student.GetHuman().GetName()
                    && list[i].GetHuman().GetSurname() == student.GetHuman().GetSurname()
                     
                    //&& list[i].GetDisease() == student.GetDisease()
                    //&& list[i].GetOtherReason() == student.GetOtherReason() 
                    //&& list[i].GetDisrespectfulReason() == student.GetDisrespectfulReason()
                    /*&& list[i].GetTotal() == student.GetTotal()*/  )
                {
                    list.RemoveAt(i);
                    i = -1; // удаляем студента, список изменяется -> начинает с начала проверять
                            // -1 т.к при возвращение в for i станет равно 0 и цикл пойдет с начала
                }          
        }
       
        public void SaveFile() // Сохранение в Xml
        {
            var xmlWriter = new XmlTextWriter("Students.xml", null);
            xmlWriter.Formatting = Formatting.Indented; //вклю отсутп
            xmlWriter.IndentChar = '\t';
            xmlWriter.Indentation = 1;
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("Students");
            foreach (Student i in list) // Обновление 
            {
                xmlWriter.WriteStartElement("Student");

                    xmlWriter.WriteStartElement("Name");
                    xmlWriter.WriteString(i.GetHuman().GetName());
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteStartElement("Surname");
                    xmlWriter.WriteString(i.GetHuman().GetSurname());
                    xmlWriter.WriteEndElement();
            
                    xmlWriter.WriteStartElement("Group");
                    xmlWriter.WriteString(i.GetGroup().ToString());
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteStartElement("Disease");
                    xmlWriter.WriteString(i.GetDisease().ToString());
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteStartElement("OtherReason");
                    xmlWriter.WriteString(i.GetOtherReason().ToString());
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteStartElement("Disrespectful_reason");
                    xmlWriter.WriteString(i.GetDisrespectfulReason().ToString());
                    xmlWriter.WriteEndElement();
                xmlWriter.WriteEndElement();

            }
            xmlWriter.WriteEndElement();
            xmlWriter.Close();
        }

        public void OpenFile() // Чтение из XML
        {
            var document = new XmlDocument();
            document.Load("Students.xml");
            XmlNode root = document.DocumentElement;

            string xmlName = null ;
            string xmlSurName = null;
            int xmlGroup = 0;
            int xmlDisease = 0;
            int xmlOtherReason = 0;
            int xmlDisrespectfulReason = 0;
            foreach (XmlNode students in root.ChildNodes)
            {
                foreach (XmlNode student in students.ChildNodes)
                {
                    if (student.Name == "Name")                      xmlName = student.InnerText;
                    else if(student.Name == "Surname")               xmlSurName = student.InnerText;
                    else if (student.Name == "Group")                xmlGroup = Int32.Parse(student.InnerText);
                    else if (student.Name == "Disease")              xmlDisease = Int32.Parse(student.InnerText);
                    else if (student.Name == "OtherReason")          xmlOtherReason = Int32.Parse(student.InnerText);
                    else if (student.Name == "Disrespectful_reason") xmlDisrespectfulReason = Int32.Parse(student.InnerText);
                }
                list.Add(new Student(new Human(xmlName,
                                        xmlSurName),
                                        xmlGroup,
                                        xmlDisease,
                                        xmlOtherReason,
                                        xmlDisrespectfulReason
                                     ));
            }

        }
        #endregion
    }
}

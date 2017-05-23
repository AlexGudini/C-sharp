using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace SecondLaba4sem
{
    // класс-помощник для взаимодействи с Xml файлами
    interface IParserXml
    {
        bool SaveFileToXml(string path, List<Student> list);
        List<Student> OpenFileFromXml(string path);
    }
    public class ParserXml: IParserXml
    {
        public bool SaveFileToXml(string path, List<Student> list)
        {
            var xmlWriter = new XmlTextWriter(path, null);
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
            return true;
        }
        public List<Student> OpenFileFromXml(string path)
        {
            List<Student> returnList = new List<Student>();
            var document = new XmlDocument();
            document.Load(path);
            XmlNode root = document.DocumentElement;

            string xmlName = null;
            string xmlSurName = null;
            int xmlGroup = 0;
            int xmlDisease = 0;
            int xmlOtherReason = 0;
            int xmlDisrespectfulReason = 0;
            foreach (XmlNode students in root.ChildNodes)
            {
                foreach (XmlNode student in students.ChildNodes)
                {
                    if (student.Name == "Name") xmlName = student.InnerText;
                    else if (student.Name == "Surname") xmlSurName = student.InnerText;
                    else if (student.Name == "Group") xmlGroup = Int32.Parse(student.InnerText);
                    else if (student.Name == "Disease") xmlDisease = Int32.Parse(student.InnerText);
                    else if (student.Name == "OtherReason") xmlOtherReason = Int32.Parse(student.InnerText);
                    else if (student.Name == "Disrespectful_reason") xmlDisrespectfulReason = Int32.Parse(student.InnerText);
                }
                returnList.Add(new Student(new Human(xmlName,xmlSurName), xmlGroup, xmlDisease, xmlOtherReason, xmlDisrespectfulReason
                              )           );
            }
            return returnList;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Idoctor
{
    public class ParserXml
    {
        public ParserXml() { }
        //public bool SaveFileToXml(string path, List<Student> list)
        //{
        //    var xmlWriter = new XmlTextWriter(path, null);
        //    xmlWriter.Formatting = Formatting.Indented; //вклю отсутп
        //    xmlWriter.IndentChar = '\t';
        //    xmlWriter.Indentation = 1;
        //    xmlWriter.WriteStartDocument();
        //    xmlWriter.WriteStartElement("Students");
        //    foreach (Student i in list) // Обновление 
        //    {
        //        xmlWriter.WriteStartElement("Student");

        //        xmlWriter.WriteStartElement("Name");
        //        xmlWriter.WriteString(i.GetHuman().GetName());
        //        xmlWriter.WriteEndElement();

        //        xmlWriter.WriteStartElement("Surname");
        //        xmlWriter.WriteString(i.GetHuman().GetSurname());
        //        xmlWriter.WriteEndElement();

        //        xmlWriter.WriteStartElement("Group");
        //        xmlWriter.WriteString(i.GetGroup().ToString());
        //        xmlWriter.WriteEndElement();

        //        xmlWriter.WriteStartElement("Disease");
        //        xmlWriter.WriteString(i.GetDisease().ToString());
        //        xmlWriter.WriteEndElement();

        //        xmlWriter.WriteStartElement("OtherReason");
        //        xmlWriter.WriteString(i.GetOtherReason().ToString());
        //        xmlWriter.WriteEndElement();

        //        xmlWriter.WriteStartElement("Disrespectful_reason");
        //        xmlWriter.WriteString(i.GetDisrespectfulReason().ToString());
        //        xmlWriter.WriteEndElement();
        //        xmlWriter.WriteEndElement();

        //    }
        //    xmlWriter.WriteEndElement();
        //    xmlWriter.Close();
        //    return true;
        //}

        public List<Question> OpenFileFromXml(string path)
        {
            List<Question> returnList = new List<Question>();
            var document = new XmlDocument();
            document.Load(path);
            XmlNode root = document.DocumentElement;

            string xmlAsk = null;
            string xmlCorrect = null;
            string xmlMistake1 = null;
            string xmlMistake2 = null;
            foreach (XmlNode students in root.ChildNodes)
            {
                foreach (XmlNode question in students.ChildNodes)
                {
                    if (question.Name == "Ask") xmlAsk = question.InnerText;
                    else if (question.Name == "Correct") xmlCorrect = question.InnerText;
                    else if (question.Name == "Mistake1") xmlMistake1 = question.InnerText;
                    else if (question.Name == "Mistake2") xmlMistake2 = question.InnerText;
                    }
                returnList.Add(new Question(xmlAsk, xmlCorrect, xmlMistake1, xmlMistake2));
            }
            return returnList;
        }
    }
}

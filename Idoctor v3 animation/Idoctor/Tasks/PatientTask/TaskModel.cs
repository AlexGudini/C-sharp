using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace Idoctor
{
    public class TaskModel
    {
        List<Question> listQuestions = new List<Question>();
        ParserXml parser = new ParserXml();
        public TaskModel()
        { 
            listQuestions = parser.OpenFileFromXml("Tasks.xml");
        }
        public List<Question> GetListQuestion()
        {
            return this.listQuestions;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondLaba4sem
{
    interface IHuman
    {
        string GetName();
        string GetSurname();
    }
    public class Human
    {
        private string name;
        private string surname;

        public Human(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        public string GetName()
        {
            return name;
        }
        public string GetSurname()
        {
            return surname;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idoctor
{
    public class Question
    {
        public string ask;
        public string correct;
        public string mistake1;
        public string mistake2;

        public string Ask
        {
            get
            {
                return ask;
            }
            set { ask = value; }
        }
        public string Correct
        {
            get
            {
                return correct;
            }
            set { correct = value; }
        }
        public string Mistake1
        {
            get
            {
                return mistake1;
            }
            set { mistake1 = value; }
        }
        public string Mistake2
        {
            get
            {
                return mistake2;
            }
            set { mistake2 = value; }
        }
        public Question(string ask, string correct, string mistake1, string mistake2)
        {
            this.ask = ask;
            this.correct = correct;
            this.mistake1 = mistake1;
            this.mistake2 = mistake2;
        }

    }
}

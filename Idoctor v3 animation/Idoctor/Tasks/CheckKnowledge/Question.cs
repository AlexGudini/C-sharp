using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idoctor
{
    public enum AnswerUser
    {
        trueAnswer, falseAnswer, noAnwer
    }

    public class Question
    {
        private string ask;
        private string correct;
        private string mistake1;
        private string mistake2;
        private AnswerUser answerUser;

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
        // 3 варианта тк если он неправильный то он будет повторяться позже
        public AnswerUser AnswerUser
        {
            get
            {
                return answerUser;
            }
            set { answerUser = value; }
        }

        public Question(string ask, string correct, string mistake1, string mistake2)
        {
            this.ask = ask;
            this.correct = correct;
            this.mistake1 = mistake1;
            this.mistake2 = mistake2;
            this.answerUser = AnswerUser.noAnwer;
        }

    }
}

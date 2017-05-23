using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLaba4sem
{
    interface IStudent
    {
        Human GetHuman();
        int GetGroup();
        int GetDisease();
        int GetOtherReason();
        int GetDisrespectfulReason();
        int GetTotal();
    }
    public class Student
    {
        #region Объявление
        private Human human;
        private int group; //группа
        private int disease; // болезнь
        private int other_reason; // другие причины
        private int disrespectful_reason; //безпричинные 
        // private int total; общая сумма пропусков
        #endregion

        #region Конуструктор
        public Student(Human human, int group, int disease, int other_reason, int disrespectful_reason)
        {
            this.human = human;
            this.group = group;
            this.disease = disease;
            this.other_reason = other_reason;
            this.disrespectful_reason = disrespectful_reason;
        }
        #endregion

        public Human GetHuman()
        {
            return human;
        }
        public int GetGroup()
        {
            return group;
        }
        public int GetDisease()
        {
            return disease;
        }
        public int GetOtherReason()
        {
            return other_reason;
        }
        public int GetDisrespectfulReason()
        {
            return disrespectful_reason;
        }
        public int GetTotal()
        {
            return (disease + other_reason + disrespectful_reason);
        }
    }

}

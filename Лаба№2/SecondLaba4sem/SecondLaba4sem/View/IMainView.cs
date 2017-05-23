using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SecondLaba4sem
{
    public interface IMainView
    {
        void SetController(Controller controll);
        void UpdateView(List<Student> list);
    }
}

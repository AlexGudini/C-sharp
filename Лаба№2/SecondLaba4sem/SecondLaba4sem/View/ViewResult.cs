using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondLaba4sem
{
    public partial class ViewResult : Form
    {
        
        public ViewResult(string lab1, string lab2)
        {
            InitializeComponent();

            label1.Text = lab1;
            label2.Text = lab2;


        }

        private void ResultAddRemove_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SetInfoResult(string lab1, string lab2)
        {

        }

        private void ViewResult_Load(object sender, EventArgs e)
        {

        }
    }
}

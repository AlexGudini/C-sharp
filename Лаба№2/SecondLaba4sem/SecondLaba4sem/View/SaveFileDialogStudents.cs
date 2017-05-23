using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondLaba4sem
{
    public class SaveFileDialogStudents
    {
        private SaveFileDialog saveFileDialog;

        public SaveFileDialogStudents() { }

        public SaveFileDialogStudents(string path, string defaultTypeDocument)
        {
            saveFileDialog = new SaveFileDialog();
            this.saveFileDialog.InitialDirectory = path;
            this.saveFileDialog.DefaultExt = defaultTypeDocument;
            this.saveFileDialog.Filter = "Text files (*." + defaultTypeDocument + ")|*." + defaultTypeDocument + "|All files (*.*)|*.*";
            this.saveFileDialog.CheckFileExists = true;
            this.saveFileDialog.CheckPathExists = true;
            this.saveFileDialog.FilterIndex = 2;
            this.saveFileDialog.RestoreDirectory = true;
            this.saveFileDialog.CheckFileExists = false;
        }

        public void SaveFileStudents()
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.AppendAllText(this.saveFileDialog.FileName, "");
            }
        }

        public string GetFileName()
        {
            return this.saveFileDialog.FileName;
        }
    }
}

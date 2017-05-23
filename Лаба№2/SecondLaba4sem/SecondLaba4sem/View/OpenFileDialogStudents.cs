using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondLaba4sem
{
    
    public class OpenFileDialogStudents
    {
        private OpenFileDialog openFileDialog;

        public OpenFileDialogStudents() { }

        public OpenFileDialogStudents(string path, string defaultTypeDocument)
        {
            this.openFileDialog = new OpenFileDialog();
            this.openFileDialog.InitialDirectory = path;
            this.openFileDialog.DefaultExt = defaultTypeDocument;
            this.openFileDialog.Filter = "Text files (*." + defaultTypeDocument + ")|*." + defaultTypeDocument + "|All files (*.*)|*.*";
            this.openFileDialog.CheckFileExists = true;
            this.openFileDialog.CheckPathExists = true;
            this.openFileDialog.FilterIndex = 2;
            this.openFileDialog.RestoreDirectory = true;
            this.openFileDialog.ReadOnlyChecked = true;
            this.openFileDialog.ShowReadOnly = true;
        }     
        public bool OpenFileStudents()
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return true;
            }
            return false;
        }
        public string GetFileName()
        {
            return this.openFileDialog.FileName;
        }
    }
}

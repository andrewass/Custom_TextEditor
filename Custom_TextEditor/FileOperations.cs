using System.IO;
using System.Windows.Forms;

namespace Custom_TextEditor {


    class FileOperations {

       
        /* Create a new tab on the form, providing a new rich text box
         * filling the form */
        public void CreateNewTab(TabControl tabCtrl) {
            TabPage tabPage = new TabPage("New Document");
            RichTextBox textBox = new RichTextBox();
            textBox.Dock = DockStyle.Fill;
            tabPage.Controls.Add(textBox);
            tabPage.ImageIndex = 0;
            tabCtrl.TabPages.Add(tabPage);
        }


        /* Load the content from a file to the text box */
        public void Load(RichTextBox textBox, TabControl tabCtrl) {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK) {
                string filePath = Path.GetFullPath(ofd.FileName);
                StreamReader reader = new StreamReader(filePath);
                textBox.Text = reader.ReadToEnd();
                reader.Dispose();
                reader.Close();
            }
        }


        /* Store the content of the text box to a not-yet defined file*/
        public void SaveAs(RichTextBox textBox, TabControl tabCtrl) {
            SaveFileDialog sfd = new SaveFileDialog();
            //If user clicks OK in the dialog window
            if(sfd.ShowDialog() == DialogResult.OK) {
                string filePath = Path.GetFullPath(sfd.FileName);
                WriteToFile(textBox, filePath);
            }
        }


        /* Store the content of the text box to a pre-defined file */
        public void Save(RichTextBox textBox) {
           
        }


        /* Write the content of textBox to the file specified in filePath */
        private void WriteToFile(RichTextBox textBox, string path) {
            StreamWriter writer = new StreamWriter(path);
            writer.Write(textBox.Text);
            writer.Dispose();
            writer.Close();
        }   
    }
}

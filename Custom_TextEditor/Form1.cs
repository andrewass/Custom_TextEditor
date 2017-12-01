using System;
using System.Windows.Forms;

namespace Custom_TextEditor {

    public partial class Form1 : Form {

        SaveLoadOperations saveLoadOps = new SaveLoadOperations();


        public Form1() {
            InitializeComponent();
        }


        /* Save the current content in the editor to a not-yet defined file */
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e) {
            saveLoadOps.SaveAs();
        }


        /* Load the content from a pre-stored file into the editor */
        private void loadToolStripMenuItem_Click(object sender, EventArgs e) {
            saveLoadOps.Load();
        }


        /* Save the content in the editor to a pre-defined file */
        private void saveToolStripMenuItem1_Click(object sender, EventArgs e) {
            saveLoadOps.Save();
        }
    }
}

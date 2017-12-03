using System;
using System.Windows.Forms;

namespace Custom_TextEditor {

    public partial class MainForm : Form {

        FileOperations fileOps = new FileOperations();


        public MainForm() {
            InitializeComponent();
        }

        /* Get the rich text box from the currently selected tab */
        private RichTextBox GetRichTextBox() {
            TabPage tabPage = tabController.SelectedTab;
            return tabPage.Controls[0] as RichTextBox;
        }


        //================= File operations ======================

        /* Save the current content in the editor to a not-yet defined file */
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e) {
            fileOps.SaveAs(GetRichTextBox(), tabController);
        }

        /* Load the content from a pre-stored file into the editor */
        private void loadToolStripMenuItem_Click(object sender, EventArgs e) {
            fileOps.Load(GetRichTextBox(), tabController);
        }

        /* Save the content in the editor to a pre-defined file */
        private void saveToolStripMenuItem1_Click(object sender, EventArgs e) {
            fileOps.Save(GetRichTextBox());
        }

        /* Create a new tab with a rich text box */
        private void newFile_Click(object sender, EventArgs e) {
            fileOps.CreateNewTab(tabController);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e) {
            NewMethod();
        }

        private void NewMethod() {
            fileOps.CloseFile(GetRichTextBox(), tabController);
        }

        //=============== Edit operations ==========================

        /* Copy the selected part of a rich text box to the clipboard*/
        private void copyEdit_Click(object sender, EventArgs e) {
            GetRichTextBox().Copy();
        }

        /* Past selected text from the clipboard into current rich text box */
        private void pasteEdit_Click(object sender, EventArgs e) {
            GetRichTextBox().Paste();
        }

        /* Cut the selected part from the selected rich text box, and store
         * it in the clipboard */
        private void cutToolStripMenuItem_Click(object sender, EventArgs e) {
            GetRichTextBox().Cut();
        }

        
    }
}

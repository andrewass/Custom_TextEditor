namespace Custom_TextEditor {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.notepadMenu = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newFile = new System.Windows.Forms.ToolStripMenuItem();
            this.openFile = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsFile = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.copyEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tabController = new System.Windows.Forms.TabControl();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.notepadMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // notepadMenu
            // 
            this.notepadMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu});
            this.notepadMenu.Location = new System.Drawing.Point(0, 0);
            this.notepadMenu.Name = "notepadMenu";
            this.notepadMenu.Size = new System.Drawing.Size(1276, 24);
            this.notepadMenu.TabIndex = 0;
            this.notepadMenu.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFile,
            this.openFile,
            this.saveFile,
            this.saveAsFile});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "File";
            // 
            // newFile
            // 
            this.newFile.Name = "newFile";
            this.newFile.Size = new System.Drawing.Size(152, 22);
            this.newFile.Text = "New";
            this.newFile.Click += new System.EventHandler(this.newFile_Click);
            // 
            // openFile
            // 
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(152, 22);
            this.openFile.Text = "Open";
            this.openFile.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveFile
            // 
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(152, 22);
            this.saveFile.Text = "Save";
            this.saveFile.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // saveAsFile
            // 
            this.saveAsFile.Name = "saveAsFile";
            this.saveAsFile.Size = new System.Drawing.Size(152, 22);
            this.saveAsFile.Text = "Save as";
            this.saveAsFile.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyEdit,
            this.pasteEdit,
            this.cutToolStripMenuItem});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(39, 20);
            this.editMenu.Text = "Edit";
            // 
            // copyEdit
            // 
            this.copyEdit.Name = "copyEdit";
            this.copyEdit.Size = new System.Drawing.Size(152, 22);
            this.copyEdit.Text = "Copy";
            this.copyEdit.Click += new System.EventHandler(this.copyEdit_Click);
            // 
            // pasteEdit
            // 
            this.pasteEdit.Name = "pasteEdit";
            this.pasteEdit.Size = new System.Drawing.Size(152, 22);
            this.pasteEdit.Text = "Paste";
            this.pasteEdit.Click += new System.EventHandler(this.pasteEdit_Click);
            // 
            // tabController
            // 
            this.tabController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabController.ImageList = this.imageList;
            this.tabController.ItemSize = new System.Drawing.Size(0, 24);
            this.tabController.Location = new System.Drawing.Point(0, 24);
            this.tabController.Name = "tabController";
            this.tabController.SelectedIndex = 0;
            this.tabController.Size = new System.Drawing.Size(1276, 596);
            this.tabController.TabIndex = 1;
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "cancel.png");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 620);
            this.Controls.Add(this.tabController);
            this.Controls.Add(this.notepadMenu);
            this.MainMenuStrip = this.notepadMenu;
            this.Name = "MainForm";
            this.Text = "Custom Text Editor";
            this.notepadMenu.ResumeLayout(false);
            this.notepadMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip notepadMenu;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem openFile;
        private System.Windows.Forms.ToolStripMenuItem saveFile;
        private System.Windows.Forms.ToolStripMenuItem saveAsFile;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem copyEdit;
        private System.Windows.Forms.ToolStripMenuItem pasteEdit;
        private System.Windows.Forms.ToolStripMenuItem newFile;
        private System.Windows.Forms.TabControl tabController;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList;
    }
}


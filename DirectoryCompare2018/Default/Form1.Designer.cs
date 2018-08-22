namespace Default
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnPrimaryDir = new System.Windows.Forms.Button();
            this.btnSecondDir = new System.Windows.Forms.Button();
            this.btnCompare = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.compareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directorySettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expandAllToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadDirectoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSaveResults = new System.Windows.Forms.Button();
            this.tvFilesView = new System.Windows.Forms.TreeView();
            this.dGVoutPut = new System.Windows.Forms.DataGridView();
            this.tbOutPut = new System.Windows.Forms.TextBox();
            this.rbPrimaryDir = new System.Windows.Forms.RadioButton();
            this.rbSecondaryDir = new System.Windows.Forms.RadioButton();
            this.btnAddFilePath = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVoutPut)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrimaryDir
            // 
            this.btnPrimaryDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrimaryDir.Location = new System.Drawing.Point(546, 53);
            this.btnPrimaryDir.Name = "btnPrimaryDir";
            this.btnPrimaryDir.Size = new System.Drawing.Size(34, 23);
            this.btnPrimaryDir.TabIndex = 2;
            this.btnPrimaryDir.Text = "...";
            this.btnPrimaryDir.UseVisualStyleBackColor = true;
            this.btnPrimaryDir.Click += new System.EventHandler(this.FolderSearch);
            // 
            // btnSecondDir
            // 
            this.btnSecondDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSecondDir.Location = new System.Drawing.Point(546, 102);
            this.btnSecondDir.Name = "btnSecondDir";
            this.btnSecondDir.Size = new System.Drawing.Size(34, 23);
            this.btnSecondDir.TabIndex = 3;
            this.btnSecondDir.Text = "...";
            this.btnSecondDir.UseVisualStyleBackColor = true;
            this.btnSecondDir.Click += new System.EventHandler(this.FolderSearch);
            // 
            // btnCompare
            // 
            this.btnCompare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompare.Location = new System.Drawing.Point(480, 131);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(100, 32);
            this.btnCompare.TabIndex = 4;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.compareToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(12, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(528, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(12, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(528, 20);
            this.textBox2.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenu,
            this.applicationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(898, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MainMenu
            // 
            this.MainMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compareToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(35, 20);
            this.MainMenu.Text = "File";
            // 
            // compareToolStripMenuItem
            // 
            this.compareToolStripMenuItem.Name = "compareToolStripMenuItem";
            this.compareToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.compareToolStripMenuItem.Text = "Compare";
            this.compareToolStripMenuItem.Click += new System.EventHandler(this.compareToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.directorySettingsToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.applicationToolStripMenuItem.Text = "Application";
            // 
            // directorySettingsToolStripMenuItem
            // 
            this.directorySettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.expandAllToolStripMenuItem2,
            this.reloadDirectoriesToolStripMenuItem});
            this.directorySettingsToolStripMenuItem.Name = "directorySettingsToolStripMenuItem";
            this.directorySettingsToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.directorySettingsToolStripMenuItem.Text = "File Directory Settings";
            // 
            // expandAllToolStripMenuItem2
            // 
            this.expandAllToolStripMenuItem2.Name = "expandAllToolStripMenuItem2";
            this.expandAllToolStripMenuItem2.Size = new System.Drawing.Size(161, 22);
            this.expandAllToolStripMenuItem2.Text = "Expand All";
            this.expandAllToolStripMenuItem2.Click += new System.EventHandler(this.expandAllToolStripMenuItem2_Click);
            // 
            // reloadDirectoriesToolStripMenuItem
            // 
            this.reloadDirectoriesToolStripMenuItem.Name = "reloadDirectoriesToolStripMenuItem";
            this.reloadDirectoriesToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.reloadDirectoriesToolStripMenuItem.Text = "Reload Directories";
            this.reloadDirectoriesToolStripMenuItem.Click += new System.EventHandler(this.reloadDirectoriesToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(179, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Results:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 395);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(898, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip2";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(505, 325);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSaveResults
            // 
            this.btnSaveResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveResults.Location = new System.Drawing.Point(15, 325);
            this.btnSaveResults.Name = "btnSaveResults";
            this.btnSaveResults.Size = new System.Drawing.Size(75, 23);
            this.btnSaveResults.TabIndex = 15;
            this.btnSaveResults.Text = "Save";
            this.btnSaveResults.UseVisualStyleBackColor = true;
            this.btnSaveResults.Click += new System.EventHandler(this.SaveOutput);
            // 
            // tvFilesView
            // 
            this.tvFilesView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvFilesView.Location = new System.Drawing.Point(595, 48);
            this.tvFilesView.Name = "tvFilesView";
            this.tvFilesView.Size = new System.Drawing.Size(291, 300);
            this.tvFilesView.TabIndex = 16;
            this.tvFilesView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeExpand);
            // 
            // dGVoutPut
            // 
            this.dGVoutPut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVoutPut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVoutPut.Location = new System.Drawing.Point(15, 169);
            this.dGVoutPut.Name = "dGVoutPut";
            this.dGVoutPut.Size = new System.Drawing.Size(565, 150);
            this.dGVoutPut.TabIndex = 17;
            // 
            // tbOutPut
            // 
            this.tbOutPut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOutPut.BackColor = System.Drawing.SystemColors.Menu;
            this.tbOutPut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOutPut.Location = new System.Drawing.Point(15, 357);
            this.tbOutPut.Name = "tbOutPut";
            this.tbOutPut.ReadOnly = true;
            this.tbOutPut.Size = new System.Drawing.Size(565, 22);
            this.tbOutPut.TabIndex = 31;
            this.tbOutPut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rbPrimaryDir
            // 
            this.rbPrimaryDir.AutoSize = true;
            this.rbPrimaryDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPrimaryDir.Location = new System.Drawing.Point(12, 27);
            this.rbPrimaryDir.Name = "rbPrimaryDir";
            this.rbPrimaryDir.Size = new System.Drawing.Size(141, 22);
            this.rbPrimaryDir.TabIndex = 32;
            this.rbPrimaryDir.TabStop = true;
            this.rbPrimaryDir.Text = "Primary Directory";
            this.rbPrimaryDir.UseVisualStyleBackColor = true;
            this.rbPrimaryDir.CheckedChanged += new System.EventHandler(this.rbPrimaryDir_CheckedChanged);
            // 
            // rbSecondaryDir
            // 
            this.rbSecondaryDir.AutoSize = true;
            this.rbSecondaryDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSecondaryDir.Location = new System.Drawing.Point(12, 79);
            this.rbSecondaryDir.Name = "rbSecondaryDir";
            this.rbSecondaryDir.Size = new System.Drawing.Size(161, 22);
            this.rbSecondaryDir.TabIndex = 33;
            this.rbSecondaryDir.TabStop = true;
            this.rbSecondaryDir.Text = "Secondary Directory";
            this.rbSecondaryDir.UseVisualStyleBackColor = true;
            this.rbSecondaryDir.CheckedChanged += new System.EventHandler(this.rbSecondaryDir_CheckedChanged);
            // 
            // btnAddFilePath
            // 
            this.btnAddFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFilePath.Location = new System.Drawing.Point(620, 360);
            this.btnAddFilePath.Name = "btnAddFilePath";
            this.btnAddFilePath.Size = new System.Drawing.Size(238, 23);
            this.btnAddFilePath.TabIndex = 34;
            this.btnAddFilePath.Text = "Pick Path";
            this.btnAddFilePath.UseVisualStyleBackColor = true;
            this.btnAddFilePath.Click += new System.EventHandler(this.btnAddFilePath_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 417);
            this.Controls.Add(this.btnAddFilePath);
            this.Controls.Add(this.rbSecondaryDir);
            this.Controls.Add(this.rbPrimaryDir);
            this.Controls.Add(this.tbOutPut);
            this.Controls.Add(this.dGVoutPut);
            this.Controls.Add(this.tvFilesView);
            this.Controls.Add(this.btnSaveResults);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.btnSecondDir);
            this.Controls.Add(this.btnPrimaryDir);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVoutPut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPrimaryDir;
        private System.Windows.Forms.Button btnSecondDir;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MainMenu;
        private System.Windows.Forms.ToolStripMenuItem compareToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSaveResults;
        private System.Windows.Forms.TreeView tvFilesView;
        private System.Windows.Forms.DataGridView dGVoutPut;
        private System.Windows.Forms.TextBox tbOutPut;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.RadioButton rbSecondaryDir;
        private System.Windows.Forms.RadioButton rbPrimaryDir;
        private System.Windows.Forms.Button btnAddFilePath;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem directorySettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expandAllToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem reloadDirectoriesToolStripMenuItem;
    }
}


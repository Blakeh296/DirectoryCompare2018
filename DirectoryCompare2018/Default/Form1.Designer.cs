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
            this.button1 = new System.Windows.Forms.Button();
            this.rtbOutPut = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.compareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrimaryDir
            // 
            this.btnPrimaryDir.Location = new System.Drawing.Point(619, 53);
            this.btnPrimaryDir.Name = "btnPrimaryDir";
            this.btnPrimaryDir.Size = new System.Drawing.Size(34, 23);
            this.btnPrimaryDir.TabIndex = 2;
            this.btnPrimaryDir.Text = "...";
            this.btnPrimaryDir.UseVisualStyleBackColor = true;
            // 
            // btnSecondDir
            // 
            this.btnSecondDir.Location = new System.Drawing.Point(619, 96);
            this.btnSecondDir.Name = "btnSecondDir";
            this.btnSecondDir.Size = new System.Drawing.Size(34, 23);
            this.btnSecondDir.TabIndex = 3;
            this.btnSecondDir.Text = "...";
            this.btnSecondDir.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(553, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Compare";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // rtbOutPut
            // 
            this.rtbOutPut.BackColor = System.Drawing.SystemColors.Control;
            this.rtbOutPut.Location = new System.Drawing.Point(85, 163);
            this.rtbOutPut.Name = "rtbOutPut";
            this.rtbOutPut.Size = new System.Drawing.Size(568, 151);
            this.rtbOutPut.TabIndex = 5;
            this.rtbOutPut.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(528, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(85, 98);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(528, 20);
            this.textBox2.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MainMenu
            // 
            this.MainMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compareToolStripMenuItem});
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(35, 20);
            this.MainMenu.Text = "File";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Primary Directory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Secondary Directory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Results:";
            // 
            // compareToolStripMenuItem
            // 
            this.compareToolStripMenuItem.Name = "compareToolStripMenuItem";
            this.compareToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.compareToolStripMenuItem.Text = "Compare";
            this.compareToolStripMenuItem.Click += new System.EventHandler(this.compareToolStripMenuItem_Click);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip2";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(109, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(109, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.rtbOutPut);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSecondDir);
            this.Controls.Add(this.btnPrimaryDir);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPrimaryDir;
        private System.Windows.Forms.Button btnSecondDir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rtbOutPut;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MainMenu;
        private System.Windows.Forms.ToolStripMenuItem compareToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}


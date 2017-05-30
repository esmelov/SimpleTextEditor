namespace text_editor
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontLargeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontSmallerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripCharCountLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripCharCountLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripFontSizeLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripFontSizeLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripClockLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripClockLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.FileDataTextBox = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(795, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFileToolStripMenuItem,
            this.SaveFileToolStripMenuItem,
            this.toolStripSeparator1,
            this.newToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // OpenFileToolStripMenuItem
            // 
            this.OpenFileToolStripMenuItem.Name = "OpenFileToolStripMenuItem";
            this.OpenFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.OpenFileToolStripMenuItem.Text = "Open";
            // 
            // SaveFileToolStripMenuItem
            // 
            this.SaveFileToolStripMenuItem.Enabled = false;
            this.SaveFileToolStripMenuItem.Name = "SaveFileToolStripMenuItem";
            this.SaveFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.SaveFileToolStripMenuItem.Text = "Save";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FontLargeToolStripMenuItem,
            this.FontSmallerToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // FontLargeToolStripMenuItem
            // 
            this.FontLargeToolStripMenuItem.Enabled = false;
            this.FontLargeToolStripMenuItem.Name = "FontLargeToolStripMenuItem";
            this.FontLargeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Up)));
            this.FontLargeToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.FontLargeToolStripMenuItem.Text = "Font larger";
            // 
            // FontSmallerToolStripMenuItem
            // 
            this.FontSmallerToolStripMenuItem.Enabled = false;
            this.FontSmallerToolStripMenuItem.Name = "FontSmallerToolStripMenuItem";
            this.FontSmallerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
            this.FontSmallerToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.FontSmallerToolStripMenuItem.Text = "Font smaller";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCharCountLabel1,
            this.toolStripCharCountLabel2,
            this.toolStripFontSizeLabel1,
            this.toolStripFontSizeLabel2,
            this.toolStripClockLabel1,
            this.toolStripClockLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 406);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(795, 24);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripCharCountLabel1
            // 
            this.toolStripCharCountLabel1.Name = "toolStripCharCountLabel1";
            this.toolStripCharCountLabel1.Size = new System.Drawing.Size(69, 19);
            this.toolStripCharCountLabel1.Text = "Char count:";
            // 
            // toolStripCharCountLabel2
            // 
            this.toolStripCharCountLabel2.Name = "toolStripCharCountLabel2";
            this.toolStripCharCountLabel2.Size = new System.Drawing.Size(13, 19);
            this.toolStripCharCountLabel2.Text = "0";
            // 
            // toolStripFontSizeLabel1
            // 
            this.toolStripFontSizeLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripFontSizeLabel1.Name = "toolStripFontSizeLabel1";
            this.toolStripFontSizeLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripFontSizeLabel1.Size = new System.Drawing.Size(60, 19);
            this.toolStripFontSizeLabel1.Text = "Font size:";
            // 
            // toolStripFontSizeLabel2
            // 
            this.toolStripFontSizeLabel2.Name = "toolStripFontSizeLabel2";
            this.toolStripFontSizeLabel2.Size = new System.Drawing.Size(13, 19);
            this.toolStripFontSizeLabel2.Text = "0";
            // 
            // toolStripClockLabel1
            // 
            this.toolStripClockLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripClockLabel1.Name = "toolStripClockLabel1";
            this.toolStripClockLabel1.Size = new System.Drawing.Size(41, 19);
            this.toolStripClockLabel1.Text = "Time:";
            // 
            // toolStripClockLabel2
            // 
            this.toolStripClockLabel2.Name = "toolStripClockLabel2";
            this.toolStripClockLabel2.Size = new System.Drawing.Size(49, 19);
            this.toolStripClockLabel2.Text = "00:00:00";
            // 
            // FileDataTextBox
            // 
            this.FileDataTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileDataTextBox.Location = new System.Drawing.Point(0, 24);
            this.FileDataTextBox.Multiline = true;
            this.FileDataTextBox.Name = "FileDataTextBox";
            this.FileDataTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.FileDataTextBox.Size = new System.Drawing.Size(795, 382);
            this.FileDataTextBox.TabIndex = 2;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 24);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 382);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 430);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.FileDataTextBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Simple Text Editor [New]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FontLargeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FontSmallerToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripCharCountLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripCharCountLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripFontSizeLabel1;
        private System.Windows.Forms.TextBox FileDataTextBox;
        private System.Windows.Forms.ToolStripStatusLabel toolStripFontSizeLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripClockLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripClockLabel2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
    }
}


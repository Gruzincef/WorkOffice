namespace WorkOffice
{
    partial class WorkOffice
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
            this.workingText = new System.Windows.Forms.RichTextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.htmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обработкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteHyperlinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteAllTegТегиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SpecCharInHtmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стилиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.InHtmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // workingText
            // 
            this.workingText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workingText.Location = new System.Drawing.Point(0, 24);
            this.workingText.Name = "workingText";
            this.workingText.Size = new System.Drawing.Size(800, 426);
            this.workingText.TabIndex = 0;
            this.workingText.Text = "";
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 427);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(800, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.htmlToolStripMenuItem,
            this.стилиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // htmlToolStripMenuItem
            // 
            this.htmlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обработкаToolStripMenuItem});
            this.htmlToolStripMenuItem.Name = "htmlToolStripMenuItem";
            this.htmlToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.htmlToolStripMenuItem.Text = "Html";
            // 
            // обработкаToolStripMenuItem
            // 
            this.обработкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteHyperlinkToolStripMenuItem,
            this.DeleteAllTegТегиToolStripMenuItem,
            this.SpecCharInHtmlToolStripMenuItem,
            this.InHtmlToolStripMenuItem});
            this.обработкаToolStripMenuItem.Name = "обработкаToolStripMenuItem";
            this.обработкаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.обработкаToolStripMenuItem.Text = "Обработка";
            // 
            // DeleteHyperlinkToolStripMenuItem
            // 
            this.DeleteHyperlinkToolStripMenuItem.Name = "DeleteHyperlinkToolStripMenuItem";
            this.DeleteHyperlinkToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.DeleteHyperlinkToolStripMenuItem.Text = "Удалить гиперссылки";
            // 
            // DeleteAllTegТегиToolStripMenuItem
            // 
            this.DeleteAllTegТегиToolStripMenuItem.Name = "DeleteAllTegТегиToolStripMenuItem";
            this.DeleteAllTegТегиToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.DeleteAllTegТегиToolStripMenuItem.Text = "Удалить все теги";
            // 
            // SpecCharInHtmlToolStripMenuItem
            // 
            this.SpecCharInHtmlToolStripMenuItem.Name = "SpecCharInHtmlToolStripMenuItem";
            this.SpecCharInHtmlToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.SpecCharInHtmlToolStripMenuItem.Text = "Спец сим в html код";
            this.SpecCharInHtmlToolStripMenuItem.Click += new System.EventHandler(this.SpecCharInHtmlToolStripMenuItem_Click);
            // 
            // стилиToolStripMenuItem
            // 
            this.стилиToolStripMenuItem.Name = "стилиToolStripMenuItem";
            this.стилиToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.стилиToolStripMenuItem.Text = "Стили";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // InHtmlToolStripMenuItem
            // 
            this.InHtmlToolStripMenuItem.Name = "InHtmlToolStripMenuItem";
            this.InHtmlToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.InHtmlToolStripMenuItem.Text = "В html";
            this.InHtmlToolStripMenuItem.Click += new System.EventHandler(this.InHtmlToolStripMenuItem_Click);
            // 
            // WorkOffice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.workingText);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WorkOffice";
            this.Text = "Работа";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox workingText;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem htmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стилиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обработкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteHyperlinkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteAllTegТегиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SpecCharInHtmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem InHtmlToolStripMenuItem;
    }
}


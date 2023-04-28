using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using WorkOffice.html;

namespace WorkOffice
{
    public partial class WorkOffice : Form
    {
        public WorkOffice()
        {
            InitializeComponent();
        }

        private void DeleteHyperlinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkHtml wrk = new WorkHtml();
            workingText.Text=wrk.deleteAllHyperlink(workingText.Text);
        }

        private void DeleteAllTegТегиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkHtml wrk = new WorkHtml();
            workingText.Text = wrk.deleteAllTeg(workingText.Text);
        }

        private void SpecCharInHtmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkHtml wrk = new WorkHtml();
            workingText.Text = wrk.convertToHtmlCode(workingText.Text);
            RichTextBox rtBox = new RichTextBox();
          }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "RTF files (*.rtf)|*.rtf|All files (*.*)|*.*"; // устанавливаем фильтр для отображения только RTF-файлов
            if (openFileDialog.ShowDialog() == DialogResult.OK) // если пользователь выбрал файл и нажал "OK"
            {
                string rtfFilePath = openFileDialog.FileName; // получаем путь к выбранному файлу
                string rtfText = ""; // создаем строку для хранения RTF-текста

                if (File.Exists(rtfFilePath)) // если файл существует
                {
                    using (StreamReader sr = new StreamReader(rtfFilePath)) // открываем файл для чтения
                    {
                        rtfText = sr.ReadToEnd(); // читаем весь текст из файла
                    }
                }

                workingText.Rtf = rtfText; // устанавливаем RTF-текст в контрол
                
            }
        }

        private void InHtmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkHtml wrk = new WorkHtml();
            workingText.Text = wrk.convertRichTextInHtmlText(workingText);
          //  TextWriter tw=TextWriter.Null;
           // wrk.convertRichTextInHtmlText(tw, workingText.Rtf);


        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = "c:\\";
            openFile.Filter = "Текстовый файл|*.txt|Текст в формате ртф|*.rtf|Любые файлы|*.*";
            openFile.FilterIndex = 2;
            openFile.RestoreDirectory = true;
            if(openFile.ShowDialog()== DialogResult.OK)
            {
                RichTextBoxStreamType streamType = openFile.FileName.EndsWith("rtf") ?
                RichTextBoxStreamType.RichText : RichTextBoxStreamType.PlainText;
                richTextBox1.LoadFile(openFile.FileName, streamType);
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.InitialDirectory = "c:\\";
            saveFile.Filter = "Текстовый файл|*.txt|Текст в формате ртф|*.rtf";
            saveFile.FilterIndex = 2;
            saveFile.RestoreDirectory = true;
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFile.FileName);
            }
        }

        private void цветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = color.Color;
            }
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            if (font.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = font.Font;
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.Show();
        }
    }
}

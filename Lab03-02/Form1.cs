using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace Lab03_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadFontAndSize();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            foreach (FontFamily font in new InstalledFontCollection().Families)
            {
                toolStripComboBox1.Items.Add(font.Name);
            }

           
            int[] sizes = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (int size in sizes)
            {
                toolStripComboBox2.Items.Add(size.ToString());
            }

            
            toolStripComboBox1.Text = "Tahoma";
            toolStripComboBox2.Text = "14";
            richTextBox1.Font = new Font("Tahoma", 14);
        }
        private void LoadFontAndSize()
        {
            // Load Fonts
            foreach (FontFamily font in new InstalledFontCollection().Families)
            {
                toolStripComboBox1.Items.Add(font.Name);
            }
            int[] sizes = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (int size in sizes)
            {
                toolStripComboBox2.Items.Add(size.ToString());
            }

            // Đặt giá trị mặc định
            toolStripComboBox1.Text = "Tahoma";
            toolStripComboBox2.Text = "14";
            richTextBox1.Font = new Font("Tahoma", 14);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void thoaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            if (toolStripComboBox1.SelectedItem != null && !string.IsNullOrEmpty(toolStripComboBox2.Text))
            {
                string fontName = toolStripComboBox1.SelectedItem.ToString();
                float fontSize = float.Parse(toolStripComboBox2.Text);
                richTextBox1.Font = new Font(fontName, fontSize);
            }
        }

        private void toolStripComboBox2_Click(object sender, EventArgs e)
        {
            if (toolStripComboBox1.SelectedItem != null && !string.IsNullOrEmpty(toolStripComboBox2.Text))
            {
                string fontName = toolStripComboBox1.SelectedItem.ToString();
                float fontSize = float.Parse(toolStripComboBox2.Text);
                richTextBox1.Font = new Font(fontName, fontSize);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                FontStyle style = richTextBox1.SelectionFont.Style;
                style = richTextBox1.SelectionFont.Bold ? style & ~FontStyle.Bold : style | FontStyle.Bold;
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                FontStyle style = richTextBox1.SelectionFont.Style;
                style = richTextBox1.SelectionFont.Italic ? style & ~FontStyle.Italic : style | FontStyle.Italic;
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                FontStyle style = richTextBox1.SelectionFont.Style;
                style = richTextBox1.SelectionFont.Underline ? style & ~FontStyle.Underline : style | FontStyle.Underline;
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);
            }
        }
     

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tạoVănBảnMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            toolStripComboBox1.Text = "Tahoma";
            toolStripComboBox2.Text = "14";
            richTextBox1.Font = new Font("Tahoma", 14);
        }

        private void mởTậpTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt|Rich Text Files (*.rtf)|*.rtf"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog.FileName.EndsWith(".rtf"))
                {
                    richTextBox1.LoadFile(openFileDialog.FileName);
                }
                else
                {
                    richTextBox1.Text = File.ReadAllText(openFileDialog.FileName);
                }
            }
        }

        private void lưuNộiDungVănBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Rich Text Files (*.rtf)|*.rtf"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog.FileName);
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog.Font;
                richTextBox1.ForeColor = fontDialog.Color;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfoSystem.View
{
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
        }
        public InfoForm(string textUverenie)
        {
            InitializeComponent();
            richTextBoxText.Text=textUverenie;
            
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
               
                if (richTextBoxText.SelectedText == "")
                {
                    richTextBoxText.Font = fontDialog1.Font;
                }
                else
                {
                    richTextBoxText.SelectionFont = fontDialog1.Font;
                }
            }

        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {

                if (richTextBoxText.SelectedText == "")
                {
                    richTextBoxText.ForeColor = colorDialog1.Color;
                }
                else
                {
                    richTextBoxText.SelectionColor = colorDialog1.Color;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog.DefaultExt = "*.rtf";
            saveFileDialog.Filter = "RTF Files|*.rtf";
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK
            && (saveFileDialog.FileName.Length > 0))
            {
                try
                {
                    // Save the contents of the RichTextBox into the file.
                    richTextBoxText.SaveFile(saveFileDialog.FileName);
                }
                catch (Exception)
                {
                    MessageBox.Show("Файлът не беше съхранен, поради грешка в записа!",
                    "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentInfoSystem.Data;

namespace StudentInfoSystem.View
{
    public partial class GroupsForm : Form
    {
        public GroupsForm()
        {
            InitializeComponent();
            List<int> groups = Data.UserData.GetStudentGroups();
            foreach (var group in groups)
            {
                comboBox1.Items.Add(group);
            }
            comboBox1.Items.Add("ALL");
        }

        private void GroupsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentInfoDatabaseDataSet.Students' table. You can move, or remove it, as needed.
           this.studentsTableAdapter.Fill(this.studentInfoDatabaseDataSet.Students);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!comboBox1.SelectedItem.Equals("ALL"))
            {
                try
                {
                    this.studentsTableAdapter.FillByGroup(this.studentInfoDatabaseDataSet.Students, ((int)(System.Convert.ChangeType(comboBox1.SelectedItem, typeof(int)))));
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    this.studentsTableAdapter.Fill(this.studentInfoDatabaseDataSet.Students);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

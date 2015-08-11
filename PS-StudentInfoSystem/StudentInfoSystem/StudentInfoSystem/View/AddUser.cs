using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentInfoSystem.Logic;

namespace StudentInfoSystem.View
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }
        void ClearAllUserControls()
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtFacNum.Text = "";
        }
        private Data.User ReadUserInfo()
        {
            Data.User user = new Data.User();
            user.Username = txtUserName.Text;
            user.Password = txtPassword.Text;
            user.FacNumber = txtFacNum.Text;
            if (radioStudent.Checked)
            {
                user.Role = 1;
            }
            else if (radioTeacher.Checked)
            {
                user.Role = 2;
            }
            return user;
        }

        private void bntAddUser_Click(object sender, EventArgs e)
        {
            LoginValidation dc = new LoginValidation();
            if (dc.InsertUserIfValid(ReadUserInfo()))
            {
                MessageBox.Show("The user is added successfully");
                ClearAllUserControls();
            }
            else{
                MessageBox.Show(dc.errText);
            }
        }

    }
}

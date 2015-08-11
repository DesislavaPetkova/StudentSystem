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
    public enum UserStatus
    {
        ANONYMOUS, STUDENT, ADMIN
    }

    public partial class MainForm : Form
    {
        public UserStatus userStatus { get; private set; }
        public MainForm()
        {
            InitializeComponent();
            userStatus = UserStatus.ANONYMOUS;
            DisableAllControls();
        }
        void LogIn()
        {
            LoginForm login = new LoginForm();
            DialogResult res = login.ShowDialog();
            if (res == DialogResult.OK)
            {
                EnableAllControls();
                //takes the data for the student
                Data.Student student = StudentValidation.IsThereStudent(login.user);
                showStudentInfo(student);
                miLogIn.Text = "Logout";
                userStatus = UserStatus.STUDENT;

                if (login.user.Role == 3)
                {
                    userStatus = UserStatus.ADMIN;
                    btnAddStudent.Visible = true;
                    bntAddUser.Visible = true;
                }
                else
                {
                    userStatus = UserStatus.STUDENT;
                }
            }
        }
        void LogOut()
        {
            miLogIn.Text = "Login";

            DisableAllControls();
            ClearAllControls();
            userStatus = UserStatus.ANONYMOUS;
        }

        //accept parameter from type Student (prints the information)
        private void showStudentInfo(Data.Student student)
        {
            if (student != null)
            {
                txtFirstName.Text = student.FirstName;
                txtSecondName.Text = student.SecondName;
                txtLastName.Text = student.LastName;

                txtFaculty.Text = student.Faculty;
                txtSpecialty.Text = student.Specialty;
                comboOKS.SelectedIndex = student.OKS;
                comboStudentStatus.SelectedIndex = student.StudentStatus;
                txtFakNumber.Text = student.FakNumber;
                numCourse.Value = student.Course;
                txtPotok.Text = student.Potok;
                txtGrpup.Text = Convert.ToString(student.Group);
            }
            //else
            //{
            //    MessageBox.Show("There is no data for this student");
            //}

        }

        void ClearAllControls()
        {
            txtFirstName.Text = "";
            txtSecondName.Text = "";
            txtLastName.Text = "";

            txtFaculty.Text = "";
            txtSpecialty.Text = "";
            comboOKS.SelectedIndex = -1;
            comboStudentStatus.SelectedIndex = -1;
            txtFakNumber.Text = "";
            numCourse.Value = 0;
            txtPotok.Text = "";
            txtGrpup.Text = "";

        }
        void EnableAllControls()
        {
            gbStudentData.Enabled = true;
            gbStudentInfo.Enabled = true;
            gbStudentPhoto.Enabled = true;
            openPictureTool.Enabled = true;
            pictureBox1.Visible = true;
            infoFormTool.Enabled = true;
        }
        void DisableAllControls()
        {
            gbStudentData.Enabled = false;
            gbStudentInfo.Enabled = false;
            gbStudentPhoto.Enabled = false;
            openPictureTool.Enabled = false;
            pictureBox1.Visible = false;
            infoFormTool.Enabled = false;
            btnAddStudent.Visible = false;
            bntAddUser.Visible = false;
        }


        private void miLogIn_Click(object sender, EventArgs e)
        {
            switch (userStatus)
            {
                case UserStatus.ANONYMOUS:
                    DialogResult logInForm = new DialogResult();
                    LogIn();
                    break;
                case UserStatus.STUDENT:
                    LogOut();
                    break;
                case UserStatus.ADMIN:
                    LogOut();
                    break;
                default:
                    break;
            }
        }

        private void about_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            DialogResult res = about.ShowDialog();

        }

        private void openPictureTool_Click(object sender, EventArgs e)
        {
            LoadStudentPicture();
        }

        private void LoadStudentPicture()
        {
            if (openPictureDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openPictureDialog.FileName;
            }
        }

        private void infoFormTool_Click(object sender, EventArgs e)
        {
            string text = GenerateInfoText();
            InfoForm info = new InfoForm(text);
            info.Show();
        }
        private string GenerateInfoText()
        {
            string text = "\t\tУверение \n";
            text += " " + txtFirstName.Text + " " + txtSecondName.Text + " " + txtLastName.Text + "\n";
            text += " е студент/ка във Факултет " + txtFaculty.Text + ", специалност " + txtSpecialty.Text;
            text += "\n";
            text += " Курс: " + numCourse.Value + "  Поток:" + txtPotok.Text + "  Група:" + txtGrpup.Text + "\n";
            text += " Настоящето се издава в уверение на ....\n";
            text += " Уверениетосе издава да послужи пред....";

            return text;
        }


        private Data.Student ReadStudentInfo()
        {
            Data.Student student = new Data.Student();
            student.FirstName = txtFirstName.Text;
            student.SecondName = txtSecondName.Text;
            student.LastName = txtLastName.Text;

            student.Faculty = txtFaculty.Text;
            student.Specialty = txtSpecialty.Text;
            student.OKS = (Int16)comboOKS.SelectedIndex;
            student.StudentStatus = (Int16)comboStudentStatus.SelectedIndex;
            student.FakNumber = txtFakNumber.Text;
            student.Course = (Int16)numCourse.Value;
            student.Potok = txtPotok.Text;
            student.Group = Int32.Parse(txtGrpup.Text);
            return student;
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            StudentValidation sv = new StudentValidation();
            if (sv.InsertStudentIfValid(ReadStudentInfo()))
            {
                MessageBox.Show("The student is added successfully");
                ClearAllControls();
            }
            else
            {
                MessageBox.Show(sv.errText);
            }
        }

        private void groupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupsForm group = new GroupsForm();
            group.Show();

        }

        private void bntAddUser_Click(object sender, EventArgs e)
        {
            AddUser user = new AddUser();
            user.Show();
        }



    }
}

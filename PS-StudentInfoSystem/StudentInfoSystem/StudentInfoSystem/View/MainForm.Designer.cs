namespace StudentInfoSystem.View
{
    partial class MainForm
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
            this.manuMain = new System.Windows.Forms.MenuStrip();
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miLogIn = new System.Windows.Forms.ToolStripMenuItem();
            this.miNew = new System.Windows.Forms.ToolStripMenuItem();
            this.openPictureTool = new System.Windows.Forms.ToolStripMenuItem();
            this.infoFormTool = new System.Windows.Forms.ToolStripMenuItem();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.miEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.miView = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.miHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.groupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlStudentInfo = new System.Windows.Forms.TabControl();
            this.Студент = new System.Windows.Forms.TabPage();
            this.gbStudentInfo = new System.Windows.Forms.GroupBox();
            this.txtGrpup = new System.Windows.Forms.TextBox();
            this.txtPotok = new System.Windows.Forms.TextBox();
            this.lblGroup = new System.Windows.Forms.Label();
            this.lblPotok = new System.Windows.Forms.Label();
            this.numCourse = new System.Windows.Forms.NumericUpDown();
            this.lblCourse = new System.Windows.Forms.Label();
            this.comboStudentStatus = new System.Windows.Forms.ComboBox();
            this.comboOKS = new System.Windows.Forms.ComboBox();
            this.txtFakNumber = new System.Windows.Forms.TextBox();
            this.txtSpecialty = new System.Windows.Forms.TextBox();
            this.txtFaculty = new System.Windows.Forms.TextBox();
            this.lblFakNumber = new System.Windows.Forms.Label();
            this.lblStudentStatus = new System.Windows.Forms.Label();
            this.lblOKS = new System.Windows.Forms.Label();
            this.lblSpecialty = new System.Windows.Forms.Label();
            this.lblFaculty = new System.Windows.Forms.Label();
            this.gbStudentPhoto = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbStudentData = new System.Windows.Forms.GroupBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblSecondName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tabMarks = new System.Windows.Forms.TabPage();
            this.openPictureDialog = new System.Windows.Forms.OpenFileDialog();
            this.bntAddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.manuMain.SuspendLayout();
            this.tabControlStudentInfo.SuspendLayout();
            this.Студент.SuspendLayout();
            this.gbStudentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCourse)).BeginInit();
            this.gbStudentPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbStudentData.SuspendLayout();
            this.SuspendLayout();
            // 
            // manuMain
            // 
            this.manuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile,
            this.miEdit,
            this.miView,
            this.miHelp,
            this.btnAddStudent,
            this.bntAddUser,
            this.groupsToolStripMenuItem});
            this.manuMain.Location = new System.Drawing.Point(0, 0);
            this.manuMain.Name = "manuMain";
            this.manuMain.Size = new System.Drawing.Size(630, 24);
            this.manuMain.TabIndex = 0;
            this.manuMain.Text = "menuStrip1";
            // 
            // miFile
            // 
            this.miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miLogIn,
            this.miNew,
            this.openPictureTool,
            this.infoFormTool,
            this.miExit});
            this.miFile.Name = "miFile";
            this.miFile.Size = new System.Drawing.Size(37, 20);
            this.miFile.Text = "File";
            // 
            // miLogIn
            // 
            this.miLogIn.Name = "miLogIn";
            this.miLogIn.Size = new System.Drawing.Size(143, 22);
            this.miLogIn.Text = "LogIn";
            this.miLogIn.Click += new System.EventHandler(this.miLogIn_Click);
            // 
            // miNew
            // 
            this.miNew.Name = "miNew";
            this.miNew.Size = new System.Drawing.Size(143, 22);
            this.miNew.Text = "New";
            // 
            // openPictureTool
            // 
            this.openPictureTool.Name = "openPictureTool";
            this.openPictureTool.Size = new System.Drawing.Size(143, 22);
            this.openPictureTool.Text = "Open picture";
            this.openPictureTool.Click += new System.EventHandler(this.openPictureTool_Click);
            // 
            // infoFormTool
            // 
            this.infoFormTool.Name = "infoFormTool";
            this.infoFormTool.Size = new System.Drawing.Size(143, 22);
            this.infoFormTool.Text = "Info form";
            this.infoFormTool.Click += new System.EventHandler(this.infoFormTool_Click);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(143, 22);
            this.miExit.Text = "Exit";
            // 
            // miEdit
            // 
            this.miEdit.Name = "miEdit";
            this.miEdit.Size = new System.Drawing.Size(39, 20);
            this.miEdit.Text = "Edit";
            // 
            // miView
            // 
            this.miView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.about});
            this.miView.Name = "miView";
            this.miView.Size = new System.Drawing.Size(44, 20);
            this.miView.Text = "View";
            // 
            // about
            // 
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(107, 22);
            this.about.Text = "About";
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // miHelp
            // 
            this.miHelp.Name = "miHelp";
            this.miHelp.Size = new System.Drawing.Size(44, 20);
            this.miHelp.Text = "Help";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(85, 20);
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // groupsToolStripMenuItem
            // 
            this.groupsToolStripMenuItem.Name = "groupsToolStripMenuItem";
            this.groupsToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.groupsToolStripMenuItem.Text = "Groups ";
            this.groupsToolStripMenuItem.Click += new System.EventHandler(this.groupsToolStripMenuItem_Click);
            // 
            // tabControlStudentInfo
            // 
            this.tabControlStudentInfo.Controls.Add(this.Студент);
            this.tabControlStudentInfo.Controls.Add(this.tabMarks);
            this.tabControlStudentInfo.Location = new System.Drawing.Point(12, 27);
            this.tabControlStudentInfo.Name = "tabControlStudentInfo";
            this.tabControlStudentInfo.SelectedIndex = 0;
            this.tabControlStudentInfo.Size = new System.Drawing.Size(610, 351);
            this.tabControlStudentInfo.TabIndex = 1;
            // 
            // Студент
            // 
            this.Студент.Controls.Add(this.gbStudentInfo);
            this.Студент.Controls.Add(this.gbStudentPhoto);
            this.Студент.Controls.Add(this.gbStudentData);
            this.Студент.Location = new System.Drawing.Point(4, 22);
            this.Студент.Name = "Студент";
            this.Студент.Padding = new System.Windows.Forms.Padding(3);
            this.Студент.Size = new System.Drawing.Size(602, 325);
            this.Студент.TabIndex = 0;
            this.Студент.Text = "Студент";
            this.Студент.UseVisualStyleBackColor = true;
            // 
            // gbStudentInfo
            // 
            this.gbStudentInfo.Controls.Add(this.txtGrpup);
            this.gbStudentInfo.Controls.Add(this.txtPotok);
            this.gbStudentInfo.Controls.Add(this.lblGroup);
            this.gbStudentInfo.Controls.Add(this.lblPotok);
            this.gbStudentInfo.Controls.Add(this.numCourse);
            this.gbStudentInfo.Controls.Add(this.lblCourse);
            this.gbStudentInfo.Controls.Add(this.comboStudentStatus);
            this.gbStudentInfo.Controls.Add(this.comboOKS);
            this.gbStudentInfo.Controls.Add(this.txtFakNumber);
            this.gbStudentInfo.Controls.Add(this.txtSpecialty);
            this.gbStudentInfo.Controls.Add(this.txtFaculty);
            this.gbStudentInfo.Controls.Add(this.lblFakNumber);
            this.gbStudentInfo.Controls.Add(this.lblStudentStatus);
            this.gbStudentInfo.Controls.Add(this.lblOKS);
            this.gbStudentInfo.Controls.Add(this.lblSpecialty);
            this.gbStudentInfo.Controls.Add(this.lblFaculty);
            this.gbStudentInfo.Location = new System.Drawing.Point(147, 126);
            this.gbStudentInfo.Name = "gbStudentInfo";
            this.gbStudentInfo.Size = new System.Drawing.Size(434, 182);
            this.gbStudentInfo.TabIndex = 2;
            this.gbStudentInfo.TabStop = false;
            this.gbStudentInfo.Text = "Студентска информация";
            // 
            // txtGrpup
            // 
            this.txtGrpup.Location = new System.Drawing.Point(312, 96);
            this.txtGrpup.Name = "txtGrpup";
            this.txtGrpup.Size = new System.Drawing.Size(100, 20);
            this.txtGrpup.TabIndex = 17;
            // 
            // txtPotok
            // 
            this.txtPotok.Location = new System.Drawing.Point(312, 66);
            this.txtPotok.Name = "txtPotok";
            this.txtPotok.Size = new System.Drawing.Size(100, 20);
            this.txtPotok.TabIndex = 16;
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(264, 96);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(36, 13);
            this.lblGroup.TabIndex = 15;
            this.lblGroup.Text = "Група";
            // 
            // lblPotok
            // 
            this.lblPotok.AutoSize = true;
            this.lblPotok.Location = new System.Drawing.Point(264, 66);
            this.lblPotok.Name = "lblPotok";
            this.lblPotok.Size = new System.Drawing.Size(38, 13);
            this.lblPotok.TabIndex = 14;
            this.lblPotok.Text = "Поток";
            // 
            // numCourse
            // 
            this.numCourse.Location = new System.Drawing.Point(311, 33);
            this.numCourse.Name = "numCourse";
            this.numCourse.Size = new System.Drawing.Size(67, 20);
            this.numCourse.TabIndex = 13;
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(264, 36);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(31, 13);
            this.lblCourse.TabIndex = 12;
            this.lblCourse.Text = "Курс";
            // 
            // comboStudentStatus
            // 
            this.comboStudentStatus.FormattingEnabled = true;
            this.comboStudentStatus.Items.AddRange(new object[] {
            "Regular",
            "External"});
            this.comboStudentStatus.Location = new System.Drawing.Point(77, 114);
            this.comboStudentStatus.Name = "comboStudentStatus";
            this.comboStudentStatus.Size = new System.Drawing.Size(121, 21);
            this.comboStudentStatus.TabIndex = 11;
            // 
            // comboOKS
            // 
            this.comboOKS.FormattingEnabled = true;
            this.comboOKS.Items.AddRange(new object[] {
            "bachelor",
            "master"});
            this.comboOKS.Location = new System.Drawing.Point(77, 86);
            this.comboOKS.Name = "comboOKS";
            this.comboOKS.Size = new System.Drawing.Size(121, 21);
            this.comboOKS.TabIndex = 10;
            // 
            // txtFakNumber
            // 
            this.txtFakNumber.Location = new System.Drawing.Point(77, 143);
            this.txtFakNumber.Name = "txtFakNumber";
            this.txtFakNumber.Size = new System.Drawing.Size(121, 20);
            this.txtFakNumber.TabIndex = 9;
            // 
            // txtSpecialty
            // 
            this.txtSpecialty.Location = new System.Drawing.Point(77, 59);
            this.txtSpecialty.Name = "txtSpecialty";
            this.txtSpecialty.Size = new System.Drawing.Size(121, 20);
            this.txtSpecialty.TabIndex = 6;
            // 
            // txtFaculty
            // 
            this.txtFaculty.Location = new System.Drawing.Point(77, 33);
            this.txtFaculty.Name = "txtFaculty";
            this.txtFaculty.Size = new System.Drawing.Size(121, 20);
            this.txtFaculty.TabIndex = 5;
            // 
            // lblFakNumber
            // 
            this.lblFakNumber.AutoSize = true;
            this.lblFakNumber.Location = new System.Drawing.Point(4, 150);
            this.lblFakNumber.Name = "lblFakNumber";
            this.lblFakNumber.Size = new System.Drawing.Size(68, 13);
            this.lblFakNumber.TabIndex = 4;
            this.lblFakNumber.Text = "Фак. номер";
            // 
            // lblStudentStatus
            // 
            this.lblStudentStatus.AutoSize = true;
            this.lblStudentStatus.Location = new System.Drawing.Point(34, 96);
            this.lblStudentStatus.Name = "lblStudentStatus";
            this.lblStudentStatus.Size = new System.Drawing.Size(29, 13);
            this.lblStudentStatus.TabIndex = 3;
            this.lblStudentStatus.Text = "ОКС";
            // 
            // lblOKS
            // 
            this.lblOKS.AutoSize = true;
            this.lblOKS.Location = new System.Drawing.Point(22, 122);
            this.lblOKS.Name = "lblOKS";
            this.lblOKS.Size = new System.Drawing.Size(41, 13);
            this.lblOKS.TabIndex = 2;
            this.lblOKS.Text = "Статус";
            // 
            // lblSpecialty
            // 
            this.lblSpecialty.AutoSize = true;
            this.lblSpecialty.Location = new System.Drawing.Point(2, 66);
            this.lblSpecialty.Name = "lblSpecialty";
            this.lblSpecialty.Size = new System.Drawing.Size(73, 13);
            this.lblSpecialty.TabIndex = 1;
            this.lblSpecialty.Text = "Специалност";
            // 
            // lblFaculty
            // 
            this.lblFaculty.AutoSize = true;
            this.lblFaculty.Location = new System.Drawing.Point(18, 40);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(57, 13);
            this.lblFaculty.TabIndex = 0;
            this.lblFaculty.Text = "Факултет";
            // 
            // gbStudentPhoto
            // 
            this.gbStudentPhoto.Controls.Add(this.pictureBox1);
            this.gbStudentPhoto.Location = new System.Drawing.Point(6, 6);
            this.gbStudentPhoto.Name = "gbStudentPhoto";
            this.gbStudentPhoto.Size = new System.Drawing.Size(119, 168);
            this.gbStudentPhoto.TabIndex = 0;
            this.gbStudentPhoto.TabStop = false;
            this.gbStudentPhoto.Text = "Снимка";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(20, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gbStudentData
            // 
            this.gbStudentData.Controls.Add(this.txtLastName);
            this.gbStudentData.Controls.Add(this.txtSecondName);
            this.gbStudentData.Controls.Add(this.txtFirstName);
            this.gbStudentData.Controls.Add(this.lblLastName);
            this.gbStudentData.Controls.Add(this.lblSecondName);
            this.gbStudentData.Controls.Add(this.lblFirstName);
            this.gbStudentData.Location = new System.Drawing.Point(147, 6);
            this.gbStudentData.Name = "gbStudentData";
            this.gbStudentData.Size = new System.Drawing.Size(434, 114);
            this.gbStudentData.TabIndex = 1;
            this.gbStudentData.TabStop = false;
            this.gbStudentData.Text = "PersonalData";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(77, 87);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(326, 20);
            this.txtLastName.TabIndex = 5;
            // 
            // txtSecondName
            // 
            this.txtSecondName.Location = new System.Drawing.Point(77, 54);
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(326, 20);
            this.txtSecondName.TabIndex = 4;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(77, 21);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(326, 20);
            this.txtFirstName.TabIndex = 3;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(19, 87);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(56, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Фамилия";
            // 
            // lblSecondName
            // 
            this.lblSecondName.AutoSize = true;
            this.lblSecondName.Location = new System.Drawing.Point(19, 54);
            this.lblSecondName.Name = "lblSecondName";
            this.lblSecondName.Size = new System.Drawing.Size(53, 13);
            this.lblSecondName.TabIndex = 1;
            this.lblSecondName.Text = "Презиме";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(20, 29);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(29, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "Име";
            // 
            // tabMarks
            // 
            this.tabMarks.Location = new System.Drawing.Point(4, 22);
            this.tabMarks.Name = "tabMarks";
            this.tabMarks.Padding = new System.Windows.Forms.Padding(3);
            this.tabMarks.Size = new System.Drawing.Size(602, 325);
            this.tabMarks.TabIndex = 1;
            this.tabMarks.Text = "Оценки";
            this.tabMarks.UseVisualStyleBackColor = true;
            // 
            // openPictureDialog
            // 
            this.openPictureDialog.FileName = "openPictureDialog";
            this.openPictureDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            // 
            // bntAddUser
            // 
            this.bntAddUser.Name = "bntAddUser";
            this.bntAddUser.Size = new System.Drawing.Size(67, 20);
            this.bntAddUser.Text = "Add User";
            this.bntAddUser.Click += new System.EventHandler(this.bntAddUser_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 392);
            this.Controls.Add(this.tabControlStudentInfo);
            this.Controls.Add(this.manuMain);
            this.MainMenuStrip = this.manuMain;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.manuMain.ResumeLayout(false);
            this.manuMain.PerformLayout();
            this.tabControlStudentInfo.ResumeLayout(false);
            this.Студент.ResumeLayout(false);
            this.gbStudentInfo.ResumeLayout(false);
            this.gbStudentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCourse)).EndInit();
            this.gbStudentPhoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbStudentData.ResumeLayout(false);
            this.gbStudentData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip manuMain;
        private System.Windows.Forms.ToolStripMenuItem miFile;
        private System.Windows.Forms.ToolStripMenuItem miEdit;
        private System.Windows.Forms.ToolStripMenuItem miView;
        private System.Windows.Forms.ToolStripMenuItem about;
        private System.Windows.Forms.TabControl tabControlStudentInfo;
        private System.Windows.Forms.TabPage Студент;
        private System.Windows.Forms.GroupBox gbStudentData;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtSecondName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblSecondName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.GroupBox gbStudentPhoto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabMarks;
        private System.Windows.Forms.GroupBox gbStudentInfo;
        private System.Windows.Forms.TextBox txtFakNumber;
        private System.Windows.Forms.TextBox txtSpecialty;
        private System.Windows.Forms.TextBox txtFaculty;
        private System.Windows.Forms.Label lblFakNumber;
        private System.Windows.Forms.Label lblStudentStatus;
        private System.Windows.Forms.Label lblOKS;
        private System.Windows.Forms.Label lblSpecialty;
        private System.Windows.Forms.Label lblFaculty;
        private System.Windows.Forms.TextBox txtGrpup;
        private System.Windows.Forms.TextBox txtPotok;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Label lblPotok;
        private System.Windows.Forms.NumericUpDown numCourse;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.ComboBox comboStudentStatus;
        private System.Windows.Forms.ComboBox comboOKS;
        private System.Windows.Forms.ToolStripMenuItem miHelp;
        private System.Windows.Forms.ToolStripMenuItem miLogIn;
        private System.Windows.Forms.ToolStripMenuItem miNew;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripMenuItem openPictureTool;
        private System.Windows.Forms.OpenFileDialog openPictureDialog;
        private System.Windows.Forms.ToolStripMenuItem infoFormTool;
        private System.Windows.Forms.ToolStripMenuItem btnAddStudent;
        private System.Windows.Forms.ToolStripMenuItem groupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bntAddUser;
    }
}
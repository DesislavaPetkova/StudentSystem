namespace StudentInfoSystem.View
{
    partial class AddUser
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
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbFaKNumber = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtFacNum = new System.Windows.Forms.TextBox();
            this.radioStudent = new System.Windows.Forms.RadioButton();
            this.bntAddUser = new System.Windows.Forms.Button();
            this.radioTeacher = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(38, 59);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(60, 13);
            this.lbUserName.TabIndex = 0;
            this.lbUserName.Text = "User Name";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(38, 97);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(53, 13);
            this.lbPassword.TabIndex = 1;
            this.lbPassword.Text = "Password";
            // 
            // lbFaKNumber
            // 
            this.lbFaKNumber.AutoSize = true;
            this.lbFaKNumber.Location = new System.Drawing.Point(38, 135);
            this.lbFaKNumber.Name = "lbFaKNumber";
            this.lbFaKNumber.Size = new System.Drawing.Size(62, 13);
            this.lbFaKNumber.TabIndex = 2;
            this.lbFaKNumber.Text = "FacNumber";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(104, 56);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(125, 20);
            this.txtUserName.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(104, 94);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(125, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // txtFacNum
            // 
            this.txtFacNum.Location = new System.Drawing.Point(104, 132);
            this.txtFacNum.Name = "txtFacNum";
            this.txtFacNum.Size = new System.Drawing.Size(125, 20);
            this.txtFacNum.TabIndex = 5;
            // 
            // radioStudent
            // 
            this.radioStudent.AutoSize = true;
            this.radioStudent.Location = new System.Drawing.Point(48, 179);
            this.radioStudent.Name = "radioStudent";
            this.radioStudent.Size = new System.Drawing.Size(62, 17);
            this.radioStudent.TabIndex = 6;
            this.radioStudent.TabStop = true;
            this.radioStudent.Text = "Student";
            this.radioStudent.UseVisualStyleBackColor = true;
            // 
            // bntAddUser
            // 
            this.bntAddUser.Location = new System.Drawing.Point(87, 221);
            this.bntAddUser.Name = "bntAddUser";
            this.bntAddUser.Size = new System.Drawing.Size(75, 23);
            this.bntAddUser.TabIndex = 7;
            this.bntAddUser.Text = "Add User";
            this.bntAddUser.UseVisualStyleBackColor = true;
            this.bntAddUser.Click += new System.EventHandler(this.bntAddUser_Click);
            // 
            // radioTeacher
            // 
            this.radioTeacher.AutoSize = true;
            this.radioTeacher.Location = new System.Drawing.Point(151, 179);
            this.radioTeacher.Name = "radioTeacher";
            this.radioTeacher.Size = new System.Drawing.Size(65, 17);
            this.radioTeacher.TabIndex = 8;
            this.radioTeacher.TabStop = true;
            this.radioTeacher.Text = "Teacher";
            this.radioTeacher.UseVisualStyleBackColor = true;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 267);
            this.Controls.Add(this.radioTeacher);
            this.Controls.Add(this.bntAddUser);
            this.Controls.Add(this.radioStudent);
            this.Controls.Add(this.txtFacNum);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lbFaKNumber);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUserName);
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbFaKNumber;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtFacNum;
        private System.Windows.Forms.RadioButton radioStudent;
        private System.Windows.Forms.Button bntAddUser;
        private System.Windows.Forms.RadioButton radioTeacher;
    }
}
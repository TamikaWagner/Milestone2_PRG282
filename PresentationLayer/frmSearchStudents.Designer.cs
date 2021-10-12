
namespace PRG282_Milestone2.PresentationLayer
{
    partial class frmSearchStudents
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
            this.btn_SUpdate = new System.Windows.Forms.Button();
            this.btn_SView = new System.Windows.Forms.Button();
            this.btn_SReg = new System.Windows.Forms.Button();
            this.btn_SReturn = new System.Windows.Forms.Button();
            this.pnlStudentDetails = new System.Windows.Forms.Panel();
            this.lbl_SHeading = new System.Windows.Forms.Label();
            this.pnlSearchStudent = new System.Windows.Forms.Panel();
            this.lbl_SDetailsFor = new System.Windows.Forms.Label();
            this.CourseID = new System.Windows.Forms.TextBox();
            this.Lastname = new System.Windows.Forms.TextBox();
            this.StudentName = new System.Windows.Forms.TextBox();
            this.StudentID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_SDStudentID = new System.Windows.Forms.Label();
            this.cmb_S_CourseID = new System.Windows.Forms.ComboBox();
            this.txt_S_LastName = new System.Windows.Forms.TextBox();
            this.txt_SStudentName = new System.Windows.Forms.TextBox();
            this.txt_SStudentID = new System.Windows.Forms.TextBox();
            this.lbl_SLastname = new System.Windows.Forms.Label();
            this.lbl_SCourseID = new System.Windows.Forms.Label();
            this.lbl_SStudentName = new System.Windows.Forms.Label();
            this.lbl_SStudentID = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.pnlStudentDetails.SuspendLayout();
            this.pnlSearchStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_SUpdate
            // 
            this.btn_SUpdate.BackColor = System.Drawing.Color.White;
            this.btn_SUpdate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SUpdate.Location = new System.Drawing.Point(146, 271);
            this.btn_SUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_SUpdate.Name = "btn_SUpdate";
            this.btn_SUpdate.Size = new System.Drawing.Size(91, 31);
            this.btn_SUpdate.TabIndex = 9;
            this.btn_SUpdate.Text = "Update";
            this.btn_SUpdate.UseVisualStyleBackColor = false;
            // 
            // btn_SView
            // 
            this.btn_SView.BackColor = System.Drawing.Color.White;
            this.btn_SView.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SView.Location = new System.Drawing.Point(17, 271);
            this.btn_SView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_SView.Name = "btn_SView";
            this.btn_SView.Size = new System.Drawing.Size(87, 31);
            this.btn_SView.TabIndex = 10;
            this.btn_SView.Text = "View Student";
            this.btn_SView.UseVisualStyleBackColor = false;
            // 
            // btn_SReg
            // 
            this.btn_SReg.BackColor = System.Drawing.Color.White;
            this.btn_SReg.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SReg.Location = new System.Drawing.Point(399, 272);
            this.btn_SReg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_SReg.Name = "btn_SReg";
            this.btn_SReg.Size = new System.Drawing.Size(91, 30);
            this.btn_SReg.TabIndex = 11;
            this.btn_SReg.Text = "Register";
            this.btn_SReg.UseVisualStyleBackColor = false;
            this.btn_SReg.Click += new System.EventHandler(this.btn_SReg_Click);
            // 
            // btn_SReturn
            // 
            this.btn_SReturn.BackColor = System.Drawing.Color.White;
            this.btn_SReturn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SReturn.Location = new System.Drawing.Point(522, 272);
            this.btn_SReturn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_SReturn.Name = "btn_SReturn";
            this.btn_SReturn.Size = new System.Drawing.Size(136, 30);
            this.btn_SReturn.TabIndex = 12;
            this.btn_SReturn.Text = "Return to Menu";
            this.btn_SReturn.UseVisualStyleBackColor = false;
            // 
            // pnlStudentDetails
            // 
            this.pnlStudentDetails.Controls.Add(this.lbl_SHeading);
            this.pnlStudentDetails.Controls.Add(this.pnlSearchStudent);
            this.pnlStudentDetails.Controls.Add(this.cmb_S_CourseID);
            this.pnlStudentDetails.Controls.Add(this.txt_S_LastName);
            this.pnlStudentDetails.Controls.Add(this.txt_SStudentName);
            this.pnlStudentDetails.Controls.Add(this.txt_SStudentID);
            this.pnlStudentDetails.Controls.Add(this.lbl_SLastname);
            this.pnlStudentDetails.Controls.Add(this.lbl_SCourseID);
            this.pnlStudentDetails.Controls.Add(this.lbl_SStudentName);
            this.pnlStudentDetails.Controls.Add(this.lbl_SStudentID);
            this.pnlStudentDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStudentDetails.Location = new System.Drawing.Point(0, 0);
            this.pnlStudentDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlStudentDetails.Name = "pnlStudentDetails";
            this.pnlStudentDetails.Size = new System.Drawing.Size(673, 263);
            this.pnlStudentDetails.TabIndex = 13;
            // 
            // lbl_SHeading
            // 
            this.lbl_SHeading.AutoSize = true;
            this.lbl_SHeading.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SHeading.Location = new System.Drawing.Point(69, 13);
            this.lbl_SHeading.Name = "lbl_SHeading";
            this.lbl_SHeading.Size = new System.Drawing.Size(208, 18);
            this.lbl_SHeading.TabIndex = 17;
            this.lbl_SHeading.Text = "Enter Student details below.";
            // 
            // pnlSearchStudent
            // 
            this.pnlSearchStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSearchStudent.Controls.Add(this.lbl_SDetailsFor);
            this.pnlSearchStudent.Controls.Add(this.CourseID);
            this.pnlSearchStudent.Controls.Add(this.Lastname);
            this.pnlSearchStudent.Controls.Add(this.StudentName);
            this.pnlSearchStudent.Controls.Add(this.StudentID);
            this.pnlSearchStudent.Controls.Add(this.label1);
            this.pnlSearchStudent.Controls.Add(this.label2);
            this.pnlSearchStudent.Controls.Add(this.label3);
            this.pnlSearchStudent.Controls.Add(this.lbl_SDStudentID);
            this.pnlSearchStudent.Location = new System.Drawing.Point(334, 0);
            this.pnlSearchStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlSearchStudent.Name = "pnlSearchStudent";
            this.pnlSearchStudent.Size = new System.Drawing.Size(336, 263);
            this.pnlSearchStudent.TabIndex = 15;
            // 
            // lbl_SDetailsFor
            // 
            this.lbl_SDetailsFor.AutoSize = true;
            this.lbl_SDetailsFor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SDetailsFor.Location = new System.Drawing.Point(45, 12);
            this.lbl_SDetailsFor.Name = "lbl_SDetailsFor";
            this.lbl_SDetailsFor.Size = new System.Drawing.Size(141, 18);
            this.lbl_SDetailsFor.TabIndex = 25;
            this.lbl_SDetailsFor.Text = "Student details for ";
            // 
            // CourseID
            // 
            this.CourseID.Location = new System.Drawing.Point(153, 187);
            this.CourseID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CourseID.Name = "CourseID";
            this.CourseID.ReadOnly = true;
            this.CourseID.Size = new System.Drawing.Size(116, 22);
            this.CourseID.TabIndex = 24;
            // 
            // Lastname
            // 
            this.Lastname.Location = new System.Drawing.Point(153, 141);
            this.Lastname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Lastname.Name = "Lastname";
            this.Lastname.ReadOnly = true;
            this.Lastname.Size = new System.Drawing.Size(116, 22);
            this.Lastname.TabIndex = 23;
            // 
            // StudentName
            // 
            this.StudentName.Location = new System.Drawing.Point(153, 98);
            this.StudentName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            this.StudentName.Size = new System.Drawing.Size(116, 22);
            this.StudentName.TabIndex = 22;
            // 
            // StudentID
            // 
            this.StudentID.Location = new System.Drawing.Point(153, 55);
            this.StudentID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StudentID.Name = "StudentID";
            this.StudentID.ReadOnly = true;
            this.StudentID.Size = new System.Drawing.Size(116, 22);
            this.StudentID.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Course ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Student Name:";
            // 
            // lbl_SDStudentID
            // 
            this.lbl_SDStudentID.AutoSize = true;
            this.lbl_SDStudentID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SDStudentID.Location = new System.Drawing.Point(41, 59);
            this.lbl_SDStudentID.Name = "lbl_SDStudentID";
            this.lbl_SDStudentID.Size = new System.Drawing.Size(85, 18);
            this.lbl_SDStudentID.TabIndex = 17;
            this.lbl_SDStudentID.Text = "Student ID:";
            // 
            // cmb_S_CourseID
            // 
            this.cmb_S_CourseID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_S_CourseID.FormattingEnabled = true;
            this.cmb_S_CourseID.Location = new System.Drawing.Point(146, 188);
            this.cmb_S_CourseID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_S_CourseID.Name = "cmb_S_CourseID";
            this.cmb_S_CourseID.Size = new System.Drawing.Size(140, 25);
            this.cmb_S_CourseID.TabIndex = 16;
            // 
            // txt_S_LastName
            // 
            this.txt_S_LastName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_S_LastName.Location = new System.Drawing.Point(146, 141);
            this.txt_S_LastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_S_LastName.Name = "txt_S_LastName";
            this.txt_S_LastName.Size = new System.Drawing.Size(116, 22);
            this.txt_S_LastName.TabIndex = 15;
            // 
            // txt_SStudentName
            // 
            this.txt_SStudentName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SStudentName.Location = new System.Drawing.Point(146, 102);
            this.txt_SStudentName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_SStudentName.Name = "txt_SStudentName";
            this.txt_SStudentName.Size = new System.Drawing.Size(116, 22);
            this.txt_SStudentName.TabIndex = 14;
            // 
            // txt_SStudentID
            // 
            this.txt_SStudentID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SStudentID.Location = new System.Drawing.Point(146, 59);
            this.txt_SStudentID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_SStudentID.Name = "txt_SStudentID";
            this.txt_SStudentID.Size = new System.Drawing.Size(116, 22);
            this.txt_SStudentID.TabIndex = 13;
            // 
            // lbl_SLastname
            // 
            this.lbl_SLastname.AutoSize = true;
            this.lbl_SLastname.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SLastname.Location = new System.Drawing.Point(37, 145);
            this.lbl_SLastname.Name = "lbl_SLastname";
            this.lbl_SLastname.Size = new System.Drawing.Size(84, 18);
            this.lbl_SLastname.TabIndex = 12;
            this.lbl_SLastname.Text = "Last Name";
            // 
            // lbl_SCourseID
            // 
            this.lbl_SCourseID.AutoSize = true;
            this.lbl_SCourseID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SCourseID.Location = new System.Drawing.Point(38, 192);
            this.lbl_SCourseID.Name = "lbl_SCourseID";
            this.lbl_SCourseID.Size = new System.Drawing.Size(83, 18);
            this.lbl_SCourseID.TabIndex = 11;
            this.lbl_SCourseID.Text = "Course ID:";
            // 
            // lbl_SStudentName
            // 
            this.lbl_SStudentName.AutoSize = true;
            this.lbl_SStudentName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SStudentName.Location = new System.Drawing.Point(14, 102);
            this.lbl_SStudentName.Name = "lbl_SStudentName";
            this.lbl_SStudentName.Size = new System.Drawing.Size(115, 18);
            this.lbl_SStudentName.TabIndex = 10;
            this.lbl_SStudentName.Text = "Student Name:";
            // 
            // lbl_SStudentID
            // 
            this.lbl_SStudentID.AutoSize = true;
            this.lbl_SStudentID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SStudentID.Location = new System.Drawing.Point(34, 63);
            this.lbl_SStudentID.Name = "lbl_SStudentID";
            this.lbl_SStudentID.Size = new System.Drawing.Size(85, 18);
            this.lbl_SStudentID.TabIndex = 9;
            this.lbl_SStudentID.Text = "Student ID:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(0, 515);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 30);
            this.button5.TabIndex = 16;
            this.button5.Text = "Log Out";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // frmSearchStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 316);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pnlStudentDetails);
            this.Controls.Add(this.btn_SReturn);
            this.Controls.Add(this.btn_SReg);
            this.Controls.Add(this.btn_SView);
            this.Controls.Add(this.btn_SUpdate);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmSearchStudents";
            this.Text = "frmSearchStudents";
            this.Load += new System.EventHandler(this.frmSearchStudents_Load);
            this.pnlStudentDetails.ResumeLayout(false);
            this.pnlStudentDetails.PerformLayout();
            this.pnlSearchStudent.ResumeLayout(false);
            this.pnlSearchStudent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_SUpdate;
        private System.Windows.Forms.Button btn_SView;
        private System.Windows.Forms.Button btn_SReg;
        private System.Windows.Forms.Button btn_SReturn;
        private System.Windows.Forms.Panel pnlStudentDetails;
        private System.Windows.Forms.Label lbl_SHeading;
        private System.Windows.Forms.ComboBox cmb_S_CourseID;
        private System.Windows.Forms.TextBox txt_S_LastName;
        private System.Windows.Forms.TextBox txt_SStudentName;
        private System.Windows.Forms.TextBox txt_SStudentID;
        private System.Windows.Forms.Label lbl_SLastname;
        private System.Windows.Forms.Label lbl_SCourseID;
        private System.Windows.Forms.Label lbl_SStudentName;
        private System.Windows.Forms.Label lbl_SStudentID;
        private System.Windows.Forms.Panel pnlSearchStudent;
        private System.Windows.Forms.TextBox CourseID;
        private System.Windows.Forms.TextBox Lastname;
        private System.Windows.Forms.TextBox StudentName;
        private System.Windows.Forms.TextBox StudentID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_SDStudentID;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lbl_SDetailsFor;
    }
}
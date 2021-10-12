
namespace PRG282_Milestone2.PresentationLayer
{
    partial class frmModuleInfo
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pnlStudentDetails = new System.Windows.Forms.Panel();
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
            this.lblDel = new System.Windows.Forms.Label();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.lblRead = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.pnlStudentDetails.SuspendLayout();
            this.pnlSearchStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(232, 412);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 31);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.White;
            this.btnCreate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(530, 412);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(91, 30);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btn_SReg_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.White;
            this.btnReturn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(679, 411);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(136, 30);
            this.btnReturn.TabIndex = 12;
            this.btnReturn.Text = "Return to Menu";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btn_SReturn_Click);
            // 
            // pnlStudentDetails
            // 
            this.pnlStudentDetails.Controls.Add(this.btnReturn);
            this.pnlStudentDetails.Controls.Add(this.pnlSearchStudent);
            this.pnlStudentDetails.Controls.Add(this.btnCreate);
            this.pnlStudentDetails.Controls.Add(this.lblDel);
            this.pnlStudentDetails.Controls.Add(this.btnUpdate);
            this.pnlStudentDetails.Controls.Add(this.dgvStudents);
            this.pnlStudentDetails.Controls.Add(this.lblRead);
            this.pnlStudentDetails.Controls.Add(this.btnDel);
            this.pnlStudentDetails.Controls.Add(this.lblSearch);
            this.pnlStudentDetails.Controls.Add(this.btnSearch);
            this.pnlStudentDetails.Controls.Add(this.txtSearch);
            this.pnlStudentDetails.Controls.Add(this.btnRead);
            this.pnlStudentDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStudentDetails.Location = new System.Drawing.Point(0, 0);
            this.pnlStudentDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlStudentDetails.Name = "pnlStudentDetails";
            this.pnlStudentDetails.Size = new System.Drawing.Size(882, 480);
            this.pnlStudentDetails.TabIndex = 13;
            this.pnlStudentDetails.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlStudentDetails_Paint);
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
            this.pnlSearchStudent.Location = new System.Drawing.Point(516, 0);
            this.pnlSearchStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlSearchStudent.Name = "pnlSearchStudent";
            this.pnlSearchStudent.Size = new System.Drawing.Size(363, 263);
            this.pnlSearchStudent.TabIndex = 15;
            // 
            // lbl_SDetailsFor
            // 
            this.lbl_SDetailsFor.AutoSize = true;
            this.lbl_SDetailsFor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SDetailsFor.Location = new System.Drawing.Point(41, 25);
            this.lbl_SDetailsFor.Name = "lbl_SDetailsFor";
            this.lbl_SDetailsFor.Size = new System.Drawing.Size(117, 18);
            this.lbl_SDetailsFor.TabIndex = 25;
            this.lbl_SDetailsFor.Text = "Module details";
            // 
            // CourseID
            // 
            this.CourseID.Location = new System.Drawing.Point(198, 221);
            this.CourseID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CourseID.Name = "CourseID";
            this.CourseID.ReadOnly = true;
            this.CourseID.Size = new System.Drawing.Size(116, 22);
            this.CourseID.TabIndex = 24;
            // 
            // Lastname
            // 
            this.Lastname.Location = new System.Drawing.Point(198, 153);
            this.Lastname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Lastname.Multiline = true;
            this.Lastname.Name = "Lastname";
            this.Lastname.ReadOnly = true;
            this.Lastname.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.Lastname.Size = new System.Drawing.Size(116, 60);
            this.Lastname.TabIndex = 23;
            // 
            // StudentName
            // 
            this.StudentName.Location = new System.Drawing.Point(198, 109);
            this.StudentName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            this.StudentName.Size = new System.Drawing.Size(116, 22);
            this.StudentName.TabIndex = 22;
            // 
            // StudentID
            // 
            this.StudentID.Location = new System.Drawing.Point(198, 68);
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
            this.label1.Location = new System.Drawing.Point(40, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Module Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Links: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Module Name:";
            // 
            // lbl_SDStudentID
            // 
            this.lbl_SDStudentID.AutoSize = true;
            this.lbl_SDStudentID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SDStudentID.Location = new System.Drawing.Point(37, 72);
            this.lbl_SDStudentID.Name = "lbl_SDStudentID";
            this.lbl_SDStudentID.Size = new System.Drawing.Size(88, 18);
            this.lbl_SDStudentID.TabIndex = 17;
            this.lbl_SDStudentID.Text = "Module ID:";
            // 
            // lblDel
            // 
            this.lblDel.AutoSize = true;
            this.lblDel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDel.Location = new System.Drawing.Point(43, 387);
            this.lblDel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDel.Name = "lblDel";
            this.lblDel.Size = new System.Drawing.Size(130, 16);
            this.lblDel.TabIndex = 33;
            this.lblDel.Text = "Delete module info";
            this.lblDel.Visible = false;
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(41, 88);
            this.dgvStudents.Margin = new System.Windows.Forms.Padding(2);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowHeadersWidth = 102;
            this.dgvStudents.RowTemplate.Height = 40;
            this.dgvStudents.Size = new System.Drawing.Size(440, 288);
            this.dgvStudents.TabIndex = 30;
            // 
            // lblRead
            // 
            this.lblRead.AutoSize = true;
            this.lblRead.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRead.Location = new System.Drawing.Point(39, 22);
            this.lblRead.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRead.Name = "lblRead";
            this.lblRead.Size = new System.Drawing.Size(128, 16);
            this.lblRead.TabIndex = 32;
            this.lblRead.Text = "Show the  modules";
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.White;
            this.btnDel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(62, 412);
            this.btnDel.Margin = new System.Windows.Forms.Padding(2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(77, 30);
            this.btnDel.TabIndex = 26;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.UseWaitCursor = true;
            this.btnDel.Visible = false;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(310, 22);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(119, 16);
            this.lblSearch.TabIndex = 31;
            this.lblSearch.Text = "Enter a Course ID";
            this.lblSearch.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(415, 50);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 30);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Visible = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(270, 52);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(121, 22);
            this.txtSearch.TabIndex = 28;
            this.txtSearch.WordWrap = false;
            // 
            // btnRead
            // 
            this.btnRead.BackColor = System.Drawing.Color.White;
            this.btnRead.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.Location = new System.Drawing.Point(42, 50);
            this.btnRead.Margin = new System.Windows.Forms.Padding(2);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(78, 27);
            this.btnRead.TabIndex = 29;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = false;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // frmModuleInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 483);
            this.Controls.Add(this.pnlStudentDetails);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmModuleInfo";
            this.Text = "frmModules";
            this.Load += new System.EventHandler(this.frmSearchStudents_Load);
            this.pnlStudentDetails.ResumeLayout(false);
            this.pnlStudentDetails.PerformLayout();
            this.pnlSearchStudent.ResumeLayout(false);
            this.pnlSearchStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel pnlStudentDetails;
        private System.Windows.Forms.Panel pnlSearchStudent;
        private System.Windows.Forms.TextBox CourseID;
        private System.Windows.Forms.TextBox Lastname;
        private System.Windows.Forms.TextBox StudentName;
        private System.Windows.Forms.TextBox StudentID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_SDStudentID;
        private System.Windows.Forms.Label lbl_SDetailsFor;
        private System.Windows.Forms.Label lblDel;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Label lblRead;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnRead;
    }
}
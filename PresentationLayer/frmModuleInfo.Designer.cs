
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
<<<<<<< HEAD
=======
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModuleInfo));
            this.btnUpdate = new System.Windows.Forms.Button();
>>>>>>> 03a7e4238e42706cabd50c4636d4582ca115724f
            this.btnCreate = new System.Windows.Forms.Button();
            this.pnlStudentDetails = new System.Windows.Forms.Panel();
<<<<<<< HEAD
            this.pnlSearchStudent = new System.Windows.Forms.Panel();
            this.txtMName = new System.Windows.Forms.TextBox();
            this.txtMID = new System.Windows.Forms.TextBox();
=======
            this.lbl_SDetailsFor = new System.Windows.Forms.Label();
            this.CourseID = new System.Windows.Forms.TextBox();
            this.Lastname = new System.Windows.Forms.TextBox();
            this.StudentName = new System.Windows.Forms.TextBox();
            this.StudentID = new System.Windows.Forms.TextBox();
>>>>>>> 03a7e4238e42706cabd50c4636d4582ca115724f
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_SDStudentID = new System.Windows.Forms.Label();
            this.lblDel = new System.Windows.Forms.Label();
            this.dgvModules = new System.Windows.Forms.DataGridView();
            this.lblRead = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.brnReturn = new System.Windows.Forms.Button();
            this.txtMDesc = new System.Windows.Forms.TextBox();
            this.txtMLink = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlStudentDetails.SuspendLayout();
<<<<<<< HEAD
            this.pnlSearchStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModules)).BeginInit();
=======
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
>>>>>>> 03a7e4238e42706cabd50c4636d4582ca115724f
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.White;
            this.btnCreate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(530, 411);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(106, 35);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btn_SReg_Click);
            // 
<<<<<<< HEAD
            // pnlStudentDetails
            // 
            this.pnlStudentDetails.Controls.Add(this.btnClose);
            this.pnlStudentDetails.Controls.Add(this.brnReturn);
            this.pnlStudentDetails.Controls.Add(this.btnUp);
            this.pnlStudentDetails.Controls.Add(this.pnlSearchStudent);
=======
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.White;
            this.btnReturn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(701, 413);
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
            this.pnlStudentDetails.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlStudentDetails.BackgroundImage")));
            this.pnlStudentDetails.Controls.Add(this.lbl_SDetailsFor);
            this.pnlStudentDetails.Controls.Add(this.btnReturn);
            this.pnlStudentDetails.Controls.Add(this.CourseID);
            this.pnlStudentDetails.Controls.Add(this.Lastname);
>>>>>>> 03a7e4238e42706cabd50c4636d4582ca115724f
            this.pnlStudentDetails.Controls.Add(this.btnCreate);
            this.pnlStudentDetails.Controls.Add(this.StudentName);
            this.pnlStudentDetails.Controls.Add(this.lblDel);
<<<<<<< HEAD
            this.pnlStudentDetails.Controls.Add(this.dgvModules);
=======
            this.pnlStudentDetails.Controls.Add(this.StudentID);
            this.pnlStudentDetails.Controls.Add(this.label1);
            this.pnlStudentDetails.Controls.Add(this.btnUpdate);
            this.pnlStudentDetails.Controls.Add(this.label2);
            this.pnlStudentDetails.Controls.Add(this.dgvStudents);
            this.pnlStudentDetails.Controls.Add(this.label3);
>>>>>>> 03a7e4238e42706cabd50c4636d4582ca115724f
            this.pnlStudentDetails.Controls.Add(this.lblRead);
            this.pnlStudentDetails.Controls.Add(this.lbl_SDStudentID);
            this.pnlStudentDetails.Controls.Add(this.btnDel);
            this.pnlStudentDetails.Controls.Add(this.lblSearch);
            this.pnlStudentDetails.Controls.Add(this.btnSearch);
            this.pnlStudentDetails.Controls.Add(this.txtSearch);
            this.pnlStudentDetails.Controls.Add(this.btnRead);
            this.pnlStudentDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStudentDetails.Location = new System.Drawing.Point(0, 0);
            this.pnlStudentDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlStudentDetails.Name = "pnlStudentDetails";
<<<<<<< HEAD
            this.pnlStudentDetails.Size = new System.Drawing.Size(1016, 480);
            this.pnlStudentDetails.TabIndex = 13;
            this.pnlStudentDetails.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlStudentDetails_Paint);
            // 
            // pnlSearchStudent
            // 
            this.pnlSearchStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSearchStudent.Controls.Add(this.txtMLink);
            this.pnlSearchStudent.Controls.Add(this.txtMDesc);
            this.pnlSearchStudent.Controls.Add(this.txtMName);
            this.pnlSearchStudent.Controls.Add(this.txtMID);
            this.pnlSearchStudent.Controls.Add(this.label1);
            this.pnlSearchStudent.Controls.Add(this.label2);
            this.pnlSearchStudent.Controls.Add(this.label3);
            this.pnlSearchStudent.Controls.Add(this.lbl_SDStudentID);
            this.pnlSearchStudent.Location = new System.Drawing.Point(519, 88);
            this.pnlSearchStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlSearchStudent.Name = "pnlSearchStudent";
            this.pnlSearchStudent.Size = new System.Drawing.Size(497, 288);
            this.pnlSearchStudent.TabIndex = 15;
            // 
            // txtMName
            // 
            this.txtMName.Location = new System.Drawing.Point(234, 110);
            this.txtMName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMName.Name = "txtMName";
            this.txtMName.ReadOnly = true;
            this.txtMName.Size = new System.Drawing.Size(249, 26);
            this.txtMName.TabIndex = 22;
            // 
            // txtMID
            // 
            this.txtMID.Location = new System.Drawing.Point(234, 69);
            this.txtMID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMID.Name = "txtMID";
            this.txtMID.ReadOnly = true;
            this.txtMID.Size = new System.Drawing.Size(249, 26);
            this.txtMID.TabIndex = 21;
=======
            this.pnlStudentDetails.Size = new System.Drawing.Size(1067, 480);
            this.pnlStudentDetails.TabIndex = 13;
            this.pnlStudentDetails.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlStudentDetails_Paint);
            // 
            // lbl_SDetailsFor
            // 
            this.lbl_SDetailsFor.AutoSize = true;
            this.lbl_SDetailsFor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SDetailsFor.Location = new System.Drawing.Point(581, 98);
            this.lbl_SDetailsFor.Name = "lbl_SDetailsFor";
            this.lbl_SDetailsFor.Size = new System.Drawing.Size(117, 18);
            this.lbl_SDetailsFor.TabIndex = 25;
            this.lbl_SDetailsFor.Text = "Module details";
            // 
            // CourseID
            // 
            this.CourseID.Location = new System.Drawing.Point(738, 294);
            this.CourseID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CourseID.Name = "CourseID";
            this.CourseID.ReadOnly = true;
            this.CourseID.Size = new System.Drawing.Size(116, 22);
            this.CourseID.TabIndex = 24;
            // 
            // Lastname
            // 
            this.Lastname.Location = new System.Drawing.Point(738, 226);
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
            this.StudentName.Location = new System.Drawing.Point(738, 182);
            this.StudentName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            this.StudentName.Size = new System.Drawing.Size(116, 22);
            this.StudentName.TabIndex = 22;
            // 
            // StudentID
            // 
            this.StudentID.Location = new System.Drawing.Point(738, 141);
            this.StudentID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StudentID.Name = "StudentID";
            this.StudentID.ReadOnly = true;
            this.StudentID.Size = new System.Drawing.Size(116, 22);
            this.StudentID.TabIndex = 21;
>>>>>>> 03a7e4238e42706cabd50c4636d4582ca115724f
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(580, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Module Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.label2.Location = new System.Drawing.Point(41, 200);
=======
            this.label2.Location = new System.Drawing.Point(580, 294);
>>>>>>> 03a7e4238e42706cabd50c4636d4582ca115724f
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Module Links: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(577, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Module Name:";
            // 
            // lbl_SDStudentID
            // 
            this.lbl_SDStudentID.AutoSize = true;
            this.lbl_SDStudentID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SDStudentID.Location = new System.Drawing.Point(577, 145);
            this.lbl_SDStudentID.Name = "lbl_SDStudentID";
            this.lbl_SDStudentID.Size = new System.Drawing.Size(108, 23);
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
            this.lblDel.Size = new System.Drawing.Size(165, 19);
            this.lblDel.TabIndex = 33;
            this.lblDel.Text = "Delete module info";
            this.lblDel.Visible = false;
            // 
            // dgvModules
            // 
            this.dgvModules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModules.Location = new System.Drawing.Point(41, 88);
            this.dgvModules.Margin = new System.Windows.Forms.Padding(2);
            this.dgvModules.Name = "dgvModules";
            this.dgvModules.RowHeadersWidth = 102;
            this.dgvModules.RowTemplate.Height = 40;
            this.dgvModules.Size = new System.Drawing.Size(440, 288);
            this.dgvModules.TabIndex = 30;
            // 
            // lblRead
            // 
            this.lblRead.AutoSize = true;
            this.lblRead.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRead.Location = new System.Drawing.Point(39, 22);
            this.lblRead.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRead.Name = "lblRead";
            this.lblRead.Size = new System.Drawing.Size(164, 19);
            this.lblRead.TabIndex = 32;
            this.lblRead.Text = "Show the  modules";
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.White;
            this.btnDel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(72, 411);
            this.btnDel.Margin = new System.Windows.Forms.Padding(2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(108, 37);
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
            this.lblSearch.Location = new System.Drawing.Point(283, 22);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(149, 19);
            this.lblSearch.TabIndex = 31;
            this.lblSearch.Text = "Enter a Course ID";
            this.lblSearch.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(373, 50);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(108, 34);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Visible = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(226, 56);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(135, 26);
            this.txtSearch.TabIndex = 28;
            this.txtSearch.Visible = false;
            this.txtSearch.WordWrap = false;
            // 
            // btnRead
            // 
            this.btnRead.BackColor = System.Drawing.Color.White;
            this.btnRead.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.Location = new System.Drawing.Point(62, 50);
            this.btnRead.Margin = new System.Windows.Forms.Padding(2);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(108, 34);
            this.btnRead.TabIndex = 29;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = false;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.White;
            this.btnUp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.Location = new System.Drawing.Point(679, 411);
            this.btnUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(106, 35);
            this.btnUp.TabIndex = 35;
            this.btnUp.Text = "Update";
            this.btnUp.UseVisualStyleBackColor = false;
            // 
            // brnReturn
            // 
            this.brnReturn.BackColor = System.Drawing.Color.White;
            this.brnReturn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnReturn.Location = new System.Drawing.Point(823, 410);
            this.brnReturn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.brnReturn.Name = "brnReturn";
            this.brnReturn.Size = new System.Drawing.Size(161, 35);
            this.brnReturn.TabIndex = 36;
            this.brnReturn.Text = "Return to Menu";
            this.brnReturn.UseVisualStyleBackColor = false;
            // 
            // txtMDesc
            // 
            this.txtMDesc.Location = new System.Drawing.Point(234, 154);
            this.txtMDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMDesc.Name = "txtMDesc";
            this.txtMDesc.ReadOnly = true;
            this.txtMDesc.Size = new System.Drawing.Size(249, 26);
            this.txtMDesc.TabIndex = 26;
            // 
            // txtMLink
            // 
            this.txtMLink.Location = new System.Drawing.Point(234, 197);
            this.txtMLink.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMLink.Name = "txtMLink";
            this.txtMLink.ReadOnly = true;
            this.txtMLink.Size = new System.Drawing.Size(249, 26);
            this.txtMLink.TabIndex = 27;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(334, 411);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 37);
            this.btnClose.TabIndex = 37;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.UseWaitCursor = true;
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // frmModuleInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(1016, 483);
=======
            this.ClientSize = new System.Drawing.Size(1067, 589);
>>>>>>> 03a7e4238e42706cabd50c4636d4582ca115724f
            this.Controls.Add(this.pnlStudentDetails);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmModuleInfo";
            this.Text = "frmModules";
            this.Load += new System.EventHandler(this.frmSearchStudents_Load);
            this.pnlStudentDetails.ResumeLayout(false);
            this.pnlStudentDetails.PerformLayout();
<<<<<<< HEAD
            this.pnlSearchStudent.ResumeLayout(false);
            this.pnlSearchStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModules)).EndInit();
=======
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
>>>>>>> 03a7e4238e42706cabd50c4636d4582ca115724f
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Panel pnlStudentDetails;
<<<<<<< HEAD
        private System.Windows.Forms.Panel pnlSearchStudent;
        private System.Windows.Forms.TextBox txtMName;
        private System.Windows.Forms.TextBox txtMID;
=======
        private System.Windows.Forms.TextBox CourseID;
        private System.Windows.Forms.TextBox Lastname;
        private System.Windows.Forms.TextBox StudentName;
        private System.Windows.Forms.TextBox StudentID;
>>>>>>> 03a7e4238e42706cabd50c4636d4582ca115724f
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_SDStudentID;
        private System.Windows.Forms.Label lblDel;
        private System.Windows.Forms.DataGridView dgvModules;
        private System.Windows.Forms.Label lblRead;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button brnReturn;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.TextBox txtMLink;
        private System.Windows.Forms.TextBox txtMDesc;
        private System.Windows.Forms.Button btnClose;
    }
}
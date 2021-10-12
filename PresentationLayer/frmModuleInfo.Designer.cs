
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
            this.btn_SUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btn_SReturn = new System.Windows.Forms.Button();
            this.pnlStudentDetails = new System.Windows.Forms.Panel();
            this.pnlSearchStudent = new System.Windows.Forms.Panel();
            this.lbl_SDetailsFor = new System.Windows.Forms.Label();
            this.txtExstra = new System.Windows.Forms.TextBox();
            this.txtModDes = new System.Windows.Forms.TextBox();
            this.txtModName = new System.Windows.Forms.TextBox();
            this.txtModID = new System.Windows.Forms.TextBox();
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
            // btn_SUpdate
            // 
            this.btn_SUpdate.BackColor = System.Drawing.Color.White;
            this.btn_SUpdate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SUpdate.Location = new System.Drawing.Point(221, 412);
            this.btn_SUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_SUpdate.Name = "btn_SUpdate";
            this.btn_SUpdate.Size = new System.Drawing.Size(91, 31);
            this.btn_SUpdate.TabIndex = 9;
            this.btn_SUpdate.Text = "Update";
            this.btn_SUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(387, 412);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(127, 30);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add Module";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btn_SReg_Click);
            // 
            // btn_SReturn
            // 
            this.btn_SReturn.BackColor = System.Drawing.Color.White;
            this.btn_SReturn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SReturn.Location = new System.Drawing.Point(564, 412);
            this.btn_SReturn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_SReturn.Name = "btn_SReturn";
            this.btn_SReturn.Size = new System.Drawing.Size(136, 30);
            this.btn_SReturn.TabIndex = 12;
            this.btn_SReturn.Text = "Return to Menu";
            this.btn_SReturn.UseVisualStyleBackColor = false;
            this.btn_SReturn.Click += new System.EventHandler(this.btn_SReturn_Click);
            // 
            // pnlStudentDetails
            // 
            this.pnlStudentDetails.Controls.Add(this.pnlSearchStudent);
            this.pnlStudentDetails.Controls.Add(this.btn_SReturn);
            this.pnlStudentDetails.Controls.Add(this.lblDel);
            this.pnlStudentDetails.Controls.Add(this.btnAdd);
            this.pnlStudentDetails.Controls.Add(this.dgvStudents);
            this.pnlStudentDetails.Controls.Add(this.btn_SUpdate);
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
            // 
            // pnlSearchStudent
            // 
            this.pnlSearchStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSearchStudent.Controls.Add(this.lbl_SDetailsFor);
            this.pnlSearchStudent.Controls.Add(this.txtExstra);
            this.pnlSearchStudent.Controls.Add(this.txtModDes);
            this.pnlSearchStudent.Controls.Add(this.txtModName);
            this.pnlSearchStudent.Controls.Add(this.txtModID);
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
            this.lbl_SDetailsFor.Location = new System.Drawing.Point(45, 12);
            this.lbl_SDetailsFor.Name = "lbl_SDetailsFor";
            this.lbl_SDetailsFor.Size = new System.Drawing.Size(117, 18);
            this.lbl_SDetailsFor.TabIndex = 25;
            this.lbl_SDetailsFor.Text = "Module details";
            // 
            // txtExstra
            // 
            this.txtExstra.Location = new System.Drawing.Point(200, 187);
            this.txtExstra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtExstra.Name = "txtExstra";
            this.txtExstra.ReadOnly = true;
            this.txtExstra.Size = new System.Drawing.Size(116, 22);
            this.txtExstra.TabIndex = 24;
            // 
            // txtModDes
            // 
            this.txtModDes.Location = new System.Drawing.Point(200, 141);
            this.txtModDes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtModDes.Name = "txtModDes";
            this.txtModDes.ReadOnly = true;
            this.txtModDes.Size = new System.Drawing.Size(116, 22);
            this.txtModDes.TabIndex = 23;
            // 
            // txtModName
            // 
            this.txtModName.Location = new System.Drawing.Point(200, 98);
            this.txtModName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtModName.Name = "txtModName";
            this.txtModName.ReadOnly = true;
            this.txtModName.Size = new System.Drawing.Size(116, 22);
            this.txtModName.TabIndex = 22;
            // 
            // txtModID
            // 
            this.txtModID.Location = new System.Drawing.Point(200, 55);
            this.txtModID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtModID.Name = "txtModID";
            this.txtModID.ReadOnly = true;
            this.txtModID.Size = new System.Drawing.Size(116, 22);
            this.txtModID.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Module Description :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Exstra links:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Module Name:";
            // 
            // lbl_SDStudentID
            // 
            this.lbl_SDStudentID.AutoSize = true;
            this.lbl_SDStudentID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SDStudentID.Location = new System.Drawing.Point(41, 59);
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
            this.lblDel.Size = new System.Drawing.Size(128, 16);
            this.lblDel.TabIndex = 33;
            this.lblDel.Text = "Delete student info";
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
            this.lblRead.Size = new System.Drawing.Size(132, 16);
            this.lblRead.TabIndex = 32;
            this.lblRead.Text = "Show the database";
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.White;
            this.btnDel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(42, 412);
            this.btnDel.Margin = new System.Windows.Forms.Padding(2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(91, 32);
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
            this.lblSearch.Size = new System.Drawing.Size(121, 16);
            this.lblSearch.TabIndex = 31;
            this.lblSearch.Text = "Enter a student ID";
            this.lblSearch.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(415, 50);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(77, 30);
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
            // 
            // frmModuleInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 574);
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

        private System.Windows.Forms.Button btn_SUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btn_SReturn;
        private System.Windows.Forms.Panel pnlStudentDetails;
        private System.Windows.Forms.Panel pnlSearchStudent;
        private System.Windows.Forms.TextBox txtExstra;
        private System.Windows.Forms.TextBox txtModDes;
        private System.Windows.Forms.TextBox txtModName;
        private System.Windows.Forms.TextBox txtModID;
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

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
            this.btnCreate = new System.Windows.Forms.Button();
            this.pnlStudentDetails = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.brnReturn = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.pnlModuleD = new System.Windows.Forms.Panel();
            this.txtMLink = new System.Windows.Forms.TextBox();
            this.txtMDesc = new System.Windows.Forms.TextBox();
            this.txtMName = new System.Windows.Forms.TextBox();
            this.txtMNumber = new System.Windows.Forms.TextBox();
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlStudentDetails.SuspendLayout();
            this.pnlModuleD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModules)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.White;
            this.btnCreate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(41, 253);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(106, 35);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btn_SReg_Click);
            // 
            // pnlStudentDetails
            // 
            this.pnlStudentDetails.Controls.Add(this.label4);
            this.pnlStudentDetails.Controls.Add(this.btnClose);
            this.pnlStudentDetails.Controls.Add(this.lblSearch);
            this.pnlStudentDetails.Controls.Add(this.txtSearch);
            this.pnlStudentDetails.Controls.Add(this.pnlModuleD);
            this.pnlStudentDetails.Controls.Add(this.btnSearch);
            this.pnlStudentDetails.Controls.Add(this.lblDel);
            this.pnlStudentDetails.Controls.Add(this.dgvModules);
            this.pnlStudentDetails.Controls.Add(this.lblRead);
            this.pnlStudentDetails.Controls.Add(this.btnDel);
            this.pnlStudentDetails.Controls.Add(this.btnRead);
            this.pnlStudentDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStudentDetails.Location = new System.Drawing.Point(0, 0);
            this.pnlStudentDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlStudentDetails.Name = "pnlStudentDetails";
            this.pnlStudentDetails.Size = new System.Drawing.Size(1016, 480);
            this.pnlStudentDetails.TabIndex = 13;
            this.pnlStudentDetails.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlStudentDetails_Paint);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(322, 50);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 34);
            this.btnClose.TabIndex = 37;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.UseWaitCursor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // brnReturn
            // 
            this.brnReturn.BackColor = System.Drawing.Color.White;
            this.brnReturn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnReturn.Location = new System.Drawing.Point(324, 253);
            this.brnReturn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.brnReturn.Name = "brnReturn";
            this.brnReturn.Size = new System.Drawing.Size(161, 35);
            this.brnReturn.TabIndex = 36;
            this.brnReturn.Text = "Return to Menu";
            this.brnReturn.UseVisualStyleBackColor = false;
            this.brnReturn.Click += new System.EventHandler(this.brnReturn_Click);
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.White;
            this.btnUp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.Location = new System.Drawing.Point(193, 253);
            this.btnUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(106, 35);
            this.btnUp.TabIndex = 35;
            this.btnUp.Text = "Update";
            this.btnUp.UseVisualStyleBackColor = false;
            // 
            // pnlModuleD
            // 
            this.pnlModuleD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlModuleD.Controls.Add(this.label5);
            this.pnlModuleD.Controls.Add(this.txtMLink);
            this.pnlModuleD.Controls.Add(this.brnReturn);
            this.pnlModuleD.Controls.Add(this.txtMDesc);
            this.pnlModuleD.Controls.Add(this.btnUp);
            this.pnlModuleD.Controls.Add(this.txtMName);
            this.pnlModuleD.Controls.Add(this.txtMNumber);
            this.pnlModuleD.Controls.Add(this.label1);
            this.pnlModuleD.Controls.Add(this.label2);
            this.pnlModuleD.Controls.Add(this.label3);
            this.pnlModuleD.Controls.Add(this.btnCreate);
            this.pnlModuleD.Controls.Add(this.lbl_SDStudentID);
            this.pnlModuleD.Location = new System.Drawing.Point(519, 88);
            this.pnlModuleD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlModuleD.Name = "pnlModuleD";
            this.pnlModuleD.Size = new System.Drawing.Size(497, 300);
            this.pnlModuleD.TabIndex = 15;
            this.pnlModuleD.Visible = false;
            // 
            // txtMLink
            // 
            this.txtMLink.Location = new System.Drawing.Point(234, 197);
            this.txtMLink.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMLink.Name = "txtMLink";
            this.txtMLink.Size = new System.Drawing.Size(249, 26);
            this.txtMLink.TabIndex = 27;
            // 
            // txtMDesc
            // 
            this.txtMDesc.Location = new System.Drawing.Point(234, 154);
            this.txtMDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMDesc.Name = "txtMDesc";
            this.txtMDesc.Size = new System.Drawing.Size(249, 26);
            this.txtMDesc.TabIndex = 26;
            // 
            // txtMName
            // 
            this.txtMName.Location = new System.Drawing.Point(234, 110);
            this.txtMName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMName.Name = "txtMName";
            this.txtMName.Size = new System.Drawing.Size(249, 26);
            this.txtMName.TabIndex = 22;
            // 
            // txtMNumber
            // 
            this.txtMNumber.Location = new System.Drawing.Point(234, 69);
            this.txtMNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMNumber.Name = "txtMNumber";
            this.txtMNumber.Size = new System.Drawing.Size(249, 26);
            this.txtMNumber.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Module Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Module Links: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Module Name:";
            // 
            // lbl_SDStudentID
            // 
            this.lbl_SDStudentID.AutoSize = true;
            this.lbl_SDStudentID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SDStudentID.Location = new System.Drawing.Point(37, 72);
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
            this.dgvModules.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModules_CellContentClick);
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
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(294, 387);
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
            this.btnSearch.Location = new System.Drawing.Point(384, 415);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(108, 34);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Visible = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(237, 421);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(313, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 19);
            this.label4.TabIndex = 38;
            this.label4.Text = "Close Program";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(130, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(271, 19);
            this.label5.TabIndex = 39;
            this.label5.Text = "Please enter the required details";
            // 
            // frmModuleInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 483);
            this.Controls.Add(this.pnlStudentDetails);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmModuleInfo";
            this.Text = "frmModules";
            this.Load += new System.EventHandler(this.frmSearchStudents_Load);
            this.pnlStudentDetails.ResumeLayout(false);
            this.pnlStudentDetails.PerformLayout();
            this.pnlModuleD.ResumeLayout(false);
            this.pnlModuleD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModules)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Panel pnlStudentDetails;
        private System.Windows.Forms.Panel pnlModuleD;
        private System.Windows.Forms.TextBox txtMName;
        private System.Windows.Forms.TextBox txtMNumber;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
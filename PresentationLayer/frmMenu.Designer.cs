
namespace PRG282_Milestone2.PresentationLayer
{
    partial class frmMenu
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
            this.lblUp = new System.Windows.Forms.Label();
            this.lblDel = new System.Windows.Forms.Label();
            this.lblRead = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblCreate = new System.Windows.Forms.Label();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.btnRead = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUp
            // 
            this.lblUp.AutoSize = true;
            this.lblUp.Location = new System.Drawing.Point(364, 381);
            this.lblUp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUp.Name = "lblUp";
            this.lblUp.Size = new System.Drawing.Size(114, 13);
            this.lblUp.TabIndex = 23;
            this.lblUp.Text = "Update a students info";
            this.lblUp.Visible = false;
            // 
            // lblDel
            // 
            this.lblDel.AutoSize = true;
            this.lblDel.Location = new System.Drawing.Point(244, 381);
            this.lblDel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDel.Name = "lblDel";
            this.lblDel.Size = new System.Drawing.Size(96, 13);
            this.lblDel.TabIndex = 22;
            this.lblDel.Text = "Delete student info";
            this.lblDel.Visible = false;
            // 
            // lblRead
            // 
            this.lblRead.AutoSize = true;
            this.lblRead.Location = new System.Drawing.Point(371, 9);
            this.lblRead.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRead.Name = "lblRead";
            this.lblRead.Size = new System.Drawing.Size(99, 13);
            this.lblRead.TabIndex = 21;
            this.lblRead.Text = "Show the database";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(34, 381);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(93, 13);
            this.lblSearch.TabIndex = 20;
            this.lblSearch.Text = "Enter a student ID";
            this.lblSearch.Visible = false;
            // 
            // lblCreate
            // 
            this.lblCreate.AutoSize = true;
            this.lblCreate.Location = new System.Drawing.Point(34, 9);
            this.lblCreate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreate.Name = "lblCreate";
            this.lblCreate.Size = new System.Drawing.Size(96, 13);
            this.lblCreate.TabIndex = 19;
            this.lblCreate.Text = "Add a new student";
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(36, 76);
            this.dgvStudents.Margin = new System.Windows.Forms.Padding(2);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowHeadersWidth = 102;
            this.dgvStudents.RowTemplate.Height = 40;
            this.dgvStudents.Size = new System.Drawing.Size(440, 288);
            this.dgvStudents.TabIndex = 18;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(374, 34);
            this.btnRead.Margin = new System.Windows.Forms.Padding(2);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(68, 21);
            this.btnRead.TabIndex = 17;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(139, 409);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(78, 20);
            this.txtSearch.TabIndex = 16;
            this.txtSearch.WordWrap = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(36, 406);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(68, 21);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Visible = false;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(245, 405);
            this.btnDel.Margin = new System.Windows.Forms.Padding(2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(68, 21);
            this.btnDel.TabIndex = 14;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.UseWaitCursor = true;
            this.btnDel.Visible = false;
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(365, 405);
            this.btnUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(68, 21);
            this.btnUp.TabIndex = 13;
            this.btnUp.Text = "Update";
            this.btnUp.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(36, 34);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(68, 21);
            this.btnCreate.TabIndex = 12;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 453);
            this.Controls.Add(this.lblUp);
            this.Controls.Add(this.lblDel);
            this.Controls.Add(this.lblRead);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblCreate);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnCreate);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUp;
        private System.Windows.Forms.Label lblDel;
        private System.Windows.Forms.Label lblRead;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblCreate;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnCreate;
    }
}
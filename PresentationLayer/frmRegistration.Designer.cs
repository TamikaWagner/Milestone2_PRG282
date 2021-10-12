
namespace PRG282_Milestone2.PresentationLayer
{
    partial class frmRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistration));
            this.btnLoginredirect = new System.Windows.Forms.Button();
            this.lbRPassword = new System.Windows.Forms.Label();
            this.lbRUsername = new System.Windows.Forms.Label();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLoginredirect
            // 
            this.btnLoginredirect.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginredirect.Location = new System.Drawing.Point(71, 233);
            this.btnLoginredirect.Name = "btnLoginredirect";
            this.btnLoginredirect.Size = new System.Drawing.Size(155, 49);
            this.btnLoginredirect.TabIndex = 31;
            this.btnLoginredirect.Text = "Have Account? Login Now";
            this.btnLoginredirect.UseVisualStyleBackColor = true;
            this.btnLoginredirect.Click += new System.EventHandler(this.btnLoginredirect_Click);
            // 
            // lbRPassword
            // 
            this.lbRPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbRPassword.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRPassword.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbRPassword.Location = new System.Drawing.Point(95, 131);
            this.lbRPassword.Name = "lbRPassword";
            this.lbRPassword.Size = new System.Drawing.Size(103, 19);
            this.lbRPassword.TabIndex = 28;
            this.lbRPassword.Text = "Password";
            this.lbRPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbRUsername
            // 
            this.lbRUsername.BackColor = System.Drawing.Color.Transparent;
            this.lbRUsername.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRUsername.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbRUsername.Location = new System.Drawing.Point(95, 60);
            this.lbRUsername.Name = "lbRUsername";
            this.lbRUsername.Size = new System.Drawing.Size(103, 24);
            this.lbRUsername.TabIndex = 27;
            this.lbRUsername.Text = "Username";
            this.lbRUsername.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BtnRegister
            // 
            this.BtnRegister.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnRegister.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegister.Location = new System.Drawing.Point(98, 199);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(100, 28);
            this.BtnRegister.TabIndex = 26;
            this.BtnRegister.Text = "Register";
            this.BtnRegister.UseVisualStyleBackColor = false;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(98, 96);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(100, 20);
            this.txtusername.TabIndex = 25;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(98, 164);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(100, 20);
            this.txtpassword.TabIndex = 24;
            // 
            // frmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(297, 389);
            this.Controls.Add(this.btnLoginredirect);
            this.Controls.Add(this.lbRPassword);
            this.Controls.Add(this.lbRUsername);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtpassword);
            this.Name = "frmRegistration";
            this.Text = "frmRegistration";
            this.Load += new System.EventHandler(this.frmRegistration_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoginredirect;
        private System.Windows.Forms.Label lbRPassword;
        private System.Windows.Forms.Label lbRUsername;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
    }
}
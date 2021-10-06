
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
            this.btnLoginredirect = new System.Windows.Forms.Button();
            this.lbConfPassword = new System.Windows.Forms.Label();
            this.txtconfirmpassword = new System.Windows.Forms.TextBox();
            this.lbRPassword = new System.Windows.Forms.Label();
            this.lbRUsername = new System.Windows.Forms.Label();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLoginredirect
            // 
            this.btnLoginredirect.Location = new System.Drawing.Point(20, 251);
            this.btnLoginredirect.Name = "btnLoginredirect";
            this.btnLoginredirect.Size = new System.Drawing.Size(157, 23);
            this.btnLoginredirect.TabIndex = 31;
            this.btnLoginredirect.Text = "Have Account? Login Now";
            this.btnLoginredirect.UseVisualStyleBackColor = true;
            // 
            // lbConfPassword
            // 
            this.lbConfPassword.AutoSize = true;
            this.lbConfPassword.Location = new System.Drawing.Point(48, 141);
            this.lbConfPassword.Name = "lbConfPassword";
            this.lbConfPassword.Size = new System.Drawing.Size(91, 13);
            this.lbConfPassword.TabIndex = 30;
            this.lbConfPassword.Text = "Confirm Password";
            // 
            // txtconfirmpassword
            // 
            this.txtconfirmpassword.Location = new System.Drawing.Point(51, 171);
            this.txtconfirmpassword.Name = "txtconfirmpassword";
            this.txtconfirmpassword.PasswordChar = '*';
            this.txtconfirmpassword.Size = new System.Drawing.Size(100, 20);
            this.txtconfirmpassword.TabIndex = 29;
            // 
            // lbRPassword
            // 
            this.lbRPassword.AutoSize = true;
            this.lbRPassword.Location = new System.Drawing.Point(48, 81);
            this.lbRPassword.Name = "lbRPassword";
            this.lbRPassword.Size = new System.Drawing.Size(53, 13);
            this.lbRPassword.TabIndex = 28;
            this.lbRPassword.Text = "Password";
            // 
            // lbRUsername
            // 
            this.lbRUsername.AutoSize = true;
            this.lbRUsername.Location = new System.Drawing.Point(48, 18);
            this.lbRUsername.Name = "lbRUsername";
            this.lbRUsername.Size = new System.Drawing.Size(55, 13);
            this.lbRUsername.TabIndex = 27;
            this.lbRUsername.Text = "Username";
            // 
            // BtnRegister
            // 
            this.BtnRegister.Location = new System.Drawing.Point(62, 222);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(75, 23);
            this.BtnRegister.TabIndex = 26;
            this.BtnRegister.Text = "Register";
            this.BtnRegister.UseVisualStyleBackColor = true;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(51, 43);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(100, 20);
            this.txtusername.TabIndex = 25;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(51, 111);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(100, 20);
            this.txtpassword.TabIndex = 24;
            // 
            // frmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoginredirect);
            this.Controls.Add(this.lbConfPassword);
            this.Controls.Add(this.txtconfirmpassword);
            this.Controls.Add(this.lbRPassword);
            this.Controls.Add(this.lbRUsername);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtpassword);
            this.Name = "frmRegistration";
            this.Text = "frmRegistration";
            this.Load += new System.EventHandler(this.frmRegistration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoginredirect;
        private System.Windows.Forms.Label lbConfPassword;
        private System.Windows.Forms.TextBox txtconfirmpassword;
        private System.Windows.Forms.Label lbRPassword;
        private System.Windows.Forms.Label lbRUsername;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
    }
}
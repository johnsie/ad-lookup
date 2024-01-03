
namespace AD_Lookup
{
    partial class frmUserLookup
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtUserLookupReponse = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtNewPassConfirm = new System.Windows.Forms.TextBox();
            this.CmdResetPass = new System.Windows.Forms.Button();
            this.cmdUnlockUser = new System.Windows.Forms.Button();
            this.cmdShowInactiveUsers = new System.Windows.Forms.Button();
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.lstTemp = new System.Windows.Forms.ListBox();
            this.cmdLookupUser = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(4, 6);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(280, 22);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            this.txtUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsername_KeyPress);
            // 
            // txtUserLookupReponse
            // 
            this.txtUserLookupReponse.Location = new System.Drawing.Point(297, 42);
            this.txtUserLookupReponse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserLookupReponse.Multiline = true;
            this.txtUserLookupReponse.Name = "txtUserLookupReponse";
            this.txtUserLookupReponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUserLookupReponse.Size = new System.Drawing.Size(812, 626);
            this.txtUserLookupReponse.TabIndex = 3;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(8, 30);
            this.txtNewPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(247, 22);
            this.txtNewPass.TabIndex = 4;
            // 
            // txtNewPassConfirm
            // 
            this.txtNewPassConfirm.Location = new System.Drawing.Point(8, 57);
            this.txtNewPassConfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNewPassConfirm.Name = "txtNewPassConfirm";
            this.txtNewPassConfirm.PasswordChar = '*';
            this.txtNewPassConfirm.Size = new System.Drawing.Size(247, 22);
            this.txtNewPassConfirm.TabIndex = 5;
            // 
            // CmdResetPass
            // 
            this.CmdResetPass.Location = new System.Drawing.Point(276, 23);
            this.CmdResetPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmdResetPass.Name = "CmdResetPass";
            this.CmdResetPass.Size = new System.Drawing.Size(163, 59);
            this.CmdResetPass.TabIndex = 6;
            this.CmdResetPass.Text = "Set New Password";
            this.CmdResetPass.UseVisualStyleBackColor = true;
            this.CmdResetPass.Click += new System.EventHandler(this.CmdResetPass_Click);
            // 
            // cmdUnlockUser
            // 
            this.cmdUnlockUser.Location = new System.Drawing.Point(4, 681);
            this.cmdUnlockUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdUnlockUser.Name = "cmdUnlockUser";
            this.cmdUnlockUser.Size = new System.Drawing.Size(283, 94);
            this.cmdUnlockUser.TabIndex = 8;
            this.cmdUnlockUser.Text = "Unlock User";
            this.cmdUnlockUser.UseVisualStyleBackColor = true;
            this.cmdUnlockUser.Click += new System.EventHandler(this.cmdUnlockUser_Click);
            // 
            // cmdShowInactiveUsers
            // 
            this.cmdShowInactiveUsers.Location = new System.Drawing.Point(437, 6);
            this.cmdShowInactiveUsers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdShowInactiveUsers.Name = "cmdShowInactiveUsers";
            this.cmdShowInactiveUsers.Size = new System.Drawing.Size(160, 28);
            this.cmdShowInactiveUsers.TabIndex = 9;
            this.cmdShowInactiveUsers.Text = "Show Inactive Users";
            this.cmdShowInactiveUsers.UseVisualStyleBackColor = true;
            this.cmdShowInactiveUsers.Click += new System.EventHandler(this.cmdShowInactiveUsers_Click);
            // 
            // lstUsers
            // 
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.ItemHeight = 16;
            this.lstUsers.Location = new System.Drawing.Point(4, 39);
            this.lstUsers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(280, 628);
            this.lstUsers.TabIndex = 10;
            this.lstUsers.SelectedIndexChanged += new System.EventHandler(this.lstUsers_SelectedIndexChanged);
            // 
            // lstTemp
            // 
            this.lstTemp.ForeColor = System.Drawing.Color.Transparent;
            this.lstTemp.FormattingEnabled = true;
            this.lstTemp.ItemHeight = 16;
            this.lstTemp.Location = new System.Drawing.Point(773, 896);
            this.lstTemp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstTemp.Name = "lstTemp";
            this.lstTemp.Size = new System.Drawing.Size(159, 100);
            this.lstTemp.TabIndex = 11;
            this.lstTemp.SelectedIndexChanged += new System.EventHandler(this.lstTemp_SelectedIndexChanged);
            // 
            // cmdLookupUser
            // 
            this.cmdLookupUser.Location = new System.Drawing.Point(296, 6);
            this.cmdLookupUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdLookupUser.Name = "cmdLookupUser";
            this.cmdLookupUser.Size = new System.Drawing.Size(129, 28);
            this.cmdLookupUser.TabIndex = 14;
            this.cmdLookupUser.Text = "Look Up User";
            this.cmdLookupUser.UseVisualStyleBackColor = true;
            this.cmdLookupUser.Click += new System.EventHandler(this.cmdLookupUser_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CmdResetPass);
            this.groupBox1.Controls.Add(this.txtNewPass);
            this.groupBox1.Controls.Add(this.txtNewPassConfirm);
            this.groupBox1.Location = new System.Drawing.Point(301, 674);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(452, 100);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PW Reset";
            // 
            // frmUserLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 782);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdLookupUser);
            this.Controls.Add(this.lstTemp);
            this.Controls.Add(this.lstUsers);
            this.Controls.Add(this.cmdShowInactiveUsers);
            this.Controls.Add(this.cmdUnlockUser);
            this.Controls.Add(this.txtUserLookupReponse);
            this.Controls.Add(this.txtUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmUserLookup";
            this.Text = "User Lookup Tool";
            this.Load += new System.EventHandler(this.user_lookup_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtUserLookupReponse;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.TextBox txtNewPassConfirm;
        private System.Windows.Forms.Button CmdResetPass;
        private System.Windows.Forms.Button cmdUnlockUser;
        private System.Windows.Forms.Button cmdShowInactiveUsers;
        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.ListBox lstTemp;
        private System.Windows.Forms.Button cmdLookupUser;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
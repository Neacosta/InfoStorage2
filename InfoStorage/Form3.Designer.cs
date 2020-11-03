namespace InfoStorage
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.nameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.passwordErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbAction = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordErrorProvider)).BeginInit();
            this.grbAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 23);
            this.label1.TabIndex = 0;
            this.label1.Tag = "";
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(152, 64);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 32);
            this.txtUserName.TabIndex = 2;
            this.txtUserName.Tag = "User Name";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(152, 139);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 32);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Tag = "Password";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnShow.Location = new System.Drawing.Point(217, 41);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(176, 36);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Show Customers";
            this.btnShow.UseVisualStyleBackColor = false;
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnCustomer.Location = new System.Drawing.Point(21, 41);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(163, 36);
            this.btnCustomer.TabIndex = 5;
            this.btnCustomer.Text = "Add Customer";
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnLogin.Location = new System.Drawing.Point(16, 216);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(102, 36);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnButton_Click);
            // 
            // nameErrorProvider
            // 
            this.nameErrorProvider.ContainerControl = this;
            this.nameErrorProvider.Tag = "txtUserName";
            // 
            // passwordErrorProvider
            // 
            this.passwordErrorProvider.ContainerControl = this;
            // 
            // grbAction
            // 
            this.grbAction.Controls.Add(this.btnCustomer);
            this.grbAction.Controls.Add(this.btnShow);
            this.grbAction.Location = new System.Drawing.Point(33, 300);
            this.grbAction.Name = "grbAction";
            this.grbAction.Size = new System.Drawing.Size(429, 100);
            this.grbAction.TabIndex = 7;
            this.grbAction.TabStop = false;
            this.grbAction.Text = "Actions";
            this.grbAction.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnClose.Location = new System.Drawing.Point(150, 216);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 36);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(496, 529);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grbAction);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.nameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordErrorProvider)).EndInit();
            this.grbAction.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ErrorProvider nameErrorProvider;
        private System.Windows.Forms.ErrorProvider passwordErrorProvider;
        private System.Windows.Forms.GroupBox grbAction;
        private System.Windows.Forms.Button btnClose;
    }
}
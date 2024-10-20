namespace ValidatingPassword
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUser = new TextBox();
            txtPassword = new TextBox();
            btnVerifying = new Button();
            lblMessages = new Label();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.Location = new Point(206, 137);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(125, 27);
            txtUser.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(206, 190);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 1;
            // 
            // btnVerifying
            // 
            btnVerifying.Location = new Point(221, 245);
            btnVerifying.Name = "btnVerifying";
            btnVerifying.Size = new Size(94, 29);
            btnVerifying.TabIndex = 2;
            btnVerifying.Text = "Verifying";
            btnVerifying.UseVisualStyleBackColor = true;
            btnVerifying.Click += btnVerifying_Click;
            // 
            // lblMessages
            // 
            lblMessages.AutoSize = true;
            lblMessages.Location = new Point(401, 174);
            lblMessages.Name = "lblMessages";
            lblMessages.Size = new Size(113, 20);
            lblMessages.TabIndex = 3;
            lblMessages.Text = "Show Messages";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMessages);
            Controls.Add(btnVerifying);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUser;
        private TextBox txtPassword;
        private Button btnVerifying;
        private Label lblMessages;
    }
}

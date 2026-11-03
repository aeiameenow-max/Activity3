namespace activity_finals
{
    partial class register
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
            pnlCard = new Panel();
            lnkBack = new LinkLabel();
            btnRegister = new Button();
            lblStatus = new Label();
            txtConfirm = new TextBox();
            lblConfirm = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtUsername = new TextBox();
            lblUsername = new Label();
            lblSubtitle = new Label();
            lblTitle = new Label();
            pnlAccent = new Panel();
            pnlCard.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.White;
            pnlCard.Controls.Add(lnkBack);
            pnlCard.Controls.Add(btnRegister);
            pnlCard.Controls.Add(lblStatus);
            pnlCard.Controls.Add(txtConfirm);
            pnlCard.Controls.Add(lblConfirm);
            pnlCard.Controls.Add(txtPassword);
            pnlCard.Controls.Add(lblPassword);
            pnlCard.Controls.Add(txtUsername);
            pnlCard.Controls.Add(lblUsername);
            pnlCard.Controls.Add(lblSubtitle);
            pnlCard.Controls.Add(lblTitle);
            pnlCard.Controls.Add(pnlAccent);
            pnlCard.Location = new Point(230, 10);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(340, 430);
            pnlCard.TabIndex = 1;
            // 
            // lnkBack
            // 
            lnkBack.ActiveLinkColor = Color.FromArgb(219, 39, 119);
            lnkBack.LinkColor = Color.FromArgb(219, 39, 119);
            lnkBack.Location = new Point(20, 390);
            lnkBack.Name = "lnkBack";
            lnkBack.Size = new Size(300, 20);
            lnkBack.TabIndex = 11;
            lnkBack.TabStop = true;
            lnkBack.Text = "Already have an account? Sign in";
            lnkBack.TextAlign = ContentAlignment.MiddleCenter;
            lnkBack.VisitedLinkColor = Color.FromArgb(219, 39, 119);
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(219, 39, 119);
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatAppearance.MouseDownBackColor = Color.FromArgb(219, 39, 119);
            btnRegister.FlatAppearance.MouseOverBackColor = Color.FromArgb(219, 39, 119);
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(20, 330);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(300, 40);
            btnRegister.TabIndex = 10;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // lblStatus
            // 
            lblStatus.Location = new Point(20, 300);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(300, 20);
            lblStatus.TabIndex = 9;
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new Point(20, 262);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(300, 27);
            txtConfirm.TabIndex = 8;
            txtConfirm.UseSystemPasswordChar = true;
            // 
            // lblConfirm
            // 
            lblConfirm.AutoSize = true;
            lblConfirm.Location = new Point(20, 240);
            lblConfirm.Name = "lblConfirm";
            lblConfirm.Size = new Size(127, 20);
            lblConfirm.TabIndex = 7;
            lblConfirm.Text = "Confirm Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(20, 202);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(300, 27);
            txtPassword.TabIndex = 6;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(20, 180);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(20, 142);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(300, 27);
            txtUsername.TabIndex = 4;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(20, 120);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(75, 20);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Username";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9F);
            lblSubtitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblSubtitle.Location = new Point(20, 80);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(165, 20);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Fill in the details below.";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F);
            lblTitle.ForeColor = Color.FromArgb(31, 41, 55);
            lblTitle.Location = new Point(20, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(221, 41);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Create Account";
            // 
            // pnlAccent
            // 
            pnlAccent.BackColor = Color.FromArgb(219, 39, 119);
            pnlAccent.Dock = DockStyle.Top;
            pnlAccent.Location = new Point(0, 0);
            pnlAccent.Name = "pnlAccent";
            pnlAccent.Size = new Size(340, 6);
            pnlAccent.TabIndex = 0;
            // 
            // register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlCard);
            Name = "register";
            Text = "register";
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCard;
        private LinkLabel lnkBack;
        private Button btnRegister;
        private Label lblStatus;
        private TextBox txtConfirm;
        private Label lblConfirm;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtUsername;
        private Label lblUsername;
        private Label lblSubtitle;
        private Label lblTitle;
        private Panel pnlAccent;
    }
}
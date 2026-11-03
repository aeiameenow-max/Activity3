namespace activity_finals
{
    partial class signin
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
            lnkRegister = new LinkLabel();
            btnLogin = new Button();
            lblStatus = new Label();
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
            pnlCard.Controls.Add(lnkRegister);
            pnlCard.Controls.Add(btnLogin);
            pnlCard.Controls.Add(lblStatus);
            pnlCard.Controls.Add(txtPassword);
            pnlCard.Controls.Add(lblPassword);
            pnlCard.Controls.Add(txtUsername);
            pnlCard.Controls.Add(lblUsername);
            pnlCard.Controls.Add(lblSubtitle);
            pnlCard.Controls.Add(lblTitle);
            pnlCard.Controls.Add(pnlAccent);
            pnlCard.Location = new Point(230, 30);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(340, 390);
            pnlCard.TabIndex = 2;
            // 
            // lnkRegister
            // 
            lnkRegister.ActiveLinkColor = Color.FromArgb(219, 39, 119);
            lnkRegister.LinkColor = Color.FromArgb(219, 39, 119);
            lnkRegister.Location = new Point(20, 345);
            lnkRegister.Name = "lnkRegister";
            lnkRegister.Size = new Size(300, 20);
            lnkRegister.TabIndex = 9;
            lnkRegister.TabStop = true;
            lnkRegister.Text = "Don't have an account? Register";
            lnkRegister.TextAlign = ContentAlignment.MiddleCenter;
            lnkRegister.VisitedLinkColor = Color.FromArgb(219, 39, 119);
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(219, 39, 119);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(219, 39, 119);
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(219, 39, 119);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(20, 285);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(300, 40);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Sign In";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // lblStatus
            // 
            lblStatus.ForeColor = Color.FromArgb(190, 18, 60);
            lblStatus.Location = new Point(20, 250);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(300, 20);
            lblStatus.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(20, 207);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(300, 27);
            txtPassword.TabIndex = 6;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(20, 185);
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
            lblSubtitle.Size = new Size(243, 20);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Enter your username and password.";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F);
            lblTitle.ForeColor = Color.FromArgb(31, 41, 55);
            lblTitle.Location = new Point(20, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(109, 41);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Sign In";
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
            // signin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlCard);
            Name = "signin";
            Text = "signin";
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCard;
        private LinkLabel lnkRegister;
        private Button btnLogin;
        private Label lblStatus;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtUsername;
        private Label lblUsername;
        private Label lblSubtitle;
        private Label lblTitle;
        private Panel pnlAccent;
    }
}
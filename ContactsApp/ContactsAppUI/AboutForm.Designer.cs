namespace ContactsApp
{
    partial class AboutForm
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.MailLinklabel = new System.Windows.Forms.LinkLabel();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.MailLabel = new System.Windows.Forms.Label();
            this.GitLabel = new System.Windows.Forms.Label();
            this.GitLinklabel = new System.Windows.Forms.LinkLabel();
            this.MarkLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLabel.Location = new System.Drawing.Point(18, 19);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(148, 26);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "ContactsApp";
            this.TitleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // MailLinklabel
            // 
            this.MailLinklabel.AutoSize = true;
            this.MailLinklabel.Location = new System.Drawing.Point(124, 126);
            this.MailLinklabel.Name = "MailLinklabel";
            this.MailLinklabel.Size = new System.Drawing.Size(102, 13);
            this.MailLinklabel.TabIndex = 1;
            this.MailLinklabel.TabStop = true;
            this.MailLinklabel.Text = "v.gorbunoff@mail.ru";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(23, 52);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(43, 13);
            this.VersionLabel.TabIndex = 2;
            this.VersionLabel.Text = "v. 1.0.0";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(22, 90);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(130, 13);
            this.AuthorLabel.TabIndex = 3;
            this.AuthorLabel.Text = "Author: Vladimir Gorbunov";
            // 
            // MailLabel
            // 
            this.MailLabel.AutoSize = true;
            this.MailLabel.Location = new System.Drawing.Point(24, 126);
            this.MailLabel.Name = "MailLabel";
            this.MailLabel.Size = new System.Drawing.Size(103, 13);
            this.MailLabel.TabIndex = 4;
            this.MailLabel.Text = "e-mail for feedback: ";
            // 
            // GitLabel
            // 
            this.GitLabel.AutoSize = true;
            this.GitLabel.Location = new System.Drawing.Point(23, 151);
            this.GitLabel.Name = "GitLabel";
            this.GitLabel.Size = new System.Drawing.Size(46, 13);
            this.GitLabel.TabIndex = 5;
            this.GitLabel.Text = "GitHub: ";
            // 
            // GitLinklabel
            // 
            this.GitLinklabel.AutoSize = true;
            this.GitLinklabel.Location = new System.Drawing.Point(68, 151);
            this.GitLinklabel.Name = "GitLinklabel";
            this.GitLinklabel.Size = new System.Drawing.Size(307, 13);
            this.GitLinklabel.TabIndex = 6;
            this.GitLinklabel.TabStop = true;
            this.GitLinklabel.Text = "gitthub.com/VladlenVladlenovich/VladlenVladlenovich.github.io";
            // 
            // MarkLabel
            // 
            this.MarkLabel.AutoSize = true;
            this.MarkLabel.Location = new System.Drawing.Point(12, 246);
            this.MarkLabel.Name = "MarkLabel";
            this.MarkLabel.Size = new System.Drawing.Size(135, 13);
            this.MarkLabel.TabIndex = 7;
            this.MarkLabel.Text = "2024 Vladimir Gorbunov  ©";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 268);
            this.Controls.Add(this.MarkLabel);
            this.Controls.Add(this.GitLinklabel);
            this.Controls.Add(this.GitLabel);
            this.Controls.Add(this.MailLabel);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.MailLinklabel);
            this.Controls.Add(this.TitleLabel);
            this.MaximumSize = new System.Drawing.Size(426, 307);
            this.MinimumSize = new System.Drawing.Size(426, 307);
            this.Name = "AboutForm";
            this.Text = "About";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.LinkLabel MailLinklabel;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label MailLabel;
        private System.Windows.Forms.Label GitLabel;
        private System.Windows.Forms.LinkLabel GitLinklabel;
        private System.Windows.Forms.Label MarkLabel;
    }
}
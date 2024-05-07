namespace ContactsApp
{
    partial class EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            this.BirthdayTimepicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.VkTextbox = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MailTextbox = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PhoneTextbox = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NameTextbox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SurnameTextbox = new System.Windows.Forms.MaskedTextBox();
            this.ButtonOk = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.EditPanel = new System.Windows.Forms.Panel();
            this.EditPictureBox = new System.Windows.Forms.PictureBox();
            this.AddPictureBox = new System.Windows.Forms.PictureBox();
            this.RemovePictureBox = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.EditPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemovePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BirthdayTimepicker
            // 
            this.BirthdayTimepicker.Location = new System.Drawing.Point(67, 76);
            this.BirthdayTimepicker.MaxDate = new System.DateTime(2035, 12, 1, 0, 0, 0, 0);
            this.BirthdayTimepicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.BirthdayTimepicker.Name = "BirthdayTimepicker";
            this.BirthdayTimepicker.Size = new System.Drawing.Size(155, 20);
            this.BirthdayTimepicker.TabIndex = 29;
            this.BirthdayTimepicker.Value = new System.DateTime(2024, 4, 24, 0, 0, 0, 0);
            this.BirthdayTimepicker.ValueChanged += new System.EventHandler(this.BirthdayTimepicker_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "vk.com:";
            // 
            // VkTextbox
            // 
            this.VkTextbox.Location = new System.Drawing.Point(65, 181);
            this.VkTextbox.Name = "VkTextbox";
            this.VkTextbox.Size = new System.Drawing.Size(388, 20);
            this.VkTextbox.TabIndex = 27;
            this.VkTextbox.TextChanged += new System.EventHandler(this.VkTextbox_TextChanged);
            this.VkTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VkTextbox_KeyPress);
            this.VkTextbox.Leave += new System.EventHandler(this.VkTextbox_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "E-mail:";
            // 
            // MailTextbox
            // 
            this.MailTextbox.Location = new System.Drawing.Point(65, 145);
            this.MailTextbox.Name = "MailTextbox";
            this.MailTextbox.Size = new System.Drawing.Size(388, 20);
            this.MailTextbox.TabIndex = 25;
            this.MailTextbox.TextChanged += new System.EventHandler(this.MailTextbox_TextChanged);
            this.MailTextbox.Leave += new System.EventHandler(this.MailTextbox_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Phone:";
            // 
            // PhoneTextbox
            // 
            this.PhoneTextbox.Location = new System.Drawing.Point(65, 110);
            this.PhoneTextbox.Name = "PhoneTextbox";
            this.PhoneTextbox.Size = new System.Drawing.Size(388, 20);
            this.PhoneTextbox.TabIndex = 23;
            this.PhoneTextbox.TextChanged += new System.EventHandler(this.PhoneTextbox_TextChanged);
            this.PhoneTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneTextbox_KeyPress);
            this.PhoneTextbox.Leave += new System.EventHandler(this.PhoneTextbox_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Birthday:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Name:";
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(65, 40);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(388, 20);
            this.NameTextbox.TabIndex = 20;
            this.NameTextbox.TextChanged += new System.EventHandler(this.NameTextbox_TextChanged);
            this.NameTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTextbox_KeyPress);
            this.NameTextbox.Leave += new System.EventHandler(this.NameTextbox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Surname:";
            // 
            // SurnameTextbox
            // 
            this.SurnameTextbox.Location = new System.Drawing.Point(65, 7);
            this.SurnameTextbox.Name = "SurnameTextbox";
            this.SurnameTextbox.Size = new System.Drawing.Size(388, 20);
            this.SurnameTextbox.TabIndex = 18;
            this.SurnameTextbox.TextChanged += new System.EventHandler(this.SurnameTextbox_TextChanged);
            this.SurnameTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SurnameTextbox_KeyPress);
            this.SurnameTextbox.Leave += new System.EventHandler(this.SurnameTextbox_Leave);
            // 
            // ButtonOk
            // 
            this.ButtonOk.Location = new System.Drawing.Point(285, 226);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(75, 23);
            this.ButtonOk.TabIndex = 30;
            this.ButtonOk.Text = "OK";
            this.ButtonOk.UseVisualStyleBackColor = true;
            this.ButtonOk.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(378, 226);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 31;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // EditPanel
            // 
            this.EditPanel.Controls.Add(this.EditPictureBox);
            this.EditPanel.Controls.Add(this.AddPictureBox);
            this.EditPanel.Controls.Add(this.RemovePictureBox);
            this.EditPanel.Controls.Add(this.ButtonCancel);
            this.EditPanel.Controls.Add(this.SurnameTextbox);
            this.EditPanel.Controls.Add(this.ButtonOk);
            this.EditPanel.Controls.Add(this.label1);
            this.EditPanel.Controls.Add(this.BirthdayTimepicker);
            this.EditPanel.Controls.Add(this.NameTextbox);
            this.EditPanel.Controls.Add(this.label6);
            this.EditPanel.Controls.Add(this.label3);
            this.EditPanel.Controls.Add(this.VkTextbox);
            this.EditPanel.Controls.Add(this.label4);
            this.EditPanel.Controls.Add(this.label7);
            this.EditPanel.Controls.Add(this.PhoneTextbox);
            this.EditPanel.Controls.Add(this.MailTextbox);
            this.EditPanel.Controls.Add(this.label5);
            this.EditPanel.Location = new System.Drawing.Point(19, 17);
            this.EditPanel.MaximumSize = new System.Drawing.Size(705, 375);
            this.EditPanel.MinimumSize = new System.Drawing.Size(470, 250);
            this.EditPanel.Name = "EditPanel";
            this.EditPanel.Size = new System.Drawing.Size(470, 250);
            this.EditPanel.TabIndex = 32;
            // 
            // EditPictureBox
            // 
            this.EditPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("EditPictureBox.Image")));
            this.EditPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("EditPictureBox.InitialImage")));
            this.EditPictureBox.Location = new System.Drawing.Point(31, 230);
            this.EditPictureBox.Name = "EditPictureBox";
            this.EditPictureBox.Size = new System.Drawing.Size(21, 17);
            this.EditPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EditPictureBox.TabIndex = 34;
            this.EditPictureBox.TabStop = false;
            // 
            // AddPictureBox
            // 
            this.AddPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("AddPictureBox.Image")));
            this.AddPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("AddPictureBox.InitialImage")));
            this.AddPictureBox.Location = new System.Drawing.Point(51, 218);
            this.AddPictureBox.Name = "AddPictureBox";
            this.AddPictureBox.Size = new System.Drawing.Size(36, 40);
            this.AddPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddPictureBox.TabIndex = 33;
            this.AddPictureBox.TabStop = false;
            // 
            // RemovePictureBox
            // 
            this.RemovePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("RemovePictureBox.Image")));
            this.RemovePictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("RemovePictureBox.InitialImage")));
            this.RemovePictureBox.Location = new System.Drawing.Point(0, 230);
            this.RemovePictureBox.Name = "RemovePictureBox";
            this.RemovePictureBox.Size = new System.Drawing.Size(21, 17);
            this.RemovePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RemovePictureBox.TabIndex = 32;
            this.RemovePictureBox.TabStop = false;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 291);
            this.Controls.Add(this.EditPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(795, 495);
            this.MinimumSize = new System.Drawing.Size(530, 330);
            this.Name = "EditForm";
            this.Text = "Add/Edit Contact";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.EditPanel.ResumeLayout(false);
            this.EditPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemovePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker BirthdayTimepicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox VkTextbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox MailTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox PhoneTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox NameTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox SurnameTextbox;
        private System.Windows.Forms.Button ButtonOk;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Panel EditPanel;
        private System.Windows.Forms.PictureBox EditPictureBox;
        private System.Windows.Forms.PictureBox AddPictureBox;
        private System.Windows.Forms.PictureBox RemovePictureBox;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
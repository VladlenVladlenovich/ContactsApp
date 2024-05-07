﻿namespace ContactsAppUI
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SurnameTextboxMain = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FindTextbox = new System.Windows.Forms.MaskedTextBox();
            this.FindLabel = new System.Windows.Forms.Label();
            this.ContactsListbox = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.FileTollstrip = new System.Windows.Forms.ToolStripDropDownButton();
            this.ExitToolstripmenuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolstrip = new System.Windows.Forms.ToolStripDropDownButton();
            this.AddToolstripmenuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditTolstripmenuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveToolstripmenuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolstrip = new System.Windows.Forms.ToolStripDropDownButton();
            this.AboutToolstripmenuIiem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.NameTextboxMain = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PhoneTextboxMain = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.VkTextboxMain = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MailTextboxMain = new System.Windows.Forms.MaskedTextBox();
            this.BirthdayTimepickerMain = new System.Windows.Forms.DateTimePicker();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.InputsLayouttable = new System.Windows.Forms.TableLayoutPanel();
            this.EditPictureBox = new System.Windows.Forms.PictureBox();
            this.AddPictureBox = new System.Windows.Forms.PictureBox();
            this.RemovePictureBox = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.InputsLayouttable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemovePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SurnameTextboxMain
            // 
            this.SurnameTextboxMain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SurnameTextboxMain.Location = new System.Drawing.Point(61, 3);
            this.SurnameTextboxMain.Name = "SurnameTextboxMain";
            this.SurnameTextboxMain.ReadOnly = true;
            this.SurnameTextboxMain.Size = new System.Drawing.Size(388, 20);
            this.SurnameTextboxMain.TabIndex = 1;
            this.SurnameTextboxMain.Leave += new System.EventHandler(this.SurnameTextboxMain_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Surname:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FindTextbox
            // 
            this.FindTextbox.Location = new System.Drawing.Point(33, 14);
            this.FindTextbox.Name = "FindTextbox";
            this.FindTextbox.Size = new System.Drawing.Size(219, 20);
            this.FindTextbox.TabIndex = 3;
            this.FindTextbox.TextChanged += new System.EventHandler(this.FindTextbox_TextChanged);
            // 
            // FindLabel
            // 
            this.FindLabel.AutoSize = true;
            this.FindLabel.Location = new System.Drawing.Point(2, 17);
            this.FindLabel.Name = "FindLabel";
            this.FindLabel.Size = new System.Drawing.Size(30, 13);
            this.FindLabel.TabIndex = 4;
            this.FindLabel.Text = "Find:";
            // 
            // ContactsListbox
            // 
            this.ContactsListbox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ContactsListbox.FormattingEnabled = true;
            this.ContactsListbox.Location = new System.Drawing.Point(0, 74);
            this.ContactsListbox.MaximumSize = new System.Drawing.Size(300, 400);
            this.ContactsListbox.Name = "ContactsListbox";
            this.ContactsListbox.Size = new System.Drawing.Size(254, 329);
            this.ContactsListbox.TabIndex = 5;
            this.ContactsListbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ContactsListbox_MouseClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileTollstrip,
            this.EditToolstrip,
            this.HelpToolstrip});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(811, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // FileTollstrip
            // 
            this.FileTollstrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolstripmenuitem});
            this.FileTollstrip.Name = "FileTollstrip";
            this.FileTollstrip.Size = new System.Drawing.Size(50, 22);
            this.FileTollstrip.Text = "File    ";
            // 
            // ExitToolstripmenuitem
            // 
            this.ExitToolstripmenuitem.Name = "ExitToolstripmenuitem";
            this.ExitToolstripmenuitem.Size = new System.Drawing.Size(93, 22);
            this.ExitToolstripmenuitem.Text = "Exit";
            this.ExitToolstripmenuitem.Click += new System.EventHandler(this.ExitToolstripmenuitem_Click);
            // 
            // EditToolstrip
            // 
            this.EditToolstrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolstripmenuitem,
            this.EditTolstripmenuitem,
            this.RemoveToolstripmenuitem});
            this.EditToolstrip.Name = "EditToolstrip";
            this.EditToolstrip.Size = new System.Drawing.Size(52, 22);
            this.EditToolstrip.Text = "Edit    ";
            // 
            // AddToolstripmenuitem
            // 
            this.AddToolstripmenuitem.Name = "AddToolstripmenuitem";
            this.AddToolstripmenuitem.Size = new System.Drawing.Size(160, 22);
            this.AddToolstripmenuitem.Text = "Add contact";
            this.AddToolstripmenuitem.Click += new System.EventHandler(this.AddTooltripenutem_Click);
            // 
            // EditTolstripmenuitem
            // 
            this.EditTolstripmenuitem.Name = "EditTolstripmenuitem";
            this.EditTolstripmenuitem.Size = new System.Drawing.Size(160, 22);
            this.EditTolstripmenuitem.Text = "Edit contact";
            this.EditTolstripmenuitem.Click += new System.EventHandler(this.EditTolstripmenuitem_Click);
            // 
            // RemoveToolstripmenuitem
            // 
            this.RemoveToolstripmenuitem.Name = "RemoveToolstripmenuitem";
            this.RemoveToolstripmenuitem.Size = new System.Drawing.Size(160, 22);
            this.RemoveToolstripmenuitem.Text = "Remove contact";
            this.RemoveToolstripmenuitem.Click += new System.EventHandler(this.RemoveToolstripmenuitem_Click);
            // 
            // HelpToolstrip
            // 
            this.HelpToolstrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolstripmenuIiem});
            this.HelpToolstrip.Name = "HelpToolstrip";
            this.HelpToolstrip.Size = new System.Drawing.Size(54, 22);
            this.HelpToolstrip.Text = "Help   ";
            // 
            // AboutToolstripmenuIiem
            // 
            this.AboutToolstripmenuIiem.Name = "AboutToolstripmenuIiem";
            this.AboutToolstripmenuIiem.Size = new System.Drawing.Size(107, 22);
            this.AboutToolstripmenuIiem.Text = "About";
            this.AboutToolstripmenuIiem.Click += new System.EventHandler(this.AboutToolstripmenuIiem_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name:";
            // 
            // NameTextboxMain
            // 
            this.NameTextboxMain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.NameTextboxMain.Location = new System.Drawing.Point(61, 29);
            this.NameTextboxMain.Name = "NameTextboxMain";
            this.NameTextboxMain.ReadOnly = true;
            this.NameTextboxMain.Size = new System.Drawing.Size(388, 20);
            this.NameTextboxMain.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Birthday";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Phone:";
            // 
            // PhoneTextboxMain
            // 
            this.PhoneTextboxMain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PhoneTextboxMain.Location = new System.Drawing.Point(61, 81);
            this.PhoneTextboxMain.Name = "PhoneTextboxMain";
            this.PhoneTextboxMain.ReadOnly = true;
            this.PhoneTextboxMain.Size = new System.Drawing.Size(388, 20);
            this.PhoneTextboxMain.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "vk.com";
            // 
            // VkTextboxMain
            // 
            this.VkTextboxMain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.VkTextboxMain.Location = new System.Drawing.Point(61, 133);
            this.VkTextboxMain.Name = "VkTextboxMain";
            this.VkTextboxMain.ReadOnly = true;
            this.VkTextboxMain.Size = new System.Drawing.Size(388, 20);
            this.VkTextboxMain.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "E-mail:";
            // 
            // MailTextboxMain
            // 
            this.MailTextboxMain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MailTextboxMain.Location = new System.Drawing.Point(61, 107);
            this.MailTextboxMain.Name = "MailTextboxMain";
            this.MailTextboxMain.ReadOnly = true;
            this.MailTextboxMain.Size = new System.Drawing.Size(388, 20);
            this.MailTextboxMain.TabIndex = 13;
            // 
            // BirthdayTimepickerMain
            // 
            this.BirthdayTimepickerMain.CalendarTitleBackColor = System.Drawing.SystemColors.ControlLight;
            this.BirthdayTimepickerMain.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            this.BirthdayTimepickerMain.Enabled = false;
            this.BirthdayTimepickerMain.Location = new System.Drawing.Point(61, 55);
            this.BirthdayTimepickerMain.Name = "BirthdayTimepickerMain";
            this.BirthdayTimepickerMain.Size = new System.Drawing.Size(155, 20);
            this.BirthdayTimepickerMain.TabIndex = 17;
            // 
            // splitContainer
            // 
            this.splitContainer.Location = new System.Drawing.Point(22, 43);
            this.splitContainer.MaximumSize = new System.Drawing.Size(1100, 600);
            this.splitContainer.MinimumSize = new System.Drawing.Size(765, 403);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.ContactsListbox);
            this.splitContainer.Panel1.Controls.Add(this.FindLabel);
            this.splitContainer.Panel1.Controls.Add(this.FindTextbox);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.InputsLayouttable);
            this.splitContainer.Size = new System.Drawing.Size(766, 403);
            this.splitContainer.SplitterDistance = 254;
            this.splitContainer.TabIndex = 18;
            // 
            // InputsLayouttable
            // 
            this.InputsLayouttable.ColumnCount = 2;
            this.InputsLayouttable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.InputsLayouttable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.InputsLayouttable.Controls.Add(this.label1, 0, 0);
            this.InputsLayouttable.Controls.Add(this.VkTextboxMain, 1, 5);
            this.InputsLayouttable.Controls.Add(this.BirthdayTimepickerMain, 1, 2);
            this.InputsLayouttable.Controls.Add(this.MailTextboxMain, 1, 4);
            this.InputsLayouttable.Controls.Add(this.PhoneTextboxMain, 1, 3);
            this.InputsLayouttable.Controls.Add(this.label6, 0, 5);
            this.InputsLayouttable.Controls.Add(this.NameTextboxMain, 1, 1);
            this.InputsLayouttable.Controls.Add(this.label7, 0, 4);
            this.InputsLayouttable.Controls.Add(this.label5, 0, 3);
            this.InputsLayouttable.Controls.Add(this.label4, 0, 2);
            this.InputsLayouttable.Controls.Add(this.label3, 0, 1);
            this.InputsLayouttable.Controls.Add(this.SurnameTextboxMain, 1, 0);
            this.InputsLayouttable.Location = new System.Drawing.Point(25, 17);
            this.InputsLayouttable.MaximumSize = new System.Drawing.Size(600, 153);
            this.InputsLayouttable.Name = "InputsLayouttable";
            this.InputsLayouttable.RowCount = 6;
            this.InputsLayouttable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InputsLayouttable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InputsLayouttable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InputsLayouttable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InputsLayouttable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InputsLayouttable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InputsLayouttable.Size = new System.Drawing.Size(467, 153);
            this.InputsLayouttable.TabIndex = 19;
            // 
            // EditPictureBox
            // 
            this.EditPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("EditPictureBox.Image")));
            this.EditPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("EditPictureBox.InitialImage")));
            this.EditPictureBox.Location = new System.Drawing.Point(56, 459);
            this.EditPictureBox.Name = "EditPictureBox";
            this.EditPictureBox.Size = new System.Drawing.Size(21, 17);
            this.EditPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EditPictureBox.TabIndex = 37;
            this.EditPictureBox.TabStop = false;
            // 
            // AddPictureBox
            // 
            this.AddPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("AddPictureBox.Image")));
            this.AddPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("AddPictureBox.InitialImage")));
            this.AddPictureBox.Location = new System.Drawing.Point(80, 447);
            this.AddPictureBox.Name = "AddPictureBox";
            this.AddPictureBox.Size = new System.Drawing.Size(36, 40);
            this.AddPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddPictureBox.TabIndex = 36;
            this.AddPictureBox.TabStop = false;
            // 
            // RemovePictureBox
            // 
            this.RemovePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("RemovePictureBox.Image")));
            this.RemovePictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("RemovePictureBox.InitialImage")));
            this.RemovePictureBox.Location = new System.Drawing.Point(22, 459);
            this.RemovePictureBox.Name = "RemovePictureBox";
            this.RemovePictureBox.Size = new System.Drawing.Size(21, 17);
            this.RemovePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RemovePictureBox.TabIndex = 35;
            this.RemovePictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 488);
            this.Controls.Add(this.EditPictureBox);
            this.Controls.Add(this.AddPictureBox);
            this.Controls.Add(this.RemovePictureBox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.splitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1224, 752);
            this.MinimumSize = new System.Drawing.Size(827, 527);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContactsApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.InputsLayouttable.ResumeLayout(false);
            this.InputsLayouttable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemovePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox SurnameTextboxMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox FindTextbox;
        private System.Windows.Forms.Label FindLabel;
        private System.Windows.Forms.ListBox ContactsListbox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox NameTextboxMain;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox PhoneTextboxMain;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox VkTextboxMain;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox MailTextboxMain;
        private System.Windows.Forms.DateTimePicker BirthdayTimepickerMain;
        private System.Windows.Forms.ToolStripDropDownButton FileTollstrip;
        private System.Windows.Forms.ToolStripMenuItem ExitToolstripmenuitem;
        private System.Windows.Forms.ToolStripDropDownButton EditToolstrip;
        private System.Windows.Forms.ToolStripMenuItem AddToolstripmenuitem;
        private System.Windows.Forms.ToolStripMenuItem EditTolstripmenuitem;
        private System.Windows.Forms.ToolStripMenuItem RemoveToolstripmenuitem;
        private System.Windows.Forms.ToolStripDropDownButton HelpToolstrip;
        private System.Windows.Forms.ToolStripMenuItem AboutToolstripmenuIiem;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TableLayoutPanel InputsLayouttable;
        private System.Windows.Forms.PictureBox EditPictureBox;
        private System.Windows.Forms.PictureBox AddPictureBox;
        private System.Windows.Forms.PictureBox RemovePictureBox;
    }
}


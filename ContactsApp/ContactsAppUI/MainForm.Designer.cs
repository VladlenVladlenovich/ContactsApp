namespace ContactsAppUI
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
            this.SurnameTextbox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FindTextbox = new System.Windows.Forms.MaskedTextBox();
            this.FindLabel = new System.Windows.Forms.Label();
            this.ContactsListbox = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.FileTollstrip = new System.Windows.Forms.ToolStripDropDownButton();
            this.ExitToolstripmenuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolstrip = new System.Windows.Forms.ToolStripDropDownButton();
            this.AddTooltripenutem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditTolstripmenuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveToolstripmenuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolstrip = new System.Windows.Forms.ToolStripDropDownButton();
            this.AboutToolstripmenuIiem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.NameTextbox = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PhoneTextbox = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.VkTextbox = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MailTextbox = new System.Windows.Forms.MaskedTextBox();
            this.BirthdayTimepicker = new System.Windows.Forms.DateTimePicker();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.InputsLayouttable = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.InputsLayouttable.SuspendLayout();
            this.SuspendLayout();
            // 
            // SurnameTextbox
            // 
            this.SurnameTextbox.Location = new System.Drawing.Point(61, 3);
            this.SurnameTextbox.Name = "SurnameTextbox";
            this.SurnameTextbox.Size = new System.Drawing.Size(388, 20);
            this.SurnameTextbox.TabIndex = 1;
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FindTextbox
            // 
            this.FindTextbox.Location = new System.Drawing.Point(33, 14);
            this.FindTextbox.Name = "FindTextbox";
            this.FindTextbox.Size = new System.Drawing.Size(219, 20);
            this.FindTextbox.TabIndex = 3;
            // 
            // FindLabel
            // 
            this.FindLabel.AutoSize = true;
            this.FindLabel.Location = new System.Drawing.Point(2, 17);
            this.FindLabel.Name = "FindLabel";
            this.FindLabel.Size = new System.Drawing.Size(30, 13);
            this.FindLabel.TabIndex = 4;
            this.FindLabel.Text = "Find:";
            this.FindLabel.Click += new System.EventHandler(this.label2_Click);
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
            this.ContactsListbox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
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
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // FileTollstrip
            // 
            this.FileTollstrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolstripmenuitem});
            this.FileTollstrip.Name = "FileTollstrip";
            this.FileTollstrip.Size = new System.Drawing.Size(50, 22);
            this.FileTollstrip.Text = "File    ";
            this.FileTollstrip.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // ExitToolstripmenuitem
            // 
            this.ExitToolstripmenuitem.Name = "ExitToolstripmenuitem";
            this.ExitToolstripmenuitem.Size = new System.Drawing.Size(180, 22);
            this.ExitToolstripmenuitem.Text = "Exit";
            // 
            // EditToolstrip
            // 
            this.EditToolstrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddTooltripenutem,
            this.EditTolstripmenuitem,
            this.RemoveToolstripmenuitem});
            this.EditToolstrip.Name = "EditToolstrip";
            this.EditToolstrip.Size = new System.Drawing.Size(52, 22);
            this.EditToolstrip.Text = "Edit    ";
            this.EditToolstrip.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // AddTooltripenutem
            // 
            this.AddTooltripenutem.Name = "AddTooltripenutem";
            this.AddTooltripenutem.Size = new System.Drawing.Size(180, 22);
            this.AddTooltripenutem.Text = "Add contact";
            // 
            // EditTolstripmenuitem
            // 
            this.EditTolstripmenuitem.Name = "EditTolstripmenuitem";
            this.EditTolstripmenuitem.Size = new System.Drawing.Size(180, 22);
            this.EditTolstripmenuitem.Text = "Edit contact";
            // 
            // RemoveToolstripmenuitem
            // 
            this.RemoveToolstripmenuitem.Name = "RemoveToolstripmenuitem";
            this.RemoveToolstripmenuitem.Size = new System.Drawing.Size(180, 22);
            this.RemoveToolstripmenuitem.Text = "Remove contact";
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
            this.AboutToolstripmenuIiem.Size = new System.Drawing.Size(180, 22);
            this.AboutToolstripmenuIiem.Text = "About";
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
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(61, 29);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(388, 20);
            this.NameTextbox.TabIndex = 7;
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
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // PhoneTextbox
            // 
            this.PhoneTextbox.Location = new System.Drawing.Point(61, 81);
            this.PhoneTextbox.Name = "PhoneTextbox";
            this.PhoneTextbox.Size = new System.Drawing.Size(388, 20);
            this.PhoneTextbox.TabIndex = 11;
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
            // VkTextbox
            // 
            this.VkTextbox.Location = new System.Drawing.Point(61, 133);
            this.VkTextbox.Name = "VkTextbox";
            this.VkTextbox.Size = new System.Drawing.Size(388, 20);
            this.VkTextbox.TabIndex = 15;
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
            // MailTextbox
            // 
            this.MailTextbox.Location = new System.Drawing.Point(61, 107);
            this.MailTextbox.Name = "MailTextbox";
            this.MailTextbox.Size = new System.Drawing.Size(388, 20);
            this.MailTextbox.TabIndex = 13;
            // 
            // BirthdayTimepicker
            // 
            this.BirthdayTimepicker.Location = new System.Drawing.Point(61, 55);
            this.BirthdayTimepicker.Name = "BirthdayTimepicker";
            this.BirthdayTimepicker.Size = new System.Drawing.Size(155, 20);
            this.BirthdayTimepicker.TabIndex = 17;
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
            this.InputsLayouttable.Controls.Add(this.VkTextbox, 1, 5);
            this.InputsLayouttable.Controls.Add(this.BirthdayTimepicker, 1, 2);
            this.InputsLayouttable.Controls.Add(this.MailTextbox, 1, 4);
            this.InputsLayouttable.Controls.Add(this.PhoneTextbox, 1, 3);
            this.InputsLayouttable.Controls.Add(this.label6, 0, 5);
            this.InputsLayouttable.Controls.Add(this.NameTextbox, 1, 1);
            this.InputsLayouttable.Controls.Add(this.label7, 0, 4);
            this.InputsLayouttable.Controls.Add(this.label5, 0, 3);
            this.InputsLayouttable.Controls.Add(this.label4, 0, 2);
            this.InputsLayouttable.Controls.Add(this.SurnameTextbox, 1, 0);
            this.InputsLayouttable.Controls.Add(this.label3, 0, 1);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 488);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.splitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1224, 752);
            this.MinimumSize = new System.Drawing.Size(827, 527);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContactsApp";
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox SurnameTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox FindTextbox;
        private System.Windows.Forms.Label FindLabel;
        private System.Windows.Forms.ListBox ContactsListbox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox NameTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox PhoneTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox VkTextbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox MailTextbox;
        private System.Windows.Forms.DateTimePicker BirthdayTimepicker;
        private System.Windows.Forms.ToolStripDropDownButton FileTollstrip;
        private System.Windows.Forms.ToolStripMenuItem ExitToolstripmenuitem;
        private System.Windows.Forms.ToolStripDropDownButton EditToolstrip;
        private System.Windows.Forms.ToolStripMenuItem AddTooltripenutem;
        private System.Windows.Forms.ToolStripMenuItem EditTolstripmenuitem;
        private System.Windows.Forms.ToolStripMenuItem RemoveToolstripmenuitem;
        private System.Windows.Forms.ToolStripDropDownButton HelpToolstrip;
        private System.Windows.Forms.ToolStripMenuItem AboutToolstripmenuIiem;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TableLayoutPanel InputsLayouttable;
    }
}


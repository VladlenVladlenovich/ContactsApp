using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ContactsAppUI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace ContactsApp
{
    public partial class EditForm : Form
    {
        private Contact phonelist;
        private int check = 0; //Переменная для проверки заполненности всех полей в форме
        

        public Contact Contact //Свойство для заполнения экземпляра класса Contact
        {
            get { return phonelist; }
            set
            {
                phonelist = value;

                if (phonelist != null)
                {
                    SurnameTextbox.Text = phonelist.Surname;
                    NameTextbox.Text = phonelist.Name;
                    PhoneTextbox.Text = phonelist.PhoneNumber.Number.ToString();
                    BirthdayTimepicker.Value = phonelist.Birthday;
                    MailTextbox.Text = phonelist.Mail;
                    VkTextbox.Text = phonelist.Id.ToString();
                }
            }
        }

        public EditForm()
        {
            InitializeComponent();
        
    }




        private void SurnameTextbox_TextChanged(object sender, EventArgs e)
        {
            phonelist.Surname = SurnameTextbox.Text; //При изменении информации Textbox перехаписываем данные
           
        }
        private void SurnameTextbox_KeyPress(object sender, KeyPressEventArgs e) //Событие набора текста
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)) // Проверяем, что введенный символ не является числом
            {
                e.Handled = true; // Отменяем ввод символа, если он не является числом
            }
        }
        private void SurnameTextbox_Leave(object sender, EventArgs e) //Событие потери фокуса
        {
            if (SurnameTextbox.Text.Length > 50 || string.IsNullOrEmpty(SurnameTextbox.Text)) //Проверка длины
            {
                SurnameTextbox.BackColor = Color.IndianRed; //Окрашиваем поле в красный
                toolTip1.Show("", SurnameTextbox, SurnameTextbox.Location.X, //Выводим сообщение о типе ошибки
                    SurnameTextbox.Location.Y, 2000);
                check = 0;
            }

            else
            {
                SurnameTextbox.BackColor = Color.White;
                phonelist.Surname = SurnameTextbox.Text;
                phonelist.Surname = char.ToUpper(phonelist.Surname[0]) + 
                                    phonelist.Surname.Substring(1); //Переводим первый символ в верхний регистр
                
                check = 1;//Меняем значение проверочной переменной
            }
        }


        private void NameTextbox_TextChanged(object sender, EventArgs e)
        {
            phonelist.Name = NameTextbox.Text;
        }

        private void NameTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)) // Проверяем, что введенный символ не является числом
            {
                e.Handled = true; // Отменяем ввод символа, если он не является буквой
            }
        }

        private void NameTextbox_Leave(object sender, EventArgs e)
        {
            if (NameTextbox.Text.Length > 50 || string.IsNullOrEmpty(NameTextbox.Text))
            {
                NameTextbox.BackColor = Color.IndianRed;
                toolTip1.Show("To many chars", NameTextbox, NameTextbox.Location.X, NameTextbox.Location.Y, 2000);
                check = 0;
            }

            else
            {
                NameTextbox.BackColor = Color.White;
                
                phonelist.Name = NameTextbox.Text;
                phonelist.Name = char.ToUpper(phonelist.Name[0]) + phonelist.Name.Substring(1);
                check = 1;
            }
        }



        private void BirthdayTimepicker_ValueChanged(object sender, EventArgs e)
        {
            phonelist.Birthday = BirthdayTimepicker.Value;
        }


        private void PhoneTextbox_TextChanged(object sender, EventArgs e)
        {
            long ValueNum;
            long.TryParse(PhoneTextbox.Text, out ValueNum); 
            phonelist.PhoneNumber.Number = ValueNum;
        }

        private void PhoneTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) // Проверяем, что введенный символ не является числом
            {
                e.Handled = true; // Отменяем ввод символа, если он не является числом
            }
        }

        private void PhoneTextbox_Leave(object sender, EventArgs e)
        {
            long ValueNum;
            long.TryParse(PhoneTextbox.Text, out ValueNum);

            if (string.IsNullOrEmpty(PhoneTextbox.Text) || PhoneTextbox.Text[0]!='7' || PhoneTextbox.Text.Length != 11)
            {
                PhoneTextbox.BackColor = Color.IndianRed;
                toolTip1.Show("Invalid number", PhoneTextbox, PhoneTextbox.Location.X, PhoneTextbox.Location.Y, 2000);
                check = 0;
            }

            else
            {
                PhoneTextbox.BackColor = Color.White;
                phonelist.PhoneNumber.Number = ValueNum;
                check = 1;
            }
        }


        private void MailTextbox_TextChanged(object sender, EventArgs e)
        {
            phonelist.Mail = MailTextbox.Text;

        } 
        
        private void MailTextbox_Leave(object sender, EventArgs e)
        {
            if (MailTextbox.Text.Length > 50 || string.IsNullOrEmpty(MailTextbox.Text))
            {
                MailTextbox.BackColor = Color.IndianRed;
                toolTip1.Show("To many chars", MailTextbox, MailTextbox.Location.X, MailTextbox.Location.Y, 2000);
                check = 0;
            }

            else
            {
                MailTextbox.BackColor = Color.White;
                phonelist.Mail = MailTextbox.Text;
                check = 1;
            }
        }





        private void VkTextbox_TextChanged(object sender, EventArgs e)
        {
            int ValueVk;
            int.TryParse(VkTextbox.Text, out ValueVk);

            phonelist.Id = ValueVk;
        }

        private void VkTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar)) // Проверяем, что введенный символ не является числом
            {
                e.Handled = true; // Отменяем ввод символа, если он не является числом
            }
        }
        
        private void VkTextbox_Leave(object sender, EventArgs e)
        {
            int ValueVk;
            int.TryParse(VkTextbox.Text, out ValueVk);

            if (VkTextbox.Text.Length > 15 || string.IsNullOrEmpty(VkTextbox.Text))
            {
                VkTextbox.BackColor = Color.IndianRed;
                toolTip1.Show("To many chars", VkTextbox, VkTextbox.Location.X, VkTextbox.Location.Y, 2000);
                check = 0;
            }

            else
            {
                VkTextbox.BackColor = Color.White;
                phonelist.Id = ValueVk;
                check = 1;
            }
        }




        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
  
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            phonelist.Surname = null;
            DialogResult = DialogResult.Cancel;
            this.Hide();
            
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            if (check == 1)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else MessageBox.Show("Check fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}

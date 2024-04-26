using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp;

namespace ContactsAppUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
            var contact = new Contact(); //Создание экземпляра класса "Contact"
            var contact2 = new Contact(); //Создание второго экземпляра класса "Contact");

            List <Contact> phoneList = new List <Contact>(); //Создание экземпляра класса "Project"

            

            contact.SetSurname("halls");
            contact.SetName("ethan");
            contact.number.SetNumber(79095417077);
            contact.SetBirthday(new DateTime(1999, 8, 27));
            contact.SetMail("example@mail.com");
            contact.SetVk(4545344);

            contact2.SetSurname("green");
            contact2.SetName("ben");
           // contact2.number.SetNumber(79039554455);
            contact2.SetBirthday(new DateTime(1966, 5, 6));
            contact2.SetMail("fake@yandex.ru");
            contact2.SetVk(6765344);
            

            phoneList.Add(contact); //Добавление экземляра "Contact" в список
            phoneList.Add(contact2); //Добавление экземляра "Contact2" в список


            for (int i = 0; i < phoneList.Count; i++) //Цикл для вывода накопленной информации
                                                      //В списке "phoneList" в случае, если 
                                                      //Поля класса "Contact" находятся под 
                                                      //Модификатором "private"
            {
                Console.WriteLine(phoneList[i].GetName());
                Console.WriteLine(phoneList[i].GetSurname());
                Console.WriteLine(phoneList[i].number.GetNumber());
                Console.WriteLine(phoneList[i].GetBirthday());
                Console.WriteLine(phoneList[i].GetMail());
                Console.WriteLine(phoneList[i].GetVk());
                Console.WriteLine(" ");
            }

            ProjectManager.SaveToFile(phoneList); //Загрузка списка контактов в файл
            //Console.WriteLine(ProjectManager.LoadFromFile()); //Выгрузка их файла
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            c.Surname = SurnameTextbox.Text;
            c.Name = NameTextbox.Text;
            c.Birthday = BirthdayTimepicker.;
          
            c.Mail = MailTextbox.Text; 
            //c.IdVk = long.Parse(VkTextbox.Text);
            Console.WriteLine(c.Surname);
            phonelist.Add(c);
            Console.WriteLine(phonelist[0].Surname);
            ContactsListbox.Items.Add(c.Surname);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    } 
    
}

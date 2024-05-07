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
using System.Xml.Linq;
using ContactsApp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ContactsAppUI
{
    public partial class MainForm : Form
    {
        private Project project = new Project();
        private Project temp = new Project();

        public MainForm()
        {
            project.PhoneBook = new List<Contact>();

            temp = ProjectManager.LoadFromFile();
            if (temp != null)
            {
                project = temp;
            }

            InitializeComponent();

            if (project.PhoneBook.Count!=0)
            {
            for (int i = 0; i < project.PhoneBook.Count; i++)
            {
                ContactsListbox.Items.Add(project.PhoneBook[i].Surname);
            }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        } 
        
        private void ContactsListbox_MouseClick(object sender, MouseEventArgs e)
        { 
            var selectedIndex = ContactsListbox.SelectedIndex;
            if (selectedIndex != -1)
            {
                //индекс в списке, в нашем случае нужен по размеру
                var selectedData = project.PhoneBook[selectedIndex]; //экземляр списка под выбранном индексом 

                NameTextboxMain.Text = selectedData.Name;
                SurnameTextboxMain.Text = selectedData.Surname;
                PhoneTextboxMain.Text = selectedData.PhoneNumber.Number.ToString();
                BirthdayTimepickerMain.Value = selectedData.Birthday;
                MailTextboxMain.Text = selectedData.Mail;
                VkTextboxMain.Text = selectedData.Id.ToString();
            }
        }

        private void AddTooltripenutem_Click(object sender, EventArgs e)
        {
            var inner = new EditForm(); //Создаем форму

            inner.Contact = new Contact();


            inner.ShowDialog();

            var addedData = inner.Contact;

            project.PhoneBook.Add(addedData);

            
            var listboxPreview = addedData.Surname;

            ContactsListbox.Items.Add(listboxPreview);
            ProjectManager.SaveToFile(project);
        }

       private void EditTolstripmenuitem_Click(object sender, EventArgs e) 
       { 
            var selectedIndex = ContactsListbox.SelectedIndex; //присваиваем переменной хначение индекса выбранногоконтакта 
            if (selectedIndex != -1) //если пользователь выбрал контакт, то:
            {
                var selectedData = project.PhoneBook[selectedIndex]; //экземляр списка под выбранном индексом 
                var inner = new EditForm(); //Создаем форму

                inner.Contact = selectedData; //Передаем форме данные
                inner.ShowDialog(); //Отображаем форму для редактирования
                var updatedData = inner.Contact; //Создание экземпляра класса "Contact"

                ContactsListbox.Items.RemoveAt(selectedIndex); //Удаление фамилии из списка формы по выбранному индексу
                project.PhoneBook.RemoveAt(selectedIndex); //Удаление фамилии из списка по выбранному индексу

                project.PhoneBook.Insert(selectedIndex, updatedData); //Вставляем новую фамилию в список по текущему индексу
                var listboxPreview = updatedData.Surname; //Присваиваем переменной новое значение фамилии,
                                                                //если оно было изменено
                ContactsListbox.Items.Insert(selectedIndex, listboxPreview); //Отоюражаем в списке формы новую фамилию
                ProjectManager.SaveToFile(project); //Активируем сериализацию в файл
            }

            else //если пользователь не выбрал контакт, то выводим соответсвующий MessageBox
            {
                MessageBox.Show("Choose the item below", "Choose item", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }


        private void RemoveToolstripmenuitem_Click(object sender, EventArgs e)
        {
            var selectedIndex = ContactsListbox.SelectedIndex; //индекс в списке, в нашем случае нужен по размеру
            if (selectedIndex != -1)
            {

                var selectedData = project.PhoneBook[selectedIndex]; //экземляр списка под выбранном индексом 
                project.PhoneBook.Remove(selectedData);
                ContactsListbox.Items.RemoveAt(selectedIndex);
                ProjectManager.SaveToFile(project);
            }

            else
            {
                MessageBox.Show("Choose the item below", "Choose item", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void ExitToolstripmenuitem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            e.Cancel = MessageBox.Show("Вы хотите закрыть программу?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes;

        }

        private void AboutToolstripmenuIiem_Click(object sender, EventArgs e)
        {
            AboutForm.AboutFormList.ShowForm();
        }

       private void FindTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SurnameTextboxMain_Leave(object sender, EventArgs e)
        {
            
        }
    }

}

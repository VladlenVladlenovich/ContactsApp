using NUnit.Framework.Legacy;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Contexts;

namespace ContactsApp.UnitTests
{
    public class ProjectTest
    {
        //Тест свойства ContactsList
        [Test(Description = "Позитивный тест геттера ContactsList")]
        public void TestContactsListGet_CorrectValue()
        {
            Project project = new Project();

            var expected = new List <Contact>();
            project.Contactslist = expected;
            var actual = project.Contactslist;
            ClassicAssert.AreEqual(expected, actual, "Геттер ContactsList возвращает неправильный список контактов");
        }

        [Test(Description = "Позитивный тест сеттера ContactsList")]
        public void TestContactsListSet_CorrectValue()
        {
            try
            {
                Project project = new Project();
                List<Contact> contactslist = new List<Contact> ();
    
            }
            catch (ArgumentException exception)
            {
              
            }
        }
    }
}

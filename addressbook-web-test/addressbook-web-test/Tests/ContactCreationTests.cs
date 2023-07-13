using addressbook_web_test;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {

        [Test]
        public void TheContactCreateTest()
        {
            appManager.Navigator.OpenHomePage();
            appManager.Auth.Login(new AccountData("admin", "secret"));
            appManager.Contacts.AddNewContact();
            appManager.Contacts.FillContactForm(new ContactData("Test", "Testov", "123456789"));
            appManager.Contacts.SubmitContactCreation();
        }
    }
}


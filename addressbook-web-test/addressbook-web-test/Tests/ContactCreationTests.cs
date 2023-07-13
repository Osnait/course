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
            appManager.Contacts
                .AddNewContact()
                .FillContactForm(new ContactData("Test", "Testov", "123456789"))
                .SubmitContactCreation();
        }
    }
}


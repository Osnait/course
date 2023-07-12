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
            navigationHelper.OpenHomePage();
            loginHelper.Login(new AccountData("admin", "secret"));
            contactHepler.AddNewContact();
            contactHepler.FillContactForm(new ContactData("Test", "Testov", "123456789"));
            contactHepler.SubmitContactCreation();
        }
    }
}


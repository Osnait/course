using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {

        [Test]
        public void ContactCreateTest()
        {
            ContactData contact = new ContactData("Test");
            contact.Lastname = "Testov";
            contact.Mobile = "123456789";

            appManager.Contacts.ContactCreate(contact);
        }
    }
}


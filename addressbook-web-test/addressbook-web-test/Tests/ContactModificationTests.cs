using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    internal class ContactModificationTests : TestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            ContactData newData = new ContactData("Petr");
            newData.Lastname = "Kekovich";
            newData.Mobile = "987654321";

            appManager.Contacts.Modify(1, newData);
        }
    }
}

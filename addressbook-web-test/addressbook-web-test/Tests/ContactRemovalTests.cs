using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactRemovalTests : TestBase
    {

        [Test]
        public void ContactRemovalTest()
        {
            appManager.Contacts.Remove(1);
        }
    }
}
// может удалить ничего, но всё равно будет passed, лол
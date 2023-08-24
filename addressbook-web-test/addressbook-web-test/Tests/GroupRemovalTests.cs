using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupRemovalTests : TestBase
    {

        [Test]
        public void GroupRemovalTest()
        {
            appManager.Groups.Remove(1);
        }
    }
}
// может удалить ничего, но всё равно будет passed, лол
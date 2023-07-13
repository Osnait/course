using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupRemovalTests : TestBase
    {

        [Test]
        public void TheGroupRemovalTestsTest()
        {
            appManager.Navigator.GoToGroupsPage();
            appManager.Groups
                .SelectGroup(1)
                .RemoveGroup()
                .ReturnToGroupsPage();
        }
    }
}
// может удалить ничего, но всё равно будет passed, лол
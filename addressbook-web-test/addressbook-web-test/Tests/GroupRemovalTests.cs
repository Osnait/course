using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupRemovalTests : TestBase
    {

        [Test]
        public void TheGroupRemovalTestsTest()
        {
            appManager.Navigator.OpenHomePage();
            appManager.Auth.Login(new AccountData("admin", "secret"));
            appManager.Navigator.GoToGroupsPage();
            appManager.Groups.SelectGroup(1);
            appManager.Groups.RemoveGroup();
            appManager.Groups.ReturnToGroupsPage();
        }
    }
}
// может удалить ничего, но всё равно будет passed, лол
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {

        [Test]
        public void GroupCreationTest()
        {
            appManager.Navigator.OpenHomePage();
            appManager.Auth.Login(new AccountData("admin", "secret"));
            appManager.Navigator.GoToGroupsPage();
            appManager.Groups.InitNewGroupCreation();
            appManager.Groups.FillGroupForm(new GroupData("Test1", "Test2", "Test3"));
            appManager.Groups.SubmitGroupCreation();
            appManager.Groups.ReturnToGroupsPage();
        }
    }
}


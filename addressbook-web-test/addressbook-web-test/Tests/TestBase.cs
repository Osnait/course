using NUnit.Framework;


namespace WebAddressbookTests
{
    public class TestBase
    {

        protected AppManager appManager;

        [SetUp]
        public void SetupTest()
        {
            appManager = new AppManager();
            appManager.Navigator.OpenHomePage();
            appManager.Auth.Login(new AccountData("admin", "secret"));
        }

        [TearDown]
        public void TeardownTest()
        {
            appManager.Stop();
        }
    }
}

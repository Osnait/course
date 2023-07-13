using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {

        [Test]
        public void GroupCreationTest()
        {
            GroupData group = new GroupData("Test1");
            group.Header = "Test2";
            group.Footer = "Test3";

            appManager.Groups.CreateGroup(group);
        }

        [Test]
        public void EmptyGroupCreationTest()
        {
            GroupData group = new GroupData("");
            group.Header = "";
            group.Footer = "";

            appManager.Groups.CreateGroup(group);
        }
    }
}


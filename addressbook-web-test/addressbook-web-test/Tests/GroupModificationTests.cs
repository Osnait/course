using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    internal class GroupModificationTests : TestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            GroupData newData = new GroupData("Lol");
            newData.Header = "Kek";
            newData.Footer = "Chebureck";

            appManager.Groups.Modify(1, newData);
        }
    }
}

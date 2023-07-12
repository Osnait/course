﻿using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {

        [Test]
        public void GroupCreationTest()
        {
            navigationHelper.OpenHomePage();
            loginHelper.Login(new AccountData("admin", "secret"));
            navigationHelper.GoToGroupsPage();
            groupHelper.InitNewGroupCreation();
            groupHelper.FillGroupForm(new GroupData("Test1", "Test2", "Test3"));
            groupHelper.SubmitGroupCreation();
            groupHelper.ReturnToGroupsPage();
        }
    }
}


using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week18AdvanceTaskMarsPart1NUnitPOMJson.Models;
using Week18AdvanceTaskMarsPart1NUnitPOMJson.Utilities;

namespace Week18AdvanceTaskMarsPart1NUnitPOMJson.Tests
{
    [TestFixture]
    public class _006NotificationTest:Hooks
    {
        private List<ModelLogin> _ModelLogin;
        private List<_006ModelNotification> _ModelNotification;
        private List<_005ModelSearchSkill> _ModelSearchSkill;

        [SetUp]
        public new void Initialize()
        {
            string jsonFilePathLogin = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestData", "TestDataLogin.json");
            _ModelLogin = JsonReader.ReadLoginData(jsonFilePathLogin);
            string jsonFilePathNotification = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestData", "006TestDataNotification.json");
            _ModelNotification = JsonReader.ReadNotificationData(jsonFilePathNotification);
            string jsonFilePathSearchSkill = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestData", "005TestDataSearchSkill.json");
            _ModelSearchSkill = JsonReader.ReadSearchSkillData(jsonFilePathSearchSkill);
        }


        [Test, Category("Notification")]
        // TS_601_TC_001 Verify that show less button on notification page is show notification correctly
        public void TS_601_TC_001NotificationShowLessButton()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_ModelLogin.Count > 0 && _ModelNotification.Count > 0)
            {
                var loginModel = _ModelLogin.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                _006ModelNotification NotificationModel = _ModelNotification.FirstOrDefault(edu => edu.TestCaseId == "TS_601_TC_001");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(NotificationModel.username, NotificationModel.password);
                LoginPageObj.ClickOnLogin();
                StepNotificationObj.StepUserClickOnNotificationOnTheTopRightOfThePage();
                StepNotificationObj.StepShowNotificationPage();
                StepNotificationObj.StepCLickSeeMoreNotification();
                StepNotificationObj.StepClickShowLessNotification();
                StepNotificationObj.StepResultShowLessNotification();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }

        [Test, Category("Notification")]
        // TS_601_TC_002 Verify that load more button on notification page is show notification correctly
        public void TS_601_TC_002NotificationLoadMoreButton()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_ModelLogin.Count > 0 && _ModelNotification.Count > 0)
            {
                var loginModel = _ModelLogin.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                _006ModelNotification NotificationModel = _ModelNotification.FirstOrDefault(edu => edu.TestCaseId == "TS_601_TC_002");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(NotificationModel.username, NotificationModel.password);
                LoginPageObj.ClickOnLogin();
                StepNotificationObj.StepUserClickOnNotificationOnTheTopRightOfThePage();
                StepNotificationObj.StepShowNotificationPage();
                StepNotificationObj.StepCLickSeeMoreNotification();
                StepNotificationObj.StepResultLoadMoreNotification();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }

        [Test, Category("Notification")]
        // TS_601_TC_003 Verify 'mark as read' link on notification message
        public void TS_601_TC_003NotificationMarkAsRead()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_ModelLogin.Count > 0 && _ModelNotification.Count > 0)
            {
                var loginModel = _ModelLogin.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                _006ModelNotification NotificationModel = _ModelNotification.FirstOrDefault(edu => edu.TestCaseId == "TS_601_TC_003");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(NotificationModel.username, NotificationModel.password);
                LoginPageObj.ClickOnLogin();
                StepNotificationObj.StepUserClickOnNotificationOnTheTopRightOfThePage();
                StepNotificationObj.StepUserClickSelectAllLink();
                StepNotificationObj.StepShowNotificationPage();
                StepNotificationObj.StepSelectAMessage();
                StepNotificationObj.StepSelectMarkAsRead();
                StepNotificationObj.StepNotificationUpdated();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }

        [Test, Category("Notification")]
        // TS_601_TC_004 Verify 'select one' link on notification message
        public void TS_601_TC_004NotificationSelectOne()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_ModelLogin.Count > 0 && _ModelNotification.Count > 0)
            {
                var loginModel = _ModelLogin.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                _006ModelNotification NotificationModel = _ModelNotification.FirstOrDefault(edu => edu.TestCaseId == "TS_601_TC_004");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(NotificationModel.username, NotificationModel.password);
                LoginPageObj.ClickOnLogin();
                StepNotificationObj.StepUserClickOnNotificationOnTheTopRightOfThePage();
                StepNotificationObj.StepUserClickSelectAllLink();
                StepNotificationObj.StepShowNotificationPage();
                StepNotificationObj.StepSelectAMessage();
                StepNotificationObj.StepPendingMenuPopUpShouldBeDisplay();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }

        [Test, Category("Notification")]
        // TS_601_TC_005 Verify user unselect 'select one' link on notification message
        public void TS_601_TC_005NotificationUnSelectOne()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_ModelLogin.Count > 0 && _ModelNotification.Count > 0)
            {
                var loginModel = _ModelLogin.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                _006ModelNotification NotificationModel = _ModelNotification.FirstOrDefault(edu => edu.TestCaseId == "TS_601_TC_005");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(NotificationModel.username, NotificationModel.password);
                LoginPageObj.ClickOnLogin();
                StepNotificationObj.StepUserClickOnNotificationOnTheTopRightOfThePage();
                StepNotificationObj.StepUserClickSelectAllLink();
                StepNotificationObj.StepShowNotificationPage();
                StepNotificationObj.StepSelectAMessage();
                StepNotificationObj.StepUnselectAMessage();
                StepNotificationObj.StepPendingMenuPopUpShouldBeGone();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }

        [Test, Category("Notification")]
        // TS_601_TC_006 Verify delete a message on notification page
        public void TS_601_TC_006NotificationDeletedAMessage()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_ModelLogin.Count > 0 && _ModelNotification.Count > 0)
            {
                var loginModel = _ModelLogin.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                _006ModelNotification NotificationModel = _ModelNotification.FirstOrDefault(edu => edu.TestCaseId == "TS_601_TC_006");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(NotificationModel.username, NotificationModel.password);
                LoginPageObj.ClickOnLogin();
                StepNotificationObj.StepUserClickOnNotificationOnTheTopRightOfThePage();
                StepNotificationObj.StepUserClickSelectAllLink();
                StepNotificationObj.StepShowNotificationPage();
                StepNotificationObj.StepSelectAMessage();
                StepNotificationObj.StepClickDeleteAMessage();
                StepNotificationObj.StepNotificationUpdated();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }

        [Test, Category("Notification")]
        // Create Test Data for TC006
        public void TS_601_TC_0061PrepForDelete()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_ModelLogin.Count > 0 && _ModelNotification.Count > 0)
            {
                var loginModel = _ModelLogin.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                _006ModelNotification NotificationModel = _ModelNotification.FirstOrDefault(edu => edu.TestCaseId == "TS_601_TC_0061");
                _005ModelSearchSkill SearchSkillModel = _ModelSearchSkill.FirstOrDefault(edu => edu.TestCaseId == "TS_601_TC_0061");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(NotificationModel.username2, NotificationModel.password);
                LoginPageObj.ClickOnLogin();
                StepSearchSkillObj.StepClickOnLink(SearchSkillModel.Skill);
                //StepSearchSkillObj.StepDisplaySkillOnTheResultPage();
                //StepSearchSkillObj.StepSearchSkillFilter(SearchSkillModel.buttonName, SearchSkillModel.SkillSearch);
                StepNotificationObj.StepSearchForAListingAndSendRequest(NotificationModel.title, NotificationModel.MessageRequestText);
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }



    }
}

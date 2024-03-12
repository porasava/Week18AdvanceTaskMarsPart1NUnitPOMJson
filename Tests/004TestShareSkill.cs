using AventStack.ExtentReports.Gherkin.Model;
using Microsoft.CodeAnalysis.Text;
using Microsoft.VisualBasic;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Week18AdvanceTaskMarsPart1NUnitPOMJson.Models;
using Week18AdvanceTaskMarsPart1NUnitPOMJson.Utilities;
using static System.Net.Mime.MediaTypeNames;

namespace Week18AdvanceTaskMarsPart1NUnitPOMJson.Tests
{
    [TestFixture]
    public class _004ShareSkillTest:Hooks
    {
        private List<ModelLogin> _ModelLogin;
        private List<_004ModelShareSkill> _ModelShareSkill;

        [SetUp]
        public new void Initialize()
        {
            string jsonFilePathLogin = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestData", "TestDataLogin.json");
            _ModelLogin = JsonReader.ReadLoginData(jsonFilePathLogin);
            string jsonFilePathShareSkill = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestData", "004TestDataShareSkill.json");
            _ModelShareSkill = JsonReader.ReadShareSkillData(jsonFilePathShareSkill);

        }


        [Test, Category("ShareSkill")]
        // TS_401_TC_001 Verify the user share new skill and put blank on Title text box
        public void TS_401_TC_001ShareNewSkillWithblankOnTitleTextBox()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_ModelLogin.Count > 0 && _ModelShareSkill.Count > 0)
            {
                var loginModel = _ModelLogin.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                _004ModelShareSkill ShareSkillModel = _ModelShareSkill.FirstOrDefault(edu => edu.TestCaseId == "TS_401_TC_001");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepShareSkillObj.StepCreateAListing(ShareSkillModel.Title, ShareSkillModel.Description, ShareSkillModel.Category, ShareSkillModel.Subcategory, ShareSkillModel.Tags, ShareSkillModel.SkillExchange);
                StepShareSkillObj.StepErrorTitleIsRequired();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }

        [Test, Category("ShareSkill")]
        // TS_401_TC_002 Verify the user share new skill and put blank on Description text box
        public void TS_401_TC_002ShareNewSkillWithBlankOnDescriptionTextBox()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_ModelLogin.Count > 0 && _ModelShareSkill.Count > 0)
            {
                var loginModel = _ModelLogin.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                _004ModelShareSkill ShareSkillModel = _ModelShareSkill.FirstOrDefault(edu => edu.TestCaseId == "TS_401_TC_002");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepShareSkillObj.StepCreateAListing(ShareSkillModel.Title, ShareSkillModel.Description, ShareSkillModel.Category, ShareSkillModel.Subcategory, ShareSkillModel.Tags, ShareSkillModel.SkillExchange);
                StepShareSkillObj.StepErrorDescriptionIsRequired();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }

        [Test, Category("ShareSkill")]
        // TS_401_TC_003 Verify the user share new skill and put blank on Category text box
        public void TS_401_TC_003ShareNewSkillWithBlankOnCategoryTextBox()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_ModelLogin.Count > 0 && _ModelShareSkill.Count > 0)
            {
                var loginModel = _ModelLogin.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                _004ModelShareSkill ShareSkillModel = _ModelShareSkill.FirstOrDefault(edu => edu.TestCaseId == "TS_401_TC_003");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepShareSkillObj.StepCreateAListing(ShareSkillModel.Title, ShareSkillModel.Description, ShareSkillModel.Category, ShareSkillModel.Subcategory, ShareSkillModel.Tags, ShareSkillModel.SkillExchange);
                StepShareSkillObj.StepErrorCategoryIsRequired();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }


        [Test, Category("ShareSkill")]
        // TS_401_TC_004 Verify the user share new skill and put blank on Tags text box
        public void TS_401_TC_004ShareNewSkillWithBlankOnTagsTextBox()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_ModelLogin.Count > 0 && _ModelShareSkill.Count > 0)
            {
                var loginModel = _ModelLogin.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                _004ModelShareSkill ShareSkillModel = _ModelShareSkill.FirstOrDefault(edu => edu.TestCaseId == "TS_401_TC_004");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepShareSkillObj.StepCreateAListing(ShareSkillModel.Title, ShareSkillModel.Description, ShareSkillModel.Category, ShareSkillModel.Subcategory, ShareSkillModel.Tags, ShareSkillModel.SkillExchange);
                StepShareSkillObj.StepErrorTagsAreRequired();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }

        [Test, Category("ShareSkill")]
        // TS_401_TC_005 Verify the user share new skill and put blank on Skill-Exchange text box
        public void TS_401_TC_005ShareNewSkillWithBlankOnSkillExchangeTextBox()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_ModelLogin.Count > 0 && _ModelShareSkill.Count > 0)
            {
                var loginModel = _ModelLogin.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                _004ModelShareSkill ShareSkillModel = _ModelShareSkill.FirstOrDefault(edu => edu.TestCaseId == "TS_401_TC_005");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepShareSkillObj.StepCreateAListing(ShareSkillModel.Title, ShareSkillModel.Description, ShareSkillModel.Category, ShareSkillModel.Subcategory, ShareSkillModel.Tags, ShareSkillModel.SkillExchange);
                StepShareSkillObj.StepErrorSkill_ExchangeAreRequired();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }

        [Test, Category("ShareSkill")]
        // TS_401_TC_006 Verify the user share new skill with correct mandatory
        public void TS_401_TC_006ShareNewSkillWithCorrectMandatory()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_ModelLogin.Count > 0 && _ModelShareSkill.Count > 0)
            {
                var loginModel = _ModelLogin.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                _004ModelShareSkill ShareSkillModel = _ModelShareSkill.FirstOrDefault(edu => edu.TestCaseId == "TS_401_TC_006");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepShareSkillObj.StepCreateAListing(ShareSkillModel.Title, ShareSkillModel.Description, ShareSkillModel.Category, ShareSkillModel.Subcategory, ShareSkillModel.Tags, ShareSkillModel.SkillExchange);
                StepShareSkillObj.StepSkillShouldBeshareSuccessfully(ShareSkillModel.TitleListing);
                StepShareSkillObj.StepDeleteListing(); 
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }

        [Test, Category("ShareSkill")]
        // TS_402_TC_001 Verify the user update share skill and put blank on Title text box
        public void TS_402_TC_001UpdateShareSkillWithBlankOnTitleTextBox()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_ModelLogin.Count > 0 && _ModelShareSkill.Count > 0)
            {
                var loginModel = _ModelLogin.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                _004ModelShareSkill ShareSkillModel = _ModelShareSkill.FirstOrDefault(edu => edu.TestCaseId == "TS_402_TC_001");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepShareSkillObj.StepCreateAListing(ShareSkillModel.Title, ShareSkillModel.Description, ShareSkillModel.Category, ShareSkillModel.Subcategory, ShareSkillModel.Tags, ShareSkillModel.SkillExchange);
                StepShareSkillObj.StepSkillShouldBeshareSuccessfully(ShareSkillModel.TitleListing);
                StepShareSkillObj.StepEditListing(ShareSkillModel.TitleEdit, ShareSkillModel.Description, ShareSkillModel.Category, ShareSkillModel.Subcategory, ShareSkillModel.Tags, ShareSkillModel.SkillExchange);
                StepShareSkillObj.StepNavigateToManageListingPage();
                StepShareSkillObj.StepDeleteListing();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }

    }
}

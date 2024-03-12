using AventStack.ExtentReports.Gherkin.Model;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using Week18AdvanceTaskMarsPart1NUnitPOMJson.Models;
using Week18AdvanceTaskMarsPart1NUnitPOMJson.Utilities;

namespace Week18AdvanceTaskMarsPart1NUnitPOMJson.Tests
{
    [TestFixture]
    public class _003SkillTest : Hooks
    {
        private List<ModelLogin> _ModelLogin;
        private List<_003ModelSkill> _ModelSkill;

        [SetUp]
        public new void Initialize()
        {
            string jsonFilePathLogin = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestData", "TestDataLogin.json");
            _ModelLogin = JsonReader.ReadLoginData(jsonFilePathLogin);
            string jsonFilePathSkill = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestData", "003TestDataSkill.json");
            _ModelSkill = JsonReader.ReadSkillData(jsonFilePathSkill);

        }


        [Test, Category("Skill")]
        // TS_301_TC_001 Verify that the user add a skill on the account profile page with correct mandatory
        public void TS_301_TC_001AddASkillWithCorrectMandatory()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_ModelLogin.Count > 0 && _ModelSkill.Count > 0)
            {
                var loginModel = _ModelLogin.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                _003ModelSkill SkillModel = _ModelSkill.FirstOrDefault(edu => edu.TestCaseId == "TS_301_TC_001");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();                
                StepSkillObj.StepNavigateToAccountProfileSkill();
                StepSkillObj.StepCheckExistingSkill();
                StepSkillObj.StepAddANewSkill(SkillModel.SkillName, SkillModel.SkillLevel);
                StepSkillObj.StepShowANewSkill();
                StepSkillObj.StepDeleteASkill(SkillModel.SkillName);
                StepSkillObj.StepSkillShouldBeRemoveSuccessfully();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }


        [Test, Category("Skill")]
        // TS_301_TC_002 Verify that the user add a skill on the account profile page with incorrect mandatory
        public void TS_301_TC_002AddASkillWithIncorrectMandatory()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_ModelLogin.Count > 0 && _ModelSkill.Count > 0)
            {
                var loginModel = _ModelLogin.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                _003ModelSkill SkillModel = _ModelSkill.FirstOrDefault(edu => edu.TestCaseId == "TS_301_TC_002");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepSkillObj.StepNavigateToAccountProfileSkill();
                StepSkillObj.StepCheckExistingSkill();
                StepSkillObj.StepAddANewSkill(SkillModel.SkillName, SkillModel.SkillLevel);
                StepSkillObj.StepErrorPleaseEnterSkillAndExperienceLevel();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }

        [Test, Category("Skill")]
        // TS_301_TC_003 Verify that the user add a new skill on the account profile page with space on Add skill field
        public void TS_301_TC_003addanewskillwithspaceonAddskillfField()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_ModelLogin.Count > 0 && _ModelSkill.Count > 0)
            {
                var loginModel = _ModelLogin.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                _003ModelSkill SkillModel = _ModelSkill.FirstOrDefault(edu => edu.TestCaseId == "TS_301_TC_003");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepSkillObj.StepNavigateToAccountProfileSkill();
                StepSkillObj.StepCheckExistingSkill();
                StepSkillObj.StepAddANewSkill(SkillModel.SkillName, SkillModel.SkillLevel);
                StepSkillObj.StepShowANewSkill();
                StepSkillObj.StepDeleteASkill(SkillModel.SkillName);
                StepSkillObj.StepSkillShouldBeRemoveSuccessfully();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }


        [Test, Category("Skill")]
        // TS_301_TC_004 Verify that the user add a new skill on the account profile page with special character on Add skill field
        public void TS_301_TC_004AddANewSkillWithSpecialCharacter()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_ModelLogin.Count > 0 && _ModelSkill.Count > 0)
            {
                var loginModel = _ModelLogin.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                _003ModelSkill SkillModel = _ModelSkill.FirstOrDefault(edu => edu.TestCaseId == "TS_301_TC_004");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepSkillObj.StepNavigateToAccountProfileSkill();
                StepSkillObj.StepCheckExistingSkill();
                StepSkillObj.StepAddANewSkill(SkillModel.SkillName, SkillModel.SkillLevel);
                StepSkillObj.StepShowANewSkill();
                StepSkillObj.StepDeleteASkill(SkillModel.SkillName);
                StepSkillObj.StepSkillShouldBeRemoveSuccessfully();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }

        [Test, Category("Skill")]
        // TS_301_TC_005 Verify that the user add a new skill on the account profile page with over 50 characters on Add skill field
        public void TS_301_TC_005AddANewSkillWithOver50characters()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_ModelLogin.Count > 0 && _ModelSkill.Count > 0)
            {
                var loginModel = _ModelLogin.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                _003ModelSkill SkillModel = _ModelSkill.FirstOrDefault(edu => edu.TestCaseId == "TS_301_TC_005");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepSkillObj.StepNavigateToAccountProfileSkill();
                StepSkillObj.StepCheckExistingSkill();
                StepSkillObj.StepAddANewSkill(SkillModel.SkillName, SkillModel.SkillLevel);
                StepSkillObj.StepShowANewSkill();
                StepSkillObj.StepDeleteASkill(SkillModel.SkillName);
                StepSkillObj.StepSkillShouldBeRemoveSuccessfully();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }

        [Test, Category("Skill")]
        // TS_301_TC_006 Verify that the user add a new skill on the account profile page with duplicate on Add skill field
        public void TS_301_TC_006AddANewSkillWithDuplicate()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_ModelLogin.Count > 0 && _ModelSkill.Count > 0)
            {
                var loginModel = _ModelLogin.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                _003ModelSkill SkillModel = _ModelSkill.FirstOrDefault(edu => edu.TestCaseId == "TS_301_TC_006");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepSkillObj.StepNavigateToAccountProfileSkill();
                StepSkillObj.StepCheckExistingSkill();
                StepSkillObj.StepAddANewSkill(SkillModel.SkillName, SkillModel.SkillLevel);
                StepSkillObj.StepShowANewSkill();
                StepSkillObj.StepAddANewSkill(SkillModel.SkillName, SkillModel.SkillLevel);
                StepSkillObj.StepErrorThisskillIsAlreadyExistInYourSkillList();
                StepSkillObj.StepDeleteASkill(SkillModel.SkillName);
                StepSkillObj.StepSkillShouldBeRemoveSuccessfully();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }

        [Test, Category("Skill")]
        // TS_301_TC_007 Verify that the user add a new skill on the account profile page with a paragraph on Add skill field
        public void TS_301_TC_007AddANewSkillWithAParagraph()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_ModelLogin.Count > 0 && _ModelSkill.Count > 0)
            {
                var loginModel = _ModelLogin.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                _003ModelSkill SkillModel = _ModelSkill.FirstOrDefault(edu => edu.TestCaseId == "TS_301_TC_007");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepSkillObj.StepNavigateToAccountProfileSkill();
                StepSkillObj.StepCheckExistingSkill();
                StepSkillObj.StepAddANewSkill(SkillModel.SkillName, SkillModel.SkillLevel);
                StepSkillObj.StepShowANewSkill();
                StepSkillObj.StepDeleteASkill(SkillModel.SkillName);
                StepSkillObj.StepSkillShouldBeRemoveSuccessfully();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }

        [Test, Category("Skill")]
        // TS_302_TC_001 Verify that the user edit a skill on the account profile page
        public void TS_302_TC_001EditASkill()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_ModelLogin.Count > 0 && _ModelSkill.Count > 0)
            {
                var loginModel = _ModelLogin.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                _003ModelSkill SkillModel = _ModelSkill.FirstOrDefault(edu => edu.TestCaseId == "TS_302_TC_001");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepSkillObj.StepNavigateToAccountProfileSkill();
                StepSkillObj.StepCheckExistingSkill();
                StepSkillObj.StepAddANewSkill(SkillModel.SkillName, SkillModel.SkillLevel);
                StepSkillObj.StepShowANewSkill();
                StepSkillObj.StepEditASkill(SkillModel.SkillEdit);
                StepSkillObj.StepDeleteASkill(SkillModel.SkillEdit);
                StepSkillObj.StepSkillShouldBeRemoveSuccessfully();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }

        [Test, Category("Skill")]
        // TS_303_TC_001 Verify that the user delete a skill on the account profile page
        public void TS_303_TC_001DeleteASkill()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_ModelLogin.Count > 0 && _ModelSkill.Count > 0)
            {
                var loginModel = _ModelLogin.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                _003ModelSkill SkillModel = _ModelSkill.FirstOrDefault(edu => edu.TestCaseId == "TS_303_TC_001");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepSkillObj.StepNavigateToAccountProfileSkill();
                StepSkillObj.StepCheckExistingSkill();
                StepSkillObj.StepAddANewSkill(SkillModel.SkillName, SkillModel.SkillLevel);
                StepSkillObj.StepShowANewSkill();
                StepSkillObj.StepEditASkill(SkillModel.SkillEdit);
                StepSkillObj.StepDeleteASkill(SkillModel.SkillEdit);
                StepSkillObj.StepSkillShouldBeRemoveSuccessfully();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }

    }
}
